<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProviderReportsAttributes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProviderReportsAttributes))
        Me.ProvHdr = New System.Windows.Forms.Label()
        Me.ProviderAttributesDataGridView = New System.Windows.Forms.DataGridView()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvideridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PracticenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReporttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reportemail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PdfDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EncryptDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PatientdtlDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TemplateidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProviderreportsattributesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProvidersMissingAttributesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddReportTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProviderreportsattributesTableAdapter = New MonthEnd.DataSet1TableAdapters.providerreportsattributesTableAdapter()
        CType(Me.ProviderAttributesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProviderreportsattributesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProvHdr
        '
        Me.ProvHdr.BackColor = System.Drawing.Color.Transparent
        Me.ProvHdr.Font = New System.Drawing.Font("Monotype Corsiva", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvHdr.ForeColor = System.Drawing.Color.White
        Me.ProvHdr.Location = New System.Drawing.Point(406, 106)
        Me.ProvHdr.Name = "ProvHdr"
        Me.ProvHdr.Size = New System.Drawing.Size(444, 62)
        Me.ProvHdr.TabIndex = 3
        Me.ProvHdr.Text = "ProviderReportAttributes"
        '
        'ProviderAttributesDataGridView
        '
        Me.ProviderAttributesDataGridView.AutoGenerateColumns = False
        Me.ProviderAttributesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ProviderAttributesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProviderAttributesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.ProvideridDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.PracticenameDataGridViewTextBoxColumn, Me.ReporttypeDataGridViewTextBoxColumn, Me.ReportnameDataGridViewTextBoxColumn, Me.reportemail, Me.PdfDataGridViewCheckBoxColumn, Me.EncryptDataGridViewCheckBoxColumn, Me.PatientdtlDataGridViewCheckBoxColumn, Me.TemplateidDataGridViewTextBoxColumn})
        Me.ProviderAttributesDataGridView.DataSource = Me.ProviderreportsattributesBindingSource
        Me.ProviderAttributesDataGridView.Location = New System.Drawing.Point(53, 171)
        Me.ProviderAttributesDataGridView.Name = "ProviderAttributesDataGridView"
        Me.ProviderAttributesDataGridView.Size = New System.Drawing.Size(1197, 458)
        Me.ProviderAttributesDataGridView.TabIndex = 4
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProvideridDataGridViewTextBoxColumn
        '
        Me.ProvideridDataGridViewTextBoxColumn.DataPropertyName = "providerid"
        Me.ProvideridDataGridViewTextBoxColumn.HeaderText = "providerid"
        Me.ProvideridDataGridViewTextBoxColumn.Name = "ProvideridDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'PracticenameDataGridViewTextBoxColumn
        '
        Me.PracticenameDataGridViewTextBoxColumn.DataPropertyName = "practicename"
        Me.PracticenameDataGridViewTextBoxColumn.HeaderText = "practicename"
        Me.PracticenameDataGridViewTextBoxColumn.Name = "PracticenameDataGridViewTextBoxColumn"
        '
        'ReporttypeDataGridViewTextBoxColumn
        '
        Me.ReporttypeDataGridViewTextBoxColumn.DataPropertyName = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.HeaderText = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.Name = "ReporttypeDataGridViewTextBoxColumn"
        '
        'ReportnameDataGridViewTextBoxColumn
        '
        Me.ReportnameDataGridViewTextBoxColumn.DataPropertyName = "reportname"
        Me.ReportnameDataGridViewTextBoxColumn.HeaderText = "reportname"
        Me.ReportnameDataGridViewTextBoxColumn.Name = "ReportnameDataGridViewTextBoxColumn"
        '
        'reportemail
        '
        Me.reportemail.DataPropertyName = "reportemail"
        Me.reportemail.HeaderText = "reportemail"
        Me.reportemail.Name = "reportemail"
        Me.reportemail.Width = 150
        '
        'PdfDataGridViewCheckBoxColumn
        '
        Me.PdfDataGridViewCheckBoxColumn.DataPropertyName = "pdf"
        Me.PdfDataGridViewCheckBoxColumn.HeaderText = "pdf"
        Me.PdfDataGridViewCheckBoxColumn.Name = "PdfDataGridViewCheckBoxColumn"
        Me.PdfDataGridViewCheckBoxColumn.Width = 75
        '
        'EncryptDataGridViewCheckBoxColumn
        '
        Me.EncryptDataGridViewCheckBoxColumn.DataPropertyName = "encrypt"
        Me.EncryptDataGridViewCheckBoxColumn.HeaderText = "encrypt"
        Me.EncryptDataGridViewCheckBoxColumn.Name = "EncryptDataGridViewCheckBoxColumn"
        Me.EncryptDataGridViewCheckBoxColumn.Width = 75
        '
        'PatientdtlDataGridViewCheckBoxColumn
        '
        Me.PatientdtlDataGridViewCheckBoxColumn.DataPropertyName = "patientdtl"
        Me.PatientdtlDataGridViewCheckBoxColumn.HeaderText = "patientdtl"
        Me.PatientdtlDataGridViewCheckBoxColumn.Name = "PatientdtlDataGridViewCheckBoxColumn"
        Me.PatientdtlDataGridViewCheckBoxColumn.Width = 75
        '
        'TemplateidDataGridViewTextBoxColumn
        '
        Me.TemplateidDataGridViewTextBoxColumn.DataPropertyName = "templateid"
        Me.TemplateidDataGridViewTextBoxColumn.HeaderText = "templateid"
        Me.TemplateidDataGridViewTextBoxColumn.Name = "TemplateidDataGridViewTextBoxColumn"
        Me.TemplateidDataGridViewTextBoxColumn.Width = 75
        '
        'ProviderreportsattributesBindingSource
        '
        Me.ProviderreportsattributesBindingSource.DataMember = "providerreportsattributes"
        Me.ProviderreportsattributesBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProvidersMissingAttributesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProvidersMissingAttributesToolStripMenuItem
        '
        Me.ProvidersMissingAttributesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.AddReportTypeToolStripMenuItem})
        Me.ProvidersMissingAttributesToolStripMenuItem.Name = "ProvidersMissingAttributesToolStripMenuItem"
        Me.ProvidersMissingAttributesToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ProvidersMissingAttributesToolStripMenuItem.Text = "File"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'AddReportTypeToolStripMenuItem
        '
        Me.AddReportTypeToolStripMenuItem.Name = "AddReportTypeToolStripMenuItem"
        Me.AddReportTypeToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AddReportTypeToolStripMenuItem.Text = "AddReportType"
        '
        'ProviderreportsattributesTableAdapter
        '
        Me.ProviderreportsattributesTableAdapter.ClearBeforeFill = True
        '
        'ProviderReportsAttributes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.ProviderAttributesDataGridView)
        Me.Controls.Add(Me.ProvHdr)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ProviderReportsAttributes"
        Me.Text = "ProviderReportsAttributes"
        CType(Me.ProviderAttributesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProviderreportsattributesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProvHdr As Label
    Friend WithEvents ProviderAttributesDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ProviderreportsattributesBindingSource As BindingSource
    Friend WithEvents ProviderreportsattributesTableAdapter As DataSet1TableAdapters.providerreportsattributesTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProvidersMissingAttributesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvideridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PracticenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReporttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents reportemail As DataGridViewTextBoxColumn
    Friend WithEvents PdfDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EncryptDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PatientdtlDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TemplateidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddReportTypeToolStripMenuItem As ToolStripMenuItem
End Class
