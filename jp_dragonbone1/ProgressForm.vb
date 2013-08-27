Public Class ProgressForm



    Public bgw As System.ComponentModel.BackgroundWorker ' this is set externally and is only used for cacelation
    Public testvariable As Int16 = 0

    Public Delegate Sub background_work_delegate(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    Delegate Sub retryfunctiondelegate()
    Public Delegate Function retryFunctionDelegate_with_bgw(ByRef addressof_background_work As background_work_delegate)


    Public retryfunction As retryfunctiondelegate
    Public retryfunction_withbgw As retryFunctionDelegate_with_bgw


    Private _success As Boolean = False
    Public ReadOnly Property success() As Boolean
        Get
            Return _success
        End Get
    End Property

    Public Sub set_retry_function(ByVal addressof_retry_function)

        Try
            retryfunction = addressof_retry_function
            retryfunction_withbgw = Nothing
        Catch ex As Exception


            retryfunction_withbgw = addressof_retry_function
            retryfunction = Nothing


        End Try


    End Sub

    Public autocloseatcompletions As Boolean = True
    Public ReadOnly Property active() As Boolean
        Get
            Return m_active
        End Get
    End Property
    Private Shared m_active As Boolean = False
    Public Sub enableRetry()

        'this functions shows the retry button and assigns the sub that is invoked
        'when the button is pressed.
        'the sub invoked can not take any paremters

        'MsgBox("enableretry")
        'AddHandler retry, AddressOf addressOfRetryFunction.Invoke
        'myretryfunctiondelegate = addressOfRetryFunction


        _success = False
        But_retry.Visible = True
        But_ok.Visible = True

        'markfinished()

    End Sub

    Public Sub markfinished()
        'MsgBox("markfinished")

        _success = True
        If autocloseatcompletions Then
            Threading.Thread.Sleep(3000)
            'reset()
            Me.Close()
        Else

            But_ok.Visible = True
            But_cancel.Visible = False

        End If
        
        
    End Sub

    Public Sub reset()
        'MsgBox("markfinished")

        Me.Location = New Point(Form1.Location.X + 95, Form1.Location.Y + 70)

        But_ok.Visible = False
        But_cancel.Visible = True
        But_retry.Visible = False
        Me.ProgressBar.Value = 0
        Me.Lbl_WarningLine1.Text = ""
        Me.Lbl_WarningLine2.Text = ""



    End Sub

    Private Sub connectionProgressForm_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ProgressBar.Width = Me.Width

        LblProgress.Width = Me.Width

    End Sub

    Private Sub But_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_ok.Click
        'MsgBox("close")

        'reset()
        Me.Close()
    End Sub

    Private Sub But_retry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_retry.Click

        'But_retry.Visible = False
        reset()

        Try
            retryfunction.Invoke() 'invoke the function that has been assigned for retry


        Catch ex As Exception
            'the simple retry function not passed so the more complicated one must have been
            'nothing for parameter means the function should reuse the same background work function
            retryfunction_withbgw.Invoke(Nothing)
        End Try


    End Sub

    Private Sub connectionProgressForm_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged

        m_active = Me.Visible

        Dim testvar = Me.But_ok.Visible

        If Me.Visible Then


            reset()

        End If
        
        'But_retry.Visible = False
    End Sub



    
    
    Private Sub But_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_cancel.Click
        bgw.CancelAsync()
    End Sub

    Private Sub ProgressForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reset()
    End Sub

    
    Private Sub But_retry_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_retry.VisibleChanged
        Dim breakpointholder = But_retry.Visible
    End Sub

   
End Class