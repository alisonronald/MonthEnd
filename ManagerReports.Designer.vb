<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerReports
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagerReports))
        Me.MRHeader = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UpdateManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagerReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.ManagerReportsTableAdapter = New MonthEnd.DataSet1TableAdapters.ManagerReportsTableAdapter()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReporttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManagerlastDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManagerfirstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PracticenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportdirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportemailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportccDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PdfDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EncryptDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.reportsubject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Selected = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ManagerReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MRHeader
        '
        Me.MRHeader.BackColor = System.Drawing.Color.Transparent
        Me.MRHeader.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MRHeader.ForeColor = System.Drawing.Color.White
        Me.MRHeader.Location = New System.Drawing.Point(510, 87)
        Me.MRHeader.Name = "MRHeader"
        Me.MRHeader.Size = New System.Drawing.Size(260, 47)
        Me.MRHeader.TabIndex = 2
        Me.MRHeader.Text = "ManagerReports"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.ReporttypeDataGridViewTextBoxColumn, Me.ManagerlastDataGridViewTextBoxColumn, Me.ManagerfirstDataGridViewTextBoxColumn, Me.ReportnameDataGridViewTextBoxColumn, Me.PracticenameDataGridViewTextBoxColumn, Me.ReportdirDataGridViewTextBoxColumn, Me.ReportemailDataGridViewTextBoxColumn, Me.ReportccDataGridViewTextBoxColumn, Me.PdfDataGridViewCheckBoxColumn, Me.EncryptDataGridViewCheckBoxColumn, Me.reportsubject, Me.Selected})
        Me.DataGridView1.DataSource = Me.ManagerReportsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(14, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.Size = New System.Drawing.Size(1263, 418)
        Me.DataGridView1.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateManagerToolStripMenuItem, Me.DeleteManagerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1292, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UpdateManagerToolStripMenuItem
        '
        Me.UpdateManagerToolStripMenuItem.Name = "UpdateManagerToolStripMenuItem"
        Me.UpdateManagerToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.UpdateManagerToolStripMenuItem.Text = "UpdateManager"
        '
        'DeleteManagerToolStripMenuItem
        '
        Me.DeleteManagerToolStripMenuItem.Name = "DeleteManagerToolStripMenuItem"
        Me.DeleteManagerToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.DeleteManagerToolStripMenuItem.Text = "DeleteManager"
        '
        'ManagerReportsBindingSource
        '
        Me.ManagerReportsBindingSource.DataMember = "ManagerReports"
        Me.ManagerReportsBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ManagerReportsTableAdapter
        '
        Me.ManagerReportsTableAdapter.ClearBeforeFill = True
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.RecordidDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecordidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RecordidDataGridViewTextBoxColumn.Visible = False
        Me.RecordidDataGridViewTextBoxColumn.Width = 75
        '
        'ReporttypeDataGridViewTextBoxColumn
        '
        Me.ReporttypeDataGridViewTextBoxColumn.DataPropertyName = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.HeaderText = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.Name = "ReporttypeDataGridViewTextBoxColumn"
        '
        'ManagerlastDataGridViewTextBoxColumn
        '
        Me.ManagerlastDataGridViewTextBoxColumn.DataPropertyName = "managerlast"
        Me.ManagerlastDataGridViewTextBoxColumn.HeaderText = "managerlast"
        Me.ManagerlastDataGridViewTextBoxColumn.Name = "ManagerlastDataGridViewTextBoxColumn"
        Me.ManagerlastDataGridViewTextBoxColumn.Width = 75
        '
        'ManagerfirstDataGridViewTextBoxColumn
        '
        Me.ManagerfirstDataGridViewTextBoxColumn.DataPropertyName = "managerfirst"
        Me.ManagerfirstDataGridViewTextBoxColumn.HeaderText = "managerfirst"
        Me.ManagerfirstDataGridViewTextBoxColumn.Name = "ManagerfirstDataGridViewTextBoxColumn"
        Me.ManagerfirstDataGridViewTextBoxColumn.Width = 75
        '
        'ReportnameDataGridViewTextBoxColumn
        '
        Me.ReportnameDataGridViewTextBoxColumn.DataPropertyName = "reportname"
        Me.ReportnameDataGridViewTextBoxColumn.HeaderText = "reportname"
        Me.ReportnameDataGridViewTextBoxColumn.Name = "ReportnameDataGridViewTextBoxColumn"
        Me.ReportnameDataGridViewTextBoxColumn.Width = 75
        '
        'PracticenameDataGridViewTextBoxColumn
        '
        Me.PracticenameDataGridViewTextBoxColumn.DataPropertyName = "practicename"
        Me.PracticenameDataGridViewTextBoxColumn.HeaderText = "practicename"
        Me.PracticenameDataGridViewTextBoxColumn.Name = "PracticenameDataGridViewTextBoxColumn"
        Me.PracticenameDataGridViewTextBoxColumn.Width = 75
        '
        'ReportdirDataGridViewTextBoxColumn
        '
        Me.ReportdirDataGridViewTextBoxColumn.DataPropertyName = "reportdir"
        Me.ReportdirDataGridViewTextBoxColumn.HeaderText = "reportdir"
        Me.ReportdirDataGridViewTextBoxColumn.Name = "ReportdirDataGridViewTextBoxColumn"
        Me.ReportdirDataGridViewTextBoxColumn.Width = 200
        '
        'ReportemailDataGridViewTextBoxColumn
        '
        Me.ReportemailDataGridViewTextBoxColumn.DataPropertyName = "reportemail"
        Me.ReportemailDataGridViewTextBoxColumn.HeaderText = "reportemail"
        Me.ReportemailDataGridViewTextBoxColumn.Name = "ReportemailDataGridViewTextBoxColumn"
        Me.ReportemailDataGridViewTextBoxColumn.Width = 222
        '
        'ReportccDataGridViewTextBoxColumn
        '
        Me.ReportccDataGridViewTextBoxColumn.DataPropertyName = "reportcc"
        Me.ReportccDataGridViewTextBoxColumn.HeaderText = "reportcc"
        Me.ReportccDataGridViewTextBoxColumn.Name = "ReportccDataGridViewTextBoxColumn"
        Me.ReportccDataGridViewTextBoxColumn.Width = 150
        '
        'PdfDataGridViewCheckBoxColumn
        '
        Me.PdfDataGridViewCheckBoxColumn.DataPropertyName = "pdf"
        Me.PdfDataGridViewCheckBoxColumn.HeaderText = "pdf"
        Me.PdfDataGridViewCheckBoxColumn.Name = "PdfDataGridViewCheckBoxColumn"
        Me.PdfDataGridViewCheckBoxColumn.Visible = False
        '
        'EncryptDataGridViewCheckBoxColumn
        '
        Me.EncryptDataGridViewCheckBoxColumn.DataPropertyName = "encrypt"
        Me.EncryptDataGridViewCheckBoxColumn.HeaderText = "encrypt"
        Me.EncryptDataGridViewCheckBoxColumn.Name = "EncryptDataGridViewCheckBoxColumn"
        Me.EncryptDataGridViewCheckBoxColumn.Visible = False
        '
        'reportsubject
        '
        Me.reportsubject.DataPropertyName = "reportsubject"
        Me.reportsubject.HeaderText = "reportsubject"
        Me.reportsubject.Name = "reportsubject"
        Me.reportsubject.Width = 150
        '
        'Selected
        '
        Me.Selected.HeaderText = "ClickToListOrAdd"
        Me.Selected.Name = "Selected"
        Me.Selected.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Selected.ToolTipText = "ClickToList"
        Me.Selected.Width = 95
        '
        'ManagerReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1292, 641)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MRHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ManagerReports"
        Me.Text = "ManagerReports"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ManagerReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MRHeader As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ManagerReportsBindingSource As BindingSource
    Friend WithEvents ManagerReportsTableAdapter As DataSet1TableAdapters.ManagerReportsTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DeleteManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReporttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManagerlastDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManagerfirstDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PracticenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportdirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportemailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportccDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PdfDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EncryptDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents reportsubject As DataGridViewTextBoxColumn
    Friend WithEvents Selected As DataGridViewButtonColumn
End Class
