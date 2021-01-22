<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_makeorder_a175139
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeorder_a175139))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_product_id = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_add_cart = New System.Windows.Forms.Button()
        Me.lbl_total_price = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.lbl_price_product = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_name_product = New System.Windows.Forms.Label()
        Me.lbl_type_product = New System.Windows.Forms.Label()
        Me.lbl_colour_product = New System.Windows.Forms.Label()
        Me.lbl_material_product = New System.Windows.Forms.Label()
        Me.lbl_stock_product = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_cancel_order = New System.Windows.Forms.Button()
        Me.lbl_customer_name = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_make_order = New System.Windows.Forms.Button()
        Me.lbl_orderID = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_customer = New System.Windows.Forms.ComboBox()
        Me.cmb_staff = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_total_cart_price = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_confirmation = New System.Windows.Forms.Button()
        Me.grd_orderList = New System.Windows.Forms.DataGridView()
        Me.FLD_PRODUCT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_PRODUCT_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_QUANTITY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grd_orderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FloralWhite
        Me.GroupBox1.Controls.Add(Me.cmb_product_id)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.btn_add_cart)
        Me.GroupBox1.Controls.Add(Me.lbl_total_price)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown)
        Me.GroupBox1.Controls.Add(Me.lbl_price_product)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbl_name_product)
        Me.GroupBox1.Controls.Add(Me.lbl_type_product)
        Me.GroupBox1.Controls.Add(Me.lbl_colour_product)
        Me.GroupBox1.Controls.Add(Me.lbl_material_product)
        Me.GroupBox1.Controls.Add(Me.lbl_stock_product)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(687, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 437)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Information"
        '
        'cmb_product_id
        '
        Me.cmb_product_id.BackColor = System.Drawing.SystemColors.Info
        Me.cmb_product_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_product_id.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_product_id.ForeColor = System.Drawing.Color.DarkRed
        Me.cmb_product_id.FormattingEnabled = True
        Me.cmb_product_id.Location = New System.Drawing.Point(109, 43)
        Me.cmb_product_id.Name = "cmb_product_id"
        Me.cmb_product_id.Size = New System.Drawing.Size(121, 28)
        Me.cmb_product_id.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(105, 345)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 20)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "RM"
        '
        'btn_add_cart
        '
        Me.btn_add_cart.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_add_cart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_add_cart.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_cart.Location = New System.Drawing.Point(104, 385)
        Me.btn_add_cart.Name = "btn_add_cart"
        Me.btn_add_cart.Size = New System.Drawing.Size(104, 33)
        Me.btn_add_cart.TabIndex = 18
        Me.btn_add_cart.Text = "ADD TO CART"
        Me.btn_add_cart.UseVisualStyleBackColor = False
        '
        'lbl_total_price
        '
        Me.lbl_total_price.AutoSize = True
        Me.lbl_total_price.Location = New System.Drawing.Point(146, 345)
        Me.lbl_total_price.Name = "lbl_total_price"
        Me.lbl_total_price.Size = New System.Drawing.Size(14, 20)
        Me.lbl_total_price.TabIndex = 17
        Me.lbl_total_price.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 345)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 20)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Sub-total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Quantity:"
        '
        'NumericUpDown
        '
        Me.NumericUpDown.BackColor = System.Drawing.SystemColors.Info
        Me.NumericUpDown.ForeColor = System.Drawing.Color.DarkRed
        Me.NumericUpDown.Location = New System.Drawing.Point(109, 256)
        Me.NumericUpDown.Name = "NumericUpDown"
        Me.NumericUpDown.Size = New System.Drawing.Size(120, 28)
        Me.NumericUpDown.TabIndex = 14
        '
        'lbl_price_product
        '
        Me.lbl_price_product.AutoSize = True
        Me.lbl_price_product.Location = New System.Drawing.Point(105, 226)
        Me.lbl_price_product.Name = "lbl_price_product"
        Me.lbl_price_product.Size = New System.Drawing.Size(42, 20)
        Me.lbl_price_product.TabIndex = 13
        Me.lbl_price_product.Text = "Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Price (RM):"
        '
        'lbl_name_product
        '
        Me.lbl_name_product.AutoSize = True
        Me.lbl_name_product.Location = New System.Drawing.Point(105, 81)
        Me.lbl_name_product.Name = "lbl_name_product"
        Me.lbl_name_product.Size = New System.Drawing.Size(49, 20)
        Me.lbl_name_product.TabIndex = 11
        Me.lbl_name_product.Text = "Name"
        '
        'lbl_type_product
        '
        Me.lbl_type_product.AutoSize = True
        Me.lbl_type_product.Location = New System.Drawing.Point(105, 108)
        Me.lbl_type_product.Name = "lbl_type_product"
        Me.lbl_type_product.Size = New System.Drawing.Size(42, 20)
        Me.lbl_type_product.TabIndex = 10
        Me.lbl_type_product.Text = "Type"
        '
        'lbl_colour_product
        '
        Me.lbl_colour_product.AutoSize = True
        Me.lbl_colour_product.Location = New System.Drawing.Point(105, 168)
        Me.lbl_colour_product.Name = "lbl_colour_product"
        Me.lbl_colour_product.Size = New System.Drawing.Size(55, 20)
        Me.lbl_colour_product.TabIndex = 9
        Me.lbl_colour_product.Text = "Colour"
        '
        'lbl_material_product
        '
        Me.lbl_material_product.AutoSize = True
        Me.lbl_material_product.Location = New System.Drawing.Point(105, 138)
        Me.lbl_material_product.Name = "lbl_material_product"
        Me.lbl_material_product.Size = New System.Drawing.Size(64, 20)
        Me.lbl_material_product.TabIndex = 8
        Me.lbl_material_product.Text = "Material"
        '
        'lbl_stock_product
        '
        Me.lbl_stock_product.AutoSize = True
        Me.lbl_stock_product.Location = New System.Drawing.Point(105, 198)
        Me.lbl_stock_product.Name = "lbl_stock_product"
        Me.lbl_stock_product.Size = New System.Drawing.Size(47, 20)
        Me.lbl_stock_product.TabIndex = 7
        Me.lbl_stock_product.Text = "Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Product ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stock left:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Colour:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Material:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.SystemColors.Info
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_product.Location = New System.Drawing.Point(778, 35)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(140, 128)
        Me.pic_product.TabIndex = 1
        Me.pic_product.TabStop = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_back.Location = New System.Drawing.Point(388, 652)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(146, 44)
        Me.btn_back.TabIndex = 3
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FloralWhite
        Me.GroupBox2.Controls.Add(Me.btn_cancel_order)
        Me.GroupBox2.Controls.Add(Me.lbl_customer_name)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lbl_date)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.btn_make_order)
        Me.GroupBox2.Controls.Add(Me.lbl_orderID)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cmb_customer)
        Me.GroupBox2.Controls.Add(Me.cmb_staff)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox2.Location = New System.Drawing.Point(42, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 158)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Order's Information"
        '
        'btn_cancel_order
        '
        Me.btn_cancel_order.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_cancel_order.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancel_order.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel_order.Location = New System.Drawing.Point(461, 86)
        Me.btn_cancel_order.Name = "btn_cancel_order"
        Me.btn_cancel_order.Size = New System.Drawing.Size(108, 49)
        Me.btn_cancel_order.TabIndex = 11
        Me.btn_cancel_order.Text = "CANCEL ORDER"
        Me.btn_cancel_order.UseVisualStyleBackColor = False
        '
        'lbl_customer_name
        '
        Me.lbl_customer_name.AutoSize = True
        Me.lbl_customer_name.Location = New System.Drawing.Point(138, 113)
        Me.lbl_customer_name.Name = "lbl_customer_name"
        Me.lbl_customer_name.Size = New System.Drawing.Size(52, 22)
        Me.lbl_customer_name.TabIndex = 10
        Me.lbl_customer_name.Text = "Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 22)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Customer Name:"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(368, 86)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(42, 22)
        Me.lbl_date.TabIndex = 8
        Me.lbl_date.Text = "Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(278, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 22)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Order Date:"
        '
        'btn_make_order
        '
        Me.btn_make_order.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_make_order.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_make_order.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_make_order.Location = New System.Drawing.Point(461, 44)
        Me.btn_make_order.Name = "btn_make_order"
        Me.btn_make_order.Size = New System.Drawing.Size(108, 29)
        Me.btn_make_order.TabIndex = 6
        Me.btn_make_order.Text = "MAKE ORDER"
        Me.btn_make_order.UseVisualStyleBackColor = False
        '
        'lbl_orderID
        '
        Me.lbl_orderID.AutoSize = True
        Me.lbl_orderID.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderID.Location = New System.Drawing.Point(368, 46)
        Me.lbl_orderID.Name = "lbl_orderID"
        Me.lbl_orderID.Size = New System.Drawing.Size(27, 22)
        Me.lbl_orderID.TabIndex = 5
        Me.lbl_orderID.Text = "ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(294, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 22)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Order ID:"
        '
        'cmb_customer
        '
        Me.cmb_customer.BackColor = System.Drawing.SystemColors.Info
        Me.cmb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_customer.ForeColor = System.Drawing.Color.DarkRed
        Me.cmb_customer.FormattingEnabled = True
        Me.cmb_customer.Location = New System.Drawing.Point(138, 78)
        Me.cmb_customer.Name = "cmb_customer"
        Me.cmb_customer.Size = New System.Drawing.Size(121, 30)
        Me.cmb_customer.TabIndex = 3
        '
        'cmb_staff
        '
        Me.cmb_staff.BackColor = System.Drawing.SystemColors.Info
        Me.cmb_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_staff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_staff.ForeColor = System.Drawing.Color.DarkRed
        Me.cmb_staff.FormattingEnabled = True
        Me.cmb_staff.Location = New System.Drawing.Point(138, 46)
        Me.cmb_staff.Name = "cmb_staff"
        Me.cmb_staff.Size = New System.Drawing.Size(121, 30)
        Me.cmb_staff.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 22)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Customer ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(65, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 22)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Staff ID:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.btn_cancel)
        Me.GroupBox3.Controls.Add(Me.btn_confirmation)
        Me.GroupBox3.Controls.Add(Me.grd_orderList)
        Me.GroupBox3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox3.Location = New System.Drawing.Point(42, 230)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(607, 386)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Item(s) on cart"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_total_cart_price)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Location = New System.Drawing.Point(346, 303)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(190, 66)
        Me.Panel1.TabIndex = 21
        '
        'lbl_total_cart_price
        '
        Me.lbl_total_cart_price.AutoSize = True
        Me.lbl_total_cart_price.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_cart_price.Location = New System.Drawing.Point(55, 30)
        Me.lbl_total_cart_price.Name = "lbl_total_cart_price"
        Me.lbl_total_cart_price.Size = New System.Drawing.Size(64, 28)
        Me.lbl_total_cart_price.TabIndex = 20
        Me.lbl_total_cart_price.Text = "RM 0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(154, 20)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Total price in the cart:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(390, 303)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 18)
        Me.Label16.TabIndex = 20
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancel.Location = New System.Drawing.Point(202, 320)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(106, 49)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "REMOVE"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_confirmation
        '
        Me.btn_confirmation.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_confirmation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_confirmation.Location = New System.Drawing.Point(69, 320)
        Me.btn_confirmation.Name = "btn_confirmation"
        Me.btn_confirmation.Size = New System.Drawing.Size(106, 49)
        Me.btn_confirmation.TabIndex = 1
        Me.btn_confirmation.Text = "CONFRIM ORDER"
        Me.btn_confirmation.UseVisualStyleBackColor = False
        '
        'grd_orderList
        '
        Me.grd_orderList.AllowUserToAddRows = False
        Me.grd_orderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_orderList.BackgroundColor = System.Drawing.SystemColors.Info
        Me.grd_orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FLD_PRODUCT_ID, Me.FLD_PRODUCT_NAME, Me.FLD_QUANTITY, Me.FLD_PRICE})
        Me.grd_orderList.Location = New System.Drawing.Point(9, 34)
        Me.grd_orderList.Name = "grd_orderList"
        Me.grd_orderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_orderList.Size = New System.Drawing.Size(592, 254)
        Me.grd_orderList.TabIndex = 0
        '
        'FLD_PRODUCT_ID
        '
        Me.FLD_PRODUCT_ID.HeaderText = "PRODUCT ID"
        Me.FLD_PRODUCT_ID.Name = "FLD_PRODUCT_ID"
        Me.FLD_PRODUCT_ID.ReadOnly = True
        '
        'FLD_PRODUCT_NAME
        '
        Me.FLD_PRODUCT_NAME.HeaderText = "PRODUCT NAME"
        Me.FLD_PRODUCT_NAME.Name = "FLD_PRODUCT_NAME"
        Me.FLD_PRODUCT_NAME.ReadOnly = True
        '
        'FLD_QUANTITY
        '
        Me.FLD_QUANTITY.HeaderText = "QUANTITY"
        Me.FLD_QUANTITY.Name = "FLD_QUANTITY"
        Me.FLD_QUANTITY.ReadOnly = True
        '
        'FLD_PRICE
        '
        Me.FLD_PRICE.HeaderText = "SUB-TOTAL(RM)"
        Me.FLD_PRICE.Name = "FLD_PRICE"
        Me.FLD_PRICE.ReadOnly = True
        '
        'btn_invoice
        '
        Me.btn_invoice.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_invoice.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_invoice.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_invoice.Location = New System.Drawing.Point(570, 652)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(129, 44)
        Me.btn_invoice.TabIndex = 2
        Me.btn_invoice.Text = "SHOW INVOICE"
        Me.btn_invoice.UseVisualStyleBackColor = False
        '
        'frm_makeorder_a175139
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_uniquegiftshop_a175139.My.Resources.Resources.love_gifts_wallpaper
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1046, 730)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.btn_invoice)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_makeorder_a175139"
        Me.Text = "Create New Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grd_orderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_name_product As Label
    Friend WithEvents lbl_type_product As Label
    Friend WithEvents lbl_colour_product As Label
    Friend WithEvents lbl_material_product As Label
    Friend WithEvents lbl_stock_product As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_price_product As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NumericUpDown As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_make_order As Button
    Friend WithEvents lbl_orderID As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmb_customer As ComboBox
    Friend WithEvents cmb_staff As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_total_price As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents grd_orderList As DataGridView
    Friend WithEvents btn_add_cart As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_invoice As Button
    Friend WithEvents btn_confirmation As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lbl_total_cart_price As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cmb_product_id As ComboBox
    Friend WithEvents lbl_customer_name As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btn_cancel_order As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FLD_PRODUCT_ID As DataGridViewTextBoxColumn
    Friend WithEvents FLD_PRODUCT_NAME As DataGridViewTextBoxColumn
    Friend WithEvents FLD_QUANTITY As DataGridViewTextBoxColumn
    Friend WithEvents FLD_PRICE As DataGridViewTextBoxColumn
End Class
