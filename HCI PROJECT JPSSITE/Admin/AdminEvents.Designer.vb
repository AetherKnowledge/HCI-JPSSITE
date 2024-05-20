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
        eventLBox = New ListBox()
        eventCal = New MonthCalendar()
        logoutBtn = New Button()
        usernameLabel = New Label()
        PictureBox1 = New PictureBox()
        officersBtn = New Button()
        ratingsBtn = New Button()
        profileBtn = New Button()
        Panel3 = New Panel()
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.MidnightBlue
        Label4.Location = New Point(15, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(246, 25)
        Label4.TabIndex = 2
        Label4.Text = "Current and Upcoming"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(eventLBox)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(185, 68)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(292, 168)
        Panel4.TabIndex = 24
        ' 
        ' eventLBox
        ' 
        eventLBox.BorderStyle = BorderStyle.None
        eventLBox.FormattingEnabled = True
        eventLBox.ItemHeight = 15
        eventLBox.Location = New Point(25, 45)
        eventLBox.Name = "eventLBox"
        eventLBox.Size = New Size(242, 105)
        eventLBox.TabIndex = 3
        ' 
        ' eventCal
        ' 
        eventCal.Location = New Point(28, 12)
        eventCal.Name = "eventCal"
        eventCal.TabIndex = 0
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
        officersBtn.BackColor = Color.CornflowerBlue
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(eventCal)
        Panel3.Location = New Point(185, 255)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(292, 183)
        Panel3.TabIndex = 23
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(24, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 25)
        Label1.TabIndex = 1
        Label1.Text = "Past Events"
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
        eventsBtn.BackColor = Color.RoyalBlue
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
        Panel1.Location = New Point(17, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(153, 427)
        Panel1.TabIndex = 18
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
        Label3.ForeColor = Color.MidnightBlue
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
        Label2.ForeColor = Color.MidnightBlue
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
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "AdminEvents"
        Text = "AdminEvents"
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents eventLBox As ListBox
    Friend WithEvents eventCal As MonthCalendar
    Friend WithEvents logoutBtn As Button
    Friend WithEvents usernameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents officersBtn As Button
    Friend WithEvents ratingsBtn As Button
    Friend WithEvents profileBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents event2LBox As ListBox
    Friend WithEvents eventsBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dashboardBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
