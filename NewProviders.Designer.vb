<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProviders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewProviders))
        Me.ProcHdr = New System.Windows.Forms.Label()
        Me.ProvidersInDataGridView = New System.Windows.Forms.DataGridView()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvideridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonlastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonfirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HealthcareidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HealthcarecertificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvideractiveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvideronstaffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatagroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RptsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProvidersInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.ProvidersInTableAdapter = New MonthEnd.DataSet1TableAdapters.ProvidersInTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddProvidersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvidersTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProviderReportsAttributesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdLbl = New System.Windows.Forms.Label()
        CType(Me.ProvidersInDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvidersInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProcHdr
        '
        Me.ProcHdr.BackColor = System.Drawing.Color.Transparent
        Me.ProcHdr.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcHdr.ForeColor = System.Drawing.Color.White
        Me.ProcHdr.Location = New System.Drawing.Point(463, 112)
        Me.ProcHdr.Name = "ProcHdr"
        Me.ProcHdr.Size = New System.Drawing.Size(324, 62)
        Me.ProcHdr.TabIndex = 2
        Me.ProcHdr.Text = "Add New Providers"
        '
        'ProvidersInDataGridView
        '
        Me.ProvidersInDataGridView.AllowUserToAddRows = False
        Me.ProvidersInDataGridView.AllowUserToDeleteRows = False
        Me.ProvidersInDataGridView.AutoGenerateColumns = False
        Me.ProvidersInDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ProvidersInDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProvidersInDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.PersonidDataGridViewTextBoxColumn, Me.ProvideridDataGridViewTextBoxColumn, Me.PersonlastnameDataGridViewTextBoxColumn, Me.PersonfirstnameDataGridViewTextBoxColumn, Me.HealthcareidDataGridViewTextBoxColumn, Me.HealthcarecertificationDataGridViewTextBoxColumn, Me.ProvideractiveDataGridViewTextBoxColumn, Me.ProvideronstaffDataGridViewTextBoxColumn, Me.DatagroupDataGridViewTextBoxColumn, Me.RptsDataGridViewTextBoxColumn, Me.PersonnameDataGridViewTextBoxColumn, Me.SelectDataGridViewCheckBoxColumn})
        Me.ProvidersInDataGridView.DataSource = Me.ProvidersInBindingSource
        Me.ProvidersInDataGridView.Location = New System.Drawing.Point(128, 196)
        Me.ProvidersInDataGridView.Name = "ProvidersInDataGridView"
        Me.ProvidersInDataGridView.Size = New System.Drawing.Size(1036, 378)
        Me.ProvidersInDataGridView.TabIndex = 3
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecordidDataGridViewTextBoxColumn.Visible = False
        '
        'PersonidDataGridViewTextBoxColumn
        '
        Me.PersonidDataGridViewTextBoxColumn.DataPropertyName = "person_id"
        Me.PersonidDataGridViewTextBoxColumn.HeaderText = "person_id"
        Me.PersonidDataGridViewTextBoxColumn.Name = "PersonidDataGridViewTextBoxColumn"
        Me.PersonidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProvideridDataGridViewTextBoxColumn
        '
        Me.ProvideridDataGridViewTextBoxColumn.DataPropertyName = "provider_id"
        Me.ProvideridDataGridViewTextBoxColumn.HeaderText = "provider_id"
        Me.ProvideridDataGridViewTextBoxColumn.Name = "ProvideridDataGridViewTextBoxColumn"
        Me.ProvideridDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PersonlastnameDataGridViewTextBoxColumn
        '
        Me.PersonlastnameDataGridViewTextBoxColumn.DataPropertyName = "person_lastname"
        Me.PersonlastnameDataGridViewTextBoxColumn.HeaderText = "person_lastname"
        Me.PersonlastnameDataGridViewTextBoxColumn.Name = "PersonlastnameDataGridViewTextBoxColumn"
        Me.PersonlastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PersonfirstnameDataGridViewTextBoxColumn
        '
        Me.PersonfirstnameDataGridViewTextBoxColumn.DataPropertyName = "person_firstname"
        Me.PersonfirstnameDataGridViewTextBoxColumn.HeaderText = "person_firstname"
        Me.PersonfirstnameDataGridViewTextBoxColumn.Name = "PersonfirstnameDataGridViewTextBoxColumn"
        Me.PersonfirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HealthcareidDataGridViewTextBoxColumn
        '
        Me.HealthcareidDataGridViewTextBoxColumn.DataPropertyName = "healthcare_id"
        Me.HealthcareidDataGridViewTextBoxColumn.HeaderText = "healthcare_id"
        Me.HealthcareidDataGridViewTextBoxColumn.Name = "HealthcareidDataGridViewTextBoxColumn"
        Me.HealthcareidDataGridViewTextBoxColumn.Visible = False
        '
        'HealthcarecertificationDataGridViewTextBoxColumn
        '
        Me.HealthcarecertificationDataGridViewTextBoxColumn.DataPropertyName = "healthcare_certification"
        Me.HealthcarecertificationDataGridViewTextBoxColumn.HeaderText = "certification"
        Me.HealthcarecertificationDataGridViewTextBoxColumn.Name = "HealthcarecertificationDataGridViewTextBoxColumn"
        Me.HealthcarecertificationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProvideractiveDataGridViewTextBoxColumn
        '
        Me.ProvideractiveDataGridViewTextBoxColumn.DataPropertyName = "provider_active"
        Me.ProvideractiveDataGridViewTextBoxColumn.HeaderText = "provider_active"
        Me.ProvideractiveDataGridViewTextBoxColumn.Name = "ProvideractiveDataGridViewTextBoxColumn"
        Me.ProvideractiveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProvideronstaffDataGridViewTextBoxColumn
        '
        Me.ProvideronstaffDataGridViewTextBoxColumn.DataPropertyName = "provider_onstaff"
        Me.ProvideronstaffDataGridViewTextBoxColumn.HeaderText = "provider_onstaff"
        Me.ProvideronstaffDataGridViewTextBoxColumn.Name = "ProvideronstaffDataGridViewTextBoxColumn"
        Me.ProvideronstaffDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatagroupDataGridViewTextBoxColumn
        '
        Me.DatagroupDataGridViewTextBoxColumn.DataPropertyName = "datagroup"
        Me.DatagroupDataGridViewTextBoxColumn.HeaderText = "datagroup"
        Me.DatagroupDataGridViewTextBoxColumn.Name = "DatagroupDataGridViewTextBoxColumn"
        Me.DatagroupDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RptsDataGridViewTextBoxColumn
        '
        Me.RptsDataGridViewTextBoxColumn.DataPropertyName = "rpts"
        Me.RptsDataGridViewTextBoxColumn.HeaderText = "rpts"
        Me.RptsDataGridViewTextBoxColumn.Name = "RptsDataGridViewTextBoxColumn"
        Me.RptsDataGridViewTextBoxColumn.Visible = False
        '
        'PersonnameDataGridViewTextBoxColumn
        '
        Me.PersonnameDataGridViewTextBoxColumn.DataPropertyName = "person_name"
        Me.PersonnameDataGridViewTextBoxColumn.HeaderText = "person_name"
        Me.PersonnameDataGridViewTextBoxColumn.Name = "PersonnameDataGridViewTextBoxColumn"
        Me.PersonnameDataGridViewTextBoxColumn.ReadOnly = True
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
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(1075, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Upd Select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddProvidersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddProvidersToolStripMenuItem
        '
        Me.AddProvidersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProvidersTableToolStripMenuItem, Me.ProviderReportsAttributesToolStripMenuItem})
        Me.AddProvidersToolStripMenuItem.Name = "AddProvidersToolStripMenuItem"
        Me.AddProvidersToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.AddProvidersToolStripMenuItem.Text = "Add Providers"
        '
        'ProvidersTableToolStripMenuItem
        '
        Me.ProvidersTableToolStripMenuItem.Name = "ProvidersTableToolStripMenuItem"
        Me.ProvidersTableToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.ProvidersTableToolStripMenuItem.Text = "Add Providers Table"
        '
        'ProviderReportsAttributesToolStripMenuItem
        '
        Me.ProviderReportsAttributesToolStripMenuItem.Name = "ProviderReportsAttributesToolStripMenuItem"
        Me.ProviderReportsAttributesToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.ProviderReportsAttributesToolStripMenuItem.Text = "Add ProviderReportsAttributes Table"
        '
        'UpdLbl
        '
        Me.UpdLbl.BackColor = System.Drawing.Color.Transparent
        Me.UpdLbl.Font = New System.Drawing.Font("Monotype Corsiva", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdLbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.UpdLbl.Location = New System.Drawing.Point(1157, 161)
        Me.UpdLbl.Name = "UpdLbl"
        Me.UpdLbl.Size = New System.Drawing.Size(100, 35)
        Me.UpdLbl.TabIndex = 6
        Me.UpdLbl.Text = "(Select Provider To Add)"
        '
        'NewProviders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.UpdLbl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProvidersInDataGridView)
        Me.Controls.Add(Me.ProcHdr)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "NewProviders"
        Me.Text = "NewProviders"
        CType(Me.ProvidersInDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvidersInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProcHdr As Label
    Friend WithEvents ProvidersInDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ProvidersInBindingSource As BindingSource
    Friend WithEvents ProvidersInTableAdapter As DataSet1TableAdapters.ProvidersInTableAdapter
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvideridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonlastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonfirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HealthcareidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HealthcarecertificationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvideractiveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvideronstaffDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatagroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RptsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SelectDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddProvidersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProvidersTableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProviderReportsAttributesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdLbl As Label
End Class
