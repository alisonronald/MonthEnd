<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MEDirectories
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MEDirectories))
        Me.MEDirHdr = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.DataSet11 = New MonthEnd.DataSet1()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet12 = New MonthEnd.DataSet1()
        Me.CopyFoldersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CopyFoldersTableAdapter = New MonthEnd.DataSet1TableAdapters.CopyFoldersTableAdapter()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatatypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromfldrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TofldrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CopyFoldersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MEDirHdr
        '
        Me.MEDirHdr.BackColor = System.Drawing.Color.Transparent
        Me.MEDirHdr.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEDirHdr.ForeColor = System.Drawing.Color.White
        Me.MEDirHdr.Location = New System.Drawing.Point(390, 121)
        Me.MEDirHdr.Name = "MEDirHdr"
        Me.MEDirHdr.Size = New System.Drawing.Size(487, 62)
        Me.MEDirHdr.TabIndex = 2
        Me.MEDirHdr.Text = "Maintain File Directories"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.InsertToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InsertToolStripMenuItem.Text = "Insert"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.DatatypeDataGridViewTextBoxColumn, Me.FromfldrDataGridViewTextBoxColumn, Me.TofldrDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CopyFoldersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(168, 203)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(943, 370)
        Me.DataGridView1.TabIndex = 7
        '
        'DataSet12
        '
        Me.DataSet12.DataSetName = "DataSet1"
        Me.DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CopyFoldersBindingSource
        '
        Me.CopyFoldersBindingSource.DataMember = "CopyFolders"
        Me.CopyFoldersBindingSource.DataSource = Me.DataSet12
        '
        'CopyFoldersTableAdapter
        '
        Me.CopyFoldersTableAdapter.ClearBeforeFill = True
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatatypeDataGridViewTextBoxColumn
        '
        Me.DatatypeDataGridViewTextBoxColumn.DataPropertyName = "datatype"
        Me.DatatypeDataGridViewTextBoxColumn.HeaderText = "datatype"
        Me.DatatypeDataGridViewTextBoxColumn.Name = "DatatypeDataGridViewTextBoxColumn"
        '
        'FromfldrDataGridViewTextBoxColumn
        '
        Me.FromfldrDataGridViewTextBoxColumn.DataPropertyName = "fromfldr"
        Me.FromfldrDataGridViewTextBoxColumn.HeaderText = "fromfldr"
        Me.FromfldrDataGridViewTextBoxColumn.Name = "FromfldrDataGridViewTextBoxColumn"
        Me.FromfldrDataGridViewTextBoxColumn.Width = 300
        '
        'TofldrDataGridViewTextBoxColumn
        '
        Me.TofldrDataGridViewTextBoxColumn.DataPropertyName = "tofldr"
        Me.TofldrDataGridViewTextBoxColumn.HeaderText = "tofldr"
        Me.TofldrDataGridViewTextBoxColumn.Name = "TofldrDataGridViewTextBoxColumn"
        Me.TofldrDataGridViewTextBoxColumn.Width = 300
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'MEDirectories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MEDirHdr)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MEDirectories"
        Me.Text = "MEDirectories"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CopyFoldersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MEDirHdr As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet12 As DataSet1
    Friend WithEvents CopyFoldersBindingSource As BindingSource
    Friend WithEvents CopyFoldersTableAdapter As DataSet1TableAdapters.CopyFoldersTableAdapter
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatatypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FromfldrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TofldrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
