Public Class CodingProfilesSent
    Private Sub CodingProfilesSent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.CodingProfilesSent' table. You can move, or remove it, as needed.
        Me.CodingProfilesSentTableAdapter.FillCPSent(Me.DataSet1.CodingProfilesSent)

    End Sub
End Class