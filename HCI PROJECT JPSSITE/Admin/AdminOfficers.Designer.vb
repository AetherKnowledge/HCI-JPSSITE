﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminOfficers
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
        MySqlCommand1 = New MySqlConnector.MySqlCommand()
        logoutBtn = New Button()
        usernameLabel = New Label()
        PictureBox1 = New PictureBox()
        officersBtn = New Button()
        ratingsBtn = New Button()
        profileBtn = New Button()
        eventsBtn = New Button()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        dashboardBtn = New Button()
        Panel2 = New Panel()
        achivementsRTBox = New RichTextBox()
        saveBtn = New Button()
        motoRTBox = New RichTextBox()
        Label15 = New Label()
        Label1 = New Label()
        Panel4 = New Panel()
        nameTextBox = New TextBox()
        sexCmBox = New ComboBox()
        ageCmBox = New ComboBox()
        sectionCmBox = New ComboBox()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        officerPBox = New PictureBox()
        officerPositionCBox = New ComboBox()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(officerPBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CommandTimeout = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.Transaction = Nothing
        MySqlCommand1.UpdatedRowSource = UpdateRowSource.None
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
        officersBtn.BackColor = SystemColors.ControlDark
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
        profileBtn.BackColor = SystemColors.ControlDarkDark
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
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._2
        PictureBox2.Location = New Point(736, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 45)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 28
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(587, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 25)
        Label3.TabIndex = 27
        Label3.Text = "JPPSITE ORG."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(185, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 25)
        Label2.TabIndex = 26
        Label2.Text = "OFFICERS"
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
        Panel1.TabIndex = 25
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
        Panel2.Controls.Add(achivementsRTBox)
        Panel2.Controls.Add(saveBtn)
        Panel2.Controls.Add(motoRTBox)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(495, 68)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(288, 370)
        Panel2.TabIndex = 29
        ' 
        ' achivementsRTBox
        ' 
        achivementsRTBox.BorderStyle = BorderStyle.None
        achivementsRTBox.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        achivementsRTBox.Location = New Point(17, 39)
        achivementsRTBox.Name = "achivementsRTBox"
        achivementsRTBox.Size = New Size(256, 157)
        achivementsRTBox.TabIndex = 6
        achivementsRTBox.Text = "hehehehe"
        ' 
        ' saveBtn
        ' 
        saveBtn.BackColor = SystemColors.ControlDarkDark
        saveBtn.FlatStyle = FlatStyle.Popup
        saveBtn.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        saveBtn.ForeColor = Color.White
        saveBtn.Location = New Point(106, 325)
        saveBtn.Name = "saveBtn"
        saveBtn.Size = New Size(75, 23)
        saveBtn.TabIndex = 5
        saveBtn.Text = "SAVE"
        saveBtn.UseVisualStyleBackColor = False
        ' 
        ' motoRTBox
        ' 
        motoRTBox.BorderStyle = BorderStyle.None
        motoRTBox.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        motoRTBox.Location = New Point(17, 230)
        motoRTBox.Name = "motoRTBox"
        motoRTBox.Size = New Size(256, 80)
        motoRTBox.TabIndex = 4
        motoRTBox.Text = "hehehehe"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = SystemColors.ActiveCaptionText
        Label15.Location = New Point(105, 199)
        Label15.Name = "Label15"
        Label15.Size = New Size(76, 25)
        Label15.TabIndex = 3
        Label15.Text = "MOTO"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(62, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 25)
        Label1.TabIndex = 1
        Label1.Text = "Achievements"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(nameTextBox)
        Panel4.Controls.Add(sexCmBox)
        Panel4.Controls.Add(ageCmBox)
        Panel4.Controls.Add(sectionCmBox)
        Panel4.Controls.Add(Label14)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(officerPBox)
        Panel4.Controls.Add(officerPositionCBox)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(185, 68)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(292, 370)
        Panel4.TabIndex = 30
        ' 
        ' nameTextBox
        ' 
        nameTextBox.Location = New Point(39, 224)
        nameTextBox.Name = "nameTextBox"
        nameTextBox.Size = New Size(214, 23)
        nameTextBox.TabIndex = 18
        ' 
        ' sexCmBox
        ' 
        sexCmBox.FlatStyle = FlatStyle.Flat
        sexCmBox.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sexCmBox.FormattingEnabled = True
        sexCmBox.Items.AddRange(New Object() {"Male", "Female"})
        sexCmBox.Location = New Point(164, 321)
        sexCmBox.Name = "sexCmBox"
        sexCmBox.Size = New Size(89, 24)
        sexCmBox.TabIndex = 17
        ' 
        ' ageCmBox
        ' 
        ageCmBox.FlatStyle = FlatStyle.Flat
        ageCmBox.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ageCmBox.FormattingEnabled = True
        ageCmBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40"})
        ageCmBox.Location = New Point(164, 291)
        ageCmBox.Name = "ageCmBox"
        ageCmBox.Size = New Size(89, 24)
        ageCmBox.TabIndex = 16
        ' 
        ' sectionCmBox
        ' 
        sectionCmBox.FlatStyle = FlatStyle.Flat
        sectionCmBox.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sectionCmBox.FormattingEnabled = True
        sectionCmBox.Items.AddRange(New Object() {"BSIT - 1A", "BSIT - 1B", "BSIT - 2A", "BSIT - 2B", "BSIT - 3", "BSIT - 4"})
        sectionCmBox.Location = New Point(164, 262)
        sectionCmBox.Name = "sectionCmBox"
        sectionCmBox.Size = New Size(89, 24)
        sectionCmBox.TabIndex = 15
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(132, 325)
        Label14.Name = "Label14"
        Label14.Size = New Size(11, 16)
        Label14.TabIndex = 14
        Label14.Text = ":"
        Label14.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(132, 294)
        Label13.Name = "Label13"
        Label13.Size = New Size(11, 16)
        Label13.TabIndex = 13
        Label13.Text = ":"
        Label13.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(132, 264)
        Label12.Name = "Label12"
        Label12.Size = New Size(11, 16)
        Label12.TabIndex = 12
        Label12.Text = ":"
        Label12.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(64, 325)
        Label8.Name = "Label8"
        Label8.Size = New Size(29, 16)
        Label8.TabIndex = 8
        Label8.Text = "Sex"
        Label8.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(59, 294)
        Label7.Name = "Label7"
        Label7.Size = New Size(34, 16)
        Label7.TabIndex = 7
        Label7.Text = "Age"
        Label7.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(39, 264)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 16)
        Label6.TabIndex = 6
        Label6.Text = "Section"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' officerPBox
        ' 
        officerPBox.Image = My.Resources.Resources.Pres_Darren
        officerPBox.Location = New Point(74, 88)
        officerPBox.Name = "officerPBox"
        officerPBox.Size = New Size(135, 130)
        officerPBox.SizeMode = PictureBoxSizeMode.Zoom
        officerPBox.TabIndex = 4
        officerPBox.TabStop = False
        ' 
        ' officerPositionCBox
        ' 
        officerPositionCBox.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        officerPositionCBox.FormattingEnabled = True
        officerPositionCBox.Items.AddRange(New Object() {"President", "Vice President", "Secretary", "Assitance Secretary", "VP Finance", "VP Auditor", "VP Marketing", "VP Event Management", "Internal Guest Relation", "External Guest Relation", "Creative Manager"})
        officerPositionCBox.Location = New Point(33, 48)
        officerPositionCBox.Name = "officerPositionCBox"
        officerPositionCBox.Size = New Size(220, 24)
        officerPositionCBox.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(33, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(220, 25)
        Label4.TabIndex = 2
        Label4.Text = "Personal Information"
        ' 
        ' AdminOfficers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Panel4)
        Name = "AdminOfficers"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminOfficers"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(officerPBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MySqlCommand1 As MySqlConnector.MySqlCommand
    Friend WithEvents logoutBtn As Button
    Friend WithEvents usernameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents officersBtn As Button
    Friend WithEvents ratingsBtn As Button
    Friend WithEvents profileBtn As Button
    Friend WithEvents eventsBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dashboardBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents motoRTBox As RichTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents officerPBox As PictureBox
    Friend WithEvents officerPositionCBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sexCmBox As ComboBox
    Friend WithEvents ageCmBox As ComboBox
    Friend WithEvents sectionCmBox As ComboBox
    Friend WithEvents saveBtn As Button
    Friend WithEvents achivementsRTBox As RichTextBox
    Friend WithEvents nameTextBox As TextBox
End Class
