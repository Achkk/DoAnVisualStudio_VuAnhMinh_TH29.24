Imports Microsoft.Data.SqlClient
Public Class frmTaiKhoanGiaoVien
    Private Sub TaiKhoanGiaoVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New SqlConnection("Data Source=DESKTOP-PJSL3HN\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
            Dim da As New SqlDataAdapter("SELECT TenDangNhap FROM TaiKhoan WHERE VaiTro = 'GiaoVien'", conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvGVTK.DataSource = dt
        End Using
    End Sub
End Class