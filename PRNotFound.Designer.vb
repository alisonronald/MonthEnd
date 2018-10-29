<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRNotFound
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PRNotFound))
        Me.ProcHdr = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RundtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvidernmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReporttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PracticeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvideridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SlectDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProviderReportsNotFoundBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvidersInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProviderReportsNotFoundTableAdapter = New MonthEnd.DataSet1TableAdapters.ProviderReportsNotFoundTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProviderReportsNotFoundBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProcHdr
        '
        Me.ProcHdr.BackColor = System.Drawing.Color.Transparent
        Me.ProcHdr.Font = New System.Drawing.Font("Monotype Corsiva", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcHdr.ForeColor = System.Drawing.Color.White
        Me.ProcHdr.Location = New System.Drawing.Point(374, 100)
        Me.ProcHdr.Name = "ProcHdr"
        Me.ProcHdr.Size = New System.Drawing.Size(507, 62)
        Me.ProcHdr.TabIndex = 2
        Me.ProcHdr.Text = "Providers(reports) Not Found"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.RundtDataGridViewTextBoxColumn, Me.ProvidernmDataGridViewTextBoxColumn, Me.ReporttypeDataGridViewTextBoxColumn, Me.PracticeidDataGridViewTextBoxColumn, Me.ProvideridDataGridViewTextBoxColumn, Me.SlectDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.ProviderReportsNotFoundBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(291, 157)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(697, 384)
        Me.DataGridView1.TabIndex = 3
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RundtDataGridViewTextBoxColumn
        '
        Me.RundtDataGridViewTextBoxColumn.DataPropertyName = "rundt"
        Me.RundtDataGridViewTextBoxColumn.HeaderText = "rundt"
        Me.RundtDataGridViewTextBoxColumn.Name = "RundtDataGridViewTextBoxColumn"
        '
        'ProvidernmDataGridViewTextBoxColumn
        '
        Me.ProvidernmDataGridViewTextBoxColumn.DataPropertyName = "providernm"
        Me.ProvidernmDataGridViewTextBoxColumn.HeaderText = "providernm"
        Me.ProvidernmDataGridViewTextBoxColumn.Name = "ProvidernmDataGridViewTextBoxColumn"
        '
        'ReporttypeDataGridViewTextBoxColumn
        '
        Me.ReporttypeDataGridViewTextBoxColumn.DataPropertyName = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.HeaderText = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.Name = "ReporttypeDataGridViewTextBoxColumn"
        '
        'PracticeidDataGridViewTextBoxColumn
        '
        Me.PracticeidDataGridViewTextBoxColumn.DataPropertyName = "practiceid"
        Me.PracticeidDataGridViewTextBoxColumn.HeaderText = "practiceid"
        Me.PracticeidDataGridViewTextBoxColumn.Name = "PracticeidDataGridViewTextBoxColumn"
        '
        'ProvideridDataGridViewTextBoxColumn
        '
        Me.ProvideridDataGridViewTextBoxColumn.DataPropertyName = "providerid"
        Me.ProvideridDataGridViewTextBoxColumn.HeaderText = "providerid"
        Me.ProvideridDataGridViewTextBoxColumn.Name = "ProvideridDataGridViewTextBoxColumn"
        '
        'SlectDataGridViewCheckBoxColumn
        '
        Me.SlectDataGridViewCheckBoxColumn.DataPropertyName = "slect"
        Me.SlectDataGridViewCheckBoxColumn.HeaderText = "select"
        Me.SlectDataGridViewCheckBoxColumn.Name = "SlectDataGridViewCheckBoxColumn"
        Me.SlectDataGridViewCheckBoxColumn.Width = 50
        '
        'ProviderReportsNotFoundBindingSource
        '
        Me.ProviderReportsNotFoundBindingSource.DataMember = "ProviderReportsNotFound"
        Me.ProviderReportsNotFoundBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProvidersInToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteAllToolStripMenuItem, Me.UpdateToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DeleteAllToolStripMenuItem
        '
        Me.DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem"
        Me.DeleteAllToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.DeleteAllToolStripMenuItem.Text = "DeleteAll"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'ProvidersInToolStripMenuItem
        '
        Me.ProvidersInToolStripMenuItem.Name = "ProvidersInToolStripMenuItem"
        Me.ProvidersInToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.ProvidersInToolStripMenuItem.Text = "NewProviders"
        '
        'ProviderReportsNotFoundTableAdapter
        '
        Me.ProviderReportsNotFoundTableAdapter.ClearBeforeFill = True
        '
        'PRNotFound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ProcHdr)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PRNotFound"
        Me.Text = "PRNotFound"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProviderReportsNotFoundBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProcHdr As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ProviderReportsNotFoundTableAdapter As DataSet1TableAdapters.ProviderReportsNotFoundTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RundtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvidernmDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReporttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PracticeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvideridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SlectDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ProviderReportsNotFoundBindingSource As BindingSource
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProvidersInToolStripMenuItem As ToolStripMenuItem
End Class
