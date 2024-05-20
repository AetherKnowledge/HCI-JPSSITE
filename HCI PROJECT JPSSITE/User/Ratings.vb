Imports System.Diagnostics.Tracing

Public Class Ratings

    Public Shared selectedEvent As String = ""

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Hide()
        Login.show()
    End Sub
    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        Me.Hide()
        Dashboard.show()
    End Sub

    Private Sub profileBtn_Click(sender As Object, e As EventArgs) Handles profileBtn.Click
        Me.Hide()
        Profile.show()
    End Sub

    Private Sub eventsBtn_Click(sender As Object, e As EventArgs) Handles eventsBtn.Click
        Me.Hide()
        HCI_PROJECT_JPSSITE.Events.show()
    End Sub

    Private Sub officersBtn_Click(sender As Object, e As EventArgs) Handles officersBtn.Click
        Me.Hide()
        Officers.show()
    End Sub

    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()
    End Sub

    Shadows Sub show()
        MyBase.Show()
        usernameLabel.Text = UserHandler.getCurrentuser.username
        loadEvents()
        loadComments()
    End Sub

    Private Sub loadEvents()
        eventselectCBox.Items.Clear()
        Dim eventList As ArrayList = EventHandler.getEvents()
        For Each ev As EventObj In eventList
            eventselectCBox.Items.Add(ev.ToString)
        Next
    End Sub

    Private Sub loadComments()
        allcommentRTBox.Clear()
        Dim comments As ArrayList = CommentHandler.getCommentsFromEvent(selectedEvent)
        For Each comment As Comment In comments
            allcommentRTBox.AppendText(comment.userName + " : " + comment.comment + vbCrLf)
        Next
    End Sub

    Private Sub eventselectCBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles eventselectCBox.SelectedIndexChanged
        If eventselectCBox.SelectedIndex <> -1 Then
            selectedEvent = eventselectCBox.SelectedItem
            loadComments()
        End If
    End Sub

    Private Sub rateBtn_Click(sender As Object, e As EventArgs) Handles rateBtn.Click
        If selectedEvent = "" Then
            MessageBox.Show("Select Event to Rate")
        Else
            Me.Hide()
            Ratings1.show()
        End If
    End Sub

    Private Sub sendBtn_Click(sender As Object, e As EventArgs) Handles sendBtn.Click
        If selectedEvent = "" Then
            MessageBox.Show("Select Event to Comment on")
            Return
        End If
        CommentHandler.addComment(New Comment(UserHandler.getCurrentuser.username, selectedEvent, yourcommentRTBox.Text))
        loadComments()
    End Sub
End Class