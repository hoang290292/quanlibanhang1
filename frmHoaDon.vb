Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data.DataSet
Public Class frmHoaDon
    Dim database As New DataTable
    Dim chuoiketnoi As String = " workstation id=ps00481.mssql.somee.com;packet size=4096;user id=Hoangfpoly92_SQLLogin_1;pwd=tmqij74pf6;data source=ps00481.mssql.somee.com;persist security info=False;initial catalog=ps00481"
    Private Sub frmHoaDon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from HoaDon", ketnoi)
        'Kết nối mở ra
        ketnoi.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview
        DataGridView1.DataSource = database.DefaultView
        LoadCombobox()
        LoadCombobox1()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaHD.Text = DataGridView1.Item(0, index).Value
        txtNgayLap.Text = DataGridView1.Item(1, index).Value
        cbbMaNV.Text = DataGridView1.Item(2, index).Value
        cbbMaKH.Text = DataGridView1.Item(3, index).Value
    End Sub
    Private Sub btnThem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem5.Click
       
        Them()

    

    End Sub

    Public Sub LoadCombobox()
        Dim db As New DataTable
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim Query1 As String = " select MaKH from KhachHang"
        Dim cmd As SqlCommand = New SqlCommand(Query1, ketnoi)
        cmd.CommandType = CommandType.Text
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        da.Fill(db)
        cbbMaKH.DataSource = db
        cbbMaKH.DisplayMember = "MaKH"

    End Sub
    Public Sub LoadCombobox1()
        Dim db1 As New DataTable
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim Query2 As String = " select MaNV from NhanVien"
        Dim cmd1 As SqlCommand = New SqlCommand(Query2, ketnoi)
        cmd1.CommandType = CommandType.Text
        Dim da1 As SqlDataAdapter = New SqlDataAdapter(cmd1)
        da1.Fill(db1)
        cbbMaNV.DataSource = db1
        cbbMaNV.DisplayMember = "MaNV"


        ketnoi.Close()
    End Sub
    Private Sub Them()

        'Dim MaHD As String = txtMaHD.Text
        'Dim NgayLap As String = txtNgayLap.Text ' sửa sau
        'Dim MaNV As String = cbbMaNV.ValueMember
        'Dim MaKH As String = cbbMaKH.ValueMember

        'If (MaHD = " ") And (NgayLap = " ") And (MaNV = " ") And (MaKH = " ") Then
        '    MessageBox.Show("Dien Thiếu  thông tin  ")


        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)

        Dim Query2 As String = "insert into Hoadon values (@MaHD,@NgayLap,@NhanVien_MaNV,@KhachHang_MaKH)"

        Dim ExecuteQuery1 As New SqlCommand(Query2, ketnoi)

        ketnoi.Open()


        Try

            ExecuteQuery1.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
            ExecuteQuery1.Parameters.AddWithValue("@NgayLap", txtNgayLap.Text)
            ExecuteQuery1.Parameters.AddWithValue("@NhanVien_MaNV", cbbMaNV.Text)
            ExecuteQuery1.Parameters.AddWithValue("@KhachHang_MaKH", cbbMaKH.Text)


            MessageBox.Show("Thêm thành công")
            ExecuteQuery1.ExecuteNonQuery()
        Catch ex As Exception

            MessageBox.Show("Không thêm được!")

        End Try

        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from HoaDon", ketnoi)
        database.Clear()

        Query3.Fill(database)
        DataGridView1.DataSource = database.DefaultView

    End Sub


    Private Sub cbbMaNV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbMaNV.SelectedIndexChanged

    End Sub

    Private Sub btnSua5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua5.Click
        Dim ketnoi1 As New SqlConnection(chuoiketnoi)
        ketnoi1.Open()
        Dim fix As String = " Update HoaDon set KhachHang_MaKH = @KhachHang_MaKH,NhanVien_MaNV = @NHanVien_MaNV,NgayLap=@NgayLap  where MaHD = @MaHD"
        Dim com As New SqlCommand(fix, ketnoi1)
        Try
            com.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
            com.Parameters.AddWithValue("@NgayLap", txtNgayLap.Text)
            com.Parameters.AddWithValue("@NhanVien_MaNV", cbbMaNV.Text)
            com.Parameters.AddWithValue("@KhachHang_MaKH", cbbMaKH.Text)
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
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from HoaDon", ketnoi)

        ketnoi.Open()
        Query1.Fill(database)
        DataGridView1.DataSource = database.DefaultView
    End Sub

    Private Sub btnXoa5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa5.Click
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim xoal As String = "Delete from HoaDon Where MaHD = @MaHD"
        Dim lenh As New SqlCommand(xoal, ketnoi)
        Try
            lenh.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
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

    Private Sub btnThoat5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat5.Click
        FrmQuanLiBanHang.Show()
        Me.Hide()
    End Sub
End Class