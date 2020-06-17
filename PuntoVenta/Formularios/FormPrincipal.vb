Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class FormPrincipal
    Private botonActual As IconButton
    Private formularioActual As Form
    Private bordeBotonIzq As Panel
    Private SubMenuActual As Panel
    Dim lx, ly, sw, sh As Integer

    Dim countVentas, countCompras, countAlmacen, countRegistro As Integer

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW = &H2000000
            Dim create As CreateParams = MyBase.CreateParams
            create.ExStyle = create.ExStyle Or CS_DROPSHADOW
            Return create
        End Get
    End Property



    Private Structure RGBColors
        Public Shared color As Color = Color.White
    End Structure

    Public Sub New()

        InitializeComponent()
        bordeBotonIzq = New Panel()
        bordeBotonIzq.Visible = False
        bordeBotonIzq.Size = New Size(3, 43)
        GradientePanel.Controls.Add(bordeBotonIzq)
        Text = String.Empty
        Me.DoubleBuffered = True
        Me.ControlBox = False
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea

    End Sub
    Private Sub CloseWindow_Click(sender As Object, e As EventArgs) Handles CloseWindow.Click
        formularioActual.Close()
        Me.Close()

    End Sub

    Private Sub MaximizeWindow_Click(sender As Object, e As EventArgs) Handles MaximizeWindow.Click
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        RestoreWindow.Visible = True
        MaximizeWindow.Visible = False

    End Sub

    Private Sub MinimizeWindow_Click(sender As Object, e As EventArgs) Handles MinimizeWindow.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles RestoreWindow.Click
        Me.Size = New Size(sw, sh)
        'Me.Location = New Point(lx, ly)
        RestoreWindow.Visible = False
        MaximizeWindow.Visible = True

    End Sub

    Private Sub BarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub




    Public Sub ShowMenu(panel As Panel)
        panel.Visible = False
        SubMenuTransition.Show(panel)
    End Sub

    Private Sub HideSubMenu()
        If SubMenuActual IsNot Nothing Then
            SubMenuActual.Visible = False
        End If
    End Sub
    Private Sub ActivarBoton(senderBtn As Object, color As Color)

        If senderBtn IsNot Nothing Then
            DesactivarBoton()
            HideSubMenu()
            botonActual = CType(senderBtn, IconButton)

            bordeBotonIzq.BackColor = color
            bordeBotonIzq.Location = New Point(2, botonActual.Location.Y)
            bordeBotonIzq.Visible = True
            bordeBotonIzq.BringToFront()
        End If
    End Sub

    Private Sub BtnActualizacionInv_Click(sender As Object, e As EventArgs) Handles BtnActualizacionInv.Click
        OpenFormulario(New FormActualizacionInventario)
    End Sub

    Private Sub BtnEntradasMercancia_Click(sender As Object, e As EventArgs) Handles BtnEntradasMercancia.Click
        OpenFormulario(New FormEntradas)
    End Sub

    Private Sub DesactivarBoton()
        If botonActual IsNot Nothing Then
            botonActual.BackColor = Color.Transparent
            botonActual.ForeColor = Color.White
            botonActual.TextAlign = ContentAlignment.MiddleLeft
            botonActual.IconColor = Color.White
            botonActual.TextImageRelation = TextImageRelation.ImageBeforeText
            botonActual.ImageAlign = ContentAlignment.MiddleLeft
        End If
    End Sub


    Private Sub OpenFormulario(form As Form)
        If (formularioActual IsNot Nothing) Then
            formularioActual.Close()
        End If

        formularioActual = form
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        PanelFormularios.Controls.Add(form)
        PanelFormularios.Tag = form
        form.BringToFront()
        form.Show()
    End Sub

    Private Sub BtnInvFisico_Click(sender As Object, e As EventArgs) Handles BtnInvFisico.Click
        OpenFormulario(New FormInventarioFisico)
    End Sub

    Private Sub BtnCompras_Click(sender As Object, e As EventArgs) Handles BtnCompras.Click
        countCompras += 1
        If countCompras Mod 2 = 0 Then
            DesactivarBoton()
            HideSubMenu()
        Else
            ActivarBoton(sender, RGBColors.color)
            SubMenuCompra.Height = 315
            SubMenuActual = SubMenuCompra
            ShowMenu(SubMenuCompra)
        End If

    End Sub

    Private Sub BtnAlmacen_Click(sender As Object, e As EventArgs) Handles BtnAlmacen.Click
        countAlmacen += 1
        If countAlmacen Mod 2 = 0 Then
            DesactivarBoton()
            HideSubMenu()
        Else
            ActivarBoton(sender, RGBColors.color)
            SubMenuAlmacen.Height = 735
            SubMenuActual = SubMenuAlmacen
            ShowMenu(SubMenuAlmacen)
        End If

    End Sub



    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        countVentas += 1
        If countVentas Mod 2 = 0 Then
            DesactivarBoton()
            HideSubMenu()
        Else
            ActivarBoton(sender, RGBColors.color)
            SubMenuVentas.Height = 455
            SubMenuActual = SubMenuVentas
            ShowMenu(SubMenuVentas)
        End If


    End Sub





End Class