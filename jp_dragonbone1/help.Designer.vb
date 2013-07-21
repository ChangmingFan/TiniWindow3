<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class help
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
        Me.CB_topics = New System.Windows.Forms.ComboBox
        Me.TB_help = New System.Windows.Forms.TextBox
        Me.But_select_topic = New System.Windows.Forms.Button
        Me.But_close = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CB_topics
        '
        Me.CB_topics.Location = New System.Drawing.Point(33, 14)
        Me.CB_topics.Name = "CB_topics"
        Me.CB_topics.Size = New System.Drawing.Size(163, 21)
        Me.CB_topics.TabIndex = 0
        '
        'TB_help
        '
        Me.TB_help.BackColor = System.Drawing.Color.White
        Me.TB_help.Location = New System.Drawing.Point(33, 59)
        Me.TB_help.Multiline = True
        Me.TB_help.Name = "TB_help"
        Me.TB_help.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TB_help.Size = New System.Drawing.Size(429, 290)
        Me.TB_help.TabIndex = 1
        '
        'But_select_topic
        '
        Me.But_select_topic.Location = New System.Drawing.Point(208, 12)
        Me.But_select_topic.Name = "But_select_topic"
        Me.But_select_topic.Size = New System.Drawing.Size(75, 23)
        Me.But_select_topic.TabIndex = 2
        Me.But_select_topic.Text = "Select Topic"
        Me.But_select_topic.UseVisualStyleBackColor = True
        '
        'But_close
        '
        Me.But_close.Location = New System.Drawing.Point(180, 383)
        Me.But_close.Name = "But_close"
        Me.But_close.Size = New System.Drawing.Size(75, 23)
        Me.But_close.TabIndex = 3
        Me.But_close.Text = "Close"
        Me.But_close.UseVisualStyleBackColor = True
        '
        'help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 428)
        Me.Controls.Add(Me.But_close)
        Me.Controls.Add(Me.But_select_topic)
        Me.Controls.Add(Me.TB_help)
        Me.Controls.Add(Me.CB_topics)
        Me.Name = "help"
        Me.Text = "help"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CB_topics As System.Windows.Forms.ComboBox
    Friend WithEvents TB_help As System.Windows.Forms.TextBox
    Friend WithEvents But_select_topic As System.Windows.Forms.Button
    Friend WithEvents But_close As System.Windows.Forms.Button
End Class
