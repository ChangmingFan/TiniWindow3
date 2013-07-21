Public Class select_comport_form
    'Dim cancel_has_been_pressed As Boolean = False
    Dim comport As String = ""
    Dim success As Boolean = False
    Dim fail As Boolean = False
    Dim portlist As String()
    Public clear_help_at_load As Boolean = True

    Dim status As String = ""


    Public Function getcomport() As String
        Return comport
    End Function
    Public Sub setcomport(ByVal passedcomport As String)

        comport = passedcomport
        Dim i As Integer = 0
        While (i < c.Items.Count)
            c.SelectedIndex = i
            If (c.SelectedItem.ToString() = passedcomport) Then
                i = c.Items.Count + 1
            End If

        End While


    End Sub

    Const BOOTLOADER_VERSIONCOMMAND As String = "V" 'used to check if bootloader running

    Private Sub auto_try_ports()
        If c.SelectedIndex = -1 Then
            c.SelectedIndex = 0
        End If

        Dim startindex = c.SelectedIndex
        But_auto_retry.Visible = False

        While True
            status = "Establishing communication with the sign" + Constants.vbCrLf + "Trying " + c.SelectedItem.ToString + "..."
            Dim portresult As Int16 = openport(c.SelectedItem.ToString)
            If portresult = openportResult.success Then

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
                Return
            ElseIf portresult = openportResult.bootloader_downloadfirmware Then
                Form1.updatetinidisk = True
                Form1.CheckForUpdatesToolStripMenuItem_Click(New Object, New System.EventArgs)
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
                Return
            ElseIf portresult = openportResult.fail Or portresult = openportResult.bootloader_tryanotherport Then
                If c.SelectedIndex = c.Items.Count - 1 Then
                    c.SelectedIndex = 0

                Else
                    c.SelectedIndex += 1
                End If
                If c.SelectedIndex = startindex Then

                    status = "Unable to establish communication with sign" + Constants.vbCrLf
                    status += "Make sure the sign is connected to the USB port and try again"
                    But_auto_retry.Visible = True
                    Return
                Else
                    Continue While
                End If
            ElseIf portresult = openportResult.bootloader_cancle Then
                status = "establishing communication with sign has been cancled"
                But_auto_retry.Visible = True
                Return

            Else
                status = "There was an error" + Constants.vbCrLf
                status = "Please report this bug" + Constants.vbCrLf

                But_auto_retry.Visible = True
                Return
                

            End If


        End While

    End Sub

    Private Sub select_comport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        status = "Establishing communication with sign..."
        Timer_showstatus.Start()

        But_continue.Visible = False
        c.Visible = True
        But_select.Visible = True
        But_cancle.Visible = True

        But_retryport.Visible = False
        Dim screenRectangle As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea
        Dim screenHeight As Int32 = screenRectangle.Height
        Dim screenWidth As Int32 = screenRectangle.Width

        If Form1.Location.X < screenWidth / 2 Then
            'place open comport form to left of TiniWindow

            Me.Location = New System.Drawing.Point(Form1.Location.X + Form1.Width + 20, 20)
        Else
            'place to right of TiniWindow
            Me.Location = New System.Drawing.Point(Form1.Location.X - Me.Width - 20, 20)
        End If


        refreshports()
        'c.Text = "select one"

        Timer_refresh_ports.Start()



        Timer_load_finished.Start()
        
        Return


        'below is old stuff pertaining to manuel select
        If clear_help_at_load Then
            'Form1.TB_beginners_help.Clear()
            Form1.appendrichtext("The sign must be plugged into the USB port before selecting a comport" + Constants.vbCrLf + Constants.vbCrLf, 12, FontStyle.Bold)
        End If


        Return
        clear_help_at_load = True
        'Form1.appendrichtext("The comport is a identifyer that specifies which device to communicate with " + Constants.vbCrLf, 10)
        'Form1.appendrichtext("We want to communicate with the sign (as opposed to say a modom or flash drive)" + Constants.vbCrLf + Constants.vbCrLf, 10)




        Form1.appendrichtext("To select a comport" + Constants.vbCrLf, 12, FontStyle.Bold)
        Form1.appendrichtext("1.    Select the correct comport from the drop down " + Constants.vbCrLf, 9)


        Form1.appendrichtext("      menue (If you are not sure which one is" + Constants.vbCrLf, 9)
        Form1.appendrichtext("      correct, you may try them all one by one)" + Constants.vbCrLf, 9)
        Form1.appendrichtext("2.    Click button labled 'Open'" + Constants.vbCrLf, 9)
        Form1.appendrichtext("3.    Click button labled 'Continue'" + Constants.vbCrLf, 9)


        '
        Form1.Refresh()


        'But_select.Text = "select"

        'Timer_polliifBGWdone.Stop()
        'cancel_has_been_pressed = False
        refreshports()
        'c.Text = "select one"

        Timer_refresh_ports.Start()
        'But_select.Enabled = False
        status = "Click 'next' to open " + c.SelectedItem + Constants.vbCrLf
        status += "To chose another comport, click ▼"
        ''''''''''''
        'While (True)
        '    If (my_select_comport_form.DialogResult = Windows.Forms.DialogResult.OK) Then

        '        If my_select_comport_form.getcomport() = comport Then
        '            MsgBox(comport + " is already currently selected!")
        '            my_select_comport_form.ShowDialog()
        '            Continue While
        '        End If

        '        comport = my_select_comport_form.getcomport()

        '        mySerialPort = New System.IO.Ports.SerialPort(comport, 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One)

        '        If (Not getversion(TiniDiskMajorVersion, TiniDiskMinorVersion)) Then
        '            'check for bootloader
        '            If (bootloaderrunning()) Then
        '                If My.Computer.Network.IsAvailable = True Then
        '                    Dim message As String = "this appears to be the correct comport" + Constants.vbCrLf
        '                    message += "however no valid software was found!" + Constants.vbCrLf
        '                    message += "do you wish to download software?"
        '                    Dim result As Windows.Forms.DialogResult = MsgBox(message, MsgBoxStyle.YesNo)
        '                    If result = Windows.Forms.DialogResult.Yes Then
        '                        TiniDiskMajorVersion = -1
        '                        TiniDiskMinorVersion = -1
        '                        CheckForUpdatesToolStripMenuItem_Click(New Object, New System.EventArgs)
        '                    ElseIf result = Windows.Forms.DialogResult.No Then
        '                        my_select_comport_form.ShowDialog()
        '                        Continue While
        '                    Else
        '                        MsgBox("bugg!")
        '                    End If

        '                End If
        '            Else

        '                Dim message As String
        '                message = "communication error with port " + mySerialPort.PortName + Constants.vbCrLf
        '                message += "make sure you have selected the correct comport and that the device is plugged in"
        '                MsgBox(message)
        '                my_select_comport_form.ShowDialog()
        '                Continue While
        '            End If

        '        End If
        '        comportselected = True
        '        Try
        '            oldSerialPort.Close()
        '        Catch ex As Exception

        '        End Try
        '        If (selectcomportclicked) Then
        '            showtooltip()
        '        End If
        '        Return True
        '    ElseIf (my_select_comport_form.DialogResult = Windows.Forms.DialogResult.Cancel) Then
        '        mySerialPort = oldSerialPort
        '        Return False
        '    Else
        '        MsgBox("error")

        '    End If
        'End While



    End Sub

    'Private Sub CB_portlist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c.SelectedIndexChanged
    '   comport = c.SelectedItem.ToString
    'End Sub

    Private Sub showComError(ByVal message As String)
        'But_select.Text = "Retry " + comport
        But_cancle.Visible = True
        But_retryport.Visible = True
        But_select.Visible = True
        'Txtmessage.Visible = True
        c.Visible = False
        status = message

        'Form1.TB_beginners_help.Text = "Make sure the sign is plugged in to the USB port and you have selected the right comport" + Constants.vbCrLf + Constants.vbCrLf
        Form1.appendrichtext(" you should only retry " + comport + " if you are certain it is the correct comport" + Constants.vbCrLf + Constants.vbCrLf, 10)

        Form1.appendrichtext("Contact technical support for additional assistance " + Constants.vbCrLf, 10)
    End Sub
    Private Sub start_progress_mode()
        status = "opening " + comport + "...."
        'Txtmessage.Refresh()

        c.Visible = False
        But_select.Visible = False
        But_retryport.Visible = False
        But_cancle.Visible = False
        Me.Refresh()
    End Sub

    Private Sub showComportAlreadySelected()

        'But_select.Text = "Retry " + comport
        'But_cancle.Visible = True
        'But_retryport.Visible = True
        'But_select.Visible = False
        'Txtmessage.Visible = True
        'c.Visible = False

        status = comport + " is already currently open!" + Constants.vbCrLf
        status += "to leave " + comport + " open click cancel" + Constants.vbCrLf

        If (c.SelectedIndex = c.Items.Count - 1) Then
            c.SelectedIndex = 0
        Else
            c.SelectedIndex += 1
        End If

        status += "to open " + c.SelectedItem + "click next" + Constants.vbCrLf


        'myerror(comport + " is already currently selected!")
    End Sub

    Private Function bootloader_prompt(ByVal passed_comport As String) As Int16
        Dim controlls_array As ArrayList = New ArrayList

        controlls_array = New ArrayList

        controlls_array.Add(New ArrayList)
        controlls_array.Add(New ArrayList)
        controlls_array.Add(New ArrayList)
        Dim message As String

        While True
            If My.Computer.Network.IsAvailable = True Then
                'the bootloader is detected and trhe user's computer is connecred to the internet


                message = passed_comport + " appears to be the correct comport" + Constants.vbCrLf
                message += "However it is neccesary to download new firmware!" + Constants.vbCrLf




                '''''''''


                controlls_array(mymsg.parameterArrayIndex.ControllType).add("button")
                controlls_array(mymsg.parameterArrayIndex.ControllValue).add("Download")
                controlls_array(mymsg.parameterArrayIndex.ControllIdentifier).add("download")

                controlls_array(mymsg.parameterArrayIndex.ControllType).add("newrow")
                controlls_array(mymsg.parameterArrayIndex.ControllValue).add("")
                controlls_array(mymsg.parameterArrayIndex.ControllIdentifier).add("")

                controlls_array(mymsg.parameterArrayIndex.ControllType).Add("button")
                controlls_array(mymsg.parameterArrayIndex.ControllValue).Add("Cancel")
                controlls_array(mymsg.parameterArrayIndex.ControllIdentifier).Add("cancel")


                controlls_array(mymsg.parameterArrayIndex.ControllType).add("newrow")
                controlls_array(mymsg.parameterArrayIndex.ControllValue).add("")
                controlls_array(mymsg.parameterArrayIndex.ControllIdentifier).add("")

                controlls_array(mymsg.parameterArrayIndex.ControllType).Add("button")
                controlls_array(mymsg.parameterArrayIndex.ControllValue).Add("Try another port")
                controlls_array(mymsg.parameterArrayIndex.ControllIdentifier).Add("tryanotherport")


            Else
                'the bootloader is detected howevver it is not possible to download embedded code
                'because there is no internet connection

                message = passed_comport.ToString + " appears to be the correct comport" + Constants.vbCrLf
                message += "However is neccesary to download new firmware" + Constants.vbCrLf
                message += "Unfortunantly an internet connection is required" + Constants.vbCrLf



                controlls_array(mymsg.parameterArrayIndex.ControllType).Add("button")
                controlls_array(mymsg.parameterArrayIndex.ControllValue).Add("Cancel")
                controlls_array(mymsg.parameterArrayIndex.ControllIdentifier).Add("cancel")

                controlls_array(mymsg.parameterArrayIndex.ControllType).Add("button")
                controlls_array(mymsg.parameterArrayIndex.ControllValue).Add("Retry Internet connection")
                controlls_array(mymsg.parameterArrayIndex.ControllIdentifier).Add("retry")

                controlls_array(mymsg.parameterArrayIndex.ControllType).add("newrow")
                controlls_array(mymsg.parameterArrayIndex.ControllValue).add("")
                controlls_array(mymsg.parameterArrayIndex.ControllIdentifier).add("")

                controlls_array(mymsg.parameterArrayIndex.ControllType).Add("button")
                controlls_array(mymsg.parameterArrayIndex.ControllValue).Add("Try another port")
                controlls_array(mymsg.parameterArrayIndex.ControllIdentifier).Add("tryanotherport")
            End If



            Dim selection_array As ArrayList = mymsg.showform(message, controlls_array)

            Dim pressed_button As String = selection_array(mymsg.returnArrayIndex.button)(mymsg.returnArraySecondDimention.identifyer)

            If pressed_button = "download" Then
                Return openportResult.bootloader_downloadfirmware
            ElseIf pressed_button = "cancel" Then
                Return openportResult.bootloader_cancle
            ElseIf pressed_button = "tryanotherport" Then
                Return openportResult.bootloader_tryanotherport
            ElseIf pressed_button = "retry" Then
                Continue While
            Else
                Return openportResult.err
            End If
        End While
    End Function

    Enum openportResult
        fail = 0
        success = 1
        bootloader_downloadfirmware = 2
        bootloader_cancle = 3
        bootloader_tryanotherport = 4

        err = -1

    End Enum
    Private Function openport(ByVal port As String) As Int16
        'function temporarily removed while implementing class structure for connections

        ''Timer_showsuccess.Start()
        ''BGW_readport.RunWorkerAsync()
        'Dim oldSerialPort = Form1.mySerialPort
        'Dim oldcomport = comport


        'comport = port

        'Form1.mySerialPort = New System.IO.Ports.SerialPort(comport, 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One)
        ''start_progress_mode() 'has to be after comport set 
        ''MsgBox(Form1.mySerialPort.PortName)
        ''If cancel_has_been_pressed Then
        ''    cancel_has_been_pressed = False
        ''    Form1.mySerialPort = oldSerialPort
        ''    comport = oldcomport
        ''    Return
        ''End If


        'If (Not Form1.getversion(Form1.TiniDiskMajorVersion, Form1.TiniDiskMinorVersion)) Then


        '    'version commna dreturns false if it fails to write to comport or fails to read anything back


        '    'temporarily not dealing with comport 
        '    'check for bootloader
        '    'If (bootloaderrunning()) Then

        '    '    Return bootloader_prompt(port)



        '    'Else

        '    'both the version cetuommand and the bootloader test have failed

        '    'Form1.mySerialPort = oldSerialPort
        '    'comport = oldcomport

        '    Return openportResult.fail

        'End If


        ''reach this point if the version command returns understandable response


        'If Form1.TiniDiskMajorVersion < 1 Or Form1.TiniDiskMinorVersion < 1 Then

        '    Return bootloader_prompt(port)
        'End If


        ''MsgBox(Form1.mySerialPort.PortName)
        'Form1.comportselected = True

        ' ''showsuccess()
        ' ''MsgBox("reached 11")
        ' ''Return

        'Return openportResult.success

        ''MsgBox(Form1.mySerialPort.PortName)


        ''''''''''''
        ''



    End Function


    Private Sub But_select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_select.Click
        'Timer_showsuccess.Start()

        If c.SelectedItem.ToString = comport Then
            showComportAlreadySelected()
            Return
        End If
        ''''''''''''''''

        openport(c.SelectedItem.ToString)

        'Txtmessage.Visible = True
        'comport = c.SelectedItem.ToString




        

    End Sub

    Private Sub But_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_cancle.Click

        Me.DialogResult() = Windows.Forms.DialogResult.Cancel
        'If BGW_readport.IsBusy Then
        '    cancel_has_been_pressed = True
        '    ''''''
        '    But_select.Visible = False
        '    But_change_port.Visible = False

        '    'Txtmessage.Visible = True
        '    c.Visible = False
        '    status = "canceling...."
        '    ''''''''
        '    Timer_polliifBGWdone.Start()
        '    Return
        'End If
        Form1.showmainhelp()


        Me.Close()
    End Sub

    Private Sub CB_portlist_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True

    End Sub
    Private Sub But_retry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_retryport.Click


        'openport(sender.tag, False)


        
    End Sub


    ''''from here down are bootloader functions'''''
    Private Function bootloaderrunning() As Boolean
        With Form1.mySerialPort
            Try
                If (Not .IsOpen) Then
                    .Open()
                End If

                If (Not .IsOpen) Then
                    .Close()
                    Return False
                End If

                If Not Form1.sendcommand(BOOTLOADER_VERSIONCOMMAND) Then
                    .Close()
                    Return False
                End If

                Dim version As String = readport(5) 'should read 4 then timeout
                If version.Length <> 2 Then
                    .Close()
                    Return False

                End If
                Dim i As Integer = 0
                While i < version.Length 'make sure only digits are returned
                    If version(i) < "0" Or version(i) > "9" Then
                        .Close()
                        Return False
                    End If
                    i += 1
                End While
            Catch
                Try
                    .Close()
                Catch ex As Exception

                End Try

                Return False
            End Try



        End With

        Return True

    End Function





    Private Function readport(ByVal length As Integer) As String
        'this functions reads length characters from the comport. it is usually used with the bootloader rather then the application
        Dim starttime As Double = DateAndTime.Timer() 'returns seconds since midnight
        Dim stringtoreadto As String = ""
        Dim timesthrouloop As Integer = 0
        While (True)

            Form1.echoerror = 0


            If (DateAndTime.Timer() - starttime > 3 Or DateAndTime.Timer() - starttime < -86397) Then
                Form1.echoerror = 1

                Return stringtoreadto
            End If

            Dim characterread As String = ""
            Try

                characterread = Form1.mySerialPort.ReadExisting()
                'characterread = simulatereadingport()
            Catch ex As UnauthorizedAccessException


                Dim loopcounter As Integer = 0
                Dim ok As Boolean = False
                While (loopcounter < 3)
                    Try

                        Form1.mySerialPort.Close()

                        Form1.mySerialPort.Open()

                        characterread = Form1.mySerialPort.ReadExisting()


                    Catch ex2 As UnauthorizedAccessException

                        loopcounter += 1
                        Continue While
                    Catch ex3 As System.IO.IOException

                        loopcounter += 1
                        Continue While
                    End Try

                    ok = True
                    loopcounter = 5
                End While

                If (Not ok) Then

                    Form1.echoerror = 7
                    Return stringtoreadto
                End If

                '''''''
            Catch ex_2 As System.IO.IOException


                Dim loopcounter As Integer = 0
                Dim ok As Boolean = False
                While (loopcounter < 3)

                    Try
                        Form1.mySerialPort.Close()

                        Form1.mySerialPort.Open()

                        characterread = Form1.mySerialPort.ReadExisting()

                    Catch ex2 As UnauthorizedAccessException

                        loopcounter += 1
                        Continue While
                    Catch ex3 As System.IO.IOException

                        loopcounter += 1
                        Continue While
                    End Try

                    ok = True
                    loopcounter = 5
                End While


                If (Not ok) Then

                    Form1.echoerror = 7
                    Return stringtoreadto
                End If



            End Try



            If (characterread <> "") Then

                starttime = DateAndTime.Timer()
            End If
            stringtoreadto = stringtoreadto + characterread
            If (stringtoreadto.Length() = length) Then

                Form1.echoerror = 0
                Return stringtoreadto

            End If



        End While
        'Dim commandstring As String = "W " + Hex(AscW(character)) + Constants.vbCrLf
        'Return commandstring




        MsgBox("bugg")




    End Function

    Private Sub showsuccess()

        ' MsgBox("reached")
        'Me.DialogResult() = Windows.Forms.DialogResult.OK
        'MsgBox("reached2")
        But_select.Visible = False
        'MsgBox("reached3")
        But_retryport.Visible = False
        'MsgBox("reached4")
        c.Visible = False
        'MsgBox("reached5")
        status = "Success! comport " + comport + " selected"
        'MsgBox("reached6")
        But_cancle.Visible = False
        But_continue.Visible = True
        MsgBox("reached7")
        Form1.comportselected = True
        MsgBox("reached8")
    End Sub
    'Private Sub BGW_readport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGW_readport.DoWork

    'End Sub

    'Private Sub Timer_polliifBGWdone_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_polliifBGWdone.Tick
    '    If BGW_readport.IsBusy Then
    '        Return
    '    Else
    '        Timer_polliifBGWdone.Stop()
    '        Me.Close()
    '    End If
    'End Sub

    Private Sub But_continue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_continue.Click
        'MsgBox(Form1.mySerialPort.PortName)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Form1.showmainhelp()
        Me.Close()
    End Sub

    Private Sub Timer_showsuccess_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'it is not neccesary ro use a timer for this
        'it was an attempt to solve a problem with the background worker that no longer exist
        If success Then

            'Timer_showsuccess.Stop()
            'MsgBox(Form1.mySerialPort.PortName)
            'Try
            '    Form1.mySerialPort.Close()
            'Catch ex As Exception

            'End Try

            'Form1.mySerialPort = Form1.mySerialPort
            'MsgBox(Form1.mySerialPort.PortName)

            But_select.Visible = False
            'MsgBox("reached3")
            But_retryport.Visible = False
            'MsgBox("reached4")
            c.Visible = False
            'MsgBox("reached5")
            status = "Success!" + Constants.vbCrLf + comport + " opened"
            'MsgBox("reached6")
            But_cancle.Visible = False
            But_continue.Visible = True
            '   MsgBox("reached7")
            Form1.comportselected = True
            '  MsgBox("reached8")
            success = False

        End If
    End Sub

    Private Sub refreshports()
        Dim selectedportname As String = c.SelectedItem
        Dim selectedportindex As String = c.SelectedIndex
        Dim selectioncount As Int16 = c.Items.Count
        Dim portnamepresent As Boolean = False
        portlist = System.IO.Ports.SerialPort.GetPortNames
        'Dim thisSerialPort As System.IO.Ports.SerialPort

        c.Items.Clear() 'prevent listing ports multiple times
        Dim i As Integer = portlist.Length() - 1
        Dim j As Int16 = 0
        While (i >= 0)
            c.Items.Add(portlist(i))

            If (selectedportname = portlist(i)) Then
                c.SelectedIndex = j
                portnamepresent = True
            End If
            i -= 1
            j += 1
        End While

        If Not portnamepresent Then

            If selectedportindex <= 0 Then
                'initial condition
                c.SelectedIndex = 0
            Else

                c.SelectedIndex = selectedportindex + (selectioncount - c.Items.Count)


            End If
        End If

        'If (comport = "") Then
        '    c.SelectedIndex = 0
        'Else
        '    c.SelectedText = comport

        'End If
    End Sub
    Private Sub Timer_refresh_ports_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_refresh_ports.Tick
        Dim temp As String()
        temp = System.IO.Ports.SerialPort.GetPortNames
        If temp.Length <> portlist.Length Then
            refreshports()
            Return
        End If

        Dim i = 0

        While i < temp.Length
            If temp(i) <> portlist(i) Then
                refreshports()
                Return

            End If
            i += 1
        End While

    End Sub

    Private Sub c_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c.SelectedIndexChanged
        But_select.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        help.Show()
    End Sub

    Private Sub But_auto_retry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_auto_retry.Click

        auto_try_ports()

        'If auto_try_ports() Then
        '    success = True
        '    Me.Close()
        'Else

        '    status = "unable to communicate with sign" + Constants.vbCrLf + "Make sure it is plugged into the USB port and try again"
        'End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Timer_load_finished_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_load_finished.Tick
        Timer_load_finished.Stop()
        auto_try_ports()

    End Sub

    Private Sub Timer_showstatus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_showstatus.Tick
        Txtmessage.Text = status
    End Sub
End Class