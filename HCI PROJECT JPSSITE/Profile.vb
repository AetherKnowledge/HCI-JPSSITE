Public Class Profile
    Shadows Sub show()
        MyBase.Show()
        fullnameLabel.Text = UserHandler.getCurrentuser.firstName + " " + UserHandler.getCurrentuser.surName
        usernameLabel.Text = UserHandler.getCurrentuser.username
        userIDLabel.Text = UserHandler.getCurrentuser.userID
        usrnameLabel.Text = UserHandler.getCurrentuser.username
        courselabel.Text = UserHandler.getCurrentuser.courseProgram
        yearLabel.Text = UserHandler.getCurrentuser.yearLevel
        passLabel.Text = "*******"

        firstnameField.Text = UserHandler.getCurrentuser.firstName
        surnameField.Text = UserHandler.getCurrentuser.firstName
        usernameField.Text = UserHandler.getCurrentuser.username
        birthDateField.Value = UserHandler.getCurrentuser.birthDate
        passwordField.Text = "Password"
    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        Me.Hide()
        Dashboard.show()
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
        Me.Hide()
        Dashboard.show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()
    End Sub
End Class