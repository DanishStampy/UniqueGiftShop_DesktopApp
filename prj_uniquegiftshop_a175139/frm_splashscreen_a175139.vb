Public Class frm_splashscreen_a175139

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub frm_splashscreen_a175139_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End

    End Sub
End Class