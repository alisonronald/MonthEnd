<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodingProfilesSent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CodingProfilesSent))
        Me.ProviderReportsHdr = New System.Windows.Forms.Label()
        Me.CPSentDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodingProfilesSentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.CodingProfilesSentTableAdapter = New MonthEnd.DataSet1TableAdapters.CodingProfilesSentTableAdapter()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvideridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CertificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PracticenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SendtoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatetosendDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SenddtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CPSentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodingProfilesSentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProviderReportsHdr
        '
        Me.ProviderReportsHdr.BackColor = System.Drawing.Color.Transparent
        Me.ProviderReportsHdr.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProviderReportsHdr.ForeColor = System.Drawing.Color.White
        Me.ProviderReportsHdr.Location = New System.Drawing.Point(449, 114)
        Me.ProviderReportsHdr.Name = "ProviderReportsHdr"
        Me.ProviderReportsHdr.Size = New System.Drawing.Size(336, 62)
        Me.ProviderReportsHdr.TabIndex = 5
        Me.ProviderReportsHdr.Text = "CodingProfilesSent"
        '
        'CPSentDataGridView
        '
        Me.CPSentDataGridView.AutoGenerateColumns = False
        Me.CPSentDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CPSentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CPSentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.ProvideridDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.CertificationDataGridViewTextBoxColumn, Me.PracticenameDataGridViewTextBoxColumn, Me.ReportnameDataGridViewTextBoxColumn, Me.SendtoDataGridViewTextBoxColumn, Me.DatetosendDataGridViewTextBoxColumn, Me.SenddtDataGridViewTextBoxColumn})
        Me.CPSentDataGridView.DataSource = Me.CodingProfilesSentBindingSource
        Me.CPSentDataGridView.Location = New System.Drawing.Point(134, 179)
        Me.CPSentDataGridView.Name = "CPSentDataGridView"
        Me.CPSentDataGridView.Size = New System.Drawing.Size(1044, 391)
        Me.CPSentDataGridView.TabIndex = 6
        '
        'CodingProfilesSentBindingSource
        '
        Me.CodingProfilesSentBindingSource.DataMember = "CodingProfilesSent"
        Me.CodingProfilesSentBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CodingProfilesSentTableAdapter
        '
        Me.CodingProfilesSentTableAdapter.ClearBeforeFill = True
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
        'CertificationDataGridViewTextBoxColumn
        '
        Me.CertificationDataGridViewTextBoxColumn.DataPropertyName = "certification"
        Me.CertificationDataGridViewTextBoxColumn.HeaderText = "certification"
        Me.CertificationDataGridViewTextBoxColumn.Name = "CertificationDataGridViewTextBoxColumn"
        '
        'PracticenameDataGridViewTextBoxColumn
        '
        Me.PracticenameDataGridViewTextBoxColumn.DataPropertyName = "practicename"
        Me.PracticenameDataGridViewTextBoxColumn.HeaderText = "practicename"
        Me.PracticenameDataGridViewTextBoxColumn.Name = "PracticenameDataGridViewTextBoxColumn"
        '
        'ReportnameDataGridViewTextBoxColumn
        '
        Me.ReportnameDataGridViewTextBoxColumn.DataPropertyName = "reportname"
        Me.ReportnameDataGridViewTextBoxColumn.HeaderText = "reportname"
        Me.ReportnameDataGridViewTextBoxColumn.Name = "ReportnameDataGridViewTextBoxColumn"
        '
        'SendtoDataGridViewTextBoxColumn
        '
        Me.SendtoDataGridViewTextBoxColumn.DataPropertyName = "sendto"
        Me.SendtoDataGridViewTextBoxColumn.HeaderText = "sendto"
        Me.SendtoDataGridViewTextBoxColumn.Name = "SendtoDataGridViewTextBoxColumn"
        '
        'DatetosendDataGridViewTextBoxColumn
        '
        Me.DatetosendDataGridViewTextBoxColumn.DataPropertyName = "datetosend"
        Me.DatetosendDataGridViewTextBoxColumn.HeaderText = "datetosend"
        Me.DatetosendDataGridViewTextBoxColumn.Name = "DatetosendDataGridViewTextBoxColumn"
        '
        'SenddtDataGridViewTextBoxColumn
        '
        Me.SenddtDataGridViewTextBoxColumn.DataPropertyName = "senddt"
        Me.SenddtDataGridViewTextBoxColumn.HeaderText = "senddt"
        Me.SenddtDataGridViewTextBoxColumn.Name = "SenddtDataGridViewTextBoxColumn"
        '
        'CodingProfilesSent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.CPSentDataGridView)
        Me.Controls.Add(Me.ProviderReportsHdr)
        Me.Name = "CodingProfilesSent"
        Me.Text = "CodingProfilesSent"
        CType(Me.CPSentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodingProfilesSentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProviderReportsHdr As Label
    Friend WithEvents CPSentDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents CodingProfilesSentBindingSource As BindingSource
    Friend WithEvents CodingProfilesSentTableAdapter As DataSet1TableAdapters.CodingProfilesSentTableAdapter
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvideridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CertificationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PracticenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SendtoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatetosendDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SenddtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
