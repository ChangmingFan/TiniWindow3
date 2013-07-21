<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enter_name_form
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.TB_username = New System.Windows.Forms.TextBox
        Me.But_ok = New System.Windows.Forms.Button
        Me.But_latter = New System.Windows.Forms.Button
        Me.But_dont_ask_again = New System.Windows.Forms.Button
        Me.But_why = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome, please enter your name"
        '
        'TB_username
        '
        Me.TB_username.Location = New System.Drawing.Point(16, 30)
        Me.TB_username.Name = "TB_username"
        Me.TB_username.Size = New System.Drawing.Size(251, 20)
        Me.TB_username.TabIndex = 1
        '
        'But_ok
        '
        Me.But_ok.Location = New System.Drawing.Point(38, 84)
        Me.But_ok.Name = "But_ok"
        Me.But_ok.Size = New System.Drawing.Size(75, 23)
        Me.But_ok.TabIndex = 2
        Me.But_ok.Text = "Submit"
        Me.But_ok.UseVisualStyleBackColor = True
        '
        'But_latter
        '
        Me.But_latter.Location = New System.Drawing.Point(131, 84)
        Me.But_latter.Name = "But_latter"
        Me.But_latter.Size = New System.Drawing.Size(75, 23)
        Me.But_latter.TabIndex = 3
        Me.But_latter.Text = "Latter"
        Me.But_latter.UseVisualStyleBackColor = True
        '
        'But_dont_ask_again
        '
        Me.But_dont_ask_again.Location = New System.Drawing.Point(16, 123)
        Me.But_dont_ask_again.Name = "But_dont_ask_again"
        Me.But_dont_ask_again.Size = New System.Drawing.Size(97, 23)
        Me.But_dont_ask_again.TabIndex = 4
        Me.But_dont_ask_again.Text = "Don't ask again"
        Me.But_dont_ask_again.UseVisualStyleBackColor = True
        '
        'But_why
        '
        Me.But_why.Location = New System.Drawing.Point(131, 123)
        Me.But_why.Name = "But_why"
        Me.But_why.Size = New System.Drawing.Size(75, 23)
        Me.But_why.TabIndex = 5
        Me.But_why.Text = "Why we ask"
        Me.But_why.UseVisualStyleBackColor = True
        '
        'enter_name_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 158)
        Me.Controls.Add(Me.But_why)
        Me.Controls.Add(Me.But_dont_ask_again)
        Me.Controls.Add(Me.But_latter)
        Me.Controls.Add(Me.But_ok)
        Me.Controls.Add(Me.TB_username)
        Me.Controls.Add(Me.Label1)
        Me.Name = "enter_name_form"
        Me.Text = "enter_name_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_username As System.Windows.Forms.TextBox
    Friend WithEvents But_ok As System.Windows.Forms.Button
    Friend WithEvents But_latter As System.Windows.Forms.Button
    Friend WithEvents But_dont_ask_again As System.Windows.Forms.Button
    Friend WithEvents But_why As System.Windows.Forms.Button
End Class
