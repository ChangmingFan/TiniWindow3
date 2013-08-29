Public Class Remote_sign_advanced_config

    Public Working_sign As RemoteSignsForm.remoteSign

    Private Sub Button_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_OK.Click
        If Not arrIP_list_validate() Then
            MsgBox("Please correct the error !")
            Return
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    'Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    'End Sub

    Private Sub Remote_sign_advanced_config_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            If Working_sign.arrIP_list Is Nothing Then
                'check default box
                Txt_IP4.Text = ""
                Txt_IP3.Text = ""
                Txt_IP2.Text = ""
                Txt_IP1.Text = ""
                Txt_IP0.Text = ""
                Chk_IP.Checked = True
            Else
                Chk_IP.Checked = False
                If Working_sign.arrIP_list.Length > 5 Then
                    MsgBox("Warning only 5 IPs")
                End If

                If Working_sign.arrIP_list.Length >= 5 Then
                    Txt_IP4.Text = Working_sign.arrIP_list(4)
                End If
                If Working_sign.arrIP_list.Length >= 4 Then
                    Txt_IP3.Text = Working_sign.arrIP_list(3)
                End If
                If Working_sign.arrIP_list.Length >= 3 Then
                    Txt_IP2.Text = Working_sign.arrIP_list(2)
                End If
                If Working_sign.arrIP_list.Length >= 2 Then
                    Txt_IP1.Text = Working_sign.arrIP_list(1)
                End If
                If Working_sign.arrIP_list.Length >= 1 Then
                    Txt_IP0.Text = Working_sign.arrIP_list(0)
                End If
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
            Txt_IP0.Enabled = False
            Txt_IP1.Enabled = False
            Txt_IP2.Enabled = False
            Txt_IP3.Enabled = False
            Txt_IP4.Enabled = False
        Else
            Txt_IP0.Enabled = True
            Txt_IP1.Enabled = True
            Txt_IP2.Enabled = True
            Txt_IP3.Enabled = True
            Txt_IP4.Enabled = True
            validateandadd()
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
            Working_sign.directory = Txt_Directory.Text
        End If
    End Sub

    Private Sub Chk_DataFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_DataFile.CheckedChanged
        If Chk_DataFile.Checked = True Then
            ' erase data from the ram
            Working_sign.datafilename = ""
            ' disable the datafilename
            Txt_DataFile.Enabled = False
        Else
            Working_sign.datafilename = Txt_DataFile.Text
            Txt_DataFile.Enabled = True
        End If
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

    Function valid_IP(ByVal IP As String) As Boolean
        Dim arr_IP_Txt_split() As String = IP.Split(".")
        If IP = "" Then
            Return True
        End If

        If arr_IP_Txt_split.Length <> 4 Then
            Beep()
            Return False
        End If
        If (arr_IP_Txt_split(0).Length = 0 Or arr_IP_Txt_split(0).Length > 3) Then
            Return False
        End If
        If (arr_IP_Txt_split(1).Length = 0 Or arr_IP_Txt_split(1).Length > 3) Then
            Return False
        End If
        If (arr_IP_Txt_split(2).Length = 0 Or arr_IP_Txt_split(2).Length > 3) Then
            Return False
        End If
        If (arr_IP_Txt_split(3).Length = 0 Or arr_IP_Txt_split(3).Length > 3) Then
            Return False
        End If
        'if it doesnt fail any test, it must be valid
        Return True
    End Function

    'Function for validtare IP list

    Function arrIP_list_validate() As Boolean
        'test txt of IPs

        Dim returnvalue As Boolean = True 'assume all valid unless one of more fails test

        If Not valid_IP(Txt_IP0.Text) Then
            Txt_IP0.ForeColor = Color.Red
            returnvalue = False
        Else
            Txt_IP0.ForeColor = Color.Black
        End If

        If Not valid_IP(Txt_IP1.Text) Then
            Txt_IP1.ForeColor = Color.Red
            returnvalue = False
        Else
            Txt_IP1.ForeColor = Color.Black
        End If
        If Not valid_IP(Txt_IP2.Text) Then
            Txt_IP2.ForeColor = Color.Red
            returnvalue = False
        Else
            Txt_IP2.ForeColor = Color.Black
        End If

        If Not valid_IP(Txt_IP3.Text) Then
            Txt_IP3.ForeColor = Color.Red
            returnvalue = False
        Else
            Txt_IP3.ForeColor = Color.Black
        End If

        Return returnvalue

    End Function

    Sub validateandadd()
        If arrIP_list_validate() Then
            Dim array_size As Int16 = 0
            If Txt_IP0.Text <> "" Then
                array_size += 1
            End If
            If Txt_IP1.Text <> "" Then
                array_size += 1
            End If
            If Txt_IP2.Text <> "" Then
                array_size += 1
            End If
            If Txt_IP3.Text <> "" Then
                array_size += 1
            End If



            If array_size = 0 Then
                Working_sign.arrIP_list = Nothing
                Return
            End If


            Dim temp_ip_list(array_size - 1) As String
            Dim i As Int16 = 0
            If Txt_IP0.Text <> "" Then
                temp_ip_list(i) = Txt_IP0.Text
                i += 1
            End If
            If Txt_IP1.Text <> "" Then
                temp_ip_list(i) = Txt_IP1.Text
                i += 1
            End If
            If Txt_IP2.Text <> "" Then
                temp_ip_list(i) = Txt_IP2.Text
                i += 1
            End If
            If Txt_IP3.Text <> "" Then
                temp_ip_list(i) = Txt_IP3.Text
                i += 1
            End If

            Working_sign.arrIP_list = temp_ip_list
        Else

            Beep()

        End If

    End Sub

    Private Sub Txt_IP_common_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_IP4.Leave, Txt_IP3.Leave, Txt_IP2.Leave, Txt_IP1.Leave, Txt_IP0.Leave
        validateandadd()
    End Sub

    Private Sub Txt_IP_common_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_IP4.KeyPress, Txt_IP3.KeyPress, Txt_IP2.KeyPress, Txt_IP1.KeyPress, Txt_IP0.KeyPress
        'MsgBox(Asc(e.KeyChar))

        Dim BACK_SPACE As Char = Chr(8)
        Dim CONTROL_A As Char = Chr(1)
        Dim CONTROL_C As Char = Chr(3)
        'we do not yet support CONTROl_V because pasting is more difficult to ensure valid values

        If e.KeyChar = "." Or e.KeyChar = BACK_SPACE Or e.KeyChar = CONTROL_A Or e.KeyChar = CONTROL_C Then
            'these special non-digit character are allowed
            Return
        End If

        If e.KeyChar < "0" Or e.KeyChar > "9" Then
            'reach here if characters are not digits
            Beep()
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_IP_common_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_IP4.Enter, Txt_IP3.Enter, Txt_IP2.Enter, Txt_IP1.Enter, Txt_IP0.Enter
        sender.ForeColor = Color.Black
    End Sub

    Private Sub Txt_IP_common_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_IP4.EnabledChanged, Txt_IP3.EnabledChanged, Txt_IP2.EnabledChanged, Txt_IP1.EnabledChanged, Txt_IP0.EnabledChanged
        If sender.Enabled Then
            sender.BackColor = Color.White
        Else
            sender.BackColor = Me.BackColor
        End If
    End Sub
End Class

