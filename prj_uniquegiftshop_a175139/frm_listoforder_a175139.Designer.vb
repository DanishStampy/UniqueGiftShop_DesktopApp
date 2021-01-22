<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listoforder_a175139
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_listoforder_a175139))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Maroon
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btn_back.Location = New System.Drawing.Point(262, 322)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(76, 34)
        Me.btn_back.TabIndex = 4
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'grd_order
        '
        Me.grd_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grd_order.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.GridColor = System.Drawing.Color.LavenderBlush
        Me.grd_order.Location = New System.Drawing.Point(49, 72)
        Me.grd_order.Margin = New System.Windows.Forms.Padding(2)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.ReadOnly = True
        Me.grd_order.RowHeadersWidth = 51
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(503, 227)
        Me.grd_order.TabIndex = 5
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Lavender
        Me.lbl_title.Location = New System.Drawing.Point(195, 24)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(211, 39)
        Me.lbl_title.TabIndex = 6
        Me.lbl_title.Text = "LIST OF ORDERS"
        '
        'frm_listoforder_a175139
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.BackgroundImage = Global.prj_uniquegiftshop_a175139.My.Resources.Resources.love_wallpaper_20081013452726_scaled
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 375)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.btn_back)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_listoforder_a175139"
        Me.Text = "List of Orders"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents lbl_title As Label
End Class
