Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class ManagerReports
    Private Sub ManagerReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ManagerReports' table. You can move, or remove it, as needed.
        Me.ManagerReportsTableAdapter.FillManagerReports(Me.DataSet1.ManagerReports)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 12 Then
            Dim mgr As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Dim ConStr As String = My.Settings.MonthEndConnectionString
            Dim NewCon As SqlConnection = New SqlConnection(ConStr)
            Dim SQLCmd As SqlCommand = New SqlCommand()
            Dim Ad1 As New SqlDataAdapter()
            Dim Dta As New DataSet()
            Dim NumRows As Integer = 0
            If mgr < 1 Then
                Dim rtyp = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                Dim lst = DataGridView1.Rows(e.RowIndex).Cells(2).Value
                Dim fst = DataGridView1.Rows(e.RowIndex).Cells(3).Value
                Dim rnme = DataGridView1.Rows(e.RowIndex).Cells(4).Value
                Dim prac = DataGridView1.Rows(e.RowIndex).Cells(5).Value
                Dim rdir = DataGridView1.Rows(e.RowIndex).Cells(6).Value
                Dim reml = DataGridView1.Rows(e.RowIndex).Cells(7).Value
                Dim rcc = DataGridView1.Rows(e.RowIndex).Cells(8).Value
                Dim rsub = DataGridView1.Rows(e.RowIndex).Cells(9).Value
                Dim pdf As Boolean = True
                Dim enc As Boolean = False
                If Not Directory.Exists(rdir) Then
                    MsgBox("Directory " & rdir & " does not exist. Please try again")
                    Exit Sub
                End If
                Me.ManagerReportsTableAdapter.Insert(rtyp, lst, fst, rnme, prac, rdir, reml, rcc, rsub, pdf, enc)
                Me.ManagerReportsTableAdapter.FillManagerReports(Me.DataSet1.ManagerReports)
                SQLCmd.CommandText = "insert into managerreportfiles(managerid, reporttype, practice, reportdir) select recordid, reporttype, practicename, reportdir from managerreports where recordid = (select max(recordid) from managerreports)"
                SQLCmd.CommandType = CommandType.Text
                SQLCmd.Connection = NewCon
                NewCon.Open()
                NumRows = SQLCmd.ExecuteNonQuery()
                NewCon.Close()
                Me.ManagerReportsTableAdapter.FillManagerReports(Me.DataSet1.ManagerReports)
                Dim MrFiles As New ManagerReportFiles
                MrFiles.Tag = 2
                MrFiles.Show()
                Me.Close()
                Exit Sub
            End If
            SQLCmd.CommandText = "spManagerReportFilesList"
            SQLCmd.CommandType = CommandType.StoredProcedure
            SQLCmd.Parameters.AddWithValue("manager", mgr)
            SQLCmd.Connection = NewCon
            SQLCmd.CommandTimeout = 0
            NewCon.Open()
            NumRows = SQLCmd.ExecuteNonQuery()
            NewCon.Close()
            Dim MRFileList As New ManagerReportFilesList
            MRFileList.Show()
        End If
    End Sub

    Private Sub DeleteManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteManagerToolStripMenuItem.Click
        Dim rusure As Int16 = 0
        rusure = MsgBox("Are You Sure you want to delete the selected manager??", vbYesNo)
        If rusure = 7 Then
            Exit Sub
        End If
        Dim Row As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim Recid = Row.Cells(0).Value
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        SQLCmd.CommandText = "spManagerReportsDel"
        SQLCmd.Parameters.AddWithValue("recordid", Recid)
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Connection = NewCon
        SQLCmd.CommandTimeout = 0
        NewCon.Open()
        Dim NumRows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
        Me.ManagerReportsTableAdapter.FillManagerReports(Me.DataSet1.ManagerReports)
    End Sub

    Private Sub UpdateManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateManagerToolStripMenuItem.Click
        Me.Validate()
        Me.ManagerReportsBindingSource.EndEdit()
        Me.ManagerReportsTableAdapter.Update(Me.DataSet1.ManagerReports)
        Me.ManagerReportsTableAdapter.FillManagerReports(Me.DataSet1.ManagerReports)
    End Sub
End Class