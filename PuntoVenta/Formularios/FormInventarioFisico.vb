Imports System.IO
Public Class FormInventarioFisico
    Dim almacen As New Almacen
    Private Sub FormInventarioFisico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        almacen.Almacen_default(DropSucursal)
    End Sub

    Private Sub BtnLoadFile_Click_1(sender As Object, e As EventArgs) Handles BtnLoadFile.Click
        almacen.Load_File(fileDialog, GridDetalles)
    End Sub

    Private Sub BtnGuardarInventario_Click(sender As Object, e As EventArgs) Handles BtnGuardarInventario.Click

        Try
            almacen.UpdateInventarioFisico()
            Using mensaje As New FormMsgBox()
                mensaje.mensaje = "Inventario guardado con exito"
                mensaje.titulo = "Mensaje"
                mensaje.solicitud = False
                mensaje.ShowDialog()
                GridDetalles.Rows.Clear()
            End Using
        Catch ex As Exception
            Using mensaje As New FormMsgBox()
                mensaje.mensaje = ex.Message
                mensaje.titulo = "Advertencia"
                mensaje.solicitud = False
                mensaje.ShowDialog()
            End Using
        End Try

    End Sub
End Class

