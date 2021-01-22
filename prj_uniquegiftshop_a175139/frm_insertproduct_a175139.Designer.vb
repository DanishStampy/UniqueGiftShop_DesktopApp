<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproduct_a175139
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertproduct_a175139))
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_material = New System.Windows.Forms.TextBox()
        Me.txt_colour = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_pic_location = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_select_pic = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_product
        '
        Me.grd_product.BackgroundColor = System.Drawing.SystemColors.Info
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(530, 126)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.Size = New System.Drawing.Size(737, 462)
        Me.grd_product.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Snow
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(523, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 39)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "CREATE PRODUCT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label2.Location = New System.Drawing.Point(44, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Product ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label3.Location = New System.Drawing.Point(220, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Product Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label4.Location = New System.Drawing.Point(220, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Product Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label5.Location = New System.Drawing.Point(44, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 21)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Material:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label6.Location = New System.Drawing.Point(220, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Colour:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label7.Location = New System.Drawing.Point(44, 373)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Price (RM):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label8.Location = New System.Drawing.Point(44, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 21)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Stock Quantity:"
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.SystemColors.Info
        Me.txt_id.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(48, 159)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(99, 28)
        Me.txt_id.TabIndex = 18
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.SystemColors.Info
        Me.txt_name.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(224, 159)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(218, 28)
        Me.txt_name.TabIndex = 19
        '
        'txt_quantity
        '
        Me.txt_quantity.BackColor = System.Drawing.SystemColors.Info
        Me.txt_quantity.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(48, 237)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(99, 28)
        Me.txt_quantity.TabIndex = 21
        '
        'txt_material
        '
        Me.txt_material.BackColor = System.Drawing.SystemColors.Info
        Me.txt_material.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_material.Location = New System.Drawing.Point(47, 318)
        Me.txt_material.Name = "txt_material"
        Me.txt_material.Size = New System.Drawing.Size(100, 28)
        Me.txt_material.TabIndex = 22
        '
        'txt_colour
        '
        Me.txt_colour.BackColor = System.Drawing.SystemColors.Info
        Me.txt_colour.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_colour.Location = New System.Drawing.Point(224, 318)
        Me.txt_colour.Name = "txt_colour"
        Me.txt_colour.Size = New System.Drawing.Size(102, 28)
        Me.txt_colour.TabIndex = 23
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.SystemColors.Info
        Me.txt_price.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(47, 396)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(100, 28)
        Me.txt_price.TabIndex = 24
        '
        'txt_pic_location
        '
        Me.txt_pic_location.BackColor = System.Drawing.SystemColors.Info
        Me.txt_pic_location.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pic_location.Location = New System.Drawing.Point(275, 478)
        Me.txt_pic_location.Name = "txt_pic_location"
        Me.txt_pic_location.Size = New System.Drawing.Size(239, 25)
        Me.txt_pic_location.TabIndex = 25
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Maroon
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btn_back.Location = New System.Drawing.Point(591, 652)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(97, 37)
        Me.btn_back.TabIndex = 27
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_select_pic
        '
        Me.btn_select_pic.BackColor = System.Drawing.Color.Maroon
        Me.btn_select_pic.FlatAppearance.BorderSize = 0
        Me.btn_select_pic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_select_pic.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_select_pic.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btn_select_pic.Location = New System.Drawing.Point(275, 527)
        Me.btn_select_pic.Name = "btn_select_pic"
        Me.btn_select_pic.Size = New System.Drawing.Size(123, 42)
        Me.btn_select_pic.TabIndex = 28
        Me.btn_select_pic.Text = "SELECT PICTURE"
        Me.btn_select_pic.UseVisualStyleBackColor = False
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Maroon
        Me.btn_insert.FlatAppearance.BorderSize = 0
        Me.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_insert.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btn_insert.Location = New System.Drawing.Point(275, 595)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(97, 37)
        Me.btn_insert.TabIndex = 29
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label9.Location = New System.Drawing.Point(271, 454)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 21)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "File Location:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cmb_type
        '
        Me.cmb_type.BackColor = System.Drawing.SystemColors.Info
        Me.cmb_type.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(224, 238)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(218, 29)
        Me.cmb_type.TabIndex = 31
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.SystemColors.Info
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(75, 454)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(183, 166)
        Me.pic_product.TabIndex = 26
        Me.pic_product.TabStop = False
        '
        'frm_insertproduct_a175139
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.prj_uniquegiftshop_a175139.My.Resources.Resources._2461286afc14ea178d40a0e7b1419819
        Me.ClientSize = New System.Drawing.Size(1279, 715)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_select_pic)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_pic_location)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_colour)
        Me.Controls.Add(Me.txt_material)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_product)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_insertproduct_a175139"
        Me.Text = "Create New Product"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_product As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents txt_material As TextBox
    Friend WithEvents txt_colour As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_pic_location As TextBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_select_pic As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cmb_type As ComboBox
End Class
