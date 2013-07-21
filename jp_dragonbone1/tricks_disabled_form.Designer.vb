<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tricks_disabled_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tricks_disabled_form))
        Me.Txt_message = New System.Windows.Forms.TextBox
        Me.But_ok = New System.Windows.Forms.Button
        Me.But_discard = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Txt_message
        '
        Me.Txt_message.BackColor = System.Drawing.SystemColors.Control
        Me.Txt_message.Dock = System.Windows.Forms.DockStyle.Top
        Me.Txt_message.Location = New System.Drawing.Point(0, 0)
        Me.Txt_message.Multiline = True
        Me.Txt_message.Name = "Txt_message"
        Me.Txt_message.Size = New System.Drawing.Size(257, 71)
        Me.Txt_message.TabIndex = 0
        Me.Txt_message.Text = resources.GetString("Txt_message.Text")
        '
        'But_ok
        '
        Me.But_ok.Location = New System.Drawing.Point(12, 98)
        Me.But_ok.Name = "But_ok"
        Me.But_ok.Size = New System.Drawing.Size(95, 23)
        Me.But_ok.TabIndex = 1
        Me.But_ok.Text = "OK"
        Me.But_ok.UseVisualStyleBackColor = True
        '
        'But_discard
        '
        Me.But_discard.Location = New System.Drawing.Point(122, 98)
        Me.But_discard.Name = "But_discard"
        Me.But_discard.Size = New System.Drawing.Size(106, 23)
        Me.But_discard.TabIndex = 2
        Me.But_discard.Text = "Discard trick data"
        Me.But_discard.UseVisualStyleBackColor = True
        '
        'tricks_disabled_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 120)
        Me.Controls.Add(Me.But_discard)
        Me.Controls.Add(Me.But_ok)
        Me.Controls.Add(Me.Txt_message)
        Me.Name = "tricks_disabled_form"
        Me.Text = "tricks_disabled_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_message As System.Windows.Forms.TextBox
    Friend WithEvents But_ok As System.Windows.Forms.Button
    Friend WithEvents But_discard As System.Windows.Forms.Button
End Class
