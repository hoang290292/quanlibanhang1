<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuanLiKhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQuanLiKhachHang))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSoDienThoai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnThoat = New DevComponents.DotNetBar.ButtonX()
        Me.btnSua = New DevComponents.DotNetBar.ButtonX()
        Me.btnXoa = New DevComponents.DotNetBar.ButtonX()
        Me.btnThem = New DevComponents.DotNetBar.ButtonX()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtTenKhachHang = New System.Windows.Forms.TextBox()
        Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Controls.Add(Me.txtSoDienThoai)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnThoat)
        Me.GroupBox1.Controls.Add(Me.btnSua)
        Me.GroupBox1.Controls.Add(Me.btnXoa)
        Me.GroupBox1.Controls.Add(Me.btnThem)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.txtTenKhachHang)
        Me.GroupBox1.Controls.Add(Me.txtMaKhachHang)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(-5, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 179)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thêm Thông Tin Khách Hàng"
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Location = New System.Drawing.Point(126, 147)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(236, 22)
        Me.txtSoDienThoai.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Số Điện Thoại"
        '
        'btnThoat
        '
        Me.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnThoat.BackColor = System.Drawing.Color.Transparent
        Me.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.Location = New System.Drawing.Point(539, 89)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.btnThoat.Size = New System.Drawing.Size(94, 56)
        Me.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnThoat.TabIndex = 10
        Me.btnThoat.Text = "Thoát"
        '
        'btnSua
        '
        Me.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSua.Image = CType(resources.GetObject("btnSua.Image"), System.Drawing.Image)
        Me.btnSua.Location = New System.Drawing.Point(539, 25)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.btnSua.Size = New System.Drawing.Size(94, 58)
        Me.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSua.TabIndex = 9
        Me.btnSua.Text = "Sửa"
        '
        'btnXoa
        '
        Me.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.Location = New System.Drawing.Point(414, 89)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.btnXoa.Size = New System.Drawing.Size(97, 56)
        Me.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.Text = "Xóa"
        '
        'btnThem
        '
        Me.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.Location = New System.Drawing.Point(414, 26)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.btnThem.Size = New System.Drawing.Size(97, 57)
        Me.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnThem.TabIndex = 7
        Me.btnThem.Text = "Thêm"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(126, 109)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(236, 22)
        Me.txtDiaChi.TabIndex = 6
        '
        'txtTenKhachHang
        '
        Me.txtTenKhachHang.Location = New System.Drawing.Point(124, 65)
        Me.txtTenKhachHang.Name = "txtTenKhachHang"
        Me.txtTenKhachHang.Size = New System.Drawing.Size(236, 22)
        Me.txtTenKhachHang.TabIndex = 5
        '
        'txtMaKhachHang
        '
        Me.txtMaKhachHang.Location = New System.Drawing.Point(124, 28)
        Me.txtMaKhachHang.Name = "txtMaKhachHang"
        Me.txtMaKhachHang.Size = New System.Drawing.Size(236, 22)
        Me.txtMaKhachHang.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mã Khách Hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Khách Hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Địa Chỉ"
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
        Me.DataGridViewX1.Location = New System.Drawing.Point(-5, 198)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.Size = New System.Drawing.Size(662, 150)
        Me.DataGridViewX1.TabIndex = 2
        '
        'FrmQuanLiKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 309)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmQuanLiKhachHang"
        Me.Text = "Quản Lí Khách Hàng"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSoDienThoai As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnThoat As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSua As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnXoa As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnThem As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKhachHang As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKhachHang As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
End Class
