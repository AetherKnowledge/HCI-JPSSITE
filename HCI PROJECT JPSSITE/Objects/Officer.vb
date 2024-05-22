Public Class Officer

    Public ReadOnly name As String
    Public ReadOnly img As Image
    Public ReadOnly section As String
    Public ReadOnly age As Integer
    Public ReadOnly sex As String
    Public ReadOnly achievements As String
    Public ReadOnly motto As String
    Public ReadOnly position As String

    Public Sub New(name As String, img As Image, section As String, age As Integer, sex As String, achievements As String, motto As String, position As String)
        Me.name = name
        Me.img = img
        Me.section = section
        Me.age = age
        Me.sex = sex
        Me.achievements = achievements
        Me.motto = motto
        Me.position = position
    End Sub
End Class
