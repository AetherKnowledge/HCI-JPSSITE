Imports System.Configuration
Imports Microsoft.VisualBasic.ApplicationServices

Public Class AdminProfile
    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()
    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        Me.Hide()
        AdminDashboard.show()
    End Sub

    Private Sub eventsBtn_Click(sender As Object, e As EventArgs) Handles eventsBtn.Click
        Me.Hide()
        HCI_PROJECT_JPSSITE.AdminEvents.show()
    End Sub

    Private Sub ratingsBtn_Click(sender As Object, e As EventArgs) Handles ratingsBtn.Click
        Me.Hide()
        AdminRatings.show()
    End Sub

    Private Sub officersBtn_Click(sender As Object, e As EventArgs) Handles officersBtn.Click
        Me.Hide()
        AdminOfficers.show()
    End Sub

    Shadows Sub show()
        MyBase.Show()
        loadUsers()

    End Sub

    Private Sub loadUsers()
        Dim users As List(Of User) = UserHandler.getUsers
        Dim indexOfAdmin As Integer
        For Each user As User In users
            If user.username = "admin" Then
                indexOfAdmin = users.IndexOf(user)
            End If
        Next
        users.RemoveAt(indexOfAdmin)

        users.Sort()

        If descRBtn.Checked Then
            users.Reverse()
        End If

        studLBox.Items.Clear()
        For Each user As User In users
            If nameSearch.Text = "" Then
                studLBox.Items.Add(user)
            ElseIf (user.firstName + " " + user.password).ToLower.Contains(nameSearch.Text.ToLower) Then
                studLBox.Items.Add(user)
            End If
        Next
    End Sub

    Private Sub nameSearch_TextChanged(sender As Object, e As EventArgs) Handles nameSearch.TextChanged
        loadUsers()
    End Sub

    Private Sub studLBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studLBox.SelectedIndexChanged
        Dim user As User = studLBox.SelectedItem

        fullnameLabel.Text = user.firstName + " " + user.surName
        userIDLabel.Text = user.userID
        usrnameLabel.Text = user.username
        courselabel.Text = user.courseProgram
        yearLabel.Text = user.yearLevel
        passLabel.Text = "*******"
        sexLabel.Text = user.sex

    End Sub

    Private Sub ascRBtn_Selected(sender As Object, e As EventArgs)
        loadUsers()
    End Sub

    Private Sub descRBtn_Selected(sender As Object, e As EventArgs)
        loadUsers()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If studLBox.SelectedIndex <> -1 Then
            UserHandler.removeUser(studLBox.SelectedItem)
        End If

    End Sub
End Class