Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblText1.Text = "Welcome To My Application"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strText As String
        strText = TextBox1.Text
        Label2.Text = strText
    End Sub

    Private Function Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label3.Text = "DDT4C"
        Return Label3
    End Function

    Private Function Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim strText2 As String
        strText2 = TextBox2.Text
        Label4.Text = strText2
        Return Label4
    End Function
End Class
