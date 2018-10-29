<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MEHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MEHome))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MEProcs = New System.Windows.Forms.LinkLabel()
        Me.NXHealthLinkLable = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthEndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NXHealthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecreateReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SvemgMhmgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecreateLink = New System.Windows.Forms.LinkLabel()
        Me.SEVMGLink = New System.Windows.Forms.LinkLabel()
        Me.ProcessingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TasksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(374, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(496, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " MonthEnd Reporting Home"
        '
        'MEProcs
        '
        Me.MEProcs.BackColor = System.Drawing.Color.Transparent
        Me.MEProcs.Font = New System.Drawing.Font("Monotype Corsiva", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte), True)
        Me.MEProcs.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MEProcs.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.MEProcs.Location = New System.Drawing.Point(476, 186)
        Me.MEProcs.Name = "MEProcs"
        Me.MEProcs.Size = New System.Drawing.Size(329, 57)
        Me.MEProcs.TabIndex = 4
        Me.MEProcs.TabStop = True
        Me.MEProcs.Text = "MonthEnd Processing"
        '
        'NXHealthLinkLable
        '
        Me.NXHealthLinkLable.BackColor = System.Drawing.Color.Transparent
        Me.NXHealthLinkLable.Font = New System.Drawing.Font("Monotype Corsiva", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte), True)
        Me.NXHealthLinkLable.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NXHealthLinkLable.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.NXHealthLinkLable.Location = New System.Drawing.Point(476, 244)
        Me.NXHealthLinkLable.Name = "NXHealthLinkLable"
        Me.NXHealthLinkLable.Size = New System.Drawing.Size(329, 57)
        Me.NXHealthLinkLable.TabIndex = 5
        Me.NXHealthLinkLable.TabStop = True
        Me.NXHealthLinkLable.Text = "NXHealth"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DocumentationToolStripMenuItem
        '
        Me.DocumentationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonthEndToolStripMenuItem, Me.NXHealthToolStripMenuItem, Me.RecreateReportsToolStripMenuItem, Me.SvemgMhmgToolStripMenuItem})
        Me.DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
        Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.DocumentationToolStripMenuItem.Text = "Documentation"
        '
        'MonthEndToolStripMenuItem
        '
        Me.MonthEndToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcessingToolStripMenuItem, Me.TasksToolStripMenuItem})
        Me.MonthEndToolStripMenuItem.Name = "MonthEndToolStripMenuItem"
        Me.MonthEndToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MonthEndToolStripMenuItem.Text = "MonthEnd"
        '
        'NXHealthToolStripMenuItem
        '
        Me.NXHealthToolStripMenuItem.Name = "NXHealthToolStripMenuItem"
        Me.NXHealthToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NXHealthToolStripMenuItem.Text = "NXHealth"
        '
        'RecreateReportsToolStripMenuItem
        '
        Me.RecreateReportsToolStripMenuItem.Name = "RecreateReportsToolStripMenuItem"
        Me.RecreateReportsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RecreateReportsToolStripMenuItem.Text = "RecreateReports"
        '
        'SvemgMhmgToolStripMenuItem
        '
        Me.SvemgMhmgToolStripMenuItem.Name = "SvemgMhmgToolStripMenuItem"
        Me.SvemgMhmgToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SvemgMhmgToolStripMenuItem.Text = "SvemgMhmg"
        '
        'RecreateLink
        '
        Me.RecreateLink.BackColor = System.Drawing.Color.Transparent
        Me.RecreateLink.Font = New System.Drawing.Font("Monotype Corsiva", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte), True)
        Me.RecreateLink.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RecreateLink.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.RecreateLink.Location = New System.Drawing.Point(476, 301)
        Me.RecreateLink.Name = "RecreateLink"
        Me.RecreateLink.Size = New System.Drawing.Size(329, 57)
        Me.RecreateLink.TabIndex = 7
        Me.RecreateLink.TabStop = True
        Me.RecreateLink.Text = "RecreateReports"
        '
        'SEVMGLink
        '
        Me.SEVMGLink.BackColor = System.Drawing.Color.Transparent
        Me.SEVMGLink.Font = New System.Drawing.Font("Monotype Corsiva", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte), True)
        Me.SEVMGLink.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SEVMGLink.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.SEVMGLink.Location = New System.Drawing.Point(476, 358)
        Me.SEVMGLink.Name = "SEVMGLink"
        Me.SEVMGLink.Size = New System.Drawing.Size(329, 57)
        Me.SEVMGLink.TabIndex = 8
        Me.SEVMGLink.TabStop = True
        Me.SEVMGLink.Text = "SVEMG-MHMG"
        '
        'ProcessingToolStripMenuItem
        '
        Me.ProcessingToolStripMenuItem.Name = "ProcessingToolStripMenuItem"
        Me.ProcessingToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProcessingToolStripMenuItem.Text = "Processing"
        '
        'TasksToolStripMenuItem
        '
        Me.TasksToolStripMenuItem.Name = "TasksToolStripMenuItem"
        Me.TasksToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TasksToolStripMenuItem.Text = "Tasks"
        '
        'MEHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1304, 641)
        Me.Controls.Add(Me.SEVMGLink)
        Me.Controls.Add(Me.RecreateLink)
        Me.Controls.Add(Me.NXHealthLinkLable)
        Me.Controls.Add(Me.MEProcs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MEHome"
        Me.Text = "MonthEnd Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MEProcs As LinkLabel
    Friend WithEvents NXHealthLinkLable As LinkLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DocumentationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecreateLink As LinkLabel
    Friend WithEvents MonthEndToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NXHealthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecreateReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SEVMGLink As LinkLabel
    Friend WithEvents SvemgMhmgToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcessingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TasksToolStripMenuItem As ToolStripMenuItem
End Class
