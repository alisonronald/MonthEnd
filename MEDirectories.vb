Public Class MEDirectories
    Private Sub MEDirectories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet12.CopyFolders' table. You can move, or remove it, as needed.
        Me.CopyFoldersTableAdapter.FillCopyFolders(Me.DataSet12.CopyFolders)
        'TODO: This line of code loads data into the 'DataSet11.CopyFolders' table. You can move, or remove it, as needed.
        Me.CopyFoldersTableAdapter.FillCopyFolders(Me.DataSet11.CopyFolders)
        'TODO: This line of code loads data into the 'DataSet1.CopyFolders' table. You can move, or remove it, as needed.
        Me.CopyFoldersTableAdapter.FillCopyFolders(Me.DataSet1.CopyFolders)

    End Sub

    Private Sub UpdBtn_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Me.Validate()
        Me.CopyFoldersBindingSource.EndEdit()
        Me.CopyFoldersTableAdapter.Update(Me.DataSet1.CopyFolders)
        Me.CopyFoldersTableAdapter.FillCopyFolders(Me.DataSet1.CopyFolders)
    End Sub

    Private Sub InsertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertToolStripMenuItem.Click

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Me.CopyFoldersBindingSource.RemoveCurrent()
        Me.CopyFoldersBindingSource.EndEdit()
        Me.CopyFoldersTableAdapter.Update(Me.DataSet1.CopyFolders)
        Me.CopyFoldersTableAdapter.FillCopyFolders(Me.DataSet1.CopyFolders)
    End Sub
End Class