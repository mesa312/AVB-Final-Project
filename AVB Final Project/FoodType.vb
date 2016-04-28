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

    Public Function getbyrestaurantFoodType(ByVal FoodType As String) As DataTable
        Dim table As DataTable = adapter.GetData()
        table.DefaultView.RowFilter = "FoodType='" & FoodType & "'"
        Return table
    End Function







End Class
