Public Class Serries
    'creates a public windows media player to be called any time
    Public Playlist As WMPLib.IWMPPlaylist
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Go back to previous form
        Try
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            Me.Hide()
            HomePage.Show()
            'visual stuff when clicking
            AxWindowsMediaPlayer1.Visible = False
            PictureBox6.BackColor = Color.Transparent
            Button1.BackColor = Color.Transparent
            Button2.BackColor = Color.Transparent
            Button3.BackColor = Color.Transparent
            Button4.BackColor = Color.Transparent
            Button5.BackColor = Color.Transparent
            Button6.BackColor = Color.Transparent
            Button7.BackColor = Color.Transparent
            Button8.BackColor = Color.Transparent
            Label1.Visible = True
            Label4.Visible = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'play the movie
        Try
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Pause the movie
        Try
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Mute or unmute the movie
        Try
            If AxWindowsMediaPlayer1.settings.mute = False Then
                AxWindowsMediaPlayer1.settings.mute = True
                Button3.Text = "UnMute"
            ElseIf AxWindowsMediaPlayer1.settings.mute = True Then
                AxWindowsMediaPlayer1.settings.mute = False
                Button3.Text = "Mute"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Stop the current movie or playlist
        Try
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            'visual stuff when clicking
            AxWindowsMediaPlayer1.Visible = False
            PictureBox6.BackColor = Color.Transparent
            Button1.BackColor = Color.Transparent
            Button2.BackColor = Color.Transparent
            Button3.BackColor = Color.Transparent
            Button4.BackColor = Color.Transparent
            Button5.BackColor = Color.Transparent
            Button6.BackColor = Color.Transparent
            Button7.BackColor = Color.Transparent
            Button8.BackColor = Color.Transparent
            Label1.Visible = True
            Label4.Visible = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'creates a playlist of all the files in a folder from a to z and loops it
        Try
            AxWindowsMediaPlayer1.settings.setMode("loop", False)
            Playlist = AxWindowsMediaPlayer1.newPlaylist("MyPlayList", "")
            AxWindowsMediaPlayer1.currentPlaylist = Playlist

            Playlist.clear()
            For Each video As String In System.IO.Directory.GetFiles(LoadingForm.SFolder)
                Playlist.appendItem(AxWindowsMediaPlayer1.newMedia(video))
            Next
            'visual stuff when clicking
            AxWindowsMediaPlayer1.Visible = True
            PictureBox6.BackColor = Color.Black
            Button1.BackColor = Color.Black
            Button2.BackColor = Color.Black
            Button3.BackColor = Color.Black
            Button4.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button6.BackColor = Color.Black
            Button7.BackColor = Color.Black
            Button8.BackColor = Color.Black
            Label1.Visible = False
            Label4.Visible = False
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'creates a random playlist to shuffle all the movies in a folder
        Try
            Dim vids() As String = System.IO.Directory.GetFiles(LoadingForm.SFolder)
            For x As Integer = 0 To vids.GetUpperBound(0)
                Dim vid As WMPLib.IWMPMedia = AxWindowsMediaPlayer1.newMedia(vids(x))
                AxWindowsMediaPlayer1.currentPlaylist.appendItem(vid)
            Next
            AxWindowsMediaPlayer1.settings.setMode("shuffle", True)
            'visual stuff when clicking
            AxWindowsMediaPlayer1.Visible = True
            PictureBox6.BackColor = Color.Black
            Button1.BackColor = Color.Black
            Button2.BackColor = Color.Black
            Button3.BackColor = Color.Black
            Button4.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button6.BackColor = Color.Black
            Button7.BackColor = Color.Black
            Button8.BackColor = Color.Black
            Label1.Visible = False
            Label4.Visible = False
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            AxWindowsMediaPlayer1.currentPlaylist.clear()
            If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
                LoadingForm.SFolder = FolderBrowserDialog1.SelectedPath
            End If
            'visual stuff when clicking
            AxWindowsMediaPlayer1.Visible = True
            PictureBox6.BackColor = Color.Black
            Button1.BackColor = Color.Black
            Button2.BackColor = Color.Black
            Button3.BackColor = Color.Black
            Button4.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button6.BackColor = Color.Black
            Button7.BackColor = Color.Black
            Button8.BackColor = Color.Black
            Label1.Visible = False
            Label4.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Serries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.Visible = False
        PictureBox6.BackColor = Color.Transparent
        Label1.Visible = True
        Label4.Visible = True
    End Sub
End Class