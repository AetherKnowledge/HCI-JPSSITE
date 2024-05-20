Public Class Dashboard

    Dim user As User

    Shadows Sub show()
        If user Is Nothing Then
            user = UserHandler.getCurrentuser
        End If
        usernameLabel.Text = user.username
        MyBase.Show()
    End Sub

    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()
    End Sub
    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Hide()
        Login.Show()
    End Sub

    Private Sub profileBtn_Click(sender As Object, e As EventArgs) Handles profileBtn.Click
        Me.Hide()
        Profile.show()
    End Sub

    Private Sub eventsBtn_Click(sender As Object, e As EventArgs) Handles eventsBtn.Click
        Me.Hide()
        HCI_PROJECT_JPSSITE.Events.Show()
    End Sub

    Private Sub ratingsBtn_Click(sender As Object, e As EventArgs) Handles ratingsBtn.Click
        Me.Hide()
        Ratings.Show()
    End Sub

    Private Sub officersBtn_Click(sender As Object, e As EventArgs) Handles officersBtn.Click
        Officers.show()
        Me.Hide()
    End Sub
End Class