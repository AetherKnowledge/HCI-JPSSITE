<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ratings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ratings))
        Panel4 = New Panel()
        rateBtn = New Button()
        eventpicPBox = New PictureBox()
        eventselectCBox = New ComboBox()
        Label4 = New Label()
        logoutBtn = New Button()
        usernameLabel = New Label()
        PictureBox1 = New PictureBox()
        officersBtn = New Button()
        ratingsBtn = New Button()
        profileBtn = New Button()
        eventsBtn = New Button()
        Panel1 = New Panel()
        dashboardBtn = New Button()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Panel2 = New Panel()
        sendBtn = New Button()
        yourcommentRTBox = New RichTextBox()
        allcommentRTBox = New RichTextBox()
        Label1 = New Label()
        Panel4.SuspendLayout()
        CType(eventpicPBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(rateBtn)
        Panel4.Controls.Add(eventpicPBox)
        Panel4.Controls.Add(eventselectCBox)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(180, 68)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(292, 370)
        Panel4.TabIndex = 30
        ' 
        ' rateBtn
        ' 
        rateBtn.BackColor = Color.CornflowerBlue
        rateBtn.FlatStyle = FlatStyle.Flat
        rateBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rateBtn.ForeColor = Color.White
        rateBtn.Location = New Point(101, 320)
        rateBtn.Name = "rateBtn"
        rateBtn.Size = New Size(90, 31)
        rateBtn.TabIndex = 49
        rateBtn.Text = "RATE"
        rateBtn.UseVisualStyleBackColor = False
        ' 
        ' eventpicPBox
        ' 
        eventpicPBox.Image = My.Resources.Resources.EVENT_2
        eventpicPBox.Location = New Point(45, 89)
        eventpicPBox.Name = "eventpicPBox"
        eventpicPBox.Size = New Size(197, 179)
        eventpicPBox.SizeMode = PictureBoxSizeMode.Zoom
        eventpicPBox.TabIndex = 4
        eventpicPBox.TabStop = False
        ' 
        ' eventselectCBox
        ' 
        eventselectCBox.Font = New Font("Century Gothic", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        eventselectCBox.FormattingEnabled = True
        eventselectCBox.Items.AddRange(New Object() {"Event 1", "Event 2", "Event 3"})
        eventselectCBox.Location = New Point(36, 58)
        eventselectCBox.Name = "eventselectCBox"
        eventselectCBox.Size = New Size(217, 25)
        eventselectCBox.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.MidnightBlue
        Label4.Location = New Point(36, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(217, 25)
        Label4.TabIndex = 2
        Label4.Text = "Overall Event Rating"
        ' 
        ' logoutBtn
        ' 
        logoutBtn.BackColor = Color.CornflowerBlue
        logoutBtn.FlatStyle = FlatStyle.Popup
        logoutBtn.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        usernameLabel.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        officersBtn.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        ratingsBtn.BackColor = Color.RoyalBlue
        ratingsBtn.FlatStyle = FlatStyle.Popup
        ratingsBtn.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        profileBtn.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        eventsBtn.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(153, 427)
        Panel1.TabIndex = 25
        ' 
        ' dashboardBtn
        ' 
        dashboardBtn.BackColor = Color.CornflowerBlue
        dashboardBtn.FlatStyle = FlatStyle.Popup
        dashboardBtn.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dashboardBtn.ForeColor = Color.White
        dashboardBtn.Location = New Point(12, 114)
        dashboardBtn.Name = "dashboardBtn"
        dashboardBtn.Size = New Size(128, 37)
        dashboardBtn.TabIndex = 2
        dashboardBtn.Text = "My Dashboard"
        dashboardBtn.TextAlign = ContentAlignment.MiddleLeft
        dashboardBtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._2
        PictureBox2.Location = New Point(731, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 45)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 28
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(180, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 25)
        Label2.TabIndex = 26
        Label2.Text = "RATINGS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.MidnightBlue
        Label3.Location = New Point(582, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 25)
        Label3.TabIndex = 27
        Label3.Text = "JPPSITE ORG."
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(152, 83)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 16)
        TextBox1.TabIndex = 39
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.White
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(152, 133)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 16)
        TextBox2.TabIndex = 40
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.White
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(152, 235)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 16)
        TextBox3.TabIndex = 42
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.White
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(152, 288)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 16)
        TextBox4.TabIndex = 43
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(sendBtn)
        Panel2.Controls.Add(yourcommentRTBox)
        Panel2.Controls.Add(allcommentRTBox)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(490, 68)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(288, 370)
        Panel2.TabIndex = 29
        ' 
        ' sendBtn
        ' 
        sendBtn.BackColor = Color.CornflowerBlue
        sendBtn.FlatStyle = FlatStyle.Flat
        sendBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sendBtn.ForeColor = Color.White
        sendBtn.Location = New Point(224, 310)
        sendBtn.Name = "sendBtn"
        sendBtn.Size = New Size(50, 41)
        sendBtn.TabIndex = 54
        sendBtn.Text = "SEND"
        sendBtn.UseVisualStyleBackColor = False
        ' 
        ' yourcommentRTBox
        ' 
        yourcommentRTBox.BorderStyle = BorderStyle.FixedSingle
        yourcommentRTBox.Location = New Point(14, 310)
        yourcommentRTBox.Name = "yourcommentRTBox"
        yourcommentRTBox.Size = New Size(204, 41)
        yourcommentRTBox.TabIndex = 45
        yourcommentRTBox.Text = ""
        ' 
        ' allcommentRTBox
        ' 
        allcommentRTBox.BackColor = Color.White
        allcommentRTBox.BorderStyle = BorderStyle.None
        allcommentRTBox.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        allcommentRTBox.Location = New Point(14, 58)
        allcommentRTBox.Name = "allcommentRTBox"
        allcommentRTBox.ReadOnly = True
        allcommentRTBox.Size = New Size(260, 224)
        allcommentRTBox.TabIndex = 44
        allcommentRTBox.Text = resources.GetString("allcommentRTBox.Text")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(65, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 25)
        Label1.TabIndex = 1
        Label1.Text = "Comment Wall"
        ' 
        ' Ratings
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(Label3)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Ratings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Forum"
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(eventpicPBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents logoutBtn As Button
    Friend WithEvents usernameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents officersBtn As Button
    Friend WithEvents ratingsBtn As Button
    Friend WithEvents profileBtn As Button
    Friend WithEvents eventsBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dashboardBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents eventpicPBox As PictureBox
    Friend WithEvents eventselectCBox As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents rateBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents allcommentRTBox As RichTextBox
    Friend WithEvents sendBtn As Button
    Friend WithEvents yourcommentRTBox As RichTextBox
End Class
