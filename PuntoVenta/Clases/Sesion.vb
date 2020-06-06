Imports System.Data.SqlClient
Imports Bunifu.Framework.UI
Public Class Sesion
    Dim _usuario As String
    Dim _contraseña As String


    Dim conexion As SqlConnection
    Dim conexionSQL As ConexionSQL
    Public Sub Sesion()

    End Sub

    Public Sub Sesion(ByVal _usuario As String, ByVal _contraseña As String)
        Me._usuario = _usuario
        Me._contraseña = _contraseña
    End Sub

    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property


    Public Property Contraseña() As String
        Get
            Return _contraseña
        End Get
        Set(ByVal value As String)
            _contraseña = value
        End Set
    End Property




    Public Function OpenConexion() As SqlConnection
        Return New SqlConnection("server=EMMANUELSIST-PC\EMMANUEL ; database=puntoventasql ; integrated security = true")
    End Function

    Public Function IniciarSesion() As Boolean
        conexion = OpenConexion()
        conexion.Open()
        Dim cmd = New SqlCommand("SELECT CASE WHEN EXISTS (SELECT * FROM TbaUsuarios WHERE Usuario = @Usuario AND Password = @Contraseña)" +
                                 "THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END", conexion)
        cmd.Parameters.AddWithValue("@Usuario", Usuario)
        cmd.Parameters.AddWithValue("@Contraseña", Contraseña)

        Using reader As SqlDataReader = cmd.ExecuteReader()
            If (reader.Read()) Then
                Utility.Usuario = Usuario
                Utility.IdUsuario = GetIdUsuario()
                Return reader.GetBoolean(0)

            End If
        End Using

        Return False

    End Function

    Public Function GetIdUsuario() As String
        conexion = OpenConexion()
        conexion.Open()
        Dim cmd = New SqlCommand("SELECT IdUsuario From TbaUsuarios where Usuario = @Usuario", conexion)
        cmd.Parameters.AddWithValue("@Usuario", Usuario)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            If (reader.Read()) Then
                Return reader.GetValue(0)
            Else
                Return ""
            End If

        End Using

    End Function

    Public Sub CargaUsuarios(ByRef dropdown As BunifuDropdown)
        conexion = OpenConexion()
        conexion.Open()

        Dim cmd = New SqlCommand("SELECT Usuario from TbaUsuarios", conexion)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            While (reader.Read())
                dropdown.AddItem(reader.GetValue(0))
            End While
        End Using

    End Sub

End Class
