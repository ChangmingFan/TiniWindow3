<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmImportTricksInMonitorMode
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
        Me.But_cancel = New System.Windows.Forms.Button
        Me.But_exit = New System.Windows.Forms.Button
        Me.But_replace = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'But_cancel
        '
        Me.But_cancel.Location = New System.Drawing.Point(12, 184)
        Me.But_cancel.Name = "But_cancel"
        Me.But_cancel.Size = New System.Drawing.Size(217, 44)
        Me.But_cancel.TabIndex = 7
        Me.But_cancel.Text = "Cancel"
        Me.But_cancel.UseVisualStyleBackColor = True
        '
        'But_exit
        '
        Me.But_exit.Location = New System.Drawing.Point(11, 134)
        Me.But_exit.Name = "But_exit"
        Me.But_exit.Size = New System.Drawing.Size(218, 44)
        Me.But_exit.TabIndex = 6
        Me.But_exit.Text = "Exit monitor mode and import display patterns"
        Me.But_exit.UseVisualStyleBackColor = True
        '
        'But_replace
        '
        Me.But_replace.Location = New System.Drawing.Point(12, 84)
        Me.But_replace.Name = "But_replace"
        Me.But_replace.Size = New System.Drawing.Size(217, 44)
        Me.But_replace.TabIndex = 5
        Me.But_replace.Text = "Replace the display patterns currently in the sign  with the tricks you're import" & _
            "ing"
        Me.But_replace.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "You are currently in monitor mode" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "What do you wish to do?"
        '
        'ConfirmImportTricksInMonitorMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 264)
        Me.Controls.Add(Me.But_cancel)
        Me.Controls.Add(Me.But_exit)
        Me.Controls.Add(Me.But_replace)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConfirmImportTricksInMonitorMode"
        Me.Text = "ConfirmImportTricksInMonitorMode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents But_cancel As System.Windows.Forms.Button
    Friend WithEvents But_exit As System.Windows.Forms.Button
    Friend WithEvents But_replace As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
