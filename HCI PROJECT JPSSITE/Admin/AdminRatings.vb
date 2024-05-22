Public Class AdminRatings

    Private starRating As StarRating
    Public Shared selectedEvent As String = ""

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Hide()
        Login.show()
    End Sub
    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        Me.Hide()
        AdminDashboard.show()
    End Sub

    Private Sub profileBtn_Click(sender As Object, e As EventArgs) Handles profileBtn.Click
        Me.Hide()
        AdminProfile.show()
    End Sub

    Private Sub eventsBtn_Click(sender As Object, e As EventArgs) Handles eventsBtn.Click
        Me.Hide()
        HCI_PROJECT_JPSSITE.AdminEvents.show()
    End Sub

    Private Sub officersBtn_Click(sender As Object, e As EventArgs) Handles officersBtn.Click
        Me.Hide()
        AdminOfficers.show()
    End Sub

    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()
    End Sub

    Shadows Sub show()
        MyBase.Show()
        usernameLabel.Text = UserHandler.getCurrentuser.username
        eventpicPBox.Image = My.Resources.upload
        loadEvents()
        loadComments()
        If eventselectCBox.Items.Count > 0 Then
            eventselectCBox.SelectedIndex = 0
        End If
        Timer1.Enabled = True
    End Sub

    Shadows Sub hide()
        MyBase.Hide()
        Timer1.Enabled = False
    End Sub

    Private Sub loadEvents()
        eventselectCBox.Items.Clear()
        eventpicPBox.Image = My.Resources.upload
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
            starRating.Rating = EventEvaluationHandler.getTotalRating(selectedEvent)
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

    Private Sub Ratings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        starRating = New StarRating()
        starRating.NumberOfStars = 5
        starRating.Location = New Point(75, 273)
        Panel4.Controls.Add(starRating)

        Timer1.Interval = 1000
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        loadComments()
    End Sub

    Private Sub showrateBtn_Click(sender As Object, e As EventArgs) Handles showrateBtn.Click
        If selectedEvent = "" Then
            MessageBox.Show("Select Event to Rate")
        Else
            Me.Hide()
            AdminRatings1.show(selectedEvent)
        End If
    End Sub
End Class