Imports System.Data.OleDb
Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source= E:\Project\ImageDb.accdb"
        con.Open()
        Dim cmd As New OleDbCommand("Insert into Criminal([imagename],[image]) Values (?,?)")
        cmd.Parameters.Add(New OleDbParameter("imagename", CType(TextBox1.Text, String)))
        Dim ms As New 

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog2.Filter = "image file (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png| all files (*.*) | *.*"
        If OpenFileDialog2.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog2.FileName)
        End If
    End Sub
End Class
