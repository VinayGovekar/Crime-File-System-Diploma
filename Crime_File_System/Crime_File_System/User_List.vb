Public Class User_List

    Private Sub User_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Login_DatabaseDataSet1.LogIn' table. You can move, or remove it, as needed.
        Me.LogInTableAdapter.Fill(Me.Login_DatabaseDataSet1.LogIn)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Add_User.Show()
        Me.Close()

    End Sub
End Class