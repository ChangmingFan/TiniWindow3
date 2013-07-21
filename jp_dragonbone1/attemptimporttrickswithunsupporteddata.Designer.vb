<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class attemptimporttrickswithunsupporteddata
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.But_cancel = New System.Windows.Forms.Button
        Me.But_change_file = New System.Windows.Forms.Button
        Me.But_open = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Get Enhansed Version of TiniWindow"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'But_cancel
        '
        Me.But_cancel.Location = New System.Drawing.Point(1, 183)
        Me.But_cancel.Name = "But_cancel"
        Me.But_cancel.Size = New System.Drawing.Size(198, 23)
        Me.But_cancel.TabIndex = 17
        Me.But_cancel.Text = "Cancel"
        Me.But_cancel.UseVisualStyleBackColor = True
        '
        'But_change_file
        '
        Me.But_change_file.Location = New System.Drawing.Point(1, 154)
        Me.But_change_file.Name = "But_change_file"
        Me.But_change_file.Size = New System.Drawing.Size(198, 23)
        Me.But_change_file.TabIndex = 16
        Me.But_change_file.Text = "Pick Another Pattern File To Import"
        Me.But_change_file.UseVisualStyleBackColor = True
        '
        'But_open
        '
        Me.But_open.Location = New System.Drawing.Point(1, 125)
        Me.But_open.Name = "But_open"
        Me.But_open.Size = New System.Drawing.Size(198, 23)
        Me.But_open.TabIndex = 15
        Me.But_open.Text = "Import Patterns With Restrictions"
        Me.But_open.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 52)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "This file contains sign display patters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "that are not supported by this version o" & _
            "f TiniWindow" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "What do you wish to do  "
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(205, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "What" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Restrictions?"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'attemptimporttrickswithunsupporteddata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 264)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.But_cancel)
        Me.Controls.Add(Me.But_change_file)
        Me.Controls.Add(Me.But_open)
        Me.Controls.Add(Me.Label1)
        Me.Name = "attemptimporttrickswithunsupporteddata"
        Me.Text = "attemptimporttrickswithunsupporteddata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents But_cancel As System.Windows.Forms.Button
    Friend WithEvents But_change_file As System.Windows.Forms.Button
    Friend WithEvents But_open As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
