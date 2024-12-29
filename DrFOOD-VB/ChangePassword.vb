Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class ChangePassword
    Private nextForm As Form
    Private golbalData As GlobalData

    Public Sub New(golbalD As GlobalData, nextF As Form)
        nextForm = nextF
        golbalData = golbalD
        InitializeComponent()
    End Sub

    Private Sub Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim password As String = NewPassword.Text
        Dim again As String = Reenter.Text

        If password = again Then
            golbalData.userDatabase.UpdatePassword(golbalData.currentUser, password)
            golbalData.navigation.NavigateTo(Me, nextForm)
        Else
            MessageBox.Show("Two Fields do not match", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class