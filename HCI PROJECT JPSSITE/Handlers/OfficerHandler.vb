Imports MySqlConnector

Public Class OfficerHandler

    Private Shared loadedOfficers As Boolean = False
    Private Shared officerList As New ArrayList()
    Private Shared ReadOnly OFFICERS_PATH As String = "officers.sav"

    Public Shared Sub addOfficer(newOfficer As Officer)
        ConnectionHandler.connection.open()
        Try
            Dim query As String = "INSERT into officers(name, img, section, age, sex, achievements, motto) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Dim command As New MySqlCommand(query, ConnectionHandler.connection)

            command.Parameters.AddWithValue(1, newOfficer.name)
            command.Parameters.AddWithValue(2, newOfficer.img)
            command.Parameters.AddWithValue(3, newOfficer.section)
            command.Parameters.AddWithValue(3, newOfficer.age)
            command.Parameters.AddWithValue(3, newOfficer.sex)
            command.Parameters.AddWithValue(3, newOfficer.achievements)
            command.Parameters.AddWithValue(3, newOfficer.motto)

            command.ExecuteNonQuery()
            officerList.Add(newOfficer)
            Console.WriteLine("Officer " + newOfficer.name + "Added")

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try

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
            Dim age As String = reader.GetString("age")
            Dim sex As String = reader.GetString("sex")
            Dim achievements As String = reader.GetString("achievements")
            Dim motto As String = reader.GetString("motto")

            Dim newEvent As Officer = New Officer(name, img, section, age, sex, achievements, motto)
            officerList.Add(newEvent)
        End While

        ConnectionHandler.connection.close()
    End Sub

    Public Shared Function getOfficers() As ArrayList
        getOfficersFromDB()
        Return officerList
    End Function

End Class
