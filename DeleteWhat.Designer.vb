<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteWhat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteWhat))
        Me.TTMChk = New System.Windows.Forms.CheckBox()
        Me.SupChk = New System.Windows.Forms.CheckBox()
        Me.PDChk = New System.Windows.Forms.CheckBox()
        Me.CPChk = New System.Windows.Forms.CheckBox()
        Me.AllChk = New System.Windows.Forms.CheckBox()
        Me.GoBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TTMChk
        '
        Me.TTMChk.BackgroundImage = CType(resources.GetObject("TTMChk.BackgroundImage"), System.Drawing.Image)
        Me.TTMChk.ForeColor = System.Drawing.Color.White
        Me.TTMChk.Location = New System.Drawing.Point(112, 40)
        Me.TTMChk.Name = "TTMChk"
        Me.TTMChk.Size = New System.Drawing.Size(74, 24)
        Me.TTMChk.TabIndex = 0
        Me.TTMChk.Text = "TTM"
        Me.TTMChk.UseVisualStyleBackColor = True
        Me.TTMChk.UseWaitCursor = True
        '
        'SupChk
        '
        Me.SupChk.BackgroundImage = CType(resources.GetObject("SupChk.BackgroundImage"), System.Drawing.Image)
        Me.SupChk.ForeColor = System.Drawing.Color.White
        Me.SupChk.Location = New System.Drawing.Point(112, 115)
        Me.SupChk.Name = "SupChk"
        Me.SupChk.Size = New System.Drawing.Size(74, 31)
        Me.SupChk.TabIndex = 1
        Me.SupChk.Text = "Super"
        Me.SupChk.UseVisualStyleBackColor = True
        Me.SupChk.UseWaitCursor = True
        '
        'PDChk
        '
        Me.PDChk.BackgroundImage = CType(resources.GetObject("PDChk.BackgroundImage"), System.Drawing.Image)
        Me.PDChk.ForeColor = System.Drawing.Color.White
        Me.PDChk.Location = New System.Drawing.Point(112, 87)
        Me.PDChk.Name = "PDChk"
        Me.PDChk.Size = New System.Drawing.Size(74, 34)
        Me.PDChk.TabIndex = 2
        Me.PDChk.Text = "PDetail"
        Me.PDChk.UseVisualStyleBackColor = True
        Me.PDChk.UseWaitCursor = True
        '
        'CPChk
        '
        Me.CPChk.BackgroundImage = CType(resources.GetObject("CPChk.BackgroundImage"), System.Drawing.Image)
        Me.CPChk.ForeColor = System.Drawing.Color.White
        Me.CPChk.Location = New System.Drawing.Point(112, 66)
        Me.CPChk.Name = "CPChk"
        Me.CPChk.Size = New System.Drawing.Size(74, 28)
        Me.CPChk.TabIndex = 3
        Me.CPChk.Text = "CProfile"
        Me.CPChk.UseVisualStyleBackColor = True
        Me.CPChk.UseWaitCursor = True
        '
        'AllChk
        '
        Me.AllChk.BackgroundImage = CType(resources.GetObject("AllChk.BackgroundImage"), System.Drawing.Image)
        Me.AllChk.ForeColor = System.Drawing.Color.White
        Me.AllChk.Location = New System.Drawing.Point(112, 141)
        Me.AllChk.Name = "AllChk"
        Me.AllChk.Size = New System.Drawing.Size(74, 31)
        Me.AllChk.TabIndex = 4
        Me.AllChk.Text = "All"
        Me.AllChk.UseVisualStyleBackColor = True
        Me.AllChk.UseWaitCursor = True
        '
        'GoBtn
        '
        Me.GoBtn.ForeColor = System.Drawing.Color.Red
        Me.GoBtn.Location = New System.Drawing.Point(110, 165)
        Me.GoBtn.Name = "GoBtn"
        Me.GoBtn.Size = New System.Drawing.Size(75, 23)
        Me.GoBtn.TabIndex = 5
        Me.GoBtn.Text = "Go!"
        Me.GoBtn.UseVisualStyleBackColor = True
        '
        'DeleteWhat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GoBtn)
        Me.Controls.Add(Me.AllChk)
        Me.Controls.Add(Me.CPChk)
        Me.Controls.Add(Me.PDChk)
        Me.Controls.Add(Me.SupChk)
        Me.Controls.Add(Me.TTMChk)
        Me.Name = "DeleteWhat"
        Me.Text = "DeleteWhat"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TTMChk As CheckBox
    Friend WithEvents SupChk As CheckBox
    Friend WithEvents PDChk As CheckBox
    Friend WithEvents CPChk As CheckBox
    Friend WithEvents AllChk As CheckBox
    Friend WithEvents GoBtn As Button
End Class
