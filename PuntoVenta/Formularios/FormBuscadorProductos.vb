Public Class FormBuscadorProductos
    Dim almacen As New Almacen()

    Public codigo As String
    Public producto As String
    Private Sub FormBuscadorProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        almacen.ListaProductos(GridProductos)
    End Sub


    Private Sub TxtProducto_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtProducto.KeyUp
        almacen.BuscarProductos(TxtProducto.Text, GridProductos)
    End Sub

    Private Sub GridProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridProductos.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then

            producto = GridProductos.SelectedCells(0).Value
            codigo = GridProductos.SelectedCells(3).Value
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub CloseWindow_Click(sender As Object, e As EventArgs) Handles CloseWindow.Click
        Me.Close()
    End Sub
End Class