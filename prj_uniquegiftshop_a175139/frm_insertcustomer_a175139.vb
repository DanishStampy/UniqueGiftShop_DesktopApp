Public Class frm_insertcustomer_a175139
    Private Sub frm_insertcustomer_a175139_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A175139 ORDER BY FLD_CUSTOMER_ID ASC")
        txt_id.Text = generate_idcustomer()

    End Sub

    Private Function generate_idcustomer() As String

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTID FROM TBL_CUSTOMER_A175139").Rows(0).Item("LASTID")
        MsgBox("This is the latest customer ID: " + lastid)
        Dim new_customerID As String = "C" & Mid(lastid, 2) + 1
        Return new_customerID

    End Function

    Private Sub btn_insert_customer_Click(sender As Object, e As EventArgs) Handles btn_insert_customer.Click

        If txt_name.Text = String.Empty Then
            MsgBox("Please fill in all the empty box.")
            clear()
        Else
            Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A175139 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "')"
            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()

                grd_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A175139 ORDER BY FLD_CUSTOMER_ID ASC")
                clear()
                MsgBox("New customer information succesfully created !")

            Catch ex As Exception
                Beep()
                MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
                mywriter.Connection.Close()
                clear()
            End Try
        End If

    End Sub
    Private Sub clear()
        txt_id.Text = generate_idcustomer()
        txt_name.Text = ""
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a175139.Show()
        Me.Hide()

    End Sub
End Class