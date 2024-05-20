Imports System.Runtime.Serialization

Public Class User

    Public username As String
    Public password As String
    Public firstName As String
    Public surName As String
    Public userID As String
    Public birthDate As Date
    Public courseProgram As String
    Public yearLevel As Integer

    Public Sub New(username As String, password As String, firstName As String, surName As String, userID As String, birthDate As Date, courseProgram As String, yearLevel As Integer)
        Me.username = username
        Me.password = password
        Me.firstName = firstName
        Me.surName = surName
        Me.userID = userID
        Me.birthDate = birthDate
        Me.courseProgram = courseProgram
        Me.yearLevel = yearLevel
    End Sub
End Class
