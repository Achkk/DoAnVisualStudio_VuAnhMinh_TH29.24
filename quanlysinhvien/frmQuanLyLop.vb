Imports Microsoft.Data.SqlClient

Public Class FrmQuanLyLop
    Dim connStr As String = "Data Source=DESKTOP-PJSL3HN\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"

    Private Sub FrmQuanLyLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDanhSachLop()
    End Sub

    ' Load dữ liệu lên DataGridView
    Private Sub LoadDanhSachLop()
        Using conn As New SqlConnection(connStr)
            Dim da As New SqlDataAdapter("SELECT * FROM Lop", conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvLop.DataSource = dt
        End Using
    End Sub

    ' Nút Thêm
    Private Sub Them_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Using conn As New SqlConnection(connStr)
            Dim sql = "INSERT INTO Lop (MaLop, TenLop, Nganh) VALUES (@MaLop, @TenLop, @Nganh)"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text)
            cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text)
            cmd.Parameters.AddWithValue("@Nganh", txtNganh.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
        End Using
        LoadDanhSachLop()
    End Sub

    ' Nút Sửa
    Private Sub Sua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Using conn As New SqlConnection(connStr)
            Dim sql = "UPDATE Lop SET TenLop = @TenLop, KhoaHoc = @KhoaHoc WHERE MaLop = @MaLop"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text)
            cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text)
            cmd.Parameters.AddWithValue("@Nganh", txtNganh.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
        End Using
        LoadDanhSachLop()
    End Sub

    ' Nút Xóa
    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Using conn As New SqlConnection(connStr)
                Dim sql = "DELETE FROM Lop WHERE MaLop = @MaLop"
                Dim cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            LoadDanhSachLop()
        End If
    End Sub

    ' Nút Làm Mới
    Private Sub LamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        txtMaLop.Clear()
        txtTenLop.Clear()
        txtNganh.Clear()
    End Sub

    ' Sự kiện khi chọn dòng trong DataGridView
    Private Sub Lop_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLop.CellClick
        Dim i As Integer = dgvLop.CurrentRow.Index
        txtMaLop.Text = dgvLop.Item("MaLop", i).Value.ToString()
        txtTenLop.Text = dgvLop.Item("TenLop", i).Value.ToString()
        txtNganh.Text = dgvLop.Item("Nganh", i).Value.ToString()
    End Sub
End Class
