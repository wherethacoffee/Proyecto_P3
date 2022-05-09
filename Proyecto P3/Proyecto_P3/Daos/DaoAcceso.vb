Imports System.Data.SqlClient

Class DaoAcceso
    Public Sub InsertarAcceso(dto As Acceso)
        Dim commandText As String = "uspInsertarAcceso"
        Using connection As New SqlConnection(My.Settings.MyCs), command As New SqlCommand(commandText, connection)
            command.CommandType = CommandType.StoredProcedure
            With command.Parameters
                .AddWithValue("@IDUsuario", dto.IdUsuario)
                .AddWithValue("@Momento", dto.Momento)
            End With
            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub
End Class