Public Class Remote_sign_advanced_config

    Public Working_sign As RemoteSignsForm.remoteSign



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_OK.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Remote_sign_advanced_config_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            If Working_sign.arrIP_list Is Nothing Then
                'check default box
                Chk_IP.Checked = True
            Else
                'place value in textbox
                Txt_IP.Text = Working_sign.arrIP_list
            End If


            If Working_sign.directory = "" Then
                'check default box
                Chk_Directory.Checked = True
            Else
                'place value in textbox
                Txt_Directory.Text = Working_sign.directory
            End If


            If Working_sign.datafilename = "" Then
                'check default box
                Chk_DataFile.Checked = True
            Else
                'place value in textbox
                Txt_DataFile.Text = Working_sign.datafilename
            End If

        End If
    End Sub

    Private Sub Chk_IP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_IP.CheckedChanged
        If Chk_IP.Checked = True Then
            ' erase data from the ram
            Working_sign.arrIP_list = Nothing
            ' disable the text box
            Txt_IP.Enabled = False
        Else
            Txt_IP.Enabled = True
        End If
    End Sub

    Private Sub Chk_Directory_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Directory.CheckedChanged
        If Chk_Directory.Checked = True Then
            ' erase data from the ram
            Working_sign.directory = ""
            ' disable the directoryx
            Txt_Directory.Enabled = False
        Else
            Txt_Directory.Enabled = True
        End If
    End Sub

    Private Sub Chk_DataFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_DataFile.CheckedChanged
        If Chk_DataFile.Checked = True Then
            ' erase data from the ram
            Working_sign.datafilename = ""
            ' disable the datafilename
            Txt_DataFile.Enabled = False
        Else
            Txt_DataFile.Enabled = True
        End If
    End Sub

    Private Sub Txt_IP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_IP.TextChanged
        Working_sign.ip = Txt_IP.Text
    End Sub

    Private Sub Txt_Directory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Directory.TextChanged
        Working_sign.directory = Txt_Directory.Text
    End Sub

    Private Sub Txt_DataFile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_DataFile.TextChanged
        Working_sign.datafilename = Txt_DataFile.Text
    End Sub

    Private Sub But_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub Remote_sign_advanced_config_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class





'Shared default_ip As String = "184.168.86.30"
'Shared default_directory As String = "dat"
'Dim signname As String
'Dim username As String
'Dim password As String
'Dim ip As String
'Dim directory As String
'Dim datafilename As String