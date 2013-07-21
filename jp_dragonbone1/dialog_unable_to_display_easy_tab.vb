Public Class dialog_unable_to_display_easy_tab

    Dim backupavailable As Boolean = False
    Public Enum backupfileflags
        restoreStoredState
        saveCurrentState
        clear 'to save memory when not needed

    End Enum
    'cancelopenfil(cancelopenfileflags.)

    Public Sub backupfile(ByVal flag As Int16)
        Static storedtextdata As ArrayList = New ArrayList
        Static storedtrickdata As ArrayList = New ArrayList

        Static storedlinecount As Int16 = 0
        Static storedlinelength As Int16 = 0

        'Static storedmetext As String = .Text
        'Static storedopenfilepath
        Static storedchange
        Static storedtrickcodingversion
        If flag = backupfileflags.saveCurrentState Then
            Dim loopcounter = 0
            storedlinecount = Form1.linecount
            storedlinelength = Form1.settings(Form1.settingsindex.linelength)
            'storedopenfilepath = Form1.userdata(Form1.userdataindex.OpenFilePath)
            storedtextdata = New ArrayList
            While loopcounter < Form1.textdata.Count
                storedtextdata.Add(Form1.textdata(loopcounter))
                loopcounter += 1
            End While

            loopcounter = 0
            storedtrickdata = New ArrayList

            While loopcounter < Form1.trickdata.Count
                storedtrickdata.Add(Form1.trickdata(loopcounter))
                loopcounter += 1
            End While
            storedchange = Form1.change
            storedtrickcodingversion = Form1.currenttrickcodingversion
            backupavailable = True
        ElseIf flag = backupfileflags.restoreStoredState Then
            Form1.databeinginternallymanipulated = True
            If Not backupavailable Then
                MsgBox("error - attempt to restore unsaved data")
                Return
            End If
            Dim loopcounter = 0
            Form1.currentlychanginglinecount = True
            Form1.linecount = storedlinecount

            Form1.NUD_linestab_liinecounts.Value = storedlinecount
            Form1.currentlychanginglinecount = False

            Form1.currentlychanginglinelength = True
            Form1.settings(Form1.settingsindex.linelength) = storedlinelength
            Form1.NUD_linestab_liinecounts.Value = storedlinelength
            Form1.NUD_cardcount_easytab.Value = storedlinelength
            Form1.currentlychanginglinelength = False
            'LINELENGTH = storedlinelength
            'Form1.userdata(Form1.userdataindex.OpenFilePath) = storedopenfilepath
            Form1.textdata = New ArrayList
            While loopcounter < storedtextdata.Count
                Form1.textdata.Add(storedtextdata(loopcounter))
                loopcounter += 1
            End While

            loopcounter = 0
            Form1.trickdata = New ArrayList

            While loopcounter < storedtrickdata.Count
                Form1.trickdata.Add(storedtrickdata(loopcounter))
                loopcounter += 1
            End While

            Form1.currenttrickcodingversion = storedtrickcodingversion
            Form1.change = storedchange

            Form1.refresh_available_lines()
            Form1.databeinginternallymanipulated = False
        ElseIf flag = backupfileflags.clear Then

            storedtextdata.Clear()
            storedtrickdata.Clear()
            backupavailable = False
        End If

    End Sub








    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes

        Me.Close()

    End Sub

    Private Sub dialog_unable_to_display_simple_tab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New System.Drawing.Point(Form1.Location.X - Me.Width - 10, 20)
        If backupavailable Then
            Button1.Enabled = True
            Lbl_discardchanges.Text = "Discard recent changes and switch to basic tab"
            'Button1.Text = "Discard recent changes and switch to basic tab"
            'discard changes made on this tab
        Else
            Button1.Enabled = False
            Lbl_discardchanges.Text = "this option not currently available"
            'Button1.Text = "Unable to discard recent changes and switch to basic tab"
        End If

    End Sub
End Class