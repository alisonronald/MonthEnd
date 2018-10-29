<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MEProcessing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MEProcessing))
        Me.ProcHdr = New System.Windows.Forms.Label()
        Me.DataSet1 = New MonthEnd.DataSet1()
        Me.RunTTM = New System.Windows.Forms.LinkLabel()
        Me.RunPatientDetail = New System.Windows.Forms.LinkLabel()
        Me.LoadDataTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New MonthEnd.DataSet1()
        Me.LoadDataTypesTableAdapter = New MonthEnd.DataSet1TableAdapters.LoadDataTypesTableAdapter()
        Me.PracticegroupBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet12 = New MonthEnd.DataSet1()
        Me.ClearLoadTables = New System.Windows.Forms.LinkLabel()
        Me.RunCodingProfiles = New System.Windows.Forms.LinkLabel()
        Me.PracticegroupTableAdapter = New MonthEnd.DataSet1TableAdapters.practicegroupTableAdapter()
        Me.EncountersLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.MissingChargesLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PatientDetailAuditLink = New System.Windows.Forms.LinkLabel()
        Me.Supervisor_LinkLbl = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportsCheckListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MergeProfilesLbl = New System.Windows.Forms.LinkLabel()
        Me.LoadDropDown = New System.Windows.Forms.ComboBox()
        Me.Loadlbl = New System.Windows.Forms.Label()
        Me.GoBtn = New System.Windows.Forms.Button()
        Me.PGDropDown = New System.Windows.Forms.ComboBox()
        Me.PGroupLbl = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.RunDirectories = New System.Windows.Forms.LinkLabel()
        Me.WorkingFoldersLbl = New System.Windows.Forms.LinkLabel()
        Me.MEProviders = New System.Windows.Forms.LinkLabel()
        Me.SpecialProcessingLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PR2LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.DistributionLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AdminRptsLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.CPSpecialtiesLbl = New System.Windows.Forms.LinkLabel()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadDataTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PracticegroupBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProcHdr
        '
        Me.ProcHdr.BackColor = System.Drawing.Color.Transparent
        Me.ProcHdr.Font = New System.Drawing.Font("Monotype Corsiva", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcHdr.ForeColor = System.Drawing.Color.White
        Me.ProcHdr.Location = New System.Drawing.Point(422, 98)
        Me.ProcHdr.Name = "ProcHdr"
        Me.ProcHdr.Size = New System.Drawing.Size(414, 62)
        Me.ProcHdr.TabIndex = 1
        Me.ProcHdr.Text = "Monthend Processing"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RunTTM
        '
        Me.RunTTM.AutoEllipsis = True
        Me.RunTTM.BackColor = System.Drawing.Color.Transparent
        Me.RunTTM.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunTTM.LinkColor = System.Drawing.Color.White
        Me.RunTTM.Location = New System.Drawing.Point(124, 48)
        Me.RunTTM.Name = "RunTTM"
        Me.RunTTM.Size = New System.Drawing.Size(153, 36)
        Me.RunTTM.TabIndex = 2
        Me.RunTTM.TabStop = True
        Me.RunTTM.Text = "TTMProcessing"
        '
        'RunPatientDetail
        '
        Me.RunPatientDetail.AutoEllipsis = True
        Me.RunPatientDetail.BackColor = System.Drawing.Color.Transparent
        Me.RunPatientDetail.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunPatientDetail.LinkColor = System.Drawing.Color.White
        Me.RunPatientDetail.Location = New System.Drawing.Point(124, 76)
        Me.RunPatientDetail.Name = "RunPatientDetail"
        Me.RunPatientDetail.Size = New System.Drawing.Size(221, 36)
        Me.RunPatientDetail.TabIndex = 3
        Me.RunPatientDetail.TabStop = True
        Me.RunPatientDetail.Text = "PatientDetailProcessing"
        '
        'LoadDataTypesBindingSource
        '
        Me.LoadDataTypesBindingSource.DataMember = "LoadDataTypes"
        Me.LoadDataTypesBindingSource.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoadDataTypesTableAdapter
        '
        Me.LoadDataTypesTableAdapter.ClearBeforeFill = True
        '
        'PracticegroupBindingSource1
        '
        Me.PracticegroupBindingSource1.DataMember = "practicegroup"
        Me.PracticegroupBindingSource1.DataSource = Me.DataSet12
        '
        'DataSet12
        '
        Me.DataSet12.DataSetName = "DataSet1"
        Me.DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClearLoadTables
        '
        Me.ClearLoadTables.BackColor = System.Drawing.Color.Transparent
        Me.ClearLoadTables.Font = New System.Drawing.Font("Monotype Corsiva", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearLoadTables.LinkColor = System.Drawing.Color.White
        Me.ClearLoadTables.Location = New System.Drawing.Point(604, 321)
        Me.ClearLoadTables.Name = "ClearLoadTables"
        Me.ClearLoadTables.Size = New System.Drawing.Size(46, 22)
        Me.ClearLoadTables.TabIndex = 9
        Me.ClearLoadTables.TabStop = True
        Me.ClearLoadTables.Text = "Clear"
        Me.ClearLoadTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RunCodingProfiles
        '
        Me.RunCodingProfiles.AutoEllipsis = True
        Me.RunCodingProfiles.BackColor = System.Drawing.Color.Transparent
        Me.RunCodingProfiles.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunCodingProfiles.LinkColor = System.Drawing.Color.White
        Me.RunCodingProfiles.Location = New System.Drawing.Point(124, 107)
        Me.RunCodingProfiles.Name = "RunCodingProfiles"
        Me.RunCodingProfiles.Size = New System.Drawing.Size(221, 36)
        Me.RunCodingProfiles.TabIndex = 12
        Me.RunCodingProfiles.TabStop = True
        Me.RunCodingProfiles.Text = "CodingProfileProcessing"
        '
        'PracticegroupTableAdapter
        '
        Me.PracticegroupTableAdapter.ClearBeforeFill = True
        '
        'EncountersLinkLabel
        '
        Me.EncountersLinkLabel.AutoEllipsis = True
        Me.EncountersLinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.EncountersLinkLabel.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EncountersLinkLabel.LinkColor = System.Drawing.Color.White
        Me.EncountersLinkLabel.Location = New System.Drawing.Point(124, 229)
        Me.EncountersLinkLabel.Name = "EncountersLinkLabel"
        Me.EncountersLinkLabel.Size = New System.Drawing.Size(221, 36)
        Me.EncountersLinkLabel.TabIndex = 15
        Me.EncountersLinkLabel.TabStop = True
        Me.EncountersLinkLabel.Text = "SVMC Encounters"
        '
        'MissingChargesLinkLabel
        '
        Me.MissingChargesLinkLabel.AutoEllipsis = True
        Me.MissingChargesLinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.MissingChargesLinkLabel.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MissingChargesLinkLabel.LinkColor = System.Drawing.Color.White
        Me.MissingChargesLinkLabel.Location = New System.Drawing.Point(124, 197)
        Me.MissingChargesLinkLabel.Name = "MissingChargesLinkLabel"
        Me.MissingChargesLinkLabel.Size = New System.Drawing.Size(221, 36)
        Me.MissingChargesLinkLabel.TabIndex = 16
        Me.MissingChargesLinkLabel.TabStop = True
        Me.MissingChargesLinkLabel.Text = "Missing Charges"
        '
        'PatientDetailAuditLink
        '
        Me.PatientDetailAuditLink.AutoEllipsis = True
        Me.PatientDetailAuditLink.BackColor = System.Drawing.Color.Transparent
        Me.PatientDetailAuditLink.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientDetailAuditLink.LinkColor = System.Drawing.Color.White
        Me.PatientDetailAuditLink.Location = New System.Drawing.Point(124, 258)
        Me.PatientDetailAuditLink.Name = "PatientDetailAuditLink"
        Me.PatientDetailAuditLink.Size = New System.Drawing.Size(221, 36)
        Me.PatientDetailAuditLink.TabIndex = 18
        Me.PatientDetailAuditLink.TabStop = True
        Me.PatientDetailAuditLink.Text = "PatientDetailAudit"
        '
        'Supervisor_LinkLbl
        '
        Me.Supervisor_LinkLbl.AutoEllipsis = True
        Me.Supervisor_LinkLbl.BackColor = System.Drawing.Color.Transparent
        Me.Supervisor_LinkLbl.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supervisor_LinkLbl.LinkColor = System.Drawing.Color.White
        Me.Supervisor_LinkLbl.Location = New System.Drawing.Point(126, 167)
        Me.Supervisor_LinkLbl.Name = "Supervisor_LinkLbl"
        Me.Supervisor_LinkLbl.Size = New System.Drawing.Size(221, 36)
        Me.Supervisor_LinkLbl.TabIndex = 19
        Me.Supervisor_LinkLbl.TabStop = True
        Me.Supervisor_LinkLbl.Text = "SupervisorPatientDtl"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportsCheckListToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportsCheckListToolStripMenuItem
        '
        Me.ReportsCheckListToolStripMenuItem.Name = "ReportsCheckListToolStripMenuItem"
        Me.ReportsCheckListToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.ReportsCheckListToolStripMenuItem.Text = "ReportsCheckList"
        '
        'MergeProfilesLbl
        '
        Me.MergeProfilesLbl.AutoEllipsis = True
        Me.MergeProfilesLbl.BackColor = System.Drawing.Color.Transparent
        Me.MergeProfilesLbl.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MergeProfilesLbl.LinkColor = System.Drawing.Color.White
        Me.MergeProfilesLbl.Location = New System.Drawing.Point(126, 290)
        Me.MergeProfilesLbl.Name = "MergeProfilesLbl"
        Me.MergeProfilesLbl.Size = New System.Drawing.Size(221, 36)
        Me.MergeProfilesLbl.TabIndex = 23
        Me.MergeProfilesLbl.TabStop = True
        Me.MergeProfilesLbl.Text = "ClinicMgrReports"
        '
        'LoadDropDown
        '
        Me.LoadDropDown.DataSource = Me.LoadDataTypesBindingSource
        Me.LoadDropDown.DisplayMember = "loadtype"
        Me.LoadDropDown.FormattingEnabled = True
        Me.LoadDropDown.Location = New System.Drawing.Point(154, 119)
        Me.LoadDropDown.Name = "LoadDropDown"
        Me.LoadDropDown.Size = New System.Drawing.Size(183, 30)
        Me.LoadDropDown.TabIndex = 4
        Me.LoadDropDown.ValueMember = "recordid"
        '
        'Loadlbl
        '
        Me.Loadlbl.AutoSize = True
        Me.Loadlbl.BackColor = System.Drawing.Color.Transparent
        Me.Loadlbl.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loadlbl.ForeColor = System.Drawing.Color.White
        Me.Loadlbl.Location = New System.Drawing.Point(149, 91)
        Me.Loadlbl.Name = "Loadlbl"
        Me.Loadlbl.Size = New System.Drawing.Size(148, 25)
        Me.Loadlbl.TabIndex = 5
        Me.Loadlbl.Text = "Load Data Tables"
        '
        'GoBtn
        '
        Me.GoBtn.BackColor = System.Drawing.Color.Transparent
        Me.GoBtn.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GoBtn.Location = New System.Drawing.Point(343, 163)
        Me.GoBtn.Name = "GoBtn"
        Me.GoBtn.Size = New System.Drawing.Size(47, 23)
        Me.GoBtn.TabIndex = 6
        Me.GoBtn.Text = "Go!"
        Me.GoBtn.UseVisualStyleBackColor = False
        '
        'PGDropDown
        '
        Me.PGDropDown.DataSource = Me.PracticegroupBindingSource1
        Me.PGDropDown.DisplayMember = "practicename"
        Me.PGDropDown.FormattingEnabled = True
        Me.PGDropDown.Location = New System.Drawing.Point(153, 163)
        Me.PGDropDown.Name = "PGDropDown"
        Me.PGDropDown.Size = New System.Drawing.Size(184, 30)
        Me.PGDropDown.TabIndex = 7
        Me.PGDropDown.ValueMember = "recordid"
        '
        'PGroupLbl
        '
        Me.PGroupLbl.BackColor = System.Drawing.Color.Transparent
        Me.PGroupLbl.Font = New System.Drawing.Font("Monotype Corsiva", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PGroupLbl.ForeColor = System.Drawing.Color.White
        Me.PGroupLbl.Location = New System.Drawing.Point(149, 144)
        Me.PGroupLbl.Name = "PGroupLbl"
        Me.PGroupLbl.Size = New System.Drawing.Size(234, 18)
        Me.PGroupLbl.TabIndex = 8
        Me.PGroupLbl.Text = "Select Practice Group to Load"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LinkLabel1.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.LinkLabel1.Location = New System.Drawing.Point(149, 58)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(185, 25)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "CopyDataFolders/Files"
        Me.LinkLabel1.UseMnemonic = False
        '
        'RunDirectories
        '
        Me.RunDirectories.AutoEllipsis = True
        Me.RunDirectories.BackColor = System.Drawing.Color.Transparent
        Me.RunDirectories.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunDirectories.LinkColor = System.Drawing.Color.White
        Me.RunDirectories.Location = New System.Drawing.Point(149, 189)
        Me.RunDirectories.Name = "RunDirectories"
        Me.RunDirectories.Size = New System.Drawing.Size(221, 36)
        Me.RunDirectories.TabIndex = 11
        Me.RunDirectories.TabStop = True
        Me.RunDirectories.Text = "MaintainDirectories"
        '
        'WorkingFoldersLbl
        '
        Me.WorkingFoldersLbl.AutoSize = True
        Me.WorkingFoldersLbl.BackColor = System.Drawing.Color.Transparent
        Me.WorkingFoldersLbl.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingFoldersLbl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.WorkingFoldersLbl.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.WorkingFoldersLbl.Location = New System.Drawing.Point(149, 25)
        Me.WorkingFoldersLbl.Name = "WorkingFoldersLbl"
        Me.WorkingFoldersLbl.Size = New System.Drawing.Size(177, 25)
        Me.WorkingFoldersLbl.TabIndex = 13
        Me.WorkingFoldersLbl.TabStop = True
        Me.WorkingFoldersLbl.Text = "CreateWorkingFolders"
        '
        'MEProviders
        '
        Me.MEProviders.AutoEllipsis = True
        Me.MEProviders.BackColor = System.Drawing.Color.Transparent
        Me.MEProviders.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEProviders.LinkColor = System.Drawing.Color.White
        Me.MEProviders.Location = New System.Drawing.Point(148, 222)
        Me.MEProviders.Name = "MEProviders"
        Me.MEProviders.Size = New System.Drawing.Size(221, 36)
        Me.MEProviders.TabIndex = 14
        Me.MEProviders.TabStop = True
        Me.MEProviders.Text = "MaintainProviders"
        '
        'SpecialProcessingLinkLabel
        '
        Me.SpecialProcessingLinkLabel.AutoEllipsis = True
        Me.SpecialProcessingLinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.SpecialProcessingLinkLabel.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialProcessingLinkLabel.LinkColor = System.Drawing.Color.White
        Me.SpecialProcessingLinkLabel.Location = New System.Drawing.Point(149, 287)
        Me.SpecialProcessingLinkLabel.Name = "SpecialProcessingLinkLabel"
        Me.SpecialProcessingLinkLabel.Size = New System.Drawing.Size(221, 36)
        Me.SpecialProcessingLinkLabel.TabIndex = 17
        Me.SpecialProcessingLinkLabel.TabStop = True
        Me.SpecialProcessingLinkLabel.Text = "SpecialProcessing"
        '
        'PR2LinkLabel
        '
        Me.PR2LinkLabel.AutoEllipsis = True
        Me.PR2LinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.PR2LinkLabel.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PR2LinkLabel.LinkColor = System.Drawing.Color.White
        Me.PR2LinkLabel.Location = New System.Drawing.Point(149, 255)
        Me.PR2LinkLabel.Name = "PR2LinkLabel"
        Me.PR2LinkLabel.Size = New System.Drawing.Size(221, 36)
        Me.PR2LinkLabel.TabIndex = 21
        Me.PR2LinkLabel.TabStop = True
        Me.PR2LinkLabel.Text = "MaintProviderReports2"
        '
        'DistributionLinkLabel
        '
        Me.DistributionLinkLabel.AutoEllipsis = True
        Me.DistributionLinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.DistributionLinkLabel.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistributionLinkLabel.LinkColor = System.Drawing.Color.White
        Me.DistributionLinkLabel.Location = New System.Drawing.Point(149, 323)
        Me.DistributionLinkLabel.Name = "DistributionLinkLabel"
        Me.DistributionLinkLabel.Size = New System.Drawing.Size(259, 36)
        Me.DistributionLinkLabel.TabIndex = 22
        Me.DistributionLinkLabel.TabStop = True
        Me.DistributionLinkLabel.Text = "Maintain Distribution Lists"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DistributionLinkLabel)
        Me.GroupBox1.Controls.Add(Me.PR2LinkLabel)
        Me.GroupBox1.Controls.Add(Me.SpecialProcessingLinkLabel)
        Me.GroupBox1.Controls.Add(Me.MEProviders)
        Me.GroupBox1.Controls.Add(Me.WorkingFoldersLbl)
        Me.GroupBox1.Controls.Add(Me.RunDirectories)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.PGroupLbl)
        Me.GroupBox1.Controls.Add(Me.PGDropDown)
        Me.GroupBox1.Controls.Add(Me.GoBtn)
        Me.GroupBox1.Controls.Add(Me.Loadlbl)
        Me.GroupBox1.Controls.Add(Me.LoadDropDown)
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Location = New System.Drawing.Point(211, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 371)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Processing"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CPSpecialtiesLbl)
        Me.GroupBox2.Controls.Add(Me.AdminRptsLinkLabel)
        Me.GroupBox2.Controls.Add(Me.MergeProfilesLbl)
        Me.GroupBox2.Controls.Add(Me.Supervisor_LinkLbl)
        Me.GroupBox2.Controls.Add(Me.PatientDetailAuditLink)
        Me.GroupBox2.Controls.Add(Me.MissingChargesLinkLabel)
        Me.GroupBox2.Controls.Add(Me.EncountersLinkLabel)
        Me.GroupBox2.Controls.Add(Me.RunCodingProfiles)
        Me.GroupBox2.Controls.Add(Me.RunPatientDetail)
        Me.GroupBox2.Controls.Add(Me.RunTTM)
        Me.GroupBox2.Font = New System.Drawing.Font("Monotype Corsiva", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Location = New System.Drawing.Point(682, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 371)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reporting"
        '
        'AdminRptsLinkLabel
        '
        Me.AdminRptsLinkLabel.AutoEllipsis = True
        Me.AdminRptsLinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.AdminRptsLinkLabel.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminRptsLinkLabel.LinkColor = System.Drawing.Color.White
        Me.AdminRptsLinkLabel.Location = New System.Drawing.Point(120, 320)
        Me.AdminRptsLinkLabel.Name = "AdminRptsLinkLabel"
        Me.AdminRptsLinkLabel.Size = New System.Drawing.Size(221, 36)
        Me.AdminRptsLinkLabel.TabIndex = 24
        Me.AdminRptsLinkLabel.TabStop = True
        Me.AdminRptsLinkLabel.Text = "AdminReports"
        '
        'CPSpecialtiesLbl
        '
        Me.CPSpecialtiesLbl.AutoEllipsis = True
        Me.CPSpecialtiesLbl.BackColor = System.Drawing.Color.Transparent
        Me.CPSpecialtiesLbl.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPSpecialtiesLbl.LinkColor = System.Drawing.Color.White
        Me.CPSpecialtiesLbl.Location = New System.Drawing.Point(126, 138)
        Me.CPSpecialtiesLbl.Name = "CPSpecialtiesLbl"
        Me.CPSpecialtiesLbl.Size = New System.Drawing.Size(221, 36)
        Me.CPSpecialtiesLbl.TabIndex = 25
        Me.CPSpecialtiesLbl.TabStop = True
        Me.CPSpecialtiesLbl.Text = "CodingProfileSpecialties"
        '
        'MEProcessing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.ClearLoadTables)
        Me.Controls.Add(Me.ProcHdr)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MEProcessing"
        Me.Text = "MonthEnd Processing"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadDataTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PracticegroupBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProcHdr As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents MonthEndReportsBindingSource As BindingSource
    'Friend WithEvents MonthEndReportsTableAdapter As DataSet1TableAdapters.MonthEndReportsTableAdapter
    Friend WithEvents RunTTM As LinkLabel
    Friend WithEvents RunPatientDetail As LinkLabel
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents LoadDataTypesBindingSource As BindingSource
    Friend WithEvents LoadDataTypesTableAdapter As DataSet1TableAdapters.LoadDataTypesTableAdapter
    Friend WithEvents ClearLoadTables As LinkLabel
    Friend WithEvents RunCodingProfiles As LinkLabel
    Friend WithEvents DataSet12 As DataSet1
    Friend WithEvents PracticegroupBindingSource1 As BindingSource
    Friend WithEvents PracticegroupTableAdapter As DataSet1TableAdapters.practicegroupTableAdapter
    Friend WithEvents EncountersLinkLabel As LinkLabel
    Friend WithEvents MissingChargesLinkLabel As LinkLabel
    Friend WithEvents PatientDetailAuditLink As LinkLabel
    Friend WithEvents Supervisor_LinkLbl As LinkLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MergeProfilesLbl As LinkLabel
    Friend WithEvents LoadDropDown As ComboBox
    Friend WithEvents Loadlbl As Label
    Friend WithEvents GoBtn As Button
    Friend WithEvents PGDropDown As ComboBox
    Friend WithEvents PGroupLbl As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents RunDirectories As LinkLabel
    Friend WithEvents WorkingFoldersLbl As LinkLabel
    Friend WithEvents MEProviders As LinkLabel
    Friend WithEvents SpecialProcessingLinkLabel As LinkLabel
    Friend WithEvents PR2LinkLabel As LinkLabel
    Friend WithEvents DistributionLinkLabel As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ReportsCheckListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminRptsLinkLabel As LinkLabel
    Friend WithEvents CPSpecialtiesLbl As LinkLabel
End Class
