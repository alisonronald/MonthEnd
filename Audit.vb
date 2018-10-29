Imports System.Data.SqlClient
Public Class Audit
    Private Sub PDWrite_Click(sender As Object, e As EventArgs)
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

    Private Sub Audit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.CopyFolders3' table. You can move, or remove it, as needed.
        Me.CopyFolders3TableAdapter.FillAuditMove(Me.DataSet1.CopyFolders3)
        WorkingLbl.Visible = False
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Me.Validate()
        Me.CopyFolders3BindingSource.EndEdit()
        Me.CopyFolders3TableAdapter.Update(Me.DataSet1.CopyFolders3)
        Me.CopyFolders3TableAdapter.FillAuditMove(Me.DataSet1.CopyFolders3)
    End Sub

    Private Sub LoadBtn_Click(sender As Object, e As EventArgs) Handles LoadBtn.Click
        Dim Selstr As String = "spReadInsertAuditData"
        Dim Folder As String = ""
        Dim Pos As Integer = 0
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        SQLCmd.CommandText = Selstr
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.CommandTimeout = 0
        SQLCmd.Connection = NewCon
        NewCon.Open()
        Dim NumRows As Integer = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
        Me.CopyFolders3TableAdapter.FillAuditMove(Me.DataSet1.CopyFolders3)
        Dim Aud2 As New Audit2
        Aud2.Show()
        Me.Close()
    End Sub
End Class