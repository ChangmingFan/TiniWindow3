Public Class settings_form
    '''''form functions''''''''
    Private Sub settings_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        getsettings()
        refreshhelp()
    End Sub
    
    Private Sub getsettings()
        TB_username.Text = Form1.userdata(Form1.userdataindex.name)
        CB_donotaskforname.Checked = Not Form1.settings(Form1.settingsindex.askforname)
        CB_donotkeepuserdata.Checked = Not Form1.settings(Form1.settingsindex.keepuserdata)

        TB_datafileextentions.Text = Form1.userdata(Form1.userdataindex.dataFileExtentions).Replace("*.", ".")
        TB_trickfileextentions.Text = Form1.userdata(Form1.userdataindex.trickFileExtentions).Replace("*.", ".")


        'opening trick files
        If (Form1.settings(Form1.settingsindex.opentrickfileaction) = Form1.opentrickfileaction_value.cancel) Then
            RB_cancel_opentrickfile.Checked = True
        ElseIf (Form1.settings(Form1.settingsindex.opentrickfileaction) = Form1.opentrickfileaction_value.import) Then
            RB_importtricks.Checked = True
        ElseIf (Form1.settings(Form1.settingsindex.opentrickfileaction) = Form1.opentrickfileaction_value.openasdatafile) Then
            RB_openasdatafile.Checked = True

        ElseIf (Form1.settings(Form1.settingsindex.opentrickfileaction) = Form1.opentrickfileaction_value.pickanotherfile) Then
            RB_openanotherfile.Checked = True
        ElseIf (Form1.settings(Form1.settingsindex.opentrickfileaction) = Form1.opentrickfileaction_value.showdialog) Then
            RB_showdialog_opentrickfile.Checked = True

        End If


        'opening files with too many chars (20 in 6 char version of Tiniwindow) 
        If (Form1.settings(Form1.settingsindex.openfilewithtoomanycharsaction) = Form1.openfilewithtoomanycharsaction_value.showdialog) Then
            RB_showdialog_opentoomanychars.Checked = True
        ElseIf (Form1.settings(Form1.settingsindex.openfilewithtoomanycharsaction) = Form1.openfilewithtoomanycharsaction_value.truncate) Then
            RB_truncate.Checked = True
        ElseIf (Form1.settings(Form1.settingsindex.openfilewithtoomanycharsaction) = Form1.openfilewithtoomanycharsaction_value.cancel) Then
            RB_cancelopentoomanychars.Checked = True
        End If

        CB_showwelcome.Checked = Form1.settings(Form1.settingsindex.showwelcomeform)
    End Sub

    Private Sub sendsettings()

        Form1.userdata(Form1.userdataindex.name) = TB_username.Text
        Form1.settings(Form1.settingsindex.askforname) = Not CB_donotaskforname.Checked
        Form1.settings(Form1.settingsindex.keepuserdata) = Not CB_donotkeepuserdata.Checked
        If (Not fixfileextentionlist(TB_datafileextentions.Text)) Then
            Dim message As String = ""
            If (Not fixfileextentionlist(TB_trickfileextentions.Text)) Then
                message = "Due to type-os " + Constants.vbCrLf
                message += "we are unable to update file extentions" + Constants.vbCrLf
                message += "for either data or trick files"


            Else
                message = "Due to type-os " + Constants.vbCrLf
                message += "we are unable to update file extentions" + Constants.vbCrLf
                message += "for data files"
                Form1.userdata(Form1.userdataindex.trickFileExtentions) = TB_trickfileextentions.Text.Replace(".", "*.")
                Form1.settrickfilefilter(Form1.userdata(Form1.userdataindex.trickFileExtentions), Form1.userdata(Form1.userdataindex.dataFileExtentions))
            End If
            MsgBox(message)
        ElseIf (Not fixfileextentionlist(TB_trickfileextentions.Text)) Then
            Dim message As String = ""
            message = "Due to type-os " + Constants.vbCrLf
            message += "we are unable to update file extentions" + Constants.vbCrLf
            message += "for trick files"
            Form1.userdata(Form1.userdataindex.dataFileExtentions) = TB_datafileextentions.Text.Replace(".", "*.")
            MsgBox(message)
            Form1.setdatafilefilter(Form1.userdata(Form1.userdataindex.dataFileExtentions))
        Else
            'everything ok
            Form1.userdata(Form1.userdataindex.trickFileExtentions) = TB_trickfileextentions.Text.Replace(".", "*.")
            Form1.userdata(Form1.userdataindex.dataFileExtentions) = TB_datafileextentions.Text.Replace(".", "*.")

            Form1.setdatafilefilter(Form1.userdata(Form1.userdataindex.dataFileExtentions))
            Form1.settrickfilefilter(Form1.userdata(Form1.userdataindex.trickFileExtentions), Form1.userdata(Form1.userdataindex.dataFileExtentions))
        End If

        'opening trick file 
        If (RB_cancel_opentrickfile.Checked) Then
            Form1.settings(Form1.settingsindex.opentrickfileaction) = Form1.opentrickfileaction_value.cancel

        ElseIf (RB_importtricks.Checked) Then
            Form1.settings(Form1.settingsindex.opentrickfileaction) = Form1.opentrickfileaction_value.import

        ElseIf (RB_openasdatafile.Checked) Then
            Form1.settings(Form1.settingsindex.opentrickfileaction) = Form1.opentrickfileaction_value.openasdatafile
        ElseIf (RB_openanotherfile.Checked) Then
            Form1.settings(Form1.settingsindex.opentrickfileaction) = Form1.opentrickfileaction_value.pickanotherfile

        ElseIf (RB_showdialog_opentrickfile.Checked) Then
            Form1.settings(Form1.settingsindex.opentrickfileaction) = Form1.opentrickfileaction_value.showdialog
        End If


        'opening file with too many chars
        If (RB_truncate.Checked) Then
            Form1.settings(Form1.settingsindex.openfilewithtoomanycharsaction) = Form1.openfilewithtoomanycharsaction_value.truncate

        ElseIf (RB_cancelopentoomanychars.Checked) Then
            Form1.settings(Form1.settingsindex.openfilewithtoomanycharsaction) = Form1.openfilewithtoomanycharsaction_value.cancel

        ElseIf (RB_showdialog_opentoomanychars.Checked) Then
            Form1.settings(Form1.settingsindex.openfilewithtoomanycharsaction) = Form1.openfilewithtoomanycharsaction_value.showdialog
        End If




        Form1.settings(Form1.settingsindex.showwelcomeform) = CB_showwelcome.Checked

    End Sub
    Private Sub But_change_userdata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_change_userdata.Click
        sendsettings()

        Me.Close()



    End Sub


    Private Sub But_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_cancel.Click
        'used
        Me.Close()
    End Sub

    Private Sub But_applychanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_applychanges.Click
        sendsettings()

    End Sub

    Private Sub But_discardchanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_discardchanges.Click
        getsettings()
    End Sub

    ''''''functions for user data tab''''''''''''
    Private Sub ShowCorrectItems()
        'used
        If (CB_donotkeepuserdata.Checked) Then
            CB_donotkeepuserdata.Visible = True

            CB_donotaskforname.Visible = False
            TB_username.Visible = False

        ElseIf (CB_donotaskforname.Checked) Then
            CB_donotkeepuserdata.Visible = True
            CB_donotaskforname.Visible = True
            TB_username.Visible = False

        ElseIf (TB_username.Text = "") Then
            CB_donotkeepuserdata.Visible = True
            CB_donotaskforname.Visible = True
            TB_username.Visible = True

        Else
            CB_donotkeepuserdata.Visible = True
            CB_donotaskforname.Visible = False
            TB_username.Visible = True


        End If
    End Sub

    Private Sub CB_donotaskforname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_donotaskforname.CheckedChanged
        'used
        ShowCorrectItems()
    End Sub

    Private Sub CB_donotkeepuserdata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_donotkeepuserdata.CheckedChanged
        'used
        ShowCorrectItems()
    End Sub

    Private Sub TB_username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_username.TextChanged
        'used
        ShowCorrectItems()
    End Sub

    Private Sub But_why_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_why.Click
        'used
        Dim message As String = "We ask you name so that we can greet you by name on the welcome page"
        MsgBox(message)
    End Sub

    


    Private Sub TB_username_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_username.VisibleChanged
        Lbl_name.Visible = TB_username.Visible
        But_why.Visible = TB_username.Visible
    End Sub
    'functions for file options tab
    Private Function fixfileextentionlist(ByRef fileextentionlist As String) As Boolean
        Dim tempextentionlist As String = ""
        Dim extraspace As Int16 = 0
        Dim index As Integer = 0
        Dim startindex As Integer
        Dim inmiddleofextention As Boolean = False

        'acceptable formats 
        'at least one of the intems in parenthesis must seperate each extention in list
        '*.ext1[;][:][,][space] 
        '*ext1[;][:][,][space]
        '.ext1[;][:][,][space]
        'ext1[;][:][,][space]

        '.*ext1[;][:][,][space]

        Try
            While (fileextentionlist.Substring(index, 1) = " " Or fileextentionlist.Substring(index, 1) = Constants.vbTab)
                index += 1
            End While

        Catch ex As ArgumentOutOfRangeException
            'string is empty or all space
            Return False
        End Try


        Try
            While (index < fileextentionlist.Length)

                If (Not inmiddleofextention) Then
                    inmiddleofextention = True

                    If (fileextentionlist.Substring(index, 1) = ".") Then
                        index += 1
                    ElseIf (fileextentionlist.Substring(index, 1) = "*") Then
                        index += 1
                    ElseIf (fileextentionlist.Substring(index, 2) = "*.") Then
                        index += 2
                    ElseIf (fileextentionlist.Substring(index, 2) = ".*") Then
                        index += 2

                    End If


                    If (fileextentionlist.Substring(index, 1) = "/") Then
                        Return False
                    ElseIf (fileextentionlist.Substring(index, 1) = "\") Then
                        Return False

                    ElseIf (fileextentionlist.Substring(index, 1) = "|") Then
                        Return False
                    ElseIf (fileextentionlist.Substring(index, 1) = "*") Then
                        Return False
                    ElseIf (fileextentionlist.Substring(index, 1) = ":") Then
                        Return False
                    ElseIf (fileextentionlist.Substring(index, 1) = ";") Then
                        Return False
                    ElseIf (fileextentionlist.Substring(index, 1) = "?") Then
                        Return False
                    ElseIf (fileextentionlist.Substring(index, 1) = "<") Then
                        Return False
                    ElseIf (fileextentionlist.Substring(index, 1) = ">") Then
                        Return False
                    ElseIf (fileextentionlist.Substring(index, 1) = Chr(34)) Then
                        Return False
                        'quotemark 

                    End If
                    startindex = index
                End If

                If (fileextentionlist.Substring(index, 1) = ";" Or fileextentionlist.Substring(index, 1) = ":" Or fileextentionlist.Substring(index, 1) = "," Or fileextentionlist.Substring(index, 1) = " " Or fileextentionlist.Substring(index, 1) = Constants.vbTab) Then

                    extraspace = 0
                    While (fileextentionlist.Substring(index, 1) = ";" Or fileextentionlist.Substring(index, 1) = ":" Or fileextentionlist.Substring(index, 1) = "," Or fileextentionlist.Substring(index, 1) = " " Or fileextentionlist.Substring(index, 1) = Constants.vbTab)
                        index += 1
                        extraspace += 1
                    End While
                    'these two statements must be after while loop. if it causes argument out of range exception the extention is added in catch
                    tempextentionlist += "." + fileextentionlist.Substring(startindex, index - startindex - extraspace) + "; "
                    inmiddleofextention = False
                    Continue While
                End If


                If (fileextentionlist.Substring(index, 1) = "/") Then
                    Return False
                ElseIf (fileextentionlist.Substring(index, 1) = "\") Then
                    Return False

                ElseIf (fileextentionlist.Substring(index, 1) = "|") Then
                    Return False
                ElseIf (fileextentionlist.Substring(index, 1) = "*") Then
                    Return False

                ElseIf (fileextentionlist.Substring(index, 1) = "?") Then
                    Return False
                ElseIf (fileextentionlist.Substring(index, 1) = "<") Then
                    Return False
                ElseIf (fileextentionlist.Substring(index, 1) = ">") Then
                    Return False

                ElseIf (fileextentionlist.Substring(index, 1) = Chr(34)) Then
                    Return False
                    'quotemark
                End If

                index += 1
            End While
        Catch ex As ArgumentOutOfRangeException
            'a substring call exceed the end of the string
            If (inmiddleofextention) Then
                If (fileextentionlist.Substring(startindex).Length > 0) Then

                    tempextentionlist += "." + fileextentionlist.Substring(startindex, fileextentionlist.Substring(startindex).Length - extraspace) + "; "
                End If
            Else
                Return False
            End If


        End Try
        fileextentionlist = tempextentionlist
        Return True

    End Function

    Private Sub TabControl1_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs)


    End Sub

    Private Sub refreshhelp()

        If TabControl1.SelectedIndex = 0 Then

            'Form1.TB_beginners_help.Clear()
            Form1.appendrichtext("user data settings  " + Constants.vbCrLf, 12, FontStyle.Bold)
            Form1.appendrichtext("to change your name " + Constants.vbCrLf, 10, FontStyle.Bold)
            Form1.appendrichtext("1.    Make sure that none of the checkboxes are" + Constants.vbCrLf, 9)
            Form1.appendrichtext("      checked" + Constants.vbCrLf + Constants.vbCrLf, 9)
            Form1.appendrichtext("2.    Place the mouse pointer over the text field to the" + Constants.vbCrLf, 9)
            Form1.appendrichtext("      left of the word 'name'  " + Constants.vbCrLf, 9)
            Form1.appendrichtext("3.    Click to make the cursor appear" + Constants.vbCrLf, 9)
            Form1.appendrichtext("4.    Edit your name" + Constants.vbCrLf, 9)
            Form1.appendrichtext("5.    press 'Apply Changes' button at bottom of form" + Constants.vbCrLf + Constants.vbCrLf, 9)

            Form1.appendrichtext("If you do not want your name to be stored " + Constants.vbCrLf, 10, FontStyle.Bold)
            Form1.appendrichtext("1.    If either checkbox is checked, " + Constants.vbCrLf, 9)
            Form1.appendrichtext("      your name is already not being stored" + Constants.vbCrLf, 9)
            Form1.appendrichtext("2.    Place the mouse pointer over the text field to the left of the word 'name' " + Constants.vbCrLf, 9)
            Form1.appendrichtext("      field to the left of the word 'name' " + Constants.vbCrLf, 9)
            Form1.appendrichtext("3.    Click to make the cursor appear" + Constants.vbCrLf, 9)
            Form1.appendrichtext("4.    Erease all characters from the text field" + Constants.vbCrLf, 9)
            Form1.appendrichtext("5.    check either checkbox displaying on the form" + Constants.vbCrLf, 9)
            Form1.appendrichtext("6.    press 'Apply Changes' button at bottom of form" + Constants.vbCrLf, 9)
            ' Form1.Refresh()
        ElseIf TabControl1.SelectedIndex = 1 Then
            'Form1.TB_beginners_help.Clear()
            Form1.appendrichtext("File settings  " + Constants.vbCrLf, 12, FontStyle.Bold)
            Form1.appendrichtext("Do not change file extensions unless you understand what you are doing " + Constants.vbCrLf + Constants.vbCrLf, 10, FontStyle.Bold)


            Form1.appendrichtext("Display pattern files can not be opened as a regular file because it contain only display patters - no text. " + Constants.vbCrLf + Constants.vbCrLf, 9)
            Form1.appendrichtext("The option to (attempt to) open as data file is not recomended." + Constants.vbCrLf + Constants.vbCrLf, 9)

        ElseIf TabControl1.SelectedIndex = 2 Then

            'Form1.TB_beginners_help.Clear()
            Form1.appendrichtext("Misc settings  " + Constants.vbCrLf, 12, FontStyle.Bold)
            Form1.appendrichtext("If you would like to see the welcome form when TiniWindow starts, check the box" + Constants.vbCrLf + Constants.vbCrLf, 9)
            Form1.appendrichtext("Other wise, uncheck the box" + Constants.vbCrLf + Constants.vbCrLf, 9)

        End If
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        refreshhelp()
        'MsgBox(TabControl1.SelectedIndex)
        
    End Sub

    

    

    
    Private Sub settings_form_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.showmainhelp()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub But_browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_browse.Click
        Dim path As String 'the file diolog box changes the default path 
        'making the program not find the help file

    End Sub
End Class
