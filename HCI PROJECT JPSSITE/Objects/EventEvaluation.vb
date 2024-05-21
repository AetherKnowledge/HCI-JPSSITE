Public Class EventEvaluation

    Public eventName As String
    Public userName As String

    Public ReadOnly activitiesQ1 As Integer
    Public ReadOnly activitiesQ2 As Integer
    Public ReadOnly activitiesQ3 As Integer
    Public ReadOnly activitiesQ4 As Integer
    Public ReadOnly activitiesQ5 As Integer
    Public ReadOnly activitiesQ6 As Integer
    Public ReadOnly activitiesQ7 As Integer
    Public ReadOnly activitiesQ8 As Integer

    Public ReadOnly speakersQ1 As Integer
    Public ReadOnly speakersQ2 As Integer
    Public ReadOnly speakersQ3 As Integer
    Public ReadOnly speakersQ4 As Integer
    Public ReadOnly speakersQ5 As Integer
    Public ReadOnly speakersQ6 As Integer

    Public ReadOnly overallQ1_1 As Integer
    Public ReadOnly overallQ1_2 As Integer
    Public ReadOnly overallQ2 As Integer

    Public ReadOnly dateSubmitted As Date

    Public Sub New(eventName As String, userName As String, activitiesQ1 As Integer, activitiesQ2 As Integer, activitiesQ3 As Integer, activitiesQ4 As Integer, activitiesQ5 As Integer, activitiesQ6 As Integer, activitiesQ7 As Integer, activitiesQ8 As Integer, speakersQ1 As Integer, speakersQ2 As Integer, speakersQ3 As Integer, speakersQ4 As Integer, speakersQ5 As Integer, speakersQ6 As Integer, overallQ1_1 As Integer, overallQ1_2 As Integer, overallQ2 As Integer, dateSubmitted As Date)
        Me.eventName = eventName
        Me.userName = userName
        Me.activitiesQ1 = activitiesQ1
        Me.activitiesQ2 = activitiesQ2
        Me.activitiesQ3 = activitiesQ3
        Me.activitiesQ4 = activitiesQ4
        Me.activitiesQ5 = activitiesQ5
        Me.activitiesQ6 = activitiesQ6
        Me.activitiesQ7 = activitiesQ7
        Me.activitiesQ8 = activitiesQ8
        Me.speakersQ1 = speakersQ1
        Me.speakersQ2 = speakersQ2
        Me.speakersQ3 = speakersQ3
        Me.speakersQ4 = speakersQ4
        Me.speakersQ5 = speakersQ5
        Me.speakersQ6 = speakersQ6
        Me.overallQ1_1 = overallQ1_1
        Me.overallQ1_2 = overallQ1_2
        Me.overallQ2 = overallQ2
        Me.dateSubmitted = dateSubmitted
    End Sub

    Public Function getActivitiesMean() As Integer
        Dim activitiesTotal As String = activitiesQ1 + activitiesQ2 + activitiesQ3 + activitiesQ4 + activitiesQ5 + activitiesQ6 + activitiesQ7 + activitiesQ8
        Return activitiesTotal / 8
    End Function

    Public Function getSpeakersMean() As Integer
        Dim speakersTotal As String = speakersQ1 + speakersQ2 + speakersQ3 + speakersQ4 + speakersQ5 + speakersQ6
        Return speakersTotal / 6
    End Function

    Public Function getOverallMean() As Integer
        Dim overallTotal As String = overallQ1_1 + overallQ1_2 + overallQ2
        Return overallTotal / 3
    End Function

    Public Function getTotalMean() As Integer
        Dim total As String = getActivitiesMean() + getSpeakersMean() + getOverallMean()
        Return total / 3
    End Function

End Class
