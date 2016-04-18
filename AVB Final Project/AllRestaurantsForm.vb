Public Class AllRestaurantsForm
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RestaurantsDataSet.Restaurants' table. You can move, or remove it, as needed.
        Me.RestaurantsTableAdapter.Fill(Me.RestaurantsDataSet.Restaurants)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class