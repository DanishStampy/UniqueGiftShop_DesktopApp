Public Class frm_customerinfo_a175139
    Private Sub frm_customerinfo_a175139_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A175139 ORDER BY FLD_CUSTOMER_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a175139.Show()
        Me.Close()

    End Sub
End Class