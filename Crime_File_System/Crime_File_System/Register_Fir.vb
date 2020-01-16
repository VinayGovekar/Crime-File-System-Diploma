Public Class Register_Fir
    Dim count As Integer
    Private Sub Fir_TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Fir_TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Fir_DatabaseDataSet)

    End Sub

    Private Sub Register_Fir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Fir_DatabaseDataSet.Fir_Table' table. You can move, or remove it, as needed.
        Me.Fir_TableTableAdapter.Fill(Me.Fir_DatabaseDataSet.Fir_Table)
        Timer1.Start()
       

    End Sub

    Private Sub Addbutton_Click(sender As Object, e As EventArgs) Handles Addbutton.Click
        Fir_TableBindingSource.AddNew()

        Dim c1 As Integer = count + 1

        ' FIR_NumberTextBox.Text = c1.ToString

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Fir_TableBindingSource.EndEdit()
            Fir_TableTableAdapter.Update(Fir_DatabaseDataSet.Fir_Table)
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("Error while saving data.")
        End Try
       
    End Sub

    

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Address_of_CriminalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Address_of_CriminalTextBox.TextChanged

    End Sub

    Private Sub Address_of_CriminalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Name_of_CriminalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Name_of_CriminalTextBox.TextChanged

    End Sub

    Private Sub Name_of_CriminalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FIR_DetailsTextBox_TextChanged(sender As Object, e As EventArgs) Handles FIR_DetailsTextBox.TextChanged

    End Sub

    Private Sub FIR_DetailsLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Place_of_IncidentTextBox_TextChanged(sender As Object, e As EventArgs) Handles Place_of_IncidentTextBox.TextChanged

    End Sub

    Private Sub Place_of_IncidentLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Address_of_InformerTextBox_TextChanged(sender As Object, e As EventArgs) Handles Address_of_InformerTextBox.TextChanged

    End Sub

    Private Sub Address_of_InformerLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Name_of_InformerTextBox_TextChanged(sender As Object, e As EventArgs) Handles Name_of_InformerTextBox.TextChanged

    End Sub

    Private Sub Name_of_InformerLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Date_of_FIR_registrationDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Date_of_FIR_registrationDateTimePicker.ValueChanged

    End Sub

    Private Sub Date_of_FIR_registrationLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DistrictTextBox_TextChanged(sender As Object, e As EventArgs) Handles DistrictTextBox.TextChanged

    End Sub

    Private Sub DistrictLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ActTextBox_TextChanged(sender As Object, e As EventArgs) Handles ActTextBox.TextChanged

    End Sub

    Private Sub ActLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FIR_NumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles FIR_NumberTextBox.TextChanged

    End Sub

    Private Sub FIR_NumberLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Fir_TableBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles Fir_TableBindingSource.CurrentChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count = Fir_TableBindingSource.Count
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MainScreen.Show()
        Me.Close()

    End Sub
End Class