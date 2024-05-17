Public Class Utilities
    Public Shared Function containsSpecial(text As String) As Boolean
        For Each ch As Char In text
            If Not Char.IsLetter(ch) And Not Char.IsNumber(ch) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Shared Function containsUppercase(text As String) As Boolean
        For Each ch As Char In text
            If Char.IsUpper(ch) Then
                Return True
            End If
        Next
        Return False
    End Function
End Class
