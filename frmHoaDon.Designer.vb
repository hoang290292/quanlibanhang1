<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoaDon))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtMaHD = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNgayLap = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnThem5 = New System.Windows.Forms.Button()
        Me.btnSua5 = New System.Windows.Forms.Button()
        Me.btnXoa5 = New System.Windows.Forms.Button()
        Me.btnThoat5 = New System.Windows.Forms.Button()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.cbbMaNV = New System.Windows.Forms.ComboBox()
        Me.cbbMaKH = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(0, 39)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Mã HD"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(0, 84)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Ngày Lập"
        '
        'txtMaHD
        '
        Me.txtMaHD.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtMaHD.Border.Class = "TextBoxBorder"
        Me.txtMaHD.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMaHD.ForeColor = System.Drawing.Color.Black
        Me.txtMaHD.Location = New System.Drawing.Point(59, 41)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(183, 22)
        Me.txtMaHD.TabIndex = 4
        '
        'txtNgayLap
        '
        Me.txtNgayLap.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNgayLap.Border.Class = "TextBoxBorder"
        Me.txtNgayLap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNgayLap.ForeColor = System.Drawing.Color.Black
        Me.txtNgayLap.Location = New System.Drawing.Point(59, 85)
        Me.txtNgayLap.Name = "txtNgayLap"
        Me.txtNgayLap.Size = New System.Drawing.Size(183, 22)
        Me.txtNgayLap.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-7, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(584, 130)
        Me.DataGridView1.TabIndex = 8
        '
        'btnThem5
        '
        Me.btnThem5.Image = CType(resources.GetObject("btnThem5.Image"), System.Drawing.Image)
        Me.btnThem5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem5.Location = New System.Drawing.Point(59, 266)
        Me.btnThem5.Name = "btnThem5"
        Me.btnThem5.Size = New System.Drawing.Size(75, 35)
        Me.btnThem5.TabIndex = 9
        Me.btnThem5.Text = "Thêm"
        Me.btnThem5.UseVisualStyleBackColor = True
        '
        'btnSua5
        '
        Me.btnSua5.Image = CType(resources.GetObject("btnSua5.Image"), System.Drawing.Image)
        Me.btnSua5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua5.Location = New System.Drawing.Point(167, 266)
        Me.btnSua5.Name = "btnSua5"
        Me.btnSua5.Size = New System.Drawing.Size(75, 35)
        Me.btnSua5.TabIndex = 10
        Me.btnSua5.Text = "Sửa"
        Me.btnSua5.UseVisualStyleBackColor = True
        '
        'btnXoa5
        '
        Me.btnXoa5.Image = CType(resources.GetObject("btnXoa5.Image"), System.Drawing.Image)
        Me.btnXoa5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa5.Location = New System.Drawing.Point(288, 266)
        Me.btnXoa5.Name = "btnXoa5"
        Me.btnXoa5.Size = New System.Drawing.Size(75, 35)
        Me.btnXoa5.TabIndex = 11
        Me.btnXoa5.Text = "Xóa"
        Me.btnXoa5.UseVisualStyleBackColor = True
        '
        'btnThoat5
        '
        Me.btnThoat5.Image = CType(resources.GetObject("btnThoat5.Image"), System.Drawing.Image)
        Me.btnThoat5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat5.Location = New System.Drawing.Point(394, 266)
        Me.btnThoat5.Name = "btnThoat5"
        Me.btnThoat5.Size = New System.Drawing.Size(75, 35)
        Me.btnThoat5.TabIndex = 12
        Me.btnThoat5.Text = "Thoát"
        Me.btnThoat5.UseVisualStyleBackColor = True
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(258, 38)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 13
        Me.LabelX2.Text = "Mã NV"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(258, 85)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 14
        Me.LabelX4.Text = "Mã KH"
        '
        'cbbMaNV
        '
        Me.cbbMaNV.FormattingEnabled = True
        Me.cbbMaNV.Location = New System.Drawing.Point(305, 39)
        Me.cbbMaNV.Name = "cbbMaNV"
        Me.cbbMaNV.Size = New System.Drawing.Size(176, 21)
        Me.cbbMaNV.TabIndex = 15
        '
        'cbbMaKH
        '
        Me.cbbMaKH.FormattingEnabled = True
        Me.cbbMaKH.Location = New System.Drawing.Point(305, 84)
        Me.cbbMaKH.Name = "cbbMaKH"
        Me.cbbMaKH.Size = New System.Drawing.Size(176, 21)
        Me.cbbMaKH.TabIndex = 16
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 313)
        Me.Controls.Add(Me.cbbMaKH)
        Me.Controls.Add(Me.cbbMaNV)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.btnThoat5)
        Me.Controls.Add(Me.btnXoa5)
        Me.Controls.Add(Me.btnSua5)
        Me.Controls.Add(Me.btnThem5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtNgayLap)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmHoaDon"
        Me.Text = "Hóa Đơn"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMaHD As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNgayLap As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnThem5 As System.Windows.Forms.Button
    Friend WithEvents btnSua5 As System.Windows.Forms.Button
    Friend WithEvents btnXoa5 As System.Windows.Forms.Button
    Friend WithEvents btnThoat5 As System.Windows.Forms.Button
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbbMaNV As System.Windows.Forms.ComboBox
    Friend WithEvents cbbMaKH As System.Windows.Forms.ComboBox
End Class
