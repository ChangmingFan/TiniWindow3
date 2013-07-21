'20110821 j.p.: determined this form is not used in this version of tiniwindow
'comented it out with no errors



'Public Class jpmsgform
'    'this form is created by J.P. Denoyer
'    'it is not owned by TiniLite and is not proprietory
'    'any one may use it for any purpose so long as credit for creator remains
'    'it may be modified as long as credit for all co-creators are documented
'    Private buttons As ArrayList = New ArrayList
'    Private boxes As ArrayList = New ArrayList
'    Private checkboxistrueradioisfalse As Boolean
'    Private buttonhandles As Button()


'    Public Sub setmessage(ByVal message As String)
'        Txt_message.Text = message

'    End Sub
'    Private Sub disposebuttons()
'        Dim index As Int16 = 0

'        While (index < buttons.Count)
'            buttons(index).dispose()
'            index += 1
'        End While
'    End Sub
'    Public Sub setbuttons(ByVal buttontext As ArrayList)
'        disposebuttons()
'        Dim longesttextlength As Int16 = 0
'        Dim index As Int16 = 0

'        While (index < buttontext.Count)
'            If buttontext(index).length > longesttextlength Then
'                longesttextlength = buttontext(index).length
'            End If

'            index += 1
'        End While
'        Dim buttonwidth As Int16 = 27 + 3 * (longesttextlength - 1)
'        Dim buttonrows As Int16 = 1
'        Dim formwidth As Int16
'        While (True)
'            formwidth = 27 * 2 + (buttonwidth + 3) * buttontext.Count / buttonrows
'            If formwidth > 1200 Then

'                buttonrows += 1
'            Else
'                Exit While
'            End If

'        End While

'        Me.Width = formwidth

'        Dim buttonx As Int16 = 12
'        Dim buttony As Int16 = 84

'        buttons = New ArrayList

'        index = 0

'        While (index < buttontext.Count)
'            Dim thisbutton As Button = New Button
'            thisbutton.Parent = Me
'            thisbutton.Location = New System.Drawing.Point(buttonx, buttony)
'            thisbutton.Text = buttontext(index)
'            thisbutton.Width = buttonwidth
'            thisbutton.Name = "button" + index.ToString
'            'thisbutton.
'            buttons.Add(thisbutton)

'            buttonx += buttonwidth + 3
'            If (buttonx + buttonwidth > 1200) Then
'                buttonx = 17
'                buttony += 30
'            End If

'            index += 1
'        End While

'    End Sub

'    Private Sub jpmsgform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        Dim testbuttons As ArrayList = New ArrayList

'        testbuttons.Add("but1")
'        testbuttons.Add("but2")
'        testbuttons.Add("but3")

'        setbuttons(testbuttons)

'    End Sub

'    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
'        ' Add event handler code here.
'    End Sub


'End Class
