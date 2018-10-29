<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DistributionList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DistributionList))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DistributionListDataGridView = New System.Windows.Forms.DataGridView()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PracticeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TolineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CclineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SublineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DistributionlistBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.DistributionlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DistributionlistTableAdapter = New MonthEnd.DataSet1TableAdapters.distributionlistTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DistributionListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistributionlistBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistributionlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(452, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "(If Necessary, Resize Row Height to Copy and Paste)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DistributionListDataGridView
        '
        Me.DistributionListDataGridView.AutoGenerateColumns = False
        Me.DistributionListDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DistributionListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DistributionListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.PracticeDataGridViewTextBoxColumn, Me.ReportDataGridViewTextBoxColumn, Me.TolineDataGridViewTextBoxColumn, Me.CclineDataGridViewTextBoxColumn, Me.SublineDataGridViewTextBoxColumn})
        Me.DistributionListDataGridView.DataSource = Me.DistributionlistBindingSource1
        Me.DistributionListDataGridView.Location = New System.Drawing.Point(0, 141)
        Me.DistributionListDataGridView.Name = "DistributionListDataGridView"
        Me.DistributionListDataGridView.RowTemplate.Height = 75
        Me.DistributionListDataGridView.Size = New System.Drawing.Size(1304, 418)
        Me.DistributionListDataGridView.TabIndex = 3
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecordidDataGridViewTextBoxColumn.Width = 75
        '
        'PracticeDataGridViewTextBoxColumn
        '
        Me.PracticeDataGridViewTextBoxColumn.DataPropertyName = "practice"
        Me.PracticeDataGridViewTextBoxColumn.HeaderText = "practice"
        Me.PracticeDataGridViewTextBoxColumn.Name = "PracticeDataGridViewTextBoxColumn"
        '
        'ReportDataGridViewTextBoxColumn
        '
        Me.ReportDataGridViewTextBoxColumn.DataPropertyName = "report"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReportDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ReportDataGridViewTextBoxColumn.HeaderText = "report"
        Me.ReportDataGridViewTextBoxColumn.Name = "ReportDataGridViewTextBoxColumn"
        Me.ReportDataGridViewTextBoxColumn.Width = 200
        '
        'TolineDataGridViewTextBoxColumn
        '
        Me.TolineDataGridViewTextBoxColumn.DataPropertyName = "toline"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TolineDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TolineDataGridViewTextBoxColumn.HeaderText = "toline"
        Me.TolineDataGridViewTextBoxColumn.Name = "TolineDataGridViewTextBoxColumn"
        Me.TolineDataGridViewTextBoxColumn.Width = 275
        '
        'CclineDataGridViewTextBoxColumn
        '
        Me.CclineDataGridViewTextBoxColumn.DataPropertyName = "ccline"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CclineDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CclineDataGridViewTextBoxColumn.HeaderText = "ccline"
        Me.CclineDataGridViewTextBoxColumn.Name = "CclineDataGridViewTextBoxColumn"
        Me.CclineDataGridViewTextBoxColumn.Width = 300
        '
        'SublineDataGridViewTextBoxColumn
        '
        Me.SublineDataGridViewTextBoxColumn.DataPropertyName = "subline"
        Me.SublineDataGridViewTextBoxColumn.HeaderText = "subline"
        Me.SublineDataGridViewTextBoxColumn.Name = "SublineDataGridViewTextBoxColumn"
        Me.SublineDataGridViewTextBoxColumn.Width = 300
        '
        'DistributionlistBindingSource1
        '
        Me.DistributionlistBindingSource1.DataMember = "distributionlist"
        Me.DistributionlistBindingSource1.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DistributionlistBindingSource
        '
        Me.DistributionlistBindingSource.DataMember = "distributionlist"
        Me.DistributionlistBindingSource.DataSource = Me.DataSet1
        '
        'DistributionlistTableAdapter
        '
        Me.DistributionlistTableAdapter.ClearBeforeFill = True
        '
        'DistributionList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.DistributionListDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DistributionList"
        Me.Text = "DistributionList"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DistributionListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistributionlistBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistributionlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DistributionlistBindingSource As BindingSource
    Friend WithEvents DistributionlistTableAdapter As DataSet1TableAdapters.distributionlistTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents DistributionListDataGridView As DataGridView
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PracticeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TolineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CclineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SublineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DistributionlistBindingSource1 As BindingSource
End Class
