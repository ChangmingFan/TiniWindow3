<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jpmsgform
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
        Me.Txt_message = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Txt_message
        '
        Me.Txt_message.Dock = System.Windows.Forms.DockStyle.Top
        Me.Txt_message.Location = New System.Drawing.Point(0, 0)
        Me.Txt_message.Multiline = True
        Me.Txt_message.Name = "Txt_message"
        Me.Txt_message.Size = New System.Drawing.Size(1184, 66)
        Me.Txt_message.TabIndex = 0
        Me.Txt_message.Text = "12345678901234567890"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'jpmsgform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 264)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Txt_message)
        Me.Name = "jpmsgform"
        Me.Text = "jpmsgform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_message As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
