Public Class RemoteSignsForm
    Dim databeinginternallymanipulated = False
    Dim filename As String = "remoteSignlist.rsl"
    'format is
    '[start SIGNAME]
    'username:USERNAME
    'ip:IP
    '[end SIGNAME]

    'information not between start and end tag are ignored and may be used as notes
    Public Structure remoteSign
        Shared default_ip As String = "184.168.86.30"
        Dim signname As String
        Dim username As String
        Dim password As String
        Dim ip As String
        Dim datafilename As String
    End Structure

    Dim m_remoteSignList As ArrayList = New ArrayList
    Dim formloaded As Boolean = False
    Public ReadOnly Property remoteSignList As remoteSign()
        Get
            Dim returnvalue(m_remoteSignList.Count - 1) As remoteSign
            Dim i As Integer = 0
            For Each sign As remoteSign In m_remoteSignList
                returnvalue(i) = sign
                i += 1
            Next

            Return returnvalue

        End Get
    End Property

    Private Sub savefile(fname)
        Dim SW As IO.StreamWriter = IO.File.CreateText(fname)
        For Each this_sign As remoteSign In m_remoteSignList
            SW.Write("[start " & this_sign.signname & "]" & Constants.vbCrLf)
            If this_sign.signname <> "" Then
                SW.Write("username:" & this_sign.username & Constants.vbCrLf)
            End If
            If this_sign.password <> "" Then
                SW.Write("password:" & this_sign.password & Constants.vbCrLf)
            End If
            If this_sign.ip <> "" Then
                SW.Write("ip:" & this_sign.ip & Constants.vbCrLf)
            End If
            If this_sign.datafilename <> "" Then
                SW.Write("datafilename:" & this_sign.datafilename & Constants.vbCrLf)
            End If
            SW.Write("[end " & this_sign.signname & "]" & Constants.vbCrLf)
        Next

        SW.Close()
    End Sub

    Private Sub loadfile(ByVal fname As String)
        databeinginternallymanipulated = True
        If (IO.File.Exists(fname)) Then
            m_remoteSignList.Clear()

            Dim SR As IO.StreamReader = IO.File.OpenText(fname)
            Dim filetext As String = ""

            filetext = SR.ReadToEnd

            'Dim this_dataname As String = ""
            Dim this_signsdata As String = ""
            'Dim this_dataindex As Integer


            While (filetext.IndexOf("]") >= 0)
                Dim this_remoteSign As remoteSign = New remoteSign

                Try 'catches bad substring calls resulting from '[' and ']' being in wrong order

                    'get the name of the sign
                    'temporarily has 'start' proceeding sign name
                    this_remoteSign.signname = filetext.Substring(filetext.IndexOf("[") + 1, filetext.IndexOf("]") - filetext.IndexOf("[") - 1).Trim()
                    If (this_remoteSign.signname.Substring(0, 5).ToLower <> "start") Then
                        'ignore this supposed opening sign bracket because in wrong format
                        'truncate the portion of the file that is being ignored
                        filetext = filetext.Substring(filetext.IndexOf("]") + 1)
                        Continue While
                    End If

                    'remove the word "start" from proceeding the sign name
                    this_remoteSign.signname = this_remoteSign.signname.Substring(5).Trim

                    'truncate the portion of the file that has been processed
                    filetext = filetext.Substring(filetext.IndexOf("]") + 1)

                    'if the data is in the correct format these few lines will place several lines of data 
                    'into string this_signsdata 
                    'otherwise an exception is raised from bad substring calls
                    Dim endtag As String = "[end " + this_remoteSign.signname + "]"
                    Dim endtagindex As Integer = filetext.IndexOf(endtag)
                    this_signsdata = filetext.Substring(0, endtagindex)

                    'remove this signs data from the sign buffer 
                    filetext = filetext.Substring(endtagindex)
                    filetext = filetext.Substring(filetext.IndexOf(Constants.vbLf))


                    Dim splitsigndata As String() = this_signsdata.Split(Constants.vbLf)
                    For Each this_data_item As String In splitsigndata
                        If this_data_item.Trim = "" Then
                            Continue For
                        End If

                        Dim this_data_item_split As String() = this_data_item.Trim.Split(":")
                        Dim this_data_item_name As String = this_data_item_split(0)
                        Dim this_data_item_value As String = this_data_item_split(1)

                        If (this_data_item_name.ToLower = "username") Then
                            this_remoteSign.username = this_data_item_value

                        ElseIf (this_data_item_name.ToLower = "ip") Then
                            this_remoteSign.ip = this_data_item_value

                        ElseIf (this_data_item_name.ToLower = "password") Then
                            this_remoteSign.password = this_data_item_value


                        ElseIf (this_data_item_name.ToLower = "datafilename") Then
                            this_remoteSign.datafilename = this_data_item_value


                        End If


                    Next 'datafield in this sign

                    m_remoteSignList.Add(this_remoteSign)

                Catch ex As Exception
                    filetext = filetext.Substring(filetext.IndexOf("]") + 1)
                    Continue While
                End Try

            End While

            SR.Close()


        End If
        CB_remoteSignList.SelectedIndex = -1
        CB_remoteSignList.Items.Clear()
        For Each this_remotesign As remoteSign In m_remoteSignList
            CB_remoteSignList.Items.Add(this_remotesign.signname)
        Next
        CB_remoteSignList.Text = "Select Sign To Edit"
        TB_signname.Text = ""
        TB_username.Text = ""
        TB_password.Text = ""
        TB_signname.Enabled = False
        TB_username.Enabled = False
        TB_password.Enabled = False

        databeinginternallymanipulated = False

    End Sub
    Public Sub init()
        If (IO.File.Exists((filename))) Then
            loadfile(filename)
        End If
        Form1.refreshSignMenue()
    End Sub
   

    Private Sub CB_promptforpassword_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CB_promptforpassword.CheckedChanged
        If Not formloaded Then
            Return
        End If
        If databeinginternallymanipulated Then
            Return
        End If

        Try
            TB_password.Enabled = Not CB_promptforpassword.Checked

            If Not TB_password.Enabled Then
                Dim this_remoteSign As remoteSign = m_remoteSignList(CB_remoteSignList.SelectedIndex)
                this_remoteSign.password = ""
                m_remoteSignList(CB_remoteSignList.SelectedIndex) = this_remoteSign

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub But_newsign_Click(sender As System.Object, e As System.EventArgs) Handles But_newsign.Click
        Try
            Dim this_remoteSign As remoteSign = New remoteSign
            this_remoteSign.signname = "unnamed_sign"
            m_remoteSignList.Add(this_remoteSign)
            CB_remoteSignList.Items.Add(this_remoteSign.signname)
            'select the last item which should be the one just added
            CB_remoteSignList.SelectedIndex = CB_remoteSignList.Items.Count - 1
        Catch ex As Exception
            MsgBox(2)
        End Try

    End Sub

    Private Sub TB_signname_TextChanged(sender As System.Object, e As System.EventArgs) Handles TB_signname.TextChanged
        If databeinginternallymanipulated Then
            Return
        End If

        Dim this_remoteSign As remoteSign = m_remoteSignList(CB_remoteSignList.SelectedIndex)
        this_remoteSign.signname = TB_signname.Text
        m_remoteSignList(CB_remoteSignList.SelectedIndex) = this_remoteSign
        CB_remoteSignList.Items(CB_remoteSignList.SelectedIndex) = this_remoteSign.signname


    End Sub


    Private Sub TB_username_TextChanged(sender As System.Object, e As System.EventArgs) Handles TB_username.TextChanged
        If databeinginternallymanipulated Then
            Return
        End If

        Dim this_remoteSign As remoteSign = m_remoteSignList(CB_remoteSignList.SelectedIndex)
        this_remoteSign.username = TB_username.Text
        m_remoteSignList(CB_remoteSignList.SelectedIndex) = this_remoteSign

    End Sub

    Private Sub TB_password_TextChanged(sender As System.Object, e As System.EventArgs) Handles TB_password.TextChanged
        If databeinginternallymanipulated Then
            Return
        End If

        Dim this_remoteSign As remoteSign = m_remoteSignList(CB_remoteSignList.SelectedIndex)
        this_remoteSign.password = TB_password.Text
        m_remoteSignList(CB_remoteSignList.SelectedIndex) = this_remoteSign

    End Sub

    Private Sub CB_remoteSignList_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_remoteSignList.SelectedIndexChanged
        If CB_remoteSignList.SelectedIndex = -1 Then
            TB_signname.Text = ""
            TB_username.Text = ""
            TB_password.Text = ""
            TB_signname.Enabled = False
            TB_username.Enabled = False
            TB_password.Enabled = False
        Else
            TB_signname.Enabled = True
            TB_username.Enabled = True

            'this is set when CB_promptforpassword.Checked is
            'TB_password.Enabled = True
            Dim this_remoteSign As remoteSign = m_remoteSignList(CB_remoteSignList.SelectedIndex)
            TB_signname.Text = this_remoteSign.signname
            TB_username.Text = this_remoteSign.username
            If this_remoteSign.password = "" Then
                CB_promptforpassword.Checked = True
                TB_password.Text = ""
            Else
                CB_promptforpassword.Checked = False
                TB_password.Text = this_remoteSign.password
            End If
        End If

    End Sub

    Private Sub But_OK_Click(sender As System.Object, e As System.EventArgs) Handles But_OK.Click
        savefile(filename)

        Me.Close()
    End Sub

    Private Sub But_apply_Click(sender As System.Object, e As System.EventArgs) Handles But_apply.Click
        savefile(filename)
    End Sub

    Private Sub But_cancel_Click(sender As System.Object, e As System.EventArgs) Handles But_cancel.Click
        Me.Close()
    End Sub

    Private Sub RemoteSignsForm_VisibleChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.VisibleChanged

        If Me.Visible Then
            If (IO.File.Exists((filename))) Then
                loadfile(filename)
            End If
            formloaded = True

        Else
            formloaded = False
            Form1.refreshSignMenue()
        End If
    End Sub

End Class