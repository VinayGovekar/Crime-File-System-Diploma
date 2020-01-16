Imports System.Windows.Forms
Imports System.Data.OleDb


Public Class MainScreen

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub RegisterFIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterFIRToolStripMenuItem.Click
        Register_Fir.Show()
        Me.Close()

    End Sub

    Private Sub AddCriminalRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCriminalRecordsToolStripMenuItem.Click
        add_records.Show()
        Me.Close()

    End Sub

    Private Sub FingerprintMatchingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FingerprintMatchingToolStripMenuItem.Click
        FingerPrintMatching.Show()
        Me.Close()

    End Sub

    Private Sub DeleteFIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteFIRToolStripMenuItem.Click
        If Label5.Text = "Admin" Then
            DeleteFir.Show()
            Me.Close()
        Else
            Admin_password.Show()
            Me.Close()
        End If
       
    End Sub

    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Login_DatabaseDataSet2.LogIn' table. You can move, or remove it, as needed.
        Me.LogInTableAdapter.Fill(Me.Login_DatabaseDataSet2.LogIn)
        'TODO: This line of code loads data into the 'Fir_DatabaseDataSet1.Fir_Table' table. You can move, or remove it, as needed.
        Me.Fir_TableTableAdapter.Fill(Me.Fir_DatabaseDataSet1.Fir_Table)
        'TODO: This line of code loads data into the 'Criminal_DatabaseDataSet4.Criminal' table. You can move, or remove it, as needed.
        Me.CriminalTableAdapter.Fill(Me.Criminal_DatabaseDataSet4.Criminal)
        Timer1.Start()
        Timer3.Start()
        Timer2.Start()
        Me.Label5.Text = Login.txtUsername.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim count As Integer
        count = CriminalBindingSource.Count
        Label2.Text = "Total number of Criminal records: " + count.ToString



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ToolTip_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip.Popup

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ViewCriminalRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCriminalRecordsToolStripMenuItem.Click
        criminals.Show()
        Me.Close()

    End Sub

    Private Sub CriminalRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CriminalRecordsToolStripMenuItem.Click

    End Sub

    Private Sub ViewFIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFIRToolStripMenuItem.Click
        firlist.Show()
        Me.Close
    End Sub

    Private Sub FirstInformationReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FirstInformationReportToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CriminalBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles CriminalBindingSource.CurrentChanged

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim count1 As Integer
        count1 = FirTableBindingSource.Count
        Label3.Text = "Total number of FIR registered:      " + count1.ToString


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim count2 As Integer
        count2 = LogInBindingSource.Count
        Label4.Text = "Total number of Users:                   " + count2.ToString


    End Sub

    Private Sub DeleteCriminalRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCriminalRecordsToolStripMenuItem.Click
        If Label5.Text = "Admin" Then
            DeleteRecord.Show()
            Me.Close()
        Else
            Addpass.Show()
            Me.Close()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.Show()
        Me.Close()

    End Sub

    Private Sub CryptographyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CryptographyToolStripMenuItem.Click
        Cryptography.Show()
        Me.Close()
    End Sub
End Class
