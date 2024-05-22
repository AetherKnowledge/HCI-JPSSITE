Imports System.IO

Public Class AdminOfficers

    Private selectedImg As Image = Nothing
    Public Shared imageBytes As Byte()
    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()
    End Sub
    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Hide()
        Login.show()
    End Sub
    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        Me.Hide()
        AdminDashboard.show()
    End Sub

    Private Sub profileBtn_Click(sender As Object, e As EventArgs) Handles profileBtn.Click
        Me.Hide()
        AdminProfile.show()
    End Sub

    Private Sub eventsBtn_Click(sender As Object, e As EventArgs) Handles eventsBtn.Click
        Me.Hide()
        HCI_PROJECT_JPSSITE.AdminEvents.show()
    End Sub

    Private Sub ratingsBtn_Click(sender As Object, e As EventArgs) Handles ratingsBtn.Click
        Me.Hide()
        AdminRatings.show()
    End Sub

    Shadows Sub show()
        MyBase.Show()
        usernameLabel.Text = UserHandler.getCurrentuser.username
        officerPositionCBox.SelectedIndex = 0
    End Sub

    Private Sub officerPBox_Click(sender As Object, e As EventArgs) Handles officerPBox.Click
        imageBytes = Nothing
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        openFileDialog.Multiselect = False ' Allow only one file selection
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedImagePath As String = openFileDialog.FileName
            ' Display selected image in PictureBox
            selectedImg = Image.FromFile(selectedImagePath)
            officerPBox.Image = Image.FromFile(selectedImagePath)
            imageBytes = File.ReadAllBytes(selectedImagePath)
        End If
    End Sub

    Private Sub officerPositionCBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles officerPositionCBox.SelectedIndexChanged
        If officerPositionCBox.SelectedIndex <> -1 Then
            Dim officer As Officer = OfficerHandler.getOfficer(officerPositionCBox.SelectedItem)
            If officer Is Nothing Then
                nameTextBox.Text = "N/A"
                sectionCmBox.SelectedIndex = -1
                ageCmBox.SelectedIndex = -1
                sexCmBox.SelectedIndex = -1
                officerPBox.Image = My.Resources.upload
                achivementsRTBox.Text = ""
                motoRTBox.Text = ""
            Else
                officerPositionCBox.SelectedItem = officer.position
                ageCmBox.SelectedItem = officer.age.ToString
                sectionCmBox.SelectedItem = officer.section

                If officer.sex = "Male" Then
                    sexCmBox.SelectedItem = "Male"
                Else
                    sexCmBox.SelectedItem = "Female"
                End If
                nameTextBox.Text = officer.name
                officerPBox.Image = officer.img

                If officer.img Is Nothing Then
                    officerPBox.Image = My.Resources.upload
                End If

                achivementsRTBox.Text = officer.achievements
                motoRTBox.Text = officer.motto
            End If

        End If
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If nameTextBox.Text = "N/A" Or nameTextBox.Text = "" Then
            MessageBox.Show("Please fill all fields")
            Return
        ElseIf ageCmBox.SelectedIndex = -1 Then
            MessageBox.Show("Please fill all fields")
            Return
        ElseIf sectionCmBox.SelectedIndex = -1 Then
            MessageBox.Show("Please fill all fields")
            Return
        ElseIf sexCmBox.SelectedIndex = -1 Then
            MessageBox.Show("Please fill all fields")
            Return
        ElseIf motoRTBox.Text = "N/A" Or motoRTBox.Text = "" Then
            MessageBox.Show("Please fill all fields")
            Return
        ElseIf achivementsRTBox.Text = "N/A" Or motoRTBox.Text = "" Then
            MessageBox.Show("Please fill all fields")
            Return
        End If


        Dim name = nameTextBox.Text
        Dim age = Integer.Parse(ageCmBox.SelectedItem)
        Dim section = sectionCmBox.SelectedItem
        Dim sex = sexCmBox.SelectedItem
        Dim achievements = achivementsRTBox.Text
        Dim img = selectedImg
        Dim motto = motoRTBox.Text
        Dim position = officerPositionCBox.SelectedItem

        OfficerHandler.updateOfficer(New Officer(name, img, section, age, sex, achievements, motto, position))
    End Sub
End Class