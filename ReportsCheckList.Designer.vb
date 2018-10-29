<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsCheckList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportsCheckList))
        Me.ProcHdr = New System.Windows.Forms.Label()
        Me.CheckListDataGridView = New System.Windows.Forms.DataGridView()
        Me.reportmanagerid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReporttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportpracticeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportmanagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportcreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportsentdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportcountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportsentDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ReportsCheckListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.ReportsCheckListTableAdapter = New MonthEnd.DataSet1TableAdapters.ReportsCheckListTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UpdateCheckListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateALLReportSentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.CheckListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsCheckListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProcHdr
        '
        Me.ProcHdr.BackColor = System.Drawing.Color.Transparent
        Me.ProcHdr.Font = New System.Drawing.Font("Monotype Corsiva", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcHdr.ForeColor = System.Drawing.Color.White
        Me.ProcHdr.Location = New System.Drawing.Point(423, 101)
        Me.ProcHdr.Name = "ProcHdr"
        Me.ProcHdr.Size = New System.Drawing.Size(414, 62)
        Me.ProcHdr.TabIndex = 2
        Me.ProcHdr.Text = "Reporting/Reports Check List"
        '
        'CheckListDataGridView
        '
        Me.CheckListDataGridView.AutoGenerateColumns = False
        Me.CheckListDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.CheckListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CheckListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.ReporttypeDataGridViewTextBoxColumn, Me.ReportpracticeDataGridViewTextBoxColumn, Me.ReportmanagerDataGridViewTextBoxColumn, Me.reportmanagerid, Me.ReportcreatedDataGridViewTextBoxColumn, Me.ReportsentdateDataGridViewTextBoxColumn, Me.ReportcountDataGridViewTextBoxColumn, Me.ReportsentDataGridViewCheckBoxColumn})
        Me.CheckListDataGridView.DataSource = Me.ReportsCheckListBindingSource
        Me.CheckListDataGridView.Location = New System.Drawing.Point(181, 149)
        Me.CheckListDataGridView.Name = "CheckListDataGridView"
        Me.CheckListDataGridView.Size = New System.Drawing.Size(944, 421)
        Me.CheckListDataGridView.TabIndex = 3
        '
        'reportmanagerid
        '
        Me.reportmanagerid.DataPropertyName = "reportmanagerid"
        Me.reportmanagerid.HeaderText = "reportmanagerid"
        Me.reportmanagerid.Name = "reportmanagerid"
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReporttypeDataGridViewTextBoxColumn
        '
        Me.ReporttypeDataGridViewTextBoxColumn.DataPropertyName = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.HeaderText = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.Name = "ReporttypeDataGridViewTextBoxColumn"
        '
        'ReportpracticeDataGridViewTextBoxColumn
        '
        Me.ReportpracticeDataGridViewTextBoxColumn.DataPropertyName = "reportpractice"
        Me.ReportpracticeDataGridViewTextBoxColumn.HeaderText = "reportpractice"
        Me.ReportpracticeDataGridViewTextBoxColumn.Name = "ReportpracticeDataGridViewTextBoxColumn"
        '
        'ReportmanagerDataGridViewTextBoxColumn
        '
        Me.ReportmanagerDataGridViewTextBoxColumn.DataPropertyName = "reportmanager"
        Me.ReportmanagerDataGridViewTextBoxColumn.HeaderText = "reportmanager"
        Me.ReportmanagerDataGridViewTextBoxColumn.Name = "ReportmanagerDataGridViewTextBoxColumn"
        '
        'ReportcreatedDataGridViewTextBoxColumn
        '
        Me.ReportcreatedDataGridViewTextBoxColumn.DataPropertyName = "reportcreated"
        Me.ReportcreatedDataGridViewTextBoxColumn.HeaderText = "reportcreated"
        Me.ReportcreatedDataGridViewTextBoxColumn.Name = "ReportcreatedDataGridViewTextBoxColumn"
        '
        'ReportsentdateDataGridViewTextBoxColumn
        '
        Me.ReportsentdateDataGridViewTextBoxColumn.DataPropertyName = "reportsentdate"
        Me.ReportsentdateDataGridViewTextBoxColumn.HeaderText = "reportsentdate"
        Me.ReportsentdateDataGridViewTextBoxColumn.Name = "ReportsentdateDataGridViewTextBoxColumn"
        '
        'ReportcountDataGridViewTextBoxColumn
        '
        Me.ReportcountDataGridViewTextBoxColumn.DataPropertyName = "reportcount"
        Me.ReportcountDataGridViewTextBoxColumn.HeaderText = "reportcount"
        Me.ReportcountDataGridViewTextBoxColumn.Name = "ReportcountDataGridViewTextBoxColumn"
        '
        'ReportsentDataGridViewCheckBoxColumn
        '
        Me.ReportsentDataGridViewCheckBoxColumn.DataPropertyName = "reportsent"
        Me.ReportsentDataGridViewCheckBoxColumn.HeaderText = "reportsent"
        Me.ReportsentDataGridViewCheckBoxColumn.Name = "ReportsentDataGridViewCheckBoxColumn"
        '
        'ReportsCheckListBindingSource
        '
        Me.ReportsCheckListBindingSource.DataMember = "ReportsCheckList"
        Me.ReportsCheckListBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportsCheckListTableAdapter
        '
        Me.ReportsCheckListTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateCheckListToolStripMenuItem, Me.UpdateALLReportSentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UpdateCheckListToolStripMenuItem
        '
        Me.UpdateCheckListToolStripMenuItem.Name = "UpdateCheckListToolStripMenuItem"
        Me.UpdateCheckListToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.UpdateCheckListToolStripMenuItem.Text = "UpdateCheckList"
        '
        'UpdateALLReportSentToolStripMenuItem
        '
        Me.UpdateALLReportSentToolStripMenuItem.Name = "UpdateALLReportSentToolStripMenuItem"
        Me.UpdateALLReportSentToolStripMenuItem.Size = New System.Drawing.Size(135, 20)
        Me.UpdateALLReportSentToolStripMenuItem.Text = "UpdateALLReportSent"
        '
        'ReportsCheckList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.CheckListDataGridView)
        Me.Controls.Add(Me.ProcHdr)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ReportsCheckList"
        Me.Text = "ReportsCheckList"
        CType(Me.CheckListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsCheckListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProcHdr As Label
    Friend WithEvents CheckListDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ReportsCheckListBindingSource As BindingSource
    Friend WithEvents ReportsCheckListTableAdapter As DataSet1TableAdapters.ReportsCheckListTableAdapter
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReporttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportpracticeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportmanagerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents reportmanagerid As DataGridViewTextBoxColumn
    Friend WithEvents ReportcreatedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportsentdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportcountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportsentDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UpdateCheckListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateALLReportSentToolStripMenuItem As ToolStripMenuItem
End Class
