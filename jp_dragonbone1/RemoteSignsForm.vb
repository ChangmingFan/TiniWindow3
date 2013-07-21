Public Class RemoteSignsForm
    Dim filename As String = "remoteSignlist.rsl"
    'format is
    '[start SIGNAME]
    'username:USERNAME
    'ip:IP
    '[end SIGNAME]

    'information not between start and end tag are ignored and may be used as notes
    Structure remoteSign
        Dim signname As String
        Dim username As String
        Dim password As String
        Dim ip As String
        Dim datafilename As String
    End Structure

    Dim remoteSignList As ArrayList = New ArrayList


    Private Sub loadfile(ByVal fname As String)
        If (IO.File.Exists(fname)) Then
            remoteSignList.Clear()

            Dim SR As IO.StreamReader = IO.File.OpenText(fname)
            Dim filetext As String = ""

            filetext = SR.ReadToEnd

            Dim this_dataname As String = ""
            Dim this_signsdata As String = ""
            Dim this_dataindex As Integer


            While (filetext.IndexOf("]") >= 0)
                Dim this_remoteSign As remoteSign = New remoteSign

                Try 'catches bad substring calls resulting from '[' and ']' being in wrong order

                    'get the name of the sign
                    'temporarily has 'start' proceeding sign name
                    this_remoteSign.signname = filetext.Substring(filetext.IndexOf("[") + 1, filetext.IndexOf("]") - filetext.IndexOf("[") - 1).Trim()
                    If (this_remoteSign.signname.Substring(0, 5).ToLower <> "start") Then
                        'ignore this supposed opening sign bracket because in wrong format
                        'truncate the portion of the file that is being ignored
                        filetext = filetext.Substring(filetext.IndexOf("]") + 1)
                        Continue While
                    End If

                    'remove the word "start" from proceeding the sign name
                    this_remoteSign.signname = this_remoteSign.signname.Substring(5).Trim

                    'truncate the portion of the file that has been processed
                    filetext = filetext.Substring(filetext.IndexOf("]") + 1)

                    'if the data is in the correct format these few lines will place several lines of data 
                    'into string this_signsdata 
                    'otherwise an exception is raised from bad substring calls
                    Dim endtag As String = "[end " + this_remoteSign.signname + "]"
                    Dim endtagindex As Integer = filetext.IndexOf(endtag)
                    this_signsdata = filetext.Substring(0, endtagindex)
                    filetext = filetext.Substring(filetext.IndexOf("[end " + this_remoteSign.signname + "]") + 1)

                    Dim splitsigndata As String() = this_signsdata.Split(Constants.vbLf)
                    For Each this_data_item As String In splitsigndata
                        Dim this_data_item_split As String() = this_data_item.Trim.Split(":")
                        Dim this_data_item_name As String = this_data_item_split(0)
                        Dim this_data_item_value As String = this_data_item_split(1)

                        If (this_data_item_name.ToLower = "username") Then
                            this_remoteSign.username = this_data_item_value

                        ElseIf (this_data_item_name.ToLower = "ip") Then
                            this_remoteSign.ip = this_data_item_value

                        ElseIf (this_data_item_name.ToLower = "password") Then
                            this_remoteSign.password = this_data_item_value


                        ElseIf (this_data_item_name.ToLower = "datafilename") Then
                            this_remoteSign.datafilename = this_data_item_value


                        End If
                



                    Next









                Catch ex As Exception
                    filetext = filetext.Substring(filetext.IndexOf("]") + 1)
                    Continue While
                End Try

            End While

            SR.Close()
           
        End If

    End Sub

    Private Sub RemoteSignsForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If (IO.File.Exists((filename))) Then
            loadfile(filename)
        End If

        
    End Sub
End Class