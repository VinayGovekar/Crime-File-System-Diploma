Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sfdPic As New SaveFileDialog()
        Dim Path As String = "C:\Users\Vinay\Desktop\"
        Dim Dir As String = System.IO.Path.GetDirectoryName(Path)

        Dim title As String = "Code A Minute - iBasskung."
        Dim btn = MessageBoxButtons.YesNo
        Dim ico = MessageBoxIcon.Information


        If Not System.IO.Directory.Exists(Dir) Then
            System.IO.Directory.CreateDirectory(Dir)
        End If

        With sfdPic
            .Title = "Save Image As"
            .Filter = "Jpg, Jpeg Images|*.jpg;*.jpeg|PNG Image|*.png|BMP Image|*.bmp"
            .AddExtension = True
            .DefaultExt = ".jpg"
            .FileName = "myPicture-.jpg"
            .ValidateNames = True
            .OverwritePrompt = True
            .InitialDirectory = Dir
            .RestoreDirectory = True

            If .ShowDialog = DialogResult.OK Then
                If .FilterIndex = 1 Then
                    PictureBox1.Image.Save(sfdPic.FileName, Imaging.ImageFormat.Jpeg)
                ElseIf .FilterIndex = 2 Then
                    PictureBox1.Image.Save(sfdPic.FileName, Imaging.ImageFormat.Png)
                ElseIf .FilterIndex = 3 Then
                    PictureBox1.Image.Save(sfdPic.FileName, Imaging.ImageFormat.Bmp)
                End If
            Else
                Return
            End If

        End With

        If CheckBox1.Checked Then
            Dim r As DialogResult
            Dim msg As String = "The image was saved successfully." & vbNewLine
            msg &= "Do you want to open it now?"

            r = MessageBox.Show(msg, title, btn, ico)

            If r = System.Windows.Forms.DialogResult.Yes Then
                Dim startInfo As New ProcessStartInfo("mspaint.exe") ' ^_^
                startInfo.WindowStyle = ProcessWindowStyle.Maximized
                startInfo.Arguments = Chr(34) & Dir & Chr(34) & "\" & System.IO.Path.GetFileName(sfdPic.FileName).ToString()
                Process.Start(startInfo)
            Else
                Return
            End If
        End If

        sfdPic.Dispose()

    End Sub
End Class