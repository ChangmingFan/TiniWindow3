Public Class tricks_disabled_form

    Private Sub tricks_disabled_form_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.Width >= 519 Then
            Txt_message.Height = 50
        ElseIf Me.Width >= 426 Then
            Txt_message.Height = 58

        ElseIf Me.Width >= 273 Then
            Txt_message.Height = 71

        ElseIf Me.Width < 273 Then
            Me.Width = 273
            Txt_message.Height = 71
        End If

        If Me.Height < 156 Then
            Me.Height = 156
        End If
    End Sub

    
    Private Sub But_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_ok.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()


    End Sub

    Private Sub But_discard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_discard.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub
End Class