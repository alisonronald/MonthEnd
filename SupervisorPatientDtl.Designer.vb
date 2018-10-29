<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupervisorPatientDtl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupervisorPatientDtl))
        Me.ProcHdr = New System.Windows.Forms.Label()
        Me.SupervisorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.WRVUSupervisorPatientDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WRVUSupervisorPatientDetailTableAdapter = New MonthEnd.DataSet1TableAdapters.wRVUSupervisorPatientDetailTableAdapter()
        Me.SupervisorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProviderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkingLbl = New System.Windows.Forms.Label()
        Me.SPDWrite = New System.Windows.Forms.Button()
        CType(Me.SupervisorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WRVUSupervisorPatientDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProcHdr
        '
        Me.ProcHdr.BackColor = System.Drawing.Color.Transparent
        Me.ProcHdr.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcHdr.ForeColor = System.Drawing.Color.White
        Me.ProcHdr.Location = New System.Drawing.Point(386, 103)
        Me.ProcHdr.Name = "ProcHdr"
        Me.ProcHdr.Size = New System.Drawing.Size(483, 62)
        Me.ProcHdr.TabIndex = 2
        Me.ProcHdr.Text = "Supervisor/PatientDetail"
        '
        'SupervisorDataGridView
        '
        Me.SupervisorDataGridView.AutoGenerateColumns = False
        Me.SupervisorDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SupervisorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupervisorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupervisorDataGridViewTextBoxColumn, Me.ProviderDataGridViewTextBoxColumn, Me.FacilityDataGridViewTextBoxColumn, Me.Column1DataGridViewTextBoxColumn})
        Me.SupervisorDataGridView.DataSource = Me.WRVUSupervisorPatientDetailBindingSource
        Me.SupervisorDataGridView.Location = New System.Drawing.Point(314, 202)
        Me.SupervisorDataGridView.Name = "SupervisorDataGridView"
        Me.SupervisorDataGridView.Size = New System.Drawing.Size(648, 376)
        Me.SupervisorDataGridView.TabIndex = 3
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WRVUSupervisorPatientDetailBindingSource
        '
        Me.WRVUSupervisorPatientDetailBindingSource.DataMember = "wRVUSupervisorPatientDetail"
        Me.WRVUSupervisorPatientDetailBindingSource.DataSource = Me.DataSet1
        '
        'WRVUSupervisorPatientDetailTableAdapter
        '
        Me.WRVUSupervisorPatientDetailTableAdapter.ClearBeforeFill = True
        '
        'SupervisorDataGridViewTextBoxColumn
        '
        Me.SupervisorDataGridViewTextBoxColumn.DataPropertyName = "supervisor"
        Me.SupervisorDataGridViewTextBoxColumn.HeaderText = "Supervisor"
        Me.SupervisorDataGridViewTextBoxColumn.Name = "SupervisorDataGridViewTextBoxColumn"
        Me.SupervisorDataGridViewTextBoxColumn.Width = 150
        '
        'ProviderDataGridViewTextBoxColumn
        '
        Me.ProviderDataGridViewTextBoxColumn.DataPropertyName = "provider"
        Me.ProviderDataGridViewTextBoxColumn.HeaderText = "Provider"
        Me.ProviderDataGridViewTextBoxColumn.Name = "ProviderDataGridViewTextBoxColumn"
        Me.ProviderDataGridViewTextBoxColumn.Width = 150
        '
        'FacilityDataGridViewTextBoxColumn
        '
        Me.FacilityDataGridViewTextBoxColumn.DataPropertyName = "facility"
        Me.FacilityDataGridViewTextBoxColumn.HeaderText = "Facility"
        Me.FacilityDataGridViewTextBoxColumn.Name = "FacilityDataGridViewTextBoxColumn"
        Me.FacilityDataGridViewTextBoxColumn.Width = 200
        '
        'Column1DataGridViewTextBoxColumn
        '
        Me.Column1DataGridViewTextBoxColumn.DataPropertyName = "Column1"
        Me.Column1DataGridViewTextBoxColumn.HeaderText = "TotalwRVUs"
        Me.Column1DataGridViewTextBoxColumn.Name = "Column1DataGridViewTextBoxColumn"
        Me.Column1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'WorkingLbl
        '
        Me.WorkingLbl.AutoSize = True
        Me.WorkingLbl.BackColor = System.Drawing.Color.Transparent
        Me.WorkingLbl.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingLbl.ForeColor = System.Drawing.Color.White
        Me.WorkingLbl.Location = New System.Drawing.Point(313, 175)
        Me.WorkingLbl.Name = "WorkingLbl"
        Me.WorkingLbl.Size = New System.Drawing.Size(103, 22)
        Me.WorkingLbl.TabIndex = 8
        Me.WorkingLbl.Text = "Working....."
        '
        'SPDWrite
        '
        Me.SPDWrite.BackColor = System.Drawing.Color.Transparent
        Me.SPDWrite.BackgroundImage = CType(resources.GetObject("SPDWrite.BackgroundImage"), System.Drawing.Image)
        Me.SPDWrite.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SPDWrite.ForeColor = System.Drawing.Color.Red
        Me.SPDWrite.Location = New System.Drawing.Point(835, 161)
        Me.SPDWrite.Name = "SPDWrite"
        Me.SPDWrite.Size = New System.Drawing.Size(127, 35)
        Me.SPDWrite.TabIndex = 7
        Me.SPDWrite.Text = "WriteDetail"
        Me.SPDWrite.UseVisualStyleBackColor = False
        '
        'SupervisorPatientDtl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.WorkingLbl)
        Me.Controls.Add(Me.SPDWrite)
        Me.Controls.Add(Me.SupervisorDataGridView)
        Me.Controls.Add(Me.ProcHdr)
        Me.Name = "SupervisorPatientDtl"
        Me.Text = "SupervisorPatientDtl"
        CType(Me.SupervisorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WRVUSupervisorPatientDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProcHdr As Label
    Friend WithEvents SupervisorDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents WRVUSupervisorPatientDetailBindingSource As BindingSource
    Friend WithEvents WRVUSupervisorPatientDetailTableAdapter As DataSet1TableAdapters.wRVUSupervisorPatientDetailTableAdapter
    Friend WithEvents SupervisorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProviderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacilityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WorkingLbl As Label
    Friend WithEvents SPDWrite As Button
End Class
