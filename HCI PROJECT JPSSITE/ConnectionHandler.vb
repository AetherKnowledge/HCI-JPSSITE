﻿Imports System.Net
Imports MySqlConnector
Public Class ConnectionHandler

    Public Shared ReadOnly connection = startConnection()

    Private Shared Function startConnection()
        Dim fullAddress() As String = getTCPAddress.Split(":"c)
        Dim tcp As String = fullAddress.GetValue(0)
        Dim port As String = fullAddress.GetValue(1)

        Dim conString As String = "server=" + tcp + ";Port=" + port + ";user id=wew;password=ruX4q1pvt8Rxck4n;database=jpssite"
        Dim con As New MySqlConnection(conString)

        con.Open()
        Return con
    End Function

    Public Shared Function getTCPAddress() As String
        ' URL of the HTML file with .txt extension
        Dim url As String = "https://related-seemingly-goose.ngrok-free.app/ip.txt"

        ' Create a WebClient instance
        Dim client As New WebClient()

        Try
            ' Download the content of the file into a string
            Dim htmlContent As String = client.DownloadString(url)
            Console.WriteLine(htmlContent)
            ' Print the content to the console (for demonstration)

            Return htmlContent
        Catch ex As Exception
            ' Handle any errors
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return ""
    End Function

End Class
