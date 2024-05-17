Public Class SignIn
    Private Sub toLoginBtn_click(sender As Object, e As EventArgs) Handles toLoginBtn.Click
        usernameField.Text = ""
        passwordField.Text = ""
        firstNameField.Text = ""
        surnameField.Text = ""
        userIDField.Text = ""
        birthDateField.Value = Date.Now
        yearLevelComboBox.SelectedIndex = 0
        courseprogramComboBox.SelectedIndex = 0

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        Dim username As String = usernameField.Text
        Dim password As String = passwordField.Text
        Dim firstName As String = firstNameField.Text
        Dim surName As String = surnameField.Text
        Dim userID As String = userIDField.Text
        Dim birthDate As Date = birthDateField.Value
        Dim courseProgram As String = courseprogramComboBox.SelectedItem
        Dim yearLevel As Integer = Integer.Parse(DirectCast(yearLevelComboBox.SelectedItem, String))

        If username.Length < 4 Then
            MessageBox.Show("Invalid username, length must be greater than 3")
            Return
        ElseIf password.Length < 8 Then
            MessageBox.Show("Invalid password, length must be greater or equal to 8")
            Return
        ElseIf Not containsUppercase(password) Then
            MessageBox.Show("Invalid password, must contain uppercase")
            Return
        ElseIf Not containsSpecial(password) Then
            MessageBox.Show("Invalid password, must contain special character")
            Return
        ElseIf firstName = "" Then
            MessageBox.Show("Invalid Firstname, cannot be empty")
            Return
        ElseIf surName = "" Then
            MessageBox.Show("Invalid Surname, cannot be empty")
            Return
        ElseIf userID = "" Then
            MessageBox.Show("Invalid User ID, cannot be empty")
            Return
        End If

        Dim newUser As User = New User(username, password, firstName, surName, userID, birthDate, courseProgram, yearLevel)
        If Not UserHandler.containsUserDuplicate(newUser) Then
            UserHandler.addUser(newUser)
            UserHandler.isLoginSuccessful(username, password)

            usernameField.Text = ""
            passwordField.Text = ""
            firstNameField.Text = ""
            surnameField.Text = ""
            userIDField.Text = ""
            birthDateField.Value = Date.Now
            yearLevelComboBox.SelectedIndex = 0
            courseprogramComboBox.SelectedIndex = 0

            Me.Hide()
            Dashboard.show()

        End If
    End Sub

    Private Function containsSpecial(text As String) As Boolean
        For Each ch As Char In text
            If Not Char.IsLetter(ch) And Not Char.IsNumber(ch) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function containsUppercase(text As String) As Boolean
        For Each ch As Char In text
            If Char.IsUpper(ch) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()
    End Sub

    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        yearLevelComboBox.SelectedIndex = 0
        courseprogramComboBox.SelectedIndex = 0
    End Sub
End Class