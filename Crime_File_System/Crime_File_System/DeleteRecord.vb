Imports System.Data.OleDb
Public Class DeleteRecord
    Dim con As New OleDbConnection
    Private Sub DeleteRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Criminal_DatabaseDataSet5.Criminal' table. You can move, or remove it, as needed.
        Me.CriminalTableAdapter.Fill(Me.Criminal_DatabaseDataSet5.Criminal)
        Form_load()

    End Sub
    Public Sub Form_load()
        con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=E:\Project\Crime_File_System\Crime_File_System\bin\Debug\Criminal_Database.accdb"
        con.Open()
        Dim dt As New DataTable


        Dim ds As New DataSet

        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("Select * from Criminal", con)
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
        da = New OleDbDataAdapter("Delete * from Criminal Where [CriminalRecordNo] = " & TextBox1.Text & "", con)
        da.Fill(dt)

        'dt.Rows(TextBox1.Text).BeginEdit()
        'dt.Rows(TextBox1.Text).Delete()
        'dt.Rows(TextBox1.Text).EndEdit()

        Dim cb As New OleDbCommandBuilder(da)
        da.Update(dt)
        DataGridView1.Update()
        MsgBox("Record Deleted")
        con.Close()
        Form_load()


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MainScreen.Show()
        Me.Close()

    End Sub
End Class