Imports System.IO

Public Class Profile
    Shadows Sub show()
        MyBase.Show()
        update_contents()
    End Sub

    Private Sub update_contents()
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

        Dim today As Date = Date.Now
        Dim birthDate As Date = UserHandler.getCurrentuser.birthDate
        Dim age As Integer = today.Year - birthDate.Year
        If (birthDate > today.AddYears(-age)) Then age -= 1
        ageLabel.Text = age.ToString()

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
        Dim username = usernameField.Text
        Dim password = passwordField.Text
        Dim firstName = firstnameField.Text
        Dim surName = surnameField.Text
        Dim userID = UserHandler.getCurrentuser.userID
        Dim birthDate = birthDateField.Value
        Dim courseProgram = UserHandler.getCurrentuser.courseProgram
        Dim yearLevel = UserHandler.getCurrentuser.yearLevel

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

        Dim newUser = New User(username, password, firstName, surName, userID, birthDate, courseProgram, yearLevel, sex, Nothing)
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
        update_contents()
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

    Private Sub delete_account_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        UserHandler.removeUser(UserHandler.getCurrentuser)
        MessageBox.Show("Account Deleted")
        Login.show()
    End Sub
End Class