Imports MySqlConnector

Public Class OfficerHandler

    Private Shared loadedOfficers As Boolean = False
    Private Shared officerList As New ArrayList()
    Private Shared ReadOnly OFFICERS_PATH As String = "officers.sav"

    Public Shared Sub addOfficer(newOfficer As Officer)
        ConnectionHandler.connection.open()
        Try
            Dim query As String = "INSERT into officers(name, img, section, age, sex, achievements, motto, position) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
            Dim command As New MySqlCommand(query, ConnectionHandler.connection)

            command.Parameters.AddWithValue(1, newOfficer.name)
            command.Parameters.AddWithValue(2, AdminOfficers.imageBytes)
            command.Parameters.AddWithValue(3, newOfficer.section)
            command.Parameters.AddWithValue(4, newOfficer.age)
            command.Parameters.AddWithValue(5, newOfficer.sex)
            command.Parameters.AddWithValue(6, newOfficer.achievements)
            command.Parameters.AddWithValue(7, newOfficer.motto)
            command.Parameters.AddWithValue(8, newOfficer.position)

            command.ExecuteNonQuery()
            officerList.Add(newOfficer)
            Console.WriteLine("Officer " + newOfficer.name + "Added")

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try

        ConnectionHandler.connection.close()
    End Sub

    Private Shared Function doesExist(position As String) As Boolean
        ConnectionHandler.connection.open()
        Dim query As String = "SELECT * FROM officers WHERE position = '" + position + "'"
        Dim command As New MySqlCommand(query, ConnectionHandler.connection)

        Dim reader As MySqlDataReader = command.ExecuteReader()
        While reader.Read
            Return True
        End While

        ConnectionHandler.connection.close()
        Return False
    End Function

    Public Shared Sub updateOfficer(newOfficer As Officer)
        If Not doesExist(newOfficer.position) Then
            addOfficer(newOfficer)
            ConnectionHandler.connection.close()
            Return
        End If
        ConnectionHandler.connection.close()
        ConnectionHandler.connection.open()
        Dim query As String = "UPDATE officers SET name = ?, img = ?, section = ?, age = ?, sex = ?, achievements = ?, motto = ? WHERE position = ?"
        Dim command As New MySqlCommand(query, ConnectionHandler.connection)

        command.Parameters.AddWithValue(1, newOfficer.name)
        command.Parameters.AddWithValue(2, AdminOfficers.imageBytes)
        command.Parameters.AddWithValue(3, newOfficer.section)
        command.Parameters.AddWithValue(4, newOfficer.age)
        command.Parameters.AddWithValue(5, newOfficer.sex)
        command.Parameters.AddWithValue(6, newOfficer.achievements)
        command.Parameters.AddWithValue(7, newOfficer.motto)
        command.Parameters.AddWithValue(8, newOfficer.position)
        command.ExecuteNonQuery()
        Console.WriteLine("Officer " + newOfficer.name + "Added")

        For Each officer As Officer In officerList
            If officer.position = newOfficer.position Then
                officer = newOfficer
            End If
        Next

        ConnectionHandler.connection.close()
    End Sub

    Private Shared Sub getOfficersFromDB()
        officerList.Clear()

        ConnectionHandler.connection.open()
        Dim query As String = "SELECT * FROM officers"
        Dim command As New MySqlCommand(query, ConnectionHandler.connection)
        Dim reader As MySqlDataReader = command.ExecuteReader()

        While reader.Read
            Dim name As String = reader.GetString("name")
            Dim img As Image = Nothing
            Dim section As String = reader.GetString("section")
            Dim age As String = reader.GetInt32("age")
            Dim sex As String = reader.GetString("sex")
            Dim achievements As String = reader.GetString("achievements")
            Dim motto As String = reader.GetString("motto")
            Dim position As String = reader.GetString("position")

            Dim newEvent As Officer = New Officer(name, img, section, age, sex, achievements, motto, position)
            officerList.Add(newEvent)
        End While

        ConnectionHandler.connection.close()
    End Sub

    Public Shared Function getOfficers() As ArrayList
        getOfficersFromDB()
        Return officerList
    End Function

    Public Shared Function getOfficer(position As String) As Officer
        getOfficersFromDB()
        For Each officer As Officer In officerList
            If officer.position = position Then
                Return officer
            End If
        Next
        Return Nothing
    End Function

End Class
