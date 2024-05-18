Imports System.ComponentModel

Public Class Login

    Private Sub userNameTextField_GotFocus(sender As Object, e As EventArgs) Handles userNameTextField.GotFocus
        If userNameTextField.Text = "Username" Then
            userNameTextField.Text = ""
        End If
    End Sub

    Private Sub userNameTextField_LostFocus(sender As Object, e As EventArgs) Handles userNameTextField.LostFocus
        If userNameTextField.Text = "" Then
            userNameTextField.Text = "Username"
        End If
    End Sub

    Private Sub passwordTextField_GotFocus(sender As Object, e As EventArgs) Handles passwordTextField.GotFocus
        If passwordTextField.Text = "Password" Then
            passwordTextField.Text = ""
        End If
    End Sub

    Private Sub passwordTextField_LostFocus(sender As Object, e As EventArgs) Handles passwordTextField.LostFocus
        If passwordTextField.Text = "" Then
            passwordTextField.Text = "Password"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles signupBtn.Click
        userNameTextField.Text = ""
        passwordTextField.Text = ""

        SignIn.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim username As String = userNameTextField.Text
        Dim password As String = passwordTextField.Text
        If UserHandler.isLoginSuccessful(username, password) Then
            Hide()
            Dashboard.show()

            userNameTextField.Text = ""
            passwordTextField.Text = ""

        Else
            MessageBox.Show("Invalid Credentials")
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserHandler.getUsersFromDB()
    End Sub

End Class
