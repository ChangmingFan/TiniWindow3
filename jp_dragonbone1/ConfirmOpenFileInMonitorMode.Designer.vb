<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmOpenFileInMonitorMode
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.But_replace = New System.Windows.Forms.Button
        Me.But_exit = New System.Windows.Forms.Button
        Me.But_cancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "You are currently in monitor mode" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "What do you wish to do?"
        '
        'But_replace
        '
        Me.But_replace.Location = New System.Drawing.Point(12, 62)
        Me.But_replace.Name = "But_replace"
        Me.But_replace.Size = New System.Drawing.Size(217, 44)
        Me.But_replace.TabIndex = 1
        Me.But_replace.Text = "Replace the data currently in the sign  with the data in the file you're opening"
        Me.But_replace.UseVisualStyleBackColor = True
        '
        'But_exit
        '
        Me.But_exit.Location = New System.Drawing.Point(11, 112)
        Me.But_exit.Name = "But_exit"
        Me.But_exit.Size = New System.Drawing.Size(218, 44)
        Me.But_exit.TabIndex = 2
        Me.But_exit.Text = "Exit monitor mode and open file"
        Me.But_exit.UseVisualStyleBackColor = True
        '
        'But_cancel
        '
        Me.But_cancel.Location = New System.Drawing.Point(12, 162)
        Me.But_cancel.Name = "But_cancel"
        Me.But_cancel.Size = New System.Drawing.Size(217, 44)
        Me.But_cancel.TabIndex = 3
        Me.But_cancel.Text = "Cancel"
        Me.But_cancel.UseVisualStyleBackColor = True
        '
        'ConfirmOpenFileInMonitorMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(243, 227)
        Me.Controls.Add(Me.But_cancel)
        Me.Controls.Add(Me.But_exit)
        Me.Controls.Add(Me.But_replace)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConfirmOpenFileInMonitorMode"
        Me.Text = "Opening File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents But_replace As System.Windows.Forms.Button
    Friend WithEvents But_exit As System.Windows.Forms.Button
    Friend WithEvents But_cancel As System.Windows.Forms.Button
End Class
