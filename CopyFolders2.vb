Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class CopyFolders2
    Private Sub CopyFolders2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        Dim NumRows As Integer = 0
        SQLCmd.CommandText = "spFillCopyFolders2"
        SQLCmd.CommandType = CommandType.StoredProcedure
        SQLCmd.Connection = NewCon
        NewCon.Open()
        'NumRows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
        'TODO: This line of code loads data into the 'DataSet1.CopyFolders2' table. You can move, or remove it, as needed.
        Me.CopyFolders2TableAdapter.FillCopyFolders2(Me.DataSet1.CopyFolders2)

    End Sub

    Private Sub CopyBtn_Click(sender As Object, e As EventArgs) Handles CopyBtn.Click
        Dim ConStr As String = My.Settings.MonthEndConnectionString
        Dim Ddta As New DataSet()
        Dim NewCon As SqlConnection = New SqlConnection(ConStr)
        Dim SQLCmd As SqlCommand = New SqlCommand()
        Dim NumRows As Integer = 0
        SQLCmd.CommandText = "Select datatype, fromfldr, tofldr from copyfolders2 where [move] = 1 order by [type],datatype"
        SQLCmd.CommandType = CommandType.Text
        SQLCmd.Connection = NewCon
        Dim Ad1 As New SqlDataAdapter()
        Ad1.SelectCommand = SQLCmd
        NewCon.Open()
        Ad1.Fill(Ddta)
        NewCon.Close()
        Dim LMonth As Date = DateSerial(Year(Date.Now), Month(Date.Now), 0)
        Dim Folder As String = MonthName(DatePart(DateInterval.Month, LMonth))
        Dim DType As String = ""
        Dim Dffldr As String = ""
        Dim Dtfldr As String = ""
        For Each drow As DataRow In Ddta.Tables(0).Rows
            DType = drow("datatype")
            Select Case DType
                Case "Providers", "Recreate"
                    Dffldr = drow("fromfldr") & "\"
                    Dtfldr = drow("tofldr") & "\"
                Case Else
                    Dffldr = drow("fromfldr") & "\" & Folder
                    Dtfldr = drow("tofldr") & "\" & Folder
            End Select
            CopyFiles(Dffldr, Dtfldr)
        Next
        SQLCmd.CommandText = "Update CopyFolders2 Set Move = Null"
        NewCon.Open()
        NumRows = SQLCmd.ExecuteNonQuery()
        NewCon.Close()
        Me.CopyFolders2TableAdapter.FillCopyFolders2(Me.DataSet1.CopyFolders2)
        Me.Close()
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
            Else
                For Each file As FileInfo In FrmFldr.GetFiles()
                    file.CopyTo(Path.Combine(ToFldr, file.Name), True)
                Next
            End If
        End If

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Me.Validate()
        Me.CopyFolders2BindingSource.EndEdit()
        Me.CopyFolders2TableAdapter.Update(Me.DataSet1.CopyFolders2)
        Me.CopyFolders2TableAdapter.FillCopyFolders2(Me.DataSet1.CopyFolders2)
    End Sub
End Class