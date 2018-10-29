<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Audit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Audit))
        Me.AuditHdr = New System.Windows.Forms.Label()
        Me.WorkingLbl = New System.Windows.Forms.Label()
        Me.AuditDataGridView = New System.Windows.Forms.DataGridView()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TofldrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CopyFolders3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.CopyFolders3TableAdapter = New MonthEnd.DataSet1TableAdapters.CopyFolders3TableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadBtn = New System.Windows.Forms.Button()
        CType(Me.AuditDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CopyFolders3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AuditHdr
        '
        Me.AuditHdr.BackColor = System.Drawing.Color.Transparent
        Me.AuditHdr.Font = New System.Drawing.Font("Monotype Corsiva", 32.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuditHdr.ForeColor = System.Drawing.Color.White
        Me.AuditHdr.Location = New System.Drawing.Point(491, 113)
        Me.AuditHdr.Name = "AuditHdr"
        Me.AuditHdr.Size = New System.Drawing.Size(284, 62)
        Me.AuditHdr.TabIndex = 2
        Me.AuditHdr.Text = "Audit Processing"
        '
        'WorkingLbl
        '
        Me.WorkingLbl.AutoSize = True
        Me.WorkingLbl.BackColor = System.Drawing.Color.Transparent
        Me.WorkingLbl.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingLbl.ForeColor = System.Drawing.Color.White
        Me.WorkingLbl.Location = New System.Drawing.Point(348, 181)
        Me.WorkingLbl.Name = "WorkingLbl"
        Me.WorkingLbl.Size = New System.Drawing.Size(103, 22)
        Me.WorkingLbl.TabIndex = 8
        Me.WorkingLbl.Text = "Working....."
        '
        'AuditDataGridView
        '
        Me.AuditDataGridView.AutoGenerateColumns = False
        Me.AuditDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.AuditDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AuditDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.TofldrDataGridViewTextBoxColumn, Me.MoveDataGridViewCheckBoxColumn})
        Me.AuditDataGridView.DataSource = Me.CopyFolders3BindingSource
        Me.AuditDataGridView.Location = New System.Drawing.Point(324, 206)
        Me.AuditDataGridView.Name = "AuditDataGridView"
        Me.AuditDataGridView.Size = New System.Drawing.Size(636, 423)
        Me.AuditDataGridView.TabIndex = 9
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TofldrDataGridViewTextBoxColumn
        '
        Me.TofldrDataGridViewTextBoxColumn.DataPropertyName = "tofldr"
        Me.TofldrDataGridViewTextBoxColumn.HeaderText = "tofldr"
        Me.TofldrDataGridViewTextBoxColumn.Name = "TofldrDataGridViewTextBoxColumn"
        Me.TofldrDataGridViewTextBoxColumn.Width = 400
        '
        'MoveDataGridViewCheckBoxColumn
        '
        Me.MoveDataGridViewCheckBoxColumn.DataPropertyName = "move"
        Me.MoveDataGridViewCheckBoxColumn.HeaderText = "move"
        Me.MoveDataGridViewCheckBoxColumn.Name = "MoveDataGridViewCheckBoxColumn"
        '
        'CopyFolders3BindingSource
        '
        Me.CopyFolders3BindingSource.DataMember = "CopyFolders3"
        Me.CopyFolders3BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CopyFolders3TableAdapter
        '
        Me.CopyFolders3TableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'LoadBtn
        '
        Me.LoadBtn.BackColor = System.Drawing.Color.Transparent
        Me.LoadBtn.BackgroundImage = CType(resources.GetObject("LoadBtn.BackgroundImage"), System.Drawing.Image)
        Me.LoadBtn.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBtn.ForeColor = System.Drawing.Color.Red
        Me.LoadBtn.Location = New System.Drawing.Point(829, 171)
        Me.LoadBtn.Name = "LoadBtn"
        Me.LoadBtn.Size = New System.Drawing.Size(127, 35)
        Me.LoadBtn.TabIndex = 11
        Me.LoadBtn.Text = "LoadData"
        Me.LoadBtn.UseVisualStyleBackColor = False
        '
        'Audit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.LoadBtn)
        Me.Controls.Add(Me.AuditDataGridView)
        Me.Controls.Add(Me.WorkingLbl)
        Me.Controls.Add(Me.AuditHdr)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Audit"
        Me.Text = "Audit"
        CType(Me.AuditDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CopyFolders3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AuditHdr As Label
    Friend WithEvents WorkingLbl As Label
    Friend WithEvents AuditDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents CopyFolders3BindingSource As BindingSource
    Friend WithEvents CopyFolders3TableAdapter As DataSet1TableAdapters.CopyFolders3TableAdapter
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TofldrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadBtn As Button
End Class
