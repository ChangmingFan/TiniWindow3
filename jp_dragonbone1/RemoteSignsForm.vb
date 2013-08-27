Public Class RemoteSignsForm
    Dim databeinginternallymanipulated = False
    Dim filename As String = "remoteSignlist.rsl"
    Dim initialized As Boolean = False

    'Dim arrIP_list(5) As String



    '082513 CMF
    'Format of remotrSignlist.rsl :
    '[start SIGNAME]
    'username:USERNAME
    'ips:IP0I|IP1|IP2|IP3|IP4|IP5   'Total 5 IPs in format xx:xx:xx:xx
    '[end SIGNAME]

    'Jp's old format
    'format is
    '[start SIGNAME]
    'username:USERNAME
    'ip:IP                      ' Single one IP only
    '[end SIGNAME]

    'information not between start and end tag are ignored and may be used as notes
    Public Structure remoteSign
        '082413 Instead of singleIP, we now create an array list for IPs
        Shared default_IP_list As ArrayList
        Shared Sub init()
            'next step is to check if "local ip list" file exist and if so use instead of these hardcoded values  
            If (My.Computer.FileSystem.FileExists("local_FTP_ip.lst") Or My.Computer.FileSystem.FileExists("global_FTP_ip.lst")) Then
                Dim sr As IO.StreamReader ' = New IO.StreamReader("global_FTP_ip.lst")

                If (My.Computer.FileSystem.FileExists("local_FTP_ip.lst")) Then
                    sr = New IO.StreamReader("local_FTP_ip.lst")
                ElseIf (My.Computer.FileSystem.FileExists("global_FTP_ip.lst")) Then
                    sr = New IO.StreamReader("global_FTP_ip.lst")
                Else
                    MsgBox("error in remotesign--init")
                End If

                default_IP_list = New ArrayList
                Dim line As String = ""

                While Not sr.EndOfStream
                    line = sr.ReadLine
                    If line.Trim <> "" Then
                        default_IP_list.Add(line)
                    End If
                End While

                sr.Close()
            Else
                'defualt hardcoded values
                default_IP_list = New ArrayList
                default_IP_list.Add("184.168.86.30")
                default_IP_list.Add("97.74.144.142")
            End If



        End Sub



        'Shared default_ip As String = "184.168.86.30"
        Shared default_directory As String = "dat"

        Dim IP_list As ArrayList
        Dim signname As String
        Dim username As String
        Dim password As String
        Dim ip As String
        Dim directory As String
        Dim datafilename As String
    End Structure

    Dim m_remoteSignList As ArrayList = New ArrayList
    Dim formloaded As Boolean = False








    'function delegates used so properties can be defined to marshal in a multi-threaded invironment

    'functioanlity for making remote sign list available to other parts of program
    Delegate Function getremoteSignDelegate() As remoteSign()
    Dim generate_remoteSignList_delegate As getremoteSignDelegate '= AddressOf generate_remoteSignList
    Private Function generate_remoteSignList() As remoteSign()
        Dim returnvalue(m_remoteSignList.Count - 1) As remoteSign
        Dim i As Integer = 0
        For Each sign As remoteSign In m_remoteSignList

            'make sure we are using a copy and not a reference
            Dim signcopy As remoteSign = New remoteSign
            signcopy.signname = sign.signname
            signcopy.username = sign.username
            signcopy.password = sign.password

            If sign.directory Is Nothing Then
                signcopy.directory = remoteSign.default_directory
            Else
                signcopy.directory = sign.directory
            End If
            If signcopy.IP_list Is Nothing Then
                signcopy.IP_list = New ArrayList
                For Each ip As String In remoteSign.default_IP_list
                    signcopy.IP_list.Add(ip)
                Next
            Else
                signcopy.IP_list = New ArrayList
                For Each ip As String In sign.IP_list
                    signcopy.IP_list.Add(ip)
                Next
            End If
            If sign.datafilename Is Nothing Then
                signcopy.datafilename = sign.signname & ".data"
            Else
                signcopy.datafilename = sign.datafilename
            End If

            returnvalue(i) = signcopy
            i += 1
        Next

        Return returnvalue

    End Function

    Public ReadOnly Property remoteSignList As remoteSign()
        Get
            'written this way to work in multi-threaded invironment
            Return generate_remoteSignList_delegate.Invoke
        End Get
    End Property

    '''


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

        If Not initialized Then

            initialized = True
            remoteSign.init()
            generate_remoteSignList_delegate = AddressOf generate_remoteSignList
            If (IO.File.Exists((filename))) Then
                loadfile(filename)
            End If
            'Form1.refreshSignMenue()

        End If
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

        Static Dim previous_text As String = TB_signname.Text
        Static Dim previous_selection_start As Int16 = TB_signname.SelectionStart
        Static Dim previous_selection_length As Int16 = TB_signname.SelectionLength

        Static Dim recursive As Boolean = False

        If databeinginternallymanipulated Then
            Return
        End If

        If Not recursive Then

            recursive = True
            'check validity of text
            Dim invalidchars As String = Chr(0) & Chr(1) & Chr(2) & Chr(3) & Chr(4) & Chr(5) & Chr(6) & Chr(7) & Chr(8) & Chr(9) & Chr(10) & Chr(11) & Chr(12) & Chr(13) _
                & Chr(14) & Chr(15) & Chr(16) & Chr(17) & Chr(18) & Chr(19) & Chr(20) & Chr(21) & Chr(22) & Chr(23) & Chr(24) & Chr(25) & Chr(26) & Chr(27) & Chr(28) _
                & Chr(29) & Chr(30) & Chr(31) & " " & Chr(127) & Chr(129) & Chr(141) & Chr(143) & Chr(144) & Chr(157) & Chr(16)
            For Each letter As Char In TB_signname.Text
                If invalidchars.IndexOf(letter) >= 0 Then
                    'Invalidate letters present
                    TB_signname.Text = previous_text
                    TB_signname.SelectionStart = previous_selection_start
                    TB_signname.SelectionLength = previous_selection_length
                    Beep()

                    recursive = False
                    Return
                End If

            Next


            Dim this_remoteSign As remoteSign = m_remoteSignList(CB_remoteSignList.SelectedIndex)
            this_remoteSign.signname = TB_signname.Text
            m_remoteSignList(CB_remoteSignList.SelectedIndex) = this_remoteSign
            CB_remoteSignList.Items(CB_remoteSignList.SelectedIndex) = this_remoteSign.signname


            previous_text = TB_signname.Text
            previous_selection_start = TB_signname.SelectionStart
            previous_selection_length = TB_signname.SelectionLength


            recursive = False
        End If
    End Sub


    Private Sub TB_username_TextChanged(sender As System.Object, e As System.EventArgs) Handles TB_username.TextChanged
        Static Dim previous_text As String = TB_username.Text
        Static Dim previous_selection_start As Int16 = TB_username.SelectionStart
        Static Dim previous_selection_length As Int16 = TB_username.SelectionLength

        Static Dim recursive As Boolean = False

        If databeinginternallymanipulated Then
            Return
        End If

        If Not recursive Then

            recursive = True
            'check validity of text
            Dim invalidchars As String = Chr(0) & Chr(1) & Chr(2) & Chr(3) & Chr(4) & Chr(5) & Chr(6) & Chr(7) & Chr(8) & Chr(9) & Chr(10) & Chr(11) & Chr(12) & Chr(13) _
                & Chr(14) & Chr(15) & Chr(16) & Chr(17) & Chr(18) & Chr(19) & Chr(20) & Chr(21) & Chr(22) & Chr(23) & Chr(24) & Chr(25) & Chr(26) & Chr(27) & Chr(28) _
                & Chr(29) & Chr(30) & Chr(31) & " " & Chr(127) & Chr(129) & Chr(141) & Chr(143) & Chr(144) & Chr(157) & Chr(16)
            For Each letter As Char In TB_username.Text
                If invalidchars.IndexOf(letter) >= 0 Then
                    'Invalidate letters present
                    TB_username.Text = previous_text
                    TB_username.SelectionStart = previous_selection_start
                    TB_username.SelectionLength = previous_selection_length
                    Beep()

                    recursive = False
                    Return
                End If

            Next


            Dim this_remoteSign As remoteSign = m_remoteSignList(CB_remoteSignList.SelectedIndex)
            this_remoteSign.username = TB_username.Text
            m_remoteSignList(CB_remoteSignList.SelectedIndex) = this_remoteSign


            previous_text = TB_username.Text
            previous_selection_start = TB_username.SelectionStart
            previous_selection_length = TB_username.SelectionLength


            recursive = False

        End If

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
            But_advanced.Enabled = False
            But_deleteSign.Enabled = False
        Else
            TB_signname.Enabled = True
            TB_username.Enabled = True
            But_advanced.Enabled = True
            But_deleteSign.Enabled = True

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

    Private Sub But_apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_apply.Click
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

    Private Sub RemoteSignsForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        init()
    End Sub


    Private Sub CB_remotesignlist_refresh()

        databeinginternallymanipulated = True


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

    Private Sub But_deleteSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_deleteSign.Click
        Dim user_response As DialogResult = MsgBox("Are you sure you want to delete this sign?", MsgBoxStyle.OkCancel)

        If user_response = DialogResult.OK Then
            m_remoteSignList.RemoveAt(CB_remoteSignList.SelectedIndex)
            CB_remotesignlist_refresh()

        End If
        
    End Sub

    Private Sub But_advanced_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_advanced.Click
        ' 3 jobs to do:
        ' 1-copy the data into the advanced form

        Remote_sign_advanced_config.Working_sign = m_remoteSignList(CB_remoteSignList.SelectedIndex)

        ' 2-blocking show the advanced form
        Remote_sign_advanced_config.ShowDialog()

        ' 3-copy the data back
        If Remote_sign_advanced_config.DialogResult = DialogResult.OK Then
            m_remoteSignList(CB_remoteSignList.SelectedIndex) = Remote_sign_advanced_config.Working_sign
        End If


    End Sub


End Class

