Module Utility
    Public _usuario As String
    Public _idusuario As String


    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Public Property IdUsuario() As String
        Get
            Return _idusuario
        End Get
        Set(value As String)
            _idusuario = value
        End Set
    End Property
    Sub New()

    End Sub
End Module
