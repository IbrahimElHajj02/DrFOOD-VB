<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignInForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        SignInMainPanel = New TableLayoutPanel()
        PasswordLabel = New Label()
        Password = New TextBox()
        Username = New TextBox()
        UsernameLabel = New Label()
        LoginBtn = New Button()
        SignInMainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' SignInMainPanel
        ' 
        SignInMainPanel.AutoSize = True
        SignInMainPanel.BackColor = Color.FromArgb(CByte(222), CByte(219), CByte(193))
        SignInMainPanel.CausesValidation = False
        SignInMainPanel.ColumnCount = 4
        SignInMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        SignInMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        SignInMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        SignInMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        SignInMainPanel.Controls.Add(PasswordLabel, 1, 2)
        SignInMainPanel.Controls.Add(Password, 2, 2)
        SignInMainPanel.Controls.Add(Username, 2, 1)
        SignInMainPanel.Controls.Add(UsernameLabel, 1, 1)
        SignInMainPanel.Controls.Add(LoginBtn, 1, 3)
        SignInMainPanel.Dock = DockStyle.Fill
        SignInMainPanel.Location = New Point(0, 0)
        SignInMainPanel.Name = "SignInMainPanel"
        SignInMainPanel.RowCount = 6
        SignInMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        SignInMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        SignInMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        SignInMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        SignInMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        SignInMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        SignInMainPanel.Size = New Size(800, 450)
        SignInMainPanel.TabIndex = 0
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Anchor = AnchorStyles.None
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordLabel.Location = New Point(272, 183)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(96, 25)
        PasswordLabel.TabIndex = 1
        PasswordLabel.Text = "Password: "
        ' 
        ' Password
        ' 
        Password.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Password.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Password.Location = New Point(403, 180)
        Password.Name = "Password"
        Password.PasswordChar = "*"c
        Password.Size = New Size(154, 31)
        Password.TabIndex = 3
        ' 
        ' Username
        ' 
        Username.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Username.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Username.Location = New Point(403, 124)
        Username.Name = "Username"
        Username.Size = New Size(154, 31)
        Username.TabIndex = 2
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Anchor = AnchorStyles.None
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        UsernameLabel.Location = New Point(270, 127)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(100, 25)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "Username: "
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Anchor = AnchorStyles.None
        SignInMainPanel.SetColumnSpan(LoginBtn, 2)
        LoginBtn.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LoginBtn.Location = New Point(348, 235)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(104, 33)
        LoginBtn.TabIndex = 4
        LoginBtn.Text = "Log In"
        LoginBtn.UseVisualStyleBackColor = True
        ' 
        ' SignInForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SignInMainPanel)
        Name = "SignInForm"
        Text = "Dr FOOD"
        SignInMainPanel.ResumeLayout(False)
        SignInMainPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SignInMainPanel As TableLayoutPanel
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents LoginBtn As Button
End Class
