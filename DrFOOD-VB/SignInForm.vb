Imports System.Windows

Public Class SignInForm
    Private globalD As GlobalData

    Private Sub Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbPath As String = "database.db"
        globalD = New GlobalData()
        globalD.navigation = New NavigationManager()
        globalD.userDatabase = New UserDatabaseHelper(dbPath)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim user As String = Username.Text
        Dim pass As String = Password.Text

        Dim UserObject As User = globalD.userDatabase.ValidateUser(user, pass)
        If UserObject IsNot Nothing Then

            globalD.currentUser = UserObject
            ' Login successful
            Dim MainMenuForm As New MainMenu(globalD)

            If UserObject.IsPasswordSet Then
                globalD.navigation.NavigateTo(Me, MainMenuForm)
            Else
                Dim SetPasswordForm As New ChangePassword(globalD, MainMenuForm)
                globalD.navigation.NavigateTo(Me, SetPasswordForm)
            End If
        Else
            ' Login failed
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class