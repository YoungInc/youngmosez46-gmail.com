Public Class Signupform


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CancelLabel.Enabled = True
        CaptureButton.Enabled = True

        CancelLabel.Visible = True
        CaptureButton.Visible = True

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Close()
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim strFileName As String

        OpenFileDialog.InitialDirectory = "C:\"

        OpenFileDialog.Title = "Select your image"
        OpenFileDialog.Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"
        Dim DidWork As Integer = OpenFileDialog.ShowDialog()

        If DidWork <> DialogResult.Cancel Then

            strFileName = OpenFileDialog.FileName
            PictureBox1.Image = Image.FromFile(strFileName)
            OpenFileDialog.Reset()

        End If
    End Sub

    Private Sub CancelLabel_Click(sender As Object, e As EventArgs) Handles CancelLabel.Click
        CancelLabel.Enabled = False
        CaptureButton.Enabled = False

        CancelLabel.Visible = False
        CaptureButton.Visible = False

    End Sub
End Class