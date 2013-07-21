Public Class reestablish_communication_form

    Private Sub But_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Timer_attemptcom_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_attemptcom.Tick
        'temporarily removed while implementing class structure for connections
        'Try

        '    Dim dummystring As String = ""
        '    If (Form1.getversion(dummystring, dummystring)) Then


        '        Timer_attemptcom.Stop()
        '        Form1.hidemonitor_commerror()
        '        Me.DialogResult = Windows.Forms.DialogResult.OK
        '        If Form1.InMonitorMode Then
        '            Form1.Timer_pole_active_string.Start()
        '        End If
        '        Me.Close()
        '    End If
        'Catch ex As Exception

        'End Try
        
    End Sub

    'Private Sub But_changecomport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Timer_attemptcom.Stop()
    '    If (Form1.selectcomport()) Then
    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '        Me.Close()
    '    Else
    '        Timer_attemptcom.Start()

    '    End If

    'End Sub

    Private Sub reestablish_communication_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.Timer_pole_active_string.Stop()
    End Sub

    Private Sub reestablish_communication_form_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MsgBox("closing")
    End Sub
End Class