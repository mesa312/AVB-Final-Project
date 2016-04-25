Public Class EditForm

    Public Property RestaurantId As Integer
    Private mRestaurants As New Restaurants

    Private Sub EditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row As RestaurantsDataSet.RestaurantsRow
        row = mRestaurants.FindById(RestaurantId)
        txtId.Text = row.Id
        txtFoodType.Text = row.FoodType
        txtBusiness.Text = row.Business
        txtAddress.Text = row.Address
        txtPhone.Text = row.Phone
        txtHours.Text = row.Hours
        txtDriveThru.Text = row.DriveThru
    End Sub

    'updates restaurant information when save button is clicked.
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        mRestaurants.Update(txtId.Text, txtFoodType.Text, txtBusiness.Text, txtAddress.Text, txtPhone.Text, txtHours.Text, txtDriveThru.Text)

        MessageBox.Show(mRestaurants.LastStatus)

    End Sub


    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class