Public Class HomePage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Closes the program
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        'displays settings
        Try
            MsgBox("This feature is not yet available")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Opens the movies form
        Try
            Me.Hide()
            Movies.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Opens the serries form
        Try
            Me.Hide()
            Serries.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Opens the stream form
        Try
            Me.Hide()
            Stream.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display my trademark
        Label2.Text = Chr(153) & "Created by Mornante' Basson"
    End Sub
End Class