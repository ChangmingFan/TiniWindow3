Public Class enter_name_form

    Public username As String
    Private Sub But_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_ok.Click
        username = TB_username.Text
        Me.DialogResult() = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub But_latter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_latter.Click
        Me.DialogResult() = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub But_dont_ask_again_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_dont_ask_again.Click
        Me.DialogResult() = Windows.Forms.DialogResult.Abort
        Me.Close()
    End Sub

    Private Sub But_why_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_why.Click
        Dim message As String = "We ask you name so that we can greet you by name on the welcome page"
        MsgBox(message)
    End Sub
End Class