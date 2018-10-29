Public Class PatientDetailAudit
    Private Sub PatientDetailAudit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.wRVUPatientDetailAudit' table. You can move, or remove it, as needed.
        Me.WRVUPatientDetailAuditTableAdapter.FillPatientDetailAudit(Me.DataSet1.wRVUPatientDetailAudit)
        WorkingLbl.Visible = False
    End Sub

    Private Sub PDWrite_Click(sender As Object, e As EventArgs) Handles PDWrite.Click
        Dim PDtl As String = "E:\ConsoleApps\PatientDetailAudit\PatientDetailAudit\PatientDetailAudit\bin\Debug\PatientDetailAudit.exe"
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