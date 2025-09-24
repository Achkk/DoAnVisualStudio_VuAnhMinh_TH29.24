Imports Microsoft.Data.SqlClient

Public Class frmTaiKhoanSinhVien
    Private Sub TaiKhoanSinhVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New SqlConnection("Data Source=DESKTOP-PJSL3HN\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
            Dim da As New SqlDataAdapter("SELECT TenDangNhap FROM TaiKhoan WHERE VaiTro = 'SinhVien'", conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvSVTK.DataSource = dt
        End Using
    End Sub
End Class
