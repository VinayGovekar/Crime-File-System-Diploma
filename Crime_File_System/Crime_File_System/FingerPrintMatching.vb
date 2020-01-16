Imports System.Data.OleDb
Imports System.IO
Public Class FingerPrintMatching
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Public Function AreSameImage(ByVal I1 As Image, ByVal I2 As Image) As Boolean
        Dim BM1 As Bitmap = I1
        Dim BM2 As Bitmap = I2
        For X = 0 To BM1.Width - 1
            For y = 0 To BM2.Height - 1
                If BM1.GetPixel(X, y) <> BM2.GetPixel(X, y) Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "image file (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png| all files (*.*) | *.*"
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

        'provider = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source="
        ' dataFile = "E:\Project\Crime_File_System\Crime_File_System\bin\Debug\Criminal_Database.accdb"
        '     connString = provider & dataFile
        '    myConnection.ConnectionString = connString
        '   Dim Sql As String
        '  Sql = "UPDATE Criminal SET [Photo of Criminal] = ? WHERE [CriminalRecordNo] = 1"
        ' Dim cmd As New OleDbCommand(Sql, myConnection)
        '      'Dim dr As OleDbDataReader = cmd.ExecuteReader()
        '
        ' Using picture As Image = Image.FromFile("C:\Users\Vinay\Desktop\criminalimage.jpg")
        '
        '       Using stream As New IO.MemoryStream
        '
        '   picture.Save(Stream, Imaging.ImageFormat.Jpeg)

        '        cmd.Parameters.Add("Photo of Criminal", OleDbType.VarBinary).Value = Stream.GetBuffer()

        ' End Using

        '       End Using



        'myConnection.Open()

        '        cmd.ExecuteNonQuery()

        'myConnection.Close()
        '
        '

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog2.Filter = "image file (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png| all files (*.*) | *.*"
        If OpenFileDialog2.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox2.Image = Image.FromFile(OpenFileDialog2.FileName)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As Boolean = AreSameImage(PictureBox1.Image, PictureBox2.Image)
        If a Then
            MsgBox("Fingerprint Matched", MsgBoxStyle.Information)
        Else
            MsgBox("Fingerprints are Different.", MsgBoxStyle.Exclamation
                   )
        End If

    End Sub

    Private Sub FingerPrintMatching_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)


        '  Dim adp As New OleDb.OleDbDataAdapter("select * FROM Criminal WHERE [CriminalRecordNo]='" & TextBox1.Text & "'", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Crime_File_System\Crime_File_System\bin\Debug\Criminal_Database.accdb")
        ' Dim ds As New DataSet
        ' adp.Fill(ds, "Criminal")
        '  ' Dim bytes() As Byte = ds.Tables("Criminal").Rows(0).Item("Photo of Criminal")
        ' Dim img As Image = Image.FromStream(New System.IO.MemoryStream(bytes))
        '  PictureBox1.Image = img
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MainScreen.Show()
        Me.Close()

    End Sub
End Class