Option Explicit On
Option Strict On

Imports System.Data.OleDb

Public Class Login
    Dim objCon As New OleDbConnection
    Dim strSQL As String
    Dim strConnection As String = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Crime_File_System\Crime_File_System\bin\Debug\Login_Database.accdb"
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim attempt As Integer = 0

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim warning As String = "Warning!" & vbNewLine & vbNewLine + _
        "If attempt var = 3" + vbNewLine + _
        "System will shutdown."

        If (txtUsername.Text = "") And (txtPassword.Text = "") Then
            attempt = attempt + 1
            MsgBox("Please input username and password!" & vbNewLine & vbNewLine + _
                   warning, MsgBoxStyle.Exclamation, "Sorry sir! " & _
                   "Now attempt var = " & attempt)
        ElseIf (txtUsername.Text = "") Then
            attempt = attempt + 1
            MsgBox("Please input your username!" & vbNewLine & vbNewLine + _
                   warning, MsgBoxStyle.Information, "Sorry sir! " & _
                   "Now attempt var = " & attempt)
        ElseIf (txtPassword.Text = "") Then
            attempt = attempt + 1
            MsgBox("Please input password!" & vbNewLine & vbNewLine + _
                   warning, MsgBoxStyle.Information, "Sorry sir! " & _
                   "Now attempt var = " & attempt)
        Else

            Dim strName = txtUsername.Text
            Dim strPass = txtPassword.Text

            With objCon
                .Close()
                If .State = ConnectionState.Closed Then
                    .ConnectionString = strConnection
                    .Open()
                    '-----------MsgBox("ConnectionState.Open", MsgBoxStyle.Information, "Connected")
                End If
            End With

            ds.Clear()
            strSQL = "Select * From LogIn Where Username ='" & txtUsername.Text & "' And Password ='" & txtPassword.Text & "'"
            da = New OleDbDataAdapter(strSQL, objCon)
            da.Fill(ds, "LogIn")

            If ds.Tables("LogIn").Rows.Count <> 0 Then
                'Play Login Sound
                My.Computer.Audio.Play(Application.StartupPath + "\Sounds\login.Wav")
                MaximizeBox = True
                MinimizeBox = True
                '- MyBase.Hide()
                MsgBox("Hello! " + strName + vbNewLine +
                       "Log in successful", MsgBoxStyle.OkOnly,
                       "Welcome " + strName)
                MainScreen.Show()
            Else
                MaximizeBox = False
                MinimizeBox = False
                attempt = attempt +
                MsgBox("Oop! --> " & strName & "  _&_  " & strPass + vbNewLine + vbNewLine + _
                       "The username or password yor entered" + vbNewLine + _
                       "is not valid." + vbNewLine + _
                       "Please try again", MsgBoxStyle.Exclamation, "Invalid")
            End If
        End If

        If attempt = 3 Then
            MsgBox("Application is shutting down...", MsgBoxStyle.Critical, "Good bye sir!")
            Me.Close()
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        If objCon.State = ConnectionState.Open Then
            objCon.Close()
            '-----MsgBox("Good bye sir" + vbNewLine + _
            '-----"ConnectionState.Closed", MsgBoxStyle.Information, "Thank you for watching") Comment Line
        End If

        Dim msg As String = "Do you want to Exit?"
        Dim title As String = "Exit Application"
        Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNoCancel
        Dim icons As MessageBoxIcon = MessageBoxIcon.Exclamation
        Dim result As DialogResult = MessageBox.Show(msg, title, buttons, icons, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            'Play Exit Sound
            '     My.Computer.Audio.Play(Application.StartupPath + "\Sounds\error.Wav")
            MessageBox.Show("Thank you for using." + vbNewLine + _
                             "Exit Application Confirm")
            Me.Close()
        ElseIf result = DialogResult.No Then
            MsgBox("No Pressed", CType(MsgBoxStyle.Information & MsgBoxStyle.OkOnly, MsgBoxStyle), "No Button")
        Else
            MsgBox("Cancel Pressed", CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle), "Cancel Button")
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        MinimizeBox = False
        txtUsername.MaxLength = 10
        txtPassword.MaxLength = 10
        SplashScreen.Timer1.Enabled = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Add_User.Show()
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
      
    End Sub
End Class
