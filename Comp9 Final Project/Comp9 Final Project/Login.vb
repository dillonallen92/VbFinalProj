'Imports System.Data.OleDb
Public Class Login

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim name As String = txtName.Text
        'Dim counter As Integer = 2
        ''Dim ID As Integer 'Must equal a new id need to check other id and make a new one
        ''****************Needs to connect to database****************
        'Try
        '    DatabaseForm.PlayerDatabaseDataSet.PlayerDatabase.AddPlayerDatabaseRow(counter, txtName.Text, 100, 10, 0)
        '    Try
        '        PlayerDatabaseTableAdapter.Update(PlayerDatabaseDataSet.products)
        '        counter += 1
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message, "Add Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End Try
        'Catch ex As Exception
        '    MessageBox.Show("Duplicate record", "Add Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Try

        DatabaseForm.addData(name)
        Form1.game = ""
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Form1.game = ""
        Close()
    End Sub

End Class