Imports System.Data.OleDb
Public Class firlist
    Dim con As New OleDbConnection
   
    Private Sub firlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=E:\Project\Crime_File_System\Crime_File_System\bin\Debug\Fir_Database.accdb"
        con.Open()
        Dim dt As New DataTable


        Dim ds As New DataSet

        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("Select * from Fir_Table", con)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MainScreen.Show()
        Me.Close()

    End Sub
End Class