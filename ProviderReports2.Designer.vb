<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProviderReports2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProviderReports2))
        Me.ProvHdr = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvideridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PracticenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReporttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportemailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeleteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProviderReports2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UpdateSendReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvidersNotFoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProviderRepodrtsSentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateSentRptsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProviderRptsSentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodingProfilesSentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProviderReportsAttributesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.ProviderReports2TableAdapter = New MonthEnd.DataSet1TableAdapters.ProviderReports2TableAdapter()
        Me.DellAllBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProviderReports2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProvHdr
        '
        Me.ProvHdr.BackColor = System.Drawing.Color.Transparent
        Me.ProvHdr.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvHdr.ForeColor = System.Drawing.Color.White
        Me.ProvHdr.Location = New System.Drawing.Point(339, 97)
        Me.ProvHdr.Name = "ProvHdr"
        Me.ProvHdr.Size = New System.Drawing.Size(592, 62)
        Me.ProvHdr.TabIndex = 3
        Me.ProvHdr.Text = "MaintainSendReports-ProviderRpts2"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.ProvideridDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.PracticenameDataGridViewTextBoxColumn, Me.ReporttypeDataGridViewTextBoxColumn, Me.ReportemailDataGridViewTextBoxColumn, Me.DeleteDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.ProviderReports2BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(235, 173)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(819, 402)
        Me.DataGridView1.TabIndex = 4
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecordidDataGridViewTextBoxColumn.Visible = False
        '
        'ProvideridDataGridViewTextBoxColumn
        '
        Me.ProvideridDataGridViewTextBoxColumn.DataPropertyName = "providerid"
        Me.ProvideridDataGridViewTextBoxColumn.HeaderText = "Providerid"
        Me.ProvideridDataGridViewTextBoxColumn.Name = "ProvideridDataGridViewTextBoxColumn"
        Me.ProvideridDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProvideridDataGridViewTextBoxColumn.Width = 75
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastnameDataGridViewTextBoxColumn.Width = 150
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstnameDataGridViewTextBoxColumn.Width = 150
        '
        'PracticenameDataGridViewTextBoxColumn
        '
        Me.PracticenameDataGridViewTextBoxColumn.DataPropertyName = "practicename"
        Me.PracticenameDataGridViewTextBoxColumn.HeaderText = "practicename"
        Me.PracticenameDataGridViewTextBoxColumn.Name = "PracticenameDataGridViewTextBoxColumn"
        Me.PracticenameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PracticenameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ReporttypeDataGridViewTextBoxColumn
        '
        Me.ReporttypeDataGridViewTextBoxColumn.DataPropertyName = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.HeaderText = "reporttype"
        Me.ReporttypeDataGridViewTextBoxColumn.Name = "ReporttypeDataGridViewTextBoxColumn"
        Me.ReporttypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReportemailDataGridViewTextBoxColumn
        '
        Me.ReportemailDataGridViewTextBoxColumn.DataPropertyName = "reportemail"
        Me.ReportemailDataGridViewTextBoxColumn.HeaderText = "reportemail"
        Me.ReportemailDataGridViewTextBoxColumn.Name = "ReportemailDataGridViewTextBoxColumn"
        Me.ReportemailDataGridViewTextBoxColumn.Width = 150
        '
        'DeleteDataGridViewCheckBoxColumn
        '
        Me.DeleteDataGridViewCheckBoxColumn.DataPropertyName = "delete"
        Me.DeleteDataGridViewCheckBoxColumn.HeaderText = "delete"
        Me.DeleteDataGridViewCheckBoxColumn.Name = "DeleteDataGridViewCheckBoxColumn"
        Me.DeleteDataGridViewCheckBoxColumn.Width = 50
        '
        'ProviderReports2BindingSource
        '
        Me.ProviderReports2BindingSource.DataMember = "ProviderReports2"
        Me.ProviderReports2BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateSendReportsToolStripMenuItem, Me.ProvidersNotFoundToolStripMenuItem, Me.ProviderRepodrtsSentToolStripMenuItem, Me.ProviderReportsAttributesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UpdateSendReportsToolStripMenuItem
        '
        Me.UpdateSendReportsToolStripMenuItem.Name = "UpdateSendReportsToolStripMenuItem"
        Me.UpdateSendReportsToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.UpdateSendReportsToolStripMenuItem.Text = "UpdateSelections"
        '
        'ProvidersNotFoundToolStripMenuItem
        '
        Me.ProvidersNotFoundToolStripMenuItem.Name = "ProvidersNotFoundToolStripMenuItem"
        Me.ProvidersNotFoundToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.ProvidersNotFoundToolStripMenuItem.Text = "ProvidersNotFound"
        '
        'ProviderRepodrtsSentToolStripMenuItem
        '
        Me.ProviderRepodrtsSentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateSentRptsToolStripMenuItem, Me.ProviderRptsSentToolStripMenuItem, Me.CodingProfilesSentToolStripMenuItem})
        Me.ProviderRepodrtsSentToolStripMenuItem.Name = "ProviderRepodrtsSentToolStripMenuItem"
        Me.ProviderRepodrtsSentToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.ProviderRepodrtsSentToolStripMenuItem.Text = "SentReports"
        '
        'UpdateSentRptsToolStripMenuItem
        '
        Me.UpdateSentRptsToolStripMenuItem.Name = "UpdateSentRptsToolStripMenuItem"
        Me.UpdateSentRptsToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.UpdateSentRptsToolStripMenuItem.Text = "UpdateSentRpts"
        '
        'ProviderRptsSentToolStripMenuItem
        '
        Me.ProviderRptsSentToolStripMenuItem.Name = "ProviderRptsSentToolStripMenuItem"
        Me.ProviderRptsSentToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ProviderRptsSentToolStripMenuItem.Text = "ProviderRptsSent"
        '
        'CodingProfilesSentToolStripMenuItem
        '
        Me.CodingProfilesSentToolStripMenuItem.Name = "CodingProfilesSentToolStripMenuItem"
        Me.CodingProfilesSentToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CodingProfilesSentToolStripMenuItem.Text = "CodingProfilesSent"
        '
        'ProviderReportsAttributesToolStripMenuItem
        '
        Me.ProviderReportsAttributesToolStripMenuItem.Name = "ProviderReportsAttributesToolStripMenuItem"
        Me.ProviderReportsAttributesToolStripMenuItem.Size = New System.Drawing.Size(155, 20)
        Me.ProviderReportsAttributesToolStripMenuItem.Text = "ProviderReportsAttributes"
        '
        'DelBtn
        '
        Me.DelBtn.BackgroundImage = CType(resources.GetObject("DelBtn.BackgroundImage"), System.Drawing.Image)
        Me.DelBtn.ForeColor = System.Drawing.Color.White
        Me.DelBtn.Location = New System.Drawing.Point(979, 151)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(75, 23)
        Me.DelBtn.TabIndex = 6
        Me.DelBtn.Text = "DeleteType"
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'ProviderReports2TableAdapter
        '
        Me.ProviderReports2TableAdapter.ClearBeforeFill = True
        '
        'DellAllBtn
        '
        Me.DellAllBtn.BackgroundImage = CType(resources.GetObject("DellAllBtn.BackgroundImage"), System.Drawing.Image)
        Me.DellAllBtn.ForeColor = System.Drawing.Color.White
        Me.DellAllBtn.Location = New System.Drawing.Point(235, 151)
        Me.DellAllBtn.Name = "DellAllBtn"
        Me.DellAllBtn.Size = New System.Drawing.Size(75, 23)
        Me.DellAllBtn.TabIndex = 7
        Me.DellAllBtn.Text = "Delete All"
        Me.DellAllBtn.UseVisualStyleBackColor = True
        '
        'ProviderReports2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.DellAllBtn)
        Me.Controls.Add(Me.DelBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ProvHdr)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ProviderReports2"
        Me.Text = "ProviderReports2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProviderReports2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProvHdr As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ProviderReports2BindingSource As BindingSource
    Friend WithEvents ProviderReports2TableAdapter As DataSet1TableAdapters.ProviderReports2TableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UpdateSendReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvideridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PracticenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReporttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportemailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeleteDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DelBtn As Button
    Friend WithEvents ProvidersNotFoundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProviderRepodrtsSentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateSentRptsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProviderRptsSentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DellAllBtn As Button
    Friend WithEvents ProviderReportsAttributesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CodingProfilesSentToolStripMenuItem As ToolStripMenuItem
End Class
