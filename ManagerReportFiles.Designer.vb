<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagerReportFiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagerReportFiles))
        Me.MRHeader = New System.Windows.Forms.Label()
        Me.ManagerReportFilesDataGridView = New System.Windows.Forms.DataGridView()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManageridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReporttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PracticeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportdirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClickToDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ClickToAdd = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ManagerReportFilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.ManagerReportFilesTableAdapter = New MonthEnd.DataSet1TableAdapters.ManagerReportFilesTableAdapter()
        Me.MgrLbl = New System.Windows.Forms.Label()
        Me.AddFilesLbl = New System.Windows.Forms.Label()
        Me.AddReport = New System.Windows.Forms.TextBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.AddNew = New System.Windows.Forms.Button()
        CType(Me.ManagerReportFilesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagerReportFilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MRHeader
        '
        Me.MRHeader.BackColor = System.Drawing.Color.Transparent
        Me.MRHeader.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MRHeader.ForeColor = System.Drawing.Color.White
        Me.MRHeader.Location = New System.Drawing.Point(455, 91)
        Me.MRHeader.Name = "MRHeader"
        Me.MRHeader.Size = New System.Drawing.Size(279, 34)
        Me.MRHeader.TabIndex = 4
        Me.MRHeader.Text = "ManagerReportFiles"
        '
        'ManagerReportFilesDataGridView
        '
        Me.ManagerReportFilesDataGridView.AllowUserToAddRows = False
        Me.ManagerReportFilesDataGridView.AutoGenerateColumns = False
        Me.ManagerReportFilesDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.ManagerReportFilesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ManagerReportFilesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.ManageridDataGridViewTextBoxColumn, Me.ReporttypeDataGridViewTextBoxColumn, Me.PracticeDataGridViewTextBoxColumn, Me.ReportdirDataGridViewTextBoxColumn, Me.ReportnameDataGridViewTextBoxColumn, Me.ClickToDelete, Me.ClickToAdd})
        Me.ManagerReportFilesDataGridView.DataSource = Me.ManagerReportFilesBindingSource
        Me.ManagerReportFilesDataGridView.Location = New System.Drawing.Point(235, 164)
        Me.ManagerReportFilesDataGridView.Name = "ManagerReportFilesDataGridView"
        Me.ManagerReportFilesDataGridView.Size = New System.Drawing.Size(842, 360)
        Me.ManagerReportFilesDataGridView.TabIndex = 5
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
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
        '
        'ReportnameDataGridViewTextBoxColumn
        '
        Me.ReportnameDataGridViewTextBoxColumn.DataPropertyName = "reportname"
        Me.ReportnameDataGridViewTextBoxColumn.HeaderText = "reportname"
        Me.ReportnameDataGridViewTextBoxColumn.Name = "ReportnameDataGridViewTextBoxColumn"
        '
        'ClickToDelete
        '
        Me.ClickToDelete.HeaderText = "ClickToDelete"
        Me.ClickToDelete.Name = "ClickToDelete"
        '
        'ClickToAdd
        '
        Me.ClickToAdd.HeaderText = "ClickToAdd"
        Me.ClickToAdd.Name = "ClickToAdd"
        Me.ClickToAdd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClickToAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ManagerReportFilesBindingSource
        '
        Me.ManagerReportFilesBindingSource.DataMember = "ManagerReportFiles"
        Me.ManagerReportFilesBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ManagerReportFilesTableAdapter
        '
        Me.ManagerReportFilesTableAdapter.ClearBeforeFill = True
        '
        'MgrLbl
        '
        Me.MgrLbl.BackColor = System.Drawing.Color.Transparent
        Me.MgrLbl.Font = New System.Drawing.Font("Monotype Corsiva", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MgrLbl.ForeColor = System.Drawing.Color.White
        Me.MgrLbl.Location = New System.Drawing.Point(457, 125)
        Me.MgrLbl.Name = "MgrLbl"
        Me.MgrLbl.Size = New System.Drawing.Size(266, 26)
        Me.MgrLbl.TabIndex = 12
        Me.MgrLbl.Text = "Manager"
        Me.MgrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AddFilesLbl
        '
        Me.AddFilesLbl.BackColor = System.Drawing.Color.Transparent
        Me.AddFilesLbl.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddFilesLbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AddFilesLbl.Location = New System.Drawing.Point(255, 532)
        Me.AddFilesLbl.Name = "AddFilesLbl"
        Me.AddFilesLbl.Size = New System.Drawing.Size(265, 27)
        Me.AddFilesLbl.TabIndex = 13
        Me.AddFilesLbl.Text = "Add Report Name (For Manager)"
        '
        'AddReport
        '
        Me.AddReport.Location = New System.Drawing.Point(517, 536)
        Me.AddReport.Name = "AddReport"
        Me.AddReport.Size = New System.Drawing.Size(236, 20)
        Me.AddReport.TabIndex = 14
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(760, 536)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddBtn.TabIndex = 15
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'AddNew
        '
        Me.AddNew.Location = New System.Drawing.Point(842, 535)
        Me.AddNew.Name = "AddNew"
        Me.AddNew.Size = New System.Drawing.Size(75, 23)
        Me.AddNew.TabIndex = 16
        Me.AddNew.Text = "QuitAdding"
        Me.AddNew.UseVisualStyleBackColor = True
        '
        'ManagerReportFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.AddNew)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.AddReport)
        Me.Controls.Add(Me.AddFilesLbl)
        Me.Controls.Add(Me.MgrLbl)
        Me.Controls.Add(Me.ManagerReportFilesDataGridView)
        Me.Controls.Add(Me.MRHeader)
        Me.Name = "ManagerReportFiles"
        Me.Text = "ManagerReportFiles"
        CType(Me.ManagerReportFilesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagerReportFilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MRHeader As Label
    Friend WithEvents ManagerReportFilesDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ManagerReportFilesBindingSource As BindingSource
    Friend WithEvents ManagerReportFilesTableAdapter As DataSet1TableAdapters.ManagerReportFilesTableAdapter
    Friend WithEvents MgrLbl As Label
    Friend WithEvents AddFilesLbl As Label
    Friend WithEvents AddReport As TextBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManageridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReporttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PracticeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportdirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClickToDelete As DataGridViewButtonColumn
    Friend WithEvents ClickToAdd As DataGridViewButtonColumn
    Friend WithEvents AddNew As Button
End Class
