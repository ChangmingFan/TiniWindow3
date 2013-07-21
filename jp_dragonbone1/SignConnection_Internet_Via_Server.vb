



Imports portConnectionHandle = System.Int16 'create an alias to make function signatures less confusing
'                                            only used in overridden or inherited functions that ignore this parameter  
Imports System.Net.Sockets
Imports System.Text

Public Class SignConnection_Internet_Via_Server

    'format for sign identifyers will be 









    Inherits SignConnection_OneSign

    Dim communicationInProgress As Boolean = False

    Dim current_checkouthandle As checkouthandle = checkouthandle.NOTCHECKEDOUT
    Public Const COORDINATOR_DEVICE_LIST_COMMAND As String = "CDL" & Constants.vbCrLf
    Public Const SIGN_VERSION_COMMAND As String = "V" & Constants.vbCrLf
    Dim timer_scan_for_signs As Timer = New Timer


    'Private m_support_tiniwindow_as_server As Boolean = False

    'Private m_support_tiniwindow_as_client As Boolean = False

    'Private m_support_tiniWindow_as_client_to_website As Boolean = False


    


    '''''''Private tcpservers As ArrayList = New ArrayList() ' of tcp_server ie of our custom class 
    '    Delegate Sub background_work_delegate(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    Delegate Function dofunction_delegate(ByVal addressof_background_work As ProgressForm.background_work_delegate)
    Public Function dobackgroundwork(ByRef addressof_background_work As ProgressForm.background_work_delegate, Optional ByVal CloseDialogWhenComplete As Boolean = False) As Boolean


        Dim dofunction As ProgressForm.retryFunctionDelegate_with_bgw = AddressOf dobackgroundwork_do

        If Not MarshallingInitialized Then
            initialisemarshalling()
        End If

        Dim autoCloseDialogWhenComplete As Boolean = True

        myProgressForm = New ProgressForm()
        myProgressForm.autocloseatcompletions = autoCloseDialogWhenComplete
        myProgressForm.set_retry_function(dofunction)
        dobackgroundwork_do(addressof_background_work)
        myProgressForm.ShowDialog()



        Return myProgressForm.success




    End Function


    Function dobackgroundwork_do(ByRef addressof_background_work As ProgressForm.background_work_delegate)
        Static backgroundworkfunction As ProgressForm.background_work_delegate
        If addressof_background_work Is Nothing Then
            'this happens when this function is called in a retry from progressform
            'use background work function previosly set

        Else
            backgroundworkfunction = addressof_background_work
        End If


        Dim bgw As System.ComponentModel.BackgroundWorker = New System.ComponentModel.BackgroundWorker
        myProgressForm.bgw = bgw 'stored on pregress form only for purpose of allowing cancelation
        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True
        AddHandler bgw.DoWork, AddressOf backgroundworkfunction.Invoke
        AddHandler bgw.ProgressChanged, AddressOf common_backgroundwork_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf common_backgroundwork_RunWorkerCompleted

        bgw.RunWorkerAsync()

    End Function


    Structure serverConnection

        Private Shared background_worker_socket As TCP_Client
        Private m_signconnectionclass As SignConnection_Internet_Via_Server
        Private m_socket As TCP_Client
        Private m_ip As String
        Private m_port As Int16
        Private m_company As String
        Private m_username As String
        Private m_hashed_password As String

        Private m_session_string As String

        Private m_loggedon As Boolean

        Public ReadOnly Property loggedon() As Boolean
            Get
                Return m_loggedon
            End Get
        End Property


        Public ReadOnly Property connection_status() As TCP_Client.connection_status_options
            Get
                Return m_socket.connectionStatus
            End Get
        End Property
        Public Sub New(ByRef signconnectionclass As SignConnection_Internet_Via_Server)
            m_signconnectionclass = signconnectionclass



        End Sub

        Public Sub New(ByRef signconnectionclass As SignConnection_Internet_Via_Server, ByVal ip As String, ByVal port As Int16, ByVal company As String, ByVal username As String, ByVal password As String)
            m_signconnectionclass = signconnectionclass

            connect(ip, port, company, username, password)




        End Sub


        Public Function connect(ByVal ip As String, ByVal port As String, ByVal company As String, ByVal username As String, ByVal password As String) As Boolean

            m_ip = ip
            m_port = port
            m_username = username
            m_hashed_password = SimpleHash.ComputeHash(password, "SHA1")
            m_company = company

            background_worker_socket = m_socket
            If m_signconnectionclass.dobackgroundwork(AddressOf connect_backgroundWork) Then

                m_socket = background_worker_socket
                'MsgBox("connected to server")
                m_signconnectionclass.timer_scan_for_signs.Start()

                m_loggedon = True

            End If


            Return loggedon


        End Function


        Sub connect_backgroundWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)



            Const IDENTIFY_AS_TINIWINDOW As String = "TiniWindow 0 0 0" & Constants.vbCrLf


            Dim responsestring As String = ""


            Dim process As String = "connecting to server'" '& myserverfileoperationhandle.filename & "' to server" & Constants.vbCr
            Dim bgw As System.ComponentModel.BackgroundWorker = sender
            Dim numberofsteps As Int16 = 4


            Dim currentProgress As Single = 0


            'm_loggedon = False 'we will set true if end of function reached

            bgw.ReportProgress(currentProgress, process & "opening connection")

            Dim attempts As Int16 = 0
            If bgw.CancellationPending Then
                bgw.ReportProgress(currentProgress, process & "Cancled!")
                e.Cancel = True
                ' myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                Return
            End If

            Dim proceed As Boolean

            proceed = False

            Dim starttime As Double = DateAndTime.Timer
            While attempts < 3 And Not proceed
                If bgw.CancellationPending Then
                    bgw.ReportProgress(currentProgress, process & "Cancled!")
                    e.Cancel = True
                    ' myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                    Return
                End If


                bgw.ReportProgress(currentProgress, process & "opening connection - attempt " & attempts)

                Try
                    background_worker_socket.close()

                Catch ex As Exception

                End Try

                background_worker_socket = New TCP_Client(m_ip, m_port)
                starttime = DateAndTime.Timer
                While (DateAndTime.Timer - starttime < m_signconnectionclass.communication_time_out_in_seconds)

                    If bgw.CancellationPending Then
                        bgw.ReportProgress(currentProgress, process & "Cancled!")
                        e.Cancel = True
                        ' myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                        Return
                    End If

                    If background_worker_socket.connectionStatus = TCP_Client.connection_status_options.Connected Then
                        proceed = True
                        Exit While
                    End If

                End While

                attempts += 1
            End While


            If Not proceed Then
                'we were unable to establish a connection with the server
                bgw.ReportProgress(currentProgress, "ERROR " & process & "unable to connect to server")
                e.Cancel = True
                'myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.miscError
                Return


            End If

            currentProgress += 100 / numberofsteps
            bgw.ReportProgress(currentProgress, process & "Identifying TinWindow")

            attempts = 0
            proceed = False


            While attempts < 3 And Not proceed

                If bgw.CancellationPending Then
                    bgw.ReportProgress(currentProgress, process & "Cancled!")
                    e.Cancel = True
                    ' myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                    Return
                End If


                bgw.ReportProgress(currentProgress, process & "Identifying TinWindow - attempt " & attempts)

                starttime = DateAndTime.Timer

                Try
                    background_worker_socket.send(IDENTIFY_AS_TINIWINDOW)


                Catch ex As Exception

                End Try
                responsestring = ""
                Dim responsefeilds As String()
                Dim index As Int16 = 0
                starttime = DateAndTime.Timer

                While (DateAndTime.Timer - starttime < m_signconnectionclass.communication_time_out_in_seconds)

                    If bgw.CancellationPending Then
                        bgw.ReportProgress(currentProgress, process & "Cancled!")
                        e.Cancel = True
                        ' myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                        Return
                    End If
                    responsestring &= background_worker_socket.receive

                    If responsestring.IndexOf(Constants.vbCr) <> -1 Or responsestring.IndexOf(Constants.vbLf) <> -1 Then



                        responsefeilds = responsestring.Split(" ")

                        index = 0
                        If responsefeilds.Length > index Then

                            While responsefeilds(index).Trim = ""

                                index += 1
                                If responsefeilds.Length <= index Then
                                    Exit While
                                End If

                            End While

                        End If
                        If responsefeilds.Length > index Then
                            'session string
                            m_session_string = responsefeilds(index)
                        End If

                        index += 1

                        'there should be 3 more feilds - in this version all three are '0'

                        Dim threefeildcounter As Int16 = 0
                        While threefeildcounter < 3
                            If responsefeilds.Length > index Then

                                While responsefeilds(index).Trim = ""

                                    index += 1
                                    If responsefeilds.Length <= index Then
                                        Exit While
                                    End If

                                End While

                            End If
                            If responsefeilds.Length > index Then
                                If responsefeilds(index).Trim = "0" Then

                                Else
                                    Exit While
                                End If
                            End If



                            threefeildcounter += 1
                        End While

                        If threefeildcounter = 3 Then

                            proceed = True

                        End If


                        Exit While 'exit the string gathering loop because we received a complete line
                        '          'which either was correct or was wrong




                    End If


                End While

                attempts += 1
            End While





            Dim outputstring As String = ""

            If Not proceed Then
                'we were unable to establish a connection with the server
                bgw.ReportProgress(currentProgress, "ERROR " & process & "unable to identify as TinWindow")
                e.Cancel = True
                'myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.miscError
                Return

            End If

            currentProgress += 100 / numberofsteps
            bgw.ReportProgress(currentProgress, process & "Verifying Company")


            attempts = 0
            proceed = False


            While attempts < 3 And Not proceed

                If bgw.CancellationPending Then
                    bgw.ReportProgress(currentProgress, process & "Cancled!")
                    e.Cancel = True
                    ' myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                    Return
                End If


                bgw.ReportProgress(currentProgress, process & "Verifying Company - attempt " & attempts)


                outputstring = "logon company " & Me.m_company & Constants.vbCrLf


                Try
                    background_worker_socket.send(outputstring)


                Catch ex As Exception

                End Try
                responsestring = ""
                Dim responsefeilds As String()
                Dim index As Int16 = 0
                starttime = DateAndTime.Timer

                While (DateAndTime.Timer - starttime < m_signconnectionclass.communication_time_out_in_seconds)

                    If bgw.CancellationPending Then
                        bgw.ReportProgress(currentProgress, process & "Cancled!")
                        e.Cancel = True
                        ' myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                        Return
                    End If
                    responsestring &= background_worker_socket.receive

                    If responsestring.IndexOf(Constants.vbCr) <> -1 Or responsestring.IndexOf(Constants.vbLf) <> -1 Then

                        If responsestring.Trim.ToLower = "ok" Then

                            proceed = True
                        End If


                        Exit While
                    End If
                End While
                attempts += 1
            End While




            If Not proceed Then
                'we were unable to establish a connection with the server
                bgw.ReportProgress(currentProgress, "ERROR " & process & "unable to identify company")
                e.Cancel = True
                'myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.miscError
                Return

            End If

            currentProgress += 100 / numberofsteps
            bgw.ReportProgress(currentProgress, process & "Verifying username and password")


            attempts = 0
            proceed = False


            While attempts < 3 And Not proceed

                If bgw.CancellationPending Then
                    bgw.ReportProgress(currentProgress, process & "Cancled!")
                    e.Cancel = True
                    ' myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                    Return
                End If


                bgw.ReportProgress(currentProgress, process & "Verifying Company - attempt " & attempts)


                outputstring = "logon credentials " & Me.m_username & " " & Me.m_hashed_password & Constants.vbCrLf


                Try
                    background_worker_socket.send(outputstring)


                Catch ex As Exception

                End Try
                responsestring = ""
                'Dim responsefeilds As String()
                'Dim index As Int16 = 0
                starttime = DateAndTime.Timer

                While (DateAndTime.Timer - starttime < m_signconnectionclass.communication_time_out_in_seconds)

                    If bgw.CancellationPending Then
                        bgw.ReportProgress(currentProgress, process & "Cancled!")
                        e.Cancel = True
                        ' myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.cancled

                        Return
                    End If
                    responsestring &= background_worker_socket.receive

                    If responsestring.IndexOf(Constants.vbCr) <> -1 Or responsestring.IndexOf(Constants.vbLf) <> -1 Then

                        If responsestring.Trim.ToLower = "logged on" Then

                            proceed = True
                        End If


                        Exit While
                    End If
                End While
                attempts += 1
            End While



            If proceed Then

                bgw.ReportProgress(100, process & "Sucess!! logged on to server")
                'myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.success
                m_loggedon = True

                MsgBox("connected to server")
            Else

                'an error occured

                bgw.ReportProgress(currentProgress, "ERROR " & process & "verifying username and password")
                e.Cancel = True
                ' myserverfileoperationhandle.status = ServerFileOperationHandle.statusoptions.miscError

            End If

        End Sub

        Public Function checkedOutToME(ByVal _checkouthandle) As Boolean
            Return m_socket.checkedOutToME(_checkouthandle)


        End Function

        Public Function DataAvailable() As Boolean
            Return m_socket.DataAvailable()

        End Function


        Public Function DataAvailable(ByRef _checkouthandle As checkouthandle) As Boolean
            Return m_socket.DataAvailable(_checkouthandle)

        End Function


        Public Function send(ByVal output As String, ByRef _checkouthandle As checkouthandle) As Boolean
            Return m_socket.send(output, _checkouthandle)
        End Function

        Public Function send(ByVal output As String) As Boolean
            Return m_socket.send(output)
        End Function

        Public Function receive(ByRef _checkouthandle As checkouthandle) As String
            Return m_socket.receive(_checkouthandle)
        End Function

        Public Function receive() As String
            Return m_socket.receive()


        End Function

        Public Function checkout(Optional ByVal timeoutinseconds As Double = 1.0) As checkouthandle

            Return m_socket.checkout(timeoutinseconds)
        End Function

        Public Function checkin(ByRef _checkouthandle As checkouthandle) As Boolean

            Return m_socket.checkin(_checkouthandle)
        End Function









    End Structure

    Public ReadOnly Property serverConncetionCount() As Int16
        Get

            Dim returnvalue As Int16 = 0

            For Each thisconnection As serverConnection In ServerConnections
                If thisconnection.loggedon And thisconnection.connection_status = TCP_Client.connection_status_options.Connected Then
                    returnvalue += 1
                End If
            Next
            Return returnvalue
        End Get
        
    End Property

    Private ServerConnections As ArrayList = New ArrayList 'of our serverconnection structure

    Private tcpclients As ArrayList = New ArrayList() 'of TCP_client ie our cusntom class 'to be removed - temporarily left to avoid errors

    Public Overridable Function addServer(ByVal ip As String, ByVal portnum As Int16, ByVal company As String, ByVal username As String, ByVal password As String) As Boolean
        Dim this_server_connection As serverConnection = New serverConnection(Me)

        If this_server_connection.connect(ip, portnum, company, username, password) Then

            Me.ServerConnections.Add(this_server_connection)
        End If

    End Function






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

        If Me.connected Then

            'in the current version the server can not process this command while in connected state
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

        Const SIGN_LIST_COMMAND As String = "getsigns" & Constants.vbCrLf


        For Each this_server_connection As serverConnection In Me.ServerConnections
            If (this_server_connection.connection_status <> TCP_Client.connection_status_options.Connected) Then
                'The connection with the server has been lost
                'no point trying to test anything

                Continue For


            End If


            Dim this_checkouthandle As checkouthandle = this_server_connection.checkout(Me.communication_time_out_in_seconds)
            If this_checkouthandle.id = checkouthandle.ALREADYCHECKEDOUT.id Then
                'this server connection is in use 
                'abort test for signs for the moment
                Continue For

            End If

            Dim response As String = ""

            this_server_connection.send(SIGN_LIST_COMMAND, this_checkouthandle)

            Dim starttime As Double = DateAndTime.Timer

            While (DateAndTime.Timer - starttime < communication_time_out_in_seconds)

                response &= this_server_connection.receive(this_checkouthandle)

                'we are expeting 2 line

                Dim splitresponse As String() = response.TrimEnd.Split(Constants.vbCr)

                If (splitresponse.Length < 2) Then

                    Continue While
                End If


                If (splitresponse.Length >= 2) Then
                    'we have 2 lines

                    Dim ready_signs As String = splitresponse(0)
                    Dim not_ready_signs As String = splitresponse(1) 'we don't use in this version of TiniWindow

                    Dim split_ready_signs As String() = ready_signs.Split(" ")

                    If split_ready_signs(0).Trim = "signs_ready" Then

                        Dim ready_sign_walker As Integer = 1
                        While ready_sign_walker < split_ready_signs.Length

                            If (split_ready_signs(ready_sign_walker).Trim <> "") Then

                                tempsignlist.Add(ServerConnections.IndexOf(this_server_connection).ToString & "." & split_ready_signs(ready_sign_walker))
                            End If


                            ready_sign_walker += 1

                        End While


                        Exit While 'failure to exit will result in received responce being processed repeatedly


                    End If





                End If






            End While



            this_server_connection.checkin(this_checkouthandle)






        Next




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

    'Public Overridable Sub addclient(ByVal ip As String, ByVal portnum As Int16, Optional ByVal openingSendMessage As String = "", Optional ByVal clossingSendMessage As String = "")
    '    Dim thisclient As TCP_Client = New TCP_Client(ip, portnum, True)
    '    thisclient.closingSendMessage = clossingSendMessage
    '    thisclient.openingSendMessage = openingSendMessage
    '    Me.tcpclients.Add(thisclient)
    '    timer_scan_for_signs.Start()

    'End Sub

    'Public Overridable Sub addserver(ByVal portnum As Int16)
    '    Dim thisserver As tcp_server = New tcp_server()
    '    thisserver.start(portnum)
    '    tcpservers.Add(thisserver)

    '    timer_scan_for_signs.Start()


    'End Sub


    Public Sub New(ByRef CM As ComportManager)

        'there is one comport manager in the whole program

        'we do not use the comport manager for internet connections because we are not using a comport
        'for consistency we still store the comport manager
        mycomportmanager = CM


        AddHandler timer_scan_for_signs.Tick, AddressOf timer_scan_for_signs_Tick

        timer_scan_for_signs.Interval = 10000 ' 10  seconds  031713

        'this variable is defined in base class and is used so that 
        'different communication methods can tweek this without 
        'overiding several functions 

        communication_time_out_in_seconds = 10
        '041413  change 5 to 10 seconds
        'communication_time_out_in_seconds = 5
        '031713  change 2 to 5 seconds

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
        'march 9 2011 added return and commented out all lines below as shortcut to remove syntax errors
        Return checkouthandle.NOTCHECKEDOUT


        'Dim splitsignidentifyer As String() = signidentifyer.Split(":")

        'If splitsignidentifyer(0).StartsWith("s") Then
        '    'tiniwindow is TCP server for selected sign


        '    Dim serverindex As Int16 = Convert.ToInt16(splitsignidentifyer(1))
        '    Dim clientindex As Int16 = Convert.ToInt16(splitsignidentifyer(2).Split(".")(0))
        '    Dim thisclient As tcp_server.client = Me.tcpservers(serverindex).clients(clientindex)




        '    'thisclient.checkout()


        '    'checkout not yet implemented for this configuration
        '    Return checkouthandle.CHECKOUTNOTSUPPORTED




        '    'end 'tiniwindow is tcp server to this sign
        'ElseIf splitsignidentifyer(0).StartsWith("c") Then
        '    'tiniwindow is tcp client for selected sign
        '    'cu:clientindex


        '    Dim clientindex As Int16 = Convert.ToInt16(splitsignidentifyer(1).Split(".")(0))
        '    Dim thisclient As TCP_Client = Me.tcpclients(clientindex)

        '    Return thisclient.checkout()
        'Else

        '    Return checkouthandle.NOTCHECKEDOUT


        'End If

    End Function





    Protected Overrides Function writeThenReadline(ByVal writestring As String, ByRef readstring As String, Optional ByVal maxlength As Int64 = 100, Optional ByVal maxattempts As UInt16 = 1, Optional ByVal CommunicationTimeoutInSeconds As Double = 1, Optional ByVal ConnectionBusyTimeoutInSeconds As Double = 5, Optional ByVal preWriteGuardTimeInseconds As Double = 0, Optional ByVal comhandle As portConnectionHandle = Nothing) As CommunicationResult

        communicationInProgress = True

        readstring = "" 'nothing has been read so far




        Dim splitselectedsign As String() = _selectedsign.Split(".")

        Dim serverindex As Integer = Convert.ToInt16(splitselectedsign(0))

        Dim this_serverconnection As serverConnection = Me.ServerConnections(serverindex)


      
        'If splitselectedsign(0).StartsWith("c") Then
        'tiniwindow is tcp client for selected sign
        'cu:clientindex


        'Dim clientindex As Int16 = Convert.ToInt16(splitselectedsign(1).Split(".")(0))
        'Dim thisclient As TCP_Client = Me.tcpclients(clientindex)

        'for now do local check out  and check in each time this function called
        'later may do fancier scheme
        Dim localcheckouthandle As checkouthandle = this_serverconnection.checkout(CommunicationTimeoutInSeconds)
        '042113 Changming

        If Not (this_serverconnection.checkedOutToME(localcheckouthandle)) Then
            Return CommunicationResult.connectionBusy
        End If

        Dim attempts As Int16 = 0

        While attempts < maxattempts


            'flush buffer
            While this_serverconnection.DataAvailable(localcheckouthandle)

                this_serverconnection.receive(localcheckouthandle)


            End While


            If Not this_serverconnection.send(writestring, localcheckouthandle) Then


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







                    If this_serverconnection.DataAvailable(localcheckouthandle) Then

                        readstring &= this_serverconnection.receive(localcheckouthandle)
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

                            this_serverconnection.checkin(localcheckouthandle)


                            If readstring.StartsWith("101") Then
                                'with communication time out set at 1.5 secs 
                                'this situation happens occasionally 
                                'but less then once every 3 minutes
                                Dim bpholder = 1
                            End If



                            communicationInProgress = False
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
        this_serverconnection.checkin(localcheckouthandle)


        communicationInProgress = False
        Return CommunicationResult.fail

        'End If


        'should not reach here
        communicationInProgress = False
        Return CommunicationResult.fail

    End Function

    'jp jan/23/2011: copied and pasted connect functions from USB object
    'proceed to modify so that it does not attempt to use a comport



    Public Overrides Function connect(ByVal signidentifyer As Object, Optional ByVal autoCloseDialogWhenComplete As Boolean = False) As Object
        'this function MUST be overidden by classes that inherit it

        If Me.connected Then


            If Not Me.disconnect() Then

                Return False
            End If



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

        Dim split_selectedsign As String() = selectedsign.Split(".")
        Dim this_server_index As Integer = Convert.ToInt32(split_selectedsign(0))
        Dim this_server_connection As serverConnection = ServerConnections(this_server_index)

        Dim this_sign_name = split_selectedsign(1)

        

        Dim selectsigncommand As String = "selectsign " & this_sign_name & Constants.vbCrLf
        Dim response As String

        If bgw.CancellationPending Then
            e.Cancel = True
            Return
        End If

        Dim proceed As Boolean = True

        bgw.ReportProgress(0, process & "connecting to sign:" & this_sign_name & " attempt " & attemptcounter)

        proceed = False 'we only procced beyond this loop if succesful connection
        While (Not proceed And attemptcounter < 3)

            If bgw.CancellationPending Then

                bgw.ReportProgress(0, process & "Connection process canceled!")
                'mycomportmanager.discardPortConnection(myPortConnectionHandle)
                e.Cancel = True
                Return
            End If



            Dim this_checkouthandle As checkouthandle = this_server_connection.checkout(Me.communication_time_out_in_seconds)

            If (this_checkouthandle.id = checkouthandle.ALREADYCHECKEDOUT.id) Then
                attemptcounter += 1
                Continue While
            End If
            this_server_connection.send(selectsigncommand, this_checkouthandle)

            Dim starttime As Double = DateAndTime.Timer

            While (starttime - DateAndTime.Timer < Me.communication_time_out_in_seconds) And (Not proceed)




                response &= this_server_connection.receive(this_checkouthandle)



                Dim split_response As String() = response.Split(" ")

                If split_response.Length >= 2 Then

                    If split_response(0) = "connected" Then
                        If split_response(1) = this_sign_name Then
                            'succesfully connected to sign
                            proceed = True

                        End If

                    End If
                End If



            End While

            this_server_connection.checkin(this_checkouthandle)


            attemptcounter += 1
        End While

        If Not proceed Then

            bgw.ReportProgress(50, process & "Error! unable to connect with sign:" & this_sign_name)
            'mycomportmanager.discardPortConnection(myPortConnectionHandle)
            e.Cancel = True
            Return

        End If






        'temporarily forgo testing sign connection because function writethenreadline is not currently correct


        'attemptcounter = 1
        'bgw.ReportProgress(50, process & "Testing connection... attempt " & attemptcounter)
        'While Not TestSignConnection()

        '    If attemptcounter > 40 Then
        '        bgw.ReportProgress(50, process & "Error! sign not responding...Giving up after 40 attempts ")
        '        'mycomportmanager.discardPortConnection(myPortConnectionHandle)
        '        e.Cancel = True
        '        Return
        '    End If
        '    If bgw.CancellationPending Then

        '        bgw.ReportProgress(50, process & "Connection process canceled!")
        '        'mycomportmanager.discardPortConnection(myPortConnectionHandle)
        '        e.Cancel = True
        '        Return
        '    End If
        '    System.Threading.Thread.Sleep(5)
        '    attemptcounter += 1
        '    bgw.ReportProgress(50, process & "Testing connection... attempt " & attemptcounter)

        'End While

        Me.connected = True
        bgw.ReportProgress(100, process & "Success! connected to sign " & selectedsign)



    End Sub
    Public Overrides Function disconnect() As Object
        If Not Me.connected Then
            Return True
        End If

        Dim returnvalue As Boolean = Me.dobackgroundwork(AddressOf disconnect_backgroundWork)

        'mark as discconected reguardless of communication with server    
        Me.connected = False
        Me._selectedsign = ""
        Return returnvalue

    End Function
    Protected Overridable Sub disconnect_backgroundWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)



        Dim process As String = "Disconnecting from " & selectedsign & Constants.vbCr
        Dim bgw As System.ComponentModel.BackgroundWorker = sender

        Dim attemptcounter As Int16 = 1

        Dim split_selectedsign As String() = selectedsign.Split(".")
        Dim this_server_index As Integer = Convert.ToInt32(split_selectedsign(0))
        Dim this_server_connection As serverConnection = ServerConnections(this_server_index)

        Dim this_sign_name = split_selectedsign(1)



        Dim disconnectCommand As String = "disconnect" & Constants.vbCrLf
        Dim response As String

        If bgw.CancellationPending Then
            e.Cancel = True
            Return
        End If

        Dim proceed As Boolean = True

        bgw.ReportProgress(0, process & "connecting to sign:" & this_sign_name & " attempt " & attemptcounter)

        proceed = False 'we only procced beyond this loop if succesful connection
        While (Not proceed And attemptcounter < 3)

            If bgw.CancellationPending Then

                bgw.ReportProgress(0, process & "Connection process canceled!")
                'mycomportmanager.discardPortConnection(myPortConnectionHandle)
                e.Cancel = True
                Return
            End If


            'note writeThenReadline can be used as long as selectedsign is defined   
            If writeThenReadline(disconnectCommand, response) = CommunicationResult.success Then

                If response.Trim = "disconnected" Then
                    bgw.ReportProgress(100, process & "succesfully disconnected from sign;" & this_sign_name)
                    Return
                    'success'
                End If
            End If



            attemptcounter += 1
        End While



        bgw.ReportProgress(50, process & "Error! unable to disconnect from sign:" & this_sign_name & this_sign_name)
        'mycomportmanager.discardPortConnection(myPortConnectionHandle)
        e.Cancel = True
        Return

        

    End Sub


    Public Overrides Function TestSignConnection(Optional ByVal comhandle As portConnectionHandle = Nothing) As Boolean
        'comhandle is ignored in this class because we done use a comport


        If communicationInProgress Then

            ' in process of sending or recieving data 
            'communication conflicts make test below fail

            Return True
        End If


        Dim dummystring As String = ""

        Dim returnvalue As Boolean = getFirmwareVersion(dummystring, dummystring)


        If Not returnvalue Then

            Dim breakpointholder As Int16 = 0
        End If
        Return returnvalue

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
