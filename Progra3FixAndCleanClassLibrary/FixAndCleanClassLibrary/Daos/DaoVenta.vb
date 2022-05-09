Imports System.Data.SqlClient

Class DaoVenta
    Public Sub InsertarVenta(dto As Venta)
        Dim commandText As String = "uspInsertarVenta"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            With command.Parameters
                .AddWithValue("@Momento", dto.Momento)
                .AddWithValue("@IDUsuario", dto.IdUsuario)
                .AddWithValue("@IDProducto", dto.IdProducto)
                .AddWithValue("@Descuento", dto.Descuento)
                .AddWithValue("@Total", dto.Total)
            End With
            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    Public Function SeleccionarVentasUltimoMesUsuario(dto As Usuario) As List(Of Venta)
        Dim commandText As String = "uspSeleccionarVentasUltimoMesUsuario"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@IDUsuario", dto.Id)
            Dim list As New List(Of Venta)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim ret As New Venta With {
                    .Momento = reader("Momento"),
                    .IdUsuario = reader("IDUsuario"),
                    .IdProducto = reader("IDProducto"),
                    .Descuento = reader("Descuento"),
                    .Total = reader("Total")
                }
                list.Add(ret)
            End While
            Return list
        End Using
    End Function
End Class