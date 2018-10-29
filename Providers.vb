Imports System.Data
Imports System.Data.SqlClient
Public Class Providers
    Private Sub Providers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Providers' table. You can move, or remove it, as needed.
        Me.ProvidersTableAdapter.FillProviders(Me.DataSet1.Providers)

    End Sub

    'Private Sub UpdBtn_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.ProvidersBindingSource.EndEdit()
    '    Me.ProvidersTableAdapter.Update(Me.DataSet1.Providers)
    '    Me.ProvidersTableAdapter.FillProviders(Me.DataSet1.Providers)
    'End Sub

    'Private Sub InsertToolStripMenuItem_Click(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    Me.ProvidersBindingSource.RemoveCurrent()
    '    Me.ProvidersBindingSource.EndEdit()
    '    Me.ProvidersTableAdapter.Update(Me.DataSet1.Providers)
    '    Me.ProvidersTableAdapter.FillProviders(Me.DataSet1.Providers)
    'End Sub

    Private Sub ProviderReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProviderReportsToolStripMenuItem.Click
        Dim PrRpt As New ProvidersIn
        PrRpt.Show()
    End Sub

    Private Sub UpdateProvidersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateProvidersToolStripMenuItem.Click
        Me.Validate()
        Me.ProvidersBindingSource.EndEdit()
        Me.ProvidersTableAdapter.Update(Me.DataSet1.Providers)
        Me.ProvidersTableAdapter.FillProviders(Me.DataSet1.Providers)
    End Sub

    'Private Sub UpdateProviderAttributesToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    Dim Row As DataGridViewRow = ProvidersDataGridView.SelectedRows(0)
    '    Dim Recid = Row.Cells(0).Value
    '    Dim RType As String = InputBox("Report Type?")
    '    Dim ConStr As String = My.Settings.MonthEndConnectionString
    '    Dim NewCon As SqlConnection = New SqlConnection(ConStr)
    '    Dim SQLCmd As SqlCommand = New SqlCommand()
    '    SQLCmd.CommandText = "spInsertProviderReportsAttributes"
    '    SQLCmd.CommandType = CommandType.StoredProcedure
    '    SQLCmd.Parameters.AddWithValue("Recordid", Recid)
    '    SQLCmd.Parameters.AddWithValue("RptType", RType)
    '    SQLCmd.Connection = NewCon
    '    SQLCmd.CommandTimeout = 0
    '    NewCon.Open()
    '    Dim NumRows = SQLCmd.ExecuteNonQuery()
    '    NewCon.Close()
    'End Sub
End Class