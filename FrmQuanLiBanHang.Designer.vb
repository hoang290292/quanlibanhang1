<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuanLiBanHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQuanLiBanHang))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HệThốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TìmKiếmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MặtHàngSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLíToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoạiSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiTiếtHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiênHệToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGray
        Me.MenuStrip1.Font = New System.Drawing.Font("Snap ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HệThốngToolStripMenuItem, Me.TìmKiếmToolStripMenuItem, Me.QuảnLíToolStripMenuItem, Me.LiênHệToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(653, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HệThốngToolStripMenuItem
        '
        Me.HệThốngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĐăngNhậpToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.HệThốngToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem"
        Me.HệThốngToolStripMenuItem.Size = New System.Drawing.Size(97, 23)
        Me.HệThốngToolStripMenuItem.Text = "Hệ Thống"
        '
        'ĐăngNhậpToolStripMenuItem
        '
        Me.ĐăngNhậpToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.ĐăngNhậpToolStripMenuItem.Name = "ĐăngNhậpToolStripMenuItem"
        Me.ĐăngNhậpToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.ĐăngNhậpToolStripMenuItem.Text = "Đăng Nhập"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'TìmKiếmToolStripMenuItem
        '
        Me.TìmKiếmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MặtHàngSảnPhẩmToolStripMenuItem})
        Me.TìmKiếmToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.TìmKiếmToolStripMenuItem.Name = "TìmKiếmToolStripMenuItem"
        Me.TìmKiếmToolStripMenuItem.Size = New System.Drawing.Size(98, 23)
        Me.TìmKiếmToolStripMenuItem.Text = "Tìm Kiếm"
        '
        'MặtHàngSảnPhẩmToolStripMenuItem
        '
        Me.MặtHàngSảnPhẩmToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.MặtHàngSảnPhẩmToolStripMenuItem.Name = "MặtHàngSảnPhẩmToolStripMenuItem"
        Me.MặtHàngSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(243, 24)
        Me.MặtHàngSảnPhẩmToolStripMenuItem.Text = "Mặt Hàng Sản Phẩm"
        '
        'QuảnLíToolStripMenuItem
        '
        Me.QuảnLíToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NhânViênToolStripMenuItem, Me.SảnPhẩmToolStripMenuItem, Me.LoạiSảnPhẩmToolStripMenuItem, Me.KháchHàngToolStripMenuItem, Me.HóaĐơnToolStripMenuItem, Me.ChiTiếtHóaĐơnToolStripMenuItem})
        Me.QuảnLíToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.QuảnLíToolStripMenuItem.Name = "QuảnLíToolStripMenuItem"
        Me.QuảnLíToolStripMenuItem.Size = New System.Drawing.Size(86, 23)
        Me.QuảnLíToolStripMenuItem.Text = "Quản Lí"
        '
        'NhânViênToolStripMenuItem
        '
        Me.NhânViênToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem"
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.NhânViênToolStripMenuItem.Text = "Nhân Viên"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.SảnPhẩmToolStripMenuItem.Text = "Sản Phẩm"
        '
        'LoạiSảnPhẩmToolStripMenuItem
        '
        Me.LoạiSảnPhẩmToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.LoạiSảnPhẩmToolStripMenuItem.Name = "LoạiSảnPhẩmToolStripMenuItem"
        Me.LoạiSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.LoạiSảnPhẩmToolStripMenuItem.Text = "Loại Sản Phẩm"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.KháchHàngToolStripMenuItem.Text = "Khách Hàng"
        '
        'HóaĐơnToolStripMenuItem
        '
        Me.HóaĐơnToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.HóaĐơnToolStripMenuItem.Name = "HóaĐơnToolStripMenuItem"
        Me.HóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.HóaĐơnToolStripMenuItem.Text = "Hóa Đơn"
        '
        'ChiTiếtHóaĐơnToolStripMenuItem
        '
        Me.ChiTiếtHóaĐơnToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.ChiTiếtHóaĐơnToolStripMenuItem.Name = "ChiTiếtHóaĐơnToolStripMenuItem"
        Me.ChiTiếtHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.ChiTiếtHóaĐơnToolStripMenuItem.Text = "Chi Tiết Hóa Đơn"
        '
        'LiênHệToolStripMenuItem
        '
        Me.LiênHệToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange
        Me.LiênHệToolStripMenuItem.Name = "LiênHệToolStripMenuItem"
        Me.LiênHệToolStripMenuItem.Size = New System.Drawing.Size(85, 23)
        Me.LiênHệToolStripMenuItem.Text = "Liên Hệ"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(653, 244)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FrmQuanLiBanHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 271)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmQuanLiBanHang"
        Me.Text = "Quản Lí Bán Hàng"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HệThốngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐăngNhậpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TìmKiếmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MặtHàngSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLíToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoạiSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LiênHệToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ChiTiếtHóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
