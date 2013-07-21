Public Class jpstringfunctions
    'these functions were written by J.P.
    'J.P. retains the intellectual property rights to these functions 
    'a non revocable right has been granted to Tini Lite World Inc to use these functions.

    Public Function getLineCount(ByVal strn As String, Optional ByVal lineTerminators As String = Constants.vbCrLf, Optional ByVal MultipleTerminateCharactersAreOneLine As Boolean = True, Optional ByVal countUnterminatedLineAtEndOfString As Boolean = False) As Integer

        'this function has not been tested and may contain bugs


        Dim returnvalue As Integer = 0
        Dim continueloop As Boolean = True
        Dim indexOfLineTerminator As Integer = strn.IndexOfAny(lineTerminators)
        While (indexOfLineTerminator >= 0)
            'a line terminator has been found in the string
            'increment counter and truncate string to discaurd first line


            returnvalue += 1

            strn = strn.Substring(indexOfLineTerminator + 1)

            If (MultipleTerminateCharactersAreOneLine) Then
                strn = strn.TrimStart(lineTerminators)
            End If
            indexOfLineTerminator = strn.IndexOfAny(lineTerminators)

        End While

        If countUnterminatedLineAtEndOfString And strn.Length > 0 Then
            returnvalue += 1
        End If

        Return returnvalue


    End Function

    Public Function getLettersFromBeginningTo(ByVal original As String, ByVal ch As String) As String
        If ch = "" Then
            ch = " "

        End If


        Dim returnvalue As String = ""

        Dim originalwalker As Int16 = 0

        While originalwalker < original.Length
            Dim chwalker As Int16 = 0
            While chwalker < ch.Length
                If ch(chwalker) = original(originalwalker) Then
                    Return returnvalue

                End If

                chwalker += 1
            End While

            returnvalue &= original(originalwalker)
            originalwalker += 1

        End While



        'gets to here if none of the chars in ch are encountered in original
        Return returnvalue




    End Function
    Public Function getLettersFromendTo(ByVal original As String, ByVal ch As String) As String


        If ch = "" Then
            ch = " "

        End If


        Dim returnvalue As String = ""

        Dim originalwalker As Int16 = original.Length - 1

        While originalwalker >= 0
            Dim chwalker As Int16 = 0
            While chwalker < ch.Length
                If ch(chwalker) = original(originalwalker) Then
                    Return returnvalue

                End If

                chwalker += 1
            End While

            returnvalue = original(originalwalker) & returnvalue
            originalwalker -= 1

        End While



        'gets to here if none of the chars in ch are encountered in original
        Return returnvalue




    End Function




    Public Function discardwhitespace(ByVal original As String, Optional ByVal spacechars As String = "     " & Constants.vbCrLf & Constants.vbVerticalTab & Constants.vbBack & Constants.vbNullChar) As String
        If spacechars = "" Then
            spacechars = " "

        End If

        Dim returnvalue As String = original
        Dim loopcounter As Int16 = 0
        While loopcounter < spacechars.Length

            returnvalue = returnvalue.Replace(spacechars(loopcounter), "")

            'String.Join("", returnvalue.Split(spacechars(loopcounter)))


            loopcounter += 1
        End While


        Return returnvalue

    End Function
    Public Function padleft(ByVal original As String, ByVal pad As Char, ByVal finalsize As Int32) As String

        If finalsize < 0 Then
            Throw New IndexOutOfRangeException("final size can not be less then 0")

        End If

        If pad = "" Then
            pad = " "

        End If

        Dim returnvalue As String = original
        While returnvalue.Length < finalsize
            returnvalue = pad + returnvalue

        End While
        Return returnvalue
    End Function

    Public Function padright(ByVal original As String, ByVal pad As Char, ByVal finalsize As Int32) As String
        If finalsize < 0 Then
            Throw New IndexOutOfRangeException("final size can not be less then 0")

        End If

        If pad = "" Then
            pad = " "

        End If


        Dim returnvalue As String = original
        While returnvalue.Length < finalsize
            returnvalue += pad

        End While
        Return returnvalue
    End Function

    Public Function truncateright(ByVal original As String, ByVal finalsize As Int32) As String
        If finalsize < 0 Then
            Throw New IndexOutOfRangeException("final size can not be less then 0")

        End If

        If finalsize = 0 Then
            Return ""
        End If
        If original.Length <= finalsize Then
            Return original
        Else

            Return original.Substring(0, finalsize)
        End If

    End Function
    Public Function truncateleft(ByVal original As String, ByVal finalsize As Int32) As String
        If finalsize < 0 Then
            Throw New IndexOutOfRangeException("final size can not be less then 0")

        End If


        If finalsize = 0 Then
            Return ""
        End If
        If original.Length <= finalsize Then
            Return original
        Else
            Return original.Substring(original.Length - finalsize)


        End If

    End Function


    Public Function sizeexactlyright(ByVal original As String, ByVal pad As Char, ByVal finalsize As Int32)
        If finalsize < 0 Then
            Throw New IndexOutOfRangeException("final size can not be less then 0")

        End If

        If pad = "" Then
            pad = " "

        End If
        If finalsize = 0 Then
            Return ""
        End If

        If original.Length = finalsize Then
            Return original
        ElseIf original.Length > finalsize Then
            Return truncateright(original, finalsize)
        ElseIf original.Length < finalsize Then
            Return padright(original, pad, finalsize)
        Else
            MsgBox("bug in jpstringfunctios.sizeexactlyright()")
            Return original
        End If

    End Function


    Public Function sizeexactlyleft(ByVal original As String, ByVal pad As Char, ByVal finalsize As Int32)

        If finalsize < 0 Then
            Throw New IndexOutOfRangeException("final size can not be less then 0")

        End If

        If pad = "" Then
            pad = " "

        End If
        If finalsize = 0 Then
            Return ""
        End If

        If original.Length = finalsize Then
            Return original
        ElseIf original.Length > finalsize Then
            Return truncateleft(original, finalsize)
        ElseIf original.Length < finalsize Then
            Return padleft(original, pad, finalsize)
        Else
            MsgBox("bug in jpstringfunctios.sizeexactlyright()")
            Return original
        End If

    End Function

    Public Function leftcharatercount(ByVal strn As String, ByVal ch As String) As Int32
        
        If ch = "" Then
            ch = " "

        End If

        Dim newstring As String = strn.TrimStart(ch)

        Return strn.Length - newstring.Length

    End Function

    Public Function rightcharatercount(ByVal strn As String, ByVal ch As Char) As Int32
        If ch = "" Then
            ch = " "

        End If


        Dim newstring As String = strn.TrimEnd(ch)

        Return strn.Length - newstring.Length
    End Function

    Public Function trimtolength(ByVal original As String, ByVal ch As String, ByVal finallength As Int32) As String
        If finallength < 0 Then
            Throw New IndexOutOfRangeException("final size can not be less then 0")

        End If

        If ch = "" Then
            ch = " "

        End If




        Dim workonbegining As Boolean = True

        Dim begexhausted As Boolean = False
        Dim endexhausted As Boolean = False

        Dim loopcounter As Int16 = 0
        Dim returnvalue As String = original
        While returnvalue.Length > finallength
            If workonbegining Then
                loopcounter = 0
                While loopcounter < ch.Length
                    If ch(loopcounter) = returnvalue(0) Then
                        returnvalue = returnvalue.Substring(1)
                        Exit While 'inner while
                    End If
                    loopcounter += 1
                End While
                If loopcounter = ch.Length Then
                    begexhausted = True
                End If

            Else
                loopcounter = 0
                While loopcounter < ch.Length
                    If returnvalue.EndsWith(ch(loopcounter)) Then
                        returnvalue = returnvalue.Substring(0, returnvalue.Length - 1)
                        Exit While 'inner while
                    End If
                    loopcounter += 1
                End While
                If loopcounter = ch.Length Then
                    endexhausted = True
                End If


            End If

            If endexhausted And begexhausted Then
                Exit While
            ElseIf endexhausted Then
                workonbegining = True
            ElseIf begexhausted Then
                workonbegining = False
            Else
                workonbegining = Not workonbegining
            End If
        End While

        Return returnvalue

    End Function


    Public Function capitolizewords(ByVal original As String, Optional ByVal nonleadingletterslowercase As Boolean = True) As String




        Dim previouscharnonletter As Boolean = True
        Dim returnvalue As String = ""
        Dim loopcounter As Int16 = 0

        While loopcounter < original.Length
            Dim ch As Char = original(loopcounter)
            If (ch >= "a" And ch <= "z") Or (ch >= "A" And ch <= "Z") Then
                If previouscharnonletter Then
                    returnvalue += Char.ToUpper(ch)
                ElseIf nonleadingletterslowercase Then

                    returnvalue += Char.ToLower(ch)
                Else
                    returnvalue += ch

                End If
                previouscharnonletter = False
            Else
                returnvalue += ch
                previouscharnonletter = True
            End If


            loopcounter += 1
        End While
        Return returnvalue
    End Function

    Public Function removeduplicatechars(ByVal original As String, ByVal ch As Char) As String

        If ch = "" Then
            ch = " "

        End If



        Dim previouscharisch As Boolean = False


        Dim returnvalue As String = ""
        Dim loopcounter As Int16 = 0

        While loopcounter < original.Length
            Dim thisletter As Char = original(loopcounter)

            If (thisletter = ch) Then
                If previouscharisch Then
                    'duplicate, do nothing
                Else
                    'first occurenc in sequece, append to returnvalue
                    returnvalue += thisletter
                End If
                previouscharisch = True
            Else
                returnvalue += thisletter
                previouscharisch = False
            End If


            loopcounter += 1
        End While

        Return returnvalue
    End Function

    Public Function getleadingspace(ByVal str As String, Optional ByVal ch As String = " ") As Int16

        If ch = "" Then
            ch = " "

        End If

        Dim returnvalue As Int16 = str.Length - str.TrimStart(ch).Length
        Return returnvalue


    End Function

    Public Function gettrailingspace(ByVal str As String, Optional ByVal ch As String = " ") As Int16

        If ch = "" Then
            ch = " "

        End If

        Dim returnvalue As Int16 = str.Length - str.TrimEnd(ch).Length
        Return returnvalue


    End Function
End Class
