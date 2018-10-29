<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Audit2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Audit2))
        Me.AuditHdr = New System.Windows.Forms.Label()
        Me.PDWrite = New System.Windows.Forms.Button()
        Me.Audit2DataGridview = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.WRVUPatientDetailAuditBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WRVUPatientDetailAuditTableAdapter = New MonthEnd.DataSet1TableAdapters.wRVUPatientDetailAuditTableAdapter()
        Me.ProviderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientcountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WRVUsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkingLbl = New System.Windows.Forms.Label()
        CType(Me.Audit2DataGridview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WRVUPatientDetailAuditBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AuditHdr
        '
        Me.AuditHdr.BackColor = System.Drawing.Color.Transparent
        Me.AuditHdr.Font = New System.Drawing.Font("Monotype Corsiva", 32.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuditHdr.ForeColor = System.Drawing.Color.White
        Me.AuditHdr.Location = New System.Drawing.Point(468, 109)
        Me.AuditHdr.Name = "AuditHdr"
        Me.AuditHdr.Size = New System.Drawing.Size(284, 62)
        Me.AuditHdr.TabIndex = 3
        Me.AuditHdr.Text = "Audit Processing"
        '
        'PDWrite
        '
        Me.PDWrite.BackColor = System.Drawing.Color.Transparent
        Me.PDWrite.BackgroundImage = CType(resources.GetObject("PDWrite.BackgroundImage"), System.Drawing.Image)
        Me.PDWrite.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PDWrite.ForeColor = System.Drawing.Color.Red
        Me.PDWrite.Location = New System.Drawing.Point(889, 175)
        Me.PDWrite.Name = "PDWrite"
        Me.PDWrite.Size = New System.Drawing.Size(127, 35)
        Me.PDWrite.TabIndex = 8
        Me.PDWrite.Text = "WriteDetail"
        Me.PDWrite.UseVisualStyleBackColor = False
        '
        'Audit2DataGridview
        '
        Me.Audit2DataGridview.AutoGenerateColumns = False
        Me.Audit2DataGridview.BackgroundColor = System.Drawing.Color.White
        Me.Audit2DataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Audit2DataGridview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProviderDataGridViewTextBoxColumn, Me.FacilityDataGridViewTextBoxColumn, Me.PatientcountDataGridViewTextBoxColumn, Me.WRVUsDataGridViewTextBoxColumn})
        Me.Audit2DataGridview.DataSource = Me.WRVUPatientDetailAuditBindingSource
        Me.Audit2DataGridview.Location = New System.Drawing.Point(212, 215)
        Me.Audit2DataGridview.Name = "Audit2DataGridview"
        Me.Audit2DataGridview.Size = New System.Drawing.Size(841, 414)
        Me.Audit2DataGridview.TabIndex = 9
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
        'ProviderDataGridViewTextBoxColumn
        '
        Me.ProviderDataGridViewTextBoxColumn.DataPropertyName = "provider"
        Me.ProviderDataGridViewTextBoxColumn.HeaderText = "provider"
        Me.ProviderDataGridViewTextBoxColumn.Name = "ProviderDataGridViewTextBoxColumn"
        Me.ProviderDataGridViewTextBoxColumn.Width = 200
        '
        'FacilityDataGridViewTextBoxColumn
        '
        Me.FacilityDataGridViewTextBoxColumn.DataPropertyName = "facility"
        Me.FacilityDataGridViewTextBoxColumn.HeaderText = "facility"
        Me.FacilityDataGridViewTextBoxColumn.Name = "FacilityDataGridViewTextBoxColumn"
        Me.FacilityDataGridViewTextBoxColumn.Width = 400
        '
        'PatientcountDataGridViewTextBoxColumn
        '
        Me.PatientcountDataGridViewTextBoxColumn.DataPropertyName = "patientcount"
        Me.PatientcountDataGridViewTextBoxColumn.HeaderText = "patientcount"
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
        'WorkingLbl
        '
        Me.WorkingLbl.AutoSize = True
        Me.WorkingLbl.BackColor = System.Drawing.Color.Transparent
        Me.WorkingLbl.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingLbl.ForeColor = System.Drawing.Color.White
        Me.WorkingLbl.Location = New System.Drawing.Point(228, 185)
        Me.WorkingLbl.Name = "WorkingLbl"
        Me.WorkingLbl.Size = New System.Drawing.Size(103, 22)
        Me.WorkingLbl.TabIndex = 10
        Me.WorkingLbl.Text = "Working....."
        '
        'Audit2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.WorkingLbl)
        Me.Controls.Add(Me.Audit2DataGridview)
        Me.Controls.Add(Me.PDWrite)
        Me.Controls.Add(Me.AuditHdr)
        Me.Name = "Audit2"
        Me.Text = "Audit2"
        CType(Me.Audit2DataGridview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WRVUPatientDetailAuditBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AuditHdr As Label
    Friend WithEvents PDWrite As Button
    Friend WithEvents Audit2DataGridview As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents WRVUPatientDetailAuditBindingSource As BindingSource
    Friend WithEvents WRVUPatientDetailAuditTableAdapter As DataSet1TableAdapters.wRVUPatientDetailAuditTableAdapter
    Friend WithEvents ProviderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacilityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientcountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WRVUsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WorkingLbl As Label
End Class
