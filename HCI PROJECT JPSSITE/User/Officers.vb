Public Class Officers
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
        HCI_PROJECT_JPSSITE.Events.show()
    End Sub

    Private Sub ratingsBtn_Click(sender As Object, e As EventArgs) Handles ratingsBtn.Click
        Me.Hide()
        Ratings.show()
    End Sub

    Shadows Sub show()
        MyBase.Show()
        usernameLabel.Text = UserHandler.getCurrentuser.username
        officerPositionCBox.SelectedIndex = 0
    End Sub

    Private Sub officerPositionCBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles officerPositionCBox.SelectedIndexChanged
        If officerPositionCBox.SelectedIndex <> -1 Then
            Dim officer As Officer = OfficerHandler.getOfficer(officerPositionCBox.SelectedItem)
            If officer Is Nothing Then
                nameLabel.Text = "N/A"
                sectionLabel.Text = "N/A"
                ageLabel.Text = "N/A"
                sexLabel.Text = "N/A"
                officerPBox.Image = My.Resources.upload
                achievementRTBox.Text = "N/A"
                motoRTBox.Text = "N/A"
            Else
                nameLabel.Text = officer.name
                officerPositionCBox.SelectedItem = officer.position
                ageLabel.Text = officer.age.ToString
                sectionLabel.Text = officer.section

                If officer.sex = "M" Then
                    sexLabel.Text = "Male"
                Else
                    sexLabel.Text = "Female"
                End If

                officerPBox.Image = officer.img
                If officer.img Is Nothing Then
                    officerPBox.Image = My.Resources.upload
                End If

                achievementRTBox.Text = officer.achievements
                motoRTBox.Text = officer.motto
            End If

        End If
    End Sub
End Class