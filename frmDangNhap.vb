Imports System.Data.SqlClient
Public Class frmDangNhap

    Private Sub frmDangNhap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDangNhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDangNhap.Click


        Dim chuoiketnoi As String = " workstation id=ps00481.mssql.somee.com;packet size=4096;user id=Hoangfpoly92_SQLLogin_1;pwd=tmqij74pf6;data source=ps00481.mssql.somee.com;persist security info=False;initial catalog=ps00481"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where TenNV='" & txtTenDangNhap.Text & "' and MatKhau='" & txtMatKhau.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("ket nối thành công")
                FrmQuanLiBanHang.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai Tai Khoan hoac Mat Khau")
            End If

        Catch ex As Exception



        End Try

    End Sub
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        If MessageBox.Show("Are You Sure?", "Quit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()

       
        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class