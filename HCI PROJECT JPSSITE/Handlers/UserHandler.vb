Imports System.IO
Imports System.Text.Json
Imports Microsoft.Extensions.Logging
Imports MySqlConnector

Public Class UserHandler

    Private Shared loadedUsers As Boolean = False
    Private Shared usersList As New List(Of User)
    Private Shared currentUser As User
    Private Shared ReadOnly USERS_PATH As String = "users.sav"

    Public Shared Sub addUser(newUser As User)
        ConnectionHandler.connection.open()
        Try
            Dim query As String = "INSERT into users(username, password, firstname, surname, userID, birthDate, courseProgram, yearLevel, sex, img) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Dim command As New MySqlCommand(query, ConnectionHandler.connection)

            command.Parameters.AddWithValue(1, newUser.username)
            command.Parameters.AddWithValue(2, newUser.password)
            command.Parameters.AddWithValue(3, newUser.firstName)
            command.Parameters.AddWithValue(4, newUser.surName)
            command.Parameters.AddWithValue(5, newUser.userID)
            command.Parameters.AddWithValue(6, newUser.birthDate.ToString("yyyy-MM-dd HH:mm:ss"))
            command.Parameters.AddWithValue(7, newUser.courseProgram)
            command.Parameters.AddWithValue(8, newUser.yearLevel)
            command.Parameters.AddWithValue(9, newUser.sex)
            command.Parameters.AddWithValue(10, newUser.img)

            command.ExecuteNonQuery()
            usersList.Add(newUser)
            Console.WriteLine(newUser.firstName + " " + newUser.surName + " Added")

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try

        ConnectionHandler.connection.close()
    End Sub

    Public Shared Sub removeUser(user As User)
        ConnectionHandler.connection.open()
        Try
            Dim query As String = "DELETE FROM users WHERE username = '" + user.username + "'"
            Dim command As New MySqlCommand(query, ConnectionHandler.connection)
            command.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try

        ConnectionHandler.connection.close()
    End Sub

    Public Shared Sub updateUser(newUser As User, oldUsername As String)
        ConnectionHandler.connection.open()
        Try
            Dim query As String = "UPDATE users SET username = ?, password = ?, firstname = ?, surname = ?, userID = ?, birthDate = ?, courseProgram = ?, yearLevel = ?, sex = ?, img = ? WHERE username = ?"
            Dim command As New MySqlCommand(query, ConnectionHandler.connection)

            command.Parameters.AddWithValue(1, newUser.username)
            command.Parameters.AddWithValue(2, newUser.password)
            command.Parameters.AddWithValue(3, newUser.firstName)
            command.Parameters.AddWithValue(4, newUser.surName)
            command.Parameters.AddWithValue(5, newUser.userID)
            command.Parameters.AddWithValue(6, newUser.birthDate.ToString("yyyy-MM-dd HH:mm:ss"))
            command.Parameters.AddWithValue(7, newUser.courseProgram)
            command.Parameters.AddWithValue(8, newUser.yearLevel)
            command.Parameters.AddWithValue(9, newUser.sex)
            command.Parameters.AddWithValue(10, newUser.img)
            command.Parameters.AddWithValue(11, oldUsername)

            command.ExecuteNonQuery()
            For Each user As User In usersList
                If user.username Is oldUsername Then
                    user = newUser
                    Exit For
                End If
            Next

            currentUser = newUser
            Console.WriteLine(oldUsername + " Changed")

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try
        ConnectionHandler.connection.close()
    End Sub

    Public Shared Sub getUsersFromDB()
        usersList.Clear()
        ConnectionHandler.connection.open()
        Dim query As String = "SELECT * FROM users"
        Dim command As New MySqlCommand(query, ConnectionHandler.connection)
        Dim reader As MySqlDataReader = command.ExecuteReader()

        While reader.Read
            Dim username As String = reader.GetString("username")
            Dim password As String = reader.GetString("password")
            Dim firstName As String = reader.GetString("firstName")
            Dim surName As String = reader.GetString("surName")
            Dim userID As String = reader.GetString("userID")
            Dim birthDate As Date = reader.GetDateTime("birthDate")
            Dim courseProgram As String = reader.GetString("courseProgram")
            Dim yearLevel As Integer = reader.GetInt32("yearLevel")
            Dim sex As String = reader.GetString("sex")

            Dim img As Image
            If Not reader.IsDBNull(reader.GetOrdinal("img")) Then
                Dim byteArray As Byte() = DirectCast(reader("img"), Byte())
                Dim imageStream As New System.IO.MemoryStream(byteArray)
                img = Image.FromStream(imageStream)
            Else
                img = My.Resources.circle_user1
            End If

            Dim newUser As User = New User(username, password, firstName, surName, userID, birthDate, courseProgram, yearLevel, sex, img)
            usersList.Add(newUser)
        End While

        ConnectionHandler.connection.close()
    End Sub

    Public Shared Function containsUserDuplicate(newUser As User)
        For Each user As User In usersList
            If user.username = newUser.username Then
                MessageBox.Show("User Already Exists")
                Return True
            End If
        Next
        Return False
    End Function

    Public Shared Function isLoginSuccessful(username As String, password As String) As Boolean
        For Each user As User In usersList
            If user.username = username And user.password = password Then
                currentUser = user
                Return True
            End If
        Next
        Return False
    End Function

    Public Shared Function getUsers() As List(Of User)
        Return usersList
    End Function

    Public Shared Function getCurrentuser() As User
        Return currentUser
    End Function

End Class
