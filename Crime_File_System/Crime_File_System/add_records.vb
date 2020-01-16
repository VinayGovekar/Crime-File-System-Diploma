Imports System.Data.OleDb
Public Class add_records
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim count As Integer
    Dim c1 As Integer = count + 1
    Private Sub add_records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Criminal_DatabaseDataSet1.Criminal' table. You can move, or remove it, as needed.
        Me.CriminalTableAdapter.Fill(Me.Criminal_DatabaseDataSet1.Criminal)
        Timer1.Start()
        'TextBox1.Text = c1.ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "E:\Project\Crime_File_System\Crime_File_System\bin\Debug\Criminal_Database.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into Criminal([CriminalRecordNo],[Date of Arrest],[Name of Criminal],[Address of Criminal],[Offence of Criminal],[Designation of Criminal],[Confession of Criminal],[Action against Criminal],[Photo of Criminal],[Fingerprint of Criminal]) Values (?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("CriminalRecordNo", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Date of Arrest", CType(DateTimePicker1.Value, Date)))
        cmd.Parameters.Add(New OleDbParameter("Name of Criminal", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Address of Criminal", CType(TextBox4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Offence of Criminal", CType(TextBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Designation of Criminal", CType(TextBox6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Confession of Criminal", CType(TextBox7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Action against Criminal", CType(TextBox8.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Photo of Criminal", CType(PictureBox1.Image, Object)))
        cmd.Parameters.Add(New OleDbParameter("Fingerprint of Criminal", CType(PictureBox2.Image, Object)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            TextBox1.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.Filter = "image file (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png| all files (*.*) | *.*"
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenFileDialog2.Filter = "image file (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png| all files (*.*) | *.*"
        If OpenFileDialog2.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox2.Image = Image.FromFile(OpenFileDialog2.FileName)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        criminals.show()
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MainScreen.Show()
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class