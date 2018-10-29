Public Class DistributionList
    Private Sub DistributionList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.distributionlist' table. You can move, or remove it, as needed.
        Me.DistributionlistTableAdapter.FillDistribution(Me.DataSet1.distributionlist)

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Me.Validate()
        Me.DistributionlistBindingSource1.EndEdit()
        Me.DistributionlistTableAdapter.Update(Me.DataSet1.distributionlist)
        Me.DistributionlistTableAdapter.FillDistribution(Me.DataSet1.distributionlist)
    End Sub

End Class