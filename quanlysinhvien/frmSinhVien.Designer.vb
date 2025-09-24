<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSinhVien
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
        picAvatar = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        lblTen = New Label()
        lblMa = New Label()
        dgvBangDiem = New DataGridView()
        txtTimMaSV = New TextBox()
        Label3 = New Label()
        btnTimDiem = New Button()
        btnDangXuat = New Button()
        CType(picAvatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvBangDiem, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picAvatar
        ' 
        picAvatar.BackColor = SystemColors.ActiveCaption
        picAvatar.Location = New Point(39, 30)
        picAvatar.Name = "picAvatar"
        picAvatar.Size = New Size(129, 169)
        picAvatar.TabIndex = 0
        picAvatar.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(192, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 20)
        Label1.TabIndex = 1
        Label1.Text = "Tên Sinh Viên :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(194, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 20)
        Label2.TabIndex = 2
        Label2.Text = "Mã Sinh Viên :"
        ' 
        ' lblTen
        ' 
        lblTen.AutoSize = True
        lblTen.Location = New Point(302, 30)
        lblTen.Name = "lblTen"
        lblTen.Size = New Size(18, 20)
        lblTen.TabIndex = 3
        lblTen.Text = "..."
        ' 
        ' lblMa
        ' 
        lblMa.AutoSize = True
        lblMa.Location = New Point(302, 69)
        lblMa.Name = "lblMa"
        lblMa.Size = New Size(18, 20)
        lblMa.TabIndex = 4
        lblMa.Text = "..."
        ' 
        ' dgvBangDiem
        ' 
        dgvBangDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBangDiem.Location = New Point(39, 205)
        dgvBangDiem.Name = "dgvBangDiem"
        dgvBangDiem.RowHeadersWidth = 51
        dgvBangDiem.Size = New Size(727, 206)
        dgvBangDiem.TabIndex = 5
        ' 
        ' txtTimMaSV
        ' 
        txtTimMaSV.Location = New Point(337, 106)
        txtTimMaSV.Name = "txtTimMaSV"
        txtTimMaSV.Size = New Size(152, 27)
        txtTimMaSV.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(194, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 20)
        Label3.TabIndex = 7
        Label3.Text = "Điền mã Sinh Viên :"
        ' 
        ' btnTimDiem
        ' 
        btnTimDiem.Location = New Point(495, 104)
        btnTimDiem.Name = "btnTimDiem"
        btnTimDiem.Size = New Size(94, 29)
        btnTimDiem.TabIndex = 8
        btnTimDiem.Text = "Tìm"
        btnTimDiem.UseVisualStyleBackColor = True
        ' 
        ' btnDangXuat
        ' 
        btnDangXuat.Location = New Point(237, 170)
        btnDangXuat.Name = "btnDangXuat"
        btnDangXuat.Size = New Size(94, 29)
        btnDangXuat.TabIndex = 9
        btnDangXuat.Text = "Đăng Xuất"
        btnDangXuat.UseVisualStyleBackColor = True
        ' 
        ' frmSinhVien
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDangXuat)
        Controls.Add(btnTimDiem)
        Controls.Add(Label3)
        Controls.Add(txtTimMaSV)
        Controls.Add(dgvBangDiem)
        Controls.Add(lblMa)
        Controls.Add(lblTen)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(picAvatar)
        Name = "frmSinhVien"
        Text = "Sinh Viên"
        CType(picAvatar, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvBangDiem, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picAvatar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTen As Label
    Friend WithEvents lblMa As Label
    Friend WithEvents dgvBangDiem As DataGridView
    Friend WithEvents txtTimMaSV As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTimDiem As Button
    Friend WithEvents btnDangXuat As Button
End Class
