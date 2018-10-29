<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NXReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NXReport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RecordidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RunDtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PractitionerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PracStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NXReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.NXReportTableAdapter = New MonthEnd.DataSet1TableAdapters.NXReportTableAdapter()
        Me.WriteBtn = New System.Windows.Forms.Button()
        Me.WorkingLbl = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GetNewDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NXReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(433, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 62)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NXHealth Reporting"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecordidDataGridViewTextBoxColumn, Me.RunDtDataGridViewTextBoxColumn, Me.PractitionerDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MIDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.PracStatusDataGridViewTextBoxColumn, Me.PSDateDataGridViewTextBoxColumn, Me.AppDateDataGridViewTextBoxColumn, Me.PCPDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.NXReportBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(119, 212)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1069, 362)
        Me.DataGridView1.TabIndex = 2
        '
        'RecordidDataGridViewTextBoxColumn
        '
        Me.RecordidDataGridViewTextBoxColumn.DataPropertyName = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.HeaderText = "recordid"
        Me.RecordidDataGridViewTextBoxColumn.Name = "RecordidDataGridViewTextBoxColumn"
        Me.RecordidDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecordidDataGridViewTextBoxColumn.Visible = False
        '
        'RunDtDataGridViewTextBoxColumn
        '
        Me.RunDtDataGridViewTextBoxColumn.DataPropertyName = "RunDt"
        Me.RunDtDataGridViewTextBoxColumn.HeaderText = "RunDt"
        Me.RunDtDataGridViewTextBoxColumn.Name = "RunDtDataGridViewTextBoxColumn"
        '
        'PractitionerDataGridViewTextBoxColumn
        '
        Me.PractitionerDataGridViewTextBoxColumn.DataPropertyName = "Practitioner"
        Me.PractitionerDataGridViewTextBoxColumn.HeaderText = "Practitioner"
        Me.PractitionerDataGridViewTextBoxColumn.Name = "PractitionerDataGridViewTextBoxColumn"
        Me.PractitionerDataGridViewTextBoxColumn.Width = 75
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.Width = 150
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.Width = 150
        '
        'MIDataGridViewTextBoxColumn
        '
        Me.MIDataGridViewTextBoxColumn.DataPropertyName = "MI"
        Me.MIDataGridViewTextBoxColumn.HeaderText = "MI"
        Me.MIDataGridViewTextBoxColumn.Name = "MIDataGridViewTextBoxColumn"
        Me.MIDataGridViewTextBoxColumn.Width = 50
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.Width = 50
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'PracStatusDataGridViewTextBoxColumn
        '
        Me.PracStatusDataGridViewTextBoxColumn.DataPropertyName = "PracStatus"
        Me.PracStatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.PracStatusDataGridViewTextBoxColumn.Name = "PracStatusDataGridViewTextBoxColumn"
        '
        'PSDateDataGridViewTextBoxColumn
        '
        Me.PSDateDataGridViewTextBoxColumn.DataPropertyName = "PSDate"
        Me.PSDateDataGridViewTextBoxColumn.HeaderText = "StatusDate"
        Me.PSDateDataGridViewTextBoxColumn.Name = "PSDateDataGridViewTextBoxColumn"
        '
        'AppDateDataGridViewTextBoxColumn
        '
        Me.AppDateDataGridViewTextBoxColumn.DataPropertyName = "AppDate"
        Me.AppDateDataGridViewTextBoxColumn.HeaderText = "StartDate"
        Me.AppDateDataGridViewTextBoxColumn.Name = "AppDateDataGridViewTextBoxColumn"
        '
        'PCPDataGridViewTextBoxColumn
        '
        Me.PCPDataGridViewTextBoxColumn.DataPropertyName = "PCP"
        Me.PCPDataGridViewTextBoxColumn.HeaderText = "PCP"
        Me.PCPDataGridViewTextBoxColumn.Name = "PCPDataGridViewTextBoxColumn"
        Me.PCPDataGridViewTextBoxColumn.Width = 50
        '
        'NXReportBindingSource
        '
        Me.NXReportBindingSource.DataMember = "NXReport"
        Me.NXReportBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NXReportTableAdapter
        '
        Me.NXReportTableAdapter.ClearBeforeFill = True
        '
        'WriteBtn
        '
        Me.WriteBtn.BackColor = System.Drawing.Color.Transparent
        Me.WriteBtn.BackgroundImage = CType(resources.GetObject("WriteBtn.BackgroundImage"), System.Drawing.Image)
        Me.WriteBtn.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WriteBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WriteBtn.Location = New System.Drawing.Point(995, 170)
        Me.WriteBtn.Name = "WriteBtn"
        Me.WriteBtn.Size = New System.Drawing.Size(189, 36)
        Me.WriteBtn.TabIndex = 12
        Me.WriteBtn.Text = "Write/Send Result"
        Me.WriteBtn.UseVisualStyleBackColor = False
        '
        'WorkingLbl
        '
        Me.WorkingLbl.AutoSize = True
        Me.WorkingLbl.BackColor = System.Drawing.Color.Transparent
        Me.WorkingLbl.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingLbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WorkingLbl.Location = New System.Drawing.Point(127, 184)
        Me.WorkingLbl.Name = "WorkingLbl"
        Me.WorkingLbl.Size = New System.Drawing.Size(93, 22)
        Me.WorkingLbl.TabIndex = 13
        Me.WorkingLbl.Text = "Working..."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetNewDataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GetNewDataToolStripMenuItem
        '
        Me.GetNewDataToolStripMenuItem.Name = "GetNewDataToolStripMenuItem"
        Me.GetNewDataToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.GetNewDataToolStripMenuItem.Text = "GetNewData"
        '
        'NXReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.WorkingLbl)
        Me.Controls.Add(Me.WriteBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "NXReport"
        Me.Text = "NXReport"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NXReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents NXReportBindingSource As BindingSource
    Friend WithEvents NXReportTableAdapter As DataSet1TableAdapters.NXReportTableAdapter
    Friend WithEvents RecordidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RunDtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PractitionerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PracStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PSDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PCPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WriteBtn As Button
    Friend WithEvents WorkingLbl As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GetNewDataToolStripMenuItem As ToolStripMenuItem
End Class
