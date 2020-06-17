Imports System.IO
Public Class FormInventarioFisico
    Dim almacen As New Almacen
    Private Sub FormInventarioFisico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '___CARGAR ALMACEN DEFAULT___
        almacen.Almacen_default(DropSucursal)
        For Each colum As DataGridViewColumn In GridDetalles.Columns
            colum.ReadOnly = True
        Next

        GridDetalles.Columns("ClConteo").ReadOnly = False
        'GridDetalles.Columns("ClCodigo").ReadOnly = False
    End Sub

    Private Sub BtnLoadFile_Click_1(sender As Object, e As EventArgs) Handles BtnLoadFile.Click
        '___CARGAR PISOLA___
        almacen.Load_File(fileDialog, GridDetalles)
    End Sub

    Private Sub BtnGuardarInventario_Click(sender As Object, e As EventArgs) Handles BtnGuardarInventario.Click
        '___GUARDAR INVENTARIO___
        Try
            If GridDetalles.Rows.Count > 0 Then

                If Not DropSucursal.selectedIndex = -1 Then
                    almacen.GuardarInventarioFisicoDetallado(GridDetalles)
                    Using mensaje As New FormMsgBox()
                        mensaje.mensaje = "Inventario guardado con exito"
                        mensaje.titulo = "Mensaje"
                        mensaje.solicitud = False
                        mensaje.ShowDialog()
                        GridDetalles.Rows.Clear()
                    End Using
                Else
                    Using mensaje As New FormMsgBox()
                        mensaje.mensaje = "Seleccione un almacen de la lista"
                        mensaje.titulo = "Mensaje"
                        mensaje.solicitud = False
                        mensaje.ShowDialog()
                    End Using
                End If

            Else
                Using mensaje As New FormMsgBox()
                    mensaje.mensaje = "Ingrese o cargue los productos a guardar"
                    mensaje.titulo = "Mensaje"
                    mensaje.solicitud = False
                    mensaje.ShowDialog()
                End Using
            End If

        Catch ex As Exception
            Using mensaje As New FormMsgBox()
                mensaje.mensaje = ex.Message
                mensaje.titulo = "Advertencia"
                mensaje.solicitud = False
                mensaje.ShowDialog()
            End Using
        End Try

    End Sub





    Private Sub DropSucursal_onItemSelected(sender As Object, e As EventArgs) Handles DropSucursal.onItemSelected
        TxtCodigo.Enabled = True
        TxtProducto.Enabled = False
        TxtConteo.Enabled = True
    End Sub



    Private Sub TxtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCodigo.KeyDown
        '___BUSCAR PRODUCTO EN BD___
        If e.KeyCode = Keys.Enter Then

            Dim producto = almacen.AddProducto(TxtCodigo.Text)
            If producto IsNot String.Empty Then
                Me.BringToFront()
                Me.TxtConteo.Select()
                Me.Select()
                TxtProducto.Text = producto

            Else
                Me.BringToFront()
                Me.TxtCodigo.Select()
                TxtCodigo.Text = ""
                Using mensaje As New FormMsgBox()
                    mensaje.mensaje = "Producto no encontrado"
                    mensaje.titulo = "Advertencia"
                    mensaje.solicitud = False
                    mensaje.ShowDialog()
                End Using

            End If
        End If
    End Sub

    Private Sub TxtConteo2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtConteo.KeyPress
        '____VALIDA NUMEROS DECIMALES___

        If e.KeyChar = "." Then

            If Len(TxtConteo.Text) = 0 Then
                e.Handled = True
            ElseIf InStr(TxtConteo.Text, ".") <= 1 Then
                e.Handled = False
            Else
                e.Handled = True
            End If


        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtConteo2_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtConteo.KeyDown
        '___AGREGAR PRODUCTO AL GRID___'
        If e.KeyCode = Keys.Enter Then
            If TxtCodigo.Text IsNot String.Empty And TxtProducto IsNot String.Empty And TxtConteo IsNot String.Empty Then

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
                    GridDetalles.Rows.Add(TxtCodigo.Text, TxtProducto.Text, TxtConteo.Text)
                    Me.GridDetalles.CurrentCell = Me.GridDetalles.Rows(Me.GridDetalles.RowCount - 1).Cells(0)
                Else
                    Using mensaje As New FormMsgBox
                        mensaje.mensaje = "Codigo ya ingresado"
                        mensaje.titulo = "Mensaje"
                        mensaje.solicitud = True
                        mensaje.ShowDialog()
                    End Using
                End If
                TxtCodigo.Text = ""
                TxtProducto.Text = ""
                TxtConteo.Text = ""
                Me.BringToFront()
                Me.TxtCodigo.Select()
                Me.Select()
            End If

        End If
    End Sub

    Private Sub GridDetalles_KeyDown(sender As Object, e As KeyEventArgs) Handles GridDetalles.KeyDown
        '___LIMPIAR GRID CON F5___
        If e.KeyCode = Keys.F5 Then
            GridDetalles.Rows.Clear()
        End If
        If e.KeyCode = Keys.Delete Then
            If GridDetalles.Rows.Count > 0 Then
                GridDetalles.Rows.Remove(GridDetalles.Rows(GridDetalles.Rows.Count - 1))
            End If

        End If

    End Sub

    Private Sub GridDetalles_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles GridDetalles.EditingControlShowing
    End Sub

    Private Sub BtnTerminarCaptura_Click(sender As Object, e As EventArgs) Handles BtnTerminarCaptura.Click
        Utility.TerminarInventario = True
    End Sub
End Class

