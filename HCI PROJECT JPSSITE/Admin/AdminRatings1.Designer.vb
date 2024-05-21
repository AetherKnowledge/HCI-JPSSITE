<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminRatings1
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
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        logoutBtn = New Button()
        usernameLabel = New Label()
        PictureBox1 = New PictureBox()
        officersBtn = New Button()
        ratingsBtn = New Button()
        profileBtn = New Button()
        eventsBtn = New Button()
        dashboardBtn = New Button()
        Label4 = New Label()
        eventselectCBox = New ComboBox()
        Panel4 = New Panel()
        DateTimePicker1 = New DateTimePicker()
        TableLayoutPanel1 = New TableLayoutPanel()
        Q8_Total = New Label()
        Q8_3 = New Label()
        Q8_2 = New Label()
        Q8_5 = New Label()
        Q8_4 = New Label()
        Q8_Mean = New Label()
        Q8_Eval = New Label()
        Q8_1 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Q1_4 = New Label()
        Q1_3 = New Label()
        Q1_5 = New Label()
        Q1_2 = New Label()
        Q1_1 = New Label()
        Q2_5 = New Label()
        Q2_4 = New Label()
        Q2_2 = New Label()
        Q2_3 = New Label()
        Q3_5 = New Label()
        Q3_4 = New Label()
        Q3_3 = New Label()
        Q3_2 = New Label()
        Q2_1 = New Label()
        Q3_1 = New Label()
        Q4_5 = New Label()
        Q4_4 = New Label()
        Q4_3 = New Label()
        Q4_2 = New Label()
        Q4_1 = New Label()
        Q5_5 = New Label()
        Q5_4 = New Label()
        Q5_3 = New Label()
        Q5_2 = New Label()
        Q5_1 = New Label()
        Q6_5 = New Label()
        Q6_4 = New Label()
        Q6_2 = New Label()
        Q6_3 = New Label()
        Q6_1 = New Label()
        Q7_5 = New Label()
        Q7_4 = New Label()
        Q7_3 = New Label()
        Q7_2 = New Label()
        Q7_1 = New Label()
        Q1_Mean = New Label()
        Q1_Total = New Label()
        Q2_Total = New Label()
        Q2_Mean = New Label()
        Q3_Total = New Label()
        Q3_Mean = New Label()
        Q4_Mean = New Label()
        Q4_Total = New Label()
        Q5_Total = New Label()
        Q5_Mean = New Label()
        Q6_Total = New Label()
        Q6_Mean = New Label()
        Q7_Total = New Label()
        Q7_Mean = New Label()
        Q2_Eval = New Label()
        Q3_Eval = New Label()
        Q4_Eval = New Label()
        Q5_Eval = New Label()
        Q6_Eval = New Label()
        Q7_Eval = New Label()
        Q1_Eval = New Label()
        Label32 = New Label()
        Button1 = New Button()
        backBtn = New Button()
        MySqlCommand1 = New MySqlConnector.MySqlCommand()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._2
        PictureBox2.Location = New Point(736, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 45)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 40
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(185, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 25)
        Label2.TabIndex = 38
        Label2.Text = "RATINGS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(587, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 25)
        Label3.TabIndex = 39
        Label3.Text = "JPPSITE ORG."
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
        Panel1.TabIndex = 37
        ' 
        ' logoutBtn
        ' 
        logoutBtn.BackColor = SystemColors.ControlDarkDark
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
        officersBtn.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        ratingsBtn.BackColor = SystemColors.ControlDark
        ratingsBtn.FlatStyle = FlatStyle.Popup
        ratingsBtn.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        profileBtn.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        eventsBtn.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        eventsBtn.ForeColor = Color.White
        eventsBtn.Location = New Point(12, 157)
        eventsBtn.Name = "eventsBtn"
        eventsBtn.Size = New Size(128, 37)
        eventsBtn.TabIndex = 3
        eventsBtn.Text = "Events"
        eventsBtn.TextAlign = ContentAlignment.MiddleLeft
        eventsBtn.UseVisualStyleBackColor = False
        ' 
        ' dashboardBtn
        ' 
        dashboardBtn.BackColor = SystemColors.ControlDarkDark
        dashboardBtn.FlatStyle = FlatStyle.Popup
        dashboardBtn.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dashboardBtn.ForeColor = Color.White
        dashboardBtn.Location = New Point(12, 114)
        dashboardBtn.Name = "dashboardBtn"
        dashboardBtn.Size = New Size(128, 37)
        dashboardBtn.TabIndex = 2
        dashboardBtn.Text = "Dashboard"
        dashboardBtn.TextAlign = ContentAlignment.MiddleLeft
        dashboardBtn.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(18, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 25)
        Label4.TabIndex = 2
        Label4.Text = "Activities"
        ' 
        ' eventselectCBox
        ' 
        eventselectCBox.Font = New Font("Century Gothic", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        eventselectCBox.FormattingEnabled = True
        eventselectCBox.Items.AddRange(New Object() {"Event 1", "Event 2", "Event 3"})
        eventselectCBox.Location = New Point(266, 13)
        eventselectCBox.Name = "eventselectCBox"
        eventselectCBox.Size = New Size(217, 25)
        eventselectCBox.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(DateTimePicker1)
        Panel4.Controls.Add(TableLayoutPanel1)
        Panel4.Controls.Add(Button1)
        Panel4.Controls.Add(backBtn)
        Panel4.Controls.Add(eventselectCBox)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(185, 68)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(598, 370)
        Panel4.TabIndex = 42
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "MM/yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(489, 15)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(82, 23)
        DateTimePicker1.TabIndex = 53
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 9
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 63.02161F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 25.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 25.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 25.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 25.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 25.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 9.682552F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 9.682552F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.61328F))
        TableLayoutPanel1.Controls.Add(Q8_Total, 0, 8)
        TableLayoutPanel1.Controls.Add(Q8_3, 0, 8)
        TableLayoutPanel1.Controls.Add(Q8_2, 0, 8)
        TableLayoutPanel1.Controls.Add(Q8_5, 0, 8)
        TableLayoutPanel1.Controls.Add(Q8_4, 0, 8)
        TableLayoutPanel1.Controls.Add(Q8_Mean, 0, 8)
        TableLayoutPanel1.Controls.Add(Q8_Eval, 0, 8)
        TableLayoutPanel1.Controls.Add(Q8_1, 0, 8)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label5, 1, 0)
        TableLayoutPanel1.Controls.Add(Label6, 2, 0)
        TableLayoutPanel1.Controls.Add(Label7, 3, 0)
        TableLayoutPanel1.Controls.Add(Label8, 4, 0)
        TableLayoutPanel1.Controls.Add(Label9, 5, 0)
        TableLayoutPanel1.Controls.Add(Label10, 6, 0)
        TableLayoutPanel1.Controls.Add(Label11, 7, 0)
        TableLayoutPanel1.Controls.Add(Label12, 8, 0)
        TableLayoutPanel1.Controls.Add(Label13, 0, 1)
        TableLayoutPanel1.Controls.Add(Label14, 0, 2)
        TableLayoutPanel1.Controls.Add(Label15, 0, 3)
        TableLayoutPanel1.Controls.Add(Label16, 0, 4)
        TableLayoutPanel1.Controls.Add(Label17, 0, 5)
        TableLayoutPanel1.Controls.Add(Label18, 0, 6)
        TableLayoutPanel1.Controls.Add(Label19, 0, 7)
        TableLayoutPanel1.Controls.Add(Q1_4, 2, 1)
        TableLayoutPanel1.Controls.Add(Q1_3, 3, 1)
        TableLayoutPanel1.Controls.Add(Q1_5, 1, 1)
        TableLayoutPanel1.Controls.Add(Q1_2, 4, 1)
        TableLayoutPanel1.Controls.Add(Q1_1, 5, 1)
        TableLayoutPanel1.Controls.Add(Q2_5, 1, 2)
        TableLayoutPanel1.Controls.Add(Q2_4, 2, 2)
        TableLayoutPanel1.Controls.Add(Q2_2, 4, 2)
        TableLayoutPanel1.Controls.Add(Q2_3, 3, 2)
        TableLayoutPanel1.Controls.Add(Q3_5, 1, 3)
        TableLayoutPanel1.Controls.Add(Q3_4, 2, 3)
        TableLayoutPanel1.Controls.Add(Q3_3, 3, 3)
        TableLayoutPanel1.Controls.Add(Q3_2, 4, 3)
        TableLayoutPanel1.Controls.Add(Q2_1, 5, 2)
        TableLayoutPanel1.Controls.Add(Q3_1, 5, 3)
        TableLayoutPanel1.Controls.Add(Q4_5, 1, 4)
        TableLayoutPanel1.Controls.Add(Q4_4, 2, 4)
        TableLayoutPanel1.Controls.Add(Q4_3, 3, 4)
        TableLayoutPanel1.Controls.Add(Q4_2, 4, 4)
        TableLayoutPanel1.Controls.Add(Q4_1, 5, 4)
        TableLayoutPanel1.Controls.Add(Q5_5, 1, 5)
        TableLayoutPanel1.Controls.Add(Q5_4, 2, 5)
        TableLayoutPanel1.Controls.Add(Q5_3, 3, 5)
        TableLayoutPanel1.Controls.Add(Q5_2, 4, 5)
        TableLayoutPanel1.Controls.Add(Q5_1, 5, 5)
        TableLayoutPanel1.Controls.Add(Q6_5, 1, 6)
        TableLayoutPanel1.Controls.Add(Q6_4, 2, 6)
        TableLayoutPanel1.Controls.Add(Q6_2, 4, 6)
        TableLayoutPanel1.Controls.Add(Q6_3, 3, 6)
        TableLayoutPanel1.Controls.Add(Q6_1, 5, 6)
        TableLayoutPanel1.Controls.Add(Q7_5, 1, 7)
        TableLayoutPanel1.Controls.Add(Q7_4, 2, 7)
        TableLayoutPanel1.Controls.Add(Q7_3, 3, 7)
        TableLayoutPanel1.Controls.Add(Q7_2, 4, 7)
        TableLayoutPanel1.Controls.Add(Q7_1, 5, 7)
        TableLayoutPanel1.Controls.Add(Q1_Mean, 7, 1)
        TableLayoutPanel1.Controls.Add(Q1_Total, 6, 1)
        TableLayoutPanel1.Controls.Add(Q2_Total, 6, 2)
        TableLayoutPanel1.Controls.Add(Q2_Mean, 7, 2)
        TableLayoutPanel1.Controls.Add(Q3_Total, 6, 3)
        TableLayoutPanel1.Controls.Add(Q3_Mean, 7, 3)
        TableLayoutPanel1.Controls.Add(Q4_Mean, 7, 4)
        TableLayoutPanel1.Controls.Add(Q4_Total, 6, 4)
        TableLayoutPanel1.Controls.Add(Q5_Total, 6, 5)
        TableLayoutPanel1.Controls.Add(Q5_Mean, 7, 5)
        TableLayoutPanel1.Controls.Add(Q6_Total, 6, 6)
        TableLayoutPanel1.Controls.Add(Q6_Mean, 7, 6)
        TableLayoutPanel1.Controls.Add(Q7_Total, 6, 7)
        TableLayoutPanel1.Controls.Add(Q7_Mean, 7, 7)
        TableLayoutPanel1.Controls.Add(Q2_Eval, 8, 2)
        TableLayoutPanel1.Controls.Add(Q3_Eval, 8, 3)
        TableLayoutPanel1.Controls.Add(Q4_Eval, 8, 4)
        TableLayoutPanel1.Controls.Add(Q5_Eval, 8, 5)
        TableLayoutPanel1.Controls.Add(Q6_Eval, 8, 6)
        TableLayoutPanel1.Controls.Add(Q7_Eval, 8, 7)
        TableLayoutPanel1.Controls.Add(Q1_Eval, 8, 1)
        TableLayoutPanel1.Controls.Add(Label32, 0, 8)
        TableLayoutPanel1.Location = New Point(18, 48)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 9
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel1.Size = New Size(553, 268)
        TableLayoutPanel1.TabIndex = 52
        ' 
        ' Q8_Total
        ' 
        Q8_Total.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q8_Total.AutoSize = True
        Q8_Total.BorderStyle = BorderStyle.FixedSingle
        Q8_Total.Location = New Point(394, 237)
        Q8_Total.Margin = New Padding(0)
        Q8_Total.Name = "Q8_Total"
        Q8_Total.Size = New Size(41, 31)
        Q8_Total.TabIndex = 82
        Q8_Total.Text = "5"
        Q8_Total.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q8_3
        ' 
        Q8_3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q8_3.AutoSize = True
        Q8_3.BorderStyle = BorderStyle.FixedSingle
        Q8_3.Location = New Point(319, 237)
        Q8_3.Margin = New Padding(0)
        Q8_3.Name = "Q8_3"
        Q8_3.Size = New Size(25, 31)
        Q8_3.TabIndex = 81
        Q8_3.Text = "5"
        Q8_3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q8_2
        ' 
        Q8_2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q8_2.AutoSize = True
        Q8_2.BorderStyle = BorderStyle.FixedSingle
        Q8_2.Location = New Point(344, 237)
        Q8_2.Margin = New Padding(0)
        Q8_2.Name = "Q8_2"
        Q8_2.Size = New Size(25, 31)
        Q8_2.TabIndex = 79
        Q8_2.Text = "5"
        Q8_2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q8_5
        ' 
        Q8_5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q8_5.AutoSize = True
        Q8_5.BorderStyle = BorderStyle.FixedSingle
        Q8_5.Location = New Point(269, 237)
        Q8_5.Margin = New Padding(0)
        Q8_5.Name = "Q8_5"
        Q8_5.Size = New Size(25, 31)
        Q8_5.TabIndex = 78
        Q8_5.Text = "5"
        Q8_5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q8_4
        ' 
        Q8_4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q8_4.AutoSize = True
        Q8_4.BorderStyle = BorderStyle.FixedSingle
        Q8_4.Location = New Point(294, 237)
        Q8_4.Margin = New Padding(0)
        Q8_4.Name = "Q8_4"
        Q8_4.Size = New Size(25, 31)
        Q8_4.TabIndex = 77
        Q8_4.Text = "5"
        Q8_4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q8_Mean
        ' 
        Q8_Mean.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q8_Mean.AutoSize = True
        Q8_Mean.BorderStyle = BorderStyle.FixedSingle
        Q8_Mean.Location = New Point(435, 237)
        Q8_Mean.Margin = New Padding(0)
        Q8_Mean.Name = "Q8_Mean"
        Q8_Mean.Size = New Size(41, 31)
        Q8_Mean.TabIndex = 76
        Q8_Mean.Text = "5"
        Q8_Mean.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q8_Eval
        ' 
        Q8_Eval.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q8_Eval.AutoSize = True
        Q8_Eval.BorderStyle = BorderStyle.FixedSingle
        Q8_Eval.Location = New Point(476, 237)
        Q8_Eval.Margin = New Padding(0)
        Q8_Eval.Name = "Q8_Eval"
        Q8_Eval.Size = New Size(77, 31)
        Q8_Eval.TabIndex = 75
        Q8_Eval.Text = "5"
        Q8_Eval.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q8_1
        ' 
        Q8_1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q8_1.AutoSize = True
        Q8_1.BorderStyle = BorderStyle.FixedSingle
        Q8_1.Location = New Point(369, 237)
        Q8_1.Margin = New Padding(0)
        Q8_1.Name = "Q8_1"
        Q8_1.Size = New Size(25, 31)
        Q8_1.TabIndex = 74
        Q8_1.Text = "5"
        Q8_1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Location = New Point(0, 0)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Size = New Size(269, 20)
        Label1.TabIndex = 0
        Label1.Text = "Activities"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Location = New Point(269, 0)
        Label5.Margin = New Padding(0)
        Label5.Name = "Label5"
        Label5.Size = New Size(25, 20)
        Label5.TabIndex = 1
        Label5.Text = "5"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.Location = New Point(294, 0)
        Label6.Margin = New Padding(0)
        Label6.Name = "Label6"
        Label6.Size = New Size(25, 20)
        Label6.TabIndex = 2
        Label6.Text = "4"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.BorderStyle = BorderStyle.FixedSingle
        Label7.Location = New Point(319, 0)
        Label7.Margin = New Padding(0)
        Label7.Name = "Label7"
        Label7.Size = New Size(25, 20)
        Label7.TabIndex = 3
        Label7.Text = "3"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Location = New Point(344, 0)
        Label8.Margin = New Padding(0)
        Label8.Name = "Label8"
        Label8.Size = New Size(25, 20)
        Label8.TabIndex = 4
        Label8.Text = "2"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.BorderStyle = BorderStyle.FixedSingle
        Label9.Location = New Point(369, 0)
        Label9.Margin = New Padding(0)
        Label9.Name = "Label9"
        Label9.Size = New Size(25, 20)
        Label9.TabIndex = 5
        Label9.Text = "1"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.BorderStyle = BorderStyle.FixedSingle
        Label10.Location = New Point(394, 0)
        Label10.Margin = New Padding(0)
        Label10.Name = "Label10"
        Label10.Size = New Size(41, 20)
        Label10.TabIndex = 6
        Label10.Text = "Total"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.BorderStyle = BorderStyle.FixedSingle
        Label11.Location = New Point(435, 0)
        Label11.Margin = New Padding(0)
        Label11.Name = "Label11"
        Label11.Size = New Size(41, 20)
        Label11.TabIndex = 7
        Label11.Text = "Mean"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.BorderStyle = BorderStyle.FixedSingle
        Label12.Location = New Point(476, 0)
        Label12.Margin = New Padding(0)
        Label12.Name = "Label12"
        Label12.Size = New Size(77, 20)
        Label12.TabIndex = 8
        Label12.Text = "Evaluation"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.BorderStyle = BorderStyle.FixedSingle
        Label13.Location = New Point(0, 20)
        Label13.Margin = New Padding(0)
        Label13.Name = "Label13"
        Label13.Size = New Size(269, 31)
        Label13.TabIndex = 9
        Label13.Text = "1. The schedule of activities were all well planned."
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label14.AutoSize = True
        Label14.BorderStyle = BorderStyle.FixedSingle
        Label14.Location = New Point(0, 51)
        Label14.Margin = New Padding(0)
        Label14.Name = "Label14"
        Label14.Size = New Size(269, 31)
        Label14.TabIndex = 10
        Label14.Text = "2. The program started on time."
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.BorderStyle = BorderStyle.FixedSingle
        Label15.Location = New Point(0, 82)
        Label15.Margin = New Padding(0)
        Label15.Name = "Label15"
        Label15.Size = New Size(269, 31)
        Label15.TabIndex = 11
        Label15.Text = "3. The activities were properly designed."
        Label15.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.BorderStyle = BorderStyle.FixedSingle
        Label16.Location = New Point(0, 113)
        Label16.Margin = New Padding(0)
        Label16.Name = "Label16"
        Label16.Size = New Size(269, 31)
        Label16.TabIndex = 12
        Label16.Text = "4. The activities were all well disseminated."
        Label16.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label17.AutoSize = True
        Label17.BorderStyle = BorderStyle.FixedSingle
        Label17.Location = New Point(0, 144)
        Label17.Margin = New Padding(0)
        Label17.Name = "Label17"
        Label17.Size = New Size(269, 31)
        Label17.TabIndex = 13
        Label17.Text = "5. The activities were all well participated."
        Label17.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label18.AutoSize = True
        Label18.BorderStyle = BorderStyle.FixedSingle
        Label18.Location = New Point(0, 175)
        Label18.Margin = New Padding(0)
        Label18.Name = "Label18"
        Label18.Size = New Size(269, 31)
        Label18.TabIndex = 14
        Label18.Text = "6. The activities met the needs of the students"
        Label18.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label19.AutoSize = True
        Label19.BorderStyle = BorderStyle.FixedSingle
        Label19.Location = New Point(0, 206)
        Label19.Margin = New Padding(0)
        Label19.Name = "Label19"
        Label19.Size = New Size(269, 31)
        Label19.TabIndex = 15
        Label19.Text = "7. The length of the activities were suffictient"
        Label19.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Q1_4
        ' 
        Q1_4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q1_4.AutoSize = True
        Q1_4.BorderStyle = BorderStyle.FixedSingle
        Q1_4.Location = New Point(294, 20)
        Q1_4.Margin = New Padding(0)
        Q1_4.Name = "Q1_4"
        Q1_4.Size = New Size(25, 31)
        Q1_4.TabIndex = 17
        Q1_4.Text = "5"
        Q1_4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q1_3
        ' 
        Q1_3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q1_3.AutoSize = True
        Q1_3.BorderStyle = BorderStyle.FixedSingle
        Q1_3.Location = New Point(319, 20)
        Q1_3.Margin = New Padding(0)
        Q1_3.Name = "Q1_3"
        Q1_3.Size = New Size(25, 31)
        Q1_3.TabIndex = 18
        Q1_3.Text = "5"
        Q1_3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q1_5
        ' 
        Q1_5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q1_5.AutoSize = True
        Q1_5.BorderStyle = BorderStyle.FixedSingle
        Q1_5.Location = New Point(269, 20)
        Q1_5.Margin = New Padding(0)
        Q1_5.Name = "Q1_5"
        Q1_5.Size = New Size(25, 31)
        Q1_5.TabIndex = 19
        Q1_5.Text = "5"
        Q1_5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q1_2
        ' 
        Q1_2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q1_2.AutoSize = True
        Q1_2.BorderStyle = BorderStyle.FixedSingle
        Q1_2.Location = New Point(344, 20)
        Q1_2.Margin = New Padding(0)
        Q1_2.Name = "Q1_2"
        Q1_2.Size = New Size(25, 31)
        Q1_2.TabIndex = 20
        Q1_2.Text = "5"
        Q1_2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q1_1
        ' 
        Q1_1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q1_1.AutoSize = True
        Q1_1.BorderStyle = BorderStyle.FixedSingle
        Q1_1.Location = New Point(369, 20)
        Q1_1.Margin = New Padding(0)
        Q1_1.Name = "Q1_1"
        Q1_1.Size = New Size(25, 31)
        Q1_1.TabIndex = 21
        Q1_1.Text = "5"
        Q1_1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q2_5
        ' 
        Q2_5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q2_5.AutoSize = True
        Q2_5.BorderStyle = BorderStyle.FixedSingle
        Q2_5.Location = New Point(269, 51)
        Q2_5.Margin = New Padding(0)
        Q2_5.Name = "Q2_5"
        Q2_5.Size = New Size(25, 31)
        Q2_5.TabIndex = 22
        Q2_5.Text = "5"
        Q2_5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q2_4
        ' 
        Q2_4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q2_4.AutoSize = True
        Q2_4.BorderStyle = BorderStyle.FixedSingle
        Q2_4.Location = New Point(294, 51)
        Q2_4.Margin = New Padding(0)
        Q2_4.Name = "Q2_4"
        Q2_4.Size = New Size(25, 31)
        Q2_4.TabIndex = 25
        Q2_4.Text = "5"
        Q2_4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q2_2
        ' 
        Q2_2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q2_2.AutoSize = True
        Q2_2.BorderStyle = BorderStyle.FixedSingle
        Q2_2.Location = New Point(344, 51)
        Q2_2.Margin = New Padding(0)
        Q2_2.Name = "Q2_2"
        Q2_2.Size = New Size(25, 31)
        Q2_2.TabIndex = 27
        Q2_2.Text = "5"
        Q2_2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q2_3
        ' 
        Q2_3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q2_3.AutoSize = True
        Q2_3.BorderStyle = BorderStyle.FixedSingle
        Q2_3.Location = New Point(319, 51)
        Q2_3.Margin = New Padding(0)
        Q2_3.Name = "Q2_3"
        Q2_3.Size = New Size(25, 31)
        Q2_3.TabIndex = 28
        Q2_3.Text = "5"
        Q2_3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q3_5
        ' 
        Q3_5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q3_5.AutoSize = True
        Q3_5.BorderStyle = BorderStyle.FixedSingle
        Q3_5.Location = New Point(269, 82)
        Q3_5.Margin = New Padding(0)
        Q3_5.Name = "Q3_5"
        Q3_5.Size = New Size(25, 31)
        Q3_5.TabIndex = 30
        Q3_5.Text = "5"
        Q3_5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q3_4
        ' 
        Q3_4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q3_4.AutoSize = True
        Q3_4.BorderStyle = BorderStyle.FixedSingle
        Q3_4.Location = New Point(294, 82)
        Q3_4.Margin = New Padding(0)
        Q3_4.Name = "Q3_4"
        Q3_4.Size = New Size(25, 31)
        Q3_4.TabIndex = 23
        Q3_4.Text = "5"
        Q3_4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q3_3
        ' 
        Q3_3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q3_3.AutoSize = True
        Q3_3.BorderStyle = BorderStyle.FixedSingle
        Q3_3.Location = New Point(319, 82)
        Q3_3.Margin = New Padding(0)
        Q3_3.Name = "Q3_3"
        Q3_3.Size = New Size(25, 31)
        Q3_3.TabIndex = 31
        Q3_3.Text = "5"
        Q3_3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q3_2
        ' 
        Q3_2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q3_2.AutoSize = True
        Q3_2.BorderStyle = BorderStyle.FixedSingle
        Q3_2.Location = New Point(344, 82)
        Q3_2.Margin = New Padding(0)
        Q3_2.Name = "Q3_2"
        Q3_2.Size = New Size(25, 31)
        Q3_2.TabIndex = 32
        Q3_2.Text = "5"
        Q3_2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q2_1
        ' 
        Q2_1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q2_1.AutoSize = True
        Q2_1.BorderStyle = BorderStyle.FixedSingle
        Q2_1.Location = New Point(369, 51)
        Q2_1.Margin = New Padding(0)
        Q2_1.Name = "Q2_1"
        Q2_1.Size = New Size(25, 31)
        Q2_1.TabIndex = 33
        Q2_1.Text = "5"
        Q2_1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q3_1
        ' 
        Q3_1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q3_1.AutoSize = True
        Q3_1.BorderStyle = BorderStyle.FixedSingle
        Q3_1.Location = New Point(369, 82)
        Q3_1.Margin = New Padding(0)
        Q3_1.Name = "Q3_1"
        Q3_1.Size = New Size(25, 31)
        Q3_1.TabIndex = 24
        Q3_1.Text = "5"
        Q3_1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q4_5
        ' 
        Q4_5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q4_5.AutoSize = True
        Q4_5.BorderStyle = BorderStyle.FixedSingle
        Q4_5.Location = New Point(269, 113)
        Q4_5.Margin = New Padding(0)
        Q4_5.Name = "Q4_5"
        Q4_5.Size = New Size(25, 31)
        Q4_5.TabIndex = 35
        Q4_5.Text = "5"
        Q4_5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q4_4
        ' 
        Q4_4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q4_4.AutoSize = True
        Q4_4.BorderStyle = BorderStyle.FixedSingle
        Q4_4.Location = New Point(294, 113)
        Q4_4.Margin = New Padding(0)
        Q4_4.Name = "Q4_4"
        Q4_4.Size = New Size(25, 31)
        Q4_4.TabIndex = 34
        Q4_4.Text = "5"
        Q4_4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q4_3
        ' 
        Q4_3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q4_3.AutoSize = True
        Q4_3.BorderStyle = BorderStyle.FixedSingle
        Q4_3.Location = New Point(319, 113)
        Q4_3.Margin = New Padding(0)
        Q4_3.Name = "Q4_3"
        Q4_3.Size = New Size(25, 31)
        Q4_3.TabIndex = 36
        Q4_3.Text = "5"
        Q4_3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q4_2
        ' 
        Q4_2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q4_2.AutoSize = True
        Q4_2.BorderStyle = BorderStyle.FixedSingle
        Q4_2.Location = New Point(344, 113)
        Q4_2.Margin = New Padding(0)
        Q4_2.Name = "Q4_2"
        Q4_2.Size = New Size(25, 31)
        Q4_2.TabIndex = 38
        Q4_2.Text = "5"
        Q4_2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q4_1
        ' 
        Q4_1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q4_1.AutoSize = True
        Q4_1.BorderStyle = BorderStyle.FixedSingle
        Q4_1.Location = New Point(369, 113)
        Q4_1.Margin = New Padding(0)
        Q4_1.Name = "Q4_1"
        Q4_1.Size = New Size(25, 31)
        Q4_1.TabIndex = 37
        Q4_1.Text = "5"
        Q4_1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q5_5
        ' 
        Q5_5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q5_5.AutoSize = True
        Q5_5.BorderStyle = BorderStyle.FixedSingle
        Q5_5.Location = New Point(269, 144)
        Q5_5.Margin = New Padding(0)
        Q5_5.Name = "Q5_5"
        Q5_5.Size = New Size(25, 31)
        Q5_5.TabIndex = 40
        Q5_5.Text = "5"
        Q5_5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q5_4
        ' 
        Q5_4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q5_4.AutoSize = True
        Q5_4.BorderStyle = BorderStyle.FixedSingle
        Q5_4.Location = New Point(294, 144)
        Q5_4.Margin = New Padding(0)
        Q5_4.Name = "Q5_4"
        Q5_4.Size = New Size(25, 31)
        Q5_4.TabIndex = 39
        Q5_4.Text = "5"
        Q5_4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q5_3
        ' 
        Q5_3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q5_3.AutoSize = True
        Q5_3.BorderStyle = BorderStyle.FixedSingle
        Q5_3.Location = New Point(319, 144)
        Q5_3.Margin = New Padding(0)
        Q5_3.Name = "Q5_3"
        Q5_3.Size = New Size(25, 31)
        Q5_3.TabIndex = 41
        Q5_3.Text = "5"
        Q5_3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q5_2
        ' 
        Q5_2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q5_2.AutoSize = True
        Q5_2.BorderStyle = BorderStyle.FixedSingle
        Q5_2.Location = New Point(344, 144)
        Q5_2.Margin = New Padding(0)
        Q5_2.Name = "Q5_2"
        Q5_2.Size = New Size(25, 31)
        Q5_2.TabIndex = 42
        Q5_2.Text = "5"
        Q5_2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q5_1
        ' 
        Q5_1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q5_1.AutoSize = True
        Q5_1.BorderStyle = BorderStyle.FixedSingle
        Q5_1.Location = New Point(369, 144)
        Q5_1.Margin = New Padding(0)
        Q5_1.Name = "Q5_1"
        Q5_1.Size = New Size(25, 31)
        Q5_1.TabIndex = 43
        Q5_1.Text = "5"
        Q5_1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q6_5
        ' 
        Q6_5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q6_5.AutoSize = True
        Q6_5.BorderStyle = BorderStyle.FixedSingle
        Q6_5.Location = New Point(269, 175)
        Q6_5.Margin = New Padding(0)
        Q6_5.Name = "Q6_5"
        Q6_5.Size = New Size(25, 31)
        Q6_5.TabIndex = 44
        Q6_5.Text = "5"
        Q6_5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q6_4
        ' 
        Q6_4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q6_4.AutoSize = True
        Q6_4.BorderStyle = BorderStyle.FixedSingle
        Q6_4.Location = New Point(294, 175)
        Q6_4.Margin = New Padding(0)
        Q6_4.Name = "Q6_4"
        Q6_4.Size = New Size(25, 31)
        Q6_4.TabIndex = 45
        Q6_4.Text = "5"
        Q6_4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q6_2
        ' 
        Q6_2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q6_2.AutoSize = True
        Q6_2.BorderStyle = BorderStyle.FixedSingle
        Q6_2.Location = New Point(344, 175)
        Q6_2.Margin = New Padding(0)
        Q6_2.Name = "Q6_2"
        Q6_2.Size = New Size(25, 31)
        Q6_2.TabIndex = 46
        Q6_2.Text = "5"
        Q6_2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q6_3
        ' 
        Q6_3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q6_3.AutoSize = True
        Q6_3.BorderStyle = BorderStyle.FixedSingle
        Q6_3.Location = New Point(319, 175)
        Q6_3.Margin = New Padding(0)
        Q6_3.Name = "Q6_3"
        Q6_3.Size = New Size(25, 31)
        Q6_3.TabIndex = 47
        Q6_3.Text = "5"
        Q6_3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q6_1
        ' 
        Q6_1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q6_1.AutoSize = True
        Q6_1.BorderStyle = BorderStyle.FixedSingle
        Q6_1.Location = New Point(369, 175)
        Q6_1.Margin = New Padding(0)
        Q6_1.Name = "Q6_1"
        Q6_1.Size = New Size(25, 31)
        Q6_1.TabIndex = 48
        Q6_1.Text = "5"
        Q6_1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q7_5
        ' 
        Q7_5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q7_5.AutoSize = True
        Q7_5.BorderStyle = BorderStyle.FixedSingle
        Q7_5.Location = New Point(269, 206)
        Q7_5.Margin = New Padding(0)
        Q7_5.Name = "Q7_5"
        Q7_5.Size = New Size(25, 31)
        Q7_5.TabIndex = 49
        Q7_5.Text = "5"
        Q7_5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q7_4
        ' 
        Q7_4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q7_4.AutoSize = True
        Q7_4.BorderStyle = BorderStyle.FixedSingle
        Q7_4.Location = New Point(294, 206)
        Q7_4.Margin = New Padding(0)
        Q7_4.Name = "Q7_4"
        Q7_4.Size = New Size(25, 31)
        Q7_4.TabIndex = 50
        Q7_4.Text = "5"
        Q7_4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q7_3
        ' 
        Q7_3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q7_3.AutoSize = True
        Q7_3.BorderStyle = BorderStyle.FixedSingle
        Q7_3.Location = New Point(319, 206)
        Q7_3.Margin = New Padding(0)
        Q7_3.Name = "Q7_3"
        Q7_3.Size = New Size(25, 31)
        Q7_3.TabIndex = 51
        Q7_3.Text = "5"
        Q7_3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q7_2
        ' 
        Q7_2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q7_2.AutoSize = True
        Q7_2.BorderStyle = BorderStyle.FixedSingle
        Q7_2.Location = New Point(344, 206)
        Q7_2.Margin = New Padding(0)
        Q7_2.Name = "Q7_2"
        Q7_2.Size = New Size(25, 31)
        Q7_2.TabIndex = 52
        Q7_2.Text = "5"
        Q7_2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q7_1
        ' 
        Q7_1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q7_1.AutoSize = True
        Q7_1.BorderStyle = BorderStyle.FixedSingle
        Q7_1.Location = New Point(369, 206)
        Q7_1.Margin = New Padding(0)
        Q7_1.Name = "Q7_1"
        Q7_1.Size = New Size(25, 31)
        Q7_1.TabIndex = 53
        Q7_1.Text = "5"
        Q7_1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q1_Mean
        ' 
        Q1_Mean.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q1_Mean.AutoSize = True
        Q1_Mean.BorderStyle = BorderStyle.FixedSingle
        Q1_Mean.Location = New Point(435, 20)
        Q1_Mean.Margin = New Padding(0)
        Q1_Mean.Name = "Q1_Mean"
        Q1_Mean.Size = New Size(41, 31)
        Q1_Mean.TabIndex = 54
        Q1_Mean.Text = "5"
        Q1_Mean.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q1_Total
        ' 
        Q1_Total.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q1_Total.AutoSize = True
        Q1_Total.BorderStyle = BorderStyle.FixedSingle
        Q1_Total.Location = New Point(394, 20)
        Q1_Total.Margin = New Padding(0)
        Q1_Total.Name = "Q1_Total"
        Q1_Total.Size = New Size(41, 31)
        Q1_Total.TabIndex = 55
        Q1_Total.Text = "5"
        Q1_Total.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q2_Total
        ' 
        Q2_Total.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q2_Total.AutoSize = True
        Q2_Total.BorderStyle = BorderStyle.FixedSingle
        Q2_Total.Location = New Point(394, 51)
        Q2_Total.Margin = New Padding(0)
        Q2_Total.Name = "Q2_Total"
        Q2_Total.Size = New Size(41, 31)
        Q2_Total.TabIndex = 56
        Q2_Total.Text = "5"
        Q2_Total.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q2_Mean
        ' 
        Q2_Mean.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q2_Mean.AutoSize = True
        Q2_Mean.BorderStyle = BorderStyle.FixedSingle
        Q2_Mean.Location = New Point(435, 51)
        Q2_Mean.Margin = New Padding(0)
        Q2_Mean.Name = "Q2_Mean"
        Q2_Mean.Size = New Size(41, 31)
        Q2_Mean.TabIndex = 57
        Q2_Mean.Text = "5"
        Q2_Mean.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q3_Total
        ' 
        Q3_Total.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q3_Total.AutoSize = True
        Q3_Total.BorderStyle = BorderStyle.FixedSingle
        Q3_Total.Location = New Point(394, 82)
        Q3_Total.Margin = New Padding(0)
        Q3_Total.Name = "Q3_Total"
        Q3_Total.Size = New Size(41, 31)
        Q3_Total.TabIndex = 58
        Q3_Total.Text = "5"
        Q3_Total.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q3_Mean
        ' 
        Q3_Mean.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q3_Mean.AutoSize = True
        Q3_Mean.BorderStyle = BorderStyle.FixedSingle
        Q3_Mean.Location = New Point(435, 82)
        Q3_Mean.Margin = New Padding(0)
        Q3_Mean.Name = "Q3_Mean"
        Q3_Mean.Size = New Size(41, 31)
        Q3_Mean.TabIndex = 59
        Q3_Mean.Text = "5"
        Q3_Mean.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q4_Mean
        ' 
        Q4_Mean.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q4_Mean.AutoSize = True
        Q4_Mean.BorderStyle = BorderStyle.FixedSingle
        Q4_Mean.Location = New Point(435, 113)
        Q4_Mean.Margin = New Padding(0)
        Q4_Mean.Name = "Q4_Mean"
        Q4_Mean.Size = New Size(41, 31)
        Q4_Mean.TabIndex = 60
        Q4_Mean.Text = "5"
        Q4_Mean.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q4_Total
        ' 
        Q4_Total.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q4_Total.AutoSize = True
        Q4_Total.BorderStyle = BorderStyle.FixedSingle
        Q4_Total.Location = New Point(394, 113)
        Q4_Total.Margin = New Padding(0)
        Q4_Total.Name = "Q4_Total"
        Q4_Total.Size = New Size(41, 31)
        Q4_Total.TabIndex = 61
        Q4_Total.Text = "5"
        Q4_Total.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q5_Total
        ' 
        Q5_Total.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q5_Total.AutoSize = True
        Q5_Total.BorderStyle = BorderStyle.FixedSingle
        Q5_Total.Location = New Point(394, 144)
        Q5_Total.Margin = New Padding(0)
        Q5_Total.Name = "Q5_Total"
        Q5_Total.Size = New Size(41, 31)
        Q5_Total.TabIndex = 62
        Q5_Total.Text = "5"
        Q5_Total.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q5_Mean
        ' 
        Q5_Mean.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q5_Mean.AutoSize = True
        Q5_Mean.BorderStyle = BorderStyle.FixedSingle
        Q5_Mean.Location = New Point(435, 144)
        Q5_Mean.Margin = New Padding(0)
        Q5_Mean.Name = "Q5_Mean"
        Q5_Mean.Size = New Size(41, 31)
        Q5_Mean.TabIndex = 63
        Q5_Mean.Text = "5"
        Q5_Mean.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q6_Total
        ' 
        Q6_Total.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q6_Total.AutoSize = True
        Q6_Total.BorderStyle = BorderStyle.FixedSingle
        Q6_Total.Location = New Point(394, 175)
        Q6_Total.Margin = New Padding(0)
        Q6_Total.Name = "Q6_Total"
        Q6_Total.Size = New Size(41, 31)
        Q6_Total.TabIndex = 64
        Q6_Total.Text = "5"
        Q6_Total.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q6_Mean
        ' 
        Q6_Mean.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q6_Mean.AutoSize = True
        Q6_Mean.BorderStyle = BorderStyle.FixedSingle
        Q6_Mean.Location = New Point(435, 175)
        Q6_Mean.Margin = New Padding(0)
        Q6_Mean.Name = "Q6_Mean"
        Q6_Mean.Size = New Size(41, 31)
        Q6_Mean.TabIndex = 65
        Q6_Mean.Text = "5"
        Q6_Mean.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q7_Total
        ' 
        Q7_Total.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q7_Total.AutoSize = True
        Q7_Total.BorderStyle = BorderStyle.FixedSingle
        Q7_Total.Location = New Point(394, 206)
        Q7_Total.Margin = New Padding(0)
        Q7_Total.Name = "Q7_Total"
        Q7_Total.Size = New Size(41, 31)
        Q7_Total.TabIndex = 66
        Q7_Total.Text = "5"
        Q7_Total.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q7_Mean
        ' 
        Q7_Mean.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q7_Mean.AutoSize = True
        Q7_Mean.BorderStyle = BorderStyle.FixedSingle
        Q7_Mean.Location = New Point(435, 206)
        Q7_Mean.Margin = New Padding(0)
        Q7_Mean.Name = "Q7_Mean"
        Q7_Mean.Size = New Size(41, 31)
        Q7_Mean.TabIndex = 67
        Q7_Mean.Text = "5"
        Q7_Mean.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q2_Eval
        ' 
        Q2_Eval.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q2_Eval.AutoSize = True
        Q2_Eval.BorderStyle = BorderStyle.FixedSingle
        Q2_Eval.Location = New Point(476, 51)
        Q2_Eval.Margin = New Padding(0)
        Q2_Eval.Name = "Q2_Eval"
        Q2_Eval.Size = New Size(77, 31)
        Q2_Eval.TabIndex = 68
        Q2_Eval.Text = "5"
        Q2_Eval.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q3_Eval
        ' 
        Q3_Eval.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q3_Eval.AutoSize = True
        Q3_Eval.BorderStyle = BorderStyle.FixedSingle
        Q3_Eval.Location = New Point(476, 82)
        Q3_Eval.Margin = New Padding(0)
        Q3_Eval.Name = "Q3_Eval"
        Q3_Eval.Size = New Size(77, 31)
        Q3_Eval.TabIndex = 70
        Q3_Eval.Text = "5"
        Q3_Eval.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q4_Eval
        ' 
        Q4_Eval.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q4_Eval.AutoSize = True
        Q4_Eval.BorderStyle = BorderStyle.FixedSingle
        Q4_Eval.Location = New Point(476, 113)
        Q4_Eval.Margin = New Padding(0)
        Q4_Eval.Name = "Q4_Eval"
        Q4_Eval.Size = New Size(77, 31)
        Q4_Eval.TabIndex = 69
        Q4_Eval.Text = "5"
        Q4_Eval.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q5_Eval
        ' 
        Q5_Eval.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q5_Eval.AutoSize = True
        Q5_Eval.BorderStyle = BorderStyle.FixedSingle
        Q5_Eval.Location = New Point(476, 144)
        Q5_Eval.Margin = New Padding(0)
        Q5_Eval.Name = "Q5_Eval"
        Q5_Eval.Size = New Size(77, 31)
        Q5_Eval.TabIndex = 71
        Q5_Eval.Text = "5"
        Q5_Eval.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q6_Eval
        ' 
        Q6_Eval.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q6_Eval.AutoSize = True
        Q6_Eval.BorderStyle = BorderStyle.FixedSingle
        Q6_Eval.Location = New Point(476, 175)
        Q6_Eval.Margin = New Padding(0)
        Q6_Eval.Name = "Q6_Eval"
        Q6_Eval.Size = New Size(77, 31)
        Q6_Eval.TabIndex = 72
        Q6_Eval.Text = "5"
        Q6_Eval.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q7_Eval
        ' 
        Q7_Eval.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q7_Eval.AutoSize = True
        Q7_Eval.BorderStyle = BorderStyle.FixedSingle
        Q7_Eval.Location = New Point(476, 206)
        Q7_Eval.Margin = New Padding(0)
        Q7_Eval.Name = "Q7_Eval"
        Q7_Eval.Size = New Size(77, 31)
        Q7_Eval.TabIndex = 73
        Q7_Eval.Text = "5"
        Q7_Eval.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Q1_Eval
        ' 
        Q1_Eval.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Q1_Eval.AutoSize = True
        Q1_Eval.BorderStyle = BorderStyle.FixedSingle
        Q1_Eval.Location = New Point(476, 20)
        Q1_Eval.Margin = New Padding(0)
        Q1_Eval.Name = "Q1_Eval"
        Q1_Eval.Size = New Size(77, 31)
        Q1_Eval.TabIndex = 80
        Q1_Eval.Text = "5"
        Q1_Eval.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label32
        ' 
        Label32.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label32.AutoSize = True
        Label32.BorderStyle = BorderStyle.FixedSingle
        Label32.ImageAlign = ContentAlignment.MiddleLeft
        Label32.Location = New Point(0, 237)
        Label32.Margin = New Padding(0)
        Label32.Name = "Label32"
        Label32.Size = New Size(269, 31)
        Label32.TabIndex = 29
        Label32.Text = "8. The segments are logically arranged."
        Label32.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(489, 322)
        Button1.Name = "Button1"
        Button1.Size = New Size(82, 31)
        Button1.TabIndex = 51
        Button1.Text = "NEXT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' backBtn
        ' 
        backBtn.BackColor = Color.White
        backBtn.FlatStyle = FlatStyle.Flat
        backBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        backBtn.ForeColor = SystemColors.ActiveCaptionText
        backBtn.Location = New Point(18, 322)
        backBtn.Name = "backBtn"
        backBtn.Size = New Size(82, 31)
        backBtn.TabIndex = 50
        backBtn.Text = "BACK"
        backBtn.UseVisualStyleBackColor = False
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CommandTimeout = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.Transaction = Nothing
        MySqlCommand1.UpdatedRowSource = UpdateRowSource.None
        ' 
        ' AdminRatings1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel4)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Name = "AdminRatings1"
        Text = "AdminRatings1"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents logoutBtn As Button
    Friend WithEvents usernameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents officersBtn As Button
    Friend WithEvents ratingsBtn As Button
    Friend WithEvents profileBtn As Button
    Friend WithEvents eventsBtn As Button
    Friend WithEvents dashboardBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents eventselectCBox As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents backBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MySqlCommand1 As MySqlConnector.MySqlCommand
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Q1_5 As Label
    Friend WithEvents Q1_4 As Label
    Friend WithEvents Q1_3 As Label
    Friend WithEvents Q3_3 As Label
    Friend WithEvents Q3_5 As Label
    Friend WithEvents Q2_3 As Label
    Friend WithEvents Q2_2 As Label
    Friend WithEvents Q2_4 As Label
    Friend WithEvents Q3_1 As Label
    Friend WithEvents Q3_4 As Label
    Friend WithEvents Q2_5 As Label
    Friend WithEvents Q1_2 As Label
    Friend WithEvents Q1_1 As Label
    Friend WithEvents Q8_Total As Label
    Friend WithEvents Q8_3 As Label
    Friend WithEvents Q8_2 As Label
    Friend WithEvents Q8_5 As Label
    Friend WithEvents Q8_4 As Label
    Friend WithEvents Q8_Mean As Label
    Friend WithEvents Q8_Eval As Label
    Friend WithEvents Q8_1 As Label
    Friend WithEvents Q3_2 As Label
    Friend WithEvents Q2_1 As Label
    Friend WithEvents Q4_5 As Label
    Friend WithEvents Q4_4 As Label
    Friend WithEvents Q4_3 As Label
    Friend WithEvents Q4_2 As Label
    Friend WithEvents Q4_1 As Label
    Friend WithEvents Q5_5 As Label
    Friend WithEvents Q5_4 As Label
    Friend WithEvents Q5_3 As Label
    Friend WithEvents Q5_2 As Label
    Friend WithEvents Q5_1 As Label
    Friend WithEvents Q6_5 As Label
    Friend WithEvents Q6_4 As Label
    Friend WithEvents Q6_2 As Label
    Friend WithEvents Q6_3 As Label
    Friend WithEvents Q6_1 As Label
    Friend WithEvents Q7_5 As Label
    Friend WithEvents Q7_4 As Label
    Friend WithEvents Q7_3 As Label
    Friend WithEvents Q7_2 As Label
    Friend WithEvents Q7_1 As Label
    Friend WithEvents Q1_Mean As Label
    Friend WithEvents Q1_Total As Label
    Friend WithEvents Q2_Total As Label
    Friend WithEvents Q2_Mean As Label
    Friend WithEvents Q3_Total As Label
    Friend WithEvents Q3_Mean As Label
    Friend WithEvents Q4_Mean As Label
    Friend WithEvents Q4_Total As Label
    Friend WithEvents Q5_Total As Label
    Friend WithEvents Q5_Mean As Label
    Friend WithEvents Q6_Total As Label
    Friend WithEvents Q6_Mean As Label
    Friend WithEvents Q7_Total As Label
    Friend WithEvents Q7_Mean As Label
    Friend WithEvents Q2_Eval As Label
    Friend WithEvents Q3_Eval As Label
    Friend WithEvents Q4_Eval As Label
    Friend WithEvents Q5_Eval As Label
    Friend WithEvents Q6_Eval As Label
    Friend WithEvents Q7_Eval As Label
    Friend WithEvents Q1_Eval As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
