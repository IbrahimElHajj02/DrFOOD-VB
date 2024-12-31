Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class UserInfo
    Private nextForm As Form
    Private globalData As GlobalData
    Private inspectedUser As User
    Private isReadOnly As Boolean
    Private isInsertMode As Boolean

    Public Sub New(golbalD As GlobalData, insUser As User, nextF As Form)
        nextForm = nextF
        globalData = golbalD
        inspectedUser = insUser
        isReadOnly = Not (globalData.currentUser.Role = UserRoles.Owner) And
            globalData.currentUser IsNot inspectedUser
        isInsertMode = (globalData.currentUser.Role = UserRoles.Owner) And
            inspectedUser.Username Is Nothing
        InitializeComponent()
    End Sub

    Private Sub Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add items to the ComboBox
        RoleSelector.Items.Add(UserRoles.Cashier)
        RoleSelector.Items.Add(UserRoles.Supervisor)
        RoleSelector.Items.Add(UserRoles.Owner)

        If inspectedUser.Username IsNot Nothing Then
            Username.Text = inspectedUser.Username
        End If

        If inspectedUser.Role IsNot Nothing Then
            RoleSelector.SelectedIndex = RoleSelector.Items.IndexOf(inspectedUser.Role)
        Else
            RoleSelector.SelectedIndex = 0
        End If
        SalesAmount.Text = inspectedUser.Sales.ToString()


        If Not (globalData.currentUser.Role = UserRoles.Owner) Or
            globalData.currentUser Is inspectedUser Then
            RoleSelector.Enabled = False
        End If

        If isReadOnly Then
            Username.Enabled = False
            RoleSelector.Enabled = False
            PasswordBtn.Hide()
            PasswordLabel.Hide()
            SaveBtn.Hide()
        End If

        If isInsertMode Then
            PasswordBtn.Hide()
            PasswordLabel.Hide()
            SaveBtn.Text = "Save User"
            SaleDetailsButton.Hide()
        End If

    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        globalData.navigation.NavigateTo(Me, nextForm)
    End Sub

    Private Sub PasswordBtn_Click(sender As Object, e As EventArgs) Handles PasswordBtn.Click
        If globalData.currentUser Is inspectedUser Then
            Dim thisFrameCopy = New UserInfo(globalData, inspectedUser, nextForm)
            Dim SetPasswordForm As New ChangePassword(globalData, thisFrameCopy)
            globalData.navigation.NavigateTo(Me, SetPasswordForm)
        Else
            inspectedUser.IsPasswordSet = False
            globalData.userDatabase.UpdateUser(inspectedUser)
            MessageBox.Show("User will be prompted to change password at next login.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        inspectedUser.Username = Username.Text
        inspectedUser.Role = RoleSelector.Text
        If (isInsertMode) Then
            If globalData.userDatabase.AddUser(inspectedUser) Then
                MessageBox.Show("User Added.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                globalData.navigation.NavigateTo(Me, nextForm)
            Else
                MessageBox.Show("Username already in use.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If globalData.userDatabase.UpdateUser(inspectedUser) Then
                MessageBox.Show("Changes Saved.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Username already in use.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class