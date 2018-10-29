<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProvidersIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProvidersIn))
        Me.ProcHdr = New System.Windows.Forms.Label()
        Me.PrInDataGridView = New System.Windows.Forms.DataGridView()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvideridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonlastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonfirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HealthcarecertificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatagroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RptsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportemailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReporttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProvidersInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.ProvidersInTableAdapter = New MonthEnd.DataSet1TableAdapters.ProvidersInTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveCurrentProvidersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProvidersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProviderAttributesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddReportTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPtroviderReports2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PrInDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvidersInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProcHdr
        '
        Me.ProcHdr.BackColor = System.Drawing.Color.Transparent
        Me.ProcHdr.Font = New System.Drawing.Font("Monotype Corsiva", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcHdr.ForeColor = System.Drawing.Color.White
        Me.ProcHdr.Location = New System.Drawing.Point(501, 106)
        Me.ProcHdr.Name = "ProcHdr"
        Me.ProcHdr.Size = New System.Drawing.Size(263, 62)
        Me.ProcHdr.TabIndex = 2
        Me.ProcHdr.Text = "NewProviders"
        '
        'PrInDataGridView
        '
        Me.PrInDataGridView.AutoGenerateColumns = False
        Me.PrInDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.PrInDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrInDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.PersonidDataGridViewTextBoxColumn, Me.ProvideridDataGridViewTextBoxColumn, Me.PersonlastnameDataGridViewTextBoxColumn, Me.PersonfirstnameDataGridViewTextBoxColumn, Me.HealthcarecertificationDataGridViewTextBoxColumn, Me.DatagroupDataGridViewTextBoxColumn, Me.RptsDataGridViewTextBoxColumn, Me.PersonnameDataGridViewTextBoxColumn, Me.ReportnameDataGridViewTextBoxColumn, Me.ReportemailDataGridViewTextBoxColumn, Me.ReporttypeDataGridViewTextBoxColumn, Me.SelectDataGridViewCheckBoxColumn})
        Me.PrInDataGridView.DataSource = Me.ProvidersInBindingSource
        Me.PrInDataGridView.Location = New System.Drawing.Point(58, 161)
        Me.PrInDataGridView.Name = "PrInDataGridView"
        Me.PrInDataGridView.Size = New System.Drawing.Size(1322, 468)
        Me.PrInDataGridView.TabIndex = 3
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PersonidDataGridViewTextBoxColumn
        '
        Me.PersonidDataGridViewTextBoxColumn.DataPropertyName = "person_id"
        Me.PersonidDataGridViewTextBoxColumn.HeaderText = "person_id"
        Me.PersonidDataGridViewTextBoxColumn.Name = "PersonidDataGridViewTextBoxColumn"
        '
        'ProvideridDataGridViewTextBoxColumn
        '
        Me.ProvideridDataGridViewTextBoxColumn.DataPropertyName = "provider_id"
        Me.ProvideridDataGridViewTextBoxColumn.HeaderText = "provider_id"
        Me.ProvideridDataGridViewTextBoxColumn.Name = "ProvideridDataGridViewTextBoxColumn"
        '
        'PersonlastnameDataGridViewTextBoxColumn
        '
        Me.PersonlastnameDataGridViewTextBoxColumn.DataPropertyName = "person_lastname"
        Me.PersonlastnameDataGridViewTextBoxColumn.HeaderText = "person_lastname"
        Me.PersonlastnameDataGridViewTextBoxColumn.Name = "PersonlastnameDataGridViewTextBoxColumn"
        '
        'PersonfirstnameDataGridViewTextBoxColumn
        '
        Me.PersonfirstnameDataGridViewTextBoxColumn.DataPropertyName = "person_firstname"
        Me.PersonfirstnameDataGridViewTextBoxColumn.HeaderText = "person_firstname"
        Me.PersonfirstnameDataGridViewTextBoxColumn.Name = "PersonfirstnameDataGridViewTextBoxColumn"
        '
        'HealthcarecertificationDataGridViewTextBoxColumn
        '
        Me.HealthcarecertificationDataGridViewTextBoxColumn.DataPropertyName = "healthcare_certification"
        Me.HealthcarecertificationDataGridViewTextBoxColumn.HeaderText = "certification"
        Me.HealthcarecertificationDataGridViewTextBoxColumn.Name = "HealthcarecertificationDataGridViewTextBoxColumn"
        Me.HealthcarecertificationDataGridViewTextBoxColumn.Width = 75
        '
        'DatagroupDataGridViewTextBoxColumn
        '
        Me.DatagroupDataGridViewTextBoxColumn.DataPropertyName = "datagroup"
        Me.DatagroupDataGridViewTextBoxColumn.HeaderText = "datagroup"
        Me.DatagroupDataGridViewTextBoxColumn.Name = "DatagroupDataGridViewTextBoxColumn"
        '
        'RptsDataGridViewTextBoxColumn
        '
        Me.RptsDataGridViewTextBoxColumn.DataPropertyName = "rpts"
        Me.RptsDataGridViewTextBoxColumn.HeaderText = "rpts"
        Me.RptsDataGridViewTextBoxColumn.Name = "RptsDataGridViewTextBoxColumn"
        '
        'PersonnameDataGridViewTextBoxColumn
        '
        Me.PersonnameDataGridViewTextBoxColumn.DataPropertyName = "person_name"
        Me.PersonnameDataGridViewTextBoxColumn.HeaderText = "person_name"
        Me.PersonnameDataGridViewTextBoxColumn.Name = "PersonnameDataGridViewTextBoxColumn"
        '
        'ReportnameDataGridViewTextBoxColumn
        '
        Me.ReportnameDataGridViewTextBoxColumn.DataPropertyName = "reportname"
        Me.ReportnameDataGridViewTextBoxColumn.HeaderText = "reportname"
        Me.ReportnameDataGridViewTextBoxColumn.Name = "ReportnameDataGridViewTextBoxColumn"
        '
        'ReportemailDataGridViewTextBoxColumn
        '
        Me.ReportemailDataGridViewTextBoxColumn.DataPropertyName = "reportemail"
        Me.ReportemailDataGridViewTextBoxColumn.HeaderText = "reportemail"
        Me.ReportemailDataGridViewTextBoxColumn.Name = "ReportemailDataGridViewTextBoxColumn"
        '
        'ReporttypeDataGridViewTextBoxColumn
        '
        Me.ReporttypeDataGridViewTextBoxColumn.DataPropertyName = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.HeaderText = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.Name = "ReporttypeDataGridViewTextBoxColumn"
        '
        'SelectDataGridViewCheckBoxColumn
        '
        Me.SelectDataGridViewCheckBoxColumn.DataPropertyName = "select"
        Me.SelectDataGridViewCheckBoxColumn.HeaderText = "select"
        Me.SelectDataGridViewCheckBoxColumn.Name = "SelectDataGridViewCheckBoxColumn"
        '
        'ProvidersInBindingSource
        '
        Me.ProvidersInBindingSource.DataMember = "ProvidersIn"
        Me.ProvidersInBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProvidersInTableAdapter
        '
        Me.ProvidersInTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1441, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveCurrentProvidersToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.AddProvidersToolStripMenuItem, Me.AddProviderAttributesToolStripMenuItem, Me.AddReportTypeToolStripMenuItem, Me.AddPtroviderReports2ToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RemoveCurrentProvidersToolStripMenuItem
        '
        Me.RemoveCurrentProvidersToolStripMenuItem.Name = "RemoveCurrentProvidersToolStripMenuItem"
        Me.RemoveCurrentProvidersToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.RemoveCurrentProvidersToolStripMenuItem.Text = "RemoveCurrentProviders"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'AddProvidersToolStripMenuItem
        '
        Me.AddProvidersToolStripMenuItem.Name = "AddProvidersToolStripMenuItem"
        Me.AddProvidersToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AddProvidersToolStripMenuItem.Text = "AddProviders"
        '
        'AddProviderAttributesToolStripMenuItem
        '
        Me.AddProviderAttributesToolStripMenuItem.Name = "AddProviderAttributesToolStripMenuItem"
        Me.AddProviderAttributesToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AddProviderAttributesToolStripMenuItem.Text = "AddProviderAttributes"
        '
        'AddReportTypeToolStripMenuItem
        '
        Me.AddReportTypeToolStripMenuItem.Name = "AddReportTypeToolStripMenuItem"
        Me.AddReportTypeToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AddReportTypeToolStripMenuItem.Text = "AddReportType"
        '
        'AddPtroviderReports2ToolStripMenuItem
        '
        Me.AddPtroviderReports2ToolStripMenuItem.Name = "AddPtroviderReports2ToolStripMenuItem"
        Me.AddPtroviderReports2ToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AddPtroviderReports2ToolStripMenuItem.Text = "AddPtroviderReports2"
        '
        'ProvidersIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1441, 641)
        Me.Controls.Add(Me.PrInDataGridView)
        Me.Controls.Add(Me.ProcHdr)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ProvidersIn"
        Me.Text = "ProvidersIn"
        CType(Me.PrInDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvidersInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProcHdr As Label
    Friend WithEvents PrInDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ProvidersInBindingSource As BindingSource
    Friend WithEvents ProvidersInTableAdapter As DataSet1TableAdapters.ProvidersInTableAdapter
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvideridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonlastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonfirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HealthcarecertificationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatagroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RptsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportemailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReporttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SelectDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddProvidersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddReportTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveCurrentProvidersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddProviderAttributesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPtroviderReports2ToolStripMenuItem As ToolStripMenuItem
End Class
