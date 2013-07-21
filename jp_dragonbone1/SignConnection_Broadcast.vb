Public Class SignConnection_Broadcast
    Inherits SignConnection_Base

    Protected MAXSIGNSBEFOREREPONSEOVERFLOW As Int16 = 10





    Public Overrides Function sendData() As Object

        If Not MarshallingInitialized Then
            initialisemarshalling()
        End If

        sendData_do()
        myProgressForm.ShowDialog()

        Return True 'need to impliment way of checking result, perhaps on progress form
    End Function

    Private Sub sendData_do()
        'this function seperated from sendData so that it can be called when the retry button is pressed on progress form

        Dim bgw As System.ComponentModel.BackgroundWorker = New System.ComponentModel.BackgroundWorker
        myProgressForm.bgw = bgw
        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True
        AddHandler bgw.DoWork, AddressOf sendData_backgroundWork
        AddHandler bgw.ProgressChanged, AddressOf common_backgroundwork_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf common_backgroundwork_RunWorkerCompleted
        bgw.RunWorkerAsync()
    End Sub

    Protected Overridable Sub sendData_backgroundWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

        Dim signcount As UInt16 = _allSigns_working.Count 'define this so that if scan process detects a change we keep same count
        Dim minresponsesreceived As UInt16 = signcount
        Dim maxresponsesreceived As UInt16 = signcount

        Dim process As String = "Sending data to sign" & Constants.vbCr
        Dim warning As String = ""
        Dim bgw As System.ComponentModel.BackgroundWorker = sender

        'Dim steps As Int16 = Form1.linecount + 2
        Dim steps As Int16 = linecount + 2
        Dim increment As Single = 100.0 / steps
        Dim currentProgress As Single = 0

        bgw.ReportProgress(currentProgress, process & "sending configuration data")

        If bgw.CancellationPending Then
            bgw.ReportProgress(currentProgress, process & "Cancled!")
            e.Cancel = True

            Return
        End If

        'timer_monitor_pan_morelines.Stop()

        'mySerialPort.WriteTimeout = 100
        'backgroundworkerdebugvalue = "001"

        'Dim tricks As Integer = trickcount()
        'progress_form.setstepcount(linecount + trickcount + 1)
        Dim trickstartpointerscopy As ArrayList = trickstartpointers
        Dim trickstartpointersindex As Int16 = 0

        'progresform_StepCount = linecount + trickcount


        Dim textdatawalker As Integer = 0
        ADDRESS_STARTOFTEXTDATA = 500 - (linecount * linelength)
        Dim address_ptr As Integer = ADDRESS_STARTOFTEXTDATA
        'backgroundworkerdebugvalue = "110"
        Dim responsesreceived As UInt16


        If signcount <= MAXSIGNSBEFOREREPONSEOVERFLOW Then
            'if their are fewer signs then sould overflow the receive buffer on the bas unit then we count responses and give warning if differen then expected 
            'consider failure and exit only if there are 0 valid responses
            responsesreceived = broadcast_writeparametertodevice(1, ADDRESS_EEPROM_MAP_TYPE, signcount)
            If (responsesreceived = 0) Then
                'no responses received, communication error 
                bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
                e.Cancel = True
                Return
            Else

                If (responsesreceived <> signcount) Then

                    If responsesreceived < minresponsesreceived Then
                        minresponsesreceived = responsesreceived

                    End If


                    If responsesreceived > maxresponsesreceived Then
                        maxresponsesreceived = responsesreceived

                    End If

                    If minresponsesreceived < signcount And maxresponsesreceived > signcount Then
                        'most unusuall situation, we have fluctuated between too many and too few signs
                        warning = "Inconsistant sign communication!"
                        warning &= Constants.vbCrLf & "Expected: " & signcount & " Min: " & minresponsesreceived & " Max: " & maxresponsesreceived

                    ElseIf minresponsesreceived < signcount Then
                        warning = "Communication error with at least " & (signcount - minresponsesreceived) & " Signs"
                        warning &= Constants.vbCrLf & "Expected: " & signcount & " Min: " & minresponsesreceived & " Max: " & maxresponsesreceived

                    ElseIf maxresponsesreceived > signcount Then
                        warning = "More signs then expected " & (signcount - minresponsesreceived) & " Signs"
                        warning &= Constants.vbCrLf & "Expected: " & signcount & " Min: " & minresponsesreceived & " Max: " & maxresponsesreceived

                    End If



                End If
                currentProgress += increment / 3
                bgw.ReportProgress(currentProgress, process & "sending configuration data" & Constants.vbCrLf & warning)

            End If

        Else
            'if there are more signs then the receive buffer on the base unit can handle 
            'then we consider communication sucessful if there is at least one valid response


            If (Not broadcast_writeparametertodevice(1, ADDRESS_EEPROM_MAP_TYPE, signcount, True)) Then
                'no responses received, communication error 
                bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
                e.Cancel = True
                Return
                currentProgress += increment / 3
                bgw.ReportProgress(currentProgress, process & "sending configuration data")

            End If



        End If

        If bgw.CancellationPending Then
            bgw.ReportProgress(currentProgress, process & "Send Data Cancled")
            e.Cancel = True
            Return
        End If





        If signcount <= MAXSIGNSBEFOREREPONSEOVERFLOW Then
            'if their are fewer signs then sould overflow the receive buffer on the bas unit then we count responses and give warning if differen then expected 
            'consider failure and exit only if there are 0 valid responses


            responsesreceived = broadcast_writeparametertodevice(linecount, ADDRESS_LINECOUNT, signcount)
            If (responsesreceived = 0) Then
                'no responses received, communication error 
                bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
                e.Cancel = True
                Return
            Else

                If (responsesreceived <> signcount) Then

                    If responsesreceived < minresponsesreceived Then
                        minresponsesreceived = responsesreceived

                    End If


                    If responsesreceived > maxresponsesreceived Then
                        maxresponsesreceived = responsesreceived

                    End If

                    If minresponsesreceived < signcount And maxresponsesreceived > signcount Then
                        'most unusuall situation, we have fluctuated between too many and too few signs
                        warning = "Inconsistant sign communication!"
                        warning &= Constants.vbCrLf & "Expected: " & signcount & " Min: " & minresponsesreceived & " Max: " & maxresponsesreceived

                    ElseIf minresponsesreceived < signcount Then
                        warning = "Communication error with at least " & (signcount - minresponsesreceived) & " Signs"
                        warning &= Constants.vbCrLf & "Expected: " & signcount & " Min: " & minresponsesreceived & " Max: " & maxresponsesreceived

                    ElseIf maxresponsesreceived > signcount Then
                        warning = "More signs then expected " & (signcount - minresponsesreceived) & " Signs"
                        warning &= Constants.vbCrLf & "Expected: " & signcount & " Min: " & minresponsesreceived & " Max: " & maxresponsesreceived

                    End If



                End If
                currentProgress += increment / 3
                bgw.ReportProgress(currentProgress, process & "sending configuration data" & Constants.vbCrLf & warning)

            End If

        Else
            'if there are more signs then the receive buffer on the base unit can handle 
            'then we consider communication sucessful if there is at least one valid response


            If (Not broadcast_writeparametertodevice(linecount, ADDRESS_LINECOUNT, signcount, True)) Then
                'failed to receive at least 1 valid response, communication error 
                bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
                e.Cancel = True
                Return
                currentProgress += increment / 3
                bgw.ReportProgress(currentProgress, process & "sending configuration data")

            End If





        End If



        If bgw.CancellationPending Then
            bgw.ReportProgress(currentProgress, process & "Cancled!")
            e.Cancel = True
            Return
        End If




        If signcount <= MAXSIGNSBEFOREREPONSEOVERFLOW Then
            'if their are fewer signs then sould overflow the receive buffer on the bas unit then we count responses and give warning if differen then expected 
            'consider failure and exit only if there are 0 valid responses

            responsesreceived = broadcast_writeparametertodevice(linelength, ADDRESS_LINELENGTH, signcount)
            If (responsesreceived = 0) Then
                'no responses received, communication error 
                bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
                e.Cancel = True
                Return
            Else

                If (responsesreceived <> signcount) Then

                    If responsesreceived < minresponsesreceived Then
                        minresponsesreceived = responsesreceived

                    End If


                    If responsesreceived > maxresponsesreceived Then
                        maxresponsesreceived = responsesreceived

                    End If

                    If minresponsesreceived < signcount And maxresponsesreceived > signcount Then
                        'most unusuall situation, we have fluctuated between too many and too few signs
                        warning = "Inconsistant sign communication!"
                        warning &= Constants.vbCrLf & "Expected: " & signcount & " Min: " & minresponsesreceived & " Max: " & maxresponsesreceived

                    ElseIf minresponsesreceived < signcount Then
                        warning = "Communication error with at least " & (signcount - minresponsesreceived) & " Signs"
                        warning &= Constants.vbCrLf & "Expected: " & signcount & " Min: " & minresponsesreceived & " Max: " & maxresponsesreceived

                    ElseIf maxresponsesreceived > signcount Then
                        warning = "More signs then expected " & (signcount - minresponsesreceived) & " Signs"
                        warning &= Constants.vbCrLf & "Expected: " & signcount & " Min: " & minresponsesreceived & " Max: " & maxresponsesreceived

                    End If



                End If
                currentProgress += increment / 3
                bgw.ReportProgress(currentProgress, process & "sending configuration data" & Constants.vbCrLf & warning)

            End If

        Else
            'if there are more signs then the receive buffer on the base unit can handle 
            'then we consider communication sucessful if there is at least one valid response


            If (Not broadcast_writeparametertodevice(linelength, ADDRESS_LINELENGTH, signcount, True)) Then
                'failed to receive at least 1 valid response, communication error 
                bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
                e.Cancel = True
                Return
                currentProgress += increment / 3
                bgw.ReportProgress(currentProgress, process & "sending configuration data")

            End If



        End If
        Dim textdatacopy As ArrayList = textdata

        While (textdatawalker < textdatacopy.Count)
            bgw.ReportProgress(currentProgress, process & "sending line " & (textdatawalker + 1).ToString & " of " & linecount)
            If bgw.CancellationPending Then
                bgw.ReportProgress(currentProgress, process & "Cancled!")
                e.Cancel = True
                Return
            End If


            'MsgBox(address_ptr)
            If signcount <= MAXSIGNSBEFOREREPONSEOVERFLOW Then
                'if their are fewer signs then sould overflow the receive buffer on the bas unit then we count responses and give warning if differen then expected 
                'consider failure and exit only if there are 0 valid responses

                responsesreceived = Broadcast_writeToDevice(address_ptr, textdatacopy(textdatawalker), signcount)
                If (responsesreceived = 0) Then
                    'no responses received, communication error 
                    bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
                    e.Cancel = True
                    Return
                Else

                    If (responsesreceived <> signcount) Then

                        If responsesreceived < minresponsesreceived Then
                            minresponsesreceived = responsesreceived

                        End If


                        If responsesreceived > maxresponsesreceived Then
                            maxresponsesreceived = responsesreceived

                        End If

                        If minresponsesreceived < signcount And maxresponsesreceived > signcount Then
                            'most unusuall situation, we have fluctuated between too many and too few signs
                            warning = "Inconsistant sign communication!"
                            warning &= Constants.vbCrLf & "Expected: " & signcount & " Min: " & minresponsesreceived & " Max: " & maxresponsesreceived

                        ElseIf minresponsesreceived < signcount Then
                            warning = "Communication error with at least " & (signcount - minresponsesreceived) & " Signs"
                            warning &= Constants.vbCrLf & "Expected: " & signcount & " Min: " & minresponsesreceived & " Max: " & maxresponsesreceived

                        ElseIf maxresponsesreceived > signcount Then
                            warning = "More signs then expected " & (signcount - minresponsesreceived) & " Signs"
                            warning &= Constants.vbCrLf & "Expected: " & signcount & " Min: " & minresponsesreceived & " Max: " & maxresponsesreceived

                        End If



                    End If
                    currentProgress += increment
                    bgw.ReportProgress(currentProgress, process & "sending configuration data" & Constants.vbCrLf & warning)


                End If




            Else
                'if there are more signs then the receive buffer on the base unit can handle 
                'then we consider communication sucessful if there is at least one valid response


                If (Not Broadcast_writeToDevice(address_ptr, textdatacopy(textdatawalker), , True)) Then
                    'failed to receive at least 1 valid response, communication error 
                    bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending lines")
                    e.Cancel = True
                    Return
                    

                End If




            End If


            textdatawalker += 1
            address_ptr += linelength

        End While




        address_ptr = address_startoftrickdata





        Dim trickswalker As Integer = 0


        trickstartpointersindex = 1


        bgw.ReportProgress(currentProgress, process & "sending display patterns " & Constants.vbCrLf & warning)

        If bgw.CancellationPending Then

            bgw.ReportProgress(currentProgress, process & "Cancled!")
            e.Cancel = True
            Return
        End If


        Dim trickdatacopy As ArrayList = trickdata

        While trickswalker < trickdatacopy.Count
            bgw.ReportProgress(currentProgress, process & "sending display pattern  " + trickstartpointersindex.ToString + "of " + trickcount.ToString)

            If bgw.CancellationPending Then
                bgw.ReportProgress(currentProgress, process & "Cancled!")
                e.Cancel = True
                Return
            End If



            responsesreceived = broadcast_writeparametertodevice(trickdatacopy(trickswalker), address_ptr, signcount)
            If (responsesreceived = 0) Then
                'no responses received, communication error 
                bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
                e.Cancel = True
                Return
            Else

                If (responsesreceived <> signcount) Then

                    If responsesreceived < minresponsesreceived Then
                        minresponsesreceived = responsesreceived

                    End If


                    If responsesreceived > maxresponsesreceived Then
                        maxresponsesreceived = responsesreceived

                    End If

                    If minresponsesreceived < signcount And maxresponsesreceived > signcount Then
                        'most unusuall situation, we have fluctuated between too many and too few signs
                        warning = "Inconsistant sign communication!"
                        warning &= Constants.vbCrLf & "Expected: " & signcount & " Min: " & minresponsesreceived & " Max: " & maxresponsesreceived

                    ElseIf minresponsesreceived < signcount Then
                        warning = "Communication error with at least " & (signcount - minresponsesreceived) & " Signs"
                        warning &= Constants.vbCrLf & "Expected: " & signcount & " Min: " & minresponsesreceived & " Max: " & maxresponsesreceived

                    ElseIf maxresponsesreceived > signcount Then
                        warning = "More signs then expected " & (signcount - minresponsesreceived) & " Signs"
                        warning &= Constants.vbCrLf & "Expected: " & signcount & " Min: " & minresponsesreceived & " Max: " & maxresponsesreceived

                    End If



                End If
                currentProgress += increment / trickdatacopy.Count
                bgw.ReportProgress(currentProgress, process & "sending configuration data" & Constants.vbCrLf & warning)

            End If

            'writeparametertodevice(trickdatacopy(trickswalker), address_ptr)

            If trickstartpointersindex < trickstartpointerscopy.Count Then
                If (trickswalker = trickstartpointerscopy(trickstartpointersindex)) Then
                    'bgw.ReportProgress(currentProgress, process & "sending display patterns ")
                    'update_progress_form("display pattern " + trickstartpointersindex.ToString + "of " + trickcount.ToString + " sent")
                    'trickstartpointersindex += 1
                End If

            End If

            currentProgress += increment / trickdatacopy.Count
            trickswalker += 1
            address_ptr += 1
        End While
        'update_progress_form("display pattern " + trickstartpointersindex + "of " + trickcount + " sent")

        bgw.ReportProgress(currentProgress, process & "Finished sending data" & Constants.vbCrLf & warning)



    End Sub

    Public Sub New(ByRef CM As ComportManager)


        'Me.New()
        'there can only be one comport manager in the whole program
        mycomportmanager = CM
    End Sub

    Public Sub New(ByRef signconnection_onesign_wireless As SignConnection_OneSign_Wireless_XB)
        mycomportmanager = signconnection_onesign_wireless.comportmanager
        _allSigns_working = signconnection_onesign_wireless.allSigns_working
        _allSigns_NeedFirmware = signconnection_onesign_wireless.allSigns_NeedFirmware
        _allSigns_malfunctioning = signconnection_onesign_wireless.allSigns_malfunctioning
        _allSigns_notFound = signconnection_onesign_wireless.allSigns_notFound


    End Sub
    Protected Overridable Function broadcast_writeparametertodevice(ByRef value As Integer, ByVal address As Integer, Optional ByVal expectedsigns As UInt16 = 0, Optional ByVal truefalsemode As Boolean = False) As UInt16


        If (value > 255) Then

            MsgBox("parameter value greater then 255 passed to writeparametertodevice")

            If truefalsemode Then
                Return False
            Else
                Return 0
            End If

        End If

        Return broadcast_writecharactertodevice(Chr(value), address, expectedsigns, truefalsemode)


    End Function

    Protected Overridable Function Broadcast_writeToDevice(ByVal startaddress As Integer, ByVal text As String, Optional ByVal expectedsigns As UInt16 = 0, Optional ByVal truefalsemode As Boolean = False) As UInt16
        'this function write a string to the EEprom     
        'backgroundworkerdebugvalue = "290"

        Dim returnvalue As UInt16 = 0

        Dim i As Integer = 0

        Dim responseline As String = ""

        While text.Length() < linelength
            'of the tesxt pass is to short padd with space
            text += " "
        End While

        While (i < linelength)
            'backgroundworkerdebugvalue = (i + 201).ToString
            Dim tempreturnvalue As UInt16





            tempreturnvalue = broadcast_writecharactertodevice(text.Substring(i, 1), startaddress + i, expectedsigns, truefalsemode)

            If truefalsemode And tempreturnvalue = False Then
                Return False
            End If

            If tempreturnvalue < returnvalue Then
                returnvalue = tempreturnvalue
            End If

            If returnvalue = 0 Then
                'if no valid responses then stop 
                Return 0

            End If




            i = i + 1

        End While
        '   backgroundworkerdebugvalue = "292"


        Return returnvalue


    End Function




    Protected Overridable Function broadcast_writecharactertodevice(ByRef character As Char, ByVal address As Integer, Optional ByVal expectedsigns As UInt16 = 0, Optional ByVal truefalsemode As Boolean = False) As UInt16
        'writes a single charater to the device 

        Dim line As String = ""
        Dim addressasstring As String = addresstostring(address)
        'backgroundworkerdebugvalue = "305"
        Dim myaddresscommand As String = "A " + addresstostring(address) + Constants.vbCrLf
        'backgroundworkerdebugvalue = "306"
        Dim mywritecommand As String = "W "
        mywritecommand = convertCharacterToWriteComand(character)


        Dim attemps As Integer = 0
        'With mySerialPort
        'backgroundworkerdebugvalue = "307"

        Dim validAddressresponescount As UInt16 = 0
        Dim validWriteresponescount As UInt16 = 0

        While (True)
            'address command loop


            If writeThenReadline(myaddresscommand, line, 1000, 3, 0.5) <> CommunicationResult.success Then


                'communication completely fails after 3 attempts


                If truefalsemode Then
                    Return False
                Else
                    'return zero valid responses
                    Return 0
                End If

            End If

            Dim splitline As String() = line.Split("A")
            Dim tempresponsecount As Int16 = 0

            For Each response As String In splitline

                If ("A" + response.TrimEnd = myaddresscommand.TrimEnd) Then
                    tempresponsecount += 1
                End If

            Next



            If expectedsigns = 0 And tempresponsecount >= 1 Then

                'the dummy value indicating no expected sign count was passed
                'and there is at least 1 valid response
                validAddressresponescount = tempresponsecount
                Exit While

            ElseIf expectedsigns >= tempresponsecount Then
                'correct number of responses or too many responses
                validAddressresponescount = tempresponsecount
                Exit While
            Else
                'too few responses
                If validAddressresponescount < tempresponsecount Then
                    'use the highest value of all attempts
                    validAddressresponescount = tempresponsecount
                End If

                If attemps > 3 Then
                    'if too few responses 3 times in a row give up

                    Exit While
                Else
                    attemps += 1
                End If
            End If

        End While






        While (True)
            'write command loop


            If writeThenReadline(mywritecommand, line, 1000, 3, 0.5) <> CommunicationResult.success Then
                'communication completely fails after 3 attempts
                If truefalsemode Then
                    Return False
                Else
                    'return zero valid responses
                    Return 0
                End If
            End If

            Dim splitline As String() = line.Split("W")
            Dim tempresponsecount As Int16 = 0

            For Each response As String In splitline

                If ("W" + response.TrimEnd = myaddresscommand.TrimEnd) Then
                    tempresponsecount += 1
                End If

            Next



            If expectedsigns = 0 And tempresponsecount >= 1 Then

                'the dummy value indicating no expected sign count was passed
                'and there is at least 1 valid response
                validWriteresponescount = tempresponsecount
                Exit While

            ElseIf expectedsigns >= tempresponsecount Then
                'correct number of responses (or too many responses)
                validWriteresponescount = tempresponsecount
                Exit While
            Else
                'too few responses
                If validWriteresponescount < tempresponsecount Then
                    'use the highest value of all attempts
                    validWriteresponescount = tempresponsecount
                End If

                If attemps > 3 Then
                    'if too few responses 3 times in a row give up

                    Exit While
                Else
                    attemps += 1
                End If
            End If

        End While

        Dim returnvalue = validWriteresponescount
        If returnvalue > validAddressresponescount Then
            'if the count of valid addres responses differs from the count of the write responses 
            'use the lower count
            returnvalue = validAddressresponescount
        End If

        If truefalsemode Then
            If returnvalue = expectedsigns Then
                Return True
            Else
                Return False
            End If


        Else
            Return returnvalue
        End If



    End Function
End Class
