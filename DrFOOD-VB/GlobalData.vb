Imports System.Globalization

Public Class GlobalData
    Public Property lbpFormat As New NumberFormatInfo()
    Public Property navigation As NavigationManager
    Public Property currentUser As User
    Public Property userDatabase As UserDatabaseHelper

    Public Sub New()
        lbpFormat.CurrencySymbol = "LBP" ' Set the currency symbol
        lbpFormat.CurrencyDecimalDigits = 0 ' No decimal places for LBP (common practice)
        lbpFormat.CurrencyGroupSeparator = "," ' Use commas for thousands
        lbpFormat.CurrencyPositivePattern = 2 ' Format: 123 LBP
    End Sub
End Class
