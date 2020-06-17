Public Class Entradas
    '__entrada__'
    Public identrada As Integer
    Public folio As String
    Public idalmacen As Integer
    Public almacen As String
    Public concepto As String
    Public idconcepto As String
    Public idusuario As Integer
    Public referencia As String
    Public observacion As String
    Public estado As String
    '__entrada detalle__
    Public codigo As String
    Public cantidad As String
    Public idproducto As String
    Public costo As Double
    Public total As Double
    Public tc As Integer
    Public act As String
    Public ultcosto As String
    Public idmoneda As String



    Public Sub Entradas()

    End Sub

    Public Sub Entradas(ByVal identrada As Integer, folio As String, idalmacen As Integer, idconcepto As String,
                      idusuario As Integer, referencia As String, observacion As String, estado As String, codigo As String, almacen As String, concepto As String,
                        cantidad As String, idproducto As String, costo As Double, total As Double, tc As String, act As String, ultcosto As String, idmoneda As String)
        Me.identrada = identrada
        Me.folio = folio
        Me.idalmacen = idalmacen
        Me.concepto = concepto
        Me.almacen = almacen
        Me.idconcepto = idconcepto
        Me.idusuario = idusuario
        Me.referencia = referencia
        Me.observacion = observacion
        Me.estado = estado
        Me.codigo = codigo
        Me.cantidad = cantidad
        Me.idproducto = idproducto
        Me.costo = costo
        Me.total = total
        Me.tc = tc
        Me.act = act
        Me.ultcosto = ultcosto
        Me.idmoneda = idmoneda
    End Sub





End Class
