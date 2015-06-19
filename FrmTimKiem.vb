



Imports System.Data.DataSet
Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmTimKiem
    Dim adater As New SqlDataAdapter
    Dim database As New DataTable
    Dim dataview As New DataView
    Dim chuoiketnoi As String = " workstation id=ps00481.mssql.somee.com;packet size=4096;user id=Hoangfpoly92_SQLLogin_1;pwd=tmqij74pf6;data source=ps00481.mssql.somee.com;persist security info=False;initial catalog=ps00481"
    Private Sub FrmTimKiem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        ' Câu truy vấn để get dữ liệu
        adater = New SqlDataAdapter("select * from SanPham", ketnoi)
        database = New DataTable("SanPham")
        'Kết nối mở ra

        'Đổ dữ liệu vào đối tượng database
        adater.Fill(database)
        dataview = New DataView(database)
        'Hiển thị dữ liệu ra Datagridview
        dgvTimKIem.DataSource = database.DefaultView



    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
        Dim LoaiSP As String = txtTimKiem.Text
        'dataview.RowFilter = "TenSP like '" + LoaiSP + "%'"
        dataview.RowFilter = "MaSP like '" + LoaiSP + "%'"
        dgvTimKIem.DataSource = dataview
    End Sub

    Private Sub btnTroVe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTroVe.Click
        FrmQuanLiBanHang.Show()
        Me.Hide()
    End Sub
End Class
