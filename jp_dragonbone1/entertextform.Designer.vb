<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entertextform
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
        Me.Lbl_prompt = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.But_ok = New System.Windows.Forms.Button
        Me.But_cancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Lbl_prompt
        '
        Me.Lbl_prompt.AutoSize = True
        Me.Lbl_prompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_prompt.Location = New System.Drawing.Point(12, 22)
        Me.Lbl_prompt.Name = "Lbl_prompt"
        Me.Lbl_prompt.Size = New System.Drawing.Size(0, 25)
        Me.Lbl_prompt.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 20)
        Me.TextBox1.TabIndex = 1
        '
        'But_ok
        '
        Me.But_ok.Location = New System.Drawing.Point(13, 156)
        Me.But_ok.Name = "But_ok"
        Me.But_ok.Size = New System.Drawing.Size(75, 23)
        Me.But_ok.TabIndex = 2
        Me.But_ok.Text = "OK"
        Me.But_ok.UseVisualStyleBackColor = True
        '
        'But_cancel
        '
        Me.But_cancel.Location = New System.Drawing.Point(136, 156)
        Me.But_cancel.Name = "But_cancel"
        Me.But_cancel.Size = New System.Drawing.Size(75, 23)
        Me.But_cancel.TabIndex = 3
        Me.But_cancel.Text = "Cancel"
        Me.But_cancel.UseVisualStyleBackColor = True
        '
        'entertextform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 196)
        Me.ControlBox = False
        Me.Controls.Add(Me.But_cancel)
        Me.Controls.Add(Me.But_ok)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Lbl_prompt)
        Me.Name = "entertextform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_prompt As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents But_ok As System.Windows.Forms.Button
    Friend WithEvents But_cancel As System.Windows.Forms.Button
End Class
