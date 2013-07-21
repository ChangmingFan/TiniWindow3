Imports System.Net.Sockets
Imports System.Text

Public Class tcp_server


    Public Structure client
        Private stream As NetworkStream
        Private tcpclient As TcpClient
        Dim tag ' not used by this class, avalibale to other users
        Private m_connectionstarttime As Double
        Private m_openingmessage As String
        Public ReadOnly Property DataAvailable() As Boolean
            Get
                Return stream.DataAvailable
            End Get
        End Property
        Public ReadOnly Property openingmessage() As String
            Get

                Return m_openingmessage

            End Get
        End Property

        Public Sub New(ByRef passed_stream As NetworkStream, ByVal passed_tcpclient As TcpClient, Optional ByVal passed_connectiontarttime As Double = Nothing, Optional ByVal passed_openingmessage As String = "")
            stream = passed_stream
            tcpclient = passed_tcpclient
            m_openingmessage = passed_openingmessage
            tag = ""
            If passed_connectiontarttime = Nothing Then
                m_connectionstarttime = DateAndTime.Timer
            Else
                m_connectionstarttime = passed_connectiontarttime
            End If

        End Sub

        Public Sub settag(ByVal t As Object)
            tag = t
        End Sub
        Public Sub send(ByVal output As String)

            Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(output)
            stream.Write(sendBytes, 0, sendBytes.Length)

        End Sub

        Public Function receive() As String

            If stream.DataAvailable Then


                Dim bytes(tcpclient.ReceiveBufferSize) As Byte

                stream.Read(bytes, 0, CInt(tcpclient.ReceiveBufferSize))
                Return Encoding.ASCII.GetString(bytes).TrimEnd(Chr(0))

            Else
                'no data received
                'return empty string
                Return ""
            End If

        End Function
    End Structure




    Dim tcpListener As TcpListener '( New TcpListener(portNumber)
    Dim connected As Boolean = False


    Dim _port As Int16 = 2000 'initialised to defualt value
    Public ReadOnly Property port() As Int16
        Get
            Return _port
        End Get
    End Property
    Dim bgw_accept_clients As System.ComponentModel.BackgroundWorker = New System.ComponentModel.BackgroundWorker

    Dim m_clients As ArrayList = New ArrayList

    Public ReadOnly Property clients() As ArrayList
        Get
            Return m_clients


        End Get
    End Property





    Protected Overridable Sub accept_clients_backgroundWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

        While connected

            If tcpListener.Pending Then

                Try


                    Dim tcpClient As TcpClient
                    Dim networkStream As NetworkStream


                    tcpClient = tcpListener.AcceptTcpClient()
                    Dim connectionstarttime As Double = DateAndTime.Timer

                    networkStream = tcpClient.GetStream()


                    Dim this_client As client '= New client(networkStream, tcpClient)

                    Dim openingmessage As String = ""

                    If networkStream.DataAvailable Then
                        'get opening line

                        Dim bytes(tcpClient.ReceiveBufferSize) As Byte

                        networkStream.Read(bytes, 0, CInt(tcpClient.ReceiveBufferSize))


                        openingmessage = Encoding.ASCII.GetString(bytes)


                    Else
                        'no initial message
                        openingmessage = ""

                    End If


                    this_client = New client(networkStream, tcpClient, connectionstarttime, openingmessage)

                    m_clients.Add(this_client)

                Catch ex As Exception
                    'connection failed
                    'since adding new client to arraylist is last step
                    'and likely has not been done there is nothing more to do

                End Try


            End If
        End While




    End Sub

    Public Sub start(Optional ByVal portnum As Int16 = Nothing)

        If Not portnum = Nothing Then
            _port = portnum
        End If


        tcpListener = New TcpListener(_port)
        tcpListener.Start()
        connected = True
        AddHandler bgw_accept_clients.DoWork, AddressOf accept_clients_backgroundWork

        bgw_accept_clients.RunWorkerAsync()

    End Sub


End Class
