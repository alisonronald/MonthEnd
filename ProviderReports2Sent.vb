Public Class ProviderReports2Sent
    Private Sub ProviderReports2Sent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ReportsSent' table. You can move, or remove it, as needed.
        Me.ReportsSentTableAdapter.FillReportsSent(Me.DataSet1.ReportsSent)

    End Sub
End Class