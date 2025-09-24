Imports Microsoft.Data.SqlClient
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub DangKy_Click(sender As Object, e As EventArgs) Handles btnDangKy.Click
        ' 🛑 KIỂM TRA: Nếu bỏ trống thì báo lỗi
        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub ' Không thực hiện đăng ký
        End If

        ' 🔽 PHẦN CÒN LẠI: Kết nối và lưu vào SQL
        Dim connStr As String = "Data Source=DESKTOP-PJSL3HN\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"

        Using conn As New SqlConnection(connStr)
            Try
                conn.Open()

                ' Kiểm tra trùng tài khoản
                Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap=@TenDangNhap", conn)
                checkCmd.Parameters.AddWithValue("@TenDangNhap", txtUsername.Text)
                If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                    MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' Thêm tài khoản mới
                Dim cmd As New SqlCommand("INSERT INTO TaiKhoan (TenDangNhap, MatKhau) VALUES (@TenDangNhap, @MatKhau)", conn)
                cmd.Parameters.AddWithValue("@TenDangNhap", txtUsername.Text)
                cmd.Parameters.AddWithValue("@MatKhau", txtPassword.Text)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Tạo tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Huy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub
End Class