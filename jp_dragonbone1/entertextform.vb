Public Class entertextform


    Public Property input() As String
        Get
            Return TextBox1.Text
        End Get
        Set(ByVal value As String)
            TextBox1.Text = value
        End Set
    End Property
    Public Property prompt() As String
        Get
            Return Lbl_prompt.Text

        End Get
        Set(ByVal value As String)
            Lbl_prompt.Text = value
            Me.Text = value
        End Set
    End Property


    Private Sub But_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_ok.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub But_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class