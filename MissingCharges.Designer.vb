<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MissingCharges
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MissingCharges))
        Me.MissingChargesHdr = New System.Windows.Forms.Label()
        Me.StartDtTxt = New System.Windows.Forms.TextBox()
        Me.StartDtLbl = New System.Windows.Forms.Label()
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.MissingChargesTableAdapter = New MonthEnd.DataSet1TableAdapters.MissingChargesTableAdapter()
        Me.EndDtLbl = New System.Windows.Forms.Label()
        Me.EndDtTxt = New System.Windows.Forms.TextBox()
        Me.GoBtn = New System.Windows.Forms.Button()
        Me.WriteBtn = New System.Windows.Forms.Button()
        Me.WorkingLbl = New System.Windows.Forms.Label()
        Me.MissingChargesDataGridView = New System.Windows.Forms.DataGridView()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DischargedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DispositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MissingChargesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RetrieveLbl = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MissingChargesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MissingChargesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MissingChargesHdr
        '
        Me.MissingChargesHdr.BackColor = System.Drawing.Color.Transparent
        Me.MissingChargesHdr.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MissingChargesHdr.ForeColor = System.Drawing.Color.White
        Me.MissingChargesHdr.Location = New System.Drawing.Point(444, 116)
        Me.MissingChargesHdr.Name = "MissingChargesHdr"
        Me.MissingChargesHdr.Size = New System.Drawing.Size(317, 62)
        Me.MissingChargesHdr.TabIndex = 4
        Me.MissingChargesHdr.Text = "Missing Charges"
        '
        'StartDtTxt
        '
        Me.StartDtTxt.Location = New System.Drawing.Point(607, 190)
        Me.StartDtTxt.Name = "StartDtTxt"
        Me.StartDtTxt.Size = New System.Drawing.Size(100, 20)
        Me.StartDtTxt.TabIndex = 5
        '
        'StartDtLbl
        '
        Me.StartDtLbl.AutoSize = True
        Me.StartDtLbl.BackColor = System.Drawing.Color.Transparent
        Me.StartDtLbl.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDtLbl.ForeColor = System.Drawing.Color.White
        Me.StartDtLbl.Location = New System.Drawing.Point(428, 192)
        Me.StartDtLbl.Name = "StartDtLbl"
        Me.StartDtLbl.Size = New System.Drawing.Size(173, 18)
        Me.StartDtLbl.TabIndex = 6
        Me.StartDtLbl.Text = "Start Date for Patient Search"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MissingChargesTableAdapter
        '
        Me.MissingChargesTableAdapter.ClearBeforeFill = True
        '
        'EndDtLbl
        '
        Me.EndDtLbl.AutoSize = True
        Me.EndDtLbl.BackColor = System.Drawing.Color.Transparent
        Me.EndDtLbl.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDtLbl.ForeColor = System.Drawing.Color.White
        Me.EndDtLbl.Location = New System.Drawing.Point(428, 210)
        Me.EndDtLbl.Name = "EndDtLbl"
        Me.EndDtLbl.Size = New System.Drawing.Size(170, 18)
        Me.EndDtLbl.TabIndex = 9
        Me.EndDtLbl.Text = "End Date for Patient Search"
        '
        'EndDtTxt
        '
        Me.EndDtTxt.Location = New System.Drawing.Point(607, 208)
        Me.EndDtTxt.Name = "EndDtTxt"
        Me.EndDtTxt.Size = New System.Drawing.Size(100, 20)
        Me.EndDtTxt.TabIndex = 8
        '
        'GoBtn
        '
        Me.GoBtn.BackColor = System.Drawing.Color.Transparent
        Me.GoBtn.BackgroundImage = CType(resources.GetObject("GoBtn.BackgroundImage"), System.Drawing.Image)
        Me.GoBtn.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GoBtn.Location = New System.Drawing.Point(713, 190)
        Me.GoBtn.Name = "GoBtn"
        Me.GoBtn.Size = New System.Drawing.Size(75, 38)
        Me.GoBtn.TabIndex = 10
        Me.GoBtn.Text = "Go!"
        Me.GoBtn.UseVisualStyleBackColor = False
        '
        'WriteBtn
        '
        Me.WriteBtn.BackColor = System.Drawing.Color.Transparent
        Me.WriteBtn.BackgroundImage = CType(resources.GetObject("WriteBtn.BackgroundImage"), System.Drawing.Image)
        Me.WriteBtn.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WriteBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WriteBtn.Location = New System.Drawing.Point(964, 225)
        Me.WriteBtn.Name = "WriteBtn"
        Me.WriteBtn.Size = New System.Drawing.Size(189, 36)
        Me.WriteBtn.TabIndex = 11
        Me.WriteBtn.Text = "Write/Send/Result"
        Me.WriteBtn.UseVisualStyleBackColor = False
        '
        'WorkingLbl
        '
        Me.WorkingLbl.AutoSize = True
        Me.WorkingLbl.BackColor = System.Drawing.Color.Transparent
        Me.WorkingLbl.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingLbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WorkingLbl.Location = New System.Drawing.Point(151, 239)
        Me.WorkingLbl.Name = "WorkingLbl"
        Me.WorkingLbl.Size = New System.Drawing.Size(76, 22)
        Me.WorkingLbl.TabIndex = 12
        Me.WorkingLbl.Text = "Done....."
        '
        'MissingChargesDataGridView
        '
        Me.MissingChargesDataGridView.AutoGenerateColumns = False
        Me.MissingChargesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MissingChargesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MissingChargesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DischargedDataGridViewTextBoxColumn, Me.DispositionDataGridViewTextBoxColumn, Me.StartDtDataGridViewTextBoxColumn, Me.EndDtDataGridViewTextBoxColumn})
        Me.MissingChargesDataGridView.DataSource = Me.MissingChargesBindingSource
        Me.MissingChargesDataGridView.Location = New System.Drawing.Point(105, 264)
        Me.MissingChargesDataGridView.Name = "MissingChargesDataGridView"
        Me.MissingChargesDataGridView.Size = New System.Drawing.Size(1103, 304)
        Me.MissingChargesDataGridView.TabIndex = 13
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Account"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Account"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Patient"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Patient"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DOS"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DOS"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DischargedDataGridViewTextBoxColumn
        '
        Me.DischargedDataGridViewTextBoxColumn.DataPropertyName = "Discharged"
        Me.DischargedDataGridViewTextBoxColumn.HeaderText = "Discharged"
        Me.DischargedDataGridViewTextBoxColumn.Name = "DischargedDataGridViewTextBoxColumn"
        '
        'DispositionDataGridViewTextBoxColumn
        '
        Me.DispositionDataGridViewTextBoxColumn.DataPropertyName = "Disposition"
        Me.DispositionDataGridViewTextBoxColumn.HeaderText = "Disposition"
        Me.DispositionDataGridViewTextBoxColumn.Name = "DispositionDataGridViewTextBoxColumn"
        '
        'StartDtDataGridViewTextBoxColumn
        '
        Me.StartDtDataGridViewTextBoxColumn.DataPropertyName = "StartDt"
        Me.StartDtDataGridViewTextBoxColumn.HeaderText = "StartDate"
        Me.StartDtDataGridViewTextBoxColumn.Name = "StartDtDataGridViewTextBoxColumn"
        '
        'EndDtDataGridViewTextBoxColumn
        '
        Me.EndDtDataGridViewTextBoxColumn.DataPropertyName = "EndDt"
        Me.EndDtDataGridViewTextBoxColumn.HeaderText = "EndDate"
        Me.EndDtDataGridViewTextBoxColumn.Name = "EndDtDataGridViewTextBoxColumn"
        '
        'MissingChargesBindingSource
        '
        Me.MissingChargesBindingSource.DataMember = "MissingCharges"
        Me.MissingChargesBindingSource.DataSource = Me.DataSet1
        '
        'RetrieveLbl
        '
        Me.RetrieveLbl.AutoSize = True
        Me.RetrieveLbl.BackColor = System.Drawing.Color.Transparent
        Me.RetrieveLbl.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetrieveLbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RetrieveLbl.Location = New System.Drawing.Point(427, 239)
        Me.RetrieveLbl.Name = "RetrieveLbl"
        Me.RetrieveLbl.Size = New System.Drawing.Size(229, 18)
        Me.RetrieveLbl.TabIndex = 14
        Me.RetrieveLbl.Text = "Retrieving the data may take a minute"
        '
        'MissingCharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.RetrieveLbl)
        Me.Controls.Add(Me.MissingChargesDataGridView)
        Me.Controls.Add(Me.WorkingLbl)
        Me.Controls.Add(Me.WriteBtn)
        Me.Controls.Add(Me.GoBtn)
        Me.Controls.Add(Me.EndDtLbl)
        Me.Controls.Add(Me.EndDtTxt)
        Me.Controls.Add(Me.StartDtLbl)
        Me.Controls.Add(Me.StartDtTxt)
        Me.Controls.Add(Me.MissingChargesHdr)
        Me.Name = "MissingCharges"
        Me.Text = "MissingCharges"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MissingChargesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MissingChargesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MissingChargesHdr As Label
    Friend WithEvents StartDtTxt As TextBox
    Friend WithEvents StartDtLbl As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents MissingChargesTableAdapter As DataSet1TableAdapters.MissingChargesTableAdapter
    Friend WithEvents AccountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DischgdtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DispDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndDtLbl As Label
    Friend WithEvents EndDtTxt As TextBox
    Friend WithEvents GoBtn As Button
    Friend WithEvents WriteBtn As Button
    Friend WithEvents WorkingLbl As Label
    Friend WithEvents MissingChargesDataGridView As DataGridView
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DischargedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DispositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartDtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndDtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MissingChargesBindingSource As BindingSource
    Friend WithEvents RetrieveLbl As Label
End Class
