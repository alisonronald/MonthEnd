Public Class SupervisorPatientDtl
    Private Sub SupervisorPatientDtl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.wRVUSupervisorPatientDetail' table. You can move, or remove it, as needed.
        Me.WRVUSupervisorPatientDetailTableAdapter.FillSupervisor(Me.DataSet1.wRVUSupervisorPatientDetail)
        WorkingLbl.Visible = False
    End Sub

    Private Sub SPDWrite_Click(sender As Object, e As EventArgs) Handles SPDWrite.Click
        Dim PDtl As String = "E:\ConsoleApps\SupervisorPatientDetail\SupervisorPatientDetail\SupervisorPatientDetail\bin\Debug\SupervisorPatientDetail.exe"
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
        Dim arrProcess() As Process = System.Diagnostics.Process.GetProcessesByName("Excel")

        For Each p As Process In arrProcess
            p.Kill()
        Next
        WorkingLbl.Visible = False
    End Sub
End Class