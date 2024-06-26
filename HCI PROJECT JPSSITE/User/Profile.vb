﻿Imports System.IO

Public Class Profile
    Shadows Sub show()
        MyBase.Show()
        fullnameLabel.Text = UserHandler.getCurrentuser.firstName + " " + UserHandler.getCurrentuser.surName
        usernameLabel.Text = UserHandler.getCurrentuser.username
        userIDLabel.Text = UserHandler.getCurrentuser.userID
        usrnameLabel.Text = UserHandler.getCurrentuser.username
        courselabel.Text = UserHandler.getCurrentuser.courseProgram
        yearLabel.Text = UserHandler.getCurrentuser.yearLevel
        passLabel.Text = "*******"
        sexLabel.Text = UserHandler.getCurrentuser.sex

        firstnameField.Text = UserHandler.getCurrentuser.firstName
        surnameField.Text = UserHandler.getCurrentuser.firstName
        usernameField.Text = UserHandler.getCurrentuser.username
        birthDateField.Value = UserHandler.getCurrentuser.birthDate
        If UserHandler.getCurrentuser.sex = "M" Then
            maleRbtn.Checked = True
        Else
            femaleRbtn.Checked = True
        End If

        passwordField.Text = "*******"
    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        Me.Hide()
        Dashboard.show()
    End Sub

    Private Sub eventsBtn_Click(sender As Object, e As EventArgs) Handles eventsBtn.Click
        Me.Hide()
        HCI_PROJECT_JPSSITE.Events.show()
    End Sub

    Private Sub ratingsBtn_Click(sender As Object, e As EventArgs) Handles ratingsBtn.Click
        Me.Hide()
        Ratings.show()
    End Sub

    Private Sub officersBtn_Click(sender As Object, e As EventArgs) Handles officersBtn.Click
        Me.Hide()
        Officers.show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim username As String = usernameField.Text
        Dim password As String = passwordField.Text
        Dim firstName As String = firstnameField.Text
        Dim surName As String = surnameField.Text
        Dim userID As String = UserHandler.getCurrentuser.userID
        Dim birthDate As Date = birthDateField.Value
        Dim courseProgram As String = UserHandler.getCurrentuser.courseProgram
        Dim yearLevel As Integer = UserHandler.getCurrentuser.yearLevel

        If username.Length < 4 Then
            MessageBox.Show("Invalid username, length must be greater than 3")
            Return
        ElseIf password <> "*******" And password.Length < 8 Then
            MessageBox.Show("Invalid password, length must be greater or equal to 8")
            Return
        ElseIf password <> "*******" And Not Utilities.containsUppercase(password) Then
            MessageBox.Show("Invalid password, must contain uppercase")
            Return
        ElseIf password <> "*******" And Not Utilities.containsSpecial(password) Then
            MessageBox.Show("Invalid password, must contain special character")
            Return
        ElseIf firstName = "" Then
            MessageBox.Show("Invalid Firstname, cannot be empty")
            Return
        ElseIf surName = "" Then
            MessageBox.Show("Invalid Surname, cannot be empty")
            Return
        ElseIf Not maleRbtn.Checked And Not femaleRbtn.Checked Then
            MessageBox.Show("Please Pick your Sex")
            Return
        End If

        Dim sex As String
        If maleRbtn.Checked Then
            sex = "M"
        Else
            sex = "F"
        End If

        If password = "*******" Then
            password = UserHandler.getCurrentuser.password
        End If

        Dim newUser As User = New User(username, password, firstName, surName, userID, birthDate, courseProgram, yearLevel, sex, Nothing)
        UserHandler.updateUser(newUser, UserHandler.getCurrentuser.username)

        fullnameLabel.Text = UserHandler.getCurrentuser.firstName + " " + UserHandler.getCurrentuser.surName
        usernameLabel.Text = UserHandler.getCurrentuser.username
        userIDLabel.Text = UserHandler.getCurrentuser.userID
        usrnameLabel.Text = UserHandler.getCurrentuser.username
        courselabel.Text = UserHandler.getCurrentuser.courseProgram
        yearLabel.Text = UserHandler.getCurrentuser.yearLevel
        passLabel.Text = "*******"
        sexLabel.Text = UserHandler.getCurrentuser.sex

        firstnameField.Text = UserHandler.getCurrentuser.firstName
        surnameField.Text = UserHandler.getCurrentuser.firstName
        usernameField.Text = UserHandler.getCurrentuser.username
        birthDateField.Value = UserHandler.getCurrentuser.birthDate
        If UserHandler.getCurrentuser.sex = "M" Then
            maleRbtn.Checked = True
        Else
            femaleRbtn.Checked = True
        End If

        passwordField.Text = "*******"
        MessageBox.Show("Account Updated")
    End Sub

    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()
    End Sub

    Private Sub maleRbtn_CheckedChanged(sender As Object, e As EventArgs)
        maleRbtn.Checked = True
        femaleRbtn.Checked = False
    End Sub

    Private Sub femaleRbtn_CheckedChanged(sender As Object, e As EventArgs)
        maleRbtn.Checked = False
        femaleRbtn.Checked = True
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Me.Hide()
        Login.show()
    End Sub
End Class