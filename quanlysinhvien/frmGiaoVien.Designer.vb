<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGiaoVien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pnlMenu = New Panel()
        btnDangXuat = New Button()
        btnTKGV = New Button()
        btnTKSV = New Button()
        btnQuanLyLop = New Button()
        btnQuanLySV = New Button()
        pnlNoiDung = New Panel()
        pnlMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMenu
        ' 
        pnlMenu.Controls.Add(btnDangXuat)
        pnlMenu.Controls.Add(btnTKGV)
        pnlMenu.Controls.Add(btnTKSV)
        pnlMenu.Controls.Add(btnQuanLyLop)
        pnlMenu.Controls.Add(btnQuanLySV)
        pnlMenu.Location = New Point(12, 12)
        pnlMenu.Name = "pnlMenu"
        pnlMenu.Size = New Size(217, 543)
        pnlMenu.TabIndex = 0
        ' 
        ' btnDangXuat
        ' 
        btnDangXuat.Location = New Point(3, 361)
        btnDangXuat.Name = "btnDangXuat"
        btnDangXuat.Size = New Size(211, 55)
        btnDangXuat.TabIndex = 6
        btnDangXuat.Text = "Đăng Xuất"
        btnDangXuat.UseVisualStyleBackColor = True
        ' 
        ' btnTKGV
        ' 
        btnTKGV.Location = New Point(3, 300)
        btnTKGV.Name = "btnTKGV"
        btnTKGV.Size = New Size(211, 55)
        btnTKGV.TabIndex = 5
        btnTKGV.Text = "Quản Lý Tài Khoản Giáo Viên"
        btnTKGV.UseVisualStyleBackColor = True
        ' 
        ' btnTKSV
        ' 
        btnTKSV.Location = New Point(3, 239)
        btnTKSV.Name = "btnTKSV"
        btnTKSV.Size = New Size(211, 55)
        btnTKSV.TabIndex = 4
        btnTKSV.Text = "Quản Lý Tài Khoản Sinh Viên"
        btnTKSV.UseVisualStyleBackColor = True
        ' 
        ' btnQuanLyLop
        ' 
        btnQuanLyLop.Location = New Point(3, 178)
        btnQuanLyLop.Name = "btnQuanLyLop"
        btnQuanLyLop.Size = New Size(211, 55)
        btnQuanLyLop.TabIndex = 2
        btnQuanLyLop.Text = "Quản Lý Lớp"
        btnQuanLyLop.UseVisualStyleBackColor = True
        ' 
        ' btnQuanLySV
        ' 
        btnQuanLySV.Location = New Point(3, 117)
        btnQuanLySV.Name = "btnQuanLySV"
        btnQuanLySV.Size = New Size(211, 55)
        btnQuanLySV.TabIndex = 0
        btnQuanLySV.Text = "Quản Lý Sinh Viên"
        btnQuanLySV.UseVisualStyleBackColor = True
        ' 
        ' pnlNoiDung
        ' 
        pnlNoiDung.Location = New Point(235, 12)
        pnlNoiDung.Name = "pnlNoiDung"
        pnlNoiDung.Size = New Size(949, 543)
        pnlNoiDung.TabIndex = 1
        ' 
        ' FrmGiaoVien
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1196, 567)
        Controls.Add(pnlNoiDung)
        Controls.Add(pnlMenu)
        Name = "FrmGiaoVien"
        Text = "Giáo Viên"
        pnlMenu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnQuanLyLop As Button
    Friend WithEvents btnQuanLySV As Button
    Friend WithEvents pnlNoiDung As Panel
    Friend WithEvents btnDangXuat As Button
    Friend WithEvents btnTKGV As Button
    Friend WithEvents btnTKSV As Button
End Class
