Public Class FormActualizacionInventario

    Dim almacen As New Almacen

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW = &H2000000
            Dim create As CreateParams = MyBase.CreateParams
            create.ExStyle = create.ExStyle Or CS_DROPSHADOW
            Return create
        End Get
    End Property
    Private Sub FormActualizacionInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatimeFecha.Value = DateTime.Now
        almacen.Almacenes(CmbAlmacen)
        If Utility.TerminarInventario Then
            BtnAjustar.Enabled = True
            BtnGeneraDif.Enabled = True
        Else
            BtnAjustar.Enabled = False
            BtnGeneraDif.Enabled = False
        End If
    End Sub

    Private Sub CmbTipoInventario_onItemSelected(sender As Object, e As EventArgs) Handles CmbTipoInventario.onItemSelected
        Select Case CmbTipoInventario.selectedValue
            Case "Familia"
                FlexDrop.Clear()
                almacen.CargaFamilias(FlexDrop)
                FlexDrop.Visible = True
                LabelFlexTitulo.Visible = True
                LabelFlexTitulo.Text = "Familia:"
            Case "Proveedor"
                FlexDrop.Clear()
                almacen.CargaProveedores(FlexDrop)
                FlexDrop.Visible = True
                LabelFlexTitulo.Visible = True
                LabelFlexTitulo.Text = "Proveedor:"
            Case "Ubicacion"
                FlexDrop.Clear()
                almacen.CargaUbicacion(FlexDrop)
                FlexDrop.Visible = True
                LabelFlexTitulo.Visible = True
                LabelFlexTitulo.Text = "Ubicacion:"
            Case "General", "Seleccion de productos"
                FlexDrop.Clear()
                FlexDrop.Visible = False
                LabelFlexTitulo.Visible = False
        End Select
    End Sub

    Private Sub BtnInicializa_Click(sender As Object, e As EventArgs) Handles BtnInicializa.Click
        Try
            Select Case CmbTipoInventario.selectedValue
                Case "General"
                    almacen.InicializaInventario(CmbTipoInventario.selectedValue, CmbAlmacen.selectedValue, "", DatimeFecha.Value.Date)
                Case "Familia", "Ubicacion"
                    almacen.InicializaInventario(CmbTipoInventario.selectedValue, CmbAlmacen.selectedValue, FlexDrop.selectedValue + "", DatimeFecha.Value.Date)
                Case "Seleccion de productos"
                    almacen.InicializaInventario(CmbTipoInventario.selectedValue, CmbAlmacen.selectedValue, DatimeFecha.Value + "", DatimeFecha.Value.Date)
            End Select


            Using mensaje As New FormMsgBox
                mensaje.mensaje = "Inventario inicializado con exito"
                mensaje.titulo = "Mensaje"
                mensaje.solicitud = True
                mensaje.ShowDialog()
            End Using
        Catch ex As Exception
            Using mensaje As New FormMsgBox
                mensaje.mensaje = ex.Message
                mensaje.titulo = "Advertencia"
                mensaje.solicitud = True
                mensaje.ShowDialog()
            End Using
        End Try

    End Sub

    Private Sub BtnGeneraDif_Click(sender As Object, e As EventArgs) Handles BtnGeneraDif.Click

        'Try
        Select Case CmbTipoInventario.selectedValue
                Case "General", "Ubicacion"

                almacen.InicializaDiferencias(CmbTipoInventario.selectedValue, DatimeFecha.Value.Date, "")
            Case "Familia"
                almacen.InicializaDiferencias(CmbTipoInventario.selectedValue, DatimeFecha.Value.Date, FlexDrop.selectedValue)
        End Select

            Select Case CmbTipoInventario.selectedValue
                Case "General", "Seleccion de productos"
                almacen.GenerarDiferencias(CmbTipoInventario.selectedValue, CmbAlmacen.selectedValue, DatimeFecha.Value.Date, "")
            Case "Familia", "Ubicacion"
                    almacen.GenerarDiferencias(CmbTipoInventario.selectedValue, CmbAlmacen.selectedValue, DatimeFecha.Value.Date, FlexDrop.selectedValue)

            End Select
            Using mensaje As New FormMsgBox
                mensaje.mensaje = "Diferencias generadas con exito"
                mensaje.titulo = "Mensaje"
                mensaje.solicitud = True
                mensaje.ShowDialog()
            End Using
        'Catch ex As Exception
        'Using mensaje As New FormMsgBox
        'mensaje.mensaje = ex.Message
        'mensaje.titulo = "Advertencia"
        'mensaje.solicitud = True
        'mensaje.ShowDialog()
        'End Using
        'End Try





    End Sub

    Private Sub BtnAjustar_Click(sender As Object, e As EventArgs) Handles BtnAjustar.Click
        Try
            Select Case CmbTipoInventario.selectedValue
                Case "General"
                    almacen.AjustarInventario(CmbTipoInventario.selectedValue, CmbAlmacen.selectedValue, DatimeFecha.Value.Date, "")
                Case "Familia", "Ubicacion"
                    almacen.AjustarInventario(CmbTipoInventario.selectedValue, CmbAlmacen.selectedValue, DatimeFecha.Value.Date, FlexDrop.selectedValue)
            End Select
            Using mensaje As New FormMsgBox
                mensaje.mensaje = "Inventario ajustado con exito"
                mensaje.titulo = "Mensaje"
                mensaje.solicitud = True
                mensaje.ShowDialog()
            End Using
        Catch ex As Exception
            Using mensaje As New FormMsgBox
                mensaje.mensaje = ex.Message
                mensaje.titulo = "Advertencia"
                mensaje.solicitud = True
                mensaje.ShowDialog()
            End Using
        End Try

    End Sub
End Class