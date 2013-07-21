Public Class mymsg
    'version 1.20080822



    Public returnvalue As ArrayList
    Private checkboxes As ArrayList = New ArrayList
    Private radiobuttons As ArrayList = New ArrayList
    Private inputs As ArrayList = New ArrayList
    Private inputfilters As ArrayList = New ArrayList
    Private labels As ArrayList = New ArrayList
    Private allowtextchange As Boolean = False

    Const WIDTHOFCHARACTER As Int16 = 7
    Const charsInThinistWindow As Int16 = 14
    Const MINIMUMFORMWIDTH As Int16 = 124
    Const MINIMUMFORMHEIGHT As Int16 = 38
    Const CONTROLS_LEFT_MARGIN As Int16 = 0
    Const CONTROLS_VERTICAL_SPACE As Int16 = 7

    Public Enum parameterArrayIndex
        ControllType = 0
        ControllValue = 1
        ControllIdentifier = 2
    End Enum
    Public Enum returnArrayIndex
        button = 0
        checkboxes = 1
        inputs = 2
        radiobuttons = 3
    End Enum

    Public Enum returnArraySecondDimention
        index = 0
        value = 1
        identifyer = 2
    End Enum





    'Enum stringinfo
    '    lineCount = 0
    '    longestLineLength = 1

    'End Enum
    Enum lineTerminator
        lF
        cR
        crlf
        endOfString
    End Enum
    Public Function showform(ByVal prompt As String, ByRef controlls As ArrayList, ByVal width As Int16, ByVal height As Int16) As ArrayList
        setsize(width, height)
        Return showform(prompt, controlls)
    End Function
    Public Function showform(ByVal prompt As String, ByRef controlls As ArrayList) As ArrayList
        Dim restorevalue = Form1.databeinginternallymanipulated
        Form1.databeinginternallymanipulated = False
        setsize(MINIMUMFORMWIDTH, MINIMUMFORMHEIGHT)
        If initialize(prompt, controlls) Then
            Me.ShowDialog()
            Form1.databeinginternallymanipulated = restorevalue
            Return returnvalue

        Else

            Form1.databeinginternallymanipulated = restorevalue
            Return New ArrayList
        End If

        
    End Function


    Private Sub clearform()
        Dim i As Int16 = 0
        While i < checkboxes.Count
            checkboxes(i).Dispose()
            i += 1
        End While
        i = 0
        While i < radiobuttons.Count
            radiobuttons(i).Dispose()
            i += 1
        End While
        i = 0
        While i < inputs.Count
            inputs(i).Dispose()
            i += 1
        End While

        i = 0
        While i < labels.Count
            labels(i).Dispose()
            i += 1
        End While

        Button0.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False

        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button17.Visible = False
        Button18.Visible = False
        Button19.Visible = False
        Button20.Visible = False
        Button21.Visible = False
        Button22.Visible = False
        Button23.Visible = False
        Button24.Visible = False
        Button25.Visible = False

    End Sub

    'Private Function getstringinfo(ByVal prompt As String) As ArrayList
    '    Dim returnvalue As ArrayList = New ArrayList
    '    returnvalue.Add(0) 'linecount
    '    returnvalue.Add(0) 'longestLineLength
    '    While prompt.Length > 0
    '        Dim crindex As Int16 = prompt.IndexOf(Constants.vbCr)
    '        Dim lfindex As Int16 = prompt.IndexOf(Constants.vbLf)
    '        Dim usedindex As Int16
    '        If crindex < 0 And lfindex < 0 Then
    '            usedindex = prompt.Length - 1
    '        ElseIf crindex < lfindex And crindex <> -1 Then
    '            usedindex = crindex
    '        Else
    '            usedindex = lfindex
    '        End If

    '        If returnvalue(stringinfo.longestLineLength) < usedindex Then
    '            returnvalue(stringinfo.longestLineLength) = usedindex
    '        End If

    '        prompt = prompt.Substring(usedindex + 1).TrimStart(Constants.vbCrLf)


    '    End While
    '    'MsgBox(returnvalue)


    '    Return returnvalue
    'End Function
    Private Function countLines(ByVal prompt As String) As Int16
        'this function must be called AFTER the width of the form is determined 
        'constant.vbcr makes a new line only if continuing same line extend beyond form

        '10/08/08 temporarily disabled to get TiniWindow working quickly
        Return 3
        Dim mylineterminator As Int16

        Dim linecount As Int16 = 0
        While prompt.Length > 0
            Dim continueloop As Boolean = True
            Dim firsttimethroughloop = True

            Dim crindex As Int16 = 0
            Dim lfindex As Int16 = 0
            Dim usedindex As Int16 = 0

            Dim noncountedchars = 0
            While continueloop

                'cr only results in newline if concantonating 
                'lines would result in word wrap

                'find both of these starting from 1 char past last cr
                'first time through loop this starts from 
                'begining of string (position 0)
                'value of crindex must be reset last in this list 
                If crindex = -1 Then
                    crindex = 0
                End If
                lfindex = prompt.IndexOf(Constants.vbLf, usedindex + 1)
                crindex = prompt.IndexOf(Constants.vbCr, usedindex + 1)


                If crindex < 0 And lfindex < 0 Then
                    'usedindex += prompt.Length - 1
                    mylineterminator = lineTerminator.endOfString
                    'continueWithCR = False
                ElseIf crindex < lfindex Then
                    If crindex = -1 Then
                        'usedindex += lfindex
                        mylineterminator = lineTerminator.lF
                        'continueWithCR = False
                    ElseIf lfindex - crindex = 1 Then
                        mylineterminator = lineTerminator.crlf
                    Else
                        'usedindex += crindex
                        mylineterminator = lineTerminator.cR
                        'continueWithCR = True
                    End If
                Else
                    If lfindex = -1 Then
                        'usedindex += crindex
                        mylineterminator = lineTerminator.cR
                        'continueWithCR = True
                    Else
                        'usedindex += lfindex
                        mylineterminator = lineTerminator.lF
                        'continueWithCR = False
                    End If

                End If

                If firsttimethroughloop Then
                    If mylineterminator = lineTerminator.cR Then
                        noncountedchars += 1
                        'contitnue loop
                        usedindex = crindex
                        continueloop = True

                    ElseIf mylineterminator = lineTerminator.lF Then
                        noncountedchars += 1
                        'contitnue loop
                        usedindex = lfindex
                        continueloop = True



                    ElseIf mylineterminator = lineTerminator.crlf Then

                        noncountedchars += 2
                        usedindex = lfindex
                        continueloop = False

                    ElseIf mylineterminator = lineTerminator.endOfString Then

                        noncountedchars -= 1
                        usedindex = prompt.Length - 1
                        continueloop = False

                    Else
                        MsgBox("bugg")
                        Return -1
                    End If
                    firsttimethroughloop = False

                Else 'sebsequent times through loop
                    Dim lastlinelength As Int16 = usedindex Mod (charsInThinistWindow + (Me.Width - MINIMUMFORMWIDTH) / WIDTHOFCHARACTER)

                    If mylineterminator = lineTerminator.cR Then

                        If MINIMUMFORMWIDTH + (lastlinelength + (crindex - usedindex) - charsInThinistWindow) * WIDTHOFCHARACTER > Me.Width Then
                            'process using only previous time trough loop  
                            continueloop = False
                        Else
                            'add this time through loop and continue loop
                            noncountedchars += 1
                            usedindex = crindex
                            continueloop = True
                        End If



                    ElseIf mylineterminator = lineTerminator.lF Then
                        If MINIMUMFORMWIDTH + (lastlinelength + (lfindex - usedindex) - charsInThinistWindow) * WIDTHOFCHARACTER > Me.Width Then
                            'process using only previous time trough loop  
                            continueloop = False
                        Else
                            'add this time through loop and continue loop
                            noncountedchars += 1
                            usedindex = lfindex
                            continueloop = True
                        End If


                    ElseIf mylineterminator = lineTerminator.crlf Then
                        If MINIMUMFORMWIDTH + (lastlinelength + (lfindex - usedindex) - charsInThinistWindow) * WIDTHOFCHARACTER > Me.Width Then
                            'process using only previous time trough loop  
                            continueloop = False
                        Else
                            'add this time through loop then process
                            noncountedchars += 2
                            usedindex = lfindex
                            continueloop = False
                        End If

                    ElseIf mylineterminator = lineTerminator.endOfString Then

                        If MINIMUMFORMWIDTH + (lastlinelength + (prompt.Length - 1 - usedindex) - charsInThinistWindow) * WIDTHOFCHARACTER > Me.Width Then
                            'process using only previous time trough loop  
                            continueloop = False
                        Else
                            'add this time through loop then process
                            noncountedchars -= 1
                            usedindex = prompt.Length - 1
                            continueloop = False
                        End If

                    Else
                        MsgBox("bugg")
                        Return -1
                    End If

                End If
            End While

            Dim templinelength = usedindex - noncountedchars
            linecount += 1 'add at least one line
            While MINIMUMFORMWIDTH + (templinelength - charsInThinistWindow) * WIDTHOFCHARACTER > Me.Width
                'this loop determines lines added because of word wrap
                linecount += 1
                ''MINIMUMFORMWIDTH + (templinelength - charsInThinistWindow) * 5 = me.Width
                ''  (templinelength - charsInThinistWindow) * 5 = me.Width - MINIMUMFORMWIDTH
                ''  templinelength - charsInThinistWindow  = (me.Width - MINIMUMFORMWIDTH)/5
                ''  templinelength   = (me.Width - MINIMUMFORMWIDTH)/5 + charsInThinistWindow
                templinelength -= (charsInThinistWindow + (Me.Width - MINIMUMFORMWIDTH) / WIDTHOFCHARACTER)
            End While




            prompt = prompt.Substring(usedindex + 1)


        End While
        'MsgBox(returnvalue)


        Return linecount
    End Function

    Private Function longestLineLength(ByVal prompt As String) As Int16

        Dim returnvalue As Int16 = 0
        While prompt.Length > 0
            Dim crindex As Int16 = prompt.IndexOf(Constants.vbCr)
            Dim lfindex As Int16 = prompt.IndexOf(Constants.vbLf)
            Dim usedindex As Int16
            If crindex < 0 And lfindex < 0 Then
                usedindex = prompt.Length


                If returnvalue < usedindex Then
                    returnvalue = usedindex
                End If
                Return returnvalue

            ElseIf crindex < lfindex Then
                If crindex = -1 Then
                    usedindex = lfindex
                Else
                    usedindex = crindex
                End If
            Else
                If lfindex = -1 Then
                    usedindex = crindex
                Else
                    usedindex = lfindex
                End If

            End If


            If returnvalue < usedindex Then
                returnvalue = usedindex
            End If

            prompt = prompt.Substring(usedindex + 1)


        End While
        'MsgBox(returnvalue)


        Return returnvalue
    End Function
    Public Sub setsize(ByVal width As Int16, ByVal height As Int16)
        Me.Width = width
        Me.Height = height
    End Sub
    Public Function initialize(ByVal prompt As String, ByRef elements As ArrayList) As Boolean
        'elements(0) a string which identifies which controll and (optional) specifies the size
        'elements(1) a string which is the value visable to the user 
        'elements(2) (optional) an identifying string that is placed in the return array with controls that return info
        Dim i As Int16 = 0
        Dim currentbutton As Int16 = 0
        Dim currentcheckbox As Int16 = 0
        Dim currentinput As Int16 = 0
        Dim currentlabel As Int16 = 0
        Dim prevcontrollwidth As Int16 = 0
        Dim prevcontrollheight As Int16 = 0
        Dim currentlocation As Drawing.Point = New Drawing.Point(0, 50)
        Dim prevcontroll As String = ""
        Dim screenRectangle As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea
        Dim screenHeight As Int32 = screenRectangle.Height
        Dim screenWidth As Int32 = screenRectangle.Width

        Dim thelongestline As Int16 = longestLineLength(prompt)
        Static recursive As Boolean = False

        allowtextchange = True
        '        MsgBox(thelongestline)
        If Not recursive And MINIMUMFORMWIDTH + (thelongestline - charsInThinistWindow) * WIDTHOFCHARACTER > Me.Width Then
            Me.Width = MINIMUMFORMWIDTH + WIDTHOFCHARACTER * (thelongestline - charsInThinistWindow)
        End If
        If Me.Width > screenWidth Then
            Me.Width = screenWidth
        End If

        Dim promptlines = (countLines(prompt))
        'first line is 19 
        'each additional line is 13
        'MsgBox(promptlines)
        txtprompt.Height = 6 + promptlines * 13
        currentlocation = New Drawing.Point(0, txtprompt.Height + 7)
        clearform()
        checkboxes = New ArrayList
        radiobuttons = New ArrayList
        inputs = New ArrayList
        inputfilters = New ArrayList
        labels = New ArrayList
        txtprompt.Text = prompt



        If elements.Count <> 2 And elements.Count <> 3 Then
            allowtextchange = False
            Return False
        End If
        If (elements(0).Count <> elements(1).Count) Then
            allowtextchange = False
            Return False
        End If

        If (elements.Count = 3) Then
            If (elements(1).Count <> elements(2).Count) Then
                'must be embedded to prevent out of range exception
                allowtextchange = False
                Return False
            End If
        End If
        While (i < elements(0).Count)


            If elements(0)(i).startswith("button") Then

                Dim lengthastext As String = elements(0)(i).Substring(6)
                Dim lengthofinput As Int16
                If lengthastext = "" Then
                    lengthofinput = elements(1)(i).length
                Else
                    lengthofinput = Convert.ToInt16(lengthastext)
                End If


                Dim newbutwidth = WIDTHOFCHARACTER * (lengthofinput) + 15

                If prevcontroll = "newrow" Then

                    currentlocation = New Drawing.Point(CONTROLS_LEFT_MARGIN, currentlocation.Y + prevcontrollheight + CONTROLS_VERTICAL_SPACE)

                    prevcontrollheight = 0
                Else
                    Dim newx As Int16 = currentlocation.X + prevcontrollwidth + 5
                    Dim newy As Int16 = currentlocation.Y

                    If (prevcontroll = "carraigenewrow" Or Me.Width = screenWidth) And newx + newbutwidth > txtprompt.Width Then
                        newx = CONTROLS_LEFT_MARGIN
                        newy = newy + prevcontrollwidth + CONTROLS_VERTICAL_SPACE
                        prevcontrollheight = 0
                    End If

                    currentlocation = New Drawing.Point(newx, newy)

                End If



                If currentbutton = 0 Then
                    Button0.Visible = True
                    Button0.Text = elements(1)(i)

                    Button0.Location = currentlocation
                    Button0.Width = newbutwidth
                    prevcontrollwidth = Button0.Width

                    If ((elements.Count = 3)) Then
                        Button0.Tag = elements(2)(i)
                    Else
                        Button0.Tag = ""
                    End If

                ElseIf currentbutton = 1 Then
                    Button1.Visible = True
                    Button1.Text = elements(1)(i)

                    Button1.Location = currentlocation
                    Button1.Width = newbutwidth
                    prevcontrollwidth = Button1.Width
                    If ((elements.Count = 3)) Then
                        Button1.Tag = elements(2)(i)
                    Else
                        Button1.Tag = ""
                    End If
                ElseIf currentbutton = 2 Then
                    Button2.Visible = True
                    Button2.Text = elements(1)(i)

                    Button2.Location = currentlocation
                    Button2.Width = newbutwidth
                    prevcontrollwidth = Button2.Width
                    If ((elements.Count = 3)) Then
                        Button2.Tag = elements(2)(i)
                    Else
                        Button2.Tag = ""
                    End If
                ElseIf currentbutton = 3 Then
                    Button3.Visible = True
                    Button3.Text = elements(1)(i)


                    Button3.Location = currentlocation
                    Button3.Width = newbutwidth
                    prevcontrollwidth = Button3.Width
                    If ((elements.Count = 3)) Then
                        Button3.Tag = elements(2)(i)
                    Else
                        Button3.Tag = ""
                    End If
                ElseIf currentbutton = 4 Then
                    Button4.Visible = True
                    Button4.Text = elements(1)(i)

                    Button4.Location = currentlocation
                    Button4.Width = newbutwidth
                    prevcontrollwidth = Button4.Width
                    If ((elements.Count = 3)) Then
                        Button4.Tag = elements(2)(i)
                    Else
                        Button4.Tag = ""
                    End If
                ElseIf currentbutton = 5 Then
                    Button5.Visible = True
                    Button5.Text = elements(1)(i)

                    Button5.Location = currentlocation
                    Button5.Width = newbutwidth
                    prevcontrollwidth = Button5.Width
                    If ((elements.Count = 3)) Then
                        Button5.Tag = elements(2)(i)
                    Else
                        Button5.Tag = ""
                    End If
                ElseIf currentbutton = 6 Then
                    Button6.Visible = True
                    Button6.Text = elements(1)(i)

                    Button6.Location = currentlocation
                    Button6.Width = newbutwidth
                    prevcontrollwidth = Button6.Width
                    If ((elements.Count = 3)) Then
                        Button6.Tag = elements(2)(i)
                    Else
                        Button6.Tag = ""
                    End If
                ElseIf currentbutton = 7 Then
                    Button7.Visible = True
                    Button7.Text = elements(1)(i)

                    Button7.Location = currentlocation
                    Button7.Width = newbutwidth
                    prevcontrollwidth = Button7.Width
                    If ((elements.Count = 3)) Then
                        Button7.Tag = elements(2)(i)
                    Else
                        Button7.Tag = ""
                    End If
                ElseIf currentbutton = 8 Then
                    Button8.Visible = True
                    Button8.Text = elements(1)(i)

                    Button8.Location = currentlocation
                    Button8.Width = newbutwidth
                    prevcontrollwidth = Button8.Width
                    If ((elements.Count = 3)) Then
                        Button8.Tag = elements(2)(i)
                    Else
                        Button8.Tag = ""
                    End If
                ElseIf currentbutton = 9 Then
                    Button9.Visible = True
                    Button9.Text = elements(1)(i)

                    Button9.Location = currentlocation
                    Button9.Width = newbutwidth
                    prevcontrollwidth = Button9.Width
                    If ((elements.Count = 3)) Then
                        Button9.Tag = elements(2)(i)
                    Else
                        Button9.Tag = ""
                    End If
                ElseIf currentbutton = 10 Then
                    Button10.Visible = True
                    Button10.Text = elements(1)(i)

                    Button10.Location = currentlocation
                    Button10.Width = newbutwidth
                    prevcontrollwidth = Button10.Width

                    If ((elements.Count = 3)) Then
                        Button11.Tag = elements(2)(i)
                    Else
                        Button11.Tag = ""
                    End If

                ElseIf currentbutton = 11 Then
                    Button11.Visible = True
                    Button11.Text = elements(1)(i)

                    Button11.Location = currentlocation
                    Button11.Width = newbutwidth
                    prevcontrollwidth = Button11.Width
                    If ((elements.Count = 3)) Then
                        Button11.Tag = elements(2)(i)
                    Else
                        Button11.Tag = ""
                    End If
                ElseIf currentbutton = 12 Then
                    Button12.Visible = True
                    Button12.Text = elements(1)(i)

                    Button12.Location = currentlocation
                    Button12.Width = newbutwidth
                    prevcontrollwidth = Button12.Width
                    If ((elements.Count = 3)) Then
                        Button12.Tag = elements(2)(i)
                    Else
                        Button12.Tag = ""
                    End If
                ElseIf currentbutton = 13 Then
                    Button13.Visible = True
                    Button13.Text = elements(1)(i)

                    Button13.Location = currentlocation
                    Button13.Width = newbutwidth
                    prevcontrollwidth = Button13.Width
                    If ((elements.Count = 3)) Then
                        Button13.Tag = elements(2)(i)
                    Else
                        Button13.Tag = ""
                    End If
                ElseIf currentbutton = 14 Then
                    Button14.Visible = True
                    Button14.Text = elements(1)(i)

                    Button14.Location = currentlocation
                    Button14.Width = newbutwidth
                    prevcontrollwidth = Button14.Width
                    If ((elements.Count = 3)) Then
                        Button14.Tag = elements(2)(i)
                    Else
                        Button14.Tag = ""
                    End If
                ElseIf currentbutton = 15 Then
                    Button15.Visible = True
                    Button15.Text = elements(1)(i)

                    Button15.Location = currentlocation
                    Button15.Width = newbutwidth
                    prevcontrollwidth = Button15.Width
                    If ((elements.Count = 3)) Then
                        Button15.Tag = elements(2)(i)
                    Else
                        Button15.Tag = ""
                    End If
                ElseIf currentbutton = 16 Then
                    Button16.Visible = True
                    Button16.Text = elements(1)(i)

                    Button16.Location = currentlocation
                    Button16.Width = newbutwidth
                    prevcontrollwidth = Button16.Width
                    If ((elements.Count = 3)) Then
                        Button16.Tag = elements(2)(i)
                    Else
                        Button16.Tag = ""
                    End If
                ElseIf currentbutton = 17 Then
                    Button17.Visible = True
                    Button17.Text = elements(1)(i)

                    Button17.Location = currentlocation
                    Button17.Width = newbutwidth
                    prevcontrollwidth = Button17.Width
                    If ((elements.Count = 3)) Then
                        Button17.Tag = elements(2)(i)
                    Else
                        Button17.Tag = ""
                    End If
                ElseIf currentbutton = 18 Then
                    Button18.Visible = True
                    Button18.Text = elements(1)(i)

                    Button18.Location = currentlocation
                    Button18.Width = newbutwidth
                    prevcontrollwidth = Button18.Width
                    If ((elements.Count = 3)) Then
                        Button18.Tag = elements(2)(i)
                    Else
                        Button18.Tag = ""
                    End If
                ElseIf currentbutton = 19 Then
                    Button19.Visible = True
                    Button19.Text = elements(1)(i)

                    Button19.Location = currentlocation
                    Button19.Width = newbutwidth
                    prevcontrollwidth = Button19.Width
                    If ((elements.Count = 3)) Then
                        Button19.Tag = elements(2)(i)
                    Else
                        Button19.Tag = ""
                    End If
                ElseIf currentbutton = 20 Then
                    Button20.Visible = True
                    Button20.Text = elements(1)(i)

                    Button20.Location = currentlocation
                    Button20.Width = newbutwidth
                    prevcontrollwidth = Button20.Width
                    If ((elements.Count = 3)) Then
                        Button20.Tag = elements(2)(i)
                    Else
                        Button20.Tag = ""
                    End If
                ElseIf currentbutton = 21 Then
                    Button21.Visible = True
                    Button21.Text = elements(1)(i)

                    Button21.Location = currentlocation
                    Button21.Width = newbutwidth
                    prevcontrollwidth = Button21.Width
                    If ((elements.Count = 3)) Then
                        Button21.Tag = elements(2)(i)
                    Else
                        Button21.Tag = ""
                    End If

                ElseIf currentbutton = 22 Then
                    Button22.Visible = True
                    Button22.Text = elements(1)(i)

                    Button22.Location = currentlocation
                    Button22.Width = newbutwidth
                    prevcontrollwidth = Button22.Width
                    If ((elements.Count = 3)) Then
                        Button22.Tag = elements(2)(i)
                    Else
                        Button22.Tag = ""
                    End If
                ElseIf currentbutton = 23 Then
                    Button23.Visible = True
                    Button23.Text = elements(1)(i)

                    Button23.Location = currentlocation
                    Button23.Width = newbutwidth
                    prevcontrollwidth = Button23.Width
                    If ((elements.Count = 3)) Then
                        Button23.Tag = elements(2)(i)
                    Else
                        Button23.Tag = ""
                    End If
                ElseIf currentbutton = 24 Then
                    Button24.Visible = True
                    Button24.Text = elements(1)(i)

                    Button24.Location = currentlocation
                    Button24.Width = newbutwidth
                    prevcontrollwidth = Button24.Width
                    If ((elements.Count = 3)) Then
                        Button24.Tag = elements(2)(i)
                    Else
                        Button24.Tag = ""
                    End If
                ElseIf currentbutton = 25 Then
                    Button25.Visible = True
                    Button25.Text = elements(1)(i)

                    Button25.Location = currentlocation
                    Button25.Width = newbutwidth
                    prevcontrollwidth = Button25.Width
                    If ((elements.Count = 3)) Then
                        Button25.Tag = elements(2)(i)
                    Else
                        Button25.Tag = ""
                    End If
                Else
                    'more buttons passed then we have
                    allowtextchange = False
                    Return False
                End If
                If (23 > prevcontrollheight) Then
                    prevcontrollheight = 23 'the hight of buttons
                End If

                currentbutton += 1
                prevcontroll = "button"

            ElseIf elements(0)(i).StartsWith("checkbox") Then

                Dim addedcheckbox As CheckBox = New CheckBox

                Dim lengthastext As String = elements(0)(i).Substring(8)
                Dim lengthofinput As Int16

                Dim valuetype As String = elements(1)(i).GetType.Name

                'MsgBox(valuetype)

                If valuetype = "String" Then
                    If lengthastext = "" Then
                        lengthofinput = elements(1)(i).length
                    Else
                        lengthofinput = Convert.ToInt16(lengthastext)
                    End If



                    addedcheckbox.Text = elements(1)(i)

                ElseIf valuetype = "ArrayList" Then
                    If lengthastext = "" Then
                        lengthofinput = elements(1)(i)(0).length
                    Else
                        lengthofinput = Convert.ToInt16(lengthastext)
                    End If

                    addedcheckbox.Text = elements(1)(i)(0)

                    If elements(1)(i)(1).ToString.ToLower = "true" Or elements(1)(i)(1).ToString.ToLower = "checked" Then
                        addedcheckbox.Checked = True
                    Else
                        addedcheckbox.Checked = False
                    End If
                End If

                If lengthofinput = 1 Then
                    addedcheckbox.Width = 30
                ElseIf lengthofinput = 2 Then
                    addedcheckbox.Width = 42
                Else
                    addedcheckbox.Width = 42 + (WIDTHOFCHARACTER * (lengthofinput - 2))
                End If

                addedcheckbox.Parent = Me

                'Dim newcbwidth = 7 * (elements(1)(i).length + 2)

                If prevcontroll = "newrow" Then

                    currentlocation = New Drawing.Point(CONTROLS_LEFT_MARGIN, currentlocation.Y + prevcontrollheight + CONTROLS_VERTICAL_SPACE)
                    prevcontrollheight = 0

                Else

                    Dim newx As Int16 = currentlocation.X + prevcontrollwidth + 5
                    Dim newy As Int16 = currentlocation.Y

                    If (prevcontroll = "carraigenewrow" Or Me.Width = screenWidth) And newx + addedcheckbox.Width > txtprompt.Width Then
                        newx = CONTROLS_LEFT_MARGIN
                        newy = newy + prevcontrollheight
                        prevcontrollheight = 0
                    End If

                    currentlocation = New Drawing.Point(newx, newy)


                End If

                addedcheckbox.Location = currentlocation
                checkboxes.Add(addedcheckbox)
                If addedcheckbox.Height > prevcontrollheight Then
                    prevcontrollheight = addedcheckbox.Height
                End If

                prevcontrollwidth = addedcheckbox.Width
                currentcheckbox += 1
                prevcontroll = "radiobutton"


                If ((elements.Count = 3)) Then
                    addedcheckbox.Tag = elements(2)(i)
                Else
                    addedcheckbox.Tag = ""
                End If

                '''''''''''''''
            ElseIf elements(0)(i).StartsWith("radiobutton") Then

                Dim addedradiobutton As RadioButton = New RadioButton

                Dim lengthastext As String = elements(0)(i).Substring(11)
                Dim lengthofinput As Int16


                Dim valuetype As String = elements(1)(i).GetType.Name

                'MsgBox(valuetype)

                If valuetype = "String" Then

                    If lengthastext = "" Then
                        lengthofinput = elements(1)(i).length
                    Else
                        lengthofinput = Convert.ToInt16(lengthastext)
                    End If

                    addedradiobutton.Text = elements(1)(i)
                ElseIf valuetype = "ArrayList" Then

                    If lengthastext = "" Then
                        lengthofinput = elements(1)(i)(0).length
                    Else
                        lengthofinput = Convert.ToInt16(lengthastext)
                    End If

                    addedradiobutton.Text = elements(1)(i)(0)

                    If elements(1)(i)(1).ToString.ToLower = "true" Or elements(1)(i)(1).ToString.ToLower = "checked" Then
                        addedradiobutton.Checked = True
                    Else
                        addedradiobutton.Checked = False
                    End If
                End If

                If lengthofinput = 1 Then
                    addedradiobutton.Width = 30
                ElseIf lengthofinput = 2 Then
                    addedradiobutton.Width = 42
                Else
                    addedradiobutton.Width = 42 + (WIDTHOFCHARACTER * (lengthofinput - 2))
                End If

                addedradiobutton.Parent = Me

                'Dim newcbwidth = 7 * (elements(1)(i).length + 2)
                '''''''''''''''''''''''
                If prevcontroll = "newrow" Then

                    currentlocation = New Drawing.Point(CONTROLS_LEFT_MARGIN, currentlocation.Y + prevcontrollheight + CONTROLS_VERTICAL_SPACE)
                    prevcontrollheight = 0

                Else

                    Dim newx As Int16 = currentlocation.X + prevcontrollwidth + 5
                    Dim newy As Int16 = currentlocation.Y

                    If (prevcontroll = "carraigenewrow" Or Me.Width = screenWidth) And newx + addedradiobutton.Width > txtprompt.Width Then
                        newx = CONTROLS_LEFT_MARGIN
                        newy = newy + prevcontrollheight
                        prevcontrollheight = 0
                    End If

                    currentlocation = New Drawing.Point(newx, newy)


                End If

                addedradiobutton.Location = currentlocation
                radiobuttons.Add(addedradiobutton)
                If addedradiobutton.Height > prevcontrollheight Then
                    prevcontrollheight = addedradiobutton.Height * 1 / 2
                End If

                prevcontrollwidth = addedradiobutton.Width
                currentcheckbox += 1
                prevcontroll = "radiobutton"


                If ((elements.Count = 3)) Then
                    addedradiobutton.Tag = elements(2)(i)
                Else
                    addedradiobutton.Tag = ""
                End If

            ElseIf elements(0)(i).StartsWith("input") Then
                'Dim str As String = ""
                'str.Substring(5)
                Dim addedinput As TextBox = New TextBox
                Dim filter = ""
                Dim truncatedelement As String = elements(0)(i).Substring(5)
                Dim lengthastext = ""
                If (truncatedelement(0) >= "0" And truncatedelement(0) <= "9") Then
                    lengthastext = truncatedelement
                ElseIf truncatedelement.StartsWith("num") Then
                    filter = "num"
                    lengthastext = truncatedelement.Substring(3)
                ElseIf truncatedelement.StartsWith("int") Then
                    filter = "int"
                    lengthastext = truncatedelement.Substring(3)
                End If
                'Dim lengthastext = elements(0)(i).Substring(5)

                Dim lengthofinput As Int16
                If lengthastext = "" Then
                    lengthofinput = elements(1)(i).length
                    If (lengthofinput = 0) Then
                        lengthofinput = 1
                    End If
                Else
                    lengthofinput = Convert.ToInt16(lengthastext)
                    addedinput.MaxLength = lengthofinput
                End If

                addedinput.Width = 9 * lengthofinput

                If prevcontroll = "newrow" Then

                    currentlocation = New Drawing.Point(CONTROLS_LEFT_MARGIN, currentlocation.Y + prevcontrollheight + CONTROLS_VERTICAL_SPACE)
                    prevcontrollheight = 0

                Else

                    Dim newx As Int16 = currentlocation.X + prevcontrollwidth + 5
                    Dim newy As Int16 = currentlocation.Y

                    If (prevcontroll = "carraigenewrow" Or Me.Width = screenWidth) And newx + addedinput.Width > txtprompt.Width Then
                        newx = CONTROLS_LEFT_MARGIN
                        newy = newy + prevcontrollheight
                        prevcontrollheight = 0
                    End If

                    currentlocation = New Drawing.Point(newx, newy)


                End If


                addedinput.Text = elements(1)(i)
                addedinput.Location = currentlocation
                addedinput.Parent = Me

                inputs.Add(addedinput)
                inputfilters.Add(filter)
                If addedinput.Height > prevcontrollheight Then
                    prevcontrollheight = addedinput.Height
                End If

                prevcontrollwidth = addedinput.Width
                currentinput += 1
                prevcontroll = "input"
                If ((elements.Count = 3)) Then
                    addedinput.Tag = elements(2)(i)
                Else
                    addedinput.Tag = ""
                End If
            ElseIf elements(0)(i).StartsWith("label") Then
                Dim addedlabel As Label = New Label
                Dim lengthastext = elements(0)(i).Substring(5)
                Dim lengthofinput As Int16
                If lengthastext = "" Then
                    lengthofinput = elements(1)(i).length
                Else
                    lengthofinput = Convert.ToInt16(lengthastext)
                End If


                addedlabel.Text = elements(1)(i)
                If lengthofinput = 1 Then
                    addedlabel.Width = 9
                ElseIf lengthofinput = 2 Then
                    addedlabel.Width = 21
                Else
                    addedlabel.Width = 21 + (WIDTHOFCHARACTER * (lengthofinput - 2))
                End If
                'addedlabel.Width = 28 + 2.6 * addedlabel.Text.Length
                'addedlabel.Width = 41
                '''''''''''''''
                If prevcontroll = "newrow" Then

                    currentlocation = New Drawing.Point(CONTROLS_LEFT_MARGIN, currentlocation.Y + prevcontrollheight + CONTROLS_VERTICAL_SPACE)
                    prevcontrollheight = 0

                Else

                    Dim newx As Int16 = currentlocation.X + prevcontrollwidth + 5
                    Dim newy As Int16 = currentlocation.Y

                    If (prevcontroll = "carraigenewrow" Or Me.Width = screenWidth) And newx + addedlabel.Width > txtprompt.Width Then
                        newx = CONTROLS_LEFT_MARGIN
                        newy = newy + prevcontrollheight
                        prevcontrollheight = 0
                    End If

                    currentlocation = New Drawing.Point(newx, newy)


                End If


                addedlabel.Location = currentlocation
                addedlabel.Parent = Me
                labels.Add(addedlabel)

                If addedlabel.Height > prevcontrollheight Then
                    prevcontrollheight = addedlabel.Height
                    'else retain provious height
                End If


                prevcontrollwidth = addedlabel.Width
                currentlabel += 1
                prevcontroll = "label"
            ElseIf elements(0)(i).StartsWith("newrow") Then
                prevcontroll = "newrow" 'all other will insert a new row 
            ElseIf elements(0)(i).StartsWith("carraigenewrow") Then
                prevcontroll = "carraigenewrow" 'all other will process  correctly 
            Else
                allowtextchange = False
                Return False
            End If

            If currentlocation.Y + prevcontrollheight + 20 > Me.Height And Me.Height <> screenHeight Then
                'increase form height is needed 
                Me.Height = currentlocation.Y + prevcontrollheight + 20


            End If

            If (Me.Height > screenHeight Or currentlocation.X + prevcontrollwidth + 16 > Me.Width) And Me.Width <> screenWidth Then

                'if elements are wider then the form, 
                'or form is higher then screen
                'then re-width and start initialization all over

                If currentlocation.X + prevcontrollwidth + 16 > Me.Width Then
                    Me.Width = currentlocation.X + prevcontrollwidth + 16
                Else
                    Me.Width = 1.25 * Me.Width
                End If


                If Me.Width > screenWidth Then
                    Me.Width = screenWidth
                End If

                recursive = True
                Return initialize(prompt, elements)

            End If
            If Me.Height > screenHeight Then
                'this condition is reached if we are unable 
                'to re-width the form 
                Me.Height = screenHeight
            End If

            i += 1
        End While
        allowtextchange = False
        recursive = False
        'Me.ShowDialog()
        Tim_enforce_inputfilter.Start()
        Return True

    End Function



    Private Sub ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button0.Click, Button1.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button2.Click, Button20.Click, Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        'first member  is arraylist refering to buttons
        '            first member is integer index of button pressed
        '            2nd member is string value (appearing in button)  
        '            3rd member is the string identifyer 
        '            
        'second member is 2 dimentional arraylist of boxes checked
        '            1rst arraylist contain indexes of boxes checked
        '            2nd arraylist contain string values (appearing in checkbox)              
        '            3rd arraylist contain string identifyers assigned to boxes checked
        '                     
        'third member is 2dimentional arraylist of strings containing data in input textboxes
        '            1rst arraylist contains indexes - for semetry
        '            2nd  arraylist contain strings entered by the user
        '            3rd  arraylist contains identifying string assigned to the box
        'fourth member  is arraylist refering to radiobuttons
        '            first member is integer index of radiobutton checked
        '            2nd member is string value (text showing)  
        '            3rd member is the string identifyer 

        
        'intial array set up

        returnvalue = New ArrayList

        returnvalue.Add(New ArrayList) 'button


        returnvalue.Add(New ArrayList) 'checkboxes
        returnvalue(returnArrayIndex.checkboxes).Add(New ArrayList)
        returnvalue(returnArrayIndex.checkboxes).Add(New ArrayList)
        returnvalue(returnArrayIndex.checkboxes).Add(New ArrayList)

        returnvalue.Add(New ArrayList) 'inputs
        returnvalue(returnArrayIndex.inputs).Add(New ArrayList)
        returnvalue(returnArrayIndex.inputs).Add(New ArrayList)
        returnvalue(returnArrayIndex.inputs).Add(New ArrayList)

        returnvalue.Add(New ArrayList) 'radiobuttons

        'set values for button
        Dim buttonindexasstring = sender.name.ToString.Substring(6)
        Dim buttonindex As Integer = Convert.ToInt16(buttonindexasstring)
        Dim buttonidentifyer As String = sender.tag.ToString
        Dim buttonvalue As String = sender.text
        returnvalue(returnArrayIndex.button).add(buttonindex)
        returnvalue(returnArrayIndex.button).add(buttonvalue)
        returnvalue(returnArrayIndex.button).add(buttonidentifyer)


        'set values for checkboxes
        Dim i As Int16 = 0
        While i < checkboxes.Count
            If checkboxes(i).checked Then
                returnvalue(returnArrayIndex.checkboxes)(returnArraySecondDimention.index).add(i)
                returnvalue(returnArrayIndex.checkboxes)(returnArraySecondDimention.value).add(checkboxes(i).text)
                returnvalue(returnArrayIndex.checkboxes)(returnArraySecondDimention.identifyer).add(checkboxes(i).tag.ToString)
            End If

            i += 1
        End While

        i = 0
        'set value for inputs
        While i < inputs.Count

            returnvalue(returnArrayIndex.inputs)(returnArraySecondDimention.index).add(i)
            returnvalue(returnArrayIndex.inputs)(returnArraySecondDimention.value).add(inputs(i).text)
            returnvalue(returnArrayIndex.inputs)(returnArraySecondDimention.identifyer).add(inputs(i).tag.ToString)
            i += 1
        End While


        'set values for radiobuttons
        i = 0
        While i < radiobuttons.Count
            If radiobuttons(i).checked Then
                returnvalue(returnArrayIndex.radiobuttons).add(i)
                returnvalue(returnArrayIndex.radiobuttons).add(radiobuttons(i).text)
                returnvalue(returnArrayIndex.radiobuttons).add(radiobuttons(i).tag.ToString)
            End If

            i += 1
        End While

        Me.Close()
    End Sub


    Private Sub txtprompt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprompt.KeyPress
        Dim control_c As Char = Chr(3)
        If e.KeyChar <> control_c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtprompt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprompt.TextChanged

        Static prevtext As String
        Static recursive As Boolean = False

        If Not recursive Then
            recursive = True
            If allowtextchange Then
                prevtext = txtprompt.Text
            Else
                txtprompt.Text = prevtext
            End If
            recursive = False
        End If


    End Sub

    Private Sub mymsg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tim_enforce_inputfilter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tim_enforce_inputfilter.Tick

        If inputs.Count = 0 Then
            Tim_enforce_inputfilter.Stop()
            Return
        End If

        Static previouscontent As ArrayList = New ArrayList
        Static previousselectionstart As ArrayList = New ArrayList
        Static previousselectionlength As ArrayList = New ArrayList

        Dim loopcounter As Integer = 0
        If previouscontent.Count = 0 Then
            'first time timer ticks
            While (loopcounter < inputs.Count)
                previouscontent.Add(inputs(loopcounter).text)
                previousselectionstart.Add(inputs(loopcounter).selectionstart)
                previousselectionlength.Add(inputs(loopcounter).selectionlength)
                loopcounter += 1
            End While
            Return
        End If
        loopcounter = 0
        While (loopcounter < inputfilters.Count)
            Dim inputtextwalker As Integer = 0
            Dim inputtext As String = inputs(loopcounter).text
            If (inputfilters(loopcounter) = "int") Then
                While inputtextwalker < inputtext.Length
                    If inputtext(inputtextwalker) < "0" Or inputtext(inputtextwalker) > "9" Then
                        inputs(loopcounter).text = previouscontent(loopcounter)
                        inputs(loopcounter).selectionstart = previousselectionstart(loopcounter)
                        inputs(loopcounter).selectionlength = previousselectionlength(loopcounter)
                        Beep()
                        Exit While
                    End If
                    inputtextwalker += 1
                End While
            ElseIf (inputfilters(loopcounter) = "num") Then
                'not yet tested and debugged
                Dim dotencountered As Boolean = False
                While inputtextwalker < inputtext.Length
                    If inputtext(inputtextwalker) = "." Then
                        If dotencountered Then
                            inputs(loopcounter).text = previouscontent(loopcounter)
                            inputs(loopcounter).selectionstart = previousselectionstart(loopcounter)
                            inputs(loopcounter).selectionlength = previousselectionlength(loopcounter)
                            Beep()
                            Exit While
                        Else
                            dotencountered = True
                        End If

                    ElseIf (inputtext(inputtextwalker) < "0" Or inputtext(inputtextwalker) > "9") Then
                        inputs(loopcounter).text = previouscontent(loopcounter)
                        Beep()
                        Exit While
                    End If
                    inputtextwalker += 1
                End While

            End If
            loopcounter += 1
        End While

        loopcounter = 0
        previouscontent = New ArrayList
        previousselectionstart = New ArrayList
        previousselectionlength = New ArrayList
        While (loopcounter < inputs.Count)
            previouscontent.Add(inputs(loopcounter).text)
            previousselectionstart.Add(inputs(loopcounter).selectionstart)
            previousselectionlength.Add(inputs(loopcounter).selectionlength)
            loopcounter += 1
        End While
    End Sub
End Class