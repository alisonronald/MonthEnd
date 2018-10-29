Imports System.Data.SqlClient
Public Class PRNotFound
    Private Sub PRNotFound_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ProviderReportsNotFound' table. You can move, or remove it, as needed.
        Me.ProviderReportsNotFoundTableAdapter.FillPRNotFound(Me.DataSet1.ProviderReportsNotFound)

    End Sub

    Private Sub DeleteAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAllToolStripMenuItem.Click
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim Numrows As Integer = 0
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        SQLCmd.CommandText = "delete from providerreportsnotfound"
        SQLCmd.CommandType = CommandType.Text
        SQLCmd.Connection = NewCon
        NewCon.Open()
        Numrows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
        Me.ProviderReportsNotFoundTableAdapter.FillPRNotFound(Me.DataSet1.ProviderReportsNotFound)

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Me.Validate()
        Me.ProviderReportsNotFoundBindingSource.EndEdit()
        Me.ProviderReportsNotFoundTableAdapter.Update(Me.DataSet1.ProviderReportsNotFound)
        Me.ProviderReportsNotFoundTableAdapter.FillPRNotFound(Me.DataSet1.ProviderReportsNotFound)
    End Sub

    Private Sub ProvidersInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvidersInToolStripMenuItem.Click
        Dim PrIN As New ProvidersIn
        PrIN.Show()
    End Sub
End Class