<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Label4 = New Label()
        myoffPBox = New PictureBox()
        Label6 = New Label()
        Panel5 = New Panel()
        myratePBox = New PictureBox()
        Label7 = New Label()
        myprofPBox = New PictureBox()
        Label5 = New Label()
        Label1 = New Label()
        RadioButton3 = New RadioButton()
        eventbannerPBox = New PictureBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label3 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Panel3 = New Panel()
        Panel2 = New Panel()
        profileBtn = New Button()
        eventsBtn = New Button()
        Panel4 = New Panel()
        logoutBtn = New Button()
        usernameLabel = New Label()
        PictureBox1 = New PictureBox()
        officersBtn = New Button()
        ratingsBtn = New Button()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        CType(myoffPBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(myratePBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(myprofPBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(eventbannerPBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(697, 209)
        Label4.Name = "Label4"
        Label4.RightToLeft = RightToLeft.Yes
        Label4.Size = New Size(85, 16)
        Label4.TabIndex = 25
        Label4.Text = "Event Sched"
        ' 
        ' myoffPBox
        ' 
        myoffPBox.Image = My.Resources.Resources.meeting
        myoffPBox.Location = New Point(3, 28)
        myoffPBox.Name = "myoffPBox"
        myoffPBox.Size = New Size(178, 169)
        myoffPBox.SizeMode = PictureBoxSizeMode.Zoom
        myoffPBox.TabIndex = 2
        myoffPBox.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.ImageAlign = ContentAlignment.MiddleLeft
        Label6.Location = New Point(3, 6)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 19)
        Label6.TabIndex = 1
        Label6.Text = "My Officers"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(myoffPBox)
        Panel5.Controls.Add(Label6)
        Panel5.Location = New Point(395, 242)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(184, 197)
        Panel5.TabIndex = 22
        ' 
        ' myratePBox
        ' 
        myratePBox.Image = My.Resources.Resources.ratings_graphics
        myratePBox.Location = New Point(3, 28)
        myratePBox.Name = "myratePBox"
        myratePBox.Size = New Size(178, 169)
        myratePBox.SizeMode = PictureBoxSizeMode.Zoom
        myratePBox.TabIndex = 3
        myratePBox.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.ImageAlign = ContentAlignment.MiddleLeft
        Label7.Location = New Point(3, 6)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 19)
        Label7.TabIndex = 1
        Label7.Text = "My Ratings"
        ' 
        ' myprofPBox
        ' 
        myprofPBox.Image = My.Resources.Resources.profile_graphics
        myprofPBox.Location = New Point(3, 28)
        myprofPBox.Name = "myprofPBox"
        myprofPBox.Size = New Size(178, 169)
        myprofPBox.SizeMode = PictureBoxSizeMode.Zoom
        myprofPBox.TabIndex = 3
        myprofPBox.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.ImageAlign = ContentAlignment.MiddleLeft
        Label5.Location = New Point(3, 6)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 19)
        Label5.TabIndex = 0
        Label5.Text = "My Profile"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(192, 212)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 16)
        Label1.TabIndex = 24
        Label1.Text = "Event title"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.BackColor = Color.Transparent
        RadioButton3.Location = New Point(482, 212)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(14, 13)
        RadioButton3.TabIndex = 19
        RadioButton3.UseVisualStyleBackColor = False
        ' 
        ' eventbannerPBox
        ' 
        eventbannerPBox.Image = My.Resources.Resources.Event_banner
        eventbannerPBox.Location = New Point(0, -1)
        eventbannerPBox.Name = "eventbannerPBox"
        eventbannerPBox.Size = New Size(593, 146)
        eventbannerPBox.SizeMode = PictureBoxSizeMode.StretchImage
        eventbannerPBox.TabIndex = 4
        eventbannerPBox.TabStop = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = Color.Transparent
        RadioButton1.Checked = True
        RadioButton1.ForeColor = Color.CornflowerBlue
        RadioButton1.Location = New Point(462, 212)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(14, 13)
        RadioButton1.TabIndex = 17
        RadioButton1.TabStop = True
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = Color.Transparent
        RadioButton2.Location = New Point(442, 212)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(14, 13)
        RadioButton2.TabIndex = 18
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(586, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 25)
        Label3.TabIndex = 15
        Label3.Text = "JPPSITE ORG."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(184, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 25)
        Label2.TabIndex = 14
        Label2.Text = "DASHBOARD"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlDark
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(12, 114)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 37)
        Button1.TabIndex = 2
        Button1.Text = "My Dashboard"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(myprofPBox)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(189, 242)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(184, 197)
        Panel3.TabIndex = 21
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(eventbannerPBox)
        Panel2.Location = New Point(189, 61)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(593, 145)
        Panel2.TabIndex = 20
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
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(myratePBox)
        Panel4.Controls.Add(Label7)
        Panel4.Location = New Point(598, 242)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(184, 197)
        Panel4.TabIndex = 23
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
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._2
        PictureBox2.Location = New Point(735, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 45)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 16
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
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(19, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(153, 427)
        Panel1.TabIndex = 13
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Panel5)
        Controls.Add(Label1)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton1)
        Controls.Add(RadioButton2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel4)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Name = "AdminDashboard"
        Text = "AdminDashboard"
        CType(myoffPBox, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(myratePBox, ComponentModel.ISupportInitialize).EndInit()
        CType(myprofPBox, ComponentModel.ISupportInitialize).EndInit()
        CType(eventbannerPBox, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents myoffPBox As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents myratePBox As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents myprofPBox As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents eventbannerPBox As PictureBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents profileBtn As Button
    Friend WithEvents eventsBtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents logoutBtn As Button
    Friend WithEvents usernameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents officersBtn As Button
    Friend WithEvents ratingsBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
