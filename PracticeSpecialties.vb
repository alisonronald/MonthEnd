Imports System.Data.SqlClient
Imports System.IO
Public Class PracticeSpecialties
    Private Sub SpecsBtn_Click(sender As Object, e As EventArgs) Handles SpecsBtn.Click
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        Dim Spec = PracticeCombo.SelectedItem
        SQLCmd.CommandText = "spGetSpecialties"
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Parameters.AddWithValue("Specialty", Spec)
        SQLCmd.Connection = NewCon
        NewCon.Open()
        Dim Numrows As Int16 = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
        Me.SpecialtiesTableAdapter.FillSpecialties(Me.DataSet1.Specialties)
    End Sub

    Private Sub PracticeSpecialties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Specialties' table. You can move, or remove it, as needed.
        Me.SpecialtiesTableAdapter.FillSpecialties(Me.DataSet1.Specialties)
        WorkingLbl.Visible = False
    End Sub

    Private Sub RptBtn_Click(sender As Object, e As EventArgs) Handles RptBtn.Click
        Dim Practice = PracticeCombo.SelectedItem
        Dim Specialty = SpecialtyCombo.SelectedValue
        Dim YesNo As Integer = 0
        YesNo = MsgBox("Have the Coding Profiles for " + Practice + " been loaded?", vbYesNo)
        If YesNo = 7 Then
            Exit Sub
        End If
        Dim CPro As String = "E:\ConsoleApps\CodingProfileSpecialties\CodingProfileSpecialties\CodingProfileSpecialties\bin\Debug\CodingProfileSpecialties.exe"
        Dim procsi As ProcessStartInfo = New ProcessStartInfo()
        procsi.Arguments = Specialty
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