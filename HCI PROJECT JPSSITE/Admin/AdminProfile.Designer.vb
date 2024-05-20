<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminProfile
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
        dashboardBtn = New Button()
        Panel2 = New Panel()
        femaleRbtn = New RadioButton()
        maleRbtn = New RadioButton()
        Label14 = New Label()
        saveBtn = New Button()
        Panel3 = New Panel()
        Label15 = New Label()
        Label23 = New Label()
        Label22 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        Label16 = New Label()
        passwordField = New TextBox()
        usernameField = New TextBox()
        birthDateField = New DateTimePicker()
        surnameField = New TextBox()
        firstnameField = New TextBox()
        Panel9 = New Panel()
        Panel10 = New Panel()
        Panel11 = New Panel()
        Panel12 = New Panel()
        Panel13 = New Panel()
        Label17 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        Label24 = New Label()
        Label25 = New Label()
        Label1 = New Label()
        Panel4 = New Panel()
        Label28 = New Label()
        Label27 = New Label()
        Label26 = New Label()
        ageLabel = New Label()
        Label13 = New Label()
        sexLabel = New Label()
        Label9 = New Label()
        userIDLabel = New Label()
        Label5 = New Label()
        passLabel = New Label()
        usrnameLabel = New Label()
        Label11 = New Label()
        Label10 = New Label()
        yearLabel = New Label()
        courselabel = New Label()
        Label7 = New Label()
        Label6 = New Label()
        fullnameLabel = New Label()
        profilepicPBox = New PictureBox()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        logoutBtn = New Button()
        usernameLabel = New Label()
        PictureBox1 = New PictureBox()
        officersBtn = New Button()
        ratingsBtn = New Button()
        profileBtn = New Button()
        eventsBtn = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(profilepicPBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dashboardBtn
        ' 
        dashboardBtn.BackColor = SystemColors.ControlDarkDark
        dashboardBtn.FlatStyle = FlatStyle.Popup
        dashboardBtn.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dashboardBtn.ForeColor = Color.White
        dashboardBtn.Location = New Point(12, 114)
        dashboardBtn.Name = "dashboardBtn"
        dashboardBtn.Size = New Size(128, 37)
        dashboardBtn.TabIndex = 2
        dashboardBtn.Text = "My Dashboard"
        dashboardBtn.TextAlign = ContentAlignment.MiddleLeft
        dashboardBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(femaleRbtn)
        Panel2.Controls.Add(maleRbtn)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(saveBtn)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(Label23)
        Panel2.Controls.Add(Label22)
        Panel2.Controls.Add(Label19)
        Panel2.Controls.Add(Label18)
        Panel2.Controls.Add(Label16)
        Panel2.Controls.Add(passwordField)
        Panel2.Controls.Add(usernameField)
        Panel2.Controls.Add(birthDateField)
        Panel2.Controls.Add(surnameField)
        Panel2.Controls.Add(firstnameField)
        Panel2.Controls.Add(Panel9)
        Panel2.Controls.Add(Panel10)
        Panel2.Controls.Add(Panel11)
        Panel2.Controls.Add(Panel12)
        Panel2.Controls.Add(Panel13)
        Panel2.Controls.Add(Label17)
        Panel2.Controls.Add(Label20)
        Panel2.Controls.Add(Label21)
        Panel2.Controls.Add(Label24)
        Panel2.Controls.Add(Label25)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(495, 68)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(288, 370)
        Panel2.TabIndex = 36
        ' 
        ' femaleRbtn
        ' 
        femaleRbtn.AutoSize = True
        femaleRbtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        femaleRbtn.Location = New Point(217, 272)
        femaleRbtn.Name = "femaleRbtn"
        femaleRbtn.Size = New Size(32, 21)
        femaleRbtn.TabIndex = 54
        femaleRbtn.TabStop = True
        femaleRbtn.Text = "F"
        femaleRbtn.UseVisualStyleBackColor = True
        ' 
        ' maleRbtn
        ' 
        maleRbtn.AutoSize = True
        maleRbtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        maleRbtn.Location = New Point(149, 273)
        maleRbtn.Name = "maleRbtn"
        maleRbtn.Size = New Size(37, 21)
        maleRbtn.TabIndex = 53
        maleRbtn.TabStop = True
        maleRbtn.Text = "M"
        maleRbtn.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(131, 276)
        Label14.Name = "Label14"
        Label14.Size = New Size(12, 17)
        Label14.TabIndex = 52
        Label14.Text = ":"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' saveBtn
        ' 
        saveBtn.BackColor = SystemColors.ControlDarkDark
        saveBtn.FlatStyle = FlatStyle.Flat
        saveBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        saveBtn.ForeColor = Color.White
        saveBtn.Location = New Point(110, 326)
        saveBtn.Name = "saveBtn"
        saveBtn.Size = New Size(75, 32)
        saveBtn.TabIndex = 49
        saveBtn.Text = "SAVE"
        saveBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Silver
        Panel3.Location = New Point(36, 296)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(213, 1)
        Panel3.TabIndex = 51
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(36, 276)
        Label15.Name = "Label15"
        Label15.Size = New Size(28, 17)
        Label15.TabIndex = 50
        Label15.Text = "Sex"
        Label15.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(131, 229)
        Label23.Name = "Label23"
        Label23.Size = New Size(12, 17)
        Label23.TabIndex = 48
        Label23.Text = ":"
        Label23.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(131, 185)
        Label22.Name = "Label22"
        Label22.Size = New Size(12, 17)
        Label22.TabIndex = 47
        Label22.Text = ":"
        Label22.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(131, 144)
        Label19.Name = "Label19"
        Label19.Size = New Size(12, 17)
        Label19.TabIndex = 46
        Label19.Text = ":"
        Label19.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(131, 108)
        Label18.Name = "Label18"
        Label18.Size = New Size(12, 17)
        Label18.TabIndex = 45
        Label18.Text = ":"
        Label18.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(131, 68)
        Label16.Name = "Label16"
        Label16.Size = New Size(12, 17)
        Label16.TabIndex = 44
        Label16.Text = ":"
        Label16.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' passwordField
        ' 
        passwordField.BackColor = Color.White
        passwordField.BorderStyle = BorderStyle.None
        passwordField.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordField.Location = New Point(149, 229)
        passwordField.Name = "passwordField"
        passwordField.Size = New Size(100, 16)
        passwordField.TabIndex = 43
        ' 
        ' usernameField
        ' 
        usernameField.BackColor = Color.White
        usernameField.BorderStyle = BorderStyle.None
        usernameField.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameField.Location = New Point(149, 185)
        usernameField.Name = "usernameField"
        usernameField.Size = New Size(100, 16)
        usernameField.TabIndex = 42
        ' 
        ' birthDateField
        ' 
        birthDateField.CalendarFont = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        birthDateField.CalendarMonthBackground = Color.White
        birthDateField.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        birthDateField.Format = DateTimePickerFormat.Custom
        birthDateField.Location = New Point(149, 139)
        birthDateField.Name = "birthDateField"
        birthDateField.Size = New Size(100, 22)
        birthDateField.TabIndex = 41
        birthDateField.Value = New Date(2024, 5, 11, 0, 0, 0, 0)
        ' 
        ' surnameField
        ' 
        surnameField.BackColor = Color.White
        surnameField.BorderStyle = BorderStyle.None
        surnameField.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        surnameField.Location = New Point(149, 108)
        surnameField.Name = "surnameField"
        surnameField.Size = New Size(100, 16)
        surnameField.TabIndex = 40
        ' 
        ' firstnameField
        ' 
        firstnameField.BackColor = Color.White
        firstnameField.BorderStyle = BorderStyle.None
        firstnameField.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        firstnameField.Location = New Point(149, 68)
        firstnameField.Name = "firstnameField"
        firstnameField.Size = New Size(100, 16)
        firstnameField.TabIndex = 39
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Silver
        Panel9.Location = New Point(36, 249)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(213, 1)
        Panel9.TabIndex = 38
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Silver
        Panel10.Location = New Point(36, 205)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(213, 1)
        Panel10.TabIndex = 37
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.Silver
        Panel11.Location = New Point(36, 167)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(213, 1)
        Panel11.TabIndex = 36
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.Silver
        Panel12.Location = New Point(36, 128)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(213, 1)
        Panel12.TabIndex = 35
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.Silver
        Panel13.Location = New Point(36, 86)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(213, 1)
        Panel13.TabIndex = 34
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(36, 68)
        Label17.Name = "Label17"
        Label17.Size = New Size(75, 17)
        Label17.TabIndex = 32
        Label17.Text = "First Name"
        Label17.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(36, 229)
        Label20.Name = "Label20"
        Label20.Size = New Size(69, 17)
        Label20.TabIndex = 29
        Label20.Text = "Password"
        Label20.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(36, 185)
        Label21.Name = "Label21"
        Label21.Size = New Size(71, 17)
        Label21.TabIndex = 28
        Label21.Text = "Username"
        Label21.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(36, 144)
        Label24.Name = "Label24"
        Label24.Size = New Size(59, 17)
        Label24.TabIndex = 25
        Label24.Text = "Birthday"
        Label24.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(36, 108)
        Label25.Name = "Label25"
        Label25.Size = New Size(64, 17)
        Label25.TabIndex = 24
        Label25.Text = "Surname"
        Label25.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(65, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 25)
        Label1.TabIndex = 1
        Label1.Text = "Edit Information"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Label28)
        Panel4.Controls.Add(Label27)
        Panel4.Controls.Add(Label26)
        Panel4.Controls.Add(ageLabel)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(sexLabel)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(userIDLabel)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(passLabel)
        Panel4.Controls.Add(usrnameLabel)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(yearLabel)
        Panel4.Controls.Add(courselabel)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(fullnameLabel)
        Panel4.Controls.Add(profilepicPBox)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(185, 68)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(292, 370)
        Panel4.TabIndex = 35
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Century Gothic", 9F)
        Label28.Location = New Point(138, 326)
        Label28.Name = "Label28"
        Label28.Size = New Size(11, 17)
        Label28.TabIndex = 25
        Label28.Text = ":"
        Label28.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Century Gothic", 9F)
        Label27.Location = New Point(138, 299)
        Label27.Name = "Label27"
        Label27.Size = New Size(11, 17)
        Label27.TabIndex = 24
        Label27.Text = ":"
        Label27.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Century Gothic", 9F)
        Label26.Location = New Point(138, 272)
        Label26.Name = "Label26"
        Label26.Size = New Size(11, 17)
        Label26.TabIndex = 23
        Label26.Text = ":"
        Label26.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ageLabel
        ' 
        ageLabel.AutoSize = True
        ageLabel.Font = New Font("Century Gothic", 9F)
        ageLabel.Location = New Point(213, 250)
        ageLabel.Name = "ageLabel"
        ageLabel.Size = New Size(22, 17)
        ageLabel.TabIndex = 22
        ageLabel.Text = "20"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 9F)
        Label13.Location = New Point(179, 250)
        Label13.Name = "Label13"
        Label13.Size = New Size(36, 17)
        Label13.TabIndex = 21
        Label13.Text = "AGE:"
        ' 
        ' sexLabel
        ' 
        sexLabel.AutoSize = True
        sexLabel.Font = New Font("Century Gothic", 9F)
        sexLabel.Location = New Point(60, 250)
        sexLabel.Name = "sexLabel"
        sexLabel.Size = New Size(28, 17)
        sexLabel.TabIndex = 20
        sexLabel.Text = "m/f"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 9F)
        Label9.Location = New Point(32, 250)
        Label9.Name = "Label9"
        Label9.Size = New Size(31, 17)
        Label9.TabIndex = 19
        Label9.Text = "SEX:"
        ' 
        ' userIDLabel
        ' 
        userIDLabel.AutoSize = True
        userIDLabel.Font = New Font("Century Gothic", 9F)
        userIDLabel.Location = New Point(179, 273)
        userIDLabel.Name = "userIDLabel"
        userIDLabel.Size = New Size(56, 17)
        userIDLabel.TabIndex = 18
        userIDLabel.Text = "LOLOLO"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F)
        Label5.Location = New Point(32, 273)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 17)
        Label5.TabIndex = 17
        Label5.Text = "USER ID"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' passLabel
        ' 
        passLabel.AutoSize = True
        passLabel.Font = New Font("Century Gothic", 9F)
        passLabel.Location = New Point(179, 326)
        passLabel.Name = "passLabel"
        passLabel.Size = New Size(50, 17)
        passLabel.TabIndex = 16
        passLabel.Text = "666666"
        ' 
        ' usrnameLabel
        ' 
        usrnameLabel.AutoSize = True
        usrnameLabel.Font = New Font("Century Gothic", 9F)
        usrnameLabel.Location = New Point(179, 299)
        usrnameLabel.Name = "usrnameLabel"
        usrnameLabel.Size = New Size(56, 17)
        usrnameLabel.TabIndex = 15
        usrnameLabel.Text = "LOLOLO"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 9F)
        Label11.Location = New Point(32, 326)
        Label11.Name = "Label11"
        Label11.Size = New Size(77, 17)
        Label11.TabIndex = 14
        Label11.Text = "PASSWORD"
        Label11.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 9F)
        Label10.Location = New Point(32, 299)
        Label10.Name = "Label10"
        Label10.Size = New Size(71, 17)
        Label10.TabIndex = 13
        Label10.Text = "USERNAME"
        Label10.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' yearLabel
        ' 
        yearLabel.AutoSize = True
        yearLabel.Font = New Font("Century Gothic", 9F)
        yearLabel.Location = New Point(251, 230)
        yearLabel.Name = "yearLabel"
        yearLabel.Size = New Size(15, 17)
        yearLabel.TabIndex = 12
        yearLabel.Text = "2"
        ' 
        ' courselabel
        ' 
        courselabel.AutoSize = True
        courselabel.Font = New Font("Century Gothic", 9F)
        courselabel.Location = New Point(89, 230)
        courselabel.Name = "courselabel"
        courselabel.Size = New Size(30, 17)
        courselabel.TabIndex = 11
        courselabel.Text = "BSIT"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 9F)
        Label7.Location = New Point(179, 230)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 17)
        Label7.TabIndex = 10
        Label7.Text = "YEAR LEVEL:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9F)
        Label6.Location = New Point(32, 230)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 17)
        Label6.TabIndex = 9
        Label6.Text = "COURSE:"
        ' 
        ' fullnameLabel
        ' 
        fullnameLabel.AutoSize = True
        fullnameLabel.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fullnameLabel.Location = New Point(89, 197)
        fullnameLabel.Name = "fullnameLabel"
        fullnameLabel.Size = New Size(103, 17)
        fullnameLabel.TabIndex = 8
        fullnameLabel.Text = "User's Fullname"
        ' 
        ' profilepicPBox
        ' 
        profilepicPBox.Image = My.Resources.Resources.circle_user__1_
        profilepicPBox.Location = New Point(71, 58)
        profilepicPBox.Name = "profilepicPBox"
        profilepicPBox.Size = New Size(137, 123)
        profilepicPBox.SizeMode = PictureBoxSizeMode.Zoom
        profilepicPBox.TabIndex = 7
        profilepicPBox.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(34, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(221, 25)
        Label4.TabIndex = 2
        Label4.Text = "Account Information"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._2
        PictureBox2.Location = New Point(736, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 45)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 34
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDarkDark
        Panel1.Controls.Add(logoutBtn)
        Panel1.Controls.Add(usernameLabel)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(officersBtn)
        Panel1.Controls.Add(ratingsBtn)
        Panel1.Controls.Add(profileBtn)
        Panel1.Controls.Add(eventsBtn)
        Panel1.Controls.Add(dashboardBtn)
        Panel1.Location = New Point(17, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(153, 427)
        Panel1.TabIndex = 31
        ' 
        ' logoutBtn
        ' 
        logoutBtn.BackColor = SystemColors.ControlDarkDark
        logoutBtn.FlatStyle = FlatStyle.Popup
        logoutBtn.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        logoutBtn.ForeColor = Color.White
        logoutBtn.Location = New Point(12, 329)
        logoutBtn.Name = "logoutBtn"
        logoutBtn.Size = New Size(128, 37)
        logoutBtn.TabIndex = 6
        logoutBtn.Text = "Log Out"
        logoutBtn.TextAlign = ContentAlignment.MiddleLeft
        logoutBtn.UseVisualStyleBackColor = False
        ' 
        ' usernameLabel
        ' 
        usernameLabel.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        usernameLabel.ForeColor = Color.White
        usernameLabel.Location = New Point(38, 85)
        usernameLabel.Name = "usernameLabel"
        usernameLabel.Size = New Size(70, 16)
        usernameLabel.TabIndex = 1
        usernameLabel.Text = "Admin"
        usernameLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.circle_user
        PictureBox1.Location = New Point(38, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(70, 69)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' officersBtn
        ' 
        officersBtn.BackColor = SystemColors.ControlDarkDark
        officersBtn.FlatStyle = FlatStyle.Popup
        officersBtn.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        officersBtn.ForeColor = Color.White
        officersBtn.Location = New Point(12, 286)
        officersBtn.Name = "officersBtn"
        officersBtn.Size = New Size(128, 37)
        officersBtn.TabIndex = 5
        officersBtn.Text = "My Officers"
        officersBtn.TextAlign = ContentAlignment.MiddleLeft
        officersBtn.UseVisualStyleBackColor = False
        ' 
        ' ratingsBtn
        ' 
        ratingsBtn.BackColor = SystemColors.ControlDarkDark
        ratingsBtn.FlatStyle = FlatStyle.Popup
        ratingsBtn.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ratingsBtn.ForeColor = Color.White
        ratingsBtn.Location = New Point(12, 243)
        ratingsBtn.Name = "ratingsBtn"
        ratingsBtn.Size = New Size(128, 37)
        ratingsBtn.TabIndex = 4
        ratingsBtn.Text = "My Ratings"
        ratingsBtn.TextAlign = ContentAlignment.MiddleLeft
        ratingsBtn.UseVisualStyleBackColor = False
        ' 
        ' profileBtn
        ' 
        profileBtn.BackColor = SystemColors.ControlDark
        profileBtn.FlatStyle = FlatStyle.Popup
        profileBtn.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        profileBtn.ForeColor = Color.White
        profileBtn.Location = New Point(12, 200)
        profileBtn.Name = "profileBtn"
        profileBtn.Size = New Size(128, 37)
        profileBtn.TabIndex = 3
        profileBtn.Text = "My Profile"
        profileBtn.TextAlign = ContentAlignment.MiddleLeft
        profileBtn.UseVisualStyleBackColor = False
        ' 
        ' eventsBtn
        ' 
        eventsBtn.BackColor = SystemColors.ControlDarkDark
        eventsBtn.FlatStyle = FlatStyle.Popup
        eventsBtn.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        eventsBtn.ForeColor = Color.White
        eventsBtn.Location = New Point(12, 157)
        eventsBtn.Name = "eventsBtn"
        eventsBtn.Size = New Size(128, 37)
        eventsBtn.TabIndex = 3
        eventsBtn.Text = "My Events"
        eventsBtn.TextAlign = ContentAlignment.MiddleLeft
        eventsBtn.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(587, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 25)
        Label3.TabIndex = 33
        Label3.Text = "JPPSITE ORG."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(185, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 25)
        Label2.TabIndex = 32
        Label2.Text = "PROFILE"
        ' 
        ' AdminProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel4)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "AdminProfile"
        Text = "AdminProfile"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(profilepicPBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dashboardBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents femaleRbtn As RadioButton
    Friend WithEvents maleRbtn As RadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents saveBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents passwordField As TextBox
    Friend WithEvents usernameField As TextBox
    Friend WithEvents birthDateField As DateTimePicker
    Friend WithEvents surnameField As TextBox
    Friend WithEvents firstnameField As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents ageLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents sexLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents userIDLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents passLabel As Label
    Friend WithEvents usrnameLabel As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents yearLabel As Label
    Friend WithEvents courselabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents fullnameLabel As Label
    Friend WithEvents profilepicPBox As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents logoutBtn As Button
    Friend WithEvents usernameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents officersBtn As Button
    Friend WithEvents ratingsBtn As Button
    Friend WithEvents profileBtn As Button
    Friend WithEvents eventsBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
