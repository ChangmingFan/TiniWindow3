<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class attempttoopenfilewithunrecognizedtrickcodingversion
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
        Me.But_change_file = New System.Windows.Forms.Button
        Me.But_open_with_restrictions = New System.Windows.Forms.Button
        Me.button_open_and_discard = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'But_cancel
        '
        Me.But_cancel.Location = New System.Drawing.Point(4, 165)
        Me.But_cancel.Name = "But_cancel"
        Me.But_cancel.Size = New System.Drawing.Size(198, 23)
        Me.But_cancel.TabIndex = 17
        Me.But_cancel.Text = "Cancel"
        Me.But_cancel.UseVisualStyleBackColor = True
        '
        'But_change_file
        '
        Me.But_change_file.Location = New System.Drawing.Point(4, 136)
        Me.But_change_file.Name = "But_change_file"
        Me.But_change_file.Size = New System.Drawing.Size(198, 23)
        Me.But_change_file.TabIndex = 16
        Me.But_change_file.Text = "Pick Another File To Open"
        Me.But_change_file.UseVisualStyleBackColor = True
        '
        'But_open_with_restrictions
        '
        Me.But_open_with_restrictions.Location = New System.Drawing.Point(4, 107)
        Me.But_open_with_restrictions.Name = "But_open_with_restrictions"
        Me.But_open_with_restrictions.Size = New System.Drawing.Size(198, 23)
        Me.But_open_with_restrictions.TabIndex = 15
        Me.But_open_with_restrictions.Text = "Open File With Restrictions"
        Me.But_open_with_restrictions.UseVisualStyleBackColor = True
        '
        'button_open_and_discard
        '
        Me.button_open_and_discard.Location = New System.Drawing.Point(4, 78)
        Me.button_open_and_discard.Name = "button_open_and_discard"
        Me.button_open_and_discard.Size = New System.Drawing.Size(198, 23)
        Me.button_open_and_discard.TabIndex = 14
        Me.button_open_and_discard.Text = "Discard Unrecognised Patterns "
        Me.button_open_and_discard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 39)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "This stores sign display patterns in an unrecognized format" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "What do you wish t" & _
            "o do  "
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(208, 109)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "What" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Restrictions?"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'attempttoopenfilewithunrecognizedtrickcodingversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.But_cancel)
        Me.Controls.Add(Me.But_change_file)
        Me.Controls.Add(Me.But_open_with_restrictions)
        Me.Controls.Add(Me.button_open_and_discard)
        Me.Controls.Add(Me.Label1)
        Me.Name = "attempttoopenfilewithunrecognizedtrickcodingversion"
        Me.Text = "attempttoopenfilewithunrecognizedtrickcodingversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents But_cancel As System.Windows.Forms.Button
    Friend WithEvents But_change_file As System.Windows.Forms.Button
    Friend WithEvents But_open_with_restrictions As System.Windows.Forms.Button
    Friend WithEvents button_open_and_discard As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
