
Public Class SignConnection_FTP
    Inherits SignConnection_OneSign
    

    ''''''' related to asyncronous FTP
    Public Structure FtpState

        Public Shared counter_failedFTP_list As Integer = 0
        Public Shared counter_suceedFTP_list As Integer = 0
        Private Shared instantcount As Integer = 1
        Public i As Integer

        Private m_wait As Threading.ManualResetEvent
        Private m_request As System.Net.FtpWebRequest
        Private m_fileName As String
        'Private operationException As Exception = null
        Private m_operationException As Exception

        Private m_bytesinfile As Integer
        Private m_bytesread As Integer

        Dim m_status As String
        Dim m_resultCode As System.Net.FtpStatusCode

        Private m_operationComplete As Boolean

        Public ReadOnly Property operationComplete As Boolean
            Get
                Return m_operationComplete
            End Get
        End Property


        Public ReadOnly Property resultCode As System.Net.FtpStatusCode
            Get
                Return m_resultCode
            End Get
        End Property
        Public ReadOnly Property bytesinfile As Integer
            Get
                Return m_bytesinfile
            End Get
        End Property
        Public ReadOnly Property bytesread As Integer
            Get
                Return m_bytesread
            End Get
        End Property


        Sub init()
            'a structure does not allow to a new function
            'this function does what would normally be done in new()
            i = instantcount
            instantcount += 1
            m_operationException = Nothing
            m_wait = New Threading.ManualResetEvent(False)
            m_bytesinfile = -1
            m_bytesread = 0
            m_resultCode = Net.FtpStatusCode.Undefined
            m_operationComplete = False
        End Sub

        Public ReadOnly Property waitobject As Threading.ManualResetEvent
            'call this property with waitone to block untill finished
            Get
                Return m_wait
            End Get
        End Property


        Public Property Request As Net.FtpWebRequest
            Get
                Return m_request
            End Get
            Set(ByVal value As Net.FtpWebRequest)
                m_request = value
            End Set
        End Property

        Public Property FileName As String
            Get
                Return m_fileName
            End Get
            Set(ByVal value As String)
                m_fileName = value
            End Set
        End Property



        Public Property OperationException As Exception
            Get
                Return m_operationException
            End Get
            Set(ByVal value As Exception)
                m_operationException = value
            End Set
        End Property



        Public Property Status As String
            Get
                Return m_status
            End Get
            Set(ByVal value As String)
                m_status = value
            End Set
        End Property




        Public Sub EndGetStreamCallback(ByVal ar As IAsyncResult)
            m_operationComplete = False


            Dim state As FtpState = DirectCast(ar.AsyncState, FtpState)

            'state.m_status = "stream to server opened"
            state.m_status = "stream to server opened"

            Dim requestStream As IO.Stream = Nothing

            ' End the asynchronous call to get the request stream. 
            Try

                'requestStream = state.Request.EndGetRequestStream(ar)
                requestStream = state.Request.EndGetRequestStream(ar)




                ' Copy the file contents to the request stream. 
                Const bufferLength As Int16 = 2048
                Dim buffer(bufferLength) As Byte
                'Dim count As Int16 = 0
                Dim readBytes As Int16 = 1 'any dummy value other then 0
                Dim stream As IO.FileStream = IO.File.OpenRead(state.FileName)
                state.m_status = "local file " & state.FileName & " opened"
                state.m_bytesinfile = stream.Length
                While (readBytes <> 0)
                    readBytes = stream.Read(buffer, 0, bufferLength)
                    requestStream.Write(buffer, 0, readBytes)
                    '   count += readBytes
                    state.m_bytesread += readBytes

                    state.m_status = state.m_bytesread & " bytes out of " & state.m_bytesinfile & " sent"
                End While

                'Console.WriteLine ("Writing {0} bytes to the stream.", count);
                '// IMPORTANT: Close the request stream before sending the request.
                requestStream.Close()
                '// Asynchronously get the response to the upload request.
                state.Request.BeginGetResponse(
                    AddressOf EndGetResponseCallback,
                    state
                )

                '// Return exceptions to the main application thread. 
            Catch e As Exception

                state.m_resultCode = Net.FtpStatusCode.Undefined

                'Console.WriteLine("Could not get the request stream.")
                state.m_status = "an error occured"
                state.OperationException = e



                state.m_operationComplete = True

                counter_failedFTP_list += 1
                state.waitobject.Set()
                
                Return
            End Try




        End Sub

        ''''''wwwwww''''''
        '// The EndGetResponseCallback method   
        '   // completes a call to BeginGetResponse. 
        Public Sub EndGetResponseCallback(ByVal ar As IAsyncResult)


            Dim state As FtpState = DirectCast(ar.AsyncState, FtpState)
            'state.m_operationComplete = False
            state.m_operationComplete = False
            Dim response As Net.FtpWebResponse = Nothing
            'state.m_resultCode = Net.FtpStatusCode.Undefined

            state.m_resultCode = Net.FtpStatusCode.Undefined
            Try

                response = DirectCast(state.Request.EndGetResponse(ar), Net.FtpWebResponse)
                response.Close()

                'state.m_status = response.StatusDescription
                state.m_status = response.StatusDescription
                'state.m_resultCode = response.StatusCode
                state.m_resultCode = response.StatusCode


                ' // Signal the main application thread that  
                '// the operation is complete.
                'state.waitobject.Set()
                state.waitobject.Set()
                'state.m_operationComplete = True
                state.m_operationComplete = True
                '// Return exceptions to the main application thread. 
            Catch e As Exception

                'Console.WriteLine ("Error getting response.");
                'state.m_status = "an error occured!"
                state.m_status = "an error occured!"

                'state.OperationException = e
                state.OperationException = e

                'state.m_operationComplete = True
                state.m_operationComplete = True
                ' state.waitobject.Set()

                counter_failedFTP_list += 1
                state.waitobject.Set()


            End Try


            counter_suceedFTP_list += 1
            'state.m_operationComplete = True
            state.m_operationComplete = True

        End Sub
    End Structure











    Dim FTP_username As String
    Dim FTP_password As String
    'Dim FTP_IP As String '082413 change unto an array
    Dim FTP_IP_list As ArrayList = New ArrayList



    Dim FTP_directory As String
    Dim failedFTP_list As ArrayList = New ArrayList
   


    Public Overrides ReadOnly Property allSigns_working() As ArrayList
        Get
            Dim returnvalue As ArrayList = New ArrayList
            For Each sign As RemoteSignsForm.remoteSign In Form1.myRemoteSignsForm.remoteSignList
                returnvalue.Add(sign.signname)
                If (sign.signname Is Nothing) Then
                    Dim breakpointholder = ""
                End If
                If (sign.signname = "") Then
                    Dim breakpointholder = ""


                End If
            Next

            Return returnvalue

        End Get
    End Property

    Public Overrides Function disconnect() As Object
        Me._selectedsign = ""
        Me.connected = False
        Return True
    End Function
    Public Overrides Function TestSignConnection(Optional ByVal comhandle As Int16 = Nothing) As Boolean

        'currently there is no easily way to test this sign connction. 
        'All we know to do with this sign is upload a file to the server to send data
        Return (True)

    End Function


    Protected Overrides Sub Connect_backgroundWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

        Dim process As String = "Connecting to " & selectedsign & Constants.vbCr
        Dim bgw As System.ComponentModel.BackgroundWorker = sender

        'we have a temporary instance of form open the file each time.
        'this is one (sloppy) way to get around thread issues
        Dim temp_remote_signform As RemoteSignsForm = New RemoteSignsForm
        temp_remote_signform.init()
        For Each sign As RemoteSignsForm.remoteSign In temp_remote_signform.remoteSignList

            If (sign.signname = selectedsign) Then
                FTP_username = sign.username
                FTP_password = sign.password
                FTP_directory = sign.directory
            End If

            FTP_IP_list.Clear()
            For Each IP As String In sign.arrIP_list
                FTP_IP_list.Add(IP)
            Next

        Next
        Me.connected = True

        bgw.ReportProgress(100, process & "Success! connected to sign " & selectedsign)



    End Sub
    Dim bgw As System.ComponentModel.BackgroundWorker
    Private WithEvents myFtpUploadWebClient As New Net.WebClient

    'Private Sub myFtpUploadWebClient_UploadFileCompleted(ByVal sender As Object, ByVal e As System.Net.UploadFileCompletedEventArgs) Handles myFtpUploadWebClient.UploadFileCompleted
    '    'MsgBox(e.Result)
    '    Dim process As String = "Sending data to sign" & Constants.vbCr
    '    Try
    '        Dim res As Byte() = e.Result
    '        counter_suceedFTP_list += 1
    '    Catch ex As Exception
    '        ' failedFTP_list.Add(sender.) 
    '        counter_failedFTP_list += 1

    '        'MsgBox("Error occured sending the file!")

    '    End Try
    '    Dim message As String = ""
    '    Dim count_totalftp_list = FTP_IP_list.Count
    '    If counter_suceedFTP_list > 0 And counter_failedFTP_list > 0 Then
    '        message = counter_suceedFTP_list & " Suceeded out of " & count_totalftp_list & "  IPs in local_FTP_list; but " & counter_failedFTP_list & " File Uploads failed."

    '    ElseIf counter_failedFTP_list > 0 Then
    '        message = counter_failedFTP_list & " File Uploads failed out of " & count_totalftp_list & "   IPs in local_FTP_list. "
    '    Else
    '        message = counter_suceedFTP_list & " File Uploads suceeded out of " & count_totalftp_list & "   IPs in local_FTP_list.  "

    '    End If



    '    Dim percentprogress As Int16 = 100.0 * (counter_failedFTP_list + counter_suceedFTP_list) / count_totalftp_list

    '    If percentprogress <> 100 Then
    '        bgw.ReportProgress(percentprogress, process & message)
    '        'else
    '        'let another part of the program report the finish message
    '    End If


    '    Dim breakointholder As Int16 = 5

    'End Sub
    'Private Sub FtpUploadWebClient_UploadProgressChanged(ByVal sender As Object, ByVal e As System.Net.UploadProgressChangedEventArgs)
    '    Dim process As String = "Sending data to sign" & Constants.vbCr

    '    'if you'll want to calculate some ratio between what has been uploaded and what must be

    '    'you can use those two:

    '    Dim bytesAlreadySent As Long = e.BytesSent

    '    Dim totalBytesToSend As Long = e.TotalBytesToSend

    '    Dim ustate = e.UserState

    '    'for reporting progress percentage, you have that already inside UploadProgressChangedEventArgs:

    '    'bgw.ReportProgress(e.ProgressPercentage, process & "Uploading file to server, please wait......")

    'End Sub


    'this delegate can not be defined within a funtion running in a seperate thread
    'the rules of marshalling required to be defined in the primay thread
    'also it can not be defined outside of a function because an inner exceptions occurs durring startup
    Dim generate_file_output As getStringDelegate
    Protected Overrides Sub sendData_do()
        generate_file_output = AddressOf Form1.generate_file_output
        MyBase.sendData_do()
    End Sub
    Protected Overrides Sub sendData_backgroundWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        'Dim bgw As System.ComponentModel.BackgroundWorker = sender
        Dim count_totalftp_list = FTP_IP_list.Count
        'Private WithEvents myFtpUploadWebClient As New Net.WebClient
        Dim myFtpUploadWebClients As ArrayList = New ArrayList
        Dim mystates(count_totalftp_list - 1) As FtpState
        Dim mywaitobjects(count_totalftp_list - 1) As Threading.ManualResetEvent

        bgw = sender
        'MsgBox("bgw ok")

        Dim process As String = "Sending data to sign---------  " & selectedsign & "" & Constants.vbCr
        bgw.ReportProgress(0, process & "Uploading files       Please wait.............")


        Try

            'create temporary file
            'MsgBox(1)


            'this section is to create a backup in the unlikely event that the user has a file with the name we need to upload
            Dim tempfilcounter As Int16 = 0
            If (My.Computer.FileSystem.FileExists(selectedsign & ".data")) Then
                tempfilcounter += 1
                While My.Computer.FileSystem.FileExists(selectedsign & "_back" & tempfilcounter & " .data")
                    tempfilcounter += 1
                End While

                My.Computer.FileSystem.RenameFile(selectedsign & ".data", selectedsign & "_back" & tempfilcounter & " .data")
            End If
            'MsgBox(2)

            'save the current sign data
            Dim SW As IO.StreamWriter = IO.File.CreateText(selectedsign & ".data")
            'MsgBox(3)


            'MsgBox(4)

            SW.Write(generate_file_output.Invoke)
            'MsgBox(1)


            SW.Close()

            'MsgBox(2)
            'upload file
            'myFtpUploadWebClient.Credentials = New System.Net.NetworkCredential(FTP_username, FTP_password)

            'MsgBox(3)

            FtpState.counter_failedFTP_list = 0
            FtpState.counter_suceedFTP_list = 0
            failedFTP_list.Clear() 'clear fail list before starting uploads - not curretnly used




            Dim i As Integer = 0
            For Each FTP_IP As String In FTP_IP_list





                'Dim state As New FtpState
                'mystates.Add(New FtpState)
                mystates(i).init()

                'state.init()
                'Dim waitobject As Threading.ManualResetEvent = state.waitobject


                Dim newstring As String = "ftp://" & FTP_IP & "/" & FTP_directory & "/" & selectedsign & ".data"

                'Dim FtpUploadWebClient As System.Net.FtpWebRequest 'As New Net.FtpWebRequest  '090213  passive mode error FtpWebRequest
                'FtpUploadWebClient = DirectCast(System.Net.WebRequest.Create(newstring), System.Net.FtpWebRequest)
                Dim FtpUploadWebClient As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(newstring), System.Net.FtpWebRequest)
                FtpUploadWebClient.UsePassive = True

                Try
                    FtpUploadWebClient.Credentials = New System.Net.NetworkCredential(FTP_username, FTP_password)
                    FtpUploadWebClient.Method = System.Net.WebRequestMethods.Ftp.UploadFile
                    mystates(i).Request = FtpUploadWebClient
                    mystates(i).FileName = selectedsign & ".data"

                    '// Get the event to wait on.
                    'waitobject = state.waitobject
                    mywaitobjects(i) = mystates(i).waitobject

                    FtpUploadWebClient.BeginGetRequestStream(AddressOf mystates(i).EndGetStreamCallback, mystates(i))



                    'Dim filecontents() As Byte = System.IO.File.ReadAllBytes(selectedsign & ".data")
                    'Dim remote_stream As System.IO.Stream = FtpUploadWebClient.GetRequestStream()
                    'remote_stream.Write(filecontents, 0, filecontents.Length)
                    'remote_stream.Close()
                    'remote_stream.Dispose()
                    ' FtpUploadWebClient.UploadFileAsync(New Uri(newstring), selectedsign & ".data")


                    '083113

                    'AddHandler FtpUploadWebClient.UploadFileCompleted, AddressOf myFtpUploadWebClient_UploadFileCompleted
                    'AddHandler FtpUploadWebClient.UploadProgressChanged, AddressOf FtpUploadWebClient_UploadProgressChanged
                    'FtpUploadWebClient. = False
                    '//ftp.UsePassive = False copied from web

                Catch ex As Exception
                    FtpState.counter_failedFTP_list += 1
                    Dim message2 As String = "error!: " & ex.Message
                    'Dim count_totalftp_list2 = FTP_IP_list.Count
                    'If counter_suceedFTP_list > 0 And counter_failedFTP_list > 0 Then
                    '    message2 = counter_suceedFTP_list & " Suceeded out of " & count_totalftp_list & "  IPs in local_FTP_list; but " & counter_failedFTP_list & " File Uploads failed."

                    'ElseIf counter_failedFTP_list > 0 Then
                    '    message2 = counter_failedFTP_list & " File Uploads failed out of " & count_totalftp_list2
                    'Else
                    '    message2 = counter_suceedFTP_list & " File Uploads suceeded out of " & count_totalftp_list2

                    'End If
                    'Dim percentprogress As Int16 = 100.0 * (counter_failedFTP_list + counter_suceedFTP_list) / count_totalftp_list2
                    bgw.ReportProgress(99, process & message2)
                    bgw.ReportProgress(100, process & message2)



                    'My.Computer.FileSystem.DeleteFile(selectedsign & ".data")
                    ''MsgBox(6)
                    'If tempfilcounter <> 0 Then
                    '    'reach here if we started out with a user file that happend to have the same name as our data file

                    '    My.Computer.FileSystem.RenameFile(selectedsign & "_back" & tempfilcounter & " .data", selectedsign & ".data")
                    'End If

                End Try

                
                i += 1
            Next


            i = 0
            While (FtpState.counter_failedFTP_list + FtpState.counter_suceedFTP_list < count_totalftp_list)
                'update progress

                If i > 300 Then
                    'time out after 5 minutes
                    MsgBox("timeout")
                    Exit While
                End If
                Dim breakpointholder = 1
                Threading.Thread.Sleep(1000)


                i += 1
            End While

            'For Each waitobject As System.Threading.ManualResetEvent In mywaitobjects
            '    'do to problems with copies of state object being passed by reference, 
            '    'this method did not work either
            '    waitobject.WaitOne()
            'Next
            'MsgBox(4)

            'Dim stilluploading As Boolean = True
            'While stilluploading
            '    stilluploading = False

            '    Dim percentupload As Integer = 100

            '    For Each state As FtpState In mystates
            '        If Not state.operationComplete Then
            '            stilluploading = True
            '        End If

            '        Dim this_persent_upload As Integer '= 100.0 * state.bytesread / state.bytesinfile

            '        If state.bytesinfile < 0 Then
            '            'have not yet determnined size of file.
            '            this_persent_upload = 0
            '        ElseIf state.bytesinfile = 0 Then
            '            'empty file! 
            '            this_persent_upload = 99

            '        Else
            '            this_persent_upload = 100.0 * state.bytesread / state.bytesinfile
            '        End If


            '        If percentupload > this_persent_upload Then
            '            percentupload = percentupload = this_persent_upload
            '        End If

            '        If percentupload = 100 Then
            '            percentupload = 99
            '        End If

            '        bgw.ReportProgress(percentupload, process & "Uploading files       Please wait.............")


            '    Next


            'For Each FtpUploadWebClient As Net.WebClient In myFtpUploadWebClients
            '    If bgw.CancellationPending Then
            '        Exit While
            '    End If

            '    If FtpUploadWebClient.IsBusy Then
            '        stilluploading = True
            '        Continue While
            '    End If


            'Next


            'End While

            'Dim i As Int16 = 0
            'While (count_totalftp_list <> counter_failedFTP_list + counter_suceedFTP_list)
            '    Threading.Thread.Sleep(100)
            '    i += 1
            '    If i > 1000 Then

            '        'for some reasone the upload_complete event handler has not properly updated the counters
            '        'enoth time has passed to assume this is not going to happen

            '        'for now do nothing more, the user may see funny status info below

            '        Exit While
            '    End If

            'End While


            'If bgw.CancellationPending Then
            '    For Each FtpUploadWebClient As Net.WebClient In myFtpUploadWebClients
            '        FtpUploadWebClient.CancelAsync()
            '    Next
            '    e.Cancel = True
            '    Return
            'End If

            'MsgBox(5)
            'MsgBox(5)
            'delete temprary file
            My.Computer.FileSystem.DeleteFile(selectedsign & ".data")
            'MsgBox(6)
            If tempfilcounter <> 0 Then
                'reach here if we started out with a user file that happend to have the same name as our data file

                My.Computer.FileSystem.RenameFile(selectedsign & "_back" & tempfilcounter & " .data", selectedsign & ".data")
            End If
            'MsgBox(7)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





        'Dim message As String = ""

        'If counter_suceedFTP_list > 0 And counter_failedFTP_list > 0 Then
        '    message = counter_failedFTP_list & " Uploads failed and " & counter_suceedFTP_list & " Suceeded out of " & count_totalftp_list

        'ElseIf counter_failedFTP_list > 0 Then
        '    message = counter_failedFTP_list & " Uploads failed out of " & count_totalftp_list
        'Else
        '    message = counter_suceedFTP_list & " Uploads suceeded out of " & count_totalftp_list

        'End If


        'Dim percentprogress As Int16 = 100.0 * (counter_failedFTP_list + counter_suceedFTP_list) / count_totalftp_list
        bgw.ReportProgress(99, "Finished: " & process & "finished")
        bgw.ReportProgress(100, "Finished: " & process & "finished")



        'bgw.ReportProgress(99, process & "Finished sending data to  to " & selectedsign)
        'bgw.ReportProgress(100, process & "Finished sending data to  to " & selectedsign)

        Return








        'Dim process As String = "Sending data to sign" & Constants.vbCr
        'Dim bgw As System.ComponentModel.BackgroundWorker = sender
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


End Class
