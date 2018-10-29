Imports System.Data
Imports System.Data.SqlClient
Public Class ManagerReportFiles
    Dim mgr As Integer
    Dim rtyp As String
    Dim prac As String
    Dim rdir As String
    Dim ConStr As String = My.Settings.MonthEndConnectionString
    Dim NewCon As SqlConnection = New SqlConnection(ConStr)
    Dim SQLCmd As SqlCommand = New SqlCommand()
    Dim NumRows As Integer = 0
    Dim SelStr As String = ""
    Private Sub ManagerReportFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FillWith As Integer = Me.Tag
        Dim Ad1 As New SqlDataAdapter()
        Dim Dta As New DataSet()
        Dim Dta1 As New DataSet()
        Dim Rnme As String = ""
        If FillWith = 2 Then
            SQLCmd.CommandText = "select recordid, reporttype, practicename, reportdir from managerreports where recordid = (select max(recordid) from managerreports)"
            Me.ManagerReportFilesTableAdapter.FillByNewManager(Me.DataSet1.ManagerReportFiles)
            ManagerReportFilesDataGridView.Columns(6).Visible = False
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.Connection = NewCon
            SQLCmd.CommandTimeout = 0
            Ad1.SelectCommand = SQLCmd
            NewCon.Open()
            Ad1.Fill(Dta)
            NewCon.Close()
            mgr = Dta.Tables(0).Rows(0)(0).ToString
            rtyp = Dta.Tables(0).Rows(0)(1).ToString
            prac = Dta.Tables(0).Rows(0)(2).ToString
            rdir = Dta.Tables(0).Rows(0)(3).ToString
            ''ManagerReportFilesDataGridView.Rows(0).Cells(1).Value = mgr
            'ManagerReportFilesDataGridView.Rows(0).Cells(2).Value = rtyp
            'ManagerReportFilesDataGridView.Rows(0).Cells(3).Value = prac
            'ManagerReportFilesDataGridView.Rows(0).Cells(4).Value = rdir
            SelStr = "select recordid, (managerfirst + ' ' + managerlast) as 'Manager', 'All' as 'rname' from managerreports as a where a.recordid = (select max(recordid) from managerreports)"
            AddBtn.Visible = False
            AddReport.Visible = False
            AddFilesLbl.Visible = False
        Else
            'TODO: This line of code loads data into the 'DataSet1.ManagerReportFiles' table. You can move, or remove it, as needed.
            Me.ManagerReportFilesTableAdapter.FillManagerFiles(Me.DataSet1.ManagerReportFiles)
            SelStr = "select recordid, (managerfirst + ' ' + managerlast) as 'Manager', (select top 1 reportname from managerreportfiles where managerid = a.recordid) as 'rname' from managerreports as a where a.recordid = (select distinct managerid from managerreportfileslist)"
            ManagerReportFilesDataGridView.Columns(7).Visible = False
            AddNew.Visible = False
        End If
        SQLCmd.CommandText = SelStr
        SQLCmd.CommandType = CommandType.Text
        SQLCmd.Connection = NewCon
        SQLCmd.CommandTimeout = 0
        Ad1.SelectCommand = SQLCmd
        NewCon.Open()
        Ad1.Fill(Dta1)
        NewCon.Close()
        MgrLbl.Text = "Manager: " & Convert.ToString(Dta1.Tables(0).Rows(0)(1))
        Rnme = Convert.ToString(Dta1.Tables(0).Rows(0)(2))
        mgr = Convert.ToInt16(Dta1.Tables(0).Rows(0)(0))
        If Rnme = "All" Then
            AddBtn.Visible = False
            AddReport.Visible = False
            AddFilesLbl.Visible = False
        End If

    End Sub

    Private Sub ManagerReportFilesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ManagerReportFilesDataGridView.CellContentClick
        If e.ColumnIndex = 6 Then
            Dim rec As String = ManagerReportFilesDataGridView.Rows(e.RowIndex).Cells(0).Value
            Dim mgr As String = ManagerReportFilesDataGridView.Rows(e.RowIndex).Cells(1).Value
            Dim typ As Integer = 2
            SQLCmd.CommandText = "spManagerReportFilesListDel"
            SQLCmd.CommandType = CommandType.StoredProcedure
            SQLCmd.Parameters.AddWithValue("Record", rec)
            SQLCmd.Parameters.AddWithValue("Manager", mgr)
            SQLCmd.Parameters.AddWithValue("Type", typ)
            SQLCmd.Connection = NewCon
            SQLCmd.CommandTimeout = 0
            NewCon.Open()
            NumRows = SQLCmd.ExecuteNonQuery()
            NewCon.Close()
            Me.ManagerReportFilesTableAdapter.FillManagerFiles(Me.DataSet1.ManagerReportFiles)
        End If
        If e.ColumnIndex = 7 Then
            Dim recid As Integer = ManagerReportFilesDataGridView.Rows(e.RowIndex).Cells(0).Value
            Dim rnme = ManagerReportFilesDataGridView.Rows(e.RowIndex).Cells(5).Value
            SQLCmd.CommandText = "update managerreportfiles set reportname = '" & rnme & "' where recordid = " & recid
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.Connection = NewCon
            SQLCmd.CommandTimeout = 0
            NewCon.Open()
            NumRows = SQLCmd.ExecuteNonQuery()
            NewCon.Close()
            If rnme <> "All" Then
                SQLCmd.CommandText = "insert into managerreportfiles(managerid, reporttype, practice, reportdir) values(" & mgr & ",'" & rtyp & "','" & prac & "','" & rdir & "')"
                SQLCmd.CommandType = CommandType.Text
                SQLCmd.Connection = NewCon
                NewCon.Open()
                NumRows = SQLCmd.ExecuteNonQuery()
                NewCon.Close()
            End If
            Me.ManagerReportFilesTableAdapter.FillByNewManager(Me.DataSet1.ManagerReportFiles)
        End If
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim RptName = AddReport.Text
        SQLCmd.CommandText = "spManagerReportFilesListAdd"
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Parameters.AddWithValue("Report", RptName)
        SQLCmd.Parameters.AddWithValue("Manager", mgr)
        SQLCmd.Connection = NewCon
        SQLCmd.CommandTimeout = 0
        NewCon.Open()
        Dim NumRows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
        Me.ManagerReportFilesTableAdapter.FillManagerFiles(Me.DataSet1.ManagerReportFiles)
    End Sub

    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles AddNew.Click
        Dim rec As String = ManagerReportFilesDataGridView.Rows(0).Cells(0).Value
        Dim mgr As String = ManagerReportFilesDataGridView.Rows(0).Cells(1).Value
        SQLCmd.CommandText = "delete from managerreportfiles where managerid = " & mgr & " and reportname is null"
        SQLCmd.CommandType = CommandType.Text
        SQLCmd.Connection = NewCon
        NewCon.Open()
        NumRows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
        Me.ManagerReportFilesTableAdapter.FillByNewManager(Me.DataSet1.ManagerReportFiles)
        Dim mr As New ManagerReports
        mr.Show()
        Me.Close()

    End Sub
End Class