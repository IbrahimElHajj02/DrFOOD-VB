Imports System.ComponentModel.DataAnnotations

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

        PopulateUserGrid(globalData.userDatabase.GetAllUsers())
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

    Private Sub PopulateUserGrid(users As List(Of User))
        Dim firstButtonText As String
        If globalData.currentUser.Role = UserRoles.Owner Then
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
        If e.ColumnIndex = 3 Then ' Assuming the button column is at index 2
            Dim selectedUser As User = CType(UserDataView.Rows(e.RowIndex).Tag, User)
            Dim copyCurrentForm = New ManageUsers(globalData)
            Dim UserAddForm = New UserInfo(globalData, selectedUser, copyCurrentForm)
            globalData.navigation.NavigateTo(Me, UserAddForm)
        End If
    End Sub

End Class