Public Class Events
    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Hide()
        Login.Show()
    End Sub
    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        Me.Hide()
        Dashboard.show()
    End Sub

    Private Sub officersBtn_Click(sender As Object, e As EventArgs) Handles officersBtn.Click
        Me.Hide()
        Officers.show()
    End Sub

    Private Sub profileBtn_Click(sender As Object, e As EventArgs) Handles profileBtn.Click
        Me.Hide()
        Profile.show()
    End Sub

    Private Sub ratingsBtn_Click(sender As Object, e As EventArgs) Handles ratingsBtn.Click
        Me.Hide()
        Ratings.Show()
    End Sub

    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()
    End Sub

    Shadows Sub show()
        MyBase.Show()
        usernameLabel.Text = UserHandler.getCurrentuser.username
        loadEvents()
    End Sub

    Private Sub eventCal_DateChanged(sender As Object, e As DateRangeEventArgs) Handles eventCal.DateChanged
        loadEvents()
    End Sub

    Private Sub loadEvents()
        eventLBox.Items.Clear()
        event2LBox.Items.Clear()

        Dim dateOfEvent As Date = eventCal.SelectionRange.Start
        Dim events As ArrayList = EventHandler.getEvents()
        For Each eventObj As EventObj In events
            If eventObj.dateOfEvent >= dateOfEvent Then
                eventLBox.Items.Add(eventObj.eventName)
            Else
                event2LBox.Items.Add(eventObj.eventName)
            End If
        Next

    End Sub
End Class