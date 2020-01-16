<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteRecord))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CriminalRecordNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfArrestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameOfCriminalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressOfCriminalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OffenceOfCriminalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesignationOfCriminalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConfessionOfCriminalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActionAgainstCriminalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhotoOfCriminalDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.FingerprintOfCriminalDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CriminalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Criminal_DatabaseDataSet5 = New Crime_File_System.Criminal_DatabaseDataSet5()
        Me.CriminalTableAdapter = New Crime_File_System.Criminal_DatabaseDataSet5TableAdapters.CriminalTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriminalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Criminal_DatabaseDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CriminalRecordNoDataGridViewTextBoxColumn, Me.DateOfArrestDataGridViewTextBoxColumn, Me.NameOfCriminalDataGridViewTextBoxColumn, Me.AddressOfCriminalDataGridViewTextBoxColumn, Me.OffenceOfCriminalDataGridViewTextBoxColumn, Me.DesignationOfCriminalDataGridViewTextBoxColumn, Me.ConfessionOfCriminalDataGridViewTextBoxColumn, Me.ActionAgainstCriminalDataGridViewTextBoxColumn, Me.PhotoOfCriminalDataGridViewImageColumn, Me.FingerprintOfCriminalDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.CriminalBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(628, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'CriminalRecordNoDataGridViewTextBoxColumn
        '
        Me.CriminalRecordNoDataGridViewTextBoxColumn.DataPropertyName = "CriminalRecordNo"
        Me.CriminalRecordNoDataGridViewTextBoxColumn.HeaderText = "CriminalRecordNo"
        Me.CriminalRecordNoDataGridViewTextBoxColumn.Name = "CriminalRecordNoDataGridViewTextBoxColumn"
        '
        'DateOfArrestDataGridViewTextBoxColumn
        '
        Me.DateOfArrestDataGridViewTextBoxColumn.DataPropertyName = "Date of Arrest"
        Me.DateOfArrestDataGridViewTextBoxColumn.HeaderText = "Date of Arrest"
        Me.DateOfArrestDataGridViewTextBoxColumn.Name = "DateOfArrestDataGridViewTextBoxColumn"
        '
        'NameOfCriminalDataGridViewTextBoxColumn
        '
        Me.NameOfCriminalDataGridViewTextBoxColumn.DataPropertyName = "Name of Criminal"
        Me.NameOfCriminalDataGridViewTextBoxColumn.HeaderText = "Name of Criminal"
        Me.NameOfCriminalDataGridViewTextBoxColumn.Name = "NameOfCriminalDataGridViewTextBoxColumn"
        '
        'AddressOfCriminalDataGridViewTextBoxColumn
        '
        Me.AddressOfCriminalDataGridViewTextBoxColumn.DataPropertyName = "Address of Criminal"
        Me.AddressOfCriminalDataGridViewTextBoxColumn.HeaderText = "Address of Criminal"
        Me.AddressOfCriminalDataGridViewTextBoxColumn.Name = "AddressOfCriminalDataGridViewTextBoxColumn"
        '
        'OffenceOfCriminalDataGridViewTextBoxColumn
        '
        Me.OffenceOfCriminalDataGridViewTextBoxColumn.DataPropertyName = "Offence of Criminal"
        Me.OffenceOfCriminalDataGridViewTextBoxColumn.HeaderText = "Offence of Criminal"
        Me.OffenceOfCriminalDataGridViewTextBoxColumn.Name = "OffenceOfCriminalDataGridViewTextBoxColumn"
        '
        'DesignationOfCriminalDataGridViewTextBoxColumn
        '
        Me.DesignationOfCriminalDataGridViewTextBoxColumn.DataPropertyName = "Designation of Criminal"
        Me.DesignationOfCriminalDataGridViewTextBoxColumn.HeaderText = "Designation of Criminal"
        Me.DesignationOfCriminalDataGridViewTextBoxColumn.Name = "DesignationOfCriminalDataGridViewTextBoxColumn"
        '
        'ConfessionOfCriminalDataGridViewTextBoxColumn
        '
        Me.ConfessionOfCriminalDataGridViewTextBoxColumn.DataPropertyName = "Confession of Criminal"
        Me.ConfessionOfCriminalDataGridViewTextBoxColumn.HeaderText = "Confession of Criminal"
        Me.ConfessionOfCriminalDataGridViewTextBoxColumn.Name = "ConfessionOfCriminalDataGridViewTextBoxColumn"
        '
        'ActionAgainstCriminalDataGridViewTextBoxColumn
        '
        Me.ActionAgainstCriminalDataGridViewTextBoxColumn.DataPropertyName = "Action against Criminal"
        Me.ActionAgainstCriminalDataGridViewTextBoxColumn.HeaderText = "Action against Criminal"
        Me.ActionAgainstCriminalDataGridViewTextBoxColumn.Name = "ActionAgainstCriminalDataGridViewTextBoxColumn"
        '
        'PhotoOfCriminalDataGridViewImageColumn
        '
        Me.PhotoOfCriminalDataGridViewImageColumn.DataPropertyName = "Photo of Criminal"
        Me.PhotoOfCriminalDataGridViewImageColumn.HeaderText = "Photo of Criminal"
        Me.PhotoOfCriminalDataGridViewImageColumn.Name = "PhotoOfCriminalDataGridViewImageColumn"
        '
        'FingerprintOfCriminalDataGridViewImageColumn
        '
        Me.FingerprintOfCriminalDataGridViewImageColumn.DataPropertyName = "Fingerprint of Criminal"
        Me.FingerprintOfCriminalDataGridViewImageColumn.HeaderText = "Fingerprint of Criminal"
        Me.FingerprintOfCriminalDataGridViewImageColumn.Name = "FingerprintOfCriminalDataGridViewImageColumn"
        '
        'CriminalBindingSource
        '
        Me.CriminalBindingSource.DataMember = "Criminal"
        Me.CriminalBindingSource.DataSource = Me.Criminal_DatabaseDataSet5
        '
        'Criminal_DatabaseDataSet5
        '
        Me.Criminal_DatabaseDataSet5.DataSetName = "Criminal_DatabaseDataSet5"
        Me.Criminal_DatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CriminalTableAdapter
        '
        Me.CriminalTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(444, 239)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter the Criminal Record number :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(251, 291)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 43)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Salmon
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 40)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Criminal Records"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(610, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'DeleteRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 346)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DeleteRecord"
        Me.Text = "DeleteRecord"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriminalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Criminal_DatabaseDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Criminal_DatabaseDataSet5 As Crime_File_System.Criminal_DatabaseDataSet5
    Friend WithEvents CriminalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CriminalTableAdapter As Crime_File_System.Criminal_DatabaseDataSet5TableAdapters.CriminalTableAdapter
    Friend WithEvents CriminalRecordNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfArrestDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameOfCriminalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressOfCriminalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OffenceOfCriminalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesignationOfCriminalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfessionOfCriminalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActionAgainstCriminalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhotoOfCriminalDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents FingerprintOfCriminalDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
