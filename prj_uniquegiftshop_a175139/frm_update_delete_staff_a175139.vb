Public Class frm_update_delete_staff_a175139

    Dim current_id As String
    Private Sub frm_update_delete_staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()
        get_current_id()

    End Sub
    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A175139 ORDER BY FLD_STAFF_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable

    End Sub

    Private Sub clear()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_age.Text = ""

    End Sub

    Private Sub get_current_id()

        Dim current_row As Integer = grd_staff.CurrentRow.Index
        current_id = grd_staff(0, current_row).Value
        txt_id.Text = current_id
        txt_name.Text = grd_staff(1, current_row).Value
        txt_age.Text = grd_staff(2, current_row).Value

    End Sub

    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick
        get_current_id()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_STAFF_A175139 SET FLD_STAFF_NAME='" & txt_name.Text & "', FLD_AGE= " & txt_age.Text & " WHERE FLD_STAFF_ID='" & current_id & "'")

        Beep()
        MsgBox("You have successfully updated staff ID: """ & current_id & """.")

        refresh_grid()
        clear()
        get_current_id()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete staff ID: """ & current_id & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_STAFF_A175139 WHERE FLD_STAFF_ID='" & current_id & "'")

            Beep()
            MsgBox("""" & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear()
            get_current_id()

        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a175139.Show()
        Me.Close()

    End Sub
End Class