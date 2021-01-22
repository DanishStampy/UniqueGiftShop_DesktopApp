Public Class frm_makeorder_a175139

    Dim defaultpicture As String = Application.StartupPath & "\pictures\defaultphoto.jpg"
    Dim totalPrice_cart As Integer
    Dim qty As Integer

    Private Sub frm_makeorder_a175139_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCT_A175139 ORDER BY FLD_PRODUCT_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        cmb_product_id.DataSource = mydatatable
        cmb_product_id.DisplayMember = "FLD_PRODUCT_ID"

        refresh_customer()
        refresh_staff()
        lbl_orderID.Text = generate_idorder()
        lbl_date.Text = Date.Now.ToShortDateString
        refresh_text(cmb_product_id.Text)

        btn_add_cart.Enabled = False
        btn_cancel.Enabled = False
        btn_confirmation.Enabled = False
        btn_invoice.Enabled = False
        btn_cancel_order.Enabled = False

    End Sub
    Private Function generate_idorder() As String

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDER_A175139").Rows(0).Item("LASTID")
        MsgBox("This is the latest order ID: " + lastid)
        Dim new_orderID As String = "G" & Mid(lastid, 2) + 1
        Return new_orderID

    End Function
    Private Sub refresh_customer()

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A175139 ORDER BY FLD_CUSTOMER_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_customer.DataSource = mydatatable
        cmb_customer.DisplayMember = "FLD_CUSTOMER_ID"

        refresh_name(cmb_customer.Text)

    End Sub

    Private Sub refresh_name(ID As String)

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A175139 WHERE FLD_CUSTOMER_ID='" & ID & "'"
        Dim datatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(datatable)

        If datatable.Rows.Count > 0 Then
            lbl_customer_name.Text = datatable.Rows(0).Item("FLD_CUSTOMER_NAME")
        End If

    End Sub
    Private Sub refresh_staff()

        Dim mysql As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A175139 ORDER BY FLD_STAFF_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_staff.DataSource = mydatatable
        cmb_staff.DisplayMember = "FLD_STAFF_ID"

    End Sub

    Private Sub refresh_text(ID As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A175139 WHERE FLD_PRODUCT_ID='" & ID & "'"
        Dim datatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(datatable)

        If datatable.Rows.Count > 0 Then
            cmb_product_id.Text = datatable.Rows(0).Item("FLD_PRODUCT_ID")
            lbl_name_product.Text = datatable.Rows(0).Item("FLD_PRODUCT_NAME")
            qty = datatable.Rows(0).Item("FLD_PRODUCT_QUANTITY")
            lbl_material_product.Text = datatable.Rows(0).Item("FLD_MATERIAL")
            lbl_type_product.Text = datatable.Rows(0).Item("FLD_TYPE")
            lbl_price_product.Text = datatable.Rows(0).Item("FLD_PRICE")
            lbl_colour_product.Text = datatable.Rows(0).Item("FLD_COLOUR")

            If qty = 0 Then
                lbl_stock_product.Text = "Out of Stock"
                NumericUpDown.Enabled = False
                btn_add_cart.Enabled = False
            Else
                lbl_stock_product.Text = qty.ToString
                NumericUpDown.Enabled = True
                btn_add_cart.Enabled = True
            End If

            Try
                pic_product.BackgroundImage = Image.FromFile("pictures/" & cmb_product_id.Text & ".jpg")
            Catch ex As Exception
                pic_product.BackgroundImage = Image.FromFile(defaultpicture)
            End Try

        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a175139.Show()
        Me.Close()

    End Sub

    Private Sub btn_make_order_Click(sender As Object, e As EventArgs) Handles btn_make_order.Click

        btn_make_order.Enabled = False
        btn_add_cart.Enabled = True
        btn_cancel_order.Enabled = True

        Dim mysql As String = "INSERT INTO TBL_ORDER_A175139 VALUES ('" & lbl_orderID.Text & "', '" & cmb_staff.Text & "', '" & cmb_customer.Text & "', '" & lbl_date.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
            Beep()
            MsgBox("You can make new order now!")

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try
    End Sub
    Private Sub NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown.ValueChanged

        Dim count As Integer
        Dim price As Integer
        NumericUpDown.Maximum = qty
        count = NumericUpDown.Value
        price = lbl_price_product.Text()
        lbl_total_price.Text = price * count

    End Sub

    Private Sub btn_add_cart_Click(sender As Object, e As EventArgs) Handles btn_add_cart.Click

        btn_confirmation.Enabled = True

        If NumericUpDown.Value = 0 Then
            MsgBox("This product is out of stock !")

        Else
            grd_orderList.Rows.Add(New String() {cmb_product_id.Text, lbl_name_product.Text, NumericUpDown.Value, lbl_total_price.Text})
            lbl_total_price.Text = "-"
            NumericUpDown.Value = 0
            refresh_price()
        End If


    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Dim delete_order = MsgBox("Confirm to delete this item from list?", MsgBoxStyle.YesNo)

        If delete_order = MsgBoxResult.Yes Then
            grd_orderList.Rows.Remove(grd_orderList.CurrentRow)
            refresh_price()
            btn_cancel.Enabled = False

        Else
            refresh_price()
            btn_cancel.Enabled = False
        End If
    End Sub
    Private Sub refresh_price()

        If grd_orderList.RowCount > 0 Then
            totalPrice_cart = 0

            For index As Integer = 0 To grd_orderList.RowCount - 1
                totalPrice_cart += Convert.ToDouble(grd_orderList.Rows(index).Cells(3).Value)
            Next

            lbl_total_cart_price.Text = "RM " & totalPrice_cart
        ElseIf grd_orderList.RowCount = 0 Then

            lbl_total_cart_price.Text = "RM 0"

        End If

    End Sub

    Private Sub btn_confirmation_Click(sender As Object, e As EventArgs) Handles btn_confirmation.Click

        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction

        Try
            For i As Integer = 0 To grd_orderList.RowCount - 1
                Dim productid As String = grd_orderList(0, i).Value
                Dim quantity As Integer = grd_orderList(2, i).Value

                Dim mysql As String = "INSERT INTO TBL_ORDER_DETAILS_A175139 VALUES ('" & lbl_orderID.Text & "', '" & productid & "', '" & quantity & "')"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)
                mywriter.ExecuteNonQuery()

            Next
            mytransaction.Commit()
            myconnection2.Close()
            Beep()

            For i As Integer = 0 To grd_orderList.RowCount - 1
                Dim productid As String = grd_orderList(0, i).Value
                Dim quantity As Integer = grd_orderList(2, i).Value
                run_sql_command("UPDATE TBL_PRODUCT_A175139 SET FLD_PRODUCT_QUANTITY=(FLD_PRODUCT_QUANTITY - '" & quantity & "') WHERE FLD_PRODUCT_ID='" & productid & "'")

            Next

            MsgBox("Transaction successful!")
            grd_orderList.Rows.Clear()

        Catch ex As Exception
            Beep()
            MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()

        End Try

        lbl_orderID.Text = generate_idorder()
        refresh_price()
        btn_make_order.Enabled = True
        btn_add_cart.Enabled = False
        btn_cancel_order.Enabled = False
        btn_cancel.Enabled = False
        btn_confirmation.Enabled = False
        btn_invoice.Enabled = True


    End Sub

    Private Sub cmb_product_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_product_id.SelectedIndexChanged
        refresh_text(cmb_product_id.Text)
    End Sub

    Private Sub cmb_customer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_customer.SelectedIndexChanged
        refresh_name(cmb_customer.Text)
    End Sub

    Private Sub grd_orderList_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grd_orderList.RowHeaderMouseClick
        btn_cancel.Enabled = True
    End Sub

    Private Sub btn_cancel_order_Click(sender As Object, e As EventArgs) Handles btn_cancel_order.Click

        Dim cancel_order = MsgBox("Confirm to cancel the order?", MsgBoxStyle.YesNo)
        If cancel_order = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_ORDER_A175139 WHERE FLD_ORDER_ID='" & lbl_orderID.Text & "'")
            refresh_price()

            lbl_orderID.Text = generate_idorder()
            btn_cancel_order.Enabled = False
            btn_add_cart.Enabled = False
            btn_make_order.Enabled = True

        End If
    End Sub

    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        frm_vieworder_a175139.Show()
        Me.Close()

    End Sub

End Class