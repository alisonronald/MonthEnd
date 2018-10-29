<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PracticeSpecialties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PracticeSpecialties))
        Me.ProcHdr = New System.Windows.Forms.Label()
        Me.PracticeCombo = New System.Windows.Forms.ComboBox()
        Me.PracticeLbl = New System.Windows.Forms.Label()
        Me.SpecialtyLbl = New System.Windows.Forms.Label()
        Me.SpecialtyCombo = New System.Windows.Forms.ComboBox()
        Me.SpecialtiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.SpecsBtn = New System.Windows.Forms.Button()
        Me.RptBtn = New System.Windows.Forms.Button()
        Me.SpecialtiesTableAdapter = New MonthEnd.DataSet1TableAdapters.SpecialtiesTableAdapter()
        Me.WorkingLbl = New System.Windows.Forms.Label()
        CType(Me.SpecialtiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProcHdr
        '
        Me.ProcHdr.BackColor = System.Drawing.Color.Transparent
        Me.ProcHdr.Font = New System.Drawing.Font("Monotype Corsiva", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcHdr.ForeColor = System.Drawing.Color.White
        Me.ProcHdr.Location = New System.Drawing.Point(151, 4)
        Me.ProcHdr.Name = "ProcHdr"
        Me.ProcHdr.Size = New System.Drawing.Size(299, 49)
        Me.ProcHdr.TabIndex = 2
        Me.ProcHdr.Text = "Practice Specialties"
        '
        'PracticeCombo
        '
        Me.PracticeCombo.FormattingEnabled = True
        Me.PracticeCombo.Items.AddRange(New Object() {"", "Central Coast Cardiology", "PrimeCare", "Salinas Valley Medical Corporation", "Taylor Farms"})
        Me.PracticeCombo.Location = New System.Drawing.Point(95, 125)
        Me.PracticeCombo.Name = "PracticeCombo"
        Me.PracticeCombo.Size = New System.Drawing.Size(336, 21)
        Me.PracticeCombo.TabIndex = 3
        '
        'PracticeLbl
        '
        Me.PracticeLbl.AutoSize = True
        Me.PracticeLbl.BackColor = System.Drawing.Color.Transparent
        Me.PracticeLbl.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PracticeLbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PracticeLbl.Location = New System.Drawing.Point(91, 98)
        Me.PracticeLbl.Name = "PracticeLbl"
        Me.PracticeLbl.Size = New System.Drawing.Size(88, 25)
        Me.PracticeLbl.TabIndex = 4
        Me.PracticeLbl.Text = "Practices"
        '
        'SpecialtyLbl
        '
        Me.SpecialtyLbl.AutoSize = True
        Me.SpecialtyLbl.BackColor = System.Drawing.Color.Transparent
        Me.SpecialtyLbl.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialtyLbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SpecialtyLbl.Location = New System.Drawing.Point(91, 169)
        Me.SpecialtyLbl.Name = "SpecialtyLbl"
        Me.SpecialtyLbl.Size = New System.Drawing.Size(101, 25)
        Me.SpecialtyLbl.TabIndex = 6
        Me.SpecialtyLbl.Text = "Specialties"
        '
        'SpecialtyCombo
        '
        Me.SpecialtyCombo.DataSource = Me.SpecialtiesBindingSource
        Me.SpecialtyCombo.DisplayMember = "specialty"
        Me.SpecialtyCombo.FormattingEnabled = True
        Me.SpecialtyCombo.Location = New System.Drawing.Point(95, 196)
        Me.SpecialtyCombo.Name = "SpecialtyCombo"
        Me.SpecialtyCombo.Size = New System.Drawing.Size(336, 21)
        Me.SpecialtyCombo.TabIndex = 5
        Me.SpecialtyCombo.ValueMember = "specialtyid"
        '
        'SpecialtiesBindingSource
        '
        Me.SpecialtiesBindingSource.DataMember = "Specialties"
        Me.SpecialtiesBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpecsBtn
        '
        Me.SpecsBtn.ForeColor = System.Drawing.Color.Maroon
        Me.SpecsBtn.Location = New System.Drawing.Point(437, 123)
        Me.SpecsBtn.Name = "SpecsBtn"
        Me.SpecsBtn.Size = New System.Drawing.Size(75, 23)
        Me.SpecsBtn.TabIndex = 7
        Me.SpecsBtn.Text = "GetSpecs"
        Me.SpecsBtn.UseVisualStyleBackColor = True
        '
        'RptBtn
        '
        Me.RptBtn.ForeColor = System.Drawing.Color.Maroon
        Me.RptBtn.Location = New System.Drawing.Point(437, 194)
        Me.RptBtn.Name = "RptBtn"
        Me.RptBtn.Size = New System.Drawing.Size(75, 23)
        Me.RptBtn.TabIndex = 8
        Me.RptBtn.Text = "GetReport"
        Me.RptBtn.UseVisualStyleBackColor = True
        '
        'SpecialtiesTableAdapter
        '
        Me.SpecialtiesTableAdapter.ClearBeforeFill = True
        '
        'WorkingLbl
        '
        Me.WorkingLbl.AutoSize = True
        Me.WorkingLbl.BackColor = System.Drawing.Color.Transparent
        Me.WorkingLbl.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingLbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WorkingLbl.Location = New System.Drawing.Point(92, 229)
        Me.WorkingLbl.Name = "WorkingLbl"
        Me.WorkingLbl.Size = New System.Drawing.Size(103, 22)
        Me.WorkingLbl.TabIndex = 10
        Me.WorkingLbl.Text = "Working....."
        '
        'PracticeSpecialties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(609, 286)
        Me.Controls.Add(Me.WorkingLbl)
        Me.Controls.Add(Me.RptBtn)
        Me.Controls.Add(Me.SpecsBtn)
        Me.Controls.Add(Me.SpecialtyLbl)
        Me.Controls.Add(Me.SpecialtyCombo)
        Me.Controls.Add(Me.PracticeLbl)
        Me.Controls.Add(Me.PracticeCombo)
        Me.Controls.Add(Me.ProcHdr)
        Me.Name = "PracticeSpecialties"
        Me.Text = "PracticeSpecialties"
        CType(Me.SpecialtiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProcHdr As Label
    Friend WithEvents PracticeCombo As ComboBox
    Friend WithEvents PracticeLbl As Label
    Friend WithEvents SpecialtyLbl As Label
    Friend WithEvents SpecialtyCombo As ComboBox
    Friend WithEvents SpecsBtn As Button
    Friend WithEvents RptBtn As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents SpecialtiesBindingSource As BindingSource
    Friend WithEvents SpecialtiesTableAdapter As DataSet1TableAdapters.SpecialtiesTableAdapter
    Friend WithEvents WorkingLbl As Label
End Class
