Imports System.Data
Imports System.Data.SqlClient
Public Class ProvidersIn
    Private Sub ProvidersIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ProvidersIn' table. You can move, or remove it, as needed.
        Me.ProvidersInTableAdapter.FillProvidersIn(Me.DataSet1.ProvidersIn)

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Me.Validate()
        Me.ProvidersInBindingSource.EndEdit()
        Me.ProvidersInTableAdapter.Update(Me.DataSet1.ProvidersIn)
        Me.ProvidersInTableAdapter.FillProvidersIn(Me.DataSet1.ProvidersIn)
    End Sub
    Private Sub AddProvidersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProvidersToolStripMenuItem.Click
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        Dim NumRows As Integer = 0
        Dim AddType = 1
        SQLCmd.CommandText = "spAddProvidersNotFound"
        SQLCmd.Parameters.AddWithValue("AddType", AddType)
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Connection = NewCon
        SQLCmd.CommandTimeout = 0
        NewCon.Open()
        NumRows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
    End Sub
    Private Sub AddProvidersAttributesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProvidersToolStripMenuItem.Click
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        Dim NumRows As Integer = 0
        Dim AddType = 2
        SQLCmd.CommandText = "spAddProvidersNotFound"
        SQLCmd.Parameters.AddWithValue("AddType", AddType)
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Connection = NewCon
        SQLCmd.CommandTimeout = 0
        NewCon.Open()
        NumRows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
    End Sub

    Private Sub AddReportTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddReportTypeToolStripMenuItem.Click
        Dim AddPrRt As New AddRptType
        AddPrRt.Show()
    End Sub

    Private Sub RemoveCurrentProvidersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveCurrentProvidersToolStripMenuItem.Click
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        Dim NumRows As Integer = 0
        SQLCmd.CommandText = "spRemoveCurrentProviders"
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Connection = NewCon
        SQLCmd.CommandTimeout = 0
        NewCon.Open()
        NumRows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
        Me.ProvidersInTableAdapter.FillProvidersIn(Me.DataSet1.ProvidersIn)
    End Sub

    Private Sub AddPtroviderReports2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPtroviderReports2ToolStripMenuItem.Click
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        Dim NumRows As Integer = 0
        Dim AddType = 3
        SQLCmd.CommandText = "spAddProvidersNotFound"
        SQLCmd.Parameters.AddWithValue("AddType", AddType)
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Connection = NewCon
        SQLCmd.CommandTimeout = 0
        NewCon.Open()
        NumRows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
    End Sub
End Class