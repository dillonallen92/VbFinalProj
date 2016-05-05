Public Class DatabaseForm

    Private Sub DatabaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PlayerDatabaseDataSet.PlayerTable' table. You can move, or remove it, as needed.
        Me.PlayerTableTableAdapter.Fill(Me.PlayerDatabaseDataSet.PlayerTable)

    End Sub
End Class