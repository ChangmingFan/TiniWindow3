<System.Serializable()> Public Class simulator_form
    Public StartUpDisplayPaternFile As String = "StartUpDisplayPatern.lcd"
    Dim formloaded2 As Boolean = False
    Dim my_cursors As Cursor()
    Enum cursor_enum
        _default
        mag_glass0
        mag_glass1
        mag_glass2
        hand_bulitin
        hand1
        hand2
        hand3
        disabled
    End Enum

    'Dim filter As String = "Data files|*.text; *.txt; *.dat; *.bat;|All Files| *.*"
    Dim filter_demodisplay As String = "Demo display files|*.lcd;|All Files| *.*"

    Dim filter_image As String = "Images|*.jpg; *.jpeg; *.bpm; *.gif; |All Files| *.*"


    Dim status As ArrayList = New ArrayList ' of strings to display in status bar
    'this flag specifies if the controll key is currently being pressed
    Dim controll_down As Boolean = False

    Dim min_cardsize As Single = 5
    'Dim min_cardsize As Single = 27
    'CMF 122812
    Dim max_cardsize As Single = 500


    Dim _location As System.Drawing.Point
    Dim stringstocyclethrough As ArrayList 'of integer
    Dim refreshindexintimer As Boolean = False
    Dim selectedpattern As Int16 = -1

    Dim curr_clickmode As Int16 = clickmodes.none
    'returned to after drag and zoom modes

    Dim ret_clickmode As Int16 = clickmodes.none
    'ret_clickmode
    'curr_clickmode = clickmodes
    Enum clickmodes
        none
        mypatterndesign
        signdrag
        signzoom
        imagedrag
        imagezoom


    End Enum


    Public cards_locked As Boolean = True

    Const PAN_CONSTANT As Single = 0.1

    Const BIGZOOMFACTOR As Single = 0.1
    Const SMALLZOOMFACTOR As Single = 0.005

    Const SIGNPANAMOUNT As Int16 = 2
    'these are used for making templates proportionaly spaced
    Const REALCARDHEIGHT As Single = 120
    Const REALCARDWIDTH As Single = 77
    Const MAX_REALSPACEBETWEENCARDS As Single = 50

    Enum card_pattern_type
        None = -1
        Custom
        Hor_line
        Vert_line
        Rev_arc
        Arc
        S_curve
        Rev_L
        Square
        L

    End Enum

    Public initialized As Boolean = False
    Dim normaldisplaysize As Point

    Private Sub TB_signtext_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_signtext.KeyPress
        e.Handled = True
    End Sub


    Private Sub set_cursors()



        'in order of enumration:
        '0_default()
        '1mag_glass0()
        '2mag_glass1()
        '3mag_glass2()
        '4hand_bulitin()
        '5hand1()
        '6hand2()
        '7hand3()
        '8disabled()

        Dim cursor0 As Cursor = Cursors.Default


        Dim bmp As New Bitmap(1, 1)
        bmp = Bitmap.FromFile("Cursors/magnify glass icon0.jpg")
        Dim cursor1 As Cursor = New Cursor(bmp.GetHicon)

        bmp = Bitmap.FromFile("Cursors/magnify glass icon1.jpg")
        Dim cursor2 As Cursor = New Cursor(bmp.GetHicon)

        bmp = Bitmap.FromFile("Cursors/magnify glass icon2.jpg")
        Dim cursor3 As Cursor = New Cursor(bmp.GetHicon)

        Dim cursor4 As Cursor = Cursors.Hand

        Dim cursor5 As Cursor = New Cursor(bmp.GetHicon)
        bmp = Bitmap.FromFile("Cursors/hand move icon1.jpg")

        Dim cursor6 As Cursor = New Cursor(bmp.GetHicon)
        bmp = Bitmap.FromFile("Cursors/hand move icon2.jpg")

        Dim cursor7 As Cursor = New Cursor(bmp.GetHicon)
        bmp = Bitmap.FromFile("Cursors/hand move icon3.jpg")

        Dim cursor8 As Cursor = Cursors.No


        bmp.Dispose()


        my_cursors = New Cursor() {cursor0, cursor1, cursor2, cursor3, cursor4, cursor5, cursor6, cursor7, cursor8}

    End Sub


    Private Sub position_Pan_cardbackground()

        Pan_cards.Location = New Point(-Pan_imageholder.Location.X, -Pan_imageholder.Location.Y)
        Pan_cards.Width = Pan_dislpayregion.Width
        Pan_cards.Height = Pan_dislpayregion.Height - StatusStrip.Height


    End Sub

    Private Sub set_color_templates()


        'text is what the user see displayed in the menue
        'tag contains the coded letters of the color pattern

        CMI_colorpattern0.Text = "All Red"
        CMI_colorpattern1.Text = "All Green"
        CMI_colorpattern2.Text = "All Blue"

        CMI_colorpattern3.Text = "All White"

        CMI_colorpattern4.Text = "RGWBRGWBRGWBRGWB"
        CMI_colorpattern5.Text = "RGRGRGRGRGRGRGRG"
        CMI_colorpattern6.Text = "RGGRWWRBBRGGRWWR"
        CMI_colorpattern7.Text = "RRGWWRRGWWRRGWWR"
        CMI_colorpattern8.Text = "WWGGWWGGWWGGWWGG"
        CMI_colorpattern9.Text = "WBRWWBBRRWWWBBBR"



        CMI_colorpattern0.Tag = "RRRRRRRRRRRRRRRRRRRR"
        CMI_colorpattern1.Tag = "GGGGGGGGGGGGGGGGGGGG"
        CMI_colorpattern2.Tag = "BBBBBBBBBBBBBBBBBBBB"
        CMI_colorpattern3.Tag = "WWWWWWWWWWWWWWWWWWWW"

        CMI_colorpattern4.Tag = "RGWBRGWBRGWBRGWBGWBR"
        CMI_colorpattern5.Tag = "RGRGRGRGRGRGRGRGRGRG"
        CMI_colorpattern6.Tag = "RGGRWWRBBRGGRWWRGGRW"
        CMI_colorpattern7.Tag = "RRGWWRRGWWRRGWWRRGWW"
        CMI_colorpattern8.Tag = "WWGGWWGGWWGGWWGGWWGG"
        CMI_colorpattern9.Tag = "WBRWWBBRRWWWBBBRRRWW"


        Form1.CMI_colorpattern0.Text = CMI_colorpattern0.Text
        Form1.CMI_colorpattern1.Text = CMI_colorpattern1.Text
        Form1.CMI_colorpattern2.Text = CMI_colorpattern2.Text

        Form1.CMI_colorpattern3.Text = CMI_colorpattern3.Text

        Form1.CMI_colorpattern4.Text = CMI_colorpattern4.Text
        Form1.CMI_colorpattern5.Text = CMI_colorpattern5.Text
        Form1.CMI_colorpattern6.Text = CMI_colorpattern6.Text
        Form1.CMI_colorpattern7.Text = CMI_colorpattern7.Text
        Form1.CMI_colorpattern8.Text = CMI_colorpattern8.Text
        Form1.CMI_colorpattern9.Text = CMI_colorpattern9.Text



        Form1.CMI_colorpattern0.Tag = CMI_colorpattern0.Tag
        Form1.CMI_colorpattern1.Tag = CMI_colorpattern1.Tag
        Form1.CMI_colorpattern2.Tag = CMI_colorpattern2.Tag
        Form1.CMI_colorpattern3.Tag = CMI_colorpattern3.Tag
        Form1.CMI_colorpattern4.Tag = CMI_colorpattern4.Tag
        Form1.CMI_colorpattern5.Tag = CMI_colorpattern5.Tag
        Form1.CMI_colorpattern6.Tag = CMI_colorpattern6.Tag
        Form1.CMI_colorpattern7.Tag = CMI_colorpattern7.Tag
        Form1.CMI_colorpattern8.Tag = CMI_colorpattern8.Tag
        Form1.CMI_colorpattern9.Tag = CMI_colorpattern9.Tag



    End Sub


    Public Sub _initialize()


        If Me.initialized Then
            Return
        End If


        Static currentlyrunning As Boolean = False
        If currentlyrunning Then
            Return
        End If

        LiteCard0.Visible = False
        LiteCard1.Visible = False
        LiteCard2.Visible = False
        LiteCard3.Visible = False
        LiteCard4.Visible = False
        LiteCard5.Visible = False
        LiteCard6.Visible = False
        LiteCard7.Visible = False
        LiteCard8.Visible = False
        LiteCard9.Visible = False
        LiteCard10.Visible = False
        LiteCard11.Visible = False
        LiteCard12.Visible = False
        LiteCard13.Visible = False
        LiteCard14.Visible = False
        LiteCard15.Visible = False
        LiteCard16.Visible = False

        'Changming 122412 add 1 line



        currentlyrunning = True

        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.UpdateStyles()

        Lbl_debug.Text = 0
        'Lbut_BG_Default
        'Me.Location = New System.Drawing.Point(50, 50) ''(70, 95) -061909
        LiteCard0.Backcolor = Form1.Demo_CardColor
        LiteCard1.Backcolor = Form1.Demo_CardColor
        LiteCard2.Backcolor = Form1.Demo_CardColor
        LiteCard3.Backcolor = Form1.Demo_CardColor
        LiteCard4.Backcolor = Form1.Demo_CardColor
        LiteCard5.Backcolor = Form1.Demo_CardColor
        LiteCard6.Backcolor = Form1.Demo_CardColor
        LiteCard7.Backcolor = Form1.Demo_CardColor
        LiteCard8.Backcolor = Form1.Demo_CardColor
        LiteCard9.Backcolor = Form1.Demo_CardColor

        LiteCard0.ForeColor = Form1.demo_textcolor
        LiteCard1.ForeColor = Form1.demo_textcolor
        LiteCard2.ForeColor = Form1.demo_textcolor
        LiteCard3.ForeColor = Form1.demo_textcolor
        LiteCard4.ForeColor = Form1.demo_textcolor
        LiteCard5.ForeColor = Form1.demo_textcolor
        LiteCard6.ForeColor = Form1.demo_textcolor
        LiteCard7.ForeColor = Form1.demo_textcolor
        LiteCard8.ForeColor = Form1.demo_textcolor
        LiteCard9.ForeColor = Form1.demo_textcolor
        LiteCard10.ForeColor = Form1.demo_textcolor
        LiteCard11.ForeColor = Form1.demo_textcolor
        LiteCard12.ForeColor = Form1.demo_textcolor
        LiteCard13.ForeColor = Form1.demo_textcolor
        LiteCard14.ForeColor = Form1.demo_textcolor
        LiteCard15.ForeColor = Form1.demo_textcolor
        LiteCard16.ForeColor = Form1.demo_textcolor
        'Changming 122412 add 1 line

        default_zoom()


        position_Pan_cardbackground()

        Form1.demo_set_ratio()

        'demo is the small blue screen area on TiniWindow next to green 
        '122812:

        'If IO.File.Exists(StartUpDisplayPaternFile) Then

        '    Me.importDisplayPattern(StartUpDisplayPaternFile)
        'End If



        'positionandsizecards()

        _refresh()

        'Label3_Click(Lbut_BG_Default, New System.EventArgs)

        set_cursors()


        If Me.WindowState = FormWindowState.Normal Then
            normaldisplaysize = Pan_dislpayregion.Size
        End If

        set_color_templates()


        Timer_formloaded.Start()


        initialized = True
        currentlyrunning = False

        'If Not formloaded2 Then
        '    MsgBox("not")
        'End If
    End Sub

    Private Sub simulator_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim screenRectangle As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea
        Dim screenHeight As Int32 = screenRectangle.Height
        Dim screenWidth As Int32 = screenRectangle.Width

        Me.Location = New System.Drawing.Point(Form1.Location.X - Me.Width - 6, Form1.Location.Y) ''(70, 95) -061909

        LiteCard0.character = "0"
        LiteCard1.character = "1"
        LiteCard2.character = "2"
        LiteCard3.character = "3"
        LiteCard4.character = "4"
        LiteCard5.character = "5"
        LiteCard6.character = "6"
        LiteCard7.character = "7"
        LiteCard8.character = "8"
        LiteCard9.character = "9"
        LiteCard10.character = "A"
        LiteCard11.character = "B"
        LiteCard12.character = "C"
        LiteCard13.character = "D"
        LiteCard14.character = "E"
        LiteCard14.character = "F"
        LiteCard15.character = "G"

        LiteCard16.character = "H"
        'Changming



        LiteCard0.Backcolor = Form1.Demo_CardColor
        LiteCard1.Backcolor = Form1.Demo_CardColor
        LiteCard2.Backcolor = Form1.Demo_CardColor
        LiteCard3.Backcolor = Form1.Demo_CardColor
        LiteCard4.Backcolor = Form1.Demo_CardColor
        LiteCard5.Backcolor = Form1.Demo_CardColor
        LiteCard6.Backcolor = Form1.Demo_CardColor
        LiteCard7.Backcolor = Form1.Demo_CardColor
        LiteCard8.Backcolor = Form1.Demo_CardColor
        LiteCard9.Backcolor = Form1.Demo_CardColor
        LiteCard10.Backcolor = Form1.Demo_CardColor
        LiteCard11.Backcolor = Form1.Demo_CardColor
        LiteCard12.Backcolor = Form1.Demo_CardColor
        LiteCard13.Backcolor = Form1.Demo_CardColor
        LiteCard14.Backcolor = Form1.Demo_CardColor
        LiteCard15.Backcolor = Form1.Demo_CardColor
        LiteCard16.Backcolor = Form1.Demo_CardColor
        'Changming

        LiteCard0.ForeColor = Form1.demo_textcolor
        LiteCard1.ForeColor = Form1.demo_textcolor
        LiteCard2.ForeColor = Form1.demo_textcolor
        LiteCard3.ForeColor = Form1.demo_textcolor
        LiteCard4.ForeColor = Form1.demo_textcolor
        LiteCard5.ForeColor = Form1.demo_textcolor
        LiteCard6.ForeColor = Form1.demo_textcolor
        LiteCard7.ForeColor = Form1.demo_textcolor
        LiteCard8.ForeColor = Form1.demo_textcolor
        LiteCard9.ForeColor = Form1.demo_textcolor
        LiteCard10.ForeColor = Form1.demo_textcolor
        LiteCard11.ForeColor = Form1.demo_textcolor
        LiteCard12.ForeColor = Form1.demo_textcolor
        LiteCard13.ForeColor = Form1.demo_textcolor
        LiteCard14.ForeColor = Form1.demo_textcolor
        LiteCard15.ForeColor = Form1.demo_textcolor
        LiteCard16.ForeColor = Form1.demo_textcolor
        'Changming


        formloaded2 = True

    End Sub

    Public Sub _refresh()


        Tim_trick1.Start()

        'Form1.Focus()
    End Sub

    Private Sub Tim_trick1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tim_trick1.Tick



        ''temporarily disable for dubugging
        'Tim_trick1.Stop()
        'Return

        'Dim testbool = Me.Visible
        'Dim testbool2 As Boolean = LiteCard0.Visible
        'TB_signtext.Text = Form1.Txt_demo_oneline.Text

        'set character
        If LiteCard0.character <> Form1.LiteCard0.character Then

            'LiteCard0.DoNotRedraw = False
            LiteCard0.character = Form1.LiteCard0.character

            ' LiteCard0.Visible = False
            'LiteCard0.Visible = True
        End If

        If LiteCard1.character <> Form1.LiteCard1.character Then
            LiteCard1.character = Form1.LiteCard1.character
        End If

        If LiteCard2.character <> Form1.LiteCard2.character Then
            LiteCard2.character = Form1.LiteCard2.character
        End If
        If LiteCard3.character <> Form1.LiteCard3.character Then
            LiteCard3.character = Form1.LiteCard3.character
        End If
        If LiteCard4.character <> Form1.LiteCard4.character Then
            LiteCard4.character = Form1.LiteCard4.character
        End If
        If LiteCard5.character <> Form1.LiteCard5.character Then
            LiteCard5.character = Form1.LiteCard5.character
        End If
        If LiteCard6.character <> Form1.LiteCard6.character Then
            LiteCard6.character = Form1.LiteCard6.character
        End If
        If LiteCard7.character <> Form1.LiteCard7.character Then
            LiteCard7.character = Form1.LiteCard7.character
        End If
        If LiteCard8.character <> Form1.LiteCard8.character Then
            LiteCard8.character = Form1.LiteCard8.character
        End If
        If LiteCard9.character <> Form1.LiteCard9.character Then
            LiteCard9.character = Form1.LiteCard9.character
        End If
        If LiteCard10.character <> Form1.LiteCard10.character Then
            LiteCard10.character = Form1.LiteCard10.character
        End If

        If LiteCard11.character <> Form1.LiteCard11.character Then
            LiteCard11.character = Form1.LiteCard11.character
        End If

        If LiteCard12.character <> Form1.LiteCard12.character Then
            LiteCard12.character = Form1.LiteCard12.character
        End If
        If LiteCard13.character <> Form1.LiteCard13.character Then
            LiteCard13.character = Form1.LiteCard13.character
        End If
        If LiteCard14.character <> Form1.LiteCard14.character Then
            LiteCard14.character = Form1.LiteCard14.character
        End If

        If LiteCard15.character <> Form1.LiteCard15.character Then
            LiteCard15.character = Form1.LiteCard15.character
        End If

        If LiteCard16.character <> Form1.LiteCard16.character Then
            LiteCard16.character = Form1.LiteCard16.character
        End If
        'Changming

        'set visibility
        'If LiteCard0.Visible <> Form1.LiteCard0.Visible Then
        '    LiteCard0.Visible = Form1.LiteCard0.Visible
        'End If
        'If LiteCard1.Visible <> Form1.LiteCard1.Visible Then
        '    LiteCard1.Visible = Form1.LiteCard1.Visible
        'End If
        'If LiteCard2.Visible <> Form1.LiteCard2.Visible Then
        '    LiteCard2.Visible = Form1.LiteCard2.Visible
        'End If
        'If LiteCard3.Visible <> Form1.LiteCard3.Visible Then
        '    LiteCard3.Visible = Form1.LiteCard3.Visible
        'End If
        'If LiteCard4.Visible <> Form1.LiteCard4.Visible Then
        '    LiteCard4.Visible = Form1.LiteCard4.Visible
        'End If
        'If LiteCard5.Visible <> Form1.LiteCard5.Visible Then
        '    LiteCard5.Visible = Form1.LiteCard5.Visible
        'End If
        'If LiteCard6.Visible <> Form1.LiteCard6.Visible Then
        '    LiteCard6.Visible = Form1.LiteCard6.Visible
        'End If
        'If LiteCard7.Visible <> Form1.LiteCard7.Visible Then
        '    LiteCard7.Visible = Form1.LiteCard7.Visible
        'End If
        'If LiteCard8.Visible <> Form1.LiteCard8.Visible Then
        '    LiteCard8.Visible = Form1.LiteCard8.Visible
        'End If
        'If LiteCard9.Visible <> Form1.LiteCard9.Visible Then
        '    LiteCard9.Visible = Form1.LiteCard9.Visible
        'End If
        'If LiteCard10.Visible <> Form1.LiteCard10.Visible Then
        '    LiteCard10.Visible = Form1.LiteCard10.Visible
        'End If
        'If LiteCard11.Visible <> Form1.LiteCard11.Visible Then
        '    LiteCard11.Visible = Form1.LiteCard11.Visible
        'End If
        'If LiteCard12.Visible <> Form1.LiteCard12.Visible Then
        '    LiteCard12.Visible = Form1.LiteCard12.Visible
        'End If
        'If LiteCard13.Visible <> Form1.LiteCard13.Visible Then
        '    LiteCard13.Visible = Form1.LiteCard13.Visible
        'End If
        'If LiteCard14.Visible <> Form1.LiteCard14.Visible Then
        '    LiteCard14.Visible = Form1.LiteCard14.Visible
        'End If
        'If LiteCard15.Visible <> Form1.LiteCard15.Visible Then
        '    LiteCard15.Visible = Form1.LiteCard15.Visible
        'End If






        If Form1.Timer_demo.Enabled Then

            Tim_trick1.Interval = Form1.Timer_demo.Interval

            Tim_trick1.Start()
        Else
            Tim_trick1.Interval = 1
        End If


        'Pan_cards.Invalidate()




    End Sub

    Private Sub But_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_close.Click
        Me.Close()
    End Sub

    Private Sub simulator_form_LocationChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LocationChanged
        _location = Me.Location
    End Sub

    Private Sub deselectect_all_buttons()
        'Form1.mark_unselected(Me.LbL_custom)
        ' Lbut_custon_start.Text = "Start"
        Me.LbL_custom.BackColor = Color.LightGreen
        Lbl_standard.BackColor = Color.LightGreen
        Form1.mark_unselected(Me.Lbut_custom_export)
        Form1.mark_unselected(Me.Lbut_custon_import)
        Form1.mark_unselected(Me.Lbut_custon_start)
        Form1.mark_unselected(Me.PB_arc)
        Form1.mark_unselected(Me.PB_horr_line)
        Form1.mark_unselected(Me.PB_diagdown_line)
        Form1.mark_unselected(Me.PB_rev_arc)
        Form1.mark_unselected(Me.PB_m_curve)
        Form1.mark_unselected(Me.PB_s_curve)
        Form1.mark_unselected(Me.PB_diagup_line)
        Form1.mark_unselected(Me.PB_vert_line)


    End Sub
    Private Sub But_shape_straight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_shape_straight.Click



        cards_shape_HorLine()
        'Form1.positionandsizecards()
        selectedpattern = card_pattern_type.Hor_line

        cards_locked = True


        deselectect_all_buttons()
        Form1.mark_selected(sender)



    End Sub


    Const SIN_COS45 As Double = 0.70710678118654757

    Public Sub cards_shape_diagup_line()



        LiteCard0.DoNotRedraw = True
        LiteCard1.DoNotRedraw = True
        LiteCard2.DoNotRedraw = True
        LiteCard3.DoNotRedraw = True
        LiteCard4.DoNotRedraw = True
        LiteCard5.DoNotRedraw = True
        LiteCard6.DoNotRedraw = True
        LiteCard7.DoNotRedraw = True

        LiteCard8.DoNotRedraw = True
        LiteCard9.DoNotRedraw = True
        LiteCard10.DoNotRedraw = True
        LiteCard11.DoNotRedraw = True
        LiteCard12.DoNotRedraw = True
        LiteCard13.DoNotRedraw = True
        LiteCard14.DoNotRedraw = True
        LiteCard15.DoNotRedraw = True
        LiteCard16.DoNotRedraw = True
        'Changming



        LiteCard0.Angle = -45
        LiteCard1.Angle = -45
        LiteCard2.Angle = -45
        LiteCard3.Angle = -45
        LiteCard4.Angle = -45
        LiteCard5.Angle = -45
        LiteCard6.Angle = -45
        LiteCard7.Angle = -45

        LiteCard8.Angle = -45
        LiteCard9.Angle = -45
        LiteCard10.Angle = -45
        LiteCard11.Angle = -45
        LiteCard12.Angle = -45
        LiteCard13.Angle = -45
        LiteCard14.Angle = -45
        LiteCard15.Angle = -45

        LiteCard16.Angle = -45
        'Changming


        If LiteCard0.FontSize > maxfontsize(pattern.diagUpLine, Form1.linelength) Then
            LiteCard0.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard1.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard2.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard3.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard4.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard5.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard6.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard7.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard8.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard9.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard10.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard11.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard12.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard13.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard14.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard15.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)

            LiteCard16.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            'Changming

        End If




        'vertical component is in ceter of pan_card
        'adjust for card height
        'Dim y As Int16 = Pan_cards.Height / 2 - maxcarddemension() / 2



        'center cards - card4 left of center card5 right of center

        Dim centerx As Single = Pan_cards.Width / 2
        Dim centery As Single = Pan_cards.Height / 2

        Dim ratio_realsize_to_viewsize As Single = LiteCard0.cardwidth / REALCARDWIDTH
        'REALCARDHEIGHT As Single = 120
        '       Const REALCARDWIDTH As Single = 77
        '      Const MAX_REALSPACEBETWEENCARDS

        Dim dxy_percard = (REALCARDWIDTH + MAX_REALSPACEBETWEENCARDS) * SIN_COS45 * ratio_realsize_to_viewsize
        'Dim dy_percard = (REALCARDWIDTH + MAX_REALSPACEBETWEENCARDS) * SIN_COS45 * ratio_realsize_to_viewsize

        Dim positions As ArrayList = New ArrayList

        Dim loopcounter As Integer = 0
        Dim currentworkingindex As Integer
        Dim cardstartingwith As Integer
        Dim currentx As Integer
        Dim currenty As Integer
        While loopcounter < Form1.linelength
            'create empty entries that we will then full using the correct index
            positions.Add(Nothing)

            loopcounter += 1
        End While

        dxy_percard /= 0.99 'first time through loop starting value
        Do
            dxy_percard *= 0.99
            If dxy_percard / SIN_COS45 < 1.2 * LiteCard1.cardwidth Then

                'the light cards can not fit in the display area
                'make sign smaller and retry from beginning

                'zoom out multiple times because loop was taking too long 
                Me.signZoomOutSmall()
                Me.signZoomOutSmall()
                ratio_realsize_to_viewsize = LiteCard0.cardwidth / REALCARDWIDTH
                dxy_percard = (REALCARDWIDTH + MAX_REALSPACEBETWEENCARDS) * ratio_realsize_to_viewsize * SIN_COS45

            End If





            If Form1.linelength Mod 2 = 0 Then
                cardstartingwith = Form1.linelength / 2
                'adjust for 0 base index
                cardstartingwith -= 1

                currentworkingindex = cardstartingwith



                currentx = centerx
                'move one card space from ceter
                currentx -= dxy_percard
                'adjust for fact that center of form is on a conector half way between cards
                'move card closer to center
                currentx += (dxy_percard / SIN_COS45 - LiteCard0.cardwidth) * SIN_COS45 '/ 2 'MAX_REALSPACEBETWEENCARDS * ratio_realsize_to_viewsize * SIN_COS45

                'adjust from referencing center of card to referencing left edge 
                currentx -= LiteCard0.Width / 2.0

                currenty = centery
                'move one card space from ceter
                currenty += dxy_percard
                'adjust for fact that center of form is on a conector half way between cards
                'move closer to center
                currenty -= (dxy_percard / SIN_COS45 - LiteCard0.cardwidth) * SIN_COS45 '/ 2  'MAX_REALSPACEBETWEENCARDS * ratio_realsize_to_viewsize * SIN_COS45

                'adjust from referencing center of card to referencing left edge 
                currenty -= LiteCard0.Height / 2.0




            Else

                cardstartingwith = (Form1.linelength + 1) / 2
                'adjust for 0 base index
                cardstartingwith -= 1

                currentworkingindex = cardstartingwith
                currentx = centerx
                'adjust from referencing center of card to referencing left edge 
                currentx -= LiteCard1.Width / 2.0


                currenty = centery
                'adjust from referencing center of card to referencing left edge 
                currenty -= LiteCard1.Height / 2.0


            End If


            loopcounter = cardstartingwith
            While loopcounter >= 0

                positions(loopcounter) = New PointF(currentx, currenty)
                currentx -= dxy_percard
                currenty += dxy_percard
                loopcounter -= 1
            End While

            loopcounter = cardstartingwith + 1
            currentx = positions(cardstartingwith).x + dxy_percard
            currenty = positions(cardstartingwith).y - dxy_percard
            While loopcounter < Form1.linelength

                positions(loopcounter) = New PointF(currentx, currenty)
                currentx += dxy_percard
                currenty -= dxy_percard
                loopcounter += 1
            End While



            Try

                'try blcok is cheeting way to get around fact that we are setting values for 16 cards
                'but the array list is the lenght of howmany cards the user has selected 

                LiteCard0.location = positions(0)
                LiteCard1.location = positions(1)
                LiteCard2.location = positions(2)
                LiteCard3.location = positions(3)
                LiteCard4.location = positions(4)
                LiteCard5.location = positions(5)
                LiteCard6.location = positions(6)
                LiteCard7.location = positions(7)
                LiteCard8.location = positions(8)
                LiteCard9.location = positions(9)
                LiteCard10.location = positions(10)
                LiteCard11.location = positions(11)
                LiteCard12.location = positions(12)
                LiteCard13.location = positions(13)
                LiteCard14.location = positions(14)
                LiteCard15.location = positions(15)
                LiteCard16.location = positions(16)
                'Changming

            Catch ex As Exception



            End Try



        Loop Until (cardswithinviewingarea())

        'MsgBox(LiteCard0.FontSize)


        Pan_cards.Invalidate()

        LiteCard0.DoNotRedraw = False
        LiteCard1.DoNotRedraw = False
        LiteCard2.DoNotRedraw = False
        LiteCard3.DoNotRedraw = False
        LiteCard4.DoNotRedraw = False
        LiteCard5.DoNotRedraw = False
        LiteCard6.DoNotRedraw = False
        LiteCard7.DoNotRedraw = False

        LiteCard8.DoNotRedraw = False
        LiteCard9.DoNotRedraw = False
        LiteCard10.DoNotRedraw = False
        LiteCard11.DoNotRedraw = False
        LiteCard12.DoNotRedraw = False
        LiteCard13.DoNotRedraw = False
        LiteCard14.DoNotRedraw = False
        LiteCard15.DoNotRedraw = False
        LiteCard16.DoNotRedraw = False
        'Changming


        Form1.positionandsizecards()
        Timer_delayed_invalidate.Start()









        Return

        'below is old code o be deleted when new code is tested

        'reduce flickering and speed up functionality by not redrawing lite card untill end of function
        LiteCard0.DoNotRedraw = True
        LiteCard1.DoNotRedraw = True
        LiteCard2.DoNotRedraw = True
        LiteCard3.DoNotRedraw = True
        LiteCard4.DoNotRedraw = True
        LiteCard5.DoNotRedraw = True
        LiteCard6.DoNotRedraw = True
        LiteCard7.DoNotRedraw = True

        LiteCard8.DoNotRedraw = True
        LiteCard9.DoNotRedraw = True
        LiteCard10.DoNotRedraw = True
        LiteCard11.DoNotRedraw = True
        LiteCard12.DoNotRedraw = True
        LiteCard13.DoNotRedraw = True
        LiteCard14.DoNotRedraw = True
        LiteCard15.DoNotRedraw = True
        LiteCard16.DoNotRedraw = True
        'Changming


        LiteCard0.Angle = -45
        LiteCard1.Angle = -45
        LiteCard2.Angle = -45
        LiteCard3.Angle = -45 '
        LiteCard4.Angle = -45 '-angle
        LiteCard5.Angle = -45 '-angle
        LiteCard6.Angle = -45 ' -angle
        LiteCard7.Angle = -45 '-angle

        LiteCard8.Angle = -45 '-angle
        LiteCard9.Angle = -45 '-angle
        LiteCard10.Angle = -45
        LiteCard11.Angle = -45
        LiteCard12.Angle = -45
        LiteCard13.Angle = -45 '
        LiteCard14.Angle = -45 '-angle
        LiteCard15.Angle = -45 '-angle
        LiteCard16.Angle = -45 '-angle
        'Changming






        'postition cards
        'determine position of first and last card 
        'then position remaining along line 
        Dim xfirstcard As Single
        Dim yfirstcard As Single

        Dim xlastcard As Single
        Dim ylastcard As Single

        'Dim loopcounter As Int16 = 0

        Dim xstep As Single
        Dim ystep As Single
        'calculate postion of first card


        'why x is width/40 is a mystery to me and was determined by fidling arround
        'y is the way it should be multiply by 1.05 to give a space from the bottom edge
        xfirstcard = LiteCard0.Width / 40
        yfirstcard = (Pan_dislpayregion.Height - StatusStrip.Height) - 1.05 * LiteCard0.Height



        LiteCard0.location = New PointF(xfirstcard, yfirstcard)



        'calculate postion of last card
        'why y is height/40 is a mystery to me and was determined by fiddling arround
        xlastcard = Pan_dislpayregion.Width - 1.05 * LiteCard0.Width
        ylastcard = LiteCard0.Height / 40


        If Form1.settings(Form1.settingsindex.linelength) = 4 Then
            LiteCard3.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard3.location.X - LiteCard0.location.X) / 3
            ystep = (LiteCard3.location.Y - LiteCard0.location.Y) / 3
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 5 Then
            LiteCard4.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard4.location.X - LiteCard0.location.X) / 4
            ystep = (LiteCard4.location.Y - LiteCard0.location.Y) / 4
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 6 Then
            LiteCard5.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard5.location.X - LiteCard0.location.X) / 5
            ystep = (LiteCard5.location.Y - LiteCard0.location.Y) / 5
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 7 Then
            LiteCard6.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard6.location.X - LiteCard0.location.X) / 6
            ystep = (LiteCard6.location.Y - LiteCard0.location.Y) / 6
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 8 Then
            LiteCard7.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard7.location.X - LiteCard0.location.X) / 7
            ystep = (LiteCard7.location.Y - LiteCard0.location.Y) / 7
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 9 Then
            LiteCard8.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard8.location.X - LiteCard0.location.X) / 8
            ystep = (LiteCard8.location.Y - LiteCard0.location.Y) / 8
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 10 Then
            LiteCard9.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard9.location.X - LiteCard0.location.X) / 9
            ystep = (LiteCard9.location.Y - LiteCard0.location.Y) / 9


        ElseIf Form1.settings(Form1.settingsindex.linelength) = 11 Then
            LiteCard10.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard10.location.X - LiteCard0.location.X) / 10
            ystep = (LiteCard10.location.Y - LiteCard0.location.Y) / 10
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 12 Then
            LiteCard11.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard11.location.X - LiteCard0.location.X) / 11
            ystep = (LiteCard11.location.Y - LiteCard0.location.Y) / 11
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 13 Then
            LiteCard12.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard12.location.X - LiteCard0.location.X) / 12
            ystep = (LiteCard12.location.Y - LiteCard0.location.Y) / 12
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 14 Then
            LiteCard13.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard13.location.X - LiteCard0.location.X) / 13
            ystep = (LiteCard13.location.Y - LiteCard0.location.Y) / 13
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 15 Then
            LiteCard14.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard14.location.X - LiteCard0.location.X) / 14
            ystep = (LiteCard14.location.Y - LiteCard0.location.Y) / 14

        ElseIf Form1.settings(Form1.settingsindex.linelength) = 16 Then
            LiteCard15.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard15.location.X - LiteCard0.location.X) / 15
            ystep = (LiteCard15.location.Y - LiteCard0.location.Y) / 15


        ElseIf Form1.settings(Form1.settingsindex.linelength) = 17 Then
            LiteCard16.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard16.location.X - LiteCard0.location.X) / 16
            ystep = (LiteCard16.location.Y - LiteCard0.location.Y) / 16
            'Changming

        Else
            MsgBox("invalid line lenght detected in cards_shape_diaglineup()")

        End If




        'place remaining cards on line connecting first and last card
        loopcounter = 1 'start with card 1, card 0 already placed

        While loopcounter < Form1.settings(Form1.settingsindex.linelength) - 1

            If loopcounter = 1 Then

                LiteCard1.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 2 Then

                LiteCard2.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 3 Then

                LiteCard3.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 4 Then

                LiteCard4.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 5 Then

                LiteCard5.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 6 Then

                LiteCard6.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 7 Then

                LiteCard7.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 8 Then

                LiteCard8.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))

            ElseIf loopcounter = 9 Then

                LiteCard9.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 10 Then

                LiteCard10.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 11 Then

                LiteCard11.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 12 Then

                LiteCard12.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 13 Then

                LiteCard13.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 14 Then

                LiteCard14.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            Else
                MsgBox("invalid loopcounter value in cards_shapr_diagup_line")
            End If

            loopcounter += 1

        End While



        'determine angle of line so that cards may be properly angled

        Dim hypotenuse As Single = Math.Sqrt((LiteCard1.location.X - LiteCard0.location.X) * (LiteCard1.location.X - LiteCard0.location.X) + (LiteCard1.location.Y - LiteCard0.location.Y) * (LiteCard1.location.Y - LiteCard0.location.Y))
        Dim oposite As Single = LiteCard0.location.Y - LiteCard1.location.Y
        Dim angle As Single = Math.Asin(oposite / hypotenuse)

        angle *= 180 / Math.PI

        'rotate cards
        LiteCard0.Angle = -angle
        LiteCard1.Angle = -angle
        LiteCard2.Angle = -angle
        LiteCard3.Angle = -angle
        LiteCard4.Angle = -angle
        LiteCard5.Angle = -angle
        LiteCard6.Angle = -angle
        LiteCard7.Angle = -angle

        LiteCard8.Angle = -angle
        LiteCard9.Angle = -angle
        LiteCard10.Angle = -angle
        LiteCard11.Angle = -angle
        LiteCard12.Angle = -angle
        LiteCard13.Angle = -angle
        LiteCard14.Angle = -angle
        LiteCard15.Angle = -angle
        LiteCard16.Angle = -angle
        'Changming



        Pan_cards.Invalidate()

        LiteCard0.DoNotRedraw = False
        LiteCard1.DoNotRedraw = False
        LiteCard2.DoNotRedraw = False
        LiteCard3.DoNotRedraw = False
        LiteCard4.DoNotRedraw = False
        LiteCard5.DoNotRedraw = False
        LiteCard6.DoNotRedraw = False
        LiteCard7.DoNotRedraw = False

        LiteCard8.DoNotRedraw = False
        LiteCard9.DoNotRedraw = False
        LiteCard10.DoNotRedraw = False
        LiteCard11.DoNotRedraw = False
        LiteCard12.DoNotRedraw = False
        LiteCard13.DoNotRedraw = False
        LiteCard14.DoNotRedraw = False
        LiteCard15.DoNotRedraw = False
        LiteCard16.DoNotRedraw = False
        'Changming


        Form1.positionandsizecards()
        Timer_delayed_invalidate.Start()
    End Sub

    Public Sub cards_shape_vert_line()

        'locate in center
        LiteCard0.DoNotRedraw = True
        LiteCard1.DoNotRedraw = True
        LiteCard2.DoNotRedraw = True
        LiteCard3.DoNotRedraw = True
        LiteCard4.DoNotRedraw = True
        LiteCard5.DoNotRedraw = True
        LiteCard6.DoNotRedraw = True
        LiteCard7.DoNotRedraw = True

        LiteCard8.DoNotRedraw = True
        LiteCard9.DoNotRedraw = True
        LiteCard10.DoNotRedraw = True
        LiteCard11.DoNotRedraw = True
        LiteCard12.DoNotRedraw = True
        LiteCard13.DoNotRedraw = True
        LiteCard14.DoNotRedraw = True
        LiteCard15.DoNotRedraw = True
        LiteCard16.DoNotRedraw = True
        'Changming



        LiteCard0.Angle = 0
        LiteCard1.Angle = 0
        LiteCard2.Angle = 0
        LiteCard3.Angle = 0
        LiteCard4.Angle = 0
        LiteCard5.Angle = 0
        LiteCard6.Angle = 0
        LiteCard7.Angle = 0

        LiteCard8.Angle = 0
        LiteCard9.Angle = 0
        LiteCard10.Angle = 0
        LiteCard11.Angle = 0
        LiteCard12.Angle = 0
        LiteCard13.Angle = 0
        LiteCard14.Angle = 0
        LiteCard15.Angle = 0
        LiteCard16.Angle = 0
        'Changming







        'vertical component is in ceter of pan_card
        'adjust for card height
        Dim x As Int16 = Pan_cards.Width / 2 - mincarddemension() / 2



        'center cards - card4 left of center card5 right of center

        Dim centery As Single = Pan_cards.Height / 2

        Dim ratio_realsize_to_viewsize As Single = maxcarddemension() / REALCARDHEIGHT
        'REALCARDHEIGHT As Single = 120
        '       Const REALCARDWIDTH As Single = 77
        '      Const MAX_REALSPACEBETWEENCARDS

        'MAX_REALSPACEBETWEENCARDS is not used entirely correctly here
        'we are pretendind we can use this space vertically but in reality the cable attach to middle of side 
        'meaning this drawing is more space then reality
        Dim dy_percard = (REALCARDHEIGHT + MAX_REALSPACEBETWEENCARDS) * ratio_realsize_to_viewsize

        Dim ypositions As ArrayList = New ArrayList
        Dim loopcounter As Integer = 0
        Dim currentworkingindex As Integer
        Dim cardstartingwith As Integer
        Dim currenty As Integer
        While loopcounter < Form1.linelength
            'create empty entries that we will then full using the correct index
            ypositions.Add(Nothing)

            loopcounter += 1
        End While

        dy_percard /= 0.99 'first time through loop starting value
        Do
            dy_percard *= 0.99
            If dy_percard < 1.05 * LiteCard1.Height Then

                'the light cards can not fit in the display area
                'make sign smaller and retry from beginning

                'zoom out multiple times because loop was taking too long 
                Me.signZoomOutSmall()
                Me.signZoomOutSmall()
                ratio_realsize_to_viewsize = maxcarddemension() / REALCARDHEIGHT
                dy_percard = (REALCARDHEIGHT + MAX_REALSPACEBETWEENCARDS) * ratio_realsize_to_viewsize

            End If
            If Form1.linelength Mod 2 = 0 Then
                cardstartingwith = Form1.linelength / 2
                'adjust for 0 base index
                cardstartingwith -= 1

                currentworkingindex = cardstartingwith



                currenty = centery
                'move one card space from ceter
                currenty -= dy_percard
                'adjust for fact that center of form is on a conectore half way between cards
                currenty += MAX_REALSPACEBETWEENCARDS * ratio_realsize_to_viewsize

                'adjust from referencing center of card to referencing left edge 
                currenty -= mincarddemension() / 2.0


            Else

                cardstartingwith = (Form1.linelength + 1) / 2
                'adjust for 0 base index
                cardstartingwith -= 1

                currentworkingindex = cardstartingwith
                currenty = centery
                'adjust from referencing center of card to referencing left edge 
                currenty -= mincarddemension() / 2.0

            End If


            loopcounter = cardstartingwith
            While loopcounter >= 0

                ypositions(loopcounter) = currenty
                currenty -= dy_percard
                loopcounter -= 1
            End While

            loopcounter = cardstartingwith + 1
            currenty = ypositions(cardstartingwith) + dy_percard

            While loopcounter < Form1.linelength

                ypositions(loopcounter) = currenty
                currenty += dy_percard
                loopcounter += 1
            End While



            Try

                'try blcok is cheeting way to get around fact that we are setting values for 16 cards
                'but the array list is the lenght of howmany cards the user has selected 

                LiteCard0.location = New Point(x, ypositions(0))
                LiteCard1.location = New Point(x, ypositions(1))
                LiteCard2.location = New Point(x, ypositions(2))
                LiteCard3.location = New Point(x, ypositions(3))
                LiteCard4.location = New Point(x, ypositions(4))
                LiteCard5.location = New Point(x, ypositions(5))
                LiteCard6.location = New Point(x, ypositions(6))
                LiteCard7.location = New Point(x, ypositions(7))
                LiteCard8.location = New Point(x, ypositions(8))
                LiteCard9.location = New Point(x, ypositions(9))
                LiteCard10.location = New Point(x, ypositions(10))
                LiteCard11.location = New Point(x, ypositions(11))
                LiteCard12.location = New Point(x, ypositions(12))
                LiteCard13.location = New Point(x, ypositions(13))
                LiteCard14.location = New Point(x, ypositions(14))
                LiteCard15.location = New Point(x, ypositions(15))
                LiteCard16.location = New Point(x, ypositions(16))
                'Changming

            Catch ex As Exception



            End Try



        Loop Until (cardswithinviewingarea())




        Pan_cards.Invalidate()

        LiteCard0.DoNotRedraw = False
        LiteCard1.DoNotRedraw = False
        LiteCard2.DoNotRedraw = False
        LiteCard3.DoNotRedraw = False
        LiteCard4.DoNotRedraw = False
        LiteCard5.DoNotRedraw = False
        LiteCard6.DoNotRedraw = False
        LiteCard7.DoNotRedraw = False

        LiteCard8.DoNotRedraw = False
        LiteCard9.DoNotRedraw = False
        LiteCard10.DoNotRedraw = False
        LiteCard11.DoNotRedraw = False
        LiteCard12.DoNotRedraw = False
        LiteCard13.DoNotRedraw = False
        LiteCard14.DoNotRedraw = False
        LiteCard15.DoNotRedraw = False
        LiteCard16.DoNotRedraw = False
        'Changming


        Form1.positionandsizecards()
        Timer_delayed_invalidate.Start()





        Return




        Return


        'below is old code that will be removed

        'reduce flickering and speed up functionality by not redrawing lite card untill end of function
        LiteCard0.DoNotRedraw = True
        LiteCard1.DoNotRedraw = True
        LiteCard2.DoNotRedraw = True
        LiteCard3.DoNotRedraw = True
        LiteCard4.DoNotRedraw = True
        LiteCard5.DoNotRedraw = True
        LiteCard6.DoNotRedraw = True
        LiteCard7.DoNotRedraw = True

        LiteCard10.DoNotRedraw = True
        LiteCard11.DoNotRedraw = True
        LiteCard12.DoNotRedraw = True
        LiteCard13.DoNotRedraw = True
        LiteCard14.DoNotRedraw = True
        LiteCard15.DoNotRedraw = True
        LiteCard16.DoNotRedraw = True
        'Changming

        LiteCard8.DoNotRedraw = True
        LiteCard9.DoNotRedraw = True

        LiteCard0.Angle = 0
        LiteCard1.Angle = 0
        LiteCard2.Angle = 0
        LiteCard3.Angle = 0
        LiteCard4.Angle = 0
        LiteCard5.Angle = 0
        LiteCard6.Angle = 0
        LiteCard7.Angle = 0
        LiteCard8.Angle = 0
        LiteCard9.Angle = 0
        LiteCard10.Angle = 0
        LiteCard11.Angle = 0
        LiteCard12.Angle = 0
        LiteCard13.Angle = 0
        LiteCard14.Angle = 0
        LiteCard15.Angle = 0
        LiteCard16.Angle = 0
        'Changming







        'postition cards
        'determine position of first and last card 
        'then position remaining along line 
        Dim xfirstcard As Single
        Dim yfirstcard As Single

        Dim xlastcard As Single
        Dim ylastcard As Single

        ' Dim loopcounter As Int16 = 0

        Dim xstep As Single
        Dim ystep As Single
        'calculate postion of first card


        'why x is width/40 is a mystery to me and was determined by fidling arround
        'y is the way it should be multiply by 1.05 to give a space from the bottom edge
        xfirstcard = Pan_dislpayregion.Width / 2 - LiteCard0.Width / 2
        yfirstcard = LiteCard0.Height / 10



        LiteCard0.location = New PointF(xfirstcard, yfirstcard)



        'calculate postion of last card
        'why y is height/40 is a mystery to me and was determined by fiddling arround
        xlastcard = Pan_dislpayregion.Width / 2 - LiteCard0.Width / 2
        ylastcard = (Pan_dislpayregion.Height - StatusStrip.Height) - 1.1 * LiteCard0.Height


        If Form1.settings(Form1.settingsindex.linelength) = 4 Then
            LiteCard3.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard3.location.X - LiteCard0.location.X) / 3
            ystep = (LiteCard3.location.Y - LiteCard0.location.Y) / 3
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 5 Then
            LiteCard4.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard4.location.X - LiteCard0.location.X) / 4
            ystep = (LiteCard4.location.Y - LiteCard0.location.Y) / 4
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 6 Then
            LiteCard5.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard5.location.X - LiteCard0.location.X) / 5
            ystep = (LiteCard5.location.Y - LiteCard0.location.Y) / 5
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 7 Then
            LiteCard6.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard6.location.X - LiteCard0.location.X) / 6
            ystep = (LiteCard6.location.Y - LiteCard0.location.Y) / 6
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 8 Then
            LiteCard7.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard7.location.X - LiteCard0.location.X) / 7
            ystep = (LiteCard7.location.Y - LiteCard0.location.Y) / 7
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 9 Then
            LiteCard8.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard8.location.X - LiteCard0.location.X) / 8
            ystep = (LiteCard8.location.Y - LiteCard0.location.Y) / 8
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 10 Then
            LiteCard9.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard9.location.X - LiteCard0.location.X) / 9
            ystep = (LiteCard9.location.Y - LiteCard0.location.Y) / 9

        ElseIf Form1.settings(Form1.settingsindex.linelength) = 10 Then
            LiteCard9.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard9.location.X - LiteCard0.location.X) / 9
            ystep = (LiteCard9.location.Y - LiteCard0.location.Y) / 9
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 11 Then
            LiteCard9.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard10.location.X - LiteCard0.location.X) / 10
            ystep = (LiteCard10.location.Y - LiteCard0.location.Y) / 10
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 12 Then
            LiteCard9.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard11.location.X - LiteCard0.location.X) / 11
            ystep = (LiteCard11.location.Y - LiteCard0.location.Y) / 11
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 13 Then
            LiteCard9.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard12.location.X - LiteCard0.location.X) / 12
            ystep = (LiteCard12.location.Y - LiteCard0.location.Y) / 12
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 14 Then
            LiteCard9.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard13.location.X - LiteCard0.location.X) / 13
            ystep = (LiteCard13.location.Y - LiteCard0.location.Y) / 13
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 15 Then
            LiteCard9.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard14.location.X - LiteCard0.location.X) / 14
            ystep = (LiteCard14.location.Y - LiteCard0.location.Y) / 14
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 16 Then
            LiteCard9.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard15.location.X - LiteCard0.location.X) / 15
            ystep = (LiteCard15.location.Y - LiteCard0.location.Y) / 15
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 17 Then
            LiteCard9.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard16.location.X - LiteCard0.location.X) / 16
            ystep = (LiteCard16.location.Y - LiteCard0.location.Y) / 16
            'Changming

        Else
            MsgBox("invalid line lenght detected in cards_shape_diaglineup()")

        End If




        'place remaining cards on line connecting first and last card
        loopcounter = 1 'start with card 1, card 0 already placed

        While loopcounter < Form1.settings(Form1.settingsindex.linelength) - 1

            If loopcounter = 1 Then

                LiteCard1.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 2 Then

                LiteCard2.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 3 Then

                LiteCard3.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 4 Then

                LiteCard4.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 5 Then

                LiteCard5.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 6 Then

                LiteCard6.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 7 Then

                LiteCard7.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 8 Then

                LiteCard8.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))

            ElseIf loopcounter = 9 Then

                LiteCard9.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 10 Then

                LiteCard10.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))



            ElseIf loopcounter = 11 Then

                LiteCard11.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 12 Then

                LiteCard12.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 13 Then

                LiteCard13.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 14 Then

                LiteCard14.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))

            Else

                MsgBox("invalid loopcounter value in cards_shapr_diagup_line")
            End If

            loopcounter += 1

        End While



        ''determine angle of line so that cards may be properly angled

        'Dim hypotenuse As Single = Math.Sqrt((LiteCard1.location.X - LiteCard0.location.X) * (LiteCard1.location.X - LiteCard0.location.X) + (LiteCard1.location.Y - LiteCard0.location.Y) * (LiteCard1.location.Y - LiteCard0.location.Y))
        'Dim oposite As Single = LiteCard0.location.Y - LiteCard1.location.Y
        'Dim angle As Single = Math.Asin(oposite / hypotenuse)

        'angle *= 180 / Math.PI

        ''rotate cards
        'LiteCard0.Angle = -angle
        'LiteCard1.Angle = -angle
        'LiteCard2.Angle = -angle
        'LiteCard3.Angle = -angle
        'LiteCard4.Angle = -angle
        'LiteCard5.Angle = -angle
        'LiteCard6.Angle = -angle
        'LiteCard7.Angle = -angle

        'LiteCard8.Angle = -angle
        'LiteCard9.Angle = -angle



        Pan_cards.Invalidate()

        LiteCard0.DoNotRedraw = False
        LiteCard1.DoNotRedraw = False
        LiteCard2.DoNotRedraw = False
        LiteCard3.DoNotRedraw = False
        LiteCard4.DoNotRedraw = False
        LiteCard5.DoNotRedraw = False
        LiteCard6.DoNotRedraw = False
        LiteCard7.DoNotRedraw = False

        LiteCard8.DoNotRedraw = False
        LiteCard9.DoNotRedraw = False
        LiteCard10.DoNotRedraw = False
        LiteCard11.DoNotRedraw = False
        LiteCard12.DoNotRedraw = False
        LiteCard13.DoNotRedraw = False
        LiteCard14.DoNotRedraw = False
        LiteCard15.DoNotRedraw = False
        LiteCard16.DoNotRedraw = False
        'Changming


        Form1.positionandsizecards()
        Timer_delayed_invalidate.Start()
    End Sub

    Public Sub cards_shape_diagdown_line()
        LiteCard0.DoNotRedraw = True
        LiteCard1.DoNotRedraw = True
        LiteCard2.DoNotRedraw = True
        LiteCard3.DoNotRedraw = True
        LiteCard4.DoNotRedraw = True
        LiteCard5.DoNotRedraw = True
        LiteCard6.DoNotRedraw = True
        LiteCard7.DoNotRedraw = True

        LiteCard8.DoNotRedraw = True
        LiteCard9.DoNotRedraw = True
        LiteCard10.DoNotRedraw = True
        LiteCard11.DoNotRedraw = True
        LiteCard12.DoNotRedraw = True
        LiteCard13.DoNotRedraw = True
        LiteCard14.DoNotRedraw = True
        LiteCard15.DoNotRedraw = True
        LiteCard16.DoNotRedraw = True
        'Changming



        LiteCard0.Angle = 45
        LiteCard1.Angle = 45
        LiteCard2.Angle = 45
        LiteCard3.Angle = 45
        LiteCard4.Angle = 45
        LiteCard5.Angle = 45
        LiteCard6.Angle = 45
        LiteCard7.Angle = 45

        LiteCard8.Angle = 45
        LiteCard9.Angle = 45
        LiteCard10.Angle = 45
        LiteCard11.Angle = 45
        LiteCard12.Angle = 45
        LiteCard13.Angle = 45
        LiteCard14.Angle = 45
        LiteCard15.Angle = 45
        LiteCard16.Angle = 45
        'Changming


        If LiteCard0.FontSize > maxfontsize(pattern.diagUpLine, Form1.linelength) Then
            LiteCard0.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard1.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard2.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard3.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard4.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard5.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard6.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard7.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard8.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard9.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard10.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard11.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard12.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard13.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard14.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard15.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            LiteCard16.FontSize = maxfontsize(pattern.diagUpLine, Form1.linelength)
            'Changming

        End If





        'vertical component is in ceter of pan_card
        'adjust for card height
        'Dim y As Int16 = Pan_cards.Height / 2 - maxcarddemension() / 2



        'center cards - card4 left of center card5 right of center

        Dim centerx As Single = Pan_cards.Width / 2
        Dim centery As Single = Pan_cards.Height / 2

        Dim ratio_realsize_to_viewsize As Single = LiteCard0.cardwidth / REALCARDWIDTH
        'REALCARDHEIGHT As Single = 120
        '       Const REALCARDWIDTH As Single = 77
        '      Const MAX_REALSPACEBETWEENCARDS

        Dim dxy_percard = (REALCARDWIDTH + MAX_REALSPACEBETWEENCARDS) * SIN_COS45 * ratio_realsize_to_viewsize
        'Dim dy_percard = (REALCARDWIDTH + MAX_REALSPACEBETWEENCARDS) * SIN_COS45 * ratio_realsize_to_viewsize

        Dim positions As ArrayList = New ArrayList

        Dim loopcounter As Integer = 0
        Dim currentworkingindex As Integer
        Dim cardstartingwith As Integer
        Dim currentx As Integer
        Dim currenty As Integer
        While loopcounter < Form1.linelength
            'create empty entries that we will then full using the correct index
            positions.Add(Nothing)

            loopcounter += 1
        End While

        dxy_percard /= 0.99 'first time through loop starting value
        Do
            dxy_percard *= 0.99
            If dxy_percard / SIN_COS45 < 1.2 * LiteCard1.cardwidth Then

                'the light cards can not fit in the display area
                'make sign smaller and retry from beginning

                'zoom out multiple times because loop was taking too long 
                Me.signZoomOutSmall()
                Me.signZoomOutSmall()
                ratio_realsize_to_viewsize = LiteCard0.cardwidth / REALCARDWIDTH
                dxy_percard = (REALCARDWIDTH + MAX_REALSPACEBETWEENCARDS) * ratio_realsize_to_viewsize * SIN_COS45

            End If
            If Form1.linelength Mod 2 = 0 Then
                cardstartingwith = Form1.linelength / 2
                'adjust for 0 base index
                cardstartingwith -= 1

                currentworkingindex = cardstartingwith



                currentx = centerx
                'move one card space from ceter
                currentx -= dxy_percard
                'adjust for fact that center of form is on a conectore half way between cards
                currentx += (dxy_percard / SIN_COS45 - LiteCard0.cardwidth) * SIN_COS45 '/ 2 'MAX_REALSPACEBETWEENCARDS * ratio_realsize_to_viewsize * SIN_COS45

                'adjust from referencing center of card to referencing left edge 
                currentx -= LiteCard0.Width / 2.0

                currenty = centery
                'move one card space from ceter
                currenty -= dxy_percard
                'adjust for fact that center of form is on a conectore half way between cards
                currenty += (dxy_percard / SIN_COS45 - LiteCard0.cardwidth) * SIN_COS45 '/ 2  'MAX_REALSPACEBETWEENCARDS * ratio_realsize_to_viewsize * SIN_COS45

                'adjust from referencing center of card to referencing left edge 
                currenty -= LiteCard0.Height / 2.0




            Else

                cardstartingwith = (Form1.linelength + 1) / 2
                'adjust for 0 base index
                cardstartingwith -= 1

                currentworkingindex = cardstartingwith
                currentx = centerx
                'adjust from referencing center of card to referencing left edge 
                currentx -= LiteCard1.Width / 2.0


                currenty = centery
                'adjust from referencing center of card to referencing left edge 
                currenty -= LiteCard1.Height / 2.0


            End If


            loopcounter = cardstartingwith
            While loopcounter >= 0

                positions(loopcounter) = New PointF(currentx, currenty)
                currentx -= dxy_percard
                currenty -= dxy_percard
                loopcounter -= 1
            End While

            loopcounter = cardstartingwith + 1
            currentx = positions(cardstartingwith).x + dxy_percard
            currenty = positions(cardstartingwith).y + dxy_percard
            While loopcounter < Form1.linelength

                positions(loopcounter) = New PointF(currentx, currenty)
                currentx += dxy_percard
                currenty += dxy_percard
                loopcounter += 1
            End While



            Try

                'try blcok is cheeting way to get around fact that we are setting values for 16 cards
                'but the array list is the lenght of howmany cards the user has selected 

                LiteCard0.location = positions(0)
                LiteCard1.location = positions(1)
                LiteCard2.location = positions(2)
                LiteCard3.location = positions(3)
                LiteCard4.location = positions(4)
                LiteCard5.location = positions(5)
                LiteCard6.location = positions(6)
                LiteCard7.location = positions(7)
                LiteCard8.location = positions(8)
                LiteCard9.location = positions(9)
                LiteCard10.location = positions(10)
                LiteCard11.location = positions(11)
                LiteCard12.location = positions(12)
                LiteCard13.location = positions(13)
                LiteCard14.location = positions(14)
                LiteCard15.location = positions(15)
                LiteCard16.location = positions(16)
                'Changming

            Catch ex As Exception



            End Try



        Loop Until (cardswithinviewingarea())




        Pan_cards.Invalidate()

        LiteCard0.DoNotRedraw = False
        LiteCard1.DoNotRedraw = False
        LiteCard2.DoNotRedraw = False
        LiteCard3.DoNotRedraw = False
        LiteCard4.DoNotRedraw = False
        LiteCard5.DoNotRedraw = False
        LiteCard6.DoNotRedraw = False
        LiteCard7.DoNotRedraw = False

        LiteCard8.DoNotRedraw = False
        LiteCard9.DoNotRedraw = False
        LiteCard10.DoNotRedraw = False
        LiteCard11.DoNotRedraw = False
        LiteCard12.DoNotRedraw = False
        LiteCard13.DoNotRedraw = False
        LiteCard14.DoNotRedraw = False
        LiteCard15.DoNotRedraw = False
        LiteCard16.DoNotRedraw = False
        'Changming


        Form1.positionandsizecards()
        Timer_delayed_invalidate.Start()









        Return

        'below is old code o be deleted when new code is tested






        'reduce flickering and speed up functionality by not redrawing lite card untill end of function
        LiteCard0.DoNotRedraw = True
        LiteCard1.DoNotRedraw = True
        LiteCard2.DoNotRedraw = True
        LiteCard3.DoNotRedraw = True
        LiteCard4.DoNotRedraw = True
        LiteCard5.DoNotRedraw = True
        LiteCard6.DoNotRedraw = True
        LiteCard7.DoNotRedraw = True

        LiteCard8.DoNotRedraw = True
        LiteCard9.DoNotRedraw = True
        LiteCard10.DoNotRedraw = True
        LiteCard11.DoNotRedraw = True
        LiteCard12.DoNotRedraw = True
        LiteCard13.DoNotRedraw = True
        LiteCard14.DoNotRedraw = True
        LiteCard15.DoNotRedraw = True
        LiteCard16.DoNotRedraw = True
        'Ch

        LiteCard0.Angle = 45
        LiteCard1.Angle = 45
        LiteCard2.Angle = 45
        LiteCard3.Angle = 45 '
        LiteCard4.Angle = 45 '-angle
        LiteCard5.Angle = 45 '-angle
        LiteCard6.Angle = 45 ' -angle
        LiteCard7.Angle = 45 '-angle

        LiteCard8.Angle = 45 '-angle
        LiteCard9.Angle = 45 '-angle
        LiteCard10.Angle = 45
        LiteCard11.Angle = 45
        LiteCard12.Angle = 45
        LiteCard13.Angle = 45 '
        LiteCard14.Angle = 45 '-angle
        LiteCard15.Angle = 45 '-angle
        LiteCard16.Angle = 45 '-angle
        'Ch






        'postition cards
        'determine position of first and last card 
        'then position remaining along line 
        Dim xfirstcard As Single
        Dim yfirstcard As Single

        Dim xlastcard As Single
        Dim ylastcard As Single

        'Dim loopcounter As Int16 = 0

        Dim xstep As Single
        Dim ystep As Single
        'calculate postion of first card


        'why x is width/40 is a mystery to me and was determined by fidling arround
        'y is the way it should be multiply by 1.05 to give a space from the bottom edge
        xfirstcard = LiteCard0.Width / 40
        yfirstcard = LiteCard0.Height / 40



        LiteCard0.location = New PointF(xfirstcard, yfirstcard)



        'calculate postion of last card
        'why y is height/40 is a mystery to me and was determined by fiddling arround
        xlastcard = Pan_dislpayregion.Width - 1.05 * LiteCard0.Width
        ylastcard = (Pan_dislpayregion.Height - StatusStrip.Height) - 1.05 * LiteCard0.Height


        If Form1.settings(Form1.settingsindex.linelength) = 4 Then
            LiteCard3.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard3.location.X - LiteCard0.location.X) / 3
            ystep = (LiteCard3.location.Y - LiteCard0.location.Y) / 3
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 5 Then
            LiteCard4.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard4.location.X - LiteCard0.location.X) / 4
            ystep = (LiteCard4.location.Y - LiteCard0.location.Y) / 4
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 6 Then
            LiteCard5.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard5.location.X - LiteCard0.location.X) / 5
            ystep = (LiteCard5.location.Y - LiteCard0.location.Y) / 5
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 7 Then
            LiteCard6.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard6.location.X - LiteCard0.location.X) / 6
            ystep = (LiteCard6.location.Y - LiteCard0.location.Y) / 6
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 8 Then
            LiteCard7.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard7.location.X - LiteCard0.location.X) / 7
            ystep = (LiteCard7.location.Y - LiteCard0.location.Y) / 7
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 9 Then
            LiteCard8.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard8.location.X - LiteCard0.location.X) / 8
            ystep = (LiteCard8.location.Y - LiteCard0.location.Y) / 8
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 10 Then
            LiteCard9.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard9.location.X - LiteCard0.location.X) / 9
            ystep = (LiteCard9.location.Y - LiteCard0.location.Y) / 9



        ElseIf Form1.settings(Form1.settingsindex.linelength) = 11 Then
            LiteCard10.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard10.location.X - LiteCard0.location.X) / 10
            ystep = (LiteCard10.location.Y - LiteCard0.location.Y) / 10
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 12 Then
            LiteCard11.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard11.location.X - LiteCard0.location.X) / 11
            ystep = (LiteCard11.location.Y - LiteCard0.location.Y) / 11
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 13 Then
            LiteCard12.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard12.location.X - LiteCard0.location.X) / 12
            ystep = (LiteCard12.location.Y - LiteCard0.location.Y) / 12
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 14 Then
            LiteCard13.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard13.location.X - LiteCard0.location.X) / 13
            ystep = (LiteCard13.location.Y - LiteCard0.location.Y) / 13
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 15 Then
            LiteCard14.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard14.location.X - LiteCard0.location.X) / 14
            ystep = (LiteCard14.location.Y - LiteCard0.location.Y) / 14
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 16 Then
            LiteCard15.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard15.location.X - LiteCard0.location.X) / 15
            ystep = (LiteCard15.location.Y - LiteCard0.location.Y) / 15
        ElseIf Form1.settings(Form1.settingsindex.linelength) = 17 Then
            LiteCard15.location = New PointF(xlastcard, ylastcard)
            xstep = (LiteCard15.location.X - LiteCard0.location.X) / 16
            ystep = (LiteCard16.location.Y - LiteCard0.location.Y) / 16
            'Ch


        Else
            MsgBox("invalid line lenght detected in cards_shape_diaglineup()")

        End If




        'place remaining cards on line connecting first and last card
        loopcounter = 1 'start with card 1, card 0 already placed

        While loopcounter < Form1.settings(Form1.settingsindex.linelength) - 1

            If loopcounter = 1 Then

                LiteCard1.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 2 Then

                LiteCard2.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 3 Then

                LiteCard3.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 4 Then

                LiteCard4.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 5 Then

                LiteCard5.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 6 Then

                LiteCard6.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 7 Then

                LiteCard7.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 8 Then

                LiteCard8.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))

            ElseIf loopcounter = 9 Then

                LiteCard9.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))

            ElseIf loopcounter = 10 Then

                LiteCard10.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))

            ElseIf loopcounter = 11 Then

                LiteCard11.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 12 Then

                LiteCard12.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            ElseIf loopcounter = 13 Then

                LiteCard13.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))

            ElseIf loopcounter = 14 Then
                LiteCard14.location = New PointF(LiteCard0.location.X + (xstep * loopcounter), LiteCard0.location.Y + (ystep * loopcounter))
            Else

                MsgBox("invalid loopcounter value in cards_shapr_diagdown_line")
            End If

            loopcounter += 1

        End While



        'determine angle of line so that cards may be properly angled

        Dim hypotenuse As Single = Math.Sqrt((LiteCard1.location.X - LiteCard0.location.X) * (LiteCard1.location.X - LiteCard0.location.X) + (LiteCard1.location.Y - LiteCard0.location.Y) * (LiteCard1.location.Y - LiteCard0.location.Y))
        Dim oposite As Single = LiteCard0.location.Y - LiteCard1.location.Y
        Dim angle As Single = Math.Asin(oposite / hypotenuse)

        angle *= 180 / Math.PI

        'rotate cards
        LiteCard0.Angle = -angle
        LiteCard1.Angle = -angle
        LiteCard2.Angle = -angle
        LiteCard3.Angle = -angle
        LiteCard4.Angle = -angle
        LiteCard5.Angle = -angle
        LiteCard6.Angle = -angle
        LiteCard7.Angle = -angle

        LiteCard8.Angle = -angle
        LiteCard9.Angle = -angle
        LiteCard10.Angle = -angle
        LiteCard11.Angle = -angle
        LiteCard12.Angle = -angle
        LiteCard13.Angle = -angle
        LiteCard14.Angle = -angle
        LiteCard15.Angle = -angle
        LiteCard16.Angle = -angle
        'Ch



        Pan_cards.Invalidate()

        LiteCard0.DoNotRedraw = False
        LiteCard1.DoNotRedraw = False
        LiteCard2.DoNotRedraw = False
        LiteCard3.DoNotRedraw = False
        LiteCard4.DoNotRedraw = False
        LiteCard5.DoNotRedraw = False
        LiteCard6.DoNotRedraw = False
        LiteCard7.DoNotRedraw = False

        LiteCard8.DoNotRedraw = False
        LiteCard9.DoNotRedraw = False
        LiteCard10.DoNotRedraw = False
        LiteCard11.DoNotRedraw = False
        LiteCard12.DoNotRedraw = False
        LiteCard13.DoNotRedraw = False
        LiteCard14.DoNotRedraw = False
        LiteCard15.DoNotRedraw = False
        LiteCard16.DoNotRedraw = False
        'Ch


        Form1.positionandsizecards()
        Timer_delayed_invalidate.Start()
    End Sub

    Private Function cardswithinviewingarea() As Boolean
        Const padding As Single = 0.9


        Dim min_x As Single = (Me.Pan_cards.Width - (Me.Pan_cards.Width * padding)) / 2
        Dim min_y As Single = (Me.Pan_cards.Height - (Me.Pan_cards.Height * padding)) / 2
        Dim max_x As Single = min_x + Me.Pan_cards.Width * padding
        Dim max_y As Single = min_y + Me.Pan_cards.Height * padding

        If Form1.linelength > 0 Then
            If LiteCard0.location.X < min_x Then
                Return False
            End If
            If LiteCard0.location.Y < min_y Then
                Return False
            End If


            If LiteCard0.location.X + LiteCard0.Width > max_x Then
                Return False
            End If

            If LiteCard0.location.Y + LiteCard0.Height > max_y Then
                Return False
            End If


        End If

        If Form1.linelength > 1 Then
            If LiteCard1.location.X < min_x Then
                Return False
            End If
            If LiteCard1.location.Y < min_y Then
                Return False
            End If


            If LiteCard1.location.X + LiteCard1.Width > max_x Then
                Return False
            End If

            If LiteCard1.location.Y + LiteCard1.Height > max_y Then
                Return False
            End If


        End If
        If Form1.linelength > 2 Then
            If LiteCard2.location.X < min_x Then
                Return False
            End If
            If LiteCard2.location.Y < min_y Then
                Return False
            End If


            If LiteCard2.location.X + LiteCard2.Width > max_x Then
                Return False
            End If

            If LiteCard2.location.Y + LiteCard2.Height > max_y Then
                Return False
            End If


        End If
        If Form1.linelength > 3 Then
            If LiteCard3.location.X < min_x Then
                Return False
            End If
            If LiteCard3.location.Y < min_y Then
                Return False
            End If


            If LiteCard3.location.X + LiteCard3.Width > max_x Then
                Return False
            End If

            If LiteCard3.location.Y + LiteCard3.Height > max_y Then
                Return False
            End If


        End If
        If Form1.linelength > 4 Then
            If LiteCard4.location.X < min_x Then
                Return False
            End If
            If LiteCard4.location.Y < min_y Then
                Return False
            End If


            If LiteCard4.location.X + LiteCard4.Width > max_x Then
                Return False
            End If

            If LiteCard4.location.Y + LiteCard4.Height > max_y Then
                Return False
            End If


        End If
        If Form1.linelength > 5 Then
            If LiteCard5.location.X < min_x Then
                Return False
            End If
            If LiteCard5.location.Y < min_y Then
                Return False
            End If


            If LiteCard5.location.X + LiteCard5.Width > max_x Then
                Return False
            End If

            If LiteCard5.location.Y + LiteCard5.Height > max_y Then
                Return False
            End If


        End If
        If Form1.linelength > 6 Then
            If LiteCard6.location.X < min_x Then
                Return False
            End If
            If LiteCard6.location.Y < min_y Then
                Return False
            End If


            If LiteCard6.location.X + LiteCard6.Width > max_x Then
                Return False
            End If

            If LiteCard6.location.Y + LiteCard6.Height > max_y Then
                Return False
            End If


        End If
        If Form1.linelength > 7 Then
            If LiteCard7.location.X < min_x Then
                Return False
            End If
            If LiteCard7.location.Y < min_y Then
                Return False
            End If


            If LiteCard7.location.X + LiteCard7.Width > max_x Then
                Return False
            End If

            If LiteCard7.location.Y + LiteCard7.Height > max_y Then
                Return False
            End If


        End If
        If Form1.linelength > 8 Then
            If LiteCard8.location.X < min_x Then
                Return False
            End If
            If LiteCard8.location.Y < min_y Then
                Return False
            End If


            If LiteCard8.location.X + LiteCard8.Width > max_x Then
                Return False
            End If

            If LiteCard8.location.Y + LiteCard8.Height > max_y Then
                Return False
            End If


        End If

        If Form1.linelength > 9 Then
            If LiteCard9.location.X < min_x Then
                Return False
            End If
            If LiteCard9.location.Y < min_y Then
                Return False
            End If


            If LiteCard9.location.X + LiteCard9.Width > max_x Then
                Return False
            End If

            If LiteCard9.location.Y + LiteCard9.Height > max_y Then
                Return False
            End If


        End If

        If Form1.linelength > 10 Then
            If LiteCard10.location.X < min_x Then
                Return False
            End If
            If LiteCard10.location.Y < min_y Then
                Return False
            End If


            If LiteCard10.location.X + LiteCard10.Width > max_x Then
                Return False
            End If

            If LiteCard10.location.Y + LiteCard10.Height > max_y Then
                Return False
            End If


        End If
        If Form1.linelength > 11 Then
            If LiteCard11.location.X < min_x Then
                Return False
            End If
            If LiteCard11.location.Y < min_y Then
                Return False
            End If


            If LiteCard11.location.X + LiteCard11.Width > max_x Then
                Return False
            End If

            If LiteCard11.location.Y + LiteCard11.Height > max_y Then
                Return False
            End If


        End If
        If Form1.linelength > 12 Then
            If LiteCard12.location.X < min_x Then
                Return False
            End If
            If LiteCard12.location.Y < min_y Then
                Return False
            End If


            If LiteCard12.location.X + LiteCard12.Width > max_x Then
                Return False
            End If

            If LiteCard12.location.Y + LiteCard12.Height > max_y Then
                Return False
            End If


        End If
        If Form1.linelength > 13 Then
            If LiteCard13.location.X < min_x Then
                Return False
            End If
            If LiteCard13.location.Y < min_y Then
                Return False
            End If


            If LiteCard13.location.X + LiteCard13.Width > max_x Then
                Return False
            End If

            If LiteCard13.location.Y + LiteCard13.Height > max_y Then
                Return False
            End If


        End If
        If Form1.linelength > 14 Then
            If LiteCard14.location.X < min_x Then
                Return False
            End If
            If LiteCard14.location.Y < min_y Then
                Return False
            End If


            If LiteCard14.location.X + LiteCard14.Width > max_x Then
                Return False
            End If

            If LiteCard14.location.Y + LiteCard14.Height > max_y Then
                Return False
            End If


        End If


        If Form1.linelength > 15 Then
            If LiteCard15.location.X < min_x Then
                Return False
            End If
            If LiteCard15.location.Y < min_y Then
                Return False
            End If


            If LiteCard15.location.X + LiteCard15.Width > max_x Then
                Return False
            End If

            If LiteCard15.location.Y + LiteCard15.Height > max_y Then
                Return False
            End If

        End If

        If Form1.linelength > 16 Then
            If LiteCard15.location.X < min_x Then
                Return False
            End If
            If LiteCard16.location.Y < min_y Then
                Return False
            End If


            If LiteCard16.location.X + LiteCard16.Width > max_x Then
                Return False
            End If

            If LiteCard16.location.Y + LiteCard16.Height > max_y Then
                Return False
            End If

        End If
        'Changming






        'does not fail any test so all cards must be within viewing area
        Return True

    End Function



    Public Sub cards_shape_HorLine()

        'locate in center
        LiteCard0.DoNotRedraw = True
        LiteCard1.DoNotRedraw = True
        LiteCard2.DoNotRedraw = True
        LiteCard3.DoNotRedraw = True
        LiteCard4.DoNotRedraw = True
        LiteCard5.DoNotRedraw = True
        LiteCard6.DoNotRedraw = True
        LiteCard7.DoNotRedraw = True

        LiteCard8.DoNotRedraw = True
        LiteCard9.DoNotRedraw = True
        LiteCard10.DoNotRedraw = True
        LiteCard11.DoNotRedraw = True
        LiteCard12.DoNotRedraw = True
        LiteCard13.DoNotRedraw = True
        LiteCard14.DoNotRedraw = True
        LiteCard15.DoNotRedraw = True
        LiteCard16.DoNotRedraw = True
        'Ch



        LiteCard0.Angle = 0
        LiteCard1.Angle = 0
        LiteCard2.Angle = 0
        LiteCard3.Angle = 0
        LiteCard4.Angle = 0
        LiteCard5.Angle = 0
        LiteCard6.Angle = 0
        LiteCard7.Angle = 0

        LiteCard8.Angle = 0
        LiteCard9.Angle = 0
        LiteCard10.Angle = 0
        LiteCard11.Angle = 0
        LiteCard12.Angle = 0
        LiteCard13.Angle = 0
        LiteCard14.Angle = 0
        LiteCard15.Angle = 0
        LiteCard16.Angle = 0
        'Ch








        'vertical component is in ceter of pan_card
        'adjust for card height
        Dim y As Int16 = Pan_cards.Height / 2 - maxcarddemension() / 2



        'center cards - card4 left of center card5 right of center

        Dim centerx As Single = Pan_cards.Width / 2

        Dim ratio_realsize_to_viewsize As Single = mincarddemension() / REALCARDWIDTH
        'REALCARDHEIGHT As Single = 120
        '       Const REALCARDWIDTH As Single = 77
        '      Const MAX_REALSPACEBETWEENCARDS

        Dim dx_percard = (REALCARDWIDTH + MAX_REALSPACEBETWEENCARDS) * ratio_realsize_to_viewsize

        Dim xpositions As ArrayList = New ArrayList
        Dim loopcounter As Integer = 0
        Dim currentworkingindex As Integer
        Dim cardstartingwith As Integer
        Dim currentx As Integer
        While loopcounter < Form1.linelength
            'create empty entries that we will then full using the correct index
            xpositions.Add(Nothing)

            loopcounter += 1
        End While

        dx_percard /= 0.99 'first time through loop starting value
        Do
            dx_percard *= 0.99
            If dx_percard < 1.1 * LiteCard1.Width Then

                'the light cards can not fit in the display area
                'make sign smaller and retry from beginning

                'zoom out multiple times because loop was taking too long 
                Me.signZoomOutSmall()
                Me.signZoomOutSmall()
                ratio_realsize_to_viewsize = mincarddemension() / REALCARDWIDTH
                dx_percard = (REALCARDWIDTH + MAX_REALSPACEBETWEENCARDS) * ratio_realsize_to_viewsize

            End If
            If Form1.linelength Mod 2 = 0 Then
                cardstartingwith = Form1.linelength / 2
                'adjust for 0 base index
                cardstartingwith -= 1

                currentworkingindex = cardstartingwith



                currentx = centerx
                'move one card space from ceter
                currentx -= dx_percard
                'adjust for fact that center of form is on a conectore half way between cards
                currentx += MAX_REALSPACEBETWEENCARDS * ratio_realsize_to_viewsize

                'adjust from referencing center of card to referencing left edge 
                currentx -= mincarddemension() / 2.0


            Else

                cardstartingwith = (Form1.linelength + 1) / 2
                'adjust for 0 base index
                cardstartingwith -= 1

                currentworkingindex = cardstartingwith
                currentx = centerx
                'adjust from referencing center of card to referencing left edge 
                currentx -= mincarddemension() / 2.0

            End If


            loopcounter = cardstartingwith
            While loopcounter >= 0

                xpositions(loopcounter) = currentx
                currentx -= dx_percard
                loopcounter -= 1
            End While

            loopcounter = cardstartingwith + 1
            currentx = xpositions(cardstartingwith) + dx_percard

            While loopcounter < Form1.linelength

                xpositions(loopcounter) = currentx
                currentx += dx_percard
                loopcounter += 1
            End While



            Try

                'try blcok is cheeting way to get around fact that we are setting values for 16 cards
                'but the array list is the lenght of howmany cards the user has selected 

                LiteCard0.location = New Point(xpositions(0), y)
                LiteCard1.location = New Point(xpositions(1), y)
                LiteCard2.location = New Point(xpositions(2), y)
                LiteCard3.location = New Point(xpositions(3), y)
                LiteCard4.location = New Point(xpositions(4), y)
                LiteCard5.location = New Point(xpositions(5), y)
                LiteCard6.location = New Point(xpositions(6), y)
                LiteCard7.location = New Point(xpositions(7), y)
                LiteCard8.location = New Point(xpositions(8), y)
                LiteCard9.location = New Point(xpositions(9), y)
                LiteCard10.location = New Point(xpositions(10), y)
                LiteCard11.location = New Point(xpositions(11), y)
                LiteCard12.location = New Point(xpositions(12), y)
                LiteCard13.location = New Point(xpositions(13), y)
                LiteCard14.location = New Point(xpositions(14), y)
                LiteCard15.location = New Point(xpositions(15), y)
                LiteCard16.location = New Point(xpositions(16), y)
                'Ch

            Catch ex As Exception



            End Try



        Loop Until (cardswithinviewingarea())




        Pan_cards.Invalidate()

        LiteCard0.DoNotRedraw = False
        LiteCard1.DoNotRedraw = False
        LiteCard2.DoNotRedraw = False
        LiteCard3.DoNotRedraw = False
        LiteCard4.DoNotRedraw = False
        LiteCard5.DoNotRedraw = False
        LiteCard6.DoNotRedraw = False
        LiteCard7.DoNotRedraw = False

        LiteCard8.DoNotRedraw = False
        LiteCard9.DoNotRedraw = False
        LiteCard10.DoNotRedraw = False
        LiteCard11.DoNotRedraw = False
        LiteCard12.DoNotRedraw = False
        LiteCard13.DoNotRedraw = False
        LiteCard14.DoNotRedraw = False
        LiteCard15.DoNotRedraw = False
        LiteCard16.DoNotRedraw = False
        'Ch


        Form1.positionandsizecards()
        Timer_delayed_invalidate.Start()





        Return


        'below is old code that should be deleted as soon as new code is tested

        'start x4



        'I think it is slightly off centered
        'calculating card 5 from position of card4 look good
        'and is faster then figuring out why card 4 and card 5 are placed slightly 
        'to far from the center 



        ''start x5
        'Dim x5 = centerx
        ''move one card space from ceter
        'x5 += dx_percard
        ''adjust for fact that center of form is on a conectore half way between cards
        'x5 -= MAX_REALSPACEBETWEENCARDS * ratio_realsize_to_viewsize

        ''adjust from referencing center of card to referencing left edge 
        'x5 -= mincarddemension() / 2.0


        ''deleted 05/10/11
        'Dim x5 = 0 'x4 + dx_percard
        'Dim x6 = x5 + dx_percard
        'Dim x7 = x6 + dx_percard
        'Dim x8 = x7 + dx_percard
        'Dim x9 = x8 + dx_percard
        'Dim x10 = x9 + dx_percard
        'Dim x11 = x10 + dx_percard
        'Dim x12 = x11 + dx_percard
        'Dim x13 = x12 + dx_percard
        'Dim x14 = x13 + dx_percard
        'Dim x15 = x14 + dx_percard

        'Dim x3 = 0 'x4 - dx_percard
        'Dim x2 = x3 - dx_percard
        'Dim x1 = x2 - dx_percard
        'Dim x0 = x1 - dx_percard


        'LiteCard0.location = New Point(x0, y)
        'LiteCard1.location = New Point(x1, y)
        'LiteCard2.location = New Point(x2, y)
        'LiteCard3.location = New Point(x3, y)
        ''LiteCard4.location = New Point(x4, y)
        'LiteCard5.location = New Point(x5, y)
        'LiteCard6.location = New Point(x6, y)
        'LiteCard7.location = New Point(x7, y)
        'LiteCard8.location = New Point(x8, y)
        'LiteCard9.location = New Point(x9, y)
        'LiteCard10.location = New Point(x10, y)
        'LiteCard11.location = New Point(x11, y)
        'LiteCard12.location = New Point(x12, y)
        'LiteCard13.location = New Point(x13, y)
        'LiteCard14.location = New Point(x14, y)
        'LiteCard15.location = New Point(x15, y)


        'Pan_cards.Invalidate()

        'LiteCard0.DoNotRedraw = False
        'LiteCard1.DoNotRedraw = False
        'LiteCard2.DoNotRedraw = False
        'LiteCard3.DoNotRedraw = False
        'LiteCard4.DoNotRedraw = False
        'LiteCard5.DoNotRedraw = False
        'LiteCard6.DoNotRedraw = False
        'LiteCard7.DoNotRedraw = False

        'LiteCard8.DoNotRedraw = False
        'LiteCard9.DoNotRedraw = False
        'LiteCard10.DoNotRedraw = False
        'LiteCard11.DoNotRedraw = False
        'LiteCard12.DoNotRedraw = False
        'LiteCard13.DoNotRedraw = False
        'LiteCard14.DoNotRedraw = False
        'LiteCard15.DoNotRedraw = False


        'Form1.positionandsizecards()
        'Timer_delayed_invalidate.Start()




        'Return

    End Sub



    Public Function maxcarddemension() As Single

        Dim returnvalue As Single

        returnvalue = LiteCard0.Height

        If LiteCard0.Width > returnvalue Then

            returnvalue = LiteCard0.Width
        End If

        If LiteCard1.Height > returnvalue Then

            returnvalue = LiteCard1.Height
        End If

        If LiteCard1.Width > returnvalue Then

            returnvalue = LiteCard1.Width
        End If

        If LiteCard2.Height > returnvalue Then

            returnvalue = LiteCard2.Height
        End If

        If LiteCard2.Width > returnvalue Then

            returnvalue = LiteCard2.Width
        End If

        If LiteCard3.Height > returnvalue Then

            returnvalue = LiteCard3.Height
        End If

        If LiteCard3.Width > returnvalue Then

            returnvalue = LiteCard3.Width
        End If

        If LiteCard4.Height > returnvalue Then

            returnvalue = LiteCard4.Height
        End If

        If LiteCard4.Width > returnvalue Then

            returnvalue = LiteCard4.Width
        End If

        If LiteCard5.Height > returnvalue Then

            returnvalue = LiteCard5.Height
        End If

        If LiteCard5.Width > returnvalue Then

            returnvalue = LiteCard5.Width
        End If

        If LiteCard6.Height > returnvalue Then

            returnvalue = LiteCard6.Height
        End If

        If LiteCard6.Width > returnvalue Then

            returnvalue = LiteCard6.Width
        End If

        If LiteCard7.Height > returnvalue Then

            returnvalue = LiteCard7.Height
        End If

        If LiteCard7.Width > returnvalue Then

            returnvalue = LiteCard7.Width
        End If

        If LiteCard8.Height > returnvalue Then

            returnvalue = LiteCard8.Height
        End If

        If LiteCard8.Width > returnvalue Then

            returnvalue = LiteCard8.Width
        End If

        If LiteCard9.Height > returnvalue Then

            returnvalue = LiteCard9.Height
        End If

        If LiteCard9.Width > returnvalue Then

            returnvalue = LiteCard9.Width
        End If



        If LiteCard10.Width > returnvalue Then

            returnvalue = LiteCard10.Width
        End If

        If LiteCard11.Height > returnvalue Then

            returnvalue = LiteCard11.Height
        End If

        If LiteCard11.Width > returnvalue Then

            returnvalue = LiteCard11.Width
        End If

        If LiteCard12.Height > returnvalue Then

            returnvalue = LiteCard12.Height
        End If

        If LiteCard12.Width > returnvalue Then

            returnvalue = LiteCard12.Width
        End If

        If LiteCard13.Height > returnvalue Then

            returnvalue = LiteCard13.Height
        End If

        If LiteCard13.Width > returnvalue Then

            returnvalue = LiteCard13.Width
        End If

        If LiteCard14.Height > returnvalue Then

            returnvalue = LiteCard14.Height
        End If

        If LiteCard14.Width > returnvalue Then

            returnvalue = LiteCard14.Width
        End If

        'Ch

        If LiteCard15.Height > returnvalue Then

            returnvalue = LiteCard15.Height
        End If

        If LiteCard15.Width > returnvalue Then

            returnvalue = LiteCard15.Width
        End If

        If LiteCard16.Height > returnvalue Then

            returnvalue = LiteCard16.Height
        End If

        If LiteCard16.Width > returnvalue Then

            returnvalue = LiteCard16.Width
        End If


        Return returnvalue
    End Function

    Public Function mincarddemension() As Single

        Dim returnvalue As Single

        returnvalue = LiteCard0.Height

        If LiteCard0.Width < returnvalue Then

            returnvalue = LiteCard0.Width
        End If

        If LiteCard1.Height < returnvalue Then

            returnvalue = LiteCard1.Height
        End If

        If LiteCard1.Width < returnvalue Then

            returnvalue = LiteCard1.Width
        End If
        '''
        If LiteCard2.Height < returnvalue Then

            returnvalue = LiteCard2.Height
        End If

        If LiteCard2.Width < returnvalue Then

            returnvalue = LiteCard2.Width
        End If
        '''
        If LiteCard3.Height < returnvalue Then

            returnvalue = LiteCard3.Height
        End If

        If LiteCard3.Width < returnvalue Then

            returnvalue = LiteCard3.Width
        End If
        '''
        If LiteCard4.Height < returnvalue Then

            returnvalue = LiteCard4.Height
        End If

        If LiteCard4.Width < returnvalue Then

            returnvalue = LiteCard4.Width
        End If
        '''
        If LiteCard5.Height < returnvalue Then

            returnvalue = LiteCard5.Height
        End If

        If LiteCard5.Width < returnvalue Then

            returnvalue = LiteCard5.Width
        End If
        '''
        If LiteCard6.Height < returnvalue Then

            returnvalue = LiteCard6.Height
        End If

        If LiteCard6.Width < returnvalue Then

            returnvalue = LiteCard6.Width
        End If
        '''
        If LiteCard7.Height < returnvalue Then

            returnvalue = LiteCard7.Height
        End If

        If LiteCard7.Width < returnvalue Then

            returnvalue = LiteCard7.Width
        End If
        '''
        If LiteCard8.Height < returnvalue Then

            returnvalue = LiteCard8.Height
        End If

        If LiteCard8.Width < returnvalue Then

            returnvalue = LiteCard8.Width
        End If
        '''
        If LiteCard9.Height < returnvalue Then

            returnvalue = LiteCard9.Height
        End If

        If LiteCard9.Width < returnvalue Then

            returnvalue = LiteCard9.Width
        End If
        If LiteCard10.Width < returnvalue Then

            returnvalue = LiteCard10.Width
        End If

        If LiteCard11.Height < returnvalue Then

            returnvalue = LiteCard11.Height
        End If

        If LiteCard11.Width < returnvalue Then

            returnvalue = LiteCard11.Width
        End If
        '''
        If LiteCard12.Height < returnvalue Then

            returnvalue = LiteCard12.Height
        End If

        If LiteCard12.Width < returnvalue Then

            returnvalue = LiteCard12.Width
        End If
        '''
        If LiteCard13.Height < returnvalue Then

            returnvalue = LiteCard13.Height
        End If

        If LiteCard13.Width < returnvalue Then

            returnvalue = LiteCard13.Width
        End If
        '''
        If LiteCard14.Height < returnvalue Then

            returnvalue = LiteCard14.Height
        End If

        If LiteCard14.Width < returnvalue Then

            returnvalue = LiteCard14.Width
        End If

        'Changming

        If LiteCard15.Height < returnvalue Then

            returnvalue = LiteCard15.Height
        End If

        If LiteCard15.Width < returnvalue Then

            returnvalue = LiteCard15.Width
        End If

        If LiteCard16.Height < returnvalue Then

            returnvalue = LiteCard16.Height
        End If

        If LiteCard16.Width < returnvalue Then

            returnvalue = LiteCard16.Width
        End If
        'Ch

        Return returnvalue
    End Function





    Public Sub positionandsizecards()
        Static recursive As Boolean = False

        If Not recursive Then

            recursive = True
            LiteCard0.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard0.FontSize
            LiteCard1.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard1.FontSize
            LiteCard2.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard2.FontSize
            LiteCard3.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard3.FontSize
            LiteCard4.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard4.FontSize
            LiteCard5.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard5.FontSize
            LiteCard6.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard6.FontSize
            LiteCard7.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard7.FontSize
            LiteCard8.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard8.FontSize
            LiteCard9.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard9.FontSize
            LiteCard10.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard10.FontSize
            LiteCard11.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard11.FontSize
            LiteCard12.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard12.FontSize
            LiteCard13.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard13.FontSize
            LiteCard14.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard14.FontSize
            LiteCard15.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard15.FontSize
            LiteCard16.FontSize = Form1.oneline_simulator_ratio * Form1.LiteCard16.FontSize
            'Ch


            LiteCard0.Angle = Form1.LiteCard0.Angle
            LiteCard1.Angle = Form1.LiteCard1.Angle

            LiteCard2.Angle = Form1.LiteCard2.Angle

            LiteCard3.Angle = Form1.LiteCard3.Angle

            LiteCard4.Angle = Form1.LiteCard4.Angle

            LiteCard5.Angle = Form1.LiteCard5.Angle

            LiteCard6.Angle = Form1.LiteCard6.Angle

            LiteCard7.Angle = Form1.LiteCard7.Angle

            LiteCard8.Angle = Form1.LiteCard8.Angle
            LiteCard9.Angle = Form1.LiteCard9.Angle

            LiteCard10.Angle = Form1.LiteCard10.Angle
            LiteCard11.Angle = Form1.LiteCard11.Angle

            LiteCard12.Angle = Form1.LiteCard12.Angle

            LiteCard13.Angle = Form1.LiteCard13.Angle

            LiteCard14.Angle = Form1.LiteCard14.Angle

            LiteCard15.Angle = Form1.LiteCard15.Angle
            LiteCard16.Angle = Form1.LiteCard15.Angle
            'Ch
            'Changming temp 



            LiteCard0.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard0.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard0.location.Y)
            LiteCard1.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard1.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard1.location.Y)
            LiteCard2.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard2.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard2.location.Y)
            LiteCard3.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard3.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard3.location.Y)
            LiteCard4.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard4.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard4.location.Y)
            LiteCard5.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard5.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard5.location.Y)
            LiteCard6.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard6.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard6.location.Y)
            LiteCard7.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard7.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard7.location.Y)
            LiteCard8.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard8.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard8.location.Y)
            LiteCard9.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard9.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard9.location.Y)
            LiteCard10.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard10.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard10.location.Y)
            LiteCard11.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard11.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard11.location.Y)
            LiteCard12.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard12.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard12.location.Y)
            LiteCard13.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard13.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard13.location.Y)
            LiteCard14.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard14.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard14.location.Y)
            LiteCard15.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard15.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard15.location.Y)
            LiteCard16.location = New Point(Form1.oneline_simulator_ratio * Form1.LiteCard16.location.X, Form1.oneline_simulator_ratio * Form1.LiteCard16.location.Y)
            'CMF

            Timer_delayed_invalidate.Start()



            recursive = False
        End If




    End Sub


    Private Sub simulator_form_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize


        'for now dont allow resizing
        Static size = Me.Size

        Me.Size = size

        Return





        'to be finished latter




        'first calculate the change in size of picture_panel

        'second "recenter" it. 
        'delta x  is 1/2 the change in width 
        'delta y are  is 1/2 the change in height

        '3rd reposition pan_card_background

        Static counter As Int16 = 0
        Static myprevwidth As Int16 = Me.Width
        Static myprevheight As Int16 = Me.Height

        Dim heightratio As Single = (Me.Height - Pan_buttons.Height - 35) / (myprevheight - Pan_buttons.Height - 35)
        Dim widthratio As Single = Me.Width / myprevwidth

        Dim previmageholderheight As Int16 = Pan_imageholder.Height

        Dim previmageholderwidth As Int16 = Pan_imageholder.Width

        counter += 1
        Lbl_debug.Text = counter
        Pan_imageholder.Height *= heightratio
        Pan_imageholder.Width *= widthratio

        Pan_imageholder.Left -= (Pan_imageholder.Height - previmageholderheight) / 2
        Pan_imageholder.Left -= (Pan_imageholder.Width - previmageholderwidth) / 2

        position_Pan_cardbackground()

        myprevwidth = Me.Width
        myprevheight = Me.Height


        Return

        'below is old code

        But_close.Top = Me.Height - 60
        But_shape_revarch.Top = Me.Height - 60


        But_shape_arch.Top = Me.Height - 60


        But_shape_straight.Top = Me.Height - 60


        If Me.selectedpattern = card_pattern_type.Hor_line Then
            Me.cards_shape_HorLine()
        ElseIf Me.selectedpattern = card_pattern_type.Rev_arc Then
            Me.cards_shape_ReverseArc()
        ElseIf Me.selectedpattern = card_pattern_type.Arc Then
            Me.cards_shape_Arc()

        End If
    End Sub

    Private Sub Pan_cardbackground_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pan_cards.Resize

        If initialized Then

            If Form1.formloaded Then

                'MsgBox("resize")
                Form1.demo_set_ratio()
                positionandsizecards()


            End If
        End If

    End Sub





    ''''''


    Dim cardclicked As Int16 = -1
    Dim backgroundclicked As Boolean = False
    Dim cardrightclicked As Int16 = -1

    Dim startmouselocation As Point

    'the sign is centered around this point in addition to zooming in
    Dim zoom_point_clicked As Point



    Dim zoommode_clickaction As Integer

    Enum zoomaction
        disabled
        zoominsmall
        zoominbig

        zoomoutsmall
        zoomoutbig


    End Enum



    Private Sub LiteCard_common_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles LiteCard9.MouseDown, LiteCard8.MouseDown, LiteCard7.MouseDown, LiteCard6.MouseDown, _
        LiteCard5.MouseDown, LiteCard4.MouseDown, LiteCard3.MouseDown, LiteCard2.MouseDown, _
        LiteCard1.MouseDown, LiteCard0.MouseDown, LiteCard16.MouseDown, LiteCard15.MouseDown, LiteCard14.MouseDown, _
        LiteCard13.MouseDown, LiteCard12.MouseDown, LiteCard11.MouseDown, LiteCard10.MouseDown
        'CFM

        If e.Button = Windows.Forms.MouseButtons.Right Then
            'this vslue is stored no mater what the state
            cardrightclicked = Convert.ToInt16(sender.tag)
        End If


        If curr_clickmode = clickmodes.mypatterndesign Or curr_clickmode = clickmodes.signdrag Then

            'this section done if the user has clicked start under my sign pattern
            'and have not clicked draged or zoom

            If e.Button = Windows.Forms.MouseButtons.Left Then
                cardclicked = Convert.ToInt16(sender.tag)
                'Lbl_linetime.Text = cardclicked.ToString

                startmouselocation = Control.MousePosition
            ElseIf e.Button = Windows.Forms.MouseButtons.Right Then

                cardrightclicked = Convert.ToInt16(sender.tag)
                'MsgBox(cardrightclicked)
                sender.ContextMenuStrip = Me.ContextMen_litecards
                sender.ContextMenuStrip.Show()
                'ContextMen_litecards.Show()

            End If


        ElseIf curr_clickmode = clickmodes.signzoom Then

            'show the context menue with zoom option

            If e.Button = Windows.Forms.MouseButtons.Left Then
                If zoommode_clickaction = zoomaction.zoominsmall Then

                    signZoomInbig()
                ElseIf zoommode_clickaction = zoomaction.zoominbig Then

                    signZoomInbig()
                ElseIf zoommode_clickaction = zoomaction.zoomoutsmall Then
                    signZoomOutSmall()
                ElseIf zoommode_clickaction = zoomaction.zoomoutbig Then
                    signZoomOutBig()

                End If



            ElseIf e.Button = Windows.Forms.MouseButtons.Right Then


                zoom_point_clicked = Control.MousePosition
                sender.ContextMenuStrip = ContextMen_sign_zoom
                sender.ContextMenuStrip.show()

            End If

        ElseIf curr_clickmode = clickmodes.imagezoom Then

            'show the context menue with zoom option

            If e.Button = Windows.Forms.MouseButtons.Left Then
                If zoommode_clickaction = zoomaction.zoominsmall Then
                    imageZoomInSmall()
                ElseIf zoommode_clickaction = zoomaction.zoominbig Then
                    imageZoomInLarge()
                ElseIf zoommode_clickaction = zoomaction.zoomoutsmall Then
                    imageZoomOutSmall()
                ElseIf zoommode_clickaction = zoomaction.zoomoutbig Then
                    imageZoomOutLarge()
                End If



            ElseIf e.Button = Windows.Forms.MouseButtons.Right Then


                zoom_point_clicked = Control.MousePosition
                sender.ContextMenuStrip = ContextMen_sign_zoom
                sender.ContextMenuStrip.show()

            End If








        End If

        'MsgBox()
    End Sub

    Private Sub LiteCard_common_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles LiteCard9.MouseUp, LiteCard8.MouseUp, LiteCard7.MouseUp, LiteCard6.MouseUp, LiteCard5.MouseUp, _
        LiteCard4.MouseUp, LiteCard3.MouseUp, LiteCard2.MouseUp, LiteCard1.MouseUp, LiteCard0.MouseUp, _
        LiteCard15.MouseUp, LiteCard14.MouseUp, LiteCard13.MouseUp, LiteCard12.MouseUp, LiteCard11.MouseUp, LiteCard10.MouseUp, _
         LiteCard16.MouseUp
        'CFM
        If curr_clickmode = clickmodes.signdrag Or curr_clickmode = clickmodes.mypatterndesign Then

            If e.Button = Windows.Forms.MouseButtons.Left Then

                cardclicked = -1
                'Lbl_linetime.Text = cardclicked.ToString

                'my_simulator_form.positionandsizecards()

                Pan_cards.Invalidate()
                Form1.positionandsizecards()
            ElseIf e.Button = Windows.Forms.MouseButtons.Right Then



            End If
        End If
    End Sub

    Private Sub LiteCard_common_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles LiteCard6.MouseMove, LiteCard4.MouseMove, LiteCard1.MouseMove, LiteCard9.MouseMove, LiteCard8.MouseMove, _
        LiteCard7.MouseMove, LiteCard5.MouseMove, LiteCard3.MouseMove, LiteCard2.MouseMove, LiteCard0.MouseMove, _
        LiteCard15.MouseMove, LiteCard14.MouseMove, LiteCard13.MouseMove, LiteCard12.MouseMove, LiteCard11.MouseMove, LiteCard10.MouseMove, _
        LiteCard15.MouseMove, LiteCard16.MouseMove
        'CFM

        Static counter As Integer = 0

        If curr_clickmode = clickmodes.mypatterndesign Then


            If e.Button = Windows.Forms.MouseButtons.Left Then





                If cardclicked = Convert.ToInt16(sender.tag) Then
                    '
                    '= sender.location

                    Dim currentmouselocation As Point = Control.MousePosition
                    Dim currentlocation As PointF = sender.location


                    'If startmouselocation <> currentlocation Then

                    '
                    Dim newlocation As PointF = New Point(currentlocation.X + currentmouselocation.X - startmouselocation.X, currentlocation.Y + currentmouselocation.Y - startmouselocation.Y)

                    sender.location = newlocation
                    startmouselocation = currentmouselocation

                    'Timer_delayed_invalidate.START
                    If counter >= 0 Then

                        Timer_delayed_invalidate.Start()
                        counter = 0
                    Else
                        counter += 1
                    End If
                    'End If
                    '
                End If



            ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
                'menue such as rotate etc




            End If
        ElseIf curr_clickmode = clickmodes.signdrag Then


            'Static counter As Integer = 0

            If e.Button = Windows.Forms.MouseButtons.Left Then





                If cardclicked > -1 Then
                    '
                    '= sender.location

                    Dim currentmouselocation As Point = Control.MousePosition


                    'If startmouselocation <> currentlocation Then


                    Dim card_curlocation As PointF = LiteCard0.location

                    Dim card_newlocation As PointF = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)

                    'sender.location = newlocation


                    LiteCard0.location = card_newlocation



                    card_curlocation = LiteCard1.location
                    card_newlocation = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)
                    LiteCard1.location = card_newlocation


                    card_curlocation = LiteCard2.location
                    card_newlocation = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)
                    LiteCard2.location = card_newlocation

                    card_curlocation = LiteCard3.location
                    card_newlocation = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)
                    LiteCard3.location = card_newlocation

                    card_curlocation = LiteCard4.location
                    card_newlocation = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)
                    LiteCard4.location = card_newlocation

                    card_curlocation = LiteCard5.location
                    card_newlocation = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)
                    LiteCard5.location = card_newlocation

                    card_curlocation = LiteCard6.location
                    card_newlocation = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)
                    LiteCard6.location = card_newlocation

                    card_curlocation = LiteCard7.location
                    card_newlocation = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)
                    LiteCard7.location = card_newlocation

                    card_curlocation = LiteCard8.location
                    card_newlocation = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)
                    LiteCard8.location = card_newlocation

                    card_curlocation = LiteCard9.location
                    card_newlocation = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)
                    LiteCard9.location = card_newlocation



                    card_curlocation = LiteCard10.location
                    card_newlocation = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)
                    LiteCard10.location = card_newlocation

                    card_curlocation = LiteCard11.location
                    card_newlocation = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)
                    LiteCard11.location = card_newlocation

                    card_curlocation = LiteCard12.location
                    card_newlocation = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)
                    LiteCard12.location = card_newlocation

                    card_curlocation = LiteCard13.location
                    card_newlocation = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)
                    LiteCard13.location = card_newlocation

                    card_curlocation = LiteCard14.location
                    card_newlocation = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)
                    LiteCard14.location = card_newlocation

                    card_curlocation = LiteCard15.location
                    card_newlocation = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)
                    LiteCard15.location = card_newlocation


                    card_curlocation = LiteCard16.location
                    card_newlocation = New PointF(card_curlocation.X + currentmouselocation.X - startmouselocation.X, card_curlocation.Y + currentmouselocation.Y - startmouselocation.Y)
                    LiteCard16.location = card_newlocation
                    'CFM


                    startmouselocation = currentmouselocation

                    'Timer_delayed_invalidate.START
                    If counter >= 0 Then

                        Timer_delayed_invalidate.Start()
                        counter = 0
                    Else
                        counter += 1
                    End If
                    'End If
                    '
                End If


            End If
        End If
    End Sub


    Private Sub enlargecard(ByVal cardnum As Int16, ByVal amount As Int16)
        If cardnum = 0 Then

            LiteCard0.FontSize += amount

        ElseIf cardnum = 1 Then

            LiteCard1.FontSize += amount
        ElseIf cardnum = 2 Then

            LiteCard2.FontSize += amount

        ElseIf cardnum = 3 Then

            LiteCard3.FontSize += amount

        ElseIf cardnum = 4 Then

            LiteCard4.FontSize += amount

        ElseIf cardnum = 5 Then

            LiteCard5.FontSize += amount

        ElseIf cardnum = 6 Then

            LiteCard6.FontSize += amount

        ElseIf cardnum = 7 Then

            LiteCard7.FontSize += amount

        ElseIf cardnum = 8 Then

            LiteCard8.FontSize += amount

        ElseIf cardnum = 9 Then

            LiteCard9.FontSize += amount

        ElseIf cardnum = 10 Then

            LiteCard10.FontSize += amount

        ElseIf cardnum = 11 Then

            LiteCard11.FontSize += amount
        ElseIf cardnum = 12 Then

            LiteCard12.FontSize += amount

        ElseIf cardnum = 13 Then

            LiteCard13.FontSize += amount

        ElseIf cardnum = 14 Then

            LiteCard14.FontSize += amount

        ElseIf cardnum = 15 Then

            LiteCard15.FontSize += amount

        ElseIf cardnum = 16 Then

            LiteCard16.FontSize += amount

            'CFM

        End If
        Timer_delayed_invalidate.Start()
        Form1.positionandsizecards()

        'my_simulator_form.positionandsizecards()


    End Sub
    Private Sub rotatecard(ByVal cardnum As Int16, ByVal angle As Int16)


        If cardnum = 0 Then

            LiteCard0.Angle += angle

            'MsgBox(LiteCard0.Height)
        ElseIf cardnum = 1 Then

            LiteCard1.Angle += angle
        ElseIf cardnum = 2 Then

            LiteCard2.Angle += angle

        ElseIf cardnum = 3 Then

            LiteCard3.Angle += angle

        ElseIf cardnum = 4 Then

            LiteCard4.Angle += angle

        ElseIf cardnum = 5 Then

            LiteCard5.Angle += angle

        ElseIf cardnum = 6 Then

            LiteCard6.Angle += angle

        ElseIf cardnum = 7 Then

            LiteCard7.Angle += angle

        ElseIf cardnum = 8 Then

            LiteCard8.Angle += angle

        ElseIf cardnum = 9 Then

            LiteCard9.Angle += angle


        ElseIf cardnum = 10 Then

            LiteCard10.Angle += angle

        ElseIf cardnum = 11 Then

            LiteCard11.Angle += angle
        ElseIf cardnum = 12 Then

            LiteCard12.Angle += angle

        ElseIf cardnum = 13 Then

            LiteCard13.Angle += angle

        ElseIf cardnum = 14 Then

            LiteCard14.Angle += angle

        ElseIf cardnum = 15 Then

            LiteCard15.Angle += angle

        ElseIf cardnum = 16 Then

            LiteCard16.Angle += angle
            'CFM

        End If
        Timer_delayed_invalidate.Start()
        Form1.positionandsizecards()
        'my_simulator_form.positionandsizecards()

    End Sub


    Public Sub setCardForecolor(ByVal pattern As String)
        'pattern contains a string of the letter R, w, G,or B\
        'these letters correspond to the color of the litecard that shares their index
        'if there are fewer then 10 letters the remaining cards are not changed
        'if there are more then 10 letters an error is given

        pattern = pattern.Replace(" ", "") 'remove spaces
        Dim loopcounter As Int16 = 0
        'If pattern.Length >  Then
        '    MsgBox("pattern passed to setForeColor references too many cards" + Constants.vbCrLf + "please repor this bug")
        '    Return

        'End If

        While loopcounter < pattern.Length
            Dim thiscolor As Color
            If (pattern.ToUpper())(loopcounter) = "R" Then
                thiscolor = Color.Red
            ElseIf (pattern.ToUpper())(loopcounter) = "W" Then
                thiscolor = Color.White

            ElseIf (pattern.ToUpper())(loopcounter) = "B" Then
                thiscolor = Color.Blue

            ElseIf (pattern.ToUpper())(loopcounter) = "G" Then
                thiscolor = Color.Green


            End If
            setCardForecolor(loopcounter, thiscolor)
            loopcounter += 1
        End While

    End Sub
    Private Sub setCardForecolor(ByVal cardnum As Int16, ByVal _color As Color)


        If cardnum = 0 Then

            LiteCard0.ForeColor = _color
            Form1.LiteCard0.ForeColor = _color

        ElseIf cardnum = 1 Then

            LiteCard1.ForeColor = _color
            Form1.LiteCard1.ForeColor = _color
        ElseIf cardnum = 2 Then

            LiteCard2.ForeColor = _color
            Form1.LiteCard2.ForeColor = _color

        ElseIf cardnum = 3 Then

            LiteCard3.ForeColor = _color
            Form1.LiteCard3.ForeColor = _color

        ElseIf cardnum = 4 Then

            LiteCard4.ForeColor = _color
            Form1.LiteCard4.ForeColor = _color

        ElseIf cardnum = 5 Then

            LiteCard5.ForeColor = _color
            Form1.LiteCard5.ForeColor = _color

        ElseIf cardnum = 6 Then

            LiteCard6.ForeColor = _color
            Form1.LiteCard6.ForeColor = _color

        ElseIf cardnum = 7 Then

            LiteCard7.ForeColor = _color
            Form1.LiteCard7.ForeColor = _color

        ElseIf cardnum = 8 Then

            LiteCard8.ForeColor = _color
            Form1.LiteCard8.ForeColor = _color

        ElseIf cardnum = 9 Then

            LiteCard9.ForeColor = _color
            Form1.LiteCard9.ForeColor = _color

        ElseIf cardnum = 10 Then

            LiteCard10.ForeColor = _color
            Form1.LiteCard10.ForeColor = _color

        ElseIf cardnum = 11 Then

            LiteCard11.ForeColor = _color
            Form1.LiteCard11.ForeColor = _color
        ElseIf cardnum = 12 Then

            LiteCard12.ForeColor = _color
            Form1.LiteCard12.ForeColor = _color

        ElseIf cardnum = 13 Then

            LiteCard13.ForeColor = _color
            Form1.LiteCard13.ForeColor = _color

        ElseIf cardnum = 14 Then

            LiteCard14.ForeColor = _color
            Form1.LiteCard14.ForeColor = _color

        ElseIf cardnum = 15 Then

            LiteCard15.ForeColor = _color
            Form1.LiteCard15.ForeColor = _color

        ElseIf cardnum = 16 Then

            LiteCard16.ForeColor = _color
            Form1.LiteCard16.ForeColor = _color
            'CFM
            'CMF 122812 


        End If
        'Timer_delayed_invalidate.Start()
        'Form1.positionandsizecards()
        'my_simulator_form.positionandsizecards()

    End Sub
    Private Sub setCardBackcolor(ByVal cardnum As Int16, ByVal _color As Color)


        If cardnum = 0 Then

            LiteCard0.Backcolor = _color


        ElseIf cardnum = 1 Then

            LiteCard1.Backcolor = _color
        ElseIf cardnum = 2 Then

            LiteCard2.Backcolor = _color

        ElseIf cardnum = 3 Then

            LiteCard3.Backcolor = _color

        ElseIf cardnum = 4 Then

            LiteCard4.Backcolor = _color

        ElseIf cardnum = 5 Then

            LiteCard5.Backcolor = _color

        ElseIf cardnum = 6 Then

            LiteCard6.Backcolor = _color

        ElseIf cardnum = 7 Then

            LiteCard7.Backcolor = _color

        ElseIf cardnum = 8 Then

            LiteCard8.Backcolor = _color

        ElseIf cardnum = 9 Then

            LiteCard9.Backcolor = _color


        ElseIf cardnum = 10 Then

            LiteCard10.Backcolor = _color


        ElseIf cardnum = 11 Then

            LiteCard11.Backcolor = _color
        ElseIf cardnum = 12 Then

            LiteCard12.Backcolor = _color

        ElseIf cardnum = 13 Then

            LiteCard13.Backcolor = _color

        ElseIf cardnum = 14 Then

            LiteCard14.Backcolor = _color

        ElseIf cardnum = 15 Then

            LiteCard15.Backcolor = _color

        ElseIf cardnum = 16 Then

            LiteCard16.Backcolor = _color
            'CFM

        End If
        'Timer_delayed_invalidate.Start()
        'Form1.positionandsizecards()
        'my_simulator_form.positionandsizecards()

    End Sub

    Private Sub cmi_bigclockwise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmi_bigclockwise.Click

        rotatecard(cardrightclicked, 10)




    End Sub

    Private Sub cmi_smallclockwise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmi_smallclockwise.Click
        rotatecard(cardrightclicked, 1)
    End Sub

    Private Sub cmi_bigcounterclockwise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmi_bigcounterclockwise.Click
        rotatecard(cardrightclicked, -10)
    End Sub

    Private Sub cmi_smallcounterclockwise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmi_smallcounterclockwise.Click
        rotatecard(cardrightclicked, -1)
    End Sub



    'enlarge  the size of 
    'Changming 122812
    'cmi == Context Menu 

    Private Sub cmi_bigenlarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        enlargecard(cardrightclicked, 10)

    End Sub

    Private Sub cmi_smallenlarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        enlargecard(cardrightclicked, 1)
    End Sub

    Private Sub cmi_bigsmaller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        enlargecard(cardrightclicked, -10)
    End Sub

    Private Sub cmi_smallsmaller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        enlargecard(cardrightclicked, -1)
    End Sub

    'Dim pan_cardbackground_graphics As System.Drawing.Graphics
    'Note : May be something with the context Menu setup causing Proble 
    '122812

    Private Sub Pan_cardbackground_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Pan_cards.Paint

        'this point in the center was soly for debugging 
        'Dim center1 As PointF = New PointF(Pan_cards.Width / 2 - 10, Pan_cards.Height / 2 - 10)
        'Dim center2 As PointF = New PointF(Pan_cards.Width / 2 + 10, Pan_cards.Height / 2 + 10)


        'e.Graphics.DrawLine(Pens.Black, center1, center2)

        '      Static recursive As Boolean = False

        'Dim lines As ArrayList = New ArrayList

        'Dim ends As PointF()


        'pan_cardbackground_graphics = e.Graphics
        '        Timer_delayed_invalidate.Start()
        '       Return

        '    If Not recursive Then
        'recursive = True

        'LiteCard1.Invalidate()
        'LiteCard0.Invalidate()
        'LiteCard2.Invalidate()
        'LiteCard3.Invalidate()
        ' LiteCard4.Invalidate()
        'LiteCard5.Invalidate()
        'LiteCard6.Invalidate()
        'LiteCard7.Invalidate()
        'LiteCard8.Invalidate()
        'LiteCard9.Invalidate()
        'pan_cardbackground_graphics
        Dim end1 As Point
        Dim end2 As Point

        end1 = LiteCard0.rightconection
        end2 = LiteCard1.leftconection


        Dim mypen As Pen = New Pen(Color.Gray, LiteCard0.FontSize / 10)
        'mypen.Width = LiteCard0.FontSize / 10
        If LiteCard0.Visible And LiteCard1.Visible Then
            e.Graphics.DrawLine(mypen, end1, end2)

        End If

        'end1 = LiteCard0.rightconection
        'end2 = LiteCard1.leftconection
        'e.Graphics.DrawLine(mypen, end1, end2)

        If LiteCard1.Visible And LiteCard2.Visible Then
            end1 = LiteCard1.rightconection
            end2 = LiteCard2.leftconection
            e.Graphics.DrawLine(mypen, end1, end2)
        End If

        If LiteCard2.Visible And LiteCard3.Visible Then
            end1 = LiteCard2.rightconection
            end2 = LiteCard3.leftconection
            e.Graphics.DrawLine(mypen, end1, end2)
        End If
        If LiteCard3.Visible And LiteCard4.Visible Then
            end1 = LiteCard3.rightconection
            end2 = LiteCard4.leftconection
            e.Graphics.DrawLine(mypen, end1, end2)
        End If
        If LiteCard4.Visible And LiteCard5.Visible Then
            end1 = LiteCard4.rightconection
            end2 = LiteCard5.leftconection
            e.Graphics.DrawLine(mypen, end1, end2)
        End If

        If LiteCard5.Visible And LiteCard6.Visible Then
            end1 = LiteCard5.rightconection
            end2 = LiteCard6.leftconection
            e.Graphics.DrawLine(mypen, end1, end2)
        End If

        If LiteCard6.Visible And LiteCard7.Visible Then
            end1 = LiteCard6.rightconection
            end2 = LiteCard7.leftconection
            e.Graphics.DrawLine(mypen, end1, end2)
        End If
        If LiteCard7.Visible And LiteCard8.Visible Then
            end1 = LiteCard7.rightconection
            end2 = LiteCard8.leftconection
            e.Graphics.DrawLine(mypen, end1, end2)
        End If
        If LiteCard8.Visible And LiteCard9.Visible Then
            end1 = LiteCard8.rightconection
            end2 = LiteCard9.leftconection
            e.Graphics.DrawLine(mypen, end1, end2)
        End If

        If LiteCard9.Visible And LiteCard10.Visible Then
            end1 = LiteCard9.rightconection
            end2 = LiteCard10.leftconection
            e.Graphics.DrawLine(mypen, end1, end2)
        End If

        If LiteCard10.Visible And LiteCard11.Visible Then
            end1 = LiteCard10.rightconection
            end2 = LiteCard11.leftconection
            e.Graphics.DrawLine(mypen, end1, end2)
        End If

        If LiteCard11.Visible And LiteCard12.Visible Then
            end1 = LiteCard11.rightconection
            end2 = LiteCard12.leftconection
            e.Graphics.DrawLine(mypen, end1, end2)
        End If

        If LiteCard12.Visible And LiteCard13.Visible Then
            end1 = LiteCard12.rightconection
            end2 = LiteCard13.leftconection
            e.Graphics.DrawLine(mypen, end1, end2)
        End If
        If LiteCard13.Visible And LiteCard14.Visible Then
            end1 = LiteCard13.rightconection
            end2 = LiteCard14.leftconection
            e.Graphics.DrawLine(mypen, end1, end2)
        End If
        If LiteCard14.Visible And LiteCard15.Visible Then
            end1 = LiteCard14.rightconection
            end2 = LiteCard15.leftconection
            e.Graphics.DrawLine(mypen, end1, end2)
        End If
        If LiteCard15.Visible And LiteCard16.Visible Then
            end1 = LiteCard15.rightconection
            end2 = LiteCard16.leftconection
            e.Graphics.DrawLine(mypen, end1, end2)
        End If
        'CFM

        
    End Sub

    Private Sub Timer_delayed_drawlines_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_delayed_invalidate.Tick

        Timer_delayed_invalidate.Stop()


        Pan_cards.Invalidate()
        Form1.Pan_cardbackground.Invalidate()
        Return
    End Sub





    Private Sub Change_card_size_common_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        'function no longer used

        Dim changeamount As Single = Convert.ToSingle(sender.tag)


        LiteCard0.FontSize += changeamount
        LiteCard1.FontSize += changeamount
        LiteCard2.FontSize += changeamount
        LiteCard3.FontSize += changeamount
        LiteCard4.FontSize += changeamount
        LiteCard5.FontSize += changeamount
        LiteCard6.FontSize += changeamount
        LiteCard7.FontSize += changeamount
        LiteCard8.FontSize += changeamount
        LiteCard9.FontSize += changeamount

        LiteCard10.FontSize += changeamount
        LiteCard11.FontSize += changeamount
        LiteCard12.FontSize += changeamount
        LiteCard13.FontSize += changeamount
        LiteCard14.FontSize += changeamount
        LiteCard15.FontSize += changeamount
        LiteCard16.FontSize += changeamount
        'CFM

        Pan_cards.Invalidate()

        'Lbut :  Label Button  JP/CMF 122812
        If LiteCard0.FontSize + Convert.ToSingle(Lbut_EnlargeCardSmall.Tag) > Me.max_cardsize Then
            Lbut_EnlargeCardSmall.Enabled = False
            Form1.mark_disabled(Lbut_EnlargeCardSmall)
        Else
            Lbut_EnlargeCardSmall.Enabled = True
            Form1.mark_unselected(Lbut_EnlargeCardSmall)
        End If

        If LiteCard0.FontSize + Convert.ToSingle(Lbut_EnlargeCardBig.Tag) > Me.max_cardsize Then
            Lbut_EnlargeCardBig.Enabled = False
            Form1.mark_disabled(Lbut_EnlargeCardBig)
        Else
            Lbut_EnlargeCardBig.Enabled = True
            Form1.mark_unselected(Lbut_EnlargeCardBig)
        End If



        If LiteCard0.FontSize + Convert.ToSingle(Lbut_ShrinkCardSmall.Tag) < Me.min_cardsize Then
            Lbut_ShrinkCardSmall.Enabled = False
            Form1.mark_disabled(Lbut_ShrinkCardSmall)
        Else
            Lbut_ShrinkCardSmall.Enabled = True
            Form1.mark_unselected(Lbut_ShrinkCardSmall)
        End If

        If LiteCard0.FontSize + Convert.ToSingle(Lbut_ShrinkCardBig.Tag) < Me.min_cardsize Then
            Lbut_ShrinkCardBig.Enabled = False
            Form1.mark_disabled(Lbut_ShrinkCardBig)
        Else
            Lbut_ShrinkCardBig.Enabled = True
            Form1.mark_unselected(Lbut_ShrinkCardBig)
        End If

        Form1.positionandsizecards()
    End Sub

    'Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_ShrinkCardBig.Click

    '    LiteCard0.FontSize -= 0.5
    '    LiteCard1.FontSize -= 0.5
    '    LiteCard2.FontSize -= 0.5
    '    LiteCard3.FontSize -= 0.5
    '    LiteCard4.FontSize -= 0.5
    '    LiteCard5.FontSize -= 0.5
    '    LiteCard6.FontSize -= 0.5
    '    LiteCard7.FontSize -= 0.5
    '    LiteCard8.FontSize -= 0.5
    '    LiteCard9.FontSize -= 0.5

    '    Pan_cardbackground.Invalidate()

    'End Sub




    Private Sub Lbut_custon_start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_custon_start.Click, CMI_movecards.Click, CMI_move_cards.Click, CMI_m0vecards.Click
        cards_locked = False
        curr_clickmode = clickmodes.mypatterndesign
        ret_clickmode = clickmodes.mypatterndesign 'returned to when esc is pressed



        deselectect_all_buttons()

        'Form1.mark_selected(Me.LbL_custom)
        'Lbut_custon_start.Text = "Already Started"
        Form1.mark_selected(Lbut_custon_start)

        clear_veiwmanip_buttons()
        set_mouse_display()


        Me.cmi_bigclockwise.Visible = True
        Me.cmi_smallclockwise.Visible = True
        Me.cmi_bigcounterclockwise.Visible = True
        Me.cmi_smallcounterclockwise.Visible = True
        CMI_m0vecards.Visible = False

        CMI_m0vesign.Visible = True
        CMI_l0ck.Visible = True



        LiteCard0.ContextMenuStrip = Me.ContextMen_litecards
        LiteCard1.ContextMenuStrip = Me.ContextMen_litecards
        LiteCard2.ContextMenuStrip = Me.ContextMen_litecards
        LiteCard3.ContextMenuStrip = Me.ContextMen_litecards
        LiteCard4.ContextMenuStrip = Me.ContextMen_litecards
        LiteCard5.ContextMenuStrip = Me.ContextMen_litecards
        LiteCard6.ContextMenuStrip = Me.ContextMen_litecards
        LiteCard7.ContextMenuStrip = Me.ContextMen_litecards
        LiteCard8.ContextMenuStrip = Me.ContextMen_litecards


        status = New ArrayList
        status.Add("You are in 'My pattern design' mode")
        status.Add("To move individual cards simply click and drag")
        status.Add("You are in 'My pattern design' mode")

        status.Add("To rotate individual cards, right click on card and select option")
        status.Add("You are in 'My pattern design' mode")


        status.Add("To move the entire sign click 'move' under sign controll")
        status.Add("You are in 'My pattern design' mode")
        status.Add("To start over click on one of the free templates below")
        status.Add("You are in 'My pattern design' mode")
        status.Add("To do other actions select from menus below")




    End Sub

    Private Sub simulator_form_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        e.Cancel = True


    End Sub






    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_BG_Default.Click


        OFD_UploadPicture.FileName = ""
        Pan_imageholder.BackgroundImage = Pan_pancontrols.BackgroundImage ' nothing
        Form1.mark_selected(sender)
        Form1.mark_unselected(Label18)


        Form1.mark_disabled(Lbut_BackgroundPanRight)
        Form1.mark_disabled(Lbut_BackgroundPanLeft)
        Form1.mark_disabled(Lbut_BackgroundPanUp)
        Form1.mark_disabled(Lbut_BackgroundPanDown)
        Form1.mark_disabled(Lbut_BackgroundZoomInSmall)
        Form1.mark_disabled(Lbut_BackgroundZoomInLarge)
        Form1.mark_disabled(Lbut_BackgroundZoomOutSmall)
        Form1.mark_disabled(Lbut_BackgroundZoomOutLarge)

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click




        With OFD_UploadPicture
            .Reset() 'changing the initial directory doesnt work otherwise
            .Filter = filter_image

            'the .ShowDialog function reset the path which needs to be restored in order for hep userdata and settings to be
            'written and read correctly. also I am saving the selected directory in user data file so that the dialog box will
            'open to the same path

            Dim path As String = IO.Directory.GetCurrentDirectory



            IO.Directory.SetCurrentDirectory(Form1.userdata(Form1.userdataindex.PictureUpLoadPath))

            .InitialDirectory = Form1.userdata(Form1.userdataindex.PictureUpLoadPath)

            Dim answer As DialogResult = .ShowDialog

            Form1.userdata(Form1.userdataindex.PictureUpLoadPath) = IO.Directory.GetCurrentDirectory

            If answer = Windows.Forms.DialogResult.Cancel Then

                IO.Directory.SetCurrentDirectory(path)

                Return
            Else



                ' ''If OFD_UploadPicture.ShowDialog() = Windows.Forms.DialogResult.Cancel Then

                ' ''    Return
                ' ''End If

                'Pan_imageholder.Size = Pan_cardbackground.Size
                'Pan_imageholder.Location = New Point(0, 0)




                Pan_imageholder.BackgroundImage = Image.FromFile(OFD_UploadPicture.FileName)
                Pan_imageholder.BackgroundImageLayout = ImageLayout.Zoom

                IO.Directory.SetCurrentDirectory(path)

                'Form1.mark_selected(sender)

                Form1.mark_selected(sender)

                Form1.mark_unselected(Lbut_BG_Default)


                Form1.mark_unselected(Lbut_BackgroundPanRight)
                Form1.mark_unselected(Lbut_BackgroundPanLeft)
                Form1.mark_unselected(Lbut_BackgroundPanUp)
                Form1.mark_unselected(Lbut_BackgroundPanDown)
                Form1.mark_unselected(Lbut_BackgroundZoomInSmall)
                Form1.mark_unselected(Lbut_BackgroundZoomInLarge)
                Form1.mark_unselected(Lbut_BackgroundZoomOutSmall)
                Form1.mark_unselected(Lbut_BackgroundZoomOutLarge)


                Lbut_BackgroundZoomInSmall.Enabled = True
                Lbut_BackgroundZoomInLarge.Enabled = True


                default_zoom()

                set_veiwmanip_buttons()
            End If

        End With

    End Sub

    'Private Sub set_zoomandpan_enableds()
    '    set_veiwmanip_buttons()


    'End Sub
    Private Sub default_zoom()
        Pan_imageholder.Top = 0
        Pan_imageholder.Left = 0

        Pan_imageholder.Width = Pan_dislpayregion.Width

        Pan_imageholder.Height = Pan_dislpayregion.Height
        Lbut_BackgroundZoomOutSmall.Enabled = False

        Form1.mark_disabled(Lbut_BackgroundZoomOutSmall)

        Lbut_BackgroundZoomOutLarge.Enabled = False
        Form1.mark_disabled(Lbut_BackgroundZoomOutLarge)

        Lbut_BackgroundPanUp.Enabled = False

        Form1.mark_disabled(Lbut_BackgroundPanUp)


        Lbut_BackgroundPanDown.Enabled = False

        Form1.mark_disabled(Lbut_BackgroundPanDown)

        Lbut_BackgroundPanLeft.Enabled = False

        Form1.mark_disabled(Lbut_BackgroundPanLeft)
        Lbut_BackgroundPanRight.Enabled = False

        Form1.mark_disabled(Lbut_BackgroundPanRight)
        position_Pan_cardbackground()
    End Sub


    Private Function imageZommOverflowIminent(ByVal factor As Single) As Boolean
        'check for overflow

        Dim tempvalueholder As Int64


        If factor >= 0 Then

            tempvalueholder = Pan_imageholder.Top - factor * Pan_imageholder.Height / 2
            If tempvalueholder < -32767 Or tempvalueholder > 32767 Then
                Beep()
                Return True
            End If

            tempvalueholder = Pan_imageholder.Left - factor * Pan_imageholder.Width / 2
            If tempvalueholder < -32767 Or tempvalueholder > 32767 Then
                Beep()

                Return True
            End If


            tempvalueholder = Pan_imageholder.Width * (1 + factor)
            If tempvalueholder < -32767 Or tempvalueholder > 32767 Then
                Beep()

                Return True
            End If


            tempvalueholder = Pan_imageholder.Height * (1 + factor)
            If tempvalueholder < -32767 Or tempvalueholder > 32767 Then
                Beep()

                Return True
            End If

        Else

            factor = -factor
            tempvalueholder = Pan_imageholder.Top + factor * Pan_imageholder.Height / 2
            If tempvalueholder < -32767 Or tempvalueholder > 32767 Then
                Beep()
                Return True
            End If

            tempvalueholder = Pan_imageholder.Left + factor * Pan_imageholder.Width / 2
            If tempvalueholder < -32767 Or tempvalueholder > 32767 Then
                Beep()

                Return True
            End If


            tempvalueholder = Pan_imageholder.Width / (1 + factor)
            If tempvalueholder < -32767 Or tempvalueholder > 32767 Then
                Beep()

                Return True
            End If


            tempvalueholder = Pan_imageholder.Height / (1 + factor)
            If tempvalueholder < -32767 Or tempvalueholder > 32767 Then
                Beep()

                Return True
            End If

        End If




        'if not true must be false 
        Return False

    End Function


    Private Sub imageZoomInSmall()
        If Lbut_BackgroundZoomInSmall.Enabled = False Then

            Beep()
            Return
        End If

        If imageZommOverflowIminent(0.01) Then

            Return
        End If


        curr_clickmode = clickmodes.imagezoom

        'zoommode_clickaction must be set before calling set_veiwmanip_buttons()
        zoommode_clickaction = zoomaction.zoominsmall




        Pan_imageholder.Top -= 0.01 * Pan_imageholder.Height / 2
        Pan_imageholder.Left -= 0.01 * Pan_imageholder.Width / 2


        'Dim dummy As int
        Pan_imageholder.Width *= 1.01
        Pan_imageholder.Height *= 1.01


        position_Pan_cardbackground()


        set_veiwmanip_buttons()
        Form1.mark_selected(Lbut_BackgroundZoomInSmall)

        'Pan_imageholder.Region = Pan_cardbackground.Region

    End Sub
    Private Sub Lbut_imageZoomInSmall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_BackgroundZoomInSmall.Click, Lbut_BackgroundZoom.Click, Pan_pict_BackgroundZoom.Click, Pan_BackgroundZoom.Click

        If Lbut_BackgroundZoomInSmall.Enabled = False Then

            Beep()
            Return
        End If
        imageZoomInSmall()

    End Sub
    Private Sub imageZoomIn(ByVal factor)

        'If Lbut_BackgroundZoomInLarge.Enabled = False Then

        '    Beep()
        '    Return
        'End If

        If imageZommOverflowIminent(factor) Then

            Return
        End If

        'curr_clickmode = clickmodes.imagezoom


        'zoommode_clickaction must be set before calling set_veiwmanip_buttons()
        'zoommode_clickaction = zoomaction.zoominbig


        Pan_imageholder.Top -= factor * Pan_imageholder.Height / 2
        Pan_imageholder.Left -= factor * Pan_imageholder.Width / 2



        Pan_imageholder.Width *= (1 + factor)
        Pan_imageholder.Height *= (1 + factor)
        position_Pan_cardbackground()


        'set_mouse_display()
        'set_veiwmanip_buttons()

        'Form1.mark_selected(Lbut_BackgroundZoomInLarge)

        'Pan_imageholder.Region = Pan_cardbackground.Region

        '      MsgBox("Sorry this functionality is not yet implimented")

    End Sub



    Private Sub imageZoomInLarge()

        If Lbut_BackgroundZoomInLarge.Enabled = False Then

            Beep()
            Return
        End If

        If imageZommOverflowIminent(0.5) Then

            Return
        End If

        curr_clickmode = clickmodes.imagezoom


        'zoommode_clickaction must be set before calling set_veiwmanip_buttons()
        zoommode_clickaction = zoomaction.zoominbig


        Pan_imageholder.Top -= 0.5 * Pan_imageholder.Height / 2
        Pan_imageholder.Left -= 0.5 * Pan_imageholder.Width / 2



        Pan_imageholder.Width *= 1.5
        Pan_imageholder.Height *= 1.5
        position_Pan_cardbackground()


        set_mouse_display()
        set_veiwmanip_buttons()

        Form1.mark_selected(Lbut_BackgroundZoomInLarge)

        'Pan_imageholder.Region = Pan_cardbackground.Region

        '      MsgBox("Sorry this functionality is not yet implimented")

    End Sub
    Private Sub Lbut_imageZoomInLarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_BackgroundZoomInLarge.Click
        imageZoomInLarge()
    End Sub

    Private Sub imageZoomOutSmall()

        If Lbut_BackgroundZoomOutSmall.Enabled = False Then

            Beep()
            Return
        End If

        If imageZommOverflowIminent(-0.01) Then

            Return
        End If

        curr_clickmode = clickmodes.imagezoom

        'zoommode_clickaction must be set before calling set_veiwmanip_buttons()
        zoommode_clickaction = zoomaction.zoomoutsmall


        Pan_imageholder.Width /= 1.01
        Pan_imageholder.Height /= 1.01

        Pan_imageholder.Top += 0.01 * Pan_imageholder.Height / 2
        Pan_imageholder.Left += 0.01 * Pan_imageholder.Width / 2

        position_Pan_cardbackground()


        set_mouse_display()
        set_veiwmanip_buttons()

        Form1.mark_selected(Lbut_BackgroundZoomOutSmall)

        'Pan_imageholder.Region = Pan_cardbackground.Region

        '       MsgBox("Sorry this functionality is not yet implimented")

    End Sub

    Private Sub Lbut_imageZoomOutSmall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_BackgroundZoomOutSmall.Click
        imageZoomOutSmall()
    End Sub

    Private Sub imageZoomOutLarge()

        If Lbut_BackgroundZoomOutLarge.Enabled = False Then

            Beep()
            Return
        End If

        If imageZommOverflowIminent(-0.5) Then

            Return
        End If

        curr_clickmode = clickmodes.imagezoom

        'zoommode_clickaction must be set before calling set_veiwmanip_buttons()
        zoommode_clickaction = zoomaction.zoomoutbig



        Pan_imageholder.Width /= 1.5
        Pan_imageholder.Height /= 1.5

        Pan_imageholder.Top += 0.5 * Pan_imageholder.Height / 2
        Pan_imageholder.Left += 0.5 * Pan_imageholder.Width / 2



        position_Pan_cardbackground()
        Pan_imageholder.Region = Pan_cards.Region



        set_veiwmanip_buttons()
        Form1.mark_selected(Lbut_BackgroundZoomOutLarge)

        '        MsgBox("Sorry this functionality is not yet implimented")
    End Sub
    Private Sub Lbut_imageZoomOutLarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_BackgroundZoomOutLarge.Click


        imageZoomOutLarge()


    End Sub

    Private Sub Lbut_PanLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_BackgroundPanLeft.Click

        Pan_imageholder.Left += Pan_imageholder.Width * PAN_CONSTANT

        If Pan_imageholder.Left > 0 Then

            Pan_imageholder.Left = 0


        End If
        position_Pan_cardbackground()



        BackgroundMove_Click(sender, e)

        set_veiwmanip_buttons()

        '''

        '     MsgBox("Sorry this functionality is not yet implimented")
    End Sub

    Private Sub Lbut_PanDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_BackgroundPanDown.Click
        Pan_imageholder.Top -= Pan_imageholder.Width * PAN_CONSTANT

        If Pan_imageholder.Bottom < Pan_dislpayregion.Height Then

            Pan_imageholder.Top += Pan_dislpayregion.Height - Pan_imageholder.Bottom


        End If
        position_Pan_cardbackground()

        BackgroundMove_Click(sender, e)
        set_veiwmanip_buttons()



        'MsgBox("Sorry this functionality is not yet implimented")
    End Sub

    Private Sub Lbut_PanRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_BackgroundPanRight.Click
        Pan_imageholder.Left -= Pan_imageholder.Width * PAN_CONSTANT

        If Pan_imageholder.Right < Pan_dislpayregion.Width Then

            Pan_imageholder.Left += Pan_dislpayregion.Width - Pan_imageholder.Right


        End If
        position_Pan_cardbackground()

        BackgroundMove_Click(sender, e)
        set_veiwmanip_buttons()
        ' x()



        '        MsgBox("Sorry this functionality is not yet implimented")
    End Sub

    Private Sub Lbut_PanUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_BackgroundPanUp.Click
        Pan_imageholder.Top += Pan_imageholder.Height * PAN_CONSTANT

        If Pan_imageholder.Top > 0 Then

            Pan_imageholder.Top = 0


        End If

        position_Pan_cardbackground()
        set_veiwmanip_buttons()

        'MsgBox("Sorry this functionality is not yet implimented")
    End Sub




    Private Sub signZoomInBig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_EnlargeCardBig.Click, CMI_sign_zoominlarge.Click, CMI_zoominBig.Click, CMI_z00minbig.Click
        'Dim changeamount As Single = Convert.ToSingle(sender.tag)


        If Not Lbut_EnlargeCardBig.Enabled Then
            status = New ArrayList
            status.Add("Sorry you can not zoom in any more on the sign")
            status.Add("To zoom out sign click '-' or '--' under sign controll")
            status.Add("Sorry you can not zoom in any more on the sign")
            status.Add("To zoom background in or out click zoom buttons under background image")
            status.Add("Sorry you can not zoom in any more on the sign")
            status.Add("To Move the entire sign click move buttons under sign controll")
            status.Add("Sorry you can not zoom in any more on the sign")
            If ret_clickmode = clickmodes.mypatterndesign Then
                status.Add("To move individual cards press escape on key board")
            Else
                status.Add("To move individual cards click " & Lbut_custon_start.Text & " under My Pattern")
            End If



            Beep()
            Return
        End If

        status = New ArrayList
        status.Add("you are in 'Sign Zoom In' mode")

        status.Add("To zoom in simply click on the sign")
        status.Add("you are in 'Sign Zoom In' mode")

        status.Add("To zoom out click '-' or '--' below")
        status.Add("you are in 'Sign Zoom In' mode")

        If ret_clickmode = clickmodes.mypatterndesign Then
            status.Add("To move individual cards press escape on key board")
        Else
            status.Add("To move individual cards click " & Lbut_custon_start.Text & " under My Pattern")
        End If
        status.Add("you are in 'Sign Zoom In' mode")
        status.Add("To do other actions select from menu below")
        status.Add("you are in 'Sign Zoom In' mode")

        curr_clickmode = clickmodes.signzoom
        'zoommode_clickaction must be set before calling set_veiwmanip_buttons()
        zoommode_clickaction = zoomaction.zoominbig

        set_mouse_display()
        set_veiwmanip_buttons()


        signZoomInbig()




        Return

        'below is old code

        LiteCard0.FontSize *= (1 + BIGZOOMFACTOR)
        LiteCard1.FontSize *= (1 + BIGZOOMFACTOR)
        LiteCard2.FontSize *= (1 + BIGZOOMFACTOR)
        LiteCard3.FontSize *= (1 + BIGZOOMFACTOR)
        LiteCard4.FontSize *= (1 + BIGZOOMFACTOR)
        LiteCard5.FontSize *= (1 + BIGZOOMFACTOR)
        LiteCard6.FontSize *= (1 + BIGZOOMFACTOR)
        LiteCard7.FontSize *= (1 + BIGZOOMFACTOR)
        LiteCard8.FontSize *= (1 + BIGZOOMFACTOR)
        LiteCard9.FontSize *= (1 + BIGZOOMFACTOR)
        LiteCard10.FontSize *= (1 + BIGZOOMFACTOR)
        LiteCard11.FontSize *= (1 + BIGZOOMFACTOR)
        LiteCard12.FontSize *= (1 + BIGZOOMFACTOR)
        LiteCard13.FontSize *= (1 + BIGZOOMFACTOR)
        LiteCard14.FontSize *= (1 + BIGZOOMFACTOR)
        LiteCard15.FontSize *= (1 + BIGZOOMFACTOR)
        LiteCard16.FontSize *= (1 + BIGZOOMFACTOR)
        'CFM


        LiteCard0.Top *= (1 + BIGZOOMFACTOR)
        LiteCard1.Top *= (1 + BIGZOOMFACTOR)
        LiteCard2.Top *= (1 + BIGZOOMFACTOR)
        LiteCard3.Top *= (1 + BIGZOOMFACTOR)
        LiteCard4.Top *= (1 + BIGZOOMFACTOR)
        LiteCard5.Top *= (1 + BIGZOOMFACTOR)
        LiteCard6.Top *= (1 + BIGZOOMFACTOR)
        LiteCard7.Top *= (1 + BIGZOOMFACTOR)
        LiteCard8.Top *= (1 + BIGZOOMFACTOR)
        LiteCard9.Top *= (1 + BIGZOOMFACTOR)
        LiteCard10.Top *= (1 + BIGZOOMFACTOR)
        LiteCard11.Top *= (1 + BIGZOOMFACTOR)
        LiteCard12.Top *= (1 + BIGZOOMFACTOR)
        LiteCard13.Top *= (1 + BIGZOOMFACTOR)
        LiteCard14.Top *= (1 + BIGZOOMFACTOR)
        LiteCard15.Top *= (1 + BIGZOOMFACTOR)
        LiteCard16.Top *= (1 + BIGZOOMFACTOR)
        'CFM


        LiteCard0.Left *= (1 + BIGZOOMFACTOR)
        LiteCard1.Left *= (1 + BIGZOOMFACTOR)
        LiteCard2.Left *= (1 + BIGZOOMFACTOR)
        LiteCard3.Left *= (1 + BIGZOOMFACTOR)
        LiteCard4.Left *= (1 + BIGZOOMFACTOR)
        LiteCard5.Left *= (1 + BIGZOOMFACTOR)
        LiteCard6.Left *= (1 + BIGZOOMFACTOR)
        LiteCard7.Left *= (1 + BIGZOOMFACTOR)
        LiteCard8.Left *= (1 + BIGZOOMFACTOR)
        LiteCard9.Left *= (1 + BIGZOOMFACTOR)
        LiteCard10.Left *= (1 + BIGZOOMFACTOR)
        LiteCard11.Left *= (1 + BIGZOOMFACTOR)
        LiteCard12.Left *= (1 + BIGZOOMFACTOR)
        LiteCard13.Left *= (1 + BIGZOOMFACTOR)
        LiteCard14.Left *= (1 + BIGZOOMFACTOR)
        LiteCard15.Left *= (1 + BIGZOOMFACTOR)
        LiteCard16.Left *= (1 + BIGZOOMFACTOR)
        'CFM


        'Pan_cards.Invalidate()


        If LiteCard0.FontSize + Convert.ToSingle(Lbut_EnlargeCardSmall.Tag) > Me.max_cardsize Then
            Lbut_EnlargeCardSmall.Enabled = False
            Form1.mark_disabled(Lbut_EnlargeCardSmall)
        Else
            Lbut_EnlargeCardSmall.Enabled = True
            Form1.mark_unselected(Lbut_EnlargeCardSmall)
        End If

        If LiteCard0.FontSize + Convert.ToSingle(Lbut_EnlargeCardBig.Tag) > Me.max_cardsize Then
            Lbut_EnlargeCardBig.Enabled = False
            Form1.mark_disabled(Lbut_EnlargeCardBig)
        Else
            Lbut_EnlargeCardBig.Enabled = True
            Form1.mark_unselected(Lbut_EnlargeCardBig)
        End If



        If LiteCard0.FontSize + Convert.ToSingle(Lbut_ShrinkCardSmall.Tag) < Me.min_cardsize Then
            Lbut_ShrinkCardSmall.Enabled = False
            Form1.mark_disabled(Lbut_ShrinkCardSmall)
        Else
            Lbut_ShrinkCardSmall.Enabled = True
            Form1.mark_unselected(Lbut_ShrinkCardSmall)
        End If

        If LiteCard0.FontSize + Convert.ToSingle(Lbut_ShrinkCardBig.Tag) < Me.min_cardsize Then
            Lbut_ShrinkCardBig.Enabled = False
            Form1.mark_disabled(Lbut_ShrinkCardBig)
        Else
            Lbut_ShrinkCardBig.Enabled = True
            Form1.mark_unselected(Lbut_ShrinkCardBig)
        End If
        Me.Timer_delayed_invalidate.Start()
        Form1.positionandsizecards()
    End Sub


    Private Sub signZoomInSmall()
        If Not Lbut_EnlargeCardSmall.Enabled Then
            status = New ArrayList
            status.Add("Sorry you can not zoom in any more on the sign")
            status.Add("To zoom out sign click '-' or '--' under sign controll")
            status.Add("Sorry you can not zoom in any more on the sign")
            status.Add("To zoom background in or out click zoom buttons under background image")
            status.Add("Sorry you can not zoom in any more on the sign")
            status.Add("To Move the entire sign click move buttons under sign controll")
            status.Add("Sorry you can not zoom in any more on the sign")
            If ret_clickmode = clickmodes.mypatterndesign Then
                status.Add("To move individual cards press escape on key board")
            Else
                status.Add("To move individual cards click " & Lbut_custon_start.Text & " under My Pattern")
            End If

            Beep()
            Return
        End If


        signZoom(SMALLZOOMFACTOR)



        'Pan_cards.Invalidate()





    End Sub

    Private Sub signZoomOutSmall()
        If Not Lbut_ShrinkCardSmall.Enabled Then

            status = New ArrayList
            status.Add("Sorry you can not zoom out any more on the sign")
            status.Add("To zoom in sign click '+' or '++' under sign controll")
            status.Add("Sorry you can not zoom out any more on the sign")
            status.Add("To zoom background in or out click zoom buttons under background image")
            status.Add("Sorry you can not zoom out any more on the sign")
            status.Add("To Move the entire sign click move buttons under sign controll")
            status.Add("Sorry you can not zoom out any more on the sign")
            If ret_clickmode = clickmodes.mypatterndesign Then
                status.Add("To move individual cards press escape on key board")
            Else
                status.Add("To move individual cards click " & Lbut_custon_start.Text & " under My Pattern")
            End If

            Beep()

            Return
        End If

        signZoom(-SMALLZOOMFACTOR)

    End Sub
    Private Sub signZoomOutBig()
        If Not Lbut_ShrinkCardBig.Enabled Then
            status = New ArrayList
            status.Add("Sorry you can not zoom out any more on the sign")
            status.Add("To zoom in sign click '+' or '++' under sign controll")
            status.Add("Sorry you can not zoom out any more on the sign")
            status.Add("To zoom background in or out click zoom buttons under background image")
            status.Add("Sorry you can not zoom out any more on the sign")
            status.Add("To Move the entire sign click move buttons under sign controll")
            status.Add("Sorry you can not zoom out any more on the sign")
            If ret_clickmode = clickmodes.mypatterndesign Then
                status.Add("To move individual cards press escape on key board")
            Else
                status.Add("To move individual cards click " & Lbut_custon_start.Text & " under My Pattern")
            End If

            Beep()
            Return
        End If

        signZoom(-BIGZOOMFACTOR)

    End Sub

    Private Sub signZoomInbig()
        If Not Lbut_EnlargeCardBig.Enabled Then
            status = New ArrayList
            status.Add("Sorry you can not zoom in any more on the sign")
            status.Add("To zoom out sign click '-' or '--' under sign controll")
            status.Add("Sorry you can not zoom in any more on the sign")
            status.Add("To zoom background in or out click zoom buttons under background image")
            status.Add("Sorry you can not zoom in any more on the sign")
            status.Add("To Move the entire sign click move buttons under sign controll")
            status.Add("Sorry you can not zoom in any more on the sign")
            If ret_clickmode = clickmodes.mypatterndesign Then
                status.Add("To move individual cards press escape on key board")
            Else
                status.Add("To move individual cards click " & Lbut_custon_start.Text & " under My Pattern")
            End If

            Beep()
            Return
        End If


        signZoom(BIGZOOMFACTOR)



    End Sub

    Private Sub signZoom(ByVal factor As Single)

        Dim center As PointF = New PointF(Pan_cards.Width / 2, Pan_cards.Height / 2)
        Dim newlocation As PointF

        If True Then
            LiteCard0.FontSize *= (1 + factor)
            LiteCard1.FontSize *= (1 + factor)
            LiteCard2.FontSize *= (1 + factor)
            LiteCard3.FontSize *= (1 + factor)
            LiteCard4.FontSize *= (1 + factor)
            LiteCard5.FontSize *= (1 + factor)
            LiteCard6.FontSize *= (1 + factor)
            LiteCard7.FontSize *= (1 + factor)
            LiteCard8.FontSize *= (1 + factor)
            LiteCard9.FontSize *= (1 + factor)
            LiteCard10.FontSize *= (1 + factor)
            LiteCard11.FontSize *= (1 + factor)
            LiteCard12.FontSize *= (1 + factor)
            LiteCard13.FontSize *= (1 + factor)
            LiteCard14.FontSize *= (1 + factor)
            LiteCard15.FontSize *= (1 + factor)
            LiteCard16.FontSize *= (1 + factor)
            'CFM

            'get current location
            newlocation = LiteCard0.location


            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location

            'newlocation.Y = Math.Round(newlocation.Y)
            'newlocation.X = Math.Round(newlocation.X)
            LiteCard0.location = New PointF(newlocation.X, newlocation.Y)

            'get current location
            newlocation = LiteCard1.location

            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location
            LiteCard1.location = New PointF(newlocation.X, newlocation.Y)

            ''''''
            'get current location
            newlocation = LiteCard2.location


            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location
            LiteCard2.location = New PointF(newlocation.X, newlocation.Y)

            ''''''
            'get current location
            newlocation = LiteCard3.location


            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location
            LiteCard3.location = New PointF(newlocation.X, newlocation.Y)


            ''''''
            'get current location
            newlocation = LiteCard4.location


            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location
            LiteCard4.location = New PointF(newlocation.X, newlocation.Y)


            ''''''
            'get current location
            newlocation = LiteCard5.location


            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location
            LiteCard5.location = New PointF(newlocation.X, newlocation.Y)


            ''''''
            'get current location
            newlocation = LiteCard6.location


            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location
            LiteCard6.location = New PointF(newlocation.X, newlocation.Y)



            ''''''
            'get current location
            newlocation = LiteCard7.location


            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location
            LiteCard7.location = New PointF(newlocation.X, newlocation.Y)


            ''''''
            'get current location
            newlocation = LiteCard8.location


            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location
            LiteCard8.location = New PointF(newlocation.X, newlocation.Y)



            ''''''
            'get current location
            newlocation = LiteCard9.location


            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location
            LiteCard9.location = New PointF(newlocation.X, newlocation.Y)

            ''''''
            'get current location
            newlocation = LiteCard10.location


            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location
            LiteCard10.location = New PointF(newlocation.X, newlocation.Y)


            ''''''
            'get current location
            newlocation = LiteCard11.location


            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location
            LiteCard11.location = New PointF(newlocation.X, newlocation.Y)



            ''''''
            'get current location
            newlocation = LiteCard12.location


            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location
            LiteCard12.location = New PointF(newlocation.X, newlocation.Y)

            ''''''
            'get current location
            newlocation = LiteCard13.location


            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location
            LiteCard13.location = New PointF(newlocation.X, newlocation.Y)


            ''''''
            'get current location
            newlocation = LiteCard14.location


            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location
            LiteCard14.location = New PointF(newlocation.X, newlocation.Y)

            ''''''
            'CFM begin
            'get current location
            newlocation = LiteCard15.location


            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location
            LiteCard15.location = New PointF(newlocation.X, newlocation.Y)


            ''''''
            'CFM begin 16
            'get current location
            newlocation = LiteCard16.location


            'translate so that center of form is origen
            newlocation.X -= center.X
            newlocation.Y -= center.Y

            'zoom
            newlocation.X *= (1 + factor)
            newlocation.Y *= (1 + factor)


            'translate so that top right corner is origen
            newlocation.X += center.X
            newlocation.Y += center.Y

            'set the lite card in calculated location
            LiteCard16.location = New PointF(newlocation.X, newlocation.Y)
            'CFM stop



            'finanlize
            set_veiwmanip_buttons()
           
            Me.Timer_delayed_invalidate.Start()
            Form1.positionandsizecards()




        End If

    End Sub

    Private Sub signZoomInSmall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMI_sign_zoominsmall.Click, Lbut_EnlargeCardSmall.Click, CMI_zoominSmall.Click, CMI_z00minsmall.Click
        If Not Lbut_EnlargeCardSmall.Enabled Then
            status = New ArrayList
            status.Add("Sorry you can not zoom in any more on the sign")
            status.Add("To zoom out sign click '-' or '--' under sign controll")
            status.Add("Sorry you can not zoom in any more on the sign")
            status.Add("To zoom background in or out click zoom buttons under background image")
            status.Add("Sorry you can not zoom in any more on the sign")
            status.Add("To Move the entire sign click move buttons under sign controll")
            status.Add("Sorry you can not zoom in any more on the sign")
            If ret_clickmode = clickmodes.mypatterndesign Then
                status.Add("To move individual cards press escape on key board")
            Else
                status.Add("To move individual cards click " & Lbut_custon_start.Text & " under My Pattern")
            End If


            Beep()
            Return
        End If




        status = New ArrayList
        status.Add("you are in 'Sign Zoom In' mode")

        status.Add("To zoom in simply click on the sign")
        status.Add("you are in 'Sign Zoom In' mode")

        status.Add("To zoom out click '-' or '--' below")
        status.Add("you are in 'Sign Zoom In' mode")

        If ret_clickmode = clickmodes.mypatterndesign Then
            status.Add("To move individual cards press escape on key board")
        Else
            status.Add("To move individual cards click " & Lbut_custon_start.Text & " under My Pattern")
        End If
        status.Add("you are in 'Sign Zoom In' mode")
        status.Add("To do other actions select from menu below")
        status.Add("you are in 'Sign Zoom In' mode")




        curr_clickmode = clickmodes.signzoom

        'zoommode_clickaction must be set before calling set_veiwmanip_buttons()
        zoommode_clickaction = zoomaction.zoominsmall




        set_mouse_display()
        set_veiwmanip_buttons()



        signZoomInSmall()



    End Sub

    Private Sub signZoomOutSmall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_ShrinkCardSmall.Click, CMI_sign_zoomoutsmall.Click, CMI_zoomoutSmall.Click, CMI_z00moutsmall.Click

        If Not Lbut_ShrinkCardSmall.Enabled Then
            status = New ArrayList
            status.Add("Sorry you can not zoom out any more on the sign")
            status.Add("To zoom in sign click '+' or '++' under sign controll")
            status.Add("Sorry you can not zoom out any more on the sign")
            status.Add("To zoom background in or out click zoom buttons under background image")
            status.Add("Sorry you can not zoom out any more on the sign")
            status.Add("To Move the entire sign click move buttons under sign controll")
            status.Add("Sorry you can not zoom out any more on the sign")
            If ret_clickmode = clickmodes.mypatterndesign Then
                status.Add("To move individual cards press escape on key board")
            Else
                status.Add("To move individual cards click " & Lbut_custon_start.Text & " under My Pattern")
            End If

            Beep()

            Return
        End If
        status = New ArrayList
        status.Add("You are in 'Sign Zoom Out' mode")

        status.Add("To zoom in simply click on the sign")
        status.Add("You are in 'Sign Zoom Out' mode")

        status.Add("To zoom in click '+' or '++' below")
        status.Add("You are in 'Sign Zoom Out' mode")

        If ret_clickmode = clickmodes.mypatterndesign Then
            status.Add("To move individual cards press escape on key board")
        Else
            status.Add("To move individual cards click " & Lbut_custon_start.Text & " under My Pattern")
        End If
        status.Add("You are in 'Sign Zoom Out' mode")
        status.Add("To do other actions select from menu below")
        status.Add("You are in 'Sign Zoom Out' mode")



        curr_clickmode = clickmodes.signzoom

        'zoommode_clickaction must be set before calling set_veiwmanip_buttons()
        zoommode_clickaction = zoomaction.zoomoutsmall

        set_mouse_display()
        set_veiwmanip_buttons()



        signZoomOutSmall()

        Return

        'below is old code
        'LiteCard0.FontSize /= (1 + SMALLZOOMFACTOR)
        'LiteCard1.FontSize /= (1 + SMALLZOOMFACTOR)
        'LiteCard2.FontSize /= (1 + SMALLZOOMFACTOR)
        'LiteCard3.FontSize /= (1 + SMALLZOOMFACTOR)
        'LiteCard4.FontSize /= (1 + SMALLZOOMFACTOR)
        'LiteCard5.FontSize /= (1 + SMALLZOOMFACTOR)
        'LiteCard6.FontSize /= (1 + SMALLZOOMFACTOR)
        'LiteCard7.FontSize /= (1 + SMALLZOOMFACTOR)
        'LiteCard8.FontSize /= (1 + SMALLZOOMFACTOR)
        'LiteCard9.FontSize /= (1 + SMALLZOOMFACTOR)
        'LiteCard10.FontSize /= (1 + SMALLZOOMFACTOR)
        'LiteCard11.FontSize /= (1 + SMALLZOOMFACTOR)
        'LiteCard12.FontSize /= (1 + SMALLZOOMFACTOR)
        'LiteCard13.FontSize /= (1 + SMALLZOOMFACTOR)
        'LiteCard14.FontSize /= (1 + SMALLZOOMFACTOR)
        'LiteCard15.FontSize /= (1 + SMALLZOOMFACTOR)

        'LiteCard0.Top /= (1 + SMALLZOOMFACTOR)
        'LiteCard1.Top /= (1 + SMALLZOOMFACTOR)
        'LiteCard2.Top /= (1 + SMALLZOOMFACTOR)
        'LiteCard3.Top /= (1 + SMALLZOOMFACTOR)
        'LiteCard4.Top /= (1 + SMALLZOOMFACTOR)
        'LiteCard5.Top /= (1 + SMALLZOOMFACTOR)
        'LiteCard6.Top /= (1 + SMALLZOOMFACTOR)
        'LiteCard7.Top /= (1 + SMALLZOOMFACTOR)
        'LiteCard8.Top /= (1 + SMALLZOOMFACTOR)
        'LiteCard9.Top /= (1 + SMALLZOOMFACTOR)


        'LiteCard0.Left /= (1 + SMALLZOOMFACTOR)
        'LiteCard1.Left /= (1 + SMALLZOOMFACTOR)
        'LiteCard2.Left /= (1 + SMALLZOOMFACTOR)
        'LiteCard3.Left /= (1 + SMALLZOOMFACTOR)
        'LiteCard4.Left /= (1 + SMALLZOOMFACTOR)
        'LiteCard5.Left /= (1 + SMALLZOOMFACTOR)
        'LiteCard6.Left /= (1 + SMALLZOOMFACTOR)
        'LiteCard7.Left /= (1 + SMALLZOOMFACTOR)
        'LiteCard8.Left /= (1 + SMALLZOOMFACTOR)
        'LiteCard9.Left /= (1 + SMALLZOOMFACTOR)


        ''Pan_cards.Invalidate()


        'If LiteCard0.FontSize + Convert.ToSingle(Lbut_EnlargeCardSmall.Tag) > Me.max_cardsize Then
        '    Lbut_EnlargeCardSmall.Enabled = False
        '    Form1.mark_disabled(Lbut_EnlargeCardSmall)
        'Else
        '    Lbut_EnlargeCardSmall.Enabled = True
        '    Form1.mark_unselected(Lbut_EnlargeCardSmall)
        'End If

        'If LiteCard0.FontSize + Convert.ToSingle(Lbut_EnlargeCardBig.Tag) > Me.max_cardsize Then
        '    Lbut_EnlargeCardBig.Enabled = False
        '    Form1.mark_disabled(Lbut_EnlargeCardBig)
        'Else
        '    Lbut_EnlargeCardBig.Enabled = True
        '    Form1.mark_unselected(Lbut_EnlargeCardBig)
        'End If



        'If LiteCard0.FontSize + Convert.ToSingle(Lbut_ShrinkCardSmall.Tag) < Me.min_cardsize Then
        '    Lbut_ShrinkCardSmall.Enabled = False
        '    Form1.mark_disabled(Lbut_ShrinkCardSmall)
        'Else
        '    Lbut_ShrinkCardSmall.Enabled = True
        '    Form1.mark_unselected(Lbut_ShrinkCardSmall)
        'End If

        'If LiteCard0.FontSize + Convert.ToSingle(Lbut_ShrinkCardBig.Tag) < Me.min_cardsize Then
        '    Lbut_ShrinkCardBig.Enabled = False
        '    Form1.mark_disabled(Lbut_ShrinkCardBig)
        'Else
        '    Lbut_ShrinkCardBig.Enabled = True
        '    Form1.mark_unselected(Lbut_ShrinkCardBig)
        'End If

        'Me.Timer_delayed_invalidate.Start()
        'Form1.positionandsizecards()

    End Sub

    Private Sub signZoomOutBig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMI_sign_zoomoutlarge.Click, Lbut_ShrinkCardBig.Click, CMI_zoomoutBig.Click, CMI_z00moutbig.Click

        If Not Lbut_ShrinkCardBig.Enabled Then
            status = New ArrayList
            status.Add("Sorry you can not zoom out any more on the sign")
            status.Add("To zoom in sign click '+' or '++' under sign controll")
            status.Add("Sorry you can not zoom out any more on the sign")
            status.Add("To zoom background in or out click zoom buttons under background image")
            status.Add("Sorry you can not zoom out any more on the sign")
            status.Add("To Move the entire sign click move buttons under sign controll")
            status.Add("Sorry you can not zoom out any more on the sign")
            If ret_clickmode = clickmodes.mypatterndesign Then
                status.Add("To move individual cards press escape on key board")
            Else
                status.Add("To move individual cards click " & Lbut_custon_start.Text & " under My Pattern")
            End If
            Beep()
            Return
        End If


        status = New ArrayList
        status.Add("you are in 'Sign Zoom Out' mode")

        status.Add("To zoom in simply click on the sign")
        status.Add("you are in 'Sign Zoom Out' mode")

        status.Add("To zoom in click '+' or '++' below")
        status.Add("you are in 'Sign Zoom Out' mode")

        If ret_clickmode = clickmodes.mypatterndesign Then
            status.Add("To move individual cards press escape on key board")
        Else
            status.Add("To move individual cards click " & Lbut_custon_start.Text & " under My Pattern")
        End If
        status.Add("you are in 'Sign Zoom Out' mode")
        status.Add("To do other actions select from menu below")
        status.Add("you are in 'Sign Zoom Out' mode")

        curr_clickmode = clickmodes.signzoom

        'zoommode_clickaction must be set before calling set_veiwmanip_buttons()
        zoommode_clickaction = zoomaction.zoomoutbig

        set_mouse_display()
        set_veiwmanip_buttons()

        signZoomOutBig()

        Return


        
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_SignPanUp.Click

        LiteCard0.Top -= SIGNPANAMOUNT
        LiteCard1.Top -= SIGNPANAMOUNT
        LiteCard2.Top -= SIGNPANAMOUNT
        LiteCard3.Top -= SIGNPANAMOUNT
        LiteCard4.Top -= SIGNPANAMOUNT
        LiteCard5.Top -= SIGNPANAMOUNT
        LiteCard6.Top -= SIGNPANAMOUNT
        LiteCard7.Top -= SIGNPANAMOUNT
        LiteCard8.Top -= SIGNPANAMOUNT
        LiteCard9.Top -= SIGNPANAMOUNT

        LiteCard10.Top -= SIGNPANAMOUNT
        LiteCard11.Top -= SIGNPANAMOUNT
        LiteCard12.Top -= SIGNPANAMOUNT
        LiteCard13.Top -= SIGNPANAMOUNT
        LiteCard14.Top -= SIGNPANAMOUNT
        LiteCard15.Top -= SIGNPANAMOUNT
        LiteCard16.Top -= SIGNPANAMOUNT
        'CFM

        Me.Timer_delayed_invalidate.Start()
        Form1.positionandsizecards()


    End Sub

    Private Sub Lbut_SignPanDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_SignPanDown.Click

        LiteCard0.Top += SIGNPANAMOUNT
        LiteCard1.Top += SIGNPANAMOUNT
        LiteCard2.Top += SIGNPANAMOUNT
        LiteCard3.Top += SIGNPANAMOUNT
        LiteCard4.Top += SIGNPANAMOUNT
        LiteCard5.Top += SIGNPANAMOUNT
        LiteCard6.Top += SIGNPANAMOUNT
        LiteCard7.Top += SIGNPANAMOUNT
        LiteCard8.Top += SIGNPANAMOUNT
        LiteCard9.Top += SIGNPANAMOUNT
        LiteCard10.Top += SIGNPANAMOUNT
        LiteCard11.Top += SIGNPANAMOUNT
        LiteCard12.Top += SIGNPANAMOUNT
        LiteCard13.Top += SIGNPANAMOUNT
        LiteCard14.Top += SIGNPANAMOUNT
        LiteCard15.Top += SIGNPANAMOUNT
        LiteCard16.Top += SIGNPANAMOUNT
        'CFM

        Me.Timer_delayed_invalidate.Start()
        Form1.positionandsizecards()


    End Sub

    Private Sub Lbut_SignPanRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_SignPanRight.Click
        LiteCard0.Left += SIGNPANAMOUNT
        LiteCard1.Left += SIGNPANAMOUNT
        LiteCard2.Left += SIGNPANAMOUNT
        LiteCard3.Left += SIGNPANAMOUNT
        LiteCard4.Left += SIGNPANAMOUNT
        LiteCard5.Left += SIGNPANAMOUNT
        LiteCard6.Left += SIGNPANAMOUNT
        LiteCard7.Left += SIGNPANAMOUNT
        LiteCard8.Left += SIGNPANAMOUNT
        LiteCard9.Left += SIGNPANAMOUNT
        LiteCard10.Left += SIGNPANAMOUNT
        LiteCard11.Left += SIGNPANAMOUNT
        LiteCard12.Left += SIGNPANAMOUNT
        LiteCard13.Left += SIGNPANAMOUNT
        LiteCard14.Left += SIGNPANAMOUNT
        LiteCard15.Left += SIGNPANAMOUNT
        LiteCard16.Left += SIGNPANAMOUNT
        'CFM

        Me.Timer_delayed_invalidate.Start()
        Form1.positionandsizecards()

    End Sub

    Private Sub Lbut_SignPanLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_SignPanLeft.Click
        LiteCard0.Left -= SIGNPANAMOUNT
        LiteCard1.Left -= SIGNPANAMOUNT
        LiteCard2.Left -= SIGNPANAMOUNT
        LiteCard3.Left -= SIGNPANAMOUNT
        LiteCard4.Left -= SIGNPANAMOUNT
        LiteCard5.Left -= SIGNPANAMOUNT
        LiteCard6.Left -= SIGNPANAMOUNT
        LiteCard7.Left -= SIGNPANAMOUNT
        LiteCard8.Left -= SIGNPANAMOUNT
        LiteCard9.Left -= SIGNPANAMOUNT
        LiteCard10.Left -= SIGNPANAMOUNT
        LiteCard11.Left -= SIGNPANAMOUNT
        LiteCard12.Left -= SIGNPANAMOUNT
        LiteCard13.Left -= SIGNPANAMOUNT
        LiteCard14.Left -= SIGNPANAMOUNT
        LiteCard15.Left -= SIGNPANAMOUNT
        LiteCard16.Left -= SIGNPANAMOUNT
        'CFM

        Me.Timer_delayed_invalidate.Start()
        Form1.positionandsizecards()

    End Sub


    Private Sub clear_veiwmanip_buttons()
        Form1.mark_unselected(Lbut_SignMove)

        Form1.mark_unselected(Pan_Pict_SignMove)
        Form1.mark_unselected(Pan_SignMove)


        Form1.mark_unselected(Pan_SignZoom)

        Form1.mark_unselected(Pan_pict__SignZoom)

        Form1.mark_unselected(Pan_SignZoom)


        If Lbut_BackgroundPanLeft.Enabled Then
            Form1.mark_unselected(Lbut_BackgroundMove)



            Form1.mark_unselected(Pan_pict_BackgroundMove)
            Form1.mark_unselected(Pan_BackgroundMove)

        Else

            Form1.mark_disabled(Lbut_BackgroundMove)



            Form1.mark_disabled(Pan_pict_BackgroundMove)
            Form1.mark_disabled(Pan_BackgroundMove)

        End If
        If Lbut_BackgroundZoomInSmall.Enabled Then

            Form1.mark_unselected(Lbut_BackgroundZoom)
            Form1.mark_unselected(Pan_pict_BackgroundZoom)

            Form1.mark_unselected(Pan_BackgroundZoom)

        Else
            Form1.mark_disabled(Lbut_BackgroundZoom)
            Form1.mark_disabled(Pan_pict_BackgroundZoom)

            Form1.mark_disabled(Pan_BackgroundZoom)

        End If


    End Sub
    Private Sub set_veiwmanip_buttons()

        clear_veiwmanip_buttons()



        ''the first secion of funtion pertains to background zoom buttons
        'zoom in is unlimited
        'zoom out is limited by the fact that no boundary line of
        'the image panel can not be smaller then the view area
        '(to do so would cut off the viewable portion of the lite card panel)





        'this image presnt test must be done before the panel size test
        'some buttons it allows are dissaloowed in panel size tests
        If Pan_imageholder.BackgroundImage Is Pan_pancontrols.BackgroundImage Then ' nothing

            ' no background image uploaded

            'disable all background zoom funtionality




            Form1.mark_disabled(Lbut_BackgroundZoom)
            Lbut_BackgroundZoom.Enabled = False
            Form1.mark_disabled(Pan_pict_BackgroundZoom)
            Pan_pict_BackgroundZoom.Enabled = False
            Form1.mark_disabled(Pan_BackgroundZoom)
            Pan_BackgroundZoom.Enabled = False
            Form1.mark_disabled(Lbut_BackgroundZoomInSmall)
            Lbut_BackgroundZoomInSmall.Enabled = False
            Form1.mark_disabled(Lbut_BackgroundZoomInLarge)
            Lbut_BackgroundZoomInLarge.Enabled = False
            Form1.mark_disabled(Lbut_BackgroundZoomOutSmall)
            Lbut_BackgroundZoomOutSmall.Enabled = False
            Form1.mark_disabled(Lbut_BackgroundZoomOutLarge)
            Lbut_BackgroundZoomOutLarge.Enabled = False







        Else


            'background image uploaded

            Form1.mark_unselected(Lbut_BackgroundZoom)
            Lbut_BackgroundZoom.Enabled = True
            Form1.mark_unselected(Pan_pict_BackgroundZoom)
            Pan_pict_BackgroundZoom.Enabled = True
            Form1.mark_unselected(Pan_BackgroundZoom)
            Pan_BackgroundZoom.Enabled = True
            Form1.mark_unselected(Lbut_BackgroundZoomInSmall)
            Lbut_BackgroundZoomInSmall.Enabled = True
            Form1.mark_unselected(Lbut_BackgroundZoomInLarge)
            Lbut_BackgroundZoomInLarge.Enabled = True
            'Form1.mark_unselected(Lbut_BackgroundZoomOutSmall)
            'Form1.mark_unselected(Lbut_BackgroundZoomOutLarge)


            'determin if current boundaries of image panel allows zoom out
            'a small panel would cut off part of the card view area
            If Pan_imageholder.Width / 1.01 < Pan_cards.Width Then
                Lbut_BackgroundZoomOutSmall.Enabled = False
                Form1.mark_disabled(Lbut_BackgroundZoomOutSmall)
            Else
                Lbut_BackgroundZoomOutSmall.Enabled = True
                Form1.mark_unselected(Lbut_BackgroundZoomOutSmall)
            End If

            If Pan_imageholder.Width / 1.5 < Pan_cards.Width Then

                Lbut_BackgroundZoomOutLarge.Enabled = False
                Form1.mark_disabled(Lbut_BackgroundZoomOutLarge)
            Else
                Lbut_BackgroundZoomOutLarge.Enabled = True
                Form1.mark_unselected(Lbut_BackgroundZoomOutLarge)
            End If


        End If






        'determine if image paning is allowed
        'imporperly placed image panel boundaries would cut off part of the 
        'lite card viewing area
        If Pan_imageholder.Top >= 0 Then
            Lbut_BackgroundPanUp.Enabled = False
            Form1.mark_disabled(Lbut_BackgroundPanUp)
        Else
            Lbut_BackgroundPanUp.Enabled = True
            Form1.mark_unselected(Lbut_BackgroundPanUp)
        End If

        If Pan_imageholder.Bottom <= Pan_dislpayregion.Height Then
            Lbut_BackgroundPanDown.Enabled = False
            Form1.mark_disabled(Lbut_BackgroundPanDown)
        Else
            Lbut_BackgroundPanDown.Enabled = True
            Form1.mark_unselected(Lbut_BackgroundPanDown)
        End If

        If Pan_imageholder.Left >= 0 Then
            Lbut_BackgroundPanLeft.Enabled = False
            Form1.mark_disabled(Lbut_BackgroundPanLeft)
        Else
            Lbut_BackgroundPanLeft.Enabled = True
            Form1.mark_unselected(Lbut_BackgroundPanLeft)
        End If

        If Pan_imageholder.Right <= Pan_dislpayregion.Width Then
            Lbut_BackgroundPanRight.Enabled = False
            Form1.mark_disabled(Lbut_BackgroundPanRight)
        Else
            Lbut_BackgroundPanRight.Enabled = True
            Form1.mark_unselected(Lbut_BackgroundPanRight)

        End If




        ''''from here down highlight sign move and zoom buttons appropriatesly''''


        If curr_clickmode = clickmodes.signdrag Then

            Form1.mark_selected(Lbut_SignMove)

            Form1.mark_selected(Pan_Pict_SignMove)
            Form1.mark_selected(Pan_SignMove)

            Form1.mark_unselected(Lbut_EnlargeCardBig)
            Form1.mark_unselected(Lbut_EnlargeCardSmall)
            Form1.mark_unselected(Lbut_ShrinkCardSmall)
            Form1.mark_unselected(Lbut_ShrinkCardBig)

            Form1.mark_unselected(Lbut_custon_start)
            '
        ElseIf curr_clickmode = clickmodes.signzoom Then
            Form1.mark_selected(Pan_SignZoom)

            Form1.mark_selected(Pan_pict__SignZoom)

            Form1.mark_selected(Pan_SignZoom)
            Pan_cards.Cursor = Cursors.Default
            Form1.mark_unselected(Lbut_custon_start)

            If zoommode_clickaction = zoomaction.zoominbig Then

                Form1.mark_selected(Lbut_EnlargeCardBig)
                Form1.mark_unselected(Lbut_EnlargeCardSmall)
                Form1.mark_unselected(Lbut_ShrinkCardSmall)
                Form1.mark_unselected(Lbut_ShrinkCardBig)

            ElseIf zoommode_clickaction = zoomaction.zoominsmall Then

                Form1.mark_unselected(Lbut_EnlargeCardBig)
                Form1.mark_selected(Lbut_EnlargeCardSmall)
                Form1.mark_unselected(Lbut_ShrinkCardSmall)
                Form1.mark_unselected(Lbut_ShrinkCardBig)

            ElseIf zoommode_clickaction = zoomaction.zoomoutbig Then

                Form1.mark_unselected(Lbut_EnlargeCardBig)
                Form1.mark_unselected(Lbut_EnlargeCardSmall)
                Form1.mark_unselected(Lbut_ShrinkCardSmall)
                Form1.mark_selected(Lbut_ShrinkCardBig)



            ElseIf zoommode_clickaction = zoomaction.zoomoutsmall Then

                Form1.mark_unselected(Lbut_EnlargeCardBig)
                Form1.mark_unselected(Lbut_EnlargeCardSmall)
                Form1.mark_selected(Lbut_ShrinkCardSmall)
                Form1.mark_unselected(Lbut_ShrinkCardBig)

            ElseIf zoommode_clickaction = zoomaction.disabled Then

                'there may not be any code to set zoommode_clickaction to this value 

                'mark everything unselected
                'below will mark some butons disabled

                Form1.mark_unselected(Lbut_EnlargeCardBig)
                Form1.mark_unselected(Lbut_EnlargeCardSmall)
                Form1.mark_selected(Lbut_ShrinkCardSmall)
                Form1.mark_unselected(Lbut_ShrinkCardBig)


            End If


        ElseIf curr_clickmode = clickmodes.imagedrag Then
            Form1.mark_selected(Lbut_BackgroundMove)
            Form1.mark_selected(Pan_pict_BackgroundMove)
            Form1.mark_selected(Lbut_BackgroundMove)

            Form1.mark_unselected(Lbut_custon_start)
        ElseIf curr_clickmode = clickmodes.imagezoom Then
            Form1.mark_unselected(Lbut_custon_start)
            Form1.mark_selected(Lbut_BackgroundZoom)

            Form1.mark_selected(Pan_pict_BackgroundZoom)
            Form1.mark_selected(Pan_BackgroundZoom)

            If zoommode_clickaction = zoomaction.zoominbig Then

                Form1.mark_selected(Lbut_EnlargeCardBig)
                Form1.mark_unselected(Lbut_EnlargeCardSmall)
                Form1.mark_unselected(Lbut_ShrinkCardSmall)
                Form1.mark_unselected(Lbut_ShrinkCardBig)

            ElseIf zoommode_clickaction = zoomaction.zoominsmall Then

                Form1.mark_unselected(Lbut_EnlargeCardBig)
                Form1.mark_selected(Lbut_EnlargeCardSmall)
                Form1.mark_unselected(Lbut_ShrinkCardSmall)
                Form1.mark_unselected(Lbut_ShrinkCardBig)

            ElseIf zoommode_clickaction = zoomaction.zoomoutbig Then

                Form1.mark_unselected(Lbut_EnlargeCardBig)
                Form1.mark_unselected(Lbut_EnlargeCardSmall)
                Form1.mark_unselected(Lbut_ShrinkCardSmall)
                Form1.mark_selected(Lbut_ShrinkCardBig)



            ElseIf zoommode_clickaction = zoomaction.zoomoutsmall Then

                Form1.mark_unselected(Lbut_EnlargeCardBig)
                Form1.mark_unselected(Lbut_EnlargeCardSmall)
                Form1.mark_selected(Lbut_ShrinkCardSmall)
                Form1.mark_unselected(Lbut_ShrinkCardBig)

            ElseIf zoommode_clickaction = zoomaction.disabled Then

                'there may not be any code to set zoommode_clickaction to this value 

                'mark everything unselected
                'below will mark some butons disabled

                Form1.mark_unselected(Lbut_EnlargeCardBig)
                Form1.mark_unselected(Lbut_EnlargeCardSmall)
                Form1.mark_selected(Lbut_ShrinkCardSmall)
                Form1.mark_unselected(Lbut_ShrinkCardBig)


            End If



        ElseIf curr_clickmode = clickmodes.mypatterndesign Then

            Form1.mark_unselected(Lbut_custon_start)
        Else


            'this section will be removed when everything else is completed
            'for now it marks everything unselected if there is no code writen
            'for marking a particular mode
            Form1.mark_unselected(Lbut_SignMove)

            Form1.mark_unselected(Pan_Pict_SignMove)
            Form1.mark_unselected(Pan_SignMove)

            Form1.mark_unselected(Lbut_EnlargeCardBig)
            Form1.mark_unselected(Lbut_EnlargeCardSmall)
            Form1.mark_unselected(Lbut_ShrinkCardSmall)
            Form1.mark_unselected(Lbut_ShrinkCardBig)


        End If

        'the click mode section above marked sign zoom buttons either selected or unselected
        ' this section either marks them disabled or leaves them as marked above


        If LiteCard0.FontSize + Convert.ToSingle(Lbut_EnlargeCardSmall.Tag) > Me.max_cardsize Then
            Lbut_EnlargeCardSmall.Enabled = False
            Form1.mark_disabled(Lbut_EnlargeCardSmall)
        Else
            Lbut_EnlargeCardSmall.Enabled = True
            '    Form1.mark_unselected(Lbut_EnlargeCardSmall)
        End If

        If LiteCard0.FontSize + Convert.ToSingle(Lbut_EnlargeCardBig.Tag) > Me.max_cardsize Then
            Lbut_EnlargeCardBig.Enabled = False
            Form1.mark_disabled(Lbut_EnlargeCardBig)
        Else
            Lbut_EnlargeCardBig.Enabled = True
            '    Form1.mark_unselected(Lbut_EnlargeCardBig)
        End If



        If LiteCard0.FontSize + Convert.ToSingle(Lbut_ShrinkCardSmall.Tag) < Me.min_cardsize Then
            Lbut_ShrinkCardSmall.Enabled = False
            Form1.mark_disabled(Lbut_ShrinkCardSmall)
        Else
            Lbut_ShrinkCardSmall.Enabled = True
            '    Form1.mark_unselected(Lbut_ShrinkCardSmall)
        End If

        If LiteCard0.FontSize + Convert.ToSingle(Lbut_ShrinkCardBig.Tag) < Me.min_cardsize Then
            Lbut_ShrinkCardBig.Enabled = False
            Form1.mark_disabled(Lbut_ShrinkCardBig)
        Else
            Lbut_ShrinkCardBig.Enabled = True
            '    Form1.mark_unselected(Lbut_ShrinkCardBig)
        End If

    End Sub



    Private Sub SignMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_SignMove.Click, Pan_SignMove.Click, Pan_Pict_SignMove.Click, CMI_movesign.Click, CMI_move_sign.Click, CMI_m0vesign.Click
        'ret_clickmode = curr_clickmode
        curr_clickmode = clickmodes.signdrag

        set_mouse_display()
        set_veiwmanip_buttons()


        Me.cmi_bigclockwise.Visible = False
        Me.cmi_smallclockwise.Visible = False
        Me.cmi_bigcounterclockwise.Visible = False
        Me.cmi_smallcounterclockwise.Visible = False
        CMI_m0vecards.Visible = True

        CMI_m0vesign.Visible = False

        CMI_l0ck.Visible = True
        LiteCard0.ContextMenuStrip = ContextMen_litecards
        LiteCard1.ContextMenuStrip = ContextMen_litecards
        LiteCard2.ContextMenuStrip = ContextMen_litecards
        LiteCard3.ContextMenuStrip = ContextMen_litecards
        LiteCard4.ContextMenuStrip = ContextMen_litecards
        LiteCard5.ContextMenuStrip = ContextMen_litecards
        LiteCard6.ContextMenuStrip = ContextMen_litecards
        LiteCard7.ContextMenuStrip = ContextMen_litecards
        LiteCard8.ContextMenuStrip = ContextMen_litecards
        LiteCard9.ContextMenuStrip = ContextMen_litecards
        LiteCard10.ContextMenuStrip = ContextMen_litecards
        LiteCard11.ContextMenuStrip = ContextMen_litecards
        LiteCard12.ContextMenuStrip = ContextMen_litecards
        LiteCard13.ContextMenuStrip = ContextMen_litecards
        LiteCard14.ContextMenuStrip = ContextMen_litecards
        LiteCard15.ContextMenuStrip = ContextMen_litecards
        LiteCard16.ContextMenuStrip = ContextMen_litecards
        'CFM


        ' Pan_cards.Cursor = Cursors.Hand

        status = New ArrayList
        status.Add("You are in 'Sign Move' mode")
        status.Add("To move the entire sign, simply click and drag")
        status.Add("You are in 'Sign Move' mode")
        If ret_clickmode = clickmodes.mypatterndesign Then
            status.Add("To move individual cards press escape on key board")
        Else
            status.Add("To move individual cards click " & Lbut_custon_start.Text & " under My Pattern")
        End If

        status.Add("You are in 'My pattern design' mode")
        status.Add("To do other actions select from menus below")

    End Sub

    Private Sub simulator_form_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress


        'MsgBox(Asc(e.KeyChar))


        'presing esc exits the modes for draging and zooming with the mouse

        Const ESC As Char = Chr(27)


        If e.KeyChar = ESC Then

            'ret_clickmode
            If curr_clickmode <> clickmodes.none Or curr_clickmode <> clickmodes.mypatterndesign Then

                curr_clickmode = ret_clickmode


                set_mouse_display()
                set_veiwmanip_buttons()

            End If


            'MsgBox("esc presed")
        End If
    End Sub

    Private Sub set_mouse_display()


        'dim cursor_zoom as Cursor = new Cursor(

        If curr_clickmode = clickmodes.none Then

            Pan_cards.Cursor = my_cursors(cursor_enum._default)

            LiteCard0.Cursor = my_cursors(cursor_enum._default)
            LiteCard1.Cursor = my_cursors(cursor_enum._default)
            LiteCard2.Cursor = my_cursors(cursor_enum._default)
            LiteCard3.Cursor = my_cursors(cursor_enum._default)
            LiteCard4.Cursor = my_cursors(cursor_enum._default)
            LiteCard5.Cursor = my_cursors(cursor_enum._default)
            LiteCard6.Cursor = my_cursors(cursor_enum._default)
            LiteCard7.Cursor = my_cursors(cursor_enum._default)
            LiteCard8.Cursor = my_cursors(cursor_enum._default)


        ElseIf curr_clickmode = clickmodes.mypatterndesign Then
            Pan_cards.Cursor = my_cursors(cursor_enum._default)
            LiteCard0.Cursor = my_cursors(cursor_enum.hand_bulitin)
            LiteCard1.Cursor = my_cursors(cursor_enum.hand_bulitin)
            LiteCard2.Cursor = my_cursors(cursor_enum.hand_bulitin)
            LiteCard3.Cursor = my_cursors(cursor_enum.hand_bulitin)
            LiteCard4.Cursor = my_cursors(cursor_enum.hand_bulitin)
            LiteCard5.Cursor = my_cursors(cursor_enum.hand_bulitin)
            LiteCard6.Cursor = my_cursors(cursor_enum.hand_bulitin)
            LiteCard7.Cursor = my_cursors(cursor_enum.hand_bulitin)
            LiteCard8.Cursor = my_cursors(cursor_enum.hand_bulitin)

        ElseIf curr_clickmode = clickmodes.imagedrag Then

            Pan_cards.Cursor = my_cursors(cursor_enum.hand2)

            LiteCard0.Cursor = my_cursors(cursor_enum.disabled)
            LiteCard1.Cursor = my_cursors(cursor_enum.disabled)
            LiteCard2.Cursor = my_cursors(cursor_enum.disabled)
            LiteCard3.Cursor = my_cursors(cursor_enum.disabled)
            LiteCard4.Cursor = my_cursors(cursor_enum.disabled)
            LiteCard5.Cursor = my_cursors(cursor_enum.disabled)
            LiteCard6.Cursor = my_cursors(cursor_enum.disabled)
            LiteCard7.Cursor = my_cursors(cursor_enum.disabled)
            LiteCard8.Cursor = my_cursors(cursor_enum.disabled)

        ElseIf curr_clickmode = clickmodes.imagezoom Then

            Pan_cards.Cursor = my_cursors(cursor_enum.mag_glass0)


            LiteCard0.Cursor = my_cursors(cursor_enum.disabled)
            LiteCard1.Cursor = my_cursors(cursor_enum.disabled)
            LiteCard2.Cursor = my_cursors(cursor_enum.disabled)
            LiteCard3.Cursor = my_cursors(cursor_enum.disabled)
            LiteCard4.Cursor = my_cursors(cursor_enum.disabled)
            LiteCard5.Cursor = my_cursors(cursor_enum.disabled)
            LiteCard6.Cursor = my_cursors(cursor_enum.disabled)
            LiteCard7.Cursor = my_cursors(cursor_enum.disabled)
            LiteCard8.Cursor = my_cursors(cursor_enum.disabled)



        ElseIf curr_clickmode = clickmodes.signdrag Then

            Pan_cards.Cursor = my_cursors(cursor_enum._default)
            LiteCard0.Cursor = my_cursors(cursor_enum.hand_bulitin)
            LiteCard1.Cursor = my_cursors(cursor_enum.hand_bulitin)
            LiteCard2.Cursor = my_cursors(cursor_enum.hand_bulitin)
            LiteCard3.Cursor = my_cursors(cursor_enum.hand_bulitin)
            LiteCard4.Cursor = my_cursors(cursor_enum.hand_bulitin)
            LiteCard5.Cursor = my_cursors(cursor_enum.hand_bulitin)
            LiteCard6.Cursor = my_cursors(cursor_enum.hand_bulitin)
            LiteCard7.Cursor = my_cursors(cursor_enum.hand_bulitin)
            LiteCard8.Cursor = my_cursors(cursor_enum.hand_bulitin)



        ElseIf curr_clickmode = clickmodes.signzoom Then
            Pan_cards.Cursor = my_cursors(cursor_enum._default)
            LiteCard0.Cursor = my_cursors(cursor_enum.mag_glass1)
            LiteCard1.Cursor = my_cursors(cursor_enum.mag_glass1)
            LiteCard2.Cursor = my_cursors(cursor_enum.mag_glass1)
            LiteCard3.Cursor = my_cursors(cursor_enum.mag_glass1)
            LiteCard4.Cursor = my_cursors(cursor_enum.mag_glass1)
            LiteCard5.Cursor = my_cursors(cursor_enum.mag_glass1)
            LiteCard6.Cursor = my_cursors(cursor_enum.mag_glass1)
            LiteCard7.Cursor = my_cursors(cursor_enum.mag_glass1)
            LiteCard8.Cursor = my_cursors(cursor_enum.mag_glass1)
            Pan_cards.Cursor = my_cursors(cursor_enum.mag_glass1)



        End If


    End Sub




    Private Sub SignZoom_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pan_pict__SignZoom.Click, Pan_SignZoom.Click, Lbut_SignZoom.Click, CMI_ZOOM.Click, CMI_Z00M.Click



        If Lbut_EnlargeCardSmall.Enabled Then

            signZoomInSmall_Click(Lbut_EnlargeCardSmall, e)

        Else
            signZoomOutSmall_Click(Lbut_ShrinkCardSmall, e)
        End If



        Return

        curr_clickmode = clickmodes.signzoom





        set_mouse_display()
        set_veiwmanip_buttons()
        LiteCard0.ContextMenuStrip = Me.ContextMen_sign_zoom
        LiteCard1.ContextMenuStrip = Me.ContextMen_sign_zoom
        LiteCard2.ContextMenuStrip = Me.ContextMen_sign_zoom
        LiteCard3.ContextMenuStrip = Me.ContextMen_sign_zoom
        LiteCard4.ContextMenuStrip = Me.ContextMen_sign_zoom
        LiteCard5.ContextMenuStrip = Me.ContextMen_sign_zoom
        LiteCard6.ContextMenuStrip = Me.ContextMen_sign_zoom
        LiteCard7.ContextMenuStrip = Me.ContextMen_sign_zoom
        LiteCard8.ContextMenuStrip = Me.ContextMen_sign_zoom

    End Sub



    Private Sub Timer_formloaded_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_formloaded.Tick



        Timer_formloaded.Stop()

        Dim locations As ArrayList = New ArrayList
        locations.Add(LiteCard0.location)
        locations.Add(LiteCard1.location)

        locations.Add(LiteCard2.location)
        locations.Add(LiteCard3.location)
        locations.Add(LiteCard4.location)
        locations.Add(LiteCard5.location)
        locations.Add(LiteCard6.location)
        locations.Add(LiteCard7.location)
        locations.Add(LiteCard8.location)
        locations.Add(LiteCard9.location)
        locations.Add(LiteCard10.location)
        locations.Add(LiteCard11.location)

        locations.Add(LiteCard12.location)
        locations.Add(LiteCard13.location)
        locations.Add(LiteCard14.location)
        locations.Add(LiteCard15.location)
        locations.Add(LiteCard16.location)
        'CFM


        Dim angles As ArrayList = New ArrayList
        angles.Add(LiteCard0.Angle)
        angles.Add(LiteCard1.Angle)
        angles.Add(LiteCard2.Angle)
        angles.Add(LiteCard3.Angle)
        angles.Add(LiteCard4.Angle)
        angles.Add(LiteCard5.Angle)
        angles.Add(LiteCard6.Angle)
        angles.Add(LiteCard7.Angle)
        angles.Add(LiteCard8.Angle)
        angles.Add(LiteCard9.Angle)

        angles.Add(LiteCard10.Angle)
        angles.Add(LiteCard11.Angle)
        angles.Add(LiteCard12.Angle)
        angles.Add(LiteCard13.Angle)
        angles.Add(LiteCard14.Angle)
        angles.Add(LiteCard15.Angle)
        angles.Add(LiteCard16.Angle)
        'CFM


        'Me.export(StartUpDisplayPaternFile)



        LiteCard0.DoNotRedraw = False
        LiteCard1.DoNotRedraw = False
        LiteCard2.DoNotRedraw = False
        LiteCard3.DoNotRedraw = False
        LiteCard4.DoNotRedraw = False
        LiteCard5.DoNotRedraw = False
        LiteCard6.DoNotRedraw = False
        LiteCard7.DoNotRedraw = False
        LiteCard8.DoNotRedraw = False
        LiteCard9.DoNotRedraw = False

        LiteCard10.DoNotRedraw = False
        LiteCard11.DoNotRedraw = False
        LiteCard12.DoNotRedraw = False
        LiteCard13.DoNotRedraw = False
        LiteCard14.DoNotRedraw = False
        LiteCard15.DoNotRedraw = False
        LiteCard16.DoNotRedraw = False
        'CFM

        If IO.File.Exists(StartUpDisplayPaternFile) Then

            Me.importDisplayPattern(StartUpDisplayPaternFile)
        Else
            PB_horr_line_Click(PB_horr_line, e)

            status = New ArrayList
            status.Add("To get started, you may select one of the free templates")

            status.Add("To move the sign or the backgrond, click on buttons in view manipulation")
            status.Add("To get started, you may upload a picture of where you will hang your sign")
            status.Add("To move individual sign cards, click 'Start' under My Design")


        End If
        
        If angles(0) <> LiteCard0.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        If angles(1) <> LiteCard1.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        If angles(2) <> LiteCard2.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        If angles(3) <> LiteCard3.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        If angles(4) <> LiteCard4.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        If angles(5) <> LiteCard5.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        If angles(6) <> LiteCard6.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        If angles(7) <> LiteCard7.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        If angles(8) <> LiteCard8.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        If angles(9) <> LiteCard9.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        If angles(10) <> LiteCard10.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        If angles(11) <> LiteCard11.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        If angles(12) <> LiteCard12.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        If angles(13) <> LiteCard13.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        If angles(14) <> LiteCard14.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        If angles(15) <> LiteCard15.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        If angles(16) <> LiteCard16.Angle Then
            Timer_formloaded.Start()
            Return
        End If
        'CFM

        If locations(0) <> LiteCard0.location Then
            Timer_formloaded.Start()
            Return
        End If
        If locations(1) <> LiteCard1.location Then
            Timer_formloaded.Start()
            Return
        End If
        If locations(2) <> LiteCard2.location Then
            Timer_formloaded.Start()
            Return
        End If
        If locations(3) <> LiteCard3.location Then
            Timer_formloaded.Start()
            Return
        End If
        If locations(4) <> LiteCard4.location Then
            Timer_formloaded.Start()
            Return
        End If
        If locations(5) <> LiteCard5.location Then
            Timer_formloaded.Start()
            Return
        End If
        If locations(6) <> LiteCard6.location Then
            Timer_formloaded.Start()
            Return
        End If
        If locations(7) <> LiteCard7.location Then
            Timer_formloaded.Start()
            Return
        End If
        If locations(8) <> LiteCard8.location Then
            Timer_formloaded.Start()
            Return
        End If
        If locations(9) <> LiteCard9.location Then
            Timer_formloaded.Start()
            Return
        End If
        If locations(10) <> LiteCard10.location Then
            Timer_formloaded.Start()
            Return
        End If
        If locations(11) <> LiteCard11.location Then
            Timer_formloaded.Start()
            Return
        End If
        If locations(12) <> LiteCard12.location Then
            Timer_formloaded.Start()
            Return
        End If
        If locations(13) <> LiteCard13.location Then
            Timer_formloaded.Start()
            Return
        End If
        If locations(14) <> LiteCard14.location Then
            Timer_formloaded.Start()
            Return
        End If
        If locations(15) <> LiteCard15.location Then
            Timer_formloaded.Start()
            Return
        End If
        If locations(16) <> LiteCard16.location Then
            Timer_formloaded.Start()
            Return
        End If
        'CFM

        Form1.set_cardCount(Form1.settings(Form1.settingsindex.linelength))



    End Sub


    Private Sub CMI_stop_Zoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        curr_clickmode = ret_clickmode


        set_mouse_display()
        set_veiwmanip_buttons()

    End Sub



    Private Sub locksign()
        curr_clickmode = clickmodes.none
        set_mouse_display()
        set_veiwmanip_buttons()
        Me.cmi_bigclockwise.Visible = False
        Me.cmi_smallclockwise.Visible = False
        Me.cmi_bigcounterclockwise.Visible = False
        Me.cmi_smallcounterclockwise.Visible = False
        CMI_m0vecards.Visible = True

        CMI_m0vesign.Visible = True
        CMI_l0ck.Visible = False
        LiteCard0.ContextMenuStrip = Me.ContextMen_litecards
        LiteCard1.ContextMenuStrip = Me.ContextMen_litecards
        LiteCard2.ContextMenuStrip = Me.ContextMen_litecards
        LiteCard3.ContextMenuStrip = Me.ContextMen_litecards
        LiteCard4.ContextMenuStrip = Me.ContextMen_litecards
        LiteCard5.ContextMenuStrip = Me.ContextMen_litecards
        LiteCard6.ContextMenuStrip = Me.ContextMen_litecards
        LiteCard7.ContextMenuStrip = Me.ContextMen_litecards
        LiteCard8.ContextMenuStrip = Me.ContextMen_litecards


        status = New ArrayList
        status.Add("You are in 'lock' mode")
        status.Add("To move the sign or the backgrond, click on buttons below")
        'status.Add("You are in 'Sign Move' mode")
        'If ret_clickmode = clickmodes.mypatterndesign Then
        '    status.Add("To move individual cards press escape on key board")
        'Else
        '    status.Add("To move individual cards click " & Lbut_custon_start.Text & " under My Pattern")
        'End If

        'status.Add("You are in 'My pattern design' mode")
        'status.Add("To do other actions select from menus below")

    End Sub
    Private Sub CMI_l0ck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMI_l0ck.Click, CMI_lock.Click
        locksign()
    End Sub

    Private Sub Timer_statusstrip_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_statusstrip.Tick, Pan_pict_BackgroundMove.Click

        Static index As Int16 = 0

        If status.Count = 0 Then
            Return
        End If

        'before changing text rather then after incrementing i
        'beacuase other parts of program change count between ticks
        If index >= status.Count Then
            index = 0
        End If


        StatusLabel.Text = status(index)

        index += 1

    End Sub

    Private Sub Pan_cards_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pan_cards.MouseClick

    End Sub

    Private Sub Pan_cards_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pan_cards.MouseDown
        If curr_clickmode = clickmodes.imagezoom Then

            'show the context menue with zoom option

            If e.Button = Windows.Forms.MouseButtons.Left Then
                If zoommode_clickaction = zoomaction.zoominsmall Then
                    imageZoomInSmall()
                ElseIf zoommode_clickaction = zoomaction.zoominbig Then
                    imageZoomInLarge()
                ElseIf zoommode_clickaction = zoomaction.zoomoutsmall Then
                    imageZoomOutSmall()
                ElseIf zoommode_clickaction = zoomaction.zoomoutbig Then
                    imageZoomOutLarge()
                End If



            ElseIf e.Button = Windows.Forms.MouseButtons.Right Then


                zoom_point_clicked = Control.MousePosition
                sender.ContextMenuStrip = ContextMen_sign_zoom
                sender.ContextMenuStrip.show()

            End If



        ElseIf curr_clickmode = clickmodes.imagedrag Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                backgroundclicked = True
                'Lbl_linetime.Text = cardclicked.ToString

                startmouselocation = Control.MousePosition


            End If

        End If

    End Sub






    Private Sub Pan_cards_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pan_cards.MouseUp
        If curr_clickmode = clickmodes.imagedrag Then

            If e.Button = Windows.Forms.MouseButtons.Left Then

                backgroundclicked = False


                position_Pan_cardbackground()
                '



                'Lbl_linetime.Text = cardclicked.ToString

                'my_simulator_form.positionandsizecards()

                'Pan_cards.Invalidate()
                'Form1.positionandsizecards()
            ElseIf e.Button = Windows.Forms.MouseButtons.Right Then



            End If
        End If
    End Sub



    Private Sub BackgroundMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_BackgroundMove.Click

        If ret_clickmode = clickmodes.none Then

            ret_clickmode = curr_clickmode
        End If


        curr_clickmode = clickmodes.imagedrag

        set_mouse_display()
        set_veiwmanip_buttons()


    End Sub



    Private Sub Pan_pict_BackgroundMove_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Pan_pict_BackgroundMove.Paint

    End Sub

    Private Sub Pan_cards_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pan_cards.MouseMove
        If curr_clickmode = clickmodes.imagedrag Then


            If e.Button = Windows.Forms.MouseButtons.Left Then





                If backgroundclicked Then

                    'here locations are (integer) point for use with panel
                    'elsewhere newlocation is pointF for litecard location

                    Dim currentmouselocation As Point = Control.MousePosition

                    Dim currentlocation As Point = Pan_imageholder.Location






                    Dim newlocation As Point = New Point(currentlocation.X + currentmouselocation.X - startmouselocation.X, currentlocation.Y + currentmouselocation.Y - startmouselocation.Y)

                    'if this move cuts off part of the viewing area
                    'then truncate move to largest move allowed in that direction

                    If newlocation.Y > 0 Then
                        newlocation.Y = 0

                    End If



                    If newlocation.Y + Pan_imageholder.Height < Pan_dislpayregion.Height Then
                        newlocation.Y += (Pan_dislpayregion.Height - Pan_imageholder.Height)

                    End If

                    If newlocation.X + Pan_imageholder.Width < Pan_dislpayregion.Width Then
                        newlocation.X += (Pan_dislpayregion.Width - Pan_imageholder.Width)

                    End If


                    If newlocation.X > 0 Then
                        newlocation.X = 0

                    End If


                    position_Pan_cardbackground()
                    Pan_imageholder.Location = newlocation
                    startmouselocation = currentmouselocation




                    'Timer_delayed_invalidate.Start()
                    'If counter >= 0 Then

                    '    Timer_delayed_invalidate.Start()
                    '    counter = 0
                    'Else
                    '    counter += 1
                    'End If
                    ''End If
                    '
                End If



            ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
                'do nothing as of yet


            End If
        End If
    End Sub

    Private Sub TableLayoutPanel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub

    Private Sub Pan_dislpayregion_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Pan_dislpayregion.Paint

    End Sub

    Private Sub importDisplayPattern(ByVal filename)
        'format of userdatfile is 
        '[start datamembername]datastring[end datamembername] 
        'datastring may be multiline
        'characters outside start and end tag are ignored 
        'and may be used as notes



        'set no image
        Pan_imageholder.BackgroundImage = Pan_pancontrols.BackgroundImage ' nothing

        OFD_UploadPicture.FileName = ""
        Form1.mark_selected(Lbut_BG_Default)

        Form1.mark_unselected(Label18)




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

                    If (this_dataname = "backgroundImageFile") Then

                        'assumption is that filename is set before zoom data
                        'if no zoom data is specified default (none) is used

                        If IO.File.Exists(this_datavalue) Then


                            OFD_UploadPicture.FileName = this_datavalue
                            Pan_imageholder.BackgroundImage = Image.FromFile(this_datavalue)
                            Pan_imageholder.BackgroundImageLayout = ImageLayout.Zoom


                            Form1.mark_selected(Label18)

                            Form1.mark_unselected(Lbut_BG_Default)

                            default_zoom()
                            'Else
                            '    'NO IMAGE 
                            '    OFD_UploadPicture.FileName = ""
                            '    Pan_imageholder.BackgroundImage = Pan_pancontrols.BackgroundImage ' nothing
                            '    Form1.mark_selected(Label18)

                            '    Form1.mark_unselected(Lbut_BG_Default)


                            '    Pan_imageholder.BackgroundImageLayout = ImageLayout.Zoom

                        End If
                    ElseIf (this_dataname = "backgroundImageTop") Then
                        Pan_imageholder.Top = this_datavalue

                    ElseIf (this_dataname = "backgroundImageLeft") Then
                        Pan_imageholder.Left = this_datavalue

                    ElseIf (this_dataname = "backgroundImageHeight") Then
                        Pan_imageholder.Height = this_datavalue
                    ElseIf (this_dataname = "backgroundImageWidth") Then
                        Pan_imageholder.Width = this_datavalue


                    ElseIf (this_dataname = "LiteCard0Top") Then
                        LiteCard0.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard0Left") Then
                        LiteCard0.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard0Height") Then
                        LiteCard0.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard0Width") Then
                        LiteCard0.Width = this_datavalue
                    ElseIf (this_dataname = "LiteCard0Angle") Then
                        LiteCard0.Angle = this_datavalue

                    ElseIf (this_dataname = "LiteCard0FontSize") Then
                        LiteCard0.FontSize = this_datavalue
                    ElseIf (this_dataname = "LiteCard0ForeColor") Then
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default
                    ElseIf (this_dataname = "LiteCard0BackColor") Then
                        LiteCard0.Backcolor = Color.FromArgb(this_datavalue)


                    ElseIf (this_dataname = "LiteCard1Top") Then
                        LiteCard1.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard1Left") Then
                        LiteCard1.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard1Height") Then
                        LiteCard1.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard1Width") Then
                        LiteCard1.Width = this_datavalue

                    ElseIf (this_dataname = "LiteCard1Angle") Then
                        LiteCard1.Angle = this_datavalue

                    ElseIf (this_dataname = "LiteCard1FontSize") Then
                        LiteCard1.FontSize = this_datavalue

                    ElseIf (this_dataname = "LiteCard1ForeColor") Then
                        'LiteCard1.ForeColor = Color.FromArgb(this_datavalue)
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default
                    ElseIf (this_dataname = "LiteCard1BackColor") Then
                        LiteCard1.Backcolor = Color.FromArgb(this_datavalue)




                    ElseIf (this_dataname = "LiteCard2Top") Then
                        LiteCard2.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard2Left") Then
                        LiteCard2.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard2Height") Then
                        LiteCard2.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard2Width") Then
                        LiteCard2.Width = this_datavalue
                    ElseIf (this_dataname = "LiteCard2Angle") Then
                        LiteCard2.Angle = this_datavalue
                    ElseIf (this_dataname = "LiteCard2FontSize") Then
                        LiteCard2.FontSize = this_datavalue

                    ElseIf (this_dataname = "LiteCard2ForeColor") Then
                        'LiteCard2.ForeColor = Color.FromArgb(this_datavalue)
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default
                    ElseIf (this_dataname = "LiteCard2BackColor") Then
                        LiteCard2.Backcolor = Color.FromArgb(this_datavalue)


                    ElseIf (this_dataname = "LiteCard3Top") Then
                        LiteCard3.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard3Left") Then
                        LiteCard3.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard3Height") Then
                        LiteCard3.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard3Width") Then
                        LiteCard3.Width = this_datavalue
                    ElseIf (this_dataname = "LiteCard3Angle") Then
                        LiteCard3.Angle = this_datavalue

                    ElseIf (this_dataname = "LiteCard3FontSize") Then
                        LiteCard3.FontSize = this_datavalue

                    ElseIf (this_dataname = "LiteCard3ForeColor") Then
                        'LiteCard3.ForeColor = Color.FromArgb(this_datavalue)
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default
                    ElseIf (this_dataname = "LiteCard3BackColor") Then
                        LiteCard3.Backcolor = Color.FromArgb(this_datavalue)



                    ElseIf (this_dataname = "LiteCard4Top") Then
                        LiteCard4.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard4Left") Then
                        LiteCard4.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard4Height") Then
                        LiteCard4.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard4Width") Then
                        LiteCard4.Width = this_datavalue
                    ElseIf (this_dataname = "LiteCard4Angle") Then
                        LiteCard4.Angle = this_datavalue

                    ElseIf (this_dataname = "LiteCard4FontSize") Then
                        LiteCard4.FontSize = this_datavalue

                    ElseIf (this_dataname = "LiteCard4ForeColor") Then
                        'LiteCard4.ForeColor = Color.FromArgb(this_datavalue)
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default
                    ElseIf (this_dataname = "LiteCard4BackColor") Then
                        LiteCard4.Backcolor = Color.FromArgb(this_datavalue)


                    ElseIf (this_dataname = "LiteCard5Top") Then
                        LiteCard5.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard5Left") Then
                        LiteCard5.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard5Height") Then
                        LiteCard5.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard5Width") Then
                        LiteCard5.Width = this_datavalue
                    ElseIf (this_dataname = "LiteCard5Angle") Then
                        LiteCard5.Angle = this_datavalue
                    ElseIf (this_dataname = "LiteCard5FontSize") Then
                        LiteCard5.FontSize = this_datavalue
                    ElseIf (this_dataname = "LiteCard5ForeColor") Then
                        'LiteCard5.ForeColor = Color.FromArgb(this_datavalue)
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default

                    ElseIf (this_dataname = "LiteCard5BackColor") Then
                        LiteCard5.Backcolor = Color.FromArgb(this_datavalue)



                    ElseIf (this_dataname = "LiteCard6Top") Then
                        LiteCard6.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard6Left") Then
                        LiteCard6.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard6Height") Then
                        LiteCard6.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard6Width") Then
                        LiteCard6.Width = this_datavalue
                    ElseIf (this_dataname = "LiteCard6Angle") Then
                        LiteCard6.Angle = this_datavalue

                    ElseIf (this_dataname = "LiteCard6FontSize") Then
                        LiteCard6.FontSize = this_datavalue

                    ElseIf (this_dataname = "LiteCard6ForeColor") Then
                        'LiteCard6.ForeColor = Color.FromArgb(this_datavalue)
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default


                    ElseIf (this_dataname = "LiteCard6BackColor") Then
                        LiteCard6.Backcolor = Color.FromArgb(this_datavalue)


                    ElseIf (this_dataname = "LiteCard7Top") Then
                        LiteCard7.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard7Left") Then
                        LiteCard7.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard7Height") Then
                        LiteCard7.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard7Width") Then
                        LiteCard7.Width = this_datavalue
                    ElseIf (this_dataname = "LiteCard7Angle") Then
                        LiteCard7.Angle = this_datavalue

                    ElseIf (this_dataname = "LiteCard7FontSize") Then
                        LiteCard7.FontSize = this_datavalue
                    ElseIf (this_dataname = "LiteCard7ForeColor") Then
                        'LiteCard7.ForeColor = Color.FromArgb(this_datavalue)
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default

                    ElseIf (this_dataname = "LiteCard7BackColor") Then
                        LiteCard7.Backcolor = Color.FromArgb(this_datavalue)



                    ElseIf (this_dataname = "LiteCard8Top") Then
                        LiteCard8.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard8Left") Then
                        LiteCard8.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard8Height") Then
                        LiteCard8.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard8Width") Then
                        LiteCard8.Width = this_datavalue
                    ElseIf (this_dataname = "LiteCard8Angle") Then
                        LiteCard8.Angle = this_datavalue

                    ElseIf (this_dataname = "LiteCard8FontSize") Then
                        LiteCard8.FontSize = this_datavalue

                    ElseIf (this_dataname = "LiteCard8ForeColor") Then
                        'LiteCard8.ForeColor = Color.FromArgb(this_datavalue)
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default
                    ElseIf (this_dataname = "LiteCard8BackColor") Then
                        LiteCard8.Backcolor = Color.FromArgb(this_datavalue)

                        ''''''''
                    ElseIf (this_dataname = "LiteCard9Top") Then
                        LiteCard9.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard9Left") Then
                        LiteCard9.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard8Height") Then
                        LiteCard9.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard9Width") Then
                        LiteCard9.Width = this_datavalue
                    ElseIf (this_dataname = "LiteCard9Angle") Then
                        LiteCard9.Angle = this_datavalue

                    ElseIf (this_dataname = "LiteCard9FontSize") Then
                        LiteCard9.FontSize = this_datavalue

                    ElseIf (this_dataname = "LiteCard9ForeColor") Then
                        'LiteCard9.ForeColor = Color.FromArgb(this_datavalue)
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default
                    ElseIf (this_dataname = "LiteCard9BackColor") Then
                        LiteCard9.Backcolor = Color.FromArgb(this_datavalue)








                    ElseIf (this_dataname = "LiteCard10Top") Then
                        LiteCard10.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard10Left") Then
                        LiteCard10.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard10Height") Then
                        LiteCard10.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard10Width") Then
                        LiteCard10.Width = this_datavalue
                    ElseIf (this_dataname = "LiteCard10Angle") Then
                        LiteCard10.Angle = this_datavalue

                    ElseIf (this_dataname = "LiteCard10FontSize") Then
                        LiteCard10.FontSize = this_datavalue

                    ElseIf (this_dataname = "LiteCard10ForeColor") Then
                        'LiteCard10.ForeColor = Color.FromArgb(this_datavalue)
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default

                    ElseIf (this_dataname = "LiteCard10BackColor") Then
                        LiteCard10.Backcolor = Color.FromArgb(this_datavalue)

                        '''''''
                    ElseIf (this_dataname = "LiteCard11Top") Then
                        LiteCard11.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard11Left") Then
                        LiteCard11.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard11Height") Then
                        LiteCard11.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard11Width") Then
                        LiteCard11.Width = this_datavalue
                    ElseIf (this_dataname = "LiteCard11Angle") Then
                        LiteCard11.Angle = this_datavalue

                    ElseIf (this_dataname = "LiteCard11FontSize") Then
                        LiteCard11.FontSize = this_datavalue

                    ElseIf (this_dataname = "LiteCard11ForeColor") Then
                        'LiteCard11.ForeColor = Color.FromArgb(this_datavalue)
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default

                    ElseIf (this_dataname = "LiteCard11BackColor") Then
                        LiteCard11.Backcolor = Color.FromArgb(this_datavalue)



                        '''''''
                    ElseIf (this_dataname = "LiteCard12Top") Then
                        LiteCard12.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard12Left") Then
                        LiteCard12.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard12Height") Then
                        LiteCard12.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard12Width") Then
                        LiteCard12.Width = this_datavalue
                    ElseIf (this_dataname = "LiteCard12Angle") Then
                        LiteCard12.Angle = this_datavalue

                    ElseIf (this_dataname = "LiteCard12FontSize") Then
                        LiteCard12.FontSize = this_datavalue

                    ElseIf (this_dataname = "LiteCard12ForeColor") Then
                        'LiteCard12.ForeColor = Color.FromArgb(this_datavalue)
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default
                    ElseIf (this_dataname = "LiteCard12BackColor") Then
                        LiteCard12.Backcolor = Color.FromArgb(this_datavalue)


                        '''''''
                    ElseIf (this_dataname = "LiteCard13Top") Then
                        LiteCard13.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard13Left") Then
                        LiteCard13.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard13Height") Then
                        LiteCard11.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard13Width") Then
                        LiteCard13.Width = this_datavalue
                    ElseIf (this_dataname = "LiteCard13Angle") Then
                        LiteCard13.Angle = this_datavalue

                    ElseIf (this_dataname = "LiteCard13FontSize") Then
                        LiteCard13.FontSize = this_datavalue

                    ElseIf (this_dataname = "LiteCard13ForeColor") Then
                        'LiteCard13.ForeColor = Color.FromArgb(this_datavalue)
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default

                    ElseIf (this_dataname = "LiteCard13BackColor") Then
                        LiteCard13.Backcolor = Color.FromArgb(this_datavalue)

                        '''''''
                    ElseIf (this_dataname = "LiteCard14Top") Then
                        LiteCard14.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard14Left") Then
                        LiteCard14.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard14Height") Then
                        LiteCard14.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard14Width") Then
                        LiteCard14.Width = this_datavalue
                    ElseIf (this_dataname = "LiteCard14Angle") Then
                        LiteCard14.Angle = this_datavalue

                    ElseIf (this_dataname = "LiteCard14FontSize") Then
                        LiteCard14.FontSize = this_datavalue

                    ElseIf (this_dataname = "LiteCard14ForeColor") Then
                        'LiteCard14.ForeColor = Color.FromArgb(this_datavalue)
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default

                    ElseIf (this_dataname = "LiteCard14BackColor") Then
                        LiteCard14.Backcolor = Color.FromArgb(this_datavalue)


                    
                        ''''''' CFM begin
                    ElseIf (this_dataname = "LiteCard15Top") Then
                        LiteCard15.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard15Left") Then
                        LiteCard15.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard15Height") Then
                        LiteCard15.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard15Width") Then
                        LiteCard15.Width = this_datavalue
                    ElseIf (this_dataname = "LiteCard15Angle") Then
                        LiteCard15.Angle = this_datavalue

                    ElseIf (this_dataname = "LiteCard15FontSize") Then
                        LiteCard15.FontSize = this_datavalue

                    ElseIf (this_dataname = "LiteCard15ForeColor") Then
                        'LiteCard15.ForeColor = Color.FromArgb(this_datavalue)
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default
                    ElseIf (this_dataname = "LiteCard15BackColor") Then
                        LiteCard15.Backcolor = Color.FromArgb(this_datavalue)


                        ''''''' CFM begin
                    ElseIf (this_dataname = "LiteCard16Top") Then
                        LiteCard16.Top = this_datavalue
                    ElseIf (this_dataname = "LiteCard16Left") Then
                        LiteCard16.Left = this_datavalue
                    ElseIf (this_dataname = "LiteCard16Height") Then
                        LiteCard16.Height = this_datavalue
                    ElseIf (this_dataname = "LiteCard16Width") Then
                        LiteCard16.Width = this_datavalue
                    ElseIf (this_dataname = "LiteCard16Angle") Then
                        LiteCard16.Angle = this_datavalue

                    ElseIf (this_dataname = "LiteCard16FontSize") Then
                        LiteCard16.FontSize = this_datavalue

                    ElseIf (this_dataname = "LiteCard16ForeColor") Then
                        'LiteCard16.ForeColor = Color.FromArgb(this_datavalue)
                        ' LiteCard0.ForeColor = Color.FromArgb(this_datavalue)
                        '9/30/2012 ignore saved color and leave default text collor showing
                        'latter on we will test if saved color is valid and either set it or set default
                    ElseIf (this_dataname = "LiteCard16BackColor") Then
                        LiteCard16.Backcolor = Color.FromArgb(this_datavalue)


                        'CFM stop

                    Else
                        MsgBox("unrecognized data item encountered")


                    End If
                    'userdata(this_dataindex) = this_datavalue


                Catch ex As Exception
                    filetext = filetext.Substring(filetext.IndexOf("]") + 1)
                    Continue While
                End Try

            End While

            SR.Close()


            Form1.positionandsizecards()
            Timer_delayed_invalidate.Start()

        End If
    End Sub



    Enum undoaction_flag
        set_Item_modified
        save_undo_values
        save_redo_values
        finish_save

        Undo
        Redo

    End Enum

    Enum ItemReferenceEnum
        none = -1
        image
        LiteCard0
        LiteCard1
        LiteCard2
        LiteCard3
        LiteCard4
        LiteCard5
        LiteCard6
        LiteCard7
        LiteCard8
        LiteCard9
        LiteCard10
        LiteCard11
        LiteCard12
        LiteCard13
        LiteCard14
        LiteCard15
        LiteCard16
        'CFM
        ImportFile
    End Enum
    Enum ImagePropertiesEnum
        file
        Top
        Left
        Height
        Width

    End Enum

    Enum LiteCardPropertiesEnum
        Top
        Left
        Angle
        FontSize
    End Enum



    Private Function undoaction(ByVal flag As undoaction_flag, Optional ByVal Item As ItemReferenceEnum = ItemReferenceEnum.none) As Boolean
        'index starts at -1
        'after firstr entry it becomes 0

        'at the begining of each functions call index refers to the member used for undo
        'index +1 refers to the member used for redo

        'startindex refers to the farthest to undo
        'endindex refers to fartherst to redo
        'these are neccesary because wraping beyond maxsteps makes 0 not be farthest back


        Static itemWorkinWith As ItemReferenceEnum = ItemReferenceEnum.none
        Dim maxsteps As Int16 = 20
        Static statedata As ArrayList = New ArrayList
        Static index As Int16 = 0
        Static startindex As Int16 = 0
        Static endindex As Int16 = 0
        Static currentstepdata As ArrayList


        If flag = undoaction_flag.set_Item_modified Then
            If itemWorkinWith = ItemReferenceEnum.none Then
                itemWorkinWith = Item

                currentstepdata = New ArrayList
                currentstepdata.Add(Item)

                Return True
            Else
                MsgBox("Bug - The item work with can not be set because you have not finshed working with last item")
                Return False
            End If

        ElseIf flag = undoaction_flag.save_undo_values Then
            If itemWorkinWith = ItemReferenceEnum.none Then
                MsgBox("Bug - Can not save undo value with out first specifying item worked with")
                Return False

            End If


            If currentstepdata.Count < 1 Then
                MsgBox("Bug - The currentstepdata arraylist is not in the expected state , first member missing")
                Return False
            End If

            If currentstepdata.Count = 1 Or currentstepdata.Count = 2 Or currentstepdata.Count = 3 Then
                'expected state of everything 
                'count of 1 means add values
                'count of 2 or 3 means overwrite value
                'count of 3 is rare and means redo data saved before undo data



                Dim undovalues As ArrayList = New ArrayList

                If itemWorkinWith = ItemReferenceEnum.image Then



                    undovalues.Add(OFD_UploadPicture.FileName)
                    undovalues.Add(Pan_imageholder.Top)
                    undovalues.Add(Pan_imageholder.Left)
                    undovalues.Add(Pan_imageholder.Height)
                    undovalues.Add(Pan_imageholder.Width)

                ElseIf itemWorkinWith = ItemReferenceEnum.ImportFile Then

                    undovalues.Add(OFD_import.FileName)

                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard0 Then


                    undovalues.Add(LiteCard0.Top)
                    undovalues.Add(LiteCard0.Left)
                    undovalues.Add(LiteCard0.Height)
                    undovalues.Add(LiteCard0.Width)

                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard1 Then


                    undovalues.Add(LiteCard1.Top)
                    undovalues.Add(LiteCard1.Left)
                    undovalues.Add(LiteCard1.Height)
                    undovalues.Add(LiteCard1.Width)
                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard2 Then


                    undovalues.Add(LiteCard2.Top)
                    undovalues.Add(LiteCard2.Left)
                    undovalues.Add(LiteCard2.Height)
                    undovalues.Add(LiteCard2.Width)
                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard3 Then


                    undovalues.Add(LiteCard3.Top)
                    undovalues.Add(LiteCard3.Left)
                    undovalues.Add(LiteCard3.Height)
                    undovalues.Add(LiteCard3.Width)
                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard4 Then


                    undovalues.Add(LiteCard4.Top)
                    undovalues.Add(LiteCard4.Left)
                    undovalues.Add(LiteCard4.Height)
                    undovalues.Add(LiteCard4.Width)
                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard5 Then


                    undovalues.Add(LiteCard5.Top)
                    undovalues.Add(LiteCard5.Left)
                    undovalues.Add(LiteCard5.Height)
                    undovalues.Add(LiteCard5.Width)
                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard6 Then


                    undovalues.Add(LiteCard6.Top)
                    undovalues.Add(LiteCard6.Left)
                    undovalues.Add(LiteCard6.Height)
                    undovalues.Add(LiteCard6.Width)
                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard7 Then


                    undovalues.Add(LiteCard7.Top)
                    undovalues.Add(LiteCard7.Left)
                    undovalues.Add(LiteCard7.Height)
                    undovalues.Add(LiteCard7.Width)

                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard8 Then


                    undovalues.Add(LiteCard8.Top)
                    undovalues.Add(LiteCard8.Left)
                    undovalues.Add(LiteCard8.Height)
                    undovalues.Add(LiteCard8.Width)

                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard9 Then


                    undovalues.Add(LiteCard9.Top)
                    undovalues.Add(LiteCard9.Left)
                    undovalues.Add(LiteCard9.Height)
                    undovalues.Add(LiteCard9.Width)


                    ''ad remaining latter
                Else

                    MsgBox("bug working with unrecognized item")
                    Return False

                End If

                If currentstepdata.Count = 1 Then
                    currentstepdata.Add(undovalues)
                ElseIf currentstepdata.Count = 2 Or currentstepdata.Count = 3 Then
                    currentstepdata(1) = undovalues
                Else
                    MsgBox("bug currentstepdata has count other then 1,2 or 3 while saving undo values")
                    Return False
                End If



                Return True

            End If

        ElseIf flag = undoaction_flag.save_redo_values Then
            If itemWorkinWith = ItemReferenceEnum.none Then
                MsgBox("Bug - Can not save undo value with out first specifying item worked with")
                Return False

            End If


            If currentstepdata.Count < 1 Then
                MsgBox("Bug - The currentstepdata arraylist is not in the expected state , first member missing")
                Return False
            End If

            If currentstepdata.Count = 1 Then
                'this happens if redo value is value is saved before undo values
                'a situation that is not expected to occur but implemented for max flesibility

                currentstepdata.Add(New ArrayList)
            End If


            If currentstepdata.Count = 2 Or currentstepdata.Count = 3 Then
                'expected state of everything 
                'count of 2 means adding 
                'count of 3 means overwriting

                'number of data members varies by the item worked with
                Dim redovalues As ArrayList = New ArrayList

                If itemWorkinWith = ItemReferenceEnum.image Then



                    redovalues.Add(OFD_UploadPicture.FileName)
                    redovalues.Add(Pan_imageholder.Top)
                    redovalues.Add(Pan_imageholder.Left)
                    redovalues.Add(Pan_imageholder.Height)
                    redovalues.Add(Pan_imageholder.Width)

                ElseIf itemWorkinWith = ItemReferenceEnum.ImportFile Then

                    redovalues.Add(OFD_import.FileName)

                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard0 Then


                    redovalues.Add(LiteCard0.Top)
                    redovalues.Add(LiteCard0.Left)
                    redovalues.Add(LiteCard0.Height)
                    redovalues.Add(LiteCard0.Width)

                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard1 Then


                    redovalues.Add(LiteCard1.Top)
                    redovalues.Add(LiteCard1.Left)
                    redovalues.Add(LiteCard1.Height)
                    redovalues.Add(LiteCard1.Width)
                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard2 Then


                    redovalues.Add(LiteCard2.Top)
                    redovalues.Add(LiteCard2.Left)
                    redovalues.Add(LiteCard2.Height)
                    redovalues.Add(LiteCard2.Width)
                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard3 Then


                    redovalues.Add(LiteCard3.Top)
                    redovalues.Add(LiteCard3.Left)
                    redovalues.Add(LiteCard3.Height)
                    redovalues.Add(LiteCard3.Width)
                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard4 Then


                    redovalues.Add(LiteCard4.Top)
                    redovalues.Add(LiteCard4.Left)
                    redovalues.Add(LiteCard4.Height)
                    redovalues.Add(LiteCard4.Width)
                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard5 Then


                    redovalues.Add(LiteCard5.Top)
                    redovalues.Add(LiteCard5.Left)
                    redovalues.Add(LiteCard5.Height)
                    redovalues.Add(LiteCard5.Width)
                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard6 Then


                    redovalues.Add(LiteCard6.Top)
                    redovalues.Add(LiteCard6.Left)
                    redovalues.Add(LiteCard6.Height)
                    redovalues.Add(LiteCard6.Width)
                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard7 Then


                    redovalues.Add(LiteCard7.Top)
                    redovalues.Add(LiteCard7.Left)
                    redovalues.Add(LiteCard7.Height)
                    redovalues.Add(LiteCard7.Width)

                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard8 Then


                    redovalues.Add(LiteCard8.Top)
                    redovalues.Add(LiteCard8.Left)
                    redovalues.Add(LiteCard8.Height)
                    redovalues.Add(LiteCard8.Width)

                ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard9 Then


                    redovalues.Add(LiteCard9.Top)
                    redovalues.Add(LiteCard9.Left)
                    redovalues.Add(LiteCard9.Height)
                    redovalues.Add(LiteCard9.Width)

                Else

                    MsgBox("bug working with unrecognized item")
                    Return False

                End If


                If currentstepdata.Count = 2 Then
                    currentstepdata.Add(redovalues)
                ElseIf currentstepdata.Count = 3 Then
                    currentstepdata(2) = redovalues
                End If


                Return True
            Else
                MsgBox("bug - currentstepdata has count other then 2 0r 3 while saving redovalues")
                Return False

            End If


        ElseIf flag = undoaction_flag.finish_save Then
            'test that valid undo and redo data saved then reset index and itemworked with


            If currentstepdata.Count <> 3 Then
                MsgBox("bug error finishing save, currentstepdata count is not 3 ")
                Return False

            End If
            If currentstepdata(0) <> itemWorkinWith Then
                MsgBox("bug error finishing save, arraylist has wrong item working with ")
                Return False

            End If

            If currentstepdata(1).count <> currentstepdata(2).count Then
                MsgBox("bug undo array and redo array have differing counts ")
                Return False

            End If

            'test that undo and red arrays have correct number of items

            If itemWorkinWith = ItemReferenceEnum.image Then
                If currentstepdata(1).count <> 5 Then
                    MsgBox("bug image should store 5 peices of data ")
                    Return False


                End If

            ElseIf itemWorkinWith = ItemReferenceEnum.ImportFile Then

                If currentstepdata(1).count <> 1 Then
                    MsgBox("bug import file should store 1 peices of data ")
                    Return False


                End If

            ElseIf itemWorkinWith = ItemReferenceEnum.LiteCard0 _
            Or itemWorkinWith = ItemReferenceEnum.LiteCard1 _
            Or itemWorkinWith = ItemReferenceEnum.LiteCard2 _
            Or itemWorkinWith = ItemReferenceEnum.LiteCard3 _
            Or itemWorkinWith = ItemReferenceEnum.LiteCard4 _
            Or itemWorkinWith = ItemReferenceEnum.LiteCard5 _
            Or itemWorkinWith = ItemReferenceEnum.LiteCard6 _
            Or itemWorkinWith = ItemReferenceEnum.LiteCard7 _
            Or itemWorkinWith = ItemReferenceEnum.LiteCard8 _
            Or itemWorkinWith = ItemReferenceEnum.LiteCard9 _
            Or itemWorkinWith = ItemReferenceEnum.LiteCard10 _
            Or itemWorkinWith = ItemReferenceEnum.LiteCard11 _
            Or itemWorkinWith = ItemReferenceEnum.LiteCard12 _
            Or itemWorkinWith = ItemReferenceEnum.LiteCard13 _
            Or itemWorkinWith = ItemReferenceEnum.LiteCard14 _
            Or itemWorkinWith = ItemReferenceEnum.LiteCard15 _
            Or itemWorkinWith = ItemReferenceEnum.LiteCard16 Then
                'CFM


                If currentstepdata(1).count <> 4 Then
                    MsgBox("bug LiteCards should store 4 peices of data ")
                    Return False


                End If

            Else

                MsgBox("bug Workimg with unrecognized item while finalizing save ")
                Return False

            End If


            index += 1

            If index >= maxsteps Then

                index = 0

            End If


            If index = statedata.Count Then
                statedata.Add(currentstepdata)
            ElseIf index < statedata.Count Then
                statedata(index) = currentstepdata

            Else

                MsgBox("bug index is greater then  items in array")
                Return False


            End If

            itemWorkinWith = ItemReferenceEnum.none
            Return True

        ElseIf flag = undoaction_flag.Undo Then

            If index < startindex Then
                Beep()
                Return False

            End If



        ElseIf flag = undoaction_flag.Redo Then

        End If




    End Function




    Public Sub ExportdisplayPattern(ByVal filename As String)
        'format of userdatfile is 
        '[start datamembername]datastring[end datamembername] 
        'datastring may be multiline
        'characters outside start and end tag are ignored 
        'and may be used as notes




        Dim SW As IO.StreamWriter = IO.File.CreateText(filename)
        Dim outputstring As String
        outputstring = "This is an exported litecard display file" + Constants.vbCrLf
        outputstring += "Manually editing this file is not recomended " + Constants.vbCrLf
        outputstring += "If you do, be careful that opening and closing tags are correct " + Constants.vbCrLf
        outputstring += Constants.vbCrLf
        '    Enum userdataindexags 
        '       Name
        '  End Enum
        If OFD_UploadPicture.FileName <> "" Then
            outputstring &= "[start backgroundImageFile]" & OFD_UploadPicture.FileName & "[end backgroundImageFile]" & Constants.vbCrLf

            outputstring &= "[start backgroundImageTop]" & Pan_imageholder.Top & "[end backgroundImageTop]" & Constants.vbCrLf
            outputstring &= "[start backgroundImageLeft]" & Pan_imageholder.Left & "[end backgroundImageLeft]" & Constants.vbCrLf
            outputstring &= "[start backgroundImageHeight]" & Pan_imageholder.Height & "[end backgroundImageHeight]" & Constants.vbCrLf
            outputstring &= "[start backgroundImageWidth]" & Pan_imageholder.Width & "[end backgroundImageWidth]" & Constants.vbCrLf


        End If

        outputstring &= "[start LiteCard0Top]" & LiteCard0.Top & "[end LiteCard0Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard0Left]" & LiteCard0.Left & "[end LiteCard0Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard0Angle]" & LiteCard0.Angle & "[end LiteCard0Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard0FontSize]" & LiteCard0.FontSize & "[end LiteCard0FontSize]" & Constants.vbCrLf
        outputstring &= "[start LiteCard0ForeColor]" & LiteCard0.ForeColor.ToArgb & "[end LiteCard0ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard0BackColor]" & LiteCard0.Backcolor.ToArgb & "[end LiteCard0BackColor]" & Constants.vbCrLf





        outputstring &= "[start LiteCard1Top]" & LiteCard1.Top & "[end LiteCard1Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard1Left]" & LiteCard1.Left & "[end LiteCard1Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard1Angle]" & LiteCard1.Angle & "[end LiteCard1Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard1FontSize]" & LiteCard1.FontSize & "[end LiteCard1FontSize]" & Constants.vbCrLf
        outputstring &= "[start LiteCard1ForeColor]" & LiteCard1.ForeColor.ToArgb.ToString & "[end LiteCard1ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard1BackColor]" & LiteCard1.Backcolor.ToArgb.ToString & "[end LiteCard1BackColor]" & Constants.vbCrLf


        outputstring &= "[start LiteCard2Top]" & LiteCard2.Top & "[end LiteCard2Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard2Left]" & LiteCard2.Left & "[end LiteCard2Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard2Angle]" & LiteCard2.Angle & "[end LiteCard2Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard2FontSize]" & LiteCard2.FontSize & "[end LiteCard2FontSize]" & Constants.vbCrLf
        outputstring &= "[start LiteCard2ForeColor]" & LiteCard2.ForeColor.ToArgb.ToString & "[end LiteCard2ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard2BackColor]" & LiteCard2.Backcolor.ToArgb.ToString & "[end LiteCard2BackColor]" & Constants.vbCrLf

        outputstring &= "[start LiteCard3Top]" & LiteCard3.Top & "[end LiteCard3Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard3Left]" & LiteCard3.Left & "[end LiteCard3Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard3Angle]" & LiteCard3.Angle & "[end LiteCard3Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard3FontSize]" & LiteCard3.FontSize & "[end LiteCard3FontSize]" & Constants.vbCrLf
        outputstring &= "[start LiteCard3ForeColor]" & LiteCard3.ForeColor.ToArgb.ToString & "[end LiteCard3ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard3BackColor]" & LiteCard3.Backcolor.ToArgb.ToString & "[end LiteCard3BackColor]" & Constants.vbCrLf


        outputstring &= "[start LiteCard4Top]" & LiteCard4.Top & "[end LiteCard4Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard4Left]" & LiteCard4.Left & "[end LiteCard4Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard4Angle]" & LiteCard4.Angle & "[end LiteCard4Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard4FontSize]" & LiteCard4.FontSize & "[end LiteCard4FontSize]" & Constants.vbCrLf
        outputstring &= "[start LiteCard4ForeColor]" & LiteCard4.ForeColor.ToArgb.ToString & "[end LiteCard4ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard4BackColor]" & LiteCard4.Backcolor.ToArgb.ToString & "[end LiteCard4BackColor]" & Constants.vbCrLf

        outputstring &= "[start LiteCard5Top]" & LiteCard5.Top & "[end LiteCard5Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard5Left]" & LiteCard5.Left & "[end LiteCard5Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard5Angle]" & LiteCard5.Angle & "[end LiteCard5Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard5FontSize]" & LiteCard5.FontSize & "[end LiteCard5FontSize]" & Constants.vbCrLf
        outputstring &= "[start LiteCard5ForeColor]" & LiteCard5.ForeColor.ToArgb.ToString & "[end LiteCard5ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard5BackColor]" & LiteCard5.Backcolor.ToArgb.ToString & "[end LiteCard5BackColor]" & Constants.vbCrLf


        outputstring &= "[start LiteCard6Top]" & LiteCard6.Top & "[end LiteCard6Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard6Left]" & LiteCard6.Left & "[end LiteCard6Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard6Angle]" & LiteCard6.Angle & "[end LiteCard6Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard6FontSize]" & LiteCard6.FontSize & "[end LiteCard6FontSize]" & Constants.vbCrLf
        outputstring &= "[start LiteCard6ForeColor]" & LiteCard6.ForeColor.ToArgb.ToString & "[end LiteCard6ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard6BackColor]" & LiteCard6.Backcolor.ToArgb.ToString & "[end LiteCard6BackColor]" & Constants.vbCrLf


        outputstring &= "[start LiteCard7Top]" & LiteCard7.Top & "[end LiteCard7Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard7Left]" & LiteCard7.Left & "[end LiteCard7Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard7Angle]" & LiteCard7.Angle & "[end LiteCard7Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard7FontSize]" & LiteCard7.FontSize & "[end LiteCard7FontSize]" & Constants.vbCrLf

        outputstring &= "[start LiteCard7ForeColor]" & LiteCard7.ForeColor.ToArgb.ToString & "[end LiteCard7ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard7BackColor]" & LiteCard7.Backcolor.ToArgb.ToString & "[end LiteCard7BackColor]" & Constants.vbCrLf

        outputstring &= "[start LiteCard8Top]" & LiteCard8.Top & "[end LiteCard8Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard8Left]" & LiteCard8.Left & "[end LiteCard8Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard8Angle]" & LiteCard8.Angle & "[end LiteCard8Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard8FontSize]" & LiteCard8.FontSize & "[end LiteCard8FontSize]" & Constants.vbCrLf
        outputstring &= "[start LiteCard8ForeColor]" & LiteCard8.ForeColor.ToArgb.ToString & "[end LiteCard8ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard8BackColor]" & LiteCard8.Backcolor.ToArgb.ToString & "[end LiteCard8BackColor]" & Constants.vbCrLf


        outputstring &= "[start LiteCard9Top]" & LiteCard9.Top & "[end LiteCard9Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard9Left]" & LiteCard9.Left & "[end LiteCard9Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard9Angle]" & LiteCard9.Angle & "[end LiteCard9Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard9FontSize]" & LiteCard9.FontSize & "[end LiteCard9FontSize]" & Constants.vbCrLf
        outputstring &= "[start LiteCard9ForeColor]" & LiteCard9.ForeColor.ToArgb.ToString & "[end LiteCard9ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard9BackColor]" & LiteCard9.Backcolor.ToArgb.ToString & "[end LiteCard9BackColor]" & Constants.vbCrLf

        outputstring &= "[start LiteCard10Top]" & LiteCard10.Top & "[end LiteCard10Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard10Left]" & LiteCard10.Left & "[end LiteCard10Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard10Angle]" & LiteCard10.Angle & "[end LiteCard10Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard10FontSize]" & LiteCard10.FontSize & "[end LiteCard10FontSize]" & Constants.vbCrLf
        outputstring &= "[start LiteCard10ForeColor]" & LiteCard10.ForeColor.ToArgb & "[end LiteCard10ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard10BackColor]" & LiteCard10.Backcolor.ToArgb & "[end LiteCard10BackColor]" & Constants.vbCrLf





        outputstring &= "[start LiteCard11Top]" & LiteCard11.Top & "[end LiteCard11Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard11Left]" & LiteCard11.Left & "[end LiteCard11Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard11Angle]" & LiteCard11.Angle & "[end LiteCard11Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard11FontSize]" & LiteCard11.FontSize & "[end LiteCard11FontSize]" & Constants.vbCrLf
        outputstring &= "[start LiteCard11ForeColor]" & LiteCard11.ForeColor.ToArgb.ToString & "[end LiteCard11ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard11BackColor]" & LiteCard11.Backcolor.ToArgb.ToString & "[end LiteCard11BackColor]" & Constants.vbCrLf


        outputstring &= "[start LiteCard12Top]" & LiteCard12.Top & "[end LiteCard12Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard12Left]" & LiteCard12.Left & "[end LiteCard12Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard12Angle]" & LiteCard12.Angle & "[end LiteCard12Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard12FontSize]" & LiteCard12.FontSize & "[end LiteCard12FontSize]" & Constants.vbCrLf
        outputstring &= "[start LiteCard12ForeColor]" & LiteCard12.ForeColor.ToArgb.ToString & "[end LiteCard12ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard12BackColor]" & LiteCard12.Backcolor.ToArgb.ToString & "[end LiteCard12BackColor]" & Constants.vbCrLf

        outputstring &= "[start LiteCard13Top]" & LiteCard13.Top & "[end LiteCard13Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard13Left]" & LiteCard13.Left & "[end LiteCard13Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard13Angle]" & LiteCard13.Angle & "[end LiteCard13Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard13FontSize]" & LiteCard13.FontSize & "[end LiteCard13FontSize]" & Constants.vbCrLf
        outputstring &= "[start LiteCard13ForeColor]" & LiteCard13.ForeColor.ToArgb.ToString & "[end LiteCard13ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard13BackColor]" & LiteCard13.Backcolor.ToArgb.ToString & "[end LiteCard13BackColor]" & Constants.vbCrLf


        outputstring &= "[start LiteCard14Top]" & LiteCard14.Top & "[end LiteCard14Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard14Left]" & LiteCard14.Left & "[end LiteCard14Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard14Angle]" & LiteCard14.Angle & "[end LiteCard14Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard14FontSize]" & LiteCard14.FontSize & "[end LiteCard14FontSize]" & Constants.vbCrLf
        outputstring &= "[start LiteCard14ForeColor]" & LiteCard14.ForeColor.ToArgb.ToString & "[end LiteCard14ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard14BackColor]" & LiteCard14.Backcolor.ToArgb.ToString & "[end LiteCard14BackColor]" & Constants.vbCrLf

        outputstring &= "[start LiteCard15Top]" & LiteCard15.Top & "[end LiteCard15Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard15Left]" & LiteCard15.Left & "[end LiteCard15Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard15Angle]" & LiteCard15.Angle & "[end LiteCard15Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard15FontSize]" & LiteCard15.FontSize & "[end LiteCard15FontSize]" & Constants.vbCrLf
        outputstring &= "[start LiteCard15ForeColor]" & LiteCard15.ForeColor.ToArgb.ToString & "[end LiteCard15ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard15BackColor]" & LiteCard15.Backcolor.ToArgb.ToString & "[end LiteCard15BackColor]" & Constants.vbCrLf

        outputstring &= "[start LiteCard16Top]" & LiteCard16.Top & "[end LiteCard16Top]" & Constants.vbCrLf
        outputstring &= "[start LiteCard16Left]" & LiteCard16.Left & "[end LiteCard16Left]" & Constants.vbCrLf
        outputstring &= "[start LiteCard16Angle]" & LiteCard16.Angle & "[end LiteCard16Angle]" & Constants.vbCrLf
        outputstring &= "[start LiteCard16FontSize]" & LiteCard16.FontSize & "[end LiteCard16FontSize]" & Constants.vbCrLf
        outputstring &= "[start LiteCard16ForeColor]" & LiteCard16.ForeColor.ToArgb.ToString & "[end LiteCard16ForeColor]" & Constants.vbCrLf
        outputstring &= "[start LiteCard16BackColor]" & LiteCard16.Backcolor.ToArgb.ToString & "[end LiteCard16BackColor]" & Constants.vbCrLf

        'CFM

        SW.Write(outputstring)
        SW.Close()
    End Sub







    Private Sub Lbut_custom_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_custom_export.Click



        'Dim SW As IO.StreamWriter 'IO.File.CreateText()

        Dim result As Boolean = True
        Dim answer As DialogResult
        Dim path As String 'the file diolog box changes the default path 
        'making the program not find the help file and not save setting to correct place


        With SFD_export
            .Reset() 'changing the initial directory doesnt work otherwise
            .Filter = filter_demodisplay

            'the .ShowDialog function reset the path which needs to be restored in order for hep userdata and settings to be
            'written and read correctly. also I am saving the selected directory in user data file so that the dialog box will
            'open to the same path

            path = IO.Directory.GetCurrentDirectory



            IO.Directory.SetCurrentDirectory(Form1.userdata(Form1.userdataindex.displayPatternPath))

            .InitialDirectory = Form1.userdata(Form1.userdataindex.displayPatternPath)

            answer = .ShowDialog


            If answer = Windows.Forms.DialogResult.Cancel Then

                IO.Directory.SetCurrentDirectory(path)

                Return
            Else
                'SW = IO.File.CreateText(.FileName)
                'Dim outputstring As String = ""

                'Form1.userdata(Form1.userdataindex.displayPatternPath) = .InitialDirectory
                Form1.userdata(Form1.userdataindex.displayPatternPath) = IO.Directory.GetCurrentDirectory

                ExportdisplayPattern(.FileName)




            End If
        End With
        IO.Directory.SetCurrentDirectory(path)
        'Return result

    End Sub

    Private Sub Lbut_custon_import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbut_custon_import.Click

        With OFD_import

            .Reset() 'changing the initial directory doesnt work otherwise
            .Filter = filter_demodisplay


            'the .ShowDialog function reset the path which needs to be restored in order for hep userdata and settings to be
            'written and read correctly. also I am saving the selected directory in user data file so that the dialog box will
            'open to the same path
            Dim path As String = IO.Directory.GetCurrentDirectory
            IO.Directory.SetCurrentDirectory(Form1.userdata(Form1.userdataindex.displayPatternPath))

            .InitialDirectory = Form1.userdata(Form1.userdataindex.displayPatternPath)
            Dim result As DialogResult = .ShowDialog

            If result = Windows.Forms.DialogResult.Cancel Then
                IO.Directory.SetCurrentDirectory(path)
                Return
            End If






            Me.importDisplayPattern(.FileName)

            Form1.userdata(Form1.userdataindex.displayPatternPath) = IO.Directory.GetCurrentDirectory
            IO.Directory.SetCurrentDirectory(path)
        End With


    End Sub



    Private Sub CMI_fore_red_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMI_fore_red.Click
        Me.setCardForecolor(cardrightclicked, Color.Red)
    End Sub

    Private Sub CMI_fore_green_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMI_Fore_green.Click
        Me.setCardForecolor(cardrightclicked, Color.Green)
    End Sub

    Private Sub CMI_fore_blue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMI_fore_blue.Click
        Me.setCardForecolor(cardrightclicked, Color.Blue)
    End Sub

    Private Sub CMI_backblack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.setCardBackcolor(cardrightclicked, Color.Black)


    End Sub

    Private Sub CMI_backgreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.setCardBackcolor(cardrightclicked, Color.Green)

    End Sub

    'Private Sub CMI_backred_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.setCardBackcolor(cardrightclicked, Color.Red)
    'End Sub


    Private Sub CMI_fore_white_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.setCardForecolor(cardrightclicked, Color.White)
    End Sub

    'Private Sub CMI_colorpattern_allblue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMI_colorpattern_allblue.Click
    '    Dim i As Int16 = 0
    '    While i < 10
    '        setCardForecolor(i, Color.Blue)
    '        i += 1
    '    End While
    'End Sub

    'Private Sub CMI_colorpattern_allgreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMI_colorpattern_allgreen.Click
    '    Dim i As Int16 = 0
    '    While i < 10
    '        setCardForecolor(i, Color.Green)
    '        i += 1
    '    End While
    'End Sub

    'Private Sub CMI_colorpattern_allred_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMI_colorpattern_allred.Click
    '    Dim i As Int16 = 0
    '    While i < 10
    '        setCardForecolor(i, Color.Red)
    '        i += 1
    '    End While
    'End Sub

    'Private Sub CMI_colorpattern_allwhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMI_colorpattern_allwhite.Click
    '    Dim i As Int16 = 0
    '    While i < 10
    '        setCardForecolor(i, Color.White)

    '        i += 1
    '    End While
    'End Sub

    'Public Sub CMI_colorpattern_common_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMI_colorpattern3.Click, CMI_colorpattern5.Click, CMI_colorpattern0.Click, CMI_colorpattern1.Click, CMI_colorpattern2.Click, CMI_colorpattern9.Click, CMI_colorpattern8.Click, CMI_colorpattern6.Click, CMI_colorpattern4.Click
    Public Sub CMI_colorpattern_common_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMI_colorpattern0.Click, CMI_colorpattern3.Click, CMI_colorpattern2.Click, CMI_colorpattern1.Click, CMI_mypattern9.Click, CMI_mypattern8.Click, CMI_mypattern7.Click, CMI_mypattern6.Click, CMI_mypattern5.Click, CMI_mypattern4.Click, CMI_mypattern3.Click, CMI_mypattern2.Click, CMI_mypattern1.Click, CMI_mypattern0.Click, CMI_colorpattern9.Click, CMI_colorpattern8.Click, CMI_colorpattern7.Click, CMI_colorpattern6.Click, CMI_colorpattern5.Click, CMI_colorpattern4.Click

        Dim tag As String = sender.tag.ToString

        setCardForecolor(sender.tag.ToString)
    End Sub

    Public Sub CMI_openlibrary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMI_library.Click, CMI_openlibrary.Click
        colorpatterns.ShowDialog()

    End Sub

    Private Sub simulator_form_MaximumSizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub simulator_form_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged

        If initialized Then
            Static scalefactor As Single = 1
            Static minimized = False
            'keeps track of the scale used to enlarge several objects when maximizing and shrink when restoring
            'is kept at 1 when no maximixing has occured to prevent incorrect resizing

            If Me.WindowState = FormWindowState.Maximized Then

                If minimized Then
                    minimized = False
                    Return

                End If
                Dim screenRectangle As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea
                Dim screenHeight As Int32 = screenRectangle.Height
                Dim screenWidth As Int32 = screenRectangle.Width



                Dim maxdisplaywidth As Int32 = screenWidth
                Dim maxdisplayheight As Int32 = screenHeight - Pan_buttons.Height - 20


                'determine weather to use max width or max height
                Dim usewidth As Boolean = False
                Dim useheight As Boolean = False

                Dim heightratio As Single = maxdisplayheight / normaldisplaysize.Y
                Dim widthtratio As Single = maxdisplaywidth / normaldisplaysize.X

                If normaldisplaysize.X * heightratio <= maxdisplaywidth Then
                    useheight = True
                End If

                If normaldisplaysize.Y * widthtratio <= maxdisplayheight Then
                    usewidth = True
                End If

                If usewidth And useheight Then
                    'if both can be used, determine which results in bigger diaplay area

                    Dim widtharea As Int64 = maxdisplaywidth * (normaldisplaysize.Y * widthtratio)
                    Dim heightarea As Int64 = maxdisplayheight * (normaldisplaysize.X * heightratio)



                    If widtharea > heightarea Then
                        useheight = False
                    Else
                        usewidth = False
                    End If
                End If


                If usewidth Then

                    Pan_dislpayregion.Size = New Point(maxdisplaywidth, normaldisplaysize.Y * widthtratio)
                    scalefactor = widthtratio
                ElseIf useheight Then

                    Pan_dislpayregion.Dock = DockStyle.None
                    Pan_dislpayregion.Size = New Point(normaldisplaysize.X * heightratio, maxdisplayheight)

                    scalefactor = heightratio

                End If

                'center display region

                If Pan_dislpayregion.Width < maxdisplaywidth Then

                    Pan_dislpayregion.Left += (maxdisplaywidth - Pan_dislpayregion.Width) / 2


                End If

                If Pan_dislpayregion.Height < maxdisplayheight Then

                    Pan_dislpayregion.Top += (maxdisplayheight - Pan_dislpayregion.Height) / 2


                End If



                'scale up background and litecards
                Pan_imageholder.Width *= scalefactor
                Pan_imageholder.Height *= scalefactor
                position_Pan_cardbackground()






                'Pan_dislpayregion.Size = New Point(maxdisplaywidth, maxdisplayheight)
            ElseIf Me.WindowState = FormWindowState.Normal Then
                If minimized Then
                    minimized = False
                    Return

                End If

                If scalefactor <> 1 Then
                    'condition prevents unneccesary flickering
                    Pan_dislpayregion.Location = New Point(0, 0)
                    Pan_dislpayregion.Dock = DockStyle.Top
                    Pan_dislpayregion.Size = normaldisplaysize
                    Pan_imageholder.Width /= scalefactor
                    Pan_imageholder.Height /= scalefactor
                    position_Pan_cardbackground()
                    scalefactor = 1

                End If
            ElseIf Me.WindowState = FormWindowState.Minimized Then

                minimized = True
            End If
        End If
    End Sub

    Private Sub simulator_form_AutoSizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub simulator_form_DockChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DockChanged
        MsgBox("ttttt")
    End Sub



    Public Sub cards_shape_Arc()

        'card size is fixed
        'in this function start and end angle is fixed

        'radius is caluclated to the scaled space between cards
        'however if the resulting curv does is not visible the space between cards is reduced

        'location for center of arc is calculated to center the arc on the form


        'REALCARDWIDTH()




        If LiteCard0.FontSize > Me.maxfontsize(pattern.revArch, Form1.linelength) Then
            LiteCard0.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard1.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard2.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard3.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard4.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard5.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard6.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard7.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard8.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard9.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard10.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard11.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard12.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard13.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard14.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard15.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard16.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            'CFM



        End If




        Dim usedspacebetweencards As Single = MAX_REALSPACEBETWEENCARDS







        usedspacebetweencards /= 0.99 'first time through loop starting value




        Do

            usedspacebetweencards *= 0.9

            If usedspacebetweencards < 1 Then ' then Or (LiteCard0.location.X < 0 And longestdimension < -LiteCard0.location.X) Then

                'the light cards can not fit in the display area
                'make sign smaller and retry from beginning




                'zoom out multiple times because loop was taking too long


                'Dim timestozoombig As Single = -2 * LiteCard0.location.X / longestdimension

                'Dim loopcounter As Single = 0.1
                'While loopcounter < timestozoombig

                '    Me.signZoomOutBig()
                '    loopcounter += 1
                'End While

                'If timestozoombig <= 0.1 Then

                Me.signZoomOutSmall()
                Me.signZoomOutSmall()

                'End If

                usedspacebetweencards = MAX_REALSPACEBETWEENCARDS

            End If

        Dim cheatspace As Int16 = 0 'instead if calculating distance from connector 
        'or corners, I am calculating from center of card with a cheet factor
        Dim scale = LiteCard0.cardwidth / REALCARDWIDTH
        Dim startangle As Single = -145

        Dim centerofform As PointF = New PointF(Pan_cards.Width / 2, Pan_cards.Height / 2)

        Dim endangle As Single = -startangle - 180
        Dim angle_step As Single = (startangle - endangle) / (Form1.settings(Form1.settingsindex.linelength) - 1)
        Dim stepangleinradians = angle_step * Math.PI / 180
        Dim startangleinradians As Single = startangle * Math.PI / 180

        'calculated so that the space between cards is correct
        Dim archradius = -scale * (REALCARDWIDTH + MAX_REALSPACEBETWEENCARDS + cheatspace) / (2 * Math.Sin(stepangleinradians / 2))


        ''''''calculate center of arc so that the arc is centered''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'calculate the center of the form in relation 
        'to using the center of the arc as origen 
        'x is 0
        'y is halfway between the y coordinates of angle 0  and start(or stop) angle 
        'yof angle 0 is radius


        

        While True
            'if the ark is not fully visible reduce space between cards


            Dim y_startangle As Single = archradius * Math.Sin(startangleinradians)

            Dim y_middleofform As Single = (-archradius + y_startangle) / 2
            y_middleofform = (-archradius + y_startangle) / 2

            Dim centerofrevarch As PointF = New PointF(centerofform.X, centerofform.Y - y_middleofform)
            centerofrevarch = New PointF(centerofform.X, centerofform.Y - y_middleofform)

            ''''draw arc ''''''''''
            '''''''''''''''''''''''

            angle_step = -angle_step
            Dim curr_angle = startangle

            LiteCard0.DoNotRedraw = True
            LiteCard1.DoNotRedraw = True
            LiteCard2.DoNotRedraw = True
            LiteCard3.DoNotRedraw = True
            LiteCard4.DoNotRedraw = True
            LiteCard5.DoNotRedraw = True
            LiteCard6.DoNotRedraw = True
            LiteCard7.DoNotRedraw = True

            LiteCard8.DoNotRedraw = True
            LiteCard9.DoNotRedraw = True
            LiteCard10.DoNotRedraw = True
            LiteCard11.DoNotRedraw = True
            LiteCard12.DoNotRedraw = True
            LiteCard13.DoNotRedraw = True
                LiteCard14.DoNotRedraw = True
                LiteCard15.DoNotRedraw = True
                LiteCard16.DoNotRedraw = True

                'CFM ??? indent is ODD

            LiteCard0.PositionInArk(centerofrevarch, archradius, curr_angle)
            curr_angle += angle_step
            LiteCard1.PositionInArk(centerofrevarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard2.PositionInArk(centerofrevarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard3.PositionInArk(centerofrevarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard4.PositionInArk(centerofrevarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard5.PositionInArk(centerofrevarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard6.PositionInArk(centerofrevarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard7.PositionInArk(centerofrevarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard8.PositionInArk(centerofrevarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard9.PositionInArk(centerofrevarch, archradius, curr_angle)
            curr_angle += angle_step

            LiteCard10.PositionInArk(centerofrevarch, archradius, curr_angle)
            curr_angle += angle_step
            LiteCard11.PositionInArk(centerofrevarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard12.PositionInArk(centerofrevarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard13.PositionInArk(centerofrevarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard14.PositionInArk(centerofrevarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard15.PositionInArk(centerofrevarch, archradius, curr_angle)

                curr_angle += angle_step
                LiteCard16.PositionInArk(centerofrevarch, archradius, curr_angle)

                'CFM ???

            'if the first card is partly hidden, change radius and redraw
            If LiteCard0.location.X < LiteCard0.Width / 2 Then
                archradius -= 0.01
            Else
                Exit While
            End If

            Exit While

        End While
        Loop Until (Me.cardswithinviewingarea)

        LiteCard0.DoNotRedraw = False
        LiteCard1.DoNotRedraw = False
        LiteCard2.DoNotRedraw = False
        LiteCard3.DoNotRedraw = False
        LiteCard4.DoNotRedraw = False
        LiteCard5.DoNotRedraw = False
        LiteCard6.DoNotRedraw = False
        LiteCard7.DoNotRedraw = False

        LiteCard8.DoNotRedraw = False
        LiteCard9.DoNotRedraw = False
        LiteCard10.DoNotRedraw = False
        LiteCard11.DoNotRedraw = False
        LiteCard12.DoNotRedraw = False
        LiteCard13.DoNotRedraw = False
        LiteCard14.DoNotRedraw = False
        LiteCard15.DoNotRedraw = False
        LiteCard16.DoNotRedraw = False
        'CFM

        Form1.positionandsizecards()
        Timer_delayed_invalidate.Start()



    End Sub


    Public Sub cards_shape_Scurve()


        'the 2 curves join in the exact center of the form
        'we assume that the point that they join can be anywhere from 0-90 from verticle

        'the start and stop angle from vertical (on the end oposit the center) is specified as a constant.

        'we start using a center angle of 90 and work down untill we find the largest that will work



        'from each center angle we can calculate the largest radius that will support the maximum space between cards
        'we then determine if the curve from this angle and radius is visible.
        'if not we then try the next one








        Dim cardcount As Int16 = Form1.settings(Form1.settingsindex.linelength)




        If LiteCard0.FontSize > Me.maxfontsize(pattern.sCurve, cardcount) Then
            LiteCard0.FontSize = maxfontsize(pattern.sCurve, cardcount)
            LiteCard1.FontSize = maxfontsize(pattern.sCurve, cardcount)
            LiteCard2.FontSize = maxfontsize(pattern.sCurve, cardcount)
            LiteCard3.FontSize = maxfontsize(pattern.sCurve, cardcount)
            LiteCard4.FontSize = maxfontsize(pattern.sCurve, cardcount)
            LiteCard5.FontSize = maxfontsize(pattern.sCurve, cardcount)
            LiteCard6.FontSize = maxfontsize(pattern.sCurve, cardcount)
            LiteCard7.FontSize = maxfontsize(pattern.sCurve, cardcount)
            LiteCard8.FontSize = maxfontsize(pattern.sCurve, cardcount)
            LiteCard9.FontSize = maxfontsize(pattern.sCurve, cardcount)
            LiteCard10.FontSize = maxfontsize(pattern.sCurve, cardcount)
            LiteCard11.FontSize = maxfontsize(pattern.sCurve, cardcount)
            LiteCard12.FontSize = maxfontsize(pattern.sCurve, cardcount)
            LiteCard13.FontSize = maxfontsize(pattern.sCurve, cardcount)
            LiteCard14.FontSize = maxfontsize(pattern.sCurve, cardcount)
            LiteCard15.FontSize = maxfontsize(pattern.sCurve, cardcount)
            LiteCard16.FontSize = maxfontsize(pattern.sCurve, cardcount)
            'CFM



        End If


        
        Const cheatspace As Int16 = 0 'instead if calculating distance from connector 
        'or corners, I am calculating from center of card with a cheet factor
        Dim scale = LiteCard0.cardwidth / REALCARDWIDTH

        Dim centerofarc As PointF
        Dim centerofrevarc As PointF

        Dim centerofform As PointF = New PointF(Pan_cards.Width / 2, Pan_cards.Height / 2)
        Const anglefromvertical As Single = 55

        Dim radius As Single

        Dim sweepangle As Single
        Dim angle_step As Single
        Dim stepangleinradians As Single



        Dim angleatcenter As Single = 90
        Dim continueflag As Boolean = True
        Dim revarc_steps As Int16
        Dim curang As Single
        Dim loopcounter As Int16 = 0

        While continueflag


            If angleatcenter <= 0 Then



                Me.signZoomOutSmall()
                Me.signZoomOutSmall()


                scale = LiteCard0.cardwidth / REALCARDWIDTH
                angleatcenter = 90
                'continueflag = True
                'Continue While

                ''from here to end of if statement is old code from before all patterns 
                ''were modified to reduce card size when pattern didnet fir
                'MsgBox("unable to fit this pattern on screen")
                'Exit Sub
            End If
            continueflag = False




            sweepangle = angleatcenter + anglefromvertical


            If cardcount Mod 2 = 0 Then

                angle_step = sweepangle / ((cardcount / 2.0) - (1.0 / 2.0))
            Else
                angle_step = sweepangle / ((cardcount - 1.0) / 2.0)
            End If


            '


            stepangleinradians = angle_step * Math.PI / 180

            Try
                radius = scale * (REALCARDWIDTH + MAX_REALSPACEBETWEENCARDS + cheatspace) / (2 * Math.Sin(stepangleinradians / 2))
            Catch ex As Exception
                angleatcenter -= 0.1
                continueflag = True
                Continue While
            End Try

            'get the center of arc and reverse arc
            Dim xofarc = Math.Abs(radius * Math.Sin(angleatcenter * Math.PI / 180))
            Dim yofarc = Math.Abs(radius * Math.Cos(angleatcenter * Math.PI / 180))

            centerofrevarc = New PointF(centerofform.X - xofarc, centerofform.Y - yofarc)
            centerofarc = New PointF(centerofform.X + xofarc, centerofform.Y + yofarc)

            'step through to see if entire curve is visible

            'reverse arc portion
            'for this portion of the function we assume that straight down is 0 degrees

            curang = anglefromvertical * Math.PI / 180 'in this section curangle is stored in radians


            If cardcount Mod 2 = 0 Then
                revarc_steps = (cardcount / 2) - 1
            Else
                revarc_steps = (cardcount - 1) / 2
            End If
            While loopcounter < revarc_steps
                Dim curyfromarccenter As Single = Math.Abs(radius * Math.Cos(curang))
                Dim curxfromarccenter As Single = Math.Abs(radius * Math.Sin(curang))
                Dim cardcenter_panelref As PointF
                If curang > 0 Then
                    cardcenter_panelref = New PointF(centerofrevarc.X - curxfromarccenter, centerofrevarc.Y + curyfromarccenter)
                Else
                    cardcenter_panelref = New PointF(centerofrevarc.X + curxfromarccenter, centerofrevarc.Y + curyfromarccenter)
                End If

                If cardcenter_panelref.X - (LiteCard1.cardheight / 2) <= 0.05 * Pan_cards.Width Then '0 Then
                    angleatcenter -= 0.1
                    continueflag = True
                    Exit While
                End If
                If cardcenter_panelref.Y - (LiteCard1.cardheight / 2) <= 0.05 * Pan_cards.Height Then '0 Then
                    angleatcenter -= 0.1
                    continueflag = True
                    Exit While
                End If
                curang -= stepangleinradians
                loopcounter += 1
            End While






        End While

        'MsgBox(LiteCard0.FontSize)




        'draw selected curve

        
        LiteCard0.DoNotRedraw = True
        LiteCard1.DoNotRedraw = True
        LiteCard2.DoNotRedraw = True
        LiteCard3.DoNotRedraw = True
        LiteCard4.DoNotRedraw = True
        LiteCard5.DoNotRedraw = True
        LiteCard6.DoNotRedraw = True
        LiteCard7.DoNotRedraw = True

        LiteCard8.DoNotRedraw = True
        LiteCard9.DoNotRedraw = True

        LiteCard10.DoNotRedraw = True
        LiteCard11.DoNotRedraw = True
        LiteCard12.DoNotRedraw = True
        LiteCard13.DoNotRedraw = True
        LiteCard14.DoNotRedraw = True
        LiteCard15.DoNotRedraw = True
        LiteCard16.DoNotRedraw = True
        'CFM

        'rev arc portion
        'horizontal line is 0 or 180 degrees

        curang = 90 + anglefromvertical 'in this section curangle is stored in degrees
        loopcounter = 0
        While loopcounter < revarc_steps

            If loopcounter = 0 Then
                LiteCard0.PositionInArk(centerofrevarc, radius, curang)

            ElseIf loopcounter = 1 Then
                LiteCard1.PositionInArk(centerofrevarc, radius, curang)
            ElseIf loopcounter = 2 Then
                LiteCard2.PositionInArk(centerofrevarc, radius, curang)
            ElseIf loopcounter = 3 Then
                LiteCard3.PositionInArk(centerofrevarc, radius, curang)
            ElseIf loopcounter = 4 Then
                LiteCard4.PositionInArk(centerofrevarc, radius, curang)
            ElseIf loopcounter = 5 Then
                LiteCard5.PositionInArk(centerofrevarc, radius, curang)
            ElseIf loopcounter = 6 Then
                LiteCard6.PositionInArk(centerofrevarc, radius, curang)
            ElseIf loopcounter = 7 Then
                LiteCard7.PositionInArk(centerofrevarc, radius, curang)
            ElseIf loopcounter = 8 Then
                LiteCard8.PositionInArk(centerofrevarc, radius, curang)
            ElseIf loopcounter = 9 Then
                LiteCard9.PositionInArk(centerofrevarc, radius, curang)

            ElseIf loopcounter = 10 Then
                LiteCard10.PositionInArk(centerofrevarc, radius, curang)

            ElseIf loopcounter = 11 Then
                LiteCard11.PositionInArk(centerofrevarc, radius, curang)
            ElseIf loopcounter = 12 Then
                LiteCard12.PositionInArk(centerofrevarc, radius, curang)
            ElseIf loopcounter = 13 Then
                LiteCard13.PositionInArk(centerofrevarc, radius, curang)
            ElseIf loopcounter = 14 Then
                LiteCard14.PositionInArk(centerofrevarc, radius, curang)
            ElseIf loopcounter = 15 Then
                LiteCard15.PositionInArk(centerofrevarc, radius, curang)
            ElseIf loopcounter = 16 Then
                LiteCard15.PositionInArk(centerofrevarc, radius, curang)
                'CFM
            
            End If

            curang -= angle_step
            loopcounter += 1
        End While


        'arc portion
        curang = 180 - curang
        'If cardcount Mod 2 = 0 Then
        '    curang += 1 / 2 * angle_step
        'End If

        While loopcounter < cardcount

            If loopcounter = 0 Then
                LiteCard0.PositionInArk(centerofarc, radius, curang)
            ElseIf loopcounter = 1 Then
                LiteCard1.PositionInArk(centerofarc, radius, curang)
            ElseIf loopcounter = 2 Then
                LiteCard2.PositionInArk(centerofarc, radius, curang)
            ElseIf loopcounter = 3 Then
                LiteCard3.PositionInArk(centerofarc, radius, curang)
            ElseIf loopcounter = 4 Then
                LiteCard4.PositionInArk(centerofarc, radius, curang)
            ElseIf loopcounter = 5 Then
                LiteCard5.PositionInArk(centerofarc, radius, curang)
            ElseIf loopcounter = 6 Then
                LiteCard6.PositionInArk(centerofarc, radius, curang)
            ElseIf loopcounter = 7 Then
                LiteCard7.PositionInArk(centerofarc, radius, curang)
            ElseIf loopcounter = 8 Then
                LiteCard8.PositionInArk(centerofarc, radius, curang)
            ElseIf loopcounter = 9 Then
                LiteCard9.PositionInArk(centerofarc, radius, curang)
            ElseIf loopcounter = 10 Then
                LiteCard10.PositionInArk(centerofarc, radius, curang)
            ElseIf loopcounter = 11 Then
                LiteCard11.PositionInArk(centerofarc, radius, curang)
            ElseIf loopcounter = 12 Then
                LiteCard12.PositionInArk(centerofarc, radius, curang)
            ElseIf loopcounter = 13 Then
                LiteCard13.PositionInArk(centerofarc, radius, curang)
            ElseIf loopcounter = 14 Then
                LiteCard14.PositionInArk(centerofarc, radius, curang)
            ElseIf loopcounter = 15 Then
                LiteCard15.PositionInArk(centerofarc, radius, curang)
            ElseIf loopcounter = 16 Then
                LiteCard16.PositionInArk(centerofarc, radius, curang)
                'CFM

            End If

            curang += angle_step
            loopcounter += 1
        End While



        LiteCard0.DoNotRedraw = False
        LiteCard1.DoNotRedraw = False
        LiteCard2.DoNotRedraw = False
        LiteCard3.DoNotRedraw = False
        LiteCard4.DoNotRedraw = False
        LiteCard5.DoNotRedraw = False
        LiteCard6.DoNotRedraw = False
        LiteCard7.DoNotRedraw = False

        LiteCard8.DoNotRedraw = False
        LiteCard9.DoNotRedraw = False

        LiteCard10.DoNotRedraw = False
        LiteCard11.DoNotRedraw = False
        LiteCard12.DoNotRedraw = False
        LiteCard13.DoNotRedraw = False
        LiteCard14.DoNotRedraw = False
        LiteCard15.DoNotRedraw = False
        LiteCard16.DoNotRedraw = False
        'CFm

        Form1.positionandsizecards()
        Timer_delayed_invalidate.Start()





        'MsgBox(angleatcenter)




        'Dim startangle As Single = 145
        ''Dim startangle As Single = 162

        'Dim centerofform As PointF = New PointF(Pan_cards.Width / 2, Pan_cards.Height / 2)

        'Dim endangle As Single = 50
        'Dim angle_step As Single = (startangle - endangle) / (Form1.settings(Form1.settingsindex.linelength) / 2 - 1)

        'Dim startangleinradians As Single = startangle * Math.PI / 180

        ''calculated so that the space between cards is correct


        '''''''calculate center of arc so that the arc is centered''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ''calculate the center of the form in relation 
        ''to using the center of the arc as origen 
        ''x is 0
        ''y is halfway between the y coordinates of angle 0  and start(or stop) angle 
        ''yof angle 0 is radius


        'Dim y_startangle As Single = revarchradius * Math.Sin(startangleinradians)

        'Dim y_middleofform As Single = (-revarchradius - y_startangle) / 2

        'Dim centerofrevarch As PointF = New Point(centerofform.X, centerofform.Y + y_middleofform)

        '''''draw arc ''''''''''
        ''''''''''''''''''''''''

        'angle_step = -angle_step
        'Dim curr_angle = startangle - angle_step / 2

        'LiteCard0.DoNotRedraw = True
        'LiteCard1.DoNotRedraw = True
        'LiteCard2.DoNotRedraw = True
        'LiteCard3.DoNotRedraw = True
        'LiteCard4.DoNotRedraw = True
        'LiteCard5.DoNotRedraw = True
        'LiteCard6.DoNotRedraw = True
        'LiteCard7.DoNotRedraw = True

        'LiteCard8.DoNotRedraw = True
        'LiteCard9.DoNotRedraw = True

        ''MsgBox(curr_angle)
        'LiteCard0.PositionInArk(centerofrevarch, revarchradius, curr_angle)

        'If Form1.settings(Form1.settingsindex.linelength) / 2 > 1 Then
        '    curr_angle += angle_step
        '    'MsgBox(curr_angle)
        '    LiteCard1.PositionInArk(centerofrevarch, revarchradius, curr_angle)

        'End If

        'If Form1.settings(Form1.settingsindex.linelength) / 2 > 2 Then


        '    curr_angle += angle_step
        '    'MsgBox(curr_angle)
        '    LiteCard2.PositionInArk(centerofrevarch, revarchradius, curr_angle)
        'End If

        'If Form1.settings(Form1.settingsindex.linelength) / 2 > 3 Then
        '    curr_angle += angle_step
        '    'MsgBox(curr_angle)
        '    LiteCard3.PositionInArk(centerofrevarch, revarchradius, curr_angle)

        'End If

        'If Form1.settings(Form1.settingsindex.linelength) / 2 > 4 Then
        '    curr_angle += angle_step
        '    'MsgBox(curr_angle)
        '    LiteCard4.PositionInArk(centerofrevarch, revarchradius, curr_angle)

        'End If
        'If Form1.settings(Form1.settingsindex.linelength) / 2 > 5 Then

        '    curr_angle += angle_step
        '    'MsgBox(curr_angle)
        '    LiteCard5.PositionInArk(centerofrevarch, revarchradius, curr_angle)

        'End If

        'If Form1.settings(Form1.settingsindex.linelength) / 2 > 6 Then
        '    curr_angle += angle_step
        '    'MsgBox(curr_angle)
        '    LiteCard6.PositionInArk(centerofrevarch, revarchradius, curr_angle)
        'End If



        'If Form1.settings(Form1.settingsindex.linelength) / 2 > 7 Then

        '    curr_angle += angle_step
        '    'MsgBox(curr_angle)
        '    LiteCard7.PositionInArk(centerofrevarch, revarchradius, curr_angle)

        'End If

        'If Form1.settings(Form1.settingsindex.linelength) / 2 > 8 Then

        '    curr_angle += angle_step
        '    'MsgBox(curr_angle)
        '    LiteCard8.PositionInArk(centerofrevarch, revarchradius, curr_angle)

        'End If

        'If Form1.settings(Form1.settingsindex.linelength) / 2 > 9 Then
        '    curr_angle += angle_step
        '    'MsgBox(curr_angle)
        '    LiteCard9.PositionInArk(centerofrevarch, revarchradius, curr_angle)

        'End If

        ''LiteCard0.DoNotRedraw = False
        ''LiteCard1.DoNotRedraw = False
        ''LiteCard2.DoNotRedraw = False
        ''LiteCard3.DoNotRedraw = False
        ''LiteCard4.DoNotRedraw = False
        ''LiteCard5.DoNotRedraw = False
        ''LiteCard6.DoNotRedraw = False
        ''LiteCard7.DoNotRedraw = False

        ''LiteCard8.DoNotRedraw = False
        ''LiteCard9.DoNotRedraw = False

        ''Form1.positionandsizecards()
        ''Timer_delayed_invalidate.Start()










        '''''''''''''''''''copied from arc
        ''Dim cheatspace As Int16 = 0 'instead if calculating distance from connector 
        ''or corners, I am calculating from center of card with a cheet factor
        ''Dim scale = LiteCard0.cardwidth / REALCARDWIDTH
        ''startangle = -145

        'Dim arc_centerofform As PointF = New PointF(Pan_cards.Width * ((4.67 - (1 - (cardcount / 10))) / 8), Pan_cards.Height / 2)

        ''endangle = -startangle - 180
        ''angle_step = (startangle - endangle) / (Form1.settings(Form1.settingsindex.linelength) - 1) / 2
        ''stepangleinradians = angle_step * Math.PI / 180
        ''startangleinradians = startangle * Math.PI / 180

        ''calculated so that the space between cards is correct
        'Dim archradius = -scale * (REALCARDWIDTH + MAX_REALSPACEBETWEENCARDS + cheatspace) / (2 * Math.Sin(stepangleinradians / 2))
        '' MsgBox(revarchradius)
        ''MsgBox(archradius)

        '''''''calculate center of arc so that the arc is centered''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ''calculate the center of the form in relation 
        ''to using the center of the arc as origen 
        ''x is 0
        ''y is halfway between the y coordinates of angle 0  and start(or stop) angle 
        ''yof angle 0 is radius


        ''y_startangle = archradius * Math.Sin(startangleinradians)

        ''y_middleofform = (-archradius + y_startangle) / 2

        'Dim centerofarch As PointF = New Point(arc_centerofform.X, arc_centerofform.Y - y_middleofform)

        '''''draw arc ''''''''''
        ''''''''''''''''''''''''

        'angle_step = -angle_step
        ''curr_angle += angle_step
        'curr_angle = endangle + angle_step / 2

        'LiteCard0.DoNotRedraw = True
        'LiteCard1.DoNotRedraw = True
        'LiteCard2.DoNotRedraw = True
        'LiteCard3.DoNotRedraw = True
        'LiteCard4.DoNotRedraw = True
        'LiteCard5.DoNotRedraw = True
        'LiteCard6.DoNotRedraw = True
        'LiteCard7.DoNotRedraw = True

        'LiteCard8.DoNotRedraw = True
        'LiteCard9.DoNotRedraw = True

        'Dim conditionvalue As Int16 = Form1.settings(Form1.settingsindex.linelength) / 2


        'If conditionvalue <= 1 Then

        '    'MsgBox(curr_angle)
        '    LiteCard1.PositionInArk(centerofarch, archradius, curr_angle)
        '    curr_angle += angle_step
        'End If

        'If conditionvalue <= 2 Then

        '    'MsgBox(curr_angle)
        '    LiteCard2.PositionInArk(centerofarch, archradius, curr_angle)
        '    curr_angle += angle_step
        'End If


        'If conditionvalue <= 3 Then

        '    'MsgBox(curr_angle)
        '    LiteCard3.PositionInArk(centerofarch, archradius, curr_angle)
        '    curr_angle += angle_step
        'End If

        'If conditionvalue <= 4 Then

        '    'MsgBox(curr_angle)
        '    LiteCard4.PositionInArk(centerofarch, archradius, curr_angle)
        '    curr_angle += angle_step
        'End If

        'If conditionvalue <= 5 Then

        '    'MsgBox(curr_angle)
        '    LiteCard5.PositionInArk(centerofarch, archradius, curr_angle)
        '    curr_angle += angle_step
        'End If

        'If conditionvalue <= 6 Then

        '    'MsgBox(curr_angle)
        '    LiteCard6.PositionInArk(centerofarch, archradius, curr_angle)
        '    curr_angle += angle_step
        'End If

        'If conditionvalue <= 7 Then


        '    'MsgBox(curr_angle)
        '    LiteCard7.PositionInArk(centerofarch, archradius, curr_angle)
        '    curr_angle += angle_step
        'End If

        'If conditionvalue <= 8 Then

        '    'MsgBox(curr_angle)
        '    LiteCard8.PositionInArk(centerofarch, archradius, curr_angle)
        '    curr_angle += angle_step
        'End If
        'If conditionvalue <= 9 Then

        '    'MsgBox(curr_angle)
        '    LiteCard9.PositionInArk(centerofarch, archradius, curr_angle)
        '    curr_angle += angle_step
        'End If


        'LiteCard0.DoNotRedraw = False
        'LiteCard1.DoNotRedraw = False
        'LiteCard2.DoNotRedraw = False
        'LiteCard3.DoNotRedraw = False
        'LiteCard4.DoNotRedraw = False
        'LiteCard5.DoNotRedraw = False
        'LiteCard6.DoNotRedraw = False
        'LiteCard7.DoNotRedraw = False

        'LiteCard8.DoNotRedraw = False
        'LiteCard9.DoNotRedraw = False

        'Form1.positionandsizecards()
        'Timer_delayed_invalidate.Start()



    End Sub






    Private Sub PB_horr_line_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_horr_line.Click

        cards_shape_HorLine()
        curr_clickmode = clickmodes.none

        ret_clickmode = clickmodes.none 'returned to when esc is pressed
        deselectect_all_buttons()
        Form1.mark_selected(sender)

        locksign()
    End Sub

    Private Sub PB_rev_arc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_rev_arc.Click

        'MsgBox("pattern not yet implimented")
        'Return

        Me.cards_shape_ReverseArc()

        deselectect_all_buttons()
        Form1.mark_selected(sender)
        locksign()
    End Sub

    Private Sub PB_arc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_arc.Click

        'MsgBox("pattern not yet implimented")
        'Return

        Me.cards_shape_Arc()
        deselectect_all_buttons()
        Form1.mark_selected(sender)
        Form1.mark_selected(Lbl_standard)
        locksign()
    End Sub


    Private Sub But_shape_revarch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_shape_revarch.Click
        cards_shape_ReverseArc()

        'Form1.positionandsizecards()
        selectedpattern = card_pattern_type.Rev_arc
        cards_locked = True
        deselectect_all_buttons()
        Form1.mark_selected(sender)

    End Sub

    Private Function cardsoverlaping() As Boolean
        'temporarily abandoned because an easier way to accomplish what needed



        'as a short cut test 1-2, 2-3,3-4 etc instaed of every possible combination

        'we get the four corners of the second litecard in the comparison
        'from these 4 corners we obtain the max and minimum values of x and y of the second card

        'we then test 5 poins of the first card (4 corners and center) to determine if between max and min

        Dim corners As PointF() = LiteCard1.corners


        Dim xmin As Single
        Dim xmax As Single
        Dim ymin As Single
        Dim ymax As Single



        Dim cardrectangle As System.Drawing.Rectangle = New Rectangle()

    End Function
    Enum pattern
        none
        horrLine
        vertLine
        diagDownLine
        diagUpLine
        arch
        revArch
        sCurve
        mCurve
    End Enum
    Private Function maxfontsize(Optional ByVal patt As pattern = pattern.none, Optional ByVal cardcount As Int16 = -1) As Single
        If patt = pattern.none Then
            If Form1.is_selected(PB_horr_line) Then
                patt = pattern.horrLine

            ElseIf Form1.is_selected(PB_rev_arc) Then
                patt = pattern.revArch
            ElseIf Form1.is_selected(PB_s_curve) Then
                patt = pattern.sCurve
            ElseIf Form1.is_selected(PB_diagup_line) Then
                patt = pattern.diagUpLine
            ElseIf Form1.is_selected(PB_vert_line) Then
                patt = pattern.vertLine
            ElseIf Form1.is_selected(PB_arc) Then
                patt = pattern.arch
            ElseIf Form1.is_selected(PB_m_curve) Then
                'this shape is not yet implimented 
                'button should never be selected
                patt = pattern.mCurve
            ElseIf Form1.is_selected(PB_diagdown_line) Then
                patt = pattern.diagDownLine


            Else
                'no patterns currently selected
                'do nothing

            End If
            'detect pattern from highlited button

        End If
        If cardcount = -1 Then
            cardcount = Form1.linelength
        End If

        'above this poit deals with detecting values if defual passed
        'from here down is atual functionality


        If patt = pattern.revArch Then
            If cardcount <= 4 Then
                Return 103.83
            ElseIf cardcount = 5 Then
                Return 84.52
            ElseIf cardcount = 6 Then
                Return 70.9
            ElseIf cardcount = 7 Then
                Return 61.61
            ElseIf cardcount = 8 Then
                Return 54.05
            ElseIf cardcount = 9 Then
                Return 48.4
            ElseIf cardcount = 10 Then
                Return 43.78
            ElseIf cardcount = 11 Then
                Return 39.79
            ElseIf cardcount = 12 Then
                Return 36.78
            ElseIf cardcount = 13 Then
                Return 33.89
            ElseIf cardcount = 14 Then
                Return 31.58
            ElseIf cardcount = 15 Then
                Return 29.44
            ElseIf cardcount >= 16 Then
                Return 27.71
            End If


        End If


        If patt = pattern.diagUpLine Then
            If cardcount <= 4 Then
                Return 99.5
            ElseIf cardcount = 5 Then
                Return 94.0
            ElseIf cardcount = 6 Then
                Return 74.2
            ElseIf cardcount = 7 Then
                Return 71.0
            ElseIf cardcount = 8 Then
                Return 58.5
            ElseIf cardcount = 9 Then
                Return 57.0
            ElseIf cardcount = 10 Then
                Return 49.2
            ElseIf cardcount = 11 Then
                Return 47.6
            ElseIf cardcount = 12 Then
                Return 41.4
            ElseIf cardcount = 13 Then
                Return 40.5
            ElseIf cardcount = 14 Then
                Return 36.7
            ElseIf cardcount = 15 Then
                Return 35.1
            ElseIf cardcount >= 16 Then
                Return 32.1
            End If


        End If


        If patt = pattern.sCurve Then
            If cardcount <= 4 Then
                Return 114.4
            ElseIf cardcount = 5 Then
                Return 96.2
            ElseIf cardcount = 6 Then
                Return 82.0
            ElseIf cardcount = 7 Then
                Return 71.6
            ElseIf cardcount = 8 Then
                Return 63.5
            ElseIf cardcount = 9 Then
                Return 56.9
            ElseIf cardcount = 10 Then
                Return 51.5
            ElseIf cardcount = 11 Then
                Return 47.0
            ElseIf cardcount = 12 Then
                Return 43.2
            ElseIf cardcount = 13 Then
                Return 40.1
            ElseIf cardcount = 14 Then
                Return 37.2
            ElseIf cardcount = 15 Then
                Return 34.9
            ElseIf cardcount >= 16 Then
                Return 32.7
            End If

        End If

    End Function

    Public Sub cards_shape_ReverseArc()
        'card size is fixed
        'in this function start and end angle is fixed

        'radius is caluclated to the scaled space between cards
        'location for center of arc is calculated to center the arc on the form


        'REALCARDWIDTH()


        If LiteCard0.FontSize > Me.maxfontsize(pattern.revArch, Form1.linelength) Then
            LiteCard0.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard1.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard2.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard3.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard4.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard5.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard6.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard7.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard8.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard9.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard10.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard11.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard12.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard13.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard14.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard15.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            LiteCard16.FontSize = Me.maxfontsize(pattern.revArch, Form1.linelength)
            'CFM



        End If




        Dim usedspacebetweencards As Single = MAX_REALSPACEBETWEENCARDS







        usedspacebetweencards /= 0.99 'first time through loop starting value




        Do

            usedspacebetweencards *= 0.9

            'Dim longestdimension As Int16 = LiteCard0.Width
            'If LiteCard0.Height > longestdimension Then
            '    longestdimension = LiteCard0.Height
            'End If


            If usedspacebetweencards < 1 Then ' then Or (LiteCard0.location.X < 0 And longestdimension < -LiteCard0.location.X) Then

                'the light cards can not fit in the display area
                'make sign smaller and retry from beginning




                'zoom out multiple times because loop was taking too long


                'Dim timestozoombig As Single = -2 * LiteCard0.location.X / longestdimension

                'Dim loopcounter As Single = 0.1
                'While loopcounter < timestozoombig

                '    Me.signZoomOutBig()
                '    loopcounter += 1
                'End While

                'If timestozoombig <= 0.1 Then

                Me.signZoomOutSmall()
                Me.signZoomOutSmall()

                'End If

                usedspacebetweencards = MAX_REALSPACEBETWEENCARDS

            End If






            Dim cheatspace As Int16 = 0 'instead if calculating distance from connector 
            'or corners, I am calculating from center of card with a cheet factor
            Dim scale = LiteCard0.cardwidth / REALCARDWIDTH
            Dim startangle As Single = 145







            Dim centerofform As PointF = New PointF(Pan_cards.Width / 2, Pan_cards.Height / 2)

            Dim endangle As Single = 90 - (startangle - 90)
            Dim angle_step As Single = (startangle - endangle) / (Form1.settings(Form1.settingsindex.linelength) - 1)
            Dim stepangleinradians = angle_step * Math.PI / 180
            Dim startangleinradians As Single = startangle * Math.PI / 180

            ''''''





            ''''''
            'calculated so that the space between cards is correct
            Dim archradius = scale * (REALCARDWIDTH + MAX_REALSPACEBETWEENCARDS + cheatspace) / (2 * Math.Sin(stepangleinradians / 2))


            ''''''calculate center of arc so that the arc is centered''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            'calculate the center of the form in relation 
            'to using the center of the arc as origen 
            'x is 0
            'y is halfway between the y coordinates of angle 0  and start(or stop) angle 
            'yof angle 0 is radius


            Dim y_startangle As Single = archradius * Math.Sin(startangleinradians)

            Dim y_middleofform As Single = (-archradius - y_startangle) / 2

            Dim centerofarch As PointF = New Point(centerofform.X, centerofform.Y + y_middleofform)

            ''''draw arc ''''''''''
            '''''''''''''''''''''''

            angle_step = -angle_step
            Dim curr_angle = startangle

            LiteCard0.DoNotRedraw = True
            LiteCard1.DoNotRedraw = True
            LiteCard2.DoNotRedraw = True
            LiteCard3.DoNotRedraw = True
            LiteCard4.DoNotRedraw = True
            LiteCard5.DoNotRedraw = True
            LiteCard6.DoNotRedraw = True
            LiteCard7.DoNotRedraw = True

            LiteCard8.DoNotRedraw = True
            LiteCard9.DoNotRedraw = True
            LiteCard10.DoNotRedraw = True
            LiteCard11.DoNotRedraw = True
            LiteCard12.DoNotRedraw = True
            LiteCard13.DoNotRedraw = True
            LiteCard14.DoNotRedraw = True
            LiteCard15.DoNotRedraw = True
            LiteCard16.DoNotRedraw = True
            'CFM

            LiteCard0.PositionInArk(centerofarch, archradius, curr_angle)
            curr_angle += angle_step
            LiteCard1.PositionInArk(centerofarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard2.PositionInArk(centerofarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard3.PositionInArk(centerofarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard4.PositionInArk(centerofarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard5.PositionInArk(centerofarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard6.PositionInArk(centerofarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard7.PositionInArk(centerofarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard8.PositionInArk(centerofarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard9.PositionInArk(centerofarch, archradius, curr_angle)

            curr_angle += angle_step

            LiteCard10.PositionInArk(centerofarch, archradius, curr_angle)
            curr_angle += angle_step
            LiteCard11.PositionInArk(centerofarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard12.PositionInArk(centerofarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard13.PositionInArk(centerofarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard14.PositionInArk(centerofarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard15.PositionInArk(centerofarch, archradius, curr_angle)

            curr_angle += angle_step
            LiteCard16.PositionInArk(centerofarch, archradius, curr_angle)
            'CFM

        Loop Until (Me.cardswithinviewingarea)


        'MsgBox(LiteCard0.FontSize) 'used in debugging to determine max font size bassed on number of cards

        LiteCard0.DoNotRedraw = False

        LiteCard1.DoNotRedraw = False
        LiteCard2.DoNotRedraw = False
        LiteCard3.DoNotRedraw = False
        LiteCard4.DoNotRedraw = False
        LiteCard5.DoNotRedraw = False
        LiteCard6.DoNotRedraw = False
        LiteCard7.DoNotRedraw = False

        LiteCard8.DoNotRedraw = False
        LiteCard9.DoNotRedraw = False

        LiteCard10.DoNotRedraw = False
        LiteCard11.DoNotRedraw = False
        LiteCard12.DoNotRedraw = False
        LiteCard13.DoNotRedraw = False
        LiteCard14.DoNotRedraw = False
        LiteCard15.DoNotRedraw = False
        LiteCard16.DoNotRedraw = False
        'CFM

        Form1.positionandsizecards()
        Timer_delayed_invalidate.Start()


    End Sub

    Private Sub PB_vert_line_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_vert_line.Click

        If Form1.linelength > 11 Then
            MsgBox("Due to space, pattern not possble with > 11 cards")
            Return
        End If
        cards_shape_vert_line()

        curr_clickmode = clickmodes.none

        ret_clickmode = clickmodes.none 'returned to when esc is pressed
        deselectect_all_buttons()
        Form1.mark_selected(sender)

        locksign()


    End Sub

    Private Sub PB_s_curve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_s_curve.Click
        cards_shape_Scurve()

        curr_clickmode = clickmodes.none

        ret_clickmode = clickmodes.none 'returned to when esc is pressed
        deselectect_all_buttons()
        Form1.mark_selected(sender)

        locksign()

    End Sub

    Private Sub PB_rev_L_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_m_curve.Click
        MsgBox("pattern not yet implimented")

        Return

    End Sub

    Private Sub PB_diagup_line_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_diagup_line.Click

        cards_shape_diagup_line()
        curr_clickmode = clickmodes.none

        ret_clickmode = clickmodes.none 'returned to when esc is pressed
        deselectect_all_buttons()
        Form1.mark_selected(sender)

        locksign()
    End Sub


    Private Sub PB_L_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_diagdown_line.Click
        cards_shape_diagdown_line()
        curr_clickmode = clickmodes.none

        ret_clickmode = clickmodes.none 'returned to when esc is pressed
        deselectect_all_buttons()
        Form1.mark_selected(sender)

        locksign()


    End Sub

    Private Sub ContextMen_litecards_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMen_litecards.Opening

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Timer_delayed_show_cards_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_delayed_show_cards.Tick
        Timer_delayed_show_cards.Stop()
        Form1.set_cardCount(Form1.settings(Form1.settingsindex.linelength))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim centerofform As PointF = New PointF(Me.Pan_dislpayregion.Width / 2, (Me.Pan_dislpayregion.Height - StatusStrip.Height) / 2)


        'LiteCard0.r()
        LiteCard0.rotateAroundPoint(centerofform, 1)
        LiteCard1.rotateAroundPoint(centerofform, 1)
        LiteCard2.rotateAroundPoint(centerofform, 1)
        LiteCard3.rotateAroundPoint(centerofform, 1)
        LiteCard4.rotateAroundPoint(centerofform, 1)
        'MsgBox(LiteCard4.location.X & "  " & LiteCard4.location.Y)
        LiteCard5.rotateAroundPoint(centerofform, 1)
        LiteCard6.rotateAroundPoint(centerofform, 1)
        LiteCard7.rotateAroundPoint(centerofform, 1)
        LiteCard8.rotateAroundPoint(centerofform, 1)
        LiteCard9.rotateAroundPoint(centerofform, 1)

        LiteCard10.rotateAroundPoint(centerofform, 1)
        LiteCard11.rotateAroundPoint(centerofform, 1)
        LiteCard12.rotateAroundPoint(centerofform, 1)
        LiteCard13.rotateAroundPoint(centerofform, 1)
        LiteCard14.rotateAroundPoint(centerofform, 1)
        'MsgBox(LiteCard4.location.X & "  " & LiteCard4.location.Y)
        LiteCard15.rotateAroundPoint(centerofform, 1)
        LiteCard16.rotateAroundPoint(centerofform, 1)
        'CFm



        Timer_delayed_invalidate.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim centerofform As PointF = New PointF(Me.Pan_dislpayregion.Width / 2, (Me.Pan_dislpayregion.Height - StatusStrip.Height) / 2)


        'LiteCard0.r()
        LiteCard0.rotateAroundPoint(centerofform, -1)
        LiteCard1.rotateAroundPoint(centerofform, -1)
        LiteCard2.rotateAroundPoint(centerofform, -1)
        LiteCard3.rotateAroundPoint(centerofform, -1)
        LiteCard4.rotateAroundPoint(centerofform, -1)
        'MsgBox(LiteCard4.location.X & "  " & LiteCard4.location.Y)
        LiteCard5.rotateAroundPoint(centerofform, -1)
        LiteCard6.rotateAroundPoint(centerofform, -1)
        LiteCard7.rotateAroundPoint(centerofform, -1)
        LiteCard8.rotateAroundPoint(centerofform, -1)
        LiteCard9.rotateAroundPoint(centerofform, -1)

        LiteCard10.rotateAroundPoint(centerofform, -1)
        LiteCard11.rotateAroundPoint(centerofform, -1)
        LiteCard12.rotateAroundPoint(centerofform, -1)
        LiteCard13.rotateAroundPoint(centerofform, -1)
        LiteCard14.rotateAroundPoint(centerofform, -1)
        'MsgBox(LiteCard4.location.X & "  " & LiteCard4.location.Y)
        LiteCard15.rotateAroundPoint(centerofform, -1)
        LiteCard16.rotateAroundPoint(centerofform, -1)
        'CFM


        Timer_delayed_invalidate.Start()
    End Sub


    Public Sub Repositioncardsafterchangingcount()



        'reposition lite cards bassed on pattern previously selected by user
        If Form1.is_selected(PB_horr_line) Then
            Me.cards_shape_HorLine()

        ElseIf Form1.is_selected(PB_rev_arc) Then
            Me.cards_shape_ReverseArc()
        ElseIf Form1.is_selected(PB_s_curve) Then
            Me.cards_shape_Scurve()
        ElseIf Form1.is_selected(PB_diagup_line) Then
            Me.cards_shape_diagup_line()
        ElseIf Form1.is_selected(PB_vert_line) Then

            If Form1.linelength <= 11 Then
                Me.cards_shape_vert_line()
            Else
                'due to space this pattern does not fit with > 11 cards
                Form1.mark_unselected(PB_vert_line)
            End If


        ElseIf Form1.is_selected(PB_arc) Then
            Me.cards_shape_Arc()
        ElseIf Form1.is_selected(PB_m_curve) Then
            'this shape is not yet implimented 
            'button should never be selected
        ElseIf Form1.is_selected(PB_diagdown_line) Then
            Me.cards_shape_diagdown_line()


        Else
            'no patterns currently selected
            'do nothing

        End If









    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LiteCard0.character = Form1.LiteCard0.character
        LiteCard1.character = Form1.LiteCard1.character
        LiteCard2.character = Form1.LiteCard2.character
        LiteCard3.character = Form1.LiteCard3.character

    End Sub
End Class