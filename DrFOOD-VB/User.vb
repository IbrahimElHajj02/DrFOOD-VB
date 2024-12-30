Public Class User
    Public Property ID As Integer
    Public Property Username As String
    Public Property IsPasswordSet As Boolean
    Public Property Role As String
    Public Property Sales As Double
End Class

Module UserRoles
    ' Define constants
    Public Const Owner As String = "owner"
    Public Const Supervisor As String = "supervisor"
    Public Const Cashier As String = "cashier"
End Module