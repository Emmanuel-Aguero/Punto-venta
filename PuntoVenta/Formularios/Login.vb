Public Class Login

    Dim login As New Sesion()
    Private Sub CloseWindow_Click(sender As Object, e As EventArgs) Handles CloseWindow.Click
        Me.Close()
    End Sub

    Private Sub MinimizeWindow_Click(sender As Object, e As EventArgs) Handles MinimizeWindow.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Usuario = CmbUsuarios.selectedValue
        login.Contraseña = TxtContraseña.Text
        If Not (String.IsNullOrEmpty(login.Usuario) And String.IsNullOrEmpty(login.Contraseña)) Then
            If (login.IniciarSesion()) Then
                Dim formprincipal As New FormPrincipal()
                formprincipal.Show()
                Me.Close()
            Else
                MsgBox("NO SE PUDO")
            End If
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexionRed = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()
        If (conexionRed) Then
            login.CargaUsuarios(CmbUsuarios)
        Else
            MsgBox("Compruebe su conexion")
        End If
    End Sub

    Private Sub TxtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            login.Usuario = CmbUsuarios.selectedValue
            login.Contraseña = TxtContraseña.Text
            If Not (String.IsNullOrEmpty(login.Usuario) And String.IsNullOrEmpty(login.Contraseña)) Then
                If (login.IniciarSesion()) Then
                    Dim formprincipal As New FormPrincipal()
                    formprincipal.Show()
                    Me.Close()
                Else
                    MsgBox("NO SE PUDO")
                End If
            End If
        End If
    End Sub
End Class
