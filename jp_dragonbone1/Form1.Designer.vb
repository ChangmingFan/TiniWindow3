<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.Timer_pole_active_string = New System.Windows.Forms.Timer(Me.components)
        Me.BGW_read_device = New System.ComponentModel.BackgroundWorker()
        Me.BGW_write_device = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.men_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.men_new = New System.Windows.Forms.ToolStripMenuItem()
        Me.men_open = New System.Windows.Forms.ToolStripMenuItem()
        Me.men_open_default = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.men_save = New System.Windows.Forms.ToolStripMenuItem()
        Me.men_saveas = New System.Windows.Forms.ToolStripMenuItem()
        Me.men_make_default = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.men_import_tricks = New System.Windows.Forms.ToolStripMenuItem()
        Me.men_export_tricks = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.men_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FriendsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiniliteWorldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OthersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShareTricksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WatchVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.men_device = New System.Windows.Forms.ToolStripMenuItem()
        Me.men_write_device = New System.Windows.Forms.ToolStripMenuItem()
        Me.men_read_device = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.men_select_comport = New System.Windows.Forms.ToolStripMenuItem()
        Me.USBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OneSignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WirelessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OneSignToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultipleSignsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InternetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OneSignToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultipleSignsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.men_editmode = New System.Windows.Forms.ToolStripMenuItem()
        Me.men_monitormode = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.SimulatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.men_configure_internet = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigureRemoteSignsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.men_tools = New System.Windows.Forms.ToolStripMenuItem()
        Me.Men_settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignSimulatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyColorPatternLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_openlibrary = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_mypattern0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_mypattern1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_mypattern2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_mypattern3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_mypattern4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_mypattern5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_mypattern6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_mypattern7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_mypattern8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_mypattern9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorTemplatesForTheSignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_colorpattern0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_colorpattern1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_colorpattern2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_colorpattern3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_colorpattern4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_colorpattern5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_colorpattern6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_colorpattern7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_colorpattern8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_colorpattern9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.men_help_strip = New System.Windows.Forms.ToolStripMenuItem()
        Me.men_help_go = New System.Windows.Forms.ToolStripMenuItem()
        Me.GettingStartedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportAProblemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTiniWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.men_products = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_footer_change = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_footer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_directory = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lb = New System.Windows.Forms.Label()
        Me.Tim_clock = New System.Windows.Forms.Timer(Me.components)
        Me.Pan_edit = New System.Windows.Forms.Panel()
        Me.Pan_Woodbackground = New System.Windows.Forms.Panel()
        Me.Pan_Design = New System.Windows.Forms.Panel()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tab_FreeStyle = New System.Windows.Forms.TabPage()
        Me.Lbl_freestyle_sequencetime = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.HSB_speed_freestyletab = New System.Windows.Forms.HScrollBar()
        Me.PB_horse_freestyletab = New System.Windows.Forms.PictureBox()
        Me.PB_snail_freestyletab = New System.Windows.Forms.PictureBox()
        Me.Lbl_freestyle_linetime = New System.Windows.Forms.Label()
        Me.NUD_cardcount_freestyletab = New System.Windows.Forms.NumericUpDown()
        Me.TxtFreeStyle = New System.Windows.Forms.TextBox()
        Me.Tab_Lines = New System.Windows.Forms.TabPage()
        Me.Pan_tb = New System.Windows.Forms.Panel()
        Me.Lbl_lines_sequencetime = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.HSB_speed_linestab = New System.Windows.Forms.HScrollBar()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.NUD_linestab_liinecounts = New System.Windows.Forms.NumericUpDown()
        Me.Lbl_lines_linetime = New System.Windows.Forms.Label()
        Me.Pic_textdatadown10 = New System.Windows.Forms.PictureBox()
        Me.NUD_lines_cardcount = New System.Windows.Forms.NumericUpDown()
        Me.Pic_textdataup10 = New System.Windows.Forms.PictureBox()
        Me.Lbl_pattern_type = New System.Windows.Forms.Label()
        Me.Lbl_textdatabottom = New System.Windows.Forms.Label()
        Me.Lbl_textdatadown1 = New System.Windows.Forms.Label()
        Me.lbl_textdatatop = New System.Windows.Forms.Label()
        Me.Lbl_textdataup1 = New System.Windows.Forms.Label()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.TB0 = New System.Windows.Forms.TextBox()
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.TB2 = New System.Windows.Forms.TextBox()
        Me.TB3 = New System.Windows.Forms.TextBox()
        Me.TB4 = New System.Windows.Forms.TextBox()
        Me.TB5 = New System.Windows.Forms.TextBox()
        Me.TB6 = New System.Windows.Forms.TextBox()
        Me.TB7 = New System.Windows.Forms.TextBox()
        Me.TB8 = New System.Windows.Forms.TextBox()
        Me.TB9 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tab_Easy = New System.Windows.Forms.TabPage()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Lbl_easy_sequencetime = New System.Windows.Forms.Label()
        Me.Lbl_easy_linetime = New System.Windows.Forms.Label()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Lbl_MyKeyword = New System.Windows.Forms.Label()
        Me.Pan_keyword_background = New System.Windows.Forms.Panel()
        Me.Txt_keyword = New System.Windows.Forms.TextBox()
        Me.TXTdebug = New System.Windows.Forms.TextBox()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.PB_horse_easytab = New System.Windows.Forms.PictureBox()
        Me.PB_snail_easytab = New System.Windows.Forms.PictureBox()
        Me.NUD_cardcount_easytab = New System.Windows.Forms.NumericUpDown()
        Me.HSB_speed_easytab = New System.Windows.Forms.HScrollBar()
        Me.RB_pat_random = New System.Windows.Forms.RadioButton()
        Me.RB_pat_zoom = New System.Windows.Forms.RadioButton()
        Me.Lbl_lightcards = New System.Windows.Forms.Label()
        Me.RB_pat_Constant = New System.Windows.Forms.RadioButton()
        Me.RB_pat_AddOn = New System.Windows.Forms.RadioButton()
        Me.RB_pat_BlinkFast = New System.Windows.Forms.RadioButton()
        Me.RB_pat_BlinkSlow = New System.Windows.Forms.RadioButton()
        Me.RB_pat_Dance = New System.Windows.Forms.RadioButton()
        Me.RB_pat_SplitOut = New System.Windows.Forms.RadioButton()
        Me.RB_pat_JoinIn = New System.Windows.Forms.RadioButton()
        Me.RB_pat_FlowLeft = New System.Windows.Forms.RadioButton()
        Me.RB_pat_FlowRight = New System.Windows.Forms.RadioButton()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Pan_internet_connection = New System.Windows.Forms.Panel()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Lbl_internet_sign = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.But_debug = New System.Windows.Forms.Button()
        Me.Pan_USBBase = New System.Windows.Forms.Panel()
        Me.Lbl_uabnotfound = New System.Windows.Forms.Label()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Pan_coonnect_menu = New System.Windows.Forms.Panel()
        Me.men_connect = New System.Windows.Forms.MenuStrip()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Lbl_UserManual = New System.Windows.Forms.Label()
        Me.Pan_dialog = New System.Windows.Forms.Panel()
        Me.Pan_sever_filebuttons = New System.Windows.Forms.Panel()
        Me.But_server_savefile = New System.Windows.Forms.Button()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Pan_dialog_mascot = New System.Windows.Forms.Panel()
        Me.But_server_openfile = New System.Windows.Forms.Button()
        Me.But_send = New System.Windows.Forms.Button()
        Me.But_get = New System.Windows.Forms.Button()
        Me.pan_chalkboard = New System.Windows.Forms.Panel()
        Me.Pan_boardviewingarea = New System.Windows.Forms.Panel()
        Me.Pan_noServer = New System.Windows.Forms.Panel()
        Me.lbl_999 = New System.Windows.Forms.Label()
        Me.Pan_internetNodes = New System.Windows.Forms.Panel()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Pan_server_no_signs = New System.Windows.Forms.Panel()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Node_internet3 = New jp_dragonbone1.node()
        Me.Node_internet1 = New jp_dragonbone1.node()
        Me.Node_internet2 = New jp_dragonbone1.node()
        Me.Pan_comBase = New System.Windows.Forms.Panel()
        Me.AIV_Internet = New jp_dragonbone1.animatedimageviewer()
        Me.lbl_internet_text = New System.Windows.Forms.Label()
        Me.AIV_Zigbee = New jp_dragonbone1.animatedimageviewer()
        Me.Lbl_zigbee_text = New System.Windows.Forms.Label()
        Me.AIV_USB = New jp_dragonbone1.animatedimageviewer()
        Me.Lbl_USB_text = New System.Windows.Forms.Label()
        Me.Pan_USBnodes = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Pan_noUSBFound = New System.Windows.Forms.Panel()
        Me.Pan_wirelessBaseNoSigns = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Node_usb5 = New jp_dragonbone1.node()
        Me.Node_usb4 = New jp_dragonbone1.node()
        Me.Node_usb3 = New jp_dragonbone1.node()
        Me.Node_usb2 = New jp_dragonbone1.node()
        Me.Node_usb1 = New jp_dragonbone1.node()
        Me.Pan_wirelessnodes = New System.Windows.Forms.Panel()
        Me.Pan_noWireless = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Node_wireless3 = New jp_dragonbone1.node()
        Me.Node_wireless2 = New jp_dragonbone1.node()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Node_wireless1 = New jp_dragonbone1.node()
        Me.Node_wireless5 = New jp_dragonbone1.node()
        Me.Node_wireless4 = New jp_dragonbone1.node()
        Me.Lbl_availablelines = New System.Windows.Forms.Label()
        Me.LBL_linecount = New System.Windows.Forms.Label()
        Me.Lbl_dialog = New System.Windows.Forms.Label()
        Me.Pan_bluetabs = New System.Windows.Forms.Panel()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pan_demooption_multiline = New System.Windows.Forms.Panel()
        Me.Lbl_demooption_multiline = New System.Windows.Forms.Label()
        Me.Pan_demooption_oneline = New System.Windows.Forms.Panel()
        Me.Lbl_demooption_oneline = New System.Windows.Forms.Label()
        Me.Pan_demo_lines = New System.Windows.Forms.Panel()
        Me.Pan_demo_multiline = New System.Windows.Forms.Panel()
        Me.Lbl_demoline0 = New System.Windows.Forms.Label()
        Me.Txt_demoline8 = New System.Windows.Forms.TextBox()
        Me.Pan_totaltime = New System.Windows.Forms.Panel()
        Me.lbl_totaltime = New System.Windows.Forms.Label()
        Me.Lbl_demoline1 = New System.Windows.Forms.Label()
        Me.Lbl_demoline3 = New System.Windows.Forms.Label()
        Me.Lbl_demoline2 = New System.Windows.Forms.Label()
        Me.Lbl_demoline4 = New System.Windows.Forms.Label()
        Me.Lbl_demoline9 = New System.Windows.Forms.Label()
        Me.Lbl_demoline8 = New System.Windows.Forms.Label()
        Me.Lbl_demoline7 = New System.Windows.Forms.Label()
        Me.Lbl_demoline5 = New System.Windows.Forms.Label()
        Me.Lbl_demoline6 = New System.Windows.Forms.Label()
        Me.Txt_demoline0 = New System.Windows.Forms.TextBox()
        Me.Txt_demoline1 = New System.Windows.Forms.TextBox()
        Me.Txt_demoline2 = New System.Windows.Forms.TextBox()
        Me.Txt_demoline3 = New System.Windows.Forms.TextBox()
        Me.Txt_demoline4 = New System.Windows.Forms.TextBox()
        Me.Txt_demoline5 = New System.Windows.Forms.TextBox()
        Me.Txt_demoline6 = New System.Windows.Forms.TextBox()
        Me.Txt_demoline7 = New System.Windows.Forms.TextBox()
        Me.Txt_demoline9 = New System.Windows.Forms.TextBox()
        Me.Pan_demo_oneline = New System.Windows.Forms.Panel()
        Me.But_shape_revarch = New System.Windows.Forms.Button()
        Me.But_shape_arch = New System.Windows.Forms.Button()
        Me.Pan_cardbackground = New System.Windows.Forms.Panel()
        Me.LiteCard19 = New jp_dragonbone1.LiteCard()
        Me.ContextMen_litecards = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmi_bigclockwise = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmi_smallclockwise = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmi_bigcounterclockwise = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmi_smallcounterclockwise = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiteCard18 = New jp_dragonbone1.LiteCard()
        Me.LiteCard17 = New jp_dragonbone1.LiteCard()
        Me.LiteCard16 = New jp_dragonbone1.LiteCard()
        Me.LiteCard10 = New jp_dragonbone1.LiteCard()
        Me.LiteCard11 = New jp_dragonbone1.LiteCard()
        Me.LiteCard12 = New jp_dragonbone1.LiteCard()
        Me.LiteCard13 = New jp_dragonbone1.LiteCard()
        Me.LiteCard14 = New jp_dragonbone1.LiteCard()
        Me.LiteCard15 = New jp_dragonbone1.LiteCard()
        Me.LiteCard1 = New jp_dragonbone1.LiteCard()
        Me.LiteCard9 = New jp_dragonbone1.LiteCard()
        Me.LiteCard0 = New jp_dragonbone1.LiteCard()
        Me.LiteCard8 = New jp_dragonbone1.LiteCard()
        Me.LiteCard2 = New jp_dragonbone1.LiteCard()
        Me.LiteCard7 = New jp_dragonbone1.LiteCard()
        Me.LiteCard3 = New jp_dragonbone1.LiteCard()
        Me.LiteCard6 = New jp_dragonbone1.LiteCard()
        Me.LiteCard4 = New jp_dragonbone1.LiteCard()
        Me.LiteCard5 = New jp_dragonbone1.LiteCard()
        Me.But_shape_straight = New System.Windows.Forms.Button()
        Me.Txt_demo_oneline = New System.Windows.Forms.TextBox()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.Lbl_catdown = New System.Windows.Forms.Label()
        Me.pan_cat2 = New System.Windows.Forms.Panel()
        Me.Lbl_cat2 = New System.Windows.Forms.Label()
        Me.LBL_catup = New System.Windows.Forms.Label()
        Me.Pan_cat1 = New System.Windows.Forms.Panel()
        Me.Lbl_cat1 = New System.Windows.Forms.Label()
        Me.But_selectvideo = New System.Windows.Forms.Button()
        Me.CB_videolist = New System.Windows.Forms.ComboBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.pan_no_pictures = New System.Windows.Forms.Panel()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Pan_pictureselect_buttons1 = New System.Windows.Forms.Panel()
        Me.But_prev_picture = New System.Windows.Forms.Button()
        Me.Pan_pictureselect_buttons2 = New System.Windows.Forms.Panel()
        Me.But_next_picture = New System.Windows.Forms.Button()
        Me.Pan_pictureselect_menu = New System.Windows.Forms.Panel()
        Me.CB_pictures = New System.Windows.Forms.ComboBox()
        Me.Panel35 = New System.Windows.Forms.Panel()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.pan_picture_select_buttons = New System.Windows.Forms.Panel()
        Me.lbl_picture_select_buttons = New System.Windows.Forms.Label()
        Me.pan_picture_select_menu = New System.Windows.Forms.Panel()
        Me.lbl_picture_select_menu = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Pan_Control = New System.Windows.Forms.Panel()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.But_connect = New System.Windows.Forms.Button()
        Me.Pan_beginners_help = New System.Windows.Forms.Panel()
        Me.Pan_Usermanuel_small = New System.Windows.Forms.Panel()
        Me.PDFview_usermanuel_small = New AxAcroPDFLib.AxAcroPDF()
        Me.TB_monitor_comm_error = New System.Windows.Forms.TextBox()
        Me.But_hide_pan_beginners = New System.Windows.Forms.Button()
        Me.pan_filerestrictions = New System.Windows.Forms.Panel()
        Me.Button_discard_tricks = New System.Windows.Forms.Button()
        Me.lbl_filerestrictions = New System.Windows.Forms.Label()
        Me.But_listchildren = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TB_pan_morelines_speed = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Pan_showclock = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LBL_time = New System.Windows.Forms.Label()
        Me.CB_clockoptions = New System.Windows.Forms.ComboBox()
        Me.CB_monitor_active_trick = New System.Windows.Forms.ComboBox()
        Me.Pan_monitor_comm_error = New System.Windows.Forms.Panel()
        Me.But_retrycommunication = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer_demo = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.timer_monitor_ifdoubleclickmanuel = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.WebBrowser3 = New System.Windows.Forms.WebBrowser()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.junk9 = New System.Windows.Forms.Panel()
        Me.junk6 = New System.Windows.Forms.Button()
        Me.junk1 = New System.Windows.Forms.Panel()
        Me.junk5 = New System.Windows.Forms.Button()
        Me.junk14 = New System.Windows.Forms.Panel()
        Me.junk7 = New System.Windows.Forms.ComboBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.junk10 = New System.Windows.Forms.Panel()
        Me.junk4 = New System.Windows.Forms.Label()
        Me.junk12 = New System.Windows.Forms.Panel()
        Me.junk8 = New System.Windows.Forms.Label()
        Me.junk2 = New System.Windows.Forms.PictureBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.WebBrowser4 = New System.Windows.Forms.WebBrowser()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.junk3 = New System.Windows.Forms.PictureBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Timer_formloaded = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_setkeyword_cursor = New System.Windows.Forms.Timer(Me.components)
        Me.Tim_finish_horr_line = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_delayed_invalidate = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_delayed_finish_pattern_line = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenu_combokeywords = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Menu_comboallignment = New System.Windows.Forms.ToolStripMenuItem()
        Me.Men_combokeywordallign_none = New System.Windows.Forms.ToolStripMenuItem()
        Me.Men_combokeywordallign_left = New System.Windows.Forms.ToolStripMenuItem()
        Me.Men_combokeywordallign_center = New System.Windows.Forms.ToolStripMenuItem()
        Me.Men_combokeywordallign_right = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.Men_combo_allowexceedwordlength = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_flagwatchdog = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_refreshSignMenue = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_closeconnectdropdown = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_showhide_connectcablemessage = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_showhide_mustselectconnectionmessage = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Pan_edit.SuspendLayout()
        Me.Pan_Woodbackground.SuspendLayout()
        Me.Pan_Design.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Tab_FreeStyle.SuspendLayout()
        CType(Me.PB_horse_freestyletab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_snail_freestyletab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_cardcount_freestyletab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Lines.SuspendLayout()
        Me.Pan_tb.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_linestab_liinecounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_textdatadown10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_lines_cardcount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_textdataup10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Easy.SuspendLayout()
        Me.Panel32.SuspendLayout()
        Me.Pan_keyword_background.SuspendLayout()
        CType(Me.PB_horse_easytab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_snail_easytab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_cardcount_easytab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pan_internet_connection.SuspendLayout()
        Me.Pan_USBBase.SuspendLayout()
        Me.Panel34.SuspendLayout()
        Me.Pan_coonnect_menu.SuspendLayout()
        Me.Panel33.SuspendLayout()
        Me.Pan_dialog.SuspendLayout()
        Me.Pan_sever_filebuttons.SuspendLayout()
        Me.pan_chalkboard.SuspendLayout()
        Me.Pan_boardviewingarea.SuspendLayout()
        Me.Pan_noServer.SuspendLayout()
        Me.Pan_internetNodes.SuspendLayout()
        Me.Pan_server_no_signs.SuspendLayout()
        Me.Pan_comBase.SuspendLayout()
        Me.AIV_Internet.SuspendLayout()
        Me.AIV_Zigbee.SuspendLayout()
        Me.AIV_USB.SuspendLayout()
        Me.Pan_USBnodes.SuspendLayout()
        Me.Pan_noUSBFound.SuspendLayout()
        Me.Pan_wirelessBaseNoSigns.SuspendLayout()
        Me.Pan_wirelessnodes.SuspendLayout()
        Me.Pan_noWireless.SuspendLayout()
        Me.Pan_bluetabs.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Pan_demooption_multiline.SuspendLayout()
        Me.Pan_demooption_oneline.SuspendLayout()
        Me.Pan_demo_lines.SuspendLayout()
        Me.Pan_demo_multiline.SuspendLayout()
        Me.Pan_totaltime.SuspendLayout()
        Me.Pan_demo_oneline.SuspendLayout()
        Me.Pan_cardbackground.SuspendLayout()
        Me.ContextMen_litecards.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.pan_cat2.SuspendLayout()
        Me.Pan_cat1.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        Me.pan_no_pictures.SuspendLayout()
        Me.Pan_pictureselect_buttons1.SuspendLayout()
        Me.Pan_pictureselect_buttons2.SuspendLayout()
        Me.Pan_pictureselect_menu.SuspendLayout()
        Me.Panel35.SuspendLayout()
        Me.pan_picture_select_buttons.SuspendLayout()
        Me.pan_picture_select_menu.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pan_Control.SuspendLayout()
        Me.Pan_beginners_help.SuspendLayout()
        CType(Me.PDFview_usermanuel_small, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_filerestrictions.SuspendLayout()
        Me.Pan_showclock.SuspendLayout()
        Me.Pan_monitor_comm_error.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.junk9.SuspendLayout()
        Me.junk1.SuspendLayout()
        Me.junk14.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.junk10.SuspendLayout()
        Me.junk12.SuspendLayout()
        CType(Me.junk2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.Panel28.SuspendLayout()
        Me.Panel29.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.Panel31.SuspendLayout()
        CType(Me.junk3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenu_combokeywords.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer_pole_active_string
        '
        Me.Timer_pole_active_string.Interval = 1000
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.LightGray
        Me.MenuStrip.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_file, Me.ToolStripMenuItem1, Me.men_device, Me.men_tools, Me.men_help_strip, Me.ToolStripMenuItem2})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(1, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(493, 29)
        Me.MenuStrip.TabIndex = 51
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'men_file
        '
        Me.men_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_new, Me.men_open, Me.men_open_default, Me.ToolStripSeparator1, Me.men_save, Me.men_saveas, Me.men_make_default, Me.ToolStripSeparator2, Me.men_import_tricks, Me.men_export_tricks, Me.ToolStripSeparator4, Me.men_exit})
        Me.men_file.ForeColor = System.Drawing.Color.DarkBlue
        Me.men_file.Name = "men_file"
        Me.men_file.Size = New System.Drawing.Size(52, 25)
        Me.men_file.Text = "&File"
        '
        'men_new
        '
        Me.men_new.Name = "men_new"
        Me.men_new.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.men_new.Size = New System.Drawing.Size(285, 26)
        Me.men_new.Text = "&New"
        '
        'men_open
        '
        Me.men_open.Name = "men_open"
        Me.men_open.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.men_open.Size = New System.Drawing.Size(285, 26)
        Me.men_open.Text = "&Open"
        '
        'men_open_default
        '
        Me.men_open_default.Enabled = False
        Me.men_open_default.Name = "men_open_default"
        Me.men_open_default.Size = New System.Drawing.Size(285, 26)
        Me.men_open_default.Text = "Open Default File"
        Me.men_open_default.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(282, 6)
        '
        'men_save
        '
        Me.men_save.Name = "men_save"
        Me.men_save.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.men_save.Size = New System.Drawing.Size(285, 26)
        Me.men_save.Text = "&Save"
        '
        'men_saveas
        '
        Me.men_saveas.Name = "men_saveas"
        Me.men_saveas.Size = New System.Drawing.Size(285, 26)
        Me.men_saveas.Text = "Save &As"
        '
        'men_make_default
        '
        Me.men_make_default.Enabled = False
        Me.men_make_default.Name = "men_make_default"
        Me.men_make_default.Size = New System.Drawing.Size(285, 26)
        Me.men_make_default.Text = "Make &Default File"
        Me.men_make_default.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(282, 6)
        Me.ToolStripSeparator2.Visible = False
        '
        'men_import_tricks
        '
        Me.men_import_tricks.Enabled = False
        Me.men_import_tricks.Name = "men_import_tricks"
        Me.men_import_tricks.Size = New System.Drawing.Size(285, 26)
        Me.men_import_tricks.Text = "&Import Display Patterns"
        Me.men_import_tricks.Visible = False
        '
        'men_export_tricks
        '
        Me.men_export_tricks.Enabled = False
        Me.men_export_tricks.Name = "men_export_tricks"
        Me.men_export_tricks.Size = New System.Drawing.Size(285, 26)
        Me.men_export_tricks.Text = "&Export Display Patterns"
        Me.men_export_tricks.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(282, 6)
        '
        'men_exit
        '
        Me.men_exit.Name = "men_exit"
        Me.men_exit.Size = New System.Drawing.Size(285, 26)
        Me.men_exit.Text = "E&xit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FriendsToolStripMenuItem, Me.TiniliteWorldToolStripMenuItem, Me.OthersToolStripMenuItem, Me.ToolStripSeparator5, Me.ShareTricksToolStripMenuItem, Me.WatchVideoToolStripMenuItem})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkBlue
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(88, 25)
        Me.ToolStripMenuItem1.Text = "&Contact"
        '
        'FriendsToolStripMenuItem
        '
        Me.FriendsToolStripMenuItem.Enabled = False
        Me.FriendsToolStripMenuItem.Name = "FriendsToolStripMenuItem"
        Me.FriendsToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.FriendsToolStripMenuItem.Text = "Friends"
        '
        'TiniliteWorldToolStripMenuItem
        '
        Me.TiniliteWorldToolStripMenuItem.Name = "TiniliteWorldToolStripMenuItem"
        Me.TiniliteWorldToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.TiniliteWorldToolStripMenuItem.Text = "Tinilite World"
        '
        'OthersToolStripMenuItem
        '
        Me.OthersToolStripMenuItem.Enabled = False
        Me.OthersToolStripMenuItem.Name = "OthersToolStripMenuItem"
        Me.OthersToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.OthersToolStripMenuItem.Text = "Others"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(191, 6)
        '
        'ShareTricksToolStripMenuItem
        '
        Me.ShareTricksToolStripMenuItem.Enabled = False
        Me.ShareTricksToolStripMenuItem.Name = "ShareTricksToolStripMenuItem"
        Me.ShareTricksToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.ShareTricksToolStripMenuItem.Text = "&Share tricks"
        Me.ShareTricksToolStripMenuItem.Visible = False
        '
        'WatchVideoToolStripMenuItem
        '
        Me.WatchVideoToolStripMenuItem.Name = "WatchVideoToolStripMenuItem"
        Me.WatchVideoToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.WatchVideoToolStripMenuItem.Text = "watch video"
        Me.WatchVideoToolStripMenuItem.Visible = False
        '
        'men_device
        '
        Me.men_device.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_write_device, Me.men_read_device, Me.ToolStripSeparator3, Me.men_select_comport, Me.ToolStripSeparator6, Me.men_editmode, Me.men_monitormode, Me.ToolStripSeparator7, Me.SimulatorToolStripMenuItem, Me.LineConfigurationToolStripMenuItem, Me.men_configure_internet, Me.ConfigureRemoteSignsToolStripMenuItem})
        Me.men_device.ForeColor = System.Drawing.Color.DarkBlue
        Me.men_device.Name = "men_device"
        Me.men_device.Size = New System.Drawing.Size(60, 25)
        Me.men_device.Text = "&Sign"
        '
        'men_write_device
        '
        Me.men_write_device.Name = "men_write_device"
        Me.men_write_device.Size = New System.Drawing.Size(287, 26)
        Me.men_write_device.Text = "&Send Data To Sign"
        '
        'men_read_device
        '
        Me.men_read_device.Name = "men_read_device"
        Me.men_read_device.Size = New System.Drawing.Size(287, 26)
        Me.men_read_device.Text = "&Get Data From Sign"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(284, 6)
        '
        'men_select_comport
        '
        Me.men_select_comport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USBToolStripMenuItem, Me.WirelessToolStripMenuItem, Me.InternetToolStripMenuItem})
        Me.men_select_comport.Name = "men_select_comport"
        Me.men_select_comport.Size = New System.Drawing.Size(287, 26)
        Me.men_select_comport.Text = "&Connect to sign"
        '
        'USBToolStripMenuItem
        '
        Me.USBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OneSignToolStripMenuItem})
        Me.USBToolStripMenuItem.Name = "USBToolStripMenuItem"
        Me.USBToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.USBToolStripMenuItem.Text = "USB"
        '
        'OneSignToolStripMenuItem
        '
        Me.OneSignToolStripMenuItem.Name = "OneSignToolStripMenuItem"
        Me.OneSignToolStripMenuItem.Size = New System.Drawing.Size(157, 26)
        Me.OneSignToolStripMenuItem.Text = "One Sign"
        '
        'WirelessToolStripMenuItem
        '
        Me.WirelessToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OneSignToolStripMenuItem1, Me.MultipleSignsToolStripMenuItem})
        Me.WirelessToolStripMenuItem.Name = "WirelessToolStripMenuItem"
        Me.WirelessToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.WirelessToolStripMenuItem.Text = "Wireless"
        '
        'OneSignToolStripMenuItem1
        '
        Me.OneSignToolStripMenuItem1.Name = "OneSignToolStripMenuItem1"
        Me.OneSignToolStripMenuItem1.Size = New System.Drawing.Size(201, 26)
        Me.OneSignToolStripMenuItem1.Text = "One Sign"
        '
        'MultipleSignsToolStripMenuItem
        '
        Me.MultipleSignsToolStripMenuItem.Name = "MultipleSignsToolStripMenuItem"
        Me.MultipleSignsToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.MultipleSignsToolStripMenuItem.Text = "Multiple Signs"
        '
        'InternetToolStripMenuItem
        '
        Me.InternetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OneSignToolStripMenuItem2, Me.MultipleSignsToolStripMenuItem1})
        Me.InternetToolStripMenuItem.Name = "InternetToolStripMenuItem"
        Me.InternetToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.InternetToolStripMenuItem.Text = "Internet"
        '
        'OneSignToolStripMenuItem2
        '
        Me.OneSignToolStripMenuItem2.Name = "OneSignToolStripMenuItem2"
        Me.OneSignToolStripMenuItem2.Size = New System.Drawing.Size(201, 26)
        Me.OneSignToolStripMenuItem2.Text = "One Sign"
        '
        'MultipleSignsToolStripMenuItem1
        '
        Me.MultipleSignsToolStripMenuItem1.Name = "MultipleSignsToolStripMenuItem1"
        Me.MultipleSignsToolStripMenuItem1.Size = New System.Drawing.Size(201, 26)
        Me.MultipleSignsToolStripMenuItem1.Text = "Multiple Signs"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(284, 6)
        Me.ToolStripSeparator6.Visible = False
        '
        'men_editmode
        '
        Me.men_editmode.Checked = True
        Me.men_editmode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.men_editmode.Enabled = False
        Me.men_editmode.Name = "men_editmode"
        Me.men_editmode.Size = New System.Drawing.Size(287, 26)
        Me.men_editmode.Text = "Edit Mode"
        Me.men_editmode.Visible = False
        '
        'men_monitormode
        '
        Me.men_monitormode.Enabled = False
        Me.men_monitormode.Name = "men_monitormode"
        Me.men_monitormode.Size = New System.Drawing.Size(287, 26)
        Me.men_monitormode.Text = "Monitor Mode"
        Me.men_monitormode.Visible = False
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(284, 6)
        '
        'SimulatorToolStripMenuItem
        '
        Me.SimulatorToolStripMenuItem.Name = "SimulatorToolStripMenuItem"
        Me.SimulatorToolStripMenuItem.Size = New System.Drawing.Size(287, 26)
        Me.SimulatorToolStripMenuItem.Text = "Simulator"
        AddHandler Me.SimulatorToolStripMenuItem.Click, AddressOf Me.SimulatorToolStripMenuItem_Click
        '
        'LineConfigurationToolStripMenuItem
        '
        Me.LineConfigurationToolStripMenuItem.Name = "LineConfigurationToolStripMenuItem"
        Me.LineConfigurationToolStripMenuItem.Size = New System.Drawing.Size(287, 26)
        Me.LineConfigurationToolStripMenuItem.Text = "Line Configuration"
        Me.LineConfigurationToolStripMenuItem.Visible = False
        '
        'men_configure_internet
        '
        Me.men_configure_internet.Name = "men_configure_internet"
        Me.men_configure_internet.Size = New System.Drawing.Size(287, 26)
        Me.men_configure_internet.Text = "Configure &Internet"
        Me.men_configure_internet.Visible = False
        '
        'ConfigureRemoteSignsToolStripMenuItem
        '
        Me.ConfigureRemoteSignsToolStripMenuItem.Name = "ConfigureRemoteSignsToolStripMenuItem"
        Me.ConfigureRemoteSignsToolStripMenuItem.Size = New System.Drawing.Size(287, 26)
        Me.ConfigureRemoteSignsToolStripMenuItem.Text = "Configure &Remote Signs"
        '
        'men_tools
        '
        Me.men_tools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Men_settings, Me.SignSimulatorToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.SignColorToolStripMenuItem})
        Me.men_tools.ForeColor = System.Drawing.Color.DarkBlue
        Me.men_tools.Name = "men_tools"
        Me.men_tools.Size = New System.Drawing.Size(68, 25)
        Me.men_tools.Text = "&Tools"
        '
        'Men_settings
        '
        Me.Men_settings.Name = "Men_settings"
        Me.Men_settings.Size = New System.Drawing.Size(235, 26)
        Me.Men_settings.Text = "Settings"
        '
        'SignSimulatorToolStripMenuItem
        '
        Me.SignSimulatorToolStripMenuItem.Name = "SignSimulatorToolStripMenuItem"
        Me.SignSimulatorToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.SignSimulatorToolStripMenuItem.Text = "Sign Simulator"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for updates"
        '
        'SignColorToolStripMenuItem
        '
        Me.SignColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MyColorPatternLibraryToolStripMenuItem, Me.ColorTemplatesForTheSignToolStripMenuItem})
        Me.SignColorToolStripMenuItem.Name = "SignColorToolStripMenuItem"
        Me.SignColorToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.SignColorToolStripMenuItem.Text = "Sign Color"
        '
        'MyColorPatternLibraryToolStripMenuItem
        '
        Me.MyColorPatternLibraryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMI_openlibrary, Me.CMI_mypattern0, Me.CMI_mypattern1, Me.CMI_mypattern2, Me.CMI_mypattern3, Me.CMI_mypattern4, Me.CMI_mypattern5, Me.CMI_mypattern6, Me.CMI_mypattern7, Me.CMI_mypattern8, Me.CMI_mypattern9})
        Me.MyColorPatternLibraryToolStripMenuItem.Name = "MyColorPatternLibraryToolStripMenuItem"
        Me.MyColorPatternLibraryToolStripMenuItem.Size = New System.Drawing.Size(286, 26)
        Me.MyColorPatternLibraryToolStripMenuItem.Text = "My color pattern Library"
        '
        'CMI_openlibrary
        '
        Me.CMI_openlibrary.Name = "CMI_openlibrary"
        Me.CMI_openlibrary.Size = New System.Drawing.Size(268, 26)
        Me.CMI_openlibrary.Text = "Open my library"
        '
        'CMI_mypattern0
        '
        Me.CMI_mypattern0.Name = "CMI_mypattern0"
        Me.CMI_mypattern0.Size = New System.Drawing.Size(268, 26)
        Me.CMI_mypattern0.Text = "ToolStripMenuItem11"
        Me.CMI_mypattern0.Visible = False
        '
        'CMI_mypattern1
        '
        Me.CMI_mypattern1.Name = "CMI_mypattern1"
        Me.CMI_mypattern1.Size = New System.Drawing.Size(268, 26)
        Me.CMI_mypattern1.Text = "ToolStripMenuItem12"
        Me.CMI_mypattern1.Visible = False
        '
        'CMI_mypattern2
        '
        Me.CMI_mypattern2.Name = "CMI_mypattern2"
        Me.CMI_mypattern2.Size = New System.Drawing.Size(268, 26)
        Me.CMI_mypattern2.Text = "ToolStripMenuItem13"
        Me.CMI_mypattern2.Visible = False
        '
        'CMI_mypattern3
        '
        Me.CMI_mypattern3.Name = "CMI_mypattern3"
        Me.CMI_mypattern3.Size = New System.Drawing.Size(268, 26)
        Me.CMI_mypattern3.Text = "ToolStripMenuItem14"
        Me.CMI_mypattern3.Visible = False
        '
        'CMI_mypattern4
        '
        Me.CMI_mypattern4.Name = "CMI_mypattern4"
        Me.CMI_mypattern4.Size = New System.Drawing.Size(268, 26)
        Me.CMI_mypattern4.Text = "ToolStripMenuItem15"
        Me.CMI_mypattern4.Visible = False
        '
        'CMI_mypattern5
        '
        Me.CMI_mypattern5.Name = "CMI_mypattern5"
        Me.CMI_mypattern5.Size = New System.Drawing.Size(268, 26)
        Me.CMI_mypattern5.Text = "ToolStripMenuItem16"
        '
        'CMI_mypattern6
        '
        Me.CMI_mypattern6.Name = "CMI_mypattern6"
        Me.CMI_mypattern6.Size = New System.Drawing.Size(268, 26)
        Me.CMI_mypattern6.Text = "ToolStripMenuItem17"
        Me.CMI_mypattern6.Visible = False
        '
        'CMI_mypattern7
        '
        Me.CMI_mypattern7.Name = "CMI_mypattern7"
        Me.CMI_mypattern7.Size = New System.Drawing.Size(268, 26)
        Me.CMI_mypattern7.Text = "ToolStripMenuItem18"
        Me.CMI_mypattern7.Visible = False
        '
        'CMI_mypattern8
        '
        Me.CMI_mypattern8.Name = "CMI_mypattern8"
        Me.CMI_mypattern8.Size = New System.Drawing.Size(268, 26)
        Me.CMI_mypattern8.Text = "ToolStripMenuItem19"
        Me.CMI_mypattern8.Visible = False
        '
        'CMI_mypattern9
        '
        Me.CMI_mypattern9.Name = "CMI_mypattern9"
        Me.CMI_mypattern9.Size = New System.Drawing.Size(268, 26)
        Me.CMI_mypattern9.Text = "ToolStripMenuItem20"
        Me.CMI_mypattern9.Visible = False
        '
        'ColorTemplatesForTheSignToolStripMenuItem
        '
        Me.ColorTemplatesForTheSignToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMI_colorpattern0, Me.CMI_colorpattern1, Me.CMI_colorpattern2, Me.CMI_colorpattern3, Me.CMI_colorpattern4, Me.CMI_colorpattern5, Me.CMI_colorpattern6, Me.CMI_colorpattern7, Me.CMI_colorpattern8, Me.CMI_colorpattern9})
        Me.ColorTemplatesForTheSignToolStripMenuItem.Name = "ColorTemplatesForTheSignToolStripMenuItem"
        Me.ColorTemplatesForTheSignToolStripMenuItem.Size = New System.Drawing.Size(286, 26)
        Me.ColorTemplatesForTheSignToolStripMenuItem.Text = "Color templates"
        '
        'CMI_colorpattern0
        '
        Me.CMI_colorpattern0.Name = "CMI_colorpattern0"
        Me.CMI_colorpattern0.Size = New System.Drawing.Size(268, 26)
        Me.CMI_colorpattern0.Text = "ToolStripMenuItem4"
        '
        'CMI_colorpattern1
        '
        Me.CMI_colorpattern1.Name = "CMI_colorpattern1"
        Me.CMI_colorpattern1.Size = New System.Drawing.Size(268, 26)
        Me.CMI_colorpattern1.Text = "ToolStripMenuItem5"
        '
        'CMI_colorpattern2
        '
        Me.CMI_colorpattern2.Name = "CMI_colorpattern2"
        Me.CMI_colorpattern2.Size = New System.Drawing.Size(268, 26)
        Me.CMI_colorpattern2.Text = "ToolStripMenuItem6"
        '
        'CMI_colorpattern3
        '
        Me.CMI_colorpattern3.Name = "CMI_colorpattern3"
        Me.CMI_colorpattern3.Size = New System.Drawing.Size(268, 26)
        Me.CMI_colorpattern3.Text = "ToolStripMenuItem7"
        '
        'CMI_colorpattern4
        '
        Me.CMI_colorpattern4.Name = "CMI_colorpattern4"
        Me.CMI_colorpattern4.Size = New System.Drawing.Size(268, 26)
        Me.CMI_colorpattern4.Text = "ToolStripMenuItem8"
        '
        'CMI_colorpattern5
        '
        Me.CMI_colorpattern5.Name = "CMI_colorpattern5"
        Me.CMI_colorpattern5.Size = New System.Drawing.Size(268, 26)
        Me.CMI_colorpattern5.Text = "ToolStripMenuItem9"
        '
        'CMI_colorpattern6
        '
        Me.CMI_colorpattern6.Name = "CMI_colorpattern6"
        Me.CMI_colorpattern6.Size = New System.Drawing.Size(268, 26)
        Me.CMI_colorpattern6.Text = "ToolStripMenuItem10"
        '
        'CMI_colorpattern7
        '
        Me.CMI_colorpattern7.Name = "CMI_colorpattern7"
        Me.CMI_colorpattern7.Size = New System.Drawing.Size(268, 26)
        Me.CMI_colorpattern7.Text = "ToolStripMenuItem11"
        '
        'CMI_colorpattern8
        '
        Me.CMI_colorpattern8.Name = "CMI_colorpattern8"
        Me.CMI_colorpattern8.Size = New System.Drawing.Size(268, 26)
        Me.CMI_colorpattern8.Text = "ToolStripMenuItem12"
        '
        'CMI_colorpattern9
        '
        Me.CMI_colorpattern9.Name = "CMI_colorpattern9"
        Me.CMI_colorpattern9.Size = New System.Drawing.Size(268, 26)
        Me.CMI_colorpattern9.Text = "ToolStripMenuItem10"
        '
        'men_help_strip
        '
        Me.men_help_strip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_help_go, Me.GettingStartedToolStripMenuItem, Me.ReportAProblemToolStripMenuItem, Me.AboutTiniWindowToolStripMenuItem})
        Me.men_help_strip.ForeColor = System.Drawing.Color.DarkBlue
        Me.men_help_strip.Name = "men_help_strip"
        Me.men_help_strip.Size = New System.Drawing.Size(61, 25)
        Me.men_help_strip.Text = "&Help"
        '
        'men_help_go
        '
        Me.men_help_go.Name = "men_help_go"
        Me.men_help_go.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.men_help_go.Size = New System.Drawing.Size(238, 26)
        Me.men_help_go.Text = "Help Topics"
        '
        'GettingStartedToolStripMenuItem
        '
        Me.GettingStartedToolStripMenuItem.Name = "GettingStartedToolStripMenuItem"
        Me.GettingStartedToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.GettingStartedToolStripMenuItem.Text = "Show Quick Help"
        '
        'ReportAProblemToolStripMenuItem
        '
        Me.ReportAProblemToolStripMenuItem.Name = "ReportAProblemToolStripMenuItem"
        Me.ReportAProblemToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.ReportAProblemToolStripMenuItem.Text = "Report a problem"
        '
        'AboutTiniWindowToolStripMenuItem
        '
        Me.AboutTiniWindowToolStripMenuItem.Name = "AboutTiniWindowToolStripMenuItem"
        Me.AboutTiniWindowToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.AboutTiniWindowToolStripMenuItem.Text = "About TiniWindow"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.men_products, Me.StockToolStripMenuItem})
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.DarkBlue
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(55, 25)
        Me.ToolStripMenuItem2.Text = "Buy"
        '
        'men_products
        '
        Me.men_products.Name = "men_products"
        Me.men_products.Size = New System.Drawing.Size(156, 26)
        Me.men_products.Text = "&Products"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.StockToolStripMenuItem.Text = "&Stock"
        Me.StockToolStripMenuItem.Visible = False
        '
        'Timer_footer_change
        '
        Me.Timer_footer_change.Enabled = True
        Me.Timer_footer_change.Interval = 2000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AllowDrop = True
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_footer, Me.lbl_directory})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 723)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(493, 22)
        Me.StatusStrip1.TabIndex = 52
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_footer
        '
        Me.lbl_footer.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_footer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_footer.Name = "lbl_footer"
        Me.lbl_footer.Size = New System.Drawing.Size(0, 17)
        Me.lbl_footer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_directory
        '
        Me.lbl_directory.Name = "lbl_directory"
        Me.lbl_directory.Size = New System.Drawing.Size(0, 17)
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.Location = New System.Drawing.Point(14, 416)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(0, 17)
        Me.lb.TabIndex = 46
        '
        'Tim_clock
        '
        Me.Tim_clock.Interval = 1000
        '
        'Pan_edit
        '
        Me.Pan_edit.BackColor = System.Drawing.Color.Transparent
        Me.Pan_edit.Controls.Add(Me.Pan_Woodbackground)
        Me.Pan_edit.Controls.Add(Me.pan_filerestrictions)
        Me.Pan_edit.Controls.Add(Me.But_listchildren)
        Me.Pan_edit.Controls.Add(Me.Label20)
        Me.Pan_edit.Controls.Add(Me.Button2)
        Me.Pan_edit.Controls.Add(Me.TB_pan_morelines_speed)
        Me.Pan_edit.Controls.Add(Me.Label19)
        Me.Pan_edit.Controls.Add(Me.Pan_showclock)
        Me.Pan_edit.Controls.Add(Me.Pan_monitor_comm_error)
        Me.Pan_edit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pan_edit.Location = New System.Drawing.Point(0, 29)
        Me.Pan_edit.Name = "Pan_edit"
        Me.Pan_edit.Size = New System.Drawing.Size(493, 694)
        Me.Pan_edit.TabIndex = 54
        '
        'Pan_Woodbackground
        '
        Me.Pan_Woodbackground.BackgroundImage = Global.jp_dragonbone1.My.Resources.Resources.wood0691
        Me.Pan_Woodbackground.Controls.Add(Me.Pan_Design)
        Me.Pan_Woodbackground.Controls.Add(Me.Pan_internet_connection)
        Me.Pan_Woodbackground.Controls.Add(Me.But_debug)
        Me.Pan_Woodbackground.Controls.Add(Me.Pan_USBBase)
        Me.Pan_Woodbackground.Controls.Add(Me.Panel34)
        Me.Pan_Woodbackground.Controls.Add(Me.Pan_coonnect_menu)
        Me.Pan_Woodbackground.Controls.Add(Me.Panel33)
        Me.Pan_Woodbackground.Controls.Add(Me.Pan_dialog)
        Me.Pan_Woodbackground.Controls.Add(Me.Pan_bluetabs)
        Me.Pan_Woodbackground.Controls.Add(Me.Pan_Control)
        Me.Pan_Woodbackground.Controls.Add(Me.Pan_beginners_help)
        Me.Pan_Woodbackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pan_Woodbackground.Location = New System.Drawing.Point(0, 0)
        Me.Pan_Woodbackground.Name = "Pan_Woodbackground"
        Me.Pan_Woodbackground.Size = New System.Drawing.Size(493, 694)
        Me.Pan_Woodbackground.TabIndex = 76
        '
        'Pan_Design
        '
        Me.Pan_Design.BackColor = System.Drawing.Color.Lime
        Me.Pan_Design.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pan_Design.Controls.Add(Me.Label75)
        Me.Pan_Design.Controls.Add(Me.TabControl1)
        Me.Pan_Design.Location = New System.Drawing.Point(5, 233)
        Me.Pan_Design.Name = "Pan_Design"
        Me.Pan_Design.Size = New System.Drawing.Size(229, 439)
        Me.Pan_Design.TabIndex = 75
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.BackColor = System.Drawing.Color.White
        Me.Label75.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(3, 4)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(89, 26)
        Me.Label75.TabIndex = 169
        Me.Label75.Text = " Design "
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tab_FreeStyle)
        Me.TabControl1.Controls.Add(Me.Tab_Lines)
        Me.TabControl1.Controls.Add(Me.Tab_Easy)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 26)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(2, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(220, 394)
        Me.TabControl1.TabIndex = 53
        '
        'Tab_FreeStyle
        '
        Me.Tab_FreeStyle.BackColor = System.Drawing.Color.Lime
        Me.Tab_FreeStyle.Controls.Add(Me.Lbl_freestyle_sequencetime)
        Me.Tab_FreeStyle.Controls.Add(Me.Label13)
        Me.Tab_FreeStyle.Controls.Add(Me.Label15)
        Me.Tab_FreeStyle.Controls.Add(Me.HSB_speed_freestyletab)
        Me.Tab_FreeStyle.Controls.Add(Me.PB_horse_freestyletab)
        Me.Tab_FreeStyle.Controls.Add(Me.PB_snail_freestyletab)
        Me.Tab_FreeStyle.Controls.Add(Me.Lbl_freestyle_linetime)
        Me.Tab_FreeStyle.Controls.Add(Me.NUD_cardcount_freestyletab)
        Me.Tab_FreeStyle.Controls.Add(Me.TxtFreeStyle)
        Me.Tab_FreeStyle.Location = New System.Drawing.Point(4, 26)
        Me.Tab_FreeStyle.Name = "Tab_FreeStyle"
        Me.Tab_FreeStyle.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_FreeStyle.Size = New System.Drawing.Size(212, 364)
        Me.Tab_FreeStyle.TabIndex = 3
        Me.Tab_FreeStyle.Text = "Textbox"
        '
        'Lbl_freestyle_sequencetime
        '
        Me.Lbl_freestyle_sequencetime.AutoSize = True
        Me.Lbl_freestyle_sequencetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_freestyle_sequencetime.Location = New System.Drawing.Point(67, 51)
        Me.Lbl_freestyle_sequencetime.Name = "Lbl_freestyle_sequencetime"
        Me.Lbl_freestyle_sequencetime.Size = New System.Drawing.Size(97, 15)
        Me.Lbl_freestyle_sequencetime.TabIndex = 88
        Me.Lbl_freestyle_sequencetime.Text = "sequencetime"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 17)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Speed"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 17)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "Cards Used:"
        '
        'HSB_speed_freestyletab
        '
        Me.HSB_speed_freestyletab.Location = New System.Drawing.Point(5, 66)
        Me.HSB_speed_freestyletab.Margin = New System.Windows.Forms.Padding(10)
        Me.HSB_speed_freestyletab.Maximum = 264
        Me.HSB_speed_freestyletab.Minimum = 156
        Me.HSB_speed_freestyletab.Name = "HSB_speed_freestyletab"
        Me.HSB_speed_freestyletab.Padding = New System.Windows.Forms.Padding(20)
        Me.HSB_speed_freestyletab.Size = New System.Drawing.Size(172, 25)
        Me.HSB_speed_freestyletab.TabIndex = 83
        Me.HSB_speed_freestyletab.Value = 246
        '
        'PB_horse_freestyletab
        '
        Me.PB_horse_freestyletab.BackColor = System.Drawing.Color.Transparent
        Me.PB_horse_freestyletab.Image = Global.jp_dragonbone1.My.Resources.Resources.horse_icon_2k1
        Me.PB_horse_freestyletab.Location = New System.Drawing.Point(157, 94)
        Me.PB_horse_freestyletab.Name = "PB_horse_freestyletab"
        Me.PB_horse_freestyletab.Size = New System.Drawing.Size(20, 18)
        Me.PB_horse_freestyletab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_horse_freestyletab.TabIndex = 85
        Me.PB_horse_freestyletab.TabStop = False
        '
        'PB_snail_freestyletab
        '
        Me.PB_snail_freestyletab.Image = Global.jp_dragonbone1.My.Resources.Resources.snail_bk_icon_2_copy1
        Me.PB_snail_freestyletab.Location = New System.Drawing.Point(2, 93)
        Me.PB_snail_freestyletab.Name = "PB_snail_freestyletab"
        Me.PB_snail_freestyletab.Size = New System.Drawing.Size(20, 18)
        Me.PB_snail_freestyletab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_snail_freestyletab.TabIndex = 84
        Me.PB_snail_freestyletab.TabStop = False
        '
        'Lbl_freestyle_linetime
        '
        Me.Lbl_freestyle_linetime.AutoSize = True
        Me.Lbl_freestyle_linetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_freestyle_linetime.ForeColor = System.Drawing.Color.Black
        Me.Lbl_freestyle_linetime.Location = New System.Drawing.Point(67, 96)
        Me.Lbl_freestyle_linetime.Name = "Lbl_freestyle_linetime"
        Me.Lbl_freestyle_linetime.Size = New System.Drawing.Size(59, 15)
        Me.Lbl_freestyle_linetime.TabIndex = 87
        Me.Lbl_freestyle_linetime.Text = "linetime"
        '
        'NUD_cardcount_freestyletab
        '
        Me.NUD_cardcount_freestyletab.Location = New System.Drawing.Point(29, 22)
        Me.NUD_cardcount_freestyletab.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.NUD_cardcount_freestyletab.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NUD_cardcount_freestyletab.Name = "NUD_cardcount_freestyletab"
        Me.NUD_cardcount_freestyletab.Size = New System.Drawing.Size(57, 23)
        Me.NUD_cardcount_freestyletab.TabIndex = 82
        Me.NUD_cardcount_freestyletab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUD_cardcount_freestyletab.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'TxtFreeStyle
        '
        Me.TxtFreeStyle.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFreeStyle.Location = New System.Drawing.Point(1, 133)
        Me.TxtFreeStyle.Multiline = True
        Me.TxtFreeStyle.Name = "TxtFreeStyle"
        Me.TxtFreeStyle.Size = New System.Drawing.Size(176, 107)
        Me.TxtFreeStyle.TabIndex = 0
        '
        'Tab_Lines
        '
        Me.Tab_Lines.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Tab_Lines.BackgroundImage = Global.jp_dragonbone1.My.Resources.Resources.wood069
        Me.Tab_Lines.Controls.Add(Me.Pan_tb)
        Me.Tab_Lines.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Lines.Location = New System.Drawing.Point(4, 26)
        Me.Tab_Lines.Margin = New System.Windows.Forms.Padding(2)
        Me.Tab_Lines.Name = "Tab_Lines"
        Me.Tab_Lines.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Lines.Size = New System.Drawing.Size(212, 364)
        Me.Tab_Lines.TabIndex = 0
        Me.Tab_Lines.Text = "Lines"
        Me.Tab_Lines.UseVisualStyleBackColor = True
        '
        'Pan_tb
        '
        Me.Pan_tb.BackColor = System.Drawing.Color.Lime
        Me.Pan_tb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pan_tb.Controls.Add(Me.Lbl_lines_sequencetime)
        Me.Pan_tb.Controls.Add(Me.Label76)
        Me.Pan_tb.Controls.Add(Me.Label77)
        Me.Pan_tb.Controls.Add(Me.Label74)
        Me.Pan_tb.Controls.Add(Me.HSB_speed_linestab)
        Me.Pan_tb.Controls.Add(Me.PictureBox2)
        Me.Pan_tb.Controls.Add(Me.PictureBox5)
        Me.Pan_tb.Controls.Add(Me.NUD_linestab_liinecounts)
        Me.Pan_tb.Controls.Add(Me.Lbl_lines_linetime)
        Me.Pan_tb.Controls.Add(Me.Pic_textdatadown10)
        Me.Pan_tb.Controls.Add(Me.NUD_lines_cardcount)
        Me.Pan_tb.Controls.Add(Me.Pic_textdataup10)
        Me.Pan_tb.Controls.Add(Me.Lbl_pattern_type)
        Me.Pan_tb.Controls.Add(Me.Lbl_textdatabottom)
        Me.Pan_tb.Controls.Add(Me.Lbl_textdatadown1)
        Me.Pan_tb.Controls.Add(Me.lbl_textdatatop)
        Me.Pan_tb.Controls.Add(Me.Lbl_textdataup1)
        Me.Pan_tb.Controls.Add(Me.Label0)
        Me.Pan_tb.Controls.Add(Me.TB0)
        Me.Pan_tb.Controls.Add(Me.TB1)
        Me.Pan_tb.Controls.Add(Me.TB2)
        Me.Pan_tb.Controls.Add(Me.TB3)
        Me.Pan_tb.Controls.Add(Me.TB4)
        Me.Pan_tb.Controls.Add(Me.TB5)
        Me.Pan_tb.Controls.Add(Me.TB6)
        Me.Pan_tb.Controls.Add(Me.TB7)
        Me.Pan_tb.Controls.Add(Me.TB8)
        Me.Pan_tb.Controls.Add(Me.TB9)
        Me.Pan_tb.Controls.Add(Me.Label1)
        Me.Pan_tb.Controls.Add(Me.Label3)
        Me.Pan_tb.Controls.Add(Me.Label2)
        Me.Pan_tb.Controls.Add(Me.Label4)
        Me.Pan_tb.Controls.Add(Me.Label9)
        Me.Pan_tb.Controls.Add(Me.Label8)
        Me.Pan_tb.Controls.Add(Me.Label7)
        Me.Pan_tb.Controls.Add(Me.Label5)
        Me.Pan_tb.Controls.Add(Me.Label6)
        Me.Pan_tb.Location = New System.Drawing.Point(0, 0)
        Me.Pan_tb.Name = "Pan_tb"
        Me.Pan_tb.Size = New System.Drawing.Size(211, 360)
        Me.Pan_tb.TabIndex = 58
        '
        'Lbl_lines_sequencetime
        '
        Me.Lbl_lines_sequencetime.AutoSize = True
        Me.Lbl_lines_sequencetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_lines_sequencetime.Location = New System.Drawing.Point(63, 51)
        Me.Lbl_lines_sequencetime.Name = "Lbl_lines_sequencetime"
        Me.Lbl_lines_sequencetime.Size = New System.Drawing.Size(97, 15)
        Me.Lbl_lines_sequencetime.TabIndex = 80
        Me.Lbl_lines_sequencetime.Text = "sequencetime"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(103, 5)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(94, 17)
        Me.Label76.TabIndex = 73
        Me.Label76.Text = "Total Lines:"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(0, 46)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(54, 17)
        Me.Label77.TabIndex = 78
        Me.Label77.Text = "Speed"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(-1, 5)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(97, 17)
        Me.Label74.TabIndex = 68
        Me.Label74.Text = "Cards Used:"
        '
        'HSB_speed_linestab
        '
        Me.HSB_speed_linestab.Location = New System.Drawing.Point(9, 66)
        Me.HSB_speed_linestab.Margin = New System.Windows.Forms.Padding(10)
        Me.HSB_speed_linestab.Maximum = 264
        Me.HSB_speed_linestab.Minimum = 156
        Me.HSB_speed_linestab.Name = "HSB_speed_linestab"
        Me.HSB_speed_linestab.Padding = New System.Windows.Forms.Padding(20)
        Me.HSB_speed_linestab.Size = New System.Drawing.Size(166, 19)
        Me.HSB_speed_linestab.TabIndex = 75
        Me.HSB_speed_linestab.Value = 246
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.jp_dragonbone1.My.Resources.Resources.horse_icon_2k1
        Me.PictureBox2.Location = New System.Drawing.Point(153, 86)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 77
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.jp_dragonbone1.My.Resources.Resources.snail_bk_icon_2_copy1
        Me.PictureBox5.Location = New System.Drawing.Point(9, 85)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(20, 18)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 76
        Me.PictureBox5.TabStop = False
        '
        'NUD_linestab_liinecounts
        '
        Me.NUD_linestab_liinecounts.Location = New System.Drawing.Point(119, 22)
        Me.NUD_linestab_liinecounts.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.NUD_linestab_liinecounts.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_linestab_liinecounts.Name = "NUD_linestab_liinecounts"
        Me.NUD_linestab_liinecounts.Size = New System.Drawing.Size(52, 23)
        Me.NUD_linestab_liinecounts.TabIndex = 71
        Me.NUD_linestab_liinecounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUD_linestab_liinecounts.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'Lbl_lines_linetime
        '
        Me.Lbl_lines_linetime.AutoSize = True
        Me.Lbl_lines_linetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_lines_linetime.ForeColor = System.Drawing.Color.Black
        Me.Lbl_lines_linetime.Location = New System.Drawing.Point(63, 88)
        Me.Lbl_lines_linetime.Name = "Lbl_lines_linetime"
        Me.Lbl_lines_linetime.Size = New System.Drawing.Size(59, 15)
        Me.Lbl_lines_linetime.TabIndex = 79
        Me.Lbl_lines_linetime.Text = "linetime"
        '
        'Pic_textdatadown10
        '
        Me.Pic_textdatadown10.Image = CType(resources.GetObject("Pic_textdatadown10.Image"), System.Drawing.Image)
        Me.Pic_textdatadown10.Location = New System.Drawing.Point(152, 281)
        Me.Pic_textdatadown10.Name = "Pic_textdatadown10"
        Me.Pic_textdatadown10.Size = New System.Drawing.Size(23, 21)
        Me.Pic_textdatadown10.TabIndex = 45
        Me.Pic_textdatadown10.TabStop = False
        '
        'NUD_lines_cardcount
        '
        Me.NUD_lines_cardcount.Location = New System.Drawing.Point(4, 22)
        Me.NUD_lines_cardcount.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.NUD_lines_cardcount.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NUD_lines_cardcount.Name = "NUD_lines_cardcount"
        Me.NUD_lines_cardcount.Size = New System.Drawing.Size(59, 23)
        Me.NUD_lines_cardcount.TabIndex = 69
        Me.NUD_lines_cardcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUD_lines_cardcount.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Pic_textdataup10
        '
        Me.Pic_textdataup10.BackColor = System.Drawing.Color.Aqua
        Me.Pic_textdataup10.Image = CType(resources.GetObject("Pic_textdataup10.Image"), System.Drawing.Image)
        Me.Pic_textdataup10.InitialImage = CType(resources.GetObject("Pic_textdataup10.InitialImage"), System.Drawing.Image)
        Me.Pic_textdataup10.Location = New System.Drawing.Point(151, 128)
        Me.Pic_textdataup10.Name = "Pic_textdataup10"
        Me.Pic_textdataup10.Size = New System.Drawing.Size(23, 25)
        Me.Pic_textdataup10.TabIndex = 44
        Me.Pic_textdataup10.TabStop = False
        '
        'Lbl_pattern_type
        '
        Me.Lbl_pattern_type.AutoSize = True
        Me.Lbl_pattern_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_pattern_type.Location = New System.Drawing.Point(108, 171)
        Me.Lbl_pattern_type.Name = "Lbl_pattern_type"
        Me.Lbl_pattern_type.Size = New System.Drawing.Size(118, 25)
        Me.Lbl_pattern_type.TabIndex = 55
        Me.Lbl_pattern_type.Text = "(No Pattern)"
        Me.Lbl_pattern_type.Visible = False
        '
        'Lbl_textdatabottom
        '
        Me.Lbl_textdatabottom.AutoSize = True
        Me.Lbl_textdatabottom.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Lbl_textdatabottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_textdatabottom.Location = New System.Drawing.Point(152, 309)
        Me.Lbl_textdatabottom.Name = "Lbl_textdatabottom"
        Me.Lbl_textdatabottom.Size = New System.Drawing.Size(31, 15)
        Me.Lbl_textdatabottom.TabIndex = 43
        Me.Lbl_textdatabottom.Text = "BOT"
        '
        'Lbl_textdatadown1
        '
        Me.Lbl_textdatadown1.AutoSize = True
        Me.Lbl_textdatadown1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Lbl_textdatadown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_textdatadown1.Location = New System.Drawing.Point(157, 261)
        Me.Lbl_textdatadown1.Name = "Lbl_textdatadown1"
        Me.Lbl_textdatadown1.Size = New System.Drawing.Size(15, 18)
        Me.Lbl_textdatadown1.TabIndex = 41
        Me.Lbl_textdatadown1.Text = "ᴠ"
        '
        'lbl_textdatatop
        '
        Me.lbl_textdatatop.AutoSize = True
        Me.lbl_textdatatop.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lbl_textdatatop.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textdatatop.Location = New System.Drawing.Point(149, 112)
        Me.lbl_textdatatop.Name = "lbl_textdatatop"
        Me.lbl_textdatatop.Size = New System.Drawing.Size(31, 15)
        Me.lbl_textdatatop.TabIndex = 40
        Me.lbl_textdatatop.Text = "TOP"
        '
        'Lbl_textdataup1
        '
        Me.Lbl_textdataup1.AutoSize = True
        Me.Lbl_textdataup1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Lbl_textdataup1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_textdataup1.Location = New System.Drawing.Point(157, 156)
        Me.Lbl_textdataup1.Name = "Lbl_textdataup1"
        Me.Lbl_textdataup1.Size = New System.Drawing.Size(16, 18)
        Me.Lbl_textdataup1.TabIndex = 38
        Me.Lbl_textdataup1.Text = "ᴧ"
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label0.Location = New System.Drawing.Point(3, 109)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(17, 17)
        Me.Label0.TabIndex = 15
        Me.Label0.Text = "1"
        '
        'TB0
        '
        Me.TB0.BackColor = System.Drawing.Color.White
        Me.TB0.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB0.Location = New System.Drawing.Point(24, 105)
        Me.TB0.MaxLength = 50
        Me.TB0.Name = "TB0"
        Me.TB0.Size = New System.Drawing.Size(77, 24)
        Me.TB0.TabIndex = 0
        Me.TB0.Tag = "0"
        '
        'TB1
        '
        Me.TB1.BackColor = System.Drawing.Color.White
        Me.TB1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB1.Location = New System.Drawing.Point(24, 127)
        Me.TB1.MaxLength = 50
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(78, 24)
        Me.TB1.TabIndex = 1
        Me.TB1.Tag = "1"
        '
        'TB2
        '
        Me.TB2.BackColor = System.Drawing.Color.White
        Me.TB2.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB2.Location = New System.Drawing.Point(24, 148)
        Me.TB2.MaxLength = 50
        Me.TB2.Name = "TB2"
        Me.TB2.Size = New System.Drawing.Size(78, 24)
        Me.TB2.TabIndex = 2
        Me.TB2.Tag = "2"
        '
        'TB3
        '
        Me.TB3.BackColor = System.Drawing.Color.White
        Me.TB3.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB3.Location = New System.Drawing.Point(24, 170)
        Me.TB3.MaxLength = 50
        Me.TB3.Name = "TB3"
        Me.TB3.Size = New System.Drawing.Size(78, 24)
        Me.TB3.TabIndex = 3
        Me.TB3.Tag = "3"
        '
        'TB4
        '
        Me.TB4.BackColor = System.Drawing.Color.White
        Me.TB4.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB4.Location = New System.Drawing.Point(24, 191)
        Me.TB4.MaxLength = 50
        Me.TB4.Name = "TB4"
        Me.TB4.Size = New System.Drawing.Size(78, 24)
        Me.TB4.TabIndex = 4
        Me.TB4.Tag = "4"
        '
        'TB5
        '
        Me.TB5.BackColor = System.Drawing.Color.White
        Me.TB5.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB5.Location = New System.Drawing.Point(24, 213)
        Me.TB5.MaxLength = 50
        Me.TB5.Name = "TB5"
        Me.TB5.Size = New System.Drawing.Size(78, 24)
        Me.TB5.TabIndex = 5
        Me.TB5.Tag = "5"
        '
        'TB6
        '
        Me.TB6.BackColor = System.Drawing.Color.White
        Me.TB6.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB6.Location = New System.Drawing.Point(24, 235)
        Me.TB6.MaxLength = 50
        Me.TB6.Name = "TB6"
        Me.TB6.Size = New System.Drawing.Size(78, 24)
        Me.TB6.TabIndex = 6
        Me.TB6.Tag = "6"
        '
        'TB7
        '
        Me.TB7.BackColor = System.Drawing.Color.White
        Me.TB7.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB7.Location = New System.Drawing.Point(24, 257)
        Me.TB7.MaxLength = 50
        Me.TB7.Name = "TB7"
        Me.TB7.Size = New System.Drawing.Size(78, 24)
        Me.TB7.TabIndex = 7
        Me.TB7.Tag = "7"
        '
        'TB8
        '
        Me.TB8.BackColor = System.Drawing.Color.White
        Me.TB8.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB8.Location = New System.Drawing.Point(24, 279)
        Me.TB8.MaxLength = 50
        Me.TB8.Name = "TB8"
        Me.TB8.Size = New System.Drawing.Size(78, 24)
        Me.TB8.TabIndex = 8
        Me.TB8.Tag = "8"
        '
        'TB9
        '
        Me.TB9.BackColor = System.Drawing.Color.White
        Me.TB9.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB9.Location = New System.Drawing.Point(24, 301)
        Me.TB9.MaxLength = 50
        Me.TB9.Name = "TB9"
        Me.TB9.Size = New System.Drawing.Size(78, 24)
        Me.TB9.TabIndex = 9
        Me.TB9.Tag = "9"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "5"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(3, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "10"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "9"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "8"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "6"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "7"
        '
        'Tab_Easy
        '
        Me.Tab_Easy.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Tab_Easy.BackgroundImage = Global.jp_dragonbone1.My.Resources.Resources.wood069
        Me.Tab_Easy.Controls.Add(Me.Panel32)
        Me.Tab_Easy.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Easy.Location = New System.Drawing.Point(4, 26)
        Me.Tab_Easy.Margin = New System.Windows.Forms.Padding(2)
        Me.Tab_Easy.Name = "Tab_Easy"
        Me.Tab_Easy.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Easy.Size = New System.Drawing.Size(212, 364)
        Me.Tab_Easy.TabIndex = 1
        Me.Tab_Easy.Text = "Easy"
        Me.Tab_Easy.UseVisualStyleBackColor = True
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.Lime
        Me.Panel32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel32.Controls.Add(Me.Lbl_easy_sequencetime)
        Me.Panel32.Controls.Add(Me.Lbl_easy_linetime)
        Me.Panel32.Controls.Add(Me.TextBox23)
        Me.Panel32.Controls.Add(Me.Label94)
        Me.Panel32.Controls.Add(Me.Label73)
        Me.Panel32.Controls.Add(Me.Lbl_MyKeyword)
        Me.Panel32.Controls.Add(Me.Pan_keyword_background)
        Me.Panel32.Controls.Add(Me.Label93)
        Me.Panel32.Controls.Add(Me.PB_horse_easytab)
        Me.Panel32.Controls.Add(Me.PB_snail_easytab)
        Me.Panel32.Controls.Add(Me.NUD_cardcount_easytab)
        Me.Panel32.Controls.Add(Me.HSB_speed_easytab)
        Me.Panel32.Controls.Add(Me.RB_pat_random)
        Me.Panel32.Controls.Add(Me.RB_pat_zoom)
        Me.Panel32.Controls.Add(Me.Lbl_lightcards)
        Me.Panel32.Controls.Add(Me.RB_pat_Constant)
        Me.Panel32.Controls.Add(Me.RB_pat_AddOn)
        Me.Panel32.Controls.Add(Me.RB_pat_BlinkFast)
        Me.Panel32.Controls.Add(Me.RB_pat_BlinkSlow)
        Me.Panel32.Controls.Add(Me.RB_pat_Dance)
        Me.Panel32.Controls.Add(Me.RB_pat_SplitOut)
        Me.Panel32.Controls.Add(Me.RB_pat_JoinIn)
        Me.Panel32.Controls.Add(Me.RB_pat_FlowLeft)
        Me.Panel32.Controls.Add(Me.RB_pat_FlowRight)
        Me.Panel32.Controls.Add(Me.Label70)
        Me.Panel32.Location = New System.Drawing.Point(0, 0)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(212, 368)
        Me.Panel32.TabIndex = 59
        '
        'Lbl_easy_sequencetime
        '
        Me.Lbl_easy_sequencetime.AutoSize = True
        Me.Lbl_easy_sequencetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_easy_sequencetime.Location = New System.Drawing.Point(73, 124)
        Me.Lbl_easy_sequencetime.Name = "Lbl_easy_sequencetime"
        Me.Lbl_easy_sequencetime.Size = New System.Drawing.Size(97, 15)
        Me.Lbl_easy_sequencetime.TabIndex = 74
        Me.Lbl_easy_sequencetime.Text = "sequencetime"
        '
        'Lbl_easy_linetime
        '
        Me.Lbl_easy_linetime.AutoSize = True
        Me.Lbl_easy_linetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_easy_linetime.ForeColor = System.Drawing.Color.Black
        Me.Lbl_easy_linetime.Location = New System.Drawing.Point(60, 171)
        Me.Lbl_easy_linetime.Name = "Lbl_easy_linetime"
        Me.Lbl_easy_linetime.Size = New System.Drawing.Size(59, 15)
        Me.Lbl_easy_linetime.TabIndex = 73
        Me.Lbl_easy_linetime.Text = "linetime"
        '
        'TextBox23
        '
        Me.TextBox23.BackColor = System.Drawing.Color.White
        Me.TextBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox23.Location = New System.Drawing.Point(60, 193)
        Me.TextBox23.MaxLength = 17
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(24, 24)
        Me.TextBox23.TabIndex = 72
        Me.TextBox23.Tag = "0"
        Me.TextBox23.Text = "WW"
        Me.TextBox23.Visible = False
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(-3, 62)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(60, 17)
        Me.Label94.TabIndex = 71
        Me.Label94.Text = "  Cards"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(-3, -1)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(44, 17)
        Me.Label73.TabIndex = 69
        Me.Label73.Text = " Text"
        '
        'Lbl_MyKeyword
        '
        Me.Lbl_MyKeyword.AutoSize = True
        Me.Lbl_MyKeyword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_MyKeyword.Location = New System.Drawing.Point(19, 51)
        Me.Lbl_MyKeyword.Name = "Lbl_MyKeyword"
        Me.Lbl_MyKeyword.Size = New System.Drawing.Size(0, 20)
        Me.Lbl_MyKeyword.TabIndex = 1
        '
        'Pan_keyword_background
        '
        Me.Pan_keyword_background.BackColor = System.Drawing.Color.SlateGray
        Me.Pan_keyword_background.BackgroundImage = Global.jp_dragonbone1.My.Resources.Resources.Text_bkg2
        Me.Pan_keyword_background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pan_keyword_background.Controls.Add(Me.Txt_keyword)
        Me.Pan_keyword_background.Controls.Add(Me.TXTdebug)
        Me.Pan_keyword_background.Location = New System.Drawing.Point(6, 17)
        Me.Pan_keyword_background.Name = "Pan_keyword_background"
        Me.Pan_keyword_background.Size = New System.Drawing.Size(166, 30)
        Me.Pan_keyword_background.TabIndex = 68
        '
        'Txt_keyword
        '
        Me.Txt_keyword.BackColor = System.Drawing.Color.White
        Me.Txt_keyword.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_keyword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_keyword.Location = New System.Drawing.Point(0, 4)
        Me.Txt_keyword.MaxLength = 17
        Me.Txt_keyword.Name = "Txt_keyword"
        Me.Txt_keyword.Size = New System.Drawing.Size(161, 29)
        Me.Txt_keyword.TabIndex = 0
        Me.Txt_keyword.Tag = "0"
        '
        'TXTdebug
        '
        Me.TXTdebug.Location = New System.Drawing.Point(7, -6)
        Me.TXTdebug.Name = "TXTdebug"
        Me.TXTdebug.Size = New System.Drawing.Size(100, 19)
        Me.TXTdebug.TabIndex = 62
        Me.TXTdebug.Visible = False
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(-3, 119)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(64, 17)
        Me.Label93.TabIndex = 70
        Me.Label93.Text = "  Speed"
        '
        'PB_horse_easytab
        '
        Me.PB_horse_easytab.BackColor = System.Drawing.Color.Transparent
        Me.PB_horse_easytab.Image = Global.jp_dragonbone1.My.Resources.Resources.horse_icon_2k1
        Me.PB_horse_easytab.Location = New System.Drawing.Point(150, 169)
        Me.PB_horse_easytab.Name = "PB_horse_easytab"
        Me.PB_horse_easytab.Size = New System.Drawing.Size(20, 18)
        Me.PB_horse_easytab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_horse_easytab.TabIndex = 69
        Me.PB_horse_easytab.TabStop = False
        '
        'PB_snail_easytab
        '
        Me.PB_snail_easytab.Image = Global.jp_dragonbone1.My.Resources.Resources.snail_bk_icon_2_copy1
        Me.PB_snail_easytab.Location = New System.Drawing.Point(6, 168)
        Me.PB_snail_easytab.Name = "PB_snail_easytab"
        Me.PB_snail_easytab.Size = New System.Drawing.Size(20, 18)
        Me.PB_snail_easytab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_snail_easytab.TabIndex = 63
        Me.PB_snail_easytab.TabStop = False
        '
        'NUD_cardcount_easytab
        '
        Me.NUD_cardcount_easytab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUD_cardcount_easytab.Location = New System.Drawing.Point(6, 83)
        Me.NUD_cardcount_easytab.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.NUD_cardcount_easytab.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_cardcount_easytab.Name = "NUD_cardcount_easytab"
        Me.NUD_cardcount_easytab.Size = New System.Drawing.Size(72, 30)
        Me.NUD_cardcount_easytab.TabIndex = 63
        Me.NUD_cardcount_easytab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUD_cardcount_easytab.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'HSB_speed_easytab
        '
        Me.HSB_speed_easytab.Location = New System.Drawing.Point(6, 138)
        Me.HSB_speed_easytab.Margin = New System.Windows.Forms.Padding(10)
        Me.HSB_speed_easytab.Maximum = 264
        Me.HSB_speed_easytab.Minimum = 156
        Me.HSB_speed_easytab.Name = "HSB_speed_easytab"
        Me.HSB_speed_easytab.Padding = New System.Windows.Forms.Padding(20)
        Me.HSB_speed_easytab.Size = New System.Drawing.Size(166, 30)
        Me.HSB_speed_easytab.TabIndex = 62
        Me.HSB_speed_easytab.Value = 246
        '
        'RB_pat_random
        '
        Me.RB_pat_random.AutoSize = True
        Me.RB_pat_random.Enabled = False
        Me.RB_pat_random.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_pat_random.Location = New System.Drawing.Point(97, 299)
        Me.RB_pat_random.Name = "RB_pat_random"
        Me.RB_pat_random.Size = New System.Drawing.Size(88, 21)
        Me.RB_pat_random.TabIndex = 65
        Me.RB_pat_random.TabStop = True
        Me.RB_pat_random.Tag = "11"
        Me.RB_pat_random.Text = "Random"
        Me.RB_pat_random.UseVisualStyleBackColor = True
        '
        'RB_pat_zoom
        '
        Me.RB_pat_zoom.AutoSize = True
        Me.RB_pat_zoom.Enabled = False
        Me.RB_pat_zoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_pat_zoom.Location = New System.Drawing.Point(6, 300)
        Me.RB_pat_zoom.Name = "RB_pat_zoom"
        Me.RB_pat_zoom.Size = New System.Drawing.Size(115, 21)
        Me.RB_pat_zoom.TabIndex = 64
        Me.RB_pat_zoom.TabStop = True
        Me.RB_pat_zoom.Tag = "10"
        Me.RB_pat_zoom.Text = "Zoom in/out"
        Me.RB_pat_zoom.UseVisualStyleBackColor = True
        '
        'Lbl_lightcards
        '
        Me.Lbl_lightcards.AutoSize = True
        Me.Lbl_lightcards.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_lightcards.Location = New System.Drawing.Point(84, 89)
        Me.Lbl_lightcards.Name = "Lbl_lightcards"
        Me.Lbl_lightcards.Size = New System.Drawing.Size(117, 15)
        Me.Lbl_lightcards.TabIndex = 62
        Me.Lbl_lightcards.Text = "Light Cards Used"
        '
        'RB_pat_Constant
        '
        Me.RB_pat_Constant.AutoSize = True
        Me.RB_pat_Constant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_pat_Constant.Location = New System.Drawing.Point(6, 213)
        Me.RB_pat_Constant.Name = "RB_pat_Constant"
        Me.RB_pat_Constant.Size = New System.Drawing.Size(56, 21)
        Me.RB_pat_Constant.TabIndex = 1
        Me.RB_pat_Constant.TabStop = True
        Me.RB_pat_Constant.Tag = "0"
        Me.RB_pat_Constant.Text = "Still"
        Me.RB_pat_Constant.UseVisualStyleBackColor = True
        '
        'RB_pat_AddOn
        '
        Me.RB_pat_AddOn.AutoSize = True
        Me.RB_pat_AddOn.Enabled = False
        Me.RB_pat_AddOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_pat_AddOn.Location = New System.Drawing.Point(97, 282)
        Me.RB_pat_AddOn.Name = "RB_pat_AddOn"
        Me.RB_pat_AddOn.Size = New System.Drawing.Size(83, 21)
        Me.RB_pat_AddOn.TabIndex = 9
        Me.RB_pat_AddOn.TabStop = True
        Me.RB_pat_AddOn.Tag = "9"
        Me.RB_pat_AddOn.Text = "Add On"
        Me.RB_pat_AddOn.UseVisualStyleBackColor = True
        '
        'RB_pat_BlinkFast
        '
        Me.RB_pat_BlinkFast.AutoSize = True
        Me.RB_pat_BlinkFast.Enabled = False
        Me.RB_pat_BlinkFast.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_pat_BlinkFast.Location = New System.Drawing.Point(97, 265)
        Me.RB_pat_BlinkFast.Name = "RB_pat_BlinkFast"
        Me.RB_pat_BlinkFast.Size = New System.Drawing.Size(100, 21)
        Me.RB_pat_BlinkFast.TabIndex = 8
        Me.RB_pat_BlinkFast.TabStop = True
        Me.RB_pat_BlinkFast.Tag = "8"
        Me.RB_pat_BlinkFast.Text = "Blink Fast"
        Me.RB_pat_BlinkFast.UseVisualStyleBackColor = True
        '
        'RB_pat_BlinkSlow
        '
        Me.RB_pat_BlinkSlow.AutoSize = True
        Me.RB_pat_BlinkSlow.Enabled = False
        Me.RB_pat_BlinkSlow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_pat_BlinkSlow.Location = New System.Drawing.Point(97, 248)
        Me.RB_pat_BlinkSlow.Name = "RB_pat_BlinkSlow"
        Me.RB_pat_BlinkSlow.Size = New System.Drawing.Size(102, 21)
        Me.RB_pat_BlinkSlow.TabIndex = 7
        Me.RB_pat_BlinkSlow.TabStop = True
        Me.RB_pat_BlinkSlow.Tag = "7"
        Me.RB_pat_BlinkSlow.Text = "Blink Slow"
        Me.RB_pat_BlinkSlow.UseVisualStyleBackColor = True
        '
        'RB_pat_Dance
        '
        Me.RB_pat_Dance.AutoSize = True
        Me.RB_pat_Dance.Enabled = False
        Me.RB_pat_Dance.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.RB_pat_Dance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_pat_Dance.Location = New System.Drawing.Point(97, 231)
        Me.RB_pat_Dance.Name = "RB_pat_Dance"
        Me.RB_pat_Dance.Size = New System.Drawing.Size(75, 21)
        Me.RB_pat_Dance.TabIndex = 6
        Me.RB_pat_Dance.TabStop = True
        Me.RB_pat_Dance.Tag = "6"
        Me.RB_pat_Dance.Text = "Dance"
        Me.RB_pat_Dance.UseVisualStyleBackColor = True
        '
        'RB_pat_SplitOut
        '
        Me.RB_pat_SplitOut.AutoSize = True
        Me.RB_pat_SplitOut.Enabled = False
        Me.RB_pat_SplitOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_pat_SplitOut.Location = New System.Drawing.Point(6, 283)
        Me.RB_pat_SplitOut.Name = "RB_pat_SplitOut"
        Me.RB_pat_SplitOut.Size = New System.Drawing.Size(92, 21)
        Me.RB_pat_SplitOut.TabIndex = 5
        Me.RB_pat_SplitOut.TabStop = True
        Me.RB_pat_SplitOut.Tag = "5"
        Me.RB_pat_SplitOut.Text = "Split Out"
        Me.RB_pat_SplitOut.UseVisualStyleBackColor = True
        '
        'RB_pat_JoinIn
        '
        Me.RB_pat_JoinIn.AutoSize = True
        Me.RB_pat_JoinIn.Enabled = False
        Me.RB_pat_JoinIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_pat_JoinIn.Location = New System.Drawing.Point(6, 266)
        Me.RB_pat_JoinIn.Name = "RB_pat_JoinIn"
        Me.RB_pat_JoinIn.Size = New System.Drawing.Size(77, 21)
        Me.RB_pat_JoinIn.TabIndex = 4
        Me.RB_pat_JoinIn.TabStop = True
        Me.RB_pat_JoinIn.Tag = "4"
        Me.RB_pat_JoinIn.Text = "Join In"
        Me.RB_pat_JoinIn.UseVisualStyleBackColor = True
        '
        'RB_pat_FlowLeft
        '
        Me.RB_pat_FlowLeft.AutoSize = True
        Me.RB_pat_FlowLeft.Enabled = False
        Me.RB_pat_FlowLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_pat_FlowLeft.Location = New System.Drawing.Point(6, 249)
        Me.RB_pat_FlowLeft.Name = "RB_pat_FlowLeft"
        Me.RB_pat_FlowLeft.Size = New System.Drawing.Size(94, 21)
        Me.RB_pat_FlowLeft.TabIndex = 3
        Me.RB_pat_FlowLeft.TabStop = True
        Me.RB_pat_FlowLeft.Tag = "3"
        Me.RB_pat_FlowLeft.Text = "Flow Left"
        Me.RB_pat_FlowLeft.UseVisualStyleBackColor = True
        '
        'RB_pat_FlowRight
        '
        Me.RB_pat_FlowRight.AutoSize = True
        Me.RB_pat_FlowRight.Enabled = False
        Me.RB_pat_FlowRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_pat_FlowRight.Location = New System.Drawing.Point(6, 230)
        Me.RB_pat_FlowRight.Name = "RB_pat_FlowRight"
        Me.RB_pat_FlowRight.Size = New System.Drawing.Size(109, 22)
        Me.RB_pat_FlowRight.TabIndex = 2
        Me.RB_pat_FlowRight.TabStop = True
        Me.RB_pat_FlowRight.Tag = "2"
        Me.RB_pat_FlowRight.Text = "Flow Right"
        Me.RB_pat_FlowRight.UseVisualStyleBackColor = True
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(-3, 196)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(76, 17)
        Me.Label70.TabIndex = 2
        Me.Label70.Text = "  Pattern "
        '
        'Pan_internet_connection
        '
        Me.Pan_internet_connection.Controls.Add(Me.Label71)
        Me.Pan_internet_connection.Controls.Add(Me.Lbl_internet_sign)
        Me.Pan_internet_connection.Controls.Add(Me.Label68)
        Me.Pan_internet_connection.Location = New System.Drawing.Point(517, 20)
        Me.Pan_internet_connection.Name = "Pan_internet_connection"
        Me.Pan_internet_connection.Size = New System.Drawing.Size(148, 117)
        Me.Pan_internet_connection.TabIndex = 170
        Me.Pan_internet_connection.Visible = False
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(10, 51)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(196, 17)
        Me.Label71.TabIndex = 2
        Me.Label71.Text = "all other connections disabled"
        '
        'Lbl_internet_sign
        '
        Me.Lbl_internet_sign.AutoSize = True
        Me.Lbl_internet_sign.Location = New System.Drawing.Point(162, 15)
        Me.Lbl_internet_sign.Name = "Lbl_internet_sign"
        Me.Lbl_internet_sign.Size = New System.Drawing.Size(0, 17)
        Me.Lbl_internet_sign.TabIndex = 1
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(8, 12)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(200, 17)
        Me.Label68.TabIndex = 0
        Me.Label68.Text = "Connected via internet to sign:"
        '
        'But_debug
        '
        Me.But_debug.Location = New System.Drawing.Point(673, 280)
        Me.But_debug.Name = "But_debug"
        Me.But_debug.Size = New System.Drawing.Size(122, 23)
        Me.But_debug.TabIndex = 78
        Me.But_debug.Text = "Debug action"
        Me.But_debug.UseVisualStyleBackColor = True
        '
        'Pan_USBBase
        '
        Me.Pan_USBBase.BackColor = System.Drawing.Color.White
        Me.Pan_USBBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pan_USBBase.Controls.Add(Me.Lbl_uabnotfound)
        Me.Pan_USBBase.Location = New System.Drawing.Point(396, 16)
        Me.Pan_USBBase.Name = "Pan_USBBase"
        Me.Pan_USBBase.Size = New System.Drawing.Size(60, 40)
        Me.Pan_USBBase.TabIndex = 3
        Me.Pan_USBBase.Visible = False
        '
        'Lbl_uabnotfound
        '
        Me.Lbl_uabnotfound.AutoSize = True
        Me.Lbl_uabnotfound.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_uabnotfound.Location = New System.Drawing.Point(4, 19)
        Me.Lbl_uabnotfound.Name = "Lbl_uabnotfound"
        Me.Lbl_uabnotfound.Size = New System.Drawing.Size(28, 13)
        Me.Lbl_uabnotfound.TabIndex = 1
        Me.Lbl_uabnotfound.Text = "USB"
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel34.Controls.Add(Me.RadioButton1)
        Me.Panel34.Location = New System.Drawing.Point(540, 68)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(277, 100)
        Me.Panel34.TabIndex = 77
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(60, 33)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Pan_coonnect_menu
        '
        Me.Pan_coonnect_menu.BackColor = System.Drawing.Color.White
        Me.Pan_coonnect_menu.Controls.Add(Me.men_connect)
        Me.Pan_coonnect_menu.Location = New System.Drawing.Point(517, 191)
        Me.Pan_coonnect_menu.Name = "Pan_coonnect_menu"
        Me.Pan_coonnect_menu.Size = New System.Drawing.Size(89, 56)
        Me.Pan_coonnect_menu.TabIndex = 55
        Me.Pan_coonnect_menu.Visible = False
        '
        'men_connect
        '
        Me.men_connect.Dock = System.Windows.Forms.DockStyle.None
        Me.men_connect.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.men_connect.Location = New System.Drawing.Point(1, 6)
        Me.men_connect.Name = "men_connect"
        Me.men_connect.Size = New System.Drawing.Size(30, 206)
        Me.men_connect.TabIndex = 0
        Me.men_connect.Text = "MenuStrip1"
        '
        'Panel33
        '
        Me.Panel33.BackColor = System.Drawing.Color.Red
        Me.Panel33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel33.Controls.Add(Me.Label10)
        Me.Panel33.Controls.Add(Me.Lbl_UserManual)
        Me.Panel33.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel33.Location = New System.Drawing.Point(11, 581)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(378, 10)
        Me.Panel33.TabIndex = 28
        Me.Panel33.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(95, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 17)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Double Click to expand"
        Me.Label10.Visible = False
        '
        'Lbl_UserManual
        '
        Me.Lbl_UserManual.AutoSize = True
        Me.Lbl_UserManual.BackColor = System.Drawing.Color.DarkGray
        Me.Lbl_UserManual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_UserManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_UserManual.Location = New System.Drawing.Point(3, 3)
        Me.Lbl_UserManual.Name = "Lbl_UserManual"
        Me.Lbl_UserManual.Size = New System.Drawing.Size(71, 22)
        Me.Lbl_UserManual.TabIndex = 28
        Me.Lbl_UserManual.Text = "Manuel"
        '
        'Pan_dialog
        '
        Me.Pan_dialog.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Pan_dialog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pan_dialog.Controls.Add(Me.Pan_sever_filebuttons)
        Me.Pan_dialog.Controls.Add(Me.But_send)
        Me.Pan_dialog.Controls.Add(Me.But_get)
        Me.Pan_dialog.Controls.Add(Me.pan_chalkboard)
        Me.Pan_dialog.Controls.Add(Me.Lbl_dialog)
        Me.Pan_dialog.Location = New System.Drawing.Point(6, 8)
        Me.Pan_dialog.Name = "Pan_dialog"
        Me.Pan_dialog.Padding = New System.Windows.Forms.Padding(3)
        Me.Pan_dialog.Size = New System.Drawing.Size(475, 216)
        Me.Pan_dialog.TabIndex = 74
        '
        'Pan_sever_filebuttons
        '
        Me.Pan_sever_filebuttons.Controls.Add(Me.But_server_savefile)
        Me.Pan_sever_filebuttons.Controls.Add(Me.Label72)
        Me.Pan_sever_filebuttons.Controls.Add(Me.Pan_dialog_mascot)
        Me.Pan_sever_filebuttons.Controls.Add(Me.But_server_openfile)
        Me.Pan_sever_filebuttons.Location = New System.Drawing.Point(2, 73)
        Me.Pan_sever_filebuttons.Name = "Pan_sever_filebuttons"
        Me.Pan_sever_filebuttons.Size = New System.Drawing.Size(67, 79)
        Me.Pan_sever_filebuttons.TabIndex = 79
        Me.Pan_sever_filebuttons.Visible = False
        '
        'But_server_savefile
        '
        Me.But_server_savefile.BackColor = System.Drawing.Color.RoyalBlue
        Me.But_server_savefile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_server_savefile.Location = New System.Drawing.Point(0, 50)
        Me.But_server_savefile.Name = "But_server_savefile"
        Me.But_server_savefile.Size = New System.Drawing.Size(65, 24)
        Me.But_server_savefile.TabIndex = 76
        Me.But_server_savefile.Text = "Save"
        Me.But_server_savefile.UseVisualStyleBackColor = False
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.Silver
        Me.Label72.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(3, 4)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(66, 22)
        Me.Label72.TabIndex = 78
        Me.Label72.Text = "Server"
        '
        'Pan_dialog_mascot
        '
        Me.Pan_dialog_mascot.BackColor = System.Drawing.Color.Transparent
        Me.Pan_dialog_mascot.BackgroundImage = Global.jp_dragonbone1.My.Resources.Resources.dog1
        Me.Pan_dialog_mascot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pan_dialog_mascot.Location = New System.Drawing.Point(-25, 36)
        Me.Pan_dialog_mascot.Name = "Pan_dialog_mascot"
        Me.Pan_dialog_mascot.Size = New System.Drawing.Size(53, 39)
        Me.Pan_dialog_mascot.TabIndex = 75
        Me.Pan_dialog_mascot.Visible = False
        '
        'But_server_openfile
        '
        Me.But_server_openfile.BackColor = System.Drawing.Color.Lime
        Me.But_server_openfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_server_openfile.Location = New System.Drawing.Point(0, 24)
        Me.But_server_openfile.Name = "But_server_openfile"
        Me.But_server_openfile.Size = New System.Drawing.Size(65, 24)
        Me.But_server_openfile.TabIndex = 77
        Me.But_server_openfile.Text = "Get"
        Me.But_server_openfile.UseVisualStyleBackColor = False
        '
        'But_send
        '
        Me.But_send.BackColor = System.Drawing.Color.RoyalBlue
        Me.But_send.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_send.Location = New System.Drawing.Point(5, 159)
        Me.But_send.Name = "But_send"
        Me.But_send.Size = New System.Drawing.Size(65, 24)
        Me.But_send.TabIndex = 60
        Me.But_send.Text = "Send"
        Me.But_send.UseVisualStyleBackColor = False
        '
        'But_get
        '
        Me.But_get.BackColor = System.Drawing.Color.Lime
        Me.But_get.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_get.Location = New System.Drawing.Point(3, 38)
        Me.But_get.Name = "But_get"
        Me.But_get.Size = New System.Drawing.Size(65, 24)
        Me.But_get.TabIndex = 61
        Me.But_get.Text = "Get"
        Me.But_get.UseVisualStyleBackColor = False
        '
        'pan_chalkboard
        '
        Me.pan_chalkboard.BackgroundImage = Global.jp_dragonbone1.My.Resources.Resources.blackboard
        Me.pan_chalkboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pan_chalkboard.Controls.Add(Me.Pan_boardviewingarea)
        Me.pan_chalkboard.Location = New System.Drawing.Point(78, 10)
        Me.pan_chalkboard.Name = "pan_chalkboard"
        Me.pan_chalkboard.Size = New System.Drawing.Size(348, 203)
        Me.pan_chalkboard.TabIndex = 73
        '
        'Pan_boardviewingarea
        '
        Me.Pan_boardviewingarea.Controls.Add(Me.Pan_noServer)
        Me.Pan_boardviewingarea.Controls.Add(Me.Pan_internetNodes)
        Me.Pan_boardviewingarea.Controls.Add(Me.Pan_comBase)
        Me.Pan_boardviewingarea.Controls.Add(Me.Pan_USBnodes)
        Me.Pan_boardviewingarea.Controls.Add(Me.Pan_wirelessnodes)
        Me.Pan_boardviewingarea.Controls.Add(Me.Lbl_availablelines)
        Me.Pan_boardviewingarea.Controls.Add(Me.LBL_linecount)
        Me.Pan_boardviewingarea.Location = New System.Drawing.Point(17, 13)
        Me.Pan_boardviewingarea.Name = "Pan_boardviewingarea"
        Me.Pan_boardviewingarea.Size = New System.Drawing.Size(309, 166)
        Me.Pan_boardviewingarea.TabIndex = 80
        '
        'Pan_noServer
        '
        Me.Pan_noServer.BackColor = System.Drawing.Color.White
        Me.Pan_noServer.Controls.Add(Me.lbl_999)
        Me.Pan_noServer.Location = New System.Drawing.Point(82, 72)
        Me.Pan_noServer.Name = "Pan_noServer"
        Me.Pan_noServer.Size = New System.Drawing.Size(221, 36)
        Me.Pan_noServer.TabIndex = 172
        Me.Pan_noServer.Visible = False
        '
        'lbl_999
        '
        Me.lbl_999.AutoSize = True
        Me.lbl_999.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_999.Location = New System.Drawing.Point(9, 12)
        Me.lbl_999.Name = "lbl_999"
        Me.lbl_999.Size = New System.Drawing.Size(209, 20)
        Me.lbl_999.TabIndex = 0
        Me.lbl_999.Text = "No Internet Connection Yet"
        '
        'Pan_internetNodes
        '
        Me.Pan_internetNodes.BackColor = System.Drawing.Color.White
        Me.Pan_internetNodes.Controls.Add(Me.Label80)
        Me.Pan_internetNodes.Controls.Add(Me.Pan_server_no_signs)
        Me.Pan_internetNodes.Controls.Add(Me.Node_internet3)
        Me.Pan_internetNodes.Controls.Add(Me.Node_internet1)
        Me.Pan_internetNodes.Controls.Add(Me.Node_internet2)
        Me.Pan_internetNodes.Location = New System.Drawing.Point(83, 74)
        Me.Pan_internetNodes.Name = "Pan_internetNodes"
        Me.Pan_internetNodes.Size = New System.Drawing.Size(189, 36)
        Me.Pan_internetNodes.TabIndex = 83
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(-5, 9)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(81, 25)
        Me.Label80.TabIndex = 96
        Me.Label80.Text = " Online"
        '
        'Pan_server_no_signs
        '
        Me.Pan_server_no_signs.BackColor = System.Drawing.Color.White
        Me.Pan_server_no_signs.Controls.Add(Me.Label81)
        Me.Pan_server_no_signs.Location = New System.Drawing.Point(64, 3)
        Me.Pan_server_no_signs.Name = "Pan_server_no_signs"
        Me.Pan_server_no_signs.Size = New System.Drawing.Size(122, 33)
        Me.Pan_server_no_signs.TabIndex = 171
        Me.Pan_server_no_signs.Visible = False
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label81.Location = New System.Drawing.Point(2, 8)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(156, 24)
        Me.Label81.TabIndex = 0
        Me.Label81.Text = "looking for signs.."
        '
        'Node_internet3
        '
        Me.Node_internet3.Location = New System.Drawing.Point(150, 4)
        Me.Node_internet3.Name = "Node_internet3"
        Me.Node_internet3.picture_percent = 70.0!
        Me.Node_internet3.selected_imagefile = ""
        Me.Node_internet3.selected_text = ""
        Me.Node_internet3.Size = New System.Drawing.Size(40, 30)
        Me.Node_internet3.state = jp_dragonbone1.node.nodestate.unavailable
        Me.Node_internet3.TabIndex = 90
        Me.Node_internet3.unavailable_imagefile = ""
        Me.Node_internet3.unavailable_text = ""
        Me.Node_internet3.unselected_imagefile = ""
        Me.Node_internet3.unselected_text = ""
        '
        'Node_internet1
        '
        Me.Node_internet1.Location = New System.Drawing.Point(60, 4)
        Me.Node_internet1.Name = "Node_internet1"
        Me.Node_internet1.picture_percent = 70.0!
        Me.Node_internet1.selected_imagefile = ""
        Me.Node_internet1.selected_text = ""
        Me.Node_internet1.Size = New System.Drawing.Size(40, 30)
        Me.Node_internet1.state = jp_dragonbone1.node.nodestate.unavailable
        Me.Node_internet1.TabIndex = 89
        Me.Node_internet1.unavailable_imagefile = ""
        Me.Node_internet1.unavailable_text = ""
        Me.Node_internet1.unselected_imagefile = ""
        Me.Node_internet1.unselected_text = ""
        '
        'Node_internet2
        '
        Me.Node_internet2.Location = New System.Drawing.Point(105, 4)
        Me.Node_internet2.Name = "Node_internet2"
        Me.Node_internet2.picture_percent = 70.0!
        Me.Node_internet2.selected_imagefile = ""
        Me.Node_internet2.selected_text = ""
        Me.Node_internet2.Size = New System.Drawing.Size(40, 30)
        Me.Node_internet2.state = jp_dragonbone1.node.nodestate.unavailable
        Me.Node_internet2.TabIndex = 97
        Me.Node_internet2.unavailable_imagefile = ""
        Me.Node_internet2.unavailable_text = ""
        Me.Node_internet2.unselected_imagefile = ""
        Me.Node_internet2.unselected_text = ""
        '
        'Pan_comBase
        '
        Me.Pan_comBase.BackColor = System.Drawing.Color.White
        Me.Pan_comBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pan_comBase.Controls.Add(Me.AIV_Internet)
        Me.Pan_comBase.Controls.Add(Me.AIV_Zigbee)
        Me.Pan_comBase.Controls.Add(Me.AIV_USB)
        Me.Pan_comBase.Location = New System.Drawing.Point(8, 3)
        Me.Pan_comBase.Name = "Pan_comBase"
        Me.Pan_comBase.Size = New System.Drawing.Size(61, 111)
        Me.Pan_comBase.TabIndex = 4
        '
        'AIV_Internet
        '
        Me.AIV_Internet.BackColor = System.Drawing.Color.White
        Me.AIV_Internet.Controls.Add(Me.lbl_internet_text)
        Me.AIV_Internet.imagefile = ""
        Me.AIV_Internet.Location = New System.Drawing.Point(0, 74)
        Me.AIV_Internet.Name = "AIV_Internet"
        Me.AIV_Internet.Size = New System.Drawing.Size(61, 36)
        Me.AIV_Internet.TabIndex = 81
        Me.AIV_Internet.Visible = False
        '
        'lbl_internet_text
        '
        Me.lbl_internet_text.AutoSize = True
        Me.lbl_internet_text.Location = New System.Drawing.Point(2, 4)
        Me.lbl_internet_text.Name = "lbl_internet_text"
        Me.lbl_internet_text.Size = New System.Drawing.Size(82, 34)
        Me.lbl_internet_text.TabIndex = 1
        Me.lbl_internet_text.Text = "No internet " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "image!"
        Me.lbl_internet_text.Visible = False
        '
        'AIV_Zigbee
        '
        Me.AIV_Zigbee.BackColor = System.Drawing.Color.White
        Me.AIV_Zigbee.Controls.Add(Me.Lbl_zigbee_text)
        Me.AIV_Zigbee.imagefile = ""
        Me.AIV_Zigbee.Location = New System.Drawing.Point(0, 37)
        Me.AIV_Zigbee.Name = "AIV_Zigbee"
        Me.AIV_Zigbee.Size = New System.Drawing.Size(61, 36)
        Me.AIV_Zigbee.TabIndex = 81
        Me.AIV_Zigbee.Visible = False
        '
        'Lbl_zigbee_text
        '
        Me.Lbl_zigbee_text.AutoSize = True
        Me.Lbl_zigbee_text.Location = New System.Drawing.Point(1, 5)
        Me.Lbl_zigbee_text.Name = "Lbl_zigbee_text"
        Me.Lbl_zigbee_text.Size = New System.Drawing.Size(78, 34)
        Me.Lbl_zigbee_text.TabIndex = 1
        Me.Lbl_zigbee_text.Text = "No Zigbee " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "image !"
        Me.Lbl_zigbee_text.Visible = False
        '
        'AIV_USB
        '
        Me.AIV_USB.BackColor = System.Drawing.Color.White
        Me.AIV_USB.Controls.Add(Me.Lbl_USB_text)
        Me.AIV_USB.imagefile = ""
        Me.AIV_USB.Location = New System.Drawing.Point(0, 0)
        Me.AIV_USB.Name = "AIV_USB"
        Me.AIV_USB.Size = New System.Drawing.Size(61, 36)
        Me.AIV_USB.TabIndex = 80
        Me.AIV_USB.Visible = False
        '
        'Lbl_USB_text
        '
        Me.Lbl_USB_text.AutoSize = True
        Me.Lbl_USB_text.Location = New System.Drawing.Point(6, 5)
        Me.Lbl_USB_text.Name = "Lbl_USB_text"
        Me.Lbl_USB_text.Size = New System.Drawing.Size(62, 34)
        Me.Lbl_USB_text.TabIndex = 1
        Me.Lbl_USB_text.Text = "No USB " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "image!"
        Me.Lbl_USB_text.Visible = False
        '
        'Pan_USBnodes
        '
        Me.Pan_USBnodes.BackColor = System.Drawing.Color.White
        Me.Pan_USBnodes.Controls.Add(Me.Label11)
        Me.Pan_USBnodes.Controls.Add(Me.Pan_noUSBFound)
        Me.Pan_USBnodes.Controls.Add(Me.Node_usb5)
        Me.Pan_USBnodes.Controls.Add(Me.Node_usb4)
        Me.Pan_USBnodes.Controls.Add(Me.Node_usb3)
        Me.Pan_USBnodes.Controls.Add(Me.Node_usb2)
        Me.Pan_USBnodes.Controls.Add(Me.Node_usb1)
        Me.Pan_USBnodes.Location = New System.Drawing.Point(83, 1)
        Me.Pan_USBnodes.Name = "Pan_USBnodes"
        Me.Pan_USBnodes.Size = New System.Drawing.Size(189, 36)
        Me.Pan_USBnodes.TabIndex = 79
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(51, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 13)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Available USB Signs"
        Me.Label11.Visible = False
        '
        'Pan_noUSBFound
        '
        Me.Pan_noUSBFound.BackColor = System.Drawing.Color.White
        Me.Pan_noUSBFound.Controls.Add(Me.Pan_wirelessBaseNoSigns)
        Me.Pan_noUSBFound.Controls.Add(Me.Label14)
        Me.Pan_noUSBFound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pan_noUSBFound.Location = New System.Drawing.Point(0, 0)
        Me.Pan_noUSBFound.Name = "Pan_noUSBFound"
        Me.Pan_noUSBFound.Size = New System.Drawing.Size(189, 36)
        Me.Pan_noUSBFound.TabIndex = 81
        '
        'Pan_wirelessBaseNoSigns
        '
        Me.Pan_wirelessBaseNoSigns.BackColor = System.Drawing.Color.White
        Me.Pan_wirelessBaseNoSigns.Controls.Add(Me.Label17)
        Me.Pan_wirelessBaseNoSigns.Location = New System.Drawing.Point(0, 36)
        Me.Pan_wirelessBaseNoSigns.Name = "Pan_wirelessBaseNoSigns"
        Me.Pan_wirelessBaseNoSigns.Size = New System.Drawing.Size(189, 36)
        Me.Pan_wirelessBaseNoSigns.TabIndex = 83
        Me.Pan_wirelessBaseNoSigns.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(8, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(227, 25)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Wireless OK, no sign yet"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "No USB , waiting"
        '
        'Node_usb5
        '
        Me.Node_usb5.Location = New System.Drawing.Point(150, 11)
        Me.Node_usb5.Name = "Node_usb5"
        Me.Node_usb5.picture_percent = 70.0!
        Me.Node_usb5.selected_imagefile = ""
        Me.Node_usb5.selected_text = ""
        Me.Node_usb5.Size = New System.Drawing.Size(33, 22)
        Me.Node_usb5.state = jp_dragonbone1.node.nodestate.unavailable
        Me.Node_usb5.TabIndex = 88
        Me.Node_usb5.unavailable_imagefile = ""
        Me.Node_usb5.unavailable_text = ""
        Me.Node_usb5.unselected_imagefile = ""
        Me.Node_usb5.unselected_text = ""
        '
        'Node_usb4
        '
        Me.Node_usb4.Location = New System.Drawing.Point(114, 11)
        Me.Node_usb4.Name = "Node_usb4"
        Me.Node_usb4.picture_percent = 70.0!
        Me.Node_usb4.selected_imagefile = ""
        Me.Node_usb4.selected_text = ""
        Me.Node_usb4.Size = New System.Drawing.Size(33, 22)
        Me.Node_usb4.state = jp_dragonbone1.node.nodestate.unavailable
        Me.Node_usb4.TabIndex = 87
        Me.Node_usb4.unavailable_imagefile = ""
        Me.Node_usb4.unavailable_text = ""
        Me.Node_usb4.unselected_imagefile = ""
        Me.Node_usb4.unselected_text = ""
        '
        'Node_usb3
        '
        Me.Node_usb3.Location = New System.Drawing.Point(78, 11)
        Me.Node_usb3.Name = "Node_usb3"
        Me.Node_usb3.picture_percent = 70.0!
        Me.Node_usb3.selected_imagefile = ""
        Me.Node_usb3.selected_text = ""
        Me.Node_usb3.Size = New System.Drawing.Size(33, 22)
        Me.Node_usb3.state = jp_dragonbone1.node.nodestate.unavailable
        Me.Node_usb3.TabIndex = 86
        Me.Node_usb3.unavailable_imagefile = ""
        Me.Node_usb3.unavailable_text = ""
        Me.Node_usb3.unselected_imagefile = ""
        Me.Node_usb3.unselected_text = ""
        '
        'Node_usb2
        '
        Me.Node_usb2.Location = New System.Drawing.Point(42, 11)
        Me.Node_usb2.Name = "Node_usb2"
        Me.Node_usb2.picture_percent = 70.0!
        Me.Node_usb2.selected_imagefile = ""
        Me.Node_usb2.selected_text = ""
        Me.Node_usb2.Size = New System.Drawing.Size(33, 22)
        Me.Node_usb2.state = jp_dragonbone1.node.nodestate.unavailable
        Me.Node_usb2.TabIndex = 85
        Me.Node_usb2.unavailable_imagefile = ""
        Me.Node_usb2.unavailable_text = ""
        Me.Node_usb2.unselected_imagefile = ""
        Me.Node_usb2.unselected_text = ""
        '
        'Node_usb1
        '
        Me.Node_usb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Node_usb1.ForeColor = System.Drawing.Color.Black
        Me.Node_usb1.Location = New System.Drawing.Point(6, 11)
        Me.Node_usb1.Name = "Node_usb1"
        Me.Node_usb1.picture_percent = 70.0!
        Me.Node_usb1.selected_imagefile = ""
        Me.Node_usb1.selected_text = ""
        Me.Node_usb1.Size = New System.Drawing.Size(172, 22)
        Me.Node_usb1.state = jp_dragonbone1.node.nodestate.unavailable
        Me.Node_usb1.TabIndex = 84
        Me.Node_usb1.unavailable_imagefile = ""
        Me.Node_usb1.unavailable_text = ""
        Me.Node_usb1.unselected_imagefile = ""
        Me.Node_usb1.unselected_text = ""
        '
        'Pan_wirelessnodes
        '
        Me.Pan_wirelessnodes.BackColor = System.Drawing.Color.White
        Me.Pan_wirelessnodes.Controls.Add(Me.Pan_noWireless)
        Me.Pan_wirelessnodes.Controls.Add(Me.Node_wireless3)
        Me.Pan_wirelessnodes.Controls.Add(Me.Node_wireless2)
        Me.Pan_wirelessnodes.Controls.Add(Me.Label12)
        Me.Pan_wirelessnodes.Controls.Add(Me.Node_wireless1)
        Me.Pan_wirelessnodes.Controls.Add(Me.Node_wireless5)
        Me.Pan_wirelessnodes.Controls.Add(Me.Node_wireless4)
        Me.Pan_wirelessnodes.Location = New System.Drawing.Point(83, 37)
        Me.Pan_wirelessnodes.Name = "Pan_wirelessnodes"
        Me.Pan_wirelessnodes.Size = New System.Drawing.Size(189, 36)
        Me.Pan_wirelessnodes.TabIndex = 80
        '
        'Pan_noWireless
        '
        Me.Pan_noWireless.BackColor = System.Drawing.Color.White
        Me.Pan_noWireless.Controls.Add(Me.Label16)
        Me.Pan_noWireless.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pan_noWireless.Location = New System.Drawing.Point(0, 0)
        Me.Pan_noWireless.Name = "Pan_noWireless"
        Me.Pan_noWireless.Size = New System.Drawing.Size(189, 36)
        Me.Pan_noWireless.TabIndex = 82
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(219, 20)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "No Wireless Connection Yet"
        '
        'Node_wireless3
        '
        Me.Node_wireless3.Location = New System.Drawing.Point(77, 10)
        Me.Node_wireless3.Name = "Node_wireless3"
        Me.Node_wireless3.picture_percent = 70.0!
        Me.Node_wireless3.selected_imagefile = ""
        Me.Node_wireless3.selected_text = ""
        Me.Node_wireless3.Size = New System.Drawing.Size(33, 22)
        Me.Node_wireless3.state = jp_dragonbone1.node.nodestate.unavailable
        Me.Node_wireless3.TabIndex = 90
        Me.Node_wireless3.unavailable_imagefile = ""
        Me.Node_wireless3.unavailable_text = ""
        Me.Node_wireless3.unselected_imagefile = ""
        Me.Node_wireless3.unselected_text = ""
        '
        'Node_wireless2
        '
        Me.Node_wireless2.Location = New System.Drawing.Point(41, 10)
        Me.Node_wireless2.Name = "Node_wireless2"
        Me.Node_wireless2.picture_percent = 70.0!
        Me.Node_wireless2.selected_imagefile = ""
        Me.Node_wireless2.selected_text = ""
        Me.Node_wireless2.Size = New System.Drawing.Size(33, 22)
        Me.Node_wireless2.state = jp_dragonbone1.node.nodestate.unavailable
        Me.Node_wireless2.TabIndex = 97
        Me.Node_wireless2.unavailable_imagefile = ""
        Me.Node_wireless2.unavailable_text = ""
        Me.Node_wireless2.unselected_imagefile = ""
        Me.Node_wireless2.unselected_text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(54, 1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 13)
        Me.Label12.TabIndex = 96
        Me.Label12.Text = "Available Wireless Signs"
        '
        'Node_wireless1
        '
        Me.Node_wireless1.Location = New System.Drawing.Point(5, 10)
        Me.Node_wireless1.Name = "Node_wireless1"
        Me.Node_wireless1.picture_percent = 70.0!
        Me.Node_wireless1.selected_imagefile = ""
        Me.Node_wireless1.selected_text = ""
        Me.Node_wireless1.Size = New System.Drawing.Size(33, 22)
        Me.Node_wireless1.state = jp_dragonbone1.node.nodestate.unavailable
        Me.Node_wireless1.TabIndex = 89
        Me.Node_wireless1.unavailable_imagefile = ""
        Me.Node_wireless1.unavailable_text = ""
        Me.Node_wireless1.unselected_imagefile = ""
        Me.Node_wireless1.unselected_text = ""
        '
        'Node_wireless5
        '
        Me.Node_wireless5.Location = New System.Drawing.Point(149, 10)
        Me.Node_wireless5.Name = "Node_wireless5"
        Me.Node_wireless5.picture_percent = 70.0!
        Me.Node_wireless5.selected_imagefile = ""
        Me.Node_wireless5.selected_text = ""
        Me.Node_wireless5.Size = New System.Drawing.Size(33, 22)
        Me.Node_wireless5.state = jp_dragonbone1.node.nodestate.unavailable
        Me.Node_wireless5.TabIndex = 99
        Me.Node_wireless5.unavailable_imagefile = ""
        Me.Node_wireless5.unavailable_text = ""
        Me.Node_wireless5.unselected_imagefile = ""
        Me.Node_wireless5.unselected_text = ""
        '
        'Node_wireless4
        '
        Me.Node_wireless4.Location = New System.Drawing.Point(113, 10)
        Me.Node_wireless4.Name = "Node_wireless4"
        Me.Node_wireless4.picture_percent = 70.0!
        Me.Node_wireless4.selected_imagefile = ""
        Me.Node_wireless4.selected_text = ""
        Me.Node_wireless4.Size = New System.Drawing.Size(33, 22)
        Me.Node_wireless4.state = jp_dragonbone1.node.nodestate.unavailable
        Me.Node_wireless4.TabIndex = 98
        Me.Node_wireless4.unavailable_imagefile = ""
        Me.Node_wireless4.unavailable_text = ""
        Me.Node_wireless4.unselected_imagefile = ""
        Me.Node_wireless4.unselected_text = ""
        '
        'Lbl_availablelines
        '
        Me.Lbl_availablelines.AutoSize = True
        Me.Lbl_availablelines.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_availablelines.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_availablelines.ForeColor = System.Drawing.Color.Red
        Me.Lbl_availablelines.Location = New System.Drawing.Point(144, 141)
        Me.Lbl_availablelines.Name = "Lbl_availablelines"
        Me.Lbl_availablelines.Size = New System.Drawing.Size(87, 17)
        Me.Lbl_availablelines.TabIndex = 77
        Me.Lbl_availablelines.Text = "0 available"
        '
        'LBL_linecount
        '
        Me.LBL_linecount.AllowDrop = True
        Me.LBL_linecount.AutoSize = True
        Me.LBL_linecount.BackColor = System.Drawing.Color.Transparent
        Me.LBL_linecount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_linecount.Location = New System.Drawing.Point(15, 140)
        Me.LBL_linecount.Name = "LBL_linecount"
        Me.LBL_linecount.Size = New System.Drawing.Size(298, 17)
        Me.LBL_linecount.TabIndex = 1
        Me.LBL_linecount.Text = "frame count: 0 used, 0 available, 0 total"
        '
        'Lbl_dialog
        '
        Me.Lbl_dialog.AutoSize = True
        Me.Lbl_dialog.BackColor = System.Drawing.Color.White
        Me.Lbl_dialog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_dialog.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_dialog.Location = New System.Drawing.Point(7, 10)
        Me.Lbl_dialog.Name = "Lbl_dialog"
        Me.Lbl_dialog.Size = New System.Drawing.Size(79, 26)
        Me.Lbl_dialog.TabIndex = 73
        Me.Lbl_dialog.Text = "Control"
        '
        'Pan_bluetabs
        '
        Me.Pan_bluetabs.BackColor = System.Drawing.Color.RoyalBlue
        Me.Pan_bluetabs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pan_bluetabs.Controls.Add(Me.Label98)
        Me.Pan_bluetabs.Controls.Add(Me.TabControl2)
        Me.Pan_bluetabs.Location = New System.Drawing.Point(240, 231)
        Me.Pan_bluetabs.Name = "Pan_bluetabs"
        Me.Pan_bluetabs.Size = New System.Drawing.Size(243, 441)
        Me.Pan_bluetabs.TabIndex = 60
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.BackColor = System.Drawing.Color.White
        Me.Label98.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label98.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(4, 7)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(54, 26)
        Me.Label98.TabIndex = 63
        Me.Label98.Text = "Sign"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage9)
        Me.TabControl2.Controls.Add(Me.TabPage10)
        Me.TabControl2.Controls.Add(Me.TabPage11)
        Me.TabControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(3, 34)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.Padding = New System.Drawing.Point(12, 3)
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(184, 361)
        Me.TabControl2.TabIndex = 0
        Me.TabControl2.Visible = False
        '
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TabPage9.Controls.Add(Me.Panel1)
        Me.TabPage9.Controls.Add(Me.Pan_demo_lines)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(176, 335)
        Me.TabPage9.TabIndex = 0
        Me.TabPage9.Text = "Sign"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Pan_demooption_multiline)
        Me.Panel1.Controls.Add(Me.Pan_demooption_oneline)
        Me.Panel1.Location = New System.Drawing.Point(-4, -11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 37)
        Me.Panel1.TabIndex = 52
        '
        'Pan_demooption_multiline
        '
        Me.Pan_demooption_multiline.BackColor = System.Drawing.Color.Khaki
        Me.Pan_demooption_multiline.Controls.Add(Me.Lbl_demooption_multiline)
        Me.Pan_demooption_multiline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pan_demooption_multiline.Location = New System.Drawing.Point(85, 14)
        Me.Pan_demooption_multiline.Name = "Pan_demooption_multiline"
        Me.Pan_demooption_multiline.Size = New System.Drawing.Size(58, 21)
        Me.Pan_demooption_multiline.TabIndex = 36
        '
        'Lbl_demooption_multiline
        '
        Me.Lbl_demooption_multiline.AutoSize = True
        Me.Lbl_demooption_multiline.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_demooption_multiline.ForeColor = System.Drawing.Color.Black
        Me.Lbl_demooption_multiline.Location = New System.Drawing.Point(-1, 4)
        Me.Lbl_demooption_multiline.Name = "Lbl_demooption_multiline"
        Me.Lbl_demooption_multiline.Size = New System.Drawing.Size(72, 15)
        Me.Lbl_demooption_multiline.TabIndex = 0
        Me.Lbl_demooption_multiline.Text = "Multi-Line"
        '
        'Pan_demooption_oneline
        '
        Me.Pan_demooption_oneline.BackColor = System.Drawing.Color.White
        Me.Pan_demooption_oneline.Controls.Add(Me.Lbl_demooption_oneline)
        Me.Pan_demooption_oneline.Location = New System.Drawing.Point(11, 15)
        Me.Pan_demooption_oneline.Name = "Pan_demooption_oneline"
        Me.Pan_demooption_oneline.Size = New System.Drawing.Size(56, 21)
        Me.Pan_demooption_oneline.TabIndex = 35
        '
        'Lbl_demooption_oneline
        '
        Me.Lbl_demooption_oneline.AutoSize = True
        Me.Lbl_demooption_oneline.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_demooption_oneline.ForeColor = System.Drawing.Color.Black
        Me.Lbl_demooption_oneline.Location = New System.Drawing.Point(3, 4)
        Me.Lbl_demooption_oneline.Name = "Lbl_demooption_oneline"
        Me.Lbl_demooption_oneline.Size = New System.Drawing.Size(65, 15)
        Me.Lbl_demooption_oneline.TabIndex = 0
        Me.Lbl_demooption_oneline.Text = "One Line"
        '
        'Pan_demo_lines
        '
        Me.Pan_demo_lines.BackColor = System.Drawing.Color.White
        Me.Pan_demo_lines.Controls.Add(Me.Pan_demo_multiline)
        Me.Pan_demo_lines.Controls.Add(Me.Pan_demo_oneline)
        Me.Pan_demo_lines.Location = New System.Drawing.Point(-4, 29)
        Me.Pan_demo_lines.Margin = New System.Windows.Forms.Padding(0)
        Me.Pan_demo_lines.Name = "Pan_demo_lines"
        Me.Pan_demo_lines.Size = New System.Drawing.Size(177, 252)
        Me.Pan_demo_lines.TabIndex = 53
        '
        'Pan_demo_multiline
        '
        Me.Pan_demo_multiline.BackColor = System.Drawing.Color.RoyalBlue
        Me.Pan_demo_multiline.Controls.Add(Me.Lbl_demoline0)
        Me.Pan_demo_multiline.Controls.Add(Me.Txt_demoline8)
        Me.Pan_demo_multiline.Controls.Add(Me.Pan_totaltime)
        Me.Pan_demo_multiline.Controls.Add(Me.Lbl_demoline1)
        Me.Pan_demo_multiline.Controls.Add(Me.Lbl_demoline3)
        Me.Pan_demo_multiline.Controls.Add(Me.Lbl_demoline2)
        Me.Pan_demo_multiline.Controls.Add(Me.Lbl_demoline4)
        Me.Pan_demo_multiline.Controls.Add(Me.Lbl_demoline9)
        Me.Pan_demo_multiline.Controls.Add(Me.Lbl_demoline8)
        Me.Pan_demo_multiline.Controls.Add(Me.Lbl_demoline7)
        Me.Pan_demo_multiline.Controls.Add(Me.Lbl_demoline5)
        Me.Pan_demo_multiline.Controls.Add(Me.Lbl_demoline6)
        Me.Pan_demo_multiline.Controls.Add(Me.Txt_demoline0)
        Me.Pan_demo_multiline.Controls.Add(Me.Txt_demoline1)
        Me.Pan_demo_multiline.Controls.Add(Me.Txt_demoline2)
        Me.Pan_demo_multiline.Controls.Add(Me.Txt_demoline3)
        Me.Pan_demo_multiline.Controls.Add(Me.Txt_demoline4)
        Me.Pan_demo_multiline.Controls.Add(Me.Txt_demoline5)
        Me.Pan_demo_multiline.Controls.Add(Me.Txt_demoline6)
        Me.Pan_demo_multiline.Controls.Add(Me.Txt_demoline7)
        Me.Pan_demo_multiline.Controls.Add(Me.Txt_demoline9)
        Me.Pan_demo_multiline.Location = New System.Drawing.Point(12, 65)
        Me.Pan_demo_multiline.Name = "Pan_demo_multiline"
        Me.Pan_demo_multiline.Size = New System.Drawing.Size(43, 38)
        Me.Pan_demo_multiline.TabIndex = 45
        '
        'Lbl_demoline0
        '
        Me.Lbl_demoline0.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_demoline0.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_demoline0.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_demoline0.Location = New System.Drawing.Point(4, 71)
        Me.Lbl_demoline0.Name = "Lbl_demoline0"
        Me.Lbl_demoline0.Size = New System.Drawing.Size(15, 9)
        Me.Lbl_demoline0.TabIndex = 25
        Me.Lbl_demoline0.Text = "1"
        Me.Lbl_demoline0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Txt_demoline8
        '
        Me.Txt_demoline8.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Txt_demoline8.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_demoline8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_demoline8.Location = New System.Drawing.Point(22, 274)
        Me.Txt_demoline8.MaxLength = 50
        Me.Txt_demoline8.Name = "Txt_demoline8"
        Me.Txt_demoline8.Size = New System.Drawing.Size(91, 24)
        Me.Txt_demoline8.TabIndex = 8
        Me.Txt_demoline8.Tag = "8"
        '
        'Pan_totaltime
        '
        Me.Pan_totaltime.Controls.Add(Me.lbl_totaltime)
        Me.Pan_totaltime.Location = New System.Drawing.Point(143, 289)
        Me.Pan_totaltime.Name = "Pan_totaltime"
        Me.Pan_totaltime.Size = New System.Drawing.Size(145, 10)
        Me.Pan_totaltime.TabIndex = 13
        '
        'lbl_totaltime
        '
        Me.lbl_totaltime.AutoSize = True
        Me.lbl_totaltime.BackColor = System.Drawing.Color.Yellow
        Me.lbl_totaltime.Location = New System.Drawing.Point(25, 8)
        Me.lbl_totaltime.Name = "lbl_totaltime"
        Me.lbl_totaltime.Size = New System.Drawing.Size(75, 15)
        Me.lbl_totaltime.TabIndex = 11
        Me.lbl_totaltime.Text = "Total Time"
        Me.lbl_totaltime.Visible = False
        '
        'Lbl_demoline1
        '
        Me.Lbl_demoline1.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_demoline1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_demoline1.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_demoline1.Location = New System.Drawing.Point(4, 98)
        Me.Lbl_demoline1.Name = "Lbl_demoline1"
        Me.Lbl_demoline1.Size = New System.Drawing.Size(15, 9)
        Me.Lbl_demoline1.TabIndex = 26
        Me.Lbl_demoline1.Text = "2"
        Me.Lbl_demoline1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl_demoline3
        '
        Me.Lbl_demoline3.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_demoline3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_demoline3.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_demoline3.Location = New System.Drawing.Point(4, 151)
        Me.Lbl_demoline3.Name = "Lbl_demoline3"
        Me.Lbl_demoline3.Size = New System.Drawing.Size(15, 9)
        Me.Lbl_demoline3.TabIndex = 27
        Me.Lbl_demoline3.Text = "4"
        Me.Lbl_demoline3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_demoline2
        '
        Me.Lbl_demoline2.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_demoline2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_demoline2.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_demoline2.Location = New System.Drawing.Point(4, 124)
        Me.Lbl_demoline2.Name = "Lbl_demoline2"
        Me.Lbl_demoline2.Size = New System.Drawing.Size(15, 9)
        Me.Lbl_demoline2.TabIndex = 28
        Me.Lbl_demoline2.Text = "3"
        Me.Lbl_demoline2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_demoline4
        '
        Me.Lbl_demoline4.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_demoline4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_demoline4.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_demoline4.Location = New System.Drawing.Point(4, 173)
        Me.Lbl_demoline4.Name = "Lbl_demoline4"
        Me.Lbl_demoline4.Size = New System.Drawing.Size(15, 9)
        Me.Lbl_demoline4.TabIndex = 29
        Me.Lbl_demoline4.Text = "5"
        Me.Lbl_demoline4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_demoline9
        '
        Me.Lbl_demoline9.AutoSize = True
        Me.Lbl_demoline9.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_demoline9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_demoline9.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_demoline9.Location = New System.Drawing.Point(3, 305)
        Me.Lbl_demoline9.Name = "Lbl_demoline9"
        Me.Lbl_demoline9.Size = New System.Drawing.Size(21, 13)
        Me.Lbl_demoline9.TabIndex = 30
        Me.Lbl_demoline9.Text = "10"
        '
        'Lbl_demoline8
        '
        Me.Lbl_demoline8.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_demoline8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_demoline8.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_demoline8.Location = New System.Drawing.Point(4, 280)
        Me.Lbl_demoline8.Name = "Lbl_demoline8"
        Me.Lbl_demoline8.Size = New System.Drawing.Size(15, 9)
        Me.Lbl_demoline8.TabIndex = 31
        Me.Lbl_demoline8.Text = "9"
        Me.Lbl_demoline8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_demoline7
        '
        Me.Lbl_demoline7.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_demoline7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_demoline7.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_demoline7.Location = New System.Drawing.Point(4, 252)
        Me.Lbl_demoline7.Name = "Lbl_demoline7"
        Me.Lbl_demoline7.Size = New System.Drawing.Size(15, 9)
        Me.Lbl_demoline7.TabIndex = 32
        Me.Lbl_demoline7.Text = "8"
        Me.Lbl_demoline7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_demoline5
        '
        Me.Lbl_demoline5.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_demoline5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_demoline5.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_demoline5.Location = New System.Drawing.Point(4, 201)
        Me.Lbl_demoline5.Name = "Lbl_demoline5"
        Me.Lbl_demoline5.Size = New System.Drawing.Size(15, 9)
        Me.Lbl_demoline5.TabIndex = 34
        Me.Lbl_demoline5.Text = "6"
        Me.Lbl_demoline5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_demoline6
        '
        Me.Lbl_demoline6.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_demoline6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_demoline6.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_demoline6.Location = New System.Drawing.Point(4, 227)
        Me.Lbl_demoline6.Name = "Lbl_demoline6"
        Me.Lbl_demoline6.Size = New System.Drawing.Size(15, 9)
        Me.Lbl_demoline6.TabIndex = 33
        Me.Lbl_demoline6.Text = "7"
        Me.Lbl_demoline6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_demoline0
        '
        Me.Txt_demoline0.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Txt_demoline0.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_demoline0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_demoline0.Location = New System.Drawing.Point(22, 66)
        Me.Txt_demoline0.MaxLength = 50
        Me.Txt_demoline0.Name = "Txt_demoline0"
        Me.Txt_demoline0.Size = New System.Drawing.Size(91, 24)
        Me.Txt_demoline0.TabIndex = 0
        Me.Txt_demoline0.Tag = "0"
        '
        'Txt_demoline1
        '
        Me.Txt_demoline1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Txt_demoline1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_demoline1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_demoline1.Location = New System.Drawing.Point(22, 92)
        Me.Txt_demoline1.MaxLength = 50
        Me.Txt_demoline1.Name = "Txt_demoline1"
        Me.Txt_demoline1.Size = New System.Drawing.Size(91, 24)
        Me.Txt_demoline1.TabIndex = 1
        Me.Txt_demoline1.Tag = "1"
        '
        'Txt_demoline2
        '
        Me.Txt_demoline2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Txt_demoline2.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_demoline2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_demoline2.Location = New System.Drawing.Point(22, 118)
        Me.Txt_demoline2.MaxLength = 50
        Me.Txt_demoline2.Name = "Txt_demoline2"
        Me.Txt_demoline2.Size = New System.Drawing.Size(91, 24)
        Me.Txt_demoline2.TabIndex = 2
        Me.Txt_demoline2.Tag = "2"
        '
        'Txt_demoline3
        '
        Me.Txt_demoline3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Txt_demoline3.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_demoline3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_demoline3.Location = New System.Drawing.Point(22, 144)
        Me.Txt_demoline3.MaxLength = 50
        Me.Txt_demoline3.Name = "Txt_demoline3"
        Me.Txt_demoline3.Size = New System.Drawing.Size(91, 24)
        Me.Txt_demoline3.TabIndex = 3
        Me.Txt_demoline3.Tag = "3"
        '
        'Txt_demoline4
        '
        Me.Txt_demoline4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Txt_demoline4.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_demoline4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_demoline4.Location = New System.Drawing.Point(22, 170)
        Me.Txt_demoline4.MaxLength = 50
        Me.Txt_demoline4.Name = "Txt_demoline4"
        Me.Txt_demoline4.Size = New System.Drawing.Size(91, 24)
        Me.Txt_demoline4.TabIndex = 4
        Me.Txt_demoline4.Tag = "4"
        '
        'Txt_demoline5
        '
        Me.Txt_demoline5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Txt_demoline5.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_demoline5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_demoline5.Location = New System.Drawing.Point(22, 196)
        Me.Txt_demoline5.MaxLength = 50
        Me.Txt_demoline5.Name = "Txt_demoline5"
        Me.Txt_demoline5.Size = New System.Drawing.Size(91, 24)
        Me.Txt_demoline5.TabIndex = 5
        Me.Txt_demoline5.Tag = "5"
        '
        'Txt_demoline6
        '
        Me.Txt_demoline6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Txt_demoline6.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_demoline6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_demoline6.Location = New System.Drawing.Point(22, 222)
        Me.Txt_demoline6.MaxLength = 50
        Me.Txt_demoline6.Name = "Txt_demoline6"
        Me.Txt_demoline6.Size = New System.Drawing.Size(91, 24)
        Me.Txt_demoline6.TabIndex = 6
        Me.Txt_demoline6.Tag = "6"
        '
        'Txt_demoline7
        '
        Me.Txt_demoline7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Txt_demoline7.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_demoline7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_demoline7.Location = New System.Drawing.Point(22, 248)
        Me.Txt_demoline7.MaxLength = 50
        Me.Txt_demoline7.Name = "Txt_demoline7"
        Me.Txt_demoline7.Size = New System.Drawing.Size(91, 24)
        Me.Txt_demoline7.TabIndex = 7
        Me.Txt_demoline7.Tag = "7"
        '
        'Txt_demoline9
        '
        Me.Txt_demoline9.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Txt_demoline9.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_demoline9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_demoline9.Location = New System.Drawing.Point(22, 300)
        Me.Txt_demoline9.MaxLength = 50
        Me.Txt_demoline9.Name = "Txt_demoline9"
        Me.Txt_demoline9.Size = New System.Drawing.Size(91, 24)
        Me.Txt_demoline9.TabIndex = 9
        Me.Txt_demoline9.Tag = "9"
        '
        'Pan_demo_oneline
        '
        Me.Pan_demo_oneline.BackColor = System.Drawing.Color.RoyalBlue
        Me.Pan_demo_oneline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pan_demo_oneline.Controls.Add(Me.But_shape_revarch)
        Me.Pan_demo_oneline.Controls.Add(Me.But_shape_arch)
        Me.Pan_demo_oneline.Controls.Add(Me.Pan_cardbackground)
        Me.Pan_demo_oneline.Controls.Add(Me.But_shape_straight)
        Me.Pan_demo_oneline.Controls.Add(Me.Txt_demo_oneline)
        Me.Pan_demo_oneline.Location = New System.Drawing.Point(2, 239)
        Me.Pan_demo_oneline.Name = "Pan_demo_oneline"
        Me.Pan_demo_oneline.Size = New System.Drawing.Size(165, 94)
        Me.Pan_demo_oneline.TabIndex = 28
        Me.Pan_demo_oneline.Visible = False
        '
        'But_shape_revarch
        '
        Me.But_shape_revarch.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_shape_revarch.Location = New System.Drawing.Point(83, 272)
        Me.But_shape_revarch.Name = "But_shape_revarch"
        Me.But_shape_revarch.Size = New System.Drawing.Size(43, 23)
        Me.But_shape_revarch.TabIndex = 7
        Me.But_shape_revarch.Text = "U"
        Me.But_shape_revarch.UseVisualStyleBackColor = True
        Me.But_shape_revarch.Visible = False
        '
        'But_shape_arch
        '
        Me.But_shape_arch.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_shape_arch.Location = New System.Drawing.Point(42, 272)
        Me.But_shape_arch.Name = "But_shape_arch"
        Me.But_shape_arch.Size = New System.Drawing.Size(41, 23)
        Me.But_shape_arch.TabIndex = 6
        Me.But_shape_arch.Text = "ARCH"
        Me.But_shape_arch.UseVisualStyleBackColor = True
        Me.But_shape_arch.Visible = False
        '
        'Pan_cardbackground
        '
        Me.Pan_cardbackground.BackColor = System.Drawing.Color.RoyalBlue
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard19)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard18)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard17)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard16)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard10)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard11)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard12)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard13)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard14)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard15)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard1)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard9)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard0)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard8)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard2)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard7)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard3)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard6)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard4)
        Me.Pan_cardbackground.Controls.Add(Me.LiteCard5)
        Me.Pan_cardbackground.Location = New System.Drawing.Point(0, -12)
        Me.Pan_cardbackground.Name = "Pan_cardbackground"
        Me.Pan_cardbackground.Size = New System.Drawing.Size(163, 85)
        Me.Pan_cardbackground.TabIndex = 2
        '
        'LiteCard19
        '
        Me.LiteCard19.Angle = 9.0R
        Me.LiteCard19.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard19.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard19.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard19.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard19.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard19.FontSize = 30.0!
        Me.LiteCard19.Left = 83.0!
        Me.LiteCard19.location = CType(resources.GetObject("LiteCard19.location"), System.Drawing.PointF)
        Me.LiteCard19.location = New System.Drawing.Point(83, 17)
        Me.LiteCard19.Name = "LiteCard19"
        Me.LiteCard19.Size = New System.Drawing.Size(28, 38)
        Me.LiteCard19.TabIndex = 38
        Me.LiteCard19.Tag = "19"
        Me.LiteCard19.Top = 17.0!
        Me.LiteCard19.Visible = False
        '
        'ContextMen_litecards
        '
        Me.ContextMen_litecards.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmi_bigclockwise, Me.cmi_smallclockwise, Me.cmi_bigcounterclockwise, Me.cmi_smallcounterclockwise})
        Me.ContextMen_litecards.Name = "ContextMen_litecards"
        Me.ContextMen_litecards.Size = New System.Drawing.Size(107, 92)
        '
        'cmi_bigclockwise
        '
        Me.cmi_bigclockwise.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmi_bigclockwise.Name = "cmi_bigclockwise"
        Me.cmi_bigclockwise.Size = New System.Drawing.Size(106, 22)
        Me.cmi_bigclockwise.Text = "ÊÊ"
        '
        'cmi_smallclockwise
        '
        Me.cmi_smallclockwise.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmi_smallclockwise.Name = "cmi_smallclockwise"
        Me.cmi_smallclockwise.Size = New System.Drawing.Size(106, 22)
        Me.cmi_smallclockwise.Text = "Ê"
        '
        'cmi_bigcounterclockwise
        '
        Me.cmi_bigcounterclockwise.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmi_bigcounterclockwise.Name = "cmi_bigcounterclockwise"
        Me.cmi_bigcounterclockwise.Size = New System.Drawing.Size(106, 22)
        Me.cmi_bigcounterclockwise.Text = "ÉÉ"
        '
        'cmi_smallcounterclockwise
        '
        Me.cmi_smallcounterclockwise.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmi_smallcounterclockwise.Name = "cmi_smallcounterclockwise"
        Me.cmi_smallcounterclockwise.Size = New System.Drawing.Size(106, 22)
        Me.cmi_smallcounterclockwise.Text = "É"
        '
        'LiteCard18
        '
        Me.LiteCard18.Angle = 9.0R
        Me.LiteCard18.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard18.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard18.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard18.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard18.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard18.FontSize = 30.0!
        Me.LiteCard18.Left = 75.0!
        Me.LiteCard18.location = CType(resources.GetObject("LiteCard18.location"), System.Drawing.PointF)
        Me.LiteCard18.location = New System.Drawing.Point(75, 17)
        Me.LiteCard18.Name = "LiteCard18"
        Me.LiteCard18.Size = New System.Drawing.Size(28, 38)
        Me.LiteCard18.TabIndex = 37
        Me.LiteCard18.Tag = "18"
        Me.LiteCard18.Top = 17.0!
        Me.LiteCard18.Visible = False
        '
        'LiteCard17
        '
        Me.LiteCard17.Angle = 9.0R
        Me.LiteCard17.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard17.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard17.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard17.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard17.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard17.FontSize = 30.0!
        Me.LiteCard17.Left = 67.0!
        Me.LiteCard17.location = CType(resources.GetObject("LiteCard17.location"), System.Drawing.PointF)
        Me.LiteCard17.location = New System.Drawing.Point(67, 17)
        Me.LiteCard17.Name = "LiteCard17"
        Me.LiteCard17.Size = New System.Drawing.Size(28, 38)
        Me.LiteCard17.TabIndex = 36
        Me.LiteCard17.Tag = "17"
        Me.LiteCard17.Top = 17.0!
        Me.LiteCard17.Visible = False
        '
        'LiteCard16
        '
        Me.LiteCard16.Angle = 9.0R
        Me.LiteCard16.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard16.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard16.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard16.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard16.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard16.FontSize = 30.0!
        Me.LiteCard16.Left = 129.0!
        Me.LiteCard16.location = CType(resources.GetObject("LiteCard16.location"), System.Drawing.PointF)
        Me.LiteCard16.location = New System.Drawing.Point(129, 17)
        Me.LiteCard16.Name = "LiteCard16"
        Me.LiteCard16.Size = New System.Drawing.Size(28, 38)
        Me.LiteCard16.TabIndex = 35
        Me.LiteCard16.Tag = "16"
        Me.LiteCard16.Top = 17.0!
        Me.LiteCard16.Visible = False
        '
        'LiteCard10
        '
        Me.LiteCard10.Angle = 45.0R
        Me.LiteCard10.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard10.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard10.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard10.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard10.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard10.FontSize = 30.0!
        Me.LiteCard10.Left = 86.0!
        Me.LiteCard10.location = CType(resources.GetObject("LiteCard10.location"), System.Drawing.PointF)
        Me.LiteCard10.location = New System.Drawing.Point(86, 52)
        Me.LiteCard10.Name = "LiteCard10"
        Me.LiteCard10.Size = New System.Drawing.Size(40, 40)
        Me.LiteCard10.TabIndex = 20
        Me.LiteCard10.Tag = "10"
        Me.LiteCard10.Top = 52.0!
        Me.LiteCard10.Visible = False
        '
        'LiteCard11
        '
        Me.LiteCard11.Angle = 37.0R
        Me.LiteCard11.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard11.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard11.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard11.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard11.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard11.FontSize = 30.0!
        Me.LiteCard11.Left = 71.0!
        Me.LiteCard11.location = CType(resources.GetObject("LiteCard11.location"), System.Drawing.PointF)
        Me.LiteCard11.location = New System.Drawing.Point(71, 39)
        Me.LiteCard11.Name = "LiteCard11"
        Me.LiteCard11.Size = New System.Drawing.Size(39, 41)
        Me.LiteCard11.TabIndex = 19
        Me.LiteCard11.Tag = "11"
        Me.LiteCard11.Top = 39.0!
        Me.LiteCard11.Visible = False
        '
        'LiteCard12
        '
        Me.LiteCard12.Angle = 27.0R
        Me.LiteCard12.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard12.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard12.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard12.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard12.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard12.FontSize = 30.0!
        Me.LiteCard12.Left = 55.0!
        Me.LiteCard12.location = CType(resources.GetObject("LiteCard12.location"), System.Drawing.PointF)
        Me.LiteCard12.location = New System.Drawing.Point(55, 29)
        Me.LiteCard12.Name = "LiteCard12"
        Me.LiteCard12.Size = New System.Drawing.Size(36, 41)
        Me.LiteCard12.TabIndex = 18
        Me.LiteCard12.Tag = "12"
        Me.LiteCard12.Top = 29.0!
        Me.LiteCard12.Visible = False
        '
        'LiteCard13
        '
        Me.LiteCard13.Angle = 18.0R
        Me.LiteCard13.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard13.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard13.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard13.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard13.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard13.FontSize = 30.0!
        Me.LiteCard13.Left = 39.0!
        Me.LiteCard13.location = CType(resources.GetObject("LiteCard13.location"), System.Drawing.PointF)
        Me.LiteCard13.location = New System.Drawing.Point(39, 22)
        Me.LiteCard13.Name = "LiteCard13"
        Me.LiteCard13.Size = New System.Drawing.Size(32, 40)
        Me.LiteCard13.TabIndex = 17
        Me.LiteCard13.Tag = "13"
        Me.LiteCard13.Top = 22.0!
        Me.LiteCard13.Visible = False
        '
        'LiteCard14
        '
        Me.LiteCard14.Angle = -9.0R
        Me.LiteCard14.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard14.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard14.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard14.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard14.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard14.FontSize = 30.0!
        Me.LiteCard14.Left = 7.0!
        Me.LiteCard14.location = CType(resources.GetObject("LiteCard14.location"), System.Drawing.PointF)
        Me.LiteCard14.location = New System.Drawing.Point(7, 17)
        Me.LiteCard14.Name = "LiteCard14"
        Me.LiteCard14.Size = New System.Drawing.Size(28, 38)
        Me.LiteCard14.TabIndex = 15
        Me.LiteCard14.Tag = "14"
        Me.LiteCard14.Top = 17.0!
        Me.LiteCard14.Visible = False
        '
        'LiteCard15
        '
        Me.LiteCard15.Angle = 9.0R
        Me.LiteCard15.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard15.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard15.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard15.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard15.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard15.FontSize = 30.0!
        Me.LiteCard15.Left = 23.0!
        Me.LiteCard15.location = CType(resources.GetObject("LiteCard15.location"), System.Drawing.PointF)
        Me.LiteCard15.location = New System.Drawing.Point(23, 17)
        Me.LiteCard15.Name = "LiteCard15"
        Me.LiteCard15.Size = New System.Drawing.Size(28, 38)
        Me.LiteCard15.TabIndex = 16
        Me.LiteCard15.Tag = "15"
        Me.LiteCard15.Top = 17.0!
        Me.LiteCard15.Visible = False
        '
        'LiteCard1
        '
        Me.LiteCard1.Angle = -36.0R
        Me.LiteCard1.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard1.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard1.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard1.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard1.FontSize = 30.0!
        Me.LiteCard1.Left = 18.0!
        Me.LiteCard1.location = CType(resources.GetObject("LiteCard1.location"), System.Drawing.PointF)
        Me.LiteCard1.location = New System.Drawing.Point(18, 39)
        Me.LiteCard1.Name = "LiteCard1"
        Me.LiteCard1.Size = New System.Drawing.Size(38, 41)
        Me.LiteCard1.TabIndex = 6
        Me.LiteCard1.Tag = "1"
        Me.LiteCard1.Top = 39.0!
        Me.LiteCard1.Visible = False
        '
        'LiteCard9
        '
        Me.LiteCard9.Angle = 45.0R
        Me.LiteCard9.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard9.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard9.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard9.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard9.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard9.FontSize = 30.0!
        Me.LiteCard9.Left = 145.0!
        Me.LiteCard9.location = CType(resources.GetObject("LiteCard9.location"), System.Drawing.PointF)
        Me.LiteCard9.location = New System.Drawing.Point(145, 52)
        Me.LiteCard9.Name = "LiteCard9"
        Me.LiteCard9.Size = New System.Drawing.Size(40, 40)
        Me.LiteCard9.TabIndex = 14
        Me.LiteCard9.Tag = "9"
        Me.LiteCard9.Top = 52.0!
        Me.LiteCard9.Visible = False
        '
        'LiteCard0
        '
        Me.LiteCard0.Angle = -45.0R
        Me.LiteCard0.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard0.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard0.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard0.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard0.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard0.FontSize = 30.0!
        Me.LiteCard0.Left = 2.0!
        Me.LiteCard0.location = CType(resources.GetObject("LiteCard0.location"), System.Drawing.PointF)
        Me.LiteCard0.location = New System.Drawing.Point(2, 52)
        Me.LiteCard0.Name = "LiteCard0"
        Me.LiteCard0.Size = New System.Drawing.Size(40, 40)
        Me.LiteCard0.TabIndex = 5
        Me.LiteCard0.Tag = "0"
        Me.LiteCard0.Top = 52.0!
        Me.LiteCard0.Visible = False
        '
        'LiteCard8
        '
        Me.LiteCard8.Angle = 37.0R
        Me.LiteCard8.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard8.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard8.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard8.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard8.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard8.FontSize = 30.0!
        Me.LiteCard8.Left = 130.0!
        Me.LiteCard8.location = CType(resources.GetObject("LiteCard8.location"), System.Drawing.PointF)
        Me.LiteCard8.location = New System.Drawing.Point(130, 39)
        Me.LiteCard8.Name = "LiteCard8"
        Me.LiteCard8.Size = New System.Drawing.Size(39, 41)
        Me.LiteCard8.TabIndex = 13
        Me.LiteCard8.Tag = "8"
        Me.LiteCard8.Top = 39.0!
        Me.LiteCard8.Visible = False
        '
        'LiteCard2
        '
        Me.LiteCard2.Angle = -27.0R
        Me.LiteCard2.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard2.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard2.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard2.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard2.FontSize = 30.0!
        Me.LiteCard2.Left = 34.0!
        Me.LiteCard2.location = CType(resources.GetObject("LiteCard2.location"), System.Drawing.PointF)
        Me.LiteCard2.location = New System.Drawing.Point(34, 29)
        Me.LiteCard2.Name = "LiteCard2"
        Me.LiteCard2.Size = New System.Drawing.Size(36, 41)
        Me.LiteCard2.TabIndex = 7
        Me.LiteCard2.Tag = "2"
        Me.LiteCard2.Top = 29.0!
        Me.LiteCard2.Visible = False
        '
        'LiteCard7
        '
        Me.LiteCard7.Angle = 27.0R
        Me.LiteCard7.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard7.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard7.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard7.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard7.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard7.FontSize = 30.0!
        Me.LiteCard7.Left = 114.0!
        Me.LiteCard7.location = CType(resources.GetObject("LiteCard7.location"), System.Drawing.PointF)
        Me.LiteCard7.location = New System.Drawing.Point(114, 29)
        Me.LiteCard7.Name = "LiteCard7"
        Me.LiteCard7.Size = New System.Drawing.Size(36, 41)
        Me.LiteCard7.TabIndex = 12
        Me.LiteCard7.Tag = "7"
        Me.LiteCard7.Top = 29.0!
        Me.LiteCard7.Visible = False
        '
        'LiteCard3
        '
        Me.LiteCard3.Angle = -18.0R
        Me.LiteCard3.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard3.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard3.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard3.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard3.FontSize = 30.0!
        Me.LiteCard3.Left = 50.0!
        Me.LiteCard3.location = CType(resources.GetObject("LiteCard3.location"), System.Drawing.PointF)
        Me.LiteCard3.location = New System.Drawing.Point(50, 22)
        Me.LiteCard3.Name = "LiteCard3"
        Me.LiteCard3.Size = New System.Drawing.Size(32, 40)
        Me.LiteCard3.TabIndex = 8
        Me.LiteCard3.Tag = "3"
        Me.LiteCard3.Top = 22.0!
        Me.LiteCard3.Visible = False
        '
        'LiteCard6
        '
        Me.LiteCard6.Angle = 18.0R
        Me.LiteCard6.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard6.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard6.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard6.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard6.FontSize = 30.0!
        Me.LiteCard6.Left = 98.0!
        Me.LiteCard6.location = CType(resources.GetObject("LiteCard6.location"), System.Drawing.PointF)
        Me.LiteCard6.location = New System.Drawing.Point(98, 22)
        Me.LiteCard6.Name = "LiteCard6"
        Me.LiteCard6.Size = New System.Drawing.Size(32, 40)
        Me.LiteCard6.TabIndex = 11
        Me.LiteCard6.Tag = "6"
        Me.LiteCard6.Top = 22.0!
        Me.LiteCard6.Visible = False
        '
        'LiteCard4
        '
        Me.LiteCard4.Angle = -9.0R
        Me.LiteCard4.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard4.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard4.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard4.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard4.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard4.FontSize = 30.0!
        Me.LiteCard4.Left = 66.0!
        Me.LiteCard4.location = CType(resources.GetObject("LiteCard4.location"), System.Drawing.PointF)
        Me.LiteCard4.location = New System.Drawing.Point(66, 17)
        Me.LiteCard4.Name = "LiteCard4"
        Me.LiteCard4.Size = New System.Drawing.Size(28, 38)
        Me.LiteCard4.TabIndex = 9
        Me.LiteCard4.Tag = "4"
        Me.LiteCard4.Top = 17.0!
        Me.LiteCard4.Visible = False
        '
        'LiteCard5
        '
        Me.LiteCard5.Angle = 9.0R
        Me.LiteCard5.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard5.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard5.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard5.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.LiteCard5.FontSize = 30.0!
        Me.LiteCard5.Left = 82.0!
        Me.LiteCard5.location = CType(resources.GetObject("LiteCard5.location"), System.Drawing.PointF)
        Me.LiteCard5.location = New System.Drawing.Point(82, 17)
        Me.LiteCard5.Name = "LiteCard5"
        Me.LiteCard5.Size = New System.Drawing.Size(28, 38)
        Me.LiteCard5.TabIndex = 10
        Me.LiteCard5.Tag = "5"
        Me.LiteCard5.Top = 17.0!
        Me.LiteCard5.Visible = False
        '
        'But_shape_straight
        '
        Me.But_shape_straight.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_shape_straight.Location = New System.Drawing.Point(6, 272)
        Me.But_shape_straight.Name = "But_shape_straight"
        Me.But_shape_straight.Size = New System.Drawing.Size(36, 23)
        Me.But_shape_straight.TabIndex = 5
        Me.But_shape_straight.Text = "LINE"
        Me.But_shape_straight.UseVisualStyleBackColor = True
        Me.But_shape_straight.Visible = False
        '
        'Txt_demo_oneline
        '
        Me.Txt_demo_oneline.BackColor = System.Drawing.Color.Lime
        Me.Txt_demo_oneline.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_demo_oneline.ForeColor = System.Drawing.Color.Red
        Me.Txt_demo_oneline.Location = New System.Drawing.Point(27, 219)
        Me.Txt_demo_oneline.Name = "Txt_demo_oneline"
        Me.Txt_demo_oneline.Size = New System.Drawing.Size(71, 37)
        Me.Txt_demo_oneline.TabIndex = 1
        Me.Txt_demo_oneline.Visible = False
        '
        'TabPage10
        '
        Me.TabPage10.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TabPage10.Controls.Add(Me.Lbl_catdown)
        Me.TabPage10.Controls.Add(Me.pan_cat2)
        Me.TabPage10.Controls.Add(Me.LBL_catup)
        Me.TabPage10.Controls.Add(Me.Pan_cat1)
        Me.TabPage10.Controls.Add(Me.But_selectvideo)
        Me.TabPage10.Controls.Add(Me.CB_videolist)
        Me.TabPage10.Controls.Add(Me.WebBrowser1)
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(176, 335)
        Me.TabPage10.TabIndex = 1
        Me.TabPage10.Text = "Video"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'Lbl_catdown
        '
        Me.Lbl_catdown.AutoSize = True
        Me.Lbl_catdown.Location = New System.Drawing.Point(64, 68)
        Me.Lbl_catdown.Name = "Lbl_catdown"
        Me.Lbl_catdown.Size = New System.Drawing.Size(49, 15)
        Me.Lbl_catdown.TabIndex = 39
        Me.Lbl_catdown.Text = "DOWN"
        '
        'pan_cat2
        '
        Me.pan_cat2.BackColor = System.Drawing.Color.Khaki
        Me.pan_cat2.Controls.Add(Me.Lbl_cat2)
        Me.pan_cat2.Location = New System.Drawing.Point(11, 44)
        Me.pan_cat2.Name = "pan_cat2"
        Me.pan_cat2.Size = New System.Drawing.Size(137, 19)
        Me.pan_cat2.TabIndex = 38
        '
        'Lbl_cat2
        '
        Me.Lbl_cat2.AutoSize = True
        Me.Lbl_cat2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_cat2.ForeColor = System.Drawing.Color.Black
        Me.Lbl_cat2.Location = New System.Drawing.Point(3, 2)
        Me.Lbl_cat2.Name = "Lbl_cat2"
        Me.Lbl_cat2.Size = New System.Drawing.Size(64, 17)
        Me.Lbl_cat2.TabIndex = 0
        Me.Lbl_cat2.Text = "Cat one"
        '
        'LBL_catup
        '
        Me.LBL_catup.AutoSize = True
        Me.LBL_catup.Location = New System.Drawing.Point(70, 5)
        Me.LBL_catup.Name = "LBL_catup"
        Me.LBL_catup.Size = New System.Drawing.Size(26, 15)
        Me.LBL_catup.TabIndex = 37
        Me.LBL_catup.Text = "UP"
        '
        'Pan_cat1
        '
        Me.Pan_cat1.BackColor = System.Drawing.Color.Khaki
        Me.Pan_cat1.Controls.Add(Me.Lbl_cat1)
        Me.Pan_cat1.Location = New System.Drawing.Point(10, 21)
        Me.Pan_cat1.Name = "Pan_cat1"
        Me.Pan_cat1.Size = New System.Drawing.Size(137, 19)
        Me.Pan_cat1.TabIndex = 36
        '
        'Lbl_cat1
        '
        Me.Lbl_cat1.AutoSize = True
        Me.Lbl_cat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_cat1.ForeColor = System.Drawing.Color.Black
        Me.Lbl_cat1.Location = New System.Drawing.Point(3, 2)
        Me.Lbl_cat1.Name = "Lbl_cat1"
        Me.Lbl_cat1.Size = New System.Drawing.Size(64, 17)
        Me.Lbl_cat1.TabIndex = 0
        Me.Lbl_cat1.Text = "Cat one"
        '
        'But_selectvideo
        '
        Me.But_selectvideo.Location = New System.Drawing.Point(44, 110)
        Me.But_selectvideo.Name = "But_selectvideo"
        Me.But_selectvideo.Size = New System.Drawing.Size(75, 23)
        Me.But_selectvideo.TabIndex = 2
        Me.But_selectvideo.Text = "Select Video"
        Me.But_selectvideo.UseVisualStyleBackColor = True
        '
        'CB_videolist
        '
        Me.CB_videolist.FormattingEnabled = True
        Me.CB_videolist.Location = New System.Drawing.Point(4, 86)
        Me.CB_videolist.Name = "CB_videolist"
        Me.CB_videolist.Size = New System.Drawing.Size(151, 21)
        Me.CB_videolist.TabIndex = 1
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(4, 136)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(154, 170)
        Me.WebBrowser1.TabIndex = 0
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.pan_no_pictures)
        Me.TabPage11.Controls.Add(Me.Pan_pictureselect_buttons1)
        Me.TabPage11.Controls.Add(Me.Pan_pictureselect_buttons2)
        Me.TabPage11.Controls.Add(Me.Pan_pictureselect_menu)
        Me.TabPage11.Controls.Add(Me.Panel35)
        Me.TabPage11.Controls.Add(Me.Label69)
        Me.TabPage11.Controls.Add(Me.PictureBox)
        Me.TabPage11.Location = New System.Drawing.Point(4, 22)
        Me.TabPage11.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(176, 335)
        Me.TabPage11.TabIndex = 2
        Me.TabPage11.Text = "Picture"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'pan_no_pictures
        '
        Me.pan_no_pictures.BackColor = System.Drawing.Color.RoyalBlue
        Me.pan_no_pictures.Controls.Add(Me.Label67)
        Me.pan_no_pictures.Location = New System.Drawing.Point(24, 124)
        Me.pan_no_pictures.Name = "pan_no_pictures"
        Me.pan_no_pictures.Size = New System.Drawing.Size(152, 325)
        Me.pan_no_pictures.TabIndex = 2
        Me.pan_no_pictures.Visible = False
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(20, 53)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(159, 62)
        Me.Label67.TabIndex = 0
        Me.Label67.Text = "No pictures " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "found!"
        '
        'Pan_pictureselect_buttons1
        '
        Me.Pan_pictureselect_buttons1.Controls.Add(Me.But_prev_picture)
        Me.Pan_pictureselect_buttons1.Location = New System.Drawing.Point(0, 73)
        Me.Pan_pictureselect_buttons1.Name = "Pan_pictureselect_buttons1"
        Me.Pan_pictureselect_buttons1.Size = New System.Drawing.Size(169, 49)
        Me.Pan_pictureselect_buttons1.TabIndex = 62
        '
        'But_prev_picture
        '
        Me.But_prev_picture.Location = New System.Drawing.Point(42, 12)
        Me.But_prev_picture.Name = "But_prev_picture"
        Me.But_prev_picture.Size = New System.Drawing.Size(75, 23)
        Me.But_prev_picture.TabIndex = 0
        Me.But_prev_picture.Text = "Previous"
        Me.But_prev_picture.UseVisualStyleBackColor = True
        Me.But_prev_picture.Visible = False
        '
        'Pan_pictureselect_buttons2
        '
        Me.Pan_pictureselect_buttons2.Controls.Add(Me.But_next_picture)
        Me.Pan_pictureselect_buttons2.Location = New System.Drawing.Point(7, 253)
        Me.Pan_pictureselect_buttons2.Name = "Pan_pictureselect_buttons2"
        Me.Pan_pictureselect_buttons2.Size = New System.Drawing.Size(146, 41)
        Me.Pan_pictureselect_buttons2.TabIndex = 61
        '
        'But_next_picture
        '
        Me.But_next_picture.Location = New System.Drawing.Point(43, 9)
        Me.But_next_picture.Name = "But_next_picture"
        Me.But_next_picture.Size = New System.Drawing.Size(75, 23)
        Me.But_next_picture.TabIndex = 1
        Me.But_next_picture.Text = "Next"
        Me.But_next_picture.UseVisualStyleBackColor = True
        '
        'Pan_pictureselect_menu
        '
        Me.Pan_pictureselect_menu.Controls.Add(Me.CB_pictures)
        Me.Pan_pictureselect_menu.Location = New System.Drawing.Point(1, 73)
        Me.Pan_pictureselect_menu.Name = "Pan_pictureselect_menu"
        Me.Pan_pictureselect_menu.Size = New System.Drawing.Size(170, 48)
        Me.Pan_pictureselect_menu.TabIndex = 60
        Me.Pan_pictureselect_menu.Visible = False
        '
        'CB_pictures
        '
        Me.CB_pictures.FormattingEnabled = True
        Me.CB_pictures.Location = New System.Drawing.Point(8, 11)
        Me.CB_pictures.Name = "CB_pictures"
        Me.CB_pictures.Size = New System.Drawing.Size(156, 21)
        Me.CB_pictures.TabIndex = 40
        '
        'Panel35
        '
        Me.Panel35.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel35.Controls.Add(Me.Label66)
        Me.Panel35.Controls.Add(Me.pan_picture_select_buttons)
        Me.Panel35.Controls.Add(Me.pan_picture_select_menu)
        Me.Panel35.Location = New System.Drawing.Point(0, 5)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(173, 63)
        Me.Panel35.TabIndex = 59
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(20, 7)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(166, 15)
        Me.Label66.TabIndex = 38
        Me.Label66.Text = "Picture selection method"
        '
        'pan_picture_select_buttons
        '
        Me.pan_picture_select_buttons.BackColor = System.Drawing.Color.Khaki
        Me.pan_picture_select_buttons.Controls.Add(Me.lbl_picture_select_buttons)
        Me.pan_picture_select_buttons.Location = New System.Drawing.Point(17, 30)
        Me.pan_picture_select_buttons.Name = "pan_picture_select_buttons"
        Me.pan_picture_select_buttons.Size = New System.Drawing.Size(57, 21)
        Me.pan_picture_select_buttons.TabIndex = 37
        '
        'lbl_picture_select_buttons
        '
        Me.lbl_picture_select_buttons.AutoSize = True
        Me.lbl_picture_select_buttons.BackColor = System.Drawing.Color.Khaki
        Me.lbl_picture_select_buttons.ForeColor = System.Drawing.Color.Black
        Me.lbl_picture_select_buttons.Location = New System.Drawing.Point(4, 4)
        Me.lbl_picture_select_buttons.Name = "lbl_picture_select_buttons"
        Me.lbl_picture_select_buttons.Size = New System.Drawing.Size(55, 15)
        Me.lbl_picture_select_buttons.TabIndex = 0
        Me.lbl_picture_select_buttons.Text = "Buttons"
        '
        'pan_picture_select_menu
        '
        Me.pan_picture_select_menu.BackColor = System.Drawing.Color.White
        Me.pan_picture_select_menu.Controls.Add(Me.lbl_picture_select_menu)
        Me.pan_picture_select_menu.Location = New System.Drawing.Point(89, 30)
        Me.pan_picture_select_menu.Name = "pan_picture_select_menu"
        Me.pan_picture_select_menu.Size = New System.Drawing.Size(55, 21)
        Me.pan_picture_select_menu.TabIndex = 35
        '
        'lbl_picture_select_menu
        '
        Me.lbl_picture_select_menu.AutoSize = True
        Me.lbl_picture_select_menu.ForeColor = System.Drawing.Color.Black
        Me.lbl_picture_select_menu.Location = New System.Drawing.Point(10, 4)
        Me.lbl_picture_select_menu.Name = "lbl_picture_select_menu"
        Me.lbl_picture_select_menu.Size = New System.Drawing.Size(43, 15)
        Me.lbl_picture_select_menu.TabIndex = 0
        Me.lbl_picture_select_menu.Text = "menu"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(63, 1)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(0, 15)
        Me.Label69.TabIndex = 57
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(7, 130)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(146, 118)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 58
        Me.PictureBox.TabStop = False
        '
        'Pan_Control
        '
        Me.Pan_Control.BackColor = System.Drawing.Color.Azure
        Me.Pan_Control.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pan_Control.Controls.Add(Me.Label99)
        Me.Pan_Control.Controls.Add(Me.But_connect)
        Me.Pan_Control.Location = New System.Drawing.Point(554, 186)
        Me.Pan_Control.Name = "Pan_Control"
        Me.Pan_Control.Padding = New System.Windows.Forms.Padding(3)
        Me.Pan_Control.Size = New System.Drawing.Size(241, 30)
        Me.Pan_Control.TabIndex = 68
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.BackColor = System.Drawing.Color.Silver
        Me.Label99.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(5, -1)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(84, 27)
        Me.Label99.TabIndex = 67
        Me.Label99.Text = "Control"
        '
        'But_connect
        '
        Me.But_connect.BackColor = System.Drawing.Color.Red
        Me.But_connect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_connect.Location = New System.Drawing.Point(105, 2)
        Me.But_connect.Name = "But_connect"
        Me.But_connect.Size = New System.Drawing.Size(65, 24)
        Me.But_connect.TabIndex = 72
        Me.But_connect.Text = "Connect"
        Me.But_connect.UseVisualStyleBackColor = False
        '
        'Pan_beginners_help
        '
        Me.Pan_beginners_help.Controls.Add(Me.Pan_Usermanuel_small)
        Me.Pan_beginners_help.Controls.Add(Me.PDFview_usermanuel_small)
        Me.Pan_beginners_help.Controls.Add(Me.TB_monitor_comm_error)
        Me.Pan_beginners_help.Controls.Add(Me.But_hide_pan_beginners)
        Me.Pan_beginners_help.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pan_beginners_help.Location = New System.Drawing.Point(11, 691)
        Me.Pan_beginners_help.Name = "Pan_beginners_help"
        Me.Pan_beginners_help.Size = New System.Drawing.Size(378, 26)
        Me.Pan_beginners_help.TabIndex = 52
        '
        'Pan_Usermanuel_small
        '
        Me.Pan_Usermanuel_small.BackgroundImage = Global.jp_dragonbone1.My.Resources.Resources.TiniWindowUserManu_Page_1
        Me.Pan_Usermanuel_small.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pan_Usermanuel_small.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pan_Usermanuel_small.Location = New System.Drawing.Point(0, 0)
        Me.Pan_Usermanuel_small.Name = "Pan_Usermanuel_small"
        Me.Pan_Usermanuel_small.Size = New System.Drawing.Size(378, 26)
        Me.Pan_Usermanuel_small.TabIndex = 28
        Me.Pan_Usermanuel_small.Visible = False
        '
        'PDFview_usermanuel_small
        '
        Me.PDFview_usermanuel_small.Enabled = True
        Me.PDFview_usermanuel_small.Location = New System.Drawing.Point(0, 158)
        Me.PDFview_usermanuel_small.Name = "PDFview_usermanuel_small"
        Me.PDFview_usermanuel_small.OcxState = CType(resources.GetObject("PDFview_usermanuel_small.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PDFview_usermanuel_small.Size = New System.Drawing.Size(240, 240)
        Me.PDFview_usermanuel_small.TabIndex = 27
        Me.PDFview_usermanuel_small.Visible = False
        '
        'TB_monitor_comm_error
        '
        Me.TB_monitor_comm_error.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TB_monitor_comm_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_monitor_comm_error.ForeColor = System.Drawing.Color.Red
        Me.TB_monitor_comm_error.Location = New System.Drawing.Point(-1, 126)
        Me.TB_monitor_comm_error.Multiline = True
        Me.TB_monitor_comm_error.Name = "TB_monitor_comm_error"
        Me.TB_monitor_comm_error.Size = New System.Drawing.Size(288, 10)
        Me.TB_monitor_comm_error.TabIndex = 26
        Me.TB_monitor_comm_error.Text = "Monitor disabled because of comunication error"
        Me.TB_monitor_comm_error.Visible = False
        '
        'But_hide_pan_beginners
        '
        Me.But_hide_pan_beginners.Location = New System.Drawing.Point(191, 181)
        Me.But_hide_pan_beginners.Name = "But_hide_pan_beginners"
        Me.But_hide_pan_beginners.Size = New System.Drawing.Size(75, 23)
        Me.But_hide_pan_beginners.TabIndex = 1
        Me.But_hide_pan_beginners.Text = "Hide"
        Me.But_hide_pan_beginners.UseVisualStyleBackColor = True
        '
        'pan_filerestrictions
        '
        Me.pan_filerestrictions.Controls.Add(Me.Button_discard_tricks)
        Me.pan_filerestrictions.Controls.Add(Me.lbl_filerestrictions)
        Me.pan_filerestrictions.Location = New System.Drawing.Point(503, 241)
        Me.pan_filerestrictions.Name = "pan_filerestrictions"
        Me.pan_filerestrictions.Size = New System.Drawing.Size(277, 101)
        Me.pan_filerestrictions.TabIndex = 56
        Me.pan_filerestrictions.Visible = False
        '
        'Button_discard_tricks
        '
        Me.Button_discard_tricks.Location = New System.Drawing.Point(56, 80)
        Me.Button_discard_tricks.Name = "Button_discard_tricks"
        Me.Button_discard_tricks.Size = New System.Drawing.Size(170, 32)
        Me.Button_discard_tricks.TabIndex = 1
        Me.Button_discard_tricks.Text = "Discard unsupported patterns"
        Me.Button_discard_tricks.UseVisualStyleBackColor = True
        '
        'lbl_filerestrictions
        '
        Me.lbl_filerestrictions.AutoSize = True
        Me.lbl_filerestrictions.Location = New System.Drawing.Point(53, 11)
        Me.lbl_filerestrictions.Name = "lbl_filerestrictions"
        Me.lbl_filerestrictions.Size = New System.Drawing.Size(273, 68)
        Me.lbl_filerestrictions.TabIndex = 0
        Me.lbl_filerestrictions.Text = "You may not modify sign display patterns" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Because you have opted to retain displa" &
    "y " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "patterns that are not supported by this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "version of TiniWindow"
        '
        'But_listchildren
        '
        Me.But_listchildren.Location = New System.Drawing.Point(450, 468)
        Me.But_listchildren.Name = "But_listchildren"
        Me.But_listchildren.Size = New System.Drawing.Size(108, 23)
        Me.But_listchildren.TabIndex = 74
        Me.But_listchildren.Text = "debug action"
        Me.But_listchildren.UseVisualStyleBackColor = True
        Me.But_listchildren.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(540, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 17)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "seconds per line"
        Me.Label20.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(420, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "mark255"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'TB_pan_morelines_speed
        '
        Me.TB_pan_morelines_speed.Location = New System.Drawing.Point(602, 3)
        Me.TB_pan_morelines_speed.Name = "TB_pan_morelines_speed"
        Me.TB_pan_morelines_speed.Size = New System.Drawing.Size(33, 23)
        Me.TB_pan_morelines_speed.TabIndex = 2
        Me.TB_pan_morelines_speed.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(501, 6)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 17)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Speed"
        Me.Label19.Visible = False
        '
        'Pan_showclock
        '
        Me.Pan_showclock.Controls.Add(Me.Panel3)
        Me.Pan_showclock.Controls.Add(Me.LBL_time)
        Me.Pan_showclock.Controls.Add(Me.CB_clockoptions)
        Me.Pan_showclock.Controls.Add(Me.CB_monitor_active_trick)
        Me.Pan_showclock.Location = New System.Drawing.Point(256, 391)
        Me.Pan_showclock.Name = "Pan_showclock"
        Me.Pan_showclock.Size = New System.Drawing.Size(92, 73)
        Me.Pan_showclock.TabIndex = 25
        Me.Pan_showclock.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(39, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 2
        '
        'LBL_time
        '
        Me.LBL_time.AutoSize = True
        Me.LBL_time.Location = New System.Drawing.Point(56, 37)
        Me.LBL_time.Name = "LBL_time"
        Me.LBL_time.Size = New System.Drawing.Size(59, 17)
        Me.LBL_time.TabIndex = 1
        Me.LBL_time.Text = "Label16"
        '
        'CB_clockoptions
        '
        Me.CB_clockoptions.FormattingEnabled = True
        Me.CB_clockoptions.Items.AddRange(New Object() {"Time Only", "Time and Date", "Time, Date and Day"})
        Me.CB_clockoptions.Location = New System.Drawing.Point(35, 90)
        Me.CB_clockoptions.Name = "CB_clockoptions"
        Me.CB_clockoptions.Size = New System.Drawing.Size(121, 25)
        Me.CB_clockoptions.TabIndex = 0
        '
        'CB_monitor_active_trick
        '
        Me.CB_monitor_active_trick.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_monitor_active_trick.FormattingEnabled = True
        Me.CB_monitor_active_trick.Location = New System.Drawing.Point(14, 26)
        Me.CB_monitor_active_trick.Name = "CB_monitor_active_trick"
        Me.CB_monitor_active_trick.Size = New System.Drawing.Size(124, 28)
        Me.CB_monitor_active_trick.TabIndex = 27
        Me.CB_monitor_active_trick.Visible = False
        '
        'Pan_monitor_comm_error
        '
        Me.Pan_monitor_comm_error.Controls.Add(Me.But_retrycommunication)
        Me.Pan_monitor_comm_error.Location = New System.Drawing.Point(5, 688)
        Me.Pan_monitor_comm_error.Name = "Pan_monitor_comm_error"
        Me.Pan_monitor_comm_error.Size = New System.Drawing.Size(290, 10)
        Me.Pan_monitor_comm_error.TabIndex = 50
        Me.Pan_monitor_comm_error.Visible = False
        '
        'But_retrycommunication
        '
        Me.But_retrycommunication.Location = New System.Drawing.Point(86, 85)
        Me.But_retrycommunication.Name = "But_retrycommunication"
        Me.But_retrycommunication.Size = New System.Drawing.Size(121, 23)
        Me.But_retrycommunication.TabIndex = 27
        Me.But_retrycommunication.Text = "Retry Communication"
        Me.But_retrycommunication.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "test"
        Me.NotifyIcon1.BalloonTipTitle = "test"
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 0
        Me.ToolTip1.AutoPopDelay = 0
        Me.ToolTip1.InitialDelay = 0
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 50
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(44, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Select Video"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 25)
        Me.ComboBox1.TabIndex = 1
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(3, 74)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.ScrollBarsEnabled = False
        Me.WebBrowser2.Size = New System.Drawing.Size(166, 255)
        Me.WebBrowser2.TabIndex = 0
        '
        'timer_monitor_ifdoubleclickmanuel
        '
        Me.timer_monitor_ifdoubleclickmanuel.Enabled = True
        Me.timer_monitor_ifdoubleclickmanuel.Interval = 50
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Controls.Add(Me.Panel7)
        Me.TabPage3.Controls.Add(Me.Panel9)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(172, 332)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Demo"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Location = New System.Drawing.Point(5, -11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 43)
        Me.Panel2.TabIndex = 52
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Location = New System.Drawing.Point(-1, 14)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(40, 21)
        Me.Panel4.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(3, 4)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 17)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "None"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Khaki
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Location = New System.Drawing.Point(99, 14)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(63, 21)
        Me.Panel5.TabIndex = 36
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(1, 4)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 17)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Multi-Line"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.Label22)
        Me.Panel6.Location = New System.Drawing.Point(41, 14)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(55, 21)
        Me.Panel6.TabIndex = 35
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(2, 4)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 17)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "One Line"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Navy
        Me.Panel7.Controls.Add(Me.Label23)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Label25)
        Me.Panel7.Controls.Add(Me.Label26)
        Me.Panel7.Controls.Add(Me.TextBox1)
        Me.Panel7.Controls.Add(Me.TextBox2)
        Me.Panel7.Controls.Add(Me.Label27)
        Me.Panel7.Controls.Add(Me.TextBox3)
        Me.Panel7.Controls.Add(Me.TextBox4)
        Me.Panel7.Controls.Add(Me.Label28)
        Me.Panel7.Controls.Add(Me.TextBox5)
        Me.Panel7.Controls.Add(Me.TextBox6)
        Me.Panel7.Controls.Add(Me.Label29)
        Me.Panel7.Controls.Add(Me.TextBox7)
        Me.Panel7.Controls.Add(Me.TextBox8)
        Me.Panel7.Controls.Add(Me.Label30)
        Me.Panel7.Controls.Add(Me.TextBox9)
        Me.Panel7.Controls.Add(Me.TextBox10)
        Me.Panel7.Controls.Add(Me.Label31)
        Me.Panel7.Controls.Add(Me.Label32)
        Me.Panel7.Controls.Add(Me.Label33)
        Me.Panel7.Controls.Add(Me.Label34)
        Me.Panel7.Location = New System.Drawing.Point(4, 27)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(153, 305)
        Me.Panel7.TabIndex = 45
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label23.Location = New System.Drawing.Point(89, 248)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 17)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Label18"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label24)
        Me.Panel8.Location = New System.Drawing.Point(13, 273)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(145, 21)
        Me.Panel8.TabIndex = 13
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Yellow
        Me.Label24.Location = New System.Drawing.Point(7, 5)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 17)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "Total Time"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label25.Location = New System.Drawing.Point(81, 3)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 34)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "Time table " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(seconds)"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label26.Location = New System.Drawing.Point(89, 225)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(59, 17)
        Me.Label26.TabIndex = 17
        Me.Label26.Text = "Label18"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(23, 27)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(54, 26)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Tag = "0"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(23, 51)
        Me.TextBox2.MaxLength = 50
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(54, 26)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Tag = "1"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label27.Location = New System.Drawing.Point(89, 203)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(59, 17)
        Me.Label27.TabIndex = 15
        Me.Label27.Text = "Label18"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(23, 75)
        Me.TextBox3.MaxLength = 50
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(54, 26)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Tag = "2"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox4.Location = New System.Drawing.Point(23, 99)
        Me.TextBox4.MaxLength = 50
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(54, 26)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Tag = "3"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label28.Location = New System.Drawing.Point(89, 177)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(59, 17)
        Me.Label28.TabIndex = 13
        Me.Label28.Text = "Label18"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox5.Location = New System.Drawing.Point(23, 123)
        Me.TextBox5.MaxLength = 50
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(54, 26)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Tag = "4"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox6.Location = New System.Drawing.Point(23, 147)
        Me.TextBox6.MaxLength = 50
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(54, 26)
        Me.TextBox6.TabIndex = 5
        Me.TextBox6.Tag = "5"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label29.Location = New System.Drawing.Point(89, 153)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(59, 17)
        Me.Label29.TabIndex = 11
        Me.Label29.Text = "Label18"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox7.Location = New System.Drawing.Point(23, 171)
        Me.TextBox7.MaxLength = 50
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(54, 26)
        Me.TextBox7.TabIndex = 6
        Me.TextBox7.Tag = "6"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox8.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox8.Location = New System.Drawing.Point(23, 195)
        Me.TextBox8.MaxLength = 50
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(54, 26)
        Me.TextBox8.TabIndex = 7
        Me.TextBox8.Tag = "7"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label30.Location = New System.Drawing.Point(89, 132)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(59, 17)
        Me.Label30.TabIndex = 9
        Me.Label30.Text = "Label18"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox9.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox9.Location = New System.Drawing.Point(23, 218)
        Me.TextBox9.MaxLength = 50
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(54, 26)
        Me.TextBox9.TabIndex = 8
        Me.TextBox9.Tag = "8"
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox10.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox10.Location = New System.Drawing.Point(23, 241)
        Me.TextBox10.MaxLength = 50
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(54, 26)
        Me.TextBox10.TabIndex = 9
        Me.TextBox10.Tag = "9"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label31.Location = New System.Drawing.Point(89, 105)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(59, 17)
        Me.Label31.TabIndex = 7
        Me.Label31.Text = "Label18"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label32.Location = New System.Drawing.Point(89, 33)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(59, 17)
        Me.Label32.TabIndex = 1
        Me.Label32.Text = "Label18"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label33.Location = New System.Drawing.Point(89, 57)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(59, 17)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "Label18"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label34.Location = New System.Drawing.Point(89, 81)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(59, 17)
        Me.Label34.TabIndex = 5
        Me.Label34.Text = "Label18"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Navy
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Controls.Add(Me.Panel11)
        Me.Panel9.Location = New System.Drawing.Point(10, 37)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(143, 309)
        Me.Panel9.TabIndex = 53
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.TextBox11)
        Me.Panel10.Location = New System.Drawing.Point(3, 18)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(130, 281)
        Me.Panel10.TabIndex = 28
        Me.Panel10.Visible = False
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.Lime
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.ForeColor = System.Drawing.Color.Red
        Me.TextBox11.Location = New System.Drawing.Point(3, 121)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(128, 49)
        Me.TextBox11.TabIndex = 1
        Me.TextBox11.Text = "123456"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Label35)
        Me.Panel11.Location = New System.Drawing.Point(-21, 21)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(143, 286)
        Me.Panel11.TabIndex = 1
        Me.Panel11.Visible = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.LawnGreen
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Red
        Me.Label35.Location = New System.Drawing.Point(30, 91)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(106, 89)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "Demo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Turned " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Off"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TabPage4.Controls.Add(Me.Label36)
        Me.TabPage4.Controls.Add(Me.Panel12)
        Me.TabPage4.Controls.Add(Me.Label38)
        Me.TabPage4.Controls.Add(Me.Panel13)
        Me.TabPage4.Controls.Add(Me.Button3)
        Me.TabPage4.Controls.Add(Me.ComboBox2)
        Me.TabPage4.Controls.Add(Me.WebBrowser3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(172, 332)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Video"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(64, 68)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(52, 17)
        Me.Label36.TabIndex = 39
        Me.Label36.Text = "DOWN"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Khaki
        Me.Panel12.Controls.Add(Me.Label37)
        Me.Panel12.Location = New System.Drawing.Point(11, 44)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(137, 19)
        Me.Panel12.TabIndex = 38
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(3, 2)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(64, 17)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Cat one"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(70, 5)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(27, 17)
        Me.Label38.TabIndex = 37
        Me.Label38.Text = "UP"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Khaki
        Me.Panel13.Controls.Add(Me.Label39)
        Me.Panel13.Location = New System.Drawing.Point(10, 21)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(137, 19)
        Me.Panel13.TabIndex = 36
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(3, 2)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(64, 17)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "Cat one"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(44, 110)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Select Video"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(9, 86)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(156, 24)
        Me.ComboBox2.TabIndex = 1
        '
        'WebBrowser3
        '
        Me.WebBrowser3.Location = New System.Drawing.Point(3, 126)
        Me.WebBrowser3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser3.Name = "WebBrowser3"
        Me.WebBrowser3.ScrollBarsEnabled = False
        Me.WebBrowser3.Size = New System.Drawing.Size(166, 203)
        Me.WebBrowser3.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.junk9)
        Me.TabPage5.Controls.Add(Me.junk1)
        Me.TabPage5.Controls.Add(Me.junk14)
        Me.TabPage5.Controls.Add(Me.Panel14)
        Me.TabPage5.Controls.Add(Me.junk2)
        Me.TabPage5.Controls.Add(Me.Label41)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(172, 332)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "pictures"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'junk9
        '
        Me.junk9.Controls.Add(Me.junk6)
        Me.junk9.Location = New System.Drawing.Point(1, 69)
        Me.junk9.Name = "junk9"
        Me.junk9.Size = New System.Drawing.Size(169, 52)
        Me.junk9.TabIndex = 56
        '
        'junk6
        '
        Me.junk6.Location = New System.Drawing.Point(50, 12)
        Me.junk6.Name = "junk6"
        Me.junk6.Size = New System.Drawing.Size(75, 23)
        Me.junk6.TabIndex = 0
        Me.junk6.Text = "Previous"
        Me.junk6.UseVisualStyleBackColor = True
        Me.junk6.Visible = False
        '
        'junk1
        '
        Me.junk1.Controls.Add(Me.junk5)
        Me.junk1.Location = New System.Drawing.Point(3, 271)
        Me.junk1.Name = "junk1"
        Me.junk1.Size = New System.Drawing.Size(169, 58)
        Me.junk1.TabIndex = 55
        '
        'junk5
        '
        Me.junk5.Location = New System.Drawing.Point(47, 18)
        Me.junk5.Name = "junk5"
        Me.junk5.Size = New System.Drawing.Size(75, 23)
        Me.junk5.TabIndex = 1
        Me.junk5.Text = "Next"
        Me.junk5.UseVisualStyleBackColor = True
        '
        'junk14
        '
        Me.junk14.Controls.Add(Me.junk7)
        Me.junk14.Location = New System.Drawing.Point(1, 66)
        Me.junk14.Name = "junk14"
        Me.junk14.Size = New System.Drawing.Size(170, 41)
        Me.junk14.TabIndex = 54
        Me.junk14.Visible = False
        '
        'junk7
        '
        Me.junk7.FormattingEnabled = True
        Me.junk7.Location = New System.Drawing.Point(8, 11)
        Me.junk7.Name = "junk7"
        Me.junk7.Size = New System.Drawing.Size(156, 24)
        Me.junk7.TabIndex = 40
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel14.Controls.Add(Me.Label40)
        Me.Panel14.Controls.Add(Me.junk10)
        Me.Panel14.Controls.Add(Me.junk12)
        Me.Panel14.Location = New System.Drawing.Point(0, 3)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(173, 63)
        Me.Panel14.TabIndex = 53
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(20, 7)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(163, 17)
        Me.Label40.TabIndex = 38
        Me.Label40.Text = "Picture selection method"
        '
        'junk10
        '
        Me.junk10.BackColor = System.Drawing.Color.Khaki
        Me.junk10.Controls.Add(Me.junk4)
        Me.junk10.Location = New System.Drawing.Point(17, 30)
        Me.junk10.Name = "junk10"
        Me.junk10.Size = New System.Drawing.Size(48, 21)
        Me.junk10.TabIndex = 37
        '
        'junk4
        '
        Me.junk4.AutoSize = True
        Me.junk4.BackColor = System.Drawing.Color.Khaki
        Me.junk4.ForeColor = System.Drawing.Color.Black
        Me.junk4.Location = New System.Drawing.Point(2, 3)
        Me.junk4.Name = "junk4"
        Me.junk4.Size = New System.Drawing.Size(56, 17)
        Me.junk4.TabIndex = 0
        Me.junk4.Text = "Buttons"
        '
        'junk12
        '
        Me.junk12.BackColor = System.Drawing.Color.White
        Me.junk12.Controls.Add(Me.junk8)
        Me.junk12.Location = New System.Drawing.Point(89, 30)
        Me.junk12.Name = "junk12"
        Me.junk12.Size = New System.Drawing.Size(55, 21)
        Me.junk12.TabIndex = 35
        '
        'junk8
        '
        Me.junk8.AutoSize = True
        Me.junk8.ForeColor = System.Drawing.Color.Black
        Me.junk8.Location = New System.Drawing.Point(10, 4)
        Me.junk8.Name = "junk8"
        Me.junk8.Size = New System.Drawing.Size(43, 17)
        Me.junk8.TabIndex = 0
        Me.junk8.Text = "menu"
        '
        'junk2
        '
        Me.junk2.Location = New System.Drawing.Point(7, 136)
        Me.junk2.Name = "junk2"
        Me.junk2.Size = New System.Drawing.Size(158, 118)
        Me.junk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.junk2.TabIndex = 43
        Me.junk2.TabStop = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(63, -1)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(0, 17)
        Me.Label41.TabIndex = 41
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TabPage6.Controls.Add(Me.Panel15)
        Me.TabPage6.Controls.Add(Me.Panel19)
        Me.TabPage6.Controls.Add(Me.Panel21)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(172, 332)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Demo"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.Panel16)
        Me.Panel15.Controls.Add(Me.Panel17)
        Me.Panel15.Controls.Add(Me.Panel18)
        Me.Panel15.Location = New System.Drawing.Point(5, -11)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(180, 43)
        Me.Panel15.TabIndex = 52
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.White
        Me.Panel16.Controls.Add(Me.Label42)
        Me.Panel16.Location = New System.Drawing.Point(-1, 14)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(40, 21)
        Me.Panel16.TabIndex = 37
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(3, 4)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(42, 17)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "None"
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Khaki
        Me.Panel17.Controls.Add(Me.Label43)
        Me.Panel17.Location = New System.Drawing.Point(99, 14)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(63, 21)
        Me.Panel17.TabIndex = 36
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(1, 4)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(79, 17)
        Me.Label43.TabIndex = 0
        Me.Label43.Text = "Multi-Line"
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.White
        Me.Panel18.Controls.Add(Me.Label44)
        Me.Panel18.Location = New System.Drawing.Point(41, 14)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(55, 21)
        Me.Panel18.TabIndex = 35
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(2, 4)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(66, 17)
        Me.Label44.TabIndex = 0
        Me.Label44.Text = "One Line"
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.Navy
        Me.Panel19.Controls.Add(Me.Label45)
        Me.Panel19.Controls.Add(Me.Panel20)
        Me.Panel19.Controls.Add(Me.Label47)
        Me.Panel19.Controls.Add(Me.Label48)
        Me.Panel19.Controls.Add(Me.TextBox12)
        Me.Panel19.Controls.Add(Me.TextBox13)
        Me.Panel19.Controls.Add(Me.Label49)
        Me.Panel19.Controls.Add(Me.TextBox14)
        Me.Panel19.Controls.Add(Me.TextBox15)
        Me.Panel19.Controls.Add(Me.Label50)
        Me.Panel19.Controls.Add(Me.TextBox16)
        Me.Panel19.Controls.Add(Me.TextBox17)
        Me.Panel19.Controls.Add(Me.Label51)
        Me.Panel19.Controls.Add(Me.TextBox18)
        Me.Panel19.Controls.Add(Me.TextBox19)
        Me.Panel19.Controls.Add(Me.Label52)
        Me.Panel19.Controls.Add(Me.TextBox20)
        Me.Panel19.Controls.Add(Me.TextBox21)
        Me.Panel19.Controls.Add(Me.Label53)
        Me.Panel19.Controls.Add(Me.Label54)
        Me.Panel19.Controls.Add(Me.Label55)
        Me.Panel19.Controls.Add(Me.Label56)
        Me.Panel19.Location = New System.Drawing.Point(4, 27)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(153, 305)
        Me.Panel19.TabIndex = 45
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label45.Location = New System.Drawing.Point(89, 248)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(59, 17)
        Me.Label45.TabIndex = 19
        Me.Label45.Text = "Label18"
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.Label46)
        Me.Panel20.Location = New System.Drawing.Point(13, 273)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(145, 21)
        Me.Panel20.TabIndex = 13
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Yellow
        Me.Label46.Location = New System.Drawing.Point(7, 5)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(75, 17)
        Me.Label46.TabIndex = 11
        Me.Label46.Text = "Total Time"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label47.Location = New System.Drawing.Point(81, 3)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(78, 34)
        Me.Label47.TabIndex = 10
        Me.Label47.Text = "Time table " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(seconds)"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label48.Location = New System.Drawing.Point(89, 225)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(59, 17)
        Me.Label48.TabIndex = 17
        Me.Label48.Text = "Label18"
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox12.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox12.Location = New System.Drawing.Point(23, 27)
        Me.TextBox12.MaxLength = 50
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(54, 26)
        Me.TextBox12.TabIndex = 0
        Me.TextBox12.Tag = "0"
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox13.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox13.Location = New System.Drawing.Point(23, 51)
        Me.TextBox13.MaxLength = 50
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(54, 26)
        Me.TextBox13.TabIndex = 1
        Me.TextBox13.Tag = "1"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label49.Location = New System.Drawing.Point(89, 203)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(59, 17)
        Me.Label49.TabIndex = 15
        Me.Label49.Text = "Label18"
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox14.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox14.Location = New System.Drawing.Point(23, 75)
        Me.TextBox14.MaxLength = 50
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(54, 26)
        Me.TextBox14.TabIndex = 2
        Me.TextBox14.Tag = "2"
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox15.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox15.Location = New System.Drawing.Point(23, 99)
        Me.TextBox15.MaxLength = 50
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(54, 26)
        Me.TextBox15.TabIndex = 3
        Me.TextBox15.Tag = "3"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label50.Location = New System.Drawing.Point(89, 177)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(59, 17)
        Me.Label50.TabIndex = 13
        Me.Label50.Text = "Label18"
        '
        'TextBox16
        '
        Me.TextBox16.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox16.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox16.Location = New System.Drawing.Point(23, 123)
        Me.TextBox16.MaxLength = 50
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(54, 26)
        Me.TextBox16.TabIndex = 4
        Me.TextBox16.Tag = "4"
        '
        'TextBox17
        '
        Me.TextBox17.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox17.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox17.Location = New System.Drawing.Point(23, 147)
        Me.TextBox17.MaxLength = 50
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(54, 26)
        Me.TextBox17.TabIndex = 5
        Me.TextBox17.Tag = "5"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label51.Location = New System.Drawing.Point(89, 153)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(59, 17)
        Me.Label51.TabIndex = 11
        Me.Label51.Text = "Label18"
        '
        'TextBox18
        '
        Me.TextBox18.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox18.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox18.Location = New System.Drawing.Point(23, 171)
        Me.TextBox18.MaxLength = 50
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(54, 26)
        Me.TextBox18.TabIndex = 6
        Me.TextBox18.Tag = "6"
        '
        'TextBox19
        '
        Me.TextBox19.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox19.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox19.Location = New System.Drawing.Point(23, 195)
        Me.TextBox19.MaxLength = 50
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(54, 26)
        Me.TextBox19.TabIndex = 7
        Me.TextBox19.Tag = "7"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label52.Location = New System.Drawing.Point(89, 132)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(59, 17)
        Me.Label52.TabIndex = 9
        Me.Label52.Text = "Label18"
        '
        'TextBox20
        '
        Me.TextBox20.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox20.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox20.Location = New System.Drawing.Point(23, 218)
        Me.TextBox20.MaxLength = 50
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(54, 26)
        Me.TextBox20.TabIndex = 8
        Me.TextBox20.Tag = "8"
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox21.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox21.Location = New System.Drawing.Point(23, 241)
        Me.TextBox21.MaxLength = 50
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(54, 26)
        Me.TextBox21.TabIndex = 9
        Me.TextBox21.Tag = "9"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label53.Location = New System.Drawing.Point(89, 105)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(59, 17)
        Me.Label53.TabIndex = 7
        Me.Label53.Text = "Label18"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label54.Location = New System.Drawing.Point(89, 33)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(59, 17)
        Me.Label54.TabIndex = 1
        Me.Label54.Text = "Label18"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label55.Location = New System.Drawing.Point(89, 57)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(59, 17)
        Me.Label55.TabIndex = 3
        Me.Label55.Text = "Label18"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label56.Location = New System.Drawing.Point(89, 81)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(59, 17)
        Me.Label56.TabIndex = 5
        Me.Label56.Text = "Label18"
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.Navy
        Me.Panel21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel21.Controls.Add(Me.Panel22)
        Me.Panel21.Controls.Add(Me.Panel23)
        Me.Panel21.Location = New System.Drawing.Point(10, 37)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(143, 309)
        Me.Panel21.TabIndex = 53
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.TextBox22)
        Me.Panel22.Location = New System.Drawing.Point(3, 18)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(130, 281)
        Me.Panel22.TabIndex = 28
        Me.Panel22.Visible = False
        '
        'TextBox22
        '
        Me.TextBox22.BackColor = System.Drawing.Color.Lime
        Me.TextBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox22.ForeColor = System.Drawing.Color.Red
        Me.TextBox22.Location = New System.Drawing.Point(3, 121)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(128, 49)
        Me.TextBox22.TabIndex = 1
        Me.TextBox22.Text = "123456"
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.Label57)
        Me.Panel23.Location = New System.Drawing.Point(-21, 21)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(143, 286)
        Me.Panel23.TabIndex = 1
        Me.Panel23.Visible = False
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.BackColor = System.Drawing.Color.LawnGreen
        Me.Label57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Red
        Me.Label57.Location = New System.Drawing.Point(30, 91)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(106, 89)
        Me.Label57.TabIndex = 0
        Me.Label57.Text = "Demo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Turned " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Off"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TabPage7.Controls.Add(Me.Label58)
        Me.TabPage7.Controls.Add(Me.Panel24)
        Me.TabPage7.Controls.Add(Me.Label60)
        Me.TabPage7.Controls.Add(Me.Panel25)
        Me.TabPage7.Controls.Add(Me.Button4)
        Me.TabPage7.Controls.Add(Me.ComboBox3)
        Me.TabPage7.Controls.Add(Me.WebBrowser4)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(172, 332)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "Video"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(64, 68)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(52, 17)
        Me.Label58.TabIndex = 39
        Me.Label58.Text = "DOWN"
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.Khaki
        Me.Panel24.Controls.Add(Me.Label59)
        Me.Panel24.Location = New System.Drawing.Point(11, 44)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(137, 19)
        Me.Panel24.TabIndex = 38
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(3, 2)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(64, 17)
        Me.Label59.TabIndex = 0
        Me.Label59.Text = "Cat one"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(70, 5)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(27, 17)
        Me.Label60.TabIndex = 37
        Me.Label60.Text = "UP"
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.Khaki
        Me.Panel25.Controls.Add(Me.Label61)
        Me.Panel25.Location = New System.Drawing.Point(10, 21)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(137, 19)
        Me.Panel25.TabIndex = 36
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Black
        Me.Label61.Location = New System.Drawing.Point(3, 2)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(64, 17)
        Me.Label61.TabIndex = 0
        Me.Label61.Text = "Cat one"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(44, 110)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Select Video"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(9, 86)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(156, 24)
        Me.ComboBox3.TabIndex = 1
        '
        'WebBrowser4
        '
        Me.WebBrowser4.Location = New System.Drawing.Point(3, 126)
        Me.WebBrowser4.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser4.Name = "WebBrowser4"
        Me.WebBrowser4.ScrollBarsEnabled = False
        Me.WebBrowser4.Size = New System.Drawing.Size(166, 203)
        Me.WebBrowser4.TabIndex = 0
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.Panel26)
        Me.TabPage8.Controls.Add(Me.Panel27)
        Me.TabPage8.Controls.Add(Me.Panel28)
        Me.TabPage8.Controls.Add(Me.Panel29)
        Me.TabPage8.Controls.Add(Me.junk3)
        Me.TabPage8.Controls.Add(Me.Label65)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(172, 332)
        Me.TabPage8.TabIndex = 2
        Me.TabPage8.Text = "pictures"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'Panel26
        '
        Me.Panel26.Controls.Add(Me.Button5)
        Me.Panel26.Location = New System.Drawing.Point(1, 69)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(169, 52)
        Me.Panel26.TabIndex = 56
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(50, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Previous"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'Panel27
        '
        Me.Panel27.Controls.Add(Me.Button6)
        Me.Panel27.Location = New System.Drawing.Point(3, 271)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(169, 58)
        Me.Panel27.TabIndex = 55
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(47, 18)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Next"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Panel28
        '
        Me.Panel28.Controls.Add(Me.ComboBox4)
        Me.Panel28.Location = New System.Drawing.Point(1, 66)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(170, 41)
        Me.Panel28.TabIndex = 54
        Me.Panel28.Visible = False
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(8, 11)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(156, 24)
        Me.ComboBox4.TabIndex = 40
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel29.Controls.Add(Me.Label62)
        Me.Panel29.Controls.Add(Me.Panel30)
        Me.Panel29.Controls.Add(Me.Panel31)
        Me.Panel29.Location = New System.Drawing.Point(0, 3)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(173, 63)
        Me.Panel29.TabIndex = 53
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(20, 7)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(163, 17)
        Me.Label62.TabIndex = 38
        Me.Label62.Text = "Picture selection method"
        '
        'Panel30
        '
        Me.Panel30.BackColor = System.Drawing.Color.Khaki
        Me.Panel30.Controls.Add(Me.Label63)
        Me.Panel30.Location = New System.Drawing.Point(17, 30)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(48, 21)
        Me.Panel30.TabIndex = 37
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.Color.Khaki
        Me.Label63.ForeColor = System.Drawing.Color.Black
        Me.Label63.Location = New System.Drawing.Point(2, 3)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(56, 17)
        Me.Label63.TabIndex = 0
        Me.Label63.Text = "Buttons"
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.White
        Me.Panel31.Controls.Add(Me.Label64)
        Me.Panel31.Location = New System.Drawing.Point(89, 30)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(55, 21)
        Me.Panel31.TabIndex = 35
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.ForeColor = System.Drawing.Color.Black
        Me.Label64.Location = New System.Drawing.Point(10, 4)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(43, 17)
        Me.Label64.TabIndex = 0
        Me.Label64.Text = "menu"
        '
        'junk3
        '
        Me.junk3.Location = New System.Drawing.Point(7, 136)
        Me.junk3.Name = "junk3"
        Me.junk3.Size = New System.Drawing.Size(158, 118)
        Me.junk3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.junk3.TabIndex = 43
        Me.junk3.TabStop = False
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(63, -1)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(0, 17)
        Me.Label65.TabIndex = 41
        '
        'Timer_formloaded
        '
        Me.Timer_formloaded.Interval = 1000
        '
        'Timer_setkeyword_cursor
        '
        Me.Timer_setkeyword_cursor.Interval = 300
        '
        'Tim_finish_horr_line
        '
        Me.Tim_finish_horr_line.Interval = 500
        '
        'ContextMenu_combokeywords
        '
        Me.ContextMenu_combokeywords.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_comboallignment, Me.ToolStripSeparator8, Me.Men_combo_allowexceedwordlength})
        Me.ContextMenu_combokeywords.Name = "ContextMen_litecards"
        Me.ContextMenu_combokeywords.Size = New System.Drawing.Size(172, 54)
        '
        'Menu_comboallignment
        '
        Me.Menu_comboallignment.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Men_combokeywordallign_none, Me.Men_combokeywordallign_left, Me.Men_combokeywordallign_center, Me.Men_combokeywordallign_right})
        Me.Menu_comboallignment.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_comboallignment.Name = "Menu_comboallignment"
        Me.Menu_comboallignment.Size = New System.Drawing.Size(171, 22)
        Me.Menu_comboallignment.Text = "Allignment"
        '
        'Men_combokeywordallign_none
        '
        Me.Men_combokeywordallign_none.Name = "Men_combokeywordallign_none"
        Me.Men_combokeywordallign_none.Size = New System.Drawing.Size(113, 22)
        Me.Men_combokeywordallign_none.Text = "None"
        '
        'Men_combokeywordallign_left
        '
        Me.Men_combokeywordallign_left.Name = "Men_combokeywordallign_left"
        Me.Men_combokeywordallign_left.Size = New System.Drawing.Size(113, 22)
        Me.Men_combokeywordallign_left.Text = "Left"
        '
        'Men_combokeywordallign_center
        '
        Me.Men_combokeywordallign_center.Name = "Men_combokeywordallign_center"
        Me.Men_combokeywordallign_center.Size = New System.Drawing.Size(113, 22)
        Me.Men_combokeywordallign_center.Text = "Center"
        '
        'Men_combokeywordallign_right
        '
        Me.Men_combokeywordallign_right.Name = "Men_combokeywordallign_right"
        Me.Men_combokeywordallign_right.Size = New System.Drawing.Size(113, 22)
        Me.Men_combokeywordallign_right.Text = "Right"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(168, 6)
        '
        'Men_combo_allowexceedwordlength
        '
        Me.Men_combo_allowexceedwordlength.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Men_combo_allowexceedwordlength.Name = "Men_combo_allowexceedwordlength"
        Me.Men_combo_allowexceedwordlength.Size = New System.Drawing.Size(171, 22)
        Me.Men_combo_allowexceedwordlength.Text = "Allow > x letters"
        '
        'Timer_flagwatchdog
        '
        Me.Timer_flagwatchdog.Interval = 500
        '
        'Timer_refreshSignMenue
        '
        Me.Timer_refreshSignMenue.Enabled = True
        Me.Timer_refreshSignMenue.Interval = 2000
        '
        'Timer_closeconnectdropdown
        '
        Me.Timer_closeconnectdropdown.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(493, 745)
        Me.Controls.Add(Me.Pan_edit)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(500, 50)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Form1"
        Me.Text = "TiniWindow"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Pan_edit.ResumeLayout(False)
        Me.Pan_edit.PerformLayout()
        Me.Pan_Woodbackground.ResumeLayout(False)
        Me.Pan_Design.ResumeLayout(False)
        Me.Pan_Design.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Tab_FreeStyle.ResumeLayout(False)
        Me.Tab_FreeStyle.PerformLayout()
        CType(Me.PB_horse_freestyletab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_snail_freestyletab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_cardcount_freestyletab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Lines.ResumeLayout(False)
        Me.Pan_tb.ResumeLayout(False)
        Me.Pan_tb.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_linestab_liinecounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_textdatadown10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_lines_cardcount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_textdataup10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Easy.ResumeLayout(False)
        Me.Panel32.ResumeLayout(False)
        Me.Panel32.PerformLayout()
        Me.Pan_keyword_background.ResumeLayout(False)
        Me.Pan_keyword_background.PerformLayout()
        CType(Me.PB_horse_easytab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_snail_easytab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_cardcount_easytab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pan_internet_connection.ResumeLayout(False)
        Me.Pan_internet_connection.PerformLayout()
        Me.Pan_USBBase.ResumeLayout(False)
        Me.Pan_USBBase.PerformLayout()
        Me.Panel34.ResumeLayout(False)
        Me.Panel34.PerformLayout()
        Me.Pan_coonnect_menu.ResumeLayout(False)
        Me.Pan_coonnect_menu.PerformLayout()
        Me.Panel33.ResumeLayout(False)
        Me.Panel33.PerformLayout()
        Me.Pan_dialog.ResumeLayout(False)
        Me.Pan_dialog.PerformLayout()
        Me.Pan_sever_filebuttons.ResumeLayout(False)
        Me.Pan_sever_filebuttons.PerformLayout()
        Me.pan_chalkboard.ResumeLayout(False)
        Me.Pan_boardviewingarea.ResumeLayout(False)
        Me.Pan_boardviewingarea.PerformLayout()
        Me.Pan_noServer.ResumeLayout(False)
        Me.Pan_noServer.PerformLayout()
        Me.Pan_internetNodes.ResumeLayout(False)
        Me.Pan_internetNodes.PerformLayout()
        Me.Pan_server_no_signs.ResumeLayout(False)
        Me.Pan_server_no_signs.PerformLayout()
        Me.Pan_comBase.ResumeLayout(False)
        Me.AIV_Internet.ResumeLayout(False)
        Me.AIV_Internet.PerformLayout()
        Me.AIV_Zigbee.ResumeLayout(False)
        Me.AIV_Zigbee.PerformLayout()
        Me.AIV_USB.ResumeLayout(False)
        Me.AIV_USB.PerformLayout()
        Me.Pan_USBnodes.ResumeLayout(False)
        Me.Pan_USBnodes.PerformLayout()
        Me.Pan_noUSBFound.ResumeLayout(False)
        Me.Pan_noUSBFound.PerformLayout()
        Me.Pan_wirelessBaseNoSigns.ResumeLayout(False)
        Me.Pan_wirelessBaseNoSigns.PerformLayout()
        Me.Pan_wirelessnodes.ResumeLayout(False)
        Me.Pan_wirelessnodes.PerformLayout()
        Me.Pan_noWireless.ResumeLayout(False)
        Me.Pan_noWireless.PerformLayout()
        Me.Pan_bluetabs.ResumeLayout(False)
        Me.Pan_bluetabs.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Pan_demooption_multiline.ResumeLayout(False)
        Me.Pan_demooption_multiline.PerformLayout()
        Me.Pan_demooption_oneline.ResumeLayout(False)
        Me.Pan_demooption_oneline.PerformLayout()
        Me.Pan_demo_lines.ResumeLayout(False)
        Me.Pan_demo_multiline.ResumeLayout(False)
        Me.Pan_demo_multiline.PerformLayout()
        Me.Pan_totaltime.ResumeLayout(False)
        Me.Pan_totaltime.PerformLayout()
        Me.Pan_demo_oneline.ResumeLayout(False)
        Me.Pan_demo_oneline.PerformLayout()
        Me.Pan_cardbackground.ResumeLayout(False)
        Me.ContextMen_litecards.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        Me.pan_cat2.ResumeLayout(False)
        Me.pan_cat2.PerformLayout()
        Me.Pan_cat1.ResumeLayout(False)
        Me.Pan_cat1.PerformLayout()
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout()
        Me.pan_no_pictures.ResumeLayout(False)
        Me.pan_no_pictures.PerformLayout()
        Me.Pan_pictureselect_buttons1.ResumeLayout(False)
        Me.Pan_pictureselect_buttons2.ResumeLayout(False)
        Me.Pan_pictureselect_menu.ResumeLayout(False)
        Me.Panel35.ResumeLayout(False)
        Me.Panel35.PerformLayout()
        Me.pan_picture_select_buttons.ResumeLayout(False)
        Me.pan_picture_select_buttons.PerformLayout()
        Me.pan_picture_select_menu.ResumeLayout(False)
        Me.pan_picture_select_menu.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pan_Control.ResumeLayout(False)
        Me.Pan_Control.PerformLayout()
        Me.Pan_beginners_help.ResumeLayout(False)
        Me.Pan_beginners_help.PerformLayout()
        CType(Me.PDFview_usermanuel_small, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_filerestrictions.ResumeLayout(False)
        Me.pan_filerestrictions.PerformLayout()
        Me.Pan_showclock.ResumeLayout(False)
        Me.Pan_showclock.PerformLayout()
        Me.Pan_monitor_comm_error.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.junk9.ResumeLayout(False)
        Me.junk1.ResumeLayout(False)
        Me.junk14.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.junk10.ResumeLayout(False)
        Me.junk10.PerformLayout()
        Me.junk12.ResumeLayout(False)
        Me.junk12.PerformLayout()
        CType(Me.junk2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel21.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.Panel24.ResumeLayout(False)
        Me.Panel24.PerformLayout()
        Me.Panel25.ResumeLayout(False)
        Me.Panel25.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.Panel26.ResumeLayout(False)
        Me.Panel27.ResumeLayout(False)
        Me.Panel28.ResumeLayout(False)
        Me.Panel29.ResumeLayout(False)
        Me.Panel29.PerformLayout()
        Me.Panel30.ResumeLayout(False)
        Me.Panel30.PerformLayout()
        Me.Panel31.ResumeLayout(False)
        Me.Panel31.PerformLayout()
        CType(Me.junk3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenu_combokeywords.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer_pole_active_string As System.Windows.Forms.Timer
    Friend WithEvents BGW_read_device As System.ComponentModel.BackgroundWorker
    Friend WithEvents BGW_write_device As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents men_help_strip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_help_go As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_tools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_device As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_write_device As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_read_device As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_select_comport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer_footer_change As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl_footer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_directory As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents men_file As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_new As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_open As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents men_save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_saveas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents men_exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FriendsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiniliteWorldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OthersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lb As System.Windows.Forms.Label
    Friend WithEvents Tim_clock As System.Windows.Forms.Timer
    Friend WithEvents Men_settings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SignSimulatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pan_edit As System.Windows.Forms.Panel
    Friend WithEvents Pan_monitor_comm_error As System.Windows.Forms.Panel
    Friend WithEvents But_retrycommunication As System.Windows.Forms.Button
    Friend WithEvents TB_monitor_comm_error As System.Windows.Forms.TextBox
    Friend WithEvents CB_monitor_active_trick As System.Windows.Forms.ComboBox
    Friend WithEvents Pan_showclock As System.Windows.Forms.Panel
    Friend WithEvents LBL_time As System.Windows.Forms.Label
    Friend WithEvents CB_clockoptions As System.Windows.Forms.ComboBox
    Friend WithEvents men_import_tricks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_export_tricks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_products As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_editmode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_monitormode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShareTricksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SimulatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Pan_beginners_help As System.Windows.Forms.Panel
    Friend WithEvents But_hide_pan_beginners As System.Windows.Forms.Button
    Friend WithEvents GettingStartedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportAProblemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutTiniWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Timer_demo As System.Windows.Forms.Timer
    Friend WithEvents men_make_default As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents men_open_default As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WatchVideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents LineConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents timer_monitor_ifdoubleclickmanuel As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents WebBrowser3 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents junk9 As System.Windows.Forms.Panel
    Friend WithEvents junk6 As System.Windows.Forms.Button
    Friend WithEvents junk1 As System.Windows.Forms.Panel
    Friend WithEvents junk5 As System.Windows.Forms.Button
    Friend WithEvents junk14 As System.Windows.Forms.Panel
    Friend WithEvents junk7 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents junk10 As System.Windows.Forms.Panel
    Friend WithEvents junk4 As System.Windows.Forms.Label
    Friend WithEvents junk12 As System.Windows.Forms.Panel
    Friend WithEvents junk8 As System.Windows.Forms.Label
    Friend WithEvents junk2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents WebBrowser4 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents Panel26 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Panel28 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel29 As System.Windows.Forms.Panel
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Panel30 As System.Windows.Forms.Panel
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Panel31 As System.Windows.Forms.Panel
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents junk3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Lines As System.Windows.Forms.TabPage
    Friend WithEvents Pan_bluetabs As System.Windows.Forms.Panel
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents Pan_demooption_multiline As System.Windows.Forms.Panel
    Friend WithEvents Lbl_demooption_multiline As System.Windows.Forms.Label
    Friend WithEvents Pan_demooption_oneline As System.Windows.Forms.Panel
    Friend WithEvents Lbl_demooption_oneline As System.Windows.Forms.Label
    Friend WithEvents Pan_demo_multiline As System.Windows.Forms.Panel
    Friend WithEvents Lbl_demoline0 As System.Windows.Forms.Label
    Friend WithEvents Txt_demoline8 As System.Windows.Forms.TextBox
    Friend WithEvents Pan_totaltime As System.Windows.Forms.Panel
    Friend WithEvents lbl_totaltime As System.Windows.Forms.Label
    Friend WithEvents Lbl_demoline1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_demoline3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_demoline2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_demoline4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_demoline9 As System.Windows.Forms.Label
    Friend WithEvents Lbl_demoline8 As System.Windows.Forms.Label
    Friend WithEvents Lbl_demoline7 As System.Windows.Forms.Label
    Friend WithEvents Lbl_demoline5 As System.Windows.Forms.Label
    Friend WithEvents Lbl_demoline6 As System.Windows.Forms.Label
    Friend WithEvents Txt_demoline0 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_demoline1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_demoline2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_demoline3 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_demoline4 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_demoline5 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_demoline6 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_demoline7 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_demoline9 As System.Windows.Forms.TextBox
    Friend WithEvents Pan_demo_lines As System.Windows.Forms.Panel
    Friend WithEvents Pan_demo_oneline As System.Windows.Forms.Panel
    Friend WithEvents Txt_demo_oneline As System.Windows.Forms.TextBox
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_catdown As System.Windows.Forms.Label
    Friend WithEvents pan_cat2 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_cat2 As System.Windows.Forms.Label
    Friend WithEvents LBL_catup As System.Windows.Forms.Label
    Friend WithEvents Pan_cat1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_cat1 As System.Windows.Forms.Label
    Friend WithEvents But_selectvideo As System.Windows.Forms.Button
    Friend WithEvents CB_videolist As System.Windows.Forms.ComboBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents Pan_pictureselect_buttons1 As System.Windows.Forms.Panel
    Friend WithEvents But_prev_picture As System.Windows.Forms.Button
    Friend WithEvents Pan_pictureselect_buttons2 As System.Windows.Forms.Panel
    Friend WithEvents But_next_picture As System.Windows.Forms.Button
    Friend WithEvents Pan_pictureselect_menu As System.Windows.Forms.Panel
    Friend WithEvents CB_pictures As System.Windows.Forms.ComboBox
    Friend WithEvents Panel35 As System.Windows.Forms.Panel
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents pan_picture_select_buttons As System.Windows.Forms.Panel
    Friend WithEvents lbl_picture_select_buttons As System.Windows.Forms.Label
    Friend WithEvents pan_picture_select_menu As System.Windows.Forms.Panel
    Friend WithEvents lbl_picture_select_menu As System.Windows.Forms.Label
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Lbl_pattern_type As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TB_pan_morelines_speed As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Pan_tb As System.Windows.Forms.Panel
    Friend WithEvents Pic_textdatadown10 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_textdataup10 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_textdatabottom As System.Windows.Forms.Label
    Friend WithEvents Lbl_textdatadown1 As System.Windows.Forms.Label
    Friend WithEvents lbl_textdatatop As System.Windows.Forms.Label
    Friend WithEvents Lbl_textdataup1 As System.Windows.Forms.Label
    Friend WithEvents Label0 As System.Windows.Forms.Label
    Friend WithEvents TB0 As System.Windows.Forms.TextBox
    Friend WithEvents TB1 As System.Windows.Forms.TextBox
    Friend WithEvents TB2 As System.Windows.Forms.TextBox
    Friend WithEvents TB3 As System.Windows.Forms.TextBox
    Friend WithEvents TB4 As System.Windows.Forms.TextBox
    Friend WithEvents TB5 As System.Windows.Forms.TextBox
    Friend WithEvents TB6 As System.Windows.Forms.TextBox
    Friend WithEvents TB7 As System.Windows.Forms.TextBox
    Friend WithEvents TB8 As System.Windows.Forms.TextBox
    Friend WithEvents TB9 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Pan_cardbackground As System.Windows.Forms.Panel
    Friend WithEvents Timer_formloaded As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Timer_setkeyword_cursor As System.Windows.Forms.Timer
    Friend WithEvents LiteCard2 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard1 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard0 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard4 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard3 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard9 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard8 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard7 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard6 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard5 As jp_dragonbone1.LiteCard
    Friend WithEvents But_shape_arch As System.Windows.Forms.Button
    Friend WithEvents But_shape_straight As System.Windows.Forms.Button
    Friend WithEvents But_shape_revarch As System.Windows.Forms.Button
    Friend WithEvents ContextMen_litecards As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmi_bigclockwise As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmi_smallcounterclockwise As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmi_smallclockwise As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmi_bigcounterclockwise As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tim_finish_horr_line As System.Windows.Forms.Timer
    Friend WithEvents Timer_delayed_invalidate As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer_delayed_finish_pattern_line As System.Windows.Forms.Timer
    Friend WithEvents SignColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyColorPatternLibraryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_openlibrary As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern9 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern0 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern1 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern2 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern3 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern4 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern5 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern6 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern7 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern8 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern9 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents ColorTemplatesForTheSignToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents NUD_lines_cardcount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents NUD_linestab_liinecounts As System.Windows.Forms.NumericUpDown
    Friend WithEvents LiteCard10 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard11 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard12 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard13 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard14 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard15 As jp_dragonbone1.LiteCard
    Friend WithEvents ContextMenu_combokeywords As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Menu_comboallignment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Men_combo_allowexceedwordlength As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Men_combokeywordallign_left As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Men_combokeywordallign_center As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Men_combokeywordallign_right As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Men_combokeywordallign_none As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer_flagwatchdog As System.Windows.Forms.Timer
    Friend WithEvents USBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WirelessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OneSignToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OneSignToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MultipleSignsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer_refreshSignMenue As System.Windows.Forms.Timer
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Lbl_lines_sequencetime As System.Windows.Forms.Label
    Friend WithEvents Lbl_lines_linetime As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents HSB_speed_linestab As System.Windows.Forms.HScrollBar
    Friend WithEvents Timer_closeconnectdropdown As System.Windows.Forms.Timer
    Private WithEvents Tab_Easy As System.Windows.Forms.TabPage
    Friend WithEvents Pan_Control As System.Windows.Forms.Panel
    Friend WithEvents pan_chalkboard As System.Windows.Forms.Panel
    Friend WithEvents Pan_coonnect_menu As System.Windows.Forms.Panel
    Friend WithEvents men_connect As System.Windows.Forms.MenuStrip
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents But_get As System.Windows.Forms.Button
    Friend WithEvents But_send As System.Windows.Forms.Button
    Friend WithEvents Panel32 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_easy_sequencetime As System.Windows.Forms.Label
    Friend WithEvents Lbl_easy_linetime As System.Windows.Forms.Label
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Lbl_MyKeyword As System.Windows.Forms.Label
    Friend WithEvents Pan_keyword_background As System.Windows.Forms.Panel
    Friend WithEvents Txt_keyword As System.Windows.Forms.TextBox
    Friend WithEvents TXTdebug As System.Windows.Forms.TextBox
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents PB_horse_easytab As System.Windows.Forms.PictureBox
    Friend WithEvents PB_snail_easytab As System.Windows.Forms.PictureBox
    Friend WithEvents NUD_cardcount_easytab As System.Windows.Forms.NumericUpDown
    Friend WithEvents HSB_speed_easytab As System.Windows.Forms.HScrollBar
    Friend WithEvents RB_pat_random As System.Windows.Forms.RadioButton
    Friend WithEvents RB_pat_zoom As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_lightcards As System.Windows.Forms.Label
    Friend WithEvents RB_pat_Constant As System.Windows.Forms.RadioButton
    Friend WithEvents RB_pat_AddOn As System.Windows.Forms.RadioButton
    Friend WithEvents RB_pat_BlinkFast As System.Windows.Forms.RadioButton
    Friend WithEvents RB_pat_BlinkSlow As System.Windows.Forms.RadioButton
    Friend WithEvents RB_pat_Dance As System.Windows.Forms.RadioButton
    Friend WithEvents RB_pat_SplitOut As System.Windows.Forms.RadioButton
    Friend WithEvents RB_pat_JoinIn As System.Windows.Forms.RadioButton
    Friend WithEvents RB_pat_FlowLeft As System.Windows.Forms.RadioButton
    Friend WithEvents RB_pat_FlowRight As System.Windows.Forms.RadioButton
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Timer_showhide_connectcablemessage As System.Windows.Forms.Timer
    Friend WithEvents But_connect As System.Windows.Forms.Button
    Friend WithEvents Lbl_dialog As System.Windows.Forms.Label
    Friend WithEvents pan_no_pictures As System.Windows.Forms.Panel
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents pan_filerestrictions As System.Windows.Forms.Panel
    Friend WithEvents Button_discard_tricks As System.Windows.Forms.Button
    Friend WithEvents lbl_filerestrictions As System.Windows.Forms.Label
    Friend WithEvents PDFview_usermanuel_small As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents But_listchildren As System.Windows.Forms.Button
    Friend WithEvents Lbl_UserManual As System.Windows.Forms.Label
    Friend WithEvents Panel33 As System.Windows.Forms.Panel
    Friend WithEvents Pan_dialog As System.Windows.Forms.Panel
    Friend WithEvents Pan_dialog_mascot As System.Windows.Forms.Panel
    Friend WithEvents Pan_Design As System.Windows.Forms.Panel
    Friend WithEvents Pan_Woodbackground As System.Windows.Forms.Panel
    Friend WithEvents Pan_Usermanuel_small As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Timer_showhide_mustselectconnectionmessage As System.Windows.Forms.Timer
    Friend WithEvents Panel34 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents But_debug As System.Windows.Forms.Button
    Friend WithEvents Tab_FreeStyle As System.Windows.Forms.TabPage
    Friend WithEvents TxtFreeStyle As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_freestyle_sequencetime As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents HSB_speed_freestyletab As System.Windows.Forms.HScrollBar
    Friend WithEvents PB_horse_freestyletab As System.Windows.Forms.PictureBox
    Friend WithEvents PB_snail_freestyletab As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_freestyle_linetime As System.Windows.Forms.Label
    Friend WithEvents NUD_cardcount_freestyletab As System.Windows.Forms.NumericUpDown
    Friend WithEvents Pan_noUSBFound As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Pan_boardviewingarea As System.Windows.Forms.Panel
    Friend WithEvents AIV_USB As jp_dragonbone1.animatedimageviewer
    Friend WithEvents Pan_wirelessBaseNoSigns As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Pan_noWireless As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Pan_USBnodes As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Pan_wirelessnodes As System.Windows.Forms.Panel
    Friend WithEvents Pan_USBBase As System.Windows.Forms.Panel
    Friend WithEvents Lbl_uabnotfound As System.Windows.Forms.Label
    Friend WithEvents Pan_comBase As System.Windows.Forms.Panel
    Friend WithEvents Lbl_USB_text As System.Windows.Forms.Label
    Friend WithEvents Lbl_availablelines As System.Windows.Forms.Label
    Friend WithEvents LBL_linecount As System.Windows.Forms.Label
    Friend WithEvents Node_usb1 As jp_dragonbone1.node
    Friend WithEvents Node_usb5 As jp_dragonbone1.node
    Friend WithEvents Node_usb4 As jp_dragonbone1.node
    Friend WithEvents Node_usb3 As jp_dragonbone1.node
    Friend WithEvents Node_usb2 As jp_dragonbone1.node
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Node_wireless1 As jp_dragonbone1.node
    Friend WithEvents Node_wireless3 As jp_dragonbone1.node
    Friend WithEvents Node_wireless2 As jp_dragonbone1.node
    Friend WithEvents Node_wireless5 As jp_dragonbone1.node
    Friend WithEvents Node_wireless4 As jp_dragonbone1.node
    Friend WithEvents men_configure_internet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pan_internet_connection As System.Windows.Forms.Panel
    Friend WithEvents Lbl_internet_sign As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents But_server_savefile As System.Windows.Forms.Button
    Friend WithEvents But_server_openfile As System.Windows.Forms.Button
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Pan_sever_filebuttons As System.Windows.Forms.Panel
    Friend WithEvents InternetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OneSignToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MultipleSignsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AIV_Internet As jp_dragonbone1.animatedimageviewer
    Friend WithEvents lbl_internet_text As System.Windows.Forms.Label
    Friend WithEvents AIV_Zigbee As jp_dragonbone1.animatedimageviewer
    Friend WithEvents Lbl_zigbee_text As System.Windows.Forms.Label
    Friend WithEvents Pan_internetNodes As System.Windows.Forms.Panel
    Friend WithEvents Node_internet3 As jp_dragonbone1.node
    Friend WithEvents Node_internet2 As jp_dragonbone1.node
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Node_internet1 As jp_dragonbone1.node
    Friend WithEvents Pan_noServer As System.Windows.Forms.Panel
    Friend WithEvents lbl_999 As System.Windows.Forms.Label
    Friend WithEvents Pan_server_no_signs As System.Windows.Forms.Panel
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents LiteCard16 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard19 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard18 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard17 As jp_dragonbone1.LiteCard
    Friend WithEvents ConfigureRemoteSignsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
