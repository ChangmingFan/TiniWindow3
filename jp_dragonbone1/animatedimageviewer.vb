Public Class animatedimageviewer
    Inherits Panel
    Dim myAnimImage As Image



    Dim imagesourcefile As String = ""
    Public Property imagefile() As String
        Get
            Return imagesourcefile
        End Get
        Set(ByVal value As String)



            Try
                myAnimImage = Image.FromFile(value)


                imagesourcefile = value
            Catch ex As Exception
                'invalid file
                'turn off animation

                imagesourcefile = ""

                ImageAnimator.StopAnimate(myAnimImage, New EventHandler(AddressOf onFrameChanged))

                myAnimImage = Nothing
            End Try

            'turn on animation
            ImageAnimator.Animate(myAnimImage, New EventHandler(AddressOf onFrameChanged))

            Me.Invalidate()

        End Set
    End Property

    Private Sub onFrameChanged( _
       ByVal sender As System.Object, _
       ByVal e As System.EventArgs)


        Me.Invalidate()

    End Sub


    Protected Overrides Sub OnPaint( _
           ByVal e As System.Windows.Forms.PaintEventArgs)
        ImageAnimator.UpdateFrames()

        If Not myAnimImage Is Nothing Then

            e.Graphics.DrawImage(myAnimImage, New System.Drawing.Rectangle(New Point(0, 0), Me.Size))
        End If

    End Sub

   
End Class
