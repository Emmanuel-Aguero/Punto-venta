Public Class FormEntradas

    Dim almacen As New Almacen
    Private Sub TxtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCodigo.KeyDown
        '___BUSCAR PRODUCTO EN BD___
        If e.KeyCode = Keys.Enter Then

            Dim producto = almacen.AddProducto(TxtCodigo.Text)
            If producto IsNot String.Empty Then
                If almacen.ProductoDisponible(TxtCodigo.Text) Then
                    Me.BringToFront()
                    Me.TxtCantidad.Select()
                    Me.Select()
                    TxtProducto.Text = producto
                Else
                    Using mensaje As New FormMsgBox
                        mensaje.mensaje = "Articulo no Disponible Para Tienda"
                        mensaje.titulo = "Mensaje"
                        mensaje.solicitud = False
                        mensaje.ShowDialog()
                    End Using
                End If


            Else
                Me.BringToFront()
                Me.TxtCodigo.Select()
                TxtCodigo.Text = ""
                Using mensaje As New FormMsgBox()
                    mensaje.mensaje = "Articulo no valido"
                    mensaje.titulo = "Advertencia"
                    mensaje.solicitud = False
                    mensaje.ShowDialog()
                End Using

            End If
        Else
            If e.KeyCode = Keys.Insert Then
                Using buscador As New FormBuscadorProductos()
                    Dim dialog As DialogResult = buscador.ShowDialog()
                    If dialog = DialogResult.OK Then
                        TxtCodigo.Text = buscador.codigo
                        TxtProducto.Text = buscador.producto
                        Me.BringToFront()
                        Me.TxtCantidad.Select()
                        Me.Select()
                    End If
                End Using
            End If
        End If
    End Sub

    Private Sub TxtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCantidad.KeyDown
        '___AGREGAR PRODUCTO AL GRID___'
        If e.KeyCode = Keys.Enter Then
            If TxtCodigo.Text IsNot String.Empty And TxtProducto.Text IsNot String.Empty And TxtCantidad.Text IsNot String.Empty Then

                Dim bandera_producto As Boolean = True
                If GridDetalles.Rows.Count > 0 Then
                    For Each Fila As DataGridViewRow In GridDetalles.Rows
                        If Not Fila Is Nothing Then
                            If Fila.Cells("ClCodigo").Value = TxtCodigo.Text Then
                                bandera_producto = False
                            End If
                        End If
                    Next
                End If
                If bandera_producto Then
                    GridDetalles.Rows.Add(TxtCodigo.Text, TxtCantidad.Text, TxtProducto.Text)
                    Me.GridDetalles.CurrentCell = Me.GridDetalles.Rows(Me.GridDetalles.RowCount - 1).Cells(0)

                Else
                    Using mensaje As New FormMsgBox
                        mensaje.mensaje = "Codigo ya ingresado"
                        mensaje.titulo = "Mensaje"
                        mensaje.solicitud = False
                        mensaje.ShowDialog()
                    End Using
                End If
                TxtCodigo.Text = ""
                TxtProducto.Text = ""
                TxtCantidad.Text = ""
                Me.BringToFront()
                Me.TxtCodigo.Select()
                Me.Select()
            Else
                Using mensaje As New FormMsgBox
                    mensaje.mensaje = "No se permiten campos vacios"
                    mensaje.titulo = "Advertencia"
                    mensaje.solicitud = False
                    mensaje.ShowDialog()
                End Using
            End If

        End If
    End Sub

    Private Sub FormEntradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        almacen.AlmacenesEntradas(DropAlmacen)
        almacen.ConceptosEntradas(DropConcepto)
        LabelFechaEntrada.Text = Format(Now, "Long Date")
    End Sub

    Private Sub BtnNuevaEntrada_Click(sender As Object, e As EventArgs) Handles BtnNuevaEntrada.Click
        TxtCodigo.Text = ""
        TxtCantidad.Text = ""
        TxtProducto.Text = ""
        GridDetalles.Rows.Clear()
        DropAlmacen.selectedIndex = -1
        DropConcepto.selectedIndex = -1
        TxtReferencia.Text = ""
        TxtObervaciones.Text = ""
        LabelIdEntrada.Text = "ID Entrada:"
    End Sub

    Private Sub TxtReferencia_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtReferencia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not TxtReferencia.Text = Nothing Then
                If almacen.ReferenciaExiste(TxtReferencia.Text) Then
                    Using mensaje As New FormMsgBox
                        mensaje.mensaje = "Referencia ya existente"
                        mensaje.titulo = "Aviso"
                        mensaje.solicitud = False
                        mensaje.ShowDialog()
                    End Using
                Else
                    almacen.GetEntradaByReferencia(TxtReferencia.Text, GridDetalles)
                End If
            End If
        End If
    End Sub

    Private Sub BtnGuardarEntrada_Click(sender As Object, e As EventArgs) Handles BtnGuardarEntrada.Click
        Dim usuario_autorizado As Boolean = False
        If DropAlmacen.selectedIndex <> -1 And DropConcepto.selectedIndex <> -1 Then
            If GridDetalles.Rows.Count > 0 Then
                If DropConcepto.selectedValue = "Entrada provisional" Then
                    Using autorizacion As New FormAutorizacion
                        Dim dialogResult As DialogResult = autorizacion.ShowDialog()
                        If dialogResult = DialogResult.OK Then
                            If almacen.AutorizaEntrada(autorizacion.clave_autorizacion) Then
                                usuario_autorizado = True
                            Else

                                usuario_autorizado = False
                                Using mensaje As New FormMsgBox
                                    mensaje.mensaje = "Clave invalida"
                                    mensaje.titulo = "Advertencia"
                                    mensaje.solicitud = False
                                    mensaje.ShowDialog()
                                End Using
                            End If
                        End If
                    End Using

                Else
                    usuario_autorizado = True
                End If

                If usuario_autorizado Then

                    If DropConcepto.selectedValue = "Entrada por traspaso" And TxtReferencia.Text <> Nothing Then
                        MsgBox("simon")
                    Else
                        Dim entrada As New Entradas
                        entrada.concepto = DropConcepto.selectedValue
                        entrada.almacen = DropAlmacen.selectedValue
                        entrada.observacion = TxtObervaciones.Text
                        entrada.referencia = TxtReferencia.Text
                        '___AGREGA ENTRADA___
                        almacen.AgregaEntrada(entrada, GridDetalles)
                    End If


                End If
            Else
                Using mensaje As New FormMsgBox
                    mensaje.mensaje = "No hay registros para realizar una entrada"
                    mensaje.titulo = "Mensaje"
                    mensaje.solicitud = False
                    mensaje.ShowDialog()
                End Using
            End If



        Else
            Using mensaje As New FormMsgBox
                mensaje.mensaje = "Campo Almacen Y/O Concepto Vacios"
                mensaje.titulo = "Advertencia"
                mensaje.solicitud = False
                mensaje.ShowDialog()
            End Using
        End If


    End Sub

    Private Sub DropConcepto_onItemSelected(sender As Object, e As EventArgs) Handles DropConcepto.onItemSelected
        If DropConcepto.selectedValue = "Entrada por traspaso" Then
            TxtReferencia.Enabled = True
        Else
            TxtReferencia.Enabled = False
        End If
    End Sub
End Class