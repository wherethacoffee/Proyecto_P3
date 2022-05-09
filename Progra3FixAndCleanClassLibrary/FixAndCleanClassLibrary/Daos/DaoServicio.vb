Imports System.Data.SqlClient

Public Class DaoServicio
    Private Sub AddParameters(command As SqlCommand, justId As Boolean, dto As Servicio)
        command.Parameters.AddWithValue("@ID", dto.Id)
        If justId Then
            Return
        End If
        With command.Parameters
            .AddWithValue("@Nombre", dto.Nombre)
            .AddWithValue("@Descripcion", dto.Descripcion)
            .AddWithValue("@Precio", dto.Precio)
            .AddWithValue("@Disponible", dto.Disponible)
        End With
    End Sub

    Public Function SeleccionarServicio(dto As Servicio) As Servicio
        Dim commandText As String = "uspSeleccionarServicio"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            AddParameters(command, True, dto)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                Dim ret As New Servicio With {
                    .Id = reader("ID"),
                    .Nombre = reader("Nombre"),
                    .Descripcion = reader("Descripcion"),
                    .Precio = reader("Precio"),
                    .Disponible = reader("Disponible")
                }
                Return ret
            End If
            Return Nothing
        End Using
    End Function

    Public Function SeleccionarServicios(dto As Servicio) As List(Of Servicio)
        Dim commandText As String = "uspSeleccionarServicios"
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

    Public Sub InsertarServicio(dto As Servicio)
        Dim commandText As String = "uspInsertarServicio"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            With command.Parameters
                .AddWithValue("@Nombre", dto.Nombre)
                .AddWithValue("@Descripcion", dto.Descripcion)
                .AddWithValue("@Precio", dto.Precio)
                .AddWithValue("@Disponible", dto.Disponible)
            End With
            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub ActualizarServicio(dto As Servicio)
        Dim commandText As String = "uspActualizarServicio"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            AddParameters(command, False, dto)
            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub EliminarServicio(dto As Servicio)
        Dim commandText As String = "uspEliminarServicio"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            AddParameters(command, True, dto)
            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

End Class