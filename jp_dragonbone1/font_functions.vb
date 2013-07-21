Public Class font_functions
    ''this is a non displaying form that is used for font functions

    Public Sub changesize(ByRef obj As Object, ByVal newsize As Single)
        Dim fontfam As FontFamily = obj.Font.FontFamily
        obj.font = New Font(fontfam, newsize)
    End Sub

    Public Sub changesize(ByRef fnt As Font, ByVal newsize As Single)
        Dim fontfam As FontFamily = fnt.FontFamily
        fnt = New Font(fontfam, newsize)
    End Sub

    Public Sub changestyle(ByRef fnt As Font, ByVal style As FontStyle)

        fnt = New Font(fnt.FontFamily, fnt.Size, style)
    End Sub
    Public Sub changestyle(ByRef obj As Object, ByVal style As FontStyle)
        'changes the font of the object passed
        'if the object does not have a font property an exception is thrown
        Dim fam As FontFamily = obj.font.FontFamily
        obj.font = New Font(fam, obj.font.Size, style)


        'If obj.GetType.Name = "Font" Then

        'Else
        '    changestyle(obj.font, style)
        'End If


    End Sub

    Public Sub makebold(ByRef fnt As Font)
        changestyle(fnt, FontStyle.Bold)
    End Sub
    Public Sub makebold(ByRef obj As Object)
        changestyle(obj, FontStyle.Bold)
    End Sub

    Private Sub font_functions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class