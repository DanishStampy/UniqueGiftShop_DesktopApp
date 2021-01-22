<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertcustomer_a175139
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertcustomer_a175139))
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.btn_insert_customer = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_customer
        '
        Me.grd_customer.AllowUserToAddRows = False
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_customer.BackgroundColor = System.Drawing.SystemColors.Info
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(278, 105)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.ReadOnly = True
        Me.grd_customer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grd_customer.ShowCellErrors = False
        Me.grd_customer.Size = New System.Drawing.Size(317, 201)
        Me.grd_customer.TabIndex = 0
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lbl_id.Location = New System.Drawing.Point(61, 103)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(111, 22)
        Me.lbl_id.TabIndex = 1
        Me.lbl_id.Text = "Customer ID:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lbl_name.Location = New System.Drawing.Point(61, 184)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(136, 22)
        Me.lbl_name.TabIndex = 2
        Me.lbl_name.Text = "Customer Name:"
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.SystemColors.Info
        Me.txt_id.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(65, 128)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(125, 29)
        Me.txt_id.TabIndex = 3
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.SystemColors.Info
        Me.txt_name.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(65, 209)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(125, 29)
        Me.txt_name.TabIndex = 4
        '
        'btn_insert_customer
        '
        Me.btn_insert_customer.BackColor = System.Drawing.Color.Maroon
        Me.btn_insert_customer.FlatAppearance.BorderSize = 0
        Me.btn_insert_customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_insert_customer.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert_customer.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btn_insert_customer.Location = New System.Drawing.Point(65, 269)
        Me.btn_insert_customer.Name = "btn_insert_customer"
        Me.btn_insert_customer.Size = New System.Drawing.Size(110, 34)
        Me.btn_insert_customer.TabIndex = 5
        Me.btn_insert_customer.Text = "INSERT"
        Me.btn_insert_customer.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Maroon
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btn_back.Location = New System.Drawing.Point(300, 336)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(97, 37)
        Me.btn_back.TabIndex = 6
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Snow
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(218, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CREATE CUSTOMER"
        '
        'frm_insertcustomer_a175139
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_uniquegiftshop_a175139.My.Resources.Resources._2461286afc14ea178d40a0e7b1419819
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(687, 413)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_insert_customer)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.grd_customer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_insertcustomer_a175139"
        Me.Text = "Create New Customer"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents btn_insert_customer As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents Label1 As Label
End Class
