Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports System
Imports System.Configuration
Imports System.IO
Imports System.Diagnostics
Public Class WorkLbl
    Dim PDta As New DataSet()
    Private Sub PatientDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.wRVUPatientDetail' table. You can move, or remove it, as needed.
        Me.WRVUPatientDetailTableAdapter.FillPDetail(Me.DataSet1.wRVUPatientDetail)
        'TODO: This line of code loads data into the 'DataSet11.wRVUPatientDetail' table. You can move, or remove it, as needed.
        'Me.WRVUPatientDetailTableAdapter.FillPDetail(Me.DataSet1.wRVUPatientDetail)
        'TODO: This line of code loads data into the 'DataSet1.wRVUPatientDetail' table. You can move, or remove it, as needed.
        'Me.WRVUPatientDetailTableAdapter.FillPDetail(Me.DataSet1.wRVUPatientDetail)
        WorkingLbl.Visible = False
    End Sub

    Private Sub PDWrite_Click(sender As Object, e As EventArgs) Handles PDWrite.Click
        Dim PDtl As String = "E:\ConsoleApps\PatientDetail\PatientDetail\PatientDetail\bin\Debug\PatientDetail.exe"
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