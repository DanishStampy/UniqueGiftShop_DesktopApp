<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_splashscreen_a175139
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.prj_uniquegiftshop_a175139.My.Resources.Resources.cd39970a881e12cc55244b5ab19d62c1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(263, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 146)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 427)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(802, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 75
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.LightPink
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_exit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_exit.Location = New System.Drawing.Point(12, 12)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(33, 32)
        Me.btn_exit.TabIndex = 3
        Me.btn_exit.Text = "X"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(50, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(710, 47)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name: Danish Irfan Shah bin Muzaffar Shah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(229, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(342, 47)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Matric No.: A175139"
        '
        'frm_splashscreen_a175139
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_uniquegiftshop_a175139.My.Resources.Resources.love_gifts_wallpaper
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_splashscreen_a175139"
        Me.Text = "Unique Gift Shop"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_exit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
