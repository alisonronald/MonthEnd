Imports System.Data.SqlClient
Public Class Audit2
    Private Sub Audit2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.wRVUPatientDetailAudit' table. You can move, or remove it, as needed.
        Me.WRVUPatientDetailAuditTableAdapter.FillPatientDetailAudit(Me.DataSet1.wRVUPatientDetailAudit)
        WorkingLbl.Visible = False
    End Sub

    Private Sub PDWrite_Click(sender As Object, e As EventArgs) Handles PDWrite.Click
        Dim Selstr As String = "spGetPostingDate"
        Dim Folder As String = ""
        Dim Pos As Integer = 0
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        SQLCmd.CommandText = Selstr
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Connection = NewCon
        Dim Dta1 As New DataSet()
        Dim Ad1 As New SqlDataAdapter()
        Ad1.SelectCommand = SQLCmd
        NewCon.Open()
        Ad1.Fill(Dta1)
        NewCon.Close()
        Folder = Convert.ToString(Dta1.Tables(0).Rows(0)(0))
        Dim PDtl As String = "E:\ConsoleApps\PatientDetailAudit\PatientDetailAudit\PatientDetailAudit\bin\Debug\PatientDetailAudit.exe"
        Dim procsi As ProcessStartInfo = New ProcessStartInfo()
        'procsi.Arguments = " " + "/C" + " " + PDtl
        procsi.FileName = PDtl
        procsi.Arguments = Folder
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
        Me.Close()
    End Sub
End Class