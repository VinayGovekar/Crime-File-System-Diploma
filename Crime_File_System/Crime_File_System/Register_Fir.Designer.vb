<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_Fir
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
        Dim FIR_NumberLabel As System.Windows.Forms.Label
        Dim ActLabel As System.Windows.Forms.Label
        Dim DistrictLabel As System.Windows.Forms.Label
        Dim Date_of_FIR_registrationLabel As System.Windows.Forms.Label
        Dim Name_of_InformerLabel As System.Windows.Forms.Label
        Dim Address_of_InformerLabel As System.Windows.Forms.Label
        Dim Place_of_IncidentLabel As System.Windows.Forms.Label
        Dim FIR_DetailsLabel As System.Windows.Forms.Label
        Dim Name_of_CriminalLabel As System.Windows.Forms.Label
        Dim Address_of_CriminalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register_Fir))
        Me.FIR_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Fir_TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Fir_DatabaseDataSet = New Crime_File_System.Fir_DatabaseDataSet()
        Me.ActTextBox = New System.Windows.Forms.TextBox()
        Me.DistrictTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_FIR_registrationDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Name_of_InformerTextBox = New System.Windows.Forms.TextBox()
        Me.Address_of_InformerTextBox = New System.Windows.Forms.TextBox()
        Me.Place_of_IncidentTextBox = New System.Windows.Forms.TextBox()
        Me.FIR_DetailsTextBox = New System.Windows.Forms.TextBox()
        Me.Name_of_CriminalTextBox = New System.Windows.Forms.TextBox()
        Me.Address_of_CriminalTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Addbutton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Fir_TableTableAdapter = New Crime_File_System.Fir_DatabaseDataSetTableAdapters.Fir_TableTableAdapter()
        Me.TableAdapterManager = New Crime_File_System.Fir_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        FIR_NumberLabel = New System.Windows.Forms.Label()
        ActLabel = New System.Windows.Forms.Label()
        DistrictLabel = New System.Windows.Forms.Label()
        Date_of_FIR_registrationLabel = New System.Windows.Forms.Label()
        Name_of_InformerLabel = New System.Windows.Forms.Label()
        Address_of_InformerLabel = New System.Windows.Forms.Label()
        Place_of_IncidentLabel = New System.Windows.Forms.Label()
        FIR_DetailsLabel = New System.Windows.Forms.Label()
        Name_of_CriminalLabel = New System.Windows.Forms.Label()
        Address_of_CriminalLabel = New System.Windows.Forms.Label()
        CType(Me.Fir_TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fir_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FIR_NumberLabel
        '
        FIR_NumberLabel.AutoSize = True
        FIR_NumberLabel.BackColor = System.Drawing.Color.Transparent
        FIR_NumberLabel.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FIR_NumberLabel.Location = New System.Drawing.Point(4, 22)
        FIR_NumberLabel.Name = "FIR_NumberLabel"
        FIR_NumberLabel.Size = New System.Drawing.Size(70, 14)
        FIR_NumberLabel.TabIndex = 1
        FIR_NumberLabel.Text = "FIR Number:"
        AddHandler FIR_NumberLabel.Click, AddressOf Me.FIR_NumberLabel_Click
        '
        'ActLabel
        '
        ActLabel.AutoSize = True
        ActLabel.BackColor = System.Drawing.Color.Transparent
        ActLabel.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ActLabel.Location = New System.Drawing.Point(4, 48)
        ActLabel.Name = "ActLabel"
        ActLabel.Size = New System.Drawing.Size(26, 14)
        ActLabel.TabIndex = 3
        ActLabel.Text = "Act:"
        AddHandler ActLabel.Click, AddressOf Me.ActLabel_Click
        '
        'DistrictLabel
        '
        DistrictLabel.AutoSize = True
        DistrictLabel.BackColor = System.Drawing.Color.Transparent
        DistrictLabel.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DistrictLabel.Location = New System.Drawing.Point(4, 74)
        DistrictLabel.Name = "DistrictLabel"
        DistrictLabel.Size = New System.Drawing.Size(46, 14)
        DistrictLabel.TabIndex = 5
        DistrictLabel.Text = "District:"
        AddHandler DistrictLabel.Click, AddressOf Me.DistrictLabel_Click
        '
        'Date_of_FIR_registrationLabel
        '
        Date_of_FIR_registrationLabel.AutoSize = True
        Date_of_FIR_registrationLabel.BackColor = System.Drawing.Color.Transparent
        Date_of_FIR_registrationLabel.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_FIR_registrationLabel.Location = New System.Drawing.Point(4, 101)
        Date_of_FIR_registrationLabel.Name = "Date_of_FIR_registrationLabel"
        Date_of_FIR_registrationLabel.Size = New System.Drawing.Size(125, 14)
        Date_of_FIR_registrationLabel.TabIndex = 7
        Date_of_FIR_registrationLabel.Text = "Date of FIR registration:"
        AddHandler Date_of_FIR_registrationLabel.Click, AddressOf Me.Date_of_FIR_registrationLabel_Click
        '
        'Name_of_InformerLabel
        '
        Name_of_InformerLabel.AutoSize = True
        Name_of_InformerLabel.BackColor = System.Drawing.Color.Transparent
        Name_of_InformerLabel.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_of_InformerLabel.Location = New System.Drawing.Point(4, 126)
        Name_of_InformerLabel.Name = "Name_of_InformerLabel"
        Name_of_InformerLabel.Size = New System.Drawing.Size(98, 14)
        Name_of_InformerLabel.TabIndex = 9
        Name_of_InformerLabel.Text = "Name of Informer:"
        AddHandler Name_of_InformerLabel.Click, AddressOf Me.Name_of_InformerLabel_Click
        '
        'Address_of_InformerLabel
        '
        Address_of_InformerLabel.AutoSize = True
        Address_of_InformerLabel.BackColor = System.Drawing.Color.Transparent
        Address_of_InformerLabel.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Address_of_InformerLabel.Location = New System.Drawing.Point(4, 152)
        Address_of_InformerLabel.Name = "Address_of_InformerLabel"
        Address_of_InformerLabel.Size = New System.Drawing.Size(109, 14)
        Address_of_InformerLabel.TabIndex = 11
        Address_of_InformerLabel.Text = "Address of Informer:"
        AddHandler Address_of_InformerLabel.Click, AddressOf Me.Address_of_InformerLabel_Click
        '
        'Place_of_IncidentLabel
        '
        Place_of_IncidentLabel.AutoSize = True
        Place_of_IncidentLabel.BackColor = System.Drawing.Color.Transparent
        Place_of_IncidentLabel.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Place_of_IncidentLabel.Location = New System.Drawing.Point(4, 231)
        Place_of_IncidentLabel.Name = "Place_of_IncidentLabel"
        Place_of_IncidentLabel.Size = New System.Drawing.Size(92, 14)
        Place_of_IncidentLabel.TabIndex = 13
        Place_of_IncidentLabel.Text = "Place of Incident:"
        AddHandler Place_of_IncidentLabel.Click, AddressOf Me.Place_of_IncidentLabel_Click
        '
        'FIR_DetailsLabel
        '
        FIR_DetailsLabel.AutoSize = True
        FIR_DetailsLabel.BackColor = System.Drawing.Color.Transparent
        FIR_DetailsLabel.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FIR_DetailsLabel.Location = New System.Drawing.Point(4, 257)
        FIR_DetailsLabel.Name = "FIR_DetailsLabel"
        FIR_DetailsLabel.Size = New System.Drawing.Size(63, 14)
        FIR_DetailsLabel.TabIndex = 15
        FIR_DetailsLabel.Text = "FIR Details:"
        AddHandler FIR_DetailsLabel.Click, AddressOf Me.FIR_DetailsLabel_Click
        '
        'Name_of_CriminalLabel
        '
        Name_of_CriminalLabel.AutoSize = True
        Name_of_CriminalLabel.BackColor = System.Drawing.Color.Transparent
        Name_of_CriminalLabel.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_of_CriminalLabel.Location = New System.Drawing.Point(4, 332)
        Name_of_CriminalLabel.Name = "Name_of_CriminalLabel"
        Name_of_CriminalLabel.Size = New System.Drawing.Size(97, 14)
        Name_of_CriminalLabel.TabIndex = 17
        Name_of_CriminalLabel.Text = "Name of Criminal:"
        AddHandler Name_of_CriminalLabel.Click, AddressOf Me.Name_of_CriminalLabel_Click
        '
        'Address_of_CriminalLabel
        '
        Address_of_CriminalLabel.AutoSize = True
        Address_of_CriminalLabel.BackColor = System.Drawing.Color.Transparent
        Address_of_CriminalLabel.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Address_of_CriminalLabel.Location = New System.Drawing.Point(4, 358)
        Address_of_CriminalLabel.Name = "Address_of_CriminalLabel"
        Address_of_CriminalLabel.Size = New System.Drawing.Size(108, 14)
        Address_of_CriminalLabel.TabIndex = 19
        Address_of_CriminalLabel.Text = "Address of Criminal:"
        AddHandler Address_of_CriminalLabel.Click, AddressOf Me.Address_of_CriminalLabel_Click
        '
        'FIR_NumberTextBox
        '
        Me.FIR_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fir_TableBindingSource, "FIR Number", True))
        Me.FIR_NumberTextBox.Location = New System.Drawing.Point(142, 72)
        Me.FIR_NumberTextBox.Name = "FIR_NumberTextBox"
        Me.FIR_NumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FIR_NumberTextBox.TabIndex = 2
        '
        'Fir_TableBindingSource
        '
        Me.Fir_TableBindingSource.DataMember = "Fir_Table"
        Me.Fir_TableBindingSource.DataSource = Me.Fir_DatabaseDataSet
        '
        'Fir_DatabaseDataSet
        '
        Me.Fir_DatabaseDataSet.DataSetName = "Fir_DatabaseDataSet"
        Me.Fir_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActTextBox
        '
        Me.ActTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fir_TableBindingSource, "Act", True))
        Me.ActTextBox.Location = New System.Drawing.Point(142, 98)
        Me.ActTextBox.Name = "ActTextBox"
        Me.ActTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ActTextBox.TabIndex = 4
        '
        'DistrictTextBox
        '
        Me.DistrictTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fir_TableBindingSource, "District", True))
        Me.DistrictTextBox.Location = New System.Drawing.Point(142, 124)
        Me.DistrictTextBox.Name = "DistrictTextBox"
        Me.DistrictTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DistrictTextBox.TabIndex = 6
        '
        'Date_of_FIR_registrationDateTimePicker
        '
        Me.Date_of_FIR_registrationDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Fir_TableBindingSource, "Date of FIR registration", True))
        Me.Date_of_FIR_registrationDateTimePicker.Location = New System.Drawing.Point(142, 150)
        Me.Date_of_FIR_registrationDateTimePicker.Name = "Date_of_FIR_registrationDateTimePicker"
        Me.Date_of_FIR_registrationDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_of_FIR_registrationDateTimePicker.TabIndex = 8
        '
        'Name_of_InformerTextBox
        '
        Me.Name_of_InformerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fir_TableBindingSource, "Name of Informer", True))
        Me.Name_of_InformerTextBox.Location = New System.Drawing.Point(142, 176)
        Me.Name_of_InformerTextBox.Name = "Name_of_InformerTextBox"
        Me.Name_of_InformerTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Name_of_InformerTextBox.TabIndex = 10
        '
        'Address_of_InformerTextBox
        '
        Me.Address_of_InformerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fir_TableBindingSource, "Address of Informer", True))
        Me.Address_of_InformerTextBox.Location = New System.Drawing.Point(142, 202)
        Me.Address_of_InformerTextBox.Multiline = True
        Me.Address_of_InformerTextBox.Name = "Address_of_InformerTextBox"
        Me.Address_of_InformerTextBox.Size = New System.Drawing.Size(200, 73)
        Me.Address_of_InformerTextBox.TabIndex = 12
        '
        'Place_of_IncidentTextBox
        '
        Me.Place_of_IncidentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fir_TableBindingSource, "Place of Incident", True))
        Me.Place_of_IncidentTextBox.Location = New System.Drawing.Point(142, 281)
        Me.Place_of_IncidentTextBox.Name = "Place_of_IncidentTextBox"
        Me.Place_of_IncidentTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Place_of_IncidentTextBox.TabIndex = 14
        '
        'FIR_DetailsTextBox
        '
        Me.FIR_DetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fir_TableBindingSource, "FIR Details", True))
        Me.FIR_DetailsTextBox.Location = New System.Drawing.Point(142, 307)
        Me.FIR_DetailsTextBox.Multiline = True
        Me.FIR_DetailsTextBox.Name = "FIR_DetailsTextBox"
        Me.FIR_DetailsTextBox.Size = New System.Drawing.Size(200, 69)
        Me.FIR_DetailsTextBox.TabIndex = 16
        '
        'Name_of_CriminalTextBox
        '
        Me.Name_of_CriminalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fir_TableBindingSource, "Name of Criminal", True))
        Me.Name_of_CriminalTextBox.Location = New System.Drawing.Point(142, 382)
        Me.Name_of_CriminalTextBox.Name = "Name_of_CriminalTextBox"
        Me.Name_of_CriminalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Name_of_CriminalTextBox.TabIndex = 18
        '
        'Address_of_CriminalTextBox
        '
        Me.Address_of_CriminalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fir_TableBindingSource, "Address of Criminal", True))
        Me.Address_of_CriminalTextBox.Location = New System.Drawing.Point(142, 408)
        Me.Address_of_CriminalTextBox.Multiline = True
        Me.Address_of_CriminalTextBox.Name = "Address_of_CriminalTextBox"
        Me.Address_of_CriminalTextBox.Size = New System.Drawing.Size(200, 53)
        Me.Address_of_CriminalTextBox.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 39)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "FIR Registration"
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(108, 432)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(74, 31)
        Me.SaveButton.TabIndex = 23
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Addbutton
        '
        Me.Addbutton.Location = New System.Drawing.Point(227, 433)
        Me.Addbutton.Name = "Addbutton"
        Me.Addbutton.Size = New System.Drawing.Size(74, 31)
        Me.Addbutton.TabIndex = 25
        Me.Addbutton.Text = "Add New"
        Me.Addbutton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RosyBrown
        Me.Label2.Location = New System.Drawing.Point(490, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 39)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "First"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RosyBrown
        Me.Label3.Location = New System.Drawing.Point(435, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 39)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RosyBrown
        Me.Label4.Location = New System.Drawing.Point(471, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 39)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Report"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(389, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(257, 275)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Date_of_FIR_registrationLabel)
        Me.Panel1.Controls.Add(Address_of_CriminalLabel)
        Me.Panel1.Controls.Add(Me.SaveButton)
        Me.Panel1.Controls.Add(Me.Addbutton)
        Me.Panel1.Controls.Add(Name_of_CriminalLabel)
        Me.Panel1.Controls.Add(FIR_DetailsLabel)
        Me.Panel1.Controls.Add(Place_of_IncidentLabel)
        Me.Panel1.Controls.Add(Address_of_InformerLabel)
        Me.Panel1.Controls.Add(FIR_NumberLabel)
        Me.Panel1.Controls.Add(Name_of_InformerLabel)
        Me.Panel1.Controls.Add(DistrictLabel)
        Me.Panel1.Controls.Add(ActLabel)
        Me.Panel1.Location = New System.Drawing.Point(13, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 470)
        Me.Panel1.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(339, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 31)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Fir_TableTableAdapter
        '
        Me.Fir_TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Fir_TableTableAdapter = Me.Fir_TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = Crime_File_System.Fir_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(645, 23)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 31
        Me.PictureBox3.TabStop = False
        '
        'Register_Fir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(687, 530)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FIR_NumberTextBox)
        Me.Controls.Add(Me.ActTextBox)
        Me.Controls.Add(Me.DistrictTextBox)
        Me.Controls.Add(Me.Date_of_FIR_registrationDateTimePicker)
        Me.Controls.Add(Me.Name_of_InformerTextBox)
        Me.Controls.Add(Me.Address_of_InformerTextBox)
        Me.Controls.Add(Me.Place_of_IncidentTextBox)
        Me.Controls.Add(Me.FIR_DetailsTextBox)
        Me.Controls.Add(Me.Name_of_CriminalTextBox)
        Me.Controls.Add(Me.Address_of_CriminalTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Register_Fir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register_Fir"
        CType(Me.Fir_TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fir_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Fir_DatabaseDataSet As Crime_File_System.Fir_DatabaseDataSet
    Friend WithEvents Fir_TableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Fir_TableTableAdapter As Crime_File_System.Fir_DatabaseDataSetTableAdapters.Fir_TableTableAdapter
    Friend WithEvents TableAdapterManager As Crime_File_System.Fir_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FIR_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ActTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DistrictTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_FIR_registrationDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Name_of_InformerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Address_of_InformerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Place_of_IncidentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FIR_DetailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_of_CriminalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Address_of_CriminalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Addbutton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
