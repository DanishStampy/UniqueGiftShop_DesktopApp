<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_catalog_a175139
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_catalog_a175139))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.lst_productID = New System.Windows.Forms.ListBox()
        Me.txt_product_name = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_colour = New System.Windows.Forms.TextBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_material = New System.Windows.Forms.TextBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Maroon
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btn_back.Location = New System.Drawing.Point(446, 582)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(100, 41)
        Me.btn_back.TabIndex = 4
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'cmb_type
        '
        Me.cmb_type.BackColor = System.Drawing.SystemColors.Info
        Me.cmb_type.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(76, 174)
        Me.cmb_type.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(177, 29)
        Me.cmb_type.TabIndex = 5
        '
        'lst_productID
        '
        Me.lst_productID.BackColor = System.Drawing.SystemColors.Info
        Me.lst_productID.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_productID.FormattingEnabled = True
        Me.lst_productID.ItemHeight = 21
        Me.lst_productID.Location = New System.Drawing.Point(76, 243)
        Me.lst_productID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lst_productID.Name = "lst_productID"
        Me.lst_productID.Size = New System.Drawing.Size(133, 214)
        Me.lst_productID.TabIndex = 6
        '
        'txt_product_name
        '
        Me.txt_product_name.BackColor = System.Drawing.SystemColors.Info
        Me.txt_product_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_product_name.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_name.Location = New System.Drawing.Point(54, 54)
        Me.txt_product_name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_product_name.Name = "txt_product_name"
        Me.txt_product_name.ReadOnly = True
        Me.txt_product_name.Size = New System.Drawing.Size(222, 25)
        Me.txt_product_name.TabIndex = 7
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.SystemColors.Info
        Me.txt_price.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(54, 318)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(74, 25)
        Me.txt_price.TabIndex = 9
        '
        'txt_colour
        '
        Me.txt_colour.BackColor = System.Drawing.SystemColors.Info
        Me.txt_colour.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_colour.Location = New System.Drawing.Point(182, 137)
        Me.txt_colour.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_colour.Name = "txt_colour"
        Me.txt_colour.ReadOnly = True
        Me.txt_colour.Size = New System.Drawing.Size(94, 25)
        Me.txt_colour.TabIndex = 10
        '
        'txt_quantity
        '
        Me.txt_quantity.BackColor = System.Drawing.SystemColors.Info
        Me.txt_quantity.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(54, 226)
        Me.txt_quantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.ReadOnly = True
        Me.txt_quantity.Size = New System.Drawing.Size(74, 25)
        Me.txt_quantity.TabIndex = 11
        '
        'txt_material
        '
        Me.txt_material.BackColor = System.Drawing.SystemColors.Info
        Me.txt_material.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_material.Location = New System.Drawing.Point(54, 137)
        Me.txt_material.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_material.Name = "txt_material"
        Me.txt_material.ReadOnly = True
        Me.txt_material.Size = New System.Drawing.Size(90, 25)
        Me.txt_material.TabIndex = 12
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.SystemColors.Info
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_product.Location = New System.Drawing.Point(320, 159)
        Me.pic_product.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(278, 368)
        Me.pic_product.TabIndex = 14
        Me.pic_product.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Snow
        Me.lbl_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_title.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_title.Location = New System.Drawing.Point(353, 64)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(287, 45)
        Me.lbl_title.TabIndex = 15
        Me.lbl_title.Text = "PRODUCT CATALOG"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_id.Location = New System.Drawing.Point(665, 159)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(110, 26)
        Me.lbl_id.TabIndex = 16
        Me.lbl_id.Text = "Product ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Product Name:"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.BackColor = System.Drawing.Color.Transparent
        Me.lbl_type.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_type.Location = New System.Drawing.Point(790, 159)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(133, 26)
        Me.lbl_type.TabIndex = 18
        Me.lbl_type.Text = "Product Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(22, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Price (RM):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(22, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Material:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(22, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "In-stock Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(166, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 18)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Colour:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label6.Location = New System.Drawing.Point(72, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 22)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "List of product ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label7.Location = New System.Drawing.Point(72, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 22)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Choose type of product"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_material)
        Me.Panel1.Controls.Add(Me.txt_quantity)
        Me.Panel1.Controls.Add(Me.txt_colour)
        Me.Panel1.Controls.Add(Me.txt_price)
        Me.Panel1.Controls.Add(Me.txt_product_name)
        Me.Panel1.Location = New System.Drawing.Point(641, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 363)
        Me.Panel1.TabIndex = 25
        '
        'frm_catalog_a175139
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_uniquegiftshop_a175139.My.Resources.Resources._2461286afc14ea178d40a0e7b1419819
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(993, 644)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lst_productID)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Front Page Neue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_catalog_a175139"
        Me.Text = "Catalog of Product"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents cmb_type As ComboBox
    Friend WithEvents lst_productID As ListBox
    Friend WithEvents txt_product_name As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_colour As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents txt_material As TextBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
End Class
