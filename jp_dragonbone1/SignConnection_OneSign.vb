Imports portConnectionHandle = System.Int16 'create an alias to make function signatures less confusing
Public Class SignConnection_OneSign
    Inherits SignConnection_Base



    



    'legacy variables
    


    

    

    






    'virtual functions


    'the following virtual functions are inherited from base class

    'Public Overridable Function connect(ByVal signidentifyer As Object) As Object
    'Public Overridable Function connect(ByVal signidentifyer As String) As Object
    'Public Overridable Function disconnect() As Object
    'Public Overridable Function sendData() As Object
    'Public Overridable Function GetData() As Object


    '''
    



    'Protected Overridable Function writeThenReadline(ByVal writestring As String, ByRef readstring As String, Optional ByVal maxlength As Int64 = 100, Optional ByVal attempts As UInt16 = 1, Optional ByVal CommunicationTimeoutInSeconds As Double = 1, Optional ByVal ConnectionBusyTimeoutInSeconds As Double = 5, Optional ByVal preWriteGuardTimeInseconds As Double = 0) As CommunicationResult
    '    Throw New Exception("You are calling a function that is virtual and must be overidden")

    'End Function

    'Protected Overridable Function writeThenReadChars(ByVal writestring As String, ByRef readstring As String, Optional ByVal length As Int64 = 10, Optional ByVal attempts As UInt16 = 1, Optional ByVal communicationTimeOutInSeconds As Double = 1, Optional ByVal ConnectionBusyTimeOutInSeconds As Double = 5, Optional ByVal preWriteGuardTimeInseconds As Double = 0) As CommunicationResult
    '    Throw New Exception("You are calling a function that is virtual and must be overidden")

    'End Function

    'Protected Overridable Function writeThenReadexisting(ByVal writestring As String, ByRef readstring As String, Optional ByVal attempts As UInt16 = 1, Optional ByVal ConnectionBusyTimeOutInSeconds As Double = 5, Optional ByVal preWriteGuardTimeInseconds As Double = 0) As CommunicationResult
    '    Throw New Exception("You are calling a function that is virtual and must be overidden")

    'End Function


    'implemented functions
    Public Overridable Function getFirmwareVersion(ByRef major_version As String, ByRef minor_version As String, Optional ByVal comhandle As portConnectionHandle = Nothing) As Boolean


        If comhandle = Nothing Then
            comhandle = myPortConnectionHandle
        End If

        Dim line As String = ""
        'Dim addressasstring As String = addresstostring(address)
        ' Dim myaddresscommand As String = "A " + addresstostring(address) + Constants.vbCrLf

        Dim attemps As Integer = 0

        While (True)

            If writeThenReadline(VERSIONCOMMAND, line, VERSIONRESPONSELENGTH, 2, communication_time_out_in_seconds, 5, 0, comhandle) <> CommunicationResult.success Then
                Return False
            End If

            If (Not validFirmwareVersionResponse(line)) Then
                If (attemps < 3) Then
                    attemps = attemps + 1

                Else

                    Return False
                End If

            Else
                major_version = Convert.ToInt32(line.Substring(2, 2), 16)
                minor_version = Convert.ToInt32(line.Substring(4, 2), 16)

                Return True
            End If

        End While

    End Function
    'functions related to get data
    Public Overrides Function getData() As Object

        Form1.timer_monitor_ifdoubleclickmanuel.Stop()


        Form1.cancelopenfile(Form1.cancelopenfileflags.saveCurrentState)
        If Not MarshallingInitialized Then
            initialisemarshalling()
        End If


        myProgressForm = New ProgressForm()
        myProgressForm.retryfunction = AddressOf getData_do
        getData_do()

        myProgressForm.ShowDialog()

        'from here down occurs after the background process has completed 
        'and the user clickec ok on progress form
        '(the functions holds while the progess form is showing)



        If myProgressForm.But_retry.Visible Then
            'the retry button is visible meaning that the process did not succesfully complete
            Form1.cancelopenfile(Form1.cancelopenfileflags.restoreStoredState)
            Return True


        Else

            'Form1.sincronizelinelength(readlinelength)
            If (Not Form1.pan_filerestrictions.Visible) Then
                'backgroundworkerdebugvalue = "bb4"
                Form1.refresh_Pan_trick_parameters() 'a dynamically created panal that has the interface for entering trick data
                'backgroundworkerdebugvalue = "bb5"
            End If
            'backgroundworkerdebugvalue = "bb6"

            simulator_form._refresh() 'the sign simulator. may or may not be showing
            Form1.refresh_demo()
        End If

        Return True 'need to impliment way of checking result, perhaps on progress form
    End Function

    Private Sub getData_do()
        'this function seperated from sendData so that it can be called when the retry button is pressed on progress form

        Dim bgw As System.ComponentModel.BackgroundWorker = New System.ComponentModel.BackgroundWorker
        myProgressForm.bgw = bgw
        myProgressForm.autocloseatcompletions = False
        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True
        AddHandler bgw.DoWork, AddressOf getData_backgroundWork
        AddHandler bgw.ProgressChanged, AddressOf common_backgroundwork_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf common_backgroundwork_RunWorkerCompleted
        bgw.RunWorkerAsync()
    End Sub
    Dim readlinelength As Int16 = 0

    Protected Overridable Sub getData_backgroundWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        ''copied from send data
        Dim trickdatacopy As ArrayList = New ArrayList
        Dim process = "Get data from sign" & Constants.vbCrLf
        Dim bgw As System.ComponentModel.BackgroundWorker = sender

        'Dim steps As Int16 = Form1.linecount + 2
        'Dim steps As Int16 = linecount + 2

        Dim steps As Int16 = linecount + 2
        Dim increment As Single = 100.0 / steps
        Dim currentProgress As Single = 0
        Dim command As String = ""
        Dim response As String = ""
        Dim commandnumber As Int16 = 0
        Dim expetedresponse As String = ""
        'Dim result As CommunicationResult
        'configuration data
        bgw.ReportProgress(currentProgress, process & "Processing configuration data, Please wait. ")

        If bgw.CancellationPending Then
            bgw.ReportProgress(currentProgress, process & "Cancled!")
            e.Cancel = True

            Return
        End If

        'get configuration data
        'ie linelength, linecount and timetoshoweachline


        command = "G3" & Chr(1) & utilities.int2Hex(commandnumber, 2) & "C" & Constants.vbCrLf
        command = appendcheckdigit(command, 3)

        Dim attemtcount = 1
        Dim MAXATTEMTPS = 3
        Dim retry = True
        While (retry)


            If bgw.CancellationPending Then
                bgw.ReportProgress(currentProgress, process & "Cancled!")
                e.Cancel = True

                Return
            End If

            retry = False  'changming 040413

            If writeThenReadline(command, response, 260, 3, Me.communication_time_out_in_seconds) <> CommunicationResult.success Then
                '042113  Changming and JP
                attemtcount += 1
                If (attemtcount <= MAXATTEMTPS) Then

                    bgw.ReportProgress(currentProgress, process & "Communication error while sending Configuration data - retrying appemt " & attemtcount)

                    retry = True
                    Continue While

                End If

                bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
                e.Cancel = True
                Return

            End If


            If bgw.CancellationPending Then
                bgw.ReportProgress(currentProgress, process & "Cancled!")
                e.Cancel = True

                Return
            End If

            If (Not response.StartsWith("G3" & Chr(1) & utilities.int2Hex(commandnumber, 2) & "C")) Then
                attemtcount += 1
                If (attemtcount <= MAXATTEMTPS) Then

                    bgw.ReportProgress(currentProgress, process & "Communication error while sending Configuration data - retrying appemt " & attemtcount)

                    retry = True
                    Continue While

                End If



                bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
                e.Cancel = True
                Return
            End If

            Try




                'convert hex to int
                '032913  JP said so  with Changming  3 numbers should add 1 

                Me.linelength = Convert.ToInt16(response.Substring(6, 2), 16)

                Me.linecount = Convert.ToInt16(response.Substring(8, 2), 16)

                protocol3TrickParameters = response.Substring(10, 3)

            Catch ex As Exception
                'reach here one of these reasons 
                '-nonhexvalues where expected in response
                '-pattern type other then C or R
                '-constant line other the line 0
                '-short response that generates a substring error

                attemtcount += 1
                If (attemtcount <= MAXATTEMTPS) Then

                    bgw.ReportProgress(currentProgress, process & "Communication error while sending Configuration data - retrying appemt " & attemtcount)

                    retry = True
                    Continue While

                End If

            End Try


        End While  'end protocal 3



        If bgw.CancellationPending Then
            bgw.ReportProgress(currentProgress, process & "Cancled!")
            e.Cancel = True

            Return
        End If



        ' Get text data  -- Changming  040713 with JP
        'creating get data command:
        Dim maxLinesPerCommand As Int16 = (255 - 14) / (Me.linelength + 4)
        Dim linesInCommandCounter = 0
        Dim startLineIndex As Int16 = 0

        Dim textdatacopy As ArrayList = New ArrayList 'read data in one swoop then marshal to form1

        Dim numberOfCommands As Int16 = linecount / maxLinesPerCommand + 1
        Dim ProcesStep = 100 / numberOfCommands

        currentProgress = ProcesStep

        'start the loop

        bgw.ReportProgress(currentProgress, process & "Getting text data lines -- " & startLineIndex & " - to-  " & (startLineIndex + maxLinesPerCommand))

        While (startLineIndex < linecount)


            If bgw.CancellationPending Then
                bgw.ReportProgress(currentProgress, process & "Cancled!")
                e.Cancel = True

                Return
            End If

            'paste 040713  starts

            attemtcount = 1
            MAXATTEMTPS = 3
            Dim retry2 = True

            While (retry2)


                If bgw.CancellationPending Then
                    bgw.ReportProgress(currentProgress, process & "Cancled!")
                    e.Cancel = True

                    Return
                End If

                bgw.ReportProgress(currentProgress, process & "Getting text data lines -- " & startLineIndex & " - to-  " & (startLineIndex + maxLinesPerCommand))

                retry2 = False  'changming 040413

                If commandnumber = 255 Then
                    commandnumber = 0
                Else
                    commandnumber = commandnumber + 1
                End If
                command = "G3" & Chr(1) & utilities.int2Hex(commandnumber, 2) & "T" & utilities.int2Hex(startLineIndex, 2) & utilities.int2Hex(maxLinesPerCommand, 2) & Constants.vbCrLf

                ' change into G3 from S2                 '  040713 
                'Data type 'T'  get command format G<3><\1><comandNumber><“T”><startLineIndex><numberLinesOfRequested><checkdigit><\r\n>

                command = appendcheckdigit(command, 3)


                If writeThenReadline(command, response, 255, 3, Me.communication_time_out_in_seconds) <> CommunicationResult.success Then
                    attemtcount += 1
                    If (attemtcount <= MAXATTEMTPS) Then

                        bgw.ReportProgress(currentProgress, process & "Communication error while sending Configuration data - retrying appemt " & attemtcount)

                        retry2 = True
                        Continue While

                    End If

                    bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
                    e.Cancel = True

                    Return

                End If


                If bgw.CancellationPending Then
                    bgw.ReportProgress(currentProgress, process & "Cancled!")
                    e.Cancel = True

                    Return
                End If

                If (Not response.StartsWith("G3" & Chr(1) & utilities.int2Hex(commandnumber, 2) & "T")) Then
                    attemtcount += 1
                    If (attemtcount <= MAXATTEMTPS) Then

                        bgw.ReportProgress(currentProgress, process & "Communication error while Getting Text data - Retrying attempt # " & attemtcount)

                        retry2 = True
                        Continue While

                    End If



                    bgw.ReportProgress(currentProgress, "ERROR - " & process & "Communication error while Getting Text data")
                    e.Cancel = True
                    Return
                End If

                Try


                    'Data(Type) 'T'  get response
                    'G<3><\1><comandNumber><“T”><startLineIndex><numberLinesOfInResponse><checkdigit><\r\n>

                    If (Convert.ToInt16(response.Substring(6, 2), 16) <> startLineIndex) Then


                        attemtcount += 1
                        If (attemtcount <= MAXATTEMTPS) Then

                            bgw.ReportProgress(currentProgress, process & "Communication error type 2 while Getng Textdata - Retrying attempt # " & attemtcount)

                            retry2 = True
                            Continue While

                        End If


                        bgw.ReportProgress(currentProgress, "ERROR - " & process & "Communication error while Getting Text data")
                        e.Cancel = True
                        Return



                        ' Data(Type) 'T'  get response
                        ' G<3><\1><comandNumber><“T”><startLineIndex><numberLinesOfInResponse><textdata><checkdigit><\r\n>
                        ' 1  1  1        2        1      2                      2             ( upto 10)      2       2  = ?? 

                    End If

                    Dim LinesPerCommand = Convert.ToInt16(response.Substring(8, 2), 16)
                    Dim loopLinecounter = 0

                    maxLinesPerCommand = LinesPerCommand
                    'In case TiniWindow mis-calculate maxlinepercommand, reset to actual number of line from the firmware 
                    '40713

                    While (loopLinecounter < LinesPerCommand)

                        Dim thisline As String = response.Substring(10 + loopLinecounter * linelength, linelength)

                        textdatacopy.Add(thisline)

                        loopLinecounter = loopLinecounter + 1

                        If bgw.CancellationPending Then
                            bgw.ReportProgress(currentProgress, process & "Cancled!")
                            e.Cancel = True

                            Return
                        End If

                    End While

                    startLineIndex = startLineIndex + LinesPerCommand

                    currentProgress += ProcesStep

                Catch ex As Exception
                    'reach here one of these reasons 
                    '-nonhexvalues where expected in response
                    '-pattern type other then C or R
                    '-constant line other the line 0
                    '-short response that generates a substring error

                    attemtcount += 1
                    If (attemtcount <= MAXATTEMTPS) Then

                        bgw.ReportProgress(currentProgress, process & "Communication error while sending Configuration data - retrying appemt " & attemtcount)

                        retry2 = True
                        Continue While

                    End If

                End Try


            End While  'end protocal 3


            'end of paste 0407

        End While

        textdata = textdatacopy

        currentProgress = 100

        bgw.ReportProgress(currentProgress, process & "Finished getting all sign data. Please Click Continue.")

        Return

       
    End Sub


    Private Sub tricks_initialize(ByRef trickdatacopy)
        'this function clears the trick array 
        'and set the first 2 value so that tricks can be added
        'an error condition will result if no tricks are added after calling this function
        trickdatacopy = New ArrayList
        trickdatacopy.Add(0) 'number of tricks = 1
        trickdatacopy.Add(0) 'current trick = 0 
    End Sub
    Private Function tricks_append_rotatethroughlines(ByRef trickdatacopy As ArrayList, ByVal trick_startline As Integer, ByVal trick_linecount As Integer, ByVal trick_time As Integer) As Boolean


        If (trick_startline > linecount Or trick_startline < 0) Then
            Return False
        End If

        If (trick_linecount > linecount Or trick_linecount < 0) Then
            Return False
        End If

        If (trick_time > 255 Or trick_time < 0) Then
            Return False
        End If


        If trickdatacopy.Count < 2 Then
            Return False
        End If
        If trickdatacopy(0) >= 255 Or trickdatacopy(0) < 0 Then
            Return False
        End If


        trickdatacopy(0) += 1 ' number of tricks

        trickdatacopy.Add(5) 'bytes in trick = 4  -2
        trickdatacopy.Add(1) 'tricktype           -3 
        trickdatacopy.Add(trick_startline) 'line to startwith -4   
        trickdatacopy.Add(trick_linecount) 'lines to rotate through -5
        trickdatacopy.Add(trick_time) 'time each line visible  -6

        Return True


    End Function



    Private Function tricks_append_showoneline(ByRef trickdatacopy As ArrayList, ByVal linenumber As Integer) As Integer


        Return tricks_append_rotatethroughlines(trickdatacopy, linenumber, 1, 255)

    End Function
    Private Function tricks_set_default(ByRef trickdatacopy As ArrayList) As Boolean
        tricks_initialize(trickdatacopy)

        If Not tricks_append_showoneline(trickdatacopy, 0) Then
            Return False
        End If

        Return tricks_append_rotatethroughlines(trickdatacopy, 0, linecount, 10)
    End Function

    Private Function tricks_get_tricktype(ByRef trickdatacopy As ArrayList, ByVal index As Int16, ByVal includetypezero As Boolean) As Integer
        If index > trickdatacopy(0) Or index < 0 Then
            Return (-1)
        End If
        Dim returnvalue As Integer
        Dim loopcounter As Int16 = 0
        Dim indexptr As Integer = 2
        While loopcounter < index
            indexptr += trickdatacopy(indexptr)
            If indexptr >= trickdatacopy.Count Then
                Return -1
            End If
            loopcounter += 1
        End While

        'indexptr is now pointing to the number of bytes for correct trick
        'advance one more memory location to point to trick type
        indexptr += 1
        If indexptr >= trickdatacopy.Count Then
            Return -1
        End If
        returnvalue = (trickdatacopy(indexptr))
        If returnvalue <> 1 Or Not includetypezero Then
            Return returnvalue
        End If
        indexptr += 2
        If indexptr >= trickdatacopy.Count Then
            Return -1
        End If
        If trickdatacopy(indexptr) = 1 Then
            Return 0
        Else
            Return 1
        End If
    End Function

    Private Function tricks_get_tricktype(ByRef trickdatacopy As ArrayList, ByVal index As Int16) As Integer
        If index > trickdatacopy(0) Or index < 0 Then
            Return (-1)
        End If

        Dim loopcounter As Int16 = 0
        Dim indexptr As Integer = 2
        'num of tricks
        'active trick
        'bytes
        'tricktype
        'startline
        'numoflines
        'time
        'bytes
        'tricktype
        'startline
        'numoflines
        'time



        While loopcounter < index
            indexptr += trickdatacopy(indexptr)
            loopcounter += 1
        End While

        'indexptr is now pointing to the number of bytes for correct trick
        'advance one more memory location to point to trick type
        indexptr += 1
        Return (trickdatacopy(indexptr))

    End Function
    Private Function tricks_get_parameters(ByRef trickdatacopy As ArrayList, ByVal index As Int16) As ArrayList

        Dim returnarray As ArrayList = New ArrayList
        If index > trickdatacopy(0) Or index < 0 Then
            Return returnarray
        End If

        Dim loopcounter As Int16 = 0
        Dim indexptr As Integer = 2
        While loopcounter < index
            indexptr += trickdatacopy(indexptr)
            loopcounter += 1
        End While

        'indexptr is now pointing to the number of bytes for correct trick


        Dim bytes As Int16 = (trickdatacopy(indexptr))
        indexptr += 1
        'indexptr is now pointing tricktype

        loopcounter = 0
        While loopcounter < bytes - 2
            indexptr += 1
            returnarray.Add(trickdatacopy(indexptr))


            loopcounter += 1
        End While
        Return returnarray
    End Function


    Private Function tricks_set_parameter(ByRef trickdatacopy As ArrayList, ByVal trickindex As Int16, ByVal parameterindex As Int16, ByVal value As Int16) As Boolean

        If trickindex > trickdatacopy(0) Or trickindex < 0 Then
            Return False
        End If

        Dim loopcounter As Int16 = 0
        Dim indexptr As Integer = 2
        While loopcounter < trickindex
            indexptr += trickdatacopy(indexptr)
            loopcounter += 1
        End While

        'indexptr is now pointing to the number of bytes for correct trick

        Dim bytes As Int16 = (trickdatacopy(indexptr))

        If bytes - 2 < parameterindex Then
            'there are 2 more bytes then parameters these are bytes and tricktype
            Return False
        End If

        indexptr += 1
        'indexptr is now pointing to tricktype


        indexptr += parameterindex + 1

        trickdatacopy(indexptr) = value
        Return True


    End Function
    Private Function tricks_set_parameters(ByRef trickdatacopy As ArrayList, ByVal trickindex As Int16, ByVal parameters As ArrayList) As Boolean


        If trickindex > trickdatacopy(0) Or trickindex < 0 Then
            Return False
        End If

        Dim loopcounter As Int16 = 0
        Dim indexptr As Integer = 2
        While loopcounter < trickindex
            indexptr += trickdatacopy(indexptr)
            loopcounter += 1
        End While

        'indexptr is now pointing to the number of bytes for correct trick

        Dim bytes As Int16 = (trickdatacopy(indexptr))

        If bytes <> parameters.Count + 2 Then
            '2 more are bytes and tricktype
            Return False
        End If

        indexptr += 1
        'indexptr is now pointing to tricktype

        loopcounter = 0
        While loopcounter < bytes - 2
            indexptr += 1
            trickdatacopy(indexptr) = parameters(loopcounter)
            loopcounter += 1
        End While
        Return True

    End Function
    Public Function tricks_get_trickcount(ByRef trickdatacopy As ArrayList) As Integer
        Return trickdatacopy(0)
    End Function
    Private Function tricks_swaptricks(ByRef trickdatacopy As ArrayList, ByVal index1 As Int16, ByVal index2 As Int16) As Boolean
        Dim trickcount = tricks_get_trickcount(trickdatacopy)
        If index1 >= trickcount Or index2 >= trickcount Or index1 < 0 Or index2 < 0 Then
            Return False
        End If
        Dim t1parameters As ArrayList = tricks_get_parameters(trickdatacopy, index1)
        Dim t2parameters As ArrayList = tricks_get_parameters(trickdatacopy, index2)

        If t1parameters.Count = 0 Or t2parameters.Count = 0 Then
            'the get parameters function failed
            Return False
        End If


        If t1parameters.Count <> t2parameters.Count Then
            'tricks use differing numbers of bytes
            'for now fails 
            'latter on will do more work to create new arraylist to allow this
            Return False
        End If

        If tricks_get_tricktype(trickdatacopy, index1) <> tricks_get_tricktype(trickdatacopy, index2) Then
            'different trick types
            'for now fails
            'later on work will be done to make it possible 
            Return False
        End If

        If Not tricks_set_parameters(trickdatacopy, index1, t2parameters) Then
            Return False
        End If

        If Not tricks_set_parameters(trickdatacopy, index2, t1parameters) Then
            Return False
        End If

        'nothing failed
        Return True
    End Function
    Private Function tricks_makecompatible_with_1_003(ByRef trickdatacopy As ArrayList) As Boolean
        If Not tricks_datavalid(trickdatacopy) Then
            Return False
        End If
        Dim trickcount As Int16 = trickdatacopy(0)

        If trickcount = 1 Then
            If tricks_get_tricktype(trickdatacopy, 0, True) = 0 Then
                'append a rotate trhough lines trick with default values
                tricks_append_rotatethroughlines(trickdatacopy, 1, linecount, 1)
                Return True
            ElseIf tricks_get_tricktype(trickdatacopy, 0, True) = 1 Then
                'make the 0th trick a default show one line move the current trick to index 1

                'this is done by storing the values of the current trick, setting default tricks then setting trick 1 to stored value
                Dim trick1parameters As ArrayList = tricks_get_parameters(trickdatacopy, 0)
                tricks_set_default(trickdatacopy)
                tricks_set_parameters(trickdatacopy, 1, trick1parameters)
                Return True
            Else
                Return False
            End If
        ElseIf trickcount = 2 Then
            If tricks_get_tricktype(trickdatacopy, 0, True) = 0 And (tricks_get_tricktype(trickdatacopy, 1, True) = 1) Then
                Return True
            ElseIf tricks_get_tricktype(trickdatacopy, 0, True) = 0 And linecount = 1 And tricks_get_tricktype(trickdatacopy, 1, True) = 0 Then
                'with only one line it is only possible to rotate through 1 line. this situation is tricktype 0 by definition
                Return True
            ElseIf tricks_get_tricktype(trickdatacopy, 0, True) = 1 And tricks_get_tricktype(trickdatacopy, 1, True) = 0 Then
                Return tricks_swaptricks(trickdatacopy, 0, 1)

            End If

        Else
            Return False


        End If

    End Function

    Private Function tricks_makecompatible_with_1_003(ByRef trickdatacopy As ArrayList, ByVal discard_tricks As Boolean) As Boolean
        'the only time false is returned is if discard_tricks is false
        'otherwise default tricks are set if no other way to make compatible

        If Not discard_tricks Then
            Return tricks_makecompatible_with_1_003(trickdatacopy)
        End If

        If tricks_makecompatible_with_1_003(trickdatacopy) Then
            'avoid duplicating code
            Return True
        End If


        If Not tricks_datavalid(trickdatacopy) Then
            tricks_set_default(trickdatacopy)
            Return True
        End If



        Dim trickcount As Int16 = tricks_get_trickcount(trickdatacopy)
        'Dim trick0indexes As ArrayList = New ArrayList
        'in version 1.03 the only supported start line for trick 0 is line 0
        Dim trick1indexes As ArrayList = New ArrayList

        Dim loopcounter As Int16 = 0
        Dim indexptr As Integer = 2
        While loopcounter < trickcount
            If tricks_get_tricktype(trickdatacopy, loopcounter, True) = 1 Then
                If tricks_get_parameters(trickdatacopy, loopcounter)(0) = 0 Then
                    'version 1.03 only supports trick1 starting with first line
                    trick1indexes.Add(loopcounter)
                End If


            End If
            indexptr += trickdatacopy(indexptr)
            loopcounter += 1

        End While
        If trick1indexes.Count > 0 Then
            Dim trick1parameters As ArrayList = tricks_get_parameters(trickdatacopy, trick1indexes(0))
            tricks_set_default(trickdatacopy)
            tricks_set_parameters(trickdatacopy, 1, trick1parameters)
        Else
            'no trick type 1 present
            tricks_set_default(trickdatacopy)
        End If

        Return True

    End Function
    Private Function textdatamakessence() As Boolean
        Dim loopcounter As Int16 = 0
        While loopcounter < textdata.Count
            Dim loopcounter2 As Int16 = 0
            Dim thisline As String = textdata(loopcounter)
            While loopcounter2 < thisline.Length

                If loopcounter = linecount - 30 And loopcounter2 = 0 Then
                    'this conditio gets around the bugg with first character in line 11

                    'replace invalid character with space
                    textdata(loopcounter) = " " + thisline.Substring(1)
                    loopcounter2 += 1
                    Continue While
                End If
                If Not isprintablechar(thisline(loopcounter2)) Then
                    'at least one char is not printable
                    Return False
                End If
                loopcounter2 += 1
            End While

            loopcounter += 1

        End While
        'all chars printable
        Return True
    End Function
    Private Function isprintablechar(ByVal ch As Char) As Boolean

        Dim ascii_value As Int16 = AscW(ch)

        'If (ascii_value = 2) Then
        '    'this condition should be removed as soon as the bug with line 11 on the sign is corrected
        '    '2 is the value currently read from this eeprom address
        '    Return True
        'End If

        If AscW(ch) >= 32 And AscW(ch) <= 126 Then
            Return True

        End If
        If AscW(ch) = 128 Then
            Return True
        End If
        If AscW(ch) >= 103 And AscW(ch) <= 255 Then
            If AscW(ch) = 141 Then
                Return False
            End If
            If AscW(ch) = 143 Then
                Return False
            End If
            If AscW(ch) = 144 Then
                Return False
            End If
            If AscW(ch) = 157 Then
                Return False
            End If
            Return True
        End If
        Return False
    End Function

    Private Function textdatamakessence(ByVal textdatacopy) As Boolean
        Dim loopcounter As Int16 = 0
        While loopcounter < textdatacopy.Count
            Dim loopcounter2 As Int16 = 0
            Dim thisline As String = textdatacopy(loopcounter)
            While loopcounter2 < thisline.Length

                If loopcounter = linecount - 30 And loopcounter2 = 0 Then
                    'this conditio gets around the bugg with first character in line 11

                    'replace invalid character with space
                    textdata(loopcounter) = " " + thisline.Substring(1)
                    loopcounter2 += 1
                    Continue While
                End If
                If Not isprintablechar(thisline(loopcounter2)) Then
                    'at least one char is not printable
                    Return False
                End If
                loopcounter2 += 1
            End While

            loopcounter += 1

        End While
        'all chars printable
        Return True
    End Function

    Private Function tricks_datavalid(ByRef trickdatacopy As ArrayList) As Boolean
        'this function tests if the trick data is valid and corrects a few correctable errors

        If trickdatacopy.Count < 3 Then
            Return False
        End If
        Dim trickcount As Int16 = trickdatacopy(0)
        Dim selectedtrick As Int16 = trickdatacopy(1)

        If selectedtrick > trickcount Then
            'if this is the only error it should be fixed rather then telling the user the data is corrupt 
            selectedtrick = 0
        End If

        Dim loopcounter As Int16 = 0
        Dim indexptr As Integer = 2


        While loopcounter < trickcount
            If indexptr >= trickdatacopy.Count Then
                'index is larger then the size of the arraylist
                'may result from invalid values in byte slot
                Return False

            End If



            Dim bytes As Int16 = trickdatacopy(indexptr)
            Dim tricktype As Int16 = trickdatacopy(indexptr + 1)


            If (tricktype = 1) Then
                If bytes = 4 Then
                    'an early version of tiniwindow made an error in the way it stored this value
                    trickdatacopy(indexptr) = 5
                    bytes = 5
                ElseIf bytes = 5 Then
                    'correct value do nothing

                Else
                    'invalid value 
                    Return False

                End If


            End If

            indexptr += bytes


            loopcounter += 1
        End While


        If indexptr < trickdatacopy.Count Then
            'pointer should be one value beyond arraylist if everything is in kilter
            'why its not I'm not sure

            Return False

        End If

        Return True

    End Function

    Private Function readparameterfromdevice(ByRef parameter As Int16, ByVal address As Integer) As Boolean
        Dim line As String = ""
        'Dim addressasstring As String = addresstostring(address)
        Dim myaddresscommand As String = "A " + addresstostring(address) + Constants.vbCrLf
        Dim attemps As Integer = 0
        'With mySerialPort

        While (True)
            'If (progresform_cancle) Then
            'cancle_read_or_write() 'confirms cancle and throws argument exception
            'End If
            line = ""
            If Me.writeThenReadline(myaddresscommand, line, 10, 3, communication_time_out_in_seconds) <> CommunicationResult.success Then
                Return False

            ElseIf (line.TrimEnd <> myaddresscommand.TrimEnd) Then
                If (addressValid(line) And attemps < 3) Then
                    attemps = attemps + 1
                Else

                    If (attemps < 3) Then
                        attemps = attemps + 1
                    Else
                        echoerror = 4 'echo error is no longer consistently used

                        Return False



                    End If

                End If
            Else
                line = ""
                If Me.writeThenReadline(READCOMMAND, line, 10, 3, communication_time_out_in_seconds) <> CommunicationResult.success Then
                    'communication completely fails 
                    'otherwise test that communication was valid
                    Return False

                ElseIf (Not validreadresponse(line)) Then
                    If (attemps < 3) Then
                        attemps = attemps + 1
                    Else
                        echoerror = 4

                        Return False
                    End If


                Else
                    parameter = Convert.ToInt32(line.Substring(2, 2), 16)
                    'MsgBox(address.ToString + "," + line + "," + parameter.ToString)
                    Return True
                End If

            End If


        End While






    End Function


    Private Function readcharacterfromdevice(ByRef text As String, ByVal address As Integer) As Boolean

        'this function reads a character from the device and appends it to the end of text


        Dim line As String = ""
        Dim addressasstring As String = addresstostring(address)
        Dim myaddresscommand As String = "A " + addresstostring(address) + Constants.vbCrLf
        Dim attemps As Integer = 0
        'With mySerialPort

        While (True)
            'If (progresform_cancle) Then
            'cancle_read_or_write() 'confirms cancle and throws argument exception
            'End If

            line = ""
            If Me.writeThenReadline(myaddresscommand, line, 10, 3, communication_time_out_in_seconds) <> CommunicationResult.success Then
                Return False
            ElseIf (line.TrimEnd <> myaddresscommand.TrimEnd) Then
                'MsgBox(line + "," + attemps.ToString)
                If (addressValid(line) And attemps < 3) Then
                    attemps = attemps + 1
                Else
                    If (attemps < 3) Then
                        attemps = attemps + 1
                    Else
                        echoerror = 4

                        Return False



                    End If

                End If
            Else
                line = ""
                If Me.writeThenReadline(READCOMMAND, line, 10, 3, communication_time_out_in_seconds) <> CommunicationResult.success Then
                    'communication completely fails 
                    'otherwise test that communication was valid
                    Return False


                ElseIf (Not validreadresponse(line)) Then
                    If (attemps < 3) Then
                        attemps = attemps + 1
                    Else
                        echoerror = 4

                        Return False
                    End If

                Else
                    Dim intvalue As Integer = Convert.ToInt32(line.Substring(2, 2), 16)

                    Dim charvalue As Char = Chr(intvalue)
                    text += charvalue


                    Return True
                End If

            End If


        End While


    End Function


    Private Function validreadresponse(ByVal line As String) As Boolean
        If (line.Trim.Length() <> READRESPONSELENGTH - 2) Then
            Return False
        End If
        If (line.Substring(0, 2) <> "R ") Then
            Return False
        End If


        If (Not ((line.Substring(2, 1) >= "0" And line.Substring(2, 1) <= "9") Or (line.Substring(2, 1) >= "A" And line.Substring(2, 1) <= "F"))) Then
            Return False
        End If
        If (Not ((line.Substring(3, 1) >= "0" And line.Substring(3, 1) <= "9") Or (line.Substring(3, 1) >= "A" And line.Substring(3, 1) <= "F"))) Then
            Return False
        End If
        Return True
    End Function



    ''end fucntions related to get data
    '''functions related to send data


    Public Overrides Function sendData() As Object

        If Not MarshallingInitialized Then
            initialisemarshalling()
        End If
        myProgressForm.retryfunction = AddressOf sendData_do
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


        Dim process As String = "Sending data to sign" & Constants.vbCr
        Dim bgw As System.ComponentModel.BackgroundWorker = sender
        Dim maxLinesPerCommand As Int16 = (255 - 14) / (Me.linelength + 4)
        Dim commandscount = Math.Round(linecount / maxLinesPerCommand, 0, MidpointRounding.AwayFromZero)
        Dim steps As Int16 = commandscount + 1

        Dim increment As Single = 100.0 / steps
        Dim currentProgress As Single = 0
        Dim command As String = ""
        Dim response As String = ""
        Dim commandnumber As Int16 = 0
        Dim expetedresponse As String = ""
        'Dim result As CommunicationResult
        'configuration data
        bgw.ReportProgress(currentProgress, process & "Processing configuration data, please wait !")

        If bgw.CancellationPending Then
            bgw.ReportProgress(currentProgress, process & "Cancled!")
            e.Cancel = True

            Return
        End If

        command = "S3" & Chr(1) & utilities.int2Hex(commandnumber, 2) & "C" & utilities.int2Hex(Me.linelength, 2) & utilities.int2Hex(Me.linecount, 2) & protocol3TrickParameters() & Constants.vbCrLf

        currentProgress += increment / 3  '1/3 get config data
        If writeThenReadline(command, response, 10, 3, Me.communication_time_out_in_seconds) <> CommunicationResult.success Then
            bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
            e.Cancel = True
            Return

        End If

        currentProgress += increment / 3 '1/3 get config data
        expetedresponse = "S3" & Chr(1) & utilities.int2Hex(commandnumber, 2) & "00"
        If response.Trim <> expetedresponse Then
            bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
            e.Cancel = True
            Return
        End If

        currentProgress += increment / 3 '1/3 get config data
        'backgroundworkerdebugvalue = "001"

        'progress_form.setstepcount(linecount + trickcount + 1)
        Dim trickstartpointerscopy As ArrayList = trickstartpointers
        Dim trickstartpointersindex As Int16 = 0

        'progresform_StepCount = linecount + trickcount


        Dim textdatawalker As Integer = 0
        ADDRESS_STARTOFTEXTDATA = 500 - (linecount * linelength)
        Dim address_ptr As Integer = ADDRESS_STARTOFTEXTDATA
        'backgroundworkerdebugvalue = "110"

        Dim thistry As Int16 = 0


        bgw.ReportProgress(currentProgress, process & "sending configuration data")
        If bgw.CancellationPending Then
            e.Cancel = True
            Return
        End If

        thistry = 0




        Dim linesInCommandCounter = 0

        command = "S2" & Chr(1) & "01" & Chr(1) & "T" & Chr(1)
        command &= utilities.int2Hex(Math.Min(maxLinesPerCommand, Me.linecount))


        Dim textdatacopy As ArrayList = textdata
        While (textdatawalker < textdatacopy.Count)
            If (linesInCommandCounter >= maxLinesPerCommand) Then

                'we have added the maximum lines for this command
                'send and validate response

                Dim checksum = "00" 'temporarily not implimented 

                command &= checksum & Constants.vbCrLf
                response = ""
                Me.communication_time_out_in_seconds = 3
                If writeThenReadline(command, response, 10, 3, Me.communication_time_out_in_seconds) <> CommunicationResult.success Then
                    bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
                    e.Cancel = True
                    Return

                End If

                expetedresponse = "S SAVED"
                If response.Trim.ToUpper <> expetedresponse Then
                    bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
                    e.Cancel = True
                    Return
                End If

                command = "S2" & Chr(1) & "01" & Chr(1) & "T" & Chr(1)
                command &= utilities.int2Hex(Math.Min(maxLinesPerCommand, Me.linecount - textdatawalker))
                linesInCommandCounter = 0
                currentProgress += increment
            End If

            bgw.ReportProgress(currentProgress, process & "sending line " & (textdatawalker + 1).ToString & " of " & linecount)
            If bgw.CancellationPending Then
                bgw.ReportProgress(currentProgress, process & "Cancled!")
                e.Cancel = True
                Return
            End If

            command &= Chr(1) & utilities.int2Hex(textdatawalker, 2) & Chr(1) & textdatacopy(textdatawalker)


            textdatawalker += 1
            linesInCommandCounter += 1
            address_ptr += linelength

        End While


        'last command needs to be sent 
        'unless linecount is an exact multiple of maxLinesPerCommand
        If (linesInCommandCounter > 0) Then


            Dim checksum = "00" 'temporarily not implimented 

            command &= Chr(1) & checksum & Constants.vbCrLf
            response = ""
            If writeThenReadline(command, response, 10, 3, Me.communication_time_out_in_seconds) <> CommunicationResult.success Then
                bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
                e.Cancel = True
                Return

            End If
            expetedresponse = "S SAVED"
            If response.Trim.ToUpper <> expetedresponse Then
                bgw.ReportProgress(currentProgress, "ERROR " & process & "Communication error while sending Configuration data")
                e.Cancel = True
                Return
            End If
        End If
        ''''
        currentProgress = 100
        bgw.ReportProgress(currentProgress, process & "Sending data Finished. Please Click Contine ")

    End Sub

    Property protocol3TrickParameters() As String
        Get
            Dim returnvalue As String = ""
            Dim trickdatacopy As ArrayList = trickdata
            Dim activeTrick = trickdatacopy(1)
            If activeTrick = 0 Then
                'this version of tiniwindow only supports constant for first line (index 00)
                returnvalue = "C00"
            Else
                returnvalue = "R"

                Dim speed As Int16 = Me.tricks_get_parameters(trickdatacopy, 1)(2)
                returnvalue &= utilities.int2Hex(speed, 2)
            End If
            Return returnvalue
        End Get
        Set(ByVal value As String)
            Dim trickdatacopy As ArrayList = trickdata
            If (Char.ToUpper(value(0)) = "C") Then

                If (value.Substring(1) = "00") Then
                    trickdatacopy(1) = 0
                Else
                    'this version of tiniwindow only accept constant with the first line (index 0)
                    Throw New Exception
                End If


            ElseIf (Char.ToUpper(value(0)) = "R") Then
                trickdatacopy(1) = 1

                Me.tricks_set_parameter(trickdatacopy, 1, 2, Convert.ToInt16(value.Substring(1), 16))

            Else
                'error
                Throw New Exception

            End If

            trickdata = trickdatacopy

        End Set
    End Property





    'legacy functions
    'from before class structure
    Protected Overridable Function validFirmwareVersionResponse(ByVal line As String) As Boolean
        If (line.Trim.Length() <> VERSIONRESPONSELENGTH - 2) Then
            Return False
        End If

        If (line.Substring(0, 2) <> "V ") Then
            Return False
        End If


        If (Not ((line.Substring(2, 1) >= "0" And line.Substring(2, 1) <= "9") Or (line.Substring(2, 1) > "A" And line.Substring(2, 1) < "F"))) Then
            Return False
        End If
        If (Not ((line.Substring(3, 1) >= "0" And line.Substring(3, 1) <= "9") Or (line.Substring(3, 1) > "A" And line.Substring(3, 1) < "F"))) Then
            Return False
        End If
        If (Not ((line.Substring(4, 1) >= "0" And line.Substring(2, 1) <= "9") Or (line.Substring(2, 1) > "A" And line.Substring(2, 1) < "F"))) Then
            Return False
        End If
        If (Not ((line.Substring(5, 1) >= "0" And line.Substring(3, 1) <= "9") Or (line.Substring(3, 1) > "A" And line.Substring(3, 1) < "F"))) Then
            Return False
        End If

        Return True
    End Function

    
End Class


