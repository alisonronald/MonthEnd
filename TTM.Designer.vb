<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TTM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TTM))
        Me.TTMHdr = New System.Windows.Forms.Label()
        Me.TTMDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.TTMHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TTMHistoryTableAdapter = New MonthEnd.DataSet1TableAdapters.TTMHistoryTableAdapter()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportdtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthyearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvidernmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CpttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkrvuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TTMWrite = New System.Windows.Forms.Button()
        Me.WorkingLbl = New System.Windows.Forms.Label()
        CType(Me.TTMDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTMHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TTMHdr
        '
        Me.TTMHdr.BackColor = System.Drawing.Color.Transparent
        Me.TTMHdr.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTMHdr.ForeColor = System.Drawing.Color.White
        Me.TTMHdr.Location = New System.Drawing.Point(443, 118)
        Me.TTMHdr.Name = "TTMHdr"
        Me.TTMHdr.Size = New System.Drawing.Size(321, 62)
        Me.TTMHdr.TabIndex = 2
        Me.TTMHdr.Text = "TTM Processing"
        '
        'TTMDataGridView
        '
        Me.TTMDataGridView.AllowUserToAddRows = False
        Me.TTMDataGridView.AllowUserToDeleteRows = False
        Me.TTMDataGridView.AutoGenerateColumns = False
        Me.TTMDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.TTMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TTMDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.ReportdtDataGridViewTextBoxColumn, Me.MonthyearDataGridViewTextBoxColumn, Me.ProvidernmDataGridViewTextBoxColumn, Me.CpttypeDataGridViewTextBoxColumn, Me.WorkrvuDataGridViewTextBoxColumn})
        Me.TTMDataGridView.DataSource = Me.TTMHistoryBindingSource
        Me.TTMDataGridView.Location = New System.Drawing.Point(273, 208)
        Me.TTMDataGridView.Name = "TTMDataGridView"
        Me.TTMDataGridView.Size = New System.Drawing.Size(698, 360)
        Me.TTMDataGridView.TabIndex = 3
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TTMHistoryBindingSource
        '
        Me.TTMHistoryBindingSource.DataMember = "TTMHistory"
        Me.TTMHistoryBindingSource.DataSource = Me.DataSet1
        '
        'TTMHistoryTableAdapter
        '
        Me.TTMHistoryTableAdapter.ClearBeforeFill = True
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReportdtDataGridViewTextBoxColumn
        '
        Me.ReportdtDataGridViewTextBoxColumn.DataPropertyName = "reportdt"
        Me.ReportdtDataGridViewTextBoxColumn.HeaderText = "reportdt"
        Me.ReportdtDataGridViewTextBoxColumn.Name = "ReportdtDataGridViewTextBoxColumn"
        '
        'MonthyearDataGridViewTextBoxColumn
        '
        Me.MonthyearDataGridViewTextBoxColumn.DataPropertyName = "monthyear"
        Me.MonthyearDataGridViewTextBoxColumn.HeaderText = "monthyear"
        Me.MonthyearDataGridViewTextBoxColumn.Name = "MonthyearDataGridViewTextBoxColumn"
        '
        'ProvidernmDataGridViewTextBoxColumn
        '
        Me.ProvidernmDataGridViewTextBoxColumn.DataPropertyName = "providernm"
        Me.ProvidernmDataGridViewTextBoxColumn.HeaderText = "providernm"
        Me.ProvidernmDataGridViewTextBoxColumn.Name = "ProvidernmDataGridViewTextBoxColumn"
        Me.ProvidernmDataGridViewTextBoxColumn.Width = 150
        '
        'CpttypeDataGridViewTextBoxColumn
        '
        Me.CpttypeDataGridViewTextBoxColumn.DataPropertyName = "cpttype"
        Me.CpttypeDataGridViewTextBoxColumn.HeaderText = "cpttype"
        Me.CpttypeDataGridViewTextBoxColumn.Name = "CpttypeDataGridViewTextBoxColumn"
        '
        'WorkrvuDataGridViewTextBoxColumn
        '
        Me.WorkrvuDataGridViewTextBoxColumn.DataPropertyName = "workrvu"
        Me.WorkrvuDataGridViewTextBoxColumn.HeaderText = "workrvu"
        Me.WorkrvuDataGridViewTextBoxColumn.Name = "WorkrvuDataGridViewTextBoxColumn"
        '
        'TTMWrite
        '
        Me.TTMWrite.BackColor = System.Drawing.Color.Transparent
        Me.TTMWrite.BackgroundImage = CType(resources.GetObject("TTMWrite.BackgroundImage"), System.Drawing.Image)
        Me.TTMWrite.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTMWrite.ForeColor = System.Drawing.Color.Red
        Me.TTMWrite.Location = New System.Drawing.Point(818, 166)
        Me.TTMWrite.Name = "TTMWrite"
        Me.TTMWrite.Size = New System.Drawing.Size(127, 36)
        Me.TTMWrite.TabIndex = 8
        Me.TTMWrite.Text = "WriteDetail"
        Me.TTMWrite.UseVisualStyleBackColor = False
        '
        'WorkingLbl
        '
        Me.WorkingLbl.AutoSize = True
        Me.WorkingLbl.BackColor = System.Drawing.Color.Transparent
        Me.WorkingLbl.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingLbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WorkingLbl.Location = New System.Drawing.Point(283, 180)
        Me.WorkingLbl.Name = "WorkingLbl"
        Me.WorkingLbl.Size = New System.Drawing.Size(103, 22)
        Me.WorkingLbl.TabIndex = 9
        Me.WorkingLbl.Text = "Working....."
        '
        'TTM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.WorkingLbl)
        Me.Controls.Add(Me.TTMWrite)
        Me.Controls.Add(Me.TTMDataGridView)
        Me.Controls.Add(Me.TTMHdr)
        Me.Name = "TTM"
        Me.Text = "TTM Processing"
        CType(Me.TTMDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTMHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TTMHdr As Label
    Friend WithEvents TTMDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents TTMHistoryBindingSource As BindingSource
    Friend WithEvents TTMHistoryTableAdapter As DataSet1TableAdapters.TTMHistoryTableAdapter
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportdtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthyearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvidernmDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CpttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WorkrvuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TTMWrite As Button
    Friend WithEvents WorkingLbl As Label
End Class
