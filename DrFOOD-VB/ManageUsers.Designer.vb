<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUsers
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
        ManageUsersMainPanel = New TableLayoutPanel()
        BackBtn = New Button()
        AddUserBtn = New Button()
        ManageUsersMainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' ManageUsersMainPanel
        ' 
        ManageUsersMainPanel.AutoSize = True
        ManageUsersMainPanel.BackColor = Color.FromArgb(CByte(222), CByte(219), CByte(193))
        ManageUsersMainPanel.CausesValidation = False
        ManageUsersMainPanel.ColumnCount = 4
        ManageUsersMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        ManageUsersMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        ManageUsersMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        ManageUsersMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        ManageUsersMainPanel.Controls.Add(BackBtn, 0, 0)
        ManageUsersMainPanel.Controls.Add(AddUserBtn, 3, 0)
        ManageUsersMainPanel.Dock = DockStyle.Fill
        ManageUsersMainPanel.Location = New Point(0, 0)
        ManageUsersMainPanel.Name = "ManageUsersMainPanel"
        ManageUsersMainPanel.RowCount = 6
        ManageUsersMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        ManageUsersMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        ManageUsersMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        ManageUsersMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        ManageUsersMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        ManageUsersMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        ManageUsersMainPanel.Size = New Size(800, 450)
        ManageUsersMainPanel.TabIndex = 1
        ' 
        ' BackBtn
        ' 
        BackBtn.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        BackBtn.Location = New Point(3, 3)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(88, 33)
        BackBtn.TabIndex = 4
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' AddUserBtn
        ' 
        AddUserBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        AddUserBtn.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        AddUserBtn.Location = New Point(631, 3)
        AddUserBtn.Name = "AddUserBtn"
        AddUserBtn.Size = New Size(166, 33)
        AddUserBtn.TabIndex = 5
        AddUserBtn.Text = "Add New User"
        AddUserBtn.UseVisualStyleBackColor = True
        ' 
        ' ManageUsers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(222), CByte(219), CByte(193))
        ClientSize = New Size(800, 450)
        Controls.Add(ManageUsersMainPanel)
        Name = "ManageUsers"
        Text = "Manage Users"
        ManageUsersMainPanel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ManageUsersMainPanel As TableLayoutPanel
    Friend WithEvents BackBtn As Button
    Friend WithEvents AddUserBtn As Button
End Class
