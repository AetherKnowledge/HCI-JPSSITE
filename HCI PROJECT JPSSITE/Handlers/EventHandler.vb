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
            Dim query As String = "INSERT into events(eventName, eventImg, eventRating) VALUES (?, ?, ?)"
            Dim command As New MySqlCommand(query, ConnectionHandler.connection)

            command.Parameters.AddWithValue(1, newEvent.eventName)
            command.Parameters.AddWithValue(2, newEvent.eventImg)
            command.Parameters.AddWithValue(3, newEvent.eventRating)

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
            Dim query As String = "UPDATE events SET eventName = ?, eventImg = ?, eventRating = ? WHERE username = ?"
            Dim command As New MySqlCommand(query, ConnectionHandler.connection)

            command.Parameters.AddWithValue(1, newEvent.eventName)
            command.Parameters.AddWithValue(2, newEvent.eventImg)
            command.Parameters.AddWithValue(3, newEvent.eventRating)
            command.Parameters.AddWithValue(4, oldEventName)

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
            Dim eventImg As Image = Nothing
            Dim eventRating As Integer = reader.GetInt32("eventRating")
            Dim newEvent As EventObj = New EventObj(eventName, eventImg, eventRating)
            eventList.Add(newEvent)
        End While

        ConnectionHandler.connection.close()
    End Sub

    Public Shared Function getEvents() As ArrayList
        getEventsFromDB()
        Return eventList
    End Function

End Class
