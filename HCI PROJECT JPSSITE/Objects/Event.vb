Public Class EventObj

    Public ReadOnly eventName As String
    Public ReadOnly eventImg As Image
    Public ReadOnly eventRating As Integer
    Public ReadOnly dateOfEvent As Date
    Public ReadOnly details As String

    Public Sub New(eventName As String, eventImg As Image, eventRating As Integer, dateOfEvent As Date)
        Me.eventName = eventName
        Me.eventImg = eventImg
        Me.eventRating = eventRating
        Me.dateOfEvent = dateOfEvent
    End Sub

    Public Overrides Function ToString() As String
        Return eventName
    End Function
End Class
