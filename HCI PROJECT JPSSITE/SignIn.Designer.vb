<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        toLoginBtn = New Button()
        registerBtn = New Button()
        Label11 = New Label()
        yearLevelComboBox = New ComboBox()
        courseprogramComboBox = New ComboBox()
        birthDateField = New DateTimePicker()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Panel7 = New Panel()
        Label7 = New Label()
        userIDField = New TextBox()
        Panel6 = New Panel()
        Label6 = New Label()
        surnameField = New TextBox()
        Panel5 = New Panel()
        Label5 = New Label()
        firstNameField = New TextBox()
        Panel3 = New Panel()
        Label3 = New Label()
        Panel4 = New Panel()
        usernameField = New TextBox()
        Label4 = New Label()
        passwordField = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.CornflowerBlue
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-6, -6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(398, 462)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.signup_image
        PictureBox1.Location = New Point(30, 139)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(317, 320)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(64, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(238, 17)
        Label2.TabIndex = 3
        Label2.Text = "and be part of our growing community!"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(55, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 38)
        Label1.TabIndex = 2
        Label1.Text = "JOIN US!"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel2.Controls.Add(toLoginBtn)
        Panel2.Controls.Add(registerBtn)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(yearLevelComboBox)
        Panel2.Controls.Add(courseprogramComboBox)
        Panel2.Controls.Add(birthDateField)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Panel7)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(userIDField)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(surnameField)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(firstNameField)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(usernameField)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(passwordField)
        Panel2.Location = New Point(425, 33)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(347, 390)
        Panel2.TabIndex = 3
        ' 
        ' toLoginBtn
        ' 
        toLoginBtn.BackColor = Color.Silver
        toLoginBtn.FlatStyle = FlatStyle.Popup
        toLoginBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        toLoginBtn.ForeColor = Color.White
        toLoginBtn.Location = New Point(23, 343)
        toLoginBtn.Name = "toLoginBtn"
        toLoginBtn.Size = New Size(101, 23)
        toLoginBtn.TabIndex = 33
        toLoginBtn.Text = "RETURN"
        toLoginBtn.UseVisualStyleBackColor = False
        ' 
        ' registerBtn
        ' 
        registerBtn.BackColor = Color.CornflowerBlue
        registerBtn.FlatStyle = FlatStyle.Popup
        registerBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        registerBtn.ForeColor = Color.White
        registerBtn.Location = New Point(224, 343)
        registerBtn.Name = "registerBtn"
        registerBtn.Size = New Size(101, 23)
        registerBtn.TabIndex = 32
        registerBtn.Text = "REGISTER"
        registerBtn.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.CornflowerBlue
        Label11.Location = New Point(23, 29)
        Label11.Name = "Label11"
        Label11.Size = New Size(286, 16)
        Label11.TabIndex = 31
        Label11.Text = "Answer all the fields below to be registered."
        ' 
        ' yearLevelComboBox
        ' 
        yearLevelComboBox.FormattingEnabled = True
        yearLevelComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        yearLevelComboBox.Location = New Point(177, 272)
        yearLevelComboBox.Name = "yearLevelComboBox"
        yearLevelComboBox.Size = New Size(148, 23)
        yearLevelComboBox.TabIndex = 30
        ' 
        ' courseprogramComboBox
        ' 
        courseprogramComboBox.FormattingEnabled = True
        courseprogramComboBox.Items.AddRange(New Object() {"BSIT", "BSCPE", "BSIE"})
        courseprogramComboBox.Location = New Point(23, 272)
        courseprogramComboBox.Name = "courseprogramComboBox"
        courseprogramComboBox.Size = New Size(148, 23)
        courseprogramComboBox.TabIndex = 29
        ' 
        ' birthDateField
        ' 
        birthDateField.CalendarFont = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        birthDateField.CalendarMonthBackground = Color.White
        birthDateField.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        birthDateField.Format = DateTimePickerFormat.Custom
        birthDateField.Location = New Point(177, 212)
        birthDateField.Name = "birthDateField"
        birthDateField.Size = New Size(148, 22)
        birthDateField.TabIndex = 28
        birthDateField.Value = New Date(2024, 5, 11, 0, 0, 0, 0)
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(177, 252)
        Label10.Name = "Label10"
        Label10.Size = New Size(74, 17)
        Label10.TabIndex = 26
        Label10.Text = "Year Level:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(23, 252)
        Label9.Name = "Label9"
        Label9.Size = New Size(105, 17)
        Label9.TabIndex = 23
        Label9.Text = "Course Program:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(177, 194)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 17)
        Label8.TabIndex = 20
        Label8.Text = "Birthdate:"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Black
        Panel7.Location = New Point(23, 231)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(148, 1)
        Panel7.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(23, 194)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 17)
        Label7.TabIndex = 17
        Label7.Text = "UserID:"
        ' 
        ' userIDField
        ' 
        userIDField.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        userIDField.BorderStyle = BorderStyle.None
        userIDField.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        userIDField.Location = New Point(23, 212)
        userIDField.Name = "userIDField"
        userIDField.Size = New Size(148, 15)
        userIDField.TabIndex = 16
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Black
        Panel6.Location = New Point(177, 175)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(148, 1)
        Panel6.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(177, 138)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 17)
        Label6.TabIndex = 14
        Label6.Text = "Surname:"
        ' 
        ' surnameField
        ' 
        surnameField.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        surnameField.BorderStyle = BorderStyle.None
        surnameField.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        surnameField.Location = New Point(177, 156)
        surnameField.Name = "surnameField"
        surnameField.Size = New Size(148, 15)
        surnameField.TabIndex = 13
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Black
        Panel5.Location = New Point(23, 175)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(148, 1)
        Panel5.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(23, 138)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 17)
        Label5.TabIndex = 11
        Label5.Text = "Firstname:"
        ' 
        ' firstNameField
        ' 
        firstNameField.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        firstNameField.BorderStyle = BorderStyle.None
        firstNameField.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        firstNameField.Location = New Point(23, 156)
        firstNameField.Name = "firstNameField"
        firstNameField.Size = New Size(148, 15)
        firstNameField.TabIndex = 10
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Black
        Panel3.Location = New Point(23, 119)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(148, 1)
        Panel3.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(23, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 17)
        Label3.TabIndex = 8
        Label3.Text = "Username:"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Black
        Panel4.Location = New Point(177, 119)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(148, 1)
        Panel4.TabIndex = 6
        ' 
        ' usernameField
        ' 
        usernameField.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        usernameField.BorderStyle = BorderStyle.None
        usernameField.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameField.Location = New Point(23, 100)
        usernameField.Name = "usernameField"
        usernameField.Size = New Size(148, 15)
        usernameField.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(177, 82)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 17)
        Label4.TabIndex = 4
        Label4.Text = "Password:"
        ' 
        ' passwordField
        ' 
        passwordField.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        passwordField.BorderStyle = BorderStyle.None
        passwordField.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordField.Location = New Point(177, 100)
        passwordField.Name = "passwordField"
        passwordField.Size = New Size(148, 15)
        passwordField.TabIndex = 3
        ' 
        ' SignIn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "SignIn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIGNUP"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents passwordField As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents userIDField As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents surnameField As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents firstNameField As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents usernameField As TextBox
    Friend WithEvents birthDateField As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents yearLevelComboBox As ComboBox
    Friend WithEvents courseprogramComboBox As ComboBox
    Friend WithEvents toLoginBtn As Button
    Friend WithEvents registerBtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
