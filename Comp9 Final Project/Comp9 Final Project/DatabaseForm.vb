'Imports System.Data.OleDb
Public Class DatabaseForm

    Dim idCount As Integer = 1

    Private Sub DatabaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PlayerDatabaseDataSet.PlayerTable' table. You can move, or remove it, as needed.
        Me.PlayerTableTableAdapter.Fill(Me.PlayerDatabaseDataSet.PlayerTable)

    End Sub

    Public Function getData(ByVal trait As String, ByVal name As String) As String
        Dim searchedValue As String = "" 'to avoid the null pointer exception

        'access the row we need in particular, based off the player name
        Dim rows() As DataRow = Me.PlayerDatabaseDataSet.PlayerTable.Select("player_name='" & name & "'")

        'make sure the rows exist
        If rows.Count > 0 Then
            'go through the row in the table and look for the particular column based off the trait passed in
            searchedValue = rows(0).Item(trait)
        End If
        'return the value from the if statement
        Return searchedValue
    End Function

    Public Sub addData(ByVal name As String)
        Dim playerName As String = ""
        playerName = name
        Try
            PlayerDatabaseDataSet.PlayerTable.AddPlayerTableRow(playerName, 100, 10, 0)
            Try
                PlayerTableTableAdapter.Update(PlayerDatabaseDataSet.PlayerTable)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Player Added!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Catch ex As Exception
            MessageBox.Show("Duplicate Message", "Add Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'Need update record function as well
End Class