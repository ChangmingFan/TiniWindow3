Public Class welcome_form

    Dim default_welcome_Text As String = "This is your TinWindow. It allows you to interface with TiniLite products and other networks for display, communication, and a lot more." + Constants.vbCrLf + "version " + Form1.TiniWindowVersion_display_string.ToString
    Private Sub welcome_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TimerCloseForm.Start()
        Dim screenRectangle As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea
        Dim screenHeight As Int32 = screenRectangle.Height
        Dim screenWidth As Int32 = screenRectangle.Width

        Me.Location = New System.Drawing.Point(15, screenHeight - Me.Height)
        If (Form1.userdata(Form1.userdataindex.name) = "" And Form1.settings(Form1.settingsindex.askforname) <> False) Then
            Dim myenternameform As enter_name_form = New enter_name_form()
            myenternameform.ShowDialog()
            If (myenternameform.DialogResult() = Windows.Forms.DialogResult.OK) Then
                Form1.userdata(Form1.userdataindex.name) = myenternameform.username

                'MsgBox(TBwelcome.Text)

            Else
                'TBwelcome.Text = "welcome"
                If (myenternameform.DialogResult() = Windows.Forms.DialogResult.Abort) Then
                    Form1.settings(Form1.settingsindex.askforname) = False
                End If

            End If

        Else
            TBwelcome.Text = TBwelcome.Text
        End If
        'Me.Text = labletext
        'men_file.Enabled = True
        'Me.Text = labletext + " : "
        'footertext(0) = "You are in welcome mode"


        TBwelcome.Text = "Welcome!" + Constants.vbCrLf + Form1.userdata(Form1.userdataindex.name) + Constants.vbCrLf + default_welcome_Text
        'Pan_edit_and_monitor.Visible = False
        'Pan_welcome.Visible = True
        'Pan_tricks.Visible = False
        'Pan_tb.Visible = False
        'Pan_monitor_active_string.Visible = False
        'CB_live_edit.Visible = False
        'monitormode = False

        'men_read_device.Enabled = True
        'men_write_device.Enabled = False
        'men_save.Enabled = False
        'men_saveas.Enabled = False
        'men_open.Enabled = True
        'men_new.Enabled = True
        'TBwelcome.Text = "Hi " + Form1.userdata(Form1.userdataindex.name) + Constants.vbCrLf + TBwelcome.Text
    End Sub

    

    Private Sub welcome_form_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.settings(Form1.settingsindex.showwelcomeform) = Not CB_dontshow.Checked
    End Sub

    Private Sub But_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_close.Click
        Me.Close()
    End Sub

    Private Sub TimerCloseForm_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCloseForm.Tick
        TimerCloseForm.Stop()
        Me.Close()
    End Sub
End Class