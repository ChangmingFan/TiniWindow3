Public Class colorpatterns
    Public StartUpColorPaternFile As String = "StartUpColorPatern.scp"
    Dim Filter As String = "Exported Color Patterns |*.scp; |All Files| *.*"

    Dim library_changed As Boolean = False

    Public initialized As Boolean = False
    Private Sub setdefaults()

        Txt_patternname0.Text = "All Red"
        Txt_patternname1.Text = "All Green"
        Txt_patternname2.Text = "All Blue"

        Txt_patternname3.Text = "All White"

        Txt_patternname4.Text = "RGWBRGWBRG"
        Txt_patternname5.Text = "RGRGRGRGRG"
        Txt_patternname6.Text = "RGGRWWRBBR"
        Txt_patternname7.Text = "RRGWWRRGWW"
        Txt_patternname8.Text = "WWGGWGWWGG"
        Txt_patternname9.Text = "WBRWWBBRR"



        Txt_patterndef0.Text = "RRRRRRRRRR"
        Txt_patterndef1.Text = "GGGGGGGGGG"
        Txt_patterndef2.Text = "BBBBBBBBBB"
        Txt_patterndef3.Text = "WWWWWWWWWW"

        Txt_patterndef4.Text = "RGWBRGWBRG"
        Txt_patterndef5.Text = "RGRGRGRGRG"
        Txt_patterndef6.Text = "RGGRWWRBBR"
        Txt_patterndef7.Text = "RRGWWRRGWW"
        Txt_patterndef8.Text = "WWGGWGWWGG"
        Txt_patterndef9.Text = "WBRWWBBRR"





    End Sub
    Public Sub _initialize()

        'this function should be executed once
        'subsequent calls result in exititing the form without doing anything

        'if it is neccesary to reinitialize, the flag initialized can be set to false.



        If Me.initialized Then
            Return
        End If


        Static currentlyrunning As Boolean = False
        If currentlyrunning Then
            Return
        End If
        currentlyrunning = True

        common_MouseEnter(New TextBox, New EventArgs) 'marks all items not selected since tag has no value

        import_colotpatterns(StartUpColorPaternFile)
        savechanges() 'apply to menu items on other forms ' also redundanly overwrites the file just imported



        settextcolors(Txt_patterndef0)
        settextcolors(Txt_patterndef1)
        settextcolors(Txt_patterndef2)
        settextcolors(Txt_patterndef3)
        settextcolors(Txt_patterndef4)
        settextcolors(Txt_patterndef5)
        settextcolors(Txt_patterndef6)
        settextcolors(Txt_patterndef7)
        settextcolors(Txt_patterndef8)
        settextcolors(Txt_patterndef9)
        settextspacing(Txt_patterndefdemo)
        settextcolors(Txt_patterndefdemo)

        simulator_form._initialize()

        Me.Location = simulator_form.Location
        currentlyrunning = False
    End Sub
    Public Sub apply()
        'this function no longer used
        MsgBox("bug function apply() should no longer be called")
        simulator_form.CMI_colorpattern0.Text = Txt_patternname0.Text
        simulator_form.CMI_colorpattern1.Text = Txt_patternname1.Text
        simulator_form.CMI_colorpattern2.Text = Txt_patternname2.Text
        simulator_form.CMI_colorpattern3.Text = Txt_patternname3.Text
        simulator_form.CMI_colorpattern4.Text = Txt_patternname4.Text
        simulator_form.CMI_colorpattern5.Text = Txt_patternname5.Text
        simulator_form.CMI_colorpattern6.Text = Txt_patternname6.Text
        simulator_form.CMI_colorpattern7.Text = Txt_patternname7.Text
        simulator_form.CMI_colorpattern8.Text = Txt_patternname8.Text
        simulator_form.CMI_colorpattern9.Text = Txt_patternname9.Text


        simulator_form.CMI_colorpattern0.Tag = Txt_patterndef0.Text
        simulator_form.CMI_colorpattern1.Tag = Txt_patterndef1.Text
        simulator_form.CMI_colorpattern2.Tag = Txt_patterndef2.Text
        simulator_form.CMI_colorpattern3.Tag = Txt_patterndef3.Text
        simulator_form.CMI_colorpattern4.Tag = Txt_patterndef4.Text
        simulator_form.CMI_colorpattern5.Tag = Txt_patterndef5.Text
        simulator_form.CMI_colorpattern6.Tag = Txt_patterndef6.Text
        simulator_form.CMI_colorpattern7.Tag = Txt_patterndef7.Text
        simulator_form.CMI_colorpattern8.Tag = Txt_patterndef8.Text
        simulator_form.CMI_colorpattern9.Tag = Txt_patterndef9.Text



    End Sub

    Public Sub reverse()

        Txt_patternname0.Text = simulator_form.CMI_colorpattern0.Text
        Txt_patternname1.Text = simulator_form.CMI_colorpattern1.Text
        Txt_patternname2.Text = simulator_form.CMI_colorpattern2.Text
        Txt_patternname3.Text = simulator_form.CMI_colorpattern3.Text
        Txt_patternname4.Text = simulator_form.CMI_colorpattern4.Text
        Txt_patternname5.Text = simulator_form.CMI_colorpattern5.Text
        Txt_patternname6.Text = simulator_form.CMI_colorpattern6.Text
        Txt_patternname7.Text = simulator_form.CMI_colorpattern7.Text
        Txt_patternname8.Text = simulator_form.CMI_colorpattern8.Text
        Txt_patternname9.Text = simulator_form.CMI_colorpattern9.Text


        Txt_patterndef0.Text = simulator_form.CMI_colorpattern0.Tag
        Txt_patterndef1.Text = simulator_form.CMI_colorpattern1.Tag
        Txt_patterndef2.Text = simulator_form.CMI_colorpattern2.Tag
        Txt_patterndef3.Text = simulator_form.CMI_colorpattern3.Tag
        Txt_patterndef4.Text = simulator_form.CMI_colorpattern4.Tag
        Txt_patterndef5.Text = simulator_form.CMI_colorpattern5.Tag
        Txt_patterndef6.Text = simulator_form.CMI_colorpattern6.Tag
        Txt_patterndef7.Text = simulator_form.CMI_colorpattern7.Tag
        Txt_patterndef8.Text = simulator_form.CMI_colorpattern8.Tag
        Txt_patterndef9.Text = simulator_form.CMI_colorpattern9.Tag





    End Sub


    Private Sub savechanges()

        library_changed = False
        simulator_form.CMI_mypattern0.Text = Txt_patternname0.Text
        simulator_form.CMI_mypattern0.Tag = Txt_patterndef0.Text

        Form1.CMI_mypattern0.Text = Txt_patternname0.Text
        Form1.CMI_mypattern0.Tag = Txt_patterndef0.Text

        If Txt_patternname0.Text <> "" And Txt_patterndef0.Text <> "" Then

            simulator_form.CMI_mypattern0.Visible = True
            Form1.CMI_mypattern0.Visible = True
        Else
            simulator_form.CMI_mypattern0.Visible = False
            Form1.CMI_mypattern0.Visible = False
        End If


        simulator_form.CMI_mypattern1.Text = Txt_patternname1.Text
        simulator_form.CMI_mypattern1.Tag = Txt_patterndef1.Text

        Form1.CMI_mypattern1.Text = Txt_patternname1.Text
        Form1.CMI_mypattern1.Tag = Txt_patterndef1.Text

        If Txt_patternname1.Text <> "" And Txt_patterndef1.Text <> "" Then
            simulator_form.CMI_mypattern1.Visible = True
            Form1.CMI_mypattern1.Visible = True
        Else
            simulator_form.CMI_mypattern1.Visible = False
            Form1.CMI_mypattern1.Visible = False
        End If


        simulator_form.CMI_mypattern2.Text = Txt_patternname2.Text
        simulator_form.CMI_mypattern2.Tag = Txt_patterndef2.Text
        Form1.CMI_mypattern2.Text = Txt_patternname2.Text
        Form1.CMI_mypattern2.Tag = Txt_patterndef2.Text

        If Txt_patternname2.Text <> "" And Txt_patterndef2.Text <> "" Then
            simulator_form.CMI_mypattern2.Visible = True
            Form1.CMI_mypattern2.Visible = True
        Else
            simulator_form.CMI_mypattern2.Visible = False
            Form1.CMI_mypattern2.Visible = False
        End If


        simulator_form.CMI_mypattern3.Text = Txt_patternname3.Text
        simulator_form.CMI_mypattern3.Tag = Txt_patterndef3.Text
        Form1.CMI_mypattern3.Text = Txt_patternname3.Text
        Form1.CMI_mypattern3.Tag = Txt_patterndef3.Text

        If Txt_patternname3.Text <> "" And Txt_patterndef3.Text <> "" Then
            simulator_form.CMI_mypattern3.Visible = True
            Form1.CMI_mypattern3.Visible = True
        Else
            simulator_form.CMI_mypattern3.Visible = False
            Form1.CMI_mypattern3.Visible = False
        End If


        simulator_form.CMI_mypattern4.Text = Txt_patternname4.Text
        simulator_form.CMI_mypattern4.Tag = Txt_patterndef4.Text
        Form1.CMI_mypattern4.Text = Txt_patternname4.Text
        Form1.CMI_mypattern4.Tag = Txt_patterndef4.Text

        If Txt_patternname4.Text <> "" And Txt_patterndef4.Text <> "" Then
            simulator_form.CMI_mypattern4.Visible = True
            Form1.CMI_mypattern4.Visible = True
        Else
            simulator_form.CMI_mypattern4.Visible = False
            Form1.CMI_mypattern4.Visible = False
        End If


        simulator_form.CMI_mypattern5.Text = Txt_patternname5.Text
        simulator_form.CMI_mypattern5.Tag = Txt_patterndef5.Text
        Form1.CMI_mypattern5.Text = Txt_patternname5.Text
        Form1.CMI_mypattern5.Tag = Txt_patterndef5.Text

        If Txt_patternname5.Text <> "" And Txt_patterndef5.Text <> "" Then
            simulator_form.CMI_mypattern5.Visible = True
            Form1.CMI_mypattern5.Visible = True
        Else
            simulator_form.CMI_mypattern5.Visible = False
            Form1.CMI_mypattern5.Visible = False
        End If


        simulator_form.CMI_mypattern6.Text = Txt_patternname6.Text
        simulator_form.CMI_mypattern6.Tag = Txt_patterndef6.Text

        Form1.CMI_mypattern6.Text = Txt_patternname6.Text
        Form1.CMI_mypattern6.Tag = Txt_patterndef6.Text

        If Txt_patternname6.Text <> "" And Txt_patterndef6.Text <> "" Then
            simulator_form.CMI_mypattern6.Visible = True
            Form1.CMI_mypattern6.Visible = True
        Else
            simulator_form.CMI_mypattern6.Visible = False
            Form1.CMI_mypattern6.Visible = False
        End If


        simulator_form.CMI_mypattern7.Text = Txt_patternname7.Text
        simulator_form.CMI_mypattern7.Tag = Txt_patterndef7.Text
        Form1.CMI_mypattern7.Text = Txt_patternname7.Text
        Form1.CMI_mypattern7.Tag = Txt_patterndef7.Text

        If Txt_patternname7.Text <> "" And Txt_patterndef7.Text <> "" Then
            simulator_form.CMI_mypattern7.Visible = True
            Form1.CMI_mypattern7.Visible = True
        Else
            simulator_form.CMI_mypattern7.Visible = False
            Form1.CMI_mypattern7.Visible = False
        End If


        simulator_form.CMI_mypattern8.Text = Txt_patternname8.Text
        simulator_form.CMI_mypattern8.Tag = Txt_patterndef8.Text
        Form1.CMI_mypattern8.Text = Txt_patternname8.Text
        Form1.CMI_mypattern8.Tag = Txt_patterndef8.Text

        If Txt_patternname8.Text <> "" And Txt_patterndef8.Text <> "" Then
            simulator_form.CMI_mypattern8.Visible = True
            Form1.CMI_mypattern8.Visible = True
        Else
            Form1.CMI_mypattern8.Visible = False
        End If



        simulator_form.CMI_mypattern9.Text = Txt_patternname9.Text
        simulator_form.CMI_mypattern9.Tag = Txt_patterndef9.Text
        Form1.CMI_mypattern9.Text = Txt_patternname9.Text
        Form1.CMI_mypattern9.Tag = Txt_patterndef9.Text

        If Txt_patternname9.Text <> "" And Txt_patterndef9.Text <> "" Then
            simulator_form.CMI_mypattern9.Visible = True
            Form1.CMI_mypattern9.Visible = True
        Else
            simulator_form.CMI_mypattern9.Visible = False
            Form1.CMI_mypattern9.Visible = False
        End If


        'save to file
        export_colotpatterns(StartUpColorPaternFile)

    End Sub

    Private Sub discardchanges()
        library_changed = False


        Txt_patternname0.Text = simulator_form.CMI_mypattern0.Text
        Txt_patterndef0.Text = simulator_form.CMI_mypattern0.Tag
        'If simulator_form.CMI_mypattern0.Visible Then

        '    'RBpatternshow0.Checked = True

        'Else
        '    'RBpatternhide0.Checked = True
        'End If



        Txt_patternname1.Text = simulator_form.CMI_mypattern1.Text
        Txt_patterndef1.Text = simulator_form.CMI_mypattern1.Tag
        ''If simulator_form.CMI_mypattern1.Visible Then

        ''    RBpatternshow1.Checked = True

        ''Else
        ''    RBpatternhide1.Checked = True
        ''End If

        Txt_patternname2.Text = simulator_form.CMI_mypattern2.Text
        Txt_patterndef2.Text = simulator_form.CMI_mypattern2.Tag
        'If simulator_form.CMI_mypattern2.Visible Then

        '    RBpatternshow2.Checked = True

        'Else
        '    RBpatternhide2.Checked = True
        'End If


        Txt_patternname3.Text = simulator_form.CMI_mypattern3.Text
        Txt_patterndef3.Text = simulator_form.CMI_mypattern3.Tag
        'If simulator_form.CMI_mypattern3.Visible Then

        '    RBpatternshow3.Checked = True

        'Else
        '    RBpatternhide3.Checked = True
        'End If

        Txt_patternname4.Text = simulator_form.CMI_mypattern4.Text
        Txt_patterndef4.Text = simulator_form.CMI_mypattern4.Tag
        'If simulator_form.CMI_mypattern4.Visible Then

        '    RBpatternshow4.Checked = True

        'Else
        '    RBpatternhide4.Checked = True
        'End If

        Txt_patternname5.Text = simulator_form.CMI_mypattern5.Text
        Txt_patterndef5.Text = simulator_form.CMI_mypattern5.Tag
        'If simulator_form.CMI_mypattern5.Visible Then

        '    RBpatternshow5.Checked = True

        'Else
        '    RBpatternhide5.Checked = True
        'End If


        Txt_patternname6.Text = simulator_form.CMI_mypattern6.Text
        Txt_patterndef6.Text = simulator_form.CMI_mypattern6.Tag
        'If simulator_form.CMI_mypattern6.Visible Then

        '    RBpatternshow6.Checked = True

        'Else
        '    RBpatternhide6.Checked = True
        'End If


        Txt_patternname7.Text = simulator_form.CMI_mypattern7.Text
        Txt_patterndef7.Text = simulator_form.CMI_mypattern7.Tag
        'If simulator_form.CMI_mypattern7.Visible Then

        '    RBpatternshow7.Checked = True

        'Else
        '    RBpatternhide7.Checked = True
        'End If


        Txt_patternname8.Text = simulator_form.CMI_mypattern8.Text
        Txt_patterndef8.Text = simulator_form.CMI_mypattern8.Tag
        'If simulator_form.CMI_mypattern8.Visible Then

        '    RBpatternshow8.Checked = True

        'Else
        '    RBpatternhide8.Checked = True
        'End If

        Txt_patternname9.Text = simulator_form.CMI_mypattern9.Text
        Txt_patterndef9.Text = simulator_form.CMI_mypattern9.Tag
        'If simulator_form.CMI_mypattern9.Visible Then

        '    RBpatternshow9.Checked = True

        'Else
        '    RBpatternhide9.Checked = True
        'End If


    End Sub

    Private Sub But_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_save.Click
        'changes are saved into cmi_mycolorpatter0 to cmi_mycolorpatter9 from simulator_form
        'pattern name is stored to .text so it show to the user. pattern definition is stored into .tag
        savechanges()



    End Sub

    Private Sub But_discard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_discard.Click
        discardchanges()
    End Sub

    Private Sub Txt_patterndef_common_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_patterndef8.KeyPress, Txt_patterndef7.KeyPress, Txt_patterndef6.KeyPress, Txt_patterndef5.KeyPress, Txt_patterndef4.KeyPress, Txt_patterndef3.KeyPress, Txt_patterndef2.KeyPress, Txt_patterndef1.KeyPress, Txt_patterndef9.KeyPress, Txt_patterndef0.KeyPress
        'note there is no need to handle the case of presing the delete key because it will not result in invalid string

        Const CONTROLL_A As Char = Chr(1)
        Const CONTROLL_C As Char = Chr(3)
        Const BACKSPACE As Char = Chr(8)
        Const CONTROLL_X As Char = Chr(24)
        Const CONTROLL_V As Char = Chr(22)
        e.KeyChar = Char.ToUpper(e.KeyChar)

        If e.KeyChar = "R" Or e.KeyChar = "W" Or e.KeyChar = "B" Or e.KeyChar = "G" Then

            Dim sendercontents As String = sender.text
            sendercontents = sendercontents.Replace(" ", "") 'remove spaces

            If sendercontents.Length + 1 - sender.SelectionLength / 2 > 16 Then


                'too many characters
                Beep()
                e.Handled = True
                Return
            Else
                'proceed

            End If



        ElseIf e.KeyChar = CONTROLL_A Or e.KeyChar = CONTROLL_C Or e.KeyChar = CONTROLL_X Or e.KeyChar = BACKSPACE Then

            'proceed


        ElseIf e.KeyChar = CONTROLL_V Then

            'remove all valid chars from string on clipboard
            'if anything is left then there is invalid characters 

            Dim pastecontent As String = Clipboard.GetDataObject.GetData(DataFormats.Text)

            pastecontent = pastecontent.Replace(" ", "") 'remove spaces
            Dim sendercontents As String = sender.text
            sendercontents = sendercontents.Replace(" ", "") 'remove spaces
            If pastecontent.Length + sendercontents.Length - (sender.SelectionLength / 2) > 10 Then
                'add together length of text in text box and lentgh of text in clipboard
                'then subtract the length of the highlighted text





                'the contents of the clipboard are too long
                Beep()
                e.Handled = True

                Exit Sub
                Return



            End If
            pastecontent = pastecontent.ToUpper
            pastecontent = pastecontent.Replace("R", "")
            pastecontent = pastecontent.Replace("W", "")
            pastecontent = pastecontent.Replace("G", "")
            pastecontent = pastecontent.Replace("B", "")

            If pastecontent.Trim.Length <> 0 Then


                'invalid charaters in paste
                Beep()
                e.Handled = True
                Return
            End If


        Else
            'invalid key pressed
            'do not proceed
            Beep()
            e.Handled = True
            Return
        End If


    End Sub

    Private Sub export_colotpatterns(ByVal filename As String)
        'format of userdatfile is 
        '[start datamembername]datastring[end datamembername] 
        'datastring may be multiline
        'characters outside start and end tag are ignored 
        'and may be used as notes




        Dim SW As IO.StreamWriter = IO.File.CreateText(filename)
        Dim outputstring As String
        outputstring = "This is an exported Color pattern file" + Constants.vbCrLf
        outputstring += "Manually editing this file is not recomended " + Constants.vbCrLf
        outputstring += "If you do, be careful that opening and closing tags are correct " + Constants.vbCrLf + Constants.vbCrLf

        outputstring += "This file is frequently overwritten by TiniWindow" + Constants.vbCrLf


        outputstring += Constants.vbCrLf
        '    Enum userdataindexags 
        '       Name
        '  End Enum





        'If RBpatternshow0.Checked Then
        outputstring &= "[start pattername0]" & Txt_patternname0.Text & "[end pattername0]" & Constants.vbCrLf
        outputstring &= "[start patterndef0]" & Txt_patterndef0.Text & "[end patterndef0]" & Constants.vbCrLf
        'End If

        'If RBpatternshow1.Checked Then
        outputstring &= "[start pattername1]" & Txt_patternname1.Text & "[end pattername1]" & Constants.vbCrLf
        outputstring &= "[start patterndef1]" & Txt_patterndef1.Text & "[end patterndef1]" & Constants.vbCrLf
        'End If

        'If RBpatternshow2.Checked Then
        outputstring &= "[start pattername2]" & Txt_patternname2.Text & "[end pattername2]" & Constants.vbCrLf
        outputstring &= "[start patterndef2]" & Txt_patterndef2.Text & "[end patterndef2]" & Constants.vbCrLf
        'End If

        'If RBpatternshow3.Checked Then
        outputstring &= "[start pattername3]" & Txt_patternname3.Text & "[end pattername3]" & Constants.vbCrLf
        outputstring &= "[start patterndef3]" & Txt_patterndef3.Text & "[end patterndef3]" & Constants.vbCrLf
        'End If

        'If RBpatternshow4.Checked Then
        outputstring &= "[start pattername4]" & Txt_patternname4.Text & "[end pattername4]" & Constants.vbCrLf
        outputstring &= "[start patterndef4]" & Txt_patterndef4.Text & "[end patterndef4]" & Constants.vbCrLf
        'End If

        'If RBpatternshow5.Checked Then
        outputstring &= "[start pattername5]" & Txt_patternname5.Text & "[end pattername5]" & Constants.vbCrLf
        outputstring &= "[start patterndef5]" & Txt_patterndef5.Text & "[end patterndef5]" & Constants.vbCrLf
        'End If

        'If RBpatternshow6.Checked Then
        outputstring &= "[start pattername6]" & Txt_patternname6.Text & "[end pattername6]" & Constants.vbCrLf
        outputstring &= "[start patterndef6]" & Txt_patterndef6.Text & "[end patterndef6]" & Constants.vbCrLf
        'End If

        'If RBpatternshow7.Checked Then
        outputstring &= "[start pattername7]" & Txt_patternname7.Text & "[end pattername7]" & Constants.vbCrLf
        outputstring &= "[start patterndef7]" & Txt_patterndef7.Text & "[end patterndef7]" & Constants.vbCrLf
        'End If

        'If RBpatternshow8.Checked Then
        outputstring &= "[start pattername8]" & Txt_patternname8.Text & "[end pattername8]" & Constants.vbCrLf
        outputstring &= "[start patterndef8]" & Txt_patterndef8.Text & "[end patterndef8]" & Constants.vbCrLf
        'End If

        'If RBpatternshow9.Checked Then
        outputstring &= "[start pattername9]" & Txt_patternname9.Text & "[end pattername9]" & Constants.vbCrLf
        outputstring &= "[start patterndef9]" & Txt_patterndef9.Text & "[end patterndef9]" & Constants.vbCrLf
        'End If

        SW.Write(outputstring)
        SW.Close()

    End Sub

    Public Sub import_colotpatterns(ByVal filename As String)
        'format of userdatfile is 
        '[start datamembername]datastring[end datamembername] 
        'datastring may be multiline
        'characters outside start and end tag are ignored 
        'and may be used as notes






        If (IO.File.Exists(filename)) Then

            Dim SR As IO.StreamReader = IO.File.OpenText(filename)
            Dim filetext As String = ""

            filetext = SR.ReadToEnd

            Dim this_dataname As String = ""
            Dim this_datavalue As String = ""
            'Dim this_dataindex As Integer


            While (filetext.IndexOf("]") >= 0)
                Try 'catches bad substring calls resulting from '[' and ']' being in wrong order
                    this_dataname = filetext.Substring(filetext.IndexOf("[") + 1, filetext.IndexOf("]") - filetext.IndexOf("[") - 1).Trim()
                    If (this_dataname.Substring(0, 5).ToLower <> "start") Then
                        filetext = filetext.Substring(filetext.IndexOf("]") + 1)
                        Continue While
                    End If

                    this_dataname = this_dataname.Substring(5).Trim


                    filetext = filetext.Substring(filetext.IndexOf("]") + 1)

                    Dim endtag As String = "[end " + this_dataname + "]"
                    Dim endtagindex As Integer = filetext.IndexOf(endtag)
                    'MsgBox(filetext + endtag)
                    'MsgBox(endtagindex)
                    this_datavalue = filetext.Substring(0, endtagindex)
                    filetext = filetext.Substring(filetext.IndexOf("[end " + this_dataname + "]") + 1)

                    '    Enum userdataindex
                    '       Name
                    '  End Enum



                    '''''''''''
                    'outputstring &= "[start backgroundImageFile]" & OFD_UploadPicture.FileName & "[end backgroundImageFile]" & Constants.vbCrLf

                    'outputstring &= "[start backgroundImageTop]" & Pan_imageholder.Top & "[end backgroundImageTop]" & Constants.vbCrLf
                    'outputstring &= "[start backgroundImageLeft]" & Pan_imageholder.Left & "[end backgroundImageLeft]" & Constants.vbCrLf
                    'outputstring &= "[start backgroundImageHeight]" & Pan_imageholder.Height & "[end backgroundImageHeight]" & Constants.vbCrLf
                    'outputstring &= "[start backgroundImageWidth]" & Pan_imageholder.Width & "[end backgroundImageWidth]" & Constants.vbCrLf


                    'End If

                    'outputstring &= "[start LiteCard0Top]" & LiteCard0.Top & "[end LiteCard0Top]" & Constants.vbCrLf
                    'outputstring &= "[start LiteCard0Left]" & LiteCard0.Left & "[end LiteCard0Left]" & Constants.vbCrLf
                    'outputstring &= "[start LiteCard0Angle]" & LiteCard0.Angle & "[end LiteCard0Angle]" & Constants.vbCrLf
                    'outputstring &= "[start LiteCard0FontSize]" & LiteCard0.FontSize & "[end LiteCard0FontSize]" & Constants.vbCrLf

                    If (this_dataname = "pattername0") Then
                        Txt_patternname0.Text = this_datavalue

                    ElseIf (this_dataname = "pattername1") Then
                        Txt_patternname1.Text = this_datavalue

                    ElseIf (this_dataname = "pattername2") Then
                        Txt_patternname2.Text = this_datavalue
                    ElseIf (this_dataname = "pattername3") Then
                        Txt_patternname3.Text = this_datavalue
                    ElseIf (this_dataname = "pattername4") Then
                        Txt_patternname4.Text = this_datavalue
                    ElseIf (this_dataname = "pattername5") Then
                        Txt_patternname5.Text = this_datavalue
                    ElseIf (this_dataname = "pattername6") Then
                        Txt_patternname6.Text = this_datavalue
                    ElseIf (this_dataname = "pattername7") Then
                        Txt_patternname7.Text = this_datavalue
                    ElseIf (this_dataname = "pattername8") Then
                        Txt_patternname8.Text = this_datavalue
                    ElseIf (this_dataname = "pattername9") Then
                        Txt_patternname9.Text = this_datavalue




                    ElseIf (this_dataname = "patterndef0") Then
                        Txt_patterndef0.Text = this_datavalue
                    ElseIf (this_dataname = "patterndef1") Then
                        Txt_patterndef1.Text = this_datavalue
                    ElseIf (this_dataname = "patterndef2") Then
                        Txt_patterndef2.Text = this_datavalue
                    ElseIf (this_dataname = "patterndef3") Then
                        Txt_patterndef3.Text = this_datavalue
                    ElseIf (this_dataname = "patterndef4") Then
                        Txt_patterndef4.Text = this_datavalue
                    ElseIf (this_dataname = "patterndef5") Then
                        Txt_patterndef5.Text = this_datavalue
                    ElseIf (this_dataname = "patterndef6") Then
                        Txt_patterndef6.Text = this_datavalue
                    ElseIf (this_dataname = "patterndef7") Then
                        Txt_patterndef7.Text = this_datavalue
                    ElseIf (this_dataname = "patterndef8") Then
                        Txt_patterndef8.Text = this_datavalue
                    ElseIf (this_dataname = "patterndef9") Then
                        Txt_patterndef9.Text = this_datavalue
                    End If


                    'userdata(this_dataindex) = this_datavalue


                Catch ex As Exception
                    filetext = filetext.Substring(filetext.IndexOf("]") + 1)
                    Continue While
                End Try

            End While

            SR.Close()

            'apply()

        End If


    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        setdefaults()
        apply()

    End Sub

    Private Sub But_import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_import.Click
        With OFD

            .Reset() 'changing the initial directory doesnt work otherwise
            .Filter = Filter


            'the .ShowDialog function reset the path which needs to be restored in order for hep userdata and settings to be
            'written and read correctly. also I am saving the selected directory in user data file so that the dialog box will
            'open to the same path
            Dim path As String = IO.Directory.GetCurrentDirectory
            IO.Directory.SetCurrentDirectory(Form1.userdata(Form1.userdataindex.ColorPatternPath))

            .InitialDirectory = Form1.userdata(Form1.userdataindex.ColorPatternPath)
            Dim result As DialogResult = .ShowDialog

            If result = Windows.Forms.DialogResult.Cancel Then
                IO.Directory.SetCurrentDirectory(path)
                Return
            End If






            Me.import_colotpatterns(.FileName)

            Form1.userdata(Form1.userdataindex.displayPatternPath) = IO.Directory.GetCurrentDirectory
            IO.Directory.SetCurrentDirectory(path)
        End With

    End Sub


    Private Sub But_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_export.Click

        With SFD

            .Reset() 'changing the initial directory doesnt work otherwise
            .Filter = Filter


            'the .ShowDialog function reset the path which needs to be restored in order for hep userdata and settings to be
            'written and read correctly. also I am saving the selected directory in user data file so that the dialog box will
            'open to the same path
            Dim path As String = IO.Directory.GetCurrentDirectory
            IO.Directory.SetCurrentDirectory(Form1.userdata(Form1.userdataindex.displayPatternPath))

            .InitialDirectory = Form1.userdata(Form1.userdataindex.ColorPatternPath)
            Dim result As DialogResult = .ShowDialog

            If result = Windows.Forms.DialogResult.Cancel Then
                IO.Directory.SetCurrentDirectory(path)
                Return
            End If






            Me.export_colotpatterns(.FileName)

            Form1.userdata(Form1.userdataindex.ColorPatternPath) = IO.Directory.GetCurrentDirectory
            IO.Directory.SetCurrentDirectory(path)
        End With







    End Sub


    Private Sub RBpatternshow10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub colorpatterns_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub settextspacing(ByVal sender As RichTextBox)
        Dim loopcounter As Int16 = 0
        Dim oldtext As String = sender.Text
        Dim newtext As String = ""

        Dim cursorposition As Int16 = sender.SelectionStart
        Dim highlightlength As Int16 = sender.SelectionLength
        'Dim loopcounter As Int16 = 0
        Dim oldcharshouldbespace As Boolean = False

        'remember we do not want space before first char or after last char
        'we put the first letter then each additional letter is a space followed by the letter



        If oldtext.Length = 0 Then
            'nothing needs to be done
            'continuing causes exceptions to be thrown

            Return

        End If

        loopcounter = 0


        While (oldtext(loopcounter) = " ")
            loopcounter += 1
            cursorposition -= 1
            If loopcounter >= oldtext.Length Then
                'VB does not do short cut logic testing 
                'this must be tested before attempting to acces character or exception may occur
                Exit While

            End If

        End While


        newtext = oldtext(loopcounter)
        loopcounter += 1


        While loopcounter < oldtext.Length

            'the expected is a space followed by a char
            'if no space is present then cursor position needs to be changed


            If oldtext(loopcounter) = " " Then
                If loopcounter + 1 >= oldtext.Length Then
                    'old text ends in space
                    'do not append anything to new text so this space is truncated
                    'adjust cursor position and highlight if needed

                    'space is removed so subtract 1
                    If loopcounter < cursorposition Then
                        cursorposition -= 1
                    ElseIf loopcounter < cursorposition + highlightlength Then
                        highlightlength -= 1
                    Else
                        'loopcouter is beyond the highlighted portion 
                        'no changes needed
                    End If
                    loopcounter += 1 'this time will end loop

                ElseIf oldtext(loopcounter + 1) <> " " Then

                    newtext += " " + oldtext(loopcounter + 1)
                    loopcounter += 2
                Else
                    'multiple space 
                    'move loopcounter ahead, adjust cursor position and continue loop 

                    If loopcounter < cursorposition Then
                        cursorposition -= 1
                    ElseIf loopcounter < cursorposition + highlightlength Then
                        highlightlength -= 1
                    Else
                        'loopcouter is beyond the highlighted portion 
                        'no changes needed
                    End If
                    loopcounter += 1

                End If
            Else

                newtext += " " + oldtext(loopcounter)
                'a space was added so curser or highlight need to be increased by 1
                If loopcounter < cursorposition Then
                    cursorposition += 1
                ElseIf loopcounter < cursorposition + highlightlength Then
                    highlightlength += 1
                Else
                    'loopcouter is beyond the highlighted portion 
                    'no changes needed
                End If
                loopcounter += 1
            End If



        End While

        'retore cursor position and highlighted text
        If cursorposition = -1 Then
            cursorposition = 0
        End If
        sender.Text = newtext
        sender.SelectionStart = cursorposition
        sender.SelectionLength = highlightlength


    End Sub
    Private Sub settextcolors(ByVal sender As RichTextBox)
        '''''''''''''''''''''''
        'this function set the colors of the text in the pattern definitions
        'R is colored red
        'B is colored blue
        'G is colored green
        'W is colored White
        ''''''''''''''''''''''''''''''''''

        'determin current cursor position so as to restore when done

        Dim cursorposition As Int16 = sender.SelectionStart
        Dim highlightlength As Int16 = sender.SelectionLength
        Dim loopcounter As Int16 = 0

        'go through text setting collors
        While loopcounter < sender.Text.Length

            sender.SelectionStart = loopcounter
            sender.SelectionLength = 1
            If sender.Text.Substring(loopcounter, 1) = "R" Then

                sender.SelectionColor = Color.Red

            ElseIf sender.Text.Substring(loopcounter, 1) = "W" Then
                sender.SelectionColor = Color.White
            ElseIf sender.Text.Substring(loopcounter, 1) = "B" Then
                sender.SelectionColor = Color.Cyan

            ElseIf sender.Text.Substring(loopcounter, 1) = "G" Then
                sender.SelectionColor = Color.GreenYellow


            End If

            loopcounter += 1
        End While

        'restore cursor position
        sender.SelectionStart = cursorposition
        sender.SelectionLength = highlightlength

    End Sub

    Private Sub Txt_patterndefcommon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_patterndef8.TextChanged, Txt_patterndef7.TextChanged, Txt_patterndef6.TextChanged, Txt_patterndef5.TextChanged, Txt_patterndef4.TextChanged, Txt_patterndef3.TextChanged, Txt_patterndef2.TextChanged, Txt_patterndef1.TextChanged, Txt_patterndef9.TextChanged, Txt_patterndef0.TextChanged

        Static recursive As Boolean = False
        If Not recursive Then
            recursive = True



            library_changed = True
            settextspacing(sender)

            settextcolors(sender)

            If sender.tag = 0 Then
                RadioButton0.Checked = False
                If sender.Text = "" Then
                    RadioButton0.Enabled = False
                Else
                    RadioButton0.Enabled = True
                End If
            ElseIf sender.tag = 1 Then
                RadioButton1.Checked = False
                If sender.Text = "" Then
                    RadioButton1.Enabled = False
                Else
                    RadioButton1.Enabled = True
                End If
            ElseIf sender.tag = 2 Then
                RadioButton2.Checked = False
                If sender.Text = "" Then
                    RadioButton2.Enabled = False
                Else
                    RadioButton2.Enabled = True
                End If
            ElseIf sender.tag = 3 Then
                RadioButton3.Checked = False
                If sender.Text = "" Then
                    RadioButton3.Enabled = False
                Else
                    RadioButton3.Enabled = True
                End If
            ElseIf sender.tag = 4 Then
                RadioButton4.Checked = False
                If sender.Text = "" Then
                    RadioButton4.Enabled = False
                Else
                    RadioButton4.Enabled = True
                End If
            ElseIf sender.tag = 5 Then
                RadioButton5.Checked = False
                If sender.Text = "" Then
                    RadioButton5.Enabled = False

                Else
                    RadioButton5.Enabled = True

                End If
            ElseIf sender.tag = 6 Then
                RadioButton6.Checked = False
                If sender.Text = "" Then
                    RadioButton6.Enabled = False
                Else
                    RadioButton6.Enabled = True
                End If
            ElseIf sender.tag = 7 Then
                RadioButton7.Checked = False
                If sender.Text = "" Then
                    RadioButton7.Enabled = False
                Else
                    RadioButton7.Enabled = True
                End If
            ElseIf sender.tag = 8 Then
                RadioButton8.Checked = False
                If sender.Text = "" Then
                    RadioButton8.Enabled = False
                Else
                    RadioButton8.Enabled = True
                End If
            ElseIf sender.tag = 9 Then
                RadioButton9.Checked = False
                If sender.Text = "" Then
                    RadioButton9.Enabled = False
                Else
                    RadioButton9.Enabled = True
                End If
            End If
            recursive = False

        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub RadioCommon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton0.CheckedChanged, RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged, RadioButton7.CheckedChanged, RadioButton8.CheckedChanged, RadioButton9.CheckedChanged
        If sender.Checked Then
            If sender.Tag = 0 Then
                simulator_form.setCardForecolor(Txt_patterndef0.Text)
            ElseIf sender.Tag = 1 Then
                simulator_form.setCardForecolor(Txt_patterndef1.Text)
            ElseIf sender.Tag = 2 Then
                simulator_form.setCardForecolor(Txt_patterndef2.Text)
            ElseIf sender.Tag = 3 Then
                simulator_form.setCardForecolor(Txt_patterndef3.Text)
            ElseIf sender.Tag = 4 Then
                simulator_form.setCardForecolor(Txt_patterndef4.Text)
            ElseIf sender.Tag = 5 Then
                simulator_form.setCardForecolor(Txt_patterndef5.Text)
            ElseIf sender.Tag = 6 Then
                simulator_form.setCardForecolor(Txt_patterndef6.Text)
            ElseIf sender.Tag = 7 Then
                simulator_form.setCardForecolor(Txt_patterndef7.Text)
            ElseIf sender.Tag = 8 Then
                simulator_form.setCardForecolor(Txt_patterndef8.Text)
            ElseIf sender.Tag = 9 Then
                simulator_form.setCardForecolor(Txt_patterndef9.Text)
            End If
        End If
    End Sub

    Private Sub but__close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but__close.Click

        Me.Hide()
        'the formclosing routine prompts to save pattern if applicable 
        'cancles closing and hides form

    End Sub

    Private Sub colorpatterns_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim recursive As Boolean = False

        If Not recursive Then
            recursive = True


            If library_changed Then
                Dim controlls_array As ArrayList = New ArrayList
                'Dim showagain As Boolean = True


                controlls_array = New ArrayList

                controlls_array.Add(New ArrayList)
                controlls_array.Add(New ArrayList)
                controlls_array.Add(New ArrayList)


                controlls_array(mymsg.parameterArrayIndex.ControllType).add("button10")
                controlls_array(mymsg.parameterArrayIndex.ControllValue).add("Save Changes")
                controlls_array(mymsg.parameterArrayIndex.ControllIdentifier).add("save")

                controlls_array(mymsg.parameterArrayIndex.ControllType).add("button10")
                controlls_array(mymsg.parameterArrayIndex.ControllValue).add("Discard changes")
                controlls_array(mymsg.parameterArrayIndex.ControllIdentifier).add("discard")

                controlls_array(mymsg.parameterArrayIndex.ControllType).add("button10")
                controlls_array(mymsg.parameterArrayIndex.ControllValue).add("Cancle")
                controlls_array(mymsg.parameterArrayIndex.ControllIdentifier).add("cancle")




                controlls_array(mymsg.parameterArrayIndex.ControllType).add("newrow")
                controlls_array(mymsg.parameterArrayIndex.ControllValue).add("")
                controlls_array(mymsg.parameterArrayIndex.ControllIdentifier).add("")

                controlls_array(mymsg.parameterArrayIndex.ControllType).add("newrow")
                controlls_array(mymsg.parameterArrayIndex.ControllValue).add("")
                controlls_array(mymsg.parameterArrayIndex.ControllIdentifier).add("")

                controlls_array(mymsg.parameterArrayIndex.ControllType).Add("checkbox")
                Dim checkboxvalue As ArrayList = New ArrayList
                checkboxvalue.Add("Don't prompt again (always do selected action)")
                checkboxvalue.Add("false")
                controlls_array(mymsg.parameterArrayIndex.ControllValue).Add(checkboxvalue)
                controlls_array(mymsg.parameterArrayIndex.ControllIdentifier).Add("beginning")


                controlls_array(mymsg.parameterArrayIndex.ControllType).add("newrow")
                controlls_array(mymsg.parameterArrayIndex.ControllValue).add("")
                controlls_array(mymsg.parameterArrayIndex.ControllIdentifier).add("")



                Dim selection_array As ArrayList = mymsg.showform("Do you wish to save the changes to your library", controlls_array)

                Dim pressed_button As String = selection_array(mymsg.returnArrayIndex.button)(mymsg.returnArraySecondDimention.identifyer)


                'gets the number of check boxes checked
                Dim numberofboxeschecked As String = selection_array(mymsg.returnArrayIndex.checkboxes)(mymsg.returnArraySecondDimention.index).count

                If pressed_button = "save" Then
                    savechanges()


                ElseIf pressed_button = "discard" Then

                    discardchanges()
                ElseIf pressed_button = "cancle" Then

                    e.Cancel = True
                    Return
                    'skip remainder and keep form open


                Else
                    MsgBox("bug - failed to recognized which button pressed!")
                End If




                If numberofboxeschecked = 0 Then
                    'MsgBox("not")
                ElseIf numberofboxeschecked = 1 Then
                    MsgBox("sorry - always do not yet implemented")
                Else
                    MsgBox("bug multiple boxes checked?")
                End If




            End If

            recursive = False
        Else
            MsgBox("recursive")
        End If
        'e.Cancel = True
        'Me.Hide()

    End Sub

    Private Sub Txt_patternname_common_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_patternname0.TextChanged, Txt_patternname1.TextChanged, Txt_patternname2.TextChanged, Txt_patternname3.TextChanged, Txt_patternname4.TextChanged, Txt_patternname5.TextChanged, Txt_patternname6.TextChanged, Txt_patternname7.TextChanged, Txt_patternname8.TextChanged, Txt_patternname9.TextChanged
        library_changed = True
    End Sub



    Private Sub Txt_patterndefdemo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_patterndefdemo.KeyPress
        Dim CONTROLL_C As Char = Chr(3)

        If e.KeyChar = CONTROLL_C Then
            'allow user to copy text from here  but not to change it
            Beep()
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_patterndefdemo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_patterndefdemo.TextChanged
        Static text As String = Txt_patterndefdemo.Text
        Txt_patterndefdemo.Text = text
        settextcolors(Txt_patterndefdemo)
    End Sub

    Public Sub mark_selected(ByRef cont As Control)

        cont.Font = New Font(cont.Font.FontFamily, cont.Font.Size, FontStyle.Bold)
        cont.BackColor = Color.Black
    End Sub
    Public Sub mark_unselected(ByRef cont As Control)
        cont.Font = New Font(cont.Font.FontFamily, cont.Font.Size, FontStyle.Regular)
        cont.BackColor = Color.DarkSlateGray
    End Sub
    Public Sub mark_disabled(ByRef cont As Control)
        cont.Font = New Font(cont.Font.FontFamily, cont.Font.Size, FontStyle.Italic)
        cont.BackColor = Color.LightGray
    End Sub




    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub


    Private Sub common_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_patterndef0.MouseEnter, Txt_patternname9.MouseEnter, Txt_patternname8.MouseEnter, Txt_patternname7.MouseEnter, Txt_patternname6.MouseEnter, Txt_patternname5.MouseEnter, Txt_patternname4.MouseEnter, Txt_patternname3.MouseEnter, Txt_patternname2.MouseEnter, Txt_patternname1.MouseEnter, Txt_patternname0.MouseEnter, Txt_patterndef9.MouseEnter, Txt_patterndef8.MouseEnter, Txt_patterndef7.MouseEnter, Txt_patterndef6.MouseEnter, Txt_patterndef5.MouseEnter, Txt_patterndef4.MouseEnter, Txt_patterndef3.MouseEnter, Txt_patterndef2.MouseEnter, Txt_patterndef1.MouseEnter, RadioButton9.MouseEnter, RadioButton5.MouseEnter, RadioButton4.MouseEnter, RadioButton3.MouseEnter, RadioButton2.MouseEnter, RadioButton0.MouseEnter

        mark_unselected(Txt_patternname0)
        mark_unselected(Txt_patternname1)
        mark_unselected(Txt_patternname2)
        mark_unselected(Txt_patternname3)
        mark_unselected(Txt_patternname4)
        mark_unselected(Txt_patternname5)
        mark_unselected(Txt_patternname6)
        mark_unselected(Txt_patternname7)
        mark_unselected(Txt_patternname8)
        mark_unselected(Txt_patternname9)

        mark_unselected(Txt_patterndef0)
        mark_unselected(Txt_patterndef1)
        mark_unselected(Txt_patterndef2)
        mark_unselected(Txt_patterndef3)
        mark_unselected(Txt_patterndef4)
        mark_unselected(Txt_patterndef5)
        mark_unselected(Txt_patterndef6)
        mark_unselected(Txt_patterndef7)
        mark_unselected(Txt_patterndef8)
        mark_unselected(Txt_patterndef9)

        mark_unselected(RadioButton0)
        mark_unselected(RadioButton1)
        mark_unselected(RadioButton2)
        mark_unselected(RadioButton3)
        mark_unselected(RadioButton4)
        mark_unselected(RadioButton5)
        mark_unselected(RadioButton6)
        mark_unselected(RadioButton7)
        mark_unselected(RadioButton8)
        mark_unselected(RadioButton9)


        If sender.tag = 0 Then
            Form1.mark_selected(Txt_patternname0)
            mark_selected(Txt_patterndef0)
            mark_selected(RadioButton0)
            Txt_patterndef0.Focus()

        ElseIf sender.tag = 1 Then
            Form1.mark_selected(Txt_patternname1)
            mark_selected(Txt_patterndef1)
            mark_selected(RadioButton1)
            Txt_patterndef1.Focus()
        ElseIf sender.tag = 2 Then
            Form1.mark_selected(Txt_patternname2)
            mark_selected(Txt_patterndef2)
            mark_selected(RadioButton2)
            Txt_patterndef2.Focus()
        ElseIf sender.tag = 3 Then
            Form1.mark_selected(Txt_patternname3)
            mark_selected(Txt_patterndef3)
            mark_selected(RadioButton3)
            Txt_patterndef3.Focus()
        ElseIf sender.tag = 4 Then
            Form1.mark_selected(Txt_patternname4)
            mark_selected(Txt_patterndef4)
            mark_selected(RadioButton4)
            Txt_patterndef4.Focus()
        ElseIf sender.tag = 5 Then
            Form1.mark_selected(Txt_patternname5)
            mark_selected(Txt_patterndef5)
            mark_selected(RadioButton5)
            Txt_patterndef5.Focus()

        ElseIf sender.tag = 6 Then
            Form1.mark_selected(Txt_patternname6)
            mark_selected(Txt_patterndef6)
            mark_selected(RadioButton6)
            Txt_patterndef6.Focus()

        ElseIf sender.tag = 7 Then
            Form1.mark_selected(Txt_patternname7)
            mark_selected(Txt_patterndef7)
            mark_selected(RadioButton7)
            Txt_patterndef7.Focus()

        ElseIf sender.tag = 8 Then
            Form1.mark_selected(Txt_patternname8)
            mark_selected(Txt_patterndef8)
            mark_selected(RadioButton8)
            Txt_patterndef8.Focus()

        ElseIf sender.tag = 9 Then
            Form1.mark_selected(Txt_patternname9)
            mark_selected(Txt_patterndef9)
            mark_selected(RadioButton9)
            Txt_patterndef9.Focus()

        End If

        settextcolors(Txt_patterndef0)
        settextcolors(Txt_patterndef1)
        settextcolors(Txt_patterndef2)
        settextcolors(Txt_patterndef3)
        settextcolors(Txt_patterndef4)
        settextcolors(Txt_patterndef5)
        settextcolors(Txt_patterndef6)
        settextcolors(Txt_patterndef7)
        settextcolors(Txt_patterndef8)
        settextcolors(Txt_patterndef9)

    End Sub

    Private Sub RadioButton1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.MouseEnter

    End Sub
End Class