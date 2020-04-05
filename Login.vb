Public Class Login


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        Close()


    End Sub



    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        Label4.ForeColor = Color.Red
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.Gray

    End Sub

    Private Sub LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel.LinkClicked
        Signupform.Show()

        Close()
    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = Color.Aqua
        If username.Text = "" Then
            MessageBox.Show("Username has not been provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf password.Text = "" Then
            MessageBox.Show("Password has not been provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
End Class