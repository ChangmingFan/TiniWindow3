Public Class ConfirmEnterMonitorMode

    Private Sub But_get_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_get.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()


    End Sub

    Private Sub But_send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_send.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub But_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        Me.Close()
    End Sub

    Private Sub ConfirmEnterMonitorMode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim screenRectangle As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea
        Dim screenHeight As Int32 = screenRectangle.Height
        Dim screenWidth As Int32 = screenRectangle.Width

        If Form1.Location.X < screenWidth / 2 Then
            'place open comport form to left of TiniWindow

            Me.Location = New System.Drawing.Point(Form1.Location.X + Form1.Width + 20, 20)
        Else
            'place to right of TiniWindow
            Me.Location = New System.Drawing.Point(Form1.Location.X - Me.Width - 20, 20)
        End If



        'Form1.TB_beginners_help.Clear()
        Form1.appendrichtext("Before entering monitor mode, the data on the sign and on the computer must match" + Constants.vbCrLf, 12, FontStyle.Bold)
        Form1.appendrichtext(Constants.vbCrLf + "If you select 'Get data from sign', The data in the sign will be retreived and the data currently displayed on your computer will be discarded" + Constants.vbCrLf, 9)
        Form1.appendrichtext(Constants.vbCrLf + "If you select 'Send data to sign', The data currently displayed on your computer will be sent to the sign and the data currently in the sign will be discarded" + Constants.vbCrLf, 9)

        Form1.appendrichtext(Constants.vbCrLf + "To do neither of the above and stay in edit mode, select 'Cancel'" + Constants.vbCrLf, 9)

    End Sub
End Class