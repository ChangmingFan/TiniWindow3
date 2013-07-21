Public Class node
    Inherits Panel


    Public Event click(ByVal sender) 'shadow parent event because clicking on child controls does not raise

    Private Event mouseclick(ByVal sender) 'disable using parent event


    Public Enum nodestate
        selected
        unselected
        unavailable
    End Enum
    Dim mystate As nodestate = nodestate.unavailable
    Dim selectedImageSourceFile As String = ""
    Dim unselectedImageSourceFile As String = ""
    Dim unavailableImageSourceFile As String = ""
    Dim selectedImageholder As Panel = New Panel
    Dim UnselectedImageHolder As Panel = New Panel
    Dim unavailableImageHolder As Panel = New Panel

    Private m_selected_fontStyle As FontStyle = FontStyle.Bold
    Private m_unselected_fontStyle As FontStyle = FontStyle.Italic
    Private m_selected_textColor As Color = Color.Black
    Private m_unselected_textColor As Color = Color.Gray


    Private m_selected_text As String = ""
    Private m_unselected_text As String = ""
    Private m_unavailable_text As String = ""

    Private m_picture_percent As Single = 10.0




    

    Public Property picture_percent() As Single
        Get
            Return m_picture_percent
        End Get
        Set(ByVal value As Single)
            If value > 100 Or value < 0 Then
                Throw New Exception("percent must be between 0 and 100")
            End If

            If value <> m_picture_percent Then
                m_picture_percent = value
                _refresh()
            End If
        End Set
    End Property

    Public Sub _refresh()

        AddHandler lbl.Click, AddressOf childControll_CommonClick
        AddHandler selectedImageholder.Click, AddressOf childControll_CommonClick
        AddHandler UnselectedImageHolder.Click, AddressOf childControll_CommonClick
        AddHandler unavailableImageHolder.Click, AddressOf childControll_CommonClick
        'AddHandler lbl.Click, AddressOf childControll_CommonClick



        lbl.AutoSize = True
        selectedImageholder.Visible = False
        UnselectedImageHolder.Visible = False
        unavailableImageHolder.Visible = False
        Dim currentviewer As Panel
        If mystate = nodestate.selected Then
            lbl.Text = m_selected_text
            currentviewer = selectedImageholder
            font_functions.changestyle(lbl.Font, Me.m_selected_fontStyle)
            lbl.ForeColor = Me.m_selected_textColor

        ElseIf mystate = nodestate.unselected Then
            lbl.Text = m_unselected_text
            font_functions.changestyle(lbl.Font, Me.m_unselected_fontStyle)
            lbl.ForeColor = Me.m_unselected_textColor
            currentviewer = UnselectedImageHolder
        ElseIf mystate = nodestate.unavailable Then
            lbl.Text = m_unavailable_text
            currentviewer = unavailableImageHolder
        End If



        currentviewer.Visible = True
        'currentviewer.BackColor = Color.AntiqueWhite
        currentviewer.Parent = Me

        If lbl.Text = "" Then
            lbl.Visible = False
            currentviewer.Dock = DockStyle.Fill

        Else


            currentviewer.Dock = DockStyle.None
            currentviewer.Location = New Point(0, 0)
            currentviewer.Width = Me.Width
            currentviewer.Height = m_picture_percent / 100 * Me.Height
            
            lbl.Visible = True
            
            lbl.AutoSize = True

            
            lbl.Parent = Me
            lbl.Dock = DockStyle.None
            lbl.Location = New Point(0, currentviewer.Height)
            


            While lbl.Height < (Me.Height - currentviewer.Height)

                font_functions.changesize(lbl, 1.1 * lbl.Font.Size)

            End While

            While lbl.Height > (Me.Height - currentviewer.Height)

                font_functions.changesize(lbl, 0.9 * lbl.Font.Size)

            End While
            'center text
            lbl.Dock = DockStyle.None
            Dim addtobeg As Boolean = True
            While lbl.Width < Me.Width
                If addtobeg Then
                    lbl.Text = " " + lbl.Text
                Else
                    lbl.Text += " "
                End If
                addtobeg = Not addtobeg
            End While
        End If

    End Sub

    Public WriteOnly Property text() As String
        Set(ByVal value As String)

            Dim refreshneccesary As Boolean = False
            If m_selected_text <> value Or m_unselected_text <> value Or m_selected_text <> value Then
                refreshneccesary = True
            End If

            m_selected_text = value
            m_unselected_text = value
            m_unavailable_text = value

            If refreshneccesary Then

                _refresh()
            End If
        End Set
    End Property
    Public Property selected_text() As String
        Get
            Return m_selected_text
        End Get
        Set(ByVal value As String)

            If m_selected_text <> value Then
                m_selected_text = value
                _refresh()
            End If
        End Set
    End Property
    Public Property unselected_text() As String
        Get
            Return m_unselected_text
        End Get
        Set(ByVal value As String)
            If m_unselected_text <> value Then
                m_unselected_text = value
                _refresh()
            End If
        End Set
    End Property
    Public Property unavailable_text() As String
        Get
            Return m_unavailable_text
        End Get
        Set(ByVal value As String)
            If m_unavailable_text <> value Then
                m_unavailable_text = value
                _refresh()
            End If
        End Set
    End Property

    Dim lbl As Label = New Label

    Public Property state() As nodestate
        Get
            Return mystate
        End Get
        Set(ByVal value As nodestate)
            If mystate <> value Then
                mystate = value
                _refresh()
            End If

        End Set
    End Property
    

    Public Property unavailable_imagefile() As String
        Get
            Return unavailableImageSourceFile
        End Get
        Set(ByVal value As String)

            If unavailableImageSourceFile = value Then
                Return
            End If

            unavailableImageSourceFile = value

            If value = "" Then
                unavailableImageHolder.Dispose()
                unavailableImageHolder = New Panel
                _refresh()
                Return
            End If

            'try using as animated image
            Dim my_animatedimageviewer As animatedimageviewer = New animatedimageviewer
            my_animatedimageviewer.imagefile = value
            If value.EndsWith(".gif") Then
                ' a bug in the animated image viewer allows it to some times take a non gif file with out recognizing the error
                my_animatedimageviewer.imagefile = value
            End If



            If my_animatedimageviewer.imagefile = "" Or Not value.EndsWith(".gif") Then
                'note a bug in our animated image viewer allows non animated images to be loaded causing other bugs
                'therefore the 2nd part of condition above

                'file is not animated image

                Try
                    unavailableImageHolder.Dispose()
                    unavailableImageHolder = New Panel
                    unavailableImageHolder.BackgroundImage = System.Drawing.Image.FromFile(value)
                    unavailableImageHolder.BackgroundImageLayout = ImageLayout.Stretch
                Catch ex As Exception

                    'file is not the an image file (and may or may not be a valid file at all)
                    unavailableImageHolder.Dispose()
                    unavailableImageHolder = New Panel

                    unavailableImageSourceFile = ""

                End Try
            Else

                unavailableImageHolder = my_animatedimageviewer
            End If


            _refresh()

        End Set
    End Property


    Public Property unselected_imagefile() As String
        Get
            Return selectedImageSourceFile
        End Get
        Set(ByVal value As String)

            If unselectedImageSourceFile = value Then
                Return
            End If

            unselectedImageSourceFile = value



            If value = "" Then
                UnselectedImageHolder.Dispose()
                UnselectedImageHolder = New Panel
                _refresh()
                Return
            End If


            'try using as animated image
            Dim my_animatedimageviewer As animatedimageviewer = New animatedimageviewer
            my_animatedimageviewer.imagefile = value

            'If value.EndsWith(".gif") Then
            '    ' a bug in the animated image viewer allows it to some times take a non gif file with out recognizing the error
            '    my_animatedimageviewer.imagefile = value
            'End If



            If my_animatedimageviewer.imagefile = "" Then 'Or Not value.EndsWith(".gif") Then
                'note a bug in our animated image viewer allows non animated images to be loaded causing other bugs
                'therefore the 2nd part of condition above

                'file is not animated image

                Try
                    selectedImageholder.Dispose()
                    selectedImageholder = New Panel
                    selectedImageholder.BackgroundImage = System.Drawing.Image.FromFile(value)
                    selectedImageholder.BackgroundImageLayout = ImageLayout.Stretch
                Catch ex As Exception

                    'file is not the an image file (and may or may not be a valid file at all)
                    UnselectedImageHolder.Dispose()
                    UnselectedImageHolder = New Panel

                    unselectedImageSourceFile = ""

                End Try
            Else

                UnselectedImageHolder = my_animatedimageviewer
            End If


            _refresh()

        End Set
    End Property


    Public Property selected_imagefile() As String
        Get
            Return selectedImageSourceFile
        End Get
        Set(ByVal value As String)



            If selectedImageSourceFile = value Then
                Return
            End If

            selectedImageSourceFile = value

            If value = "" Then
                selectedImageholder.Dispose()
                selectedImageholder = New Panel
                _refresh()
                Return
            End If


            'try using as animated image
            Dim my_animatedimageviewer As animatedimageviewer = New animatedimageviewer
            If value.EndsWith(".gif") Then
                ' a bug in the animated image viewer allows it to some times take a non gif file with out recognizing the error
                my_animatedimageviewer.imagefile = value
            End If


            If my_animatedimageviewer.imagefile = "" Or Not value.EndsWith(".gif") Then
                'file is not animated image

                Try
                    selectedImageholder.Dispose()
                    selectedImageholder = New Panel
                    selectedImageholder.BackgroundImage = System.Drawing.Image.FromFile(value)
                    selectedImageholder.BackgroundImageLayout = ImageLayout.Stretch
                Catch ex As Exception

                    'file is not the an image file (and may or may not be a valid file at all)
                    selectedImageholder.Dispose()
                    selectedImageholder = New Panel

                    selectedImageSourceFile = ""

                End Try
            End If

            _refresh()

        End Set
    End Property


    Sub childControll_CommonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox("child clicked")

        RaiseEvent click(Me)
    End Sub
End Class
