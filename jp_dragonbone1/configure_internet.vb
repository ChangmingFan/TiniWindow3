Public Class configure_internet
    Public Enum connectiontype
        TiniWindow_is_TCPserver
        TiniWindow_is_TCPclient
        Use_TiniLite_Server
    End Enum
    Private Structure connection
        Dim name As String
        Dim type As connectiontype
        Dim port As Int16
        Dim ip As String
        Dim company As String
        Dim username As String
        Dim password As String
        Dim enabled As Boolean

    End Structure
    Public Enum enabled_state
        enabled = True
        disabled = False
        make_enabled_when_valid_config = 3

    End Enum

    Public myconnections As ArrayList = New ArrayList 'of connection

    Dim oldconnections As ArrayList = New ArrayList
    'so they can be restored if user clicks cancel
    Dim formloaded As Boolean = False
    Private Sub configure_internet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        CB_connection_name.Items.Add("connection 1")
        CB_connection_name.SelectedIndex = 0
        Dim connection1 As connection = New connection
        connection1.name = "connection 1"
        connection1.type = connectiontype.Use_TiniLite_Server
        connection1.ip = "184.168.86.30"
        connection1.port = "2050"
        connection1.enabled = False 'store as false in case they click cancle but then click true
        myconnections.Add(connection1)
        formloaded = True

        CheckBox1.Checked = True

        validate_current_screen()
    End Sub

    Private Sub Txt_port_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_port.KeyPress

        'only numbers allowed in here

        If e.KeyChar = "o" Or e.KeyChar = "O" Then
            e.KeyChar = "0"
        End If


        Dim CONTROL_V As Char = Chr(22)
        Dim CONTROL_X As Char = Chr(24)
        Dim CONTROL_C As Char = Chr(3)
        Dim CONTROL_A As Char = Chr(1)
        Dim BACKSPACE As Char = Chr(8)

        If e.KeyChar = CONTROL_V Or e.KeyChar = CONTROL_X Or e.KeyChar = CONTROL_C Or e.KeyChar = CONTROL_A Or e.KeyChar = BACKSPACE Then
            Return
        End If
        If e.KeyChar >= "0" And e.KeyChar <= "9" Then
            Return
        End If

        MsgBox(Asc(e.KeyChar))
        'exhuasted all valid keys
        e.Handled = True
        Beep()

    End Sub
    Private Sub savecurrentscreendata()
        Dim connection_index = CB_connection_name.SelectedIndex
        Dim thisconnection As connection = Me.myconnections(connection_index)
        Try
            thisconnection.port = Convert.ToInt16(Me.Txt_port.Text)
        Catch ex As Exception
            'usually happens if port textbox is blank

            thisconnection.port = Nothing
        End Try
        If Me.RB_use_Tinilite_server.Checked Then
            thisconnection.ip = Txt_IP.Text
            thisconnection.type = connectiontype.Use_TiniLite_Server
            thisconnection.company = Me.txt_company.Text
            thisconnection.username = Me.txt_username.Text
            thisconnection.password = Me.txt_password.Text
        ElseIf Me.RB_client.Checked Then


            thisconnection.ip = Txt_IP.Text
            thisconnection.type = connectiontype.TiniWindow_is_TCPclient

        ElseIf Me.RB_server.Checked Then
            thisconnection.type = connectiontype.TiniWindow_is_TCPserver
        Else
            MsgBox("error - programmer neglected to account for this option!")
        End If

        If Me.CheckBox1.Checked Then
            If currentscreendatavalid() Then
                thisconnection.enabled = enabled_state.enabled
            Else
                thisconnection.enabled = enabled_state.make_enabled_when_valid_config
            End If
        Else
            thisconnection.enabled = enabled_state.disabled
        End If

        Me.myconnections(connection_index) = thisconnection

    End Sub
    Private Sub commen_connection_data_change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_port.TextChanged, CheckBox1.CheckedChanged, txt_username.TextChanged, txt_password.TextChanged, txt_company.TextChanged
        If Not formloaded Then
            Return
        End If

        savecurrentscreendata()
        validate_current_screen()

    End Sub

    Private Sub But_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_ok.Click
        'no need to do anything more
        'we do not need to restore old data
        'the old data array will be cleared next time this form becomes visible


        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub validate_current_screen()

        If Not formloaded Then
            Return
        End If

        If Me.Txt_port.Text = "" Then
            Lbl_port.ForeColor = Color.Red



        Else
            Lbl_port.ForeColor = Color.Black
            font_functions.changestyle(CheckBox1.Font, FontStyle.Regular)



        End If


        If Lbl_ip.Visible Then
            If Txt_IP.Text = "" Then
                Lbl_ip.ForeColor = Color.Red
            ElseIf Txt_IP.Text.Split(".").Length <> 4 Then
                Lbl_ip.ForeColor = Color.Orange
            Else
                Lbl_ip.ForeColor = Color.Black
            End If

        Else
            Lbl_ip.ForeColor = Color.Black

        End If

        If Lbl_ip.ForeColor = Color.Red Or Lbl_port.ForeColor = Color.Red Then
            font_functions.changestyle(CheckBox1.Font, FontStyle.Italic)
            CheckBox1.ForeColor = Color.Gray
            Dim connectionindex As Int16 = CB_connection_name.SelectedIndex
            Dim thisconnection As connection = Me.myconnections(connectionindex)
            If thisconnection.enabled = enabled_state.enabled Then
                thisconnection.enabled = enabled_state.make_enabled_when_valid_config
            End If

        Else

            CheckBox1.ForeColor = Color.Black
            Dim connectionindex As Int16 = CB_connection_name.SelectedIndex
            Dim thisconnection As connection = Me.myconnections(connectionindex)

            If thisconnection.enabled = enabled_state.make_enabled_when_valid_config Then
                thisconnection.enabled = enabled_state.enabled
            End If
        End If
    End Sub
    Private Function currentscreendatavalid() As Boolean
        If Me.Txt_port.Text = "" Then
            Return False
        End If

        If Me.RB_client.Checked And Txt_IP.Text = "" Then
            Return False
        End If

        'no problems so must be ok
        Return True
    End Function
    Private Sub backupcurrentdata()

        oldconnections = New ArrayList
        For Each thisconnection As connection In myconnections
            Dim backupconnection As connection = thisconnection
            oldconnections.Add(backupconnection)
        Next


        'so 
    End Sub

    Private Sub restorebackedupdata()

        myconnections = New ArrayList
        For Each thisconnection As connection In oldconnections
            Dim backupconnection As connection = thisconnection
            myconnections.Add(backupconnection)
        Next



    End Sub


    Private Sub but_apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_apply.Click
        backupcurrentdata()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        restorebackedupdata()

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub configure_internet_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            'back up old data first thing when form become visible in case user cancels changes

            backupcurrentdata()

            refreshScreen()

        End If
    End Sub

    Private Sub refreshScreen()
        Dim thisconnection As connection = myconnections(CB_connection_name.SelectedIndex)
        If thisconnection.port = Nothing Then
            Txt_port.Text = ""
        Else
            Txt_port.Text = thisconnection.port
        End If
        If thisconnection.enabled = enabled_state.disabled Then
            Me.CheckBox1.Checked = False
        Else
            Me.CheckBox1.Checked = True
        End If

        Me.validate_current_screen()

    End Sub

    Private Sub RB_common_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_server.CheckedChanged, RB_client.CheckedChanged, RB_use_Tinilite_server.CheckedChanged

        If Not formloaded Then
            Return
        End If
        If RB_server.Checked Then
            Pan_advance_config.Visible = True
            Lbl_ip.Visible = False
            Txt_IP.Visible = False
            CB_show_advanced.Visible = False
        ElseIf RB_client.Checked Then
            Pan_advance_config.Visible = True
            Lbl_ip.Visible = True
            Txt_IP.Visible = True
            CB_show_advanced.Visible = False
        ElseIf Me.RB_use_Tinilite_server.Checked Then
            Lbl_ip.Visible = True
            Txt_IP.Visible = True
            CB_show_advanced.Visible = True
            If CB_show_advanced.Checked Then
                Pan_advance_config.Visible = True
            Else
                Pan_advance_config.Visible = False
            End If
        Else
            MsgBox("error this option not accounted for")
        End If

        validate_current_screen()

    End Sub

    Private Sub Txt_IP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_IP.TextChanged
        If Not formloaded Then
            Return
        End If
        validate_current_screen()
    End Sub



    
    Private Sub CB_connection_name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim control_c As Char = Chr(3)

        If e.KeyChar = control_c Then
            'the only allowed keyboard action
            Return
        End If
        Beep()
        e.Handled = False

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_show_advanced.CheckedChanged
        If CB_show_advanced.Checked Then
            Pan_advance_config.Visible = True
        Else
            If RB_use_Tinilite_server.Checked Then
                Pan_advance_config.Visible = False
            End If
        End If
    End Sub
End Class