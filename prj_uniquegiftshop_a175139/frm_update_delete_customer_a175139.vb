Public Class frm_update_delete_customer_a175139

    Dim current_id As String
    Private Sub frm_update_delete_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()
        get_current_id()

    End Sub
    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A175139 ORDER BY FLD_CUSTOMER_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable

    End Sub

    Private Sub clear()
        txt_id.Text = ""
        txt_name.Text = ""

    End Sub

    Private Sub get_current_id()

        Dim current_row As Integer = grd_customer.CurrentRow.Index
        current_id = grd_customer(0, current_row).Value
        txt_id.Text = current_id
        txt_name.Text = grd_customer(1, current_row).Value

    End Sub

    Private Sub grd_customer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellClick
        get_current_id()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_CUSTOMER_A175139 SET FLD_CUSTOMER_NAME='" & txt_name.Text & "' WHERE FLD_CUSTOMER_ID='" & current_id & "'")

        Beep()
        MsgBox("You have successfully updated customer ID: """ & current_id & """.")

        refresh_grid()
        clear()
        get_current_id()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a175139.Show()
        Me.Close()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete customer ID: """ & current_id & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_CUSTOMER_A175139 WHERE FLD_CUSTOMER_ID='" & current_id & "'")

            Beep()
            MsgBox("""" & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear()
            get_current_id()

        End If
    End Sub
End Class