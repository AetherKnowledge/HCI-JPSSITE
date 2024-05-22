Imports System.Runtime.Serialization

Public Class User
    Implements IComparable(Of User)

    Public username As String
    Public password As String
    Public firstName As String
    Public surName As String
    Public userID As String
    Public birthDate As Date
    Public courseProgram As String
    Public yearLevel As Integer
    Public sex As String
    Public img As Image

    Public Sub New(username As String, password As String, firstName As String, surName As String, userID As String, birthDate As Date, courseProgram As String, yearLevel As Integer, sex As String, img As Image)
        Me.username = username
        Me.password = password
        Me.firstName = firstName
        Me.surName = surName
        Me.userID = userID
        Me.birthDate = birthDate
        Me.courseProgram = courseProgram
        Me.yearLevel = yearLevel
        Me.sex = sex
        Me.img = img
    End Sub

    Public Overrides Function ToString() As String
        Return courseProgram + "-" + yearLevel.ToString + " - " + firstName + " " + surName
    End Function

    Public Function CompareTo(other As User) As Integer Implements IComparable(Of User).CompareTo
        If other Is Nothing Then
            Return 1
        End If

        Return String.Compare(Me.ToString, other.ToString)
    End Function
End Class
