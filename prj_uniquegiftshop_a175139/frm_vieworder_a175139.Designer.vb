<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_vieworder_a175139
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_vieworder_a175139))
        Me.cmb_order_ID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_customerID = New System.Windows.Forms.TextBox()
        Me.tb_staffID = New System.Windows.Forms.TextBox()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.lbl_orderID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_totalPrice = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_order_date = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_order_ID
        '
        Me.cmb_order_ID.BackColor = System.Drawing.SystemColors.Info
        Me.cmb_order_ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_order_ID.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_order_ID.ForeColor = System.Drawing.Color.DarkRed
        Me.cmb_order_ID.FormattingEnabled = True
        Me.cmb_order_ID.Location = New System.Drawing.Point(414, 341)
        Me.cmb_order_ID.Name = "cmb_order_ID"
        Me.cmb_order_ID.Size = New System.Drawing.Size(121, 34)
        Me.cmb_order_ID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightPink
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(306, 341)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightPink
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(350, 401)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Staff ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightPink
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(88, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Customer ID:"
        '
        'tb_customerID
        '
        Me.tb_customerID.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_customerID.ForeColor = System.Drawing.Color.DarkRed
        Me.tb_customerID.Location = New System.Drawing.Point(218, 398)
        Me.tb_customerID.Name = "tb_customerID"
        Me.tb_customerID.ReadOnly = True
        Me.tb_customerID.Size = New System.Drawing.Size(100, 29)
        Me.tb_customerID.TabIndex = 4
        '
        'tb_staffID
        '
        Me.tb_staffID.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_staffID.ForeColor = System.Drawing.Color.DarkRed
        Me.tb_staffID.Location = New System.Drawing.Point(437, 398)
        Me.tb_staffID.Name = "tb_staffID"
        Me.tb_staffID.ReadOnly = True
        Me.tb_staffID.Size = New System.Drawing.Size(100, 29)
        Me.tb_staffID.TabIndex = 5
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_order.BackgroundColor = System.Drawing.SystemColors.Info
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(31, 469)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.ReadOnly = True
        Me.grd_order.Size = New System.Drawing.Size(777, 194)
        Me.grd_order.TabIndex = 6
        '
        'lbl_orderID
        '
        Me.lbl_orderID.AutoSize = True
        Me.lbl_orderID.BackColor = System.Drawing.Color.LightPink
        Me.lbl_orderID.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderID.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_orderID.Location = New System.Drawing.Point(62, 436)
        Me.lbl_orderID.Name = "lbl_orderID"
        Me.lbl_orderID.Size = New System.Drawing.Size(35, 26)
        Me.lbl_orderID.TabIndex = 8
        Me.lbl_orderID.Text = "ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightPink
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(561, 678)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 26)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total Price:"
        '
        'lbl_totalPrice
        '
        Me.lbl_totalPrice.AutoSize = True
        Me.lbl_totalPrice.BackColor = System.Drawing.Color.LightPink
        Me.lbl_totalPrice.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalPrice.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_totalPrice.Location = New System.Drawing.Point(678, 678)
        Me.lbl_totalPrice.Name = "lbl_totalPrice"
        Me.lbl_totalPrice.Size = New System.Drawing.Size(60, 26)
        Me.lbl_totalPrice.TabIndex = 10
        Me.lbl_totalPrice.Text = "RM 0"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_back.Location = New System.Drawing.Point(367, 732)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(107, 42)
        Me.btn_back.TabIndex = 11
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(367, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 28)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "INVOICE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightPink
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(-2, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 46)
        Me.Panel1.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightPink
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(575, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 22)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Order's Date:"
        '
        'lbl_order_date
        '
        Me.lbl_order_date.AutoSize = True
        Me.lbl_order_date.BackColor = System.Drawing.Color.LightPink
        Me.lbl_order_date.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_date.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_order_date.Location = New System.Drawing.Point(702, 401)
        Me.lbl_order_date.Name = "lbl_order_date"
        Me.lbl_order_date.Size = New System.Drawing.Size(42, 22)
        Me.lbl_order_date.TabIndex = 15
        Me.lbl_order_date.Text = "Date"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.prj_uniquegiftshop_a175139.My.Resources.Resources.cd39970a881e12cc55244b5ab19d62c1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(328, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 111)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(234, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(372, 28)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Tel: +60123631097   Fax: 03-123456789"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(306, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(229, 28)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "secret3321@gmail.com"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(295, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(250, 28)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "No 8-A, Jalan Kristal J7/J"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Front Page Neue", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(377, 269)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 20)
        Me.Label10.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(226, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(388, 28)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Seksyen 7, 40000 Shah Alam, Selangor"
        '
        'frm_vieworder_a175139
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_uniquegiftshop_a175139.My.Resources.Resources.love_gifts_wallpaper
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(841, 784)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_order_date)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_totalPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_orderID)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.tb_staffID)
        Me.Controls.Add(Me.tb_customerID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_order_ID)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_vieworder_a175139"
        Me.Text = "Invoice"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_order_ID As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_customerID As TextBox
    Friend WithEvents tb_staffID As TextBox
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents lbl_orderID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_totalPrice As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_order_date As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
