Public Class SrvVenta
    Private daoVenta As New DaoVenta
    Private daoProducto As New DaoProducto

    Function TieneDescuento30PorCientoEnProductos(usuario As Usuario) As Boolean
        Dim totalGastadoEnProductosDesdeElUltimoDescuento As Decimal = daoVenta.SeleccionarVentasUltimoMesUsuario(usuario) _
            .OrderByDescending(Function(venta) venta.Momento) _
            .TakeWhile(Function(venta) venta.Descuento = 0) _
            .Sum(Function(venta) venta.Total)
        Return totalGastadoEnProductosDesdeElUltimoDescuento >= 1000
    End Function

    Sub RegistrarVenta(usuario As Usuario, producto As Producto, Optional conDescuento As Boolean = False)
        producto = daoProducto.SeleccionarProducto(producto)
        Dim descuento As Decimal = If(conDescuento, producto.Precio * 0.3, 0)
        Dim total = producto.Precio - descuento
        Dim venta As New Venta With {
            .Momento = Date.Now,
            .IdUsuario = usuario.Id,
            .IdProducto = producto.Id,
            .Descuento = descuento,
            .Total = total
        }
        daoVenta.InsertarVenta(venta)

        'Disminuir el inventario.
        producto.Existencias -= 1
        daoProducto.ActualizarProducto(producto)
    End Sub
End Class