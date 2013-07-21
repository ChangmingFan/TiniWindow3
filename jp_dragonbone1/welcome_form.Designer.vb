<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class welcome_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(welcome_form))
        Me.Pan_welcome = New System.Windows.Forms.Panel
        Me.CB_dontshow = New System.Windows.Forms.CheckBox
        Me.But_close = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.But_why = New System.Windows.Forms.Button
        Me.But_dont_ask_again = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TBwelcome = New System.Windows.Forms.TextBox
        Me.TimerCloseForm = New System.Windows.Forms.Timer(Me.components)
        Me.Pan_welcome.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan_welcome
        '
        Me.Pan_welcome.Controls.Add(Me.CB_dontshow)
        Me.Pan_welcome.Controls.Add(Me.But_close)
        Me.Pan_welcome.Controls.Add(Me.Panel3)
        Me.Pan_welcome.Controls.Add(Me.TBwelcome)
        Me.Pan_welcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pan_welcome.Location = New System.Drawing.Point(0, 0)
        Me.Pan_welcome.Name = "Pan_welcome"
        Me.Pan_welcome.Size = New System.Drawing.Size(465, 561)
        Me.Pan_welcome.TabIndex = 26
        '
        'CB_dontshow
        '
        Me.CB_dontshow.AutoSize = True
        Me.CB_dontshow.Location = New System.Drawing.Point(73, 510)
        Me.CB_dontshow.Name = "CB_dontshow"
        Me.CB_dontshow.Size = New System.Drawing.Size(150, 17)
        Me.CB_dontshow.TabIndex = 35
        Me.CB_dontshow.Text = "Don't show this form again"
        Me.CB_dontshow.UseVisualStyleBackColor = True
        '
        'But_close
        '
        Me.But_close.Location = New System.Drawing.Point(255, 506)
        Me.But_close.Name = "But_close"
        Me.But_close.Size = New System.Drawing.Size(75, 23)
        Me.But_close.TabIndex = 34
        Me.But_close.Text = "close"
        Me.But_close.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(3, 311)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(441, 172)
        Me.Panel3.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(129, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(241, 78)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "To satisfy people's ever increasing needs of lighting through new product, new se" & _
            "rvice and the new art of TiniLite"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Red
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(57, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 78)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Mission"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.But_why)
        Me.Panel1.Controls.Add(Me.But_dont_ask_again)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(57, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 82)
        Me.Panel1.TabIndex = 27
        '
        'But_why
        '
        Me.But_why.Location = New System.Drawing.Point(128, 88)
        Me.But_why.Name = "But_why"
        Me.But_why.Size = New System.Drawing.Size(75, 23)
        Me.But_why.TabIndex = 38
        Me.But_why.Text = "why we ask"
        Me.But_why.UseVisualStyleBackColor = True
        '
        'But_dont_ask_again
        '
        Me.But_dont_ask_again.Location = New System.Drawing.Point(13, 88)
        Me.But_dont_ask_again.Name = "But_dont_ask_again"
        Me.But_dont_ask_again.Size = New System.Drawing.Size(97, 23)
        Me.But_dont_ask_again.TabIndex = 37
        Me.But_dont_ask_again.Text = "Don't ask again"
        Me.But_dont_ask_again.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, -32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Welcome, please enter your name"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(3)
        Me.PictureBox1.Size = New System.Drawing.Size(299, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'TBwelcome
        '
        Me.TBwelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBwelcome.Location = New System.Drawing.Point(20, 61)
        Me.TBwelcome.Multiline = True
        Me.TBwelcome.Name = "TBwelcome"
        Me.TBwelcome.ReadOnly = True
        Me.TBwelcome.Size = New System.Drawing.Size(429, 231)
        Me.TBwelcome.TabIndex = 0
        Me.TBwelcome.Text = "Welcome to TiniLite World, Inc." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TiniLite product is based on the concept of in" & _
            "terconnectable the small segment of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "We offer you a new light system based on" & _
            " "
        Me.TBwelcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimerCloseForm
        '
        Me.TimerCloseForm.Interval = 30000
        '
        'welcome_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 561)
        Me.Controls.Add(Me.Pan_welcome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "welcome_form"
        Me.ShowIcon = False
        Me.Text = "Welcome"
        Me.Pan_welcome.ResumeLayout(False)
        Me.Pan_welcome.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pan_welcome As System.Windows.Forms.Panel
    Friend WithEvents TBwelcome As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents But_why As System.Windows.Forms.Button
    Friend WithEvents But_dont_ask_again As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents But_close As System.Windows.Forms.Button
    Friend WithEvents CB_dontshow As System.Windows.Forms.CheckBox
    Friend WithEvents TimerCloseForm As System.Windows.Forms.Timer
End Class
