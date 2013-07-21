Public Class testform

    Private Sub testform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LiteCard1.character = "1"
        LiteCard2.character = "2"
        LiteCard3.character = "3"





        LiteCard1.Backcolor = Form1.Demo_CardColor
        LiteCard2.Backcolor = Form1.Demo_CardColor
        LiteCard3.Backcolor = Form1.Demo_CardColor

        LiteCard3.ForeColor = Form1.demo_textcolor
        LiteCard1.ForeColor = Form1.demo_textcolor
        LiteCard2.ForeColor = Form1.demo_textcolor

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        LiteCard1.character = simulator_form.LiteCard1.character
        LiteCard2.character = simulator_form.LiteCard2.character
        LiteCard3.character = simulator_form.LiteCard3.character

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim dummy
        dummy = simulator_form.LiteCard1.character
        dummy = simulator_form.LiteCard1.Visible
        dummy = simulator_form.LiteCard1.DoNotRedraw
        dummy = simulator_form.LiteCard1.location
        dummy = simulator_form.LiteCard1.ForeColor
        dummy = simulator_form.LiteCard1.Backcolor
        dummy = simulator_form.LiteCard1.FontSize




        dummy = simulator_form.LiteCard2.character
        dummy = simulator_form.LiteCard2.Visible
        dummy = simulator_form.LiteCard2.DoNotRedraw
        dummy = simulator_form.LiteCard2.location
        dummy = simulator_form.LiteCard2.ForeColor
        dummy = simulator_form.LiteCard2.Backcolor
        dummy = simulator_form.LiteCard2.FontSize





    End Sub
End Class