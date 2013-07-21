<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgressForm
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
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.LblProgress = New System.Windows.Forms.Label()
        Me.But_cancel = New System.Windows.Forms.Button()
        Me.But_ok = New System.Windows.Forms.Button()
        Me.But_retry = New System.Windows.Forms.Button()
        Me.Lbl_WarningLine1 = New System.Windows.Forms.Label()
        Me.Lbl_WarningLine2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(0, 23)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(267, 14)
        Me.ProgressBar.TabIndex = 0
        '
        'LblProgress
        '
        Me.LblProgress.AutoSize = True
        Me.LblProgress.Location = New System.Drawing.Point(0, -2)
        Me.LblProgress.Name = "LblProgress"
        Me.LblProgress.Size = New System.Drawing.Size(39, 13)
        Me.LblProgress.TabIndex = 2
        Me.LblProgress.Text = "Label1"
        Me.LblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'But_cancel
        '
        Me.But_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_cancel.Location = New System.Drawing.Point(87, 66)
        Me.But_cancel.Name = "But_cancel"
        Me.But_cancel.Size = New System.Drawing.Size(75, 20)
        Me.But_cancel.TabIndex = 3
        Me.But_cancel.Text = "Cancel"
        Me.But_cancel.UseVisualStyleBackColor = True
        '
        'But_ok
        '
        Me.But_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_ok.Location = New System.Drawing.Point(87, 66)
        Me.But_ok.Name = "But_ok"
        Me.But_ok.Size = New System.Drawing.Size(75, 20)
        Me.But_ok.TabIndex = 4
        Me.But_ok.Text = "Continue"
        Me.But_ok.UseVisualStyleBackColor = True
        Me.But_ok.Visible = False
        '
        'But_retry
        '
        Me.But_retry.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_retry.Location = New System.Drawing.Point(168, 66)
        Me.But_retry.Name = "But_retry"
        Me.But_retry.Size = New System.Drawing.Size(75, 20)
        Me.But_retry.TabIndex = 5
        Me.But_retry.Text = "Retry"
        Me.But_retry.UseVisualStyleBackColor = True
        '
        'Lbl_WarningLine1
        '
        Me.Lbl_WarningLine1.AutoSize = True
        Me.Lbl_WarningLine1.Location = New System.Drawing.Point(3, 39)
        Me.Lbl_WarningLine1.Name = "Lbl_WarningLine1"
        Me.Lbl_WarningLine1.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_WarningLine1.TabIndex = 6
        Me.Lbl_WarningLine1.Text = "Warning line 1"
        '
        'Lbl_WarningLine2
        '
        Me.Lbl_WarningLine2.AutoSize = True
        Me.Lbl_WarningLine2.Location = New System.Drawing.Point(3, 55)
        Me.Lbl_WarningLine2.Name = "Lbl_WarningLine2"
        Me.Lbl_WarningLine2.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_WarningLine2.TabIndex = 7
        Me.Lbl_WarningLine2.Text = "Warning line 2"
        '
        'ProgressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 88)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl_WarningLine2)
        Me.Controls.Add(Me.Lbl_WarningLine1)
        Me.Controls.Add(Me.But_retry)
        Me.Controls.Add(Me.But_ok)
        Me.Controls.Add(Me.But_cancel)
        Me.Controls.Add(Me.LblProgress)
        Me.Controls.Add(Me.ProgressBar)
        Me.Name = "ProgressForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Public WithEvents LblProgress As System.Windows.Forms.Label
    Public WithEvents But_cancel As System.Windows.Forms.Button
    Public WithEvents But_ok As System.Windows.Forms.Button
    Friend WithEvents But_retry As System.Windows.Forms.Button
    Public WithEvents Lbl_WarningLine1 As System.Windows.Forms.Label
    Public WithEvents Lbl_WarningLine2 As System.Windows.Forms.Label
End Class
