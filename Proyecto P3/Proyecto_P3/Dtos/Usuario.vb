Public Class Usuario
    Property Id As Integer
    Property Tipo As Integer
    Property CorreoElectronico As String
    Property Nombre As String
    Property Constraseña As String

    ReadOnly Property EsEmpleado() As Boolean
        Get
            Return Tipo = 0
        End Get
    End Property
End Class