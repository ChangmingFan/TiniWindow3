Public Class line_configuration

    Dim formloaded As Boolean = False
    Public Enum add_or_truncate_position
        _none
        _end
        _beginning
        _prompt
    End Enum


    Dim linesposition As Int16

    Dim charposition As Int16
    Dim abletoviewfileinsimpletab As Boolean = False

    Dim oldlinelength As Int16
    Dim oldlinecount As Int16


    Private Sub line_configurationform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        formloaded = False

        Form1.cancelopenfile(Form1.cancelopenfileflags.saveCurrentState) 'saves current file so that changes can be undone

        abletoviewfileinsimpletab = Form1.possible_to_view_file_in_easytab()

        If abletoviewfileinsimpletab Then
            CB_preservesimpletab.Visible = True
        Else
            CB_preservesimpletab.Visible = False
        End If


        oldlinecount = Form1.linecount
        'Num_linecount.Value = Form1.linecount
        oldlinelength = Form1.settings(Form1.settingsindex.linelength)
        Num_linelength.Value = Form1.settings(Form1.settingsindex.linelength)

        formloaded = True

    End Sub

    'Private Sub Num_linecount_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Num_linecount.Value = Form1.linecount Then
    '        Panel_linesRB.Visible = False
    '        If abletoviewfileinsimpletab Then
    '            CB_preservesimpletab.Visible = True
    '        End If

    '    ElseIf Num_linecount.Value > Form1.linecount Then
    '        Panel_linesRB.Visible = True
    '        CB_preservesimpletab.Visible = False
    '    ElseIf Num_linecount.Value < Form1.linecount Then
    '        Panel_linesRB.Visible = True
    '        CB_preservesimpletab.Visible = False
    '    Else
    '        MsgBox("bug1")

    '    End If


    'End Sub

    'Private Function get_line_truncate_postition() As Int16
    '    Dim linesposition As Int16
    '    If Panel_linesRB.Visible Then

    '        If RB_lines_end.Checked Then
    '            linesposition = add_or_truncate_position._end
    '        ElseIf RB_lines_beg.Checked Then
    '            linesposition = add_or_truncate_position._beginning
    '        Else
    '            MsgBox("bug5")
    '        End If
    '    Else
    '        linesposition = add_or_truncate_position._none
    '    End If
    '    Return linesposition

    'End Function
    Private Function get_char_truncate_postition() As Int16
        Dim charposition As Int16
        If Pan_charsRB.Visible Then

            If RB_chars_end.Checked Then
                charposition = add_or_truncate_position._end
            ElseIf RB_chars_beg.Checked Then
                charposition = add_or_truncate_position._beginning
            Else
                MsgBox("bug5")
            End If
        Else
            charposition = add_or_truncate_position._none
        End If
        Return charposition

    End Function


    Private Sub Num_linelength_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num_linelength.ValueChanged

        If CB_preservesimpletab.Checked Then
            'If Not Form1.set_linelength(Num_linelength.Value, get_line_truncate_postition(), True) Then
            '    MsgBox("error test set of linelngth failed in numlenght value change event")
            'End If
            'Num_linecount.Value = Form1.linecount


            'If Not Form1.set_linelength(oldlinelength, get_line_truncate_postition(), True) Then
            '    MsgBox("error setting old linelngth failed in numlenght value change event")
            'End If
            'Form1.cancelopenfile(Form1.cancelopenfileflags.restoreStoredState)



        End If
        If Num_linelength.Value >= Form1.settings(Form1.settingsindex.linelength) Then
            Pan_charsRB.Visible = False
        ElseIf Num_linelength.Value < Form1.settings(Form1.settingsindex.linelength) Then
            Pan_charsRB.Visible = True

        Else
            MsgBox("bug2")

        End If

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        'If CB_preservesimpletab.Checked Then
        '    If Not Form1.set_linelength(Num_linelength.Value, get_char_truncate_postition(), True) Then

        '        MsgBox("bug - error setting linelength in ok button press event")
        '    End If

        'Else
        '    If Not Form1.set_linelength(Num_linelength.Value, get_char_truncate_postition(), False) Then

        '        MsgBox("bug - error setting linelength in ok button press event")
        '    End If
        '    If Not Form1.set_linecount(Num_linecount.Value, get_line_truncate_postition()) Then

        '        MsgBox("bug - error setting linecount in ok button press event")
        '    End If


        'End If

        Form1.refresh_pan_morelines()
        Me.Close()

        ''set line length
        'If Pan_charsRB.Visible Then
        '    If RB_chars_end.Checked Then
        '        charposition = add_or_truncate_position._end
        '    ElseIf RB_chars_beg.Checked Then
        '        charposition = add_or_truncate_position._beginning
        '    End If
        'Else
        '    charposition = add_or_truncate_position._none
        'End If

        ''MsgBox(charposition)

        'If Not Form1.set_linelength(Num_linelength.Value, charposition, False) Then

        '    'if setting line length is canceed

        '    'keep this form open
        '    Return

        'End If




        ''set line count
        ''Me.DialogResult = Windows.Forms.DialogResult.OK

        'If Panel_linesRB.Visible Then

        '    If RB_lines_end.Checked Then
        '        linesposition = add_or_truncate_position._end
        '    ElseIf RB_lines_beg.Checked Then
        '        linesposition = add_or_truncate_position._beginning
        '    Else
        '        MsgBox("bug5")
        '    End If
        'Else
        '    linesposition = add_or_truncate_position._none
        'End If

        'If Not Form1.set_linecount(Num_linecount.Value, linesposition) Then

        '    'if setting line count is canceled, keep this form open
        '    Form1.cancelopenfile(Form1.cancelopenfileflags.restoreStoredState)
        '    Return

        'End If



        'Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'close without changing anything

        Form1.cancelopenfile(Form1.cancelopenfileflags.restoreStoredState) 'restores original values
        Me.Close()
    End Sub

    Private Sub line_configuration_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = False
    End Sub

    Private Sub CB_preservesimpletab_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_preservesimpletab.CheckedChanged

        'Num_linecount.Enabled = Not CB_preservesimpletab.Checked



    End Sub
End Class