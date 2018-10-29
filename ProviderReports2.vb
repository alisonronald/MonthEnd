Imports System.Data.SqlClient
Public Class ProviderReports2
    Private Sub ProviderReports2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ProviderReports2' table. You can move, or remove it, as needed.
        Me.ProviderReports2TableAdapter.FillProviderReports2(Me.DataSet1.ProviderReports2)

    End Sub

    Private Sub UpdateSendReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateSendReportsToolStripMenuItem.Click
        Me.Validate()
        Me.ProviderReports2BindingSource.EndEdit()
        Me.ProviderReports2TableAdapter.Update(Me.DataSet1.ProviderReports2)
        Me.ProviderReports2TableAdapter.Delete()
        Me.ProviderReports2TableAdapter.FillProviderReports2(Me.DataSet1.ProviderReports2)
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        Dim DW As New DeleteWhat
        DW.Show()
    End Sub

    Private Sub ProvidersNotFoundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvidersNotFoundToolStripMenuItem.Click
        Dim PNF As New PRNotFound
        PNF.Show()
    End Sub

    Private Sub UpdateSentRptsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateSentRptsToolStripMenuItem.Click
        Dim SndDt As New SentDt
        SndDt.Show()
    End Sub

    Private Sub ProviderRptsSentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProviderRptsSentToolStripMenuItem.Click
        Dim Pr2Sent As New ProviderReports2Sent
        Pr2Sent.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DellAllBtn.Click
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim Numrows As Integer = 0
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        SQLCmd.CommandText = "delete from providerreports2"
        SQLCmd.CommandType = CommandType.Text
        SQLCmd.Connection = NewCon
        NewCon.Open()
        Numrows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
        Me.ProviderReports2TableAdapter.FillProviderReports2(Me.DataSet1.ProviderReports2)
    End Sub

    Private Sub ProviderReportsAttributesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProviderReportsAttributesToolStripMenuItem.Click
        Dim PrAttributes As New ProviderReportsAttributes
        PrAttributes.Show()
    End Sub

    Private Sub CodingProfilesSentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodingProfilesSentToolStripMenuItem.Click
        Dim CPS As New CodingProfilesSent
        CPS.Show()
    End Sub
End Class