Public Class Ratings1

    Public Shared activitiesQ1 As Integer
    Public Shared activitiesQ2 As Integer
    Public Shared activitiesQ3 As Integer
    Public Shared activitiesQ4 As Integer
    Public Shared activitiesQ5 As Integer
    Public Shared activitiesQ6 As Integer
    Public Shared activitiesQ7 As Integer
    Public Shared activitiesQ8 As Integer

    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()
    End Sub

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
        Dashboard.show()
    End Sub

    Shadows Sub show()
        MyBase.Show()
        usernameLabel.Text = UserHandler.getCurrentuser.username
    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        If q1CBox.SelectedIndex = -1 Then
            MessageBox.Show("Please Rate All Items")
            Return
        ElseIf q2CBox.SelectedIndex = -1 Then
            MessageBox.Show("Please Rate All Items")
            Return
        ElseIf q3CBox.SelectedIndex = -1 Then
            MessageBox.Show("Please Rate All Items")
            Return
        ElseIf q4CBox.SelectedIndex = -1 Then
            MessageBox.Show("Please Rate All Items")
            Return
        ElseIf q5CBox.SelectedIndex = -1 Then
            MessageBox.Show("Please Rate All Items")
            Return
        ElseIf q6CBox.SelectedIndex = -1 Then
            MessageBox.Show("Please Rate All Items")
            Return
        ElseIf q7CBox.SelectedIndex = -1 Then
            MessageBox.Show("Please Rate All Items")
            Return
        ElseIf q8CBox.SelectedIndex = -1 Then
            MessageBox.Show("Please Rate All Items")
            Return
        End If

        activitiesQ1 = q1CBox.SelectedIndex + 1
        activitiesQ2 = q2CBox.SelectedIndex + 1
        activitiesQ3 = q3CBox.SelectedIndex + 1
        activitiesQ4 = q4CBox.SelectedIndex + 1
        activitiesQ5 = q5CBox.SelectedIndex + 1
        activitiesQ6 = q6CBox.SelectedIndex + 1
        activitiesQ7 = q7CBox.SelectedIndex + 1
        activitiesQ8 = q8CBox.SelectedIndex + 1

        Me.Hide()
        Ratings2.show()
    End Sub
End Class