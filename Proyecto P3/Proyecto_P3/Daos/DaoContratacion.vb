Imports System.Data.SqlClient

Class DaoContratacion
    Public Sub InsertarContratacion(dto As Contratacion)
        Dim commandText As String = "uspInsertarContratacion"
        Using connection As New SqlConnection(My.Settings.MyCs), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            With command.Parameters
                .AddWithValue("@IDUsuario", dto.IdUsuario)
                .AddWithValue("@IDServicio", dto.IdServicio)
                .AddWithValue("@MomentoInicio", dto.MomentoInicio)
                .AddWithValue("@Descuento", dto.Descuento)
                .AddWithValue("@Total", dto.Total)
            End With
            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub FinalizarContratacion(dto As Contratacion)
        Dim commandText As String = "uspFinalizarContratacion"
        Using connection As New SqlConnection(My.Settings.MyCs), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            With command.Parameters
                .AddWithValue("@ID", dto.Id)
            End With
            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    Public Function SeleccionarUsuariosContrataronDiaActual() As List(Of Usuario)
        Dim commandText As String = "uspSeleccionarIDUsuariosContrataronDiaActual"
        Using connection As New SqlConnection(My.Settings.MyCs), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            Dim list As New List(Of Usuario)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim ret As New Usuario With {
                    .Id = reader("IDUsuario")
                }
                list.Add(ret)
            End While
            Return list
        End Using
    End Function
End Class