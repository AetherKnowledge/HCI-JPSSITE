<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ratings3
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
        logoutBtn = New Button()
        usernameLabel = New Label()
        PictureBox1 = New PictureBox()
        officersBtn = New Button()
        ratingsBtn = New Button()
        profileBtn = New Button()
        eventsBtn = New Button()
        dashboardBtn = New Button()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label11 = New Label()
        Label10 = New Label()
        Label13 = New Label()
        ComboBox1 = New ComboBox()
        Label9 = New Label()
        Label8 = New Label()
        Panel5 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Button7 = New Button()
        Button4 = New Button()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
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
        Panel1.TabIndex = 41
        ' 
        ' logoutBtn
        ' 
        logoutBtn.BackColor = Color.CornflowerBlue
        logoutBtn.FlatStyle = FlatStyle.Flat
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
        officersBtn.FlatStyle = FlatStyle.Flat
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
        ratingsBtn.BackColor = Color.RoyalBlue
        ratingsBtn.FlatStyle = FlatStyle.Flat
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
        profileBtn.FlatStyle = FlatStyle.Flat
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
        eventsBtn.FlatStyle = FlatStyle.Flat
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
        dashboardBtn.FlatStyle = FlatStyle.Flat
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
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._2
        PictureBox2.Location = New Point(731, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 45)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 44
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.RoyalBlue
        Label2.Location = New Point(180, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 25)
        Label2.TabIndex = 42
        Label2.Text = "RATINGS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.RoyalBlue
        Label3.Location = New Point(582, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 25)
        Label3.TabIndex = 43
        Label3.Text = "JPPSITE ORG."
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(ComboBox3)
        Panel2.Controls.Add(ComboBox2)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Button7)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(180, 68)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(598, 370)
        Panel2.TabIndex = 45
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        ComboBox3.Location = New Point(384, 240)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(142, 25)
        ComboBox3.TabIndex = 29
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        ComboBox2.Location = New Point(384, 185)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(142, 25)
        ComboBox2.TabIndex = 28
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(44, 248)
        Label11.Name = "Label11"
        Label11.Size = New Size(241, 17)
        Label11.TabIndex = 27
        Label11.Text = "2. How well are your expectations met?"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(98, 193)
        Label10.Name = "Label10"
        Label10.Size = New Size(153, 17)
        Label10.TabIndex = 26
        Label10.Text = "1.2 Social development."
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(98, 152)
        Label13.Name = "Label13"
        Label13.Size = New Size(187, 17)
        Label13.TabIndex = 25
        Label13.Text = "1.1. Personal growth obtained."
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        ComboBox1.Location = New Point(384, 144)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(142, 25)
        ComboBox1.TabIndex = 21
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(44, 109)
        Label9.Name = "Label9"
        Label9.Size = New Size(249, 17)
        Label9.TabIndex = 13
        Label9.Text = "1. How beneficial the activity in terms of:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(100, 58)
        Label8.Name = "Label8"
        Label8.Size = New Size(380, 15)
        Label8.TabIndex = 12
        Label8.Text = "Rate the fields below from 1-5, 1 being the lowest and 5 the highest."
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.CornflowerBlue
        Panel5.Location = New Point(343, 351)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(80, 3)
        Panel5.TabIndex = 11
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Silver
        Panel4.Location = New Point(171, 351)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(80, 3)
        Panel4.TabIndex = 10
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Silver
        Panel3.Location = New Point(257, 351)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(80, 3)
        Panel3.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.CornflowerBlue
        Label7.Location = New Point(451, 20)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 25)
        Label7.TabIndex = 8
        Label7.Text = "Overall"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Silver
        Label6.Location = New Point(340, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 25)
        Label6.TabIndex = 7
        Label6.Text = "Speakers"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.CornflowerBlue
        Label5.Location = New Point(208, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(18, 25)
        Label5.TabIndex = 6
        Label5.Text = ":"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Silver
        Label4.Location = New Point(232, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 25)
        Label4.TabIndex = 5
        Label4.Text = "Activities"
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.White
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = Color.Black
        Button7.Location = New Point(23, 321)
        Button7.Name = "Button7"
        Button7.Size = New Size(110, 33)
        Button7.TabIndex = 4
        Button7.Text = "Back"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.CornflowerBlue
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(465, 321)
        Button4.Name = "Button4"
        Button4.Size = New Size(110, 33)
        Button4.TabIndex = 3
        Button4.Text = "Submit"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.CornflowerBlue
        Label1.Location = New Point(23, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 25)
        Label1.TabIndex = 1
        Label1.Text = "Event Evaluation"
        ' 
        ' Ratings3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Ratings3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ratings3"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents logoutBtn As Button
    Friend WithEvents usernameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents officersBtn As Button
    Friend WithEvents ratingsBtn As Button
    Friend WithEvents profileBtn As Button
    Friend WithEvents eventsBtn As Button
    Friend WithEvents dashboardBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
End Class
