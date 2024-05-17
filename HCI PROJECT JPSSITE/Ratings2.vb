Public Class Ratings2
    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Hide()
        Login.Show()
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
        HCI_PROJECT_JPSSITE.Events.Show()
    End Sub

    Private Sub officersBtn_Click(sender As Object, e As EventArgs) Handles officersBtn.Click
        Me.Hide()
    End Sub

    Shadows Sub show()
        MyBase.Show()
        usernameLabel.Text = UserHandler.getCurrentuser.username
    End Sub
End Class