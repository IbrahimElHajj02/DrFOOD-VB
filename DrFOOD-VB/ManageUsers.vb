Public Class ManageUsers
    Private globalData As GlobalData

    Public Sub New(globalD As GlobalData)
        globalData = globalD
        InitializeComponent()
    End Sub

    Private Sub ManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim mainMenu = New MainMenu(globalData)
        globalData.navigation.NavigateTo(Me, mainMenu)
    End Sub
End Class