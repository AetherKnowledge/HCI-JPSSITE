Imports System.IO

Public Class AdminEvents

    Private selectedImg As Image = Nothing
    Public Shared imageBytes As Byte()
    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Hide()
        Login.show()
    End Sub
    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        Me.Hide()
        AdminDashboard.show()
    End Sub

    Private Sub officersBtn_Click(sender As Object, e As EventArgs) Handles officersBtn.Click
        Me.Hide()
        AdminOfficers.show()
    End Sub

    Private Sub profileBtn_Click(sender As Object, e As EventArgs) Handles profileBtn.Click
        Me.Hide()
        AdminProfile.show()
    End Sub

    Private Sub ratingsBtn_Click(sender As Object, e As EventArgs) Handles ratingsBtn.Click
        Me.Hide()
        AdminRatings.show()
    End Sub

    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()
    End Sub

    Shadows Sub show()
        MyBase.Show()
        selectedImg = Nothing
        usernameLabel.Text = UserHandler.getCurrentuser.username
        loadEvents()
    End Sub

    Private Sub loadEvents()
        event2LBox.Items.Clear()

        Dim events As ArrayList = EventHandler.getEvents()
        For Each eventObj As EventObj In events
            event2LBox.Items.Add(eventObj.eventName + " - " + eventObj.dateOfEvent.ToString)
        Next
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim eventName As String = eventTitleTBox.Text
        Dim dateOfEvent As Date = DateTimePicker1.Value

        If eventName = "" Then
            MessageBox.Show("Please add title to Event")
            Return
        End If

        EventHandler.addEvent(New EventObj(eventName, selectedImg, 0, dateOfEvent))
        selectedImg = Nothing
        eventTitleTBox.Text = ""
        DateTimePicker1.Value = Date.Now
        RichTextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        imageBytes = Nothing
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        openFileDialog.Multiselect = False ' Allow only one file selection
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedImagePath As String = openFileDialog.FileName
            ' Display selected image in PictureBox
            selectedImg = Image.FromFile(selectedImagePath)
            PictureBox3.Image = Image.FromFile(selectedImagePath)
            imageBytes = File.ReadAllBytes(selectedImagePath)
        End If
    End Sub
End Class