<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class oldprogress_form
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
        Me.components = New System.ComponentModel.Container
        Me.Lbl_heading = New System.Windows.Forms.Label
        Me.LBL_progress = New System.Windows.Forms.Label
        Me.But_ok = New System.Windows.Forms.Button
        Me.But_cancle = New System.Windows.Forms.Button
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.Timer_polestate = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Lbl_heading
        '
        Me.Lbl_heading.AutoSize = True
        Me.Lbl_heading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_heading.Location = New System.Drawing.Point(29, 24)
        Me.Lbl_heading.Name = "Lbl_heading"
        Me.Lbl_heading.Size = New System.Drawing.Size(57, 20)
        Me.Lbl_heading.TabIndex = 0
        Me.Lbl_heading.Text = "Label1"
        '
        'LBL_progress
        '
        Me.LBL_progress.AutoSize = True
        Me.LBL_progress.Location = New System.Drawing.Point(29, 51)
        Me.LBL_progress.Name = "LBL_progress"
        Me.LBL_progress.Size = New System.Drawing.Size(0, 13)
        Me.LBL_progress.TabIndex = 1
        '
        'But_ok
        '
        Me.But_ok.Location = New System.Drawing.Point(125, 180)
        Me.But_ok.Name = "But_ok"
        Me.But_ok.Size = New System.Drawing.Size(75, 23)
        Me.But_ok.TabIndex = 2
        Me.But_ok.Text = "Continue"
        Me.But_ok.UseVisualStyleBackColor = True
        Me.But_ok.Visible = False
        '
        'But_cancle
        '
        Me.But_cancle.Location = New System.Drawing.Point(125, 180)
        Me.But_cancle.Name = "But_cancle"
        Me.But_cancle.Size = New System.Drawing.Size(75, 23)
        Me.But_cancle.TabIndex = 3
        Me.But_cancle.Text = "Cancel"
        Me.But_cancle.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(32, 141)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(291, 23)
        Me.ProgressBar.Step = 11
        Me.ProgressBar.TabIndex = 4
        '
        'Timer_polestate
        '
        '
        'progress_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 225)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.But_cancle)
        Me.Controls.Add(Me.But_ok)
        Me.Controls.Add(Me.LBL_progress)
        Me.Controls.Add(Me.Lbl_heading)
        Me.Name = "progress_form"
        Me.Text = "progress_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_heading As System.Windows.Forms.Label
    Friend WithEvents LBL_progress As System.Windows.Forms.Label
    Friend WithEvents But_ok As System.Windows.Forms.Button
    Friend WithEvents But_cancle As System.Windows.Forms.Button
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer_polestate As System.Windows.Forms.Timer
End Class
