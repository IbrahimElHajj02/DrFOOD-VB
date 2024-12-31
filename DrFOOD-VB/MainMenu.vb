Public Class MainMenu
    Private globalData As GlobalData

    Public Sub New(golbalD As GlobalData)
        globalData = golbalD
        InitializeComponent()
    End Sub

    Private Sub Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WelcomeLabel.Text = "Welcome: " + globalData.currentUser.Username

        If globalData.currentUser.Role = UserRoles.Cashier Then
            ManageUsersBtn.Hide()
        End If
    End Sub

    Private Sub ManageUsersBtn_Click(sender As Object, e As EventArgs) Handles ManageUsersBtn.Click
        Dim manageUsers = New ManageUsers(globalData)
        globalData.navigation.NavigateTo(Me, manageUsers)
    End Sub

    Private Sub MyAccountBtn_Click(sender As Object, e As EventArgs) Handles MyAccountBtn.Click
        Dim returnPage = New MainMenu(globalData)
        Dim myAccount = New UserInfo(globalData, globalData.currentUser, returnPage)
        globalData.navigation.NavigateTo(Me, myAccount)
    End Sub
End Class