
Public Class SignConnection_FTP
    Inherits SignConnection_OneSign

    Public Overrides ReadOnly Property allSigns_working() As ArrayList
        Get
            Dim returnvalue As ArrayList = New ArrayList
            For Each sign As RemoteSignsForm.remoteSign In RemoteSignsForm.remoteSignList
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

        'Dim attemptcounter As Int16 = 1


        'myPortConnectionHandle = -2
        'While myPortConnectionHandle < 0
        '    If attemptcounter > 40 Then
        '        bgw.ReportProgress(0, process & "Error! open comport...Giving up after 40 attempts ")
        '        e.Cancel = True
        '        Return
        '    End If
        '    bgw.ReportProgress(0, process & "creating comport handle... attempt " & attemptcounter)

        '    If bgw.CancellationPending Then
        '        bgw.ReportProgress(0, process & "connection process canceled ")
        '        e.Cancel = True
        '        Return
        '    End If
        '    myPortConnectionHandle = mycomportmanager.createPortConnection(selectedsign, )
        '    attemptcounter += 1
        '    'puase so that if there is an error the user can see the couter and do something
        '    System.Threading.Thread.Sleep(300)
        'End While

        'If bgw.CancellationPending Then
        '    e.Cancel = True
        '    Return
        'End If

        'attemptcounter = 1
        'bgw.ReportProgress(50, process & "Testing connection... attempt " & attemptcounter)
        'While Not TestSignConnection()

        '    If attemptcounter > 40 Then
        '        bgw.ReportProgress(50, process & "Error! sign not responding...Giving up after 40 attempts ")
        '        mycomportmanager.discardPortConnection(myPortConnectionHandle)
        '        e.Cancel = True
        '        Return
        '    End If
        '    If bgw.CancellationPending Then

        '        bgw.ReportProgress(50, process & "Connection process canceled!")
        '        mycomportmanager.discardPortConnection(myPortConnectionHandle)
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





End Class
