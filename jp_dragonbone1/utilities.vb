Public Class utilities
    Public Function int2Hex(ByVal num As Int64, Optional ByVal digits As UInt16 = 0) As String
        Dim returnvalue As String
        returnvalue = Hex(num)
        If digits = 0 Then
            Return returnvalue
        End If
        While (returnvalue.Length < digits)
            returnvalue = "0" & returnvalue
        End While
        Return returnvalue

    End Function

    Public Function arrayMemeberCount(ByVal array As Object) As Int32
        Try
            Return array.count
        Catch ex As Exception

        End Try
        Try
            Return array.length
        Catch ex As Exception

        End Try

        Try
            Dim counter As Int32 = 0
            For Each obj As Object In array
                counter += 1
            Next
            Return counter

        Catch ex As Exception

        End Try

        Throw New ArgumentException("object passed to arraymembercount() as array does not appear to be an array")
    End Function

    Private Sub arrayRemoveAt(ByRef arr As Object, ByVal index As Int32)
        'not finished
        'not finished
        'not finished
        'not finished
        'not finished
        Throw New Exception("you have called a function that is not finished")
        Dim newarray As Object

        If TypeOf arr Is ArrayList Then
            newarray = New ArrayList(arrayMemeberCount(arr) - 1)


        Else
            Try
                'works if array
                Array.Copy(arr, newarray, arrayMemeberCount(arr))
                newarray.resize(arrayMemeberCount(arr) - 1)

            Catch ex As Exception
            End Try

        End If

        Dim loopcounter As Int32 = 0

        While loopcounter < arrayMemeberCount(arr)

            loopcounter += 1
        End While




    End Sub

    Public Function modifyarraylist(ByRef arraytomodify As ArrayList, ByVal valuesThatNeedToBeInFinal As ArrayList, ByVal valuesToLeaveAsIs As ArrayList, Optional ByVal sort As Boolean = False, Optional ByVal changeOriginal As Boolean = False) As ArrayList


        Dim finalvalue As ArrayList = New ArrayList
        Dim loopcounter As Int32 = 0

        'copy original
        While loopcounter < arraytomodify.Count
            finalvalue.Add(arraytomodify(loopcounter))
            loopcounter += 1
        End While


        'remove values that don't belong
        loopcounter = 0
        While loopcounter < arrayMemeberCount(arraytomodify)
            'if its not in the vlues that need to be in and and not in values to leave as is
            Dim thisvalue As Object = arraytomodify(loopcounter)

            If valuesThatNeedToBeInFinal.IndexOf(thisvalue) = -1 And valuesToLeaveAsIs.IndexOf(thisvalue) = -1 Then

                finalvalue.Remove(thisvalue)

            End If
            loopcounter += 1
        End While

        'add values that need to be added
        loopcounter = 0
        While loopcounter < arrayMemeberCount(valuesThatNeedToBeInFinal)
            Dim thisvalue As Object = valuesThatNeedToBeInFinal(loopcounter)
            If finalvalue.IndexOf(thisvalue) = -1 Then
                finalvalue.Add(thisvalue)
            End If
            loopcounter += 1
        End While

        If sort Then
            finalvalue.Sort()
        End If

        If changeOriginal Then
            'copy final back to original
            arraytomodify.Clear()
            loopcounter = 0
            While loopcounter < finalvalue.Count
                arraytomodify.Add(finalvalue(loopcounter))
                loopcounter += 1
            End While

        End If
        Return finalvalue

    End Function

    Private Sub utilities_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class