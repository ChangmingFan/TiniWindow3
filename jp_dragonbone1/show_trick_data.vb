Public Class show_trick_data

    Private Sub _refresh()
        TextBox1.Text = ""

        Dim loopcounter As Int16 = 0

        While loopcounter < Form1.trickdata.Count
            TextBox1.Text += Form1.trickdata(loopcounter).ToString + Constants.vbCrLf

            loopcounter += 1
        End While
    End Sub
    Private Sub show_trick_data_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _refresh()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _refresh()
    End Sub
End Class