Imports Microsoft.Data.SqlClient

Public Class Form1
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connStr As String = "Data Source=DESKTOP-PJSL3HN\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"

        Using conn As New SqlConnection(connStr)
            Try

                conn.Open()
                Dim cmd As New SqlCommand("SELECT VaiTro FROM TaiKhoan WHERE TenDangNhap=@TenDangNhap AND MatKhau=@MatKhau", conn)
                cmd.Parameters.AddWithValue("@TenDangNhap", txtUsername.Text)
                cmd.Parameters.AddWithValue("@MatKhau", txtPassword.Text)

                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    Dim vaitro As String = result.ToString()
                    Me.Hide()

                    If vaitro = "SinhVien" Then
                        Dim f As New frmSinhVien(txtUsername.Text)
                        f.ShowDialog()
                    Else
                        Dim f As New FrmGiaoVien()
                        f.ShowDialog()
                    End If

                Else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Lỗi kết nối: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub DangKy_Click(sender As Object, e As EventArgs) Handles btnDangKy.Click
        Dim frm As New Form3() ' Tạo form đăng ký
        frm.ShowDialog()       ' Mở Form3 dưới dạng hộp thoại
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class