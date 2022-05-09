Public Class Login
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim correo As New SrvAutenticacion

        Dim correoElectronico As String = TxtCorreo.Text
        Dim contraseña As String = TxtContraseña.Text

        Try
            Dim usuarioConMomento = correo.IniciarSesion(correoElectronico, contraseña)
            usuarioConMomentoCo = usuarioConMomento
            usuarioCo = usuarioConMomento.Usuario

            If usuarioCo.EsEmpleado Then
                Hide()
            Else
                Hide()
            End If

        Catch ex As Exception
            LblError.Text = ex.Message
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub
End Class