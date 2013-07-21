<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class select_comport_form
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
        Me.Pan_selecting = New System.Windows.Forms.Panel
        Me.Pan_auto_select = New System.Windows.Forms.Panel
        Me.But_auto_retry = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.But_manually_select = New System.Windows.Forms.Button
        Me.Pan_manuel_select = New System.Windows.Forms.Panel
        Me.c = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.But_select = New System.Windows.Forms.Button
        Me.But_continue = New System.Windows.Forms.Button
        Me.But_cancle = New System.Windows.Forms.Button
        Me.But_retryport = New System.Windows.Forms.Button
        Me.Txtmessage = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer_refresh_ports = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_load_finished = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_showstatus = New System.Windows.Forms.Timer(Me.components)
        Me.Pan_selecting.SuspendLayout()
        Me.Pan_auto_select.SuspendLayout()
        Me.Pan_manuel_select.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pan_selecting
        '
        Me.Pan_selecting.Controls.Add(Me.Pan_auto_select)
        Me.Pan_selecting.Controls.Add(Me.Pan_manuel_select)
        Me.Pan_selecting.Controls.Add(Me.Txtmessage)
        Me.Pan_selecting.Controls.Add(Me.Label1)
        Me.Pan_selecting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pan_selecting.Location = New System.Drawing.Point(0, 0)
        Me.Pan_selecting.Name = "Pan_selecting"
        Me.Pan_selecting.Size = New System.Drawing.Size(204, 165)
        Me.Pan_selecting.TabIndex = 4
        '
        'Pan_auto_select
        '
        Me.Pan_auto_select.Controls.Add(Me.But_auto_retry)
        Me.Pan_auto_select.Controls.Add(Me.Button2)
        Me.Pan_auto_select.Controls.Add(Me.But_manually_select)
        Me.Pan_auto_select.Location = New System.Drawing.Point(3, 48)
        Me.Pan_auto_select.Name = "Pan_auto_select"
        Me.Pan_auto_select.Size = New System.Drawing.Size(200, 117)
        Me.Pan_auto_select.TabIndex = 13
        '
        'But_auto_retry
        '
        Me.But_auto_retry.Location = New System.Drawing.Point(95, 28)
        Me.But_auto_retry.Name = "But_auto_retry"
        Me.But_auto_retry.Size = New System.Drawing.Size(75, 23)
        Me.But_auto_retry.TabIndex = 2
        Me.But_auto_retry.Text = "Retry"
        Me.But_auto_retry.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(14, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'But_manually_select
        '
        Me.But_manually_select.Location = New System.Drawing.Point(42, 57)
        Me.But_manually_select.Name = "But_manually_select"
        Me.But_manually_select.Size = New System.Drawing.Size(102, 23)
        Me.But_manually_select.TabIndex = 0
        Me.But_manually_select.Text = "Manuelly select"
        Me.But_manually_select.UseVisualStyleBackColor = True
        '
        'Pan_manuel_select
        '
        Me.Pan_manuel_select.Controls.Add(Me.c)
        Me.Pan_manuel_select.Controls.Add(Me.Button1)
        Me.Pan_manuel_select.Controls.Add(Me.But_select)
        Me.Pan_manuel_select.Controls.Add(Me.But_continue)
        Me.Pan_manuel_select.Controls.Add(Me.But_cancle)
        Me.Pan_manuel_select.Controls.Add(Me.But_retryport)
        Me.Pan_manuel_select.Location = New System.Drawing.Point(3, 65)
        Me.Pan_manuel_select.Name = "Pan_manuel_select"
        Me.Pan_manuel_select.Size = New System.Drawing.Size(223, 100)
        Me.Pan_manuel_select.TabIndex = 12
        Me.Pan_manuel_select.Visible = False
        '
        'c
        '
        Me.c.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList
        Me.c.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.c.FormattingEnabled = True
        Me.c.Location = New System.Drawing.Point(20, 12)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(121, 21)
        Me.c.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(106, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Help"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'But_select
        '
        Me.But_select.Location = New System.Drawing.Point(10, 48)
        Me.But_select.Name = "But_select"
        Me.But_select.Size = New System.Drawing.Size(75, 23)
        Me.But_select.TabIndex = 6
        Me.But_select.Text = "Next"
        Me.But_select.UseVisualStyleBackColor = True
        '
        'But_continue
        '
        Me.But_continue.Location = New System.Drawing.Point(57, 48)
        Me.But_continue.Name = "But_continue"
        Me.But_continue.Size = New System.Drawing.Size(75, 23)
        Me.But_continue.TabIndex = 10
        Me.But_continue.Text = "Continue"
        Me.But_continue.UseVisualStyleBackColor = True
        Me.But_continue.Visible = False
        '
        'But_cancle
        '
        Me.But_cancle.Location = New System.Drawing.Point(106, 48)
        Me.But_cancle.Name = "But_cancle"
        Me.But_cancle.Size = New System.Drawing.Size(75, 23)
        Me.But_cancle.TabIndex = 7
        Me.But_cancle.Text = "Cancel"
        Me.But_cancle.UseVisualStyleBackColor = True
        '
        'But_retryport
        '
        Me.But_retryport.Location = New System.Drawing.Point(3, 86)
        Me.But_retryport.Name = "But_retryport"
        Me.But_retryport.Size = New System.Drawing.Size(82, 23)
        Me.But_retryport.TabIndex = 9
        Me.But_retryport.Text = "Retry "
        Me.But_retryport.UseVisualStyleBackColor = True
        Me.But_retryport.Visible = False
        '
        'Txtmessage
        '
        Me.Txtmessage.Dock = System.Windows.Forms.DockStyle.Top
        Me.Txtmessage.Location = New System.Drawing.Point(0, 0)
        Me.Txtmessage.Multiline = True
        Me.Txtmessage.Name = "Txtmessage"
        Me.Txtmessage.Size = New System.Drawing.Size(204, 50)
        Me.Txtmessage.TabIndex = 8
        Me.Txtmessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, -21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "select comport"
        '
        'Timer_refresh_ports
        '
        Me.Timer_refresh_ports.Interval = 500
        '
        'Timer_load_finished
        '
        Me.Timer_load_finished.Interval = 1000
        '
        'Timer_showstatus
        '
        '
        'select_comport_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 165)
        Me.Controls.Add(Me.Pan_selecting)
        Me.Name = "select_comport_form"
        Me.Text = "Select Comport"
        Me.Pan_selecting.ResumeLayout(False)
        Me.Pan_selecting.PerformLayout()
        Me.Pan_auto_select.ResumeLayout(False)
        Me.Pan_manuel_select.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pan_selecting As System.Windows.Forms.Panel
    Friend WithEvents But_cancle As System.Windows.Forms.Button
    Friend WithEvents But_select As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c As System.Windows.Forms.ComboBox
    Friend WithEvents But_retryport As System.Windows.Forms.Button
    Friend WithEvents Txtmessage As System.Windows.Forms.TextBox
    Friend WithEvents But_continue As System.Windows.Forms.Button
    Friend WithEvents Timer_refresh_ports As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Pan_auto_select As System.Windows.Forms.Panel
    Friend WithEvents But_manually_select As System.Windows.Forms.Button
    Friend WithEvents Pan_manuel_select As System.Windows.Forms.Panel
    Friend WithEvents But_auto_retry As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer_load_finished As System.Windows.Forms.Timer
    Friend WithEvents Timer_showstatus As System.Windows.Forms.Timer
End Class
