Imports System.Data.SqlClient
Imports System.IO
Imports Bunifu.Framework.UI
Public Class Almacen
    Dim SQLConexion As New ConexionSQL()
    Dim conexion As New SqlConnection
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
                'dropAlmacenes.selectedIndex = 0
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



    Public Function AddProducto(codigo As String)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()
        Dim cmd = New SqlCommand("select a.Descripcion  from TbaProducto a inner join TbaCodigos b on a.IdProducto = b.IdProducto" +
                                    " where b.Codigo = @Codigo", conexion)
        cmd.Parameters.AddWithValue("@Codigo", codigo)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read Then
                Return reader.GetValue(0)
            Else
                Return String.Empty
            End If
        End Using
    End Function

    Public Sub Load_File(fileDialog As FileDialog, ByRef GridConteo As BunifuCustomDataGrid)
        Dim allText As String = ""
        Dim path As String = ""

        fileDialog.Filter = "Text files (*.txt)|*.txt"
        If fileDialog.ShowDialog() = DialogResult.OK Then



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

        Dim cmd = New SqlCommand("INSERT INTO TbaInventarioFisico (Fecha,Hora,IdAlmacen, IdUsuario) VALUES (CONVERT(char(10), GetDate(),126), CONVERT(varchar,GETDATE(),8)," + Idalmacen + "," + Utility.IdUsuario + ")" +
            "SELECT CAST(SCOPE_IDENTITY() AS INT)", conexion)

        Using reader As SqlDataReader = cmd.ExecuteReader()
            If (reader.Read()) Then
                Return reader.GetValue(0)
            Else
                Return ""
            End If
        End Using
    End Function

    Public Sub GuardarInventarioFisicoDetallado(productos As DataGridView)

        IdInventario = GuardarInventarioFisico() 'GuardarInventarioFisico

        conexion = SQLConexion.OpenConexion()
        conexion.Open()
        Dim idproducto As String
        Dim costo As String
        If productos.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In productos.Rows
                If Not Fila Is Nothing Then
                    idproducto = GetIdproducto(Fila.Cells(0).Value)
                    costo = GetCosto(idproducto)

                    If idproducto IsNot Nothing And costo IsNot Nothing Then
                        Dim cmd = New SqlCommand("INSERT INTO TbaInventarioFisicoDetalle (IdInventario, Codigo,IdProducto, Conteo, Costo)" +
                                                "values (@IdInventario, @Codigo, @IdProducto, @Conteo, @Costo)", conexion)
                        cmd.Parameters.AddWithValue("@IdInventario", IdInventario)
                        cmd.Parameters.AddWithValue("@Codigo", Fila.Cells(0).Value)
                        cmd.Parameters.AddWithValue("@IdProducto", idproducto)
                        cmd.Parameters.AddWithValue("@Conteo", Fila.Cells(2).Value)
                        cmd.Parameters.AddWithValue("@Costo", costo)
                        cmd.ExecuteNonQuery()
                    End If
                End If
            Next

            UpdateInventarioFisico()
        End If



    End Sub

    Public Sub UpdateInventarioFisico()
        conexion = SQLConexion.OpenConexion()
        conexion.Open()
        Dim cmd = New SqlCommand("update TbaInventarioFisico SET Estado = 'Emitido' where IdInventario  = @IdInventario", conexion)
        cmd.Parameters.AddWithValue("@IdInventario", IdInventario)
        cmd.ExecuteNonQuery()


    End Sub

    Public Sub ConceptosEntradas(dropConceptos As BunifuDropdown)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()

        Dim cmd = New SqlCommand("SELECT Descripcion, IdConcepto FROM TbaConceptos WHERE (Tipo = 'E')", conexion)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            While (reader.Read())
                Dim almacen = reader.GetValue(0)
                If Not IsDBNull(almacen) Then
                    dropConceptos.AddItem(almacen)
                End If

            End While
        End Using

    End Sub
    Public Sub AlmacenesEntradas(dropAlmacenes As BunifuDropdown)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()

        Dim cmd = New SqlCommand("SELECT TbaAlmacenes.Descripcion FROM TbaAlmacenes " +
                                 " INNER JOIN TbaSucursales ON TbaAlmacenes.IdSucursal = TbaSucursales.IdSucursal INNER JOIN TbaParametros ON" +
                                 " TbaSucursales.IdSucursal = TbaParametros.IdSucursal WHERE (TbaAlmacenes.DesHabilitado = 0) And " +
                                 " (TbaAlmacenes.PermitirEnt = 1)", conexion)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            While (reader.Read())
                Dim almacen = reader.GetValue(0)
                If Not IsDBNull(almacen) Then
                    dropAlmacenes.AddItem(almacen)
                End If

            End While
        End Using

    End Sub

    Public Sub Almacenes(dropAlmacenes As BunifuDropdown)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()

        Dim cmd = New SqlCommand("SELECT Descripcion from TbaAlmacenes", conexion)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            While (reader.Read())
                Dim almacen = reader.GetValue(0)
                If Not IsDBNull(almacen) Then
                    dropAlmacenes.AddItem(almacen)
                End If

            End While
        End Using
    End Sub



    Public Sub CargaFamilias(dropFamilia As BunifuDropdown)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()

        Dim cmd = New SqlCommand("SELECT Familia from TbaFamilia", conexion)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            While (reader.Read())
                dropFamilia.AddItem(reader.GetValue(0))
            End While
        End Using
    End Sub
    Public Sub CargaProveedores(dropProveedor As BunifuDropdown)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()

        Dim cmd = New SqlCommand("SELECT Proveedor from Tbaproveedor", conexion)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            While (reader.Read())
                dropProveedor.AddItem(reader.GetValue(0))
            End While
        End Using
    End Sub
    Public Sub CargaUbicacion(dropUbicacion As BunifuDropdown)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()

        Dim cmd = New SqlCommand("SELECT Descripcion from TbaUbicacion", conexion)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            While (reader.Read())
                dropUbicacion.AddItem(reader.GetValue(0))
            End While
        End Using
    End Sub
    Public Function GetIdAlmacen(almacen As String)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()
        Dim cmd = New SqlCommand("select IdAlmacen from TbaAlmacenes where Descripcion = @Almacen", conexion)
        cmd.Parameters.AddWithValue("@Almacen", almacen)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read Then
                Return reader.GetValue(0)
            Else
                Return ""
            End If
        End Using
    End Function

    Public Function GetIdFamilia(familia As String)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()
        Dim cmd = New SqlCommand("select Idfamilia  from TbaFamilia where Familia = @Familia ", conexion)
        cmd.Parameters.AddWithValue("@Familia", familia)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read Then
                Return reader.GetValue(0)
            Else
                Return ""
            End If
        End Using
    End Function

    Public Sub InicializaInventario(tipoInventario As String, almacen As String, valor As String, fecha As Date)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()
        Select Case tipoInventario
            Case "General"
                Dim cmd = New SqlCommand("Update TbaExistencias set Inventario = 0 where IdAlmacen  = @Almacen ", conexion)
                cmd.Parameters.AddWithValue("@Almacen", GetIdAlmacen(almacen))
                cmd.ExecuteNonQuery()
            Case "Familia"
                Dim cmd = New SqlCommand("Update TbaExistencias SET Inventario =0 from TbaExistencias E" +
                                         " inner join TbaProducto P on E.IdProducto  = E.IdProducto" +
                                         " where E.IdAlmacen = @IdAlmacen And P.IdFamilia  = @IdFamilia", conexion)
                cmd.Parameters.AddWithValue("@IdFamilia", GetIdFamilia(valor))
                cmd.Parameters.AddWithValue("@IdAlmacen", GetIdAlmacen(almacen))
                cmd.ExecuteNonQuery()
            Case "Seleccion de productos"
                Dim cmd = New SqlCommand("Update TbaExistencias SET Inventario = 0 From TbaExistencias E inner join " +
                                         " TbaInventarioSelectivoDetalle ID on e.IdProducto  = ID.IdProducto" +
                                         " inner join TbaInventarioSelectivo ISe on ISe.IdInventarioSelectivo  = id.IdInventarioSelectivo" +
                                         " where E.IdAlmacen = @IdAlmacen And ISE.IdAlmacen  = @IdAlmacen And ISE.Fecha = @Fecha", conexion)
                cmd.Parameters.AddWithValue("@IdAlmacen", GetIdAlmacen(almacen))
                cmd.Parameters.AddWithValue("@Fecha", fecha)
                cmd.ExecuteNonQuery()
            Case "Ubicacion"
                Dim cmd = New SqlCommand("Update TbaExistencias SET Inventario = 0 From TbaExistencias E inner join " +
                                         " TbaProducto P on e.IdProducto  = p.IdProducto where e.IdAlmacen = @IdAlmacen" +
                                         " And P.Ubicacion  = @Ubicacion", conexion)
                cmd.Parameters.AddWithValue("@IdAlmacen", GetIdAlmacen(almacen))
                cmd.Parameters.AddWithValue("@Ubicacion", valor)
                cmd.ExecuteNonQuery()
        End Select
    End Sub

    Public Sub InicializaDiferencias(tipoInventario As String, fecha As Date, familia As String)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()
        Select Case tipoInventario
            Case "General", "Ubicacion"
                Dim cmd = New SqlCommand("Delete TbaInventario where Fecha = @Fecha", conexion)
                cmd.Parameters.AddWithValue("@Fecha", fecha)
                cmd.ExecuteNonQuery()
            Case "Familia"
                Dim cmd = New SqlCommand("Delete TbaInventario where Fecha = @Fecha And Idfamilia  = @IdFamilia", conexion)
                cmd.Parameters.AddWithValue("@Fecha", fecha)
                cmd.Parameters.AddWithValue("@IdFamilia", GetIdFamilia(familia))
                cmd.ExecuteNonQuery()

        End Select
    End Sub

    Public Sub GenerarDiferencias(tipoInventario As String, almacen As String, fecha As Date, valor As String)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()
        Select Case tipoInventario
            Case "General" '____________________________________________________________________________________________________________________________'
                Dim cmdsobrante = New SqlCommand("INSERT TbaInventario (IdAlmacen, IdProducto, Costo, Conteo, Fecha, Existencia, Faltante, Excedente)" +
                                         " SELECT e.IdAlmacen, p.IdProducto, (select top 1 costo from TbaCostos where IdProducto  = p.IdProducto)," +
                                         " e.Inventario, @Fecha , e.Existencia, e.Existencia-e.Inventario, 0 FROM TbaProducto p INNER JOIN" +
                                         " TbaExistencias E ON P.IdProducto  =  e.IdProducto where e.Existencia > e.Inventario And e.IdAlmacen = @IdAlmacen", conexion)
                cmdsobrante.Parameters.AddWithValue("@Fecha", fecha)
                cmdsobrante.Parameters.AddWithValue("@IdAlmacen", GetIdAlmacen(almacen))
                cmdsobrante.ExecuteNonQuery()
                Dim cmdfaltante = New SqlCommand("INSERT TbaInventario (IdAlmacen, IdProducto, Costo, Conteo, Fecha, Existencia, Faltante, Excedente)" +
                                      " SELECT e.IdAlmacen, p.IdProducto, (select top 1 costo from TbaCostos where IdProducto  = p.IdProducto)," +
                                      " e.Inventario, @Fecha , e.Existencia,0, E.Inventario-E.Existencia FROM TbaProducto p INNER JOIN" +
                                      " TbaExistencias E ON P.IdProducto  =  e.IdProducto where e.Existencia < e.Inventario And e.IdAlmacen = @IdAlmacen", conexion)
                cmdfaltante.Parameters.AddWithValue("@Fecha", fecha)
                cmdfaltante.Parameters.AddWithValue("IdAlmacen", GetIdAlmacen(almacen))
                cmdfaltante.ExecuteNonQuery()

            Case "Familia" '____________________________________________________________________________________________________________________________'
                Dim cmd As New SqlCommand()
                cmd = New SqlCommand("Insert TbaInventario (IdAlmacen, IdProducto, Costo, Conteo, Fecha, Existencia, Faltante, Excedente, Idfamilia)" +
                                     " select e.IdAlmacen, p.IdProducto, isnull((select costo from TbaCostos where IdProducto  = P.IdProducto),0)," +
                                     " e.Inventario, @Fecha,e.Existencia, E.Existencia -E.Inventario, 0, P.IdFamilia from TbaProducto P inner join " +
                                     " TbaExistencias E on P.IdProducto = e.IdProducto  where e.Existencia >e.Inventario And e.IdAlmacen = @IdAlmacen " +
                                     " And p.IdFamilia  = @IdFamilia", conexion)
                cmd.Parameters.AddWithValue("@Fecha", fecha)
                cmd.Parameters.AddWithValue("@IdAlmacen", GetIdAlmacen(almacen))
                cmd.Parameters.AddWithValue("@IdFamilia", GetIdFamilia(valor))
                cmd.ExecuteNonQuery()


                cmd = New SqlCommand("Insert TbaInventario (IdAlmacen, IdProducto, Costo, Conteo, Fecha, Existencia, Faltante, Excedente, Idfamilia)" +
                                     " select e.IdAlmacen, p.IdProducto, isnull((select costo from TbaCostos where IdProducto  = P.IdProducto),0)," +
                                     " e.Inventario, @Fecha,e.Existencia, 0,E.Inventario-E.Existencia, P.IdFamilia from TbaProducto P inner join " +
                                     " TbaExistencias E on P.IdProducto = e.IdProducto where e.Existencia < e.Inventario And e.IdAlmacen = @IdAlmacen " +
                                     " And p.IdFamilia  = @IdFamilia", conexion)
                cmd.Parameters.AddWithValue("@Fecha", fecha)
                cmd.Parameters.AddWithValue("@IdAlmacen", GetIdAlmacen(almacen))
                cmd.Parameters.AddWithValue("@IdFamilia", GetIdFamilia(valor))
                cmd.ExecuteNonQuery()


                cmd = New SqlCommand("Update TbaInventario Set Idfamilia  = P.IdFamilia from TbaInventario I inner join TbaProducto P" +
                                     " on I.IdProducto = P.IdProducto  where estado Is null And Fecha = GETDATE()", conexion)
                cmd.Parameters.AddWithValue("@Fecha", fecha)
                cmd.ExecuteNonQuery()



            Case "Seleccion de productos" '____________________________________________________________________________________________________________________'
                Dim cmd = New SqlCommand()
                cmd = New SqlCommand("Insert TbaInventario (IdAlmacen, IdProducto, Costo, Conteo, Fecha, Existencia, Faltante, Excedente)" +
                                     " SELECT E.IdAlmacen, Id.IdProducto, (SELECT Costo From TbaCostos where IdProducto = id.IdProducto), e.Inventario," +
                                     " @Fecha, e.Existencia, e.Existencia -e.Inventario, 0 From TbaInventarioSelectivo ISe inner join " +
                                     " TbaInventarioSelectivoDetalle ID on ISe.IdInventarioSelectivo = iD.IdInventarioSelectivo INNER JOIN " +
                                     " TbaExistencias E on Id.IdProducto = e.IdProducto where e.Existencia > e.Inventario  And e.IdAlmacen  = " +
                                     " @IdAlmacen And ISe.IdAlmacen = @IdAlmacen And Ise.Fecha  = @Fecha", conexion)
                cmd.Parameters.AddWithValue("@IdAlmacen", GetIdAlmacen(almacen))
                cmd.Parameters.AddWithValue("@Fecha", fecha)
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand("Insert TbaInventario (IdAlmacen, IdProducto, Costo, Conteo, Fecha, Existencia, Faltante, Excedente)" +
                                     " SELECT E.IdAlmacen, Id.IdProducto, (SELECT Costo From TbaCostos where IdProducto = id.IdProducto), e.Inventario, " +
                                     " @Fecha, e.Existencia, 0,e.Inventario -e.Existencia FROM TbaInventarioSelectivo ISe inner join" +
                                     " TbaInventarioSelectivoDetalle ID on ISe.IdInventarioSelectivo = iD.IdInventarioSelectivo INNER JOIN TbaExistencias" +
                                     " E on Id.IdProducto = e.IdProducto where e.Existencia < e.Inventario  And e.IdAlmacen  = @IdAlmacen And ISe.IdAlmacen= @IdAlmacen " +
                                     " And Ise.Fecha  = @Fecha", conexion)
                cmd.Parameters.AddWithValue("@IdAlmacen", GetIdAlmacen(almacen))
                cmd.Parameters.AddWithValue("@Fecha", fecha)
                cmd.ExecuteNonQuery()

            Case "Ubicacion" '____________________________________________________________________________________________________________________________'
                Dim cmd = New SqlCommand()
                cmd = New SqlCommand("Insert TbaInventario(IdAlmacen, IdProducto, Costo, Conteo, Fecha, Existencia, Faltante, Excedente)" +
                                         " select e.IdAlmacen, p.IdProducto, (select costo from TbaCostos where IdProducto = p.IdProducto), e.Inventario, " +
                                         " @Fecha, E.Existencia, e.Existencia-e.Inventario, 0 from TbaProducto P inner join TbaExistencias E on P.IdProducto" +
                                         " = e.IdProducto where E.Existencia > E.Inventario  And e.IdAlmacen = @IdAlmacen And P.Ubicacion = @Ubicacion", conexion)
                cmd.Parameters.AddWithValue("@IdAlmacen", GetIdAlmacen(almacen))
                cmd.Parameters.AddWithValue("@Fecha", fecha)
                cmd.Parameters.AddWithValue("@Ubicacion", valor)
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand("Insert TbaInventario(IdAlmacen, IdProducto, Costo, Conteo, Fecha, Existencia, Faltante, Excedente)" +
                                     " select e.IdAlmacen, p.IdProducto, (select costo from TbaCostos where IdProducto = p.IdProducto), e.Inventario, " +
                                     " @Fecha, E.Existencia, 0, E.Inventario-E.Existencia from TbaProducto P inner join TbaExistencias E on " +
                                     " P.IdProducto = e.IdProducto where E.Existencia < E.Inventario  And e.IdAlmacen = @IdAlmacen And P.Ubicacion =" +
                                     " @Ubicacion", conexion)
                cmd.Parameters.AddWithValue("@IdAlmacen", GetIdAlmacen(almacen))
                cmd.Parameters.AddWithValue("@Fecha", fecha)
                cmd.Parameters.AddWithValue("@Ubicacion", valor)
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand("Update TbaInventario set Ubicacion = P.Ubicacion From TbaInventario I inner join TbaProducto P" +
                                     " on I.IdProducto = p.IdProducto  where estado Is null And Fecha = @Fecha", conexion)
                cmd.Parameters.AddWithValue("@Fecha", fecha)
                cmd.ExecuteNonQuery()
        End Select


    End Sub

    Public Sub AjustarInventario(tipoInventario As String, almacen As String, fecha As Date, valor As String)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()

        Select Case tipoInventario
            Case "General"
                Dim cmd = New SqlCommand("Update TbaInventario SET Estado = 'Emitida' from TbaInventario I " +
                                         " Where I.IdAlmacen = @IdAlmacen and I.Fecha =  @Fecha", conexion)
                cmd.Parameters.AddWithValue("@Fecha", fecha)
                cmd.Parameters.AddWithValue("@IdAlmacen", GetIdAlmacen(almacen))
                cmd.ExecuteNonQuery()
            Case "Familia"
                Dim cmd = New SqlCommand("Update TbaInventario SET Estado = 'Emitida' From TbaInventario I" +
                                         " WHERE I.IdAlmacen = @IdAlmacen And I.Fecha =@Fecha And I.Idfamilia = @IdFamilia", conexion)
                cmd.Parameters.AddWithValue("@IdAlmacen", GetIdAlmacen(almacen))
                cmd.Parameters.AddWithValue("@Fecha", fecha)
                cmd.Parameters.AddWithValue("@IdFamilia", GetIdFamilia(valor))
                cmd.ExecuteNonQuery()
            Case "Ubicacion"
                Dim cmd = New SqlCommand("Update TbaInventario SET Estado = 'Emitida' From TbaInventario I" +
                                       " WHERE I.IdAlmacen = @IdAlmacen And I.Fecha =@Fecha And I.Ubicacion = @Ubicacion", conexion)
                cmd.Parameters.AddWithValue("@IdAlmacen", GetIdAlmacen(almacen))
                cmd.Parameters.AddWithValue("@Fecha", fecha)
                cmd.Parameters.AddWithValue("@Ubicacion", valor)
                cmd.ExecuteNonQuery()
        End Select
    End Sub



    '______________________________ENTRADAS ___________________________'

    Public Function AutorizaEntrada(clave As String)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()

        Dim cmd = New SqlCommand("select Clave, Autorizacion from TbaClavesAut where Descripcion  = 'Clave2'", conexion)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                If reader.GetValue(0) = clave Or reader.GetValue(1) = 1 Then
                    Return True
                Else
                    Return False
                End If
            End If
        End Using

        Return False

    End Function

    Public Sub ListaProductos(lista As DataGridView)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()
        Dim cmd = New SqlCommand("SELECT TbaProducto.IdProducto, TbaProducto.Descripcion, ROUND(TbaPrecios.Precio, 2) AS Precio," +
                                 " TbaProducto.IvaVenta, vwCodigos.Codigo AS Codigo FROM TbaProducto INNER JOIN TbaPrecios ON " +
                                 " TbaProducto.IdProducto = TbaPrecios.IdProducto INNER JOIN TbaConfigVentas ON TbaPrecios.IdEscala = " +
                                 " TbaConfigVentas.IdEscalaDefault INNER JOIN TbaServicioProducto ON TbaProducto.IdProducto = " +
                                 " TbaServicioProducto.IdProducto INNER JOIN vwCodigos ON TbaProducto.IdProducto = vwCodigos.IdProducto " +
                                 " INNER JOIN TbaTipoServicio ON TbaServicioProducto.IdTipoServicio = TbaTipoServicio.IdTipoServicio INNER JOIN " +
                                 " TbaParametros ON TbaTipoServicio.IdTipoServicio = TbaParametros.TipoServicio WHERE (TbaPrecios.IdEscala = " +
                                 " (SELECT IdEscalaDefault FROM TbaConfigVentas)) ORDER BY TbaProducto.Descripcion", conexion)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            While (reader.Read())
                lista.Rows.Add(reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4))
            End While
        End Using
    End Sub

    Public Sub BuscarProductos(descripcion As String, lista As DataGridView)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()
        lista.Rows.Clear()
        Dim cmd = New SqlCommand("SELECT TbaProducto.IdProducto, TbaProducto.Descripcion, ROUND(TbaPrecios.Precio, 2) AS Precio," +
                                 " TbaProducto.IvaVenta, vwCodigos.Codigo AS Codigo FROM TbaProducto INNER JOIN TbaPrecios ON " +
                                 " TbaProducto.IdProducto = TbaPrecios.IdProducto INNER JOIN TbaConfigVentas ON TbaPrecios.IdEscala = " +
                                 " TbaConfigVentas.IdEscalaDefault INNER JOIN TbaServicioProducto ON TbaProducto.IdProducto = " +
                                 " TbaServicioProducto.IdProducto INNER JOIN vwCodigos ON TbaProducto.IdProducto = vwCodigos.IdProducto " +
                                 " INNER JOIN TbaTipoServicio ON TbaServicioProducto.IdTipoServicio = TbaTipoServicio.IdTipoServicio INNER JOIN " +
                                 " TbaParametros ON TbaTipoServicio.IdTipoServicio = TbaParametros.TipoServicio WHERE (TbaPrecios.IdEscala = " +
                                 " (SELECT IdEscalaDefault FROM TbaConfigVentas)) and TbaProducto.Descripcion like '%" + descripcion + "%' ORDER BY TbaProducto.Descripcion", conexion)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            While (reader.Read())
                lista.Rows.Add(reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4))
            End While
        End Using

    End Sub

    Public Function ReferenciaExiste(referencia As String)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()
        Dim cmd = New SqlCommand("Select * From TbaEntrada where Estado = 'Emitida' and not Folio is Null and Referencia = @Referencia", conexion)
        cmd.Parameters.AddWithValue("@Referencia", referencia)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows() Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function

    Public Sub GetEntradaByReferencia(referencia As String, gridEntrada As DataGridView)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()
        Dim destino As String = String.Empty
        Dim cmd As SqlCommand
        gridEntrada.Rows.Clear()
        cmd = New SqlCommand("select  cast(codigo as int)  from tbaparametros inner join tbasucursales " +
                                 " on (tbaparametros.IdSucursal = tbasucursales.IdSucursal)", conexion)
        destino = cmd.ExecuteScalar()

        cmd = New SqlCommand("Select  Codigo,Cantidad,  b.Descripcion from TbaTraspasoDetalleTemp_03 a inner join TbaProducto b" +
                             " on a.IdProducto = b.IdProducto  where a.Folio = @Folio and Destino = @Destino", conexion)
        cmd.Parameters.AddWithValue("@Folio", referencia)
        cmd.Parameters.AddWithValue("@Destino", destino)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            While (reader.Read())
                gridEntrada.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2))
            End While
        End Using


    End Sub


    Public Function ProductoDisponible(codigo As String)
        conexion = SQLConexion.OpenConexion()
        conexion.Open()
        Dim idproducto As String = GetIdproducto(codigo)

        Dim cmd = New SqlCommand("Select * From TbaServicioProducto SP Inner join TbaParametros P on SP.IdTipoServicio=P.TipoServicio" +
        " Where SP.IdProducto= @IdProducto", conexion)
        cmd.Parameters.AddWithValue("@IdProducto", idproducto)
        Using reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows() Then
                Return True
            Else
                Return False
            End If
        End Using

    End Function

    Public Sub AgregaEntrada(entrada As Entradas, gridEntrada As DataGridView)
        Dim conexion As New SqlConnection
        Dim Transaccion As SqlTransaction = Nothing
        Try
            conexion = SQLConexion.OpenConexion()
            conexion.Open()

            Transaccion = conexion.BeginTransaction()


            '_____Folio_____
            Dim cmdFolio = New SqlCommand("Select Codigo + '_' + cast(FolioEntrada as Varchar(10)) FROM TbaParametros P INNER JOIN" +
                        " TbaSucursales S ON P.IdSucursal = S.IdSucursal, TbaFolios", conexion)
            cmdFolio.Transaction = Transaccion
            entrada.folio = cmdFolio.ExecuteScalar()

            '_____Usuario_____'
            entrada.idusuario = Utility.IdUsuario

            '_____Idconcepto_____'
            Dim cmdConcepto = New SqlCommand("select IdConcepto  from TbaConceptos where Descripcion = @Concepto", conexion)
            cmdConcepto.Transaction = Transaccion
            cmdConcepto.Parameters.AddWithValue("@Concepto", entrada.concepto)
            entrada.idconcepto = cmdConcepto.ExecuteScalar()

            '_____'IdAlmacen_____'
            Dim cmdAlmacen = New SqlCommand("select IdAlmacen  from TbaAlmacenes where Descripcion = @Almacen", conexion)
            cmdAlmacen.Transaction = Transaccion
            cmdAlmacen.Parameters.AddWithValue("@Almacen", entrada.almacen)
            entrada.idalmacen = cmdAlmacen.ExecuteScalar()




            Dim cmdEntrada = New SqlCommand("INSERT INTO TbaEntrada(Fecha, Hora, IdAlmacen, IdConcepto, IdUsuario, Referencia, Observacion)" +
                                            "values ( Cast(GetDate() as varchar(12)) , CONVERT(varchar,GETDATE(),8), @IdAlmacen, @IdConcepto, @IdUsuario, @Referencia, @Observacion)" +
                                            "SELECT CAST(SCOPE_IDENTITY() AS INT)", conexion)
            With cmdEntrada
                .Transaction = Transaccion
                .Parameters.AddWithValue("@IdAlmacen", entrada.idalmacen)
                .Parameters.AddWithValue("@IdConcepto", entrada.idconcepto)
                .Parameters.AddWithValue("@IdUsuario", entrada.idusuario)
                .Parameters.AddWithValue("Referencia", entrada.referencia)
                .Parameters.AddWithValue("@Observacion", entrada.observacion)
                Using reader As SqlDataReader = cmdEntrada.ExecuteReader()
                    If reader.Read() Then
                        entrada.identrada = reader.GetValue(0)
                    End If
                End Using
            End With








            For Each Fila As DataGridViewRow In gridEntrada.Rows
                If Not Fila Is Nothing Then



                    Dim cmdDetalles = New SqlCommand("SELECT P.Costo, P.IdProducto, P.IdMoneda, (Select Costo From TbaCostos C Where IdProducto = P.IdProducto)" +
                                             "As UltCosto From TbaProducto P Where P.DesHabilitadoVenta = 0 And P.IdProducto = @IdProducto", conexion)
                    cmdDetalles.Parameters.AddWithValue("@IdProducto", GetIdproducto(Fila.Cells("ClCodigo").Value))
                    cmdDetalles.Transaction = Transaccion
                    Using reader As SqlDataReader = cmdDetalles.ExecuteReader()
                        If reader.Read() Then
                            entrada.costo = reader.GetValue(0)
                            entrada.idproducto = reader.GetValue(1)
                            entrada.idmoneda = reader.GetValue(2)
                            entrada.ultcosto = reader.GetValue(3)
                        End If
                    End Using


                    Dim cmdTC = New SqlCommand("SELECT Importe FROM TbaMoneda WHERE IdMoneda = @IdMoneda", conexion)
                    cmdTC.Parameters.AddWithValue("@IdMoneda", entrada.idmoneda)
                    cmdTC.Transaction = Transaccion
                    Using reader As SqlDataReader = cmdTC.ExecuteReader()
                        If reader.Read() Then
                            entrada.tc = reader.GetValue(0)
                        End If
                    End Using


                    Dim cmdEntradaDetalle = New SqlCommand("INSERT INTO TbaEntradaDetalle (IdEntrada, Codigo, Cantidad, IdProducto, Costo, Total, TC, UltCosto) " +
                                                           "VALUES (@Identrada, @Codigo, @Cantidad, @IdProducto, @Costo, (@Costo*@Cantidad), @TC, @UltCosto)", conexion)
                    With cmdEntradaDetalle
                        .Transaction = Transaccion
                        .Parameters.AddWithValue("@IdEntrada", entrada.identrada)
                        .Parameters.AddWithValue("@Codigo", Fila.Cells("ClCodigo").Value)
                        .Parameters.AddWithValue("@Cantidad", Fila.Cells("ClCantidad").Value)
                        .Parameters.AddWithValue("@IdProducto", GetIdproducto(Fila.Cells("ClCodigo").Value))
                        .Parameters.AddWithValue("@Costo", entrada.costo)
                        .Parameters.AddWithValue("@TC", entrada.tc)
                        .Parameters.AddWithValue("@UltCosto", CDbl(entrada.ultcosto))
                        .ExecuteNonQuery()
                    End With

                End If
            Next

            Dim cmdUpdateEstado = New SqlCommand("Update TbaEntrada SET Estado =  'Emitida', Folio = @Folio Where IdEntrada = @IdEntrada", conexion)
            With cmdUpdateEstado
                .Transaction = Transaccion
                .Parameters.AddWithValue("@IdEntrada", entrada.identrada)
                .Parameters.AddWithValue("@Folio", entrada.folio)
                .ExecuteNonQuery()
            End With



            Transaccion.Commit()
        Catch ex As Exception
            Transaccion.Rollback()

        End Try
    End Sub



End Class
