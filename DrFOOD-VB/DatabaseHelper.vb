Imports System.Data.SQLite
Imports System.IO

Public Class DatabaseHelper
    Protected connectionString As String

    Public Sub New(dbPath As String)
        connectionString = $"Data Source={dbPath};Version=3;"
        InitializeDatabase(dbPath)
    End Sub

    ' Initialize the database and create the Users table if it doesn't exist
    Private Sub InitializeDatabase(dbPath As String)
        If Not File.Exists(dbPath) Then
            SQLiteConnection.CreateFile(dbPath) ' Create a new database file.
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                ' Create Users table
                Dim createTableQuery As String = "
                    CREATE TABLE Users (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT,
                        IsPasswordSet INTEGER NOT NULL DEFAULT 0,
                        Role TEXT,
                        Sales REAL NOT NULL DEFAULT 0.0
                    );"
                Using cmd As New SQLiteCommand(createTableQuery, connection)
                    cmd.ExecuteNonQuery()
                End Using

                ' Insert default user (Owner)
                Dim query As String = "
                    INSERT INTO Users (Username, Role) 
                    VALUES (@username, @Role)"
                Using cmd As New SQLiteCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", "Owner")
                    cmd.Parameters.AddWithValue("@Role", UserRoles.Owner)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End If
    End Sub

End Class