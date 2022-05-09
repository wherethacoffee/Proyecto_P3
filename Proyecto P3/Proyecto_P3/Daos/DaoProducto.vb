Imports System.Data.SqlClient

Public Class DaoProducto
    Private Sub AddParameters(command As SqlCommand, justId As Boolean, dto As Producto)
        command.Parameters.AddWithValue("@ID", dto.Id)
        If justId Then
            Return
        End If
        With command.Parameters
            .AddWithValue("@Nombre", dto.Nombre)
            .AddWithValue("@Descripcion", dto.Descripcion)
            .AddWithValue("@Precio", dto.Precio)
            .AddWithValue("@Existencias", dto.Existencias)
        End With
    End Sub

    Public Function SeleccionarProducto(dto As Producto) As Producto
        Dim commandText As String = "uspSeleccionarProducto"
        Using connection As New SqlConnection(My.Settings.MyCs), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            AddParameters(command, True, dto)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                Dim ret As New Producto With {
                    .Id = reader("ID"),
                    .Nombre = reader("Nombre"),
                    .Descripcion = reader("Descripcion"),
                    .Precio = reader("Precio"),
                    .Existencias = reader("Existencias")
                }
                Return ret
            End If
            Return Nothing
        End Using
    End Function

    Public Function SeleccionarProductosBreve(dto As Producto) As List(Of Producto)
        Dim commandText As String = "uspSeleccionarProductosBreve"
        Using connection As New SqlConnection(My.Settings.MyCs), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            Dim list As New List(Of Producto)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim ret As New Producto With {
                    .Id = reader("ID"),
                    .Nombre = reader("Nombre"),
                    .Precio = reader("Precio")
                }
                list.Add(ret)
            End While
            Return list
        End Using
    End Function

    Public Sub InsertarProducto(dto As Producto)
        Dim commandText As String = "uspInsertarProducto"
        Using connection As New SqlConnection(My.Settings.MyCs), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            With command.Parameters
                .AddWithValue("@Nombre", dto.Nombre)
                .AddWithValue("@Descripcion", dto.Descripcion)
                .AddWithValue("@Precio", dto.Precio)
                .AddWithValue("@Existencias", dto.Existencias)
            End With
            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub ActualizarProducto(dto As Producto)
        Dim commandText As String = "uspActualizarProducto"
        Using connection As New SqlConnection(My.Settings.MyCs), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            AddParameters(command, False, dto)
            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub EliminarProducto(dto As Producto)
        Dim commandText As String = "uspEliminarProducto"
        Using connection As New SqlConnection(My.Settings.MyCs), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            AddParameters(command, True, dto)
            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub
End Class