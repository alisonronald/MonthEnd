Imports System.Data.SqlClient
Public Class MissingCharges
    Private Sub MissingCharges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.MissingCharges' table. You can move, or remove it, as needed.
        'Me.MissingChargesTableAdapter.FillMissingCharges(Me.DataSet1.MissingCharges)
        MissingChargesDataGridView.Visible = False
        WriteBtn.Visible = False
        WorkingLbl.Visible = False
    End Sub

    Private Sub GoBtn_Click(sender As Object, e As EventArgs) Handles GoBtn.Click
        Dim StDate As String = StartDtTxt.Text
        Dim EnDate As String = EndDtTxt.Text
        Dim ConStr As String = My.MySettings.Default("MonthEndConnectionString")
        Dim SelStr As String = "spMissingTicketReport"
        Using NewCon As New SqlConnection(ConStr)
            Dim SQLCmd As New SqlCommand()
            SQLCmd.CommandText = SelStr
            SQLCmd.CommandType = CommandType.StoredProcedure
            SQLCmd.Connection = NewCon
            SQLCmd.Parameters.AddWithValue("StartDt", StDate)
            SQLCmd.Parameters.AddWithValue("EndDt", EnDate)
            SQLCmd.CommandTimeout = 0
            NewCon.Open()
            Dim NumRows As Integer = SQLCmd.ExecuteNonQuery()
            NewCon.Close()
            Me.MissingChargesTableAdapter.FillMissingCharges(Me.DataSet1.MissingCharges)
            MissingChargesDataGridView.Visible = True
            WriteBtn.Visible = True
            RetrieveLbl.Visible = False
        End Using

    End Sub

    Private Sub WriteBtn_Click(sender As Object, e As EventArgs) Handles WriteBtn.Click
        Dim CPro As String = "E:\ConsoleApps\MissingCharges\MissingChgs\MissingChgs\bin\Debug\MissingChgs.exe"
        Dim ConStr As String = My.MySettings.Default("MonthEndConnectionString")
        Dim SelStr = "spSendMissingChgs"
        Dim procsi As ProcessStartInfo = New ProcessStartInfo()
        'procsi.Arguments = " "  CPro
        procsi.FileName = CPro
        procsi.UseShellExecute = False
        procsi.CreateNoWindow = True
        Dim proc As Process = New Process()
        proc.StartInfo = procsi
        proc.Start()
        proc.WaitForExit()
        WorkingLbl.Visible = True
        'Send finished report to the report owner--------------------------
        Using NewCon As New SqlConnection(ConStr)
            Dim SQLCmd As New SqlCommand()
            SQLCmd.CommandText = SelStr
            SQLCmd.CommandType = CommandType.StoredProcedure
            SQLCmd.Connection = NewCon
            NewCon.Open()
            Dim NumRows As Integer = SQLCmd.ExecuteNonQuery()
            NewCon.Close()
        End Using
        WorkingLbl.Visible = False
    End Sub
End Class