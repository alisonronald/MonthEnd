Imports System.Data.SqlClient
Public Class DeleteWhat
    Dim Delstr As String = ""
    Dim SQLCmd As New SqlCommand()
    Dim NewCon As New SqlConnection()
    Dim ConStr As String = My.Settings.MonthEndConnectionString
    Dim NumRows As Int16 = 0
    Private Sub GoBtn_Click(sender As Object, e As EventArgs) Handles GoBtn.Click
        Dim BoxChkd As Boolean = False
        Dim LpCnt As Int16 = 1

        Do Until LpCnt = 0
            If AllChk.Checked Then
                DelStuff(5)
                AllChk.ThreeState = False
            End If
            If SupChk.Checked Then
                DelStuff(4)
                SupChk.ThreeState = False
            End If
            If PDChk.Checked Then
                DelStuff(3)
                PDChk.ThreeState = False
            End If
            If CPChk.Checked Then
                DelStuff(2)
                CPChk.ThreeState = False
            End If
            If TTMChk.Checked Then
                DelStuff(1)
                TTMChk.ThreeState = False
            End If
            LpCnt = LpCnt - 1
        Loop
        Dim frmcollect = Application.OpenForms()
        If frmcollect.OfType(Of ProviderReports2).Any Then
            frmcollect.Item("ProviderReports2").Close()
            Dim PR2new As New ProviderReports2
            PR2new.Show()
            Me.Close()
        End If


    End Sub
    Public Sub DelStuff(ByRef Lp As Integer)
        Select Case Lp
            Case 5
                Delstr = "delete from providerreports2"
            Case 4
                Delstr = "delete from providerreports2 where reporttype = 'SupervisorPatientDetail'"
            Case 3
                Delstr = "delete from providerreports2 where reporttype = 'PatientDetail'"
            Case 2
                Delstr = "delete from providerreports2 where reporttype = 'CodingProfile'"
            Case 1
                Delstr = "delete from providerreports2 where reporttype = 'TTM'"
        End Select
        Using NewCon As New SqlConnection(Constr)
            SQLCmd.Connection = NewCon
            SQLCmd.CommandText = Delstr
            SQLCmd.CommandType = CommandType.Text
            NewCon.Open()
            NumRows = SQLCmd.ExecuteNonQuery()
            NewCon.Close()
        End Using
    End Sub
End Class