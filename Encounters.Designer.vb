<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Encounters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Encounters))
        Me.EncountersHdr = New System.Windows.Forms.Label()
        Me.EncountersWrite = New System.Windows.Forms.Button()
        Me.WorkingLbl = New System.Windows.Forms.Label()
        Me.EncountersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.SVMCEncountersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SVMCEncountersTableAdapter = New MonthEnd.DataSet1TableAdapters.SVMCEncountersTableAdapter()
        Me.RecorIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EncountersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.EncountersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SVMCEncountersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EncountersHdr
        '
        Me.EncountersHdr.BackColor = System.Drawing.Color.Transparent
        Me.EncountersHdr.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EncountersHdr.ForeColor = System.Drawing.Color.White
        Me.EncountersHdr.Location = New System.Drawing.Point(428, 109)
        Me.EncountersHdr.Name = "EncountersHdr"
        Me.EncountersHdr.Size = New System.Drawing.Size(373, 62)
        Me.EncountersHdr.TabIndex = 3
        Me.EncountersHdr.Text = "SVMC Encounters"
        '
        'EncountersWrite
        '
        Me.EncountersWrite.BackColor = System.Drawing.Color.Transparent
        Me.EncountersWrite.BackgroundImage = CType(resources.GetObject("EncountersWrite.BackgroundImage"), System.Drawing.Image)
        Me.EncountersWrite.Font = New System.Drawing.Font("Monotype Corsiva", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EncountersWrite.ForeColor = System.Drawing.Color.Red
        Me.EncountersWrite.Location = New System.Drawing.Point(617, 197)
        Me.EncountersWrite.Name = "EncountersWrite"
        Me.EncountersWrite.Size = New System.Drawing.Size(161, 36)
        Me.EncountersWrite.TabIndex = 9
        Me.EncountersWrite.Text = "WriteEncounters"
        Me.EncountersWrite.UseVisualStyleBackColor = False
        '
        'WorkingLbl
        '
        Me.WorkingLbl.AutoSize = True
        Me.WorkingLbl.BackColor = System.Drawing.Color.Transparent
        Me.WorkingLbl.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingLbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WorkingLbl.Location = New System.Drawing.Point(431, 211)
        Me.WorkingLbl.Name = "WorkingLbl"
        Me.WorkingLbl.Size = New System.Drawing.Size(103, 22)
        Me.WorkingLbl.TabIndex = 10
        Me.WorkingLbl.Text = "Working....."
        '
        'EncountersDataGridView
        '
        Me.EncountersDataGridView.AllowUserToAddRows = False
        Me.EncountersDataGridView.AllowUserToDeleteRows = False
        Me.EncountersDataGridView.AutoGenerateColumns = False
        Me.EncountersDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.EncountersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EncountersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecorIdDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.EncountersDataGridViewTextBoxColumn})
        Me.EncountersDataGridView.DataSource = Me.SVMCEncountersBindingSource
        Me.EncountersDataGridView.Location = New System.Drawing.Point(435, 235)
        Me.EncountersDataGridView.Name = "EncountersDataGridView"
        Me.EncountersDataGridView.ReadOnly = True
        Me.EncountersDataGridView.Size = New System.Drawing.Size(343, 321)
        Me.EncountersDataGridView.TabIndex = 11
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SVMCEncountersBindingSource
        '
        Me.SVMCEncountersBindingSource.DataMember = "SVMCEncounters"
        Me.SVMCEncountersBindingSource.DataSource = Me.DataSet1
        '
        'SVMCEncountersTableAdapter
        '
        Me.SVMCEncountersTableAdapter.ClearBeforeFill = True
        '
        'RecorIdDataGridViewTextBoxColumn
        '
        Me.RecorIdDataGridViewTextBoxColumn.DataPropertyName = "RecorId"
        Me.RecorIdDataGridViewTextBoxColumn.HeaderText = "RecorId"
        Me.RecorIdDataGridViewTextBoxColumn.Name = "RecorIdDataGridViewTextBoxColumn"
        Me.RecorIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EncountersDataGridViewTextBoxColumn
        '
        Me.EncountersDataGridViewTextBoxColumn.DataPropertyName = "Encounters"
        Me.EncountersDataGridViewTextBoxColumn.HeaderText = "Encounters"
        Me.EncountersDataGridViewTextBoxColumn.Name = "EncountersDataGridViewTextBoxColumn"
        Me.EncountersDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Encounters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.EncountersDataGridView)
        Me.Controls.Add(Me.WorkingLbl)
        Me.Controls.Add(Me.EncountersWrite)
        Me.Controls.Add(Me.EncountersHdr)
        Me.Name = "Encounters"
        Me.Text = "Encounters"
        CType(Me.EncountersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SVMCEncountersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EncountersHdr As Label
    Friend WithEvents EncountersWrite As Button
    Friend WithEvents WorkingLbl As Label
    Friend WithEvents EncountersDataGridView As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents SVMCEncountersBindingSource As BindingSource
    Friend WithEvents SVMCEncountersTableAdapter As DataSet1TableAdapters.SVMCEncountersTableAdapter
    Friend WithEvents RecorIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EncountersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
