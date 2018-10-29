<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpecialProcessing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpecialProcessing))
        Me.CPHdr = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatasourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvideridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReporttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SqlstmntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CptempidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecialProcessingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.SpecialProcessingTableAdapter = New MonthEnd.DataSet1TableAdapters.SpecialProcessingTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpecialProcessingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CPHdr
        '
        Me.CPHdr.BackColor = System.Drawing.Color.Transparent
        Me.CPHdr.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPHdr.ForeColor = System.Drawing.Color.White
        Me.CPHdr.Location = New System.Drawing.Point(454, 116)
        Me.CPHdr.Name = "CPHdr"
        Me.CPHdr.Size = New System.Drawing.Size(336, 62)
        Me.CPHdr.TabIndex = 3
        Me.CPHdr.Text = "SpecialProcessing"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.DatasourceDataGridViewTextBoxColumn, Me.ProvideridDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.ReporttypeDataGridViewTextBoxColumn, Me.SqlstmntDataGridViewTextBoxColumn, Me.CptempidDataGridViewTextBoxColumn, Me.CommentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SpecialProcessingBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(53, 205)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1189, 363)
        Me.DataGridView1.TabIndex = 4
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecordidDataGridViewTextBoxColumn.Width = 50
        '
        'DatasourceDataGridViewTextBoxColumn
        '
        Me.DatasourceDataGridViewTextBoxColumn.DataPropertyName = "datasource"
        Me.DatasourceDataGridViewTextBoxColumn.HeaderText = "datasource"
        Me.DatasourceDataGridViewTextBoxColumn.Name = "DatasourceDataGridViewTextBoxColumn"
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
        Me.LastnameDataGridViewTextBoxColumn.Width = 150
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.Width = 150
        '
        'ReporttypeDataGridViewTextBoxColumn
        '
        Me.ReporttypeDataGridViewTextBoxColumn.DataPropertyName = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.HeaderText = "reporttp"
        Me.ReporttypeDataGridViewTextBoxColumn.Name = "ReporttypeDataGridViewTextBoxColumn"
        Me.ReporttypeDataGridViewTextBoxColumn.Width = 50
        '
        'SqlstmntDataGridViewTextBoxColumn
        '
        Me.SqlstmntDataGridViewTextBoxColumn.DataPropertyName = "sqlstmnt"
        Me.SqlstmntDataGridViewTextBoxColumn.HeaderText = "sql statement"
        Me.SqlstmntDataGridViewTextBoxColumn.Name = "SqlstmntDataGridViewTextBoxColumn"
        Me.SqlstmntDataGridViewTextBoxColumn.Width = 250
        '
        'CptempidDataGridViewTextBoxColumn
        '
        Me.CptempidDataGridViewTextBoxColumn.DataPropertyName = "cptempid"
        Me.CptempidDataGridViewTextBoxColumn.HeaderText = "cptempid"
        Me.CptempidDataGridViewTextBoxColumn.Name = "CptempidDataGridViewTextBoxColumn"
        Me.CptempidDataGridViewTextBoxColumn.Width = 50
        '
        'CommentDataGridViewTextBoxColumn
        '
        Me.CommentDataGridViewTextBoxColumn.DataPropertyName = "comment"
        Me.CommentDataGridViewTextBoxColumn.HeaderText = "comment"
        Me.CommentDataGridViewTextBoxColumn.Name = "CommentDataGridViewTextBoxColumn"
        Me.CommentDataGridViewTextBoxColumn.Width = 250
        '
        'SpecialProcessingBindingSource
        '
        Me.SpecialProcessingBindingSource.DataMember = "SpecialProcessing"
        Me.SpecialProcessingBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpecialProcessingTableAdapter
        '
        Me.SpecialProcessingTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'SpecialProcessing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CPHdr)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SpecialProcessing"
        Me.Text = "SpecialProcessing"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpecialProcessingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CPHdr As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents SpecialProcessingBindingSource As BindingSource
    Friend WithEvents SpecialProcessingTableAdapter As DataSet1TableAdapters.SpecialProcessingTableAdapter
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatasourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvideridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReporttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SqlstmntDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CptempidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
End Class
