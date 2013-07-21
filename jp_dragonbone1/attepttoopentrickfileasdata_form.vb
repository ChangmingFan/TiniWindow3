Public Class attepttoopentrickfileasdata_form

    
    Private Sub But_import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_import.Click
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

    Private Sub But_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_open.Click
        Me.DialogResult = Windows.Forms.DialogResult.Ignore
        Me.Close()

    End Sub

    Private Sub attepttoopentrickfileasdata_form_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (CB_alwaysdo.Checked) Then
            If Me.DialogResult = Windows.Forms.DialogResult.Yes Then
                Form1.settings(Form1.settingsindex.opentrickfileaction) = Form1.opentrickfileaction_value.import
            ElseIf Me.DialogResult = Windows.Forms.DialogResult.Retry Then
                Form1.settings(Form1.settingsindex.opentrickfileaction) = Form1.opentrickfileaction_value.pickanotherfile

            ElseIf Me.DialogResult = Windows.Forms.DialogResult.Cancel Then
                Form1.settings(Form1.settingsindex.opentrickfileaction) = Form1.opentrickfileaction_value.cancel
            ElseIf Me.DialogResult = Windows.Forms.DialogResult.Ignore Then
                Form1.settings(Form1.settingsindex.opentrickfileaction) = Form1.opentrickfileaction_value.openasdatafile
            End If
        Else
            Form1.settings(Form1.settingsindex.opentrickfileaction) = Form1.opentrickfileaction_value.showdialog
        End If

    End Sub
End Class