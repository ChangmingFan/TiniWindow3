
Public Class SignConnection_FTP
    Inherits SignConnection_OneSign

    Dim FTP_username As String
    Dim FTP_password As String
    'Dim FTP_IP As String '082413 change unto an array
    Dim FTP_IP_list As ArrayList = New ArrayList



    Dim FTP_directory As String


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
            For Each IP As String In sign.IP_list
                FTP_IP_list.Add(IP)
            Next

        Next
        Me.connected = True

        bgw.ReportProgress(100, process & "Success! connected to sign " & selectedsign)



    End Sub
    Dim bgw As System.ComponentModel.BackgroundWorker
    Private WithEvents myFtpUploadWebClient As New Net.WebClient

    Private Sub myFtpUploadWebClient_UploadProgress(ByVal sender As Object, ByVal e As System.Net.UploadFileCompletedEventArgs) Handles myFtpUploadWebClient.UploadFileCompleted
        'MsgBox(e.Result)
        Try
            Dim res As Byte() = e.Result
        Catch ex As Exception
            MsgBox("an error occurs sendign the file!")
        End Try

        Dim breakointholder As Int16 = 5

    End Sub
    Private Sub FtpUploadWebClient_UploadProgressChanged(ByVal sender As Object, ByVal e As System.Net.UploadProgressChangedEventArgs)
        Dim process As String = "Sending data to sign" & Constants.vbCr

        'if you'll want to calculate some ratio between what has been uploaded and what must be

        'you can use those two:

        Dim bytesAlreadySent As Long = e.BytesSent

        Dim totalBytesToSend As Long = e.TotalBytesToSend

        Dim ustate = e.UserState

        'for reporting progress percentage, you have that already inside UploadProgressChangedEventArgs:

        bgw.ReportProgress(e.ProgressPercentage, process & "uploading file to server")

    End Sub


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

        'Private WithEvents myFtpUploadWebClient As New Net.WebClient
        Dim myFtpUploadWebClients As ArrayList = New ArrayList



        bgw = sender
        'MsgBox("bgw ok")

        Dim process As String = "Sending data to sign: '" & selectedsign & "'" & Constants.vbCr
        bgw.ReportProgress(0, process & "uploading files - please wait...")


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
            For Each FTP_IP As String In FTP_IP_list
                Dim FtpUploadWebClient As New Net.WebClient
                FtpUploadWebClient.Credentials = New System.Net.NetworkCredential(FTP_username, FTP_password)

                AddHandler FtpUploadWebClient.UploadProgressChanged, AddressOf FtpUploadWebClient_UploadProgressChanged
                FtpUploadWebClient.UploadFileAsync(New Uri("ftp://" & FTP_IP & "/" & FTP_directory & "/" & selectedsign & ".data"), selectedsign & ".data")
                myFtpUploadWebClients.Add(FtpUploadWebClient)
            Next

            'MsgBox(4)

            Dim stilluploading As Boolean = True
            While stilluploading
                stilluploading = False

                For Each FtpUploadWebClient As Net.WebClient In myFtpUploadWebClients
                    If bgw.CancellationPending Then
                        Exit While
                    End If

                    If FtpUploadWebClient.IsBusy Then
                        stilluploading = True
                        Continue While
                    End If


                Next


            End While

            If bgw.CancellationPending Then
                For Each FtpUploadWebClient As Net.WebClient In myFtpUploadWebClients
                    FtpUploadWebClient.CancelAsync()
                Next
                e.Cancel = True
                Return
            End If

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
