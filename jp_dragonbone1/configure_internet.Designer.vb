<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configure_internet
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
        Me.RB_server = New System.Windows.Forms.RadioButton
        Me.Txt_port = New System.Windows.Forms.TextBox
        Me.Lbl_port = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.But_ok = New System.Windows.Forms.Button
        Me.but_apply = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.RB_client = New System.Windows.Forms.RadioButton
        Me.Txt_IP = New System.Windows.Forms.TextBox
        Me.Lbl_ip = New System.Windows.Forms.Label
        Me.RB_use_Tinilite_server = New System.Windows.Forms.RadioButton
        Me.CB_show_advanced = New System.Windows.Forms.CheckBox
        Me.Pan_advance_config = New System.Windows.Forms.Panel
        Me.txt_company = New System.Windows.Forms.TextBox
        Me.txt_username = New System.Windows.Forms.TextBox
        Me.txt_password = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CB_connection_name = New System.Windows.Forms.ComboBox
        Me.Pan_advance_config.SuspendLayout()
        Me.SuspendLayout()
        '
        'RB_server
        '
        Me.RB_server.AutoSize = True
        Me.RB_server.Location = New System.Drawing.Point(10, 248)
        Me.RB_server.Name = "RB_server"
        Me.RB_server.Size = New System.Drawing.Size(126, 17)
        Me.RB_server.TabIndex = 2
        Me.RB_server.Text = "TiniWindow is server "
        Me.RB_server.UseVisualStyleBackColor = True
        Me.RB_server.Visible = False
        '
        'Txt_port
        '
        Me.Txt_port.Location = New System.Drawing.Point(22, 43)
        Me.Txt_port.Name = "Txt_port"
        Me.Txt_port.Size = New System.Drawing.Size(100, 20)
        Me.Txt_port.TabIndex = 1
        Me.Txt_port.Text = "2050"
        '
        'Lbl_port
        '
        Me.Lbl_port.AutoSize = True
        Me.Lbl_port.Location = New System.Drawing.Point(140, 46)
        Me.Lbl_port.Name = "Lbl_port"
        Me.Lbl_port.Size = New System.Drawing.Size(25, 13)
        Me.Lbl_port.TabIndex = 4
        Me.Lbl_port.Text = "port"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(14, 206)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(120, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "connection enabled"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'But_ok
        '
        Me.But_ok.Location = New System.Drawing.Point(10, 229)
        Me.But_ok.Name = "But_ok"
        Me.But_ok.Size = New System.Drawing.Size(75, 23)
        Me.But_ok.TabIndex = 6
        Me.But_ok.Text = "GO"
        Me.But_ok.UseVisualStyleBackColor = True
        '
        'but_apply
        '
        Me.but_apply.Location = New System.Drawing.Point(191, 206)
        Me.but_apply.Name = "but_apply"
        Me.but_apply.Size = New System.Drawing.Size(75, 23)
        Me.but_apply.TabIndex = 7
        Me.but_apply.Text = "Apply"
        Me.but_apply.UseVisualStyleBackColor = True
        Me.but_apply.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(91, 229)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RB_client
        '
        Me.RB_client.AutoSize = True
        Me.RB_client.Location = New System.Drawing.Point(143, 248)
        Me.RB_client.Name = "RB_client"
        Me.RB_client.Size = New System.Drawing.Size(119, 17)
        Me.RB_client.TabIndex = 9
        Me.RB_client.Text = "TiniWindow is client"
        Me.RB_client.UseVisualStyleBackColor = True
        Me.RB_client.Visible = False
        '
        'Txt_IP
        '
        Me.Txt_IP.Location = New System.Drawing.Point(22, 9)
        Me.Txt_IP.Name = "Txt_IP"
        Me.Txt_IP.Size = New System.Drawing.Size(180, 20)
        Me.Txt_IP.TabIndex = 0
        Me.Txt_IP.Text = "184.168.86.30"
        '
        'Lbl_ip
        '
        Me.Lbl_ip.AutoSize = True
        Me.Lbl_ip.Location = New System.Drawing.Point(230, 12)
        Me.Lbl_ip.Name = "Lbl_ip"
        Me.Lbl_ip.Size = New System.Drawing.Size(17, 13)
        Me.Lbl_ip.TabIndex = 11
        Me.Lbl_ip.Text = "IP"
        '
        'RB_use_Tinilite_server
        '
        Me.RB_use_Tinilite_server.AutoSize = True
        Me.RB_use_Tinilite_server.Checked = True
        Me.RB_use_Tinilite_server.Location = New System.Drawing.Point(12, 4)
        Me.RB_use_Tinilite_server.Name = "RB_use_Tinilite_server"
        Me.RB_use_Tinilite_server.Size = New System.Drawing.Size(183, 17)
        Me.RB_use_Tinilite_server.TabIndex = 101
        Me.RB_use_Tinilite_server.TabStop = True
        Me.RB_use_Tinilite_server.Text = "Use TiniLite Server (recomended)"
        Me.RB_use_Tinilite_server.UseVisualStyleBackColor = True
        '
        'CB_show_advanced
        '
        Me.CB_show_advanced.AutoSize = True
        Me.CB_show_advanced.Location = New System.Drawing.Point(35, 110)
        Me.CB_show_advanced.Name = "CB_show_advanced"
        Me.CB_show_advanced.Size = New System.Drawing.Size(166, 17)
        Me.CB_show_advanced.TabIndex = 102
        Me.CB_show_advanced.Text = "show advanced configuration"
        Me.CB_show_advanced.UseVisualStyleBackColor = True
        '
        'Pan_advance_config
        '
        Me.Pan_advance_config.Controls.Add(Me.Txt_IP)
        Me.Pan_advance_config.Controls.Add(Me.Txt_port)
        Me.Pan_advance_config.Controls.Add(Me.Lbl_port)
        Me.Pan_advance_config.Controls.Add(Me.Lbl_ip)
        Me.Pan_advance_config.Location = New System.Drawing.Point(-1, 131)
        Me.Pan_advance_config.Name = "Pan_advance_config"
        Me.Pan_advance_config.Size = New System.Drawing.Size(274, 69)
        Me.Pan_advance_config.TabIndex = 103
        Me.Pan_advance_config.Visible = False
        '
        'txt_company
        '
        Me.txt_company.Location = New System.Drawing.Point(5, 27)
        Me.txt_company.Name = "txt_company"
        Me.txt_company.Size = New System.Drawing.Size(190, 20)
        Me.txt_company.TabIndex = 104
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(5, 52)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(190, 20)
        Me.txt_username.TabIndex = 105
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(6, 76)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(190, 20)
        Me.txt_password.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(207, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Company"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "UserName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(205, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "PassWord"
        '
        'CB_connection_name
        '
        Me.CB_connection_name.FormattingEnabled = True
        Me.CB_connection_name.Location = New System.Drawing.Point(255, 251)
        Me.CB_connection_name.Name = "CB_connection_name"
        Me.CB_connection_name.Size = New System.Drawing.Size(121, 21)
        Me.CB_connection_name.TabIndex = 110
        Me.CB_connection_name.Visible = False
        '
        'configure_internet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 264)
        Me.ControlBox = False
        Me.Controls.Add(Me.CB_connection_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_company)
        Me.Controls.Add(Me.Pan_advance_config)
        Me.Controls.Add(Me.CB_show_advanced)
        Me.Controls.Add(Me.RB_use_Tinilite_server)
        Me.Controls.Add(Me.RB_client)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.but_apply)
        Me.Controls.Add(Me.But_ok)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.RB_server)
        Me.Name = "configure_internet"
        Me.Text = "LocWifi - Configure Internet"
        Me.Pan_advance_config.ResumeLayout(False)
        Me.Pan_advance_config.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RB_server As System.Windows.Forms.RadioButton
    Friend WithEvents Txt_port As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_port As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents But_ok As System.Windows.Forms.Button
    Friend WithEvents but_apply As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RB_client As System.Windows.Forms.RadioButton
    Friend WithEvents Txt_IP As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_ip As System.Windows.Forms.Label
    Friend WithEvents RB_use_Tinilite_server As System.Windows.Forms.RadioButton
    Friend WithEvents CB_show_advanced As System.Windows.Forms.CheckBox
    Friend WithEvents Pan_advance_config As System.Windows.Forms.Panel
    Friend WithEvents txt_company As System.Windows.Forms.TextBox
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CB_connection_name As System.Windows.Forms.ComboBox
End Class
