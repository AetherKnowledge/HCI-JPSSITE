<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Button5 = New Button()
        Button6 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        Panel2 = New Panel()
        Label4 = New Label()
        Panel3 = New Panel()
        RichTextBox1 = New RichTextBox()
        Label5 = New Label()
        Panel4 = New Panel()
        PictureBox5 = New PictureBox()
        Label7 = New Label()
        Panel5 = New Panel()
        PictureBox4 = New PictureBox()
        Label6 = New Label()
        Button4 = New Button()
        Button7 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.CornflowerBlue
        Panel1.Controls.Add(logoutBtn)
        Panel1.Controls.Add(usernameLabel)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(9, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(153, 427)
        Panel1.TabIndex = 0
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
        ' Button5
        ' 
        Button5.BackColor = Color.CornflowerBlue
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(12, 286)
        Button5.Name = "Button5"
        Button5.Size = New Size(128, 37)
        Button5.TabIndex = 5
        Button5.Text = "My Officers"
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.CornflowerBlue
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.White
        Button6.Location = New Point(12, 243)
        Button6.Name = "Button6"
        Button6.Size = New Size(128, 37)
        Button6.TabIndex = 4
        Button6.Text = "My Forum"
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.CornflowerBlue
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(12, 200)
        Button3.Name = "Button3"
        Button3.Size = New Size(128, 37)
        Button3.TabIndex = 3
        Button3.Text = "My Profile"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.CornflowerBlue
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(12, 157)
        Button2.Name = "Button2"
        Button2.Size = New Size(128, 37)
        Button2.TabIndex = 3
        Button2.Text = "My Events"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.RoyalBlue
        Button1.FlatStyle = FlatStyle.Flat
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(177, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 25)
        Label2.TabIndex = 1
        Label2.Text = "DASHBOARD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(579, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 25)
        Label3.TabIndex = 2
        Label3.Text = "JPPSITE ORG."
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._2
        PictureBox2.Location = New Point(728, 11)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 45)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.EVENT_2
        PictureBox3.Location = New Point(0, -1)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(593, 146)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = Color.Transparent
        RadioButton1.Checked = True
        RadioButton1.ForeColor = Color.CornflowerBlue
        RadioButton1.Location = New Point(275, 129)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(14, 13)
        RadioButton1.TabIndex = 5
        RadioButton1.TabStop = True
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = Color.Transparent
        RadioButton2.Location = New Point(255, 129)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(14, 13)
        RadioButton2.TabIndex = 6
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.BackColor = Color.Transparent
        RadioButton3.Location = New Point(295, 129)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(14, 13)
        RadioButton3.TabIndex = 7
        RadioButton3.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(RadioButton3)
        Panel2.Controls.Add(RadioButton2)
        Panel2.Controls.Add(RadioButton1)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(182, 60)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(593, 145)
        Panel2.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.CornflowerBlue
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(0, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 19)
        Label4.TabIndex = 8
        Label4.Text = "JPPSITE DAYS"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Button7)
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(RichTextBox1)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(182, 223)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(184, 215)
        Panel3.TabIndex = 9
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(12, 39)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(157, 160)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = "1.__________________" & vbLf & "2.__________________" & vbLf & "3.__________________" & vbLf & "4.__________________" & vbLf & "5.__________________"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.CornflowerBlue
        Label5.ImageAlign = ContentAlignment.MiddleLeft
        Label5.Location = New Point(3, 6)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 19)
        Label5.TabIndex = 0
        Label5.Text = "My Latest News"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(PictureBox5)
        Panel4.Controls.Add(Label7)
        Panel4.Location = New Point(591, 223)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(184, 215)
        Panel4.TabIndex = 10
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.messages
        PictureBox5.Location = New Point(36, 74)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(119, 105)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 3
        PictureBox5.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.CornflowerBlue
        Label7.ImageAlign = ContentAlignment.MiddleLeft
        Label7.Location = New Point(3, 6)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 19)
        Label7.TabIndex = 1
        Label7.Text = "My Forum"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(PictureBox4)
        Panel5.Controls.Add(Label6)
        Panel5.Location = New Point(388, 223)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(184, 215)
        Panel5.TabIndex = 10
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.users_alt
        PictureBox4.Location = New Point(32, 74)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(119, 105)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 2
        PictureBox4.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.CornflowerBlue
        Label6.ImageAlign = ContentAlignment.MiddleLeft
        Label6.Location = New Point(3, 6)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 19)
        Label6.TabIndex = 1
        Label6.Text = "My Officers"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(51, 144)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 2
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(51, 176)
        Button7.Name = "Button7"
        Button7.Size = New Size(75, 23)
        Button7.TabIndex = 3
        Button7.Text = "Button7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(800, 450)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DASHBOARD"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents usernameLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents logoutBtn As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
End Class
