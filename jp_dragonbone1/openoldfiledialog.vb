Public Class openoldfiledialog

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Dim prompt As String = ""
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If prompt = "" Then
            prompt = TextBox1.Text
        Else
            TextBox1.Text = prompt
        End If
    End Sub

    'Private Sub openoldfiledialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    prompt = TextBox1.Text
    'End Sub
End Class