Imports Microsoft.Data.SqlClient
Imports System.IO

Public Class frmSinhVien
    Private maSV As String

    ' Nhận mã sinh viên từ form đăng nhập
    Public Sub New(mssv As String)
        InitializeComponent()
        maSV = mssv
    End Sub

    Private Sub SinhVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadThongTinSinhVien()
        LoadBangDiem()
    End Sub

    ' Tải thông tin sinh viên
    Private Sub LoadThongTinSinhVien()
        Dim connStr As String = "Data Source=DESKTOP-PJSL3HN\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"

        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT HoTen, HinhAnh FROM SinhVien WHERE MaSV = @MaSV", conn)
            cmd.Parameters.AddWithValue("@MaSV", maSV)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                lblTen.Text = reader("HoTen").ToString()
                lblMa.Text = maSV

                ' Hiển thị ảnh
                If Not IsDBNull(reader("HinhAnh")) Then
                    Dim imgData() As Byte = CType(reader("HinhAnh"), Byte())
                    Using ms As New MemoryStream(imgData)
                        picAvatar.Image = Image.FromStream(ms)
                    End Using
                End If
            End If
        End Using
    End Sub

    ' Tải bảng điểm (nếu không truyền mã -> lấy theo sinh viên đăng nhập)
    Private Sub LoadBangDiem(Optional maTim As String = "")
        Dim maCanTim = If(maTim = "", maSV, maTim)
        Dim connStr As String = "Data Source=DESKTOP-PJSL3HN\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"

        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT MonHoc, LanThi, Diem FROM Diem WHERE MaSV = @MaSV", conn)
            cmd.Parameters.AddWithValue("@MaSV", maCanTim)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvBangDiem.DataSource = dt
        End Using
    End Sub

    ' Tìm bảng điểm theo mã nhập vào
    Private Sub TimDiem_Click(sender As Object, e As EventArgs) Handles btnTimDiem.Click
        Dim maCanTim As String = txtTimMaSV.Text.Trim()

        If maCanTim = "" Then
            MessageBox.Show("Vui lòng nhập mã sinh viên cần tra điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Lấy điểm
        LoadBangDiem(maCanTim)

        ' Lấy thông tin sinh viên
        HienThongTinSinhVien(maCanTim)
    End Sub

    Private Sub DangXuat_Click(sender As Object, e As EventArgs) Handles btnDangXuat.Click
        Dim result = MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim f As New Form1()
            f.Show()
            Me.Close()
        End If
    End Sub
    Private Sub HienThongTinSinhVien(maCanTim As String)
        Dim connStr As String = "Data Source=DESKTOP-PJSL3HN\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"

        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT HoTen FROM SinhVien WHERE MaSV = @MaSV", conn)
            cmd.Parameters.AddWithValue("@MaSV", maCanTim)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                lblTen.Text = reader("HoTen").ToString()
                lblMa.Text = maCanTim
            Else
                lblTen.Text = "Không tìm thấy"
                lblMa.Text = maCanTim
            End If
        End Using
    End Sub
    Private Sub SinhVien_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit() ' Thoát toàn bộ chương trình ngay khi form bị đóng
    End Sub

End Class
