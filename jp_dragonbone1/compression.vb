Imports ICSharpCode.SharpZipLib

Public Class compression

    Shared Function StringToBytes(ByVal str As String) As Byte()
        'function from http://www.chilkatsoft.com/faq/dotnetstrtobytes.html
        Dim encoding As New System.Text.ASCIIEncoding()
        Return encoding.GetBytes(str)
    End Function 'StrToByteArray

    Shared Function BytesToString(ByVal dBytes As Byte()) As String
        'function from http://www.chilkatsoft.com/faq/dotnetstrtobytes.html
        Dim enc As New System.Text.ASCIIEncoding()
        Return enc.GetString(dBytes)

    End Function


    Shared Function compress(ByVal str As String) As String
        'Dim Def As Zip.Compression.Deflater = New Zip.Compression.Deflater(Zip.Compression.Deflater.BEST_COMPRESSION)
        'Dim retunbytyes As Byte()
        'Def.SetInput(StringToBytes(str))

        'Def.Deflate(retunbytyes)

        'Return BytesToString(retunbytyes)


    End Function


    Shared Function uncompress(ByVal str As String) As String
        'Dim inf As Zip.Compression.Inflater = New Zip.Compression.Inflater()
        'Dim retunbytyes As Byte()
        'inf.SetInput(StringToBytes(str))

        'inf.Inflate(retunbytyes)

        'Return BytesToString(retunbytyes)


    End Function


End Class
