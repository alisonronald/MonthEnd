Public Class SpecialProcessing
    Private Sub SpecialProcessing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.SpecialProcessing' table. You can move, or remove it, as needed.
        Me.SpecialProcessingTableAdapter.FillSpecialProcessing(Me.DataSet1.SpecialProcessing)

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Me.Validate()
        Me.SpecialProcessingBindingSource.EndEdit()
        Me.SpecialProcessingTableAdapter.Update(Me.DataSet1.SpecialProcessing)
        Me.SpecialProcessingTableAdapter.FillSpecialProcessing(Me.DataSet1.SpecialProcessing)
    End Sub
End Class