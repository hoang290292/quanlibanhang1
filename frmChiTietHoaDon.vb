Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmChiTietHoaDon
    Dim database As New DataTable
    Dim chuoiketnoi As String = " workstation id=ps00481.mssql.somee.com;packet size=4096;user id=Hoangfpoly92_SQLLogin_1;pwd=tmqij74pf6;data source=ps00481.mssql.somee.com;persist security info=False;initial catalog=ps00481"
 

    Private Sub frmChiTietHoaDon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from ChiTietHoaDon", ketnoi)
        'Kết nối mở ra
        ketnoi.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview
        DataGridView1.DataSource = database.DefaultView
        LoadCombobox()
        LoadCombobox1()
    End Sub
    Public Sub LoadCombobox()
        Dim db As New DataTable
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim Query1 As String = " select MaSP from SanPham"
        Dim cmd As SqlCommand = New SqlCommand(Query1, ketnoi)
        cmd.CommandType = CommandType.Text
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        da.Fill(db)
        cbbMaSP.DataSource = db
        cbbMaSP.DisplayMember = "MaSP"

    End Sub
    Public Sub LoadCombobox1()
        Dim db1 As New DataTable
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim Query2 As String = " select MaHD from HoaDon"
        Dim cmd1 As SqlCommand = New SqlCommand(Query2, ketnoi)
        cmd1.CommandType = CommandType.Text
        Dim da1 As SqlDataAdapter = New SqlDataAdapter(cmd1)
        da1.Fill(db1)
        cbbMaHD.DataSource = db1
        cbbMaHD.DisplayMember = "MaHD"


        ketnoi.Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtSoLuong.Text = DataGridView1.Item(0, index).Value
        cbbMaSP.Text = DataGridView1.Item(1, index).Value
        cbbMaHD.Text = DataGridView1.Item(2, index).Value
        txtDonGia.Text = DataGridView1.Item(3, index).Value
        txtTongTien.Text = DataGridView1.Item(4, index).Value
    End Sub

    Private Sub btnThem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem6.Click

        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)

        Dim Query2 As String = "insert into ChiTietHoaDon values (@SoLuong,@SanPham_MaSP,@HoaDon_MaHD,@DonGia,@ThanhTien)"

        Dim ExecuteQuery1 As New SqlCommand(Query2, ketnoi)

        ketnoi.Open()


        Try

            ExecuteQuery1.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
            ExecuteQuery1.Parameters.AddWithValue("@SanPham_MaSP", cbbMaSP.Text)
            ExecuteQuery1.Parameters.AddWithValue("@HoaDon_MaHD", cbbMaHD.Text)
            ExecuteQuery1.Parameters.AddWithValue("@DonGia", txtDonGia.Text)
            Dim DonGia As Integer = Convert.ToInt32(txtDonGia.Text)
            Dim SoLuong As Integer = Convert.ToInt32(txtSoLuong.Text)

            Dim TongTien As Integer = DonGia * SoLuong
            txtTongTien.Text = TongTien.ToString()
            ExecuteQuery1.Parameters.AddWithValue("@ThanhTien", txtTongTien.Text)


            MessageBox.Show("Thêm thành công")
            ExecuteQuery1.ExecuteNonQuery()
        Catch ex As Exception

            MessageBox.Show("Không thêm được!")

        End Try

        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from ChiTietHoaDon", ketnoi)
        database.Clear()

        Query3.Fill(database)
        DataGridView1.DataSource = database.DefaultView


    End Sub

    Private Sub btnSua6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua6.Click
        Dim ketnoi1 As New SqlConnection(chuoiketnoi)
        ketnoi1.Open()
        Dim fix As String = " Update ChiTietHoaDon set SoLuong = @SoLuong,DonGia = @DonGia,ThanhTien=@ThanhTien,HoaDon_MaHD=@HoaDon_MaHD where SanPham_MaSP = @SanPham_MaSP"
        Dim com As New SqlCommand(fix, ketnoi1)
        Try
            com.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
            com.Parameters.AddWithValue("@SanPham_MaSP", cbbMaSP.Text)
            com.Parameters.AddWithValue("@HoaDon_MaHD", cbbMaHD.Text)
            com.Parameters.AddWithValue("@DonGia", txtDonGia.Text)


            Dim DonGia As Integer = Convert.ToInt32(txtDonGia.Text)
            Dim SoLuong As Integer = Convert.ToInt32(txtSoLuong.Text)

            Dim TongTien As Integer = DonGia * SoLuong
            txtTongTien.Text = TongTien.ToString()
            com.Parameters.AddWithValue("@ThanhTien", txtTongTien.Text)

            com.ExecuteNonQuery()
            ketnoi1.Close()
            MessageBox.Show(" Sua Thanh Cong ")
        Catch ex As Exception
            MessageBox.Show(" Sua ko  Thanh Cong ")
        End Try
        database.Clear()
        DataGridView1.DataSource = database
        DataGridView1.DataSource = Nothing

        Loaddata()

     

    End Sub
    Private Sub Loaddata()
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from ChiTietHoaDon", ketnoi)

        ketnoi.Open()
        Query1.Fill(database)
        DataGridView1.DataSource = database.DefaultView
    End Sub

    Private Sub btnXoa6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa6.Click
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim xoal As String = "Delete from ChiTietHoaDon Where SanPham_MaSP = @SanPham_MaSP"
        Dim lenh As New SqlCommand(xoal, ketnoi)
        Try
            lenh.Parameters.AddWithValue("@SanPham_MaSP", cbbMaSP.Text)
            lenh.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xoá  thành công")
        Catch ex As Exception
            MessageBox.Show("Xoá không thành công")
        End Try
        database.Clear()
        DataGridView1.DataSource = database
        DataGridView1.DataSource = Nothing
        Loaddata()

    End Sub
  

    Private Sub txtTongTien_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTongTien.TextChanged

    End Sub

    Private Sub btnThoat6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat6.Click
        FrmQuanLiBanHang.Show()
        Me.Hide()
    End Sub
End Class