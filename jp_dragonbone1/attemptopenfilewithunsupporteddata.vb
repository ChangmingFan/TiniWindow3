Public Class attemptopenfilewithunsupporteddata
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim message As String = "You WILL NOT be able to edit display patterns" + Constants.vbCrLf + Constants.vbCrLf
        'message += "You WILL NOT be able to edit display patterns" + Constants.vbCrLf
        message += "You will be able to edit all ten lines of words" + Constants.vbCrLf
        message += "You will be able to save your changes to the file" + Constants.vbCrLf
        message += "You will be send the file(including unsupported display patterns) to the sign" + Constants.vbCrLf
        MsgBox(message)
    End Sub
    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim message As String = "In the future we will impliment the ability to purchase and download an adhansed version" + Constants.vbCrLf
        message += "For now please contact your vendor"
        MsgBox(message)

    End Sub

    Private Sub But_import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_import.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub But_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_open.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub But_change_file_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_change_file.Click
        Me.DialogResult = Windows.Forms.DialogResult.Retry
        Me.Close()
    End Sub

    Private Sub But_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class