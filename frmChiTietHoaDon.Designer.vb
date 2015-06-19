<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiTietHoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChiTietHoaDon))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbbMaSP = New System.Windows.Forms.ComboBox()
        Me.cbbMaHD = New System.Windows.Forms.ComboBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtTongTien = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnThoat6 = New System.Windows.Forms.Button()
        Me.btnXoa6 = New System.Windows.Forms.Button()
        Me.btnSua6 = New System.Windows.Forms.Button()
        Me.btnThem6 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã SP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã HD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(330, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(330, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tổng Tiền"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 4
        '
        'cbbMaSP
        '
        Me.cbbMaSP.FormattingEnabled = True
        Me.cbbMaSP.Location = New System.Drawing.Point(46, 34)
        Me.cbbMaSP.Name = "cbbMaSP"
        Me.cbbMaSP.Size = New System.Drawing.Size(170, 21)
        Me.cbbMaSP.TabIndex = 5
        '
        'cbbMaHD
        '
        Me.cbbMaHD.FormattingEnabled = True
        Me.cbbMaHD.Location = New System.Drawing.Point(50, 80)
        Me.cbbMaHD.Name = "cbbMaHD"
        Me.cbbMaHD.Size = New System.Drawing.Size(170, 21)
        Me.cbbMaHD.TabIndex = 6
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(53, 124)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(167, 22)
        Me.txtSoLuong.TabIndex = 7
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(399, 34)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(163, 22)
        Me.txtDonGia.TabIndex = 8
        '
        'txtTongTien
        '
        Me.txtTongTien.Location = New System.Drawing.Point(399, 79)
        Me.txtTongTien.Multiline = True
        Me.txtTongTien.Name = "txtTongTien"
        Me.txtTongTien.Size = New System.Drawing.Size(163, 22)
        Me.txtTongTien.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 160)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(663, 127)
        Me.DataGridView1.TabIndex = 10
        '
        'btnThoat6
        '
        Me.btnThoat6.Image = CType(resources.GetObject("btnThoat6.Image"), System.Drawing.Image)
        Me.btnThoat6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat6.Location = New System.Drawing.Point(436, 293)
        Me.btnThoat6.Name = "btnThoat6"
        Me.btnThoat6.Size = New System.Drawing.Size(75, 35)
        Me.btnThoat6.TabIndex = 16
        Me.btnThoat6.Text = "Thoát"
        Me.btnThoat6.UseVisualStyleBackColor = True
        '
        'btnXoa6
        '
        Me.btnXoa6.Image = CType(resources.GetObject("btnXoa6.Image"), System.Drawing.Image)
        Me.btnXoa6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa6.Location = New System.Drawing.Point(333, 293)
        Me.btnXoa6.Name = "btnXoa6"
        Me.btnXoa6.Size = New System.Drawing.Size(75, 35)
        Me.btnXoa6.TabIndex = 15
        Me.btnXoa6.Text = "Xóa"
        Me.btnXoa6.UseVisualStyleBackColor = True
        '
        'btnSua6
        '
        Me.btnSua6.Image = CType(resources.GetObject("btnSua6.Image"), System.Drawing.Image)
        Me.btnSua6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua6.Location = New System.Drawing.Point(181, 293)
        Me.btnSua6.Name = "btnSua6"
        Me.btnSua6.Size = New System.Drawing.Size(75, 35)
        Me.btnSua6.TabIndex = 14
        Me.btnSua6.Text = "Sửa"
        Me.btnSua6.UseVisualStyleBackColor = True
        '
        'btnThem6
        '
        Me.btnThem6.Image = CType(resources.GetObject("btnThem6.Image"), System.Drawing.Image)
        Me.btnThem6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem6.Location = New System.Drawing.Point(57, 293)
        Me.btnThem6.Name = "btnThem6"
        Me.btnThem6.Size = New System.Drawing.Size(75, 35)
        Me.btnThem6.TabIndex = 13
        Me.btnThem6.Text = "Thêm"
        Me.btnThem6.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-1, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Số lượng"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(330, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Đơn Giá"
        '
        'frmChiTietHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 340)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnThoat6)
        Me.Controls.Add(Me.btnXoa6)
        Me.Controls.Add(Me.btnSua6)
        Me.Controls.Add(Me.btnThem6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtTongTien)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.cbbMaHD)
        Me.Controls.Add(Me.cbbMaSP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmChiTietHoaDon"
        Me.Text = "Chi Tiết Hóa Đơn"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbbMaSP As System.Windows.Forms.ComboBox
    Friend WithEvents cbbMaHD As System.Windows.Forms.ComboBox
    Friend WithEvents txtSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents txtTongTien As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnThoat6 As System.Windows.Forms.Button
    Friend WithEvents btnXoa6 As System.Windows.Forms.Button
    Friend WithEvents btnSua6 As System.Windows.Forms.Button
    Friend WithEvents btnThem6 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
