Imports System.IO

Public Class frm_insertproduct_a175139

    Dim defaultpicture As String = Application.StartupPath & "\pictures\defaultphoto.jpg"
    Dim product_type As String
    Private Sub frm_insertproduct_a175139_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT DISTINCT FLD_TYPE FROM TBL_PRODUCT_A175139"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        cmb_type.DataSource = mydatatable
        cmb_type.DisplayMember = "FLD_TYPE"
        product_type = cmb_type.Text

        grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCT_A175139 ORDER BY FLD_PRODUCT_ID ASC")
        txt_id.Text = generate_idproduct()
        txt_pic_location.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Function generate_idproduct() As String

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCT_A175139").Rows(0).Item("LASTID")
        MsgBox("This is the latest product ID: " + lastid)
        Dim new_productID As String = "P" & Mid(lastid, 2) + 1
        Return new_productID

    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        If txt_colour.Text = String.Empty Or txt_material.Text = String.Empty Or txt_name.Text = String.Empty Then
            MsgBox("Please fill in all the empty box.")
            clear()

        Else
            Dim mysql As String = "INSERT INTO TBL_PRODUCT_A175139 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_price.Text & "', '" & product_type & "', '" & txt_colour.Text & "', '" & txt_quantity.Text & "', '" & txt_material.Text & "')"
            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()

                My.Computer.FileSystem.CopyFile(txt_pic_location.Text, "pictures\" & txt_id.Text & ".jpg")

                grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCT_A175139 ORDER BY FLD_PRODUCT_ID ASC")
                clear()
                MsgBox("New product information succesfully created !")

            Catch ex As Exception
                Beep()
                MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
                mywriter.Connection.Close()
                clear()
            End Try

        End If

    End Sub

    Private Sub clear()

        txt_id.Text = generate_idproduct()
        txt_name.Text = ""
        txt_price.Text = ""
        txt_colour.Text = ""
        txt_quantity.Text = ""
        txt_material.Text = ""
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Sub btn_select_pic_Click(sender As Object, e As EventArgs) Handles btn_select_pic.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        Dim xx As Image
        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        Using str As Stream = File.OpenRead(OpenFileDialog1.FileName)
            xx = Image.FromStream(str)
        End Using
        pic_product.BackgroundImage = xx
        txt_pic_location.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a175139.Show()
        Me.Close()

    End Sub

    Private Sub cmb_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedIndexChanged
        product_type = cmb_type.Text
    End Sub
End Class