Public Class SrvContratacion
    Private daoContratacion As New DaoContratacion
    Private daoServicio As New DaoServicio

    Function TieneDescuento30PorCientoEnContrataciones(usuario As Usuario) As Boolean
        Dim hoy As Date = Date.Now
        If hoy.DayOfWeek <> DayOfWeek.Tuesday AndAlso hoy.DayOfWeek <> DayOfWeek.Wednesday Then
            'No se encuentra dentro de los dias válidos del descuento.
            Return False
        End If
        Dim usuariosQueHanContratadoHoy = daoContratacion.SeleccionarUsuariosContrataronDiaActual()
        If usuariosQueHanContratadoHoy.Any(Function(u) u.Id = usuario.Id) Then
            'El usuario ya tuvo descuento en alguna contratación hoy.
            Return False
        End If
        If usuariosQueHanContratadoHoy.Count >= 4 Then
            'Ya no hay descuento en contrataciones por el día de hoy.
            Return False
        End If
        Return True
    End Function

    Sub RegistrarContratacion(usuario As Usuario, servicio As Servicio, Optional conDescuento As Boolean = False)
        servicio = daoServicio.SeleccionarServicio(servicio)
        Dim descuento As Decimal = If(conDescuento, servicio.Precio * 0.3, 0)
        Dim total = servicio.Precio - descuento
        Dim contratacion As New Contratacion With {
            .IdUsuario = usuario.Id,
            .IdServicio = servicio.Id,
            .MomentoInicio = Date.Now,
            .Descuento = descuento,
            .Total = total
        }
        daoContratacion.InsertarContratacion(contratacion)
    End Sub

    Sub FinalizarContratacion(contratacion As Contratacion)
        daoContratacion.FinalizarContratacion(contratacion)
    End Sub
End Class