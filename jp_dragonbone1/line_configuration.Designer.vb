<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class line_configuration
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
        Me.Pan_charsRB = New System.Windows.Forms.Panel
        Me.RB_chars_end = New System.Windows.Forms.RadioButton
        Me.RB_chars_beg = New System.Windows.Forms.RadioButton
        Me.Num_linelength = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.CB_preservesimpletab = New System.Windows.Forms.CheckBox
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Pan_charsRB.SuspendLayout()
        CType(Me.Num_linelength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pan_charsRB
        '
        Me.Pan_charsRB.Controls.Add(Me.RB_chars_end)
        Me.Pan_charsRB.Controls.Add(Me.RB_chars_beg)
        Me.Pan_charsRB.Location = New System.Drawing.Point(9, 141)
        Me.Pan_charsRB.Name = "Pan_charsRB"
        Me.Pan_charsRB.Size = New System.Drawing.Size(210, 49)
        Me.Pan_charsRB.TabIndex = 5
        Me.Pan_charsRB.Visible = False
        '
        'RB_chars_end
        '
        Me.RB_chars_end.AutoSize = True
        Me.RB_chars_end.Checked = True
        Me.RB_chars_end.Location = New System.Drawing.Point(6, 25)
        Me.RB_chars_end.Name = "RB_chars_end"
        Me.RB_chars_end.Size = New System.Drawing.Size(143, 17)
        Me.RB_chars_end.TabIndex = 1
        Me.RB_chars_end.TabStop = True
        Me.RB_chars_end.Text = "Truncate letters from end"
        Me.RB_chars_end.UseVisualStyleBackColor = True
        '
        'RB_chars_beg
        '
        Me.RB_chars_beg.AutoSize = True
        Me.RB_chars_beg.Location = New System.Drawing.Point(6, 4)
        Me.RB_chars_beg.Name = "RB_chars_beg"
        Me.RB_chars_beg.Size = New System.Drawing.Size(175, 17)
        Me.RB_chars_beg.TabIndex = 0
        Me.RB_chars_beg.TabStop = True
        Me.RB_chars_beg.Text = "Truncate letters from Beginning "
        Me.RB_chars_beg.UseVisualStyleBackColor = True
        '
        'Num_linelength
        '
        Me.Num_linelength.Location = New System.Drawing.Point(69, 111)
        Me.Num_linelength.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Num_linelength.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.Num_linelength.Name = "Num_linelength"
        Me.Num_linelength.Size = New System.Drawing.Size(42, 20)
        Me.Num_linelength.TabIndex = 4
        Me.Num_linelength.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "size of sign"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(124, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "letters"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(107, 242)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CB_preservesimpletab
        '
        Me.CB_preservesimpletab.AutoSize = True
        Me.CB_preservesimpletab.Location = New System.Drawing.Point(11, 193)
        Me.CB_preservesimpletab.Name = "CB_preservesimpletab"
        Me.CB_preservesimpletab.Size = New System.Drawing.Size(232, 43)
        Me.CB_preservesimpletab.TabIndex = 2
        Me.CB_preservesimpletab.Text = "Preseve ability to edit file in clasic-basic tab " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(If checked,  Number of lines " & _
            "can only" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "be auto adjusted) "
        Me.CB_preservesimpletab.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(91, 10)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(42, 20)
        Me.NumericUpDown1.TabIndex = 10
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Number of signs"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"DNA ", "Top to Bottom", "Side by side"})
        Me.ComboBox1.Location = New System.Drawing.Point(135, 60)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Arrangement of signs"
        '
        'line_configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 288)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CB_preservesimpletab)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Pan_charsRB)
        Me.Controls.Add(Me.Num_linelength)
        Me.Controls.Add(Me.Label2)
        Me.Name = "line_configuration"
        Me.Text = "line configuration"
        Me.Pan_charsRB.ResumeLayout(False)
        Me.Pan_charsRB.PerformLayout()
        CType(Me.Num_linelength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pan_charsRB As System.Windows.Forms.Panel
    Friend WithEvents RB_chars_end As System.Windows.Forms.RadioButton
    Friend WithEvents RB_chars_beg As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CB_preservesimpletab As System.Windows.Forms.CheckBox
    Public WithEvents Num_linelength As System.Windows.Forms.NumericUpDown
    Public WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
