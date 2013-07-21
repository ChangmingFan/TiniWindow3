<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManuelViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserManuelViewer))
        Me.PDFviewer_usermanuel_big = New AxAcroPDFLib.AxAcroPDF
        CType(Me.PDFviewer_usermanuel_big, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PDFviewer_usermanuel_big
        '
        Me.PDFviewer_usermanuel_big.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PDFviewer_usermanuel_big.Enabled = True
        Me.PDFviewer_usermanuel_big.Location = New System.Drawing.Point(0, 0)
        Me.PDFviewer_usermanuel_big.Name = "PDFviewer_usermanuel_big"
        Me.PDFviewer_usermanuel_big.OcxState = CType(resources.GetObject("PDFviewer_usermanuel_big.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PDFviewer_usermanuel_big.Size = New System.Drawing.Size(748, 521)
        Me.PDFviewer_usermanuel_big.TabIndex = 0
        '
        'UserManuelViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 521)
        Me.Controls.Add(Me.PDFviewer_usermanuel_big)
        Me.Name = "UserManuelViewer"
        Me.Text = "UserManuelViewer"
        CType(Me.PDFviewer_usermanuel_big, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PDFviewer_usermanuel_big As AxAcroPDFLib.AxAcroPDF
End Class
