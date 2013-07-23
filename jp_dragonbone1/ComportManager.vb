Imports scanhandle = System.Int16 'create an alias to make function signatures less confusing
Imports portConnectionHandle = System.Int16 'create an alias to make function signatures less confusing
Public Class ComportManager

    'Structure phandle
    '    Sub New()

    '    End Sub
    '    Private _id As Int16
    '    Public ReadOnly Property id() As Int16
    '        Get
    '            Return _id
    '        End Get
    '    End Property




    '    Private _port As IO.Ports.SerialPort
    '    Public ReadOnly Property port() As IO.Ports.SerialPort
    '        Get
    '            Return _port
    '        End Get
    '    End Property

    'End Structure




    'from here to next section is related to checking out comports so that there is no conflicts between scan and communication

    Const scanporthandle As portConnectionHandle = -1
    Const connectporthandle As portConnectionHandle = -2


    Shared checkedoutportnames As ArrayList = New ArrayList 'of portnames
    Shared checkedOutPortHandles As ArrayList = New ArrayList ' of porthandles. -1 is for scan
    Private Enum reservePortResult
        success = True
        alreadycheckedout
        miscerror
        invalidparameters = -5
    End Enum
    Private Enum freePortResult
        success = True
        notcheckedout
        miscerror
        invalidparameters = -5
    End Enum

    Private Enum portstatus
        free
        busy
        reservedByMe
        invalidparameters = -5
    End Enum

    Private Shared Function ReservePort(ByVal portname As String, ByVal handle As portConnectionHandle) As reservePortResult
        Try

            'verify parameters
            If handle <> scanporthandle And Not portConnectionPortNames.Contains(portname) Then
                '-1 means scan process is checking out port

                Return reservePortResult.invalidparameters
            End If

            If handle <> scanporthandle Then
                '-1 means scan process is checking out port
                Dim tempport As IO.Ports.SerialPort = getportfromhandle(handle)

                If tempport.PortName <> portname Then
                    Return reservePortResult.invalidparameters
                End If
            End If


            'make sure not already checked out
            If checkedoutportnames.Contains(portname) Then
                'port is already checked out
                Return reservePortResult.alreadycheckedout
            End If

            'check out
            checkedoutportnames.Add(portname)
            checkedOutPortHandles.Add(handle)
            Return reservePortResult.success

        Catch ex As Exception
            'misc error has occured
            Return reservePortResult.miscerror
        End Try

    End Function

    Private Shared Function FreePort(ByVal portname As String, ByVal handle As portConnectionHandle) As freePortResult
        Try



            ''verify parameters

            'handle matches portname in connection
            If handle <> scanporthandle And Not portConnectionPortNames.Contains(portname) Then
                '-1 means scan process is checking out port

                Return freePortResult.invalidparameters
            End If

            If handle <> scanporthandle Then

                Dim tempport As IO.Ports.SerialPort = getportfromhandle(handle)

                If tempport.PortName <> portname Then
                    Return freePortResult.invalidparameters
                End If
            End If


            'handle matches portname in checkout
            'remember not checked out results in both values being -1
            If checkedoutportnames.IndexOf(portname) <> checkedOutPortHandles.IndexOf(handle) Then

                Return freePortResult.invalidparameters

            End If

            'check if port has been checked out
            If Not checkedoutportnames.Contains(portname) Then
                Return freePortResult.notcheckedout
            End If


            checkedoutportnames.Remove(portname)
            checkedOutPortHandles.Remove(handle)
            Return freePortResult.success

        Catch ex As Exception
            Return freePortResult.miscerror
        End Try

    End Function
    Private Shared Function getPortStatus(ByVal portname As String, ByVal handle As portConnectionHandle) As portstatus



        If handle <> scanporthandle Then
            ''verify parameters
            ''not much verifying with scanport handle because it is allowed to be paired with any port 



            If handle <> scanporthandle And Not portConnectionPortNames.Contains(portname) Then


                Return portstatus.invalidparameters
            End If


            Dim tempport As IO.Ports.SerialPort = getportfromhandle(handle)

            If tempport.PortName <> portname Then
                Return portstatus.invalidparameters
            End If


            'handle matches portname in checkout
            'remember not checked out results in both values being -1
            'If checkedoutportnames.IndexOf(portname) <> checkedOutPortHandles.IndexOf(handle) Then

            '    Return portstatus.invalidparameters

            'End If

        End If

        'check if port has been checked out
        If checkedoutportnames.Contains(portname) Then
            'checked out

            'test if by me or by other
            Dim index As Int16 = checkedoutportnames.IndexOf(portname)
            If handle = checkedOutPortHandles(index) Then
                Return portstatus.reservedByMe
            Else
                Return portstatus.busy
            End If
        Else
            Return portstatus.free
        End If




    End Function





    'from here to next section is related to using comports
    Shared portConnectionhandles As ArrayList = New ArrayList
    Shared portConnectionComports As ArrayList = New ArrayList
    Shared portConnectionPortNames As ArrayList = New ArrayList
    Shared nextportconnectionhandle As portConnectionHandle = 1 'dont start with 0 because NOTHING is sometime treated as 0 creating bugs
    Public Shared allowMultipleConnectionsToSamePort As Boolean = False

    Public Enum disgardPortConnectionResult
        success
        invalidhandle
        fail
    End Enum


    Public Enum createPortConnectionResult
        'success
        portAlreadyInUse = -2
        portDoesNotExist = -3
        UnableToOpenPort = -4
    End Enum
    Public Enum portOperationResult
        success = True
        invalidhandle
        portBusy
        communicationTimeout
        fail

    End Enum
    Public Enum ParameterTestResult
        MatchNotRserved
        MatchReserved
        matchReserveDataError
        DoNotMatch
        InvalidHandle
    End Enum

    ''private utilityfunctions
    Private Shared Function getportfromhandle(ByVal handle As portConnectionHandle) As IO.Ports.SerialPort
        Try
            Dim index As Int16 = portConnectionhandles.IndexOf(handle)
            Return portConnectionComports(index)

        Catch ex As Exception
            'error dummy value returned
        End Try

    End Function

    Private Function parametersTest(ByVal handle As portConnectionHandle, ByVal portname As String) As ParameterTestResult

        If Not portConnectionhandles.Contains(handle) Then
            Return ParameterTestResult.InvalidHandle
        End If

        If portConnectionhandles.IndexOf(handle) = portConnectionPortNames.IndexOf(portname) Then
            If Not checkedOutPortHandles.Contains(handle) Then
                Return ParameterTestResult.MatchNotRserved
            ElseIf checkedOutPortHandles.IndexOf(handle) = Me.checkedoutportnames.IndexOf(portname) Then
                Return ParameterTestResult.MatchReserved
            Else
                Return ParameterTestResult.matchReserveDataError
            End If
        Else
            Return ParameterTestResult.DoNotMatch
        End If

    End Function

    ''internal port read and write functions'''''
    Private Function internalReadExistingPort(ByVal thisport As IO.Ports.SerialPort, ByRef str As String) As portOperationResult
        'Optional ByVal portBusyTimeOutInSeconds As Double = 10


        'Dim starttime As Double = DateAndTime.Timer() 'returns seconds since midnight


        Try
            'thisport = portConnectionComports(index)
            'thisport.Open()
            str = thisport.ReadExisting
        Catch ex As Exception
            Try
                thisport.Close()
                thisport.Open()
            Catch ex2 As Exception

            End Try
            Return portOperationResult.fail

        End Try


        Try
            thisport.Close()
        Catch ex2 As Exception

        End Try

        Return portOperationResult.success
    End Function

    Private Function internalReadCharactersPort(ByRef thisport As IO.Ports.SerialPort, ByRef stringtoreadto As String, ByVal Length As Integer, ByVal CommunicationTimeOutInSeconds As Double) As portOperationResult

        'this function does not deal with port checkin and check out
        'the calling function should



        'this function was copied from the old bootloader read function
        'Optional ByVal portBusyTimeOutInSeconds As Double = 10



        Dim starttime As Double = DateAndTime.Timer() 'returns seconds since midnight
        Dim timesthrouloop As Integer = 0
        While (True)




            If (DateAndTime.Timer() - starttime > CommunicationTimeOutInSeconds Or DateAndTime.Timer() - starttime < -86400 + CommunicationTimeOutInSeconds) Then


                Return portOperationResult.communicationTimeout
            End If

            Dim characterread As String = ""
            Try

                characterread = thisport.ReadExisting()
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
                        thisport.Close()

                        thisport.Open()

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

                    'Form1.echoerror = 7
                    Return portOperationResult.fail
                End If



            End Try



            If (characterread <> "") Then

                starttime = DateAndTime.Timer()
            End If
            stringtoreadto = stringtoreadto + characterread
            If (stringtoreadto.Length() = Length) Then


                Return portOperationResult.success

            End If



        End While
        'Dim commandstring As String = "W " + Hex(AscW(character)) + Constants.vbCrLf
        'Return commandstring




        MsgBox("bugg")




    End Function
    Private Function internalReadLinePort(ByRef thisport As IO.Ports.SerialPort, ByRef str As String, ByVal maxLength As Integer, ByVal communicationTimeOutInSeconds As Double) As portOperationResult
        'this function does not deal with port checkin and check out
        'the calling function should


        Dim starttime As Double = DateAndTime.Timer() 'returns seconds since midnight
        'Try
        '    'thisport = portConnectionComports(index)
        '    thisport.Open()

        'Catch ex As Exception
        '    Try
        '        thisport.Close()
        '    Catch ex2 As Exception

        '    End Try
        '    Return portOperationResult.fail

        'End Try


        Dim errorcount As Int16 = 0

        Dim returnvalue As portOperationResult
        While True
            If (DateAndTime.Timer() - starttime > communicationTimeOutInSeconds Or DateAndTime.Timer() - starttime < -86400 + communicationTimeOutInSeconds) Then
                Return portOperationResult.communicationTimeout
            End If

            Try
                Dim tempstring As String = thisport.ReadExisting
                If tempstring <> "" Then
                    starttime = DateAndTime.Timer()
                    str &= tempstring

                    If str.IndexOf(Constants.vbCrLf) <> -1 Then
                        str = str.Substring(0, str.IndexOf(Constants.vbCrLf))
                        returnvalue = portOperationResult.success
                        Exit While
                    ElseIf str.IndexOf(Constants.vbCr) <> -1 Then
                        str = str.Substring(0, str.IndexOf(Constants.vbCr))
                        returnvalue = portOperationResult.success
                        Exit While
                    ElseIf str.IndexOf(Constants.vbLf) <> -1 Then
                        str = str.Substring(0, str.IndexOf(Constants.vbLf))
                        returnvalue = portOperationResult.success
                        Exit While
                    ElseIf str.Length > maxLength Then
                        returnvalue = portOperationResult.fail
                        Exit While
                    End If
                End If


            Catch ex As Exception
                If errorcount > 3 Then
                    returnvalue = portOperationResult.fail
                    Exit While
                End If
                Try
                    thisport.Close()
                    thisport.Open()
                Catch ex2 As Exception
                    Try
                        thisport.Open()
                    Catch ex3 As Exception

                    End Try

                End Try

            End Try


        End While






        'Try
        '    thisport.Close()
        'Catch ex2 As Exception

        'End Try

        Return returnvalue

    End Function

    Private Function internalWritePort(ByRef thisport As IO.Ports.SerialPort, ByVal str As String) As portOperationResult
        'this function does not deal with port check out and check in
        'function calling this should do so.
        'port must be checkedout before calling this function


        Dim starttime As Double = DateAndTime.Timer() 'returns seconds since midnight
        'Dim stringtoreadto As String = ""


        starttime = DateAndTime.Timer() 'returns seconds since midnight

        Try
            'thisport = portConnectionComports(index)
            'thisport.Open()
            thisport.Write(str)

            



        Catch ex As Exception
            Try
                thisport.Close()
                thisport.Open()
            Catch ex2 As Exception

            End Try
            Return portOperationResult.fail

        End Try


        'Try
        '    thisport.Close()
        'Catch ex2 As Exception

        'End Try

        Return portOperationResult.success
    End Function

    Private Function commonpreeworktasks(ByVal handle As portConnectionHandle, ByRef thisport As IO.Ports.SerialPort, ByVal portBusyTimeOutInSeconds As Double, Optional ByVal preWriteGuardTimeInseconds As Double = 0) As portOperationResult

        'test parameters

        If Not portConnectionhandles.Contains(handle) Then
            Return portOperationResult.invalidhandle
        End If


        Try
            thisport = Me.getportfromhandle(handle)
        Catch ex As Exception
            MsgBox("bugg detected from function commonpreeworktasks")
            Return portOperationResult.fail
        End Try



        'test if port is busy or free
        Dim starttime As Double = DateAndTime.Timer() 'returns seconds since midnight

        Dim thisportstatus As portstatus = getPortStatus(thisport.PortName, handle)
        While thisportstatus <> portstatus.free

            If thisportstatus = portstatus.invalidparameters Then
                MsgBox("bug! invalid parameters detected in ")
                Return portOperationResult.fail
            ElseIf thisportstatus = portstatus.reservedByMe Then
                'this in an error condition 
                'the only way this happens is if some function fails to free the port.
                'for now simply free it so this function can reserve it again

                If FreePort(thisport.PortName, handle) = freePortResult.success Then
                    Exit While
                Else
                    Return portOperationResult.fail
                End If

            End If
            'Form1.pause(0.01)

            If (DateAndTime.Timer() - starttime > portBusyTimeOutInSeconds Or DateAndTime.Timer() - starttime < -86400 + portBusyTimeOutInSeconds) Then
                Return portOperationResult.portBusy
            End If
            thisportstatus = getPortStatus(thisport.PortName, handle)
        End While



        'reserve port

        If ReservePort(thisport.PortName, handle) <> reservePortResult.success Then

            Return portOperationResult.fail

        End If

        'open port
        Try
            thisport.Open()
        Catch ex As Exception
            Try
                'prot failed to open
                'attempt to close then reopen in case already opened
                thisport.Close()
                thisport.Open()
            Catch ex2 As Exception

                Try
                    'one last try to open in case already closed before last try
                    thisport.Open()


                Catch ex3 As Exception
                    'all attempts to open port failed
                    'make sure closed then return fail
                    Try
                        thisport.Close()

                    Catch ex4 As Exception
                    End Try
                    Return portOperationResult.fail
                End Try


            End Try

        End Try


        

        Return portOperationResult.success

    End Function

    Private Sub commonpostworktasks(ByVal handle As portConnectionHandle, ByRef thisport As IO.Ports.SerialPort)

        'close port
        thisport.Close()

        'free port
        If FreePort(thisport.PortName, handle) <> freePortResult.success Then

            MsgBox("bug! port not succesfully freed in writeThenReadExistingPort")

        End If

    End Sub

    Public Function writeThenReadExistingPort(ByVal handle As portConnectionHandle, ByVal writestring As String, ByRef readstring As String, Optional ByVal attempts As UInt16 = 1, Optional ByVal portBusyTimeOutInSeconds As Double = 5, Optional ByVal preWriteGuardTimeInseconds As Double = 0) As portOperationResult

        Dim thisport As IO.Ports.SerialPort

        'test parameters, test if port is available, reserves port and open port
        Dim preworkresult As portOperationResult = commonpreeworktasks(handle, thisport, portBusyTimeOutInSeconds, preWriteGuardTimeInseconds)

        If preworkresult <> portOperationResult.success Then
            commonpostworktasks(handle, thisport)
            Return preworkresult
        End If


        'do work
        Dim attemptcount As Int16 = 0
        Dim attemptresult As portOperationResult

        While attemptresult <> portOperationResult.success And attemptcount < attempts
            'apply(prewriteguardtime)
            If preWriteGuardTimeInseconds <> 0 Then
                '1 millisecond = 0.001 seconds
                System.Threading.Thread.Sleep(preWriteGuardTimeInseconds / 0.001)
            End If

            attemptresult = internalWritePort(thisport, writestring)
            If attemptresult = portOperationResult.success Then

                attemptresult = internalReadExistingPort(thisport, readstring)

                If attemptresult = portOperationResult.success Then
                    Exit While
                End If

            End If

            attemptcount += 1

        End While


        'close and free port
        commonpostworktasks(handle, thisport)

        Return attemptresult

    End Function

    Public Function writeThenReadCharsPort(ByVal handle As portConnectionHandle, ByVal writestring As String, ByRef readstring As String, Optional ByVal length As Int64 = 10, Optional ByVal attempts As UInt16 = 1, Optional ByVal communicationTimeOutInSeconds As Double = 10, Optional ByVal portbusyTimeOutInSeconds As Double = 10, Optional ByVal preWriteGuardTimeInseconds As Double = 0) As portOperationResult

        Dim thisport As IO.Ports.SerialPort

        'test parameters, test if port is available and reserves port
        Dim preworkresult As portOperationResult = commonpreeworktasks(handle, thisport, portbusyTimeOutInSeconds)

        If preworkresult <> portOperationResult.success Then
            commonpostworktasks(handle, thisport)
            Return preworkresult
        End If


        'do work
        Dim attemptcount As Int16 = 0
        Dim attemptresult As portOperationResult
        While attemptresult <> portOperationResult.success And attemptcount < attempts
            'apply(prewriteguardtime)
            If preWriteGuardTimeInseconds <> 0 Then
                '1 millisecond = 0.001 seconds
                System.Threading.Thread.Sleep(preWriteGuardTimeInseconds / 0.001)
            End If


            attemptresult = internalWritePort(thisport, writestring)
            If attemptresult = portOperationResult.success Then

                attemptresult = Me.internalReadCharactersPort(thisport, readstring, length, communicationTimeOutInSeconds)

                If attemptresult = portOperationResult.success Then
                    Exit While
                End If

            End If

            attemptcount += 1

        End While


        'close and free port
        commonpostworktasks(handle, thisport)

        Return attemptresult

    End Function

    Public Function writeThenReadlinePort(ByVal handle As portConnectionHandle, ByVal writestring As String, ByRef readstring As String, Optional ByVal maxlength As Int64 = 100, Optional ByVal attempts As UInt16 = 1, Optional ByVal CommunicationTimeOutInSeconds As Double = 0.5, Optional ByVal portBusyTimeOutInSeconds As Double = 5, Optional ByVal preWriteGuardTimeInseconds As Double = 0) As portOperationResult
        Dim thisport As IO.Ports.SerialPort

        'test parameters, test if port is available and reserves port
        Dim preworkresult As portOperationResult = commonpreeworktasks(handle, thisport, portBusyTimeOutInSeconds, preWriteGuardTimeInseconds)
        readstring = ""
        If preworkresult <> portOperationResult.success Then
            Try
                commonpostworktasks(handle, thisport)
            Catch ex As Exception

            End Try


            Return preworkresult
        End If


        'do work
        Dim attemptcount As Int16 = 0
        Dim attemptresult As portOperationResult = portOperationResult.fail 'set anything but success so go through loop once
        While attemptresult <> portOperationResult.success And attemptcount < attempts
            'apply prewriteguardtime
            If preWriteGuardTimeInseconds <> 0 Then
                '1 millisecond = 0.001 seconds
                System.Threading.Thread.Sleep(preWriteGuardTimeInseconds / 0.001)
            End If


            attemptresult = internalWritePort(thisport, writestring)
            If attemptresult = portOperationResult.success Then

                attemptresult = internalReadLinePort(thisport, readstring, maxlength, CommunicationTimeOutInSeconds)

                If attemptresult = portOperationResult.success Then
                    Exit While
                End If

            End If

            attemptcount += 1

        End While


        'close and free port
        commonpostworktasks(handle, thisport)

        Return attemptresult

    End Function

    Public Function writePort(ByVal handle As portConnectionHandle, ByVal str As String, Optional ByVal portBusyTimeOutInSeconds As Double = 10, Optional ByVal attempts As UInt16 = 1, Optional ByVal preWriteGuardTimeInseconds As Double = 0) As portOperationResult

        Dim thisport As IO.Ports.SerialPort

        'test parameters, test if port is available and reserves port
        Dim preworkresult As portOperationResult = commonpreeworktasks(handle, thisport, portBusyTimeOutInSeconds, preWriteGuardTimeInseconds)

        If preworkresult <> portOperationResult.success Then
            Return preworkresult
        End If


        'do work
        Dim attemptcount As Int16 = 0
        
        Dim attemptresult As portOperationResult = portOperationResult.fail 'set to anything other then success to go through loop once
        While attemptresult <> portOperationResult.success And attemptcount < attempts

            'apply(prewriteguardtime)
            If preWriteGuardTimeInseconds <> 0 Then
                '1 millisecond = 0.001 seconds
                System.Threading.Thread.Sleep(preWriteGuardTimeInseconds / 0.001)
            End If

            attemptresult = internalWritePort(thisport, str)
            attemptcount += 1

        End While

        Return attemptresult

    End Function

    Public Function discardPortConnection(ByVal handle As portConnectionHandle) As disgardPortConnectionResult


        'portConnectionhandles
        Dim connectionindex As Int16 = portConnectionhandles.IndexOf(handle)
        Dim thisport As IO.Ports.SerialPort

        If connectionindex = -1 Then
            Return disgardPortConnectionResult.invalidhandle
        End If

        thisport = Me.getportfromhandle(handle)

        If getPortStatus(thisport.PortName, handle) = portstatus.reservedByMe Then
            'this is an error condition in which a routine failed to free the port
            'free the port before disguarding conection

            If FreePort(thisport.PortName, handle) <> freePortResult.success Then
                'this should not fail unless bug 
                Return disgardPortConnectionResult.fail
            End If
        End If

        portConnectionhandles.RemoveAt(connectionindex)
        portConnectionComports.RemoveAt(connectionindex)
        portConnectionPortNames.RemoveAt(connectionindex)
        Return disgardPortConnectionResult.success

    End Function
    Private Function forceDiscardPortConnectionByName(ByVal portname As String) As Boolean
        'may be a public function when and if implemented
        'this function should only be called in the extreme that port handles have been lost.
        Throw New Exception("you are calling a function that has not yet been implemented")
        Return False
    End Function


    Public Function createPortConnection(ByVal portname As String, Optional ByVal baudrate As Integer = 9600, Optional ByVal parity As System.IO.Ports.Parity = System.IO.Ports.Parity.None, Optional ByVal databits As Integer = 8, Optional ByVal stopbits As System.IO.Ports.StopBits = System.IO.Ports.StopBits.One) As portConnectionHandle 'createPortConnectionResult
        If portConnectionPortNames.Contains(portname) And Not allowMultipleConnectionsToSamePort Then
            Return createPortConnectionResult.portAlreadyInUse
        End If
        availableComports = System.IO.Ports.SerialPort.GetPortNames
        If Array.IndexOf(availableComports, portname) = -1 Then
            Return createPortConnectionResult.portDoesNotExist
        End If
        Dim attemptcounter As Int16 = 0

        Dim temport As IO.Ports.SerialPort = New IO.Ports.SerialPort(portname, baudrate, parity, databits, stopbits)
        Dim timesportbusy As Integer = 0
        Dim returnvalue As portConnectionHandle = nextportconnectionhandle 'conversion to is important so that arraylist contains correct type
        portConnectionComports.Add(temport)
        portConnectionPortNames.Add(portname)

        portConnectionhandles.Add(returnvalue)




        While attemptcounter < 3

            Try
                Dim result As reservePortResult = ReservePort(portname, returnvalue)
                If result <> reservePortResult.success Then


                    'failed to reseve port
                    'we assume that this is due to the scan process using port 
                    'to do it properly we should do additional testing


                    'we only advance the attempt counter every 5 times the port is busy 
                    'because more time is needed then with other failures
                    System.Threading.Thread.Sleep(200)
                    timesportbusy += 1
                    If timesportbusy Mod 5 = 0 Then
                        attemptcounter += 1
                    End If
                    Continue While
                End If



                temport.Open()
                temport.Close()






                nextportconnectionhandle += 1

                FreePort(portname, returnvalue) 'free port so other processes can use it
                Return returnvalue
            Catch ex As Exception

                Try
                    temport.Close()
                Catch ex2 As Exception

                End Try
                FreePort(portname, returnvalue)
                attemptcounter += 1
                Continue While
            End Try
            'should not reach here
            MsgBox("bug in comport connection attemtps loop")
        End While

        Try
            temport.Close()
        Catch ex2 As Exception

        End Try


        'from here down if pocess failed


        discardPortConnection(returnvalue)
        Return createPortConnectionResult.UnableToOpenPort

    End Function










    'from here down is scan stuff
    Dim scantimer As Timer = New Timer
    Sub New()

        'MsgBox("new comport manager")

        '1 millisecond = 0.001 seconds
        scantimer.Interval = 10000
        ' 031713  from 2000 to 10000
        AddHandler scantimer.Tick, AddressOf scantimer_Tick
        'timer is started when first scan is added

    End Sub
    Private Shared m_firstscancomplete As Boolean = False
    Public ReadOnly Property firstscancomplete() As Boolean
        Get
            Return m_firstscancomplete
        End Get
    End Property
    



    Private Shared Sub scantimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Static badcomports As ArrayList = New ArrayList
        Static badcomports_i As Int16 = 0
        Static badcomports_j As Int16 = 0
        Static badcomports_time As Int16 = 0
        Static badcomports_retest As Boolean = False
        Static badcomports_count = 0
        If (badcomports_time = 10) Then
            badcomports_retest = True
            badcomports_time = 0
        End If
        badcomports_time += 1




        If ProgressForm.active Then
            'there were bugs with the scan and especially form1.updatesignmenu running simultanously with getting data
            Return
        End If

        Static busy = False
        If busy Then
            Return
        End If
        busy = True

        Dim starttime As Double = DateAndTime.Timer()
        availableComports = System.IO.Ports.SerialPort.GetPortNames


        Dim scanwalker As Int16 = 0
        While scanwalker < scanhandles.Count
            'goes through each comport scan function

            If (badcomports.Count <= scanwalker) Then
                badcomports.Add(New ArrayList)
            End If

            Dim passingports As ArrayList = New ArrayList
            Dim skippedports As ArrayList = New ArrayList

            Dim portwalker = 0
            While portwalker < availableComports.Length()





                If getPortStatus(availableComports(portwalker), scanporthandle) = portstatus.busy Then
                    'skip this port
                    skippedports.Add(availableComports(portwalker))

                ElseIf getPortStatus(availableComports(portwalker), scanporthandle) = portstatus.invalidparameters Then
                    'error situation
                    'somehow we have generated invalid parameters
                    '(or another routine has put invalid data into reserved ports)
                    'or the function for getting status is buggy
                    MsgBox("bug: the scan timer tick function has generated invalid parameters for testing if port is busy")
                    busy = False
                    Return

                ElseIf getPortStatus(availableComports(portwalker), scanporthandle) = portstatus.reservedByMe Then
                    'this is an error situation
                    'a previous iteration of these loops failed to free the port!
                    MsgBox("bug: the scan timer tick failed to free a port")

                    Dim fpr As freePortResult = FreePort(availableComports(portwalker), scanporthandle)
                    '
                    If fpr <> freePortResult.success Then
                        MsgBox(fpr.ToString)
                    End If
                    busy = False
                    Return

                ElseIf getPortStatus(availableComports(portwalker), scanporthandle) = portstatus.free Then
                    'normal situation
                    'the port is free and we test it

                    Dim retestingPort As Boolean = False

                    If (badcomports(scanwalker).Contains(availableComports(portwalker))) Then

                        'the port previously failed this test
                        'one port is retested every 10 ticks
                        If (Not badcomports_retest) Then
                            portwalker += 1
                            Continue While

                        End If
                        If (Not scanwalker = badcomports_i) Then
                            portwalker += 1
                            Continue While
                        End If

                        If (badcomports(badcomports_i)(badcomports_j) <> availableComports(portwalker)) Then
                            portwalker += 1
                            Continue While

                        End If

                        'if we reach here, this is the time to retest this port which previously failed
                        retestingPort = True
                    
                    End If



                    Dim thisdelegate As comportTestDelegate = scantests(scanwalker)
                    Dim comportTestResult As Boolean

                    Try

                        ReservePort(availableComports(portwalker), scanporthandle)
                        comportTestResult = thisdelegate.Invoke(availableComports(portwalker))
                        Dim fpr As freePortResult = FreePort(availableComports(portwalker), scanporthandle)
                        'Dim fpr as freePortResult =
                        If fpr <> freePortResult.success Then
                            MsgBox(fpr.ToString)
                        End If
                    Catch ex As Exception

                        MsgBox("bug a comport test passed to comportmanager has thrown an exception" & Constants.vbCrLf & ex.Message)
                        scanwalker += 1
                        Continue While

                    End Try


                    If comportTestResult Then
                        'Dim thisValidPortHolder As ArrayList = scanPortPassingTestHolder(scanwalker)
                        'add this port to list
                        passingports.Add(availableComports(portwalker))

                        If (retestingPort) Then

                            badcomports(scanwalker).Remove(availableComports(portwalker))
                            badcomports_count -= 1

                        End If
                    Else


                        If (retestingPort) Then
                            badcomports_j += 1
                        Else
                            badcomports(scanwalker).add(availableComports(portwalker))
                            badcomports_count += 1
                        End If


                    End If

                    If (retestingPort) Then

                        badcomports_retest = False

                        If (badcomports_count > 1) Then

                            If (badcomports_j >= badcomports(scanwalker).Count()) Then
                                badcomports_i += 1
                                If (badcomports_i >= badcomports.Count()) Then
                                    badcomports_i = 0
                                End If
                                While (badcomports(badcomports_i).Count() = 0)
                                    badcomports_i += 1
                                    If (badcomports_i >= badcomports.Count()) Then
                                        badcomports_i = 0
                                    End If
                                    If (badcomports_i = scanwalker) Then
                                        'if we get all the way through this means there are no bad ports stored
                                        'for any scan. break here to avoid infinate loop
                                        'this is redundant. if badcomports_count is correct we dont get here
                                        Exit While
                                    End If

                                End While
                                badcomports_j = 0

                                retestingPort = False
                            End If
                        End If
                    End If
                End If

                portwalker += 1

            End While

            'the innerloop went through all the ports and generated a list of passing and skipped ports
            'now we apply this list
            Dim returnedvalidports As ArrayList = scanPortPassingTestHolder(scanwalker)
            utilities.modifyarraylist(returnedvalidports, passingports, skippedports, True, True)

            scanwalker += 1

        End While





        m_firstscancomplete = True
        Try
            If (Not Form1.formloaded) Then
                Form1.refreshSignMenue()
                'sometimes while form1 is loading this cause an exception
            End If
            
        Catch ex As Exception

        End Try

        'MsgBox(DateAndTime.Timer - starttime)
        busy = False


    End Sub

    Private Shared availableComports As String()
    Shared scanhandlenextvalue As Int16 = 0
    Shared scanhandles As ArrayList = New ArrayList 'an array of handles assigned when the scan is added
    Shared scantests As ArrayList = New ArrayList 'an array of test functions passed to function addcomportscan
    Shared scanPortPassingTestHolder As ArrayList = New ArrayList 'an array of arrays passed to function addcomport scan. the arrays contain string name of ports passing the test 

    Public Delegate Function comportTestDelegate(ByVal portname As String) As Boolean

    Public Function addcomportscan(ByRef PortsPassingTest As ArrayList, ByVal addressOfTestFunction As comportTestDelegate) As scanhandle
        scanhandles.Add(scanhandlenextvalue)
        scantests.Add(addressOfTestFunction)
        scanPortPassingTestHolder.Add(PortsPassingTest)
        scanhandlenextvalue += 1

        scantimer.Start()
    End Function

    Public Sub removeComportScan(ByVal handle As scanhandle)
        'function not yet tested
        Dim index = scanhandles.IndexOf(handle)
        scanhandles.RemoveAt(index)
        scantests.RemoveAt(index)
        scanPortPassingTestHolder.RemoveAt(index)
        scanhandlenextvalue += 1

        If scanhandles.Count = 0 Then
            scantimer.Stop()
        End If
    End Sub

End Class
