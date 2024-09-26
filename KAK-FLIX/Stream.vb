Public Class Stream
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Go back to the previous form
        Try
            WebBrowser1.Dispose()
            TextBox1.Text = "https://www."
            'Visual effects
            PictureBox6.BackColor = Color.Transparent
            Button1.BackColor = Color.Transparent
            Button2.BackColor = Color.Transparent
            Label1.Visible = True
            Label2.Visible = True
            Label4.Visible = True
            Button5.Visible = True
            TextBox1.Visible = True
            WebBrowser1.Visible = False

            Me.Hide()
            HomePage.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Stream_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim URL As String = TextBox1.Text
            WebBrowser1.Url = New Uri(URL)
            'Visual effects
            PictureBox6.BackColor = Color.Black
            Button1.BackColor = Color.Black
            Button2.BackColor = Color.Black
            Label1.Visible = False
            Label2.Visible = False
            Label4.Visible = False
            Button5.Visible = False
            TextBox1.Visible = False
            WebBrowser1.Visible = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            WebBrowser1.Dispose()
            TextBox1.Text = "https://www."
            'Visual effects
            PictureBox6.BackColor = Color.Transparent
            Button1.BackColor = Color.Transparent
            Button2.BackColor = Color.Transparent
            Label1.Visible = True
            Label2.Visible = True
            Label4.Visible = True
            Button5.Visible = True
            TextBox1.Visible = True
            WebBrowser1.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
