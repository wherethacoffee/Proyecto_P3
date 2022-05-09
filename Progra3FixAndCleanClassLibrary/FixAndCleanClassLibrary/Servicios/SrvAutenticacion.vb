Public Class SrvAutenticacion
    Private daoUsuario As New DaoUsuario

    Function IniciarSesion(correoElectronico As String, contraseña As String) As UsuarioConMomento
        Dim now As Date = Date.Now

        'Comprobar la existencia de un usuario con las credenciales proporcionadas.
        Dim dtoUsuarioInput As New Usuario With {
            .CorreoElectronico = correoElectronico,
            .Constraseña = contraseña
        }
        Dim dtoUsuarioOutput As Usuario = daoUsuario.SeleccionarUsuarioMedianteCredenciales(dtoUsuarioInput)
        If dtoUsuarioOutput Is Nothing Then
            Throw New Exception("Credenciales inválidas.")
        End If

        'Registrar el momento de inicio de sesión.
        Dim dtoAcceso As New Acceso With {
            .IdUsuario = dtoUsuarioOutput.Id,
            .Momento = now
        }
        Dim daoAccess As New DaoAcceso
        daoAccess.InsertarAcceso(dtoAcceso)

        Return New UsuarioConMomento With {
            .Usuario = dtoUsuarioOutput,
            .Momento = now
        }
    End Function

    Sub CrearCuentaCliente(nombre As String, correoElectronico As String, contraseña As String)
        Dim nuevoUsuariocliente As New Usuario With {
            .Tipo = 1,
            .Nombre = nombre,
            .CorreoElectronico = correoElectronico,
            .Constraseña = contraseña
        }
        daoUsuario.InsertarUsuario(nuevoUsuariocliente)
    End Sub
End Class