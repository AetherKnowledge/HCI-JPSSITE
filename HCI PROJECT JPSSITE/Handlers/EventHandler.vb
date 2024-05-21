Imports System.Globalization
Imports System.IO
Imports System.Text.Json
Imports MySqlConnector

Public Class EventHandler

    Private Shared loadedEvents As Boolean = False
    Private Shared eventList As New ArrayList()
    Private Shared ReadOnly EVENTS_PATH As String = "users.sav"

    Public Shared Sub addEvent(newEvent As EventObj)
        ConnectionHandler.connection.open()
        Try
            Dim query As String = "INSERT into events(eventName, eventImg, eventRating, dateOfEvent) VALUES (?, ?, ?, ?)"
            Dim command As New MySqlCommand(query, ConnectionHandler.connection)

            command.Parameters.AddWithValue(1, newEvent.eventName)
            command.Parameters.AddWithValue(2, AdminEvents.imageBytes)
            command.Parameters.AddWithValue(3, newEvent.eventRating)
            command.Parameters.AddWithValue(4, newEvent.dateOfEvent.ToString("yyyy-MM-dd HH:mm:ss"))

            command.ExecuteNonQuery()
            eventList.Add(newEvent)
            Console.WriteLine(newEvent.eventName + " Added")

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try

        ConnectionHandler.connection.close()
    End Sub

    Public Shared Sub updateEvent(newEvent As EventObj, oldEventName As String)
        ConnectionHandler.connection.open()
        Try
            Dim query As String = "UPDATE events SET eventName = ?, eventImg = ?, eventRating = ?, dateOfEvent = ? WHERE username = ?"
            Dim command As New MySqlCommand(query, ConnectionHandler.connection)

            Dim formattedDateTime As String = newEvent.ToString("yyyy-MM-dd")
            command.Parameters.AddWithValue(1, newEvent.eventName)
            command.Parameters.AddWithValue(2, newEvent.eventImg)
            command.Parameters.AddWithValue(3, newEvent.eventRating)
            command.Parameters.AddWithValue(4, newEvent.dateOfEvent.ToString("yyyy-MM-dd HH:mm:ss"))
            command.Parameters.AddWithValue(5, oldEventName)

            command.ExecuteNonQuery()
            Console.WriteLine(oldEventName + " Changed")

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try
        ConnectionHandler.connection.close()
    End Sub

    Private Shared Sub getEventsFromDB()
        eventList.Clear()

        ConnectionHandler.connection.open()
        Dim query As String = "SELECT * FROM events"
        Dim command As New MySqlCommand(query, ConnectionHandler.connection)
        Dim reader As MySqlDataReader = command.ExecuteReader()

        While reader.Read

            Dim eventName As String = reader.GetString("eventName")
            Dim eventRating As Integer = reader.GetInt32("eventRating")
            Dim dateString As String = reader("dateOfEvent").ToString()
            Dim dateOfEvent As Date = Date.Parse(dateString)

            Dim eventImg As Image

            If Not reader.IsDBNull(reader.GetOrdinal("eventImg")) Then
                Dim byteArray As Byte() = DirectCast(reader("eventImg"), Byte())
                Dim imageStream As New System.IO.MemoryStream(byteArray)
                eventImg = Image.FromStream(imageStream)
            Else
                eventImg = My.Resources.upload
            End If

            Dim newEvent As EventObj = New EventObj(eventName, eventImg, eventRating, dateOfEvent)
            eventList.Add(newEvent)
        End While

        ConnectionHandler.connection.close()
    End Sub

    Public Shared Function getEvents() As ArrayList
        getEventsFromDB()
        Return eventList
    End Function

    Public Shared Function getEventsFromDate(dateOfEvent As Date) As ArrayList
        getEventsFromDB()
        Dim events As ArrayList = New ArrayList
        For Each eventObj As EventObj In eventList
            If eventObj.dateOfEvent >= dateOfEvent Then
                events.Add(eventObj)
            End If
        Next
        Return events
    End Function

    Public Shared Function getEvent(eventName As String) As EventObj
        For Each eventObj As EventObj In eventList
            If eventObj.eventName = eventName Then
                Return eventObj
            End If
        Next
        Return Nothing
    End Function

End Class
