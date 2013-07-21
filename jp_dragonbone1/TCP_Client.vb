Imports System.Net.Sockets
Imports System.Text
Public Class TCP_Client


    

    Dim tcpClient As New System.Net.Sockets.TcpClient()
    Dim networkStream As NetworkStream
    Dim bgw_establishConnection As System.ComponentModel.BackgroundWorker = New System.ComponentModel.BackgroundWorker

    Private m_connectionstarttime As Double
    Private m_openingmessage As String
    Private current_checkouthandle As checkouthandle = checkouthandle.NOTCHECKEDOUT


    Public Function checkedOutToME(ByVal _checkouthandle) As Boolean

        Return checkouthandle.compare(_checkouthandle, current_checkouthandle)

    End Function

    Public Function checkin(ByVal _checkouthandle As checkouthandle) As Boolean
        If Not checkouthandle.compare(_checkouthandle, current_checkouthandle) Then


            'wrong checkout hadle passed
            Return False
        End If

        current_checkouthandle = checkouthandle.NOTCHECKEDOUT
        Return True


    End Function



    Public Function checkout(Optional ByVal timeoutinseconds As Double = 1) As checkouthandle

        If current_checkouthandle.expired Then
            checkin(current_checkouthandle)

        End If

        If current_checkouthandle.id = checkouthandle.NOTCHECKEDOUT.id Then
            Dim thischeckouthandle As checkouthandle = New checkouthandle(timeoutinseconds)
            Me.current_checkouthandle = thischeckouthandle

            Return thischeckouthandle

        Else

            'already checked out 


            Return checkouthandle.ALREADYCHECKEDOUT


        End If


    End Function

    Public Function DataAvailable(ByRef _checkouthandle As checkouthandle) As Boolean

        If Me.current_checkouthandle.expired Then
            Me.checkin(current_checkouthandle)
        End If


        If (_checkouthandle.id <> Me.current_checkouthandle.id) Then

            'wrong checkout hadle passed
            Return False
        End If


        current_checkouthandle.slapTimeOutClock()
        _checkouthandle = current_checkouthandle
        If networkStream Is Nothing Then
            Return False
        Else
            Return networkStream.DataAvailable
        End If


    End Function
    Public Function DataAvailable() As Boolean

        Return DataAvailable(checkouthandle.NOTCHECKEDOUT)
    End Function






    Public ReadOnly Property openingReceiveMessage() As String
        Get

            Return m_openingmessage

        End Get
    End Property












    Public Enum connection_status_options
        NotConnected
        Attempting
        Connected
        connected_cant_read
        connected_cant_write
        connected_cant_read_or_write
        Failed 'not currenty used instead it hangs forever on attempting
    End Enum
    Private ready_to_connect As Boolean = False

    Private _mconnection_status As connection_status_options = connection_status_options.NotConnected
    Public ip As String = ""
    Public port As Int16


    Public ReadOnly Property connectionStatus() As connection_status_options
        Get
            Return _mconnection_status
        End Get
    End Property

    Public Function send(ByVal output As String, ByRef _checkouthandle As checkouthandle) As Boolean

        If Me.current_checkouthandle.expired Then
            Me.checkin(current_checkouthandle)
        End If

        If (_checkouthandle.id <> Me.current_checkouthandle.id) Then

            'wrong checkout hadle passed
            Return False
        End If

        Try

            current_checkouthandle.slapTimeOutClock()
            _checkouthandle = current_checkouthandle
            Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(output)
            networkStream.Write(sendBytes, 0, sendBytes.Length)

        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function
    Public Function send(ByVal output As String) As Boolean

        Return send(output, checkouthandle.NOTCHECKEDOUT)

    End Function

    Public Function receive(ByRef _checkouthandle As checkouthandle) As String

        If Me.current_checkouthandle.expired Then
            Me.checkin(current_checkouthandle)
        End If


        If (_checkouthandle.id <> Me.current_checkouthandle.id) Then

            'wrong checkout hadle passed
            Return ""
        End If

        current_checkouthandle.slapTimeOutClock()
        _checkouthandle = current_checkouthandle

        If networkStream Is Nothing Then
            MsgBox("error networkstream not defined")
            Return ""
        End If
        If networkStream.DataAvailable Then


            Dim bytes(tcpClient.ReceiveBufferSize) As Byte

            networkStream.Read(bytes, 0, CInt(tcpClient.ReceiveBufferSize))
            Return Encoding.ASCII.GetString(bytes).TrimEnd(Chr(0))

        Else
            'no data received
            'return empty string
            Return ""
        End If



    End Function
    Public Function receive() As String

        Return receive(checkouthandle.NOTCHECKEDOUT)

    End Function



    Protected Overridable Sub accept_clients_backgroundWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

        While True


            If ready_to_connect Then
                If tcpClient.Connected Then


                    If networkStream.CanWrite And networkStream.CanRead Then

                        _mconnection_status = connection_status_options.Connected

                    ElseIf Not networkStream.CanRead And Not networkStream.CanWrite Then
                        _mconnection_status = connection_status_options.connected_cant_read_or_write

                    ElseIf Not networkStream.CanWrite Then
                        _mconnection_status = connection_status_options.connected_cant_write
                    ElseIf Not networkStream.CanRead Then
                        _mconnection_status = connection_status_options.connected_cant_read
                    End If





                Else 'not tcpClient.connected

                    _mconnection_status = connection_status_options.Attempting
                    Try


                        tcpClient.Connect(ip, port)

                        networkStream = tcpClient.GetStream()
                        m_connectionstarttime = DateAndTime.Timer



                        m_openingmessage = receive() 'get the opening message (if any)from server

                    Catch ex As Exception
                        Dim breakpointholder As Int16 = 0


                        'J.P. oct 18,2011 I beleive the problems detailed below were solved a long time ago with a new server script


                        'unable to solve problem of TiniWindow only connecting to server every other time
                        'when running in debug mode it consistently connects
                        'when using the message box it eventually connects after several iterations of saying the server failed to respond after a certain time
                        'with sleep and report progress it does not connect (every other time)


                        'sender.ReportProgress(0, "ddddddd")
                        'System.Threading.Thread.Sleep(1000)
                        'MsgBox(ex.Message)
                        _mconnection_status = connection_status_options.NotConnected
                    End Try


                End If
            Else 'not ready to connect

                _mconnection_status = connection_status_options.NotConnected

            End If
        End While




    End Sub
    Public Sub connect(Optional ByVal _ip As String = "", Optional ByVal _port As Int16 = Nothing)

        close()

        ' ''If Me.tcpClient.Connected Then
        ' ''    tcpClient.Close(
        ' ''End If

        If _ip <> "" Then
            ip = _ip
        End If

        If _port <> Nothing Then
            port = _port
        End If

        If ip <> "" And port <> Nothing Then
            Me.ready_to_connect = True
        End If





    End Sub


    Public Sub New()
        AddHandler bgw_establishConnection.DoWork, AddressOf accept_clients_backgroundWork

        bgw_establishConnection.RunWorkerAsync()

    End Sub

    Public Sub New(ByVal _ip As String, ByVal _port As Int16, Optional ByVal connect As Boolean = False)
        AddHandler bgw_establishConnection.DoWork, AddressOf accept_clients_backgroundWork

        bgw_establishConnection.RunWorkerAsync()

        Me.connect(_ip, _port)




    End Sub
    'Protected Overloads Overrides Sub Finalize()

    '    close()


    '    MyBase.Finalize()
    'End Sub 'Finalize

    Public openingSendMessage As String = ""
    Public closingSendMessage As String = ""

    Public Sub close(ByVal _clossingMessage As String)
        closingSendMessage = _clossingMessage
        close()
    End Sub
    Public Sub close()
        If Me.connectionStatus = connection_status_options.Connected Then

            If Not checkouthandle.compare(Me.current_checkouthandle, checkouthandle.NOTCHECKEDOUT) Then
                Me.checkin(current_checkouthandle)

            End If


            If Me.closingSendMessage <> "" Then
                Me.send(closingSendMessage)
            End If


            Me.ready_to_connect = False
            Me.tcpClient.Close()
            Me._mconnection_status = connection_status_options.NotConnected

        End If

    End Sub
End Class
