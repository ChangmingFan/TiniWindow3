
Imports portConnectionHandle = System.Int16 'create an alias to make function signatures less confusing


Public Class SignConnection_OneSign_Wireless_Atmel

    Inherits SignConnection_OneSign_USB
    Public Const DEVICE_LIST_COMMAND As String = "CDL" & Constants.vbCrLf
    'jp jan/3/2011: this clas created by cutting and pasting code from SignConnection_OneSign_Wireless_XB

    Public ReadOnly Property firstComportScanComplete() As Boolean
        Get
            Return m_firstcomportscancomplete

        End Get
    End Property
    Dim m_firstcomportscancomplete As Boolean = False 'set to true in scan process after going through 10 addresses with no signs found

    Dim m_allportswithTranceiverunits As ArrayList = New ArrayList

    Public ReadOnly Property allportswithTranceiverunits() As ArrayList
        Get
            Return m_allportswithTranceiverunits
        End Get
    End Property
    Public Sub New(ByRef CM As ComportManager)
        'MyClass.New()
        'there is one comport manager in the whole program
        mycomportmanager = CM


        CM.addcomportscan(m_allportswithTranceiverunits, AddressOf Me.testComportWorking)
        'the first paraemter is an arraylist that stores ports with Xbee units connected
        'the second parameter is a function delegate. Function delegates are some what 
        'similar to function pointers in other programming languages
        'testComportWorking should be defined to take the port passed to it and test
        'whether or not this port has an xbee module attached to it.


    End Sub


    'eddie all funtions below need to be defined for wireless connection 
    'Public Overrides Function connect(ByVal signidentifier As String) As Object
    '    'This was simply copied from SignConnection_OneSignUSB. 
    '    'it probably will need to be modified for this class
    '    _selectedsign = signidentifier

    '    myProgressForm.retryfunction = AddressOf connect_do 'tell progress form which funtion to call if retry button clicked
    '    connect_do()
    '    myProgressForm.ShowDialog()


    '    'this function completes when the user clicks OK on the dialog form
    '    'it the value returned indicates whether of not a succesfull connection has been made   

    '    Return Me.connected

    'End Function


    'Protected Overridable Sub connect_do()
    '    'the pupose of seperating this from connect is to be able to call 
    '    'this function if retry is clicked from the dialog form after a failure
    '    '

    '    'This was simply copied from SignConnection_OneSignUSB. 
    '    'it probably will need to be modified for this class

    '    connected = True
    '    Dim bgw As System.ComponentModel.BackgroundWorker = New System.ComponentModel.BackgroundWorker
    '    bgw.WorkerReportsProgress = True
    '    bgw.WorkerSupportsCancellation = True
    '    AddHandler bgw.DoWork, AddressOf Connect_backgroundWork
    '    AddHandler bgw.ProgressChanged, AddressOf common_backgroundwork_ProgressChanged
    '    AddHandler bgw.RunWorkerCompleted, AddressOf common_backgroundwork_RunWorkerCompleted
    '    bgw.RunWorkerAsync()

    'End Sub

    Protected Overrides Sub Connect_backgroundWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)


        'MsgBox(0)
        Dim process As String = "Connecting to " & selectedsign & Constants.vbCrLf
        'the convention for the second parameter sent to bgw.ReportProgress is that is a 2 line string. 
        'the first line is a process description and appears in the title of the progress form
        'the second line is a progress description and appears above the progress bar on the the progress form.

        Dim bgw As System.ComponentModel.BackgroundWorker = sender

        Dim splitselectedsign As String() = selectedsign.Split(".")

        If splitselectedsign.Length <> 2 Then
            bgw.ReportProgress(0, process & "Bug! invalid value for selectedsign")
            e.Cancel = True
            Return
        End If
        Dim selectedcomport As String = splitselectedsign(0)
        Dim selectedsignname As String = splitselectedsign(1)
        Dim attemptcounter As Int16 = 1


        myPortConnectionHandle = -2
        'MsgBox(1)
        While myPortConnectionHandle < 0
            'see note above about second parameter
            'the first parameter is a percentage and must be between 1 and 100.
            'MsgBox(attemptcounter & " " & myPortConnectionHandle)

            If attemptcounter > 40 Then
                bgw.ReportProgress(0, process & "Error! unable to open comport... Giving up after 40 attempts ")
                e.Cancel = True
                Return
            End If
            bgw.ReportProgress(0, process & "Opening Comport... attempt " & attemptcounter)
            If bgw.CancellationPending Then
                bgw.ReportProgress(0, process & "connection process cancled!")
                e.Cancel = True
                Return
            End If

            myPortConnectionHandle = mycomportmanager.createPortConnection(selectedcomport)
            'the purpose of the pause is that if opening the port fails there is 
            'a puase for the user to see the counter and do something before 40 attempts reached
            System.Threading.Thread.Sleep(300)
            attemptcounter += 1
        End While


        attemptcounter = 1
        bgw.ReportProgress(33, process & "Configuring coordinator... attempt " & attemptcounter)

        While Not selectsign(selectedsignname)

            If attemptcounter > 40 Then
                bgw.ReportProgress(33, process & "Error! unable to configure coordinator...Giving up after 40 attempts ")
                e.Cancel = True
                Return
            End If
            'see note above about second parameter of reportProgress
            'the first parameter is a percentage and must be between 1 and 100.
            bgw.ReportProgress(33, process & "Configuring coordinator... attempt " & attemptcounter)

            If bgw.CancellationPending Then
                bgw.ReportProgress(33, process & "Connection process canceled!")
                e.Cancel = True
                Return
            End If
            System.Threading.Thread.Sleep(100)
            attemptcounter += 1


        End While






        attemptcounter = 1
        bgw.ReportProgress(66, process & "Testing connection... attempt " & attemptcounter)

        While Not TestSignConnection()
            If attemptcounter > 40 Then
                bgw.ReportProgress(66, process & "Error! sign not responding...Giving up after 40 attempts " & attemptcounter)
                mycomportmanager.discardPortConnection(myPortConnectionHandle)
                e.Cancel = True
                Return
            End If


            If bgw.CancellationPending Then
                bgw.ReportProgress(66, process & "Connection process canceled!")
                mycomportmanager.discardPortConnection(myPortConnectionHandle)
                e.Cancel = True
                Return
            End If
            bgw.ReportProgress(66, process & "Testing connection... attempt " & attemptcounter)
            System.Threading.Thread.Sleep(10)
            attemptcounter += 1


        End While

        bgw.ReportProgress(100, process & "Success! connected to sign " & selectedsign)




        connected = True
    End Sub

    Protected Overloads Function testComportWorking(ByVal comnum As String) As Boolean
        Dim comport As IO.Ports.SerialPort
        Dim response As String = ""
        Dim devicelist As ArrayList
        Try
            'open comport
            comport = My.Computer.Ports.OpenSerialPort(comnum)

            comport.WriteTimeout() = 100

            If Not old_sendcommand(comport, DEVICE_LIST_COMMAND) Then

                'attempt to send device list command failed

                'indicate this is not a port with a coordinator attached
                comport.Close()
                Return False

            End If
            If (Not old_readline(comport, response)) Then
                'no respoce recieved from device on comport

                'indicate this is not a port with a coordinator attached
                comport.Close()
                Return False


            End If

            devicelist = parse_device_list_response(response)
            If devicelist Is Nothing Then
                'the echo we got from suposed coordinator is not correct   
                comport.Close()
                Return False
            End If




        Catch ex As Exception

            Try
                comport.Close()
            Catch exx As Exception

            End Try
            'MsgBox("e " & DateAndTime.Timer - starttime)
            'MsgBox(DateAndTime.Timer - starttime)
            Return False


        End Try



        'reach here if port has a transceiver attached.
        'from here down copy list of found signs
        'latter possibly test that they actually work

        'make list of signs that need to be removed from grand list because the coordinator no longer list them
        Dim devicestoremove As ArrayList = New ArrayList
        For Each sign As String In _allSigns_working
            Dim splitsign As String() = sign.Split(".")
            If splitsign(0) = comnum Then
                'this sign is listed as belong to the coordinator on this comport

                If Not devicelist.Contains(splitsign(1)) Then
                    'our new device list does not contain this sign 

                    'remember we can not modify the arraylist as we are walking through it
                    devicestoremove.Add(sign)


                End If

            End If
        Next

        'actually remove signs on list just generated
        For Each sign As String In devicestoremove
            _allSigns_working.Remove(sign)
        Next

        'add any new signs to grand list
        For Each sign As String In devicelist

            Dim signidentifyer As String = comnum & "." & sign
            If Not _allSigns_working.Contains(signidentifyer) Then

                _allSigns_working.Add(signidentifyer)

            End If

        Next



        comport.Close()



        Return True

    End Function
    Private Function parse_device_list_response(ByVal response As String) As ArrayList
        Dim list As String() = response.Split(":")
        Dim returnvalue As ArrayList = New ArrayList
        Dim loopcounter As Int16 = 1

        If list.Length = 0 Then
            'the response is not the expected response to CDL command
            Return Nothing
        End If
        If (list(0) <> "CDL") Then
            'the response is not the expected response to CDL command
            Return Nothing
        End If

        loopcounter = 1 'item 0 is echo of CDL command.  
        While loopcounter < list.Length - 1 'in our set up the last item in split is an empty line following last colon
            returnvalue.Add(list(loopcounter))
            loopcounter += 1
        End While

        Return returnvalue

    End Function


    Const ATGUARDTIMEINSECONDS As Double = 0.02 'not used correctly, hacked to make things work

    Private Function selectsign(ByVal signname As String, Optional ByVal porthandle As portConnectionHandle = Nothing)

        If porthandle = Nothing Then
            porthandle = Me.portconnecrtionHandle
        End If
        Dim command As String = "CDS" & signname & Constants.vbCrLf
        Dim readline As String = ""
        If (Me.mycomportmanager.writeThenReadlinePort(porthandle, command, readline, 12, 3, , 2) <> jp_dragonbone1.ComportManager.portOperationResult.success) Then

            'comport communication failed
            Return False
        End If

        'trim all cr and lf from end to avoid comparison comflics
        readline = String.Join("", readline.Split(Constants.vbCr))
        readline = String.Join("", readline.Split(Constants.vbLf))
        readline = readline.Trim

        command = String.Join("", command.Split(Constants.vbCr))
        command = String.Join("", command.Split(Constants.vbLf))
        command = command.Trim

        If readline <> command Then
            'not the expected echo

            Return False
        End If


        'if reach here no problems encounterd so must have succesfully selected sign
        Return True

    End Function

    'Private Function enterATmode(Optional ByVal porthandle As portConnectionHandle = Nothing) As Boolean
    '    If porthandle = Nothing Then
    '        porthandle = myPortConnectionHandle
    '    End If

    '    Dim readline As String = ""

    '    Try
    '        Me.mycomportmanager.writeThenReadlinePort(porthandle, "+++", readline, 5, 3, ATGUARDTIMEINSECONDS + 1, 2, ATGUARDTIMEINSECONDS + 0.01)
    '        If Not readline.Substring(0, 2) = "OK" Then


    '            Return False
    '            'MsgBox("Failed To Enter Command Mode")
    '            'Throw New Exception
    '        End If

    '    Catch ex As Exception
    '        Return False
    '    End Try


    '    Return True


    'End Function

    'Private Function exitATmode(Optional ByVal porthandle As portConnectionHandle = Nothing) As Boolean
    '    If porthandle = Nothing Then
    '        porthandle = myPortConnectionHandle
    '    End If

    '    Dim readline As String = ""


    '    Me.mycomportmanager.writeThenReadlinePort(porthandle, "atcn" & Environment.NewLine, readline, 5, 3, 1, 2)
    '    If Not readline.Substring(0, 2) = "OK" Then

    '        Return False
    '    End If




    '    Return True

    'End Function

    'Private Function getParam(ByVal param As String, Optional ByVal porthandle As portConnectionHandle = Nothing) As String
    '    'assumes the module is already in AT mode

    '    'note if the module is not in AT mode this fucntion will return an empty string 
    '    'because this is what our sign does for unrecongnized commands
    '    'nothing is returned if the comportmanager indicates somethig other then success


    '    If porthandle = Nothing Then
    '        porthandle = myPortConnectionHandle
    '    End If

    '    Dim readline As String = ""

    '    Try



    '        If Me.mycomportmanager.writeThenReadlinePort(porthandle, param & Environment.NewLine, readline, 25, 3, 1, 2) <> jp_dragonbone1.ComportManager.portOperationResult.success Then

    '            'reading the parameter failed

    '            Return Nothing


    '        End If

    '        readline = readline.Trim








    '        Return readline


    '    Catch ex As Exception

    '        Return Nothing


    '    End Try




    'End Function





    'Public Function setParam(ByVal param As String, ByVal value As String, Optional ByVal porthandle As portConnectionHandle = Nothing) As Boolean

    '    'porthandle parameter can be ommited if this class has already defined myPortConnectionHandle to refer to the desired port connection
    '    'durring the connection process or at other times it may be desirable to have this function work with a different port connection.

    '    'this function assumes that the module is already in ATmode.

    '    If porthandle = Nothing Then
    '        porthandle = myPortConnectionHandle
    '    End If

    '    Dim readline As String = ""

    '    Try



    '        Me.mycomportmanager.writeThenReadlinePort(porthandle, param & value & Environment.NewLine, readline, 5, 3, 1, 2, 10 * 0.001)
    '        If Not readline.Substring(0, 2) = "OK" Then

    '            'failed to set parameter
    '            Return False
    '        End If





    '        Me.mycomportmanager.writeThenReadlinePort(porthandle, "atwr" & Environment.NewLine, readline, 5, 3, 1, 2, 10 * 0.001)
    '        If Not readline.Substring(0, 2) = "OK" Then
    '            'failed to write to nonvolital memory
    '            Return False
    '        End If








    '        Return True


    '    Catch ex As Exception

    '        Return False


    '    End Try




    'End Function


    'Private Function EnterAtMode(ByVal comPort As IO.Ports.SerialPort) As Boolean
    '    'this function is only good for being called by a portscan test function
    '    'calling any other way bypasses the comport manager and will create problems.

    '    'the comport pased must be open and the must remain open


    '    '1 millisecond = 0.001 seconds



    '    Try
    '        'with ATguard time on the module configured to 5 micoseconds, 
    '        'it was expirimentaly determined that 15 microseconds of silence is required before sending +++
    '        'and 20 microseconds is required before the OK response is read.
    '        'more thoeretical and/or empirical knowlege is needed to know if the 10 and 15 microseconds added to configured guard time are the correct numbers to add



    '        System.Threading.Thread.Sleep((ATGUARDTIMEINSECONDS / 0.001) + 10)
    '        comPort.Write("+++")
    '        System.Threading.Thread.Sleep((ATGUARDTIMEINSECONDS / 0.001) + 15)
    '        Dim redline As String = comPort.ReadExisting
    '        If comPort.PortName.ToUpper = "COM8" Then
    '            'debugging code
    '            'MsgBox("[" & redline & "]")
    '        End If
    '        If Not redline.Substring(0, 2) = "OK" Then
    '            'MsgBox("Failed To Enter Command Mode")
    '            'Throw New Exception
    '            Return False
    '        End If

    '        Return True


    '    Catch ex As Exception

    '        'MsgBox("ex:" & ex.Message)

    '        Return False

    '    End Try

    'End Function

    'Private Function ExitAtMode(ByVal comPort As IO.Ports.SerialPort) As Boolean
    '    'this function is only good for being called by a portscan test function
    '    'calling any other way bypasses the comport manager and will create problems.

    '    'the comport pased must be open and the must remain open


    '    '1 millisecond = 0.001 seconds



    '    Try
    '        comPort.Write("atcn" & Environment.NewLine)
    '        System.Threading.Thread.Sleep(100)
    '        If Not comPort.ReadExisting.Substring(0, 2) = "OK" Then
    '            'MsgBox("Failed Exiting Command Mode")
    '            'Throw New Exception
    '            Return False

    '        End If

    '        Return True


    '    Catch ex As Exception

    '        Return False


    '    End Try




    'End Function

    'Public Function setParam(ByVal comPort As IO.Ports.SerialPort, ByVal param As String, ByVal value As String) As Boolean
    '    'this function is only good for being called by a portscan test function
    '    'calling any other way bypasses the comport manager and will create problems.

    '    'the comport pased must be open and the must remain open

    '    'it is assumed that the modules is already in AT Mode


    '    '1 millisecond = 0.001 seconds



    '    Try
    '        'comPort = My.Computer.Ports.OpenSerialPort(comNum)

    '        comPort.Write(param & value & Environment.NewLine)
    '        System.Threading.Thread.Sleep(100)
    '        Dim readline As String = comPort.ReadExisting
    '        If readline.Substring(0, 2) <> "OK" Then
    '            'Failed setting parameter
    '            Throw New Exception


    '        End If
    '        comPort.Write("atwr" & Environment.NewLine)
    '        System.Threading.Thread.Sleep(100)
    '        readline = comPort.ReadExisting
    '        If Not readline.Substring(0, 2) = "OK" Then
    '            'Failed Writing to Module
    '            Throw New Exception

    '        End If



    '        Return True


    '    Catch ex As Exception

    '        Return False


    '    End Try




    'End Function


    'Public Function getParam(ByVal comPort As IO.Ports.SerialPort, ByVal param As String) As String
    '    'this function is only good for being called by a portscan test function
    '    'calling any other way bypasses the comport manager and will create problems.

    '    'the comport pased must be open and the must remain open

    '    'it is assumed that the modules is already in AT Mode
    '    'if not an empty string will be returned by our sign indicating it doesnt understand command
    '    'nothing will be returned if comport exceptions

    '    '1 millisecond = 0.001 seconds


    '    Dim readline As String = ""

    '    Try
    '        'comPort = My.Computer.Ports.OpenSerialPort(comNum)

    '        comPort.Write(param & Environment.NewLine)
    '        System.Threading.Thread.Sleep(100)
    '        readline = comPort.ReadExisting.Substring(0, 2)
    '        readline = readline.Trim





    '        Return readline


    '    Catch ex As Exception

    '        Return Nothing


    '    End Try




    'End Function


    'removed 020410 when replaced with old one from 121809
    'Protected Function testComportWorking(ByVal comnum As String) As Boolean



    '    'Dim usetimer As Boolean = False
    '    Static timercount As Integer = 0
    '    If comnum.ToUpper = "COM4" Then
    '        'used for debugging
    '        timercount += 1
    '        'usetimer = True

    '    End If

    '    Dim starttime As Double = DateAndTime.Timer()
    '    Dim comport As IO.Ports.SerialPort

    '        Try
    '        'open comport
    '        comport = My.Computer.Ports.OpenSerialPort(comnum)


    '        'enter AT mode
    '        If Not enterATmode(comport) Then
    '            'failed to enter ATmode means no tranceiver attached
    '            comport.Close()
    '            'MsgBox("n " & DateAndTime.Timer - starttime)
    '            Return False
    '        End If



    '    Catch ex As Exception

    '        Try
    '            comport.Close()
    '        Catch exx As Exception

    '        End Try
    '        'MsgBox("e " & DateAndTime.Timer - starttime)
    '        'MsgBox(DateAndTime.Timer - starttime)
    '        Return False


    '    End Try



    '    'reach here if port has a transceiver attached.
    '    'from here down scan for valid signs.
    '    'my convention is to start with address 1 and keep going untill 10 consecutive addresses do not have signs


    '    'read current address configuration so it can be restored before exiting function
    '    Dim currentaddress As String = Me.getParam(comport, "atdl")

    '    'to avoid lenthy tie ups this function only checks one address for a sign each time it is called. 
    '    Static addresstocheck As UInt64 = 1
    '    If addresstocheck = 2 Then
    '        Dim dummy = "debug stop"
    '    End If

    '    Static countofaddresswithnosign As Int16 = 0 ' reset addresstocheck to 1 when this = 10

    '    Dim signfound As Boolean = False
    '    If setParam(comport, "atdl", Hex(addresstocheck)) Then

    '        exitATmode(comport)
    '        'try 3 times to test for sign on this channel. if all 3 fail no sign is on line
    '        'no guard time involved in this test
    '        Dim attempt As Int16 = 0
    '        While attempt < 3


    '            Dim majorversion As Integer = 0
    '            Dim minorversion As Integer = 0

    '            If old_getFirmwareVersion(comport, majorversion, minorversion) And majorversion >= MIN_FIRMWARE_MAJOR_VERSION And minorversion >= MIN_FIRMWARE_MINOR_VERSION Then
    '                'old_getFirmwareVersion is defined in connection_onesign_USB
    '                'it is a modifed legacy function and is only good for being called from within comport scan functions
    '                'calling it any other way bypasses the comport manager and will cause problems

    '                'for now signs that need new firmware are treated not found signs

    '                signfound = True


    '                Exit While 'inner while

    '            Else
    '                attempt += 1
    '            End If
    '        End While


    '    End If

    '    If signfound Then
    '        'a valid sign has been found on this address

    '        Dim compnumasint As Int16 = Convert.ToInt16(comnum.Substring(3))


    '        Dim arraylistvalue As String = compnumasint & "." & addresstocheck
    '        If Not _allSigns_working.Contains(arraylistvalue) Then
    '            'add the value to the sign. it is now found but was not before

    '            'the conventions for wireless sign identifiers is comportnumber.address
    '            _allSigns_working.Add(arraylistvalue)
    '            _allSigns_working.Sort()
    '        End If



    '        countofaddresswithnosign = 0
    '        addresstocheck += 1


    '    Else

    '        Dim compnumasint As Int16 = Convert.ToInt16(comnum.Substring(3))


    '        Dim arraylistvalue As String = compnumasint & "." & addresstocheck
    '        If _allSigns_working.Contains(arraylistvalue) Then
    '            'remove the value from the list because the sign is no longer found

    '            'the conventions for wireless sign identifiers is comportnumber.address


    '            _allSigns_working.Remove(arraylistvalue)
    '        End If


    '        If countofaddresswithnosign >= 10 Then

    '            m_firstcomportscancomplete = True 'indicate that the first comport scan is complete
    '            countofaddresswithnosign = 0

    '            addresstocheck = 0
    '        Else
    '            addresstocheck += 1
    '            countofaddresswithnosign += 1

    '        End If
    '    End If

    '    enterATmode(comport)
    '    Me.setParam(comport, "atdl", currentaddress)
    '    exitATmode(comport)
    '    comport.Close()



    '    'MsgBox(timercount & " s " & DateAndTime.Timer - starttime)
    '    Return True




    ''End Function
    ''1 millisecond = 0.001 seconds
    'Const ATGUARDTIMEINSECONDS As Double = 0.005 '5milliseconds

    'Private Function selectsign(ByVal signaddress As Int64, Optional ByVal porthandle As portConnectionHandle = Nothing)

    '    If Not enterATmode(porthandle) Then
    '        Return False
    '    End If
    '    If Not Me.setParam("atdl", signaddress, porthandle) Then
    '        Return False
    '    End If
    '    If Not exitATmode(porthandle) Then
    '        Return False
    '    End If
    '    Return True
    'End Function

    'Private Function enterATmode(Optional ByVal porthandle As portConnectionHandle = Nothing) As Boolean
    '    If porthandle = Nothing Then
    '        porthandle = myPortConnectionHandle
    '    End If

    '    Dim readline As String = ""

    '    Try
    '        Me.mycomportmanager.writeThenReadlinePort(porthandle, "+++", readline, 5, 3, ATGUARDTIMEINSECONDS + 1, 2, ATGUARDTIMEINSECONDS + 0.01)
    '        If Not readline.Substring(0, 2) = "OK" Then


    '            Return False
    '            'MsgBox("Failed To Enter Command Mode")
    '            'Throw New Exception
    '        End If

    '    Catch ex As Exception
    '        Return False
    '    End Try


    '    Return True


    'End Function

    'Private Function exitATmode(Optional ByVal porthandle As portConnectionHandle = Nothing) As Boolean
    '    If porthandle = Nothing Then
    '        porthandle = myPortConnectionHandle
    '    End If

    '    Dim readline As String = ""


    '    Me.mycomportmanager.writeThenReadlinePort(porthandle, "atcn" & Environment.NewLine, readline, 5, 3, 1, 2)
    '    If Not readline.Substring(0, 2) = "OK" Then

    '        Return False
    '    End If




    '    Return True

    'End Function

    'Private Function getParam(ByVal param As String, Optional ByVal porthandle As portConnectionHandle = Nothing) As String
    '    'assumes the module is already in AT mode

    '    'note if the module is not in AT mode this fucntion will return an empty string 
    '    'because this is what our sign does for unrecongnized commands
    '    'nothing is returned if the comportmanager indicates somethig other then success


    '    If porthandle = Nothing Then
    '        porthandle = myPortConnectionHandle
    '    End If

    '    Dim readline As String = ""

    '    Try



    '        If Me.mycomportmanager.writeThenReadlinePort(porthandle, param & Environment.NewLine, readline, 25, 3, 1, 2) <> jp_dragonbone1.ComportManager.portOperationResult.success Then

    '            'reading the parameter failed

    '            Return Nothing


    '        End If

    '        readline = readline.Trim








    '        Return readline


    '    Catch ex As Exception

    '        Return Nothing


    '    End Try




    'End Function





    'Public Function setParam(ByVal param As String, ByVal value As String, Optional ByVal porthandle As portConnectionHandle = Nothing) As Boolean

    '    'porthandle parameter can be ommited if this class has already defined myPortConnectionHandle to refer to the desired port connection
    '    'durring the connection process or at other times it may be desirable to have this function work with a different port connection.

    '    'this function assumes that the module is already in ATmode.

    '    If porthandle = Nothing Then
    '        porthandle = myPortConnectionHandle
    '    End If

    '    Dim readline As String = ""

    '    Try



    '        Me.mycomportmanager.writeThenReadlinePort(porthandle, param & value & Environment.NewLine, readline, 5, 3, 1, 2, 10 * 0.001)
    '        If Not readline.Substring(0, 2) = "OK" Then

    '            'failed to set parameter
    '            Return False
    '        End If





    '        Me.mycomportmanager.writeThenReadlinePort(porthandle, "atwr" & Environment.NewLine, readline, 5, 3, 1, 2, 10 * 0.001)
    '        If Not readline.Substring(0, 2) = "OK" Then
    '            'failed to write to nonvolital memory
    '            Return False
    '        End If








    '        Return True


    '    Catch ex As Exception

    '        Return False


    '    End Try




    'End Function


    'Private Function EnterAtMode(ByVal comPort As IO.Ports.SerialPort) As Boolean
    '    'this function is only good for being called by a portscan test function
    '    'calling any other way bypasses the comport manager and will create problems.

    '    'the comport pased must be open and the must remain open


    '    '1 millisecond = 0.001 seconds



    '    Try
    '        'with ATguard time on the module configured to 5 micoseconds, 
    '        'it was expirimentaly determined that 15 microseconds of silence is required before sending +++
    '        'and 20 microseconds is required before the OK response is read.
    '        'more thoeretical and/or empirical knowlege is needed to know if the 10 and 15 microseconds added to configured guard time are the correct numbers to add



    '        System.Threading.Thread.Sleep((ATGUARDTIMEINSECONDS / 0.001) + 10)
    '        comPort.Write("+++")
    '        System.Threading.Thread.Sleep((ATGUARDTIMEINSECONDS / 0.001) + 15)
    '        Dim redline As String = comPort.ReadExisting
    '        If comPort.PortName.ToUpper = "COM8" Then
    '            'debugging code
    '            'MsgBox("[" & redline & "]")
    '        End If
    '        If Not redline.Substring(0, 2) = "OK" Then
    '            'MsgBox("Failed To Enter Command Mode")
    '            'Throw New Exception
    '            Return False
    '        End If

    '        Return True


    '    Catch ex As Exception

    '        'MsgBox("ex:" & ex.Message)

    '        Return False

    '    End Try

    'End Function

    'Private Function ExitAtMode(ByVal comPort As IO.Ports.SerialPort) As Boolean
    '    'this function is only good for being called by a portscan test function
    '    'calling any other way bypasses the comport manager and will create problems.

    '    'the comport pased must be open and the must remain open


    '    '1 millisecond = 0.001 seconds



    '    Try
    '        comPort.Write("atcn" & Environment.NewLine)
    '        System.Threading.Thread.Sleep(200)
    '        If Not comPort.ReadExisting.Substring(0, 2) = "OK" Then
    '            'MsgBox("Failed Exiting Command Mode")
    '            'Throw New Exception
    '            Return False

    '        End If

    '        Return True


    '    Catch ex As Exception

    '        Return False


    '    End Try




    'End Function

    'Public Function setParam(ByVal comPort As IO.Ports.SerialPort, ByVal param As String, ByVal value As String) As Boolean
    '    'this function is only good for being called by a portscan test function
    '    'calling any other way bypasses the comport manager and will create problems.

    '    'the comport pased must be open and the must remain open

    '    'it is assumed that the modules is already in AT Mode


    '    '1 millisecond = 0.001 seconds



    '    Try
    '        'comPort = My.Computer.Ports.OpenSerialPort(comNum)

    '        comPort.Write(param & value & Environment.NewLine)
    '        System.Threading.Thread.Sleep(200)
    '        Dim readstring As String = comPort.ReadExisting
    '        If Not readstring.Substring(0, 2) = "OK" Then
    '            'Failed setting parameter
    '            Throw New Exception


    '        End If
    '        comPort.Write("atwr" & Environment.NewLine)
    '        System.Threading.Thread.Sleep(200)
    '        readstring = comPort.ReadExisting
    '        If Not readstring.Substring(0, 2) = "OK" Then
    '            'Failed Writing to Module
    '            Throw New Exception

    '        End If



    '        Return True


    '    Catch ex As Exception

    '        Return False


    '    End Try




    'End Function


    'Public Function getParam(ByVal comPort As IO.Ports.SerialPort, ByVal param As String) As String
    '    'this function is only good for being called by a portscan test function
    '    'calling any other way bypasses the comport manager and will create problems.

    '    'the comport pased must be open and the must remain open

    '    'it is assumed that the modules is already in AT Mode
    '    'if not an empty string will be returned by our sign indicating it doesnt understand command
    '    'nothing will be returned if comport exceptions

    '    '1 millisecond = 0.001 seconds


    '    Dim readline As String = ""

    '    Try
    '        'comPort = My.Computer.Ports.OpenSerialPort(comNum)

    '        comPort.Write(param & Environment.NewLine)
    '        System.Threading.Thread.Sleep(200)
    '        readline = comPort.ReadExisting.Substring(0, 2)
    '        readline = readline.Trim





    '        Return readline


    '    Catch ex As Exception

    '        Return Nothing


    '    End Try




    'End Function










End Class

