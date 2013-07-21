Public Class oldprogress_form

    Public Sub setheader(ByVal header As String)
        Me.Text = header
        Lbl_heading.Text = header
    End Sub
    Public Sub setprogress(ByVal progress As String)
        LBL_progress.Text = progress
    End Sub
    Public Sub setstepcount(ByVal steps As Integer)
        If (ProgressBar.Step <> 100 / steps) Then
            ProgressBar.Step = 100 / steps
            'MsgBox(steps.ToString + " " + ProgressBar.Step.ToString)
        End If


    End Sub

    Private Sub progress_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '        Dim progresform_status As String = "" 'set by read/write another tread,  timer in main thread then updates progress form
        '       Dim progresform_process As String = "" 'should be 'read' or 'write' 
        '      Dim progresform_progress As String = "" 'should be 'read' or 'write' 
        '     Dim progresform_updatestatus As Boolean = False 'set by read/write another thread,  timer in main thread then updates progress form
        '    Dim progresform_complete As Boolean = False 'set by read/write  thread,  timer in main thread then updates progress form
        '   Dim progresform_successful As Boolean = False 'set by read/write  thread,  timer in main thread then updates progress form
        '  Dim progresform_cancle As Boolean = False
        Form1.progresform_cancel = False
        Form1.progresform_complete = False
        If (Form1.progresform_process = "read") Then
            setheader("Geting data from the sign")
        ElseIf (Form1.progresform_process = "write") Then
            setheader("Sending data to the sign")
        End If
        setstepcount(Form1.progresform_StepCount)
        setprogress(Form1.progresform_status)
        Timer_polestate.Start()
        ProgressBar.Value = 0


    End Sub

    Private Sub Button_oK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_ok.Click
        'MsgBox("cancle")
        Me.Close()
    End Sub

    Private Sub But_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_cancle.Click
        Dim message As String = "Are you sure you want to cancle?" + Constants.vbCrLf
        'this general message is not expected to display but may if for some 
        'reason the value of process is not set correctly

        Dim result As Windows.Forms.DialogResult
        If (Form1.progresform_process = "write") Then

            message = "Warning old data will NOT be restored" + Constants.vbCrLf
            message += "As a result The device will have a mixture of old and new data" + Constants.vbCrLf + Constants.vbCrLf
            message += "Are you sure you want to cancel sending data?" + Constants.vbCrLf

        End If
        If (Form1.progresform_process = "read") Then
            'progresform_process
            message = "Are you sure you want to cancel getting data?" + Constants.vbCrLf
        End If

        result = MsgBox(message, MsgBoxStyle.YesNo)
        If (result = Windows.Forms.DialogResult.Yes) Then

            Form1.progresform_cancel = True
            'mySerialPort.Close()
            'Throw New ArgumentException()
            'for now Im being lazy using arg exception instead of defining a cancle exception


            'But_cancle.Visible = False
            'But_ok.Visible = True
        End If

    End Sub

    Private Sub Timer_polestate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_polestate.Tick
        '        Dim progresform_status As String = "" 'set by read/write another tread,  timer in main thread then updates progress form
        '       Dim progresform_process As String = "" 'should be 'read' or 'write' 
        '      
        '     Dim progresform_updatestatus As Boolean = False 'set by read/write another thread,  timer in main thread then updates progress form
        '    Dim progresform_complete As Boolean = False 'set by read/write  thread,  timer in main thread then updates progress form
        '   Dim progresform_successful As Boolean = False 'set by read/write  thread,  timer in main thread then updates progress form
        '  Dim progresform_cancle As Boolean = False
        Form1.backgroundworkerdebugvalue = "g001"
        Timer_polestate.Stop()
        Static timeoutcounter As Int16 = 0

        setstepcount(Form1.progresform_StepCount)
        setprogress(Form1.progresform_status)
        If (Form1.progresform_updatestatus) Then
            ProgressBar.Increment(ProgressBar.Step)
            Form1.progresform_updatestatus = False
            timeoutcounter = 0
        End If
        If (Form1.progresform_complete) Then
            Timer_polestate.Stop()
            ProgressBar.Increment(ProgressBar.Step)
            Form1.progresform_status = ""
            If (Form1.progresform_AutoCloseAtCompletion) Then
                Form1.progresform_AutoCloseAtCompletion = False
                Me.Close()
            Else
                Form1.backgroundworkerdebugvalue = "gg1"
                But_cancle.Visible = False
                Form1.backgroundworkerdebugvalue = "gg2"
                But_ok.Visible = True
                Form1.backgroundworkerdebugvalue = "gg3"
                Return
            End If

        End If
        'If (timeoutcounter >= 197 And timeoutcounter < 200) Then

        '    Try
        '        Form1.mySerialPort.Close()
        '    Catch ex As Exception

        '    End Try

        '    Try
        '        Form1.mySerialPort.Open()
        '    Catch ex As Exception

        '    End Try

        'End If
        If (timeoutcounter > 200) Then


            If Form1.BGW_write_device.IsBusy Or Form1.BGW_read_device.IsBusy Then
                Dim message As String = "The " + Form1.progresform_process + " process seams to have frozen up" + Constants.vbCrLf
                message += "This is usually caused by unplugging the device" + Constants.vbCrLf
                message += "You may have to restart your computer before the comport will work again" + Constants.vbCrLf

                MsgBox(message)
                If Form1.BGW_write_device.IsBusy Then
                    Form1.BGW_write_device.Dispose()
                    Form1.BGW_write_device = New System.ComponentModel.BackgroundWorker

                    'Try
                    '    Form1.mySerialPort.Close()
                    '    Form1.mySerialPort.Open()

                    'Catch ex As Exception

                    'End Try
                    Form1.progresform_complete = True
                    setprogress(Form1.progresform_process + "process canceled due to error")
                ElseIf Form1.BGW_read_device.IsBusy Then
                    Form1.BGW_read_device.Dispose()
                    Form1.BGW_read_device = New System.ComponentModel.BackgroundWorker

                    'Try
                    '    Form1.mySerialPort.Close()
                    '    Form1.mySerialPort.Open()

                    'Catch ex As Exception

                    ' End Try
                    Form1.progresform_complete = True
                    setprogress(Form1.progresform_process + "process canceled due to error")
                ElseIf Form1.progresform_complete = True Then
                    MsgBox("Apparently the " + Form1.progresform_process + "resumed and completed while the previous dialog box was open")
                Else
                    MsgBox("There is a bugg in the program")

                End If

            Else
                Dim result As DialogResult
                Dim message As String = "the " + Form1.progresform_process + " process seams to have Terminated without completing" + Constants.vbCrLf
                message += "this is probably due to a programming bug"

                result = MsgBox(message)
                Form1.progresform_complete = True
                setprogress(Form1.progresform_process + "process terminated without completing")

                'If result = Windows.Forms.DialogResult.Retry Then

                '    If (Form1.progresform_process = "read") Then

                '        ProgressBar.Value = 0
                '        Form1.progresform_updatestatus = False
                '        timeoutcounter = 0
                '        Form1.BGW_read_device.RunWorkerAsync()
                '    ElseIf (Form1.progresform_process = "write") Then
                '        ProgressBar.Value = 0
                '        Form1.progresform_updatestatus = False
                '        timeoutcounter = 0
                '        Form1.BGW_write_device.RunWorkerAsync()
                '    Else
                '        message = "there is a bug in the program" + Constants.vbCrLf
                '        message += "The procees that is supposeed to be happening" + Constants.vbCrLf
                '        message += "is not correctly specified"


                '        MsgBox(message)

                '        setprogress(Form1.progresform_process + "process canceled due to error")
                '        Form1.progresform_complete = True
                '    End If
                'Else
                '    setprogress(Form1.progresform_process + "process terminated")
                '    Form1.progresform_complete = True
                'End If

            End If

            'If Form1.BGW_write_device.IsBusy Then

            '    Dim result As DialogResult
            '    Dim message As String = "the " + Form1.progresform_process + " process seams to have frozen up" + Constants.vbCrLf
            '    message += "you may have to restart your computer before the comport will work again" + Constants.vbCrLf
            '    message += "press 'abort' to terminate " + Form1.progresform_process + " process." + Constants.vbCrLf
            '    message += "press 'retry' to restart " + Form1.progresform_process + " process from beginning." + Constants.vbCrLf
            '    message += "press 'ignore' to wait and see if " + Form1.progresform_process + " process resumes."
            '    operationfreazeupdialog.Txt_message.Text = message
            '    operationfreazeupdialog.ShowDialog()

            '    result = operationfreazeupdialog.DialogResult

            '    If (result = Windows.Forms.DialogResult.Abort) Then
            '        Form1.BGW_write_device.Dispose()
            '        Form1.BGW_write_device = New System.ComponentModel.BackgroundWorker

            '        Try
            '            Form1.mySerialPort.Close()
            '            Form1.mySerialPort.Open()

            '        Catch ex As Exception

            '        End Try

            '        Form1.progresform_updatestatus = False
            '        setprogress(Form1.progresform_process + "process canceled")
            '        Form1.progresform_complete = True


            '    ElseIf (result = Windows.Forms.DialogResult.Retry) Then

            '        Form1.BGW_write_device.Dispose()
            '        Form1.BGW_write_device = New System.ComponentModel.BackgroundWorker

            '        Try
            '            Form1.mySerialPort.Close()
            '            Form1.mySerialPort.Open()

            '        Catch ex As Exception

            '        End Try

            '        ProgressBar.Value = 0
            '        Form1.progresform_updatestatus = False
            '        timeoutcounter = 0
            '        Form1.BGW_write_device.RunWorkerAsync()

            '    End If
            'ElseIf Form1.BGW_read_device.IsBusy Then
            '    Dim result As DialogResult
            '    Dim message As String = "the " + Form1.progresform_process + " process seams to have frozen up" + Constants.vbCrLf
            '    message += "you may have to restart your computer before the comport will work again" + Constants.vbCrLf
            '    message += "press 'abort' to terminate " + Form1.progresform_process + " process." + Constants.vbCrLf
            '    message += "press 'retry' to restart " + Form1.progresform_process + " process from beginning." + Constants.vbCrLf
            '    message += "press 'wait' to wait and see if " + Form1.progresform_process + " process resumes."
            '    operationfreazeupdialog.Txt_message.Text = message
            '    operationfreazeupdialog.ShowDialog()

            '    result = operationfreazeupdialog.DialogResult

            '    If (result = Windows.Forms.DialogResult.Abort) Then
            '        Form1.BGW_read_device.Dispose()
            '        Form1.BGW_read_device = New System.ComponentModel.BackgroundWorker

            '        Try
            '            Form1.mySerialPort.Close()
            '            Form1.mySerialPort.Open()

            '        Catch ex As Exception

            '        End Try

            '        Form1.progresform_updatestatus = False
            '        setprogress(Form1.progresform_process + "process canceled")
            '        Form1.progresform_complete = True


            '    ElseIf (result = Windows.Forms.DialogResult.Retry) Then

            '        Form1.BGW_read_device.Dispose()
            '        Form1.BGW_read_device = New System.ComponentModel.BackgroundWorker

            '        Try
            '            Form1.mySerialPort.Close()
            '            Form1.mySerialPort.Open()

            '        Catch ex As Exception

            '        End Try

            '        ProgressBar.Value = 0
            '        Form1.progresform_updatestatus = False
            '        timeoutcounter = 0
            '        Form1.BGW_read_device.RunWorkerAsync()

            '    Else
            '        'do nothing. counter will be set to 0 in next step
            '    End If


            timeoutcounter = 0
        Else
            timeoutcounter += 1
        End If
        Form1.backgroundworkerdebugvalue = "gg10"
        Timer_polestate.Start()
    End Sub

    Private Sub progress_form_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing


        Timer_polestate.Stop()
        Form1.showmainhelp()
    End Sub

    Private Sub But_ok_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_ok.VisibleChanged
        Form1.backgroundworkerdebugvalue = "gg11"
        If Timer_polestate.Enabled Then
            Form1.backgroundworkerdebugvalue = "gg12"
        Else
            Form1.backgroundworkerdebugvalue = "gg13"
        End If
    End Sub
End Class
