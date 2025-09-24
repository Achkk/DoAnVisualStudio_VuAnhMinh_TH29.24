<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaiKhoanGiaoVien
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
        dgvGVTK = New DataGridView()
        CType(dgvGVTK, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvGVTK
        ' 
        dgvGVTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGVTK.Location = New Point(12, 135)
        dgvGVTK.Name = "dgvGVTK"
        dgvGVTK.RowHeadersWidth = 51
        dgvGVTK.Size = New Size(776, 303)
        dgvGVTK.TabIndex = 0
        ' 
        ' frmTaiKhoanGiaoVien
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvGVTK)
        Name = "frmTaiKhoanGiaoVien"
        Text = "Tài Khoản Giáo Viên"
        CType(dgvGVTK, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvGVTK As DataGridView
End Class
