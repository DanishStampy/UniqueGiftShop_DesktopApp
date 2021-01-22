Public Class frm_insertstaff_a175139
    Private Sub frm_insertstaff_a175139_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A175139 ORDER BY FLD_STAFF_ID ASC")
        txt_id.Text = generate_idstaff()

    End Sub
    Private Function generate_idstaff() As String

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTID FROM TBL_STAFF_A175139").Rows(0).Item("LASTID")
        MsgBox("This is the latest staff ID: " + lastid)
        Dim new_staffID As String = "S" & Mid(lastid, 2) + 1
        Return new_staffID

    End Function

    Private Sub btn_insert_staff_Click(sender As Object, e As EventArgs) Handles btn_insert_staff.Click

        If txt_name.Text = String.Empty Then
            MsgBox("Please fill in all the empty box.")
            clear()

        Else

            Dim mysql As String = "INSERT INTO TBL_STAFF_A175139 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_age.Text & "')"
            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()

                grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A175139 ORDER BY FLD_STAFF_ID ASC")
                clear()
                MsgBox("New staff information succesfully created !")

            Catch ex As Exception
                Beep()
                MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
                mywriter.Connection.Close()
                clear()

            End Try
        End If



    End Sub

    Private Sub clear()
        txt_id.Text = generate_idstaff()
        txt_name.Text = ""
        txt_age.Text = ""
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a175139.Show()
        Me.Hide()

    End Sub
End Class