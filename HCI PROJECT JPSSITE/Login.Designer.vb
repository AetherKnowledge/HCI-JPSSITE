﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        passwordTextField = New TextBox()
        Button1 = New Button()
        userNameTextField = New TextBox()
        Button2 = New Button()
        Label2 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.CornflowerBlue
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(387, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(418, 455)
        Panel1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(108, 65)
        Label4.Name = "Label4"
        Label4.Size = New Size(248, 38)
        Label4.TabIndex = 11
        Label4.Text = "JPPSITE PORTAL"
        Label4.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(132, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(224, 38)
        Label3.TabIndex = 10
        Label3.Text = "WELCOME TO"
        Label3.TextAlign = ContentAlignment.TopRight
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.CornflowerBlue
        PictureBox2.Image = My.Resources.Resources._2
        PictureBox2.Location = New Point(62, 134)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(294, 283)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(135, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 38)
        Label1.TabIndex = 1
        Label1.Text = "LOGIN"
        ' 
        ' passwordTextField
        ' 
        passwordTextField.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        passwordTextField.BorderStyle = BorderStyle.None
        passwordTextField.Font = New Font("Century Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        passwordTextField.ForeColor = Color.White
        passwordTextField.Location = New Point(78, 210)
        passwordTextField.Name = "passwordTextField"
        passwordTextField.Size = New Size(222, 16)
        passwordTextField.TabIndex = 3
        passwordTextField.Text = "Password"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.CornflowerBlue
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(78, 274)
        Button1.Name = "Button1"
        Button1.Size = New Size(222, 23)
        Button1.TabIndex = 6
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' userNameTextField
        ' 
        userNameTextField.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        userNameTextField.BorderStyle = BorderStyle.None
        userNameTextField.Font = New Font("Century Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        userNameTextField.ForeColor = Color.White
        userNameTextField.Location = New Point(78, 160)
        userNameTextField.Name = "userNameTextField"
        userNameTextField.Size = New Size(222, 16)
        userNameTextField.TabIndex = 7
        userNameTextField.Text = "Username"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gray
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(266, 405)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 8
        Button2.Text = "Sign Up"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(46, 408)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 17)
        Label2.TabIndex = 9
        Label2.Text = "Don't have an account?"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(78, 182)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(222, 2)
        Panel2.TabIndex = 10
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Location = New Point(78, 232)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(222, 2)
        Panel3.TabIndex = 11
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(800, 450)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(userNameTextField)
        Controls.Add(Button1)
        Controls.Add(passwordTextField)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOGIN"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents passwordTextField As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents userNameTextField As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel

End Class
