Imports portConnectionHandle = System.Int16 'create an alias to make function signatures less confusing
'                                            only used in overridden or inherited functions that ignore this parameter  
Imports System.Net.Sockets
Imports System.Text

Public Class SignConnection_OneSign_internet
    'format for sign identifyers will be 

    'tiniwindow is server, unknow what connected to (used while scanning)
    'su:serverindex:clientindex

    'tiniwindow is server, tcp socket connect directly to sign sign
    'ss:serverindex:clientindex.name

    'tiniwindow is server, tcp socket connect to atmel zigbee coordinator
    'sc:serverindex:clientindex.coordinatorname:signname



    'tiniwindow is client, unknow what connected to (used while scanning)
    'cu:clientindex



    'more types to come .....






    



    Inherits SignConnection_OneSign



    Dim current_checkouthandle As checkouthandle = checkouthandle.NOTCHECKEDOUT
    Public Const COORDINATOR_DEVICE_LIST_COMMAND As String = "CDL" & Constants.vbCrLf
    Public Const SIGN_VERSION_COMMAND As String = "V" & Constants.vbCrLf
    Dim timer_scan_for_signs As Timer = New Timer


    'Private m_support_tiniwindow_as_server As Boolean = False

    'Private m_support_tiniwindow_as_client As Boolean = False

    'Private m_support_tiniWindow_as_client_to_website As Boolean = False


    Public ReadOnly Property portlist() As ArrayList
        Get
            Dim returnvalue As ArrayList = New ArrayList
            For Each server As tcp_server In Me.tcpservers
                returnvalue.Add(server.port)

            Next
            Return returnvalue
        End Get
    End Property


    Private tcpservers As ArrayList = New ArrayList() ' of tcp_server ie of our custom class 

    Private tcpclients As ArrayList = New ArrayList() 'of TCP_client ie our cusntom class 

    Public Enum serverFileOperationResult
        success
        notConnectedToServer
        InsufficentPermissions
        FileAlreadyExist
        InvalidFileName
        miscError
    End Enum

    Structure ServerFileOperationHandle
        Public Enum statusoptions
            notstarted
            working
            success
            notConnectedToServer
            InsufficentPermissions
            FileAlreadyExist
            InvalidFileName
            miscError
            cancled
        End Enum
        Public status As statusoptions
        Private _filename

        

        Public ReadOnly Property filename()
            Get
                Return _filename

            End Get
        End Property

        Public Sub New(ByVal passedfilename)
            _filename = passedfilename
            status = statusoptions.notstarted

        End Sub

    End Structure
    Private myserverfileoperationhandle As ServerFileOperationHandle
    Public Function getfilefromserver(ByVal filename) As serverFileOperationResult



        If Not MarshallingInitialized Then
            initialisemarshalling()

        End If

        myserverfileoperationhandle = New ServerFileOperationHandle(filename)
        Dim autoCloseDialogWhenComplete As Boolean = True


        myProgressForm = New ProgressForm()

        myProgressForm.autocloseatcompletions = autoCloseDialogWhenComplete
        myProgressForm.retryfunction = AddressOf getfilefromserver_do
        getfilefromserver_do()
        myProgressForm.ShowDialog()


        Return myserverfileoperationhandle.status


    End Function
    Protected Overridable Sub getfilefromserver_do()
        'the pupose of seperating this from connect is to be able to call 
        'this function if retry is clicked from the dialog form after a failure
        '


        Dim bgw As System.ComponentModel.BackgroundWorker = New System.ComponentModel.BackgroundWorker
        myProgressForm.bgw = bgw 'stored on pregress form only for purpose of allowing cancelation
        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True
        AddHandler bgw.DoWork, AddressOf getfilefromserver_backgroundWork
        AddHandler bgw.ProgressChanged, AddressOf common_backgroundwork_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf common_backgroundwork_RunWorkerCompleted


        bgw.RunWorkerAsync()


    End Sub

    Protected Overridable Sub getfilefromserver_backgroundWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)


        Dim serverfilecommand As String = "receivefile " & myserverfileoperationhandle.filename & Constants.vbCrLf

        'Dim endoffiletag = "{eof}" & Chr(0)



        'Dim EnterCommandStateCommand As String = "entercommandstate" & Constants.vbCrLf

        'Dim ConnectToSignCommand = "connecttosign" & Constants.vbCrLf


        Dim responsestring As String = ""


        Dim process As String = "getting file '" & myserverfileoperationhandle.filename & "' from server" & Constants.vbCr
        Dim bgw As System.ComponentModel.BackgroundWorker = sender

        Dim proceed As Boolean

        Dim outputstring As String = ""

        myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.working

        'to do fix progress calculations
        Dim currentProgress As Single = 0

        Dim attempts As Int16 = 0
        If bgw.CancellationPending Then
            bgw.ReportProgress(currentProgress, process & "Cancled!")
            e.Cancel = True
            myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

            Return
        End If


        

        If bgw.CancellationPending Then
            bgw.ReportProgress(currentProgress, process & "Cancled!")
            e.Cancel = True

            Return
        End If
        

        'enter server command mode




        proceed = False
        While Not proceed And attempts < 3

            bgw.ReportProgress(currentProgress, process & "entering server command mode ... attempt " & (attempts + 1))
            proceed = EnterServerCommandState()


            If bgw.CancellationPending Then
                bgw.ReportProgress(currentProgress, process & "Cancled!")
                e.Cancel = True
                myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                Return
            End If

            currentProgress = 0
            bgw.ReportProgress(currentProgress, process & "entering server command mode ... attempt " & (attempts + 1))


            attempts += 1

        End While


        If (Not proceed) Then
            'an error occured


            bgw.ReportProgress(currentProgress, "ERROR " & process & "Failed to save file, connecting to sign")

            attempts = 0
            While attempts < 3 And Not EnterServerConnecteToSignState()

                attempts += 1

            End While




            bgw.ReportProgress(currentProgress, "ERROR " & process & "Failed to get file from server")
            e.Cancel = True
            myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.miscError

            Return


        End If




        'get file

        proceed = False

        attempts = 0
        While Not proceed And attempts < 3

            If bgw.CancellationPending Then


                bgw.ReportProgress(currentProgress, process & "canceling ... connecting to sign")

                attempts = 0
                While attempts < 3 And Not EnterServerConnecteToSignState()

                    attempts += 1

                End While






                myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                bgw.ReportProgress(currentProgress, process & "Cancled!")
                e.Cancel = True

                Return
            End If

            currentProgress = 0
            bgw.ReportProgress(currentProgress, process & "saving.. attempt " & (attempts + 1))
            writeThenReadline(serverfilecommand, responsestring)

            If bgw.CancellationPending Then

                bgw.ReportProgress(currentProgress, process & "canceling ... connecting to sign")

                attempts = 0
                While attempts < 3 And Not EnterServerConnecteToSignState()

                    attempts += 1

                End While







                bgw.ReportProgress(currentProgress, process & "Cancled!")
                e.Cancel = True
                myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                Return
            End If



            currentProgress = 100 * serverfilecommand.Length / (outputstring.Length + serverfilecommand.Length)
            bgw.ReportProgress(currentProgress, process & "attempt " & (attempts + 1))

            responsestring = responsestring.Trim
            Dim splitresponse As String() = responsestring.Split(" ")

            Dim filesize As Int16 = 0
            Try

                filesize = Convert.ToInt16(splitresponse(0))
            Catch ex As Exception
                'response does not start with a number as expected
                attempts += 1
                Continue While
            End Try

            If splitresponse(1).Trim.ToLower = "ready" Then
                'expected response


                writeThenReadline("go" & Constants.vbCrLf, responsestring)
                If bgw.CancellationPending Then

                    bgw.ReportProgress(currentProgress, process & "canceling ... connecting to sign")

                    attempts = 0
                    While attempts < 3 And Not EnterServerConnecteToSignState()

                        attempts += 1

                    End While

                    bgw.ReportProgress(currentProgress, process & "Cancled!")
                    e.Cancel = True
                    myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                    Return
                End If

                If responsestring.Length >= filesize + "success".Length Then

                    Dim filecontents = responsestring.Substring(0, filesize)

                    responsestring = responsestring.Substring(filesize).Trim
                    If responsestring.ToLower = "success" Then

                        If processFileContents(filecontents) Then
                            'success

                            proceed = True
                        Else

                            'invalid file contents
                            attempts += 1
                            Continue While

                        End If




                    End If


                Else

                    'error condition
                    'response is not long enough to contain file contents
                    attempts += 1
                    Continue While

                End If

                

                
            Else




            End If


            attempts += 1

        End While



        'we connect to sign reguardless of success or failure

        If proceed Then

            bgw.ReportProgress(100, process & "Sucess!! file opened.. connecting to sign")


        Else
            bgw.ReportProgress(currentProgress, "ERROR " & process & "Failed to open file.. connecting to sign")
        End If

        attempts = 0
        While attempts < 3 And Not EnterServerConnecteToSignState()

            attempts += 1

        End While




        If proceed Then

            bgw.ReportProgress(100, process & "Sucess!! file opened")
            myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.success


        Else

            'an error occured

            bgw.ReportProgress(currentProgress, "ERROR " & process & "Failed to open file from server")
            e.Cancel = True
            myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.miscError

        End If













    End Sub





    Public Function savefiletoserver(ByVal filename) As serverFileOperationResult

        If Not MarshallingInitialized Then
            initialisemarshalling()

        End If

        myserverfileoperationhandle = New ServerFileOperationHandle(filename)
        Dim autoCloseDialogWhenComplete As Boolean = True


        myProgressForm = New ProgressForm()

        myProgressForm.autocloseatcompletions = autoCloseDialogWhenComplete
        myProgressForm.retryfunction = AddressOf savefiletoserver_do
        savefiletoserver_do()
        myProgressForm.ShowDialog()


        'this function completes when the user clicks OK on the dialog form
        'it returns whether of not a succesfull connection has been made   

        Return Me.connected



    End Function
    Protected Overridable Sub savefiletoserver_do()
        'the pupose of seperating this from connect is to be able to call 
        'this function if retry is clicked from the dialog form after a failure
        '


        Dim bgw As System.ComponentModel.BackgroundWorker = New System.ComponentModel.BackgroundWorker
        myProgressForm.bgw = bgw 'stored on pregress form only for purpose of allowing cancelation
        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True
        AddHandler bgw.DoWork, AddressOf savefiletoserver_backgroundWork
        AddHandler bgw.ProgressChanged, AddressOf common_backgroundwork_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf common_backgroundwork_RunWorkerCompleted


        bgw.RunWorkerAsync()


    End Sub


    Protected Overridable Function EnterServerCommandState() As Boolean

        Dim EnterCommandStateCommand As String = "entercommandstate" & Constants.vbCrLf

        Dim responsestring = ""

        writeThenReadline(EnterCommandStateCommand, responsestring)


        If (responsestring.Trim.ToLower = "ok") Then
            Return True

        End If

        Return False


    End Function
    Protected Overridable Function EnterServerConnecteToSignState() As Boolean

        Dim EnterConnectedStateCommand As String = "connecttosign" & Constants.vbCrLf

        Dim responsestring = ""

        writeThenReadline(EnterConnectedStateCommand, responsestring)


        If (responsestring.Trim.ToLower = "ok") Then
            Return True

        End If

        Return False


    End Function

    Protected Function getfilecontents(Optional ByVal _filename As String = "") As String
        'function not currently used
        'this function opens a file and returns its contents as a string

        'Dim linein As String = ""
        If _filename = "" Then
            _filename = Me.filename
        End If
        Try
            Dim SR As IO.StreamReader = IO.File.OpenText(_filename)
            Dim returnvalue As String = SR.ReadToEnd
            SR.Close()

            Return returnvalue

        Catch ex As Exception

            'something went wrong opening or reading file
            Return ""
        End Try

        'should not reach here
        Return ""


    End Function

    Protected Overridable Sub savefiletoserver_backgroundWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)


        'Dim endoffiletag = "{eof}" & Chr(0)



        Dim EnterCommandStateCommand As String = "entercommandstate" & Constants.vbCrLf

        Dim ConnectToSignCommand = "connecttosign" & Constants.vbCrLf
        

        Dim responsestring As String = ""


        Dim process As String = "Saving file '" & myserverfileoperationhandle.filename & "' to server" & Constants.vbCr
        Dim bgw As System.ComponentModel.BackgroundWorker = sender

        Dim proceed As Boolean

        Dim outputstring As String = ""

        myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.working

        'to do fix progress calculations
        Dim currentProgress As Single = 0

        Dim attempts As Int16 = 0
        If bgw.CancellationPending Then
            bgw.ReportProgress(currentProgress, process & "Cancled!")
            e.Cancel = True
            myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

            Return
        End If


        While attempts < 3 And outputstring = ""

            'possible to remove this loop which is left over from when contents read from file saved on computer 
            'rather then being generated in RAM

            If bgw.CancellationPending Then
                bgw.ReportProgress(currentProgress, process & "Cancled!")
                e.Cancel = True
                myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                Return
            End If

            bgw.ReportProgress(currentProgress, process & "gen file contents attempt " & attempts)


            outputstring = Me.generate_file_contents()

            If bgw.CancellationPending Then
                bgw.ReportProgress(currentProgress, process & "Cancled!")
                e.Cancel = True
                myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                Return
            End If

            attempts += 1
        End While

        If outputstring = "" Then
            'error generating file contents

            'since we have not yet enterd server cammand state, we are still connected to sign


            bgw.ReportProgress(currentProgress, "ERROR " & process & "Failed to generate file contents!")
            e.Cancel = True
            myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.miscError
            Return

        Else
            'convert from unicode to ansi to avoid server problems


            'Dim winLatinCodePage = Encoding.GetEncoding(1252)

            'Dim bytes As Byte() = Encoding.Convert(Encoding.UTF8, winLatinCodePage, outputstring.ToCharArray)


        End If


        If bgw.CancellationPending Then
            bgw.ReportProgress(currentProgress, process & "Cancled!")
            e.Cancel = True

            Return
        End If
        Dim serverfilecommand As String = "transmitfile " & myserverfileoperationhandle.filename & " " & outputstring.Length & Constants.vbCrLf


        'enter server command mode




        proceed = False
        While Not proceed And attempts < 3

            bgw.ReportProgress(currentProgress, process & "entering server command mode ... attempt " & (attempts + 1))
            proceed = EnterServerCommandState()


            If bgw.CancellationPending Then
                bgw.ReportProgress(currentProgress, process & "Cancled!")
                e.Cancel = True
                myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                Return
            End If

            currentProgress = 0
            bgw.ReportProgress(currentProgress, process & "entering server command mode ... attempt " & (attempts + 1))


            attempts += 1

        End While


        If (Not proceed) Then
            'an error occured


            bgw.ReportProgress(currentProgress, "ERROR " & process & "Failed to save file, connecting to sign")

            attempts = 0
            While attempts < 3 And Not EnterServerConnecteToSignState()

                attempts += 1

            End While




            bgw.ReportProgress(currentProgress, "ERROR " & process & "Failed to save file to server")
            e.Cancel = True
            myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.miscError

            Return


        End If




        'save file

        proceed = False

        attempts = 0
        While Not proceed And attempts < 3

            If bgw.CancellationPending Then


                bgw.ReportProgress(currentProgress, process & "canceling ... connecting to sign")

                attempts = 0
                While attempts < 3 And Not EnterServerConnecteToSignState()

                    attempts += 1

                End While






                myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                bgw.ReportProgress(currentProgress, process & "Cancled!")
                e.Cancel = True

                Return
            End If

            currentProgress = 0
            bgw.ReportProgress(currentProgress, process & "saving.. attempt " & (attempts + 1))
            writeThenReadline(serverfilecommand, responsestring)

            If bgw.CancellationPending Then

                bgw.ReportProgress(currentProgress, process & "canceling ... connecting to sign")

                attempts = 0
                While attempts < 3 And Not EnterServerConnecteToSignState()

                    attempts += 1

                End While







                bgw.ReportProgress(currentProgress, process & "Cancled!")
                e.Cancel = True
                myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                Return
            End If



            currentProgress = 100 * serverfilecommand.Length / (outputstring.Length + serverfilecommand.Length)
            bgw.ReportProgress(currentProgress, process & "attempt " & (attempts + 1))

            If responsestring.Trim.ToLower = "ready" Then
                'expected response


                writeThenReadline(outputstring, responsestring)
                If bgw.CancellationPending Then

                    bgw.ReportProgress(currentProgress, process & "canceling ... connecting to sign")

                    attempts = 0
                    While attempts < 3 And Not EnterServerConnecteToSignState()

                        attempts += 1

                    End While







                    bgw.ReportProgress(currentProgress, process & "Cancled!")
                    e.Cancel = True
                    myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                    Return
                End If


                If responsestring.Trim.ToUpper = "FILE SAVED" Then

                    'expected response

                    proceed = True

                    Exit While


                Else





                End If

            Else




            End If


            attempts += 1

        End While



        'we connect to sign reguardless of success or failure

        If proceed Then

            bgw.ReportProgress(100, process & "Sucess!! file saved.. connecting to sign")


        Else
            bgw.ReportProgress(currentProgress, "ERROR " & process & "Failed to save file.. connecting to sign")
        End If

        attempts = 0
        While attempts < 3 And Not EnterServerConnecteToSignState()

            attempts += 1

        End While




        If proceed Then

            bgw.ReportProgress(100, process & "Sucess!! file saved to server")
            myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.success


        Else

            'an error occured

            bgw.ReportProgress(currentProgress, "ERROR " & process & "Failed to save file to server")
            e.Cancel = True
            myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.miscError

        End If













    End Sub

    Private Sub timer_scan_for_signs_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If myProgressForm.Visible Then
            'a connect, send or get operation is in progress
            Return
        End If
        Static busy As Boolean = False 'so that we don't have multiple cimultanious scans

        If busy Then
            Return

        End If
        busy = True

        Dim tempsignlist As ArrayList = New ArrayList

        Dim serverindex As Int16 = 0

        Dim restore_selected_sign As String = _selectedsign


        For Each server As tcp_server In tcpservers

            Dim clientindex As Int16 = 0

            For Each client As tcp_server.client In server.clients

                _selectedsign = "su:" & serverindex & ":" & clientindex



                'for now forget about testing for coordinator
                'therefore this incomplete funtionality commented out

                ''test for atmel zigbee coordinator
                'Dim response As String = ""
                'If (Me.writeThenReadline(COORDINATOR_DEVICE_LIST_COMMAND, response, -1, 3, 0.5)) Then
                '    If response.StartsWith("C") Then

                '        Dim splitresponse As String() = response.Split(":")
                '        If splitresponse.Length >= 2 Then


                '            If splitresponse(0).Trim = "CDL" And splitresponse(1).Length = 5 Then
                '                'this is an atmel coordinator
                '                'store each available sign


                '                Dim loopcounter As Int16 = 1 'start with index 1 not 0
                '                While loopcounter < splitresponse.Length

                '                    Dim this_signidentifier As String = "sc:" & serverindex & ":" & clientindex & "." & "" & ":" & splitresponse(loopcounter)
                '                    tempsignlist.Add(this_signidentifier)
                '                    loopcounter += 1
                '                End While

                '            End If
                '        End If

                '    Else
                '        'client is not an atmell coordinator
                '        'test if sign




                Dim response As String
                If (Me.writeThenReadline(SIGN_VERSION_COMMAND, response, -1, 3, communication_time_out_in_seconds)) Then

                    response = response.Trim
                    If response.StartsWith("V") Then


                        'expected response is "V dddd" where dddd is the version number

                        If isdigit(response(2)) And isdigit(response(3)) And isdigit(response(4)) And isdigit(response(5)) Then

                            'we have received the expected response
                            'we could store and/or check the version number here

                            Dim this_signidentifier As String = "ss:" & serverindex & ":" & clientindex & "." & client.openingmessage


                            tempsignlist.Add(this_signidentifier)


                        End If





                    End If

                End If




                clientindex += 1


            Next

            serverindex += 1
        Next



        'done with serverstuff 
        'now do client stuff

        Dim clientindex2 As Int16 = 0
        For Each client As TCP_Client In Me.tcpclients
            'cu:clientindex
            _selectedsign = "cu:" & clientindex2

            Dim response As String
            If (Me.writeThenReadline(SIGN_VERSION_COMMAND, response, -1, 3, communication_time_out_in_seconds)) Then

                response = response.Trim
                If response.StartsWith("V") Then


                    'expected response is "V dddd" where dddd is the version number

                    If isdigit(response(2)) And isdigit(response(3)) And isdigit(response(4)) And isdigit(response(5)) Then

                        'we have received the expected response
                        'we could store and/or check the version number here

                        Dim this_signidentifier As String = "cs:" & clientindex2 & "." & client.openingReceiveMessage


                        tempsignlist.Add(this_signidentifier)


                    End If





                End If

            End If





            clientindex2 += 1




        Next


        _selectedsign = restore_selected_sign


        Dim signstoremove As ArrayList = New ArrayList
        Dim signstoadd As ArrayList = New ArrayList
        For Each sign As String In Me._allSigns_working

            'remove signs not found in this scan
            If Not tempsignlist.Contains(sign) Then
                signstoremove.Add(sign)

            End If
        Next

        For Each sign As String In tempsignlist
            'add signs found in this scan but not on list
            If Not _allSigns_working.Contains(sign) Then
                signstoadd.Add(sign)

            End If

        Next

        For Each sign As String In signstoremove
            'actualy remove the sign 
            _allSigns_working.Remove(sign)


        Next

        For Each sign As String In signstoadd
            'actualy remove the sign 
            _allSigns_working.Add(sign)


        Next


        Dim breakpointholder As ArrayList = _allSigns_working

        busy = False
    End Sub
    Private Function isdigit(ByVal ch As Char) As Boolean
        If ch >= "0" And ch <= "9" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Overridable Sub addclient(ByVal ip As String, ByVal portnum As Int16, Optional ByVal openingSendMessage As String = "", Optional ByVal clossingSendMessage As String = "")
        Dim thisclient As TCP_Client = New TCP_Client(ip, portnum, True)
        thisclient.closingSendMessage = clossingSendMessage
        thisclient.openingSendMessage = openingSendMessage
        Me.tcpclients.Add(thisclient)
        timer_scan_for_signs.Start()

    End Sub

    Public Overridable Sub addserver(ByVal portnum As Int16)
        Dim thisserver As tcp_server = New tcp_server()
        thisserver.start(portnum)
        tcpservers.Add(thisserver)

        timer_scan_for_signs.Start()


    End Sub


    Public Sub New(ByRef CM As ComportManager)

        'there is one comport manager in the whole program

        'we do not use the comport manager for internet connections because we are not using a comport
        'for consistency we still store the comport manager
        mycomportmanager = CM


        AddHandler timer_scan_for_signs.Tick, AddressOf timer_scan_for_signs_Tick

        'this variable is defined in base class and is used so that 
        'different communication methods can tweek this without 
        'overiding several functions 

        communication_time_out_in_seconds = 2

    End Sub

    'these functions are ovverridden to work with an internet connection 
    'instead of a comport

    Protected Overrides Function writeThenReadChars(ByVal writestring As String, ByRef readstring As String, Optional ByVal length As Int64 = 10, Optional ByVal attempts As UInt16 = 1, Optional ByVal communicationTimeOutInSeconds As Double = 1, Optional ByVal ConnectionBusyTimeOutInSeconds As Double = 5, Optional ByVal preWriteGuardTimeInseconds As Double = 0) As CommunicationResult
        MsgBox("writeThenReadChars() not yet inplimented!")
    End Function

    Protected Overrides Function writeThenReadexisting(ByVal writestring As String, ByRef readstring As String, Optional ByVal attempts As UInt16 = 1, Optional ByVal ConnectionBusyTimeOutInSeconds As Double = 5, Optional ByVal preWriteGuardTimeInseconds As Double = 0) As CommunicationResult
        MsgBox("writeThenReadexisting() not yet inplimented!")
    End Function


    Protected Function checkoutSelectedSign() As checkouthandle
        Return checkoutsign(Me._selectedsign)

    End Function

    Protected Function checkoutsign(ByVal signidentifyer) As checkouthandle

        MsgBox("this function is not currently in use") 'as of feb 5 2011
        Dim splitsignidentifyer As String() = signidentifyer.Split(":")

        If splitsignidentifyer(0).StartsWith("s") Then
            'tiniwindow is TCP server for selected sign


            Dim serverindex As Int16 = Convert.ToInt16(splitsignidentifyer(1))
            Dim clientindex As Int16 = Convert.ToInt16(splitsignidentifyer(2).Split(".")(0))
            Dim thisclient As tcp_server.client = Me.tcpservers(serverindex).clients(clientindex)




            'thisclient.checkout()


            'checkout not yet implemented for this configuration
            Return checkouthandle.CHECKOUTNOTSUPPORTED




            'end 'tiniwindow is tcp server to this sign
        ElseIf splitsignidentifyer(0).StartsWith("c") Then
            'tiniwindow is tcp client for selected sign
            'cu:clientindex


            Dim clientindex As Int16 = Convert.ToInt16(splitsignidentifyer(1).Split(".")(0))
            Dim thisclient As TCP_Client = Me.tcpclients(clientindex)

            Return thisclient.checkout()
        Else

            Return checkouthandle.NOTCHECKEDOUT


        End If

    End Function





    Protected Overrides Function writeThenReadline(ByVal writestring As String, ByRef readstring As String, Optional ByVal maxlength As Int64 = 100, Optional ByVal maxattempts As UInt16 = 1, Optional ByVal CommunicationTimeoutInSeconds As Double = 1, Optional ByVal ConnectionBusyTimeoutInSeconds As Double = 5, Optional ByVal preWriteGuardTimeInseconds As Double = 0, Optional ByVal comhandle As portConnectionHandle = Nothing) As CommunicationResult



        readstring = "" 'nothing has been read so far
        Dim splitselectedsign As String() = _selectedsign.Split(":")

        If splitselectedsign(0).StartsWith("s") Then
            'tiniwindow is TCP server for selected sign


            Dim serverindex As Int16 = Convert.ToInt16(splitselectedsign(1))
            Dim clientindex As Int16 = Convert.ToInt16(splitselectedsign(2).Split(".")(0))
            Dim thisclient As tcp_server.client = Me.tcpservers(serverindex).clients(clientindex)

            Dim attempts As Int16 = 0

            While attempts < maxattempts


                'flush buffer
                If thisclient.DataAvailable Then
                    thisclient.receive()


                End If


                thisclient.send(writestring)

                Dim starttime As Double = DateAndTime.Timer 'seconds since midnight


                While (DateAndTime.Timer - starttime < CommunicationTimeoutInSeconds And CommunicationTimeoutInSeconds > 0)
                    'for now ignore situation of crossing midnight



                    readstring = "" 'nothing has been read so far

                    Try







                        If thisclient.DataAvailable Then

                            readstring &= thisclient.receive
                            Dim readstringcopy As String = readstring
                            readstringcopy = String.Join("", readstringcopy.Split(Constants.vbCr))
                            readstringcopy = String.Join("", readstringcopy.Split(Constants.vbLf))

                            If maxlength > 0 And readstringcopy.Length > maxlength Then
                                'error 
                                'too many characters before cr or lf

                                'exit inner while

                                Exit While


                            End If
                            If readstring.Contains(Constants.vbCr) Or readstring.Contains(Constants.vbLf) Then
                                Return CommunicationResult.success


                            End If


                        End If


                    Catch ex As Exception
                        'some error either writing or reading

                        'go through outer loop again untill maxattempts exhausted

                    End Try



                End While

                attempts += 1
            End While

            Return CommunicationResult.fail

            'end 'tiniwindow is tcp server to this sign
        ElseIf splitselectedsign(0).StartsWith("c") Then
            'tiniwindow is tcp client for selected sign
            'cu:clientindex


            Dim clientindex As Int16 = Convert.ToInt16(splitselectedsign(1).Split(".")(0))
            Dim thisclient As TCP_Client = Me.tcpclients(clientindex)

            'for now do local check out  and check in each time this function called
            'later may do fancier scheme
            Dim localcheckouthandle As checkouthandle = thisclient.checkout()

            If Not (thisclient.checkedOutToME(localcheckouthandle)) Then
                Return CommunicationResult.connectionBusy
            End If

            Dim attempts As Int16 = 0

            While attempts < maxattempts


                'flush buffer
                While thisclient.DataAvailable(localcheckouthandle)

                    thisclient.receive(localcheckouthandle)


                End While


                If Not thisclient.send(writestring, localcheckouthandle) Then


                    If localcheckouthandle.expired() Then

                        Dim breakpointholder = 3
                    Else
                        Dim breakpointholder2 = 3
                    End If




                End If

                Dim starttime As Double = DateAndTime.Timer 'seconds since midnight

                readstring = "" 'nothing has been read so far
                While (DateAndTime.Timer - starttime < CommunicationTimeoutInSeconds And CommunicationTimeoutInSeconds > 0)
                    'for now ignore situation of crossing midnight





                    Try







                        If thisclient.DataAvailable(localcheckouthandle) Then

                            readstring &= thisclient.receive(localcheckouthandle)
                            Dim readstringcopy As String = readstring
                            readstringcopy = String.Join("", readstringcopy.Split(Constants.vbCr))
                            readstringcopy = String.Join("", readstringcopy.Split(Constants.vbLf))

                            If maxlength > 0 And readstringcopy.Length > maxlength Then
                                'error 
                                'too many characters before cr or lf

                                'exit inner while

                                Exit While


                            End If
                            If readstring.Contains(Constants.vbCr) Or readstring.Contains(Constants.vbLf) Then

                                thisclient.checkin(localcheckouthandle)


                                If readstring.StartsWith("101") Then
                                    'with communication time out set at 1.5 secs 
                                    'this situation happens occasionally 
                                    'but less then once every 3 minutes
                                    Dim bpholder = 1
                                End If
                                Return CommunicationResult.success


                            End If


                        End If


                    Catch ex As Exception
                        'some error either writing or reading

                        'go through outer loop again untill maxattempts exhausted

                    End Try



                End While

                attempts += 1
            End While
            thisclient.checkin(localcheckouthandle)
            Return CommunicationResult.fail

        End If


        'should not reach here
        Return CommunicationResult.fail

    End Function

    'jp jan/23/2011: copied and pasted connect functions from USB object
    'proceed to modify so that it does not attempt to use a comport



    Public Overrides Function connect(ByVal signidentifyer As Object, Optional ByVal autoCloseDialogWhenComplete As Boolean = False) As Object
        'this function MUST be overidden by classes that inherit it

        If Me.connected Then
            Me.disconnect()
        End If

        _selectedsign = signidentifyer

        myProgressForm = New ProgressForm()

        myProgressForm.autocloseatcompletions = autoCloseDialogWhenComplete
        myProgressForm.retryfunction = AddressOf connect_do
        connect_do()
        myProgressForm.ShowDialog()


        'this function completes when the user clicks OK on the dialog form
        'it returns whether of not a succesfull connection has been made   

        Return Me.connected

    End Function
    Protected Overridable Sub connect_do()
        'the pupose of seperating this from connect is to be able to call 
        'this function if retry is clicked from the dialog form after a failure
        '


        Dim bgw As System.ComponentModel.BackgroundWorker = New System.ComponentModel.BackgroundWorker
        myProgressForm.bgw = bgw 'stored on pregress form only for purpose of allowing cancelation
        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True
        AddHandler bgw.DoWork, AddressOf Connect_backgroundWork
        AddHandler bgw.ProgressChanged, AddressOf common_backgroundwork_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf common_backgroundwork_RunWorkerCompleted


        bgw.RunWorkerAsync()

    End Sub
    Protected Overridable Sub Connect_backgroundWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)





        Dim process As String = "Connecting to " & selectedsign & Constants.vbCr
        Dim bgw As System.ComponentModel.BackgroundWorker = sender

        Dim attemptcounter As Int16 = 1




        If bgw.CancellationPending Then
            e.Cancel = True
            Return
        End If

        attemptcounter = 1
        bgw.ReportProgress(50, process & "Testing connection... attempt " & attemptcounter)
        While Not TestSignConnection()

            If attemptcounter > 40 Then
                bgw.ReportProgress(50, process & "Error! sign not responding...Giving up after 40 attempts ")
                'mycomportmanager.discardPortConnection(myPortConnectionHandle)
                e.Cancel = True
                Return
            End If
            If bgw.CancellationPending Then

                bgw.ReportProgress(50, process & "Connection process canceled!")
                'mycomportmanager.discardPortConnection(myPortConnectionHandle)
                e.Cancel = True
                Return
            End If
            System.Threading.Thread.Sleep(5)
            attemptcounter += 1
            bgw.ReportProgress(50, process & "Testing connection... attempt " & attemptcounter)

        End While

        Me.connected = True
        bgw.ReportProgress(100, process & "Success! connected to sign " & selectedsign)



    End Sub
    Public Overrides Function disconnect() As Object
        If Not Me.connected Then
            Return True
        End If

        Me.myPortConnectionHandle = Nothing
        Me.connected = False
        Me._selectedsign = ""
        Return True
    End Function


    Public Overrides Function TestSignConnection(Optional ByVal comhandle As portConnectionHandle = Nothing) As Boolean
        'comhandle is ignored in this class because we done use a comport


        Dim dummystring As String = ""
        Return getFirmwareVersion(dummystring, dummystring)




    End Function



    Public Sub closeallclients()

        'this function is called from form1 closing
        'it is used instead of a destructor because 
        'stream resourses are disabled before destructor is reached
        For Each client As TCP_Client In Me.tcpclients

            client.close()

        Next


    End Sub

    'Protected Overloads Overrides Sub Finalize()

    '    closeallclients()

    '    MyBase.Finalize()
    'End Sub

End Class
