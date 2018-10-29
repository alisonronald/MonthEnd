Imports System.Data
Imports System.Data.SqlClient
Public Class ReportsCheckList
    Private Sub ReportsCheckList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ReportsCheckList' table. You can move, or remove it, as needed.
        Me.ReportsCheckListTableAdapter.FillCheckList(Me.DataSet1.ReportsCheckList)

    End Sub

    Private Sub UpdateCheckListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCheckListToolStripMenuItem.Click
        Me.Validate()
        Me.ReportsCheckListBindingSource.EndEdit()
        Me.ReportsCheckListTableAdapter.Update(Me.DataSet1.ReportsCheckList)
        Me.ReportsCheckListTableAdapter.FillCheckList(Me.DataSet1.ReportsCheckList)
    End Sub

    Private Sub UpdateALLReportSentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateALLReportSentToolStripMenuItem.Click
        Dim Selstr As String = "update reportschecklist set reportsent = 1"
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        SQLCmd.CommandText = Selstr
        SQLCmd.CommandType = CommandType.Text
        SQLCmd.Connection = NewCon
        SQLCmd.CommandTimeout = 0
        NewCon.Open()
        Dim NumRows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
        Me.ReportsCheckListTableAdapter.FillCheckList(Me.DataSet1.ReportsCheckList)
    End Sub
End Class