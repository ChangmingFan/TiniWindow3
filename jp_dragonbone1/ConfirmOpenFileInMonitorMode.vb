Public Class ConfirmOpenFileInMonitorMode

    Private Sub But_replace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_replace.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()


    End Sub

    Private Sub But_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_exit.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub But_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ConfirmOpenFileInMonitorMode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    End Sub
End Class