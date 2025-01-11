Imports System.ComponentModel.DataAnnotations

Public Class ManageUsers
    Private globalData As GlobalData
    Private isOwner As Boolean
    Private isDeleted As Boolean
    Public Sub New(globalD As GlobalData, isDeletedUsers As Boolean)
        globalData = globalD
        isDeleted = isDeletedUsers
        InitializeComponent()
        isOwner = globalData.currentUser.Role = UserRoles.Owner
    End Sub

    Private Sub ManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not isOwner Or isDeleted Then
            AddUserBtn.Hide()
            DeletedUsersBtn.Hide()
        End If

        PopulateUserGrid(globalData.userDatabase.GetAllUsers(Not isDeleted))
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        If Not isDeleted Then
            Dim mainMenu = New MainMenu(globalData)
            globalData.navigation.NavigateTo(Me, mainMenu)
        Else
            Dim deletedUserForm = New ManageUsers(globalData, False) 'go back to normal view
            globalData.navigation.NavigateTo(Me, deletedUserForm)
        End If

    End Sub

    Private Sub AddUserBtn_Click(sender As Object, e As EventArgs) Handles AddUserBtn.Click
        Dim newUser = New User()
        Dim copyCurrentForm = New ManageUsers(globalData, isDeleted)
        Dim UserAddForm = New UserInfo(globalData, newUser, copyCurrentForm)
        globalData.navigation.NavigateTo(Me, UserAddForm)
    End Sub

    Private Sub PopulateUserGrid(users As List(Of User))
        Dim firstButtonText As String
        If globalData.currentUser.Role = UserRoles.Owner And Not isDeleted Then
            firstButtonText = "Edit"
        Else
            firstButtonText = "Info"
            UserDataView.Columns(4).Visible = False
        End If
        For Each user As User In users
            Dim rowIndex As Integer = UserDataView.Rows.Add(user.Username, user.Role, user.Sales.ToString("C", globalData.lbpFormat),
                                                            firstButtonText, "Delete")
            UserDataView.Rows(rowIndex).Tag = user
        Next
    End Sub

    Private Sub userGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDataView.CellContentClick
        If e.ColumnIndex = 3 Then 'clicked edit
            Dim selectedUser As User = CType(UserDataView.Rows(e.RowIndex).Tag, User)
            Dim copyCurrentForm = New ManageUsers(globalData, isDeleted)
            Dim UserEditForm = New UserInfo(globalData, selectedUser, copyCurrentForm)
            globalData.navigation.NavigateTo(Me, UserEditForm)
        ElseIf e.ColumnIndex = 4 Then
            Dim selectedUser As User = CType(UserDataView.Rows(e.RowIndex).Tag, User)
            selectedUser.Role = UserRoles.Deleted
            globalData.userDatabase.UpdateUser(selectedUser)
            Dim copyCurrentForm = New ManageUsers(globalData, isDeleted) 'janky refresh
            globalData.navigation.NavigateTo(Me, copyCurrentForm)
        End If
    End Sub

    Private Sub DeletedUsersBtn_Click(sender As Object, e As EventArgs) Handles DeletedUsersBtn.Click
        Dim deletedUserForm = New ManageUsers(globalData, True)
        globalData.navigation.NavigateTo(Me, deletedUserForm)
    End Sub
End Class