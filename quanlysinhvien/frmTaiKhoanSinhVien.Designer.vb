<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaiKhoanSinhVien
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
        dgvSVTK = New DataGridView()
        CType(dgvSVTK, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvSVTK
        ' 
        dgvSVTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSVTK.Location = New Point(12, 121)
        dgvSVTK.Name = "dgvSVTK"
        dgvSVTK.RowHeadersWidth = 51
        dgvSVTK.Size = New Size(776, 317)
        dgvSVTK.TabIndex = 0
        ' 
        ' frmTaiKhoanSinhVien
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvSVTK)
        Name = "frmTaiKhoanSinhVien"
        Text = "Tài Khoản Sinh Viên"
        CType(dgvSVTK, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvSVTK As DataGridView
End Class
