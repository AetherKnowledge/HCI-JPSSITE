Public Class EventObj

    Public ReadOnly eventName As String
    Public ReadOnly eventImg As Image
    Public ReadOnly eventRating As Integer

    Public Sub New(eventName As String, eventImg As Image, eventRating As Integer)
        Me.eventName = eventName
        Me.eventImg = eventImg
        Me.eventRating = eventRating
    End Sub

    Public Overrides Function ToString() As String
        Return eventName
    End Function
End Class
