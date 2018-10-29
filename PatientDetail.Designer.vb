<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WorkLbl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorkLbl))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PDHdr = New System.Windows.Forms.Label()
        Me.PDWrite = New System.Windows.Forms.Button()
        Me.PatientDetailDataGrid = New System.Windows.Forms.DataGridView()
        Me.ProviderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientcountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WRVUsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WRVUPatientDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.WRVUPatientDetailTableAdapter = New MonthEnd.DataSet1TableAdapters.wRVUPatientDetailTableAdapter()
        Me.WorkingLbl = New System.Windows.Forms.Label()
        Me.datagroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PatientDetailDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WRVUPatientDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PDHdr
        '
        Me.PDHdr.BackColor = System.Drawing.Color.Transparent
        Me.PDHdr.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PDHdr.ForeColor = System.Drawing.Color.White
        Me.PDHdr.Location = New System.Drawing.Point(464, 117)
        Me.PDHdr.Name = "PDHdr"
        Me.PDHdr.Size = New System.Drawing.Size(317, 62)
        Me.PDHdr.TabIndex = 2
        Me.PDHdr.Text = "Patient Detail"
        '
        'PDWrite
        '
        Me.PDWrite.BackColor = System.Drawing.Color.Transparent
        Me.PDWrite.BackgroundImage = CType(resources.GetObject("PDWrite.BackgroundImage"), System.Drawing.Image)
        Me.PDWrite.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PDWrite.ForeColor = System.Drawing.Color.Red
        Me.PDWrite.Location = New System.Drawing.Point(935, 190)
        Me.PDWrite.Name = "PDWrite"
        Me.PDWrite.Size = New System.Drawing.Size(127, 35)
        Me.PDWrite.TabIndex = 4
        Me.PDWrite.Text = "WriteDetail"
        Me.PDWrite.UseVisualStyleBackColor = False
        '
        'PatientDetailDataGrid
        '
        Me.PatientDetailDataGrid.AllowUserToAddRows = False
        Me.PatientDetailDataGrid.AllowUserToDeleteRows = False
        Me.PatientDetailDataGrid.AutoGenerateColumns = False
        Me.PatientDetailDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.PatientDetailDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDetailDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProviderDataGridViewTextBoxColumn, Me.FacilityDataGridViewTextBoxColumn, Me.PatientcountDataGridViewTextBoxColumn, Me.WRVUsDataGridViewTextBoxColumn, Me.datagroup})
        Me.PatientDetailDataGrid.DataSource = Me.WRVUPatientDetailBindingSource
        Me.PatientDetailDataGrid.Location = New System.Drawing.Point(222, 231)
        Me.PatientDetailDataGrid.Name = "PatientDetailDataGrid"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.PatientDetailDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.PatientDetailDataGrid.Size = New System.Drawing.Size(847, 340)
        Me.PatientDetailDataGrid.TabIndex = 5
        '
        'ProviderDataGridViewTextBoxColumn
        '
        Me.ProviderDataGridViewTextBoxColumn.DataPropertyName = "provider"
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ProviderDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ProviderDataGridViewTextBoxColumn.HeaderText = "provider"
        Me.ProviderDataGridViewTextBoxColumn.Name = "ProviderDataGridViewTextBoxColumn"
        Me.ProviderDataGridViewTextBoxColumn.Width = 200
        '
        'FacilityDataGridViewTextBoxColumn
        '
        Me.FacilityDataGridViewTextBoxColumn.DataPropertyName = "facility"
        Me.FacilityDataGridViewTextBoxColumn.HeaderText = "facility"
        Me.FacilityDataGridViewTextBoxColumn.Name = "FacilityDataGridViewTextBoxColumn"
        Me.FacilityDataGridViewTextBoxColumn.Width = 300
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
        'WRVUPatientDetailBindingSource
        '
        Me.WRVUPatientDetailBindingSource.DataMember = "wRVUPatientDetail"
        Me.WRVUPatientDetailBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WRVUPatientDetailTableAdapter
        '
        Me.WRVUPatientDetailTableAdapter.ClearBeforeFill = True
        '
        'WorkingLbl
        '
        Me.WorkingLbl.AutoSize = True
        Me.WorkingLbl.BackColor = System.Drawing.Color.Transparent
        Me.WorkingLbl.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingLbl.Location = New System.Drawing.Point(236, 204)
        Me.WorkingLbl.Name = "WorkingLbl"
        Me.WorkingLbl.Size = New System.Drawing.Size(103, 22)
        Me.WorkingLbl.TabIndex = 6
        Me.WorkingLbl.Text = "Working....."
        '
        'datagroup
        '
        Me.datagroup.DataPropertyName = "datagroup"
        Me.datagroup.HeaderText = "datagroup"
        Me.datagroup.Name = "datagroup"
        '
        'WorkLbl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.WorkingLbl)
        Me.Controls.Add(Me.PatientDetailDataGrid)
        Me.Controls.Add(Me.PDWrite)
        Me.Controls.Add(Me.PDHdr)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Name = "WorkLbl"
        Me.Text = "Patient Detail "
        CType(Me.PatientDetailDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WRVUPatientDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PDHdr As Label
    Friend WithEvents PDWrite As Button
    Friend WithEvents PatientDetailDataGrid As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents WRVUPatientDetailBindingSource As BindingSource
    Friend WithEvents WRVUPatientDetailTableAdapter As DataSet1TableAdapters.wRVUPatientDetailTableAdapter
    Friend WithEvents ProviderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacilityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientcountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WRVUsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WorkingLbl As Label
    Friend WithEvents datagroup As DataGridViewTextBoxColumn
End Class
