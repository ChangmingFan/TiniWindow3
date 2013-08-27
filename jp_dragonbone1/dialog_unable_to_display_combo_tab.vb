Public Class dialog_unable_to_display_combo_tab

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
      'Static storedkeywords As ArrayList = New ArrayList
        Static storedlinecount As Int16 = 0
        Static storedlinelength As Int16 = 0
      'Static storedframeparameters As ArrayList = New ArrayList
        'Static storedmetext As String = .Text
        'Static storedopenfilepath
        Static storedchange
        Static storedtrickcodingversion
        If flag = backupfileflags.saveCurrentState Then
            Dim loopcounter = 0
            storedlinecount = Form1.linecount
            storedlinelength = Form1.settings(Form1.settingsindex.linelength)
            'storedopenfilepath = Form1.userdata(Form1.userdataindex.OpenFilePath)
            storedtextdata.Clear()
            While loopcounter < Form1.textdata.Count
                storedtextdata.Add(Form1.textdata(loopcounter))
                loopcounter += 1
            End While

            loopcounter = 0
            storedtrickdata.Clear()

            While loopcounter < Form1.trickdata.Count
                storedtrickdata.Add(Form1.trickdata(loopcounter))
                loopcounter += 1
            End While

         'storedkeywords.Clear()
         'storedkeywords.Add(Form1.TBkw00.Text)
         'storedkeywords.Add(Form1.TBkw01.Text)
         'storedkeywords.Add(Form1.TBkw02.Text)
         'storedkeywords.Add(Form1.TBkw03.Text)
         'storedkeywords.Add(Form1.TBkw04.Text)
         'storedkeywords.Add(Form1.TBkw05.Text)
         'storedkeywords.Add(Form1.TBkw06.Text)
         'storedkeywords.Add(Form1.TBkw07.Text)
         'storedkeywords.Add(Form1.TBkw08.Text)
         'storedkeywords.Add(Form1.TBkw09.Text)

            storedchange = Form1.change
            storedtrickcodingversion = Form1.currenttrickcodingversion


         '     storedframeparameters.Clear()
         'loopcounter = 0
         'While loopcounter < 10
         '    storedframeparameters.Add(New ArrayList)
         '    loopcounter += 1
         'End While
         'storedframeparameters(0).add(Form1.NUDfc00.Minimum)
         'storedframeparameters(0).add(Form1.NUDfc00.Maximum)
         'storedframeparameters(0).add(Form1.NUDfc00.Increment)
         'storedframeparameters(0).add(Form1.NUDfc00.Value)

         'storedframeparameters(1).add(Form1.NUDfc01.Minimum)
         'storedframeparameters(1).add(Form1.NUDfc01.Maximum)
         'storedframeparameters(1).add(Form1.NUDfc01.Increment)
         'storedframeparameters(1).add(Form1.NUDfc01.Value)

         'storedframeparameters(2).add(Form1.NUDfc02.Minimum)
         'storedframeparameters(2).add(Form1.NUDfc02.Maximum)
         'storedframeparameters(2).add(Form1.NUDfc02.Increment)
         'storedframeparameters(2).add(Form1.NUDfc02.Value)

         'storedframeparameters(3).add(Form1.NUDfc03.Minimum)
         'storedframeparameters(3).add(Form1.NUDfc03.Maximum)
         'storedframeparameters(3).add(Form1.NUDfc03.Increment)
         'storedframeparameters(3).add(Form1.NUDfc03.Value)

         'storedframeparameters(4).add(Form1.NUDfc04.Minimum)
         'storedframeparameters(4).add(Form1.NUDfc04.Maximum)
         'storedframeparameters(4).add(Form1.NUDfc04.Increment)
         'storedframeparameters(4).add(Form1.NUDfc04.Value)

         'storedframeparameters(5).add(Form1.NUDfc05.Minimum)
         'storedframeparameters(5).add(Form1.NUDfc05.Maximum)
         'storedframeparameters(5).add(Form1.NUDfc05.Increment)
         'storedframeparameters(5).add(Form1.NUDfc05.Value)

         'storedframeparameters(6).add(Form1.NUDfc06.Minimum)
         'storedframeparameters(6).add(Form1.NUDfc06.Maximum)
         'storedframeparameters(6).add(Form1.NUDfc06.Increment)
         'storedframeparameters(6).add(Form1.NUDfc06.Value)

         'storedframeparameters(7).add(Form1.NUDfc07.Minimum)
         'storedframeparameters(7).add(Form1.NUDfc07.Maximum)
         'storedframeparameters(7).add(Form1.NUDfc07.Increment)
         'storedframeparameters(7).add(Form1.NUDfc07.Value)

         'storedframeparameters(8).add(Form1.NUDfc08.Minimum)
         'storedframeparameters(8).add(Form1.NUDfc08.Maximum)
         'storedframeparameters(8).add(Form1.NUDfc08.Increment)
         'storedframeparameters(8).add(Form1.NUDfc08.Value)

         'storedframeparameters(9).add(Form1.NUDfc09.Minimum)
         'storedframeparameters(9).add(Form1.NUDfc09.Maximum)
         'storedframeparameters(9).add(Form1.NUDfc09.Increment)
         'storedframeparameters(9).add(Form1.NUDfc09.Value)

            backupavailable = True
        ElseIf flag = backupfileflags.restoreStoredState Then

            If Not backupavailable Then
                MsgBox("error - attempt to restore unsaved data")
                Return
            End If
            Form1.databeinginternallymanipulated = True
            Dim loopcounter = 0
            Form1.currentlychanginglinecount = True
            Form1.linecount = storedlinecount

            Form1.NUD_linestab_liinecounts.Value = storedlinecount
            Form1.currentlychanginglinecount = False

            Form1.currentlychanginglinelength = True
            Form1.settings(Form1.settingsindex.linelength) = storedlinelength
            Form1.NUD_linestab_liinecounts.Value = storedlinecount
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

         'Form1.TBkw00.Text = storedkeywords(0)
         'Form1.TBkw01.Text = storedkeywords(1)
         'Form1.TBkw02.Text = storedkeywords(2)
         'Form1.TBkw03.Text = storedkeywords(3)
         'Form1.TBkw04.Text = storedkeywords(4)
         'Form1.TBkw05.Text = storedkeywords(5)
         'Form1.TBkw06.Text = storedkeywords(6)
         'Form1.TBkw07.Text = storedkeywords(7)
         'Form1.TBkw08.Text = storedkeywords(8)
         'Form1.TBkw09.Text = storedkeywords(9)



         'Form1.NUDfc00.Minimum = storedframeparameters(0)(0)
         'Form1.NUDfc00.Maximum = storedframeparameters(0)(1)
         'Form1.NUDfc00.Increment = storedframeparameters(0)(2)
         'Form1.NUDfc00.Value = storedframeparameters(0)(3)

         'Form1.NUDfc01.Minimum = storedframeparameters(1)(0)
         'Form1.NUDfc01.Maximum = storedframeparameters(1)(1)
         'Form1.NUDfc01.Increment = storedframeparameters(1)(2)
         'Form1.NUDfc01.Value = storedframeparameters(1)(3)


         'Form1.NUDfc02.Minimum = storedframeparameters(2)(0)
         'Form1.NUDfc02.Maximum = storedframeparameters(2)(1)
         'Form1.NUDfc02.Increment = storedframeparameters(2)(2)
         'Form1.NUDfc02.Value = storedframeparameters(2)(3)


         'Form1.NUDfc03.Minimum = storedframeparameters(3)(0)
         'Form1.NUDfc03.Maximum = storedframeparameters(3)(1)
         'Form1.NUDfc03.Increment = storedframeparameters(3)(2)
         'Form1.NUDfc03.Value = storedframeparameters(3)(3)

         'Form1.NUDfc04.Minimum = storedframeparameters(4)(0)
         'Form1.NUDfc04.Maximum = storedframeparameters(4)(1)
         'Form1.NUDfc04.Increment = storedframeparameters(4)(2)
         'Form1.NUDfc04.Value = storedframeparameters(4)(3)

         'Form1.NUDfc05.Minimum = storedframeparameters(5)(0)
         'Form1.NUDfc05.Maximum = storedframeparameters(5)(1)
         'Form1.NUDfc05.Increment = storedframeparameters(5)(2)
         'Form1.NUDfc05.Value = storedframeparameters(5)(3)

         'Form1.NUDfc06.Minimum = storedframeparameters(6)(0)
         'Form1.NUDfc06.Maximum = storedframeparameters(6)(1)
         'Form1.NUDfc06.Increment = storedframeparameters(6)(2)
         'Form1.NUDfc06.Value = storedframeparameters(6)(3)

         'Form1.NUDfc07.Minimum = storedframeparameters(7)(0)
         'Form1.NUDfc07.Maximum = storedframeparameters(7)(1)
         'Form1.NUDfc07.Increment = storedframeparameters(7)(2)
         'Form1.NUDfc07.Value = storedframeparameters(7)(3)

         'Form1.NUDfc08.Minimum = storedframeparameters(8)(0)
         'Form1.NUDfc08.Maximum = storedframeparameters(8)(1)
         'Form1.NUDfc08.Increment = storedframeparameters(8)(2)
         'Form1.NUDfc08.Value = storedframeparameters(8)(3)

         'Form1.NUDfc09.Minimum = storedframeparameters(9)(0)
         'Form1.NUDfc09.Maximum = storedframeparameters(9)(1)
         'Form1.NUDfc09.Increment = storedframeparameters(9)(2)
         'Form1.NUDfc09.Value = storedframeparameters(9)(3)


            Form1.refresh_available_lines()
            Form1.change = storedchange




            Form1.currenttrickcodingversion = storedtrickcodingversion
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
            Button1.Text = "Discard recent changes and switch to standard tab"
        Else
            Button1.Enabled = False
            Button1.Text = "Unable to discard recent changes and switch to standard tab"
        End If

    End Sub
End Class