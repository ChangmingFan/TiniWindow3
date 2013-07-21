<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(testform))
        Me.Button1 = New System.Windows.Forms.Button
        Me.LiteCard3 = New jp_dragonbone1.LiteCard
        Me.LiteCard2 = New jp_dragonbone1.LiteCard
        Me.LiteCard1 = New jp_dragonbone1.LiteCard
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(190, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LiteCard3
        '
        Me.LiteCard3.Angle = 0
        Me.LiteCard3.Backcolor = System.Drawing.Color.Green
        Me.LiteCard3.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard3.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard3.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard3.FontSize = 50.0!
        Me.LiteCard3.Left = 0.0!
        Me.LiteCard3.location = CType(resources.GetObject("LiteCard3.location"), System.Drawing.PointF)
        Me.LiteCard3.location = New System.Drawing.Point(176, 0)
        Me.LiteCard3.Name = "LiteCard3"
        Me.LiteCard3.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard3.TabIndex = 2
        Me.LiteCard3.Top = 0.0!
        '
        'LiteCard2
        '
        Me.LiteCard2.Angle = 0
        Me.LiteCard2.Backcolor = System.Drawing.Color.Green
        Me.LiteCard2.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard2.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard2.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard2.FontSize = 50.0!
        Me.LiteCard2.Left = 0.0!
        Me.LiteCard2.location = CType(resources.GetObject("LiteCard2.location"), System.Drawing.PointF)
        Me.LiteCard2.location = New System.Drawing.Point(123, 0)
        Me.LiteCard2.Name = "LiteCard2"
        Me.LiteCard2.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard2.TabIndex = 1
        Me.LiteCard2.Top = 0.0!
        '
        'LiteCard1
        '
        Me.LiteCard1.Angle = 0
        Me.LiteCard1.Backcolor = System.Drawing.Color.Green
        Me.LiteCard1.Backcolor = System.Drawing.Color.Transparent
        Me.LiteCard1.character = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LiteCard1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.LiteCard1.FontSize = 50.0!
        Me.LiteCard1.Left = 0.0!
        Me.LiteCard1.location = CType(resources.GetObject("LiteCard1.location"), System.Drawing.PointF)
        Me.LiteCard1.location = New System.Drawing.Point(22, 0)
        Me.LiteCard1.Name = "LiteCard1"
        Me.LiteCard1.Size = New System.Drawing.Size(38, 58)
        Me.LiteCard1.TabIndex = 0
        Me.LiteCard1.Top = 0.0!
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(22, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'testform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LiteCard3)
        Me.Controls.Add(Me.LiteCard2)
        Me.Controls.Add(Me.LiteCard1)
        Me.Name = "testform"
        Me.Text = "testform"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LiteCard1 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard2 As jp_dragonbone1.LiteCard
    Friend WithEvents LiteCard3 As jp_dragonbone1.LiteCard
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
