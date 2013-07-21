Module Mod_textboxfunctions





    Public Enum txtbox_cursor_position
        _begin_absolute
        _begin_afterspace
        _end_absolute
        _end_beforespace


    End Enum

    Public Enum txtbox_alignment_type
        _left
        _right
        _center
        _none
        _auto
    End Enum

    Public Sub txtbox_positioncurser(ByRef _txtbox As TextBox, ByVal cursor_pos As Int16)
        'this function can not be called from with in a textbox enter event
        'becaue the cursor postion will be reset after this function completes

        If cursor_pos = txtbox_cursor_position._begin_absolute Then
            _txtbox.SelectionStart = 0

        ElseIf cursor_pos = txtbox_cursor_position._begin_afterspace Then
            _txtbox.SelectionStart = _txtbox.Text.Length - _txtbox.Text.TrimStart.Length
        ElseIf cursor_pos = txtbox_cursor_position._end_absolute Then

            _txtbox.SelectionStart = _txtbox.Text.Length
        ElseIf cursor_pos = txtbox_cursor_position._end_beforespace Then

            _txtbox.SelectionStart = _txtbox.Text.TrimEnd.Length



        End If



    End Sub


    Public Sub txtbox_aligntext(ByRef txtbox As Object, ByVal aligment_type As Int16, Optional ByVal txtbox_size As Int16 = -1, Optional ByVal padright As Boolean = True, Optional ByVal fixcursor As Boolean = True)
        'with left alignment padright means fill in spaces
        'with central allignment padright means that if it is imposible to exaclty center sign place the extra space on right


        Dim oldleadingspace As Int16 = txtbox.Text.Length - txtbox.Text.TrimStart.Length  'used for fixing cursor
        Dim oldcursorposition As Int16 = txtbox.SelectionStart

        If txtbox_size < 0 Then
            txtbox_size = Form1.settings(Form1.settingsindex.linelength)
        End If

        Dim text As String = txtbox.Text.Trim
        If aligment_type = txtbox_alignment_type._left Then
            If padright Then
                text = text.PadRight(txtbox_size)
            End If
            txtbox.Text = text
        ElseIf aligment_type = txtbox_alignment_type._right Then
            text = text.PadLeft(txtbox_size)
            txtbox.Text = text
        ElseIf aligment_type = txtbox_alignment_type._center Then

            padright = False
            While text.Length < txtbox_size
                If padright Then
                    text = text + " "
                Else
                    text = " " + text
                End If
                padright = Not padright
            End While
            txtbox.Text = text

        ElseIf aligment_type = txtbox_alignment_type._none Then
            'do nothing

        Else
            MsgBox("invalid alignment typed passed to txtbox_aligntext " + Constants.vbCrLf + "please report this bug")
        End If

        Dim newleadingspace As Int16 = txtbox.Text.Length - txtbox.Text.TrimStart.Length  'used for fixing cursor


        If fixcursor Then
            If oldcursorposition + newleadingspace - oldleadingspace > 0 Then
                txtbox.SelectionStart = oldcursorposition + newleadingspace - oldleadingspace
            Else
                txtbox.SelectionStart = 0
            End If


        End If

    End Sub
End Module
