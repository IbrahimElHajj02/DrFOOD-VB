Public Class MainMenu
    Private golbalData As GlobalData

    Public Sub New(golbalD As GlobalData)
        golbalData = golbalD
        InitializeComponent()
    End Sub

    Private Sub Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class