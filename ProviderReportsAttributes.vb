Public Class ProviderReportsAttributes
    Private Sub ProviderReportsAttributes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.providerreportsattributes' table. You can move, or remove it, as needed.
        Me.ProviderreportsattributesTableAdapter.FillAttributes(Me.DataSet1.providerreportsattributes)

    End Sub

End Class