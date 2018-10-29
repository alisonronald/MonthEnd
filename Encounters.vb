Public Class Encounters
    Private Sub EncountersWrite_Click(sender As Object, e As EventArgs) Handles EncountersWrite.Click
        Dim CPro As String = "E:\ConsoleApps\SVMCEncounters\SVMCEncounters\SVMCEncounters\bin\Debug\SVMCEncounters.exe"
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

    Private Sub Encounters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.SVMCEncounters' table. You can move, or remove it, as needed.
        Me.SVMCEncountersTableAdapter.FillEncounters(Me.DataSet1.SVMCEncounters)
        WorkingLbl.Visible = False
    End Sub
End Class