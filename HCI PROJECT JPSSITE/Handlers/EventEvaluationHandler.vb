Imports MySqlConnector

Public Class EventEvaluationHandler
    Private Shared loadedEvaluations As Boolean = False
    Private Shared evaluationList As New ArrayList()
    Private Shared ReadOnly EVALUATION_PATH As String = "evaluation.sav"

    Public Shared Sub addEvaluations(newEvaluation As EventEvaluation)
        ConnectionHandler.connection.open()
        Try
            Dim query As String = "INSERT into eventevaluations(username, eventName, activitiesQ1, activitiesQ2, activitiesQ3, activitiesQ4, activitiesQ5, activitiesQ6, activitiesQ7, activitiesQ8, speakersQ1, speakersQ2, speakersQ3, speakersQ4, speakersQ5, speakersQ6, overallQ1_1, overallQ1_2, overallQ2) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Dim command As New MySqlCommand(query, ConnectionHandler.connection)

            command.Parameters.AddWithValue(1, newEvaluation.userName)
            command.Parameters.AddWithValue(2, newEvaluation.eventName)
            command.Parameters.AddWithValue(3, newEvaluation.activitiesQ1)
            command.Parameters.AddWithValue(4, newEvaluation.activitiesQ2)
            command.Parameters.AddWithValue(5, newEvaluation.activitiesQ3)
            command.Parameters.AddWithValue(6, newEvaluation.activitiesQ4)
            command.Parameters.AddWithValue(7, newEvaluation.activitiesQ5)
            command.Parameters.AddWithValue(8, newEvaluation.activitiesQ6)
            command.Parameters.AddWithValue(9, newEvaluation.activitiesQ7)
            command.Parameters.AddWithValue(10, newEvaluation.activitiesQ8)

            command.Parameters.AddWithValue(11, newEvaluation.speakersQ1)
            command.Parameters.AddWithValue(12, newEvaluation.speakersQ2)
            command.Parameters.AddWithValue(13, newEvaluation.speakersQ3)
            command.Parameters.AddWithValue(14, newEvaluation.speakersQ4)
            command.Parameters.AddWithValue(15, newEvaluation.speakersQ5)
            command.Parameters.AddWithValue(16, newEvaluation.speakersQ6)

            command.Parameters.AddWithValue(17, newEvaluation.overallQ1_1)
            command.Parameters.AddWithValue(18, newEvaluation.overallQ1_2)
            command.Parameters.AddWithValue(19, newEvaluation.overallQ2)

            command.ExecuteNonQuery()
            evaluationList.Add(newEvaluation)
            Console.WriteLine(newEvaluation.userName + " Commented to " + newEvaluation.eventName)

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try

        ConnectionHandler.connection.close()
    End Sub

    Private Shared Sub getEvaluationsFromDB()
        evaluationList.Clear()

        ConnectionHandler.connection.open()
        Dim query As String = "SELECT * FROM eventevaluations"
        Dim command As New MySqlCommand(query, ConnectionHandler.connection)
        Dim reader As MySqlDataReader = command.ExecuteReader()

        While reader.Read
            Dim username As String = reader.GetString("username")
            Dim eventName As String = reader.GetString("eventName")
            Dim comment As String = reader.GetString("comment")

            Dim activitiesQ1 As Integer = reader.GetInt32("activitiesQ1")
            Dim activitiesQ2 As Integer = reader.GetInt32("activitiesQ2")
            Dim activitiesQ3 As Integer = reader.GetInt32("activitiesQ3")
            Dim activitiesQ4 As Integer = reader.GetInt32("activitiesQ4")
            Dim activitiesQ5 As Integer = reader.GetInt32("activitiesQ5")
            Dim activitiesQ6 As Integer = reader.GetInt32("activitiesQ6")
            Dim activitiesQ7 As Integer = reader.GetInt32("activitiesQ7")
            Dim activitiesQ8 As Integer = reader.GetInt32("activitiesQ8")

            Dim speakersQ1 As Integer = reader.GetInt32("speakersQ1")
            Dim speakersQ2 As Integer = reader.GetInt32("speakersQ2")
            Dim speakersQ3 As Integer = reader.GetInt32("speakersQ3")
            Dim speakersQ4 As Integer = reader.GetInt32("speakersQ4")
            Dim speakersQ5 As Integer = reader.GetInt32("speakersQ5")
            Dim speakersQ6 As Integer = reader.GetInt32("speakersQ6")

            Dim overallQ1_1 As Integer = reader.GetInt32("overallQ1_1")
            Dim overallQ1_2 As Integer = reader.GetInt32("overallQ1_2")
            Dim overallQ2 As Integer = reader.GetInt32("overallQ2")

            Dim newEvent As EventEvaluation = New EventEvaluation(eventName, username, activitiesQ1, activitiesQ2, activitiesQ3, activitiesQ4, activitiesQ5, activitiesQ6, activitiesQ7, activitiesQ8, speakersQ1, speakersQ2, speakersQ3, speakersQ4, speakersQ5, speakersQ6, overallQ1_1, overallQ1_2, overallQ2)
            evaluationList.Add(newEvent)
        End While

        ConnectionHandler.connection.close()
    End Sub

    Public Shared Function getEvaluationsFromEvent(eventName As String) As ArrayList
        getEvaluationsFromDB()
        Dim evaluations As ArrayList = New ArrayList
        For Each evaluation As EventEvaluation In evaluationList
            If evaluation.eventName = eventName Then
                evaluations.Add(evaluation)
            End If
        Next
        Return evaluations
    End Function

    Public Shared Function getEvaluationsFromEventAndUser(eventName As String, username As String) As ArrayList
        getEvaluationsFromDB()
        Dim evaluations As ArrayList = New ArrayList
        For Each evaluation As EventEvaluation In evaluationList
            If evaluation.eventName = eventName And evaluation.userName = username Then
                evaluations.Add(evaluation)
            End If
        Next
        Return evaluations
    End Function

    Public Shared Function getEvaluations() As ArrayList
        getEvaluationsFromDB()
        Return evaluationList
    End Function
End Class
