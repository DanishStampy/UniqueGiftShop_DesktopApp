
Imports System.IO

Public Class frm_update_delete_product_a175139

    Dim current_id As String
    Dim product_type As String
    Dim defaultpicture As String = Application.StartupPath & "\pictures\defaultphoto.jpg"
    Private Sub frm_update_delete_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT DISTINCT FLD_TYPE FROM TBL_PRODUCT_A175139"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        cmb_type.DataSource = mydatatable
        cmb_type.DisplayMember = "FLD_TYPE"
        product_type = cmb_type.Text

        refresh_grid()
        get_current_id()

    End Sub
    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A175139 ORDER BY FLD_PRODUCT_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_product.DataSource = mydatatable

    End Sub

    Private Sub clear()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_colour.Text = ""
        txt_material.Text = ""
        txt_price.Text = ""
        txt_quantity.Text = ""
        cmb_type.Text = ""
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Sub get_current_id()

        Dim current_row As Integer = grd_product.CurrentRow.Index
        current_id = grd_product(0, current_row).Value
        txt_id.Text = current_id
        txt_name.Text = grd_product(1, current_row).Value
        txt_price.Text = grd_product(2, current_row).Value
        cmb_type.Text = grd_product(3, current_row).Value
        txt_colour.Text = grd_product(4, current_row).Value
        txt_quantity.Text = grd_product(5, current_row).Value
        txt_material.Text = grd_product(6, current_row).Value
        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & current_id & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)
        End Try

    End Sub

    Private Sub cmb_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedIndexChanged
        product_type = cmb_type.Text
    End Sub

    Private Sub grd_product_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellClick
        get_current_id()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        Dim update_confirmation = MsgBox("Are you sure you would like to update this product ID: """ & current_id & """?", MsgBoxStyle.YesNo)
        If update_confirmation = MsgBoxResult.Yes Then

            run_sql_command("UPDATE TBL_PRODUCT_A175139 SET FLD_PRODUCT_NAME='" & txt_name.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
            run_sql_command("UPDATE TBL_PRODUCT_A175139 SET FLD_PRICE='" & txt_price.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
            run_sql_command("UPDATE TBL_PRODUCT_A175139 SET FLD_TYPE='" & product_type & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
            run_sql_command("UPDATE TBL_PRODUCT_A175139 SET FLD_COLOUR='" & txt_colour.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
            run_sql_command("UPDATE TBL_PRODUCT_A175139 SET FLD_PRODUCT_QUANTITY='" & txt_quantity.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")
            run_sql_command("UPDATE TBL_PRODUCT_A175139 SET FLD_MATERIAL='" & txt_material.Text & "' WHERE FLD_PRODUCT_ID='" & current_id & "'")

            Beep()
            MsgBox("You have successfully updated product ID: """ & current_id & """.")

            refresh_grid()
            clear()
            get_current_id()
        End If

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete this product ID: """ & current_id & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_PRODUCT_A175139 WHERE FLD_PRODUCT_ID='" & current_id & "'")

            delete(current_id)

            Beep()
            MsgBox("""" & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear()
            get_current_id()

        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a175139.Show()
        clear()
        Me.Close()

    End Sub

    Private Sub delete(ID As String)
        pic_product.BackgroundImage.Dispose()
        System.IO.File.Delete("pictures\" & ID & ".jpg")
    End Sub
End Class