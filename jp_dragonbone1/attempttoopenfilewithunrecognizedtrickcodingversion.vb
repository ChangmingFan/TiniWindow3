Public Class attempttoopenfilewithunrecognizedtrickcodingversion

    Private Sub attempttoopenfilewithunrecognizedtrickcodingversion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    

   

    

    Private Sub But_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    '''
    Private Sub But_change_file_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_change_file.Click
        Me.DialogResult = Windows.Forms.DialogResult.Retry
        Me.Close()
    End Sub
    Private Sub button_open_and_discard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_open_and_discard.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub But_open_with_restrictions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_open_with_restrictions.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim message As String = "You WILL NOT be able to edit display patterns" + Constants.vbCrLf
        message += "You WILL NOT be able send the file to the sign" + Constants.vbCrLf + Constants.vbCrLf

        message += "You will be able to edit all ten lines of words" + Constants.vbCrLf
        message += "You will be able to save your changes to the file" + Constants.vbCrLf

        MsgBox(message)
    End Sub
End Class