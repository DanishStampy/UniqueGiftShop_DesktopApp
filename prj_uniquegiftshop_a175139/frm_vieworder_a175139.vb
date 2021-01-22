Public Class frm_vieworder_a175139

    Dim totalPrice As Integer
    Private Sub frm_vieworder_a175139_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A175139 ORDER BY FLD_ORDER_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_order_ID.DataSource = mydatatable
        cmb_order_ID.DisplayMember = "FLD_ORDER_ID"

        refresh_text(cmb_order_ID.Text)

    End Sub
    Private Sub refresh_text(orderId As String)

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A175139 WHERE FLD_ORDER_ID='" & orderId & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        If mydatatable.Rows.Count > 0 Then

            tb_customerID.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ID")
            tb_staffID.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
            lbl_order_date.Text = mydatatable.Rows(0).Item("FLD_ORDER_DATE")

        End If
    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT TBL_ORDER_DETAILS_A175139.FLD_PRODUCT_ID AS Product_ID, TBL_PRODUCT_A175139.FLD_PRODUCT_NAME AS Product_Name, TBL_ORDER_DETAILS_A175139.FLD_ORDER_QUANTITY AS Quantity,
        TBL_PRODUCT_A175139.FLD_PRICE AS Price, TBL_ORDER_DETAILS_A175139.FLD_ORDER_QUANTITY * TBL_PRODUCT_A175139.FLD_PRICE AS Sub_Total_Price
        FROM TBL_PRODUCT_A175139 INNER JOIN TBL_ORDER_DETAILS_A175139 ON TBL_PRODUCT_A175139.FLD_PRODUCT_ID = TBL_ORDER_DETAILS_A175139.FLD_PRODUCT_ID
        WHERE FLD_ORDER_ID = '" & cmb_order_ID.Text & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order.DataSource = mydatatable

    End Sub

    Private Sub cmb_order_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_order_ID.SelectedIndexChanged

        refresh_text(cmb_order_ID.Text)
        refresh_grid()
        lbl_orderID.Text = cmb_order_ID.Text
        refresh_price()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a175139.Show()
        Me.Close()

    End Sub
    Private Sub refresh_price()

        If grd_order.RowCount > 0 Then
            totalPrice = 0

            For index As Integer = 0 To grd_order.RowCount - 1
                totalPrice += Convert.ToDouble(grd_order.Rows(index).Cells(4).Value)
            Next

            lbl_totalPrice.Text = "RM " & totalPrice
        ElseIf grd_order.RowCount = 0 Then

            lbl_totalPrice.Text = "RM 0"

        End If

    End Sub


End Class