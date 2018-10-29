Imports System.Data.SqlClient
Imports System.IO
Imports System.Diagnostics
Public Class MEHome
    Private Sub MEDocs_Click(sender As Object, e As EventArgs) Handles MonthEndToolStripMenuItem.Click

    End Sub

    Private Sub MEHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MEProcs_Click(sender As Object, e As EventArgs) Handles MEProcs.Click
        Dim MEp As New MEProcessing()
        MEp.Show()
    End Sub


    Private Sub NXHealthLinkLable_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles NXHealthLinkLable.LinkClicked
        Dim NewNX As New NXReport
        NewNX.Show()
    End Sub

    Private Sub RecreateLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RecreateLink.LinkClicked

        Dim PDtl As String = "E:\Desktop\Recreate\RecreateRpts\RecreateRpts\bin\Debug\RecreateRpts.exe"
        Dim procsi As ProcessStartInfo = New ProcessStartInfo()
        'procsi.Arguments = " " + "/C" + " " + PDtl
        procsi.FileName = PDtl
        procsi.UseShellExecute = False
        procsi.CreateNoWindow = True
        Dim proc As Process = New Process()
        proc.StartInfo = procsi
        proc.Start()
        proc.WaitForExit()


    End Sub

    Private Sub NXHealthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NXHealthToolStripMenuItem.Click
        Dim NXHlth As New NXHealthDoc
        NXHlth.Show()
    End Sub

    Private Sub RecreateReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecreateReportsToolStripMenuItem.Click
        Dim Recreate As New RecreateDoc
        Recreate.Show()
    End Sub

    Private Sub SEVMGLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SEVMGLink.LinkClicked
        Dim PDtl As String = "E:\Desktop\SVEMG-MHMG\SvemgMhmg\SvemgMhmg\bin\Debug\SvemgMhmg.exe"
        Dim procsi As ProcessStartInfo = New ProcessStartInfo()
        'procsi.Arguments = " " + "/C" + " " + PDtl
        procsi.FileName = PDtl
        procsi.UseShellExecute = False
        procsi.CreateNoWindow = True
        Dim proc As Process = New Process()
        proc.StartInfo = procsi
        proc.Start()
        proc.WaitForExit()
    End Sub

    Private Sub SvemgMhmgToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SvemgMhmgToolStripMenuItem.Click
        Dim Svemg As New SvemgMhmgDoc
        Svemg.Show()
    End Sub

    Private Sub ProcessingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcessingToolStripMenuItem.Click
        Dim DocU As New Documentation()
        DocU.Show()
    End Sub

    Private Sub TasksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TasksToolStripMenuItem.Click
        Dim Tsks As New METasks
        Tsks.Show()
    End Sub
End Class
