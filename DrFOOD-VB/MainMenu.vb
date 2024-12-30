Public Class MainMenu
    Private globalData As GlobalData

    Public Sub New(golbalD As GlobalData)
        globalData = golbalD
        InitializeComponent()
        WelcomeLabel.Text = "Welcome: " + globalData.currentUser.Username

        If Not (globalData.currentUser.Role = UserRoles.Owner) Then
            ManageUsersBtn.Hide()
        End If

    End Sub

    Private Sub Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ManageUsersBtn_Click(sender As Object, e As EventArgs) Handles ManageUsersBtn.Click
        Dim manageUsers = New ManageUsers(globalData)
        globalData.navigation.NavigateTo(Me, manageUsers)
    End Sub
End Class