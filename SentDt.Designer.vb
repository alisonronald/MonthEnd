<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SentDt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SentDt))
        Me.SentDtLbl = New System.Windows.Forms.Label()
        Me.SentDtTxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SentDtLbl
        '
        Me.SentDtLbl.AutoSize = True
        Me.SentDtLbl.Font = New System.Drawing.Font("Magneto", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SentDtLbl.ForeColor = System.Drawing.Color.DarkRed
        Me.SentDtLbl.Location = New System.Drawing.Point(8, 98)
        Me.SentDtLbl.Name = "SentDtLbl"
        Me.SentDtLbl.Size = New System.Drawing.Size(183, 17)
        Me.SentDtLbl.TabIndex = 0
        Me.SentDtLbl.Text = "Sent Date Greater Than"
        '
        'SentDtTxt
        '
        Me.SentDtTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SentDtTxt.Location = New System.Drawing.Point(188, 96)
        Me.SentDtTxt.Name = "SentDtTxt"
        Me.SentDtTxt.Size = New System.Drawing.Size(91, 20)
        Me.SentDtTxt.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(236, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Go!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SentDt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SentDtTxt)
        Me.Controls.Add(Me.SentDtLbl)
        Me.Name = "SentDt"
        Me.Text = "SentDt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SentDtLbl As Label
    Friend WithEvents SentDtTxt As TextBox
    Friend WithEvents Button1 As Button
End Class
