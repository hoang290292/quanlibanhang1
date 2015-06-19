<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLoaiSP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLoaiSP))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtMaLoaiSP = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtTenLoaiSP = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btnThem4 = New DevComponents.DotNetBar.ButtonX()
        Me.btnXoa4 = New DevComponents.DotNetBar.ButtonX()
        Me.btnSua4 = New DevComponents.DotNetBar.ButtonX()
        Me.btnThoat4 = New DevComponents.DotNetBar.ButtonX()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(9, 33)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(135, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Mã Loại Sản Phẩm"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(28, 72)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(116, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Tên Loại"
        '
        'txtMaLoaiSP
        '
        Me.txtMaLoaiSP.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtMaLoaiSP.Border.Class = "TextBoxBorder"
        Me.txtMaLoaiSP.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMaLoaiSP.ForeColor = System.Drawing.Color.Black
        Me.txtMaLoaiSP.Location = New System.Drawing.Point(163, 35)
        Me.txtMaLoaiSP.Name = "txtMaLoaiSP"
        Me.txtMaLoaiSP.Size = New System.Drawing.Size(194, 22)
        Me.txtMaLoaiSP.TabIndex = 2
        '
        'txtTenLoaiSP
        '
        Me.txtTenLoaiSP.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTenLoaiSP.Border.Class = "TextBoxBorder"
        Me.txtTenLoaiSP.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTenLoaiSP.ForeColor = System.Drawing.Color.Black
        Me.txtTenLoaiSP.Location = New System.Drawing.Point(163, 77)
        Me.txtTenLoaiSP.Name = "txtTenLoaiSP"
        Me.txtTenLoaiSP.Size = New System.Drawing.Size(194, 22)
        Me.txtTenLoaiSP.TabIndex = 3
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
        Me.DataGridViewX1.Location = New System.Drawing.Point(-5, 110)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.Size = New System.Drawing.Size(625, 128)
        Me.DataGridViewX1.TabIndex = 4
        '
        'btnThem4
        '
        Me.btnThem4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnThem4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnThem4.Image = CType(resources.GetObject("btnThem4.Image"), System.Drawing.Image)
        Me.btnThem4.Location = New System.Drawing.Point(12, 244)
        Me.btnThem4.Name = "btnThem4"
        Me.btnThem4.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.btnThem4.Size = New System.Drawing.Size(85, 48)
        Me.btnThem4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnThem4.TabIndex = 5
        Me.btnThem4.Text = "Thêm"
        '
        'btnXoa4
        '
        Me.btnXoa4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnXoa4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnXoa4.Image = CType(resources.GetObject("btnXoa4.Image"), System.Drawing.Image)
        Me.btnXoa4.Location = New System.Drawing.Point(146, 244)
        Me.btnXoa4.Name = "btnXoa4"
        Me.btnXoa4.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.btnXoa4.Size = New System.Drawing.Size(85, 48)
        Me.btnXoa4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnXoa4.TabIndex = 6
        Me.btnXoa4.Text = "Xóa"
        '
        'btnSua4
        '
        Me.btnSua4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSua4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSua4.Image = CType(resources.GetObject("btnSua4.Image"), System.Drawing.Image)
        Me.btnSua4.Location = New System.Drawing.Point(278, 244)
        Me.btnSua4.Name = "btnSua4"
        Me.btnSua4.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.btnSua4.Size = New System.Drawing.Size(79, 48)
        Me.btnSua4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSua4.TabIndex = 7
        Me.btnSua4.Text = "Sửa"
        '
        'btnThoat4
        '
        Me.btnThoat4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnThoat4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnThoat4.Image = CType(resources.GetObject("btnThoat4.Image"), System.Drawing.Image)
        Me.btnThoat4.Location = New System.Drawing.Point(431, 244)
        Me.btnThoat4.Name = "btnThoat4"
        Me.btnThoat4.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12)
        Me.btnThoat4.Size = New System.Drawing.Size(81, 48)
        Me.btnThoat4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnThoat4.TabIndex = 8
        Me.btnThoat4.Text = "Thoát"
        '
        'FrmLoaiSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 295)
        Me.Controls.Add(Me.btnThoat4)
        Me.Controls.Add(Me.btnSua4)
        Me.Controls.Add(Me.btnXoa4)
        Me.Controls.Add(Me.btnThem4)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.txtTenLoaiSP)
        Me.Controls.Add(Me.txtMaLoaiSP)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmLoaiSP"
        Me.Text = "Loại Sản Phẩm"
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMaLoaiSP As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtTenLoaiSP As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnThem4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnXoa4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSua4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnThoat4 As DevComponents.DotNetBar.ButtonX
End Class
