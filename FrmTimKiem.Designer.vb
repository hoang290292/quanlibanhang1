<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTimKiem
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnTimKiem = New DevComponents.DotNetBar.ButtonX()
        Me.txtTimKiem = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.dgvTimKIem = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btnTroVe = New DevComponents.DotNetBar.ButtonX()
        CType(Me.dgvTimKIem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTimKiem
        '
        Me.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnTimKiem.BackColor = System.Drawing.Color.LightGray
        Me.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnTimKiem.Location = New System.Drawing.Point(431, 13)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnTimKiem.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(14)
        Me.btnTimKiem.Size = New System.Drawing.Size(94, 23)
        Me.btnTimKiem.SplitButton = True
        Me.btnTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnTimKiem.Symbol = ""
        Me.btnTimKiem.TabIndex = 0
        Me.btnTimKiem.Text = "Tìm Kiếm"
        Me.btnTimKiem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.btnTimKiem.TextColor = System.Drawing.Color.Red
        '
        'txtTimKiem
        '
        Me.txtTimKiem.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTimKiem.Border.Class = "TextBoxBorder"
        Me.txtTimKiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTimKiem.ForeColor = System.Drawing.Color.Black
        Me.txtTimKiem.Location = New System.Drawing.Point(93, 13)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(307, 22)
        Me.txtTimKiem.TabIndex = 1
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 10)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Từ Tìm:"
        '
        'dgvTimKIem
        '
        Me.dgvTimKIem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTimKIem.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTimKIem.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgvTimKIem.Location = New System.Drawing.Point(-2, 81)
        Me.dgvTimKIem.Name = "dgvTimKIem"
        Me.dgvTimKIem.Size = New System.Drawing.Size(697, 173)
        Me.dgvTimKIem.TabIndex = 5
        '
        'btnTroVe
        '
        Me.btnTroVe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnTroVe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnTroVe.Location = New System.Drawing.Point(577, 12)
        Me.btnTroVe.Name = "btnTroVe"
        Me.btnTroVe.Size = New System.Drawing.Size(86, 23)
        Me.btnTroVe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnTroVe.Symbol = ""
        Me.btnTroVe.TabIndex = 6
        Me.btnTroVe.Text = "Trở Về"
        Me.btnTroVe.TextColor = System.Drawing.Color.SandyBrown
        '
        'FrmTimKiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 252)
        Me.Controls.Add(Me.btnTroVe)
        Me.Controls.Add(Me.dgvTimKIem)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.btnTimKiem)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmTimKiem"
        Me.Text = "Tìm Kiếm"
        CType(Me.dgvTimKIem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTimKiem As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtTimKiem As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgvTimKIem As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnTroVe As DevComponents.DotNetBar.ButtonX
End Class
