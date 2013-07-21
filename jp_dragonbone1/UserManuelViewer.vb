Public Class UserManuelViewer

    Private Sub UserManuelViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PDFviewer_usermanuel_big.LoadFile(Form1.USERMANUELFILE)
    End Sub
End Class