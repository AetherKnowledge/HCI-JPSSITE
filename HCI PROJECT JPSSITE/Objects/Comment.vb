Public Class Comment

    Public ReadOnly eventName As String
    Public ReadOnly userName As String
    Public ReadOnly comment As String

    Public Sub New(userName As String, eventName As String, comment As String)
        Me.eventName = eventName
        Me.userName = userName
        Me.comment = comment
    End Sub
End Class
