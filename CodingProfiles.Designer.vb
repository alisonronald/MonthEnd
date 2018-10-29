<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodingProfiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CodingProfiles))
        Me.CPHdr = New System.Windows.Forms.Label()
        Me.CodingProfileDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodingProfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.CodingProfilesTableAdapter = New MonthEnd.DataSet1TableAdapters.CodingProfilesTableAdapter()
        Me.WorkingLbl = New System.Windows.Forms.Label()
        Me.CPWrite = New System.Windows.Forms.Button()
        Me.rundt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProviderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CprofileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfcntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PgroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvidertypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CodingProfileDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodingProfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CPHdr
        '
        Me.CPHdr.BackColor = System.Drawing.Color.Transparent
        Me.CPHdr.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPHdr.ForeColor = System.Drawing.Color.White
        Me.CPHdr.Location = New System.Drawing.Point(474, 105)
        Me.CPHdr.Name = "CPHdr"
        Me.CPHdr.Size = New System.Drawing.Size(294, 62)
        Me.CPHdr.TabIndex = 2
        Me.CPHdr.Text = "CodingProfiles"
        '
        'CodingProfileDataGridView
        '
        Me.CodingProfileDataGridView.AutoGenerateColumns = False
        Me.CodingProfileDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.CodingProfileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CodingProfileDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rundt, Me.ProviderDataGridViewTextBoxColumn, Me.CprofileDataGridViewTextBoxColumn, Me.ProfcntDataGridViewTextBoxColumn, Me.PgroupDataGridViewTextBoxColumn, Me.ProvidertypeDataGridViewTextBoxColumn})
        Me.CodingProfileDataGridView.DataSource = Me.CodingProfilesBindingSource
        Me.CodingProfileDataGridView.Location = New System.Drawing.Point(265, 191)
        Me.CodingProfileDataGridView.Name = "CodingProfileDataGridView"
        Me.CodingProfileDataGridView.Size = New System.Drawing.Size(768, 369)
        Me.CodingProfileDataGridView.TabIndex = 3
        '
        'CodingProfilesBindingSource
        '
        Me.CodingProfilesBindingSource.DataMember = "CodingProfiles"
        Me.CodingProfilesBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CodingProfilesTableAdapter
        '
        Me.CodingProfilesTableAdapter.ClearBeforeFill = True
        '
        'WorkingLbl
        '
        Me.WorkingLbl.AutoSize = True
        Me.WorkingLbl.BackColor = System.Drawing.Color.Transparent
        Me.WorkingLbl.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingLbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WorkingLbl.Location = New System.Drawing.Point(281, 163)
        Me.WorkingLbl.Name = "WorkingLbl"
        Me.WorkingLbl.Size = New System.Drawing.Size(103, 22)
        Me.WorkingLbl.TabIndex = 8
        Me.WorkingLbl.Text = "Working....."
        '
        'CPWrite
        '
        Me.CPWrite.BackColor = System.Drawing.Color.Transparent
        Me.CPWrite.BackgroundImage = CType(resources.GetObject("CPWrite.BackgroundImage"), System.Drawing.Image)
        Me.CPWrite.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPWrite.ForeColor = System.Drawing.Color.Red
        Me.CPWrite.Location = New System.Drawing.Point(861, 154)
        Me.CPWrite.Name = "CPWrite"
        Me.CPWrite.Size = New System.Drawing.Size(127, 36)
        Me.CPWrite.TabIndex = 7
        Me.CPWrite.Text = "WriteDetail"
        Me.CPWrite.UseVisualStyleBackColor = False
        '
        'rundt
        '
        Me.rundt.DataPropertyName = "rundt"
        Me.rundt.HeaderText = "RunDt"
        Me.rundt.Name = "rundt"
        Me.rundt.Width = 75
        '
        'ProviderDataGridViewTextBoxColumn
        '
        Me.ProviderDataGridViewTextBoxColumn.DataPropertyName = "provider"
        Me.ProviderDataGridViewTextBoxColumn.HeaderText = "provider"
        Me.ProviderDataGridViewTextBoxColumn.Name = "ProviderDataGridViewTextBoxColumn"
        Me.ProviderDataGridViewTextBoxColumn.Width = 250
        '
        'CprofileDataGridViewTextBoxColumn
        '
        Me.CprofileDataGridViewTextBoxColumn.DataPropertyName = "cprofile"
        Me.CprofileDataGridViewTextBoxColumn.HeaderText = "codingprofile"
        Me.CprofileDataGridViewTextBoxColumn.Name = "CprofileDataGridViewTextBoxColumn"
        '
        'ProfcntDataGridViewTextBoxColumn
        '
        Me.ProfcntDataGridViewTextBoxColumn.DataPropertyName = "profcnt"
        Me.ProfcntDataGridViewTextBoxColumn.HeaderText = "profilecnt"
        Me.ProfcntDataGridViewTextBoxColumn.Name = "ProfcntDataGridViewTextBoxColumn"
        '
        'PgroupDataGridViewTextBoxColumn
        '
        Me.PgroupDataGridViewTextBoxColumn.DataPropertyName = "pgroup"
        Me.PgroupDataGridViewTextBoxColumn.HeaderText = "database"
        Me.PgroupDataGridViewTextBoxColumn.Name = "PgroupDataGridViewTextBoxColumn"
        '
        'ProvidertypeDataGridViewTextBoxColumn
        '
        Me.ProvidertypeDataGridViewTextBoxColumn.DataPropertyName = "providertype"
        Me.ProvidertypeDataGridViewTextBoxColumn.HeaderText = "providertype"
        Me.ProvidertypeDataGridViewTextBoxColumn.Name = "ProvidertypeDataGridViewTextBoxColumn"
        '
        'CodingProfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 657)
        Me.Controls.Add(Me.WorkingLbl)
        Me.Controls.Add(Me.CPWrite)
        Me.Controls.Add(Me.CodingProfileDataGridView)
        Me.Controls.Add(Me.CPHdr)
        Me.Name = "CodingProfiles"
        Me.Text = "CodingProfiles"
        CType(Me.CodingProfileDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodingProfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CPHdr As Label
    Friend WithEvents CodingProfileDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents CodingProfilesBindingSource As BindingSource
    Friend WithEvents CodingProfilesTableAdapter As DataSet1TableAdapters.CodingProfilesTableAdapter
    Friend WithEvents WorkingLbl As Label
    Friend WithEvents CPWrite As Button
    Friend WithEvents rundt As DataGridViewTextBoxColumn
    Friend WithEvents ProviderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CprofileDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProfcntDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PgroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvidertypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
