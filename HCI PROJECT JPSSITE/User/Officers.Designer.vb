<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Officers
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
        Panel4 = New Panel()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        sexLabel = New Label()
        ageLabel = New Label()
        sectionLabel = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        nameLabel = New Label()
        officerPBox = New PictureBox()
        officerPositionCBox = New ComboBox()
        Label4 = New Label()
        Panel2 = New Panel()
        motoRTBox = New RichTextBox()
        Label15 = New Label()
        achieveLBox = New ListBox()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        logoutBtn = New Button()
        usernameLabel = New Label()
        PictureBox1 = New PictureBox()
        officersBtn = New Button()
        ratingsBtn = New Button()
        profileBtn = New Button()
        eventsBtn = New Button()
        dashboardBtn = New Button()
        MySqlCommand1 = New MySqlConnector.MySqlCommand()
        Panel4.SuspendLayout()
        CType(officerPBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Label14)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(sexLabel)
        Panel4.Controls.Add(ageLabel)
        Panel4.Controls.Add(sectionLabel)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(nameLabel)
        Panel4.Controls.Add(officerPBox)
        Panel4.Controls.Add(officerPositionCBox)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(180, 68)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(292, 370)
        Panel4.TabIndex = 24
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
        ' sexLabel
        ' 
        sexLabel.AutoSize = True
        sexLabel.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sexLabel.Location = New Point(181, 325)
        sexLabel.Name = "sexLabel"
        sexLabel.Size = New Size(31, 16)
        sexLabel.TabIndex = 11
        sexLabel.Text = "M/F"
        sexLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ageLabel
        ' 
        ageLabel.AutoSize = True
        ageLabel.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ageLabel.Location = New Point(181, 294)
        ageLabel.Name = "ageLabel"
        ageLabel.Size = New Size(21, 16)
        ageLabel.TabIndex = 10
        ageLabel.Text = "20"
        ageLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' sectionLabel
        ' 
        sectionLabel.AutoSize = True
        sectionLabel.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sectionLabel.Location = New Point(181, 264)
        sectionLabel.Name = "sectionLabel"
        sectionLabel.Size = New Size(53, 16)
        sectionLabel.TabIndex = 9
        sectionLabel.Text = "BSIT 2A"
        sectionLabel.TextAlign = ContentAlignment.MiddleCenter
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
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nameLabel.Location = New Point(116, 230)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(46, 16)
        nameLabel.TabIndex = 5
        nameLabel.Text = "Name"
        nameLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' officerPBox
        ' 
        officerPBox.Location = New Point(74, 88)
        officerPBox.Name = "officerPBox"
        officerPBox.Size = New Size(135, 130)
        officerPBox.TabIndex = 4
        officerPBox.TabStop = False
        ' 
        ' officerPositionCBox
        ' 
        officerPositionCBox.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        officerPositionCBox.FormattingEnabled = True
        officerPositionCBox.Items.AddRange(New Object() {"President", "Vice President", "Secretary", "Assitance Secretary", "VP Finance", "VP Auditor", "VP Marketing", "VP Event Management", "Internal Guest Relation", "External Guest Relation"})
        officerPositionCBox.Location = New Point(33, 48)
        officerPositionCBox.Name = "officerPositionCBox"
        officerPositionCBox.Size = New Size(220, 24)
        officerPositionCBox.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.MidnightBlue
        Label4.Location = New Point(33, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(220, 25)
        Label4.TabIndex = 2
        Label4.Text = "Personal Information"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(motoRTBox)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(achieveLBox)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(490, 68)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(288, 370)
        Panel2.TabIndex = 22
        ' 
        ' motoRTBox
        ' 
        motoRTBox.BorderStyle = BorderStyle.None
        motoRTBox.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        motoRTBox.Location = New Point(17, 230)
        motoRTBox.Name = "motoRTBox"
        motoRTBox.Size = New Size(256, 127)
        motoRTBox.TabIndex = 4
        motoRTBox.Text = ""
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.MidnightBlue
        Label15.Location = New Point(105, 199)
        Label15.Name = "Label15"
        Label15.Size = New Size(76, 25)
        Label15.TabIndex = 3
        Label15.Text = "MOTO"
        ' 
        ' achieveLBox
        ' 
        achieveLBox.BorderStyle = BorderStyle.None
        achieveLBox.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        achieveLBox.FormattingEnabled = True
        achieveLBox.ItemHeight = 17
        achieveLBox.Location = New Point(17, 48)
        achieveLBox.Name = "achieveLBox"
        achieveLBox.Size = New Size(256, 119)
        achieveLBox.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(62, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 25)
        Label1.TabIndex = 1
        Label1.Text = "Achievements"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._2
        PictureBox2.Location = New Point(731, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 45)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.MidnightBlue
        Label3.Location = New Point(582, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 25)
        Label3.TabIndex = 20
        Label3.Text = "JPPSITE ORG."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(180, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 25)
        Label2.TabIndex = 19
        Label2.Text = "OFFICERS"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.CornflowerBlue
        Panel1.Controls.Add(logoutBtn)
        Panel1.Controls.Add(usernameLabel)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(officersBtn)
        Panel1.Controls.Add(ratingsBtn)
        Panel1.Controls.Add(profileBtn)
        Panel1.Controls.Add(eventsBtn)
        Panel1.Controls.Add(dashboardBtn)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(153, 427)
        Panel1.TabIndex = 18
        ' 
        ' logoutBtn
        ' 
        logoutBtn.BackColor = Color.CornflowerBlue
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
        usernameLabel.Text = "User"
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
        officersBtn.BackColor = Color.RoyalBlue
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
        ratingsBtn.BackColor = Color.CornflowerBlue
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
        profileBtn.BackColor = Color.CornflowerBlue
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
        eventsBtn.BackColor = Color.CornflowerBlue
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
        ' dashboardBtn
        ' 
        dashboardBtn.BackColor = Color.CornflowerBlue
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
        ' MySqlCommand1
        ' 
        MySqlCommand1.CommandTimeout = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.Transaction = Nothing
        MySqlCommand1.UpdatedRowSource = UpdateRowSource.None
        ' 
        ' Officers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "Officers"
        Text = "Officers"
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(officerPBox, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents logoutBtn As Button
    Friend WithEvents usernameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents officersBtn As Button
    Friend WithEvents ratingsBtn As Button
    Friend WithEvents profileBtn As Button
    Friend WithEvents eventsBtn As Button
    Friend WithEvents dashboardBtn As Button
    Friend WithEvents MySqlCommand1 As MySqlConnector.MySqlCommand
    Friend WithEvents officerPBox As PictureBox
    Friend WithEvents officerPositionCBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents sexLabel As Label
    Friend WithEvents ageLabel As Label
    Friend WithEvents sectionLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents motoRTBox As RichTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents achieveLBox As ListBox
End Class
