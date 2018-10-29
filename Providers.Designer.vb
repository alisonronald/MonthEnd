<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Providers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Providers))
        Me.ProvHdr = New System.Windows.Forms.Label()
        Me.ProvidersDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProvidersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.ProvidersTableAdapter = New MonthEnd.DataSet1TableAdapters.ProvidersTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProviderReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateProvidersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvideridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.provideremail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HealthcareidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CertificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveproviderDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.OnstaffproviderDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DatagroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportsDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ProvidersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvidersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProvHdr
        '
        Me.ProvHdr.BackColor = System.Drawing.Color.Transparent
        Me.ProvHdr.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvHdr.ForeColor = System.Drawing.Color.White
        Me.ProvHdr.Location = New System.Drawing.Point(432, 116)
        Me.ProvHdr.Name = "ProvHdr"
        Me.ProvHdr.Size = New System.Drawing.Size(414, 62)
        Me.ProvHdr.TabIndex = 2
        Me.ProvHdr.Text = "Maintain Providers"
        '
        'ProvidersDataGridView
        '
        Me.ProvidersDataGridView.AutoGenerateColumns = False
        Me.ProvidersDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.ProvidersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProvidersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.PersonidDataGridViewTextBoxColumn, Me.ProvideridDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.firstname, Me.provideremail, Me.HealthcareidDataGridViewTextBoxColumn, Me.CertificationDataGridViewTextBoxColumn, Me.ActiveproviderDataGridViewCheckBoxColumn, Me.OnstaffproviderDataGridViewCheckBoxColumn, Me.DatagroupDataGridViewTextBoxColumn, Me.ReportsDataGridViewCheckBoxColumn, Me.CommentDataGridViewTextBoxColumn})
        Me.ProvidersDataGridView.DataSource = Me.ProvidersBindingSource
        Me.ProvidersDataGridView.Location = New System.Drawing.Point(12, 181)
        Me.ProvidersDataGridView.Name = "ProvidersDataGridView"
        Me.ProvidersDataGridView.Size = New System.Drawing.Size(1280, 387)
        Me.ProvidersDataGridView.TabIndex = 3
        '
        'ProvidersBindingSource
        '
        Me.ProvidersBindingSource.DataMember = "Providers"
        Me.ProvidersBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProvidersTableAdapter
        '
        Me.ProvidersTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProviderReportsToolStripMenuItem, Me.UpdateProvidersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProviderReportsToolStripMenuItem
        '
        Me.ProviderReportsToolStripMenuItem.Name = "ProviderReportsToolStripMenuItem"
        Me.ProviderReportsToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.ProviderReportsToolStripMenuItem.Text = "NewProviders"
        '
        'UpdateProvidersToolStripMenuItem
        '
        Me.UpdateProvidersToolStripMenuItem.Name = "UpdateProvidersToolStripMenuItem"
        Me.UpdateProvidersToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.UpdateProvidersToolStripMenuItem.Text = "UpdateProviders"
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecordidDataGridViewTextBoxColumn.Width = 40
        '
        'PersonidDataGridViewTextBoxColumn
        '
        Me.PersonidDataGridViewTextBoxColumn.DataPropertyName = "personid"
        Me.PersonidDataGridViewTextBoxColumn.HeaderText = "personid"
        Me.PersonidDataGridViewTextBoxColumn.Name = "PersonidDataGridViewTextBoxColumn"
        Me.PersonidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProvideridDataGridViewTextBoxColumn
        '
        Me.ProvideridDataGridViewTextBoxColumn.DataPropertyName = "providerid"
        Me.ProvideridDataGridViewTextBoxColumn.HeaderText = "providerid"
        Me.ProvideridDataGridViewTextBoxColumn.Name = "ProvideridDataGridViewTextBoxColumn"
        Me.ProvideridDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'firstname
        '
        Me.firstname.DataPropertyName = "firstname"
        Me.firstname.HeaderText = "firstname"
        Me.firstname.Name = "firstname"
        '
        'provideremail
        '
        Me.provideremail.DataPropertyName = "provideremail"
        Me.provideremail.HeaderText = "provideremail"
        Me.provideremail.Name = "provideremail"
        Me.provideremail.Width = 150
        '
        'HealthcareidDataGridViewTextBoxColumn
        '
        Me.HealthcareidDataGridViewTextBoxColumn.DataPropertyName = "healthcareid"
        Me.HealthcareidDataGridViewTextBoxColumn.HeaderText = "healthcareid"
        Me.HealthcareidDataGridViewTextBoxColumn.Name = "HealthcareidDataGridViewTextBoxColumn"
        Me.HealthcareidDataGridViewTextBoxColumn.ReadOnly = True
        Me.HealthcareidDataGridViewTextBoxColumn.Visible = False
        Me.HealthcareidDataGridViewTextBoxColumn.Width = 75
        '
        'CertificationDataGridViewTextBoxColumn
        '
        Me.CertificationDataGridViewTextBoxColumn.DataPropertyName = "certification"
        Me.CertificationDataGridViewTextBoxColumn.HeaderText = "cert"
        Me.CertificationDataGridViewTextBoxColumn.Name = "CertificationDataGridViewTextBoxColumn"
        Me.CertificationDataGridViewTextBoxColumn.ReadOnly = True
        Me.CertificationDataGridViewTextBoxColumn.Width = 50
        '
        'ActiveproviderDataGridViewCheckBoxColumn
        '
        Me.ActiveproviderDataGridViewCheckBoxColumn.DataPropertyName = "activeprovider"
        Me.ActiveproviderDataGridViewCheckBoxColumn.HeaderText = "active"
        Me.ActiveproviderDataGridViewCheckBoxColumn.Name = "ActiveproviderDataGridViewCheckBoxColumn"
        Me.ActiveproviderDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ActiveproviderDataGridViewCheckBoxColumn.Width = 50
        '
        'OnstaffproviderDataGridViewCheckBoxColumn
        '
        Me.OnstaffproviderDataGridViewCheckBoxColumn.DataPropertyName = "onstaffprovider"
        Me.OnstaffproviderDataGridViewCheckBoxColumn.HeaderText = "onstaff"
        Me.OnstaffproviderDataGridViewCheckBoxColumn.Name = "OnstaffproviderDataGridViewCheckBoxColumn"
        Me.OnstaffproviderDataGridViewCheckBoxColumn.ReadOnly = True
        Me.OnstaffproviderDataGridViewCheckBoxColumn.Width = 50
        '
        'DatagroupDataGridViewTextBoxColumn
        '
        Me.DatagroupDataGridViewTextBoxColumn.DataPropertyName = "datagroup"
        Me.DatagroupDataGridViewTextBoxColumn.HeaderText = "datagroup"
        Me.DatagroupDataGridViewTextBoxColumn.Name = "DatagroupDataGridViewTextBoxColumn"
        Me.DatagroupDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReportsDataGridViewCheckBoxColumn
        '
        Me.ReportsDataGridViewCheckBoxColumn.DataPropertyName = "reports"
        Me.ReportsDataGridViewCheckBoxColumn.HeaderText = "rprts"
        Me.ReportsDataGridViewCheckBoxColumn.Name = "ReportsDataGridViewCheckBoxColumn"
        Me.ReportsDataGridViewCheckBoxColumn.Width = 30
        '
        'CommentDataGridViewTextBoxColumn
        '
        Me.CommentDataGridViewTextBoxColumn.DataPropertyName = "comment"
        Me.CommentDataGridViewTextBoxColumn.HeaderText = "comment"
        Me.CommentDataGridViewTextBoxColumn.Name = "CommentDataGridViewTextBoxColumn"
        Me.CommentDataGridViewTextBoxColumn.Width = 395
        '
        'Providers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.ProvidersDataGridView)
        Me.Controls.Add(Me.ProvHdr)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Providers"
        Me.Text = "Providers"
        CType(Me.ProvidersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvidersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProvHdr As Label
    Friend WithEvents ProvidersDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ProvidersBindingSource As BindingSource
    Friend WithEvents ProvidersTableAdapter As DataSet1TableAdapters.ProvidersTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProviderReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateProvidersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvideridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents firstname As DataGridViewTextBoxColumn
    Friend WithEvents provideremail As DataGridViewTextBoxColumn
    Friend WithEvents HealthcareidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CertificationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActiveproviderDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents OnstaffproviderDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DatagroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportsDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
