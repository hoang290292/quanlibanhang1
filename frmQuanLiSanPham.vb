Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmQuanLiSanPham
    Dim database As New DataTable
    Dim chuoiketnoi As String = " workstation id=ps00481.mssql.somee.com;packet size=4096;user id=Hoangfpoly92_SQLLogin_1;pwd=tmqij74pf6;data source=ps00481.mssql.somee.com;persist security info=False;initial catalog=ps00481"
    Private Sub frmHoaDon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", ketnoi)
        'Kết nối mở ra
        ketnoi.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview
        DataGridViewX1.DataSource = database.DefaultView
        LoadCombobox()
    End Sub

    Private Sub DataGridViewX1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick
        Dim index As Integer = DataGridViewX1.CurrentCell.RowIndex
        txtMaSanPham.Text = DataGridViewX1.Item(0, index).Value
        txtTenSanPham.Text = DataGridViewX1.Item(1, index).Value
        txtChiTietSP.Text = DataGridViewX1.Item(2, index).Value
        cbbMaLoaiSP.Text = DataGridViewX1.Item(3, index).Value
    End Sub

    Private Sub btnThem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem3.Click
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query2 As String = "insert into SanPham values(@MaSP,@TenSP,@ChiTietSP,@LoaiSanPham_MaLoaiSP)"
        Dim ExecuteQuery1 As New SqlCommand(query2, ketnoi)
        ketnoi.Open()

        Try
            ExecuteQuery1.Parameters.AddWithValue("@MaSP", txtMaSanPham.Text)
            ExecuteQuery1.Parameters.AddWithValue("@TenSP", txtTenSanPham.Text)
            ExecuteQuery1.Parameters.AddWithValue("@ChiTietSP", txtChiTietSP.Text)
            ExecuteQuery1.Parameters.AddWithValue("@LoaiSanPham_MaLoaiSP", cbbMaLoaiSP.Text)
            MessageBox.Show("Thêm Thành công")
            ExecuteQuery1.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(" ko Thêm Thành công")

        End Try
        Dim query3 As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", ketnoi)
        database.Clear()
        query3.Fill(database)
        DataGridViewX1.DataSource = database.DefaultView
    End Sub

    Private Sub btnSua3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua3.Click
        Dim ketnoi1 As New SqlConnection(chuoiketnoi)
        ketnoi1.Open()
        Dim fix As String = " Update SanPham set LoaiSanPham_MaLoaiSP= @LoaiSanPham_MaLoaiSP,ChiTietSP = @ChiTietSP,TenSP=@TenSP  where MaSP = @MaSP"
        Dim com As New SqlCommand(fix, ketnoi1)
        Try
            com.Parameters.AddWithValue("@MaSP", txtMaSanPham.Text)
            com.Parameters.AddWithValue("@TenSP", txtTenSanPham.Text)
            com.Parameters.AddWithValue("@ChiTietSP", txtChiTietSP.Text)
            com.Parameters.AddWithValue("@LoaiSanPham_MaLoaiSP", cbbMaLoaiSP.Text)
            com.ExecuteNonQuery()
            ketnoi1.Close()
            MessageBox.Show(" Sua Thanh Cong ")
        Catch ex As Exception
            MessageBox.Show(" Sua ko  Thanh Cong ")
        End Try
        database.Clear()
        DataGridViewX1.DataSource = database
        DataGridViewX1.DataSource = Nothing
        Loaddata()
    End Sub
    Private Sub Loaddata()
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", ketnoi)
        ketnoi.Open()
        query.Fill(database)
        DataGridViewX1.DataSource = database.DefaultView
    End Sub

    Private Sub btnXoa3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa3.Click
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim query As String = "Delete from SanPham Where MaSP = @MaSP"
        Dim com As New SqlCommand(query, ketnoi)


        Try
            com.Parameters.AddWithValue("@MaSP", txtMaSanPham.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa Thành Công")
        Catch ex As Exception
            MessageBox.Show("Xóa Không Thành công")
        End Try
        database.Clear()
        DataGridViewX1.DataSource = database
        DataGridViewX1.DataSource = Nothing
        Loaddata()

    End Sub
    Public Sub LoadCombobox()
        Dim db As New DataTable
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim Query1 As String = " select MaLoaiSP from LoaiSanPham "
        Dim cmd As SqlCommand = New SqlCommand(Query1, ketnoi)
        cmd.CommandType = CommandType.Text
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        da.Fill(db)
        cbbMaLoaiSP.DataSource = db
        cbbMaLoaiSP.DisplayMember = "MaLoaiSP"
    End Sub

    Private Sub btnThoat3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat3.Click
        FrmQuanLiBanHang.Show()
        Me.Hide()
    End Sub
End Class