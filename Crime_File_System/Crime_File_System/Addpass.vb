Public Class Addpass

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" Then
            DeleteRecord.Show()
            Me.Close()
        Else
            MsgBox("Password is Incorrect", MsgBoxStyle.Exclamation
                   )
        End If
    End Sub
End Class