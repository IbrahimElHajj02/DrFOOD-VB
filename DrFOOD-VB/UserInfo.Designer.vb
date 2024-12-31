<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInfo
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
        SignInMainPanel = New TableLayoutPanel()
        PasswordLabel = New Label()
        UsernameLabel = New Label()
        BackBtn = New Button()
        Username = New TextBox()
        PasswordBtn = New Button()
        SaveBtn = New Button()
        RoleLabel = New Label()
        RoleSelector = New ComboBox()
        SalesLabel = New Label()
        SalesAmount = New Label()
        SaleDetailsButton = New Button()
        SignInMainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' SignInMainPanel
        ' 
        SignInMainPanel.AutoSize = True
        SignInMainPanel.BackColor = Color.FromArgb(CByte(222), CByte(219), CByte(193))
        SignInMainPanel.CausesValidation = False
        SignInMainPanel.ColumnCount = 7
        SignInMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.408329F))
        SignInMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.6055517F))
        SignInMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.6055517F))
        SignInMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.76194334F))
        SignInMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.6051445F))
        SignInMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.6051445F))
        SignInMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.408329F))
        SignInMainPanel.Controls.Add(UsernameLabel, 1, 1)
        SignInMainPanel.Controls.Add(BackBtn, 0, 0)
        SignInMainPanel.Controls.Add(Username, 2, 1)
        SignInMainPanel.Controls.Add(SaveBtn, 1, 4)
        SignInMainPanel.Controls.Add(SalesLabel, 4, 1)
        SignInMainPanel.Controls.Add(SalesAmount, 5, 1)
        SignInMainPanel.Controls.Add(SaleDetailsButton, 4, 2)
        SignInMainPanel.Controls.Add(RoleLabel, 1, 2)
        SignInMainPanel.Controls.Add(RoleSelector, 2, 2)
        SignInMainPanel.Controls.Add(PasswordLabel, 1, 3)
        SignInMainPanel.Controls.Add(PasswordBtn, 2, 3)
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
        SignInMainPanel.TabIndex = 1
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Anchor = AnchorStyles.None
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordLabel.Location = New Point(169, 239)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(96, 25)
        PasswordLabel.TabIndex = 1
        PasswordLabel.Text = "Password: "
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Anchor = AnchorStyles.None
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        UsernameLabel.Location = New Point(167, 127)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(100, 25)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "Username: "
        ' 
        ' BackBtn
        ' 
        BackBtn.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        BackBtn.Location = New Point(3, 3)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(88, 33)
        BackBtn.TabIndex = 5
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' Username
        ' 
        Username.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Username.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Username.Location = New Point(274, 124)
        Username.Name = "Username"
        Username.Size = New Size(102, 31)
        Username.TabIndex = 6
        ' 
        ' PasswordBtn
        ' 
        PasswordBtn.Anchor = AnchorStyles.None
        PasswordBtn.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordBtn.Location = New Point(274, 235)
        PasswordBtn.Name = "PasswordBtn"
        PasswordBtn.Size = New Size(102, 33)
        PasswordBtn.TabIndex = 7
        PasswordBtn.Text = "Reset"
        PasswordBtn.UseVisualStyleBackColor = True
        ' 
        ' SaveBtn
        ' 
        SaveBtn.Anchor = AnchorStyles.None
        SignInMainPanel.SetColumnSpan(SaveBtn, 2)
        SaveBtn.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        SaveBtn.Location = New Point(196, 291)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(150, 33)
        SaveBtn.TabIndex = 4
        SaveBtn.Text = "Save  changes"
        SaveBtn.UseVisualStyleBackColor = True
        ' 
        ' RoleLabel
        ' 
        RoleLabel.Anchor = AnchorStyles.None
        RoleLabel.AutoSize = True
        RoleLabel.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        RoleLabel.Location = New Point(189, 183)
        RoleLabel.Name = "RoleLabel"
        RoleLabel.Size = New Size(55, 25)
        RoleLabel.TabIndex = 8
        RoleLabel.Text = "Role: "
        ' 
        ' RoleSelector
        ' 
        RoleSelector.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        RoleSelector.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        RoleSelector.FormattingEnabled = True
        RoleSelector.Location = New Point(274, 180)
        RoleSelector.Name = "RoleSelector"
        RoleSelector.Size = New Size(102, 31)
        RoleSelector.TabIndex = 9
        ' 
        ' SalesLabel
        ' 
        SalesLabel.Anchor = AnchorStyles.None
        SalesLabel.AutoSize = True
        SalesLabel.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        SalesLabel.Location = New Point(440, 127)
        SalesLabel.Name = "SalesLabel"
        SalesLabel.Size = New Size(61, 25)
        SalesLabel.TabIndex = 10
        SalesLabel.Text = "Sales: "
        ' 
        ' SalesAmount
        ' 
        SalesAmount.Anchor = AnchorStyles.None
        SalesAmount.AutoSize = True
        SalesAmount.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        SalesAmount.Location = New Point(548, 127)
        SalesAmount.Name = "SalesAmount"
        SalesAmount.Size = New Size(62, 25)
        SalesAmount.TabIndex = 11
        SalesAmount.Text = "12345"
        ' 
        ' SaleDetailsButton
        ' 
        SaleDetailsButton.Anchor = AnchorStyles.None
        SignInMainPanel.SetColumnSpan(SaleDetailsButton, 2)
        SaleDetailsButton.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        SaleDetailsButton.Location = New Point(470, 179)
        SaleDetailsButton.Name = "SaleDetailsButton"
        SaleDetailsButton.Size = New Size(110, 33)
        SaleDetailsButton.TabIndex = 12
        SaleDetailsButton.Text = "Details"
        SaleDetailsButton.UseVisualStyleBackColor = True
        ' 
        ' UserInfo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(222), CByte(219), CByte(193))
        ClientSize = New Size(800, 450)
        Controls.Add(SignInMainPanel)
        Name = "UserInfo"
        Text = "UserInfo"
        SignInMainPanel.ResumeLayout(False)
        SignInMainPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SignInMainPanel As TableLayoutPanel
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents BackBtn As Button
    Friend WithEvents Username As TextBox
    Friend WithEvents PasswordBtn As Button
    Friend WithEvents RoleLabel As Label
    Friend WithEvents RoleSelector As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SalesLabel As Label
    Friend WithEvents SalesAmount As Label
    Friend WithEvents SaleDetailsButton As Button
End Class
