<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnDangKy = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 0
        Label1.Text = "Tài khoản :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 20)
        Label2.TabIndex = 1
        Label2.Text = "Mật khẩu :"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(138, 51)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(211, 27)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(138, 84)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(211, 27)
        txtPassword.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(100, 132)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Đăng Nhập"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnDangKy
        ' 
        btnDangKy.Location = New Point(200, 132)
        btnDangKy.Name = "btnDangKy"
        btnDangKy.Size = New Size(94, 29)
        btnDangKy.TabIndex = 5
        btnDangKy.Text = "Đăng Ký"
        btnDangKy.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(488, 304)
        Controls.Add(btnDangKy)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Đăng Nhập"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnDangKy As Button

End Class
