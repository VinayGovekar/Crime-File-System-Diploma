<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainScreen))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FirstInformationReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterFIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewFIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriminalRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCriminalRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCriminalRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCriminalRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FingerprintMatchingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Criminal_DatabaseDataSet4 = New Crime_File_System.Criminal_DatabaseDataSet4()
        Me.CriminalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CriminalTableAdapter = New Crime_File_System.Criminal_DatabaseDataSet4TableAdapters.CriminalTableAdapter()
        Me.Fir_DatabaseDataSet1 = New Crime_File_System.Fir_DatabaseDataSet1()
        Me.FirTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Fir_TableTableAdapter = New Crime_File_System.Fir_DatabaseDataSet1TableAdapters.Fir_TableTableAdapter()
        Me.Login_DatabaseDataSet2 = New Crime_File_System.Login_DatabaseDataSet2()
        Me.LogInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogInTableAdapter = New Crime_File_System.Login_DatabaseDataSet2TableAdapters.LogInTableAdapter()
        Me.CryptographyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Criminal_DatabaseDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriminalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fir_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Login_DatabaseDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstInformationReportToolStripMenuItem, Me.CriminalRecordsToolStripMenuItem, Me.FingerprintMatchingToolStripMenuItem, Me.CryptographyToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FirstInformationReportToolStripMenuItem
        '
        Me.FirstInformationReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterFIRToolStripMenuItem, Me.ViewFIRToolStripMenuItem, Me.DeleteFIRToolStripMenuItem})
        Me.FirstInformationReportToolStripMenuItem.Name = "FirstInformationReportToolStripMenuItem"
        Me.FirstInformationReportToolStripMenuItem.Size = New System.Drawing.Size(145, 20)
        Me.FirstInformationReportToolStripMenuItem.Text = "First Information Report"
        '
        'RegisterFIRToolStripMenuItem
        '
        Me.RegisterFIRToolStripMenuItem.Name = "RegisterFIRToolStripMenuItem"
        Me.RegisterFIRToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.RegisterFIRToolStripMenuItem.Text = "Register FIR"
        '
        'ViewFIRToolStripMenuItem
        '
        Me.ViewFIRToolStripMenuItem.Name = "ViewFIRToolStripMenuItem"
        Me.ViewFIRToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ViewFIRToolStripMenuItem.Text = "View FIR"
        '
        'DeleteFIRToolStripMenuItem
        '
        Me.DeleteFIRToolStripMenuItem.Name = "DeleteFIRToolStripMenuItem"
        Me.DeleteFIRToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.DeleteFIRToolStripMenuItem.Text = "Delete FIR"
        '
        'CriminalRecordsToolStripMenuItem
        '
        Me.CriminalRecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCriminalRecordsToolStripMenuItem, Me.ViewCriminalRecordsToolStripMenuItem, Me.DeleteCriminalRecordsToolStripMenuItem})
        Me.CriminalRecordsToolStripMenuItem.Name = "CriminalRecordsToolStripMenuItem"
        Me.CriminalRecordsToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.CriminalRecordsToolStripMenuItem.Text = "Criminal Records"
        '
        'AddCriminalRecordsToolStripMenuItem
        '
        Me.AddCriminalRecordsToolStripMenuItem.Name = "AddCriminalRecordsToolStripMenuItem"
        Me.AddCriminalRecordsToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AddCriminalRecordsToolStripMenuItem.Text = "Add Criminal Records"
        '
        'ViewCriminalRecordsToolStripMenuItem
        '
        Me.ViewCriminalRecordsToolStripMenuItem.Name = "ViewCriminalRecordsToolStripMenuItem"
        Me.ViewCriminalRecordsToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ViewCriminalRecordsToolStripMenuItem.Text = "View Criminal Records"
        '
        'DeleteCriminalRecordsToolStripMenuItem
        '
        Me.DeleteCriminalRecordsToolStripMenuItem.Name = "DeleteCriminalRecordsToolStripMenuItem"
        Me.DeleteCriminalRecordsToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.DeleteCriminalRecordsToolStripMenuItem.Text = "Delete Criminal Records"
        '
        'FingerprintMatchingToolStripMenuItem
        '
        Me.FingerprintMatchingToolStripMenuItem.Name = "FingerprintMatchingToolStripMenuItem"
        Me.FingerprintMatchingToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.FingerprintMatchingToolStripMenuItem.Text = "Fingerprint Matching"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Salmon
        Me.Label1.Location = New System.Drawing.Point(146, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 46)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Crime File System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(278, 326)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 441)
        Me.Panel1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(470, 419)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Currently Logged In: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(582, 419)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(311, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Label4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(311, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(311, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Label3"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Criminal_DatabaseDataSet4
        '
        Me.Criminal_DatabaseDataSet4.DataSetName = "Criminal_DatabaseDataSet4"
        Me.Criminal_DatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CriminalBindingSource
        '
        Me.CriminalBindingSource.DataMember = "Criminal"
        Me.CriminalBindingSource.DataSource = Me.Criminal_DatabaseDataSet4
        '
        'CriminalTableAdapter
        '
        Me.CriminalTableAdapter.ClearBeforeFill = True
        '
        'Fir_DatabaseDataSet1
        '
        Me.Fir_DatabaseDataSet1.DataSetName = "Fir_DatabaseDataSet1"
        Me.Fir_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FirTableBindingSource
        '
        Me.FirTableBindingSource.DataMember = "Fir_Table"
        Me.FirTableBindingSource.DataSource = Me.Fir_DatabaseDataSet1
        '
        'Fir_TableTableAdapter
        '
        Me.Fir_TableTableAdapter.ClearBeforeFill = True
        '
        'Login_DatabaseDataSet2
        '
        Me.Login_DatabaseDataSet2.DataSetName = "Login_DatabaseDataSet2"
        Me.Login_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LogInBindingSource
        '
        Me.LogInBindingSource.DataMember = "LogIn"
        Me.LogInBindingSource.DataSource = Me.Login_DatabaseDataSet2
        '
        'LogInTableAdapter
        '
        Me.LogInTableAdapter.ClearBeforeFill = True
        '
        'CryptographyToolStripMenuItem
        '
        Me.CryptographyToolStripMenuItem.Name = "CryptographyToolStripMenuItem"
        Me.CryptographyToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.CryptographyToolStripMenuItem.Text = "Cryptography"
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MainScreen"
        Me.Text = "MainScreen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Criminal_DatabaseDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriminalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fir_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Login_DatabaseDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FirstInformationReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterFIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewFIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteFIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CriminalRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCriminalRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCriminalRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FingerprintMatchingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Criminal_DatabaseDataSet4 As Crime_File_System.Criminal_DatabaseDataSet4
    Friend WithEvents CriminalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CriminalTableAdapter As Crime_File_System.Criminal_DatabaseDataSet4TableAdapters.CriminalTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Fir_DatabaseDataSet1 As Crime_File_System.Fir_DatabaseDataSet1
    Friend WithEvents FirTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Fir_TableTableAdapter As Crime_File_System.Fir_DatabaseDataSet1TableAdapters.Fir_TableTableAdapter
    Friend WithEvents Login_DatabaseDataSet2 As Crime_File_System.Login_DatabaseDataSet2
    Friend WithEvents LogInBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LogInTableAdapter As Crime_File_System.Login_DatabaseDataSet2TableAdapters.LogInTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DeleteCriminalRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CryptographyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
