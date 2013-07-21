<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class attepttoopentrickfileasdata_form
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
        Me.But_import = New System.Windows.Forms.Button
        Me.But_open = New System.Windows.Forms.Button
        Me.But_change_file = New System.Windows.Forms.Button
        Me.But_cancel = New System.Windows.Forms.Button
        Me.CB_alwaysdo = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "It appears that you are trying to open a file used for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "exporting and importing " & _
            "tricks." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "What do you want to do?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  "
        '
        'But_import
        '
        Me.But_import.Location = New System.Drawing.Point(43, 68)
        Me.But_import.Name = "But_import"
        Me.But_import.Size = New System.Drawing.Size(158, 23)
        Me.But_import.TabIndex = 1
        Me.But_import.Text = "Import tricks"
        Me.But_import.UseVisualStyleBackColor = True
        '
        'But_open
        '
        Me.But_open.Location = New System.Drawing.Point(43, 97)
        Me.But_open.Name = "But_open"
        Me.But_open.Size = New System.Drawing.Size(158, 23)
        Me.But_open.TabIndex = 2
        Me.But_open.Text = "Open as Data File"
        Me.But_open.UseVisualStyleBackColor = True
        '
        'But_change_file
        '
        Me.But_change_file.Location = New System.Drawing.Point(43, 126)
        Me.But_change_file.Name = "But_change_file"
        Me.But_change_file.Size = New System.Drawing.Size(158, 23)
        Me.But_change_file.TabIndex = 3
        Me.But_change_file.Text = "Pick Another File To Open"
        Me.But_change_file.UseVisualStyleBackColor = True
        '
        'But_cancel
        '
        Me.But_cancel.Location = New System.Drawing.Point(43, 155)
        Me.But_cancel.Name = "But_cancel"
        Me.But_cancel.Size = New System.Drawing.Size(158, 23)
        Me.But_cancel.TabIndex = 4
        Me.But_cancel.Text = "Cancel"
        Me.But_cancel.UseVisualStyleBackColor = True
        '
        'CB_alwaysdo
        '
        Me.CB_alwaysdo.AutoSize = True
        Me.CB_alwaysdo.Location = New System.Drawing.Point(43, 196)
        Me.CB_alwaysdo.Name = "CB_alwaysdo"
        Me.CB_alwaysdo.Size = New System.Drawing.Size(152, 17)
        Me.CB_alwaysdo.TabIndex = 5
        Me.CB_alwaysdo.Text = "Always do Selected Action"
        Me.CB_alwaysdo.UseVisualStyleBackColor = True
        '
        'attepttoopentrickfileasdata_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 225)
        Me.ControlBox = False
        Me.Controls.Add(Me.CB_alwaysdo)
        Me.Controls.Add(Me.But_cancel)
        Me.Controls.Add(Me.But_change_file)
        Me.Controls.Add(Me.But_open)
        Me.Controls.Add(Me.But_import)
        Me.Controls.Add(Me.Label1)
        Me.Name = "attepttoopentrickfileasdata_form"
        Me.Text = "Attempt to open exported tricks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents But_import As System.Windows.Forms.Button
    Friend WithEvents But_open As System.Windows.Forms.Button
    Friend WithEvents But_change_file As System.Windows.Forms.Button
    Friend WithEvents But_cancel As System.Windows.Forms.Button
    Friend WithEvents CB_alwaysdo As System.Windows.Forms.CheckBox
End Class
