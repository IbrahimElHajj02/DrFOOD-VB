Imports System.Data.SQLite
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class DatabaseHelper
    Private connectionString As String

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
                        Password TEXT NOT NULL,
                        IsAdmin INTEGER NOT NULL DEFAULT 0,
                        IsOwner INTEGER NOT NULL DEFAULT 0,
                        Sales REAL NOT NULL DEFAULT 0.0
                    );"
                Using cmd As New SQLiteCommand(createTableQuery, connection)
                    cmd.ExecuteNonQuery()
                End Using

                ' Insert default user (Owner)
                AddUser("Owner", "password", True, True, 0.0)
            End Using
        End If
    End Sub

    ' Hash a password using SHA-256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    ' Insert a new user into the database
    Public Function AddUser(username As String, password As String, isAdmin As Boolean, isOwner As Boolean, sales As Double) As Boolean
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim query As String = "
                    INSERT INTO Users (Username, Password, IsAdmin, IsOwner, Sales) 
                    VALUES (@username, @password, @isAdmin, @isOwner, @sales)"
                Using cmd As New SQLiteCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", HashPassword(password))
                    cmd.Parameters.AddWithValue("@isAdmin", If(isAdmin, 1, 0))
                    cmd.Parameters.AddWithValue("@isOwner", If(isOwner, 1, 0))
                    cmd.Parameters.AddWithValue("@sales", sales)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As SQLiteException When ex.ErrorCode = SQLiteErrorCode.Constraint
            ' Handle unique constraint violation
            Return False
        End Try
    End Function

    ' Validate user credentials and return user data if valid
    Public Function ValidateUser(username As String, password As String) As User
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT * FROM Users WHERE Username = @username AND Password = @password"
            Using cmd As New SQLiteCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", HashPassword(password))
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Return New User() With {
                            .ID = reader.GetInt32(reader.GetOrdinal("ID")),
                            .Username = reader.GetString(reader.GetOrdinal("Username")),
                            .IsAdmin = reader.GetInt32(reader.GetOrdinal("IsAdmin")) = 1,
                            .IsOwner = reader.GetInt32(reader.GetOrdinal("IsOwner")) = 1,
                            .Sales = reader.GetDouble(reader.GetOrdinal("Sales"))
                        }
                    End If
                End Using
            End Using
        End Using
        Return Nothing ' Return Nothing if the user is not found
    End Function
End Class