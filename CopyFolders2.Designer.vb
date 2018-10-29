<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CopyFolders2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CopyFolders2))
        Me.CP2Hdr = New System.Windows.Forms.Label()
        Me.CopyFolders2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.CopyFolders2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CopyFolders2TableAdapter = New MonthEnd.DataSet1TableAdapters.CopyFolders2TableAdapter()
        Me.CopyBtn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatatypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromfldrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TofldrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.CopyFolders2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CopyFolders2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CP2Hdr
        '
        Me.CP2Hdr.BackColor = System.Drawing.Color.Transparent
        Me.CP2Hdr.Font = New System.Drawing.Font("Monotype Corsiva", 32.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CP2Hdr.ForeColor = System.Drawing.Color.White
        Me.CP2Hdr.Location = New System.Drawing.Point(405, 115)
        Me.CP2Hdr.Name = "CP2Hdr"
        Me.CP2Hdr.Size = New System.Drawing.Size(454, 62)
        Me.CP2Hdr.TabIndex = 2
        Me.CP2Hdr.Text = "Copy Folders And Files"
        '
        'CopyFolders2DataGridView
        '
        Me.CopyFolders2DataGridView.AutoGenerateColumns = False
        Me.CopyFolders2DataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CopyFolders2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CopyFolders2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.DatatypeDataGridViewTextBoxColumn, Me.FromfldrDataGridViewTextBoxColumn, Me.TofldrDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.MoveDataGridViewCheckBoxColumn})
        Me.CopyFolders2DataGridView.DataSource = Me.CopyFolders2BindingSource
        Me.CopyFolders2DataGridView.Location = New System.Drawing.Point(156, 217)
        Me.CopyFolders2DataGridView.Name = "CopyFolders2DataGridView"
        Me.CopyFolders2DataGridView.Size = New System.Drawing.Size(994, 417)
        Me.CopyFolders2DataGridView.TabIndex = 3
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CopyFolders2BindingSource
        '
        Me.CopyFolders2BindingSource.DataMember = "CopyFolders2"
        Me.CopyFolders2BindingSource.DataSource = Me.DataSet1
        '
        'CopyFolders2TableAdapter
        '
        Me.CopyFolders2TableAdapter.ClearBeforeFill = True
        '
        'CopyBtn
        '
        Me.CopyBtn.BackColor = System.Drawing.Color.Transparent
        Me.CopyBtn.BackgroundImage = CType(resources.GetObject("CopyBtn.BackgroundImage"), System.Drawing.Image)
        Me.CopyBtn.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyBtn.ForeColor = System.Drawing.Color.OrangeRed
        Me.CopyBtn.Location = New System.Drawing.Point(962, 181)
        Me.CopyBtn.Name = "CopyBtn"
        Me.CopyBtn.Size = New System.Drawing.Size(189, 35)
        Me.CopyBtn.TabIndex = 12
        Me.CopyBtn.Text = "CopyFolders/Files"
        Me.CopyBtn.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecordidDataGridViewTextBoxColumn.Width = 50
        '
        'DatatypeDataGridViewTextBoxColumn
        '
        Me.DatatypeDataGridViewTextBoxColumn.DataPropertyName = "datatype"
        Me.DatatypeDataGridViewTextBoxColumn.HeaderText = "datatype"
        Me.DatatypeDataGridViewTextBoxColumn.Name = "DatatypeDataGridViewTextBoxColumn"
        Me.DatatypeDataGridViewTextBoxColumn.Width = 75
        '
        'FromfldrDataGridViewTextBoxColumn
        '
        Me.FromfldrDataGridViewTextBoxColumn.DataPropertyName = "fromfldr"
        Me.FromfldrDataGridViewTextBoxColumn.HeaderText = "fromfldr"
        Me.FromfldrDataGridViewTextBoxColumn.Name = "FromfldrDataGridViewTextBoxColumn"
        Me.FromfldrDataGridViewTextBoxColumn.Width = 350
        '
        'TofldrDataGridViewTextBoxColumn
        '
        Me.TofldrDataGridViewTextBoxColumn.DataPropertyName = "tofldr"
        Me.TofldrDataGridViewTextBoxColumn.HeaderText = "tofldr"
        Me.TofldrDataGridViewTextBoxColumn.Name = "TofldrDataGridViewTextBoxColumn"
        Me.TofldrDataGridViewTextBoxColumn.Width = 350
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.Width = 75
        '
        'MoveDataGridViewCheckBoxColumn
        '
        Me.MoveDataGridViewCheckBoxColumn.DataPropertyName = "move"
        Me.MoveDataGridViewCheckBoxColumn.HeaderText = "move"
        Me.MoveDataGridViewCheckBoxColumn.Name = "MoveDataGridViewCheckBoxColumn"
        Me.MoveDataGridViewCheckBoxColumn.Width = 50
        '
        'CopyFolders2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.CopyBtn)
        Me.Controls.Add(Me.CopyFolders2DataGridView)
        Me.Controls.Add(Me.CP2Hdr)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CopyFolders2"
        Me.Text = "CopyFolders2"
        CType(Me.CopyFolders2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CopyFolders2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CP2Hdr As Label
    Friend WithEvents CopyFolders2DataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents CopyFolders2BindingSource As BindingSource
    Friend WithEvents CopyFolders2TableAdapter As DataSet1TableAdapters.CopyFolders2TableAdapter
    Friend WithEvents CopyBtn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatatypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FromfldrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TofldrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
