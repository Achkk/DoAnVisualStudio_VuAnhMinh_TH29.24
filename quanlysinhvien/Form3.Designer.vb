<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        btnDangKy = New Button()
        btnHuy = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        SuspendLayout()
        ' 
        ' btnDangKy
        ' 
        btnDangKy.Location = New Point(114, 173)
        btnDangKy.Name = "btnDangKy"
        btnDangKy.Size = New Size(94, 29)
        btnDangKy.TabIndex = 0
        btnDangKy.Text = "Đăng Ký"
        btnDangKy.UseVisualStyleBackColor = True
        ' 
        ' btnHuy
        ' 
        btnHuy.Location = New Point(214, 173)
        btnHuy.Name = "btnHuy"
        btnHuy.Size = New Size(94, 29)
        btnHuy.TabIndex = 1
        btnHuy.Text = "Hủy"
        btnHuy.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(314, 173)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 2
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(69, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 3
        Label1.Text = "Tài Khoản :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(72, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 20)
        Label2.TabIndex = 4
        Label2.Text = "Mật khẩu :"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(155, 49)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(194, 27)
        txtUsername.TabIndex = 5
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(155, 84)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(194, 27)
        txtPassword.TabIndex = 6
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(498, 252)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(btnHuy)
        Controls.Add(btnDangKy)
        Name = "Form3"
        Text = "Đăng Ký"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnDangKy As Button
    Friend WithEvents btnHuy As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
End Class
