<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Remote_sign_advanced_config
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
        Me.But_OK = New System.Windows.Forms.Button()
        Me.But_Cancel = New System.Windows.Forms.Button()
        Me.Txt_DataFile = New System.Windows.Forms.TextBox()
        Me.Txt_Directory = New System.Windows.Forms.TextBox()
        Me.Chk_IP = New System.Windows.Forms.CheckBox()
        Me.Chk_Directory = New System.Windows.Forms.CheckBox()
        Me.Chk_DataFile = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_IP0 = New System.Windows.Forms.TextBox()
        Me.Txt_IP1 = New System.Windows.Forms.TextBox()
        Me.Txt_IP2 = New System.Windows.Forms.TextBox()
        Me.Txt_IP3 = New System.Windows.Forms.TextBox()
        Me.Txt_IP4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'But_OK
        '
        Me.But_OK.BackColor = System.Drawing.Color.Lime
        Me.But_OK.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_OK.Location = New System.Drawing.Point(14, 243)
        Me.But_OK.Name = "But_OK"
        Me.But_OK.Size = New System.Drawing.Size(136, 23)
        Me.But_OK.TabIndex = 0
        Me.But_OK.Text = "OK"
        Me.But_OK.UseVisualStyleBackColor = False
        '
        'But_Cancel
        '
        Me.But_Cancel.BackColor = System.Drawing.Color.Red
        Me.But_Cancel.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Cancel.Location = New System.Drawing.Point(180, 243)
        Me.But_Cancel.Name = "But_Cancel"
        Me.But_Cancel.Size = New System.Drawing.Size(136, 23)
        Me.But_Cancel.TabIndex = 2
        Me.But_Cancel.Text = "Cancel"
        Me.But_Cancel.UseVisualStyleBackColor = False
        '
        'Txt_DataFile
        '
        Me.Txt_DataFile.Location = New System.Drawing.Point(14, 199)
        Me.Txt_DataFile.Name = "Txt_DataFile"
        Me.Txt_DataFile.Size = New System.Drawing.Size(131, 21)
        Me.Txt_DataFile.TabIndex = 4
        '
        'Txt_Directory
        '
        Me.Txt_Directory.Location = New System.Drawing.Point(14, 164)
        Me.Txt_Directory.Name = "Txt_Directory"
        Me.Txt_Directory.Size = New System.Drawing.Size(131, 21)
        Me.Txt_Directory.TabIndex = 5
        '
        'Chk_IP
        '
        Me.Chk_IP.AutoSize = True
        Me.Chk_IP.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_IP.Location = New System.Drawing.Point(260, 65)
        Me.Chk_IP.Name = "Chk_IP"
        Me.Chk_IP.Size = New System.Drawing.Size(64, 18)
        Me.Chk_IP.TabIndex = 6
        Me.Chk_IP.Text = "Default"
        Me.Chk_IP.UseVisualStyleBackColor = True
        '
        'Chk_Directory
        '
        Me.Chk_Directory.AutoSize = True
        Me.Chk_Directory.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Directory.Location = New System.Drawing.Point(260, 173)
        Me.Chk_Directory.Name = "Chk_Directory"
        Me.Chk_Directory.Size = New System.Drawing.Size(64, 18)
        Me.Chk_Directory.TabIndex = 7
        Me.Chk_Directory.Text = "Default"
        Me.Chk_Directory.UseVisualStyleBackColor = True
        '
        'Chk_DataFile
        '
        Me.Chk_DataFile.AutoSize = True
        Me.Chk_DataFile.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_DataFile.Location = New System.Drawing.Point(260, 204)
        Me.Chk_DataFile.Name = "Chk_DataFile"
        Me.Chk_DataFile.Size = New System.Drawing.Size(64, 18)
        Me.Chk_DataFile.TabIndex = 8
        Me.Chk_DataFile.Text = "Default"
        Me.Chk_DataFile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "I P  Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 14)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Data File Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(155, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 14)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Remote Directory"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(307, 14)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Uncheck the Default button  to enter custome value !"
        '
        'Txt_IP0
        '
        Me.Txt_IP0.BackColor = System.Drawing.Color.White
        Me.Txt_IP0.Enabled = False
        Me.Txt_IP0.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_IP0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_IP0.Location = New System.Drawing.Point(14, 37)
        Me.Txt_IP0.MaxLength = 50
        Me.Txt_IP0.Name = "Txt_IP0"
        Me.Txt_IP0.Size = New System.Drawing.Size(131, 21)
        Me.Txt_IP0.TabIndex = 14
        Me.Txt_IP0.Tag = "0"
        '
        'Txt_IP1
        '
        Me.Txt_IP1.BackColor = System.Drawing.Color.White
        Me.Txt_IP1.Enabled = False
        Me.Txt_IP1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_IP1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_IP1.Location = New System.Drawing.Point(14, 59)
        Me.Txt_IP1.MaxLength = 50
        Me.Txt_IP1.Name = "Txt_IP1"
        Me.Txt_IP1.Size = New System.Drawing.Size(132, 21)
        Me.Txt_IP1.TabIndex = 15
        Me.Txt_IP1.Tag = "1"
        '
        'Txt_IP2
        '
        Me.Txt_IP2.BackColor = System.Drawing.Color.White
        Me.Txt_IP2.Enabled = False
        Me.Txt_IP2.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_IP2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_IP2.Location = New System.Drawing.Point(14, 80)
        Me.Txt_IP2.MaxLength = 50
        Me.Txt_IP2.Name = "Txt_IP2"
        Me.Txt_IP2.Size = New System.Drawing.Size(132, 21)
        Me.Txt_IP2.TabIndex = 16
        Me.Txt_IP2.Tag = "2"
        '
        'Txt_IP3
        '
        Me.Txt_IP3.BackColor = System.Drawing.Color.White
        Me.Txt_IP3.Enabled = False
        Me.Txt_IP3.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_IP3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_IP3.Location = New System.Drawing.Point(14, 102)
        Me.Txt_IP3.MaxLength = 50
        Me.Txt_IP3.Name = "Txt_IP3"
        Me.Txt_IP3.Size = New System.Drawing.Size(132, 21)
        Me.Txt_IP3.TabIndex = 17
        Me.Txt_IP3.Tag = "3"
        '
        'Txt_IP4
        '
        Me.Txt_IP4.BackColor = System.Drawing.Color.White
        Me.Txt_IP4.Enabled = False
        Me.Txt_IP4.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_IP4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_IP4.Location = New System.Drawing.Point(14, 123)
        Me.Txt_IP4.MaxLength = 50
        Me.Txt_IP4.Name = "Txt_IP4"
        Me.Txt_IP4.Size = New System.Drawing.Size(132, 21)
        Me.Txt_IP4.TabIndex = 18
        Me.Txt_IP4.Tag = "4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 14)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "e.g.   111.111.111.111"
        '
        'Remote_sign_advanced_config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 283)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_IP0)
        Me.Controls.Add(Me.Txt_IP1)
        Me.Controls.Add(Me.Txt_IP2)
        Me.Controls.Add(Me.Txt_IP3)
        Me.Controls.Add(Me.Txt_IP4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chk_DataFile)
        Me.Controls.Add(Me.Chk_Directory)
        Me.Controls.Add(Me.Chk_IP)
        Me.Controls.Add(Me.Txt_Directory)
        Me.Controls.Add(Me.Txt_DataFile)
        Me.Controls.Add(Me.But_Cancel)
        Me.Controls.Add(Me.But_OK)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Remote_sign_advanced_config"
        Me.Text = "Remote_sign_advanced_config"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents But_OK As System.Windows.Forms.Button
    Friend WithEvents But_Cancel As System.Windows.Forms.Button
    Friend WithEvents Txt_DataFile As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Directory As System.Windows.Forms.TextBox
    Friend WithEvents Chk_IP As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Directory As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_DataFile As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_IP0 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_IP1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_IP2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_IP3 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_IP4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
