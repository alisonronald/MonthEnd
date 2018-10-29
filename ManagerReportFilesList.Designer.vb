<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagerReportFilesList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagerReportFilesList))
        Me.MRHeader = New System.Windows.Forms.Label()
        Me.FileListDataGridView = New System.Windows.Forms.DataGridView()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManageridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReporttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PracticeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportdirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeleteRpt = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ManagerReportFilesListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManagersList = New System.Windows.Forms.ToolStripMenuItem()
        Me.MergeListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkingLbl = New System.Windows.Forms.Label()
        Me.SendLink = New System.Windows.Forms.LinkLabel()
        Me.ManagerReportFilesListTableAdapter = New MonthEnd.DataSet1TableAdapters.ManagerReportFilesListTableAdapter()
        Me.MgrLbl = New System.Windows.Forms.Label()
        Me.AdminSendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.FileListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagerReportFilesListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MRHeader
        '
        Me.MRHeader.BackColor = System.Drawing.Color.Transparent
        Me.MRHeader.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MRHeader.ForeColor = System.Drawing.Color.White
        Me.MRHeader.Location = New System.Drawing.Point(444, 94)
        Me.MRHeader.Name = "MRHeader"
        Me.MRHeader.Size = New System.Drawing.Size(351, 49)
        Me.MRHeader.TabIndex = 3
        Me.MRHeader.Text = "ManagerReportFilesMerge"
        '
        'FileListDataGridView
        '
        Me.FileListDataGridView.AllowUserToAddRows = False
        Me.FileListDataGridView.AutoGenerateColumns = False
        Me.FileListDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FileListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FileListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.ManageridDataGridViewTextBoxColumn, Me.ReporttypeDataGridViewTextBoxColumn, Me.PracticeDataGridViewTextBoxColumn, Me.ReportdirDataGridViewTextBoxColumn, Me.ReportnameDataGridViewTextBoxColumn, Me.DeleteRpt})
        Me.FileListDataGridView.DataSource = Me.ManagerReportFilesListBindingSource
        Me.FileListDataGridView.Location = New System.Drawing.Point(166, 172)
        Me.FileListDataGridView.Name = "FileListDataGridView"
        Me.FileListDataGridView.Size = New System.Drawing.Size(974, 386)
        Me.FileListDataGridView.TabIndex = 4
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        '
        'ManageridDataGridViewTextBoxColumn
        '
        Me.ManageridDataGridViewTextBoxColumn.DataPropertyName = "managerid"
        Me.ManageridDataGridViewTextBoxColumn.HeaderText = "managerid"
        Me.ManageridDataGridViewTextBoxColumn.Name = "ManageridDataGridViewTextBoxColumn"
        '
        'ReporttypeDataGridViewTextBoxColumn
        '
        Me.ReporttypeDataGridViewTextBoxColumn.DataPropertyName = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.HeaderText = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.Name = "ReporttypeDataGridViewTextBoxColumn"
        '
        'PracticeDataGridViewTextBoxColumn
        '
        Me.PracticeDataGridViewTextBoxColumn.DataPropertyName = "practice"
        Me.PracticeDataGridViewTextBoxColumn.HeaderText = "practice"
        Me.PracticeDataGridViewTextBoxColumn.Name = "PracticeDataGridViewTextBoxColumn"
        '
        'ReportdirDataGridViewTextBoxColumn
        '
        Me.ReportdirDataGridViewTextBoxColumn.DataPropertyName = "reportdir"
        Me.ReportdirDataGridViewTextBoxColumn.HeaderText = "reportdir"
        Me.ReportdirDataGridViewTextBoxColumn.Name = "ReportdirDataGridViewTextBoxColumn"
        Me.ReportdirDataGridViewTextBoxColumn.Width = 200
        '
        'ReportnameDataGridViewTextBoxColumn
        '
        Me.ReportnameDataGridViewTextBoxColumn.DataPropertyName = "reportname"
        Me.ReportnameDataGridViewTextBoxColumn.HeaderText = "reportname"
        Me.ReportnameDataGridViewTextBoxColumn.Name = "ReportnameDataGridViewTextBoxColumn"
        Me.ReportnameDataGridViewTextBoxColumn.Width = 250
        '
        'DeleteRpt
        '
        Me.DeleteRpt.HeaderText = "ClickToDelete"
        Me.DeleteRpt.Name = "DeleteRpt"
        Me.DeleteRpt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeleteRpt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ManagerReportFilesListBindingSource
        '
        Me.ManagerReportFilesListBindingSource.DataMember = "ManagerReportFilesList"
        Me.ManagerReportFilesListBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManagersList, Me.MergeListToolStripMenuItem, Me.AdminSendToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1276, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManagersList
        '
        Me.ManagersList.DoubleClickEnabled = True
        Me.ManagersList.Name = "ManagersList"
        Me.ManagersList.Size = New System.Drawing.Size(92, 20)
        Me.ManagersList.Text = "Manager'sList"
        '
        'MergeListToolStripMenuItem
        '
        Me.MergeListToolStripMenuItem.Name = "MergeListToolStripMenuItem"
        Me.MergeListToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.MergeListToolStripMenuItem.Text = "MergeFiles"
        '
        'WorkingLbl
        '
        Me.WorkingLbl.AutoSize = True
        Me.WorkingLbl.BackColor = System.Drawing.Color.Transparent
        Me.WorkingLbl.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingLbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WorkingLbl.Location = New System.Drawing.Point(9, 43)
        Me.WorkingLbl.Name = "WorkingLbl"
        Me.WorkingLbl.Size = New System.Drawing.Size(103, 22)
        Me.WorkingLbl.TabIndex = 9
        Me.WorkingLbl.Text = "Working....."
        '
        'SendLink
        '
        Me.SendLink.BackColor = System.Drawing.Color.Transparent
        Me.SendLink.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendLink.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SendLink.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.SendLink.Location = New System.Drawing.Point(106, 43)
        Me.SendLink.Name = "SendLink"
        Me.SendLink.Size = New System.Drawing.Size(84, 28)
        Me.SendLink.TabIndex = 10
        Me.SendLink.TabStop = True
        Me.SendLink.Text = "SendFile"
        '
        'ManagerReportFilesListTableAdapter
        '
        Me.ManagerReportFilesListTableAdapter.ClearBeforeFill = True
        '
        'MgrLbl
        '
        Me.MgrLbl.BackColor = System.Drawing.Color.Transparent
        Me.MgrLbl.Font = New System.Drawing.Font("Monotype Corsiva", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MgrLbl.ForeColor = System.Drawing.Color.White
        Me.MgrLbl.Location = New System.Drawing.Point(451, 130)
        Me.MgrLbl.Name = "MgrLbl"
        Me.MgrLbl.Size = New System.Drawing.Size(327, 26)
        Me.MgrLbl.TabIndex = 11
        Me.MgrLbl.Text = "Manager"
        Me.MgrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdminSendToolStripMenuItem
        '
        Me.AdminSendToolStripMenuItem.Name = "AdminSendToolStripMenuItem"
        Me.AdminSendToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.AdminSendToolStripMenuItem.Text = "AdminSend"
        '
        'ManagerReportFilesList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1276, 641)
        Me.Controls.Add(Me.MgrLbl)
        Me.Controls.Add(Me.SendLink)
        Me.Controls.Add(Me.WorkingLbl)
        Me.Controls.Add(Me.FileListDataGridView)
        Me.Controls.Add(Me.MRHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ManagerReportFilesList"
        Me.Text = "ManagerReportFilesList"
        CType(Me.FileListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagerReportFilesListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MRHeader As Label
    Friend WithEvents FileListDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ManagerReportFilesListBindingSource As BindingSource
    Friend WithEvents ManagerReportFilesListTableAdapter As DataSet1TableAdapters.ManagerReportFilesListTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MergeListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WorkingLbl As Label
    Friend WithEvents SendLink As LinkLabel
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManageridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReporttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PracticeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportdirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeleteRpt As DataGridViewButtonColumn
    Friend WithEvents ManagersList As ToolStripMenuItem
    Friend WithEvents MgrLbl As Label
    Friend WithEvents AdminSendToolStripMenuItem As ToolStripMenuItem
End Class
