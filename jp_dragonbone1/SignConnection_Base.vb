Imports portConnectionHandle = System.Int16 'create an alias to make function signatures less confusing
Public Class SignConnection_Base
    
    'experimenting with marshaling

    Delegate Function getintdelegate() As Integer
    Delegate Function getArraylistDelegate() As ArrayList
    Delegate Function getStringDelegate() As String

    Delegate Function processString(ByVal strn As String) As Boolean


    Delegate Sub setintdelegate(ByVal value As Integer)
    Delegate Sub setarraylistdelegate(ByVal value As ArrayList)
    Delegate Sub doactiondelegate()

    'Delegate Sub doactionintdelegate(ByVal value As Integer)


    Private sendfilecontenttoform1 As processString
    Private getlinecout As getintdelegate '= AddressOf Form1.getlinecount
    Private getlinelength As getintdelegate '= AddressOf Form1.getlinelenght
    Private gettrickcout As getintdelegate '= AddressOf Form1.tricks_get_trickcount()
    Private gettrickstartpointers As getArraylistDelegate
    Private gettextdata As getArraylistDelegate
    Private gettrickdata As getArraylistDelegate

    Private getfilecontents As getStringDelegate
    Private getfilename As getStringDelegate


    Private setlinecout As setintdelegate '= AddressOf Form1.getlinecount
    Private setlinelength As setintdelegate '= AddressOf Form1.getlinelenght

    Private settrickdata As setarraylistdelegate
    Private settextdata As setarraylistdelegate

    Private _showfilerestrictions As doactiondelegate
    Private _hidefilerestrictions As doactiondelegate

    Private _sincronizelinelength As setintdelegate

    Protected MarshallingInitialized As Boolean = False

    Protected Sub initialisemarshalling()

        'these values can not be initialised in the declaration because an inner exception occurs

        'I tried several ways to make this occur with out having 
        'to explicitly call this function from inherited classes
        'but so far have not been succesfull with any of then

        'Form1.tricks_get_trickcount()


        sendfilecontenttoform1 = AddressOf Form1.ProcessFileContents
        getlinecout = AddressOf Form1.getlinecount
        getlinelength = AddressOf Form1.getlinelength
        gettrickcout = AddressOf Form1.tricks_get_trickcount
        setlinecout = AddressOf Form1.setlinecount
        setlinelength = AddressOf Form1.setlinelength
        settrickdata = AddressOf Form1.settrickdata
        settextdata = AddressOf Form1.settextdata

        gettrickstartpointers = AddressOf Form1.tricks_get_startpointers
        gettextdata = AddressOf Form1.gettextdata
        gettrickdata = AddressOf Form1.gettrickdata

        getfilecontents = AddressOf Form1.generate_file_output
        getfilename = AddressOf Form1.getfilename


        _showfilerestrictions = AddressOf Form1.show_filerestrictions
        _hidefilerestrictions = AddressOf Form1.hide_filerestrictions
        _sincronizelinelength = AddressOf Form1.sincronizelinelength
        MarshallingInitialized = True

    End Sub

    Protected Function processFileContents(ByVal filecontents) As Boolean

        If Not MarshallingInitialized Then
            Throw New Exception("marshalling not initialized")
        End If

        Return sendfilecontenttoform1.Invoke(filecontents)
    End Function
    Protected Function generate_file_contents()
        If Not MarshallingInitialized Then
            Throw New Exception("marshalling not initialized")
        End If

        Return getfilecontents()
    End Function
    Protected Sub sincronizelinelength(ByVal linelength As Integer)
        If Not MarshallingInitialized Then
            Throw New Exception("marshalling not initialized")
        End If
        _sincronizelinelength.Invoke(linelength)

    End Sub

    Protected Sub hide_filerestrictions()
        If Not MarshallingInitialized Then
            Throw New Exception("marshalling not initialized")
        End If
        _hidefilerestrictions.Invoke()

    End Sub

    Protected Sub show_filerestrictions()
        If Not MarshallingInitialized Then
            Throw New Exception("marshalling not initialized")
        End If
        _showfilerestrictions.Invoke()

    End Sub


    Protected Property trickdata() As ArrayList
        Get
            If Not MarshallingInitialized Then
                Throw New Exception("marshalling not initialized")
            End If

            Return gettrickdata.Invoke()
        End Get
        Set(ByVal value As ArrayList)

            If Not MarshallingInitialized Then
                Throw New Exception("marshalling not initialized")
            End If

            settrickdata.Invoke(value)
        End Set
    End Property

    Protected ReadOnly Property filename()

        Get

            If Not MarshallingInitialized Then
                Throw New Exception("marshalling not initialized")
            End If

            Return getfilename.Invoke()

        End Get
    End Property

    Protected Property textdata() As ArrayList
        Get

            If Not MarshallingInitialized Then
                Throw New Exception("marshalling not initialized")
            End If

            Return gettextdata.Invoke()
        End Get
        Set(ByVal value As ArrayList)

            If Not MarshallingInitialized Then
                Throw New Exception("marshalling not initialized")
            End If

            settextdata.Invoke(value)

        End Set
    End Property
    Protected Property trickstartpointers()
        Get
            If Not MarshallingInitialized Then
                Throw New Exception("marshalling not initialized")
            End If
            Return gettrickstartpointers.Invoke
        End Get
        Set(ByVal value)
            MsgBox("set trickstartpointers not yet implimenterd")
        End Set
    End Property

    Protected Property trickcount()
        Get
            If Not MarshallingInitialized Then
                Throw New Exception("marshalling not initialized")
            End If

            Return gettrickcout.Invoke()
        End Get
        Set(ByVal value)
            MsgBox("set trickcount not yet implimenterd")
        End Set
    End Property


    Property linelength()
        Get
            If Not MarshallingInitialized Then
                Throw New Exception("marshalling not initialized")
            End If

            Return getlinelength.Invoke()
        End Get
        Set(ByVal value)
            setlinelength.Invoke(value)
        End Set
    End Property

    Property linecount()
        Get
            If Not MarshallingInitialized Then
                Throw New Exception("marshalling not initialized")
            End If

            Return getlinecout.Invoke()
        End Get
        Set(ByVal value)
            setlinecout.Invoke(value)
        End Set
    End Property

    










    'end experimenting with marshaling


    'the primary purpose of this constant is to allow functions with optional object parameters
    Const EMPTYOBJECT As Object = ""



    '''''''general sign connection functionality



    'legacy variables from before class structure for connections
    Public Const READCOMMAND As String = "R" + Constants.vbCrLf
    Public Const VERSIONCOMMAND As String = "V" + Constants.vbCrLf
    Public Const BOOTLOADER_VERSIONCOMMAND As String = "V" 'used to check if bootloader running
    Protected Const ADDRESS_EEPROM_MAP_TYPE = 510
    Protected Const ADDRESS_LINECOUNT = 0
    Protected Const WRITERESPONSELENGTH = 6
    Protected Const READRESPONSELENGTH = 6
    Protected Const VERSIONRESPONSELENGTH = 8
    Protected Const ADDRESS_LINELENGTH = 1
    Protected address_startoftrickdata As Integer = 2
    Protected Const MAXIMUMECHOLENGTH As Integer = 12
    Public echoerror As Integer = 0 '0-no error 1-time out 2-line not terminated 3-unexpected line 4-error echo 5-wrong address echoed back 6-wrong character echoed back 7-comunication exception

    'end legacy variables


    'Protected backgroundworker As System.ComponentModel.BackgroundWorker
    'Protected progressfrom As Form



    Protected communication_time_out_in_seconds As Double = 1
    Protected _selectedsign As String = ""



    Public ReadOnly Property selectedsign() As String
        Get
            Return _selectedsign
        End Get
    End Property

    Public ReadOnly Property firstComportScanComplete() As Boolean
        Get
            Return comportmanager.firstscancomplete

        End Get
    End Property
    Protected myProgressForm As ProgressForm = New ProgressForm
    Protected mycomportmanager As ComportManager
    Public ReadOnly Property comportmanager() As ComportManager
        Get
            Return mycomportmanager
        End Get
    End Property

    Public connected As Boolean = False
    Public Const MIN_FIRMWARE_MAJOR_VERSION As Integer = 1
    Public Const MIN_FIRMWARE_MINOR_VERSION As Integer = 1


    Public ReadOnly Property allSigns_working() As ArrayList
        Get
            Return _allSigns_working
        End Get
    End Property
    Public ReadOnly Property allSigns_NeedFirmware() As ArrayList
        Get
            Return _allSigns_NeedFirmware
        End Get
    End Property

    Public ReadOnly Property allSigns_malfunctioning() As ArrayList
        Get
            Return _allSigns_malfunctioning
        End Get
    End Property
    Public ReadOnly Property allSigns_notFound() As ArrayList
        Get
            Return _allSigns_notFound
        End Get
    End Property



    'not all of these are expected to be used in all inherited classes
    Protected _allSigns_expected As ArrayList = New ArrayList 'the signs Tiniwindow is configured to expect to find
    Protected _allSigns_working As ArrayList = New ArrayList 'The sign for which Tiniwindow gets proper feedback while scanning
    Protected _allSigns_NeedFirmware As ArrayList = New ArrayList 'signs that either have bootloader running or have incompatable version of firmware
    Protected _allSigns_malfunctioning As ArrayList = New ArrayList 'signs expected but return a response that is not understood
    Protected _allSigns_notFound As ArrayList = New ArrayList 'signs expected but not found while scanning

    'we might temporarily decide to use theses instead of the variables above or we might get rid of them
    'Protected _allSigns_expected_count As Integer = 0 'the signs Tiniwindow is configured to expect to find
    'Protected _allSigns_working_count As Integer = 0 'The sign that Tiniwindow finds while scanning
    'Protected _allSigns_NeedFirmware_Count As Integer = 0 'signs that either have bootloader running or have incompatable version of firmware
    'Protected _allSigns_malfunctioning_Count As Integer = 0 'signs that return a response that is not understood
    'Protected _allSigns_notFound_Count As Integer = 0 'signs are not found while scanning



    'these variables should be moved to multisign versions of the class
    'Protected _selecedSigns_expected As ArrayList = New ArrayList 'the signs Tiniwindow is configured to expect to find
    'Protected _selecedSigns_working As ArrayList = New ArrayList 'The sign for which Tiniwindow gets proper feedback while scanning
    'Protected _selecedSigns_NeedFirmware As ArrayList = New ArrayList 'signs that either have bootloader running or have incompatable version of firmware
    'Protected _selecedSigns_malfunctioning As ArrayList = New ArrayList 'signs that return a response that is not understood
    'Protected _selecedSigns_notFound As ArrayList = New ArrayList 'signs are not found while scanning


    'Protected _selecedSigns_expected_count As Integer = 0 'the signs Tiniwindow is configured to expect to find
    'Protected _selecedSigns_working_count As Integer = 0 'The sign that Tiniwindow finds while scanning
    'Protected _selecedSigns_NeedFirmware_Count As Integer = 0 'signs that either have bootloader running or have incompatable version of firmware
    'Protected _selecedSigns_malfunctioning_Count As Integer = 0 'signs that return a response that is not understood
    'Protected _selecedSigns_notFound_Count As Integer = 0 'signs are not found while scanning

    '' '' implimented functions

    'functions related to background worker

    Protected Overridable Sub common_backgroundwork_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs)
        Dim userstate As String = e.UserState
        Dim partsofuserstate As String() = userstate.Split(Constants.vbCrLf)
        Dim process As String
        Dim progress As String
        Dim warning1 As String = ""
        Dim warning2 As String = ""


        If partsofuserstate.Length = 0 Then
            'no progress data at all
            'what now?
            process = ""
            progress = "no progress description"



        ElseIf partsofuserstate.Length = 1 Then
            process = partsofuserstate(0)
            progress = partsofuserstate(0)
            warning1 = ""
            warning2 = ""
        ElseIf partsofuserstate.Length = 2 Then
            ' old expected situation
            process = partsofuserstate(0)
            progress = partsofuserstate(1)
            warning1 = ""
            warning2 = ""

        ElseIf partsofuserstate.Length = 3 Then
            'new acceptable situtation with warning expected situation
            process = partsofuserstate(0)
            progress = partsofuserstate(1)
            warning1 = partsofuserstate(2)
            warning2 = ""

        ElseIf partsofuserstate.Length = 4 Then
            'new acceptable situtation with warning expected situation
            process = partsofuserstate(0)
            progress = partsofuserstate(1)
            warning1 = partsofuserstate(2)
            warning2 = partsofuserstate(3)


        ElseIf partsofuserstate.Length > 4 Then
            'more lines then expected what now?
            process = partsofuserstate(0)
            progress = partsofuserstate(1)
            warning1 = partsofuserstate(2)
            warning2 = partsofuserstate(3)
            MsgBox("warning too much data passed to progress process")

        Else

        End If
        If process = "Get data from sign" Then
            'display the lines as they are read from the sign
            'MsgBox("ttttt")
            Form1.textdata_top()
        End If

        'MsgBox(connectionProgressForm.testvariable & " " & test.testvariable)
        myProgressForm.Text = process 'removed in 1.09.002 when form made to coinside with dialog area

        myProgressForm.ProgressBar.Value = e.ProgressPercentage
        myProgressForm.LblProgress.Text = progress

    End Sub

    Protected Overridable Sub common_backgroundwork_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)




        If e.Cancelled = True Then
            'MsgBox("cancled")
            'myconnectionProgressForm.LblProgress.Text = "Canceled!"
            myProgressForm.enableRetry()


        ElseIf e.Error IsNot Nothing Then

            myProgressForm.LblProgress.Text = "Unexpected error: " & e.Error.Message
            myProgressForm.enableRetry()
        Else

            myProgressForm.markfinished()
            'success
            'in this particular case the dialog on progress form should be correct
            'in other case it might be desirable to pass dialog to the progress form

        End If



    End Sub


    'the connect functions may be removed from base class if we decide that the one sign and 
    'multisign versions require different types of parameters
    Public Overridable Function connect(ByVal signidentifyer As Object, Optional ByVal autoCloseDialogWhenComplete As Boolean = False) As Object
        'this function MUST be overidden by classes that inherit it




        'for now made return value object so that differnt derived classes can use the returned value differently 
        'suggest using false to mean connection failed 
        Throw New Exception("you have called the base connect function which is a virtual function")

        Return False
    End Function
    Public Overridable Function TestSignConnection(Optional ByVal comhandle As portConnectionHandle = Nothing) As Boolean

        Throw New Exception("You are calling a function that is virtual and must be overidden")


    End Function

    Public Overridable Function connect(ByVal signidentifyer As String) As Object
        'this function MUST be overidden by classes that inherit it




        'for now made return value object so that differnt derived classes can use the returned value differently 
        'suggest using false to mean connection failed 
        Throw New Exception("you have called the base connect function which is a virtual function")

        Return False
    End Function

    Public Overridable Function disconnect() As Object
        'this function MUST be overidden by classes that inherit it


        'false means sign disconnection failed. for return value is object so that differnt derived classes can use the returned value differently 
        'this function should do things that need to be done in order to close one connection before another can be opened.
        'it may not be needed in all connetion types

        Throw New Exception("you have called the base disconnect function which is a virtual function")
        Return False
    End Function

    Public Overridable Function sendData() As Object
        'this function MUST be overidden by classes that inherit it


        'false means sign disconnection failed. for return value is object so that differnt derived classes can use the returned value differently 
        'this function should do things that need to be done in order to close one connection before another can be opened.
        'it may not be needed in all connetion types

        Throw New Exception("you have called the base sendData function which is a virtual function")
        Return False
    End Function

    Public Overridable Function GetData() As Object
        'this function MUST be overidden by classes that inherit it


        'false means sign disconnection failed. for return value is object so that differnt derived classes can use the returned value differently 
        'this function should do things that need to be done in order to close one connection before another can be opened.
        'it may not be needed in all connetion types

        Throw New Exception("you have called the base getData function which is a virtual function")
        Return False
    End Function


    'we will decide later how to implement this and what parameters the function should take
    'Public Overridable Function updateFirmware() As Object
    '    'this function MUST be overidden by classes that inherit it


    '    'false means sign disconnection failed. for return value is object so that differnt derived classes can use the returned value differently 
    '    'this function should do things that need to be done in order to close one connection before another can be opened.
    '    'it may not be needed in all connetion types

    '    Throw New Exception("you have called the base updatefirmware function which is a virtual function")
    '    Return False
    'End Function







    ''''''''''''''''''''''''''''comport functionality''''''''''''''''''''''''

    'at time of setting up class hierachy every immaginable method 
    'of connecting to a sign involved first opening a comport and 
    'making sure it is the right conport.


    Protected comport_baudrate As Integer = 9600 'not expected to change but writen as variable for future flexibilty
    Protected comport_parity As System.IO.Ports.Parity = System.IO.Ports.Parity.None 'not expected to change but writen as variable for future flexibilty
    Protected comport_databits As Integer = 8 'not expected to change but writen as variable for future flexibilty
    Protected comport_stopbits As System.IO.Ports.StopBits = System.IO.Ports.StopBits.One 'not expected to change but writen as variable for future flexibilty







    ''''''''initializers and destructors''''''''''''
    Protected Overrides Sub Finalize()

        'Try
        '    comport.Close()
        'Catch ex As Exception

        '    'if the comport failes to close do nothing
        '    'this usualy happens because it is not open or not defined    
        'End Try

    End Sub

    Protected Sub New()

    End Sub
    Public Sub New(ByRef CM As ComportManager)


        'Me.New()
        'there can only be one comport manager in the whole program
        mycomportmanager = CM
    End Sub

    'functions related to using the comport
    Protected myPortConnectionHandle As portConnectionHandle
    Public ReadOnly Property portconnecrtionHandle()
        Get
            Return myPortConnectionHandle

        End Get
    End Property

    Protected Enum CommunicationResult
        success = True
        invalidConnection
        connectionBusy
        communicationTimeout
        fail
    End Enum
     Protected Overridable Function writeThenReadline(ByVal writestring As String, ByRef readstring As String, Optional ByVal maxlength As Int64 = 100, Optional ByVal attempts As UInt16 = 1, Optional ByVal CommunicationTimeoutInSeconds As Double = 1, Optional ByVal ConnectionBusyTimeoutInSeconds As Double = 5, Optional ByVal preWriteGuardTimeInseconds As Double = 0, Optional ByVal comhandle As portConnectionHandle = Nothing) As CommunicationResult

        If comhandle = Nothing Then
            comhandle = myPortConnectionHandle
        End If
        'Public Function writeThenReadlinePort                                                   (ByVal handle As portConnectionHandle, ByVal writestring As String, ByRef readstring As String, Optional ByVal maxlength As Int64 = 100, Optional ByVal attempts As UInt16 = 1, Optional ByVal CommunicationTimeOutInSeconds As Double = 0.5, Optional ByVal portBusyTimeOutInSeconds As Double = 5, Optional ByVal preWriteGuardTimeInseconds As Double = 0) As portOperationResult
        Dim result As ComportManager.portOperationResult = mycomportmanager.writeThenReadlinePort(comhandle, writestring, readstring, maxlength, attempts, , ConnectionBusyTimeoutInSeconds, preWriteGuardTimeInseconds)
        If result = comportmanager.portOperationResult.success Then
            Return CommunicationResult.success
        ElseIf result = comportmanager.portOperationResult.portBusy Then
            Return CommunicationResult.connectionBusy
        ElseIf result = comportmanager.portOperationResult.communicationTimeout Then
            Return CommunicationResult.communicationTimeout
        ElseIf result = comportmanager.portOperationResult.invalidhandle Then
            Return CommunicationResult.invalidConnection
        ElseIf result = comportmanager.portOperationResult.fail Then
            Return CommunicationResult.fail
        Else
            MsgBox("bug! - unrecognised return value received in writeThenReadline in class SignConnection_OneSign_USB")
            Return CommunicationResult.fail

        End If

        'Throw New Exception("You are calling a function that is virtual and must be overidden")

    End Function

    Protected Overridable Function writeThenReadChars(ByVal writestring As String, ByRef readstring As String, Optional ByVal length As Int64 = 10, Optional ByVal attempts As UInt16 = 1, Optional ByVal communicationTimeOutInSeconds As Double = 1, Optional ByVal ConnectionBusyTimeOutInSeconds As Double = 5, Optional ByVal preWriteGuardTimeInseconds As Double = 0) As CommunicationResult
        Dim result As ComportManager.portOperationResult = mycomportmanager.writeThenReadCharsPort(myPortConnectionHandle, writestring, readstring, length, attempts, communicationTimeOutInSeconds, ConnectionBusyTimeOutInSeconds, preWriteGuardTimeInseconds)

        If result = comportmanager.portOperationResult.success Then
            Return CommunicationResult.success
        ElseIf result = comportmanager.portOperationResult.portBusy Then
            Return CommunicationResult.connectionBusy
        ElseIf result = comportmanager.portOperationResult.communicationTimeout Then
            Return CommunicationResult.communicationTimeout
        ElseIf result = comportmanager.portOperationResult.invalidhandle Then
            Return CommunicationResult.invalidConnection
        ElseIf result = comportmanager.portOperationResult.fail Then
            Return CommunicationResult.fail
        Else
            MsgBox("bug! - unrecognised return value received in writeThenReadline in class SignConnection_OneSign_USB")
            Return CommunicationResult.fail

        End If

    End Function

    Protected Overridable Function writeThenReadexisting(ByVal writestring As String, ByRef readstring As String, Optional ByVal attempts As UInt16 = 1, Optional ByVal ConnectionBusyTimeOutInSeconds As Double = 5, Optional ByVal preWriteGuardTimeInseconds As Double = 0) As CommunicationResult
        Dim result As ComportManager.portOperationResult = mycomportmanager.writeThenReadExistingPort(myPortConnectionHandle, writestring, readstring, attempts, ConnectionBusyTimeOutInSeconds, preWriteGuardTimeInseconds)

        If result = comportmanager.portOperationResult.success Then
            Return CommunicationResult.success
        ElseIf result = comportmanager.portOperationResult.portBusy Then
            Return CommunicationResult.connectionBusy
        ElseIf result = comportmanager.portOperationResult.communicationTimeout Then
            Return CommunicationResult.communicationTimeout
        ElseIf result = comportmanager.portOperationResult.invalidhandle Then
            Return CommunicationResult.invalidConnection
        ElseIf result = comportmanager.portOperationResult.fail Then
            Return CommunicationResult.fail
        Else
            MsgBox("bug! - unrecognised return value received in writeThenReadline in class SignConnection_OneSign_USB")
            Return CommunicationResult.fail

        End If

    End Function











    'modified legacy functions related to send data

    Protected ADDRESS_STARTOFTEXTDATA As Integer

    Protected Overridable Sub read_write_error(ByVal message As String)

        'calls to this function need to be eliminated and the error instead sent to the report progress on background worker


    End Sub
    Protected Overridable Sub update_progress_form(ByVal message As String)
        'figure out how to impliment later
    End Sub

    'legacy functions related to get data
    'these functions will be modified to use new read and write functions

    Protected Overridable Function writeToDevice(ByVal startaddress As Integer, ByVal text As String) As Boolean
        'this function write a string to the EEprom     
        'backgroundworkerdebugvalue = "290"
        Dim i As Integer = 0
        Try
            ' backgroundworkerdebugvalue = "291"
            Dim responseline As String = ""

            While (i < linelength)
                'backgroundworkerdebugvalue = (i + 201).ToString

                If (i < text.Length()) Then
                    '    backgroundworkerdebugvalue = (i + 202).ToString
                    If (Not writecharactertodevice(text.Substring(i, 1), startaddress + i)) Then
                        '         backgroundworkerdebugvalue = (i + 203).ToString
                        Return False
                    End If
                    '      backgroundworkerdebugvalue = (i + 204).ToString
                Else
                    '       backgroundworkerdebugvalue = (i + 205).ToString
                    If (Not writecharactertodevice(" ", startaddress + i)) Then
                        '            backgroundworkerdebugvalue = (i + 206).ToString
                        Return False
                    End If
                    '         backgroundworkerdebugvalue = (i + 207).ToString
                End If
                '      backgroundworkerdebugvalue = (i + 208).ToString
                i = i + 1

            End While
            '   backgroundworkerdebugvalue = "292"
            Return True
        Catch ex As System.ObjectDisposedException
            '    backgroundworkerdebugvalue = (i + 209).ToString
            echoerror = 7
            Return False
        End Try
        ' backgroundworkerdebugvalue = "293"

    End Function



    Protected Overridable Function writeparametertodevice(ByRef value As Integer, ByVal address As Integer) As Boolean
        'MsgBox("write parameter " + value.ToString)

        If (value > 255) Then
            'Dim retorevalue As Boolean = databeinginternallymanipulated
            'databeinginternallymanipulated = False 'prevent tripping watchdog timmer
            MsgBox("parameter value greater then 255 passed to writeparametertodevice")
            'databeinginternallymanipulated = retorevalue
            Return False
        End If
        'MsgBox(value.ToString + "   " + address.ToString)
        'MsgBox(address.ToString + "," + Chr(value) + "," + value.ToString)
        Return writecharactertodevice(Chr(value), address)


        Return True

    End Function
    Protected Overridable Function writecharactertodevice(ByRef character As Char, ByVal address As Integer) As Boolean
        'writes a single charater to the device 

        '0-no error 1-time out 2-line not terminated 3-unexpected line 4-error echo 5-wrong address echoed back 6-wrong character echoed back
        'backgroundworkerdebugvalue = "304"
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
        While (True)
            'backgroundworkerdebugvalue = (attemps + 310).ToString
            'If (progresform_cancle) Then
            'cancle_read_or_write() 'confirms cancle and throws argument exception
            'End If


            If writeThenReadline(myaddresscommand, line, 10, 3, Me.communication_time_out_in_seconds) <> CommunicationResult.success Then
                'communication completely fails after 3 attempts
                Return False
            End If

            If (line.TrimEnd <> myaddresscommand.TrimEnd) Then
                If (addressValid(line) And attemps < 3) Then


                    'backgroundworkerdebugvalue = (attemps + 370).ToString
                    attemps = attemps + 1

                Else

                    If (line = Constants.vbCrLf) Then

                        If (attemps < 3) Then
                            'backgroundworkerdebugvalue = (attemps + 380).ToString
                            attemps = attemps + 1
                        Else
                            'backgroundworkerdebugvalue = (attemps + 390).ToString
                            echoerror = 4

                            Return False
                        End If
                    Else

                        If (attemps < 3) Then
                            'backgroundworkerdebugvalue = (attemps + 380).ToString
                            attemps = attemps + 1
                        Else
                            'backgroundworkerdebugvalue = (attemps + 300).ToString + "a"
                            echoerror = 5

                            Return False
                        End If

                    End If

                End If

            Else
                line = ""
                If (writeThenReadline(mywritecommand, line, WRITERESPONSELENGTH, 3, communication_time_out_in_seconds) <> CommunicationResult.success) Then

                    Return False
                ElseIf (Not validwriteresponse(line)) Then
                    'backgroundworkerdebugvalue = (attemps + 300).ToString + "f"
                    If (line = Constants.vbCrLf And attemps < 3) Then
                        If (attemps < 3) Then
                            'backgroundworkerdebugvalue = (attemps + 300).ToString + "g"
                            attemps = attemps + 1
                        Else
                            'backgroundworkerdebugvalue = (attemps + 300).ToString + "h"
                            echoerror = 4
                            Return False
                        End If

                    Else
                        'backgroundworkerdebugvalue = (attemps + 300).ToString + "i"
                        'MsgBox("[" + line + "]")
                        echoerror = 3

                        Return False
                    End If
                ElseIf (line.TrimEnd <> mywritecommand.TrimEnd) Then
                    'backgroundworkerdebugvalue = (attemps + 300).ToString + "j"
                    'MsgBox("[" + line + "]" + "[" + mywritecommand + "]")
                    echoerror = 5

                    Return False
                Else

                    'backgroundworkerdebugvalue = (attemps + 300).ToString + "k"
                    'MsgBox("exit function")
                    Return True
                End If

            End If
            'MsgBox(attemps)


        End While
        'backgroundworkerdebugvalue = "308"
        'End With   'With- End With is way to simplify the function as show below
        'backgroundworkerdebugvalue = "309"
    End Function

    Protected Overridable Function validwriteresponse(ByVal line As String) As Boolean
        If (line.TrimEnd.Length() <> WRITERESPONSELENGTH - 2) Then
            Return False
        End If
        If (line.Substring(0, 2) <> "W ") Then
            Return False
        End If

        'W xx<crlf>
        If (Not ((line.Substring(2, 1) >= "0" And line.Substring(2, 1) <= "9") Or (line.Substring(2, 1) >= "A" And line.Substring(2, 1) <= "F"))) Then
            Return False
        End If
        If (Not ((line.Substring(3, 1) >= "0" And line.Substring(3, 1) <= "9") Or (line.Substring(3, 1) >= "A" And line.Substring(3, 1) <= "F"))) Then
            Return False
        End If
        Return True
    End Function
    Protected Overridable Function addressValid(ByVal address As String) As Boolean
        If (address.TrimEnd.Length <> 5) Then
            Return False
        End If
        If (address.Substring(0, 1) <> "A") Then
            Return False
        End If
        If (address.Substring(1, 1) <> " ") Then
            Return False
        End If

        If (address.Substring(2, 1) < "0" Or address.Substring(2, 1) > "9") Then
            Return False
        End If

        If (address.Substring(3, 1) < "0" Or address.Substring(2, 1) > "9") Then
            Return False
        End If

        If (address.Substring(4, 1) < "0" Or address.Substring(2, 1) > "9") Then
            Return False
        End If

        'If (address.Substring(5, 1) <> Constants.vbCr) Then
        '    Return False
        'End If
        'If (address.Substring(6, 1) <> Constants.vbLf) Then
        '    Return False
        'End If

        Return True
    End Function
    Protected Overridable Function convertCharacterToWriteComand(ByVal character As Char) As String
        'this functions converts a single character to a command for writing it to the EEprom
        'It is nesseary to set the address pointer before sending the command generated by this function
        Dim hexvalue As String = Hex(Asc(character))
        If (hexvalue.Length = 1) Then
            hexvalue = "0" + hexvalue
        End If
        Dim commandstring As String = "W " + hexvalue + Constants.vbCrLf
        Return commandstring
    End Function
    Protected Overridable Function addresstostring(ByVal address As Integer) As String
        'converts the integer address to a string address that must be 3 digits long
        Dim returnstring As String = address
        While (returnstring.Length() < 3)
            returnstring = "0" + returnstring
        End While
        Return returnstring

    End Function

    'end functions related to send data


    'funtions related to new communication protocal
    Protected Overridable Function appendcheckdigit(ByRef line As String, protocal As Integer) As String

        'for now trim crlf , append 00 and reappend crlf
        'latter on will need to do better

        line = line.Trim & "00" & vbCrLf
        Return line

    End Function

    'end fundtions related to new communication protoac

End Class
