Imports System.Data.OleDb
Public Class DeleteFir
    Dim con As New OleDbConnection
    Private Sub DeleteFir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form_load()


    End Sub
    Public Sub Form_load()
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        con.Open()
        da = New OleDbDataAdapter("Delete * from Fir_Table Where [FIR Number] = " & TextBox1.Text & "", con)
        da.Fill(dt)

        'dt.Rows(TextBox1.Text).BeginEdit()
        'dt.Rows(TextBox1.Text).Delete()
        'dt.Rows(TextBox1.Text).EndEdit()

        Dim cb As New OleDbCommandBuilder(da)
        da.Update(dt)
        DataGridView1.Update()
        con.Close()
        Form_load()




    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MainScreen.Show()
        Me.Close()

    End Sub
End Class