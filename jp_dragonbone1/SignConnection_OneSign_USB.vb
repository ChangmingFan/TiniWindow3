Imports portConnectionHandle = System.Int16 'create an alias to make function signatures less confusing
Public Class SignConnection_OneSign_USB
    Inherits SignConnection_OneSign

    '1 millisecond = 0.001 seconds
    Const ATGUARDTIMEINSECONDS As Double = 0.02 '5milliseconds
    Protected Sub New()
        'required to prevent classes inheriting this from having an error
    End Sub

    Public Sub New(ByRef CM As ComportManager)

        'the structure of this class hierachy is such that start up tasks defined in the signconnection_base
        'are defined in the constructor which does not take any parameters and is not a public constructor.
        'all public constructors are overidded in each class.
        'therefore all consrtuctors must call MyBase.new() 
        MyBase.new()

        'there is one comport manager in the whole program
        mycomportmanager = CM

        CM.addcomportscan(_allSigns_working, AddressOf Me.testComportWorking)
        'temporaily remove to speed up scann process because we don't yet use info
        'CM.addcomportscan(_allSigns_NeedFirmware, AddressOf Me.testComportNeedFirmWare)

    End Sub

    Public Overrides Function disconnect() As Object
        If Not Me.connected Then
            Return True
        End If
        If mycomportmanager.discardPortConnection(Me.myPortConnectionHandle) <> ComportManager.disgardPortConnectionResult.success Then
            Return False
        End If
        Me.myPortConnectionHandle = Nothing
        Me.connected = False
        Me._selectedsign = ""
        Return True
    End Function

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


        myPortConnectionHandle = -2
        While myPortConnectionHandle < 0
            If attemptcounter > 40 Then
                bgw.ReportProgress(0, process & "Error! open comport...Giving up after 40 attempts ")
                e.Cancel = True
                Return
            End If
            bgw.ReportProgress(0, process & "creating comport handle... attempt " & attemptcounter)

            If bgw.CancellationPending Then
                bgw.ReportProgress(0, process & "connection process canceled ")
                e.Cancel = True
                Return
            End If
            myPortConnectionHandle = mycomportmanager.createPortConnection(selectedsign, )
            attemptcounter += 1
            'puase so that if there is an error the user can see the couter and do something
            System.Threading.Thread.Sleep(300)
        End While

        If bgw.CancellationPending Then
            e.Cancel = True
            Return
        End If

        attemptcounter = 1
        bgw.ReportProgress(50, process & "Testing connection... attempt " & attemptcounter)
        While Not TestSignConnection()

            If attemptcounter > 40 Then
                bgw.ReportProgress(50, process & "Error! sign not responding...Giving up after 40 attempts ")
                mycomportmanager.discardPortConnection(myPortConnectionHandle)
                e.Cancel = True
                Return
            End If
            If bgw.CancellationPending Then

                bgw.ReportProgress(50, process & "Connection process canceled!")
                mycomportmanager.discardPortConnection(myPortConnectionHandle)
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

    

    Protected Function testComportWorking(ByVal comport As String) As Boolean
        'tempoariliy disable usb
        'Return False

        'this function is MUST be overiden in classes that inherit it 

        'for safety conformity and flexibility I have decided on the following rules

        'this functions is passed the name of a closed comport
        'this function should close the comport it tests
        'this function should not modify class comport data.

        
        Try
            'exclude ports that cant be opened
            Dim temport As System.IO.Ports.SerialPort

            Try
                temport = New System.IO.Ports.SerialPort(comport, comport_baudrate, comport_parity, comport_databits, comport_stopbits)
                temport.Open()

                temport.WriteTimeout() = 100
            Catch ex As Exception
                Try
                    temport.Close()
                Catch exx As Exception

                End Try

                Return False

            End Try



            'test for sign connected
            Try


                Dim majorversion As Integer
                Dim minorversion As Integer

                If old_getFirmwareVersion(temport, majorversion, minorversion) Then
                    If majorversion >= MIN_FIRMWARE_MAJOR_VERSION And minorversion >= MIN_FIRMWARE_MINOR_VERSION Then

                        'test to exclude comports with atmel coordinator attached
                        System.Threading.Thread.Sleep(100) 'we were getting late junk after clearing buffer
                        temport.ReadExisting() 'clear buffer
                        temport.Write("Ctttttttt" & Constants.vbCrLf) 'a nonexistant coordinator command to get back coordinator error 
                        System.Threading.Thread.Sleep(100)
                        Dim redstring As String = temport.ReadExisting

                        'remove cr and lf
                        redstring = String.Join("", redstring.Split(Constants.vbCr))
                        redstring = String.Join("", redstring.Split(Constants.vbLf))



                        If redstring = "Ct" Then
                            'this is an atmel coordinator    


                            'close port
                            temport.Close()

                            'not a usb sign
                            Return False

                        Else
                            'not an atmell coordinator


                            ' continue to test to exclude xb tranceiver
                        End If








                       
                        'enter AT mode


                        '2 attempts to enter atmode
                        System.Threading.Thread.Sleep(ATGUARDTIMEINSECONDS / 0.001)
                        temport.ReadExisting() 'clear buffer
                        temport.Write("+++")
                        System.Threading.Thread.Sleep(ATGUARDTIMEINSECONDS / 0.001)
                        Dim readstring As String = temport.ReadExisting
                        If Not readstring.StartsWith("OK") Then
                            temport.Write("atcn" & Environment.NewLine) 'close in case needed

                            System.Threading.Thread.Sleep(ATGUARDTIMEINSECONDS / 0.001)
                            temport.ReadExisting() 'clear buffer
                            temport.Write("+++")
                            System.Threading.Thread.Sleep(ATGUARDTIMEINSECONDS / 0.001)
                            readstring = temport.ReadExisting
                        End If
                        If readstring.StartsWith("OK") Then
                            'xbee module attached

                            'exit AT mode
                            temport.Write("atcn" & Environment.NewLine)

                            'commented out code may be good for debugging but in running nothing to do if fail to exit atmode

                            'System.Threading.Thread.Sleep(100)


                            'If Not temport.ReadExisting.Substring(0, 2) = "OK" Then
                            '    'MsgBox("Failed Exiting Command Mode")

                            'End If


                            'close port
                            temport.Close()

                            'not a USB port because XB module attached
                            Return False

                        Else

                            'no xbmodule attached
                            'therefore is a USB connection
                            temport.Close()
                            Return True

                        End If




                    Else

                        'is a sign but old firmware
                        temport.Close()
                        Return False

                    End If

                Else

                    temport.Close()
                    Return False

                End If
            Catch ex As Exception

                Try
                    temport.Close()
                Catch exx As Exception

                End Try


                Return False
            End Try

            'should not reach here
            MsgBox("bug in function testComport in signConnectio_OneSign")
            Return False
        Catch ex As Exception
            MsgBox("standard" & Constants.vbCrLf & ex.Message)
        End Try



        '
    End Function

    Protected Function testComportNeedFirmWare(ByVal comport As String) As Boolean
        'this function is MUST be overiden in classes that inherit it 

        'for safety conformity and flexibility I have decided on the following rules

        'this functions is passed the name of a closed comport
        'this function should close the comport it tests
        'this function should not modify class comport data.



        'at the moment this funtion is buggy and not worth the time to fix
        Return False

        If comport.Trim = "COM8" Then
            Dim dummy = "dummy"
        End If



        Try

            Dim temport As System.IO.Ports.SerialPort

            'open port
            Try
                temport = New System.IO.Ports.SerialPort(comport, comport_baudrate, comport_parity, comport_databits, comport_stopbits)
                temport.Open()

            Catch ex As Exception
                Try
                    temport.Close()
                Catch exx As Exception

                End Try

                'port failed to open
                Return False

            End Try


            'exclude ports with tranceiver units
            Try
                'open comport
                'comport = My.Computer.Ports.OpenSerialPort(comnum)


                'enter AT mode
                System.Threading.Thread.Sleep(ATGUARDTIMEINSECONDS / 0.001)
                temport.Write("+++")
                System.Threading.Thread.Sleep(ATGUARDTIMEINSECONDS / 0.001)
                If Not temport.ReadExisting.Substring(0, 2) = "OK" Then
                    'MsgBox("Failed To Enter Command Mode")
                    'exceptions is intended to be caught below
                    Throw New Exception

                End If


                'exit AT mode
                temport.Write("atcn" & Environment.NewLine)
                System.Threading.Thread.Sleep(100)
                If Not temport.ReadExisting.Substring(0, 2) = "OK" Then
                    'MsgBox("Failed Exiting Command Mode")

                    'exceptions is intended to be caught below
                    Throw New Exception

                End If


                'reaching here means the port is connected to a tranceiver
                'and is not a USB connection
                Return False


            Catch ex As Exception

                'not connected to tranceiver

            End Try



            Try


                Dim majorversion As Integer
                Dim minorversion As Integer

                If old_getFirmwareVersion(temport, majorversion, minorversion) Then
                    If majorversion >= MIN_FIRMWARE_MAJOR_VERSION And minorversion >= MIN_FIRMWARE_MINOR_VERSION Then

                        'firmware up to date does not need firmware
                        temport.Close()
                        Return False
                    Else

                        temport.Close()
                        Return True

                    End If

                Else

                    If old_bootloaderrunning(temport) Then
                        Return True
                    Else
                        Return False
                    End If

                End If
            Catch ex As Exception
                Return False
            End Try

            'should not reach here
            MsgBox("bug in function testComport in signConnectio_OneSign")
            Return False

        Catch ex As Exception
            MsgBox("bootloader" & Constants.vbCrLf & ex.Message)
        End Try

    End Function


    'function that are overidden from onesign


    Public Overrides Function TestSignConnection(Optional ByVal comhandle As portConnectionHandle = Nothing) As Boolean

        If comhandle = Nothing Then

            Dim dummystring As String = ""
            Return getFirmwareVersion(dummystring, dummystring)

        Else
            Dim dummystring As String = ""
            Return getFirmwareVersion(dummystring, dummystring, comhandle)

        End If



    End Function


    























    '''''legacy functions now called only form the test function sent to the comport scanner
    'date back to before implementing class structure for connections




    Protected Function old_readline(ByRef comport As System.IO.Ports.SerialPort, ByRef stringtoreadto As String) As Integer
        '  !!!
        'this function reads one line from the serial port. a line ends with <cr><lf>
        'returns true is complete line read false if times out or too many characters
        'Dim echoerror As Integer = 0 '0-no error 1-time out 2-string too long 3-unexpected string 
        'myserialport must be open before calling this function
        'backgroundworkerdebugvalue = "50A"
        Dim starttime As Double = DateAndTime.Timer() 'returns seconds since midnight
        stringtoreadto = ""
        Dim timesthrouloop As Integer = 0
        While (True)
            'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "a"
            echoerror = 0
            'If (progresform_cancel) Then
            '    'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "b"
            '    cancel_read_or_write() 'confirms cancle and throws argument exception
            'End If

            'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "c"
            If (DateAndTime.Timer() - starttime > 0.03 Or DateAndTime.Timer() - starttime < -86399.97) Then
                'Dim deltatime As Double = DateAndTime.Timer() - starttime
                'If (deltatime > 3 Or deltatime < -86399) Then
                echoerror = 1
                '12072009 time out changed from 3 seconds to 0.03 to speed up comport scan process 
                ''  reversed 'jan/3/2011 increased time out because Atmel Wireless kept tripping up  

                'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "d"
                Return False
            End If
            'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "e"
            Dim characterread As String
            Try
                'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "f"
                characterread = comport.ReadExisting()
                'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "g"
            Catch ex As UnauthorizedAccessException
                'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "h"
                'deviceandmemorymatch = False
                Dim loopcounter As Integer = 0
                Dim ok As Boolean = False
                While (loopcounter < 3)
                    Try
                        ' backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "i" + loopcounter.ToString
                        comport.Close()
                        'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "j" + loopcounter.ToString
                        comport.Open()
                        'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "k" + loopcounter.ToString
                        characterread = comport.ReadExisting()
                        'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "l" + loopcounter.ToString

                    Catch ex2 As UnauthorizedAccessException
                        'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "m" + loopcounter.ToString
                        loopcounter += 1
                        Continue While
                    Catch ex3 As System.IO.IOException
                        'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "n" + loopcounter.ToString
                        loopcounter += 1
                        Continue While
                    End Try
                    'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "o" + loopcounter.ToString
                    ok = True
                    loopcounter = 5
                End While
                'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "p"
                If (Not ok) Then
                    'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "q"
                    echoerror = 7
                    Return False
                End If

                '''''''
            Catch ex_2 As System.IO.IOException
                'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "r"
                'deviceandmemorymatch = False
                Dim loopcounter As Integer = 0
                Dim ok As Boolean = False
                While (loopcounter < 3)
                    'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "s" + loopcounter.ToString
                    Try
                        comport.Close()
                        'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "t" + loopcounter.ToString
                        comport.Open()
                        'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "v" + loopcounter.ToString
                        characterread = comport.ReadExisting()
                        'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "w" + loopcounter.ToString
                    Catch ex2 As UnauthorizedAccessException
                        'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "x" + loopcounter.ToString
                        loopcounter += 1
                        Continue While
                    Catch ex3 As System.IO.IOException
                        'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "y" + loopcounter.ToString
                        loopcounter += 1
                        Continue While
                    End Try
                    ' backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "z" + loopcounter.ToString
                    ok = True
                    loopcounter = 5
                End While
                'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "A"

                If (Not ok) Then
                    'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "B"
                    echoerror = 7
                    Return False
                End If



            End Try

            'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "C"

            If (characterread <> "") Then
                ' backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "D"
                starttime = DateAndTime.Timer()
            End If
            stringtoreadto = stringtoreadto + characterread

            'jp jan/3/2011 removed MAXIMUMECHOLENGTH because CDL echo exceeds
            If (stringtoreadto.Length() > MAXIMUMECHOLENGTH) Then
                'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "E"
                echoerror = 2
                'For Each letter As Char In stringtoreadto
                '    MsgBox(Asc(letter))
                'Next
                ' Return False

            End If
            'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "F"

            If (stringtoreadto.Length() >= 2) Then
                'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "G"
                If (stringtoreadto.Substring(stringtoreadto.Length - 2, 2) = Constants.vbCrLf) Then
                    'backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "H"
                    'For Each letter As Char In stringtoreadto
                    '    MsgBox(Asc(letter))
                    'Next

                    'MsgBox("======")
                    Return True
                End If
            End If
            ' backgroundworkerdebugvalue = (500 + timesthrouloop).ToString + "I"
        End While






        'Dim commandstring As String = "W " + Hex(AscW(character)) + Constants.vbCrLf
        'Return commandstring


        MsgBox("bugg")




    End Function

    Protected Function old_sendcommand(ByRef comport As System.IO.Ports.SerialPort, ByVal command As String) As Boolean
        Dim cont As Boolean = True
        Dim attemps As Integer = 0
        While (attemps < 3)
            'backgroundworkerdebugvalue = (attemps + 400).ToString + "a"
            With comport
                Try
                    '     backgroundworkerdebugvalue = (attemps + 410).ToString
                    'If (.IsOpen) Then
                    '.ReadExisting()
                    '    backgroundworkerdebugvalue = (attemps + 410).ToString + "b" + .WriteTimeout.ToString
                    '.Close()
                    '   backgroundworkerdebugvalue = (attemps + 410).ToString + "c" + .WriteTimeout.ToString
                    '.Open()
                    '  backgroundworkerdebugvalue = (attemps + 410).ToString + "d" + .WriteTimeout.ToString
                    .Write(command)

                    ' backgroundworkerdebugvalue = (attemps + 420).ToString
                    Return True

                Catch ex As Exception
                    'backgroundworkerdebugvalue = (attemps + 430).ToString
                    'deviceandmemorymatch = False
                    Try
                        '   backgroundworkerdebugvalue = (attemps + 440).ToString
                        .Close()
                        '  backgroundworkerdebugvalue = (attemps + 450).ToString
                    Catch ex2 As Exception
                        ' backgroundworkerdebugvalue = (attemps + 460).ToString
                    End Try
                    Try
                        'backgroundworkerdebugvalue = (attemps + 470).ToString
                        .Open()
                        'backgroundworkerdebugvalue = (attemps + 480).ToString
                    Catch ex2 As Exception
                        'backgroundworkerdebugvalue = (attemps + 490).ToString
                    End Try
                    'backgroundworkerdebugvalue = (attemps + 400).ToString + "a"
                End Try


            End With
            ' backgroundworkerdebugvalue = (attemps + 400).ToString + "b"
            attemps += 1
        End While
        'backgroundworkerdebugvalue = (attemps + 400).ToString + "c"
        echoerror = 7
        Return False
    End Function



    Protected Function old_getFirmwareVersion(ByRef comport As System.IO.Ports.SerialPort, ByRef major_version As String, ByRef minor_version As String) As Boolean


        'changed the attempts from 3 to 2 to speed up the comport scan process

        Dim line As String = ""
        'Dim addressasstring As String = addresstostring(address)
        ' Dim myaddresscommand As String = "A " + addresstostring(address) + Constants.vbCrLf
        Dim attemps As Integer = 0
        With comport
            Try
                If (Not .IsOpen) Then
                    'deviceandmemorymatch = False
                    .Open()
                End If

            Catch ex As Exception
                echoerror = 7
                Return False
            End Try

            While (True)
                line = "" 'clear between attempts
                If (Not old_sendcommand(comport, VERSIONCOMMAND)) Then
                    echoerror = 7
                    Return False
                End If
                If (Not old_readline(comport, line)) Then
                    If (echoerror = 1 And attemps < 3) Then
                        attemps = attemps + 1

                    Else
                        '.Close()
                        Return False
                    End If
                ElseIf (Not validFirmwareVersionResponse(line)) Then
                    If (attemps < 3) Then
                        attemps = attemps + 1

                    Else
                        echoerror = 3
                        '.Close()
                        Return False
                    End If

                Else
                    'MsgBox(line)
                    'MsgBox(line.Substring(2, 2))
                    'MsgBox(line.Substring(4, 2))

                    major_version = Convert.ToInt32(line.Substring(2, 2), 16)
                    minor_version = Convert.ToInt32(line.Substring(4, 2), 16)

                    Return True
                End If

            End While

        End With

    End Function

    '''''''''''''legacy bootloader functions
    Private Function old_bootloaderrunning(ByRef comport As System.IO.Ports.SerialPort) As Boolean
        With comport
            Try
                If (Not .IsOpen) Then
                    .Open()
                End If

                If (Not .IsOpen) Then
                    .Close()
                    Return False
                End If

                If Not old_sendcommand(comport, BOOTLOADER_VERSIONCOMMAND) Then
                    .Close()
                    Return False
                End If

                Dim version As String = old_readport(comport, 5) ' old comment said "should read 4 then timeout" however examining code sugests return 2
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





    Private Function old_readport(ByRef comport As System.IO.Ports.SerialPort, ByVal length As Integer) As String
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

End Class
