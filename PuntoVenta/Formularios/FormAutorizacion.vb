Public Class FormAutorizacion
    Public clave_autorizacion As String

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtAutorizacion.Text IsNot "" Then
            Me.clave_autorizacion = TxtAutorizacion.Text
            LabelError.Visible = False
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            LabelError.Visible = True
        End If


    End Sub

    Private Sub TxtAutorizacion_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAutorizacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtAutorizacion.Text IsNot "" Then
                Me.clave_autorizacion = TxtAutorizacion.Text
                LabelError.Visible = False
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                LabelError.Visible = True
            End If
        End If
    End Sub
End Class