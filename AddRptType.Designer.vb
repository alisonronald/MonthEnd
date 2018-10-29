<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddRptType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddRptType))
        Me.RecIdLbl = New System.Windows.Forms.Label()
        Me.RptTypeLbl = New System.Windows.Forms.Label()
        Me.RecIdTxt = New System.Windows.Forms.TextBox()
        Me.RTypeTxt = New System.Windows.Forms.TextBox()
        Me.GoBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RecIdLbl
        '
        Me.RecIdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecIdLbl.ForeColor = System.Drawing.Color.Maroon
        Me.RecIdLbl.Location = New System.Drawing.Point(26, 64)
        Me.RecIdLbl.Name = "RecIdLbl"
        Me.RecIdLbl.Size = New System.Drawing.Size(97, 20)
        Me.RecIdLbl.TabIndex = 0
        Me.RecIdLbl.Text = "RecordId"
        '
        'RptTypeLbl
        '
        Me.RptTypeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RptTypeLbl.ForeColor = System.Drawing.Color.Maroon
        Me.RptTypeLbl.Location = New System.Drawing.Point(26, 88)
        Me.RptTypeLbl.Name = "RptTypeLbl"
        Me.RptTypeLbl.Size = New System.Drawing.Size(97, 20)
        Me.RptTypeLbl.TabIndex = 1
        Me.RptTypeLbl.Text = "ReportType"
        '
        'RecIdTxt
        '
        Me.RecIdTxt.Location = New System.Drawing.Point(129, 64)
        Me.RecIdTxt.Name = "RecIdTxt"
        Me.RecIdTxt.Size = New System.Drawing.Size(95, 20)
        Me.RecIdTxt.TabIndex = 2
        '
        'RTypeTxt
        '
        Me.RTypeTxt.Location = New System.Drawing.Point(129, 88)
        Me.RTypeTxt.Name = "RTypeTxt"
        Me.RTypeTxt.Size = New System.Drawing.Size(95, 20)
        Me.RTypeTxt.TabIndex = 3
        '
        'GoBtn
        '
        Me.GoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoBtn.ForeColor = System.Drawing.Color.Maroon
        Me.GoBtn.Location = New System.Drawing.Point(231, 86)
        Me.GoBtn.Name = "GoBtn"
        Me.GoBtn.Size = New System.Drawing.Size(44, 23)
        Me.GoBtn.TabIndex = 4
        Me.GoBtn.Text = "Go!"
        Me.GoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.GoBtn.UseVisualStyleBackColor = True
        '
        'AddRptType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(300, 198)
        Me.Controls.Add(Me.GoBtn)
        Me.Controls.Add(Me.RTypeTxt)
        Me.Controls.Add(Me.RecIdTxt)
        Me.Controls.Add(Me.RptTypeLbl)
        Me.Controls.Add(Me.RecIdLbl)
        Me.Name = "AddRptType"
        Me.Text = "AddReportType"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RecIdLbl As Label
    Friend WithEvents RptTypeLbl As Label
    Friend WithEvents RecIdTxt As TextBox
    Friend WithEvents RTypeTxt As TextBox
    Friend WithEvents GoBtn As Button
End Class
