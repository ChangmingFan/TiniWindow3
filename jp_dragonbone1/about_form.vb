Public Class about_form

    Private Sub about_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblversion.Text = "Version " + Form1.TiniWindowVersion_display_string.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class