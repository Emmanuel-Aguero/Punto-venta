Public Class FormMsgBox

    Public mensaje As String
    Public titulo As String
    Public solicitud As Boolean
    Private Sub MsgAceptar_Click(sender As Object, e As EventArgs) Handles MsgAceptar.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub MsgCancelar_Click(sender As Object, e As EventArgs) Handles MsgCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FormMsgBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelMensaje.Text = mensaje
        LabelTitulo.Text = titulo
        If Not solicitud Then
            MsgCancelar.Visible = False
        End If

    End Sub
End Class