Imports System.Windows.Forms

Public Class Cryptography
    Dim EncryptionFactor As Integer = 3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Clear()
        For Each letter As String In TextBox1.Text
            TextBox2.Text += Chr(Asc(letter) + EncryptionFactor)
        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox3.Clear()
        For Each letter As String In TextBox4.Text
            TextBox3.Text += Chr(Asc(letter) - EncryptionFactor)
        Next

    End Sub

    Private Sub Cryptography_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MainScreen.Show()
        Me.Close()

    End Sub
End Class
