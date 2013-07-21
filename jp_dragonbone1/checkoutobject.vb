Public Class checkouthandle

    Public Shared NOTCHECKEDOUT As checkouthandle = New checkouthandle(-1, )
    Public Shared CHECKOUTNOTSUPPORTED As checkouthandle = New checkouthandle(-2, )
    Public Shared ALREADYCHECKEDOUT As checkouthandle = New checkouthandle(-3, )

    Private m_id As Int16
    Private starttime As Double
    Private lastactiontime As Double
    Private timeout As Double 'values less then 0  mean no time out

    Private Shared nextcheckouthandle = 1

    Public ReadOnly Property expired()
        Get
            If DateAndTime.Timer - lastactiontime >= timeout Then

                Return True

                'ElseIf ((lastactiontime - DateAndTime.Timer) <= 86400 - timeout) Then
                '    'cross midnight
                '    Return True


            Else
                Return False
            End If

        End Get
    End Property
    Public ReadOnly Property id() As Int16
        Get

            slapTimeOutClock()
            Return m_id
        End Get
    End Property

    Private Sub New(ByVal _id As Int16, Optional ByVal timeoutinseconds As Double = 1)

        starttime = DateAndTime.Timer 'seconds since midnight
        lastactiontime = starttime

        m_id = _id
        timeout = timeoutinseconds


    End Sub
    Public Sub New(Optional ByVal timeoutinseconds As Double = 1)

        starttime = DateAndTime.Timer 'seconds since midnight
        lastactiontime = starttime
        m_id = nextcheckouthandle
        timeout = timeoutinseconds

        If nextcheckouthandle = 32767 Then
            nextcheckouthandle = 1
        Else
            nextcheckouthandle += 1

        End If

    End Sub



    Public Shared Function compare(ByVal a As checkouthandle, ByVal b As checkouthandle)
        If a.id = b.id Then
            If a.id > 0 Then
                If a.starttime = b.starttime Then

                    Return True
                Else
                    Return False
                End If

            Else
                'id less then 0. these are special dummy handles
                Return True
            End If

        Else

            'the ids are different
            Return False
        End If
    End Function
    Public Sub slapTimeOutClock()

        lastactiontime = DateAndTime.Timer
    End Sub


End Class
