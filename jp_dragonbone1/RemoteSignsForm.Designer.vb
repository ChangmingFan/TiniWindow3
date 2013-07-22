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
        Me.But_apply = New System.Windows.Forms.Button()
        Me.But_OK = New System.Windows.Forms.Button()
        Me.But_cancel = New System.Windows.Forms.Button()
        Me.But_newsign = New System.Windows.Forms.Button()
        Me.But_deleteSign = New System.Windows.Forms.Button()
        Me.CB_promptforpassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'CB_remoteSignList
        '
        Me.CB_remoteSignList.FormattingEnabled = True
        Me.CB_remoteSignList.Location = New System.Drawing.Point(2, 13)
        Me.CB_remoteSignList.Name = "CB_remoteSignList"
        Me.CB_remoteSignList.Size = New System.Drawing.Size(121, 21)
        Me.CB_remoteSignList.TabIndex = 0
        Me.CB_remoteSignList.Text = "select sign to edit"
        '
        'TB_signname
        '
        Me.TB_signname.Location = New System.Drawing.Point(2, 62)
        Me.TB_signname.Name = "TB_signname"
        Me.TB_signname.Size = New System.Drawing.Size(177, 20)
        Me.TB_signname.TabIndex = 1
        '
        'TB_username
        '
        Me.TB_username.Location = New System.Drawing.Point(2, 108)
        Me.TB_username.Name = "TB_username"
        Me.TB_username.Size = New System.Drawing.Size(177, 20)
        Me.TB_username.TabIndex = 2
        '
        'TB_password
        '
        Me.TB_password.Enabled = False
        Me.TB_password.Location = New System.Drawing.Point(2, 159)
        Me.TB_password.Name = "TB_password"
        Me.TB_password.Size = New System.Drawing.Size(177, 20)
        Me.TB_password.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sign Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "User Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'But_advanced
        '
        Me.But_advanced.Location = New System.Drawing.Point(2, 233)
        Me.But_advanced.Name = "But_advanced"
        Me.But_advanced.Size = New System.Drawing.Size(75, 23)
        Me.But_advanced.TabIndex = 7
        Me.But_advanced.Text = "Advanced"
        Me.But_advanced.UseVisualStyleBackColor = True
        '
        'But_apply
        '
        Me.But_apply.Location = New System.Drawing.Point(214, 199)
        Me.But_apply.Name = "But_apply"
        Me.But_apply.Size = New System.Drawing.Size(75, 23)
        Me.But_apply.TabIndex = 8
        Me.But_apply.Text = "Apply"
        Me.But_apply.UseVisualStyleBackColor = True
        '
        'But_OK
        '
        Me.But_OK.Location = New System.Drawing.Point(4, 196)
        Me.But_OK.Name = "But_OK"
        Me.But_OK.Size = New System.Drawing.Size(75, 23)
        Me.But_OK.TabIndex = 9
        Me.But_OK.Text = "OK"
        Me.But_OK.UseVisualStyleBackColor = True
        '
        'But_cancel
        '
        Me.But_cancel.Location = New System.Drawing.Point(93, 196)
        Me.But_cancel.Name = "But_cancel"
        Me.But_cancel.Size = New System.Drawing.Size(75, 23)
        Me.But_cancel.TabIndex = 10
        Me.But_cancel.Text = "Cancel"
        Me.But_cancel.UseVisualStyleBackColor = True
        '
        'But_newsign
        '
        Me.But_newsign.Location = New System.Drawing.Point(277, 13)
        Me.But_newsign.Name = "But_newsign"
        Me.But_newsign.Size = New System.Drawing.Size(75, 23)
        Me.But_newsign.TabIndex = 11
        Me.But_newsign.Text = "New Sign"
        Me.But_newsign.UseVisualStyleBackColor = True
        '
        'But_deleteSign
        '
        Me.But_deleteSign.Location = New System.Drawing.Point(167, 14)
        Me.But_deleteSign.Name = "But_deleteSign"
        Me.But_deleteSign.Size = New System.Drawing.Size(75, 23)
        Me.But_deleteSign.TabIndex = 12
        Me.But_deleteSign.Text = "Delete Sign"
        Me.But_deleteSign.UseVisualStyleBackColor = True
        '
        'CB_promptforpassword
        '
        Me.CB_promptforpassword.AutoSize = True
        Me.CB_promptforpassword.Checked = True
        Me.CB_promptforpassword.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_promptforpassword.Location = New System.Drawing.Point(256, 164)
        Me.CB_promptforpassword.Name = "CB_promptforpassword"
        Me.CB_promptforpassword.Size = New System.Drawing.Size(126, 17)
        Me.CB_promptforpassword.TabIndex = 13
        Me.CB_promptforpassword.Text = "Prompt For Password"
        Me.CB_promptforpassword.UseVisualStyleBackColor = True
        '
        'RemoteSignsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.CB_promptforpassword)
        Me.Controls.Add(Me.But_deleteSign)
        Me.Controls.Add(Me.But_newsign)
        Me.Controls.Add(Me.But_cancel)
        Me.Controls.Add(Me.But_OK)
        Me.Controls.Add(Me.But_apply)
        Me.Controls.Add(Me.But_advanced)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_password)
        Me.Controls.Add(Me.TB_username)
        Me.Controls.Add(Me.TB_signname)
        Me.Controls.Add(Me.CB_remoteSignList)
        Me.Name = "RemoteSignsForm"
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
    Friend WithEvents But_apply As System.Windows.Forms.Button
    Friend WithEvents But_OK As System.Windows.Forms.Button
    Friend WithEvents But_cancel As System.Windows.Forms.Button
    Friend WithEvents But_newsign As System.Windows.Forms.Button
    Friend WithEvents But_deleteSign As System.Windows.Forms.Button
    Friend WithEvents CB_promptforpassword As System.Windows.Forms.CheckBox
End Class
