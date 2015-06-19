<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLiNhanVien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLiNhanVien))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnThoat1 = New DevComponents.DotNetBar.ButtonX()
        Me.btnSua1 = New DevComponents.DotNetBar.ButtonX()
        Me.btnXoa1 = New DevComponents.DotNetBar.ButtonX()
        Me.btnThem1 = New DevComponents.DotNetBar.ButtonX()
        Me.txtTenNhanVien = New System.Windows.Forms.TextBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.txtMaNhanVien = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox1.Controls.Add(Me.btnThoat1)
        Me.GroupBox1.Controls.Add(Me.btnSua1)
        Me.GroupBox1.Controls.Add(Me.btnXoa1)
        Me.GroupBox1.Controls.Add(Me.btnThem1)
        Me.GroupBox1.Controls.Add(Me.txtTenNhanVien)
        Me.GroupBox1.Controls.Add(Me.txtMatKhau)
        Me.GroupBox1.Controls.Add(Me.txtMaNhanVien)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(-3, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 161)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thêm Thông Tin Nhân Viên"
        '
        'btnThoat1
        '
        Me.btnThoat1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnThoat1.BackColor = System.Drawing.Color.Transparent
        Me.btnThoat1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnThoat1.Image = CType(resources.GetObject("btnThoat1.Image"), System.Drawing.Image)
        Me.btnThoat1.Location = New System.Drawing.Point(539, 89)
        Me.btnThoat1.Name = "btnThoat1"
        Me.btnThoat1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.btnThoat1.Size = New System.Drawing.Size(94, 56)
        Me.btnThoat1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnThoat1.TabIndex = 10
        Me.btnThoat1.Text = "Thoát"
        '
        'btnSua1
        '
        Me.btnSua1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSua1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSua1.Image = CType(resources.GetObject("btnSua1.Image"), System.Drawing.Image)
        Me.btnSua1.Location = New System.Drawing.Point(539, 25)
        Me.btnSua1.Name = "btnSua1"
        Me.btnSua1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.btnSua1.Size = New System.Drawing.Size(94, 58)
        Me.btnSua1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSua1.TabIndex = 9
        Me.btnSua1.Text = "Sửa"
        '
        'btnXoa1
        '
        Me.btnXoa1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnXoa1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnXoa1.Image = CType(resources.GetObject("btnXoa1.Image"), System.Drawing.Image)
        Me.btnXoa1.Location = New System.Drawing.Point(414, 89)
        Me.btnXoa1.Name = "btnXoa1"
        Me.btnXoa1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.btnXoa1.Size = New System.Drawing.Size(97, 56)
        Me.btnXoa1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnXoa1.TabIndex = 8
        Me.btnXoa1.Text = "Xóa"
        '
        'btnThem1
        '
        Me.btnThem1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnThem1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnThem1.Image = CType(resources.GetObject("btnThem1.Image"), System.Drawing.Image)
        Me.btnThem1.Location = New System.Drawing.Point(414, 26)
        Me.btnThem1.Name = "btnThem1"
        Me.btnThem1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.btnThem1.Size = New System.Drawing.Size(97, 57)
        Me.btnThem1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnThem1.TabIndex = 7
        Me.btnThem1.Text = "Thêm"
        '
        'txtTenNhanVien
        '
        Me.txtTenNhanVien.Location = New System.Drawing.Point(126, 109)
        Me.txtTenNhanVien.Name = "txtTenNhanVien"
        Me.txtTenNhanVien.Size = New System.Drawing.Size(236, 22)
        Me.txtTenNhanVien.TabIndex = 6
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(124, 65)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(236, 22)
        Me.txtMatKhau.TabIndex = 5
        '
        'txtMaNhanVien
        '
        Me.txtMaNhanVien.Location = New System.Drawing.Point(124, 28)
        Me.txtMaNhanVien.Name = "txtMaNhanVien"
        Me.txtMaNhanVien.Size = New System.Drawing.Size(236, 22)
        Me.txtMaNhanVien.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mã Nhân Viên"
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
        Me.Label2.Location = New System.Drawing.Point(33, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mật Khẩu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên Nhân Viên"
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
        Me.DataGridViewX1.Location = New System.Drawing.Point(-3, 171)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.Size = New System.Drawing.Size(662, 150)
        Me.DataGridViewX1.TabIndex = 1
        '
        'frmQuanLiNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(653, 308)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuanLiNhanVien"
        Me.Text = "Quản Lí Nhân Viên"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTenNhanVien As System.Windows.Forms.TextBox
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents txtMaNhanVien As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnThoat1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSua1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnXoa1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnThem1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
End Class
