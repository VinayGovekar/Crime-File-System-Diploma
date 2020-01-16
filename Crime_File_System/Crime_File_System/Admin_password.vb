Public Class Admin_password

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" Then
            DeleteFir.Show()
            Me.Close()
        Else
            MsgBox("Password is Incorrect", MsgBoxStyle.Exclamation
                   )
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MainScreen.Show()
        Me.Close()

    End Sub

    Private Sub Admin_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class