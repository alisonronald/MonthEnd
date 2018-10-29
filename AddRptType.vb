Imports System.Data
Imports System.Data.SqlClient
Public Class AddRptType
    Private Sub GoBtn_Click(sender As Object, e As EventArgs) Handles GoBtn.Click
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        Dim NumRows As Integer = 0
        Dim RecId = RecIdTxt.Text
        Dim Rtype = RTypeTxt.Text
        SQLCmd.CommandText = "spAddProviderReport"
        SQLCmd.Parameters.AddWithValue("Record", RecId)
        SQLCmd.Parameters.AddWithValue("Report", Rtype)
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Connection = NewCon
        SQLCmd.CommandTimeout = 0
        NewCon.Open()
        NumRows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
    End Sub
End Class