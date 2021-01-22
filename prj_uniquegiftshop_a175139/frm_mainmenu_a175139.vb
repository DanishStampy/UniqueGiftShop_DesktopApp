Public Class frm_mainmenu_a175139

    Dim pl1 As Integer = 50
    Dim pl2 As Integer = 50
    Dim pl3 As Integer = 50
    Dim pl4 As Integer = 50
    Private Sub frm_splashscreen_a175139_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''MsgBox("Please hover your mouse on each button to show the list of others button")
        Dim current_date As String = Date.Now
        lbl_date.Text = current_date

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        MsgBox("Bye bye, see you later")
        End

    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staffinfo_a175139.Show()
        Me.Hide()

    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_listofproduct_a175139.Show()
        Me.Hide()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_customerinfo_a175139.Show()
        Me.Hide()

    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_listoforder_a175139.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_details_Click(sender As Object, e As EventArgs) Handles btn_order_details.Click
        frm_orderdetails_a175139.Show()
        Me.Hide()

    End Sub

    Private Sub btn_catalog_Click(sender As Object, e As EventArgs) Handles btn_catalog.Click
        frm_catalog_a175139.Show()
        Me.Hide()

    End Sub

    Private Sub btn_insert_customer_Click(sender As Object, e As EventArgs) Handles btn_insert_customer.Click
        frm_insertcustomer_a175139.Show()
        Me.Hide()

    End Sub

    Private Sub btn_insert_staff_Click(sender As Object, e As EventArgs) Handles btn_insert_staff.Click
        frm_insertstaff_a175139.Show()
        Me.Hide()

    End Sub

    Private Sub btn_insert_product_Click(sender As Object, e As EventArgs) Handles btn_insert_product.Click
        frm_insertproduct_a175139.Show()
        Me.Hide()

    End Sub

    Private Sub btn_edit_customer_Click(sender As Object, e As EventArgs) Handles btn_edit_customer.Click
        frm_update_delete_customer_a175139.Show()
        Me.Hide()
    End Sub

    Private Sub btn_edit_staff_Click(sender As Object, e As EventArgs) Handles btn_edit_staff.Click
        frm_update_delete_staff_a175139.Show()
        Me.Hide()

    End Sub

    Private Sub btn_edit_product_Click(sender As Object, e As EventArgs) Handles btn_edit_product.Click
        frm_update_delete_product_a175139.Show()
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pl1 > 150 Then

            Timer1.Stop()

        Else
            Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl1)
            pl1 += 10

        End If
    End Sub

    Private Sub btn_staff_MouseHover(sender As Object, e As EventArgs) Handles btn_staff.MouseHover
        Me.Panel2.Size = New Size(Me.Panel2.Size.Width, pl2)
        Me.Panel4.Size = New Size(Me.Panel4.Size.Width, pl4)
        Me.Panel3.Size = New Size(Me.Panel3.Size.Width, pl3)
        Timer1.Start()
    End Sub

    Private Sub btn_staff_MouseLeave(sender As Object, e As EventArgs) Handles btn_staff.MouseLeave
        Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl1)
        Timer1.Stop()
        pl1 = 50
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If pl2 > 150 Then

            Timer2.Stop()

        Else
            Me.Panel2.Size = New Size(Me.Panel2.Size.Width, pl2)
            pl2 += 10

        End If
    End Sub

    Private Sub btn_customer_MouseHover(sender As Object, e As EventArgs) Handles btn_customer.MouseHover
        Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl1)
        Me.Panel4.Size = New Size(Me.Panel4.Size.Width, pl4)
        Me.Panel3.Size = New Size(Me.Panel3.Size.Width, pl3)
        Timer2.Start()
    End Sub

    Private Sub btn_customer_MouseLeave(sender As Object, e As EventArgs) Handles btn_customer.MouseLeave
        Me.Panel2.Size = New Size(Me.Panel2.Size.Width, pl2)
        Timer2.Stop()
        pl2 = 50
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If pl3 > 200 Then

            Timer3.Stop()

        Else
            Me.Panel3.Size = New Size(Me.Panel3.Size.Width, pl3)
            pl3 += 10

        End If
    End Sub

    Private Sub btn_order_MouseHover(sender As Object, e As EventArgs) Handles btn_order.MouseHover
        Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl1)
        Me.Panel2.Size = New Size(Me.Panel2.Size.Width, pl2)
        Me.Panel4.Size = New Size(Me.Panel4.Size.Width, pl4)
        Timer3.Start()
    End Sub

    Private Sub btn_order_MouseLeave(sender As Object, e As EventArgs) Handles btn_order.MouseLeave
        Me.Panel3.Size = New Size(Me.Panel3.Size.Width, pl3)
        Timer3.Stop()
        pl3 = 50
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If pl4 > 200 Then

            Timer4.Stop()

        Else
            Me.Panel4.Size = New Size(Me.Panel4.Size.Width, pl4)
            pl4 += 10

        End If
    End Sub

    Private Sub btn_product_MouseHover(sender As Object, e As EventArgs) Handles btn_product.MouseHover
        Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl1)
        Me.Panel2.Size = New Size(Me.Panel2.Size.Width, pl2)
        Me.Panel3.Size = New Size(Me.Panel3.Size.Width, pl3)
        Timer4.Start()
    End Sub

    Private Sub btn_product_MouseLeave(sender As Object, e As EventArgs) Handles btn_product.MouseLeave
        Me.Panel4.Size = New Size(Me.Panel4.Size.Width, pl4)
        Timer4.Stop()
        pl4 = 50
    End Sub

    Private Sub frm_mainmenu_a175139_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl1)
        Me.Panel2.Size = New Size(Me.Panel2.Size.Width, pl2)
        Me.Panel3.Size = New Size(Me.Panel3.Size.Width, pl3)
        Me.Panel4.Size = New Size(Me.Panel4.Size.Width, pl4)
    End Sub

    Private Sub btn_make_order_Click(sender As Object, e As EventArgs) Handles btn_make_order.Click
        frm_makeorder_a175139.Show()
        Me.Hide()

    End Sub

    Private Sub btn_view_order_Click(sender As Object, e As EventArgs) Handles btn_view_order.Click
        frm_vieworder_a175139.Show()
        Me.Hide()

    End Sub
End Class
