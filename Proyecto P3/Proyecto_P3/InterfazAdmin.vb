Public Class InterfazAdmin
    Private Sub AdminstrarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminstrarProductosToolStripMenuItem.Click
        Hide()
        AdministracionProductos.Show()
    End Sub

    Private Sub AdministrarServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarServiciosToolStripMenuItem.Click
        Hide()
        AdministracionServicios.Show()
    End Sub

    Private Sub ContratacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratacionesToolStripMenuItem.Click
        Hide()
        Contrataciones.Show()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Hide()
        Login.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class