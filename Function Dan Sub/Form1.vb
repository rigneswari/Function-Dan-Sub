Public Class Form1
    Private Sub S1()
        lblText1.Text = "Good Morning"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        S1()
    End Sub

    Private Sub S2()
        Dim strText As String
        strText = TextBox1.Text
        Label2.Text = strText
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        S2()
    End Sub

    Private Function F1()
        Return "Hello Have A Nice Day"
    End Function
    Private Function Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label3.Text = F1()
    End Function

    Private Function F2()
        Dim strText2 As String
        strText2 = TextBox2.Text
        Return strText2
    End Function

    Private Function Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label4.Text = F2()
    End Function

End Class

