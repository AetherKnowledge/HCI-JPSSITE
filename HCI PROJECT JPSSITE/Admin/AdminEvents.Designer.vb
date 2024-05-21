<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminEvents
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
        Panel4 = New Panel()
        saveEventBtn = New Button()
        uploadBtn = New Button()
        eventPBox = New PictureBox()
        schedPicker = New DateTimePicker()
        Label6 = New Label()
        eventTitleTBox = New TextBox()
        Label5 = New Label()
        logoutBtn = New Button()
        usernameLabel = New Label()
        PictureBox1 = New PictureBox()
        officersBtn = New Button()
        ratingsBtn = New Button()
        profileBtn = New Button()
        Label1 = New Label()
        event2LBox = New ListBox()
        eventsBtn = New Button()
        Panel1 = New Panel()
        dashboardBtn = New Button()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel4.SuspendLayout()
        CType(eventPBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(15, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 25)
        Label4.TabIndex = 2
        Label4.Text = "Add Event"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(saveEventBtn)
        Panel4.Controls.Add(uploadBtn)
        Panel4.Controls.Add(eventPBox)
        Panel4.Controls.Add(schedPicker)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(eventTitleTBox)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(185, 68)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(292, 370)
        Panel4.TabIndex = 24
        ' 
        ' saveEventBtn
        ' 
        saveEventBtn.BackColor = SystemColors.ControlDarkDark
        saveEventBtn.FlatStyle = FlatStyle.Popup
        saveEventBtn.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        saveEventBtn.ForeColor = Color.White
        saveEventBtn.Location = New Point(142, 314)
        saveEventBtn.Name = "saveEventBtn"
        saveEventBtn.Size = New Size(98, 34)
        saveEventBtn.TabIndex = 11
        saveEventBtn.Text = "Save Event"
        saveEventBtn.UseVisualStyleBackColor = False
        ' 
        ' uploadBtn
        ' 
        uploadBtn.FlatStyle = FlatStyle.Popup
        uploadBtn.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        uploadBtn.Location = New Point(38, 314)
        uploadBtn.Name = "uploadBtn"
        uploadBtn.Size = New Size(94, 34)
        uploadBtn.TabIndex = 8
        uploadBtn.Text = "Upload"
        uploadBtn.UseVisualStyleBackColor = True
        ' 
        ' eventPBox
        ' 
        eventPBox.Image = My.Resources.Resources.upload
        eventPBox.Location = New Point(38, 130)
        eventPBox.Name = "eventPBox"
        eventPBox.Size = New Size(202, 169)
        eventPBox.SizeMode = PictureBoxSizeMode.Zoom
        eventPBox.TabIndex = 7
        eventPBox.TabStop = False
        ' 
        ' schedPicker
        ' 
        schedPicker.CalendarFont = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        schedPicker.Location = New Point(79, 91)
        schedPicker.Name = "schedPicker"
        schedPicker.Size = New Size(161, 23)
        schedPicker.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label6.Location = New Point(38, 96)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 16)
        Label6.TabIndex = 5
        Label6.Text = "Date:"
        ' 
        ' eventTitleTBox
        ' 
        eventTitleTBox.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        eventTitleTBox.Location = New Point(79, 58)
        eventTitleTBox.Name = "eventTitleTBox"
        eventTitleTBox.Size = New Size(161, 22)
        eventTitleTBox.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label5.Location = New Point(38, 63)
        Label5.Name = "Label5"
        Label5.Size = New Size(33, 16)
        Label5.TabIndex = 3
        Label5.Text = "Title:"
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(24, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 25)
        Label1.TabIndex = 1
        Label1.Text = "Event List"
        ' 
        ' event2LBox
        ' 
        event2LBox.BorderStyle = BorderStyle.None
        event2LBox.FormattingEnabled = True
        event2LBox.ItemHeight = 15
        event2LBox.Location = New Point(24, 63)
        event2LBox.Name = "event2LBox"
        event2LBox.Size = New Size(242, 285)
        event2LBox.TabIndex = 0
        ' 
        ' eventsBtn
        ' 
        eventsBtn.BackColor = SystemColors.ControlDark
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
        Panel1.TabIndex = 18
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
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(event2LBox)
        Panel2.Location = New Point(495, 68)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(288, 370)
        Panel2.TabIndex = 22
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._2
        PictureBox2.Location = New Point(736, 12)
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
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(587, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 25)
        Label3.TabIndex = 20
        Label3.Text = "JPPSITE ORG."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(185, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 25)
        Label2.TabIndex = 19
        Label2.Text = "EVENTS"
        ' 
        ' AdminEvents
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "AdminEvents"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminEvents"
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(eventPBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents logoutBtn As Button
    Friend WithEvents usernameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents officersBtn As Button
    Friend WithEvents ratingsBtn As Button
    Friend WithEvents profileBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents event2LBox As ListBox
    Friend WithEvents eventsBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dashboardBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents eventTitleTBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents uploadBtn As Button
    Friend WithEvents eventPBox As PictureBox
    Friend WithEvents schedPicker As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents saveEventBtn As Button
End Class
