<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class simulator_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(simulator_form))
        Me.TB_signtext = New System.Windows.Forms.TextBox()
        Me.Tim_trick1 = New System.Windows.Forms.Timer(Me.components)
        Me.But_close = New System.Windows.Forms.Button()
        Me.ContextMen_litecards = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmi_rotate = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmi_bigclockwise = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmi_smallclockwise = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmi_bigcounterclockwise = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmi_smallcounterclockwise = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_Z00M = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_z00minbig = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_z00minsmall = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_z00moutbig = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_z00moutsmall = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_m0vesign = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_m0vecards = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_l0ck = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_color = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_library = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.CMI_mypattern10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_card = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_fore_red = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_Fore_green = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_fore_blue = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_fore_white = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_templates = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Timer_delayed_invalidate = New System.Windows.Forms.Timer(Me.components)
        Me.Pan_buttons = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbut_custom_export = New System.Windows.Forms.Label()
        Me.Lbut_custon_start = New System.Windows.Forms.Label()
        Me.Lbut_custon_import = New System.Windows.Forms.Label()
        Me.LbL_custom = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PB_diagdown_line = New System.Windows.Forms.PictureBox()
        Me.PB_diagup_line = New System.Windows.Forms.PictureBox()
        Me.PB_s_curve = New System.Windows.Forms.PictureBox()
        Me.PB_arc = New System.Windows.Forms.PictureBox()
        Me.PB_rev_arc = New System.Windows.Forms.PictureBox()
        Me.PB_vert_line = New System.Windows.Forms.PictureBox()
        Me.Lbl_standard = New System.Windows.Forms.Label()
        Me.PB_horr_line = New System.Windows.Forms.PictureBox()
        Me.PB_m_curve = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Pan_BackgroundZoom = New System.Windows.Forms.Panel()
        Me.Pan_pict_BackgroundZoom = New System.Windows.Forms.Panel()
        Me.Lbut_BackgroundZoom = New System.Windows.Forms.Label()
        Me.Pan_BackgroundMove = New System.Windows.Forms.Panel()
        Me.Pan_pict_BackgroundMove = New System.Windows.Forms.Panel()
        Me.Lbut_BackgroundMove = New System.Windows.Forms.Label()
        Me.Lbut_BG_Default = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lbut_BackgroundZoomInLarge = New System.Windows.Forms.Label()
        Me.Lbut_BackgroundZoomInSmall = New System.Windows.Forms.Label()
        Me.Lbut_BackgroundZoomOutSmall = New System.Windows.Forms.Label()
        Me.Lbut_BackgroundZoomOutLarge = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Pan_pancontrols = New System.Windows.Forms.Panel()
        Me.Lbut_BackgroundPanLeft = New System.Windows.Forms.Label()
        Me.Lbut_BackgroundPanRight = New System.Windows.Forms.Label()
        Me.Lbut_BackgroundPanDown = New System.Windows.Forms.Label()
        Me.Lbut_BackgroundPanUp = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbut_SignPanLeft = New System.Windows.Forms.Label()
        Me.Lbut_SignPanRight = New System.Windows.Forms.Label()
        Me.Lbut_SignPanDown = New System.Windows.Forms.Label()
        Me.Lbut_SignPanUp = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lbut_ShrinkCardBig = New System.Windows.Forms.Label()
        Me.Lbut_EnlargeCardBig = New System.Windows.Forms.Label()
        Me.Lbut_EnlargeCardSmall = New System.Windows.Forms.Label()
        Me.Lbut_ShrinkCardSmall = New System.Windows.Forms.Label()
        Me.Pan_SignZoom = New System.Windows.Forms.Panel()
        Me.Pan_pict__SignZoom = New System.Windows.Forms.Panel()
        Me.Lbut_SignZoom = New System.Windows.Forms.Label()
        Me.Pan_SignMove = New System.Windows.Forms.Panel()
        Me.Pan_Pict_SignMove = New System.Windows.Forms.Panel()
        Me.Lbut_SignMove = New System.Windows.Forms.Label()
        Me.OFD_UploadPicture = New System.Windows.Forms.OpenFileDialog()
        Me.Pan_imageholder = New System.Windows.Forms.Panel()
        Me.Pan_cards = New System.Windows.Forms.Panel()
        Me.LiteCard19 = New jp_dragonbone1.LiteCard()
        Me.LiteCard18 = New jp_dragonbone1.LiteCard()
        Me.LiteCard17 = New jp_dragonbone1.LiteCard()
        Me.LiteCard16 = New jp_dragonbone1.LiteCard()
        Me.LiteCard0 = New jp_dragonbone1.LiteCard()
        Me.LiteCard10 = New jp_dragonbone1.LiteCard()
        Me.LiteCard11 = New jp_dragonbone1.LiteCard()
        Me.LiteCard12 = New jp_dragonbone1.LiteCard()
        Me.LiteCard13 = New jp_dragonbone1.LiteCard()
        Me.LiteCard14 = New jp_dragonbone1.LiteCard()
        Me.LiteCard15 = New jp_dragonbone1.LiteCard()
        Me.But_shape_straight = New System.Windows.Forms.Button()
        Me.But_shape_arch = New System.Windows.Forms.Button()
        Me.LiteCard1 = New jp_dragonbone1.LiteCard()
        Me.But_shape_revarch = New System.Windows.Forms.Button()
        Me.LiteCard2 = New jp_dragonbone1.LiteCard()
        Me.LiteCard3 = New jp_dragonbone1.LiteCard()
        Me.LiteCard9 = New jp_dragonbone1.LiteCard()
        Me.LiteCard4 = New jp_dragonbone1.LiteCard()
        Me.LiteCard8 = New jp_dragonbone1.LiteCard()
        Me.LiteCard5 = New jp_dragonbone1.LiteCard()
        Me.LiteCard7 = New jp_dragonbone1.LiteCard()
        Me.LiteCard6 = New jp_dragonbone1.LiteCard()
        Me.Lbl_debug = New System.Windows.Forms.Label()
        Me.Pan_dislpayregion = New System.Windows.Forms.Panel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContextMen_sign_zoom = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMI_sign_zoominsmall = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_sign_zoominlarge = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_sign_zoomoutsmall = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_sign_zoomoutlarge = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_movesign = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_movecards = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_lock = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_formloaded = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMen_Default = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMI_ZOOM = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_zoominBig = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_zoominSmall = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_zoomoutBig = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_zoomoutSmall = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_move_sign = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMI_move_cards = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_statusstrip = New System.Windows.Forms.Timer(Me.components)
        Me.SFD_export = New System.Windows.Forms.SaveFileDialog()
        Me.OFD_import = New System.Windows.Forms.OpenFileDialog()
        Me.Timer_delayed_show_cards = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMen_litecards.SuspendLayout()
        Me.Pan_buttons.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PB_diagdown_line, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_diagup_line, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_s_curve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_arc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_rev_arc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_vert_line, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_horr_line, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_m_curve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Pan_BackgroundZoom.SuspendLayout()
        Me.Pan_BackgroundMove.SuspendLayout()
        Me.Pan_pancontrols.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Pan_SignZoom.SuspendLayout()
        Me.Pan_SignMove.SuspendLayout()
        Me.Pan_imageholder.SuspendLayout()
        Me.Pan_cards.SuspendLayout()
        Me.Pan_dislpayregion.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ContextMen_sign_zoom.SuspendLayout()
        Me.ContextMen_Default.SuspendLayout()
        Me.SuspendLayout()
        '
        'TB_signtext
        '
        Me.TB_signtext.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TB_signtext.Font = New System.Drawing.Font("Lucida Console", 57.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_signtext.ForeColor = System.Drawing.Color.Red
        Me.TB_signtext.Location = New System.Drawing.Point(0, 116)
        Me.TB_signtext.Name = "TB_signtext"
        Me.TB_signtext.Size = New System.Drawing.Size(58, 84)
        Me.TB_signtext.TabIndex = 1
        Me.TB_signtext.Visible = False
        '
        'Tim_trick1
        '
        '
        'But_close
        '
        Me.But_close.Location = New System.Drawing.Point(365, 134)
        Me.But_close.Name = "But_close"
        Me.But_close.Size = New System.Drawing.Size(75, 23)
        Me.But_close.TabIndex = 2
        Me.But_close.Text = "Close"
        Me.But_close.UseVisualStyleBackColor = True
        Me.But_close.Visible = False
        '
        'ContextMen_litecards
        '
        Me.ContextMen_litecards.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmi_rotate, Me.CMI_Z00M, Me.CMI_m0vesign, Me.CMI_m0vecards, Me.CMI_l0ck, Me.CMI_color})
        Me.ContextMen_litecards.Name = "ContextMen_litecards"
        Me.ContextMen_litecards.Size = New System.Drawing.Size(191, 136)
        '
        'cmi_rotate
        '
        Me.cmi_rotate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmi_bigclockwise, Me.cmi_smallclockwise, Me.cmi_bigcounterclockwise, Me.cmi_smallcounterclockwise})
        Me.cmi_rotate.Name = "cmi_rotate"
        Me.cmi_rotate.Size = New System.Drawing.Size(190, 22)
        Me.cmi_rotate.Text = "Rotate Card"
        '
        'cmi_bigclockwise
        '
        Me.cmi_bigclockwise.Font = New System.Drawing.Font("Wingdings", 8.25!)
        Me.cmi_bigclockwise.Name = "cmi_bigclockwise"
        Me.cmi_bigclockwise.Size = New System.Drawing.Size(96, 22)
        Me.cmi_bigclockwise.Text = "ÊÊ"
        '
        'cmi_smallclockwise
        '
        Me.cmi_smallclockwise.Font = New System.Drawing.Font("Wingdings", 8.25!)
        Me.cmi_smallclockwise.Name = "cmi_smallclockwise"
        Me.cmi_smallclockwise.Size = New System.Drawing.Size(96, 22)
        Me.cmi_smallclockwise.Text = "Ê"
        '
        'cmi_bigcounterclockwise
        '
        Me.cmi_bigcounterclockwise.Font = New System.Drawing.Font("Wingdings", 8.25!)
        Me.cmi_bigcounterclockwise.Name = "cmi_bigcounterclockwise"
        Me.cmi_bigcounterclockwise.Size = New System.Drawing.Size(96, 22)
        Me.cmi_bigcounterclockwise.Text = "ÉÉ"
        '
        'cmi_smallcounterclockwise
        '
        Me.cmi_smallcounterclockwise.Font = New System.Drawing.Font("Wingdings", 8.25!)
        Me.cmi_smallcounterclockwise.Name = "cmi_smallcounterclockwise"
        Me.cmi_smallcounterclockwise.Size = New System.Drawing.Size(96, 22)
        Me.cmi_smallcounterclockwise.Text = "É"
        '
        'CMI_Z00M
        '
        Me.CMI_Z00M.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMI_z00minbig, Me.CMI_z00minsmall, Me.CMI_z00moutbig, Me.CMI_z00moutsmall})
        Me.CMI_Z00M.Name = "CMI_Z00M"
        Me.CMI_Z00M.Size = New System.Drawing.Size(190, 22)
        Me.CMI_Z00M.Text = "Zoom"
        '
        'CMI_z00minbig
        '
        Me.CMI_z00minbig.Name = "CMI_z00minbig"
        Me.CMI_z00minbig.Size = New System.Drawing.Size(107, 22)
        Me.CMI_z00minbig.Text = "In ++"
        '
        'CMI_z00minsmall
        '
        Me.CMI_z00minsmall.Name = "CMI_z00minsmall"
        Me.CMI_z00minsmall.Size = New System.Drawing.Size(107, 22)
        Me.CMI_z00minsmall.Text = "In -"
        '
        'CMI_z00moutbig
        '
        Me.CMI_z00moutbig.Name = "CMI_z00moutbig"
        Me.CMI_z00moutbig.Size = New System.Drawing.Size(107, 22)
        Me.CMI_z00moutbig.Text = "Out --"
        '
        'CMI_z00moutsmall
        '
        Me.CMI_z00moutsmall.Name = "CMI_z00moutsmall"
        Me.CMI_z00moutsmall.Size = New System.Drawing.Size(107, 22)
        Me.CMI_z00moutsmall.Text = "Out -"
        '
        'CMI_m0vesign
        '
        Me.CMI_m0vesign.Name = "CMI_m0vesign"
        Me.CMI_m0vesign.Size = New System.Drawing.Size(190, 22)
        Me.CMI_m0vesign.Text = "Move Entire Sign"
        '
        'CMI_m0vecards
        '
        Me.CMI_m0vecards.Name = "CMI_m0vecards"
        Me.CMI_m0vecards.Size = New System.Drawing.Size(190, 22)
        Me.CMI_m0vecards.Text = "Move individual cards"
        '
        'CMI_l0ck
        '
        Me.CMI_l0ck.Name = "CMI_l0ck"
        Me.CMI_l0ck.Size = New System.Drawing.Size(190, 22)
        Me.CMI_l0ck.Text = "Lock Position"
        '
        'CMI_color
        '
        Me.CMI_color.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMI_library, Me.CMI_card, Me.CMI_templates})
        Me.CMI_color.Name = "CMI_color"
        Me.CMI_color.Size = New System.Drawing.Size(190, 22)
        Me.CMI_color.Text = "Color"
        '
        'CMI_library
        '
        Me.CMI_library.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMI_openlibrary, Me.CMI_mypattern0, Me.CMI_mypattern1, Me.CMI_mypattern2, Me.CMI_mypattern3, Me.CMI_mypattern4, Me.CMI_mypattern5, Me.CMI_mypattern6, Me.CMI_mypattern7, Me.CMI_mypattern8, Me.CMI_mypattern9, Me.CMI_mypattern10})
        Me.CMI_library.Name = "CMI_library"
        Me.CMI_library.Size = New System.Drawing.Size(200, 22)
        Me.CMI_library.Text = "My Color design Library"
        '
        'CMI_openlibrary
        '
        Me.CMI_openlibrary.Name = "CMI_openlibrary"
        Me.CMI_openlibrary.Size = New System.Drawing.Size(189, 22)
        Me.CMI_openlibrary.Text = "Open my library"
        '
        'CMI_mypattern0
        '
        Me.CMI_mypattern0.Name = "CMI_mypattern0"
        Me.CMI_mypattern0.Size = New System.Drawing.Size(189, 22)
        Me.CMI_mypattern0.Text = "ToolStripMenuItem11"
        Me.CMI_mypattern0.Visible = False
        '
        'CMI_mypattern1
        '
        Me.CMI_mypattern1.Name = "CMI_mypattern1"
        Me.CMI_mypattern1.Size = New System.Drawing.Size(189, 22)
        Me.CMI_mypattern1.Text = "ToolStripMenuItem1"
        Me.CMI_mypattern1.Visible = False
        '
        'CMI_mypattern2
        '
        Me.CMI_mypattern2.Name = "CMI_mypattern2"
        Me.CMI_mypattern2.Size = New System.Drawing.Size(189, 22)
        Me.CMI_mypattern2.Visible = False
        '
        'CMI_mypattern3
        '
        Me.CMI_mypattern3.Name = "CMI_mypattern3"
        Me.CMI_mypattern3.Size = New System.Drawing.Size(189, 22)
        Me.CMI_mypattern3.Visible = False
        '
        'CMI_mypattern4
        '
        Me.CMI_mypattern4.Name = "CMI_mypattern4"
        Me.CMI_mypattern4.Size = New System.Drawing.Size(189, 22)
        Me.CMI_mypattern4.Text = "ToolStripMenuItem4"
        Me.CMI_mypattern4.Visible = False
        '
        'CMI_mypattern5
        '
        Me.CMI_mypattern5.Name = "CMI_mypattern5"
        Me.CMI_mypattern5.Size = New System.Drawing.Size(189, 22)
        Me.CMI_mypattern5.Text = "ToolStripMenuItem5"
        Me.CMI_mypattern5.Visible = False
        '
        'CMI_mypattern6
        '
        Me.CMI_mypattern6.Name = "CMI_mypattern6"
        Me.CMI_mypattern6.Size = New System.Drawing.Size(189, 22)
        Me.CMI_mypattern6.Text = "ToolStripMenuItem6"
        Me.CMI_mypattern6.Visible = False
        '
        'CMI_mypattern7
        '
        Me.CMI_mypattern7.Name = "CMI_mypattern7"
        Me.CMI_mypattern7.Size = New System.Drawing.Size(189, 22)
        Me.CMI_mypattern7.Text = "ToolStripMenuItem7"
        Me.CMI_mypattern7.Visible = False
        '
        'CMI_mypattern8
        '
        Me.CMI_mypattern8.Name = "CMI_mypattern8"
        Me.CMI_mypattern8.Size = New System.Drawing.Size(189, 22)
        Me.CMI_mypattern8.Text = "ToolStripMenuItem8"
        Me.CMI_mypattern8.Visible = False
        '
        'CMI_mypattern9
        '
        Me.CMI_mypattern9.Name = "CMI_mypattern9"
        Me.CMI_mypattern9.Size = New System.Drawing.Size(189, 22)
        Me.CMI_mypattern9.Text = "ToolStripMenuItem9"
        Me.CMI_mypattern9.Visible = False
        '
        'CMI_mypattern10
        '
        Me.CMI_mypattern10.Name = "CMI_mypattern10"
        Me.CMI_mypattern10.Size = New System.Drawing.Size(189, 22)
        Me.CMI_mypattern10.Text = "ToolStripMenuItem10"
        Me.CMI_mypattern10.Visible = False
        '
        'CMI_card
        '
        Me.CMI_card.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMI_fore_red, Me.CMI_Fore_green, Me.CMI_fore_blue, Me.CMI_fore_white})
        Me.CMI_card.Name = "CMI_card"
        Me.CMI_card.Size = New System.Drawing.Size(200, 22)
        Me.CMI_card.Text = "Card"
        '
        'CMI_fore_red
        '
        Me.CMI_fore_red.Name = "CMI_fore_red"
        Me.CMI_fore_red.Size = New System.Drawing.Size(127, 22)
        Me.CMI_fore_red.Text = "Red - R"
        '
        'CMI_Fore_green
        '
        Me.CMI_Fore_green.Name = "CMI_Fore_green"
        Me.CMI_Fore_green.Size = New System.Drawing.Size(127, 22)
        Me.CMI_Fore_green.Text = "Green - G"
        '
        'CMI_fore_blue
        '
        Me.CMI_fore_blue.Name = "CMI_fore_blue"
        Me.CMI_fore_blue.Size = New System.Drawing.Size(127, 22)
        Me.CMI_fore_blue.Text = "Blue - B"
        '
        'CMI_fore_white
        '
        Me.CMI_fore_white.Name = "CMI_fore_white"
        Me.CMI_fore_white.Size = New System.Drawing.Size(127, 22)
        Me.CMI_fore_white.Text = "White - W"
        '
        'CMI_templates
        '
        Me.CMI_templates.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMI_colorpattern0, Me.CMI_colorpattern1, Me.CMI_colorpattern2, Me.CMI_colorpattern3, Me.CMI_colorpattern4, Me.CMI_colorpattern5, Me.CMI_colorpattern6, Me.CMI_colorpattern7, Me.CMI_colorpattern8, Me.CMI_colorpattern9})
        Me.CMI_templates.Name = "CMI_templates"
        Me.CMI_templates.Size = New System.Drawing.Size(200, 22)
        Me.CMI_templates.Text = "Sign"
        '
        'CMI_colorpattern0
        '
        Me.CMI_colorpattern0.Name = "CMI_colorpattern0"
        Me.CMI_colorpattern0.Size = New System.Drawing.Size(210, 22)
        Me.CMI_colorpattern0.Tag = "RRRRRRRRRRRRRRRRRRRR"
        Me.CMI_colorpattern0.Text = "All Red"
        '
        'CMI_colorpattern1
        '
        Me.CMI_colorpattern1.Name = "CMI_colorpattern1"
        Me.CMI_colorpattern1.Size = New System.Drawing.Size(210, 22)
        Me.CMI_colorpattern1.Tag = "GGGGGGGGGGGGGGGGGGGG"
        Me.CMI_colorpattern1.Text = "All Green"
        '
        'CMI_colorpattern2
        '
        Me.CMI_colorpattern2.Name = "CMI_colorpattern2"
        Me.CMI_colorpattern2.Size = New System.Drawing.Size(210, 22)
        Me.CMI_colorpattern2.Tag = "BBBBBBBBBBBBBBBBBBBB"
        Me.CMI_colorpattern2.Text = "All Blue"
        '
        'CMI_colorpattern3
        '
        Me.CMI_colorpattern3.Name = "CMI_colorpattern3"
        Me.CMI_colorpattern3.Size = New System.Drawing.Size(210, 22)
        Me.CMI_colorpattern3.Tag = "WWWWWWWWWWWWWWWWWWWW"
        Me.CMI_colorpattern3.Text = "All White"
        '
        'CMI_colorpattern4
        '
        Me.CMI_colorpattern4.Name = "CMI_colorpattern4"
        Me.CMI_colorpattern4.Size = New System.Drawing.Size(210, 22)
        Me.CMI_colorpattern4.Tag = "GBWRGBWRGBRGBWRGBWRG"
        Me.CMI_colorpattern4.Text = "GBWRGBWRGBRGBWRG"
        '
        'CMI_colorpattern5
        '
        Me.CMI_colorpattern5.Name = "CMI_colorpattern5"
        Me.CMI_colorpattern5.Size = New System.Drawing.Size(210, 22)
        Me.CMI_colorpattern5.Tag = "RGBWRGBWRGBWRGBWRGBW"
        Me.CMI_colorpattern5.Text = "RGBWRGBWRGBWRGBW"
        '
        'CMI_colorpattern6
        '
        Me.CMI_colorpattern6.Name = "CMI_colorpattern6"
        Me.CMI_colorpattern6.Size = New System.Drawing.Size(210, 22)
        Me.CMI_colorpattern6.Tag = "RGBRGBRGBRGBRGBRGBRG"
        Me.CMI_colorpattern6.Text = "RGBRGBRGBRGBRGBR"
        '
        'CMI_colorpattern7
        '
        Me.CMI_colorpattern7.Name = "CMI_colorpattern7"
        Me.CMI_colorpattern7.Size = New System.Drawing.Size(210, 22)
        Me.CMI_colorpattern7.Tag = "RGRGRGRGRGRGRGRGRGRG"
        Me.CMI_colorpattern7.Text = "RGRGRGRGRGRGRGRG"
        '
        'CMI_colorpattern8
        '
        Me.CMI_colorpattern8.Name = "CMI_colorpattern8"
        Me.CMI_colorpattern8.Size = New System.Drawing.Size(210, 22)
        Me.CMI_colorpattern8.Tag = "BWRBWBWRBWBWRBWBWRBW"
        Me.CMI_colorpattern8.Text = "BWRBWBWRBWBWRBWB"
        '
        'CMI_colorpattern9
        '
        Me.CMI_colorpattern9.Name = "CMI_colorpattern9"
        Me.CMI_colorpattern9.Size = New System.Drawing.Size(210, 22)
        Me.CMI_colorpattern9.Tag = "RRGWBRRGWBRRGWBRGWBR"
        Me.CMI_colorpattern9.Text = "RRGWBRRGWBRRGWBR"
        '
        'Timer_delayed_invalidate
        '
        Me.Timer_delayed_invalidate.Interval = 200
        '
        'Pan_buttons
        '
        Me.Pan_buttons.Controls.Add(Me.SplitContainer1)
        Me.Pan_buttons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pan_buttons.Location = New System.Drawing.Point(0, 399)
        Me.Pan_buttons.Name = "Pan_buttons"
        Me.Pan_buttons.Size = New System.Drawing.Size(530, 138)
        Me.Pan_buttons.TabIndex = 29
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.LightBlue
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(530, 138)
        Me.SplitContainer1.SplitterDistance = 286
        Me.SplitContainer1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(215, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "rotate"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(156, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "rotate"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pattern Design"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 29)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer2.Panel1.Padding = New System.Windows.Forms.Padding(5)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer2.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.SplitContainer2.Size = New System.Drawing.Size(282, 105)
        Me.SplitContainer2.SplitterDistance = 148
        Me.SplitContainer2.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Lbut_custom_export, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Lbut_custon_start, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Lbut_custon_import, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LbL_custom, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(134, 91)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Lbut_custom_export
        '
        Me.Lbut_custom_export.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_custom_export.AutoSize = True
        Me.Lbut_custom_export.BackColor = System.Drawing.Color.White
        Me.Lbut_custom_export.Location = New System.Drawing.Point(2, 68)
        Me.Lbut_custom_export.Margin = New System.Windows.Forms.Padding(1)
        Me.Lbut_custom_export.Name = "Lbut_custom_export"
        Me.Lbut_custom_export.Size = New System.Drawing.Size(130, 21)
        Me.Lbut_custom_export.TabIndex = 3
        Me.Lbut_custom_export.Text = "Export"
        Me.Lbut_custom_export.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbut_custon_start
        '
        Me.Lbut_custon_start.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_custon_start.AutoSize = True
        Me.Lbut_custon_start.BackColor = System.Drawing.Color.White
        Me.Lbut_custon_start.Location = New System.Drawing.Point(2, 23)
        Me.Lbut_custon_start.Margin = New System.Windows.Forms.Padding(1)
        Me.Lbut_custon_start.Name = "Lbut_custon_start"
        Me.Lbut_custon_start.Size = New System.Drawing.Size(130, 20)
        Me.Lbut_custon_start.TabIndex = 1
        Me.Lbut_custon_start.Text = "Arrange cards"
        Me.Lbut_custon_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbut_custon_import
        '
        Me.Lbut_custon_import.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_custon_import.AutoSize = True
        Me.Lbut_custon_import.BackColor = System.Drawing.Color.White
        Me.Lbut_custon_import.Location = New System.Drawing.Point(2, 46)
        Me.Lbut_custon_import.Margin = New System.Windows.Forms.Padding(1)
        Me.Lbut_custon_import.Name = "Lbut_custon_import"
        Me.Lbut_custon_import.Size = New System.Drawing.Size(130, 19)
        Me.Lbut_custon_import.TabIndex = 2
        Me.Lbut_custon_import.Text = "Import"
        Me.Lbut_custon_import.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbL_custom
        '
        Me.LbL_custom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbL_custom.AutoSize = True
        Me.LbL_custom.BackColor = System.Drawing.Color.LightGreen
        Me.LbL_custom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbL_custom.Location = New System.Drawing.Point(4, 4)
        Me.LbL_custom.Margin = New System.Windows.Forms.Padding(3)
        Me.LbL_custom.Name = "LbL_custom"
        Me.LbL_custom.Size = New System.Drawing.Size(126, 14)
        Me.LbL_custom.TabIndex = 0
        Me.LbL_custom.Text = "My Pattern"
        Me.LbL_custom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PB_diagdown_line, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.PB_diagup_line, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.PB_s_curve, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.PB_arc, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.PB_rev_arc, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.PB_vert_line, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Lbl_standard, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PB_horr_line, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PB_m_curve, 1, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(116, 91)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'PB_diagdown_line
        '
        Me.PB_diagdown_line.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PB_diagdown_line.BackColor = System.Drawing.Color.White
        Me.PB_diagdown_line.Image = CType(resources.GetObject("PB_diagdown_line.Image"), System.Drawing.Image)
        Me.PB_diagdown_line.Location = New System.Drawing.Point(65, 76)
        Me.PB_diagdown_line.Name = "PB_diagdown_line"
        Me.PB_diagdown_line.Size = New System.Drawing.Size(42, 11)
        Me.PB_diagdown_line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_diagdown_line.TabIndex = 17
        Me.PB_diagdown_line.TabStop = False
        '
        'PB_diagup_line
        '
        Me.PB_diagup_line.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PB_diagup_line.BackColor = System.Drawing.Color.White
        Me.PB_diagup_line.Image = CType(resources.GetObject("PB_diagup_line.Image"), System.Drawing.Image)
        Me.PB_diagup_line.Location = New System.Drawing.Point(8, 76)
        Me.PB_diagup_line.Name = "PB_diagup_line"
        Me.PB_diagup_line.Size = New System.Drawing.Size(41, 11)
        Me.PB_diagup_line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_diagup_line.TabIndex = 16
        Me.PB_diagup_line.TabStop = False
        '
        'PB_s_curve
        '
        Me.PB_s_curve.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PB_s_curve.BackColor = System.Drawing.Color.White
        Me.PB_s_curve.Image = CType(resources.GetObject("PB_s_curve.Image"), System.Drawing.Image)
        Me.PB_s_curve.Location = New System.Drawing.Point(8, 59)
        Me.PB_s_curve.Name = "PB_s_curve"
        Me.PB_s_curve.Size = New System.Drawing.Size(41, 10)
        Me.PB_s_curve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_s_curve.TabIndex = 15
        Me.PB_s_curve.TabStop = False
        '
        'PB_arc
        '
        Me.PB_arc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PB_arc.BackColor = System.Drawing.Color.White
        Me.PB_arc.Image = CType(resources.GetObject("PB_arc.Image"), System.Drawing.Image)
        Me.PB_arc.Location = New System.Drawing.Point(65, 42)
        Me.PB_arc.Name = "PB_arc"
        Me.PB_arc.Size = New System.Drawing.Size(42, 10)
        Me.PB_arc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_arc.TabIndex = 14
        Me.PB_arc.TabStop = False
        '
        'PB_rev_arc
        '
        Me.PB_rev_arc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PB_rev_arc.BackColor = System.Drawing.Color.White
        Me.PB_rev_arc.Image = Global.jp_dragonbone1.My.Resources.Resources.U_arch_icon
        Me.PB_rev_arc.Location = New System.Drawing.Point(8, 42)
        Me.PB_rev_arc.Name = "PB_rev_arc"
        Me.PB_rev_arc.Size = New System.Drawing.Size(41, 10)
        Me.PB_rev_arc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_rev_arc.TabIndex = 13
        Me.PB_rev_arc.TabStop = False
        '
        'PB_vert_line
        '
        Me.PB_vert_line.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PB_vert_line.BackColor = System.Drawing.Color.White
        Me.PB_vert_line.Image = Global.jp_dragonbone1.My.Resources.Resources.v_line_icon
        Me.PB_vert_line.Location = New System.Drawing.Point(65, 25)
        Me.PB_vert_line.Name = "PB_vert_line"
        Me.PB_vert_line.Size = New System.Drawing.Size(42, 10)
        Me.PB_vert_line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_vert_line.TabIndex = 12
        Me.PB_vert_line.TabStop = False
        '
        'Lbl_standard
        '
        Me.Lbl_standard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_standard.AutoSize = True
        Me.Lbl_standard.BackColor = System.Drawing.Color.LightGreen
        Me.TableLayoutPanel2.SetColumnSpan(Me.Lbl_standard, 2)
        Me.Lbl_standard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_standard.Location = New System.Drawing.Point(1, 1)
        Me.Lbl_standard.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_standard.Name = "Lbl_standard"
        Me.Lbl_standard.Size = New System.Drawing.Size(114, 20)
        Me.Lbl_standard.TabIndex = 0
        Me.Lbl_standard.Text = "Free Template"
        Me.Lbl_standard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PB_horr_line
        '
        Me.PB_horr_line.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PB_horr_line.BackColor = System.Drawing.Color.White
        Me.PB_horr_line.Image = Global.jp_dragonbone1.My.Resources.Resources.line_icon
        Me.PB_horr_line.Location = New System.Drawing.Point(8, 25)
        Me.PB_horr_line.Name = "PB_horr_line"
        Me.PB_horr_line.Size = New System.Drawing.Size(41, 10)
        Me.PB_horr_line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_horr_line.TabIndex = 10
        Me.PB_horr_line.TabStop = False
        '
        'PB_m_curve
        '
        Me.PB_m_curve.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PB_m_curve.BackColor = System.Drawing.Color.White
        Me.PB_m_curve.Image = CType(resources.GetObject("PB_m_curve.Image"), System.Drawing.Image)
        Me.PB_m_curve.Location = New System.Drawing.Point(65, 59)
        Me.PB_m_curve.Name = "PB_m_curve"
        Me.PB_m_curve.Size = New System.Drawing.Size(42, 10)
        Me.PB_m_curve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_m_curve.TabIndex = 11
        Me.PB_m_curve.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "View Manipulation"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 29)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.SplitContainer3.Panel1.Padding = New System.Windows.Forms.Padding(4)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.TableLayoutPanel4)
        Me.SplitContainer3.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.SplitContainer3.Size = New System.Drawing.Size(236, 105)
        Me.SplitContainer3.SplitterDistance = 123
        Me.SplitContainer3.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.9992!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0004!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0004!))
        Me.TableLayoutPanel3.Controls.Add(Me.Pan_BackgroundZoom, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Pan_BackgroundMove, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Lbut_BG_Default, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Lbut_BackgroundZoomInLarge, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Lbut_BackgroundZoomInSmall, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Lbut_BackgroundZoomOutSmall, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Lbut_BackgroundZoomOutLarge, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label18, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Pan_pancontrols, 1, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(111, 93)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Pan_BackgroundZoom
        '
        Me.Pan_BackgroundZoom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pan_BackgroundZoom.BackColor = System.Drawing.Color.LightBlue
        Me.Pan_BackgroundZoom.Controls.Add(Me.Pan_pict_BackgroundZoom)
        Me.Pan_BackgroundZoom.Controls.Add(Me.Lbut_BackgroundZoom)
        Me.Pan_BackgroundZoom.Location = New System.Drawing.Point(1, 66)
        Me.Pan_BackgroundZoom.Margin = New System.Windows.Forms.Padding(0)
        Me.Pan_BackgroundZoom.Name = "Pan_BackgroundZoom"
        Me.TableLayoutPanel3.SetRowSpan(Me.Pan_BackgroundZoom, 2)
        Me.Pan_BackgroundZoom.Size = New System.Drawing.Size(53, 26)
        Me.Pan_BackgroundZoom.TabIndex = 30
        '
        'Pan_pict_BackgroundZoom
        '
        Me.Pan_pict_BackgroundZoom.BackColor = System.Drawing.Color.White
        Me.Pan_pict_BackgroundZoom.BackgroundImage = Global.jp_dragonbone1.My.Resources.Resources.magnify_glass_icon0
        Me.Pan_pict_BackgroundZoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pan_pict_BackgroundZoom.Location = New System.Drawing.Point(29, 3)
        Me.Pan_pict_BackgroundZoom.Name = "Pan_pict_BackgroundZoom"
        Me.Pan_pict_BackgroundZoom.Size = New System.Drawing.Size(26, 18)
        Me.Pan_pict_BackgroundZoom.TabIndex = 16
        '
        'Lbut_BackgroundZoom
        '
        Me.Lbut_BackgroundZoom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_BackgroundZoom.AutoSize = True
        Me.Lbut_BackgroundZoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbut_BackgroundZoom.Location = New System.Drawing.Point(0, 6)
        Me.Lbut_BackgroundZoom.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbut_BackgroundZoom.Name = "Lbut_BackgroundZoom"
        Me.Lbut_BackgroundZoom.Size = New System.Drawing.Size(29, 12)
        Me.Lbut_BackgroundZoom.TabIndex = 15
        Me.Lbut_BackgroundZoom.Text = "Zoom"
        Me.Lbut_BackgroundZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pan_BackgroundMove
        '
        Me.Pan_BackgroundMove.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pan_BackgroundMove.BackColor = System.Drawing.Color.LightBlue
        Me.Pan_BackgroundMove.Controls.Add(Me.Pan_pict_BackgroundMove)
        Me.Pan_BackgroundMove.Controls.Add(Me.Lbut_BackgroundMove)
        Me.Pan_BackgroundMove.Location = New System.Drawing.Point(1, 44)
        Me.Pan_BackgroundMove.Margin = New System.Windows.Forms.Padding(0)
        Me.Pan_BackgroundMove.Name = "Pan_BackgroundMove"
        Me.Pan_BackgroundMove.Size = New System.Drawing.Size(53, 21)
        Me.Pan_BackgroundMove.TabIndex = 29
        '
        'Pan_pict_BackgroundMove
        '
        Me.Pan_pict_BackgroundMove.BackColor = System.Drawing.Color.White
        Me.Pan_pict_BackgroundMove.BackgroundImage = Global.jp_dragonbone1.My.Resources.Resources.hand_move_icon1
        Me.Pan_pict_BackgroundMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pan_pict_BackgroundMove.Location = New System.Drawing.Point(30, 3)
        Me.Pan_pict_BackgroundMove.Name = "Pan_pict_BackgroundMove"
        Me.Pan_pict_BackgroundMove.Size = New System.Drawing.Size(25, 16)
        Me.Pan_pict_BackgroundMove.TabIndex = 16
        '
        'Lbut_BackgroundMove
        '
        Me.Lbut_BackgroundMove.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_BackgroundMove.AutoSize = True
        Me.Lbut_BackgroundMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbut_BackgroundMove.Location = New System.Drawing.Point(1, 4)
        Me.Lbut_BackgroundMove.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbut_BackgroundMove.Name = "Lbut_BackgroundMove"
        Me.Lbut_BackgroundMove.Size = New System.Drawing.Size(30, 12)
        Me.Lbut_BackgroundMove.TabIndex = 15
        Me.Lbut_BackgroundMove.Text = "Move"
        Me.Lbut_BackgroundMove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbut_BG_Default
        '
        Me.Lbut_BG_Default.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_BG_Default.AutoSize = True
        Me.Lbut_BG_Default.BackColor = System.Drawing.Color.White
        Me.Lbut_BG_Default.Location = New System.Drawing.Point(1, 22)
        Me.Lbut_BG_Default.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbut_BG_Default.Name = "Lbut_BG_Default"
        Me.Lbut_BG_Default.Size = New System.Drawing.Size(53, 21)
        Me.Lbut_BG_Default.TabIndex = 12
        Me.Lbut_BG_Default.Text = "None"
        Me.Lbut_BG_Default.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightGreen
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label5, 3)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 1)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Background Image"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbut_BackgroundZoomInLarge
        '
        Me.Lbut_BackgroundZoomInLarge.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_BackgroundZoomInLarge.AutoSize = True
        Me.Lbut_BackgroundZoomInLarge.BackColor = System.Drawing.Color.White
        Me.Lbut_BackgroundZoomInLarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbut_BackgroundZoomInLarge.Location = New System.Drawing.Point(82, 66)
        Me.Lbut_BackgroundZoomInLarge.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbut_BackgroundZoomInLarge.Name = "Lbut_BackgroundZoomInLarge"
        Me.Lbut_BackgroundZoomInLarge.Size = New System.Drawing.Size(28, 13)
        Me.Lbut_BackgroundZoomInLarge.TabIndex = 13
        Me.Lbut_BackgroundZoomInLarge.Text = "++"
        Me.Lbut_BackgroundZoomInLarge.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbut_BackgroundZoomInSmall
        '
        Me.Lbut_BackgroundZoomInSmall.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_BackgroundZoomInSmall.AutoSize = True
        Me.Lbut_BackgroundZoomInSmall.BackColor = System.Drawing.Color.White
        Me.Lbut_BackgroundZoomInSmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbut_BackgroundZoomInSmall.Location = New System.Drawing.Point(55, 66)
        Me.Lbut_BackgroundZoomInSmall.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbut_BackgroundZoomInSmall.Name = "Lbut_BackgroundZoomInSmall"
        Me.Lbut_BackgroundZoomInSmall.Size = New System.Drawing.Size(26, 13)
        Me.Lbut_BackgroundZoomInSmall.TabIndex = 10
        Me.Lbut_BackgroundZoomInSmall.Text = "+"
        Me.Lbut_BackgroundZoomInSmall.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbut_BackgroundZoomOutSmall
        '
        Me.Lbut_BackgroundZoomOutSmall.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_BackgroundZoomOutSmall.AutoSize = True
        Me.Lbut_BackgroundZoomOutSmall.BackColor = System.Drawing.Color.White
        Me.Lbut_BackgroundZoomOutSmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbut_BackgroundZoomOutSmall.Location = New System.Drawing.Point(55, 80)
        Me.Lbut_BackgroundZoomOutSmall.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbut_BackgroundZoomOutSmall.Name = "Lbut_BackgroundZoomOutSmall"
        Me.Lbut_BackgroundZoomOutSmall.Size = New System.Drawing.Size(26, 12)
        Me.Lbut_BackgroundZoomOutSmall.TabIndex = 11
        Me.Lbut_BackgroundZoomOutSmall.Text = "-"
        Me.Lbut_BackgroundZoomOutSmall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbut_BackgroundZoomOutLarge
        '
        Me.Lbut_BackgroundZoomOutLarge.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_BackgroundZoomOutLarge.AutoSize = True
        Me.Lbut_BackgroundZoomOutLarge.BackColor = System.Drawing.Color.White
        Me.Lbut_BackgroundZoomOutLarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbut_BackgroundZoomOutLarge.Location = New System.Drawing.Point(82, 80)
        Me.Lbut_BackgroundZoomOutLarge.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbut_BackgroundZoomOutLarge.Name = "Lbut_BackgroundZoomOutLarge"
        Me.Lbut_BackgroundZoomOutLarge.Size = New System.Drawing.Size(28, 12)
        Me.Lbut_BackgroundZoomOutLarge.TabIndex = 12
        Me.Lbut_BackgroundZoomOutLarge.Text = "- -"
        Me.Lbut_BackgroundZoomOutLarge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label18, 2)
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(55, 22)
        Me.Label18.Margin = New System.Windows.Forms.Padding(0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 21)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "My Picture"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pan_pancontrols
        '
        Me.Pan_pancontrols.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.Pan_pancontrols, 2)
        Me.Pan_pancontrols.Controls.Add(Me.Lbut_BackgroundPanLeft)
        Me.Pan_pancontrols.Controls.Add(Me.Lbut_BackgroundPanRight)
        Me.Pan_pancontrols.Controls.Add(Me.Lbut_BackgroundPanDown)
        Me.Pan_pancontrols.Controls.Add(Me.Lbut_BackgroundPanUp)
        Me.Pan_pancontrols.Location = New System.Drawing.Point(55, 44)
        Me.Pan_pancontrols.Margin = New System.Windows.Forms.Padding(0)
        Me.Pan_pancontrols.Name = "Pan_pancontrols"
        Me.Pan_pancontrols.Size = New System.Drawing.Size(55, 21)
        Me.Pan_pancontrols.TabIndex = 13
        '
        'Lbut_BackgroundPanLeft
        '
        Me.Lbut_BackgroundPanLeft.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_BackgroundPanLeft.AutoSize = True
        Me.Lbut_BackgroundPanLeft.BackColor = System.Drawing.Color.White
        Me.Lbut_BackgroundPanLeft.Font = New System.Drawing.Font("Wingdings", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Lbut_BackgroundPanLeft.Location = New System.Drawing.Point(10, 6)
        Me.Lbut_BackgroundPanLeft.Name = "Lbut_BackgroundPanLeft"
        Me.Lbut_BackgroundPanLeft.Size = New System.Drawing.Size(11, 9)
        Me.Lbut_BackgroundPanLeft.TabIndex = 7
        Me.Lbut_BackgroundPanLeft.Text = "×"
        Me.Lbut_BackgroundPanLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbut_BackgroundPanRight
        '
        Me.Lbut_BackgroundPanRight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_BackgroundPanRight.AutoSize = True
        Me.Lbut_BackgroundPanRight.BackColor = System.Drawing.Color.White
        Me.Lbut_BackgroundPanRight.Font = New System.Drawing.Font("Wingdings", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Lbut_BackgroundPanRight.Location = New System.Drawing.Point(42, 8)
        Me.Lbut_BackgroundPanRight.Name = "Lbut_BackgroundPanRight"
        Me.Lbut_BackgroundPanRight.Size = New System.Drawing.Size(11, 9)
        Me.Lbut_BackgroundPanRight.TabIndex = 6
        Me.Lbut_BackgroundPanRight.Text = "Ø"
        Me.Lbut_BackgroundPanRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbut_BackgroundPanDown
        '
        Me.Lbut_BackgroundPanDown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_BackgroundPanDown.AutoSize = True
        Me.Lbut_BackgroundPanDown.BackColor = System.Drawing.Color.White
        Me.Lbut_BackgroundPanDown.Font = New System.Drawing.Font("Wingdings", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Lbut_BackgroundPanDown.Location = New System.Drawing.Point(25, 13)
        Me.Lbut_BackgroundPanDown.Name = "Lbut_BackgroundPanDown"
        Me.Lbut_BackgroundPanDown.Size = New System.Drawing.Size(12, 9)
        Me.Lbut_BackgroundPanDown.TabIndex = 9
        Me.Lbut_BackgroundPanDown.Text = "Ú"
        Me.Lbut_BackgroundPanDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbut_BackgroundPanUp
        '
        Me.Lbut_BackgroundPanUp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_BackgroundPanUp.AutoSize = True
        Me.Lbut_BackgroundPanUp.BackColor = System.Drawing.Color.White
        Me.Lbut_BackgroundPanUp.Font = New System.Drawing.Font("Wingdings", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Lbut_BackgroundPanUp.Location = New System.Drawing.Point(25, 2)
        Me.Lbut_BackgroundPanUp.Name = "Lbut_BackgroundPanUp"
        Me.Lbut_BackgroundPanUp.Size = New System.Drawing.Size(12, 9)
        Me.Lbut_BackgroundPanUp.TabIndex = 8
        Me.Lbut_BackgroundPanUp.Text = "Ù"
        Me.Lbut_BackgroundPanUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Lbut_ShrinkCardBig, 2, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Lbut_EnlargeCardBig, 2, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Lbut_EnlargeCardSmall, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Lbut_ShrinkCardSmall, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Pan_SignZoom, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Pan_SignMove, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(95, 91)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'Panel1
        '
        Me.TableLayoutPanel4.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.Lbut_SignPanLeft)
        Me.Panel1.Controls.Add(Me.Lbut_SignPanRight)
        Me.Panel1.Controls.Add(Me.Lbut_SignPanDown)
        Me.Panel1.Controls.Add(Me.Lbut_SignPanUp)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(47, 22)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(47, 33)
        Me.Panel1.TabIndex = 14
        '
        'Lbut_SignPanLeft
        '
        Me.Lbut_SignPanLeft.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_SignPanLeft.AutoSize = True
        Me.Lbut_SignPanLeft.BackColor = System.Drawing.Color.White
        Me.Lbut_SignPanLeft.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Lbut_SignPanLeft.Location = New System.Drawing.Point(-1, 9)
        Me.Lbut_SignPanLeft.Name = "Lbut_SignPanLeft"
        Me.Lbut_SignPanLeft.Size = New System.Drawing.Size(14, 12)
        Me.Lbut_SignPanLeft.TabIndex = 7
        Me.Lbut_SignPanLeft.Text = "×"
        Me.Lbut_SignPanLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbut_SignPanRight
        '
        Me.Lbut_SignPanRight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_SignPanRight.AutoSize = True
        Me.Lbut_SignPanRight.BackColor = System.Drawing.Color.White
        Me.Lbut_SignPanRight.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Lbut_SignPanRight.Location = New System.Drawing.Point(33, 10)
        Me.Lbut_SignPanRight.Name = "Lbut_SignPanRight"
        Me.Lbut_SignPanRight.Size = New System.Drawing.Size(14, 12)
        Me.Lbut_SignPanRight.TabIndex = 6
        Me.Lbut_SignPanRight.Text = "Ø"
        Me.Lbut_SignPanRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbut_SignPanDown
        '
        Me.Lbut_SignPanDown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_SignPanDown.AutoSize = True
        Me.Lbut_SignPanDown.BackColor = System.Drawing.Color.White
        Me.Lbut_SignPanDown.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Lbut_SignPanDown.Location = New System.Drawing.Point(16, 18)
        Me.Lbut_SignPanDown.Name = "Lbut_SignPanDown"
        Me.Lbut_SignPanDown.Size = New System.Drawing.Size(15, 12)
        Me.Lbut_SignPanDown.TabIndex = 9
        Me.Lbut_SignPanDown.Text = "Ú"
        Me.Lbut_SignPanDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbut_SignPanUp
        '
        Me.Lbut_SignPanUp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_SignPanUp.AutoSize = True
        Me.Lbut_SignPanUp.BackColor = System.Drawing.Color.White
        Me.Lbut_SignPanUp.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Lbut_SignPanUp.Location = New System.Drawing.Point(16, 2)
        Me.Lbut_SignPanUp.Name = "Lbut_SignPanUp"
        Me.Lbut_SignPanUp.Size = New System.Drawing.Size(15, 12)
        Me.Lbut_SignPanUp.TabIndex = 8
        Me.Lbut_SignPanUp.Text = "Ù"
        Me.Lbut_SignPanUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightGreen
        Me.TableLayoutPanel4.SetColumnSpan(Me.Label6, 3)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 1)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Sign Control"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbut_ShrinkCardBig
        '
        Me.Lbut_ShrinkCardBig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_ShrinkCardBig.AutoSize = True
        Me.Lbut_ShrinkCardBig.BackColor = System.Drawing.Color.White
        Me.Lbut_ShrinkCardBig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbut_ShrinkCardBig.Location = New System.Drawing.Point(70, 73)
        Me.Lbut_ShrinkCardBig.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbut_ShrinkCardBig.Name = "Lbut_ShrinkCardBig"
        Me.Lbut_ShrinkCardBig.Size = New System.Drawing.Size(24, 17)
        Me.Lbut_ShrinkCardBig.TabIndex = 3
        Me.Lbut_ShrinkCardBig.Tag = "-3"
        Me.Lbut_ShrinkCardBig.Text = "- -"
        Me.Lbut_ShrinkCardBig.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbut_EnlargeCardBig
        '
        Me.Lbut_EnlargeCardBig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_EnlargeCardBig.AutoSize = True
        Me.Lbut_EnlargeCardBig.BackColor = System.Drawing.Color.White
        Me.Lbut_EnlargeCardBig.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbut_EnlargeCardBig.Location = New System.Drawing.Point(70, 56)
        Me.Lbut_EnlargeCardBig.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbut_EnlargeCardBig.Name = "Lbut_EnlargeCardBig"
        Me.Lbut_EnlargeCardBig.Size = New System.Drawing.Size(24, 16)
        Me.Lbut_EnlargeCardBig.TabIndex = 4
        Me.Lbut_EnlargeCardBig.Tag = "3"
        Me.Lbut_EnlargeCardBig.Text = "++"
        Me.Lbut_EnlargeCardBig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbut_EnlargeCardSmall
        '
        Me.Lbut_EnlargeCardSmall.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_EnlargeCardSmall.AutoSize = True
        Me.Lbut_EnlargeCardSmall.BackColor = System.Drawing.Color.White
        Me.Lbut_EnlargeCardSmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbut_EnlargeCardSmall.Location = New System.Drawing.Point(47, 56)
        Me.Lbut_EnlargeCardSmall.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbut_EnlargeCardSmall.Name = "Lbut_EnlargeCardSmall"
        Me.Lbut_EnlargeCardSmall.Size = New System.Drawing.Size(22, 16)
        Me.Lbut_EnlargeCardSmall.TabIndex = 2
        Me.Lbut_EnlargeCardSmall.Tag = "0.5"
        Me.Lbut_EnlargeCardSmall.Text = "+"
        Me.Lbut_EnlargeCardSmall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbut_ShrinkCardSmall
        '
        Me.Lbut_ShrinkCardSmall.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_ShrinkCardSmall.AutoSize = True
        Me.Lbut_ShrinkCardSmall.BackColor = System.Drawing.Color.White
        Me.Lbut_ShrinkCardSmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbut_ShrinkCardSmall.Location = New System.Drawing.Point(47, 73)
        Me.Lbut_ShrinkCardSmall.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbut_ShrinkCardSmall.Name = "Lbut_ShrinkCardSmall"
        Me.Lbut_ShrinkCardSmall.Size = New System.Drawing.Size(22, 17)
        Me.Lbut_ShrinkCardSmall.TabIndex = 5
        Me.Lbut_ShrinkCardSmall.Tag = "-0.5"
        Me.Lbut_ShrinkCardSmall.Text = "-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Lbut_ShrinkCardSmall.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Pan_SignZoom
        '
        Me.Pan_SignZoom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pan_SignZoom.BackColor = System.Drawing.Color.LightBlue
        Me.Pan_SignZoom.Controls.Add(Me.Pan_pict__SignZoom)
        Me.Pan_SignZoom.Controls.Add(Me.Lbut_SignZoom)
        Me.Pan_SignZoom.Location = New System.Drawing.Point(1, 56)
        Me.Pan_SignZoom.Margin = New System.Windows.Forms.Padding(0)
        Me.Pan_SignZoom.Name = "Pan_SignZoom"
        Me.TableLayoutPanel4.SetRowSpan(Me.Pan_SignZoom, 2)
        Me.Pan_SignZoom.Size = New System.Drawing.Size(45, 34)
        Me.Pan_SignZoom.TabIndex = 29
        '
        'Pan_pict__SignZoom
        '
        Me.Pan_pict__SignZoom.BackColor = System.Drawing.Color.White
        Me.Pan_pict__SignZoom.BackgroundImage = Global.jp_dragonbone1.My.Resources.Resources.magnify_glass_icon0
        Me.Pan_pict__SignZoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pan_pict__SignZoom.Location = New System.Drawing.Point(45, 6)
        Me.Pan_pict__SignZoom.Name = "Pan_pict__SignZoom"
        Me.Pan_pict__SignZoom.Size = New System.Drawing.Size(20, 22)
        Me.Pan_pict__SignZoom.TabIndex = 16
        '
        'Lbut_SignZoom
        '
        Me.Lbut_SignZoom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_SignZoom.AutoSize = True
        Me.Lbut_SignZoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbut_SignZoom.Location = New System.Drawing.Point(4, 12)
        Me.Lbut_SignZoom.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbut_SignZoom.Name = "Lbut_SignZoom"
        Me.Lbut_SignZoom.Size = New System.Drawing.Size(34, 13)
        Me.Lbut_SignZoom.TabIndex = 15
        Me.Lbut_SignZoom.Text = "Zoom"
        Me.Lbut_SignZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pan_SignMove
        '
        Me.Pan_SignMove.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pan_SignMove.BackColor = System.Drawing.Color.LightBlue
        Me.Pan_SignMove.Controls.Add(Me.Pan_Pict_SignMove)
        Me.Pan_SignMove.Controls.Add(Me.Lbut_SignMove)
        Me.Pan_SignMove.Location = New System.Drawing.Point(1, 22)
        Me.Pan_SignMove.Margin = New System.Windows.Forms.Padding(0)
        Me.Pan_SignMove.Name = "Pan_SignMove"
        Me.Pan_SignMove.Size = New System.Drawing.Size(45, 29)
        Me.Pan_SignMove.TabIndex = 16
        '
        'Pan_Pict_SignMove
        '
        Me.Pan_Pict_SignMove.BackColor = System.Drawing.Color.White
        Me.Pan_Pict_SignMove.BackgroundImage = Global.jp_dragonbone1.My.Resources.Resources.hand_move_icon1
        Me.Pan_Pict_SignMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pan_Pict_SignMove.Location = New System.Drawing.Point(45, 3)
        Me.Pan_Pict_SignMove.Name = "Pan_Pict_SignMove"
        Me.Pan_Pict_SignMove.Size = New System.Drawing.Size(20, 22)
        Me.Pan_Pict_SignMove.TabIndex = 16
        '
        'Lbut_SignMove
        '
        Me.Lbut_SignMove.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbut_SignMove.AutoSize = True
        Me.Lbut_SignMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbut_SignMove.Location = New System.Drawing.Point(2, 8)
        Me.Lbut_SignMove.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbut_SignMove.Name = "Lbut_SignMove"
        Me.Lbut_SignMove.Size = New System.Drawing.Size(34, 13)
        Me.Lbut_SignMove.TabIndex = 15
        Me.Lbut_SignMove.Text = "Move"
        Me.Lbut_SignMove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OFD_UploadPicture
        '
        Me.OFD_UploadPicture.Filter = "Pictures|*.jpg; *.bmp; *.jpeg;|All Files| *.*"
        '
        'Pan_imageholder
        '
        Me.Pan_imageholder.BackColor = System.Drawing.Color.Navy
        Me.Pan_imageholder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pan_imageholder.Controls.Add(Me.Pan_cards)
        Me.Pan_imageholder.Location = New System.Drawing.Point(59, 12)
        Me.Pan_imageholder.Name = "Pan_imageholder"
        Me.Pan_imageholder.Size = New System.Drawing.Size(300, 222)
        Me.Pan_imageholder.TabIndex = 28
        '
        'Pan_cards
        '
        Me.Pan_cards.BackColor = System.Drawing.Color.Transparent
        Me.Pan_cards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pan_cards.Controls.Add(Me.LiteCard19)
        Me.Pan_cards.Controls.Add(Me.LiteCard18)
        Me.Pan_cards.Controls.Add(Me.LiteCard17)
        Me.Pan_cards.Controls.Add(Me.LiteCard16)
        Me.Pan_cards.Controls.Add(Me.LiteCard0)
        Me.Pan_cards.Controls.Add(Me.LiteCard10)
        Me.Pan_cards.Controls.Add(Me.LiteCard11)
        Me.Pan_cards.Controls.Add(Me.LiteCard12)
        Me.Pan_cards.Controls.Add(Me.LiteCard13)
        Me.Pan_cards.Controls.Add(Me.LiteCard14)
        Me.Pan_cards.Controls.Add(Me.LiteCard15)
        Me.Pan_cards.Controls.Add(Me.But_shape_straight)
        Me.Pan_cards.Controls.Add(Me.But_shape_arch)
        Me.Pan_cards.Controls.Add(Me.LiteCard1)
        Me.Pan_cards.Controls.Add(Me.But_shape_revarch)
        Me.Pan_cards.Controls.Add(Me.LiteCard2)
        Me.Pan_cards.Controls.Add(Me.LiteCard3)
        Me.Pan_cards.Controls.Add(Me.LiteCard9)
        Me.Pan_cards.Controls.Add(Me.LiteCard4)
        Me.Pan_cards.Controls.Add(Me.LiteCard8)
        Me.Pan_cards.Controls.Add(Me.LiteCard5)
        Me.Pan_cards.Controls.Add(Me.LiteCard7)
        Me.Pan_cards.Controls.Add(Me.LiteCard6)
        Me.Pan_cards.Location = New System.Drawing.Point(16, 13)
        Me.Pan_cards.Name = "Pan_cards"
        Me.Pan_cards.Size = New System.Drawing.Size(263, 184)
        Me.Pan_cards.TabIndex = 28
        '
        'LiteCard19
        '
        Me.LiteCard19.Angle = 0.0R
        Me.LiteCard19.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard19.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard19.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard19.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard19.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard19.FontSize = 50.0!
        Me.LiteCard19.Left = 128.0!
        Me.LiteCard19.location = CType(resources.GetObject("LiteCard19.location"), System.Drawing.PointF)
        Me.LiteCard19.location = New System.Drawing.Point(128, 0)
        Me.LiteCard19.Name = "LiteCard19"
        Me.LiteCard19.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard19.TabIndex = 37
        Me.LiteCard19.Tag = "19"
        Me.LiteCard19.Top = 0.0!
        Me.LiteCard19.Visible = False
        '
        'LiteCard18
        '
        Me.LiteCard18.Angle = 0.0R
        Me.LiteCard18.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard18.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard18.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard18.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard18.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard18.FontSize = 50.0!
        Me.LiteCard18.Left = 120.0!
        Me.LiteCard18.location = CType(resources.GetObject("LiteCard18.location"), System.Drawing.PointF)
        Me.LiteCard18.location = New System.Drawing.Point(120, 0)
        Me.LiteCard18.Name = "LiteCard18"
        Me.LiteCard18.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard18.TabIndex = 36
        Me.LiteCard18.Tag = "18"
        Me.LiteCard18.Top = 0.0!
        Me.LiteCard18.Visible = False
        '
        'LiteCard17
        '
        Me.LiteCard17.Angle = 0.0R
        Me.LiteCard17.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard17.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard17.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard17.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard17.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard17.FontSize = 50.0!
        Me.LiteCard17.Left = 112.0!
        Me.LiteCard17.location = CType(resources.GetObject("LiteCard17.location"), System.Drawing.PointF)
        Me.LiteCard17.location = New System.Drawing.Point(112, 0)
        Me.LiteCard17.Name = "LiteCard17"
        Me.LiteCard17.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard17.TabIndex = 35
        Me.LiteCard17.Tag = "17"
        Me.LiteCard17.Top = 0.0!
        Me.LiteCard17.Visible = False
        '
        'LiteCard16
        '
        Me.LiteCard16.Angle = 0.0R
        Me.LiteCard16.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard16.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard16.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard16.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard16.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard16.FontSize = 50.0!
        Me.LiteCard16.Left = 175.0!
        Me.LiteCard16.location = CType(resources.GetObject("LiteCard16.location"), System.Drawing.PointF)
        Me.LiteCard16.location = New System.Drawing.Point(175, 0)
        Me.LiteCard16.Name = "LiteCard16"
        Me.LiteCard16.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard16.TabIndex = 33
        Me.LiteCard16.Tag = "16"
        Me.LiteCard16.Top = 0.0!
        Me.LiteCard16.Visible = False
        '
        'LiteCard0
        '
        Me.LiteCard0.Angle = 0.0R
        Me.LiteCard0.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard0.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard0.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard0.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard0.Cursor = System.Windows.Forms.Cursors.Default
        Me.LiteCard0.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard0.FontSize = 50.0!
        Me.LiteCard0.Left = 49.0!
        Me.LiteCard0.location = CType(resources.GetObject("LiteCard0.location"), System.Drawing.PointF)
        Me.LiteCard0.location = New System.Drawing.Point(49, 0)
        Me.LiteCard0.Name = "LiteCard0"
        Me.LiteCard0.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard0.TabIndex = 28
        Me.LiteCard0.Tag = "0"
        Me.LiteCard0.Top = 0.0!
        Me.LiteCard0.Visible = False
        '
        'LiteCard10
        '
        Me.LiteCard10.Angle = 0.0R
        Me.LiteCard10.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard10.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard10.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard10.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard10.Cursor = System.Windows.Forms.Cursors.Default
        Me.LiteCard10.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard10.FontSize = 50.0!
        Me.LiteCard10.Left = 55.0!
        Me.LiteCard10.location = CType(resources.GetObject("LiteCard10.location"), System.Drawing.PointF)
        Me.LiteCard10.location = New System.Drawing.Point(55, 0)
        Me.LiteCard10.Name = "LiteCard10"
        Me.LiteCard10.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard10.TabIndex = 34
        Me.LiteCard10.Tag = "10"
        Me.LiteCard10.Top = 0.0!
        Me.LiteCard10.Visible = False
        '
        'LiteCard11
        '
        Me.LiteCard11.Angle = 0.0R
        Me.LiteCard11.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard11.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard11.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard11.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard11.Cursor = System.Windows.Forms.Cursors.Default
        Me.LiteCard11.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard11.FontSize = 50.0!
        Me.LiteCard11.Left = 112.0!
        Me.LiteCard11.location = CType(resources.GetObject("LiteCard11.location"), System.Drawing.PointF)
        Me.LiteCard11.location = New System.Drawing.Point(112, 0)
        Me.LiteCard11.Name = "LiteCard11"
        Me.LiteCard11.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard11.TabIndex = 29
        Me.LiteCard11.Tag = "11"
        Me.LiteCard11.Top = 0.0!
        Me.LiteCard11.Visible = False
        '
        'LiteCard12
        '
        Me.LiteCard12.Angle = 0.0R
        Me.LiteCard12.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard12.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard12.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard12.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard12.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard12.FontSize = 50.0!
        Me.LiteCard12.Left = 55.0!
        Me.LiteCard12.location = CType(resources.GetObject("LiteCard12.location"), System.Drawing.PointF)
        Me.LiteCard12.location = New System.Drawing.Point(55, 0)
        Me.LiteCard12.Name = "LiteCard12"
        Me.LiteCard12.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard12.TabIndex = 30
        Me.LiteCard12.Tag = "12"
        Me.LiteCard12.Top = 0.0!
        Me.LiteCard12.Visible = False
        '
        'LiteCard13
        '
        Me.LiteCard13.Angle = 0.0R
        Me.LiteCard13.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard13.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard13.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard13.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard13.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard13.FontSize = 50.0!
        Me.LiteCard13.Left = 7.0!
        Me.LiteCard13.location = CType(resources.GetObject("LiteCard13.location"), System.Drawing.PointF)
        Me.LiteCard13.location = New System.Drawing.Point(7, 0)
        Me.LiteCard13.Name = "LiteCard13"
        Me.LiteCard13.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard13.TabIndex = 31
        Me.LiteCard13.Tag = "13"
        Me.LiteCard13.Top = 0.0!
        Me.LiteCard13.Visible = False
        '
        'LiteCard14
        '
        Me.LiteCard14.Angle = 0.0R
        Me.LiteCard14.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard14.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard14.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard14.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard14.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard14.FontSize = 50.0!
        Me.LiteCard14.Left = 167.0!
        Me.LiteCard14.location = CType(resources.GetObject("LiteCard14.location"), System.Drawing.PointF)
        Me.LiteCard14.location = New System.Drawing.Point(167, 0)
        Me.LiteCard14.Name = "LiteCard14"
        Me.LiteCard14.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard14.TabIndex = 33
        Me.LiteCard14.Tag = "14"
        Me.LiteCard14.Top = 0.0!
        Me.LiteCard14.Visible = False
        '
        'LiteCard15
        '
        Me.LiteCard15.Angle = 0.0R
        Me.LiteCard15.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard15.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard15.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard15.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard15.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard15.FontSize = 50.0!
        Me.LiteCard15.Left = 218.0!
        Me.LiteCard15.location = CType(resources.GetObject("LiteCard15.location"), System.Drawing.PointF)
        Me.LiteCard15.location = New System.Drawing.Point(218, 0)
        Me.LiteCard15.Name = "LiteCard15"
        Me.LiteCard15.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard15.TabIndex = 32
        Me.LiteCard15.Tag = "15"
        Me.LiteCard15.Top = 0.0!
        Me.LiteCard15.Visible = False
        '
        'But_shape_straight
        '
        Me.But_shape_straight.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_shape_straight.Location = New System.Drawing.Point(122, 3)
        Me.But_shape_straight.Name = "But_shape_straight"
        Me.But_shape_straight.Size = New System.Drawing.Size(36, 23)
        Me.But_shape_straight.TabIndex = 25
        Me.But_shape_straight.Text = "LINE"
        Me.But_shape_straight.UseVisualStyleBackColor = True
        Me.But_shape_straight.Visible = False
        '
        'But_shape_arch
        '
        Me.But_shape_arch.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_shape_arch.Location = New System.Drawing.Point(158, 3)
        Me.But_shape_arch.Name = "But_shape_arch"
        Me.But_shape_arch.Size = New System.Drawing.Size(41, 23)
        Me.But_shape_arch.TabIndex = 26
        Me.But_shape_arch.Text = "ARCH"
        Me.But_shape_arch.UseVisualStyleBackColor = True
        Me.But_shape_arch.Visible = False
        '
        'LiteCard1
        '
        Me.LiteCard1.Angle = 0.0R
        Me.LiteCard1.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard1.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard1.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard1.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard1.Cursor = System.Windows.Forms.Cursors.Default
        Me.LiteCard1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard1.FontSize = 50.0!
        Me.LiteCard1.Left = 120.0!
        Me.LiteCard1.location = CType(resources.GetObject("LiteCard1.location"), System.Drawing.PointF)
        Me.LiteCard1.location = New System.Drawing.Point(120, 0)
        Me.LiteCard1.Name = "LiteCard1"
        Me.LiteCard1.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard1.TabIndex = 16
        Me.LiteCard1.Tag = "1"
        Me.LiteCard1.Top = 0.0!
        Me.LiteCard1.Visible = False
        '
        'But_shape_revarch
        '
        Me.But_shape_revarch.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_shape_revarch.Location = New System.Drawing.Point(199, 3)
        Me.But_shape_revarch.Name = "But_shape_revarch"
        Me.But_shape_revarch.Size = New System.Drawing.Size(43, 23)
        Me.But_shape_revarch.TabIndex = 27
        Me.But_shape_revarch.Text = "U"
        Me.But_shape_revarch.UseVisualStyleBackColor = True
        Me.But_shape_revarch.Visible = False
        '
        'LiteCard2
        '
        Me.LiteCard2.Angle = 0.0R
        Me.LiteCard2.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard2.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard2.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard2.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard2.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard2.FontSize = 50.0!
        Me.LiteCard2.Left = 63.0!
        Me.LiteCard2.location = CType(resources.GetObject("LiteCard2.location"), System.Drawing.PointF)
        Me.LiteCard2.location = New System.Drawing.Point(63, 0)
        Me.LiteCard2.Name = "LiteCard2"
        Me.LiteCard2.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard2.TabIndex = 17
        Me.LiteCard2.Tag = "2"
        Me.LiteCard2.Top = 0.0!
        Me.LiteCard2.Visible = False
        '
        'LiteCard3
        '
        Me.LiteCard3.Angle = 0.0R
        Me.LiteCard3.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard3.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard3.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard3.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard3.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard3.FontSize = 50.0!
        Me.LiteCard3.Left = 15.0!
        Me.LiteCard3.location = CType(resources.GetObject("LiteCard3.location"), System.Drawing.PointF)
        Me.LiteCard3.location = New System.Drawing.Point(15, 0)
        Me.LiteCard3.Name = "LiteCard3"
        Me.LiteCard3.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard3.TabIndex = 18
        Me.LiteCard3.Tag = "3"
        Me.LiteCard3.Top = 0.0!
        Me.LiteCard3.Visible = False
        '
        'LiteCard9
        '
        Me.LiteCard9.Angle = 0.0R
        Me.LiteCard9.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard9.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard9.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard9.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard9.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard9.FontSize = 50.0!
        Me.LiteCard9.Left = 175.0!
        Me.LiteCard9.location = CType(resources.GetObject("LiteCard9.location"), System.Drawing.PointF)
        Me.LiteCard9.location = New System.Drawing.Point(175, 0)
        Me.LiteCard9.Name = "LiteCard9"
        Me.LiteCard9.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard9.TabIndex = 24
        Me.LiteCard9.Tag = "9"
        Me.LiteCard9.Top = 0.0!
        Me.LiteCard9.Visible = False
        '
        'LiteCard4
        '
        Me.LiteCard4.Angle = 0.0R
        Me.LiteCard4.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard4.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard4.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard4.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard4.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard4.FontSize = 50.0!
        Me.LiteCard4.Left = 226.0!
        Me.LiteCard4.location = CType(resources.GetObject("LiteCard4.location"), System.Drawing.PointF)
        Me.LiteCard4.location = New System.Drawing.Point(226, 0)
        Me.LiteCard4.Name = "LiteCard4"
        Me.LiteCard4.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard4.TabIndex = 19
        Me.LiteCard4.Tag = "4"
        Me.LiteCard4.Top = 0.0!
        Me.LiteCard4.Visible = False
        '
        'LiteCard8
        '
        Me.LiteCard8.Angle = 0.0R
        Me.LiteCard8.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard8.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard8.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard8.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard8.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard8.FontSize = 50.0!
        Me.LiteCard8.Left = 0.0!
        Me.LiteCard8.location = CType(resources.GetObject("LiteCard8.location"), System.Drawing.PointF)
        Me.LiteCard8.location = New System.Drawing.Point(0, 0)
        Me.LiteCard8.Name = "LiteCard8"
        Me.LiteCard8.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard8.TabIndex = 23
        Me.LiteCard8.Tag = "8"
        Me.LiteCard8.Top = 0.0!
        Me.LiteCard8.Visible = False
        '
        'LiteCard5
        '
        Me.LiteCard5.Angle = 0.0R
        Me.LiteCard5.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard5.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard5.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard5.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard5.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard5.FontSize = 50.0!
        Me.LiteCard5.Left = 0.0!
        Me.LiteCard5.location = CType(resources.GetObject("LiteCard5.location"), System.Drawing.PointF)
        Me.LiteCard5.location = New System.Drawing.Point(0, 0)
        Me.LiteCard5.Name = "LiteCard5"
        Me.LiteCard5.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard5.TabIndex = 20
        Me.LiteCard5.Tag = "5"
        Me.LiteCard5.Top = 0.0!
        Me.LiteCard5.Visible = False
        '
        'LiteCard7
        '
        Me.LiteCard7.Angle = 0.0R
        Me.LiteCard7.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard7.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard7.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard7.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard7.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard7.FontSize = 50.0!
        Me.LiteCard7.Left = 0.0!
        Me.LiteCard7.location = CType(resources.GetObject("LiteCard7.location"), System.Drawing.PointF)
        Me.LiteCard7.location = New System.Drawing.Point(0, 0)
        Me.LiteCard7.Name = "LiteCard7"
        Me.LiteCard7.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard7.TabIndex = 22
        Me.LiteCard7.Tag = "7"
        Me.LiteCard7.Top = 0.0!
        Me.LiteCard7.Visible = False
        '
        'LiteCard6
        '
        Me.LiteCard6.Angle = 0.0R
        Me.LiteCard6.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard6.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard6.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard6.ContextMenuStrip = Me.ContextMen_litecards
        Me.LiteCard6.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard6.FontSize = 50.0!
        Me.LiteCard6.Left = 0.0!
        Me.LiteCard6.location = CType(resources.GetObject("LiteCard6.location"), System.Drawing.PointF)
        Me.LiteCard6.location = New System.Drawing.Point(0, 0)
        Me.LiteCard6.Name = "LiteCard6"
        Me.LiteCard6.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard6.TabIndex = 21
        Me.LiteCard6.Tag = "6"
        Me.LiteCard6.Top = 0.0!
        Me.LiteCard6.Visible = False
        '
        'Lbl_debug
        '
        Me.Lbl_debug.AutoSize = True
        Me.Lbl_debug.Location = New System.Drawing.Point(393, 12)
        Me.Lbl_debug.Name = "Lbl_debug"
        Me.Lbl_debug.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_debug.TabIndex = 30
        Me.Lbl_debug.Text = "debug label"
        Me.Lbl_debug.Visible = False
        '
        'Pan_dislpayregion
        '
        Me.Pan_dislpayregion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Pan_dislpayregion.Controls.Add(Me.StatusStrip)
        Me.Pan_dislpayregion.Controls.Add(Me.Pan_imageholder)
        Me.Pan_dislpayregion.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pan_dislpayregion.Location = New System.Drawing.Point(0, 0)
        Me.Pan_dislpayregion.Name = "Pan_dislpayregion"
        Me.Pan_dislpayregion.Size = New System.Drawing.Size(530, 431)
        Me.Pan_dislpayregion.TabIndex = 31
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 409)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(530, 22)
        Me.StatusStrip.TabIndex = 29
        Me.StatusStrip.Text = "lllllllllllll"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(121, 17)
        Me.StatusLabel.Text = "ToolStripStatusLabel1"
        '
        'ContextMen_sign_zoom
        '
        Me.ContextMen_sign_zoom.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMI_sign_zoominsmall, Me.CMI_sign_zoominlarge, Me.CMI_sign_zoomoutsmall, Me.CMI_sign_zoomoutlarge, Me.CMI_movesign, Me.CMI_movecards, Me.CMI_lock})
        Me.ContextMen_sign_zoom.Name = "ContextMen_sign_zoom"
        Me.ContextMen_sign_zoom.Size = New System.Drawing.Size(191, 158)
        '
        'CMI_sign_zoominsmall
        '
        Me.CMI_sign_zoominsmall.Name = "CMI_sign_zoominsmall"
        Me.CMI_sign_zoominsmall.Size = New System.Drawing.Size(190, 22)
        Me.CMI_sign_zoominsmall.Text = "Zoom  In +"
        '
        'CMI_sign_zoominlarge
        '
        Me.CMI_sign_zoominlarge.Name = "CMI_sign_zoominlarge"
        Me.CMI_sign_zoominlarge.Size = New System.Drawing.Size(190, 22)
        Me.CMI_sign_zoominlarge.Text = "Zoom ++"
        '
        'CMI_sign_zoomoutsmall
        '
        Me.CMI_sign_zoomoutsmall.Name = "CMI_sign_zoomoutsmall"
        Me.CMI_sign_zoomoutsmall.Size = New System.Drawing.Size(190, 22)
        Me.CMI_sign_zoomoutsmall.Text = "Zoom Out -"
        '
        'CMI_sign_zoomoutlarge
        '
        Me.CMI_sign_zoomoutlarge.Name = "CMI_sign_zoomoutlarge"
        Me.CMI_sign_zoomoutlarge.Size = New System.Drawing.Size(190, 22)
        Me.CMI_sign_zoomoutlarge.Text = "Zoom Out --"
        '
        'CMI_movesign
        '
        Me.CMI_movesign.Name = "CMI_movesign"
        Me.CMI_movesign.Size = New System.Drawing.Size(190, 22)
        Me.CMI_movesign.Text = "Move Entire Sign"
        '
        'CMI_movecards
        '
        Me.CMI_movecards.Name = "CMI_movecards"
        Me.CMI_movecards.Size = New System.Drawing.Size(190, 22)
        Me.CMI_movecards.Text = "Move individual cards"
        '
        'CMI_lock
        '
        Me.CMI_lock.Name = "CMI_lock"
        Me.CMI_lock.Size = New System.Drawing.Size(190, 22)
        Me.CMI_lock.Text = "Lock Sign"
        '
        'Timer_formloaded
        '
        Me.Timer_formloaded.Interval = 25
        '
        'ContextMen_Default
        '
        Me.ContextMen_Default.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMI_ZOOM, Me.CMI_move_sign, Me.CMI_move_cards})
        Me.ContextMen_Default.Name = "ContextMen_Default"
        Me.ContextMen_Default.Size = New System.Drawing.Size(193, 70)
        '
        'CMI_ZOOM
        '
        Me.CMI_ZOOM.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMI_zoominBig, Me.CMI_zoominSmall, Me.CMI_zoomoutBig, Me.CMI_zoomoutSmall})
        Me.CMI_ZOOM.Name = "CMI_ZOOM"
        Me.CMI_ZOOM.Size = New System.Drawing.Size(192, 22)
        Me.CMI_ZOOM.Text = "Zoom"
        '
        'CMI_zoominBig
        '
        Me.CMI_zoominBig.Name = "CMI_zoominBig"
        Me.CMI_zoominBig.Size = New System.Drawing.Size(107, 22)
        Me.CMI_zoominBig.Text = "In ++"
        '
        'CMI_zoominSmall
        '
        Me.CMI_zoominSmall.Name = "CMI_zoominSmall"
        Me.CMI_zoominSmall.Size = New System.Drawing.Size(107, 22)
        Me.CMI_zoominSmall.Text = "In +"
        '
        'CMI_zoomoutBig
        '
        Me.CMI_zoomoutBig.Name = "CMI_zoomoutBig"
        Me.CMI_zoomoutBig.Size = New System.Drawing.Size(107, 22)
        Me.CMI_zoomoutBig.Text = "Out --"
        '
        'CMI_zoomoutSmall
        '
        Me.CMI_zoomoutSmall.Name = "CMI_zoomoutSmall"
        Me.CMI_zoomoutSmall.Size = New System.Drawing.Size(107, 22)
        Me.CMI_zoomoutSmall.Text = "Out -"
        '
        'CMI_move_sign
        '
        Me.CMI_move_sign.Name = "CMI_move_sign"
        Me.CMI_move_sign.Size = New System.Drawing.Size(192, 22)
        Me.CMI_move_sign.Text = "Move Entire Sign"
        '
        'CMI_move_cards
        '
        Me.CMI_move_cards.Name = "CMI_move_cards"
        Me.CMI_move_cards.Size = New System.Drawing.Size(192, 22)
        Me.CMI_move_cards.Text = "Move Individual Cards"
        '
        'Timer_statusstrip
        '
        Me.Timer_statusstrip.Enabled = True
        Me.Timer_statusstrip.Interval = 2000
        '
        'Timer_delayed_show_cards
        '
        Me.Timer_delayed_show_cards.Interval = 1000
        '
        'simulator_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(530, 537)
        Me.Controls.Add(Me.Pan_dislpayregion)
        Me.Controls.Add(Me.Lbl_debug)
        Me.Controls.Add(Me.Pan_buttons)
        Me.Controls.Add(Me.But_close)
        Me.Controls.Add(Me.TB_signtext)
        Me.KeyPreview = True
        Me.Name = "simulator_form"
        Me.Text = "Sign Simulator"
        Me.ContextMen_litecards.ResumeLayout(False)
        Me.Pan_buttons.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PB_diagdown_line, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_diagup_line, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_s_curve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_arc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_rev_arc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_vert_line, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_horr_line, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_m_curve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Pan_BackgroundZoom.ResumeLayout(False)
        Me.Pan_BackgroundZoom.PerformLayout()
        Me.Pan_BackgroundMove.ResumeLayout(False)
        Me.Pan_BackgroundMove.PerformLayout()
        Me.Pan_pancontrols.ResumeLayout(False)
        Me.Pan_pancontrols.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Pan_SignZoom.ResumeLayout(False)
        Me.Pan_SignZoom.PerformLayout()
        Me.Pan_SignMove.ResumeLayout(False)
        Me.Pan_SignMove.PerformLayout()
        Me.Pan_imageholder.ResumeLayout(False)
        Me.Pan_cards.ResumeLayout(False)
        Me.Pan_dislpayregion.ResumeLayout(False)
        Me.Pan_dislpayregion.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ContextMen_sign_zoom.ResumeLayout(False)
        Me.ContextMen_Default.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_signtext As System.Windows.Forms.TextBox
    Friend WithEvents But_close As System.Windows.Forms.Button
    Friend WithEvents LiteCard9 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard8 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard7 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard6 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard5 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard4 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard3 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard2 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard1 As jp_dragonbone1.LiteCard
    Friend WithEvents But_shape_revarch As System.Windows.Forms.Button
    Friend WithEvents But_shape_arch As System.Windows.Forms.Button
    Friend WithEvents But_shape_straight As System.Windows.Forms.Button
    Friend WithEvents Pan_cards As System.Windows.Forms.Panel
    Friend WithEvents ContextMen_litecards As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Pan_buttons As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LbL_custom As System.Windows.Forms.Label
    Friend WithEvents Lbl_standard As System.Windows.Forms.Label
    Friend WithEvents Lbut_custom_export As System.Windows.Forms.Label
    Friend WithEvents Lbut_custon_import As System.Windows.Forms.Label
    Friend WithEvents Lbut_custon_start As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Lbut_ShrinkCardBig As System.Windows.Forms.Label
    Friend WithEvents Lbut_EnlargeCardSmall As System.Windows.Forms.Label
    Friend WithEvents Lbut_BackgroundPanRight As System.Windows.Forms.Label
    Friend WithEvents Lbut_BackgroundZoomOutSmall As System.Windows.Forms.Label
    Friend WithEvents Lbut_BackgroundPanLeft As System.Windows.Forms.Label
    Friend WithEvents Lbut_BackgroundPanUp As System.Windows.Forms.Label
    Friend WithEvents Lbut_BackgroundPanDown As System.Windows.Forms.Label
    Friend WithEvents Lbut_BackgroundZoomInSmall As System.Windows.Forms.Label
    Friend WithEvents PB_diagup_line As System.Windows.Forms.PictureBox
    Friend WithEvents PB_s_curve As System.Windows.Forms.PictureBox
    Friend WithEvents PB_arc As System.Windows.Forms.PictureBox
    Friend WithEvents PB_rev_arc As System.Windows.Forms.PictureBox
    Friend WithEvents PB_vert_line As System.Windows.Forms.PictureBox
    Friend WithEvents PB_horr_line As System.Windows.Forms.PictureBox
    Friend WithEvents PB_m_curve As System.Windows.Forms.PictureBox
    Friend WithEvents PB_diagdown_line As System.Windows.Forms.PictureBox
    Friend WithEvents Lbut_ShrinkCardSmall As System.Windows.Forms.Label
    Friend WithEvents Lbut_EnlargeCardBig As System.Windows.Forms.Label
    Friend WithEvents Lbut_BackgroundZoomInLarge As System.Windows.Forms.Label
    Friend WithEvents Lbut_BackgroundZoomOutLarge As System.Windows.Forms.Label
    Friend WithEvents Pan_pancontrols As System.Windows.Forms.Panel
    Friend WithEvents OFD_UploadPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Pan_imageholder As System.Windows.Forms.Panel
    Friend WithEvents Lbl_debug As System.Windows.Forms.Label
    Friend WithEvents Pan_dislpayregion As System.Windows.Forms.Panel
    Public WithEvents Timer_delayed_invalidate As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbut_SignPanLeft As System.Windows.Forms.Label
    Friend WithEvents Lbut_SignPanRight As System.Windows.Forms.Label
    Friend WithEvents Lbut_SignPanDown As System.Windows.Forms.Label
    Friend WithEvents Lbut_SignPanUp As System.Windows.Forms.Label
    Friend WithEvents Lbut_SignMove As System.Windows.Forms.Label
    Friend WithEvents Pan_SignMove As System.Windows.Forms.Panel
    Friend WithEvents Pan_Pict_SignMove As System.Windows.Forms.Panel
    Friend WithEvents Pan_SignZoom As System.Windows.Forms.Panel
    Friend WithEvents Pan_pict__SignZoom As System.Windows.Forms.Panel
    Friend WithEvents Lbut_SignZoom As System.Windows.Forms.Label
    Friend WithEvents Pan_BackgroundMove As System.Windows.Forms.Panel
    Friend WithEvents Pan_pict_BackgroundMove As System.Windows.Forms.Panel
    Friend WithEvents Lbut_BackgroundMove As System.Windows.Forms.Label
    Friend WithEvents Pan_BackgroundZoom As System.Windows.Forms.Panel
    Friend WithEvents Pan_pict_BackgroundZoom As System.Windows.Forms.Panel
    Friend WithEvents Lbut_BackgroundZoom As System.Windows.Forms.Label
    Friend WithEvents ContextMen_sign_zoom As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CMI_sign_zoominsmall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_sign_zoominlarge As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_sign_zoomoutsmall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_sign_zoomoutlarge As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer_formloaded As System.Windows.Forms.Timer
    Friend WithEvents CMI_lock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMen_Default As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CMI_movesign As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_movecards As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_ZOOM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_zoominBig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_zoominSmall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_zoomoutBig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_zoomoutSmall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_move_sign As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_move_cards As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_Z00M As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_z00minbig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_z00minsmall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_z00moutbig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_z00moutsmall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_m0vesign As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_l0ck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_m0vecards As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Timer_statusstrip As System.Windows.Forms.Timer
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LiteCard0 As jp_dragonbone1.LiteCard
    Friend WithEvents Lbut_BG_Default As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents SFD_export As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OFD_import As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmi_rotate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmi_bigclockwise As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmi_smallclockwise As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmi_bigcounterclockwise As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmi_smallcounterclockwise As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_color As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_card As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_fore_red As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_Fore_green As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_fore_blue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_templates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_fore_white As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_colorpattern2 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern0 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern1 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern3 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern5 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern6 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern7 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern4 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern8 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CMI_colorpattern9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_library As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_openlibrary As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMI_mypattern10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer_delayed_show_cards As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LiteCard10 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard11 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard12 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard13 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard14 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard15 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard16 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard19 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard18 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard17 As jp_dragonbone1.LiteCard
    Public WithEvents Tim_trick1 As System.Windows.Forms.Timer
End Class
