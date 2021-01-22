<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertstaff_a175139
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertstaff_a175139))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_insert_staff = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_age = New System.Windows.Forms.TextBox()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Maroon
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btn_back.Location = New System.Drawing.Point(295, 385)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(97, 37)
        Me.btn_back.TabIndex = 7
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'grd_staff
        '
        Me.grd_staff.AllowUserToAddRows = False
        Me.grd_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_staff.BackgroundColor = System.Drawing.SystemColors.Info
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(269, 105)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.ReadOnly = True
        Me.grd_staff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grd_staff.ShowCellErrors = False
        Me.grd_staff.Size = New System.Drawing.Size(355, 201)
        Me.grd_staff.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Snow
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(250, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 39)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CREATE STAFF"
        '
        'btn_insert_staff
        '
        Me.btn_insert_staff.BackColor = System.Drawing.Color.Maroon
        Me.btn_insert_staff.FlatAppearance.BorderSize = 0
        Me.btn_insert_staff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_insert_staff.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert_staff.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btn_insert_staff.Location = New System.Drawing.Point(65, 342)
        Me.btn_insert_staff.Name = "btn_insert_staff"
        Me.btn_insert_staff.Size = New System.Drawing.Size(110, 34)
        Me.btn_insert_staff.TabIndex = 14
        Me.btn_insert_staff.Text = "INSERT"
        Me.btn_insert_staff.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.SystemColors.Info
        Me.txt_name.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(65, 203)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(125, 29)
        Me.txt_name.TabIndex = 13
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.SystemColors.Info
        Me.txt_id.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(65, 130)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(125, 29)
        Me.txt_id.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label2.Location = New System.Drawing.Point(61, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 22)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Staff ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label3.Location = New System.Drawing.Point(61, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 22)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Staff Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label4.Location = New System.Drawing.Point(61, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 22)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Age:"
        '
        'txt_age
        '
        Me.txt_age.BackColor = System.Drawing.SystemColors.Info
        Me.txt_age.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_age.Location = New System.Drawing.Point(65, 280)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(125, 29)
        Me.txt_age.TabIndex = 18
        '
        'frm_insertstaff_a175139
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_uniquegiftshop_a175139.My.Resources.Resources._2461286afc14ea178d40a0e7b1419819
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(687, 450)
        Me.Controls.Add(Me.txt_age)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_insert_staff)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_staff)
        Me.Controls.Add(Me.btn_back)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_insertstaff_a175139"
        Me.Text = "Create New Staff"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_insert_staff As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_age As TextBox
End Class
