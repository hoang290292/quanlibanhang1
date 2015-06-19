<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLiSanPham
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLiSanPham))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaSanPham = New System.Windows.Forms.TextBox()
        Me.txtTenSanPham = New System.Windows.Forms.TextBox()
        Me.txtChiTietSP = New System.Windows.Forms.TextBox()
        Me.cbbMaLoaiSP = New System.Windows.Forms.ComboBox()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnXoa3 = New DevComponents.DotNetBar.ButtonX()
        Me.btnThoat3 = New DevComponents.DotNetBar.ButtonX()
        Me.btnSua3 = New DevComponents.DotNetBar.ButtonX()
        Me.btnThem3 = New DevComponents.DotNetBar.ButtonX()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-4, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sản Phẩm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-4, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Sản Phẩm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Chi Tiết SP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(302, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mã Loại Sản Phẩm"
        '
        'txtMaSanPham
        '
        Me.txtMaSanPham.Location = New System.Drawing.Point(85, 36)
        Me.txtMaSanPham.Name = "txtMaSanPham"
        Me.txtMaSanPham.Size = New System.Drawing.Size(185, 22)
        Me.txtMaSanPham.TabIndex = 6
        '
        'txtTenSanPham
        '
        Me.txtTenSanPham.Location = New System.Drawing.Point(85, 80)
        Me.txtTenSanPham.Name = "txtTenSanPham"
        Me.txtTenSanPham.Size = New System.Drawing.Size(185, 22)
        Me.txtTenSanPham.TabIndex = 8
        '
        'txtChiTietSP
        '
        Me.txtChiTietSP.Location = New System.Drawing.Point(85, 126)
        Me.txtChiTietSP.Name = "txtChiTietSP"
        Me.txtChiTietSP.Size = New System.Drawing.Size(185, 22)
        Me.txtChiTietSP.TabIndex = 10
        '
        'cbbMaLoaiSP
        '
        Me.cbbMaLoaiSP.FormattingEnabled = True
        Me.cbbMaLoaiSP.Location = New System.Drawing.Point(417, 37)
        Me.cbbMaLoaiSP.Name = "cbbMaLoaiSP"
        Me.cbbMaLoaiSP.Size = New System.Drawing.Size(185, 21)
        Me.cbbMaLoaiSP.TabIndex = 11
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(-1, 153)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.Size = New System.Drawing.Size(412, 132)
        Me.DataGridViewX1.TabIndex = 12
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnXoa3)
        Me.GroupPanel1.Controls.Add(Me.btnThoat3)
        Me.GroupPanel1.Controls.Add(Me.btnSua3)
        Me.GroupPanel1.Controls.Add(Me.btnThem3)
        Me.GroupPanel1.Location = New System.Drawing.Point(417, 154)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(270, 131)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 13
        '
        'btnXoa3
        '
        Me.btnXoa3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnXoa3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnXoa3.Location = New System.Drawing.Point(132, 19)
        Me.btnXoa3.Name = "btnXoa3"
        Me.btnXoa3.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.btnXoa3.Size = New System.Drawing.Size(91, 36)
        Me.btnXoa3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnXoa3.TabIndex = 14
        Me.btnXoa3.Text = "Xóa"
        '
        'btnThoat3
        '
        Me.btnThoat3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnThoat3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnThoat3.Image = CType(resources.GetObject("btnThoat3.Image"), System.Drawing.Image)
        Me.btnThoat3.Location = New System.Drawing.Point(132, 72)
        Me.btnThoat3.Name = "btnThoat3"
        Me.btnThoat3.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.btnThoat3.Size = New System.Drawing.Size(91, 36)
        Me.btnThoat3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnThoat3.TabIndex = 3
        Me.btnThoat3.Text = "Thoát"
        '
        'btnSua3
        '
        Me.btnSua3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSua3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSua3.Image = CType(resources.GetObject("btnSua3.Image"), System.Drawing.Image)
        Me.btnSua3.Location = New System.Drawing.Point(15, 72)
        Me.btnSua3.Name = "btnSua3"
        Me.btnSua3.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.btnSua3.Size = New System.Drawing.Size(95, 36)
        Me.btnSua3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSua3.TabIndex = 2
        Me.btnSua3.Text = "Sửa"
        '
        'btnThem3
        '
        Me.btnThem3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnThem3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnThem3.Image = CType(resources.GetObject("btnThem3.Image"), System.Drawing.Image)
        Me.btnThem3.Location = New System.Drawing.Point(15, 19)
        Me.btnThem3.Name = "btnThem3"
        Me.btnThem3.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.btnThem3.Size = New System.Drawing.Size(95, 36)
        Me.btnThem3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnThem3.TabIndex = 0
        Me.btnThem3.Text = "Thêm"
        '
        'frmQuanLiSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 289)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.cbbMaLoaiSP)
        Me.Controls.Add(Me.txtChiTietSP)
        Me.Controls.Add(Me.txtTenSanPham)
        Me.Controls.Add(Me.txtMaSanPham)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmQuanLiSanPham"
        Me.Text = "Quản Lí Sản Phẩm"
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMaSanPham As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSanPham As System.Windows.Forms.TextBox
    Friend WithEvents txtChiTietSP As System.Windows.Forms.TextBox
    Friend WithEvents cbbMaLoaiSP As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnThem3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnThoat3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSua3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnXoa3 As DevComponents.DotNetBar.ButtonX
End Class
