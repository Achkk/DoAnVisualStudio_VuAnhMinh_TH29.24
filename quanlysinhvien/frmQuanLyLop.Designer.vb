<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuanLyLop
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
        dgvLop = New DataGridView()
        txtMaLop = New TextBox()
        txtTenLop = New TextBox()
        txtNganh = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnThem = New Button()
        btnSua = New Button()
        btnXoa = New Button()
        btnLamMoi = New Button()
        CType(dgvLop, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvLop
        ' 
        dgvLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLop.Location = New Point(12, 121)
        dgvLop.Name = "dgvLop"
        dgvLop.RowHeadersWidth = 51
        dgvLop.Size = New Size(776, 317)
        dgvLop.TabIndex = 0
        ' 
        ' txtMaLop
        ' 
        txtMaLop.Location = New Point(125, 24)
        txtMaLop.Name = "txtMaLop"
        txtMaLop.Size = New Size(125, 27)
        txtMaLop.TabIndex = 1
        ' 
        ' txtTenLop
        ' 
        txtTenLop.Location = New Point(125, 66)
        txtTenLop.Name = "txtTenLop"
        txtTenLop.Size = New Size(125, 27)
        txtTenLop.TabIndex = 2
        ' 
        ' txtNganh
        ' 
        txtNganh.Location = New Point(348, 24)
        txtNganh.Name = "txtNganh"
        txtNganh.Size = New Size(125, 27)
        txtNganh.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 20)
        Label1.TabIndex = 4
        Label1.Text = "Mã Lớp :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 20)
        Label2.TabIndex = 5
        Label2.Text = "Tên Lớp :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(282, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 20)
        Label3.TabIndex = 6
        Label3.Text = "Ngành :"
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(279, 86)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(94, 29)
        btnThem.TabIndex = 7
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Location = New Point(379, 86)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(94, 29)
        btnSua.TabIndex = 8
        btnSua.Text = "Sửa"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(479, 86)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(94, 29)
        btnXoa.TabIndex = 9
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnLamMoi
        ' 
        btnLamMoi.Location = New Point(579, 86)
        btnLamMoi.Name = "btnLamMoi"
        btnLamMoi.Size = New Size(94, 29)
        btnLamMoi.TabIndex = 10
        btnLamMoi.Text = "Làm mới"
        btnLamMoi.UseVisualStyleBackColor = True
        ' 
        ' FrmQuanLyLop
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLamMoi)
        Controls.Add(btnXoa)
        Controls.Add(btnSua)
        Controls.Add(btnThem)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNganh)
        Controls.Add(txtTenLop)
        Controls.Add(txtMaLop)
        Controls.Add(dgvLop)
        Name = "FrmQuanLyLop"
        Text = "Quản Lý Lớp"
        CType(dgvLop, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvLop As DataGridView
    Friend WithEvents txtMaLop As TextBox
    Friend WithEvents txtTenLop As TextBox
    Friend WithEvents txtNganh As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnLamMoi As Button
End Class
