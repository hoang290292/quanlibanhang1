Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmQuanLiKhachHang
    Dim database As New DataTable
    Dim chuoiketnoi As String = " workstation id=ps00481.mssql.somee.com;packet size=4096;user id=Hoangfpoly92_SQLLogin_1;pwd=tmqij74pf6;data source=ps00481.mssql.somee.com;persist security info=False;initial catalog=ps00481"


    Private Sub FrmQuanLiKhachHang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter(" select * from KhachHang", ketnoi)
        ketnoi.Open()
        Query1.Fill(database)
        DataGridViewX1.DataSource = database.DefaultView

    End Sub

    Private Sub DataGridViewX1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick
        Dim index As Integer = DataGridViewX1.CurrentCell.RowIndex
        txtMaKhachHang.Text = DataGridViewX1.Item(0, index).Value
        txtTenKhachHang.Text = DataGridViewX1.Item(1, index).Value
        txtDiaChi.Text = DataGridViewX1.Item(2, index).Value
        txtSoDienThoai.Text = DataGridViewX1.Item(3, index).Value
    End Sub
  

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Query2 As String = " insert into KhachHang values (@MaKH,@TenKH,@DiaChi,@DienThoai)"
        Dim ExecuteQuery1 As New SqlCommand(Query2, ketnoi)
        ketnoi.Open()
        Try

            ExecuteQuery1.Parameters.AddWithValue("@MaKH", txtMaKhachHang.Text)
            ExecuteQuery1.Parameters.AddWithValue("@TenKH", txtTenKhachHang.Text)
            ExecuteQuery1.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
            ExecuteQuery1.Parameters.AddWithValue("@DienThoai", txtSoDienThoai.Text)


            MessageBox.Show("Thêm thành công")
            ExecuteQuery1.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Không thêm được!")

        End Try

        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", ketnoi)
        database.Clear()

        Query3.Fill(database)
        DataGridViewX1.DataSource = database.DefaultView

        loaddata()
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim xoa As String = "Delete from KhachHang Where MaKH = @MaKH"
        Dim lenh As New SqlCommand(xoa, ketnoi)
        Try
            lenh.Parameters.AddWithValue("@MaKH", txtMaKhachHang.Text)
            lenh.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xoá  thành công")
        Catch ex As Exception
            MessageBox.Show("Xoá không thành công")
        End Try
        database.Clear()
        DataGridViewX1.DataSource = database
        DataGridViewX1.DataSource = Nothing
        loaddata()
    End Sub
    Private Sub loaddata()
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", ketnoi)

        ketnoi.Open()
        Query1.Fill(database)
        DataGridViewX1.DataSource = database.DefaultView
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Dim ketnoi1 As New SqlConnection(chuoiketnoi)
        ketnoi1.Open()
        Dim fix As String = " Update KhachHang set DienThoai = @DienThoai,DiaChi = @DiaChi,TenKH = @TenKH where MaKH = @MaKH"
        Dim com As New SqlCommand(fix, ketnoi1)
        Try
            com.Parameters.AddWithValue("@MaKH", txtMaKhachHang.Text)
            com.Parameters.AddWithValue("@TenKH", txtTenKhachHang.Text)
            com.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
            com.Parameters.AddWithValue("@DienThoai", txtSoDienThoai.Text)
            com.ExecuteNonQuery()
            ketnoi1.Close()
            MessageBox.Show(" Sua Thanh Cong ")
        Catch ex As Exception
            MessageBox.Show(" Sua ko  Thanh Cong ")
        End Try
        database.Clear()
        DataGridViewX1.DataSource = database
        DataGridViewX1.DataSource = Nothing
        loaddata()
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        FrmQuanLiBanHang.Show()
        Me.Hide()
    End Sub
End Class