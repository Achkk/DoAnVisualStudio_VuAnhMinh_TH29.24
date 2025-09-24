<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLySinhVien
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
        dgvSV = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtMaSV = New TextBox()
        txtHoTen = New TextBox()
        txtMaLop = New TextBox()
        txtMaNganh = New TextBox()
        Label4 = New Label()
        dtpNgaySinh = New DateTimePicker()
        cboGioiTinh = New ComboBox()
        btnThem = New Button()
        btnSua = New Button()
        btnXoa = New Button()
        Label5 = New Label()
        Label6 = New Label()
        CType(dgvSV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvSV
        ' 
        dgvSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSV.Location = New Point(12, 12)
        dgvSV.Name = "dgvSV"
        dgvSV.RowHeadersWidth = 51
        dgvSV.Size = New Size(927, 268)
        dgvSV.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 321)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 20)
        Label1.TabIndex = 1
        Label1.Text = "Mã Sinh Viên :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 355)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 20)
        Label2.TabIndex = 2
        Label2.Text = "Họ Tên Sinh Viên :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(48, 388)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 20)
        Label3.TabIndex = 3
        Label3.Text = "Mã Lớp :"
        ' 
        ' txtMaSV
        ' 
        txtMaSV.Location = New Point(194, 318)
        txtMaSV.Name = "txtMaSV"
        txtMaSV.Size = New Size(209, 27)
        txtMaSV.TabIndex = 4
        ' 
        ' txtHoTen
        ' 
        txtHoTen.Location = New Point(194, 352)
        txtHoTen.Name = "txtHoTen"
        txtHoTen.Size = New Size(209, 27)
        txtHoTen.TabIndex = 5
        ' 
        ' txtMaLop
        ' 
        txtMaLop.Location = New Point(194, 385)
        txtMaLop.Name = "txtMaLop"
        txtMaLop.Size = New Size(209, 27)
        txtMaLop.TabIndex = 6
        ' 
        ' txtMaNganh
        ' 
        txtMaNganh.Location = New Point(194, 418)
        txtMaNganh.Name = "txtMaNganh"
        txtMaNganh.Size = New Size(209, 27)
        txtMaNganh.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(48, 421)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 20)
        Label4.TabIndex = 10
        Label4.Text = "Ngành :"
        ' 
        ' dtpNgaySinh
        ' 
        dtpNgaySinh.Location = New Point(195, 451)
        dtpNgaySinh.Name = "dtpNgaySinh"
        dtpNgaySinh.Size = New Size(208, 27)
        dtpNgaySinh.TabIndex = 11
        ' 
        ' cboGioiTinh
        ' 
        cboGioiTinh.FormattingEnabled = True
        cboGioiTinh.Items.AddRange(New Object() {"Nam", "Nữ"})
        cboGioiTinh.Location = New Point(194, 484)
        cboGioiTinh.Name = "cboGioiTinh"
        cboGioiTinh.Size = New Size(209, 28)
        cboGioiTinh.TabIndex = 12
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(425, 334)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(94, 29)
        btnThem.TabIndex = 13
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Location = New Point(425, 369)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(94, 29)
        btnSua.TabIndex = 14
        btnSua.Text = "Sửa"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(425, 404)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(94, 29)
        btnXoa.TabIndex = 15
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(48, 456)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 20)
        Label5.TabIndex = 16
        Label5.Text = "Ngày Sinh :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(48, 492)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 20)
        Label6.TabIndex = 17
        Label6.Text = "Giới Tính :"
        ' 
        ' frmQuanLySinhVien
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(951, 548)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(btnXoa)
        Controls.Add(btnSua)
        Controls.Add(btnThem)
        Controls.Add(cboGioiTinh)
        Controls.Add(dtpNgaySinh)
        Controls.Add(Label4)
        Controls.Add(txtMaNganh)
        Controls.Add(txtMaLop)
        Controls.Add(txtHoTen)
        Controls.Add(txtMaSV)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvSV)
        Name = "frmQuanLySinhVien"
        Text = "Quản Lý Sinh Viên"
        CType(dgvSV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvSV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtMaLop As TextBox
    Friend WithEvents txtMaNganh As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents cboGioiTinh As ComboBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
