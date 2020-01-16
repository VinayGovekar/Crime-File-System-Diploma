Public Class Add_User

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub LogInBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LogInBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LogInBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Login_DatabaseDataSet)

    End Sub

    Private Sub Add_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Login_DatabaseDataSet.LogIn' table. You can move, or remove it, as needed.
        Me.LogInTableAdapter.Fill(Me.Login_DatabaseDataSet.LogIn)

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        User_List.Show()
        Me.Close()

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Login.Show()
        Me.Close()

    End Sub
End Class