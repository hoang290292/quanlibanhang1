<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangNhap))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtTenDangNhap = New System.Windows.Forms.TextBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.btnDangNhap = New DevComponents.DotNetBar.ButtonX()
        Me.btnThoat = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(635, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.Location = New System.Drawing.Point(263, 81)
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.Size = New System.Drawing.Size(246, 22)
        Me.txtTenDangNhap.TabIndex = 3
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(263, 120)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(246, 22)
        Me.txtMatKhau.TabIndex = 4
        '
        'btnDangNhap
        '
        Me.btnDangNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDangNhap.Checked = True
        Me.btnDangNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnDangNhap.Image = CType(resources.GetObject("btnDangNhap.Image"), System.Drawing.Image)
        Me.btnDangNhap.Location = New System.Drawing.Point(199, 181)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.PopupSide = DevComponents.DotNetBar.ePopupSide.Bottom
        Me.btnDangNhap.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnDangNhap.Size = New System.Drawing.Size(143, 37)
        Me.btnDangNhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDangNhap.TabIndex = 5
        Me.btnDangNhap.Text = "Đăng Nhập"
        '
        'btnThoat
        '
        Me.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnThoat.BackColor = System.Drawing.Color.White
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnThoat.Checked = True
        Me.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.Location = New System.Drawing.Point(373, 181)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.PopupSide = DevComponents.DotNetBar.ePopupSide.Top
        Me.btnThoat.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnThoat.Size = New System.Drawing.Size(136, 37)
        Me.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnThoat.TabIndex = 6
        Me.btnThoat.Text = "Thoát"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.SystemColors.Highlight
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Firebrick
        Me.LabelX1.Location = New System.Drawing.Point(93, 81)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(130, 23)
        Me.LabelX1.TabIndex = 7
        Me.LabelX1.Text = "Tên Đăng Nhập"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.SystemColors.Highlight
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Firebrick
        Me.LabelX2.Location = New System.Drawing.Point(93, 120)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(130, 23)
        Me.LabelX2.TabIndex = 8
        Me.LabelX2.Text = "Mật Khẩu"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 262)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtTenDangNhap)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDangNhap"
        Me.Text = "Đăng Nhập"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtTenDangNhap As System.Windows.Forms.TextBox
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents btnDangNhap As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnThoat As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
