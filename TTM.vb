Public Class TTM
    Private Sub TTM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.TTMHistory' table. You can move, or remove it, as needed.
        Me.TTMHistoryTableAdapter.FillTTMHistory(Me.DataSet1.TTMHistory)
        WorkingLbl.Visible = False
    End Sub

    Private Sub TTMWrite_Click(sender As Object, e As EventArgs) Handles TTMWrite.Click
        Dim CPro As String = "E:\ConsoleApps\TTM\TTM\TTM\bin\Debug\TTM.exe"
        Dim procsi As ProcessStartInfo = New ProcessStartInfo()
        'procsi.Arguments = " "  CPro
        procsi.FileName = CPro
        procsi.UseShellExecute = False
        procsi.CreateNoWindow = True
        Dim proc As Process = New Process()
        proc.StartInfo = procsi
        WorkingLbl.Visible = True
        proc.Start()
        proc.WaitForExit()
        Dim arrProcess() As Process = System.Diagnostics.Process.GetProcessesByName("Excel")

        For Each p As Process In arrProcess
            p.Kill()
        Next
        WorkingLbl.Visible = False
    End Sub
End Class