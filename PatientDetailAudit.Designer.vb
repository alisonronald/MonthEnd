<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientDetailAudit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientDetailAudit))
        Me.ProcHdr = New System.Windows.Forms.Label()
        Me.WorkingLbl = New System.Windows.Forms.Label()
        Me.PDWrite = New System.Windows.Forms.Button()
        Me.PatientDetailAuditDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.WRVUPatientDetailAuditBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WRVUPatientDetailAuditTableAdapter = New MonthEnd.DataSet1TableAdapters.wRVUPatientDetailAuditTableAdapter()
        Me.Group = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provider = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Facility = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientcountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WRVUsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PatientDetailAuditDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WRVUPatientDetailAuditBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProcHdr
        '
        Me.ProcHdr.BackColor = System.Drawing.Color.Transparent
        Me.ProcHdr.Font = New System.Drawing.Font("Monotype Corsiva", 32.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcHdr.ForeColor = System.Drawing.Color.White
        Me.ProcHdr.Location = New System.Drawing.Point(430, 104)
        Me.ProcHdr.Name = "ProcHdr"
        Me.ProcHdr.Size = New System.Drawing.Size(414, 62)
        Me.ProcHdr.TabIndex = 2
        Me.ProcHdr.Text = "PatientDetailAudit"
        '
        'WorkingLbl
        '
        Me.WorkingLbl.AutoSize = True
        Me.WorkingLbl.BackColor = System.Drawing.Color.Transparent
        Me.WorkingLbl.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingLbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WorkingLbl.Location = New System.Drawing.Point(200, 196)
        Me.WorkingLbl.Name = "WorkingLbl"
        Me.WorkingLbl.Size = New System.Drawing.Size(103, 22)
        Me.WorkingLbl.TabIndex = 8
        Me.WorkingLbl.Text = "Working....."
        '
        'PDWrite
        '
        Me.PDWrite.BackColor = System.Drawing.Color.Transparent
        Me.PDWrite.BackgroundImage = CType(resources.GetObject("PDWrite.BackgroundImage"), System.Drawing.Image)
        Me.PDWrite.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PDWrite.ForeColor = System.Drawing.Color.Red
        Me.PDWrite.Location = New System.Drawing.Point(986, 183)
        Me.PDWrite.Name = "PDWrite"
        Me.PDWrite.Size = New System.Drawing.Size(127, 35)
        Me.PDWrite.TabIndex = 7
        Me.PDWrite.Text = "WriteDetail"
        Me.PDWrite.UseVisualStyleBackColor = False
        '
        'PatientDetailAuditDataGridView
        '
        Me.PatientDetailAuditDataGridView.AutoGenerateColumns = False
        Me.PatientDetailAuditDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PatientDetailAuditDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDetailAuditDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Group, Me.Provider, Me.Facility, Me.PatientcountDataGridViewTextBoxColumn, Me.WRVUsDataGridViewTextBoxColumn})
        Me.PatientDetailAuditDataGridView.DataSource = Me.WRVUPatientDetailAuditBindingSource
        Me.PatientDetailAuditDataGridView.Location = New System.Drawing.Point(179, 221)
        Me.PatientDetailAuditDataGridView.Name = "PatientDetailAuditDataGridView"
        Me.PatientDetailAuditDataGridView.Size = New System.Drawing.Size(944, 408)
        Me.PatientDetailAuditDataGridView.TabIndex = 9
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WRVUPatientDetailAuditBindingSource
        '
        Me.WRVUPatientDetailAuditBindingSource.DataMember = "wRVUPatientDetailAudit"
        Me.WRVUPatientDetailAuditBindingSource.DataSource = Me.DataSet1
        '
        'WRVUPatientDetailAuditTableAdapter
        '
        Me.WRVUPatientDetailAuditTableAdapter.ClearBeforeFill = True
        '
        'Group
        '
        Me.Group.DataPropertyName = "Group"
        Me.Group.HeaderText = "Group"
        Me.Group.Name = "Group"
        '
        'Provider
        '
        Me.Provider.DataPropertyName = "Provider"
        Me.Provider.HeaderText = "Provider"
        Me.Provider.Name = "Provider"
        Me.Provider.Width = 200
        '
        'Facility
        '
        Me.Facility.DataPropertyName = "Facility"
        Me.Facility.HeaderText = "Facility"
        Me.Facility.Name = "Facility"
        Me.Facility.Width = 400
        '
        'PatientcountDataGridViewTextBoxColumn
        '
        Me.PatientcountDataGridViewTextBoxColumn.DataPropertyName = "patientcount"
        Me.PatientcountDataGridViewTextBoxColumn.HeaderText = "PatientCount"
        Me.PatientcountDataGridViewTextBoxColumn.Name = "PatientcountDataGridViewTextBoxColumn"
        Me.PatientcountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WRVUsDataGridViewTextBoxColumn
        '
        Me.WRVUsDataGridViewTextBoxColumn.DataPropertyName = "wRVUs"
        Me.WRVUsDataGridViewTextBoxColumn.HeaderText = "wRVUs"
        Me.WRVUsDataGridViewTextBoxColumn.Name = "WRVUsDataGridViewTextBoxColumn"
        Me.WRVUsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PatientDetailAudit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.PatientDetailAuditDataGridView)
        Me.Controls.Add(Me.WorkingLbl)
        Me.Controls.Add(Me.PDWrite)
        Me.Controls.Add(Me.ProcHdr)
        Me.Name = "PatientDetailAudit"
        Me.Text = "PatientDetailAudit"
        CType(Me.PatientDetailAuditDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WRVUPatientDetailAuditBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProcHdr As Label
    Friend WithEvents WorkingLbl As Label
    Friend WithEvents PDWrite As Button
    Friend WithEvents PatientDetailAuditDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents WRVUPatientDetailAuditBindingSource As BindingSource
    Friend WithEvents WRVUPatientDetailAuditTableAdapter As DataSet1TableAdapters.wRVUPatientDetailAuditTableAdapter
    Friend WithEvents ProviderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacilityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Group As DataGridViewTextBoxColumn
    Friend WithEvents Provider As DataGridViewTextBoxColumn
    Friend WithEvents Facility As DataGridViewTextBoxColumn
    Friend WithEvents PatientcountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WRVUsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
