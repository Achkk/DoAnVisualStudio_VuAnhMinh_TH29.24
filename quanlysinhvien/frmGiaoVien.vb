Imports System.Windows.Forms

Public Class FrmGiaoVien

    ' Khi form load, mở mặc định 1 giao diện (tùy chọn)
    Private Sub GiaoVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New frmQuanLySinhVien()
        ShowFormTrongPanel(f)
    End Sub

    ' Hàm dùng chung để mở form con trong pnlNoiDung
    Private Sub ShowFormTrongPanel(formCon As Form)
        pnlNoiDung.Controls.Clear()
        formCon.TopLevel = False
        formCon.FormBorderStyle = FormBorderStyle.None
        formCon.Dock = DockStyle.Fill
        pnlNoiDung.Controls.Add(formCon)
        formCon.Show()
    End Sub

    ' === CÁC SỰ KIỆN BUTTON ===

    Private Sub QuanLySV_Click(sender As Object, e As EventArgs) Handles btnQuanLySV.Click
        Dim f As New frmQuanLySinhVien()
        ShowFormTrongPanel(f)
    End Sub


    Private Sub QuanLyLop_Click(sender As Object, e As EventArgs) Handles btnQuanLyLop.Click
        Dim f As New FrmQuanLyLop()
        ShowFormTrongPanel(f)
    End Sub

    Private Sub TKSV_Click(sender As Object, e As EventArgs) Handles btnTKSV.Click
        Dim f As New frmTaiKhoanSinhVien()
        ShowFormTrongPanel(f)
    End Sub

    Private Sub TKGV_Click(sender As Object, e As EventArgs) Handles btnTKGV.Click
        Dim f As New frmTaiKhoanGiaoVien()
        ShowFormTrongPanel(f)
    End Sub
    Private Sub DangXuat_Click(sender As Object, e As EventArgs) Handles btnDangXuat.Click
        Dim result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim f As New Form1()
            f.Show()
            Me.Close()
        End If
    End Sub
    Private Sub GiaoVien_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit() ' Thoát toàn bộ chương trình ngay khi đóng form
    End Sub

End Class