Public Class FoodType

    Private adapter As New _
        RestaurantsDataSetTableAdapters.RestaurantsTableAdapter

    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "FoodType"
            Return table

        End Get
    End Property
End Class
