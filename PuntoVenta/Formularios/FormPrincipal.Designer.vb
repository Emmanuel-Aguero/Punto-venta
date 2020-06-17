<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.RestoreWindow = New System.Windows.Forms.PictureBox()
        Me.MinimizeWindow = New System.Windows.Forms.PictureBox()
        Me.MaximizeWindow = New System.Windows.Forms.PictureBox()
        Me.CloseWindow = New System.Windows.Forms.PictureBox()
        Me.LabelSideBar = New System.Windows.Forms.Label()
        Me.MenuSideBar = New FontAwesome.Sharp.IconPictureBox()
        Me.SideBar = New System.Windows.Forms.Panel()
        Me.GradientePanel = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.SubMenuRegistro = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.IconButton34 = New FontAwesome.Sharp.IconButton()
        Me.IconButton33 = New FontAwesome.Sharp.IconButton()
        Me.IconButton32 = New FontAwesome.Sharp.IconButton()
        Me.IconButton31 = New FontAwesome.Sharp.IconButton()
        Me.IconButton30 = New FontAwesome.Sharp.IconButton()
        Me.IconButton21 = New FontAwesome.Sharp.IconButton()
        Me.IconButton22 = New FontAwesome.Sharp.IconButton()
        Me.IconButton23 = New FontAwesome.Sharp.IconButton()
        Me.IconButton24 = New FontAwesome.Sharp.IconButton()
        Me.IconButton25 = New FontAwesome.Sharp.IconButton()
        Me.IconButton26 = New FontAwesome.Sharp.IconButton()
        Me.IconButton27 = New FontAwesome.Sharp.IconButton()
        Me.IconButton28 = New FontAwesome.Sharp.IconButton()
        Me.IconButton29 = New FontAwesome.Sharp.IconButton()
        Me.IconButton20 = New FontAwesome.Sharp.IconButton()
        Me.SubMenuCompra = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BtnReporteadorCompras = New FontAwesome.Sharp.IconButton()
        Me.BtnNotaCargoxFaltante = New FontAwesome.Sharp.IconButton()
        Me.BtnNotasCredito = New FontAwesome.Sharp.IconButton()
        Me.BtnProveedores = New FontAwesome.Sharp.IconButton()
        Me.BtnCatalogoPrecios = New FontAwesome.Sharp.IconButton()
        Me.BtnAnalisisOrden = New FontAwesome.Sharp.IconButton()
        Me.BtnContra_recibo = New FontAwesome.Sharp.IconButton()
        Me.BtnOrdenCompra = New FontAwesome.Sharp.IconButton()
        Me.BtnComprasMenu = New FontAwesome.Sharp.IconButton()
        Me.BtnCompras = New FontAwesome.Sharp.IconButton()
        Me.SubMenuAlmacen = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BtnReporteador = New FontAwesome.Sharp.IconButton()
        Me.BtnConversiones = New FontAwesome.Sharp.IconButton()
        Me.BtnConceptos = New FontAwesome.Sharp.IconButton()
        Me.BtnNotificaciones = New FontAwesome.Sharp.IconButton()
        Me.BtnActualizacionInv = New FontAwesome.Sharp.IconButton()
        Me.BtnInvFisico = New FontAwesome.Sharp.IconButton()
        Me.BtnPedidoMercancia = New FontAwesome.Sharp.IconButton()
        Me.BtnTraspasosEAlmacenes = New FontAwesome.Sharp.IconButton()
        Me.SalidaMercancia = New FontAwesome.Sharp.IconButton()
        Me.BtnEntradasMercancia = New FontAwesome.Sharp.IconButton()
        Me.BtnTablajeria = New FontAwesome.Sharp.IconButton()
        Me.BtnMinMax = New FontAwesome.Sharp.IconButton()
        Me.BtnProductosProcesados = New FontAwesome.Sharp.IconButton()
        Me.BtnEscalasPrecio = New FontAwesome.Sharp.IconButton()
        Me.BtnFamYDepartamentos = New FontAwesome.Sharp.IconButton()
        Me.BtnVerificadorProductos = New FontAwesome.Sharp.IconButton()
        Me.BtnActivacionPrecios = New FontAwesome.Sharp.IconButton()
        Me.BtnCatalogoProductos = New FontAwesome.Sharp.IconButton()
        Me.BtnProductos = New FontAwesome.Sharp.IconButton()
        Me.BtnSucursalesYAlmacenes = New FontAwesome.Sharp.IconButton()
        Me.BtnAlmacen = New FontAwesome.Sharp.IconButton()
        Me.SubMenuVentas = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BtnReporteadorCredCobranza = New FontAwesome.Sharp.IconButton()
        Me.BtnReporteadorRutas = New FontAwesome.Sharp.IconButton()
        Me.BtnCobranza = New FontAwesome.Sharp.IconButton()
        Me.BtnDocumentosClientes = New FontAwesome.Sharp.IconButton()
        Me.BtnLiberarCheques = New FontAwesome.Sharp.IconButton()
        Me.BtnClientes = New FontAwesome.Sharp.IconButton()
        Me.BtnVerOfertas = New FontAwesome.Sharp.IconButton()
        Me.BtnCrearOfertas = New FontAwesome.Sharp.IconButton()
        Me.BtnOfertas = New FontAwesome.Sharp.IconButton()
        Me.BtnRuta_Cliente = New FontAwesome.Sharp.IconButton()
        Me.BtnVendedores = New FontAwesome.Sharp.IconButton()
        Me.BtnFacComandas = New FontAwesome.Sharp.IconButton()
        Me.BtnFacRutas = New FontAwesome.Sharp.IconButton()
        Me.BtnVentas = New FontAwesome.Sharp.IconButton()
        Me.SubMenuTransition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.RestoreWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimizeWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaximizeWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuSideBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SideBar.SuspendLayout()
        Me.GradientePanel.SuspendLayout()
        Me.SubMenuRegistro.SuspendLayout()
        Me.SubMenuCompra.SuspendLayout()
        Me.SubMenuAlmacen.SuspendLayout()
        Me.SubMenuVentas.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraTitulo
        '
        Me.BarraTitulo.AutoScroll = True
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.RestoreWindow)
        Me.BarraTitulo.Controls.Add(Me.MinimizeWindow)
        Me.BarraTitulo.Controls.Add(Me.MaximizeWindow)
        Me.BarraTitulo.Controls.Add(Me.CloseWindow)
        Me.BarraTitulo.Controls.Add(Me.LabelSideBar)
        Me.BarraTitulo.Controls.Add(Me.MenuSideBar)
        Me.SubMenuTransition.SetDecoration(Me.BarraTitulo, BunifuAnimatorNS.DecorationType.None)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1200, 38)
        Me.BarraTitulo.TabIndex = 1
        '
        'RestoreWindow
        '
        Me.RestoreWindow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RestoreWindow.BackgroundImage = Global.PuntoVenta.My.Resources.Resources.Icono_Restaurar
        Me.RestoreWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SubMenuTransition.SetDecoration(Me.RestoreWindow, BunifuAnimatorNS.DecorationType.None)
        Me.RestoreWindow.Location = New System.Drawing.Point(1137, 6)
        Me.RestoreWindow.Name = "RestoreWindow"
        Me.RestoreWindow.Size = New System.Drawing.Size(25, 25)
        Me.RestoreWindow.TabIndex = 3
        Me.RestoreWindow.TabStop = False
        Me.RestoreWindow.Visible = False
        '
        'MinimizeWindow
        '
        Me.MinimizeWindow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizeWindow.BackgroundImage = Global.PuntoVenta.My.Resources.Resources.Icono_Minimizar
        Me.MinimizeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SubMenuTransition.SetDecoration(Me.MinimizeWindow, BunifuAnimatorNS.DecorationType.None)
        Me.MinimizeWindow.Location = New System.Drawing.Point(1106, 6)
        Me.MinimizeWindow.Name = "MinimizeWindow"
        Me.MinimizeWindow.Size = New System.Drawing.Size(25, 25)
        Me.MinimizeWindow.TabIndex = 3
        Me.MinimizeWindow.TabStop = False
        '
        'MaximizeWindow
        '
        Me.MaximizeWindow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaximizeWindow.BackgroundImage = Global.PuntoVenta.My.Resources.Resources.Icono_Maximizar
        Me.MaximizeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SubMenuTransition.SetDecoration(Me.MaximizeWindow, BunifuAnimatorNS.DecorationType.None)
        Me.MaximizeWindow.Location = New System.Drawing.Point(1137, 6)
        Me.MaximizeWindow.Name = "MaximizeWindow"
        Me.MaximizeWindow.Size = New System.Drawing.Size(25, 25)
        Me.MaximizeWindow.TabIndex = 3
        Me.MaximizeWindow.TabStop = False
        '
        'CloseWindow
        '
        Me.CloseWindow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseWindow.BackgroundImage = Global.PuntoVenta.My.Resources.Resources.Icono_cerrar_FN
        Me.CloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SubMenuTransition.SetDecoration(Me.CloseWindow, BunifuAnimatorNS.DecorationType.None)
        Me.CloseWindow.Location = New System.Drawing.Point(1168, 6)
        Me.CloseWindow.Name = "CloseWindow"
        Me.CloseWindow.Size = New System.Drawing.Size(25, 25)
        Me.CloseWindow.TabIndex = 2
        Me.CloseWindow.TabStop = False
        '
        'LabelSideBar
        '
        Me.LabelSideBar.AutoSize = True
        Me.SubMenuTransition.SetDecoration(Me.LabelSideBar, BunifuAnimatorNS.DecorationType.None)
        Me.LabelSideBar.Font = New System.Drawing.Font("Poppins", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSideBar.ForeColor = System.Drawing.Color.White
        Me.LabelSideBar.Location = New System.Drawing.Point(46, 6)
        Me.LabelSideBar.Name = "LabelSideBar"
        Me.LabelSideBar.Size = New System.Drawing.Size(59, 28)
        Me.LabelSideBar.TabIndex = 1
        Me.LabelSideBar.Text = "MENU"
        '
        'MenuSideBar
        '
        Me.MenuSideBar.BackColor = System.Drawing.Color.Transparent
        Me.SubMenuTransition.SetDecoration(Me.MenuSideBar, BunifuAnimatorNS.DecorationType.None)
        Me.MenuSideBar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuSideBar.IconChar = FontAwesome.Sharp.IconChar.Bars
        Me.MenuSideBar.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuSideBar.Location = New System.Drawing.Point(9, 4)
        Me.MenuSideBar.Name = "MenuSideBar"
        Me.MenuSideBar.Size = New System.Drawing.Size(32, 32)
        Me.MenuSideBar.TabIndex = 1
        Me.MenuSideBar.TabStop = False
        '
        'SideBar
        '
        Me.SideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SideBar.Controls.Add(Me.GradientePanel)
        Me.SubMenuTransition.SetDecoration(Me.SideBar, BunifuAnimatorNS.DecorationType.None)
        Me.SideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideBar.Location = New System.Drawing.Point(0, 38)
        Me.SideBar.Name = "SideBar"
        Me.SideBar.Size = New System.Drawing.Size(266, 662)
        Me.SideBar.TabIndex = 2
        '
        'GradientePanel
        '
        Me.GradientePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GradientePanel.AutoScroll = True
        Me.GradientePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GradientePanel.BackgroundImage = CType(resources.GetObject("GradientePanel.BackgroundImage"), System.Drawing.Image)
        Me.GradientePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GradientePanel.Controls.Add(Me.SubMenuRegistro)
        Me.GradientePanel.Controls.Add(Me.IconButton20)
        Me.GradientePanel.Controls.Add(Me.SubMenuCompra)
        Me.GradientePanel.Controls.Add(Me.BtnCompras)
        Me.GradientePanel.Controls.Add(Me.SubMenuAlmacen)
        Me.GradientePanel.Controls.Add(Me.BtnAlmacen)
        Me.GradientePanel.Controls.Add(Me.SubMenuVentas)
        Me.GradientePanel.Controls.Add(Me.BtnVentas)
        Me.SubMenuTransition.SetDecoration(Me.GradientePanel, BunifuAnimatorNS.DecorationType.None)
        Me.GradientePanel.GradientBottomLeft = System.Drawing.Color.Teal
        Me.GradientePanel.GradientBottomRight = System.Drawing.Color.Teal
        Me.GradientePanel.GradientTopLeft = System.Drawing.Color.Black
        Me.GradientePanel.GradientTopRight = System.Drawing.Color.Black
        Me.GradientePanel.Location = New System.Drawing.Point(7, 6)
        Me.GradientePanel.Name = "GradientePanel"
        Me.GradientePanel.Quality = 10
        Me.GradientePanel.Size = New System.Drawing.Size(252, 682)
        Me.GradientePanel.TabIndex = 1
        '
        'SubMenuRegistro
        '
        Me.SubMenuRegistro.BackgroundImage = CType(resources.GetObject("SubMenuRegistro.BackgroundImage"), System.Drawing.Image)
        Me.SubMenuRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SubMenuRegistro.Controls.Add(Me.IconButton34)
        Me.SubMenuRegistro.Controls.Add(Me.IconButton33)
        Me.SubMenuRegistro.Controls.Add(Me.IconButton32)
        Me.SubMenuRegistro.Controls.Add(Me.IconButton31)
        Me.SubMenuRegistro.Controls.Add(Me.IconButton30)
        Me.SubMenuRegistro.Controls.Add(Me.IconButton21)
        Me.SubMenuRegistro.Controls.Add(Me.IconButton22)
        Me.SubMenuRegistro.Controls.Add(Me.IconButton23)
        Me.SubMenuRegistro.Controls.Add(Me.IconButton24)
        Me.SubMenuRegistro.Controls.Add(Me.IconButton25)
        Me.SubMenuRegistro.Controls.Add(Me.IconButton26)
        Me.SubMenuRegistro.Controls.Add(Me.IconButton27)
        Me.SubMenuRegistro.Controls.Add(Me.IconButton28)
        Me.SubMenuRegistro.Controls.Add(Me.IconButton29)
        Me.SubMenuTransition.SetDecoration(Me.SubMenuRegistro, BunifuAnimatorNS.DecorationType.None)
        Me.SubMenuRegistro.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuRegistro.GradientBottomLeft = System.Drawing.Color.Teal
        Me.SubMenuRegistro.GradientBottomRight = System.Drawing.Color.Teal
        Me.SubMenuRegistro.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SubMenuRegistro.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SubMenuRegistro.Location = New System.Drawing.Point(0, 892)
        Me.SubMenuRegistro.Name = "SubMenuRegistro"
        Me.SubMenuRegistro.Quality = 10
        Me.SubMenuRegistro.Size = New System.Drawing.Size(235, 10)
        Me.SubMenuRegistro.TabIndex = 16
        Me.SubMenuRegistro.Visible = False
        '
        'IconButton34
        '
        Me.IconButton34.BackColor = System.Drawing.Color.Transparent
        Me.IconButton34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.IconButton34, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton34.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton34.FlatAppearance.BorderSize = 0
        Me.IconButton34.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton34.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton34.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton34.ForeColor = System.Drawing.Color.White
        Me.IconButton34.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton34.IconColor = System.Drawing.Color.White
        Me.IconButton34.IconSize = 32
        Me.IconButton34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton34.Location = New System.Drawing.Point(0, 455)
        Me.IconButton34.Name = "IconButton34"
        Me.IconButton34.Rotation = 0R
        Me.IconButton34.Size = New System.Drawing.Size(235, 35)
        Me.IconButton34.TabIndex = 14
        Me.IconButton34.Text = "Reporteador de cajas"
        Me.IconButton34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton34.UseVisualStyleBackColor = False
        '
        'IconButton33
        '
        Me.IconButton33.BackColor = System.Drawing.Color.Transparent
        Me.IconButton33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.IconButton33, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton33.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton33.FlatAppearance.BorderSize = 0
        Me.IconButton33.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton33.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton33.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton33.ForeColor = System.Drawing.Color.White
        Me.IconButton33.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton33.IconColor = System.Drawing.Color.White
        Me.IconButton33.IconSize = 32
        Me.IconButton33.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton33.Location = New System.Drawing.Point(0, 420)
        Me.IconButton33.Name = "IconButton33"
        Me.IconButton33.Rotation = 0R
        Me.IconButton33.Size = New System.Drawing.Size(235, 35)
        Me.IconButton33.TabIndex = 13
        Me.IconButton33.Text = "Actualizacion de ventas"
        Me.IconButton33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton33.UseVisualStyleBackColor = False
        '
        'IconButton32
        '
        Me.IconButton32.BackColor = System.Drawing.Color.Transparent
        Me.IconButton32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.IconButton32, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton32.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton32.FlatAppearance.BorderSize = 0
        Me.IconButton32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton32.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton32.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton32.ForeColor = System.Drawing.Color.White
        Me.IconButton32.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton32.IconColor = System.Drawing.Color.White
        Me.IconButton32.IconSize = 32
        Me.IconButton32.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton32.Location = New System.Drawing.Point(0, 385)
        Me.IconButton32.Name = "IconButton32"
        Me.IconButton32.Rotation = 0R
        Me.IconButton32.Size = New System.Drawing.Size(235, 35)
        Me.IconButton32.TabIndex = 12
        Me.IconButton32.Text = "Consolidacion de ventas"
        Me.IconButton32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton32.UseVisualStyleBackColor = False
        '
        'IconButton31
        '
        Me.IconButton31.BackColor = System.Drawing.Color.Transparent
        Me.IconButton31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.IconButton31, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton31.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton31.FlatAppearance.BorderSize = 0
        Me.IconButton31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton31.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton31.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton31.ForeColor = System.Drawing.Color.White
        Me.IconButton31.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton31.IconColor = System.Drawing.Color.White
        Me.IconButton31.IconSize = 32
        Me.IconButton31.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton31.Location = New System.Drawing.Point(0, 350)
        Me.IconButton31.Name = "IconButton31"
        Me.IconButton31.Rotation = 0R
        Me.IconButton31.Size = New System.Drawing.Size(235, 35)
        Me.IconButton31.TabIndex = 11
        Me.IconButton31.Text = "Devoluciones"
        Me.IconButton31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton31.UseVisualStyleBackColor = False
        '
        'IconButton30
        '
        Me.IconButton30.BackColor = System.Drawing.Color.Transparent
        Me.IconButton30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.IconButton30, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton30.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton30.FlatAppearance.BorderSize = 0
        Me.IconButton30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton30.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton30.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton30.ForeColor = System.Drawing.Color.White
        Me.IconButton30.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton30.IconColor = System.Drawing.Color.White
        Me.IconButton30.IconSize = 32
        Me.IconButton30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton30.Location = New System.Drawing.Point(0, 315)
        Me.IconButton30.Name = "IconButton30"
        Me.IconButton30.Rotation = 0R
        Me.IconButton30.Size = New System.Drawing.Size(235, 35)
        Me.IconButton30.TabIndex = 10
        Me.IconButton30.Text = "Sobrante de cajas"
        Me.IconButton30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton30.UseVisualStyleBackColor = False
        '
        'IconButton21
        '
        Me.IconButton21.BackColor = System.Drawing.Color.Transparent
        Me.IconButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.IconButton21, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton21.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton21.FlatAppearance.BorderSize = 0
        Me.IconButton21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton21.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton21.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton21.ForeColor = System.Drawing.Color.White
        Me.IconButton21.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton21.IconColor = System.Drawing.Color.White
        Me.IconButton21.IconSize = 32
        Me.IconButton21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton21.Location = New System.Drawing.Point(0, 280)
        Me.IconButton21.Name = "IconButton21"
        Me.IconButton21.Rotation = 0R
        Me.IconButton21.Size = New System.Drawing.Size(235, 35)
        Me.IconButton21.TabIndex = 9
        Me.IconButton21.Text = "Depositos de rutas"
        Me.IconButton21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton21.UseVisualStyleBackColor = False
        '
        'IconButton22
        '
        Me.IconButton22.BackColor = System.Drawing.Color.Transparent
        Me.IconButton22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.IconButton22, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton22.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton22.FlatAppearance.BorderSize = 0
        Me.IconButton22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton22.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton22.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton22.ForeColor = System.Drawing.Color.White
        Me.IconButton22.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton22.IconColor = System.Drawing.Color.White
        Me.IconButton22.IconSize = 32
        Me.IconButton22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton22.Location = New System.Drawing.Point(0, 245)
        Me.IconButton22.Name = "IconButton22"
        Me.IconButton22.Rotation = 0R
        Me.IconButton22.Size = New System.Drawing.Size(235, 35)
        Me.IconButton22.TabIndex = 8
        Me.IconButton22.Text = "Depositos"
        Me.IconButton22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton22.UseVisualStyleBackColor = False
        '
        'IconButton23
        '
        Me.IconButton23.BackColor = System.Drawing.Color.Transparent
        Me.IconButton23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.IconButton23, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton23.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton23.FlatAppearance.BorderSize = 0
        Me.IconButton23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton23.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton23.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton23.ForeColor = System.Drawing.Color.White
        Me.IconButton23.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton23.IconColor = System.Drawing.Color.White
        Me.IconButton23.IconSize = 32
        Me.IconButton23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton23.Location = New System.Drawing.Point(0, 210)
        Me.IconButton23.Name = "IconButton23"
        Me.IconButton23.Rotation = 0R
        Me.IconButton23.Size = New System.Drawing.Size(235, 35)
        Me.IconButton23.TabIndex = 7
        Me.IconButton23.Text = "Captura de cheques y tarjetas"
        Me.IconButton23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton23.UseVisualStyleBackColor = False
        '
        'IconButton24
        '
        Me.IconButton24.BackColor = System.Drawing.Color.Transparent
        Me.IconButton24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.IconButton24, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton24.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton24.FlatAppearance.BorderSize = 0
        Me.IconButton24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton24.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton24.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton24.ForeColor = System.Drawing.Color.White
        Me.IconButton24.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton24.IconColor = System.Drawing.Color.White
        Me.IconButton24.IconSize = 32
        Me.IconButton24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton24.Location = New System.Drawing.Point(0, 175)
        Me.IconButton24.Name = "IconButton24"
        Me.IconButton24.Rotation = 0R
        Me.IconButton24.Size = New System.Drawing.Size(235, 35)
        Me.IconButton24.TabIndex = 6
        Me.IconButton24.Text = "Cajeros"
        Me.IconButton24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton24.UseVisualStyleBackColor = False
        '
        'IconButton25
        '
        Me.IconButton25.BackColor = System.Drawing.Color.Transparent
        Me.IconButton25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.IconButton25, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton25.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton25.FlatAppearance.BorderSize = 0
        Me.IconButton25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton25.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton25.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton25.ForeColor = System.Drawing.Color.White
        Me.IconButton25.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton25.IconColor = System.Drawing.Color.White
        Me.IconButton25.IconSize = 32
        Me.IconButton25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton25.Location = New System.Drawing.Point(0, 140)
        Me.IconButton25.Name = "IconButton25"
        Me.IconButton25.Rotation = 0R
        Me.IconButton25.Size = New System.Drawing.Size(235, 35)
        Me.IconButton25.TabIndex = 5
        Me.IconButton25.Text = "Etiquetas"
        Me.IconButton25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton25.UseVisualStyleBackColor = False
        '
        'IconButton26
        '
        Me.IconButton26.BackColor = System.Drawing.Color.Transparent
        Me.IconButton26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.IconButton26, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton26.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton26.FlatAppearance.BorderSize = 0
        Me.IconButton26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton26.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton26.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton26.ForeColor = System.Drawing.Color.White
        Me.IconButton26.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton26.IconColor = System.Drawing.Color.White
        Me.IconButton26.IconSize = 32
        Me.IconButton26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton26.Location = New System.Drawing.Point(0, 105)
        Me.IconButton26.Name = "IconButton26"
        Me.IconButton26.Rotation = 0R
        Me.IconButton26.Size = New System.Drawing.Size(235, 35)
        Me.IconButton26.TabIndex = 4
        Me.IconButton26.Text = "Checador de precios"
        Me.IconButton26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton26.UseVisualStyleBackColor = False
        '
        'IconButton27
        '
        Me.IconButton27.BackColor = System.Drawing.Color.Transparent
        Me.IconButton27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.IconButton27, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton27.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton27.FlatAppearance.BorderSize = 0
        Me.IconButton27.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton27.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton27.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton27.ForeColor = System.Drawing.Color.White
        Me.IconButton27.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton27.IconColor = System.Drawing.Color.White
        Me.IconButton27.IconSize = 32
        Me.IconButton27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton27.Location = New System.Drawing.Point(0, 70)
        Me.IconButton27.Name = "IconButton27"
        Me.IconButton27.Rotation = 0R
        Me.IconButton27.Size = New System.Drawing.Size(235, 35)
        Me.IconButton27.TabIndex = 3
        Me.IconButton27.Text = "Cancelacion de facturas"
        Me.IconButton27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton27.UseVisualStyleBackColor = False
        '
        'IconButton28
        '
        Me.IconButton28.BackColor = System.Drawing.Color.Transparent
        Me.IconButton28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.IconButton28, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton28.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton28.FlatAppearance.BorderSize = 0
        Me.IconButton28.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton28.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton28.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton28.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton28.ForeColor = System.Drawing.Color.White
        Me.IconButton28.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton28.IconColor = System.Drawing.Color.White
        Me.IconButton28.IconSize = 32
        Me.IconButton28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton28.Location = New System.Drawing.Point(0, 35)
        Me.IconButton28.Name = "IconButton28"
        Me.IconButton28.Rotation = 0R
        Me.IconButton28.Size = New System.Drawing.Size(235, 35)
        Me.IconButton28.TabIndex = 2
        Me.IconButton28.Text = "Facturacion de varios recibos"
        Me.IconButton28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton28.UseVisualStyleBackColor = False
        '
        'IconButton29
        '
        Me.IconButton29.BackColor = System.Drawing.Color.Transparent
        Me.IconButton29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.IconButton29, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton29.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton29.FlatAppearance.BorderSize = 0
        Me.IconButton29.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton29.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton29.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton29.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton29.ForeColor = System.Drawing.Color.White
        Me.IconButton29.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton29.IconColor = System.Drawing.Color.White
        Me.IconButton29.IconSize = 32
        Me.IconButton29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton29.Location = New System.Drawing.Point(0, 0)
        Me.IconButton29.Name = "IconButton29"
        Me.IconButton29.Rotation = 0R
        Me.IconButton29.Size = New System.Drawing.Size(235, 35)
        Me.IconButton29.TabIndex = 1
        Me.IconButton29.Text = "Factura general del dia"
        Me.IconButton29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton29.UseVisualStyleBackColor = False
        '
        'IconButton20
        '
        Me.IconButton20.BackColor = System.Drawing.Color.Transparent
        Me.IconButton20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.IconButton20, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton20.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton20.FlatAppearance.BorderSize = 0
        Me.IconButton20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton20.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton20.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton20.ForeColor = System.Drawing.Color.White
        Me.IconButton20.IconChar = FontAwesome.Sharp.IconChar.Clipboard
        Me.IconButton20.IconColor = System.Drawing.Color.White
        Me.IconButton20.IconSize = 32
        Me.IconButton20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton20.Location = New System.Drawing.Point(0, 849)
        Me.IconButton20.Name = "IconButton20"
        Me.IconButton20.Rotation = 0R
        Me.IconButton20.Size = New System.Drawing.Size(235, 43)
        Me.IconButton20.TabIndex = 15
        Me.IconButton20.Text = "      Registro"
        Me.IconButton20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton20.UseVisualStyleBackColor = False
        '
        'SubMenuCompra
        '
        Me.SubMenuCompra.BackgroundImage = CType(resources.GetObject("SubMenuCompra.BackgroundImage"), System.Drawing.Image)
        Me.SubMenuCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SubMenuCompra.Controls.Add(Me.BtnReporteadorCompras)
        Me.SubMenuCompra.Controls.Add(Me.BtnNotaCargoxFaltante)
        Me.SubMenuCompra.Controls.Add(Me.BtnNotasCredito)
        Me.SubMenuCompra.Controls.Add(Me.BtnProveedores)
        Me.SubMenuCompra.Controls.Add(Me.BtnCatalogoPrecios)
        Me.SubMenuCompra.Controls.Add(Me.BtnAnalisisOrden)
        Me.SubMenuCompra.Controls.Add(Me.BtnContra_recibo)
        Me.SubMenuCompra.Controls.Add(Me.BtnOrdenCompra)
        Me.SubMenuCompra.Controls.Add(Me.BtnComprasMenu)
        Me.SubMenuTransition.SetDecoration(Me.SubMenuCompra, BunifuAnimatorNS.DecorationType.None)
        Me.SubMenuCompra.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuCompra.GradientBottomLeft = System.Drawing.Color.Teal
        Me.SubMenuCompra.GradientBottomRight = System.Drawing.Color.Teal
        Me.SubMenuCompra.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SubMenuCompra.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SubMenuCompra.Location = New System.Drawing.Point(0, 839)
        Me.SubMenuCompra.Name = "SubMenuCompra"
        Me.SubMenuCompra.Quality = 10
        Me.SubMenuCompra.Size = New System.Drawing.Size(235, 10)
        Me.SubMenuCompra.TabIndex = 14
        Me.SubMenuCompra.Visible = False
        '
        'BtnReporteadorCompras
        '
        Me.BtnReporteadorCompras.BackColor = System.Drawing.Color.Transparent
        Me.BtnReporteadorCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnReporteadorCompras, BunifuAnimatorNS.DecorationType.None)
        Me.BtnReporteadorCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReporteadorCompras.FlatAppearance.BorderSize = 0
        Me.BtnReporteadorCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnReporteadorCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnReporteadorCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReporteadorCompras.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnReporteadorCompras.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporteadorCompras.ForeColor = System.Drawing.Color.White
        Me.BtnReporteadorCompras.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnReporteadorCompras.IconColor = System.Drawing.Color.White
        Me.BtnReporteadorCompras.IconSize = 32
        Me.BtnReporteadorCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReporteadorCompras.Location = New System.Drawing.Point(0, 280)
        Me.BtnReporteadorCompras.Name = "BtnReporteadorCompras"
        Me.BtnReporteadorCompras.Rotation = 0R
        Me.BtnReporteadorCompras.Size = New System.Drawing.Size(235, 35)
        Me.BtnReporteadorCompras.TabIndex = 9
        Me.BtnReporteadorCompras.Text = "Reporteador de Compras"
        Me.BtnReporteadorCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReporteadorCompras.UseVisualStyleBackColor = False
        '
        'BtnNotaCargoxFaltante
        '
        Me.BtnNotaCargoxFaltante.BackColor = System.Drawing.Color.Transparent
        Me.BtnNotaCargoxFaltante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnNotaCargoxFaltante, BunifuAnimatorNS.DecorationType.None)
        Me.BtnNotaCargoxFaltante.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnNotaCargoxFaltante.FlatAppearance.BorderSize = 0
        Me.BtnNotaCargoxFaltante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNotaCargoxFaltante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNotaCargoxFaltante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNotaCargoxFaltante.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnNotaCargoxFaltante.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNotaCargoxFaltante.ForeColor = System.Drawing.Color.White
        Me.BtnNotaCargoxFaltante.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnNotaCargoxFaltante.IconColor = System.Drawing.Color.White
        Me.BtnNotaCargoxFaltante.IconSize = 32
        Me.BtnNotaCargoxFaltante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNotaCargoxFaltante.Location = New System.Drawing.Point(0, 245)
        Me.BtnNotaCargoxFaltante.Name = "BtnNotaCargoxFaltante"
        Me.BtnNotaCargoxFaltante.Rotation = 0R
        Me.BtnNotaCargoxFaltante.Size = New System.Drawing.Size(235, 35)
        Me.BtnNotaCargoxFaltante.TabIndex = 8
        Me.BtnNotaCargoxFaltante.Text = "Nota de cargo por faltante"
        Me.BtnNotaCargoxFaltante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNotaCargoxFaltante.UseVisualStyleBackColor = False
        '
        'BtnNotasCredito
        '
        Me.BtnNotasCredito.BackColor = System.Drawing.Color.Transparent
        Me.BtnNotasCredito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnNotasCredito, BunifuAnimatorNS.DecorationType.None)
        Me.BtnNotasCredito.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnNotasCredito.FlatAppearance.BorderSize = 0
        Me.BtnNotasCredito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNotasCredito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNotasCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNotasCredito.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnNotasCredito.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNotasCredito.ForeColor = System.Drawing.Color.White
        Me.BtnNotasCredito.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnNotasCredito.IconColor = System.Drawing.Color.White
        Me.BtnNotasCredito.IconSize = 32
        Me.BtnNotasCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNotasCredito.Location = New System.Drawing.Point(0, 210)
        Me.BtnNotasCredito.Name = "BtnNotasCredito"
        Me.BtnNotasCredito.Rotation = 0R
        Me.BtnNotasCredito.Size = New System.Drawing.Size(235, 35)
        Me.BtnNotasCredito.TabIndex = 7
        Me.BtnNotasCredito.Text = "Notas de Credito"
        Me.BtnNotasCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNotasCredito.UseVisualStyleBackColor = False
        '
        'BtnProveedores
        '
        Me.BtnProveedores.BackColor = System.Drawing.Color.Transparent
        Me.BtnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnProveedores, BunifuAnimatorNS.DecorationType.None)
        Me.BtnProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProveedores.FlatAppearance.BorderSize = 0
        Me.BtnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProveedores.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnProveedores.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProveedores.ForeColor = System.Drawing.Color.White
        Me.BtnProveedores.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnProveedores.IconColor = System.Drawing.Color.White
        Me.BtnProveedores.IconSize = 32
        Me.BtnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProveedores.Location = New System.Drawing.Point(0, 175)
        Me.BtnProveedores.Name = "BtnProveedores"
        Me.BtnProveedores.Rotation = 0R
        Me.BtnProveedores.Size = New System.Drawing.Size(235, 35)
        Me.BtnProveedores.TabIndex = 6
        Me.BtnProveedores.Text = "Proveedores"
        Me.BtnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProveedores.UseVisualStyleBackColor = False
        '
        'BtnCatalogoPrecios
        '
        Me.BtnCatalogoPrecios.BackColor = System.Drawing.Color.Transparent
        Me.BtnCatalogoPrecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnCatalogoPrecios, BunifuAnimatorNS.DecorationType.None)
        Me.BtnCatalogoPrecios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCatalogoPrecios.FlatAppearance.BorderSize = 0
        Me.BtnCatalogoPrecios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCatalogoPrecios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCatalogoPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCatalogoPrecios.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnCatalogoPrecios.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCatalogoPrecios.ForeColor = System.Drawing.Color.White
        Me.BtnCatalogoPrecios.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnCatalogoPrecios.IconColor = System.Drawing.Color.White
        Me.BtnCatalogoPrecios.IconSize = 32
        Me.BtnCatalogoPrecios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCatalogoPrecios.Location = New System.Drawing.Point(0, 140)
        Me.BtnCatalogoPrecios.Name = "BtnCatalogoPrecios"
        Me.BtnCatalogoPrecios.Rotation = 0R
        Me.BtnCatalogoPrecios.Size = New System.Drawing.Size(235, 35)
        Me.BtnCatalogoPrecios.TabIndex = 5
        Me.BtnCatalogoPrecios.Text = "Catalogo de precios"
        Me.BtnCatalogoPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCatalogoPrecios.UseVisualStyleBackColor = False
        '
        'BtnAnalisisOrden
        '
        Me.BtnAnalisisOrden.BackColor = System.Drawing.Color.Transparent
        Me.BtnAnalisisOrden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnAnalisisOrden, BunifuAnimatorNS.DecorationType.None)
        Me.BtnAnalisisOrden.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAnalisisOrden.FlatAppearance.BorderSize = 0
        Me.BtnAnalisisOrden.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnAnalisisOrden.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAnalisisOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnalisisOrden.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnAnalisisOrden.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnalisisOrden.ForeColor = System.Drawing.Color.White
        Me.BtnAnalisisOrden.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnAnalisisOrden.IconColor = System.Drawing.Color.White
        Me.BtnAnalisisOrden.IconSize = 32
        Me.BtnAnalisisOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnalisisOrden.Location = New System.Drawing.Point(0, 105)
        Me.BtnAnalisisOrden.Name = "BtnAnalisisOrden"
        Me.BtnAnalisisOrden.Rotation = 0R
        Me.BtnAnalisisOrden.Size = New System.Drawing.Size(235, 35)
        Me.BtnAnalisisOrden.TabIndex = 4
        Me.BtnAnalisisOrden.Text = "Analisis Ordenes de Compra"
        Me.BtnAnalisisOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnalisisOrden.UseVisualStyleBackColor = False
        '
        'BtnContra_recibo
        '
        Me.BtnContra_recibo.BackColor = System.Drawing.Color.Transparent
        Me.BtnContra_recibo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnContra_recibo, BunifuAnimatorNS.DecorationType.None)
        Me.BtnContra_recibo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnContra_recibo.FlatAppearance.BorderSize = 0
        Me.BtnContra_recibo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnContra_recibo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnContra_recibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnContra_recibo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnContra_recibo.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContra_recibo.ForeColor = System.Drawing.Color.White
        Me.BtnContra_recibo.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnContra_recibo.IconColor = System.Drawing.Color.White
        Me.BtnContra_recibo.IconSize = 32
        Me.BtnContra_recibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnContra_recibo.Location = New System.Drawing.Point(0, 70)
        Me.BtnContra_recibo.Name = "BtnContra_recibo"
        Me.BtnContra_recibo.Rotation = 0R
        Me.BtnContra_recibo.Size = New System.Drawing.Size(235, 35)
        Me.BtnContra_recibo.TabIndex = 3
        Me.BtnContra_recibo.Text = "Contra-Recibos"
        Me.BtnContra_recibo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnContra_recibo.UseVisualStyleBackColor = False
        '
        'BtnOrdenCompra
        '
        Me.BtnOrdenCompra.BackColor = System.Drawing.Color.Transparent
        Me.BtnOrdenCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnOrdenCompra, BunifuAnimatorNS.DecorationType.None)
        Me.BtnOrdenCompra.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOrdenCompra.FlatAppearance.BorderSize = 0
        Me.BtnOrdenCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnOrdenCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOrdenCompra.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnOrdenCompra.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOrdenCompra.ForeColor = System.Drawing.Color.White
        Me.BtnOrdenCompra.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnOrdenCompra.IconColor = System.Drawing.Color.White
        Me.BtnOrdenCompra.IconSize = 32
        Me.BtnOrdenCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOrdenCompra.Location = New System.Drawing.Point(0, 35)
        Me.BtnOrdenCompra.Name = "BtnOrdenCompra"
        Me.BtnOrdenCompra.Rotation = 0R
        Me.BtnOrdenCompra.Size = New System.Drawing.Size(235, 35)
        Me.BtnOrdenCompra.TabIndex = 2
        Me.BtnOrdenCompra.Text = "Orden de compra"
        Me.BtnOrdenCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOrdenCompra.UseVisualStyleBackColor = False
        '
        'BtnComprasMenu
        '
        Me.BtnComprasMenu.BackColor = System.Drawing.Color.Transparent
        Me.BtnComprasMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnComprasMenu, BunifuAnimatorNS.DecorationType.None)
        Me.BtnComprasMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnComprasMenu.FlatAppearance.BorderSize = 0
        Me.BtnComprasMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnComprasMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnComprasMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnComprasMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnComprasMenu.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComprasMenu.ForeColor = System.Drawing.Color.White
        Me.BtnComprasMenu.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnComprasMenu.IconColor = System.Drawing.Color.White
        Me.BtnComprasMenu.IconSize = 32
        Me.BtnComprasMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnComprasMenu.Location = New System.Drawing.Point(0, 0)
        Me.BtnComprasMenu.Name = "BtnComprasMenu"
        Me.BtnComprasMenu.Rotation = 0R
        Me.BtnComprasMenu.Size = New System.Drawing.Size(235, 35)
        Me.BtnComprasMenu.TabIndex = 1
        Me.BtnComprasMenu.Text = "Compras"
        Me.BtnComprasMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnComprasMenu.UseVisualStyleBackColor = False
        '
        'BtnCompras
        '
        Me.BtnCompras.BackColor = System.Drawing.Color.Transparent
        Me.BtnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnCompras, BunifuAnimatorNS.DecorationType.None)
        Me.BtnCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCompras.FlatAppearance.BorderSize = 0
        Me.BtnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompras.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnCompras.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompras.ForeColor = System.Drawing.Color.White
        Me.BtnCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.BtnCompras.IconColor = System.Drawing.Color.White
        Me.BtnCompras.IconSize = 32
        Me.BtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCompras.Location = New System.Drawing.Point(0, 796)
        Me.BtnCompras.Name = "BtnCompras"
        Me.BtnCompras.Rotation = 0R
        Me.BtnCompras.Size = New System.Drawing.Size(235, 43)
        Me.BtnCompras.TabIndex = 13
        Me.BtnCompras.Text = "      Compras"
        Me.BtnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCompras.UseVisualStyleBackColor = False
        '
        'SubMenuAlmacen
        '
        Me.SubMenuAlmacen.BackgroundImage = CType(resources.GetObject("SubMenuAlmacen.BackgroundImage"), System.Drawing.Image)
        Me.SubMenuAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SubMenuAlmacen.Controls.Add(Me.BtnReporteador)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnConversiones)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnConceptos)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnNotificaciones)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnActualizacionInv)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnInvFisico)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnPedidoMercancia)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnTraspasosEAlmacenes)
        Me.SubMenuAlmacen.Controls.Add(Me.SalidaMercancia)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnEntradasMercancia)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnTablajeria)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnMinMax)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnProductosProcesados)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnEscalasPrecio)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnFamYDepartamentos)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnVerificadorProductos)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnActivacionPrecios)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnCatalogoProductos)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnProductos)
        Me.SubMenuAlmacen.Controls.Add(Me.BtnSucursalesYAlmacenes)
        Me.SubMenuTransition.SetDecoration(Me.SubMenuAlmacen, BunifuAnimatorNS.DecorationType.None)
        Me.SubMenuAlmacen.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuAlmacen.GradientBottomLeft = System.Drawing.Color.Teal
        Me.SubMenuAlmacen.GradientBottomRight = System.Drawing.Color.Teal
        Me.SubMenuAlmacen.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SubMenuAlmacen.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SubMenuAlmacen.Location = New System.Drawing.Point(0, 96)
        Me.SubMenuAlmacen.Name = "SubMenuAlmacen"
        Me.SubMenuAlmacen.Quality = 10
        Me.SubMenuAlmacen.Size = New System.Drawing.Size(235, 700)
        Me.SubMenuAlmacen.TabIndex = 11
        Me.SubMenuAlmacen.Visible = False
        '
        'BtnReporteador
        '
        Me.BtnReporteador.BackColor = System.Drawing.Color.Transparent
        Me.BtnReporteador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnReporteador, BunifuAnimatorNS.DecorationType.None)
        Me.BtnReporteador.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReporteador.FlatAppearance.BorderSize = 0
        Me.BtnReporteador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnReporteador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnReporteador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReporteador.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnReporteador.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporteador.ForeColor = System.Drawing.Color.White
        Me.BtnReporteador.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnReporteador.IconColor = System.Drawing.Color.White
        Me.BtnReporteador.IconSize = 32
        Me.BtnReporteador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReporteador.Location = New System.Drawing.Point(0, 665)
        Me.BtnReporteador.Name = "BtnReporteador"
        Me.BtnReporteador.Rotation = 0R
        Me.BtnReporteador.Size = New System.Drawing.Size(235, 35)
        Me.BtnReporteador.TabIndex = 34
        Me.BtnReporteador.Text = "Reporteador almacen"
        Me.BtnReporteador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReporteador.UseVisualStyleBackColor = False
        '
        'BtnConversiones
        '
        Me.BtnConversiones.BackColor = System.Drawing.Color.Transparent
        Me.BtnConversiones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnConversiones, BunifuAnimatorNS.DecorationType.None)
        Me.BtnConversiones.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnConversiones.FlatAppearance.BorderSize = 0
        Me.BtnConversiones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnConversiones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnConversiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConversiones.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnConversiones.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConversiones.ForeColor = System.Drawing.Color.White
        Me.BtnConversiones.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnConversiones.IconColor = System.Drawing.Color.White
        Me.BtnConversiones.IconSize = 32
        Me.BtnConversiones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConversiones.Location = New System.Drawing.Point(0, 630)
        Me.BtnConversiones.Name = "BtnConversiones"
        Me.BtnConversiones.Rotation = 0R
        Me.BtnConversiones.Size = New System.Drawing.Size(235, 35)
        Me.BtnConversiones.TabIndex = 33
        Me.BtnConversiones.Text = "Conversiones"
        Me.BtnConversiones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConversiones.UseVisualStyleBackColor = False
        '
        'BtnConceptos
        '
        Me.BtnConceptos.BackColor = System.Drawing.Color.Transparent
        Me.BtnConceptos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnConceptos, BunifuAnimatorNS.DecorationType.None)
        Me.BtnConceptos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnConceptos.FlatAppearance.BorderSize = 0
        Me.BtnConceptos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnConceptos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConceptos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnConceptos.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConceptos.ForeColor = System.Drawing.Color.White
        Me.BtnConceptos.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnConceptos.IconColor = System.Drawing.Color.White
        Me.BtnConceptos.IconSize = 32
        Me.BtnConceptos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConceptos.Location = New System.Drawing.Point(0, 595)
        Me.BtnConceptos.Name = "BtnConceptos"
        Me.BtnConceptos.Rotation = 0R
        Me.BtnConceptos.Size = New System.Drawing.Size(235, 35)
        Me.BtnConceptos.TabIndex = 32
        Me.BtnConceptos.Text = "Conceptos"
        Me.BtnConceptos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConceptos.UseVisualStyleBackColor = False
        '
        'BtnNotificaciones
        '
        Me.BtnNotificaciones.BackColor = System.Drawing.Color.Transparent
        Me.BtnNotificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnNotificaciones, BunifuAnimatorNS.DecorationType.None)
        Me.BtnNotificaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnNotificaciones.FlatAppearance.BorderSize = 0
        Me.BtnNotificaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNotificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNotificaciones.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnNotificaciones.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNotificaciones.ForeColor = System.Drawing.Color.White
        Me.BtnNotificaciones.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnNotificaciones.IconColor = System.Drawing.Color.White
        Me.BtnNotificaciones.IconSize = 32
        Me.BtnNotificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNotificaciones.Location = New System.Drawing.Point(0, 560)
        Me.BtnNotificaciones.Name = "BtnNotificaciones"
        Me.BtnNotificaciones.Rotation = 0R
        Me.BtnNotificaciones.Size = New System.Drawing.Size(235, 35)
        Me.BtnNotificaciones.TabIndex = 31
        Me.BtnNotificaciones.Text = "Notificaciones"
        Me.BtnNotificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNotificaciones.UseVisualStyleBackColor = False
        '
        'BtnActualizacionInv
        '
        Me.BtnActualizacionInv.BackColor = System.Drawing.Color.Transparent
        Me.BtnActualizacionInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnActualizacionInv, BunifuAnimatorNS.DecorationType.None)
        Me.BtnActualizacionInv.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnActualizacionInv.FlatAppearance.BorderSize = 0
        Me.BtnActualizacionInv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnActualizacionInv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnActualizacionInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizacionInv.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnActualizacionInv.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizacionInv.ForeColor = System.Drawing.Color.White
        Me.BtnActualizacionInv.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnActualizacionInv.IconColor = System.Drawing.Color.White
        Me.BtnActualizacionInv.IconSize = 32
        Me.BtnActualizacionInv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizacionInv.Location = New System.Drawing.Point(0, 525)
        Me.BtnActualizacionInv.Name = "BtnActualizacionInv"
        Me.BtnActualizacionInv.Rotation = 0R
        Me.BtnActualizacionInv.Size = New System.Drawing.Size(235, 35)
        Me.BtnActualizacionInv.TabIndex = 30
        Me.BtnActualizacionInv.Text = "Actualizacion de Inventario"
        Me.BtnActualizacionInv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizacionInv.UseVisualStyleBackColor = False
        '
        'BtnInvFisico
        '
        Me.BtnInvFisico.BackColor = System.Drawing.Color.Transparent
        Me.BtnInvFisico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnInvFisico, BunifuAnimatorNS.DecorationType.None)
        Me.BtnInvFisico.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnInvFisico.FlatAppearance.BorderSize = 0
        Me.BtnInvFisico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnInvFisico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnInvFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInvFisico.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnInvFisico.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvFisico.ForeColor = System.Drawing.Color.White
        Me.BtnInvFisico.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnInvFisico.IconColor = System.Drawing.Color.White
        Me.BtnInvFisico.IconSize = 32
        Me.BtnInvFisico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInvFisico.Location = New System.Drawing.Point(0, 490)
        Me.BtnInvFisico.Name = "BtnInvFisico"
        Me.BtnInvFisico.Rotation = 0R
        Me.BtnInvFisico.Size = New System.Drawing.Size(235, 35)
        Me.BtnInvFisico.TabIndex = 28
        Me.BtnInvFisico.Text = "Inventario Fisico"
        Me.BtnInvFisico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInvFisico.UseVisualStyleBackColor = False
        '
        'BtnPedidoMercancia
        '
        Me.BtnPedidoMercancia.BackColor = System.Drawing.Color.Transparent
        Me.BtnPedidoMercancia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnPedidoMercancia, BunifuAnimatorNS.DecorationType.None)
        Me.BtnPedidoMercancia.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPedidoMercancia.FlatAppearance.BorderSize = 0
        Me.BtnPedidoMercancia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnPedidoMercancia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnPedidoMercancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPedidoMercancia.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnPedidoMercancia.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPedidoMercancia.ForeColor = System.Drawing.Color.White
        Me.BtnPedidoMercancia.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnPedidoMercancia.IconColor = System.Drawing.Color.White
        Me.BtnPedidoMercancia.IconSize = 32
        Me.BtnPedidoMercancia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPedidoMercancia.Location = New System.Drawing.Point(0, 455)
        Me.BtnPedidoMercancia.Name = "BtnPedidoMercancia"
        Me.BtnPedidoMercancia.Rotation = 0R
        Me.BtnPedidoMercancia.Size = New System.Drawing.Size(235, 35)
        Me.BtnPedidoMercancia.TabIndex = 27
        Me.BtnPedidoMercancia.Text = "Pedido de mercancia"
        Me.BtnPedidoMercancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPedidoMercancia.UseVisualStyleBackColor = False
        '
        'BtnTraspasosEAlmacenes
        '
        Me.BtnTraspasosEAlmacenes.BackColor = System.Drawing.Color.Transparent
        Me.BtnTraspasosEAlmacenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnTraspasosEAlmacenes, BunifuAnimatorNS.DecorationType.None)
        Me.BtnTraspasosEAlmacenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTraspasosEAlmacenes.FlatAppearance.BorderSize = 0
        Me.BtnTraspasosEAlmacenes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnTraspasosEAlmacenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnTraspasosEAlmacenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTraspasosEAlmacenes.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnTraspasosEAlmacenes.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTraspasosEAlmacenes.ForeColor = System.Drawing.Color.White
        Me.BtnTraspasosEAlmacenes.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnTraspasosEAlmacenes.IconColor = System.Drawing.Color.White
        Me.BtnTraspasosEAlmacenes.IconSize = 32
        Me.BtnTraspasosEAlmacenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTraspasosEAlmacenes.Location = New System.Drawing.Point(0, 420)
        Me.BtnTraspasosEAlmacenes.Name = "BtnTraspasosEAlmacenes"
        Me.BtnTraspasosEAlmacenes.Rotation = 0R
        Me.BtnTraspasosEAlmacenes.Size = New System.Drawing.Size(235, 35)
        Me.BtnTraspasosEAlmacenes.TabIndex = 26
        Me.BtnTraspasosEAlmacenes.Text = "Traspaso entre almacenes "
        Me.BtnTraspasosEAlmacenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTraspasosEAlmacenes.UseVisualStyleBackColor = False
        '
        'SalidaMercancia
        '
        Me.SalidaMercancia.BackColor = System.Drawing.Color.Transparent
        Me.SalidaMercancia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.SalidaMercancia, BunifuAnimatorNS.DecorationType.None)
        Me.SalidaMercancia.Dock = System.Windows.Forms.DockStyle.Top
        Me.SalidaMercancia.FlatAppearance.BorderSize = 0
        Me.SalidaMercancia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.SalidaMercancia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.SalidaMercancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalidaMercancia.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.SalidaMercancia.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalidaMercancia.ForeColor = System.Drawing.Color.White
        Me.SalidaMercancia.IconChar = FontAwesome.Sharp.IconChar.None
        Me.SalidaMercancia.IconColor = System.Drawing.Color.White
        Me.SalidaMercancia.IconSize = 32
        Me.SalidaMercancia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SalidaMercancia.Location = New System.Drawing.Point(0, 385)
        Me.SalidaMercancia.Name = "SalidaMercancia"
        Me.SalidaMercancia.Rotation = 0R
        Me.SalidaMercancia.Size = New System.Drawing.Size(235, 35)
        Me.SalidaMercancia.TabIndex = 25
        Me.SalidaMercancia.Text = "Salida de mercancia"
        Me.SalidaMercancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SalidaMercancia.UseVisualStyleBackColor = False
        '
        'BtnEntradasMercancia
        '
        Me.BtnEntradasMercancia.BackColor = System.Drawing.Color.Transparent
        Me.BtnEntradasMercancia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnEntradasMercancia, BunifuAnimatorNS.DecorationType.None)
        Me.BtnEntradasMercancia.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEntradasMercancia.FlatAppearance.BorderSize = 0
        Me.BtnEntradasMercancia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEntradasMercancia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEntradasMercancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntradasMercancia.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnEntradasMercancia.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntradasMercancia.ForeColor = System.Drawing.Color.White
        Me.BtnEntradasMercancia.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnEntradasMercancia.IconColor = System.Drawing.Color.White
        Me.BtnEntradasMercancia.IconSize = 32
        Me.BtnEntradasMercancia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEntradasMercancia.Location = New System.Drawing.Point(0, 350)
        Me.BtnEntradasMercancia.Name = "BtnEntradasMercancia"
        Me.BtnEntradasMercancia.Rotation = 0R
        Me.BtnEntradasMercancia.Size = New System.Drawing.Size(235, 35)
        Me.BtnEntradasMercancia.TabIndex = 24
        Me.BtnEntradasMercancia.Text = "Entrada de mercancia"
        Me.BtnEntradasMercancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEntradasMercancia.UseVisualStyleBackColor = False
        '
        'BtnTablajeria
        '
        Me.BtnTablajeria.BackColor = System.Drawing.Color.Transparent
        Me.BtnTablajeria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnTablajeria, BunifuAnimatorNS.DecorationType.None)
        Me.BtnTablajeria.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTablajeria.FlatAppearance.BorderSize = 0
        Me.BtnTablajeria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnTablajeria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnTablajeria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTablajeria.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnTablajeria.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTablajeria.ForeColor = System.Drawing.Color.White
        Me.BtnTablajeria.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnTablajeria.IconColor = System.Drawing.Color.White
        Me.BtnTablajeria.IconSize = 32
        Me.BtnTablajeria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTablajeria.Location = New System.Drawing.Point(0, 315)
        Me.BtnTablajeria.Name = "BtnTablajeria"
        Me.BtnTablajeria.Rotation = 0R
        Me.BtnTablajeria.Size = New System.Drawing.Size(235, 35)
        Me.BtnTablajeria.TabIndex = 23
        Me.BtnTablajeria.Text = "Tablajeria"
        Me.BtnTablajeria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTablajeria.UseVisualStyleBackColor = False
        '
        'BtnMinMax
        '
        Me.BtnMinMax.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnMinMax, BunifuAnimatorNS.DecorationType.None)
        Me.BtnMinMax.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMinMax.FlatAppearance.BorderSize = 0
        Me.BtnMinMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnMinMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnMinMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinMax.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnMinMax.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinMax.ForeColor = System.Drawing.Color.White
        Me.BtnMinMax.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnMinMax.IconColor = System.Drawing.Color.White
        Me.BtnMinMax.IconSize = 32
        Me.BtnMinMax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMinMax.Location = New System.Drawing.Point(0, 280)
        Me.BtnMinMax.Name = "BtnMinMax"
        Me.BtnMinMax.Rotation = 0R
        Me.BtnMinMax.Size = New System.Drawing.Size(235, 35)
        Me.BtnMinMax.TabIndex = 22
        Me.BtnMinMax.Text = "Minimos y maximos"
        Me.BtnMinMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMinMax.UseVisualStyleBackColor = False
        '
        'BtnProductosProcesados
        '
        Me.BtnProductosProcesados.BackColor = System.Drawing.Color.Transparent
        Me.BtnProductosProcesados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnProductosProcesados, BunifuAnimatorNS.DecorationType.None)
        Me.BtnProductosProcesados.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProductosProcesados.FlatAppearance.BorderSize = 0
        Me.BtnProductosProcesados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnProductosProcesados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnProductosProcesados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductosProcesados.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnProductosProcesados.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductosProcesados.ForeColor = System.Drawing.Color.White
        Me.BtnProductosProcesados.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnProductosProcesados.IconColor = System.Drawing.Color.White
        Me.BtnProductosProcesados.IconSize = 32
        Me.BtnProductosProcesados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProductosProcesados.Location = New System.Drawing.Point(0, 245)
        Me.BtnProductosProcesados.Name = "BtnProductosProcesados"
        Me.BtnProductosProcesados.Rotation = 0R
        Me.BtnProductosProcesados.Size = New System.Drawing.Size(235, 35)
        Me.BtnProductosProcesados.TabIndex = 21
        Me.BtnProductosProcesados.Text = "Productos procesados"
        Me.BtnProductosProcesados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProductosProcesados.UseVisualStyleBackColor = False
        '
        'BtnEscalasPrecio
        '
        Me.BtnEscalasPrecio.BackColor = System.Drawing.Color.Transparent
        Me.BtnEscalasPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnEscalasPrecio, BunifuAnimatorNS.DecorationType.None)
        Me.BtnEscalasPrecio.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEscalasPrecio.FlatAppearance.BorderSize = 0
        Me.BtnEscalasPrecio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEscalasPrecio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEscalasPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEscalasPrecio.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnEscalasPrecio.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEscalasPrecio.ForeColor = System.Drawing.Color.White
        Me.BtnEscalasPrecio.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnEscalasPrecio.IconColor = System.Drawing.Color.White
        Me.BtnEscalasPrecio.IconSize = 32
        Me.BtnEscalasPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEscalasPrecio.Location = New System.Drawing.Point(0, 210)
        Me.BtnEscalasPrecio.Name = "BtnEscalasPrecio"
        Me.BtnEscalasPrecio.Rotation = 0R
        Me.BtnEscalasPrecio.Size = New System.Drawing.Size(235, 35)
        Me.BtnEscalasPrecio.TabIndex = 20
        Me.BtnEscalasPrecio.Text = "Escalas de precio"
        Me.BtnEscalasPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEscalasPrecio.UseVisualStyleBackColor = False
        '
        'BtnFamYDepartamentos
        '
        Me.BtnFamYDepartamentos.BackColor = System.Drawing.Color.Transparent
        Me.BtnFamYDepartamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnFamYDepartamentos, BunifuAnimatorNS.DecorationType.None)
        Me.BtnFamYDepartamentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnFamYDepartamentos.FlatAppearance.BorderSize = 0
        Me.BtnFamYDepartamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnFamYDepartamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnFamYDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFamYDepartamentos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnFamYDepartamentos.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFamYDepartamentos.ForeColor = System.Drawing.Color.White
        Me.BtnFamYDepartamentos.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnFamYDepartamentos.IconColor = System.Drawing.Color.White
        Me.BtnFamYDepartamentos.IconSize = 32
        Me.BtnFamYDepartamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFamYDepartamentos.Location = New System.Drawing.Point(0, 175)
        Me.BtnFamYDepartamentos.Name = "BtnFamYDepartamentos"
        Me.BtnFamYDepartamentos.Rotation = 0R
        Me.BtnFamYDepartamentos.Size = New System.Drawing.Size(235, 35)
        Me.BtnFamYDepartamentos.TabIndex = 19
        Me.BtnFamYDepartamentos.Text = "Familias y departamentos"
        Me.BtnFamYDepartamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFamYDepartamentos.UseVisualStyleBackColor = False
        '
        'BtnVerificadorProductos
        '
        Me.BtnVerificadorProductos.BackColor = System.Drawing.Color.Transparent
        Me.BtnVerificadorProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnVerificadorProductos, BunifuAnimatorNS.DecorationType.None)
        Me.BtnVerificadorProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVerificadorProductos.FlatAppearance.BorderSize = 0
        Me.BtnVerificadorProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnVerificadorProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnVerificadorProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerificadorProductos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnVerificadorProductos.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerificadorProductos.ForeColor = System.Drawing.Color.White
        Me.BtnVerificadorProductos.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnVerificadorProductos.IconColor = System.Drawing.Color.White
        Me.BtnVerificadorProductos.IconSize = 32
        Me.BtnVerificadorProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVerificadorProductos.Location = New System.Drawing.Point(0, 140)
        Me.BtnVerificadorProductos.Name = "BtnVerificadorProductos"
        Me.BtnVerificadorProductos.Rotation = 0R
        Me.BtnVerificadorProductos.Size = New System.Drawing.Size(235, 35)
        Me.BtnVerificadorProductos.TabIndex = 18
        Me.BtnVerificadorProductos.Text = "Verificador de productos"
        Me.BtnVerificadorProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVerificadorProductos.UseVisualStyleBackColor = False
        '
        'BtnActivacionPrecios
        '
        Me.BtnActivacionPrecios.BackColor = System.Drawing.Color.Transparent
        Me.BtnActivacionPrecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnActivacionPrecios, BunifuAnimatorNS.DecorationType.None)
        Me.BtnActivacionPrecios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnActivacionPrecios.FlatAppearance.BorderSize = 0
        Me.BtnActivacionPrecios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnActivacionPrecios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnActivacionPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActivacionPrecios.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnActivacionPrecios.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActivacionPrecios.ForeColor = System.Drawing.Color.White
        Me.BtnActivacionPrecios.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnActivacionPrecios.IconColor = System.Drawing.Color.White
        Me.BtnActivacionPrecios.IconSize = 32
        Me.BtnActivacionPrecios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActivacionPrecios.Location = New System.Drawing.Point(0, 105)
        Me.BtnActivacionPrecios.Name = "BtnActivacionPrecios"
        Me.BtnActivacionPrecios.Rotation = 0R
        Me.BtnActivacionPrecios.Size = New System.Drawing.Size(235, 35)
        Me.BtnActivacionPrecios.TabIndex = 17
        Me.BtnActivacionPrecios.Text = "Activacion de precios"
        Me.BtnActivacionPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActivacionPrecios.UseVisualStyleBackColor = False
        '
        'BtnCatalogoProductos
        '
        Me.BtnCatalogoProductos.BackColor = System.Drawing.Color.Transparent
        Me.BtnCatalogoProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnCatalogoProductos, BunifuAnimatorNS.DecorationType.None)
        Me.BtnCatalogoProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCatalogoProductos.FlatAppearance.BorderSize = 0
        Me.BtnCatalogoProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCatalogoProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCatalogoProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCatalogoProductos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnCatalogoProductos.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCatalogoProductos.ForeColor = System.Drawing.Color.White
        Me.BtnCatalogoProductos.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnCatalogoProductos.IconColor = System.Drawing.Color.White
        Me.BtnCatalogoProductos.IconSize = 32
        Me.BtnCatalogoProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCatalogoProductos.Location = New System.Drawing.Point(0, 70)
        Me.BtnCatalogoProductos.Name = "BtnCatalogoProductos"
        Me.BtnCatalogoProductos.Rotation = 0R
        Me.BtnCatalogoProductos.Size = New System.Drawing.Size(235, 35)
        Me.BtnCatalogoProductos.TabIndex = 16
        Me.BtnCatalogoProductos.Text = "Catalogo de productos"
        Me.BtnCatalogoProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCatalogoProductos.UseVisualStyleBackColor = False
        '
        'BtnProductos
        '
        Me.BtnProductos.BackColor = System.Drawing.Color.Transparent
        Me.BtnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnProductos, BunifuAnimatorNS.DecorationType.None)
        Me.BtnProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProductos.FlatAppearance.BorderSize = 0
        Me.BtnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnProductos.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductos.ForeColor = System.Drawing.Color.White
        Me.BtnProductos.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnProductos.IconColor = System.Drawing.Color.White
        Me.BtnProductos.IconSize = 32
        Me.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProductos.Location = New System.Drawing.Point(0, 35)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Rotation = 0R
        Me.BtnProductos.Size = New System.Drawing.Size(235, 35)
        Me.BtnProductos.TabIndex = 15
        Me.BtnProductos.Text = "Productos"
        Me.BtnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProductos.UseVisualStyleBackColor = False
        '
        'BtnSucursalesYAlmacenes
        '
        Me.BtnSucursalesYAlmacenes.BackColor = System.Drawing.Color.Transparent
        Me.BtnSucursalesYAlmacenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnSucursalesYAlmacenes, BunifuAnimatorNS.DecorationType.None)
        Me.BtnSucursalesYAlmacenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSucursalesYAlmacenes.FlatAppearance.BorderSize = 0
        Me.BtnSucursalesYAlmacenes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSucursalesYAlmacenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSucursalesYAlmacenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSucursalesYAlmacenes.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnSucursalesYAlmacenes.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSucursalesYAlmacenes.ForeColor = System.Drawing.Color.White
        Me.BtnSucursalesYAlmacenes.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnSucursalesYAlmacenes.IconColor = System.Drawing.Color.White
        Me.BtnSucursalesYAlmacenes.IconSize = 32
        Me.BtnSucursalesYAlmacenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSucursalesYAlmacenes.Location = New System.Drawing.Point(0, 0)
        Me.BtnSucursalesYAlmacenes.Name = "BtnSucursalesYAlmacenes"
        Me.BtnSucursalesYAlmacenes.Rotation = 0R
        Me.BtnSucursalesYAlmacenes.Size = New System.Drawing.Size(235, 35)
        Me.BtnSucursalesYAlmacenes.TabIndex = 14
        Me.BtnSucursalesYAlmacenes.Text = "Sucursales y almacenes"
        Me.BtnSucursalesYAlmacenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSucursalesYAlmacenes.UseVisualStyleBackColor = False
        '
        'BtnAlmacen
        '
        Me.BtnAlmacen.BackColor = System.Drawing.Color.Transparent
        Me.BtnAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnAlmacen, BunifuAnimatorNS.DecorationType.None)
        Me.BtnAlmacen.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAlmacen.FlatAppearance.BorderSize = 0
        Me.BtnAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlmacen.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnAlmacen.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlmacen.ForeColor = System.Drawing.Color.White
        Me.BtnAlmacen.IconChar = FontAwesome.Sharp.IconChar.Warehouse
        Me.BtnAlmacen.IconColor = System.Drawing.Color.White
        Me.BtnAlmacen.IconSize = 32
        Me.BtnAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAlmacen.Location = New System.Drawing.Point(0, 53)
        Me.BtnAlmacen.Name = "BtnAlmacen"
        Me.BtnAlmacen.Rotation = 0R
        Me.BtnAlmacen.Size = New System.Drawing.Size(235, 43)
        Me.BtnAlmacen.TabIndex = 10
        Me.BtnAlmacen.Text = "      ALMACEN"
        Me.BtnAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAlmacen.UseVisualStyleBackColor = False
        '
        'SubMenuVentas
        '
        Me.SubMenuVentas.BackgroundImage = CType(resources.GetObject("SubMenuVentas.BackgroundImage"), System.Drawing.Image)
        Me.SubMenuVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SubMenuVentas.Controls.Add(Me.BtnReporteadorCredCobranza)
        Me.SubMenuVentas.Controls.Add(Me.BtnReporteadorRutas)
        Me.SubMenuVentas.Controls.Add(Me.BtnCobranza)
        Me.SubMenuVentas.Controls.Add(Me.BtnDocumentosClientes)
        Me.SubMenuVentas.Controls.Add(Me.BtnLiberarCheques)
        Me.SubMenuVentas.Controls.Add(Me.BtnClientes)
        Me.SubMenuVentas.Controls.Add(Me.BtnVerOfertas)
        Me.SubMenuVentas.Controls.Add(Me.BtnCrearOfertas)
        Me.SubMenuVentas.Controls.Add(Me.BtnOfertas)
        Me.SubMenuVentas.Controls.Add(Me.BtnRuta_Cliente)
        Me.SubMenuVentas.Controls.Add(Me.BtnVendedores)
        Me.SubMenuVentas.Controls.Add(Me.BtnFacComandas)
        Me.SubMenuVentas.Controls.Add(Me.BtnFacRutas)
        Me.SubMenuTransition.SetDecoration(Me.SubMenuVentas, BunifuAnimatorNS.DecorationType.None)
        Me.SubMenuVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuVentas.GradientBottomLeft = System.Drawing.Color.Teal
        Me.SubMenuVentas.GradientBottomRight = System.Drawing.Color.Teal
        Me.SubMenuVentas.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SubMenuVentas.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SubMenuVentas.Location = New System.Drawing.Point(0, 43)
        Me.SubMenuVentas.Name = "SubMenuVentas"
        Me.SubMenuVentas.Quality = 10
        Me.SubMenuVentas.Size = New System.Drawing.Size(235, 10)
        Me.SubMenuVentas.TabIndex = 3
        Me.SubMenuVentas.Visible = False
        '
        'BtnReporteadorCredCobranza
        '
        Me.BtnReporteadorCredCobranza.BackColor = System.Drawing.Color.Transparent
        Me.BtnReporteadorCredCobranza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnReporteadorCredCobranza, BunifuAnimatorNS.DecorationType.None)
        Me.BtnReporteadorCredCobranza.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReporteadorCredCobranza.FlatAppearance.BorderSize = 0
        Me.BtnReporteadorCredCobranza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnReporteadorCredCobranza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnReporteadorCredCobranza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReporteadorCredCobranza.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnReporteadorCredCobranza.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporteadorCredCobranza.ForeColor = System.Drawing.Color.White
        Me.BtnReporteadorCredCobranza.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnReporteadorCredCobranza.IconColor = System.Drawing.Color.White
        Me.BtnReporteadorCredCobranza.IconSize = 32
        Me.BtnReporteadorCredCobranza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReporteadorCredCobranza.Location = New System.Drawing.Point(0, 420)
        Me.BtnReporteadorCredCobranza.Name = "BtnReporteadorCredCobranza"
        Me.BtnReporteadorCredCobranza.Rotation = 0R
        Me.BtnReporteadorCredCobranza.Size = New System.Drawing.Size(235, 35)
        Me.BtnReporteadorCredCobranza.TabIndex = 13
        Me.BtnReporteadorCredCobranza.Text = "Reporteador de credito y cobranza"
        Me.BtnReporteadorCredCobranza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReporteadorCredCobranza.UseVisualStyleBackColor = False
        '
        'BtnReporteadorRutas
        '
        Me.BtnReporteadorRutas.BackColor = System.Drawing.Color.Transparent
        Me.BtnReporteadorRutas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnReporteadorRutas, BunifuAnimatorNS.DecorationType.None)
        Me.BtnReporteadorRutas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReporteadorRutas.FlatAppearance.BorderSize = 0
        Me.BtnReporteadorRutas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnReporteadorRutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnReporteadorRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReporteadorRutas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnReporteadorRutas.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporteadorRutas.ForeColor = System.Drawing.Color.White
        Me.BtnReporteadorRutas.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnReporteadorRutas.IconColor = System.Drawing.Color.White
        Me.BtnReporteadorRutas.IconSize = 32
        Me.BtnReporteadorRutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReporteadorRutas.Location = New System.Drawing.Point(0, 385)
        Me.BtnReporteadorRutas.Name = "BtnReporteadorRutas"
        Me.BtnReporteadorRutas.Rotation = 0R
        Me.BtnReporteadorRutas.Size = New System.Drawing.Size(235, 35)
        Me.BtnReporteadorRutas.TabIndex = 12
        Me.BtnReporteadorRutas.Text = "Reporteador de rutas"
        Me.BtnReporteadorRutas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReporteadorRutas.UseVisualStyleBackColor = False
        '
        'BtnCobranza
        '
        Me.BtnCobranza.BackColor = System.Drawing.Color.Transparent
        Me.BtnCobranza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnCobranza, BunifuAnimatorNS.DecorationType.None)
        Me.BtnCobranza.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCobranza.FlatAppearance.BorderSize = 0
        Me.BtnCobranza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCobranza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCobranza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCobranza.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnCobranza.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCobranza.ForeColor = System.Drawing.Color.White
        Me.BtnCobranza.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnCobranza.IconColor = System.Drawing.Color.White
        Me.BtnCobranza.IconSize = 32
        Me.BtnCobranza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCobranza.Location = New System.Drawing.Point(0, 350)
        Me.BtnCobranza.Name = "BtnCobranza"
        Me.BtnCobranza.Rotation = 0R
        Me.BtnCobranza.Size = New System.Drawing.Size(235, 35)
        Me.BtnCobranza.TabIndex = 11
        Me.BtnCobranza.Text = "Cobranza"
        Me.BtnCobranza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCobranza.UseVisualStyleBackColor = False
        '
        'BtnDocumentosClientes
        '
        Me.BtnDocumentosClientes.BackColor = System.Drawing.Color.Transparent
        Me.BtnDocumentosClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnDocumentosClientes, BunifuAnimatorNS.DecorationType.None)
        Me.BtnDocumentosClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDocumentosClientes.FlatAppearance.BorderSize = 0
        Me.BtnDocumentosClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnDocumentosClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnDocumentosClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDocumentosClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnDocumentosClientes.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDocumentosClientes.ForeColor = System.Drawing.Color.White
        Me.BtnDocumentosClientes.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnDocumentosClientes.IconColor = System.Drawing.Color.White
        Me.BtnDocumentosClientes.IconSize = 32
        Me.BtnDocumentosClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDocumentosClientes.Location = New System.Drawing.Point(0, 315)
        Me.BtnDocumentosClientes.Name = "BtnDocumentosClientes"
        Me.BtnDocumentosClientes.Rotation = 0R
        Me.BtnDocumentosClientes.Size = New System.Drawing.Size(235, 35)
        Me.BtnDocumentosClientes.TabIndex = 10
        Me.BtnDocumentosClientes.Text = "Documentos a clientes"
        Me.BtnDocumentosClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDocumentosClientes.UseVisualStyleBackColor = False
        '
        'BtnLiberarCheques
        '
        Me.BtnLiberarCheques.BackColor = System.Drawing.Color.Transparent
        Me.BtnLiberarCheques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnLiberarCheques, BunifuAnimatorNS.DecorationType.None)
        Me.BtnLiberarCheques.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLiberarCheques.FlatAppearance.BorderSize = 0
        Me.BtnLiberarCheques.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnLiberarCheques.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnLiberarCheques.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLiberarCheques.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnLiberarCheques.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLiberarCheques.ForeColor = System.Drawing.Color.White
        Me.BtnLiberarCheques.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnLiberarCheques.IconColor = System.Drawing.Color.White
        Me.BtnLiberarCheques.IconSize = 32
        Me.BtnLiberarCheques.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLiberarCheques.Location = New System.Drawing.Point(0, 280)
        Me.BtnLiberarCheques.Name = "BtnLiberarCheques"
        Me.BtnLiberarCheques.Rotation = 0R
        Me.BtnLiberarCheques.Size = New System.Drawing.Size(235, 35)
        Me.BtnLiberarCheques.TabIndex = 9
        Me.BtnLiberarCheques.Text = "Liberar cheques"
        Me.BtnLiberarCheques.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLiberarCheques.UseVisualStyleBackColor = False
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.Transparent
        Me.BtnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnClientes, BunifuAnimatorNS.DecorationType.None)
        Me.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnClientes.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.ForeColor = System.Drawing.Color.White
        Me.BtnClientes.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnClientes.IconColor = System.Drawing.Color.White
        Me.BtnClientes.IconSize = 32
        Me.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClientes.Location = New System.Drawing.Point(0, 245)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Rotation = 0R
        Me.BtnClientes.Size = New System.Drawing.Size(235, 35)
        Me.BtnClientes.TabIndex = 8
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'BtnVerOfertas
        '
        Me.BtnVerOfertas.BackColor = System.Drawing.Color.Transparent
        Me.BtnVerOfertas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnVerOfertas, BunifuAnimatorNS.DecorationType.None)
        Me.BtnVerOfertas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVerOfertas.FlatAppearance.BorderSize = 0
        Me.BtnVerOfertas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnVerOfertas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnVerOfertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerOfertas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnVerOfertas.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerOfertas.ForeColor = System.Drawing.Color.White
        Me.BtnVerOfertas.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnVerOfertas.IconColor = System.Drawing.Color.White
        Me.BtnVerOfertas.IconSize = 32
        Me.BtnVerOfertas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVerOfertas.Location = New System.Drawing.Point(0, 210)
        Me.BtnVerOfertas.Name = "BtnVerOfertas"
        Me.BtnVerOfertas.Rotation = 0R
        Me.BtnVerOfertas.Size = New System.Drawing.Size(235, 35)
        Me.BtnVerOfertas.TabIndex = 7
        Me.BtnVerOfertas.Text = "Ver ofertas"
        Me.BtnVerOfertas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVerOfertas.UseVisualStyleBackColor = False
        '
        'BtnCrearOfertas
        '
        Me.BtnCrearOfertas.BackColor = System.Drawing.Color.Transparent
        Me.BtnCrearOfertas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnCrearOfertas, BunifuAnimatorNS.DecorationType.None)
        Me.BtnCrearOfertas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCrearOfertas.FlatAppearance.BorderSize = 0
        Me.BtnCrearOfertas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCrearOfertas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCrearOfertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCrearOfertas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnCrearOfertas.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrearOfertas.ForeColor = System.Drawing.Color.White
        Me.BtnCrearOfertas.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnCrearOfertas.IconColor = System.Drawing.Color.White
        Me.BtnCrearOfertas.IconSize = 32
        Me.BtnCrearOfertas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrearOfertas.Location = New System.Drawing.Point(0, 175)
        Me.BtnCrearOfertas.Name = "BtnCrearOfertas"
        Me.BtnCrearOfertas.Rotation = 0R
        Me.BtnCrearOfertas.Size = New System.Drawing.Size(235, 35)
        Me.BtnCrearOfertas.TabIndex = 6
        Me.BtnCrearOfertas.Text = "Crear ofertas"
        Me.BtnCrearOfertas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrearOfertas.UseVisualStyleBackColor = False
        '
        'BtnOfertas
        '
        Me.BtnOfertas.BackColor = System.Drawing.Color.Transparent
        Me.BtnOfertas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnOfertas, BunifuAnimatorNS.DecorationType.None)
        Me.BtnOfertas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOfertas.FlatAppearance.BorderSize = 0
        Me.BtnOfertas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnOfertas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnOfertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOfertas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnOfertas.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOfertas.ForeColor = System.Drawing.Color.White
        Me.BtnOfertas.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnOfertas.IconColor = System.Drawing.Color.White
        Me.BtnOfertas.IconSize = 32
        Me.BtnOfertas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOfertas.Location = New System.Drawing.Point(0, 140)
        Me.BtnOfertas.Name = "BtnOfertas"
        Me.BtnOfertas.Rotation = 0R
        Me.BtnOfertas.Size = New System.Drawing.Size(235, 35)
        Me.BtnOfertas.TabIndex = 5
        Me.BtnOfertas.Text = "Ofertas"
        Me.BtnOfertas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOfertas.UseVisualStyleBackColor = False
        '
        'BtnRuta_Cliente
        '
        Me.BtnRuta_Cliente.BackColor = System.Drawing.Color.Transparent
        Me.BtnRuta_Cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnRuta_Cliente, BunifuAnimatorNS.DecorationType.None)
        Me.BtnRuta_Cliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRuta_Cliente.FlatAppearance.BorderSize = 0
        Me.BtnRuta_Cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnRuta_Cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnRuta_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRuta_Cliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnRuta_Cliente.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRuta_Cliente.ForeColor = System.Drawing.Color.White
        Me.BtnRuta_Cliente.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnRuta_Cliente.IconColor = System.Drawing.Color.White
        Me.BtnRuta_Cliente.IconSize = 32
        Me.BtnRuta_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRuta_Cliente.Location = New System.Drawing.Point(0, 105)
        Me.BtnRuta_Cliente.Name = "BtnRuta_Cliente"
        Me.BtnRuta_Cliente.Rotation = 0R
        Me.BtnRuta_Cliente.Size = New System.Drawing.Size(235, 35)
        Me.BtnRuta_Cliente.TabIndex = 4
        Me.BtnRuta_Cliente.Text = "Ruta-Cliente"
        Me.BtnRuta_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRuta_Cliente.UseVisualStyleBackColor = False
        '
        'BtnVendedores
        '
        Me.BtnVendedores.BackColor = System.Drawing.Color.Transparent
        Me.BtnVendedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnVendedores, BunifuAnimatorNS.DecorationType.None)
        Me.BtnVendedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVendedores.FlatAppearance.BorderSize = 0
        Me.BtnVendedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnVendedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVendedores.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnVendedores.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVendedores.ForeColor = System.Drawing.Color.White
        Me.BtnVendedores.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnVendedores.IconColor = System.Drawing.Color.White
        Me.BtnVendedores.IconSize = 32
        Me.BtnVendedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVendedores.Location = New System.Drawing.Point(0, 70)
        Me.BtnVendedores.Name = "BtnVendedores"
        Me.BtnVendedores.Rotation = 0R
        Me.BtnVendedores.Size = New System.Drawing.Size(235, 35)
        Me.BtnVendedores.TabIndex = 3
        Me.BtnVendedores.Text = "Vendedores"
        Me.BtnVendedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVendedores.UseVisualStyleBackColor = False
        '
        'BtnFacComandas
        '
        Me.BtnFacComandas.BackColor = System.Drawing.Color.Transparent
        Me.BtnFacComandas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnFacComandas, BunifuAnimatorNS.DecorationType.None)
        Me.BtnFacComandas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnFacComandas.FlatAppearance.BorderSize = 0
        Me.BtnFacComandas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnFacComandas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnFacComandas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFacComandas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnFacComandas.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFacComandas.ForeColor = System.Drawing.Color.White
        Me.BtnFacComandas.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnFacComandas.IconColor = System.Drawing.Color.White
        Me.BtnFacComandas.IconSize = 32
        Me.BtnFacComandas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFacComandas.Location = New System.Drawing.Point(0, 35)
        Me.BtnFacComandas.Name = "BtnFacComandas"
        Me.BtnFacComandas.Rotation = 0R
        Me.BtnFacComandas.Size = New System.Drawing.Size(235, 35)
        Me.BtnFacComandas.TabIndex = 2
        Me.BtnFacComandas.Text = "Facturacion de comandas de PG"
        Me.BtnFacComandas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFacComandas.UseVisualStyleBackColor = False
        '
        'BtnFacRutas
        '
        Me.BtnFacRutas.BackColor = System.Drawing.Color.Transparent
        Me.BtnFacRutas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnFacRutas, BunifuAnimatorNS.DecorationType.None)
        Me.BtnFacRutas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnFacRutas.FlatAppearance.BorderSize = 0
        Me.BtnFacRutas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnFacRutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnFacRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFacRutas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnFacRutas.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFacRutas.ForeColor = System.Drawing.Color.White
        Me.BtnFacRutas.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnFacRutas.IconColor = System.Drawing.Color.White
        Me.BtnFacRutas.IconSize = 32
        Me.BtnFacRutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFacRutas.Location = New System.Drawing.Point(0, 0)
        Me.BtnFacRutas.Name = "BtnFacRutas"
        Me.BtnFacRutas.Rotation = 0R
        Me.BtnFacRutas.Size = New System.Drawing.Size(235, 35)
        Me.BtnFacRutas.TabIndex = 1
        Me.BtnFacRutas.Text = "Facturacion de rutas"
        Me.BtnFacRutas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFacRutas.UseVisualStyleBackColor = False
        '
        'BtnVentas
        '
        Me.BtnVentas.BackColor = System.Drawing.Color.Transparent
        Me.BtnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.BtnVentas, BunifuAnimatorNS.DecorationType.None)
        Me.BtnVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVentas.FlatAppearance.BorderSize = 0
        Me.BtnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnVentas.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.ForeColor = System.Drawing.Color.White
        Me.BtnVentas.IconChar = FontAwesome.Sharp.IconChar.Calculator
        Me.BtnVentas.IconColor = System.Drawing.Color.White
        Me.BtnVentas.IconSize = 32
        Me.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVentas.Location = New System.Drawing.Point(0, 0)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Rotation = 0R
        Me.BtnVentas.Size = New System.Drawing.Size(235, 43)
        Me.BtnVentas.TabIndex = 6
        Me.BtnVentas.Text = "      VENTAS"
        Me.BtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVentas.UseVisualStyleBackColor = False
        '
        'SubMenuTransition
        '
        Me.SubMenuTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertBlind
        Me.SubMenuTransition.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.SubMenuTransition.DefaultAnimation = Animation1
        '
        'PanelFormularios
        '
        Me.PanelFormularios.Controls.Add(Me.BunifuGradientPanel1)
        Me.SubMenuTransition.SetDecoration(Me.PanelFormularios, BunifuAnimatorNS.DecorationType.None)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(266, 38)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(934, 662)
        Me.PanelFormularios.TabIndex = 3
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.IconButton1)
        Me.SubMenuTransition.SetDecoration(Me.BunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Teal
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Teal
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(934, 40)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubMenuTransition.SetDecoration(Me.IconButton1, BunifuAnimatorNS.DecorationType.None)
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconSize = 32
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(459, 7)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(122, 30)
        Me.IconButton1.TabIndex = 2
        Me.IconButton1.Text = "Inventario Fisico"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.PanelFormularios)
        Me.Controls.Add(Me.SideBar)
        Me.Controls.Add(Me.BarraTitulo)
        Me.SubMenuTransition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPrincipal"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPrincipal"
        Me.BarraTitulo.ResumeLayout(False)
        Me.BarraTitulo.PerformLayout()
        CType(Me.RestoreWindow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinimizeWindow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaximizeWindow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseWindow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuSideBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SideBar.ResumeLayout(False)
        Me.GradientePanel.ResumeLayout(False)
        Me.SubMenuRegistro.ResumeLayout(False)
        Me.SubMenuCompra.ResumeLayout(False)
        Me.SubMenuAlmacen.ResumeLayout(False)
        Me.SubMenuVentas.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents BarraTitulo As Panel
    Private WithEvents LabelSideBar As Label
    Private WithEvents MenuSideBar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents CloseWindow As PictureBox
    Friend WithEvents MinimizeWindow As PictureBox
    Friend WithEvents MaximizeWindow As PictureBox
    Friend WithEvents RestoreWindow As PictureBox
    Private WithEvents SideBar As Panel
    Private WithEvents GradientePanel As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents SubMenuVentas As Bunifu.Framework.UI.BunifuGradientPanel
    Private WithEvents BtnVentas As FontAwesome.Sharp.IconButton
    Private WithEvents BtnOfertas As FontAwesome.Sharp.IconButton
    Private WithEvents BtnRuta_Cliente As FontAwesome.Sharp.IconButton
    Private WithEvents BtnVendedores As FontAwesome.Sharp.IconButton
    Private WithEvents BtnFacComandas As FontAwesome.Sharp.IconButton
    Private WithEvents BtnFacRutas As FontAwesome.Sharp.IconButton
    Friend WithEvents SubMenuTransition As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Private WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Private WithEvents BtnCobranza As FontAwesome.Sharp.IconButton
    Private WithEvents BtnDocumentosClientes As FontAwesome.Sharp.IconButton
    Private WithEvents BtnLiberarCheques As FontAwesome.Sharp.IconButton
    Private WithEvents BtnClientes As FontAwesome.Sharp.IconButton
    Private WithEvents BtnVerOfertas As FontAwesome.Sharp.IconButton
    Private WithEvents BtnCrearOfertas As FontAwesome.Sharp.IconButton
    Private WithEvents BtnReporteadorCredCobranza As FontAwesome.Sharp.IconButton
    Private WithEvents BtnReporteadorRutas As FontAwesome.Sharp.IconButton
    Friend WithEvents SubMenuAlmacen As Bunifu.Framework.UI.BunifuGradientPanel
    Private WithEvents BtnAlmacen As FontAwesome.Sharp.IconButton
    Friend WithEvents SubMenuRegistro As Bunifu.Framework.UI.BunifuGradientPanel
    Private WithEvents IconButton34 As FontAwesome.Sharp.IconButton
    Private WithEvents IconButton33 As FontAwesome.Sharp.IconButton
    Private WithEvents IconButton32 As FontAwesome.Sharp.IconButton
    Private WithEvents IconButton31 As FontAwesome.Sharp.IconButton
    Private WithEvents IconButton30 As FontAwesome.Sharp.IconButton
    Private WithEvents IconButton21 As FontAwesome.Sharp.IconButton
    Private WithEvents IconButton22 As FontAwesome.Sharp.IconButton
    Private WithEvents IconButton23 As FontAwesome.Sharp.IconButton
    Private WithEvents IconButton24 As FontAwesome.Sharp.IconButton
    Private WithEvents IconButton25 As FontAwesome.Sharp.IconButton
    Private WithEvents IconButton26 As FontAwesome.Sharp.IconButton
    Private WithEvents IconButton27 As FontAwesome.Sharp.IconButton
    Private WithEvents IconButton28 As FontAwesome.Sharp.IconButton
    Private WithEvents IconButton29 As FontAwesome.Sharp.IconButton
    Private WithEvents IconButton20 As FontAwesome.Sharp.IconButton
    Friend WithEvents SubMenuCompra As Bunifu.Framework.UI.BunifuGradientPanel
    Private WithEvents BtnReporteadorCompras As FontAwesome.Sharp.IconButton
    Private WithEvents BtnNotaCargoxFaltante As FontAwesome.Sharp.IconButton
    Private WithEvents BtnNotasCredito As FontAwesome.Sharp.IconButton
    Private WithEvents BtnProveedores As FontAwesome.Sharp.IconButton
    Private WithEvents BtnCatalogoPrecios As FontAwesome.Sharp.IconButton
    Private WithEvents BtnAnalisisOrden As FontAwesome.Sharp.IconButton
    Private WithEvents BtnContra_recibo As FontAwesome.Sharp.IconButton
    Private WithEvents BtnOrdenCompra As FontAwesome.Sharp.IconButton
    Private WithEvents BtnComprasMenu As FontAwesome.Sharp.IconButton
    Private WithEvents BtnCompras As FontAwesome.Sharp.IconButton
    Private WithEvents BtnReporteador As FontAwesome.Sharp.IconButton
    Private WithEvents BtnConversiones As FontAwesome.Sharp.IconButton
    Private WithEvents BtnConceptos As FontAwesome.Sharp.IconButton
    Private WithEvents BtnNotificaciones As FontAwesome.Sharp.IconButton
    Private WithEvents BtnActualizacionInv As FontAwesome.Sharp.IconButton
    Private WithEvents BtnInvFisico As FontAwesome.Sharp.IconButton
    Private WithEvents BtnPedidoMercancia As FontAwesome.Sharp.IconButton
    Private WithEvents BtnTraspasosEAlmacenes As FontAwesome.Sharp.IconButton
    Private WithEvents SalidaMercancia As FontAwesome.Sharp.IconButton
    Private WithEvents BtnEntradasMercancia As FontAwesome.Sharp.IconButton
    Private WithEvents BtnTablajeria As FontAwesome.Sharp.IconButton
    Private WithEvents BtnMinMax As FontAwesome.Sharp.IconButton
    Private WithEvents BtnProductosProcesados As FontAwesome.Sharp.IconButton
    Private WithEvents BtnEscalasPrecio As FontAwesome.Sharp.IconButton
    Private WithEvents BtnFamYDepartamentos As FontAwesome.Sharp.IconButton
    Private WithEvents BtnVerificadorProductos As FontAwesome.Sharp.IconButton
    Private WithEvents BtnActivacionPrecios As FontAwesome.Sharp.IconButton
    Private WithEvents BtnCatalogoProductos As FontAwesome.Sharp.IconButton
    Private WithEvents BtnProductos As FontAwesome.Sharp.IconButton
    Private WithEvents BtnSucursalesYAlmacenes As FontAwesome.Sharp.IconButton
End Class
