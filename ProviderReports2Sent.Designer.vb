<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProviderReports2Sent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProviderReports2Sent))
        Me.ProvHdr = New System.Windows.Forms.Label()
        Me.Pr2SentDataGridView = New System.Windows.Forms.DataGridView()
        Me.ReportsSentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.ReportsSentTableAdapter = New MonthEnd.DataSet1TableAdapters.ReportsSentTableAdapter()
        Me.ProvideridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reportemail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReporttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sentdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SentstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Pr2SentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsSentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProvHdr
        '
        Me.ProvHdr.BackColor = System.Drawing.Color.Transparent
        Me.ProvHdr.Font = New System.Drawing.Font("Monotype Corsiva", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvHdr.ForeColor = System.Drawing.Color.White
        Me.ProvHdr.Location = New System.Drawing.Point(430, 104)
        Me.ProvHdr.Name = "ProvHdr"
        Me.ProvHdr.Size = New System.Drawing.Size(382, 62)
        Me.ProvHdr.TabIndex = 4
        Me.ProvHdr.Text = "Provider Reports Sent"
        '
        'Pr2SentDataGridView
        '
        Me.Pr2SentDataGridView.AutoGenerateColumns = False
        Me.Pr2SentDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Pr2SentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Pr2SentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProvideridDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.reportemail, Me.ReporttypeDataGridViewTextBoxColumn, Me.sentdate, Me.SentstatusDataGridViewTextBoxColumn})
        Me.Pr2SentDataGridView.DataSource = Me.ReportsSentBindingSource
        Me.Pr2SentDataGridView.Location = New System.Drawing.Point(261, 156)
        Me.Pr2SentDataGridView.Name = "Pr2SentDataGridView"
        Me.Pr2SentDataGridView.Size = New System.Drawing.Size(744, 411)
        Me.Pr2SentDataGridView.TabIndex = 5
        '
        'ReportsSentBindingSource
        '
        Me.ReportsSentBindingSource.DataMember = "ReportsSent"
        Me.ReportsSentBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportsSentTableAdapter
        '
        Me.ReportsSentTableAdapter.ClearBeforeFill = True
        '
        'ProvideridDataGridViewTextBoxColumn
        '
        Me.ProvideridDataGridViewTextBoxColumn.DataPropertyName = "providerid"
        Me.ProvideridDataGridViewTextBoxColumn.HeaderText = "providerid"
        Me.ProvideridDataGridViewTextBoxColumn.Name = "ProvideridDataGridViewTextBoxColumn"
        Me.ProvideridDataGridViewTextBoxColumn.Width = 75
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
        'reportemail
        '
        Me.reportemail.DataPropertyName = "reportemail"
        Me.reportemail.HeaderText = "reportemail"
        Me.reportemail.Name = "reportemail"
        Me.reportemail.Width = 150
        '
        'ReporttypeDataGridViewTextBoxColumn
        '
        Me.ReporttypeDataGridViewTextBoxColumn.DataPropertyName = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.HeaderText = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.Name = "ReporttypeDataGridViewTextBoxColumn"
        '
        'sentdate
        '
        Me.sentdate.DataPropertyName = "sentdate"
        Me.sentdate.HeaderText = "sentdate"
        Me.sentdate.Name = "sentdate"
        '
        'SentstatusDataGridViewTextBoxColumn
        '
        Me.SentstatusDataGridViewTextBoxColumn.DataPropertyName = "sentstatus"
        Me.SentstatusDataGridViewTextBoxColumn.HeaderText = "sentstatus"
        Me.SentstatusDataGridViewTextBoxColumn.Name = "SentstatusDataGridViewTextBoxColumn"
        Me.SentstatusDataGridViewTextBoxColumn.Width = 75
        '
        'ProviderReports2Sent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.Pr2SentDataGridView)
        Me.Controls.Add(Me.ProvHdr)
        Me.Name = "ProviderReports2Sent"
        Me.Text = "ProviderReports2Sent"
        CType(Me.Pr2SentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsSentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProvHdr As Label
    Friend WithEvents Pr2SentDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ReportsSentBindingSource As BindingSource
    Friend WithEvents ReportsSentTableAdapter As DataSet1TableAdapters.ReportsSentTableAdapter
    Friend WithEvents ProvideremailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SentdtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvideridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents reportemail As DataGridViewTextBoxColumn
    Friend WithEvents ReporttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents sentdate As DataGridViewTextBoxColumn
    Friend WithEvents SentstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
