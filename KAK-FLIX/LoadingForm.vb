Public Class LoadingForm
    'make the selected folderPath public for other forms to use (check line 18 + 30)
    Public Property MFolder As String
    Public Property SFolder As String
    Public Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lets the progressbar start
        Timer1.Start()
    End Sub

    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'when progressbar starts file dialogs whil start to ask which folders to assign
        Try
            ProgressBar1.Increment(1)

            If ProgressBar1.Value = 33 Then
                Timer1.Stop()
                'the public folderPath
                Dim dialog As String = FolderBrowserDialog1.ShowDialog = DialogResult.OK
                MFolder = FolderBrowserDialog1.SelectedPath

                ProgressBar1.Value = 33
                Timer1.Start()
                'check mark = ChrW(&H2713)
                Label4.Text = ChrW(&H2713)
            End If

            If ProgressBar1.Value = 66 Then
                Timer1.Stop()
                'the public folder path
                Dim dialog As String = FolderBrowserDialog2.ShowDialog = DialogResult.OK
                SFolder = FolderBrowserDialog2.SelectedPath

                ProgressBar1.Value = 66
                Timer1.Start()
                'check mark = ChrW(&H2713)
                Label5.Text = ChrW(&H2713)
            End If

            'when to stop the progressbar and continue to next form
            If ProgressBar1.Value = 100 Then
                Timer1.Stop()
                Me.Hide()
                HomePage.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        'progressbar colours
        ProgressBar1.ForeColor = Color.White
        ProgressBar1.BackColor = Color.Black
    End Sub
End Class
