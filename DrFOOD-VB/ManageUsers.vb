Public Class ManageUsers
    Private globalData As GlobalData
    Private isOwner As Boolean
    Public Sub New(globalD As GlobalData)
        globalData = globalD
        InitializeComponent()
        isOwner = globalData.currentUser.Role = UserRoles.Owner
    End Sub

    Private Sub ManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not isOwner Then
            AddUserBtn.Hide()
        End If
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim mainMenu = New MainMenu(globalData)
        globalData.navigation.NavigateTo(Me, mainMenu)
    End Sub

    Private Sub AddUserBtn_Click(sender As Object, e As EventArgs) Handles AddUserBtn.Click
        Dim newUser = New User()
        Dim copyCurrentForm = New ManageUsers(globalData)
        Dim UserAddForm = New UserInfo(globalData, newUser, copyCurrentForm)
        globalData.navigation.NavigateTo(Me, UserAddForm)
    End Sub
End Class