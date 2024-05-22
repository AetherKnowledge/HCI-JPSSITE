Public Class AdminRatings3
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

    Shadows Sub show(selectedEvent As String)
        MyBase.Show()
        loadEvents()
        eventselectCBox.SelectedItem = selectedEvent
    End Sub

    Private Sub loadEvents()
        eventselectCBox.Items.Clear()
        Dim eventList As ArrayList = EventHandler.getEvents()
        For Each ev As EventObj In eventList
            eventselectCBox.Items.Add(ev.ToString)
        Next
    End Sub

    Private Sub changeSelectedEvent(selectedEvent As String)
        Dim evals As List(Of EventEvaluation) = New List(Of EventEvaluation)
        For Each eval As EventEvaluation In EventEvaluationHandler.getEvaluationsFromEvent(selectedEvent)
            If eval.dateSubmitted.Year = DateTimePicker1.Value.Year And eval.dateSubmitted.Month = DateTimePicker1.Value.Month Then
                evals.Add(eval)
            End If
        Next

        Dim q1(5) As Integer
        Dim q1_TotalNum As Integer
        Dim q1_MeanNum As Integer

        For Each eval As EventEvaluation In evals
            If eval.overallQ1_1 >= 1 AndAlso eval.overallQ1_1 <= 5 Then
                q1(eval.overallQ1_1) += 1
                q1_TotalNum += eval.overallQ1_1
            End If
        Next
        If evals.Count > 0 Then
            q1_MeanNum = q1_TotalNum / evals.Count
        End If

        Q1_5.Text = q1(5).ToString
        Q1_4.Text = q1(4).ToString
        Q1_3.Text = q1(3).ToString
        Q1_2.Text = q1(2).ToString
        Q1_1.Text = q1(1).ToString
        Q1_Total.Text = q1_TotalNum.ToString
        Q1_Mean.Text = q1_TotalNum.ToString
        Q1_Eval.Text = checkSatisfactory(q1_MeanNum)

        Dim q2(5) As Integer
        Dim q2_TotalNum As Integer
        Dim q2_MeanNum As Integer
        For Each eval As EventEvaluation In evals
            If eval.overallQ1_2 >= 1 AndAlso eval.overallQ1_2 <= 5 Then
                q2(eval.overallQ1_2) += 1
                q2_TotalNum += eval.overallQ1_2
            End If
        Next
        If evals.Count > 0 Then
            q2_MeanNum = q2_TotalNum / evals.Count
        End If

        Q2_5.Text = q2(5).ToString
        Q2_4.Text = q2(4).ToString
        Q2_3.Text = q2(3).ToString
        Q2_2.Text = q2(2).ToString
        Q2_1.Text = q2(1).ToString
        Q2_Total.Text = q2_TotalNum.ToString
        Q2_Mean.Text = q2_TotalNum.ToString
        Q2_Eval.Text = checkSatisfactory(q2_MeanNum)

        Dim q3(5) As Integer
        Dim q3_TotalNum As Integer
        Dim q3_MeanNum As Integer
        For Each eval As EventEvaluation In evals
            If eval.overallQ2 >= 1 AndAlso eval.overallQ2 <= 5 Then
                q3(eval.overallQ2) += 1
                q3_TotalNum += eval.overallQ2
            End If
        Next
        If evals.Count > 0 Then
            q3_MeanNum = q3_TotalNum / evals.Count
        End If

        Q3_5.Text = q3(5).ToString
        Q3_4.Text = q3(4).ToString
        Q3_3.Text = q3(3).ToString
        Q3_2.Text = q3(2).ToString
        Q3_1.Text = q3(1).ToString
        Q3_Total.Text = q3_TotalNum.ToString
        Q3_Mean.Text = q3_TotalNum.ToString
        Q3_Eval.Text = checkSatisfactory(q3_MeanNum)

    End Sub

    Public Function checkSatisfactory(mean As Integer) As String
        If mean = 5 Then
            Return "Excellent"
        ElseIf mean = 4 Then
            Return "Good"
        ElseIf mean = 3 Then
            Return "Fair"
        ElseIf mean = 2 Then
            Return "Poor"
        ElseIf mean = 1 Then
            Return "Very Poor"
        End If

        Return "N/A"
    End Function

    Private Sub eventselectCBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles eventselectCBox.SelectedIndexChanged
        changeSelectedEvent(eventselectCBox.SelectedItem)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        changeSelectedEvent(eventselectCBox.SelectedItem)
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        AdminRatings2.show(eventselectCBox.SelectedItem)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        AdminRatings.show()
    End Sub
End Class