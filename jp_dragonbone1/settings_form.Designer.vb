<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings_form
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Tab_userdata = New System.Windows.Forms.TabPage
        Me.CB_donotkeepuserdata = New System.Windows.Forms.CheckBox
        Me.But_why = New System.Windows.Forms.Button
        Me.Lbl_name = New System.Windows.Forms.Label
        Me.CB_donotaskforname = New System.Windows.Forms.CheckBox
        Me.TB_username = New System.Windows.Forms.TextBox
        Me.Tab_fileoptions = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.RB_showdialog_opentoomanychars = New System.Windows.Forms.RadioButton
        Me.RB_cancelopentoomanychars = New System.Windows.Forms.RadioButton
        Me.RB_truncate = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.RB_showdialog_opentrickfile = New System.Windows.Forms.RadioButton
        Me.RB_importtricks = New System.Windows.Forms.RadioButton
        Me.RB_cancel_opentrickfile = New System.Windows.Forms.RadioButton
        Me.RB_openasdatafile = New System.Windows.Forms.RadioButton
        Me.RB_openanotherfile = New System.Windows.Forms.RadioButton
        Me.TB_trickfileextentions = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TB_datafileextentions = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Tab_misc = New System.Windows.Forms.TabPage
        Me.CB_showwelcome = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.But_discardchanges = New System.Windows.Forms.Button
        Me.But_applychanges = New System.Windows.Forms.Button
        Me.But_cancel = New System.Windows.Forms.Button
        Me.But_change_userdata = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.But_browse = New System.Windows.Forms.Button
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.TabControl1.SuspendLayout()
        Me.Tab_userdata.SuspendLayout()
        Me.Tab_fileoptions.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Tab_misc.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tab_userdata)
        Me.TabControl1.Controls.Add(Me.Tab_fileoptions)
        Me.TabControl1.Controls.Add(Me.Tab_misc)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(356, 354)
        Me.TabControl1.TabIndex = 0
        '
        'Tab_userdata
        '
        Me.Tab_userdata.Controls.Add(Me.CB_donotkeepuserdata)
        Me.Tab_userdata.Controls.Add(Me.But_why)
        Me.Tab_userdata.Controls.Add(Me.Lbl_name)
        Me.Tab_userdata.Controls.Add(Me.CB_donotaskforname)
        Me.Tab_userdata.Controls.Add(Me.TB_username)
        Me.Tab_userdata.Location = New System.Drawing.Point(4, 22)
        Me.Tab_userdata.Name = "Tab_userdata"
        Me.Tab_userdata.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_userdata.Size = New System.Drawing.Size(348, 304)
        Me.Tab_userdata.TabIndex = 0
        Me.Tab_userdata.Text = "User Data"
        Me.Tab_userdata.UseVisualStyleBackColor = True
        '
        'CB_donotkeepuserdata
        '
        Me.CB_donotkeepuserdata.AutoSize = True
        Me.CB_donotkeepuserdata.Location = New System.Drawing.Point(34, 134)
        Me.CB_donotkeepuserdata.Name = "CB_donotkeepuserdata"
        Me.CB_donotkeepuserdata.Size = New System.Drawing.Size(152, 17)
        Me.CB_donotkeepuserdata.TabIndex = 23
        Me.CB_donotkeepuserdata.Text = "Do not keep any user data"
        Me.CB_donotkeepuserdata.UseVisualStyleBackColor = True
        Me.CB_donotkeepuserdata.Visible = False
        '
        'But_why
        '
        Me.But_why.Location = New System.Drawing.Point(188, 72)
        Me.But_why.Name = "But_why"
        Me.But_why.Size = New System.Drawing.Size(75, 23)
        Me.But_why.TabIndex = 22
        Me.But_why.Text = "Why we ask"
        Me.But_why.UseVisualStyleBackColor = True
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_name.Location = New System.Drawing.Point(287, 37)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(41, 15)
        Me.Lbl_name.TabIndex = 18
        Me.Lbl_name.Text = "Name"
        '
        'CB_donotaskforname
        '
        Me.CB_donotaskforname.AutoSize = True
        Me.CB_donotaskforname.Location = New System.Drawing.Point(34, 119)
        Me.CB_donotaskforname.Name = "CB_donotaskforname"
        Me.CB_donotaskforname.Size = New System.Drawing.Size(220, 17)
        Me.CB_donotaskforname.TabIndex = 21
        Me.CB_donotaskforname.Text = "Do not prompt me to enter my name latter"
        Me.CB_donotaskforname.UseVisualStyleBackColor = True
        Me.CB_donotaskforname.Visible = False
        '
        'TB_username
        '
        Me.TB_username.Location = New System.Drawing.Point(26, 37)
        Me.TB_username.Name = "TB_username"
        Me.TB_username.Size = New System.Drawing.Size(251, 20)
        Me.TB_username.TabIndex = 19
        '
        'Tab_fileoptions
        '
        Me.Tab_fileoptions.Controls.Add(Me.But_browse)
        Me.Tab_fileoptions.Controls.Add(Me.TextBox1)
        Me.Tab_fileoptions.Controls.Add(Me.Label6)
        Me.Tab_fileoptions.Controls.Add(Me.Panel2)
        Me.Tab_fileoptions.Controls.Add(Me.Label5)
        Me.Tab_fileoptions.Controls.Add(Me.Panel1)
        Me.Tab_fileoptions.Controls.Add(Me.TB_trickfileextentions)
        Me.Tab_fileoptions.Controls.Add(Me.Label2)
        Me.Tab_fileoptions.Controls.Add(Me.TB_datafileextentions)
        Me.Tab_fileoptions.Controls.Add(Me.Label1)
        Me.Tab_fileoptions.Location = New System.Drawing.Point(4, 22)
        Me.Tab_fileoptions.Name = "Tab_fileoptions"
        Me.Tab_fileoptions.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_fileoptions.Size = New System.Drawing.Size(348, 328)
        Me.Tab_fileoptions.TabIndex = 1
        Me.Tab_fileoptions.Text = "File Options"
        Me.Tab_fileoptions.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RB_showdialog_opentoomanychars)
        Me.Panel2.Controls.Add(Me.RB_cancelopentoomanychars)
        Me.Panel2.Controls.Add(Me.RB_truncate)
        Me.Panel2.Location = New System.Drawing.Point(33, 279)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(296, 92)
        Me.Panel2.TabIndex = 12
        '
        'RB_showdialog_opentoomanychars
        '
        Me.RB_showdialog_opentoomanychars.AutoSize = True
        Me.RB_showdialog_opentoomanychars.Location = New System.Drawing.Point(128, 23)
        Me.RB_showdialog_opentoomanychars.Name = "RB_showdialog_opentoomanychars"
        Me.RB_showdialog_opentoomanychars.Size = New System.Drawing.Size(113, 17)
        Me.RB_showdialog_opentoomanychars.TabIndex = 2
        Me.RB_showdialog_opentoomanychars.TabStop = True
        Me.RB_showdialog_opentoomanychars.Text = "Ask me what to do"
        Me.RB_showdialog_opentoomanychars.UseVisualStyleBackColor = True
        '
        'RB_cancelopentoomanychars
        '
        Me.RB_cancelopentoomanychars.AutoSize = True
        Me.RB_cancelopentoomanychars.Location = New System.Drawing.Point(7, 23)
        Me.RB_cancelopentoomanychars.Name = "RB_cancelopentoomanychars"
        Me.RB_cancelopentoomanychars.Size = New System.Drawing.Size(57, 17)
        Me.RB_cancelopentoomanychars.TabIndex = 1
        Me.RB_cancelopentoomanychars.TabStop = True
        Me.RB_cancelopentoomanychars.Text = "cancel"
        Me.RB_cancelopentoomanychars.UseVisualStyleBackColor = True
        '
        'RB_truncate
        '
        Me.RB_truncate.AutoSize = True
        Me.RB_truncate.Location = New System.Drawing.Point(7, 3)
        Me.RB_truncate.Name = "RB_truncate"
        Me.RB_truncate.Size = New System.Drawing.Size(215, 17)
        Me.RB_truncate.TabIndex = 0
        Me.RB_truncate.TabStop = True
        Me.RB_truncate.Text = "Open and truncate additional characters"
        Me.RB_truncate.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(325, 26)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "When attempting to open a file with too many characters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(for instance 20 charact" & _
            "ers on a 6-character version of TiniWindow)"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.RB_showdialog_opentrickfile)
        Me.Panel1.Controls.Add(Me.RB_importtricks)
        Me.Panel1.Controls.Add(Me.RB_cancel_opentrickfile)
        Me.Panel1.Controls.Add(Me.RB_openasdatafile)
        Me.Panel1.Controls.Add(Me.RB_openanotherfile)
        Me.Panel1.Location = New System.Drawing.Point(33, 156)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 83)
        Me.Panel1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "When Attempting To ""Open"" A Display pattern file"
        '
        'RB_showdialog_opentrickfile
        '
        Me.RB_showdialog_opentrickfile.AutoSize = True
        Me.RB_showdialog_opentrickfile.Location = New System.Drawing.Point(12, 63)
        Me.RB_showdialog_opentrickfile.Name = "RB_showdialog_opentrickfile"
        Me.RB_showdialog_opentrickfile.Size = New System.Drawing.Size(113, 17)
        Me.RB_showdialog_opentrickfile.TabIndex = 9
        Me.RB_showdialog_opentrickfile.TabStop = True
        Me.RB_showdialog_opentrickfile.Text = "Ask me what to do"
        Me.RB_showdialog_opentrickfile.UseVisualStyleBackColor = True
        '
        'RB_importtricks
        '
        Me.RB_importtricks.AutoSize = True
        Me.RB_importtricks.Location = New System.Drawing.Point(12, 20)
        Me.RB_importtricks.Name = "RB_importtricks"
        Me.RB_importtricks.Size = New System.Drawing.Size(82, 17)
        Me.RB_importtricks.TabIndex = 5
        Me.RB_importtricks.TabStop = True
        Me.RB_importtricks.Text = "Import tricks"
        Me.RB_importtricks.UseVisualStyleBackColor = True
        '
        'RB_cancel_opentrickfile
        '
        Me.RB_cancel_opentrickfile.AutoSize = True
        Me.RB_cancel_opentrickfile.Location = New System.Drawing.Point(128, 42)
        Me.RB_cancel_opentrickfile.Name = "RB_cancel_opentrickfile"
        Me.RB_cancel_opentrickfile.Size = New System.Drawing.Size(58, 17)
        Me.RB_cancel_opentrickfile.TabIndex = 8
        Me.RB_cancel_opentrickfile.TabStop = True
        Me.RB_cancel_opentrickfile.Text = "Cancel"
        Me.RB_cancel_opentrickfile.UseVisualStyleBackColor = True
        '
        'RB_openasdatafile
        '
        Me.RB_openasdatafile.AutoSize = True
        Me.RB_openasdatafile.Location = New System.Drawing.Point(12, 41)
        Me.RB_openasdatafile.Name = "RB_openasdatafile"
        Me.RB_openasdatafile.Size = New System.Drawing.Size(110, 17)
        Me.RB_openasdatafile.TabIndex = 6
        Me.RB_openasdatafile.TabStop = True
        Me.RB_openasdatafile.Text = "Open as Data File"
        Me.RB_openasdatafile.UseVisualStyleBackColor = True
        '
        'RB_openanotherfile
        '
        Me.RB_openanotherfile.AutoSize = True
        Me.RB_openanotherfile.Location = New System.Drawing.Point(128, 19)
        Me.RB_openanotherfile.Name = "RB_openanotherfile"
        Me.RB_openanotherfile.Size = New System.Drawing.Size(150, 17)
        Me.RB_openanotherfile.TabIndex = 7
        Me.RB_openanotherfile.TabStop = True
        Me.RB_openanotherfile.Text = "Pick Another File To Open"
        Me.RB_openanotherfile.UseVisualStyleBackColor = True
        '
        'TB_trickfileextentions
        '
        Me.TB_trickfileextentions.Location = New System.Drawing.Point(35, 84)
        Me.TB_trickfileextentions.Name = "TB_trickfileextentions"
        Me.TB_trickfileextentions.Size = New System.Drawing.Size(220, 20)
        Me.TB_trickfileextentions.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Data File Extentions seperate by semicolons (';')" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ex:  '.trk; .trick;'"
        '
        'TB_datafileextentions
        '
        Me.TB_datafileextentions.Location = New System.Drawing.Point(37, 32)
        Me.TB_datafileextentions.Name = "TB_datafileextentions"
        Me.TB_datafileextentions.Size = New System.Drawing.Size(227, 20)
        Me.TB_datafileextentions.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data File Extentions seperate by semicolons (';')" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ex:  '.text; .txt; .dat; .bat;" & _
            "'"
        '
        'Tab_misc
        '
        Me.Tab_misc.Controls.Add(Me.CB_showwelcome)
        Me.Tab_misc.Controls.Add(Me.Label4)
        Me.Tab_misc.Location = New System.Drawing.Point(4, 22)
        Me.Tab_misc.Name = "Tab_misc"
        Me.Tab_misc.Size = New System.Drawing.Size(348, 304)
        Me.Tab_misc.TabIndex = 2
        Me.Tab_misc.Text = "Misc options"
        Me.Tab_misc.UseVisualStyleBackColor = True
        '
        'CB_showwelcome
        '
        Me.CB_showwelcome.AutoSize = True
        Me.CB_showwelcome.Location = New System.Drawing.Point(22, 93)
        Me.CB_showwelcome.Name = "CB_showwelcome"
        Me.CB_showwelcome.Size = New System.Drawing.Size(168, 17)
        Me.CB_showwelcome.TabIndex = 2
        Me.CB_showwelcome.Text = "Show welcome form at startup"
        Me.CB_showwelcome.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 0
        '
        'But_discardchanges
        '
        Me.But_discardchanges.Location = New System.Drawing.Point(180, 360)
        Me.But_discardchanges.Name = "But_discardchanges"
        Me.But_discardchanges.Size = New System.Drawing.Size(113, 23)
        Me.But_discardchanges.TabIndex = 30
        Me.But_discardchanges.Text = "Discard Changes"
        Me.But_discardchanges.UseVisualStyleBackColor = True
        '
        'But_applychanges
        '
        Me.But_applychanges.Location = New System.Drawing.Point(61, 360)
        Me.But_applychanges.Name = "But_applychanges"
        Me.But_applychanges.Size = New System.Drawing.Size(113, 23)
        Me.But_applychanges.TabIndex = 29
        Me.But_applychanges.Text = "Apply Changes"
        Me.But_applychanges.UseVisualStyleBackColor = True
        '
        'But_cancel
        '
        Me.But_cancel.Location = New System.Drawing.Point(180, 389)
        Me.But_cancel.Name = "But_cancel"
        Me.But_cancel.Size = New System.Drawing.Size(113, 23)
        Me.But_cancel.TabIndex = 28
        Me.But_cancel.Text = "Cancel"
        Me.But_cancel.UseVisualStyleBackColor = True
        '
        'But_change_userdata
        '
        Me.But_change_userdata.Location = New System.Drawing.Point(61, 389)
        Me.But_change_userdata.Name = "But_change_userdata"
        Me.But_change_userdata.Size = New System.Drawing.Size(113, 23)
        Me.But_change_userdata.TabIndex = 27
        Me.But_change_userdata.Text = "OK"
        Me.But_change_userdata.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(33, 128)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 20)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = "Functionality not implimented"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Default file "
        '
        'But_browse
        '
        Me.But_browse.Enabled = False
        Me.But_browse.Location = New System.Drawing.Point(259, 126)
        Me.But_browse.Name = "But_browse"
        Me.But_browse.Size = New System.Drawing.Size(75, 23)
        Me.But_browse.TabIndex = 15
        Me.But_browse.Text = "Browse"
        Me.But_browse.UseVisualStyleBackColor = True
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'settings_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 416)
        Me.ControlBox = False
        Me.Controls.Add(Me.But_discardchanges)
        Me.Controls.Add(Me.But_applychanges)
        Me.Controls.Add(Me.But_cancel)
        Me.Controls.Add(Me.But_change_userdata)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "settings_form"
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.Tab_userdata.ResumeLayout(False)
        Me.Tab_userdata.PerformLayout()
        Me.Tab_fileoptions.ResumeLayout(False)
        Me.Tab_fileoptions.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Tab_misc.ResumeLayout(False)
        Me.Tab_misc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Tab_userdata As System.Windows.Forms.TabPage
    Friend WithEvents Tab_fileoptions As System.Windows.Forms.TabPage
    Friend WithEvents Tab_misc As System.Windows.Forms.TabPage
    Friend WithEvents CB_donotkeepuserdata As System.Windows.Forms.CheckBox
    Friend WithEvents But_why As System.Windows.Forms.Button
    Friend WithEvents Lbl_name As System.Windows.Forms.Label
    Friend WithEvents CB_donotaskforname As System.Windows.Forms.CheckBox
    Friend WithEvents TB_username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_trickfileextentions As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_datafileextentions As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RB_cancel_opentrickfile As System.Windows.Forms.RadioButton
    Friend WithEvents RB_openanotherfile As System.Windows.Forms.RadioButton
    Friend WithEvents RB_openasdatafile As System.Windows.Forms.RadioButton
    Friend WithEvents RB_importtricks As System.Windows.Forms.RadioButton
    Friend WithEvents But_discardchanges As System.Windows.Forms.Button
    Friend WithEvents But_applychanges As System.Windows.Forms.Button
    Friend WithEvents But_cancel As System.Windows.Forms.Button
    Friend WithEvents But_change_userdata As System.Windows.Forms.Button
    Friend WithEvents RB_showdialog_opentrickfile As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CB_showwelcome As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RB_showdialog_opentoomanychars As System.Windows.Forms.RadioButton
    Friend WithEvents RB_cancelopentoomanychars As System.Windows.Forms.RadioButton
    Friend WithEvents RB_truncate As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents But_browse As System.Windows.Forms.Button
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
End Class
