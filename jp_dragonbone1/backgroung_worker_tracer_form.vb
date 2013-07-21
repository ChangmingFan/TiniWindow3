Public Class backgroung_worker_tracer_form

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox1.Text = Form1.backgroundworkerdebugvalue
    End Sub

    Private Sub backgroung_worker_tracer_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        MsgBox("load")
    End Sub

    Private Sub backgroung_worker_tracer_form_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Timer1.Enabled = False
    End Sub
End Class