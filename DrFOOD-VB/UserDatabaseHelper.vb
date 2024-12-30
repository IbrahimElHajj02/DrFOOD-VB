Imports System.Data.SQLite
Imports System.Text
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class UserDatabaseHelper
    Inherits DatabaseHelper

    Public Sub New(dbPath As String)
        MyBase.New(dbPath)
        InitialiseOwnerAccount()
    End Sub

    Private Function InitialiseOwnerAccount()
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT * FROM Users WHERE Username = 'Owner'"
            Using cmd As New SQLiteCommand(query, connection)
                Dim scalar = cmd.ExecuteScalar()
                If scalar Is Nothing Then
                    Dim OwnerAccount = New User()
                    OwnerAccount.Username = "Owner"
                    OwnerAccount.Role = UserRoles.Owner
                    AddUser(OwnerAccount)
                End If
            End Using
        End Using
    End Function


    ' Hash a password using SHA-256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    ' Insert a new user into the database
    Public Function AddUser(user As User) As Boolean
        Try
            Using connection As New SQLiteConnection(MyBase.connectionString)
                connection.Open()
                Dim query As String = "
                    INSERT INTO Users (Username, Role, Sales) 
                    VALUES (@username, @Role, @sales)"
                Using cmd As New SQLiteCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", user.Username)
                    cmd.Parameters.AddWithValue("@Role", user.Role)
                    cmd.Parameters.AddWithValue("@sales", user.Sales)
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
            Dim query As String = "SELECT * FROM Users WHERE Username = @username"
            Using cmd As New SQLiteCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", username)

                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim savedPassword = If(reader.IsDBNull(reader.GetOrdinal("Password")),
                            String.Empty,
                            reader.GetString(reader.GetOrdinal("Password"))
                            )
                        If reader.GetInt32(reader.GetOrdinal("IsPasswordSet")) = 0 Or
                            savedPassword = HashPassword(password) Then
                            Return New User() With {
                            .ID = reader.GetInt32(reader.GetOrdinal("ID")),
                            .Username = reader.GetString(reader.GetOrdinal("Username")),
                            .IsPasswordSet = reader.GetInt32(reader.GetOrdinal("IsPasswordSet")) = 1,
                            .Role = reader.GetString(reader.GetOrdinal("Role")),
                            .Sales = reader.GetDouble(reader.GetOrdinal("Sales"))
                        }
                        End If
                    End If
                End Using
            End Using
        End Using
        Return Nothing ' Return Nothing if the user is not found
    End Function

    ' Update a user's password
    Public Sub UpdatePassword(user As User, newPassword As String)
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Dim hashedPassword As String = HashPassword(newPassword)
            Dim query As String = "
                UPDATE Users 
                SET Password = @Password,
                    IsPasswordSet = 1
                WHERE Id = @Id"
            Using command As New SQLiteCommand(query, connection)
                command.Parameters.AddWithValue("@Password", hashedPassword)
                command.Parameters.AddWithValue("@Id", user.ID)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Update all user data except password
    Public Sub UpdateUser(user As User)
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Dim query As String = "
                UPDATE Users 
                SET Username = @Username, 
                    IsSupervisor = @IsSupervisor, 
                    IsOwner = @IsOwner, 
                    Sales = @Sales 
                WHERE Id = @Id"
            Using command As New SQLiteCommand(query, connection)
                command.Parameters.AddWithValue("@Username", user.Username)
                command.Parameters.AddWithValue("@Role", user.Role)
                command.Parameters.AddWithValue("@Sales", user.Sales)
                command.Parameters.AddWithValue("@Id", user.ID)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
