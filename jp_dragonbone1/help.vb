Public Class help


    Private helptopics As ArrayList = New ArrayList
    Private helptexts As ArrayList = New ArrayList
    Const helpfilename As String = "help.text"

    Private Sub But_select_topic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_select_topic.Click
        TB_help.Text = helptexts(CB_topics.SelectedIndex)
    End Sub

    Private Sub But_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_close.Click
        Me.Close()
    End Sub

    Private Sub CB_topics_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CB_topics.KeyPress
        e.Handled = True
    End Sub

    Private Sub help_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'format of helpfile is 
        '[start topic]helptext[end topic] 
        'helptext usualy is multiline
        'characters outside start and end tag are ignored 
        'and may be used as notes




        If (IO.File.Exists(helpfilename)) Then

            Dim SR2 As IO.StreamReader = IO.File.OpenText(helpfilename)
            Dim filetext As String = ""

            filetext = SR2.ReadToEnd

            Dim this_helptopic As String = ""
            Dim this_helptext As String = ""
            'Dim index As Integer = 0

            While (filetext.IndexOf("]") >= 0)
                Try 'catches bad substring calls resulting from '[' and ']' being in wrong order
                    this_helptopic = filetext.Substring(filetext.IndexOf("[") + 1, filetext.IndexOf("]") - filetext.IndexOf("[") - 1).Trim()
                    If (this_helptopic.Substring(0, 5).ToLower <> "start") Then
                        filetext = filetext.Substring(filetext.IndexOf("]") + 1)
                        Continue While
                    End If

                    this_helptopic = this_helptopic.Substring(5).Trim


                    filetext = filetext.Substring(filetext.IndexOf("]") + 1)

                    Dim endtag As String = "[end " + this_helptopic + "]"
                    Dim endtagindex As Integer = filetext.IndexOf(endtag)
                    'MsgBox(filetext + endtag)
                    'MsgBox(endtagindex)
                    this_helptext = filetext.Substring(0, endtagindex)
                    filetext = filetext.Substring(filetext.IndexOf("[end " + this_helptopic + "]") + 1)


                Catch ex As Exception
                    filetext = filetext.Substring(filetext.IndexOf("]") + 1)
                    Continue While
                End Try
                helptopics.Add(this_helptopic)
                helptexts.Add(this_helptopic + Constants.vbCrLf + this_helptext)
                CB_topics.Items.Add(this_helptopic)

                'index += 1

            End While

            SR2.Close()
            Try
                CB_topics.SelectedIndex = 0
            Catch ex As ArgumentOutOfRangeException
                MsgBox("help file is corrupt!")
                Me.Close()
            End Try
            TB_help.Text = helptexts(0)

        Else
            MsgBox("help file not found!")
            Me.Close()
        End If
        

    End Sub

    Private Sub TB_help_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_help.KeyPress
        e.Handled = True
    End Sub
End Class