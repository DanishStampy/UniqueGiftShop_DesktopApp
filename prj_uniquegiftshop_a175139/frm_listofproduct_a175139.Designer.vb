<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listofproduct_a175139
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_listofproduct_a175139))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Maroon
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btn_back.Location = New System.Drawing.Point(298, 385)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(70, 37)
        Me.btn_back.TabIndex = 3
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'grd_product
        '
        Me.grd_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grd_product.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.GridColor = System.Drawing.Color.LavenderBlush
        Me.grd_product.Location = New System.Drawing.Point(9, 72)
        Me.grd_product.Margin = New System.Windows.Forms.Padding(2)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.ReadOnly = True
        Me.grd_product.RowHeadersWidth = 51
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(650, 295)
        Me.grd_product.TabIndex = 4
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Lavender
        Me.lbl_title.Location = New System.Drawing.Point(210, 28)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(248, 39)
        Me.lbl_title.TabIndex = 5
        Me.lbl_title.Text = "LIST OF PRODUCTS"
        '
        'frm_listofproduct_a175139
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.BackgroundImage = Global.prj_uniquegiftshop_a175139.My.Resources.Resources.love_wallpaper_20081013452726_scaled
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(668, 448)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.btn_back)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_listofproduct_a175139"
        Me.Text = "List of Products"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents grd_product As DataGridView
    Friend WithEvents lbl_title As Label
End Class
