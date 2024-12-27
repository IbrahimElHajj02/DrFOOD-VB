Imports System.Windows

Public Class SignInForm
    Private dbHelper As DatabaseHelper

    Private Sub Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbPath As String = "database.db"
        dbHelper = New DatabaseHelper(dbPath)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim user As String = Username.Text
        Dim pass As String = Password.Text

        Dim UserObject As User = dbHelper.ValidateUser(user, pass)
        If UserObject IsNot Nothing Then
            ' Login successful
            Dim MainMenuForm As New MainMenu()
            MainMenuForm.Show()
            Me.Hide()
        Else
            ' Login failed
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class