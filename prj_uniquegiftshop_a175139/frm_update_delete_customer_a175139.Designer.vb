<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_update_delete_customer_a175139
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_update_delete_customer_a175139))
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_customer
        '
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_customer.BackgroundColor = System.Drawing.SystemColors.Info
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(278, 105)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.Size = New System.Drawing.Size(317, 201)
        Me.grd_customer.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Snow
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(235, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 39)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "EDIT CUSTOMER"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Maroon
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btn_back.Location = New System.Drawing.Point(300, 336)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(97, 37)
        Me.btn_back.TabIndex = 9
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.SystemColors.Info
        Me.txt_name.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(31, 211)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(125, 33)
        Me.txt_name.TabIndex = 13
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.SystemColors.Info
        Me.txt_id.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(31, 130)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(125, 33)
        Me.txt_id.TabIndex = 12
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lbl_name.Location = New System.Drawing.Point(27, 186)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(164, 26)
        Me.lbl_name.TabIndex = 11
        Me.lbl_name.Text = "Customer Name:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lbl_id.Location = New System.Drawing.Point(27, 105)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(133, 26)
        Me.lbl_id.TabIndex = 10
        Me.lbl_id.Text = "Customer ID:"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Maroon
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_update.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btn_update.Location = New System.Drawing.Point(32, 281)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(97, 37)
        Me.btn_update.TabIndex = 14
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Maroon
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_delete.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btn_delete.Location = New System.Drawing.Point(135, 281)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(97, 37)
        Me.btn_delete.TabIndex = 15
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'frm_update_delete_customer_a175139
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_uniquegiftshop_a175139.My.Resources.Resources._2461286afc14ea178d40a0e7b1419819
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(687, 413)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_customer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_update_delete_customer_a175139"
        Me.Text = "Edit Customer Information"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
End Class
