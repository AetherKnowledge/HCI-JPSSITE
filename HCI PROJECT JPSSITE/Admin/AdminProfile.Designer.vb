﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        nameSearch = New TextBox()
        studLBox = New ListBox()
        descRBtn = New RadioButton()
        ascRBtn = New RadioButton()
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
        dashboardBtn.Text = "Dashboard"
        dashboardBtn.TextAlign = ContentAlignment.MiddleLeft
        dashboardBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(nameSearch)
        Panel2.Controls.Add(studLBox)
        Panel2.Controls.Add(descRBtn)
        Panel2.Controls.Add(ascRBtn)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(495, 68)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(288, 370)
        Panel2.TabIndex = 36
        ' 
        ' nameSearch
        ' 
        nameSearch.Location = New Point(23, 50)
        nameSearch.Name = "nameSearch"
        nameSearch.Size = New Size(158, 23)
        nameSearch.TabIndex = 8
        ' 
        ' studLBox
        ' 
        studLBox.BorderStyle = BorderStyle.FixedSingle
        studLBox.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studLBox.FormattingEnabled = True
        studLBox.ItemHeight = 17
        studLBox.Location = New Point(23, 90)
        studLBox.Name = "studLBox"
        studLBox.Size = New Size(236, 257)
        studLBox.TabIndex = 7
        ' 
        ' descRBtn
        ' 
        descRBtn.AutoSize = True
        descRBtn.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        descRBtn.Location = New Point(226, 50)
        descRBtn.Name = "descRBtn"
        descRBtn.Size = New Size(33, 20)
        descRBtn.TabIndex = 4
        descRBtn.TabStop = True
        descRBtn.Text = "⬆"
        descRBtn.UseVisualStyleBackColor = True
        ' 
        ' ascRBtn
        ' 
        ascRBtn.AutoSize = True
        ascRBtn.Checked = True
        ascRBtn.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ascRBtn.Location = New Point(187, 50)
        ascRBtn.Name = "ascRBtn"
        ascRBtn.Size = New Size(33, 20)
        ascRBtn.TabIndex = 3
        ascRBtn.TabStop = True
        ascRBtn.Text = "⬇"
        ascRBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(78, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 25)
        Label1.TabIndex = 1
        Label1.Text = "STUDENT LIST"
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
        Label28.Location = New Point(138, 303)
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
        Label27.Location = New Point(138, 276)
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
        Label26.Location = New Point(138, 249)
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
        ageLabel.Location = New Point(213, 227)
        ageLabel.Name = "ageLabel"
        ageLabel.Size = New Size(22, 17)
        ageLabel.TabIndex = 22
        ageLabel.Text = "20"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 9F)
        Label13.Location = New Point(179, 227)
        Label13.Name = "Label13"
        Label13.Size = New Size(36, 17)
        Label13.TabIndex = 21
        Label13.Text = "AGE:"
        ' 
        ' sexLabel
        ' 
        sexLabel.AutoSize = True
        sexLabel.Font = New Font("Century Gothic", 9F)
        sexLabel.Location = New Point(60, 227)
        sexLabel.Name = "sexLabel"
        sexLabel.Size = New Size(28, 17)
        sexLabel.TabIndex = 20
        sexLabel.Text = "m/f"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 9F)
        Label9.Location = New Point(32, 227)
        Label9.Name = "Label9"
        Label9.Size = New Size(31, 17)
        Label9.TabIndex = 19
        Label9.Text = "SEX:"
        ' 
        ' userIDLabel
        ' 
        userIDLabel.AutoSize = True
        userIDLabel.Font = New Font("Century Gothic", 9F)
        userIDLabel.Location = New Point(179, 250)
        userIDLabel.Name = "userIDLabel"
        userIDLabel.Size = New Size(56, 17)
        userIDLabel.TabIndex = 18
        userIDLabel.Text = "LOLOLO"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F)
        Label5.Location = New Point(32, 250)
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
        passLabel.Location = New Point(179, 303)
        passLabel.Name = "passLabel"
        passLabel.Size = New Size(50, 17)
        passLabel.TabIndex = 16
        passLabel.Text = "666666"
        ' 
        ' usrnameLabel
        ' 
        usrnameLabel.AutoSize = True
        usrnameLabel.Font = New Font("Century Gothic", 9F)
        usrnameLabel.Location = New Point(179, 276)
        usrnameLabel.Name = "usrnameLabel"
        usrnameLabel.Size = New Size(56, 17)
        usrnameLabel.TabIndex = 15
        usrnameLabel.Text = "LOLOLO"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 9F)
        Label11.Location = New Point(32, 303)
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
        Label10.Location = New Point(32, 276)
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
        yearLabel.Location = New Point(251, 207)
        yearLabel.Name = "yearLabel"
        yearLabel.Size = New Size(15, 17)
        yearLabel.TabIndex = 12
        yearLabel.Text = "2"
        ' 
        ' courselabel
        ' 
        courselabel.AutoSize = True
        courselabel.Font = New Font("Century Gothic", 9F)
        courselabel.Location = New Point(89, 207)
        courselabel.Name = "courselabel"
        courselabel.Size = New Size(30, 17)
        courselabel.TabIndex = 11
        courselabel.Text = "BSIT"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 9F)
        Label7.Location = New Point(179, 207)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 17)
        Label7.TabIndex = 10
        Label7.Text = "YEAR LEVEL:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9F)
        Label6.Location = New Point(32, 207)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 17)
        Label6.TabIndex = 9
        Label6.Text = "COURSE:"
        ' 
        ' fullnameLabel
        ' 
        fullnameLabel.AutoSize = True
        fullnameLabel.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fullnameLabel.Location = New Point(89, 174)
        fullnameLabel.Name = "fullnameLabel"
        fullnameLabel.Size = New Size(106, 16)
        fullnameLabel.TabIndex = 8
        fullnameLabel.Text = "User's Fullname"
        ' 
        ' profilepicPBox
        ' 
        profilepicPBox.Image = My.Resources.Resources.circle_user__1_
        profilepicPBox.Location = New Point(89, 58)
        profilepicPBox.Name = "profilepicPBox"
        profilepicPBox.Size = New Size(103, 100)
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
        officersBtn.Text = "Officers"
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
        ratingsBtn.Text = "Ratings"
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
        profileBtn.Text = "Profile"
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
        eventsBtn.Text = "Events"
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
        StartPosition = FormStartPosition.CenterScreen
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
    Friend WithEvents ascRBtn As RadioButton
    Friend WithEvents descRBtn As RadioButton
    Friend WithEvents studLBox As ListBox
    Friend WithEvents nameSearch As TextBox
End Class
