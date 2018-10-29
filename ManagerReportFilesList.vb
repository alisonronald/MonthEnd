Imports System.Data
Imports System.Data.SqlClient
Public Class ManagerReportFilesList
    Private Sub ManagerReportFilesList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ManagerReportFilesList' table. You can move, or remove it, as needed.
        Me.ManagerReportFilesListTableAdapter.FillList(Me.DataSet1.ManagerReportFilesList)
        WorkingLbl.Visible = False
        SendLink.Visible = False
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        Dim Ad1 As New SqlDataAdapter()
        Dim Dta As New DataSet()
        SQLCmd.CommandText = "select (managerfirst + ' ' + managerlast) as 'Manager' from managerreports where recordid = (select distinct managerid from managerreportfileslist)"
        SQLCmd.CommandType = CommandType.Text
        SQLCmd.Connection = NewCon
        SQLCmd.CommandTimeout = 0
        Ad1.SelectCommand = SQLCmd
        NewCon.Open()
        Ad1.Fill(Dta)
        NewCon.Close()
        MgrLbl.Text = "Manager: " & Convert.ToString(Dta.Tables(0).Rows(0)(0))
    End Sub

    'Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
    '    Dim RptName = AddReport.Text
    '    Dim ConStr As String = My.Settings.MonthEndConnectionString
    '    Dim NewCon As SqlConnection = New SqlConnection(ConStr)
    '    Dim SQLCmd As SqlCommand = New SqlCommand()
    '    SQLCmd.CommandText = "spManagerReportFilesListAdd"
    '    SQLCmd.CommandType = CommandType.StoredProcedure
    '    SQLCmd.Parameters.AddWithValue("Report", RptName)
    '    SQLCmd.Connection = NewCon
    '    SQLCmd.CommandTimeout = 0
    '    NewCon.Open()
    '    Dim NumRows = SQLCmd.ExecuteNonQuery()
    '    NewCon.Close()
    '    Me.ManagerReportFilesListTableAdapter.FillList(Me.DataSet1.ManagerReportFilesList)
    'End Sub

    Private Sub FileListDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles FileListDataGridView.CellContentClick
        If e.ColumnIndex = 6 Then
            Dim rec As String = FileListDataGridView.Rows(e.RowIndex).Cells(0).Value
            Dim mgr As String = FileListDataGridView.Rows(e.RowIndex).Cells(1).Value
            Dim typ As Integer = 1
            Dim ConStr As String = My.Settings.MonthEndConnectionString
            Dim NewCon As SqlConnection = New SqlConnection(ConStr)
            Dim SQLCmd As SqlCommand = New SqlCommand()
            SQLCmd.CommandText = "spManagerReportFilesListDel"
            SQLCmd.CommandType = CommandType.StoredProcedure
            SQLCmd.Parameters.AddWithValue("Record", rec)
            SQLCmd.Parameters.AddWithValue("Manager", mgr)
            SQLCmd.Parameters.AddWithValue("Type", typ)
            SQLCmd.Connection = NewCon
            SQLCmd.CommandTimeout = 0
            NewCon.Open()
            Dim NumRows = SQLCmd.ExecuteNonQuery()
            NewCon.Close()
            Me.ManagerReportFilesListTableAdapter.FillList(Me.DataSet1.ManagerReportFilesList)
        End If
    End Sub

    Private Sub MergeListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MergeListToolStripMenuItem.Click
        Dim mgr As String = FileListDataGridView.Rows(0).Cells(0).Value
        Dim PDtl As String = "E:\ConsoleApps\CodingProfileCombine\CombineProfiles\CombineProfiles\bin\Debug\CombineProfiles.exe"
        Dim procsi As ProcessStartInfo = New ProcessStartInfo()
        'procsi.Arguments = " " + "/C" + " " + PDtl
        procsi.FileName = PDtl
        procsi.UseShellExecute = False
        procsi.CreateNoWindow = True
        Dim proc As Process = New Process()
        proc.StartInfo = procsi
        WorkingLbl.Visible = True
        proc.Start()
        proc.WaitForExit()
        'Dim arrProcess() As Process = System.Diagnostics.Process.GetProcessesByName("Excel")

        'For Each p As Process In arrProcess
        '    p.Kill()
        'Next
        WorkingLbl.Visible = False
        SendLink.Visible = True
    End Sub

    Private Sub SendLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SendLink.LinkClicked
        SendLink.Visible = False
        Dim mgr As String = FileListDataGridView.Rows(0).Cells(1).Value
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        SQLCmd.CommandText = "spCombinePDFSend"
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Connection = NewCon
        SQLCmd.CommandTimeout = 0
        NewCon.Open()
        Dim NumRows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
        Me.Close()
    End Sub

    Private Sub ManagersList_Click(sender As Object, e As EventArgs) Handles ManagersList.Click
        Dim MgrFiles As New ManagerReportFiles()
        MgrFiles.Tag = 1
        MgrFiles.Show()
    End Sub

    Private Sub AdminSendToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminSendToolStripMenuItem.Click

    End Sub
End Class