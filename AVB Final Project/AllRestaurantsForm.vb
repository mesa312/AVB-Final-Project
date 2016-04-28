Public Class AllRestaurantsForm

    Private mRestaurants As New Restaurants


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RestaurantsDataSet.Restaurants' table. You can move, or remove it, as needed.
        ' Me.RestaurantsTableAdapter.Fill(Me.RestaurantsDataSet.Restaurants)

        dgvRestaurants.DataSource = mRestaurants.Items()
    End Sub


    ''Fuction that adds restaurants to the data table
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lblStatus.Text = ""

        If Not mRestaurants.Insert(CInt(txtId.Text), txtFoodType.Text, txtBusiness.Text, txtAddress.Text, txtPhone.Text, txtHours.Text, txtDriveThru.Text) Then
            MessageBox.Show("Cannot add Restaurant." & mRestaurants.LastStatus)

        Else
            MessageBox.Show("Restaurant added." & mRestaurants.LastStatus)
            dgvRestaurants.DataSource = mRestaurants.Items
        End If
    End Sub


    'Fuction that deletes restaurants from the data table
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        lblStatus.Text = ""
        If mRestaurants.Delete(CInt(txtId.Text)) Then
            dgvRestaurants.DataSource = mRestaurants.Items
        End If

        lblStatus.Text = mRestaurants.LastStatus
    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim RestaurantId As Integer = CInt(txtId.Text)

        Dim FrmEdit As New EditForm
        FrmEdit.RestaurantId = RestaurantId
        FrmEdit.ShowDialog()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AllRestaurantsForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        dgvRestaurants.DataSource = mRestaurants.Items()
    End Sub
End Class