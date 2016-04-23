Public Class EditForm

    Public Property RestaurantId As Integer

    Private Sub EditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row As RestaurantsDataSet.RestaurantsRow
        row = mRestaurants.FindBtId(RestaurantId)


    End Sub




    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class