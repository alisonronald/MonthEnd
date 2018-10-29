Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports System
Imports System.Configuration
Imports System.IO
Imports System.Diagnostics
Public Class CodingProfiles
    Private Sub CodingProfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.CodingProfiles' table. You can move, or remove it, as needed.
        Me.CodingProfilesTableAdapter.FillCodingProfiles(Me.DataSet1.CodingProfiles)
        Me.WorkingLbl.Visible = False
    End Sub

    Private Sub CPWrite_Click(sender As Object, e As EventArgs) Handles CPWrite.Click
        Dim CPro As String = "E:\ConsoleApps\CodingProfiles\CodingProfiles\CodingProfiles\bin\Debug\CodingProfiles.exe"
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