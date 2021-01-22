Public Class frm_catalog_a175139

    Dim defaultpicture As String = Application.StartupPath & "\pictures\defaultphoto.jpg"
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a175139.Show()
        Me.Close()

    End Sub

    Private Sub frm_catalog_a175139_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT DISTINCT FLD_TYPE FROM TBL_PRODUCT_A175139"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        cmb_type.DataSource = mydatatable
        cmb_type.DisplayMember = "FLD_TYPE"

        refresh_list(cmb_type.Text)

    End Sub

    Private Sub refresh_list(Type As String)

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCT_A175139 WHERE FLD_TYPE='" & Type & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lst_productID.DataSource = mydatatable
        lst_productID.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_productID.Text)

    End Sub

    Private Sub refresh_text(ID As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A175139 WHERE FLD_PRODUCT_ID='" & ID & "'"
        Dim datatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(datatable)

        If datatable.Rows.Count > 0 Then
            lbl_id.Text = datatable.Rows(0).Item("FLD_PRODUCT_ID")
            txt_product_name.Text = datatable.Rows(0).Item("FLD_PRODUCT_NAME")
            txt_quantity.Text = datatable.Rows(0).Item("FLD_PRODUCT_QUANTITY")
            txt_material.Text = datatable.Rows(0).Item("FLD_MATERIAL")
            lbl_type.Text = datatable.Rows(0).Item("FLD_TYPE")
            txt_price.Text = datatable.Rows(0).Item("FLD_PRICE")
            txt_colour.Text = datatable.Rows(0).Item("FLD_COLOUR")

            Try
                pic_product.BackgroundImage = Image.FromFile("pictures/" & lbl_id.Text & ".jpg")
            Catch ex As Exception
                pic_product.BackgroundImage = Image.FromFile(defaultpicture)
            End Try

        End If

    End Sub

    Private Sub cmb_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedIndexChanged
        refresh_list(cmb_type.Text)
    End Sub

    Private Sub lst_productID_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_productID.MouseClick
        refresh_text(lst_productID.Text)
    End Sub

End Class