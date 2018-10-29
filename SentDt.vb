Imports System.Data.SqlClient
Public Class SentDt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SndDt As String = SentDtTxt.Text
        Dim NumRows As Integer = 0
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        SQLCmd.CommandText = "spUpdateProviderReports2Sent"
        SQLCmd.Parameters.AddWithValue("SentDt", SndDt)
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Connection = NewCon
        NewCon.Open()
        NumRows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
    End Sub
End Class