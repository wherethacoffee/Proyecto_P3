Imports System.Data.SqlClient

Class tmp
    Public Function ProductosDisponibles() As List(Of Producto)
        Dim commandText As String = "productoDis"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            Dim list As New List(Of Producto)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim ret As New Producto With {
            .Id = reader("ID"),
            .Nombre = reader("Nombre"),
            .Descripcion = reader("Descripcion"),
            .Precio = reader("Precio"),
            .Existencias = reader("Existencias")
            }
                list.Add(ret)
            End While
            Return list
        End Using
    End Function

    Public Function ServicioDisponible() As List(Of Servicio)
        Dim commandText As String = "servicioDis"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            Dim list As New List(Of Servicio)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim ret As New Servicio With {
                    .Id = reader("ID"),
                    .Nombre = reader("Nombre"),
                    .Descripcion = reader("Descripcion"),
                    .Precio = reader("Precio"),
                    .Disponible = reader("Disponible")
            }
                list.Add(ret)
            End While
            Return list
        End Using
    End Function

    Public Function ServicioPendiente() As List(Of ServiciosPendientes)
        Dim commandText As String = "servicioPen"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            Dim list As New List(Of ServiciosPendientes)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim ret As New ServiciosPendientes With {
            .Id = reader("ID"),
            .NombreServicio = reader("NombreServicio"),
            .NombreUsuario = reader("NombreUsuario"),
            .MomentoInicio = reader("MomentoInicio")
            }
                list.Add(ret)
            End While
            Return list
        End Using
    End Function

    Public Function serviciosContratados(dto As Usuario) As List(Of Contratacion)
        Dim commandText As String = "servicioCliente"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Id", dto.Id)
            Dim list As New List(Of Contratacion)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim ret As New Contratacion With {
            .Id = reader("ID"),
            .IdServicio = reader("IDServicio"),
            .IdUsuario = reader("IDUsuario"),
            .MomentoInicio = reader("MomentoInicio"),
            .MomentoFin = reader("MomentoFin"),
            .Descuento = reader("Descuento"),
            .Total = reader("Total")
            }
                list.Add(ret)
            End While
            Return list
        End Using
    End Function

    Public Function ProductosMasVendidos() As List(Of Producto)
        Dim commandText As String = "productoMas"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            Dim list As New List(Of Producto)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim ret As New Producto With {
            .Id = reader("IDProducto"),
            .Existencias = reader("Ventas")
            }
                list.Add(ret)
            End While
            Return list
        End Using
    End Function

    Public Function ServiciosMasContratados() As List(Of Servicio)
        Dim commandText As String = "servicioMas"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            Dim list As New List(Of Servicio)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim ret As New Servicio With {
            .Id = reader("IDServicio"),
            .Precio = reader("Contrataciones")
            }
                list.Add(ret)
            End While
            Return list
        End Using
    End Function

    Public Function contratacionesTotal() As List(Of Servicio)
        Dim commandText As String = "contratacionesTotal"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            Dim list As New List(Of Servicio)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim ret As New Servicio With {
            .Id = reader("IDServicio"),
            .Precio = reader("TotalContrataciones")
            }
                list.Add(ret)
            End While
            Return list
        End Using
    End Function

    Public Function TotalEnVentas() As List(Of Producto)
        Dim commandText As String = "ventasTotal"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            Dim list As New List(Of Producto)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim ret As New Producto With {
            .Id = reader("IDProducto"),
            .Precio = reader("TotalVentas")
            }
                list.Add(ret)
            End While
            Return list
        End Using
    End Function

    Public Function ProductoConMenosExistencias() As List(Of Producto)
        Dim commandText As String = "productoExistencia"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            Dim list As New List(Of Producto)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim ret As New Producto With {
            .Id = reader("ID"),
            .Nombre = reader("Nombre"),
            .Existencias = reader("Existencias")
            }
                list.Add(ret)
            End While
            Return list
        End Using
    End Function

    Public Function AportacionesPorCliente() As List(Of Producto)
        Dim commandText As String = "clienteMas"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            Dim list As New List(Of Producto)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim ret As New Producto With {
            .Id = reader("IDUsuario"),
            .Precio = reader("Total")
            }
                list.Add(ret)
            End While
            Return list
        End Using
    End Function

End Class