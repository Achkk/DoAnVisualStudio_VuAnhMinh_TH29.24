Imports Microsoft.Data.SqlClient

Public Class frmQuanLySinhVien
    Private Sub SinhVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSinhVien()
    End Sub

    Private Sub LoadSinhVien()
        Using conn As New SqlConnection("Data Source=DESKTOP-PJSL3HN\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
            Dim da As New SqlDataAdapter("SELECT * FROM SinhVien", conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvSV.DataSource = dt
        End Using
    End Sub

    Private Sub Them_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Using conn As New SqlConnection("Data Source=DESKTOP-PJSL3HN\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
            Dim sql = "INSERT INTO SinhVien (MaSV, HoTen, MaLop, Nganh, NgaySinh, GioiTinh) VALUES (@MaSV, @HoTen, @MaLop, @Nganh, @NgaySinh, @GioiTinh)"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
            cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
            cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text)
            cmd.Parameters.AddWithValue("@Nganh", txtMaNganh.Text)
            cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value)
            cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
        End Using
        LoadSinhVien()
    End Sub
    Private Sub Sua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Using conn As New SqlConnection("Data Source=DESKTOP-PJSL3HN\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
            Dim sql = "UPDATE SinhVien SET HoTen = @HoTen, MaLop = @MaLop, Nganh = @Nganh, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh WHERE MaSV = @MaSV"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
            cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
            cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text)
            cmd.Parameters.AddWithValue("@Nganh", txtMaNganh.Text)
            cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value)
            cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
        End Using
        LoadSinhVien()
    End Sub
    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If MessageBox.Show("Bạn có chắc muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Using conn As New SqlConnection("Data Source=DESKTOP-PJSL3HN\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
                Dim sql = "DELETE FROM SinhVien WHERE MaSV = @MaSV"
                Dim cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            LoadSinhVien()
        End If
    End Sub
    Private Sub SV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSV.CellClick
        Dim i As Integer = dgvSV.CurrentRow.Index
        txtMaSV.Text = dgvSV.Item("MaSV", i).Value.ToString()
        txtHoTen.Text = dgvSV.Item("HoTen", i).Value.ToString()
        txtMaLop.Text = dgvSV.Item("MaLop", i).Value.ToString()
        txtMaNganh.Text = dgvSV.Item("Nganh", i).Value.ToString()
        dtpNgaySinh.Value = Convert.ToDateTime(dgvSV.Item("NgaySinh", i).Value)
        cboGioiTinh.Text = dgvSV.Item("GioiTinh", i).Value.ToString()
    End Sub

End Class