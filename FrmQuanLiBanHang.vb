Public Class FrmQuanLiBanHang


    Private Sub ĐăngNhậpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ĐăngNhậpToolStripMenuItem.Click
        frmDangNhap.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThoátToolStripMenuItem.Click
        If MessageBox.Show("Are You Sure?", "Quit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub NhânViênToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NhânViênToolStripMenuItem.Click
        frmQuanLiNhanVien.Show()
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        frmQuanLiSanPham.Show()
    End Sub

    Private Sub LoạiSảnPhẩmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoạiSảnPhẩmToolStripMenuItem.Click
        FrmLoaiSP.Show()
    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KháchHàngToolStripMenuItem.Click
        FrmQuanLiKhachHang.Show()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        frmHoaDon.Show()
    End Sub

    Private Sub MặtHàngSảnPhẩmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MặtHàngSảnPhẩmToolStripMenuItem.Click
        FrmTimKiem.Show()
    End Sub

    Private Sub FrmQuanLiBanHang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChiTiếtHóaĐơnToolStripMenuItem.Click
        frmChiTietHoaDon.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class