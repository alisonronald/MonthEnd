Imports System.Data.SqlClient
Public Class NewProviders
    Private Sub NewProviders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Constr As String = My.Settings.MonthEndConnectionString
        Dim NumRws As Int16 = 0
        Using NewCon As New SqlConnection(Constr)
            Dim SQLCmd As New SqlCommand()
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.CommandText = "Update ProvidersIn set [Select] = NULL"
            SQLCmd.Connection = NewCon
            NewCon.Open()
            NumRws = SQLCmd.ExecuteNonQuery()
            NewCon.Close()
        End Using
        'TODO: This line of code loads data into the 'DataSet1.ProvidersIn' table. You can move, or remove it, as needed.
        Me.ProvidersInTableAdapter.FillProvidersIn(Me.DataSet1.ProvidersIn)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.ProvidersInBindingSource.EndEdit()
        Me.ProvidersInTableAdapter.Update(Me.DataSet1.ProvidersIn)
        Me.ProvidersInTableAdapter.FillProvidersIn(Me.DataSet1.ProvidersIn)
    End Sub

    Private Sub ProvidersTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvidersTableToolStripMenuItem.Click
        Dim Selstr As String = "spInsertNewProviders"
        Dim InsTyp As Int16 = 1
        Dim NumRws As Int16 = 0
        Dim Constr As String = My.Settings.MonthEndConnectionString
        Using NewCon As New SqlConnection(Constr)
            Dim SQLCmd As New SqlCommand()
            SQLCmd.CommandType = CommandType.StoredProcedure
            SQLCmd.CommandText = Selstr
            SQLCmd.Connection = NewCon
            SQLCmd.Parameters.AddWithValue("InsType", InsTyp)
            NewCon.Open()
            NumRws = SQLCmd.ExecuteNonQuery()
            NewCon.Close()
        End Using
        Me.ProvidersInTableAdapter.FillProvidersIn(Me.DataSet1.ProvidersIn)
    End Sub

    Private Sub ProviderReportsAttributesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProviderReportsAttributesToolStripMenuItem.Click
        Dim Selstr As String = "spInsertNewProviders"
        Dim InsTyp As Int16 = 2
        Dim NumRws As Int16 = 0
        Dim Constr As String = My.Settings.MonthEndConnectionString
        Using NewCon As New SqlConnection(Constr)
            Dim SQLCmd As New SqlCommand()
            SQLCmd.CommandType = CommandType.StoredProcedure
            SQLCmd.CommandText = Selstr
            SQLCmd.Connection = NewCon
            SQLCmd.Parameters.AddWithValue("InsType", InsTyp)
            NewCon.Open()
            NumRws = SQLCmd.ExecuteNonQuery()
            NewCon.Close()
        End Using
    End Sub
End Class