<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        MainMenuMainPanel = New TableLayoutPanel()
        MyAccountBtn = New Button()
        WelcomeLabel = New Label()
        ManageUsersBtn = New Button()
        MainMenuMainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainMenuMainPanel
        ' 
        MainMenuMainPanel.AutoSize = True
        MainMenuMainPanel.BackColor = Color.FromArgb(CByte(222), CByte(219), CByte(193))
        MainMenuMainPanel.CausesValidation = False
        MainMenuMainPanel.ColumnCount = 3
        MainMenuMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.8507442F))
        MainMenuMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.29851F))
        MainMenuMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.8507481F))
        MainMenuMainPanel.Controls.Add(MyAccountBtn, 1, 2)
        MainMenuMainPanel.Controls.Add(WelcomeLabel, 1, 0)
        MainMenuMainPanel.Controls.Add(ManageUsersBtn, 1, 3)
        MainMenuMainPanel.Dock = DockStyle.Fill
        MainMenuMainPanel.Location = New Point(0, 0)
        MainMenuMainPanel.Name = "MainMenuMainPanel"
        MainMenuMainPanel.RowCount = 6
        MainMenuMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        MainMenuMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        MainMenuMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        MainMenuMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        MainMenuMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        MainMenuMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        MainMenuMainPanel.Size = New Size(800, 450)
        MainMenuMainPanel.TabIndex = 1
        ' 
        ' MyAccountBtn
        ' 
        MyAccountBtn.Dock = DockStyle.Fill
        MyAccountBtn.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        MyAccountBtn.Location = New Point(248, 178)
        MyAccountBtn.Margin = New Padding(10)
        MyAccountBtn.Name = "MyAccountBtn"
        MyAccountBtn.Size = New Size(302, 36)
        MyAccountBtn.TabIndex = 6
        MyAccountBtn.Text = "My Account"
        MyAccountBtn.UseVisualStyleBackColor = True
        ' 
        ' WelcomeLabel
        ' 
        WelcomeLabel.Anchor = AnchorStyles.None
        WelcomeLabel.AutoSize = True
        WelcomeLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        WelcomeLabel.Location = New Point(274, 40)
        WelcomeLabel.Name = "WelcomeLabel"
        WelcomeLabel.Size = New Size(250, 32)
        WelcomeLabel.TabIndex = 1
        WelcomeLabel.Text = "Welcome: placeholder"
        ' 
        ' ManageUsersBtn
        ' 
        ManageUsersBtn.Dock = DockStyle.Fill
        ManageUsersBtn.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        ManageUsersBtn.Location = New Point(248, 234)
        ManageUsersBtn.Margin = New Padding(10)
        ManageUsersBtn.Name = "ManageUsersBtn"
        ManageUsersBtn.Size = New Size(302, 36)
        ManageUsersBtn.TabIndex = 5
        ManageUsersBtn.Text = "Manage Users"
        ManageUsersBtn.UseVisualStyleBackColor = True
        ' 
        ' MainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(222), CByte(219), CByte(193))
        ClientSize = New Size(800, 450)
        Controls.Add(MainMenuMainPanel)
        Name = "MainMenu"
        Text = "MainMenu"
        MainMenuMainPanel.ResumeLayout(False)
        MainMenuMainPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MainMenuMainPanel As TableLayoutPanel
    Friend WithEvents WelcomeLabel As Label
    Friend WithEvents ManageUsersBtn As Button
    Friend WithEvents MyAccountBtn As Button
End Class
