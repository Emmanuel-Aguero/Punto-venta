Imports System.Data.SqlClient
Imports System.IO
Imports Bunifu.Framework.UI
Public Class Almacen
    Dim SQLConexion As New ConexionSQL()
    Dim conexion As SqlConnection
    Dim sesion As New Sesion()

    Dim _idalmacen As String
    Dim _idInventario As String


    Public Property Idalmacen As String
        Get
            Return _idalmacen
        End Get
        Set(value As String)
            _idalmacen = value
        End Set
    End Property

    Public Property IdInventario As String
        Get
            Return _idInventario
        End Get
        Set(value As String)
            _idInventario = value
        End Set
    End Property

    Public Sub Almacen_default(dropAlmacenes As BunifuDropdown)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()

        Dim cmd = New SqlCommand("select  a.Descripcion, IdAlmacenDefault from TbaAlmacenes a inner join TbaConfigVentas b on a.IdAlmacen = b.IdAlmacenDefault ", conexion)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            While (reader.Read())
                dropAlmacenes.AddItem(reader.GetValue(0))
                dropAlmacenes.selectedIndex = 0
                Idalmacen = reader.GetValue(1)
            End While
        End Using

    End Sub


    Public Function ValidarArchivo(linea As String) As Boolean
        Dim countpipe As Integer = 0
        For Each item As String In linea.ToCharArray()
            If item = "|" Then
                countpipe += 1
            End If
        Next

        If countpipe = 2 Then
            Return True
        Else
            Return False
        End If


        Return True
    End Function

    Public Sub Load_File(fileDialog As FileDialog, ByRef GridConteo As BunifuCustomDataGrid)
        Dim allText As String = ""
        Dim path As String = ""

        fileDialog.Filter = "Text files (*.txt)|*.txt"
        If fileDialog.ShowDialog() = DialogResult.OK Then

            IdInventario = GuardarInventarioFisico() 'GuardarInventarioFisico

            path = fileDialog.FileName

            Dim readerFile As New StreamReader(path)
            Dim lineaText As String = ""
            Dim arrayText As New ArrayList()
            Do
                lineaText = readerFile.ReadLine()
                If Not lineaText Is Nothing Then
                    If lineaText <> "" Then
                        arrayText.Add(lineaText)
                    End If

                End If
            Loop Until lineaText Is Nothing
            readerFile.Close()

            Dim index As Integer = 0
            For Each item As String In arrayText
                Dim campo As String = item.Replace("\r", "")
                If ValidarArchivo(campo) Then
                    Dim linea() As String = campo.Split("|")
                    GridConteo.Rows.Add(linea)
                    GuardarInventarioFisicoDetallado(linea) 'GuardarInventarioFisicoDetalle
                    index += 1
                End If
            Next




        End If

    End Sub

    Public Function GetIdproducto(codigo As String)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()
        Dim cmd = New SqlCommand("select Idproducto from TbaCodigos where Codigo = @Codigo", conexion)
        cmd.Parameters.AddWithValue("@Codigo", codigo)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read Then
                Return reader.GetValue(0)
            Else
                Return ""
            End If
        End Using
    End Function

    Public Function GetCosto(idproducto As String)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()
        Dim cmd = New SqlCommand("select Costo from TbaCostos where IdProducto = @IdProducto", conexion)
        cmd.Parameters.AddWithValue("@IdProducto", idproducto)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                Return reader.GetValue(0)
            Else
                Return ""
            End If
        End Using
    End Function
    Public Function GuardarInventarioFisico() As String
        conexion = SQLConexion.OpenConexion()
        conexion.Open()

        Dim cmd = New SqlCommand("INSERT INTO TbaInventarioFisico (Fecha,Hora,IdAlmacen, IdUsuario) VALUES (GETDATE(), CONVERT(varchar,GETDATE(),8)," + Idalmacen + "," + Utility.IdUsuario + ")" +
            "SELECT CAST(SCOPE_IDENTITY() AS INT)", conexion)

        Using reader As SqlDataReader = cmd.ExecuteReader()
            If (reader.Read()) Then
                Return reader.GetValue(0)
            Else
                Return ""
            End If
        End Using
    End Function

    Public Sub GuardarInventarioFisicoDetallado(producto As String())
        conexion = SQLConexion.OpenConexion()
        conexion.Open()

        Dim idproducto As String = GetIdproducto(producto(0))
        Dim costo As String = GetCosto(idproducto)

        If idproducto IsNot Nothing And costo IsNot Nothing Then
            Dim cmd = New SqlCommand("INSERT INTO TbaInventarioFisicoDetalle (IdInventario, Codigo,IdProducto, Conteo, Costo)" +
                                    "values (@IdInventario, @Codigo, @IdProducto, @Conteo, @Costo)", conexion)
            cmd.Parameters.AddWithValue("@IdInventario", IdInventario)
            cmd.Parameters.AddWithValue("@Codigo", producto(0))
            cmd.Parameters.AddWithValue("@IdProducto", idproducto)
            cmd.Parameters.AddWithValue("@Conteo", producto(2))
            cmd.Parameters.AddWithValue("@Costo", costo)
            cmd.ExecuteNonQuery()
        End If

    End Sub

    Public Sub UpdateInventarioFisico()
        conexion = SQLConexion.OpenConexion()
        conexion.Open()
        Dim cmd = New SqlCommand("update TbaInventarioFisico SET Estado = 'Emitido' where IdInventario  = @IdInventario", conexion)
        cmd.Parameters.AddWithValue("@IdInventario", IdInventario)
        cmd.ExecuteNonQuery()


    End Sub
End Class
