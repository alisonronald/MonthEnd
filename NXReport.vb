Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Public Class NXReport
    Private Sub NXReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.NXReport' table. You can move, or remove it, as needed.
        Me.NXReportTableAdapter.FillNXReport(Me.DataSet1.NXReport)
        WorkingLbl.Visible = False
        WriteBtn.Visible = False
    End Sub

    Private Sub WriteBtn_Click(sender As Object, e As EventArgs) Handles WriteBtn.Click
        WorkingLbl.Visible = True
        Dim CPro As String = "E:\ConsoleApps\NXHealth\NXReporting\NXReporting\bin\Debug\NXReporting.exe"
        Dim ConStr As String = My.MySettings.Default("NXHealth")
        Dim SelStr = "spSendNXReport"
        Dim procsi As ProcessStartInfo = New ProcessStartInfo()
        'procsi.Arguments = " "  CPro
        procsi.FileName = CPro
        procsi.UseShellExecute = False
        procsi.CreateNoWindow = True
        Dim proc As Process = New Process()
        proc.StartInfo = procsi
        proc.Start()
        proc.WaitForExit()
        'Send finished report to the report owner--------------------------
        Using NewCon As New SqlConnection(ConStr)
            Dim SQLCmd As New SqlCommand()
            SQLCmd.CommandText = SelStr
            SQLCmd.CommandType = CommandType.StoredProcedure
            SQLCmd.Connection = NewCon
            NewCon.Open()
            Dim NumRows As Integer = SQLCmd.ExecuteNonQuery()
            NewCon.Close()
        End Using
        WorkingLbl.Visible = False
        Dim arrProcess() As Process = System.Diagnostics.Process.GetProcessesByName("Excel")

        For Each p As Process In arrProcess
            p.Kill()
        Next
    End Sub

    Private Sub GetNewDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetNewDataToolStripMenuItem.Click
        Dim ConStr As String = My.MySettings.Default("NXHealth")
        Dim SelStr As String = "spNXHealthReport"
        Dim Foldr As String = MonthName(DatePart(DateInterval.Month, Date.Now))
        Dim ToFldr = "E:\NXHealth\Reports\" & Foldr
        Dim DestFldr = New DirectoryInfo(ToFldr)
        Using NewCon As New SqlConnection(ConStr)
            Dim SQLCmd As New SqlCommand()
            SQLCmd.CommandText = SelStr
            SQLCmd.CommandType = CommandType.StoredProcedure
            SQLCmd.Connection = NewCon
            NewCon.Open()
            Dim NumRows As Integer = SQLCmd.ExecuteNonQuery()
            NewCon.Close()
        End Using
        Me.NXReportTableAdapter.FillNXReport(Me.DataSet1.NXReport)
        WriteBtn.Visible = True
        If (Not DestFldr.Exists) Then
            DestFldr.Create()
        End If
    End Sub
End Class