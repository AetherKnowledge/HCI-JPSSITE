Public Class Ratings3

    Public Shared overallQ1_1 As Integer
    Public Shared overallQ1_2 As Integer
    Public Shared overallQ2 As Integer

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
        Officers.show()
        Me.Hide()
    End Sub

    Shadows Sub show()
        MyBase.Show()
        usernameLabel.Text = UserHandler.getCurrentuser.username
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        If q1CBox.SelectedIndex = -1 Then
            MessageBox.Show("Please Rate All Items")
            Return
        ElseIf q2CBox.SelectedIndex = -1 Then
            MessageBox.Show("Please Rate All Items")
            Return
        ElseIf q3CBox.SelectedIndex = -1 Then
            MessageBox.Show("Please Rate All Items")
            Return
        End If

        overallQ1_1 = q1CBox.SelectedIndex + 1
        overallQ1_2 = q2CBox.SelectedIndex + 1
        overallQ2 = q3CBox.SelectedIndex + 1

        Dim eventName As String = Ratings.selectedEvent
        Dim username As String = UserHandler.getCurrentuser.username
        Dim q1 As Integer = Ratings1.activitiesQ1
        Dim q2 As Integer = Ratings1.activitiesQ2
        Dim q3 As Integer = Ratings1.activitiesQ3
        Dim q4 As Integer = Ratings1.activitiesQ4
        Dim q5 As Integer = Ratings1.activitiesQ5
        Dim q6 As Integer = Ratings1.activitiesQ6
        Dim q7 As Integer = Ratings1.activitiesQ7
        Dim q8 As Integer = Ratings1.activitiesQ8
        Dim q9 As Integer = Ratings2.speakersQ1
        Dim q10 As Integer = Ratings2.speakersQ2
        Dim q11 As Integer = Ratings2.speakersQ3
        Dim q12 As Integer = Ratings2.speakersQ4
        Dim q13 As Integer = Ratings2.speakersQ5
        Dim q14 As Integer = Ratings2.speakersQ6
        Dim q15 As Integer = overallQ1_1
        Dim q16 As Integer = overallQ1_2
        Dim q17 As Integer = overallQ2

        Dim eval As EventEvaluation = New EventEvaluation(eventName, username, q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, Date.Now)
        EventEvaluationHandler.addEvaluations(eval)
        MessageBox.Show("Rating " + Ratings.selectedEvent + " Complete")

        Me.Hide()
        Ratings.show()
    End Sub
End Class