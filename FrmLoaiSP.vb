Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmLoaiSP
    Dim database As New DataTable
    Dim chuoiketnoi As String = " workstation id=ps00481.mssql.somee.com;packet size=4096;user id=Hoangfpoly92_SQLLogin_1;pwd=tmqij74pf6;data source=ps00481.mssql.somee.com;persist security info=False;initial catalog=ps00481"
    Private Sub LabelX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelX1.Click

    End Sub

    Private Sub FrmLoaiSP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from LoaiSanPham", ketnoi)
        'Kết nối mở ra
        ketnoi.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview
        DataGridViewX1.DataSource = database.DefaultView
    End Sub

    Private Sub DataGridViewX1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick
        Dim index As Integer = DataGridViewX1.CurrentCell.RowIndex
        txtMaLoaiSP.Text = DataGridViewX1.Item(0, index).Value
        txtTenLoaiSP.Text = DataGridViewX1.Item(1, index).Value

    End Sub

    Private Sub btnThem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem4.Click
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)

        Dim Query2 As String = "insert into LoaiSanPham values (@MaLoaiSP,@TenLoai)"

        Dim ExecuteQuery1 As New SqlCommand(Query2, ketnoi)

        ketnoi.Open()

        Try

            ExecuteQuery1.Parameters.AddWithValue("@MaLoaiSP", txtMaLoaiSP.Text)
            ExecuteQuery1.Parameters.AddWithValue("@TenLoai", txtTenLoaiSP.Text)



            MessageBox.Show("Thêm thành công")
            ExecuteQuery1.ExecuteNonQuery()
        Catch ex As Exception

            MessageBox.Show("Không thêm được!")

        End Try

        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from LoaiSanPham", ketnoi)
        database.Clear()

        Query3.Fill(database)
        DataGridViewX1.DataSource = database.DefaultView

    End Sub

    Private Sub btnXoa4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa4.Click
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim xoal As String = "Delete from LoaiSanPham Where MaNV = @MaNV"
        Dim lenh As New SqlCommand(xoal, ketnoi)
        Try
            lenh.Parameters.AddWithValue("@MaLoaiSP", txtMaLoaiSP.Text)
            lenh.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xoá  thành công")
        Catch ex As Exception
            MessageBox.Show("Xoá không thành công")
        End Try
        database.Clear()
        DataGridViewX1.DataSource = database
        DataGridViewX1.DataSource = Nothing
        Loaddata()

    End Sub

    Private Sub btnSua4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua4.Click
        Dim ketnoi1 As New SqlConnection(chuoiketnoi)
        ketnoi1.Open()
        Dim fix As String = " Update LoaiSanPham set TenLoai = @TenLoai, where MaLoaiSP = @MaLoaiSP"
        Dim com As New SqlCommand(fix, ketnoi1)
        Try
            com.Parameters.AddWithValue("@MaLoaiSP", txtMaLoaiSP.Text)
            com.Parameters.AddWithValue("@TenLoai", txtTenLoaiSP.Text)

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
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from LoaiSanPham", ketnoi)

        ketnoi.Open()
        Query1.Fill(database)
        DataGridViewX1.DataSource = database.DefaultView
    End Sub

    Private Sub btnThoat4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat4.Click
        FrmQuanLiBanHang.Show()
        Me.Hide()
    End Sub
End Class