Imports System.Data.SqlClient
Imports System.IO
Public Class MEProcessing
    Private Sub MEProcessing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet12.practicegroup' table. You can move, or remove it, as needed.
        Me.PracticegroupTableAdapter.FillPracticeGroup(Me.DataSet12.practicegroup)
        'TODO: This line of code loads data into the 'DataSet1.practicegroup' table. You can move, or remove it, as needed.
        Me.practicegroupTableAdapter.FillPracticeGroup(Me.DataSet1.practicegroup)
        'TODO: This line of code loads data into the 'DataSet11.LoadDataTypes' table. You can move, or remove it, as needed.
        Me.LoadDataTypesTableAdapter.FillLoadData(Me.DataSet11.LoadDataTypes)
        'TODO: This line of code loads data into the 'DataSet1.MonthEndReports' table. You can move, or remove it, as needed.
        'Me.MonthEndReportsTableAdapter.FillMeReports(Me.DataSet1.MonthEndReports)
        Me.GoBtn.Visible = False
        Me.PGroupLbl.Visible = False
        Me.PGDropDown.Visible = False
        Me.ClearLoadTables.Visible = False
    End Sub

    Private Sub RunTTM_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RunTTM.LinkClicked
        Dim MEttm As New TTM()
        MEttm.Show()
    End Sub

    Private Sub RunPatientDetail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RunPatientDetail.LinkClicked
        Dim PDtl As New WorkLbl()
        PDtl.Show()
    End Sub

    Private Sub GoBtn_Click(sender As Object, e As EventArgs) Handles GoBtn.Click
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim LoadType As Integer = LoadDropDown.SelectedValue
        Dim PGType As Integer = PGDropDown.SelectedValue
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        Dim AD1 As New SqlDataAdapter()
        Dim DTa As New DataSet()

        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Connection = NewCon
        If LoadType = 9 Then
            SQLCmd.CommandText = "spReadInsertProviders"
        Else
            SQLCmd.CommandText = "spReadInsertExcelData"
            SQLCmd.Parameters.AddWithValue("Type", LoadType)
            SQLCmd.Parameters.AddWithValue("Co", PGType)
        End If
        NewCon.Open()
        Dim Numrows As Int16 = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
        Dim MEp As New MEProcessing()
        MEp.Show()
        Me.Close()
        If LoadType = 3 Then
            SQLCmd.CommandText = "select isnull(count(9),0) from missingspecialties"
            SQLCmd.CommandType = CommandType.Text
            AD1.SelectCommand = SQLCmd
            NewCon.Open()
            AD1.Fill(DTa)
            NewCon.Close()
            Numrows = Convert.ToInt16(DTa.Tables(0).Rows(0)(0))
            If Numrows > 0 Then
                MsgBox("MissingSpecialties")
            End If
        End If
    End Sub

    Private Sub LoadDropDown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LoadDropDown.SelectedIndexChanged
        Me.GoBtn.Visible = True
        Me.PGroupLbl.Visible = True
        Me.PGDropDown.Visible = True
        Me.ClearLoadTables.Visible = True
        Me.LinkLabel1.Text = "CopyDataFolders"
    End Sub

    Private Sub ClearLoadTables_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ClearLoadTables.LinkClicked
        Dim MEp As New MEProcessing()
        MEp.Show()
        Me.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim YesNo As Integer
        YesNo = MsgBox("Has the data extract for the datatype you wish to move been run?", vbYesNo)
        If YesNo = 7 Then
            Exit Sub
        End If
        Dim CP2 As New CopyFolders2
        CP2.Show()
        'WorkingFoldersLbl.Text = "CopyingFoldersAndFiles"
        'Dim ConStr As String = My.Settings.MonthEndConnectionString
        'Dim Ddta As New DataSet()
        'Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        'Dim SQLCmd As SqlCommand = New SqlCommand()
        'SQLCmd.CommandText = "Select datatype, fromfldr, tofldr from copyfolders2 where tofldr is not null order by [type],datatype"
        'SQLCmd.CommandType = CommandType.Text
        'SQLCmd.Connection = NewCon
        'Dim Ad1 As New SqlDataAdapter()
        'Ad1.SelectCommand = SQLCmd
        'NewCon.Open()
        'Ad1.Fill(Ddta)
        'NewCon.Close()
        'Dim LMonth As Date = DateSerial(Year(Date.Now), Month(Date.Now), 0)
        'Dim Folder As String = MonthName(DatePart(DateInterval.Month, LMonth))
        'Dim Dffldr As String = ""
        'Dim Dtfldr As String = ""
        'For Each drow As DataRow In Ddta.Tables(0).Rows
        '    Dffldr = drow("fromfldr") & "\" & Folder
        '    Dtfldr = drow("tofldr") & "\" & Folder
        '    CopyFiles(Dffldr, Dtfldr)
        'Next
        'LinkLabel1.Text = "Completed-Load Data Files"
    End Sub

    Public Sub CopyFiles(ByVal FromFldr As String, ByVal ToFldr As String)
        Dim FrmFldr As New DirectoryInfo(FromFldr)
        Dim DestFldr = New DirectoryInfo(ToFldr)
        If (Len(ToFldr) > 0) Then
            If (Not DestFldr.Exists) Then
                DestFldr.Create()
                For Each file As FileInfo In FrmFldr.GetFiles()
                    file.CopyTo(Path.Combine(ToFldr, file.Name))
                Next
            End If
        End If

    End Sub

    Private Sub RunDirectories_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RunDirectories.LinkClicked
        Dim MEdir As New MEDirectories()
        MEdir.Show()
    End Sub

    Private Sub RunCodingProfiles_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RunCodingProfiles.LinkClicked
        Dim MECp As New CodingProfiles()
        MECp.Show()
    End Sub

    Private Sub WorkingFoldersLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles WorkingFoldersLbl.LinkClicked
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim Ddta As New DataSet()
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        SQLCmd.CommandText = "Select datatype, fromfldr, tofldr from copyfolders where tofldr is null and [type] in ('extract','report') order by [type],datatype, fromfldr"
        SQLCmd.CommandType = CommandType.Text
        SQLCmd.Connection = NewCon
        Dim Ad1 As New SqlDataAdapter()
        Ad1.SelectCommand = SQLCmd
        NewCon.Open()
        Ad1.Fill(Ddta)
        'Null create dates and report amounts for Reports Check List-------------------------------
        SQLCmd.CommandText = "update ReportsCheckList set reportcreated = NULL, reportcount = NULL"
        Dim NumRows As Int16 = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
        Dim LMonth As Date = DateSerial(Year(Date.Now), Month(Date.Now), 0)
        Dim Folder As String = MonthName(DatePart(DateInterval.Month, LMonth))
        Dim ThisYr As String = CStr(Year(LMonth))
        Dim Dffldr As String = ""
        Dim Dtfldr As String = ""
        For Each drow As DataRow In Ddta.Tables(0).Rows
            Dffldr = drow("fromfldr")
            If Dffldr = "Z:\SVMC\Physician wRVU Compensation\ZZwRVU Detail Reports" Then
                For i As Integer = 1 To 3
                    Dffldr = "Z:\SVMC\Physician wRVU Compensation\ZZwRVU Detail Reports"
                    Select Case i
                        Case 1
                            Dffldr = Dffldr & "\" & ThisYr & "\" & Folder & "\CCC"
                        Case 2
                            Dffldr = Dffldr & "\" & ThisYr & "\" & Folder & "\Primecare"
                        Case 3
                            Dffldr = Dffldr & "\" & ThisYr & "\" & Folder & "\SVMC"
                    End Select
                    MakeDir(Dffldr)
                Next
            Else
                Dffldr = Dffldr & "\" & Folder
                MakeDir(Dffldr)
            End If
        Next
        WorkingFoldersLbl.Text = "Working Folders Created"
    End Sub

    Public Sub MakeDir(ByVal FromFldr As String)
        Dim FrmFldr As New DirectoryInfo(FromFldr)
        If (Not FrmFldr.Exists) Then
            FrmFldr.Create()
        End If
    End Sub

    Private Sub MEProviders_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MEProviders.LinkClicked
        Dim MEpr As New Providers
        MEpr.Show()
    End Sub

    Private Sub EncountersLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles EncountersLinkLabel.LinkClicked
        Dim Ecntr As New Encounters
        Ecntr.Show()
    End Sub

    Private Sub MissingChargesLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MissingChargesLinkLabel.LinkClicked
        Dim MissChgs As New MissingCharges
        MissChgs.Show()
    End Sub

    Private Sub SpecialProcessingLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SpecialProcessingLinkLabel.LinkClicked
        Dim SP1 As New SpecialProcessing
        SP1.Show()
    End Sub

    Private Sub PatientDetailAuditLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PatientDetailAuditLink.LinkClicked
        Dim YesNo As Integer = 0
        YesNo = MsgBox("Load Data ?", MsgBoxStyle.YesNo)
        If YesNo = 6 Then
            Dim ConStr As String = My.Settings.MonthEndConnectionString
            Dim NewCon As SqlConnection = New SqlConnection(ConStr)
            Dim SQLCmd As SqlCommand = New SqlCommand()
            SQLCmd.CommandText = "spReadInsertAuditData"
            SQLCmd.CommandType = CommandType.StoredProcedure
            SQLCmd.Connection = NewCon
            SQLCmd.CommandTimeout = 0
            NewCon.Open()
            Dim NumRows = SQLCmd.ExecuteNonQuery()
            NewCon.Close()
        End If
        Dim PDa As New PatientDetailAudit
        PDa.Show()
    End Sub

    Private Sub Supervisor_LinkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Supervisor_LinkLbl.LinkClicked
        Dim SPD As New SupervisorPatientDtl
        SPD.Show()
    End Sub

    Private Sub ClearProviderReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        SQLCmd.CommandText = "delete from providerreports2"
        SQLCmd.CommandType = CommandType.Text
        SQLCmd.Connection = NewCon
        SQLCmd.CommandTimeout = 0
        NewCon.Open()
        Dim NumRows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
    End Sub

    Private Sub PR2LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PR2LinkLabel.LinkClicked
        Dim PR2 As New ProviderReports2
        PR2.Show()
    End Sub

    Private Sub DistributionLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DistributionLinkLabel.LinkClicked
        Dim DL As New DistributionList
        DL.Show()
    End Sub

    Private Sub MergeProfilesLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MergeProfilesLbl.LinkClicked
        Dim MR As New ManagerReports
        MR.Show()
    End Sub

    Private Sub ReportsCheckListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsCheckListToolStripMenuItem.Click
        Dim RCList As New ReportsCheckList
        RCList.Show()
    End Sub

    Private Sub AdminRptsLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AdminRptsLinkLabel.LinkClicked
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        SQLCmd.CommandText = "spAdminReportSend"
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Connection = NewCon
        SQLCmd.CommandTimeout = 0
        NewCon.Open()
        Dim NumRows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
    End Sub

    Private Sub CPSpecialtiesLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CPSpecialtiesLbl.LinkClicked
        Dim PSNew As New PracticeSpecialties
        PSNew.Show()
    End Sub
End Class