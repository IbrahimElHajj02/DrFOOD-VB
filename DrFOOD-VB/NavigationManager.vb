Public Class NavigationManager
    ' Push the current form onto the stack
    Public Sub NavigateTo(currentForm As Form, nextForm As Form)
        currentForm.Controls.Clear()
        nextForm.TopLevel = False
        nextForm.FormBorderStyle = FormBorderStyle.None
        nextForm.Dock = DockStyle.Fill
        currentForm.Controls.Add(nextForm)
        nextForm.Show()
    End Sub

End Class
