<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        ChangePasswordMainPanel = New TableLayoutPanel()
        ReenterPasswordLabel = New Label()
        Reenter = New TextBox()
        NewPasswordLabel = New Label()
        SaveBtn = New Button()
        NewPassword = New TextBox()
        Title = New Label()
        ChangePasswordMainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' ChangePasswordMainPanel
        ' 
        ChangePasswordMainPanel.AutoSize = True
        ChangePasswordMainPanel.BackColor = Color.FromArgb(CByte(222), CByte(219), CByte(193))
        ChangePasswordMainPanel.CausesValidation = False
        ChangePasswordMainPanel.ColumnCount = 4
        ChangePasswordMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.625F))
        ChangePasswordMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22.375F))
        ChangePasswordMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        ChangePasswordMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        ChangePasswordMainPanel.Controls.Add(ReenterPasswordLabel, 1, 2)
        ChangePasswordMainPanel.Controls.Add(Reenter, 2, 2)
        ChangePasswordMainPanel.Controls.Add(NewPasswordLabel, 1, 1)
        ChangePasswordMainPanel.Controls.Add(SaveBtn, 1, 3)
        ChangePasswordMainPanel.Controls.Add(NewPassword, 2, 1)
        ChangePasswordMainPanel.Controls.Add(Title, 1, 0)
        ChangePasswordMainPanel.Dock = DockStyle.Fill
        ChangePasswordMainPanel.Location = New Point(0, 0)
        ChangePasswordMainPanel.Name = "ChangePasswordMainPanel"
        ChangePasswordMainPanel.RowCount = 6
        ChangePasswordMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        ChangePasswordMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        ChangePasswordMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        ChangePasswordMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        ChangePasswordMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        ChangePasswordMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        ChangePasswordMainPanel.Size = New Size(800, 450)
        ChangePasswordMainPanel.TabIndex = 1
        ' 
        ' ReenterPasswordLabel
        ' 
        ReenterPasswordLabel.Anchor = AnchorStyles.None
        ReenterPasswordLabel.AutoSize = True
        ReenterPasswordLabel.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        ReenterPasswordLabel.Location = New Point(227, 183)
        ReenterPasswordLabel.Name = "ReenterPasswordLabel"
        ReenterPasswordLabel.Size = New Size(167, 25)
        ReenterPasswordLabel.TabIndex = 1
        ReenterPasswordLabel.Text = "Re-enter Password: "
        ' 
        ' Reenter
        ' 
        Reenter.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Reenter.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Reenter.Location = New Point(403, 180)
        Reenter.Name = "Reenter"
        Reenter.PasswordChar = "*"c
        Reenter.Size = New Size(154, 31)
        Reenter.TabIndex = 3
        ' 
        ' NewPasswordLabel
        ' 
        NewPasswordLabel.Anchor = AnchorStyles.None
        NewPasswordLabel.AutoSize = True
        NewPasswordLabel.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        NewPasswordLabel.Location = New Point(242, 127)
        NewPasswordLabel.Name = "NewPasswordLabel"
        NewPasswordLabel.Size = New Size(136, 25)
        NewPasswordLabel.TabIndex = 0
        NewPasswordLabel.Text = "New Password: "
        ' 
        ' SaveBtn
        ' 
        SaveBtn.Anchor = AnchorStyles.None
        ChangePasswordMainPanel.SetColumnSpan(SaveBtn, 2)
        SaveBtn.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        SaveBtn.Location = New Point(311, 235)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(159, 33)
        SaveBtn.TabIndex = 4
        SaveBtn.Text = "Save Password"
        SaveBtn.UseVisualStyleBackColor = True
        ' 
        ' NewPassword
        ' 
        NewPassword.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        NewPassword.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        NewPassword.Location = New Point(403, 124)
        NewPassword.Name = "NewPassword"
        NewPassword.PasswordChar = "*"c
        NewPassword.Size = New Size(154, 31)
        NewPassword.TabIndex = 5
        ' 
        ' Title
        ' 
        Title.Anchor = AnchorStyles.None
        Title.AutoSize = True
        ChangePasswordMainPanel.SetColumnSpan(Title, 2)
        Title.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Title.Location = New Point(280, 43)
        Title.Name = "Title"
        Title.Size = New Size(220, 25)
        Title.TabIndex = 6
        Title.Text = "Please set a new Password"
        ' 
        ' ChangePassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ChangePasswordMainPanel)
        Name = "ChangePassword"
        Text = "ChangePassword"
        ChangePasswordMainPanel.ResumeLayout(False)
        ChangePasswordMainPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ChangePasswordMainPanel As TableLayoutPanel
    Friend WithEvents ReenterPasswordLabel As Label
    Friend WithEvents Reenter As TextBox
    Friend WithEvents NewPasswordLabel As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents NewPassword As TextBox
    Friend WithEvents Title As Label
End Class
