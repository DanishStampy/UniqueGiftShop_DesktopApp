Public Class frm_listofproduct_a175139
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a175139.Show()
        Me.Close()

    End Sub

    Private Sub frm_listofproduct_a175139_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A175139"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_product.DataSource = mydatatable
    End Sub
End Class