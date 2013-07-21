<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmEnterMonitorMode
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
        Me.But_cancel = New System.Windows.Forms.Button
        Me.But_send = New System.Windows.Forms.Button
        Me.But_get = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'But_cancel
        '
        Me.But_cancel.Location = New System.Drawing.Point(56, 157)
        Me.But_cancel.Name = "But_cancel"
        Me.But_cancel.Size = New System.Drawing.Size(126, 44)
        Me.But_cancel.TabIndex = 7
        Me.But_cancel.Text = "Cancel"
        Me.But_cancel.UseVisualStyleBackColor = True
        '
        'But_send
        '
        Me.But_send.Location = New System.Drawing.Point(55, 107)
        Me.But_send.Name = "But_send"
        Me.But_send.Size = New System.Drawing.Size(127, 44)
        Me.But_send.TabIndex = 6
        Me.But_send.Text = "Send Data  To Sign"
        Me.But_send.UseVisualStyleBackColor = True
        '
        'But_get
        '
        Me.But_get.Location = New System.Drawing.Point(56, 57)
        Me.But_get.Name = "But_get"
        Me.But_get.Size = New System.Drawing.Size(126, 44)
        Me.But_get.TabIndex = 5
        Me.But_get.Text = "Get Data From Sign"
        Me.But_get.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Before entering monitor mode do you wish to:"
        '
        'ConfirmEnterMonitorMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 218)
        Me.Controls.Add(Me.But_cancel)
        Me.Controls.Add(Me.But_send)
        Me.Controls.Add(Me.But_get)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConfirmEnterMonitorMode"
        Me.Text = "Entering Monitor Mode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents But_cancel As System.Windows.Forms.Button
    Friend WithEvents But_send As System.Windows.Forms.Button
    Friend WithEvents But_get As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
