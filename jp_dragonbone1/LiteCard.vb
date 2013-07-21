Imports System.ComponentModel
Imports System.Windows.Forms



Public Class LiteCard
    Inherits Panel
    Public DoNotRedraw As Boolean = False
    Private m_angle As Double = 0
    Private m_character As Char
    Private m_backcolor As Color

    'these points are stored durring paint 
    'they are in me coordinates 
    'they are convrted to parent coordinates in the get proccess of the attribute
    Private m_leftconnector As Point
    Private m_rightconnector As Point

    Private m_corners As PointF()
    'Private m_corner2 As Point
    'Private m_corner3 As Point
    'Private m_corner4 As Point


    Private m_cardheight As Single = 1.15 * MyBase.Font.Size
    Private m_cardwidth As Single = 0.75 * MyBase.Font.Size

    'Private m_cardwidth As Single
    'Private m_cardheight As Single

    Private m_location As PointF
    'CMF 122812
    Private m_gridcolor As Color = Color.MidnightBlue
    'Private m_gridcolor As Color = Color.Green



    Public ReadOnly Property corners() As PointF()
        Get

            Return m_corners
        End Get
    End Property

    Public ReadOnly Property cardwidth() As Single
        Get
            Return m_cardwidth
        End Get
    End Property

    Public ReadOnly Property cardheight() As Single
        Get


            Return m_cardheight
        End Get
    End Property

    
    Public Sub New()
        ' Stop the flicker
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.DoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.ResizeRedraw, False)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        Me.UpdateStyles()

        'jp 20121228 backcoler has no apparent effect.
        'Me.m_backcolor = Color.Green
        Me.m_backcolor = Color.Red
        m_location = MyBase.Location

    End Sub

    Public ReadOnly Property rightconection() As Point
        Get

            'dim returnedcoordinates = new Point(m_rightconnector.X + me.
            Return m_rightconnector
        End Get
    End Property

    Public ReadOnly Property leftconection() As Point
        Get
            Return m_leftconnector
        End Get
    End Property

    <Description("Amount to rotate the sign"), _
    Category("Appearance"), _
    DefaultValue(0)> _
    Public Property Angle() As Double
        Get
            Return m_angle
        End Get
        Set(ByVal value As Double)
            m_angle = value
            setparameters()

            If Not DoNotRedraw Then
                Invalidate()
            End If

        End Set
    End Property



    Public Property location() As PointF
        Get
            Return (m_location)
        End Get
        Set(ByVal value As PointF)
            m_location = value
            'setparameters()
            MyBase.Location = New Point(m_location.X, m_location.Y)
            If Not DoNotRedraw Then
                Invalidate()
            End If

        End Set
    End Property

    Public Property Top() As Single
        Get
            Return (m_location.Y)
        End Get
        Set(ByVal value As Single)
            m_location.Y = value
            'setparameters()
            MyBase.Top = value
            If Not DoNotRedraw Then
                Invalidate()
            End If

        End Set
    End Property
    Public Property Left() As Single
        Get
            Return (m_location.x)
        End Get
        Set(ByVal value As Single)
            m_location.X = value
            'setparameters()
            MyBase.Left = value
            If Not DoNotRedraw Then
                Invalidate()
            End If

        End Set
    End Property



    'Public Property location() As Point
    '    Get
    '        Return (m_location)
    '    End Get
    '    Set(ByVal value As PointF)
    '        m_location = value
    '        setparameters()

    '        If Not DoNotRedraw Then
    '            Invalidate()
    '        End If

    '    End Set
    'End Property

    'Private Overrides Property font() As Font
    '    Get

    '    End Get
    '    Set(ByVal value)

    '    End Set
    'End Property
    Public Property Backcolor() As Color
        Get
            Return m_backcolor
        End Get
        Set(ByVal value As Color)
            m_backcolor = value
            If Not DoNotRedraw Then
                Invalidate()
            End If

        End Set
    End Property
    Public Property character() As Char
        Get
            Return m_character
        End Get
        Set(ByVal value As Char)
            m_character = value

            Dim temp1 As Boolean = Me.Visible
            Dim temp2 As Boolean = Me.DoNotRedraw
            Dim temp4 As PointF = Me.location


            If Not DoNotRedraw Then
                Invalidate()
            End If
        End Set
    End Property

    Public Property FontSize() As Single
        Get
            Return MyBase.Font.Size
        End Get
        Set(ByVal value As Single)

            Dim fam As FontFamily = MyBase.Font.FontFamily
            MyBase.Font = New Font(fam, value, MyBase.Font.Style)

            setparameters()
            If Not DoNotRedraw Then
                Invalidate()
            End If
        End Set
    End Property
    Public Sub rotateAroundPoint(ByVal centerOfRotation As PointF, ByVal angleOfRotation As Double)
        'CenterOfRotaion is expresed as rectangular cooedinates using the origin of the parent form as (0,0)

        'first we calculate the location of the new center
        'then we calculate the new location of the first corner (upper left corner when at 0 degrees)
        'then we convert the location of corner to be expressed with center of lite card as origin
        'we calculate the distance of the corner from the center as this is a radius needed to calculate the angle

        'at this point we have the rectangular coodinates of the corner 
        'with this info we calculate the radius.

        'we now have the center and the angle. this is all we need to change the location



        '''''''''''''''referenc point definition''''''''''''

        'local reference means using the same reference VB uses with the litecard. ie me.location is origin. 
        'from center of litecard means using the center of the lite card as origin. 
        'from parent means using the reference VB uses with the parent controll. this usually is the opper left corner as origen
        'from centerofrotation means using the point passed to this function as origen




        'MsgBox(corners(0).X & " " & corners(0).Y & Constants.vbCrLf & Me.location.X & " " & Me.location.Y)
        'Dim degreestoradians As Single = Math.PI / 180.0
        'Dim radianstodegrees As Single = 180.0 / Math.PI


        'all values are stored as angles hower the trig functions require and return radians


        'step 1 convert center of rotation to local reference
        Dim centerOfRotation_local_reference As PointF = New PointF(centerOfRotation.X - Me.location.X, centerOfRotation.Y - Me.location.Y)



        'step 2 get curretn cardcenter using local reference
        'we start out having 4 corners using local reference
        Dim current_cardcenter As PointF = New PointF((corners(0).X + corners(2).X) / 2, (corners(0).Y + corners(2).Y) / 2)



        'step 3 convert cardcenter so that center of rotation is origen
        Dim current_cardcenter_from_centerofrotation As PointF = New PointF(current_cardcenter.X - centerOfRotation_local_reference.X, current_cardcenter.Y - centerOfRotation_local_reference.Y)




        'Dim current_cardcenter_from_centerofrotation_as_circoord_angleinRadians As Single = Math.Atan(current_cardcenter_from_centerofrotation.X / current_cardcenter_from_centerofrotation.Y)
        'Dim current_cardcenter_from_centerofrotation_as_circoord_angleinDegrees As Single = radianstodegrees * current_cardcenter_from_centerofrotation_as_circoord_angleinRadians

        Dim current_cardcenter_from_centerofrotation_as_circoord As PointF = coordinates_functions.RectToCylinder(current_cardcenter_from_centerofrotation, False)



        Dim new_cardcenter_from_centerofrotation_as_circoord As PointF = New PointF(current_cardcenter_from_centerofrotation_as_circoord.X, current_cardcenter_from_centerofrotation_as_circoord.Y + angleOfRotation)


        Dim new_cardcenter_from_centerofrotation As PointF = coordinates_functions.CylinderToRect(new_cardcenter_from_centerofrotation_as_circoord, False)


        Dim new_cardcenter As PointF = New PointF(new_cardcenter_from_centerofrotation.X + centerOfRotation_local_reference.X, new_cardcenter_from_centerofrotation.Y + centerOfRotation_local_reference.Y)




        '''''''
        Dim current_corner As PointF = corners(0)
        Dim current_corner_from_centerofrotation As PointF = New PointF(current_corner.X - centerOfRotation_local_reference.X, current_corner.Y - centerOfRotation_local_reference.Y) 'local reference

        Dim current_corner_from_centerofrotation_as_circoord As PointF = new_cardcenter_from_centerofrotation_as_circoord

        Dim new_corner_from_centerofrotation_as_circoord As PointF = New PointF(current_corner_from_centerofrotation_as_circoord.X, current_corner_from_centerofrotation_as_circoord.Y + angleOfRotation)

        Dim new_corner_from_centerofrotation As PointF = coordinates_functions.CylinderToRect(new_corner_from_centerofrotation)
        Dim new_corner_from_centerofcard As PointF = New PointF(new_corner_from_centerofrotation.X - new_cardcenter_from_centerofrotation.X, new_corner_from_centerofrotation.Y - new_cardcenter_from_centerofrotation.Y)



        Dim degreestoradians As Single = Math.PI / 180.0

        Dim radianstodegrees As Single = 180.0 / Math.PI

        Dim newangle As Single = radianstodegrees * Math.Atan(new_corner_from_centerofcard.X / new_corner_from_centerofcard.Y)

        'Me.Angle = newangle

        Dim new_cardcenter_fromparentformorigen As PointF = New PointF(new_cardcenter_from_centerofrotation.X + centerOfRotation.X, new_cardcenter_from_centerofrotation.Y + centerOfRotation.Y)

        Me.location = New Point(new_cardcenter_fromparentformorigen.X + new_cardcenter.X, new_cardcenter_fromparentformorigen.Y + new_cardcenter.Y)


    End Sub





    Private Function getmin(ByVal arr As ArrayList)

        Dim returnvalue = arr(0)
        Dim loopcounter = 1
        While loopcounter < arr.Count
            If arr(loopcounter) < returnvalue Then
                returnvalue = arr(loopcounter)
            End If

            loopcounter += 1
        End While

        Return returnvalue

    End Function

    Private Function getmax(ByVal arr As ArrayList)

        Dim returnvalue = arr(0)
        Dim loopcounter = 1
        While loopcounter < arr.Count
            If arr(loopcounter) > returnvalue Then
                returnvalue = arr(loopcounter)
            End If

            loopcounter += 1
        End While

        Return returnvalue

    End Function

    Private Function getmaxX(ByVal arr As ArrayList)

        Dim returnvalue = arr(0).x
        Dim loopcounter = 1
        While loopcounter < arr.Count
            If arr(loopcounter).x > returnvalue Then
                returnvalue = arr(loopcounter).x
            End If

            loopcounter += 1
        End While

        Return returnvalue

    End Function
    Private Function getmaxY(ByVal arr As ArrayList)

        Dim returnvalue = arr(0).y
        Dim loopcounter = 1
        While loopcounter < arr.Count
            If arr(loopcounter).y > returnvalue Then
                returnvalue = arr(loopcounter).y
            End If

            loopcounter += 1
        End While

        Return returnvalue

    End Function

    Private Function getminX(ByVal arr As ArrayList)

        Dim returnvalue = arr(0).x
        Dim loopcounter = 1
        While loopcounter < arr.Count
            If arr(loopcounter).x < returnvalue Then
                returnvalue = arr(loopcounter).x
            End If

            loopcounter += 1
        End While

        Return returnvalue

    End Function
    Private Function getminY(ByVal arr As ArrayList)

        Dim returnvalue = arr(0).y
        Dim loopcounter = 1
        While loopcounter < arr.Count
            If arr(loopcounter).y < returnvalue Then
                returnvalue = arr(loopcounter).y
            End If

            loopcounter += 1
        End While

        Return returnvalue

    End Function






    Private Function rotatecorners(ByVal corners As ArrayList) As ArrayList
        Dim rot_angle As Double = m_angle * Math.PI / 180.0

        Dim rotated_corners As ArrayList = New ArrayList

        Dim loopcounter As Int16 = 0


        While loopcounter < corners.Count

            'convert rect point to cylender point
            Dim this_cylender_point As PointF = coordinates_functions.RectToCylinder(corners(loopcounter), True)

            'rotate point
            this_cylender_point.Y += rot_angle


            'convert back to rect point and add to arraylist
            rotated_corners.Add(coordinates_functions.CylinderToRect(this_cylender_point, True))


            loopcounter += 1
        End While
        Return rotated_corners

    End Function
    Public Sub PositionInArk(ByVal center_of_ark As PointF, ByVal radius As Double, ByVal angle As Double)


        Dim angletosetme = angle - 90

        If angletosetme Mod 360 > 90 Then
            angletosetme -= 180

        End If

        If angletosetme Mod 360 < -90 Then
            angletosetme += 180

        End If
        'set the angle use the property so that it redraws. We will have to use the new heigh and width
        Me.Angle = angletosetme

        'get the center of the light card pretending center of ark is (0,0)
        Dim center_of_card As PointF = coordinates_functions.CylinderToRect(New PointF(radius, angle), False)


        'convert center of card to acttual origen
        center_of_card.X += center_of_ark.X

        center_of_card.Y += center_of_ark.Y


        Me.location = New Point(center_of_card.X - Me.Width / 2, center_of_card.Y - Me.Height / 2)



    End Sub




    Private Sub setparameters()



        'paramters such as width height and region change when other parmeters such as angle and fontsize are changes

        'previously changing these was taken care of in paint function 
        'however VB blocking delays when paint is called and it is often neccesary to know these value sooner






        'MyBase.BackColor = Color.Transparent
        'Dim brush As New SolidBrush(Me.m_backcolor)


        'Dim fAM_grid As FontFamily = New FontFamily("Transponder Grid AOE")
        'Dim font_grid = New Font(fAM_grid, MyBase.Font.Size, MyBase.Font.Style, MyBase.Font.Unit)

        'Dim fAM_char As FontFamily = New FontFamily("Transponder AOE")
        'Dim font_char = New Font(fAM_char, MyBase.Font.Size, FontStyle.Bold, MyBase.Font.Unit)

        'Dim rectpen As Pen = New Pen(Me.m_backcolor)



        'these are before rotation

        m_cardheight = 1.15 * MyBase.Font.Size
        m_cardwidth = 0.75 * MyBase.Font.Size

        Dim rectx As Single = -1 / 2 * m_cardwidth
        Dim recty As Single = -1 / 2 * m_cardheight


        'm_cardwidth = rectwidth
        'm_cardheight = rectheight





        '        .FillRectangle(brush, rectx, recty, rectwidth, rectheight)


        'brush = New SolidBrush(Color.Gray)

        '.DrawString("*", font_grid, brush, 1.32 * rectx, 1.47 * recty) 'any character will do


        'brush = New SolidBrush(MyBase.ForeColor)
        '.DrawString(m_character, font_char, brush, 1.32 * rectx, 1.47 * recty)

        'brush.Dispose()



        'this is in relation to parents coordinates beacause that is how it is used
        Dim corners_nonrotated As ArrayList = New ArrayList



        'get coordinates in reference to origin in center
        corners_nonrotated.Add(New PointF(-m_cardwidth / 2, -m_cardheight / 2))
        corners_nonrotated.Add(New PointF(m_cardwidth / 2, -m_cardheight / 2))
        corners_nonrotated.Add(New PointF(m_cardwidth / 2, m_cardheight / 2))
        corners_nonrotated.Add(New PointF(-m_cardwidth / 2, m_cardheight / 2))

        'rotate around center origen
        Dim corners_rotated As ArrayList = rotatecorners(corners_nonrotated)


        Dim corners_adjusted As ArrayList = New ArrayList


        'convert coordinants to uper left corner origen
        Dim loopcounter = 0
        While loopcounter < corners_rotated.Count

            Dim xadj As Single = Me.Width / 2
            Dim yadj As Single = Me.Height / 2
            corners_adjusted.Add(New PointF(corners_rotated(loopcounter).x + xadj, corners_rotated(loopcounter).y + yadj))



            loopcounter += 1
        End While


        m_corners = New PointF() {corners_adjusted(0), corners_adjusted(1), corners_adjusted(2), corners_adjusted(3)}
        Me.Height = (getmaxY(corners_rotated) - getminY(corners_rotated))

        Me.Width = (getmaxX(corners_rotated) - getminX(corners_rotated))


        'Me.Region = New Region(createRegion(corners_adjusted))


        'midpoint of line connecting corner 0 and corner 3
        m_leftconnector = New Point(((corners_adjusted(0).x + corners_adjusted(3).x) / 2) + Me.location.X, ((corners_adjusted(0).y + corners_adjusted(3).y) / 2) + Me.location.Y)

        'midpoint of line connecting corner 1 and corner 2
        m_rightconnector = New Point(((corners_adjusted(1).x + corners_adjusted(2).x) / 2) + Me.location.X, ((corners_adjusted(1).y + corners_adjusted(2).y) / 2) + Me.location.Y)




    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Static fontwarningalreadygiven As Boolean = False


        If DoNotRedraw Then
            Return
        End If


        Static recursive As Boolean = False

        If Not recursive Then
            recursive = True





            MyBase.OnPaint(e)
            With e.Graphics
                .TranslateTransform(MyBase.ClientSize.Width / 2.0F, MyBase.ClientSize.Height / 2.0F)
                .RotateTransform(m_angle)
                .Clear(MyBase.BackColor)


                'MyBase.Width = 3 * MyBase.Font.Size
                'MyBase.Height = 3 * MyBase.Font.Size

                'MyBase.BackColor = Me.Parent.BackColor

                'MyBase.BackColor = Color.LightPink

                MyBase.BackColor = Color.Transparent
                Dim brush As New SolidBrush(Me.m_backcolor)

                Dim fAM_grid As FontFamily

                Dim fAM_char As FontFamily '= New FontFamily("Transponder AOE")
                Dim gridcharacter As Char = "*" 'can be any char except space because every char in the font draws same grid


                Try
                    fAM_grid = New FontFamily("Transponder Grid AOE")
                    'font_grid = New Font(fAM_grid, MyBase.Font.Size, MyBase.Font.Style, MyBase.Font.Unit)
                    fAM_char = New FontFamily("Transponder AOE")
                    'font_char = New Font(fAM_char, MyBase.Font.Size, FontStyle.Bold, MyBase.Font.Unit)
                Catch ex As Exception
                    If Not fontwarningalreadygiven Then
                        'MsgBox("The sign simulator can not work correctly because required fonts have not been properly installed")
                        fontwarningalreadygiven = True
                    End If

                    fAM_grid = Me.Font.FontFamily
                    fAM_char = Me.Font.FontFamily
                    gridcharacter = " " 'nothing will be drawn for grid
                End Try

                Dim font_char As Font = New Font(fAM_char, MyBase.Font.Size, FontStyle.Bold, MyBase.Font.Unit)


                If fontwarningalreadygiven Then
                    'normal fonts are larger then transponder fonts and overflow the card
                    font_char = New Font(fAM_char, 0.75 * MyBase.Font.Size, FontStyle.Bold, MyBase.Font.Unit)
                End If

                Dim font_grid = New Font(fAM_grid, MyBase.Font.Size, MyBase.Font.Style, MyBase.Font.Unit)
                

                Dim rectpen As Pen = New Pen(Me.m_backcolor)


        

                'these are before rotation

                Dim rectheight As Single = 1.15 * MyBase.Font.Size
                Dim rectwidth As Single = 0.75 * MyBase.Font.Size

                Dim rectx As Single = -1 / 2 * rectwidth
                Dim recty As Single = -1 / 2 * rectheight




                .FillRectangle(brush, rectx, recty, rectwidth, rectheight)

                'Dim rectect As New (corners_rotated(0), corners_rotated(1), corners_rotated(2), corners_rotated(3))

                brush = New SolidBrush(m_gridcolor)
                '.DrawString("*", font_grid, brush, MyBase.Font.Size / -8, MyBase.Font.Size / -4) 'any character will do
                


                .DrawString(gridcharacter, font_grid, brush, 1.32 * rectx, 1.47 * recty) 'any character will do


                brush = New SolidBrush(MyBase.ForeColor)
                '.DrawString(m_character, font_char, brush, MyBase.Font.Size / -8, MyBase.Font.Size / -4)

                If fontwarningalreadygiven Then
                    .DrawString(m_character, font_char, brush, 1.4 * rectx, recty)
                Else
                    .DrawString(m_character, font_char, brush, 1.32 * rectx, 1.47 * recty)
                End If


                brush.Dispose()



                'this is in relation to parents coordinates beacause that is how it is used??
                Dim corners_nonrotated As ArrayList = New ArrayList
              
              


                'get coordinates in reference to origin in center
                corners_nonrotated.Add(New PointF(-rectwidth / 2, -rectheight / 2))
                corners_nonrotated.Add(New PointF(rectwidth / 2, -rectheight / 2))
                corners_nonrotated.Add(New PointF(rectwidth / 2, rectheight / 2))
                corners_nonrotated.Add(New PointF(-rectwidth / 2, rectheight / 2))





                'rotate around center origen
                Dim corners_rotated As ArrayList = rotatecorners(corners_nonrotated)






                Dim corners_adjusted As ArrayList = New ArrayList


                'convert coordinants to uper left corner origen
                Dim loopcounter = 0
                While loopcounter < corners_rotated.Count

                    Dim xadj As Single = Me.Width / 2
                    Dim yadj As Single = Me.Height / 2
                    corners_adjusted.Add(New PointF(corners_rotated(loopcounter).x + xadj, corners_rotated(loopcounter).y + yadj))



                    loopcounter += 1
                End While





                MyBase.Height = (getmaxY(corners_rotated) - getminY(corners_rotated))

                MyBase.Width = (getmaxX(corners_rotated) - getminX(corners_rotated))

                'MsgBox(Me.Location.X.ToString + " , " + Me.Location.Y.ToString)
                'MsgBox(1 & " " & Me.location.X & " " & Me.location.Y & Constants.vbCrLf & MyBase.Location.X & " " & MyBase.Location.Y)

                Me.Region = New Region(createRegion(corners_adjusted))



                ''''store points of special interest

                'midpoint of line connecting corner 0 and corner 3
                m_leftconnector = New Point(((corners_adjusted(0).x + corners_adjusted(3).x) / 2) + Me.location.X, ((corners_adjusted(0).y + corners_adjusted(3).y) / 2) + Me.location.Y)

                'midpoint of line connecting corner 1 and corner 2
                m_rightconnector = New Point(((corners_adjusted(1).x + corners_adjusted(2).x) / 2) + Me.location.X, ((corners_adjusted(1).y + corners_adjusted(2).y) / 2) + Me.location.Y)



            End With
            
            recursive = False
        End If
    End Sub

    Private Function createRegion(ByVal corners As ArrayList) As System.Drawing.Drawing2D.GraphicsPath
        'this function takes an array of points (internal reference) 
        'and creates a region (parent referenced ??? not correct)

        Dim graphics_path As New System.Drawing.Drawing2D.GraphicsPath

        Dim loopcounter = 1 'starts with second corner

        While loopcounter < corners.Count

            Dim corner1 = corners(loopcounter - 1) 'New PointF(corners(loopcounter - 1).x + locx, corners(loopcounter - 1).y + locy)
            Dim corner2 = corners(loopcounter) 'New PointF(corners(loopcounter).x + locx, corners(loopcounter).y + locy)

            graphics_path.AddLine(corner1, corner2)
            loopcounter += 1
        End While

        Return graphics_path

    End Function







    'Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)


    '    MyBase.OnPaint(e)
    '    With e.Graphics
    '        .TranslateTransform(MyBase.ClientSize.Width / 2.0F, MyBase.ClientSize.Height / 2.0F)
    '        .RotateTransform(m_angle)
    '        .Clear(MyBase.BackColor)


    '        'MyBase.Width = 3 * MyBase.Font.Size
    '        'MyBase.Height = 3 * MyBase.Font.Size

    '        'MyBase.BackColor = Me.Parent.BackColor

    '        'MyBase.BackColor = Color.LightPink

    '        MyBase.BackColor = Color.Transparent
    '        Dim brush As New SolidBrush(Me.m_backcolor)


    '        Dim fAM_grid As FontFamily = New FontFamily("Transponder Grid AOE")
    '        Dim font_grid = New Font(fAM_grid, MyBase.Font.Size, MyBase.Font.Style, MyBase.Font.Unit)

    '        Dim fAM_char As FontFamily = New FontFamily("Transponder AOE")
    '        Dim font_char = New Font(fAM_char, MyBase.Font.Size, FontStyle.Bold, MyBase.Font.Unit)

    '        Dim rectpen As Pen = New Pen(Me.m_backcolor)


    '        'MyBase.Width = 0.78 * MyBase.Font.Size
    '        'MyBase.Height = 1.2 * MyBase.Font.Size


    '        'If m_angle >= 0 Then

    '        '    MyBase.Width = 1.35 * MyBase.Font.Size
    '        '    MyBase.Height = (1.35 - K * m_angle) * MyBase.Font.Size

    '        'Else

    '        'End If


    '        Dim rectheight As Single = 1.15 * MyBase.Font.Size
    '        Dim rectwidth As Single = 0.75 * MyBase.Font.Size
    '        '.DrawRectangle(rectpen, -1/2*rectwidth, -1/2rectheight, rectwidth, rectheight)



    '        'these refer to the cylindrical coordinates of 4 corners of the lite card

    '        Dim radius As Double = Math.Sqrt(((rectheight / 2.0) ^ 2) + ((rectwidth / 2.0) ^ 2))



    '        Dim corners_nonrotated As ArrayList = New ArrayList
    '        corners_nonrotated.Add(New PointF(rectwidth / -2, rectheight / 2))
    '        corners_nonrotated.Add(New PointF(rectwidth / 2, rectheight / 2))
    '        corners_nonrotated.Add(New PointF(rectwidth / 2, rectheight / -2))
    '        corners_nonrotated.Add(New PointF(rectwidth / -2, rectheight / -2))

    '        Dim corners_rotated As ArrayList = rotatecorners(corners_nonrotated)


    '        MyBase.Height = (getmaxY(corners_rotated) - getminY(corners_rotated))

    '        MyBase.Width = (getmaxX(corners_rotated) - getminX(corners_rotated))

    '        'Dim c1 As Single = (Convert.ToSingle(m_angle) * Math.PI / 180.0) - (Math.PI / 4.0)
    '        'Dim c2 As Single = (Convert.ToSingle(m_angle) * Math.PI / 180.0) + (Math.PI / 4.0)
    '        'Dim c3 As Single = (Convert.ToSingle(m_angle) * Math.PI / 180.0) + (3.0 * Math.PI / 4.0)
    '        'Dim c4 As Single = (Convert.ToSingle(m_angle) * Math.PI / 180.0) - (3.0 * Math.PI / 4.0)


    '        'Dim c1 As Double = (m_angle - 45) * Math.PI / 180
    '        'Dim c2 As Double = m_angle + 45 * Math.PI / 180
    '        'Dim c3 As Double = m_angle + 135 * Math.PI / 180
    '        'Dim c4 As Double = m_angle - 135 * Math.PI / 180

    '        'MyBase.Width = (heightweight * rectwidth + widthweight * rectheight) / 90      '1.35 * MyBase.Font.Size

    '        'MyBase.Height = (heightweight * rectheight + widthweight * rectwidth) / 90         '(1.35 - K * m_angle) * MyBase.Font.Size

    '        'Dim c_rect1 As Point2d = coordinates_functions.CylinderToRect(New Point2d(radius, c1))
    '        'Dim c_rect2 As Point2d = coordinates_functions.CylinderToRect(New Point2d(radius, c2))
    '        'Dim c_rect3 As Point2d = coordinates_functions.CylinderToRect(New Point2d(radius, c3))
    '        'Dim c_rect4 As Point2d = coordinates_functions.CylinderToRect(New Point2d(radius, c4))


    '        'Dim xarray As ArrayList = New ArrayList
    '        'Dim yarray As ArrayList = New ArrayList
    '        'xarray.Add(c_rect1.X)
    '        'xarray.Add(c_rect2.X)
    '        'xarray.Add(c_rect3.X)
    '        'xarray.Add(c_rect4.X)

    '        'yarray.Add(c_rect1.Y)
    '        'yarray.Add(c_rect2.Y)
    '        'yarray.Add(c_rect3.Y)
    '        'yarray.Add(c_rect4.Y)



    '        'Dim xmax = getmax(xarray)
    '        'Dim xmin = getmin(xarray)

    '        'Dim ymax = (getmax(yarray))
    '        'Dim ymin = (getmin(yarray))


    '        'MyBase.Width = xmax - xmin
    '        'MyBase.Height = ymax - ymin


    '        'these are before rotation
    '        Dim x As Single = -1 / 2 * rectwidth
    '        Dim y As Single = -1 / 2 * rectheight

    '        .FillRectangle(brush, x, y, rectwidth, rectheight)

    '        'Dim rect As New (corners_rotated(0), corners_rotated(1), corners_rotated(2), corners_rotated(3))

    '        brush = New SolidBrush(Color.Gray)
    '        '.DrawString("*", font_grid, brush, MyBase.Font.Size / -8, MyBase.Font.Size / -4) 'any character will do

    '        .DrawString("*", font_grid, brush, 1.32 * x, 1.47 * y) 'any character will do


    '        brush = New SolidBrush(MyBase.ForeColor)
    '        '.DrawString(m_character, font_char, brush, MyBase.Font.Size / -8, MyBase.Font.Size / -4)
    '        .DrawString(m_character, font_char, brush, 1.32 * x, 1.47 * y)

    '        brush.Dispose()
    '        Me.Region = New Region(createRegion(corners_rotated))

    '    End With
    'End Sub

    'Private Function InternalCoordinatesToParentCoordinats(ByVal pnt)
    '    'pnt is not typed so that it can be point, pointf or point2d

    '    pnt.x += Location.X
    '    pnt.y += Location.Y

    '    Return pnt

    'End Function
    'Private Function createRegion(ByVal corners As ArrayList) As System.Drawing.Drawing2D.GraphicsPath
    '    'this function takes an array of points (internal reference) 
    '    'and creates a region (parent referenced)

    '    Dim graphics_path As New System.Drawing.Drawing2D.GraphicsPath

    '    Dim loopcounter = 1 'starts with second corner

    '    While loopcounter < corners.Count
    '        graphics_path.AddLine(InternalCoordinatesToParentCoordinats(corners(loopcounter - 1)), InternalCoordinatesToParentCoordinats((corners(loopcounter))))
    '        loopcounter += 1
    '    End While
    '    'graphics_path.AddLine(InternalCoordinatesToParentCoordinats(corners(0)), InternalCoordinatesToParentCoordinats((corners(1)))
    '    'graphics_path.AddLine(corners(1), corners(2))

    '    'graphics_path.AddLine(corners(2), corners(3))
    '    'graphics_path.AddLine(corners(3), corners(4))

    '    Return graphics_path

    '    'graphics_path.AddPolygon(corners.ToArray())

    '    'Dim BaseRect As New RectangleF(X, Y, Width, Height)
    '    'Dim ArcRect As New RectangleF(BaseRect.Location, New SizeF(diameter, diameter))
    '    ''top left Arc
    '    'graphics_path.AddArc(ArcRect, 180, 90)
    '    'graphics_path.AddLine(X + CInt(diameter / 2), _
    '    'Y, X + Width - CInt(diameter / 2), Y)
    '    '' top right arc
    '    'ArcRect.X = BaseRect.Right - diameter
    '    'graphics_path.AddArc(ArcRect, 270, 90)
    '    'graphics_path.AddLine(X + Width, _
    '    'Y + CInt(diameter / 2), X + Width, _
    '    'Y + Height - CInt(diameter / 2))
    '    '' bottom right arc
    '    'ArcRect.Y = BaseRect.Bottom - diameter
    '    'graphics_path.AddArc(ArcRect, 0, 90)
    '    'graphics_path.AddLine(X + CInt(diameter / 2), _
    '    'Y + Height, X + Width - CInt(diameter / 2), _
    '    'Y + Height)
    '    '' bottom left arc
    '    'ArcRect.X = BaseRect.Left
    '    'graphics_path.AddArc(ArcRect, 90, 90)
    '    'graphics_path.AddLine(X, Y + CInt(diameter / 2), _
    '    'X, Y + Height - CInt(diameter / 2))
    '    'Return graphics_path
    'End Function




End Class




'''   old 10/16/08 below 
'Public Class LiteCard
'    Inherits Panel

'    Private m_angle As Integer = 0
'    Private m_character As Char
'    Private m_backcolor As Color
'    'Private m_sign As Char

'    Public Sub New()
'        ' Stop the flicker
'        Me.SetStyle(ControlStyles.UserPaint, True)
'        Me.SetStyle(ControlStyles.DoubleBuffer, True)
'        'Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
'        Me.SetStyle(ControlStyles.ResizeRedraw, True)
'        Me.UpdateStyles()

'        Me.m_backcolor = Color.Green
'    End Sub

'    <Description("Amount to rotate the sign"), _
'    Category("Appearance"), _
'    DefaultValue(0)> _
'    Public Property Angle() As Integer
'        Get
'            Return m_angle
'        End Get
'        Set(ByVal value As Integer)
'            m_angle = value
'            Invalidate()
'        End Set
'    End Property

'    'Private Overrides Property font() As Font
'    '    Get

'    '    End Get
'    '    Set(ByVal value)

'    '    End Set
'    'End Property
'    Property Backcolor() As Color
'        Get
'            Return m_backcolor
'        End Get
'        Set(ByVal value As Color)
'            m_backcolor = value
'            Invalidate()
'        End Set
'    End Property
'    Public Property character() As Char
'        Get
'            Return m_character
'        End Get
'        Set(ByVal value As Char)
'            m_character = value
'            Invalidate()
'        End Set
'    End Property

'    Public Property FontSize() As Single
'        Get
'            Return MyBase.Font.Size
'        End Get
'        Set(ByVal value As Single)

'            Dim fam As FontFamily = MyBase.Font.FontFamily
'            MyBase.Font = New Font(fam, value, MyBase.Font.Style)
'            Invalidate()
'        End Set
'    End Property

'    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)


'        MyBase.OnPaint(e)
'        With e.Graphics
'            .TranslateTransform(MyBase.ClientSize.Width / 2.0F, MyBase.ClientSize.Height / 2.0F)
'            .RotateTransform(m_angle)
'            .Clear(MyBase.BackColor)

'            'MyBase.Width = 3 * MyBase.Font.Size
'            'MyBase.Height = 3 * MyBase.Font.Size

'            MyBase.BackColor = Me.Parent.BackColor

'            'MyBase.BackColor = Color.LightPink

'            Dim brush As New SolidBrush(Me.m_backcolor)


'            Dim fAM_grid As FontFamily = New FontFamily("Transponder Grid AOE")
'            Dim font_grid = New Font(fAM_grid, MyBase.Font.Size, MyBase.Font.Style, MyBase.Font.Unit)

'            Dim fAM_char As FontFamily = New FontFamily("Transponder AOE")
'            Dim font_char = New Font(fAM_char, MyBase.Font.Size, FontStyle.Bold, MyBase.Font.Unit)

'            Dim rectpen As Pen = New Pen(Me.m_backcolor)

'            MyBase.Width = 1.35 * MyBase.Font.Size
'            MyBase.Height = 1.35 * MyBase.Font.Size


'            Dim rectheight As Single = 1.15 * MyBase.Font.Size
'            Dim rectwidth As Single = 0.75 * MyBase.Font.Size
'            '.DrawRectangle(rectpen, -1/2*rectwidth, -1/2rectheight, rectwidth, rectheight)

'            Dim x As Single = -1 / 2 * rectwidth
'            Dim y As Single = -1 / 2 * rectheight

'            .FillRectangle(brush, x, y, rectwidth, rectheight)


'            brush = New SolidBrush(Color.LightGray)
'            '.DrawString("*", font_grid, brush, MyBase.Font.Size / -8, MyBase.Font.Size / -4) 'any character will do

'            .DrawString("*", font_grid, brush, 1.32 * x, 1.47 * y) 'any character will do


'            brush = New SolidBrush(MyBase.ForeColor)
'            '.DrawString(m_character, font_char, brush, MyBase.Font.Size / -8, MyBase.Font.Size / -4)
'            .DrawString(m_character, font_char, brush, 1.32 * x, 1.47 * y)

'            brush.Dispose()
'        End With
'    End Sub

'End Class
