Public Class InterfazUsuario
    Private Sub ServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem.Click
        Hide()
        Servicios.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Hide()
        Productos.Show()
    End Sub

    Private Sub ServiciosContratadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosContratadosToolStripMenuItem.Click
        Hide()
        ServiciosContratados.Show()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Hide()
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class