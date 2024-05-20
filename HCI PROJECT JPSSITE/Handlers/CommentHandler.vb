Imports MySqlConnector

Public Class CommentHandler

    Private Shared loadedComments As Boolean = False
    Private Shared commentList As New ArrayList()
    Private Shared ReadOnly COMMENTS_PATH As String = "comments.sav"

    Public Shared Sub addComment(newComment As Comment)
        ConnectionHandler.connection.open()
        Try
            Dim query As String = "INSERT into comments(username, eventName, comment) VALUES (?, ?, ?)"
            Dim command As New MySqlCommand(query, ConnectionHandler.connection)

            command.Parameters.AddWithValue(1, newComment.userName)
            command.Parameters.AddWithValue(2, newComment.eventName)
            command.Parameters.AddWithValue(3, newComment.comment)

            command.ExecuteNonQuery()
            commentList.Add(newComment)
            Console.WriteLine(newComment.userName + " Commented to " + newComment.eventName)

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try

        ConnectionHandler.connection.close()
    End Sub

    Private Shared Sub getCommentsFromDB()
        commentList.Clear()

        ConnectionHandler.connection.open()
        Dim query As String = "SELECT * FROM comments"
        Dim command As New MySqlCommand(query, ConnectionHandler.connection)
        Dim reader As MySqlDataReader = command.ExecuteReader()

        While reader.Read
            Dim commentUsername As String = reader.GetString("username")
            Dim commentEventName As String = reader.GetString("eventName")
            Dim comment As String = reader.GetString("comment")
            Dim newEvent As Comment = New Comment(commentUsername, commentEventName, comment)
            commentList.Add(newEvent)
        End While

        ConnectionHandler.connection.close()
    End Sub

    Public Shared Function getCommentsFromEvent(eventName As String) As ArrayList
        getCommentsFromDB()
        Dim comments As ArrayList = New ArrayList
        For Each comment As Comment In commentList
            If comment.eventName = eventName Then
                comments.Add(comment)
            End If
        Next

        Return comments
    End Function

    Public Shared Function getComments() As ArrayList
        getCommentsFromDB()
        Return commentList
    End Function

End Class
