Imports System.Data.SqlClient
Imports Bunifu.Framework.UI
Public Class ConexionSQL

    Public Function OpenConexion() As SqlConnection
        Return New SqlConnection("server=EMMANUELSIST-PC\EMMANUEL ; database=puntoventasql ; integrated security = true")
    End Function






End Class
