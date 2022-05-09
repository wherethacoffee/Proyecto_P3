Imports System.Data.SqlClient

Class DaoUsuario
    Public Function SeleccionarUsuarioMedianteCredenciales(dto As Usuario) As Usuario
        Dim commandText As String = "uspSeleccionarUsuarioMedianteCredenciales"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            With command.Parameters
                .AddWithValue("@CorreoElectronico", dto.CorreoElectronico)
                .AddWithValue("@Contraseña", dto.Constraseña)
            End With
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                Dim ret As New Usuario With {
                    .Id = reader("ID"),
                    .Tipo = reader("Tipo"),
                    .CorreoElectronico = reader("CorreoElectronico"),
                    .Nombre = reader("Nombre")
                }
                Return ret
            End If
            Return Nothing
        End Using
    End Function

    Public Sub InsertarUsuario(dto As Usuario)
        Dim commandText As String = "uspInsertarUsuario"
        Using connection As New SqlConnection(My.Settings.MyCS), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            With command.Parameters
                .AddWithValue("@Tipo", dto.Tipo)
                .AddWithValue("@CorreoElectronico", dto.CorreoElectronico)
                .AddWithValue("@Nombre", dto.Nombre)
                .AddWithValue("@Contraseña", dto.Constraseña)
            End With
            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub
End Class