Public Class AdminRatings1

    Private eval As List(Of EventEvaluation)
    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()
    End Sub

    Shadows Sub show(selectedEvent As String)
        MyBase.Show()
        Me.eval = EventEvaluationHandler.getEvaluationsFromEvent(selectedEvent)



    End Sub

End Class