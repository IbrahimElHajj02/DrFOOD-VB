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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        ManageUsersMainPanel = New TableLayoutPanel()
        BackBtn = New Button()
        AddUserBtn = New Button()
        UserDataView = New DataGridView()
        Username = New DataGridViewTextBoxColumn()
        Role = New DataGridViewTextBoxColumn()
        Sales = New DataGridViewTextBoxColumn()
        Edit = New DataGridViewButtonColumn()
        Delete = New DataGridViewButtonColumn()
        DeletedUsersBtn = New Button()
        ManageUsersMainPanel.SuspendLayout()
        CType(UserDataView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ManageUsersMainPanel
        ' 
        ManageUsersMainPanel.AutoSize = True
        ManageUsersMainPanel.BackColor = Color.FromArgb(CByte(222), CByte(219), CByte(193))
        ManageUsersMainPanel.CausesValidation = False
        ManageUsersMainPanel.ColumnCount = 4
        ManageUsersMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 21.2048187F))
        ManageUsersMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.5F))
        ManageUsersMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.875F))
        ManageUsersMainPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 21.2048187F))
        ManageUsersMainPanel.Controls.Add(BackBtn, 0, 0)
        ManageUsersMainPanel.Controls.Add(AddUserBtn, 3, 0)
        ManageUsersMainPanel.Controls.Add(UserDataView, 1, 1)
        ManageUsersMainPanel.Controls.Add(DeletedUsersBtn, 1, 5)
        ManageUsersMainPanel.Dock = DockStyle.Fill
        ManageUsersMainPanel.Location = New Point(0, 0)
        ManageUsersMainPanel.Name = "ManageUsersMainPanel"
        ManageUsersMainPanel.RowCount = 6
        ManageUsersMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 19.11111F))
        ManageUsersMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 18.2222214F))
        ManageUsersMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        ManageUsersMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        ManageUsersMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 19.11111F))
        ManageUsersMainPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 19.5555553F))
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
        AddUserBtn.Location = New Point(632, 3)
        AddUserBtn.Name = "AddUserBtn"
        AddUserBtn.Size = New Size(165, 33)
        AddUserBtn.TabIndex = 5
        AddUserBtn.Text = "Add New User"
        AddUserBtn.UseVisualStyleBackColor = True
        ' 
        ' UserDataView
        ' 
        UserDataView.AllowUserToAddRows = False
        UserDataView.AllowUserToDeleteRows = False
        UserDataView.BackgroundColor = Color.FromArgb(CByte(222), CByte(219), CByte(193))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(222), CByte(219), CByte(193))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(222), CByte(219), CByte(193))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        UserDataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        UserDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        UserDataView.Columns.AddRange(New DataGridViewColumn() {Username, Role, Sales, Edit, Delete})
        ManageUsersMainPanel.SetColumnSpan(UserDataView, 2)
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(222), CByte(219), CByte(193))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(222), CByte(219), CByte(193))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        UserDataView.DefaultCellStyle = DataGridViewCellStyle2
        UserDataView.Dock = DockStyle.Fill
        UserDataView.Location = New Point(173, 88)
        UserDataView.Name = "UserDataView"
        UserDataView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(222), CByte(219), CByte(193))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(222), CByte(219), CByte(193))
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        UserDataView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        ManageUsersMainPanel.SetRowSpan(UserDataView, 4)
        UserDataView.RowTemplate.Height = 25
        UserDataView.Size = New Size(453, 270)
        UserDataView.TabIndex = 6
        ' 
        ' Username
        ' 
        Username.HeaderText = "User Name"
        Username.Name = "Username"
        Username.ReadOnly = True
        ' 
        ' Role
        ' 
        Role.HeaderText = "Role"
        Role.Name = "Role"
        Role.ReadOnly = True
        Role.Width = 80
        ' 
        ' Sales
        ' 
        Sales.HeaderText = "Sales"
        Sales.Name = "Sales"
        Sales.ReadOnly = True
        Sales.Width = 120
        ' 
        ' Edit
        ' 
        Edit.HeaderText = ""
        Edit.Name = "Edit"
        Edit.ReadOnly = True
        Edit.Text = "Edit"
        Edit.Width = 50
        ' 
        ' Delete
        ' 
        Delete.HeaderText = ""
        Delete.Name = "Delete"
        Delete.ReadOnly = True
        Delete.Text = "Delete"
        Delete.Width = 50
        ' 
        ' DeletedUsersBtn
        ' 
        DeletedUsersBtn.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        DeletedUsersBtn.Location = New Point(173, 364)
        DeletedUsersBtn.Name = "DeletedUsersBtn"
        DeletedUsersBtn.Size = New Size(165, 33)
        DeletedUsersBtn.TabIndex = 7
        DeletedUsersBtn.Text = "Deleted Users"
        DeletedUsersBtn.UseVisualStyleBackColor = True
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
        CType(UserDataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ManageUsersMainPanel As TableLayoutPanel
    Friend WithEvents BackBtn As Button
    Friend WithEvents AddUserBtn As Button
    Friend WithEvents UserDataView As DataGridView
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents Role As DataGridViewTextBoxColumn
    Friend WithEvents Sales As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents DeletedUsersBtn As Button
End Class
