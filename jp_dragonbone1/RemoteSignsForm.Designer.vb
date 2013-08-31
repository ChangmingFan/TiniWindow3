<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoteSignsForm
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
        Me.CB_remoteSignList = New System.Windows.Forms.ComboBox()
        Me.TB_signname = New System.Windows.Forms.TextBox()
        Me.TB_username = New System.Windows.Forms.TextBox()
        Me.TB_password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.But_advanced = New System.Windows.Forms.Button()
        Me.But_OK = New System.Windows.Forms.Button()
        Me.But_cancel = New System.Windows.Forms.Button()
        Me.But_newsign = New System.Windows.Forms.Button()
        Me.But_deleteSign = New System.Windows.Forms.Button()
        Me.CB_promptforpassword = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.But_apply = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CB_remoteSignList
        '
        Me.CB_remoteSignList.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_remoteSignList.FormattingEnabled = True
        Me.CB_remoteSignList.Location = New System.Drawing.Point(2, 12)
        Me.CB_remoteSignList.Name = "CB_remoteSignList"
        Me.CB_remoteSignList.Size = New System.Drawing.Size(180, 20)
        Me.CB_remoteSignList.TabIndex = 0
        Me.CB_remoteSignList.Text = "     Select Sign To Edit"
        '
        'TB_signname
        '
        Me.TB_signname.Location = New System.Drawing.Point(2, 57)
        Me.TB_signname.Name = "TB_signname"
        Me.TB_signname.Size = New System.Drawing.Size(180, 20)
        Me.TB_signname.TabIndex = 1
        '
        'TB_username
        '
        Me.TB_username.Location = New System.Drawing.Point(2, 100)
        Me.TB_username.Name = "TB_username"
        Me.TB_username.Size = New System.Drawing.Size(180, 20)
        Me.TB_username.TabIndex = 2
        '
        'TB_password
        '
        Me.TB_password.Enabled = False
        Me.TB_password.Location = New System.Drawing.Point(2, 147)
        Me.TB_password.Name = "TB_password"
        Me.TB_password.Size = New System.Drawing.Size(180, 20)
        Me.TB_password.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sign Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(202, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "User Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(203, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'But_advanced
        '
        Me.But_advanced.BackColor = System.Drawing.Color.Yellow
        Me.But_advanced.Enabled = False
        Me.But_advanced.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_advanced.Location = New System.Drawing.Point(4, 211)
        Me.But_advanced.Name = "But_advanced"
        Me.But_advanced.Size = New System.Drawing.Size(194, 21)
        Me.But_advanced.TabIndex = 7
        Me.But_advanced.Text = "Go To Advanced Form"
        Me.But_advanced.UseVisualStyleBackColor = False
        '
        'But_OK
        '
        Me.But_OK.BackColor = System.Drawing.Color.Lime
        Me.But_OK.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_OK.Location = New System.Drawing.Point(2, 181)
        Me.But_OK.Name = "But_OK"
        Me.But_OK.Size = New System.Drawing.Size(196, 21)
        Me.But_OK.TabIndex = 9
        Me.But_OK.Text = "OK"
        Me.But_OK.UseVisualStyleBackColor = False
        '
        'But_cancel
        '
        Me.But_cancel.BackColor = System.Drawing.Color.Red
        Me.But_cancel.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_cancel.Location = New System.Drawing.Point(233, 181)
        Me.But_cancel.Name = "But_cancel"
        Me.But_cancel.Size = New System.Drawing.Size(183, 21)
        Me.But_cancel.TabIndex = 10
        Me.But_cancel.Text = "Cancel"
        Me.But_cancel.UseVisualStyleBackColor = False
        '
        'But_newsign
        '
        Me.But_newsign.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_newsign.Location = New System.Drawing.Point(322, 12)
        Me.But_newsign.Name = "But_newsign"
        Me.But_newsign.Size = New System.Drawing.Size(87, 21)
        Me.But_newsign.TabIndex = 11
        Me.But_newsign.Text = "New Sign"
        Me.But_newsign.UseVisualStyleBackColor = True
        '
        'But_deleteSign
        '
        Me.But_deleteSign.Enabled = False
        Me.But_deleteSign.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_deleteSign.Location = New System.Drawing.Point(204, 12)
        Me.But_deleteSign.Name = "But_deleteSign"
        Me.But_deleteSign.Size = New System.Drawing.Size(87, 21)
        Me.But_deleteSign.TabIndex = 12
        Me.But_deleteSign.Text = "Delete Sign"
        Me.But_deleteSign.UseVisualStyleBackColor = True
        '
        'CB_promptforpassword
        '
        Me.CB_promptforpassword.AutoSize = True
        Me.CB_promptforpassword.Checked = True
        Me.CB_promptforpassword.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_promptforpassword.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_promptforpassword.Location = New System.Drawing.Point(283, 151)
        Me.CB_promptforpassword.Name = "CB_promptforpassword"
        Me.CB_promptforpassword.Size = New System.Drawing.Size(151, 16)
        Me.CB_promptforpassword.TabIndex = 13
        Me.CB_promptforpassword.Text = "Prompt For Password"
        Me.CB_promptforpassword.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(205, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 14)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "-> Sign IP Address, Directory , FIle Data"
        '
        'But_apply
        '
        Me.But_apply.Location = New System.Drawing.Point(322, 86)
        Me.But_apply.Name = "But_apply"
        Me.But_apply.Size = New System.Drawing.Size(75, 23)
        Me.But_apply.TabIndex = 15
        Me.But_apply.Text = "Apply"
        Me.But_apply.UseVisualStyleBackColor = True
        Me.But_apply.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Coral
        Me.Label5.Location = New System.Drawing.Point(4, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 12)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Please type SIgn name below:"
        '
        'RemoteSignsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 241)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.But_apply)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CB_promptforpassword)
        Me.Controls.Add(Me.But_deleteSign)
        Me.Controls.Add(Me.But_newsign)
        Me.Controls.Add(Me.But_cancel)
        Me.Controls.Add(Me.But_OK)
        Me.Controls.Add(Me.But_advanced)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_password)
        Me.Controls.Add(Me.TB_username)
        Me.Controls.Add(Me.TB_signname)
        Me.Controls.Add(Me.CB_remoteSignList)
        Me.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "RemoteSignsForm"
        Me.Text = "Remote Sign Configuration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CB_remoteSignList As System.Windows.Forms.ComboBox
    Friend WithEvents TB_signname As System.Windows.Forms.TextBox
    Friend WithEvents TB_username As System.Windows.Forms.TextBox
    Friend WithEvents TB_password As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents But_advanced As System.Windows.Forms.Button
    Friend WithEvents But_OK As System.Windows.Forms.Button
    Friend WithEvents But_cancel As System.Windows.Forms.Button
    Friend WithEvents But_newsign As System.Windows.Forms.Button
    Friend WithEvents But_deleteSign As System.Windows.Forms.Button
    Friend WithEvents CB_promptforpassword As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents But_apply As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
