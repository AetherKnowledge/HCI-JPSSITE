Public Class AdminRatings1
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
            If eval.activitiesQ1 >= 1 AndAlso eval.activitiesQ1 <= 5 Then
                q1(eval.activitiesQ1) += 1
                q1_TotalNum += eval.activitiesQ1
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
            If eval.activitiesQ2 >= 1 AndAlso eval.activitiesQ2 <= 5 Then
                q2(eval.activitiesQ2) += 1
                q2_TotalNum += eval.activitiesQ2
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
            If eval.activitiesQ3 >= 1 AndAlso eval.activitiesQ3 <= 5 Then
                q3(eval.activitiesQ3) += 1
                q3_TotalNum += eval.activitiesQ3
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


        Dim q4(5) As Integer
        Dim q4_TotalNum As Integer
        Dim q4_MeanNum As Integer
        For Each eval As EventEvaluation In evals
            If eval.activitiesQ4 >= 1 AndAlso eval.activitiesQ4 <= 5 Then
                q4(eval.activitiesQ4) += 1
                q4_TotalNum += eval.activitiesQ4
            End If
        Next
        If evals.Count > 0 Then
            q4_MeanNum = q4_TotalNum / evals.Count
        End If

        Q4_5.Text = q4(5).ToString
        Q4_4.Text = q4(4).ToString
        Q4_3.Text = q4(3).ToString
        Q4_2.Text = q4(2).ToString
        Q4_1.Text = q4(1).ToString
        Q4_Total.Text = q4_TotalNum.ToString
        Q4_Mean.Text = q4_TotalNum.ToString
        Q4_Eval.Text = checkSatisfactory(q4_MeanNum)

        Dim q5(5) As Integer
        Dim q5_TotalNum As Integer
        Dim q5_MeanNum As Integer
        For Each eval As EventEvaluation In evals
            If eval.activitiesQ5 >= 1 AndAlso eval.activitiesQ5 <= 5 Then
                q5(eval.activitiesQ5) += 1
                q5_TotalNum += eval.activitiesQ5
            End If
        Next
        If evals.Count > 0 Then
            q5_MeanNum = q5_TotalNum / evals.Count
        End If

        Q5_5.Text = q5(5).ToString
        Q5_4.Text = q5(4).ToString
        Q5_3.Text = q5(3).ToString
        Q5_2.Text = q5(2).ToString
        Q5_1.Text = q5(1).ToString
        Q5_Total.Text = q5_TotalNum.ToString
        Q5_Mean.Text = q5_TotalNum.ToString
        Q5_Eval.Text = checkSatisfactory(q5_MeanNum)

        Dim q6(5) As Integer
        Dim q6_TotalNum As Integer
        Dim q6_MeanNum As Integer
        For Each eval As EventEvaluation In evals
            If eval.activitiesQ6 >= 1 AndAlso eval.activitiesQ6 <= 5 Then
                q6(eval.activitiesQ6) += 1
                q6_TotalNum += eval.activitiesQ6
            End If
        Next
        If evals.Count > 0 Then
            q6_MeanNum = q6_TotalNum / evals.Count
        End If

        Q6_5.Text = q6(5).ToString
        Q6_4.Text = q6(4).ToString
        Q6_3.Text = q6(3).ToString
        Q6_2.Text = q6(2).ToString
        Q6_1.Text = q6(1).ToString
        Q6_Total.Text = q6_TotalNum.ToString
        Q6_Mean.Text = q6_TotalNum.ToString
        Q6_Eval.Text = checkSatisfactory(q6_MeanNum)

        Dim q7(5) As Integer
        Dim q7_TotalNum As Integer
        Dim q7_MeanNum As Integer
        For Each eval As EventEvaluation In evals
            If eval.activitiesQ7 >= 1 AndAlso eval.activitiesQ7 <= 5 Then
                q7(eval.activitiesQ7) += 1
                q7_TotalNum += eval.activitiesQ7
            End If
        Next
        If evals.Count > 0 Then
            q7_MeanNum = q7_TotalNum / evals.Count
        End If

        Q7_5.Text = q7(5).ToString
        Q7_4.Text = q7(4).ToString
        Q7_3.Text = q7(3).ToString
        Q7_2.Text = q7(2).ToString
        Q7_1.Text = q7(1).ToString
        Q7_Total.Text = q7_TotalNum.ToString
        Q7_Mean.Text = q7_TotalNum.ToString
        Q7_Eval.Text = checkSatisfactory(q7_MeanNum)

        Dim q8(5) As Integer
        Dim q8_TotalNum As Integer
        Dim q8_MeanNum As Integer
        For Each eval As EventEvaluation In evals
            If eval.activitiesQ8 >= 1 AndAlso eval.activitiesQ8 <= 5 Then
                q8(eval.activitiesQ8) += 1
                q8_TotalNum += eval.activitiesQ8
            End If
        Next
        If evals.Count > 0 Then
            q8_MeanNum = q8_TotalNum / evals.Count
        End If

        Q8_5.Text = q8(5).ToString
        Q8_4.Text = q8(4).ToString
        Q8_3.Text = q8(3).ToString
        Q8_2.Text = q8(2).ToString
        Q8_1.Text = q8(1).ToString
        Q8_Total.Text = q8_TotalNum.ToString
        Q8_Mean.Text = q8_TotalNum.ToString
        Q8_Eval.Text = checkSatisfactory(q8_MeanNum)
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
        AdminRatings.show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        AdminRatings2.show(eventselectCBox.SelectedItem)
    End Sub
End Class