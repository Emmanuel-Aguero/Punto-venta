<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEntradas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEntradas))
        Me.GridDetalles = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.ClCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.TxtCantidad = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.LabelCodigo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TxtProducto = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TxtCodigo = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.LabelProducto = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LabelCantidad = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.DropConcepto = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BtnCargarSobrante = New FontAwesome.Sharp.IconButton()
        Me.BtnGuardarEntrada = New FontAwesome.Sharp.IconButton()
        Me.BtnNuevaEntrada = New FontAwesome.Sharp.IconButton()
        Me.TxtReferencia = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TxtObervaciones = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.LabelObservacion = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LabelConcepto = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LabelAlmacen = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DropAlmacen = New Bunifu.Framework.UI.BunifuDropdown()
        Me.LabelFechaEntrada = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LabelIdEntrada = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.GridDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridDetalles
        '
        Me.GridDetalles.AllowUserToAddRows = False
        Me.GridDetalles.AllowUserToDeleteRows = False
        Me.GridDetalles.AllowUserToResizeColumns = False
        Me.GridDetalles.AllowUserToResizeRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridDetalles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GridDetalles.BackgroundColor = System.Drawing.Color.White
        Me.GridDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.GridDetalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridDetalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.GridDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClCodigo, Me.ClCantidad, Me.ClProducto})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridDetalles.DefaultCellStyle = DataGridViewCellStyle6
        Me.GridDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDetalles.DoubleBuffered = True
        Me.GridDetalles.EnableHeadersVisualStyles = False
        Me.GridDetalles.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.GridDetalles.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GridDetalles.HeaderForeColor = System.Drawing.Color.White
        Me.GridDetalles.Location = New System.Drawing.Point(0, 72)
        Me.GridDetalles.MultiSelect = False
        Me.GridDetalles.Name = "GridDetalles"
        Me.GridDetalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridDetalles.RowHeadersVisible = False
        Me.GridDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridDetalles.Size = New System.Drawing.Size(625, 429)
        Me.GridDetalles.TabIndex = 46
        '
        'ClCodigo
        '
        Me.ClCodigo.HeaderText = "Codigo"
        Me.ClCodigo.Name = "ClCodigo"
        Me.ClCodigo.Width = 150
        '
        'ClCantidad
        '
        Me.ClCantidad.HeaderText = "Cantidad"
        Me.ClCantidad.Name = "ClCantidad"
        Me.ClCantidad.Width = 80
        '
        'ClProducto
        '
        Me.ClProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ClProducto.HeaderText = "Producto"
        Me.ClProducto.Name = "ClProducto"
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.TxtCantidad)
        Me.BunifuGradientPanel2.Controls.Add(Me.LabelCodigo)
        Me.BunifuGradientPanel2.Controls.Add(Me.TxtProducto)
        Me.BunifuGradientPanel2.Controls.Add(Me.TxtCodigo)
        Me.BunifuGradientPanel2.Controls.Add(Me.LabelProducto)
        Me.BunifuGradientPanel2.Controls.Add(Me.LabelCantidad)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Black
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(625, 72)
        Me.BunifuGradientPanel2.TabIndex = 3
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TxtCantidad.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TxtCantidad.BorderColorIdle = System.Drawing.Color.Silver
        Me.TxtCantidad.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TxtCantidad.BorderThickness = 1
        Me.TxtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCantidad.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.ForeColor = System.Drawing.Color.White
        Me.TxtCantidad.isPassword = False
        Me.TxtCantidad.Location = New System.Drawing.Point(149, 31)
        Me.TxtCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(90, 30)
        Me.TxtCantidad.TabIndex = 54
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LabelCodigo
        '
        Me.LabelCodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelCodigo.AutoSize = True
        Me.LabelCodigo.BackColor = System.Drawing.Color.Transparent
        Me.LabelCodigo.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCodigo.ForeColor = System.Drawing.Color.White
        Me.LabelCodigo.Location = New System.Drawing.Point(5, 6)
        Me.LabelCodigo.Name = "LabelCodigo"
        Me.LabelCodigo.Size = New System.Drawing.Size(61, 21)
        Me.LabelCodigo.TabIndex = 49
        Me.LabelCodigo.Text = "Codigo:"
        '
        'TxtProducto
        '
        Me.TxtProducto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TxtProducto.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TxtProducto.BorderColorIdle = System.Drawing.Color.Silver
        Me.TxtProducto.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TxtProducto.BorderThickness = 1
        Me.TxtProducto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtProducto.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProducto.ForeColor = System.Drawing.Color.White
        Me.TxtProducto.isPassword = False
        Me.TxtProducto.Location = New System.Drawing.Point(247, 31)
        Me.TxtProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.Size = New System.Drawing.Size(368, 30)
        Me.TxtProducto.TabIndex = 52
        Me.TxtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TxtCodigo.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TxtCodigo.BorderColorIdle = System.Drawing.Color.Silver
        Me.TxtCodigo.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TxtCodigo.BorderThickness = 1
        Me.TxtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCodigo.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.ForeColor = System.Drawing.Color.White
        Me.TxtCodigo.isPassword = False
        Me.TxtCodigo.Location = New System.Drawing.Point(5, 31)
        Me.TxtCodigo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(134, 30)
        Me.TxtCodigo.TabIndex = 51
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LabelProducto
        '
        Me.LabelProducto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelProducto.AutoSize = True
        Me.LabelProducto.BackColor = System.Drawing.Color.Transparent
        Me.LabelProducto.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProducto.ForeColor = System.Drawing.Color.White
        Me.LabelProducto.Location = New System.Drawing.Point(246, 6)
        Me.LabelProducto.Name = "LabelProducto"
        Me.LabelProducto.Size = New System.Drawing.Size(73, 21)
        Me.LabelProducto.TabIndex = 50
        Me.LabelProducto.Text = "Producto:"
        '
        'LabelCantidad
        '
        Me.LabelCantidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelCantidad.AutoSize = True
        Me.LabelCantidad.BackColor = System.Drawing.Color.Transparent
        Me.LabelCantidad.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCantidad.ForeColor = System.Drawing.Color.White
        Me.LabelCantidad.Location = New System.Drawing.Point(148, 6)
        Me.LabelCantidad.Name = "LabelCantidad"
        Me.LabelCantidad.Size = New System.Drawing.Size(72, 21)
        Me.LabelCantidad.TabIndex = 53
        Me.LabelCantidad.Text = "Cantidad"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.DropConcepto)
        Me.BunifuGradientPanel1.Controls.Add(Me.BtnCargarSobrante)
        Me.BunifuGradientPanel1.Controls.Add(Me.BtnGuardarEntrada)
        Me.BunifuGradientPanel1.Controls.Add(Me.BtnNuevaEntrada)
        Me.BunifuGradientPanel1.Controls.Add(Me.TxtReferencia)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.TxtObervaciones)
        Me.BunifuGradientPanel1.Controls.Add(Me.LabelObservacion)
        Me.BunifuGradientPanel1.Controls.Add(Me.LabelConcepto)
        Me.BunifuGradientPanel1.Controls.Add(Me.LabelAlmacen)
        Me.BunifuGradientPanel1.Controls.Add(Me.DropAlmacen)
        Me.BunifuGradientPanel1.Controls.Add(Me.LabelFechaEntrada)
        Me.BunifuGradientPanel1.Controls.Add(Me.LabelIdEntrada)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(625, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(314, 501)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'DropConcepto
        '
        Me.DropConcepto.BackColor = System.Drawing.Color.Transparent
        Me.DropConcepto.BorderRadius = 3
        Me.DropConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DropConcepto.ForeColor = System.Drawing.Color.White
        Me.DropConcepto.Items = New String(-1) {}
        Me.DropConcepto.Location = New System.Drawing.Point(17, 157)
        Me.DropConcepto.Name = "DropConcepto"
        Me.DropConcepto.NomalColor = System.Drawing.Color.Transparent
        Me.DropConcepto.onHoverColor = System.Drawing.Color.Transparent
        Me.DropConcepto.selectedIndex = -1
        Me.DropConcepto.Size = New System.Drawing.Size(282, 35)
        Me.DropConcepto.TabIndex = 64
        '
        'BtnCargarSobrante
        '
        Me.BtnCargarSobrante.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCargarSobrante.BackColor = System.Drawing.Color.Transparent
        Me.BtnCargarSobrante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCargarSobrante.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnCargarSobrante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnCargarSobrante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCargarSobrante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCargarSobrante.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnCargarSobrante.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargarSobrante.ForeColor = System.Drawing.Color.White
        Me.BtnCargarSobrante.IconChar = FontAwesome.Sharp.IconChar.FileUpload
        Me.BtnCargarSobrante.IconColor = System.Drawing.Color.White
        Me.BtnCargarSobrante.IconSize = 28
        Me.BtnCargarSobrante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCargarSobrante.Location = New System.Drawing.Point(18, 447)
        Me.BtnCargarSobrante.Name = "BtnCargarSobrante"
        Me.BtnCargarSobrante.Rotation = 0R
        Me.BtnCargarSobrante.Size = New System.Drawing.Size(276, 41)
        Me.BtnCargarSobrante.TabIndex = 63
        Me.BtnCargarSobrante.Text = "      Cargar Sobrante"
        Me.BtnCargarSobrante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCargarSobrante.UseVisualStyleBackColor = False
        '
        'BtnGuardarEntrada
        '
        Me.BtnGuardarEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardarEntrada.BackColor = System.Drawing.Color.Transparent
        Me.BtnGuardarEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnGuardarEntrada.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnGuardarEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnGuardarEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarEntrada.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnGuardarEntrada.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarEntrada.ForeColor = System.Drawing.Color.White
        Me.BtnGuardarEntrada.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.BtnGuardarEntrada.IconColor = System.Drawing.Color.White
        Me.BtnGuardarEntrada.IconSize = 28
        Me.BtnGuardarEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarEntrada.Location = New System.Drawing.Point(18, 400)
        Me.BtnGuardarEntrada.Name = "BtnGuardarEntrada"
        Me.BtnGuardarEntrada.Rotation = 0R
        Me.BtnGuardarEntrada.Size = New System.Drawing.Size(276, 41)
        Me.BtnGuardarEntrada.TabIndex = 62
        Me.BtnGuardarEntrada.Text = "      Guardar"
        Me.BtnGuardarEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardarEntrada.UseVisualStyleBackColor = False
        '
        'BtnNuevaEntrada
        '
        Me.BtnNuevaEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNuevaEntrada.BackColor = System.Drawing.Color.Transparent
        Me.BtnNuevaEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnNuevaEntrada.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnNuevaEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnNuevaEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNuevaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevaEntrada.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnNuevaEntrada.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevaEntrada.ForeColor = System.Drawing.Color.White
        Me.BtnNuevaEntrada.IconChar = FontAwesome.Sharp.IconChar.FileImport
        Me.BtnNuevaEntrada.IconColor = System.Drawing.Color.White
        Me.BtnNuevaEntrada.IconSize = 28
        Me.BtnNuevaEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevaEntrada.Location = New System.Drawing.Point(18, 353)
        Me.BtnNuevaEntrada.Name = "BtnNuevaEntrada"
        Me.BtnNuevaEntrada.Rotation = 0R
        Me.BtnNuevaEntrada.Size = New System.Drawing.Size(276, 41)
        Me.BtnNuevaEntrada.TabIndex = 61
        Me.BtnNuevaEntrada.Text = "      Nuevo"
        Me.BtnNuevaEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNuevaEntrada.UseVisualStyleBackColor = False
        '
        'TxtReferencia
        '
        Me.TxtReferencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TxtReferencia.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TxtReferencia.BorderColorIdle = System.Drawing.Color.Silver
        Me.TxtReferencia.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TxtReferencia.BorderThickness = 1
        Me.TxtReferencia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtReferencia.Enabled = False
        Me.TxtReferencia.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferencia.ForeColor = System.Drawing.Color.White
        Me.TxtReferencia.isPassword = False
        Me.TxtReferencia.Location = New System.Drawing.Point(18, 232)
        Me.TxtReferencia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtReferencia.Name = "TxtReferencia"
        Me.TxtReferencia.Size = New System.Drawing.Size(276, 30)
        Me.TxtReferencia.TabIndex = 60
        Me.TxtReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(14, 206)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(83, 21)
        Me.BunifuCustomLabel1.TabIndex = 59
        Me.BunifuCustomLabel1.Text = "Referencia:"
        '
        'TxtObervaciones
        '
        Me.TxtObervaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TxtObervaciones.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TxtObervaciones.BorderColorIdle = System.Drawing.Color.Silver
        Me.TxtObervaciones.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TxtObervaciones.BorderThickness = 1
        Me.TxtObervaciones.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtObervaciones.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObervaciones.ForeColor = System.Drawing.Color.White
        Me.TxtObervaciones.isPassword = False
        Me.TxtObervaciones.Location = New System.Drawing.Point(18, 310)
        Me.TxtObervaciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtObervaciones.Name = "TxtObervaciones"
        Me.TxtObervaciones.Size = New System.Drawing.Size(276, 30)
        Me.TxtObervaciones.TabIndex = 58
        Me.TxtObervaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LabelObservacion
        '
        Me.LabelObservacion.AutoSize = True
        Me.LabelObservacion.BackColor = System.Drawing.Color.Transparent
        Me.LabelObservacion.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelObservacion.ForeColor = System.Drawing.Color.White
        Me.LabelObservacion.Location = New System.Drawing.Point(14, 284)
        Me.LabelObservacion.Name = "LabelObservacion"
        Me.LabelObservacion.Size = New System.Drawing.Size(111, 21)
        Me.LabelObservacion.TabIndex = 57
        Me.LabelObservacion.Text = "Observaciones:"
        '
        'LabelConcepto
        '
        Me.LabelConcepto.AutoSize = True
        Me.LabelConcepto.BackColor = System.Drawing.Color.Transparent
        Me.LabelConcepto.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConcepto.ForeColor = System.Drawing.Color.White
        Me.LabelConcepto.Location = New System.Drawing.Point(14, 133)
        Me.LabelConcepto.Name = "LabelConcepto"
        Me.LabelConcepto.Size = New System.Drawing.Size(78, 21)
        Me.LabelConcepto.TabIndex = 55
        Me.LabelConcepto.Text = "Concepto:"
        '
        'LabelAlmacen
        '
        Me.LabelAlmacen.AutoSize = True
        Me.LabelAlmacen.BackColor = System.Drawing.Color.Transparent
        Me.LabelAlmacen.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlmacen.ForeColor = System.Drawing.Color.White
        Me.LabelAlmacen.Location = New System.Drawing.Point(14, 62)
        Me.LabelAlmacen.Name = "LabelAlmacen"
        Me.LabelAlmacen.Size = New System.Drawing.Size(72, 21)
        Me.LabelAlmacen.TabIndex = 54
        Me.LabelAlmacen.Text = "Almacen:"
        '
        'DropAlmacen
        '
        Me.DropAlmacen.BackColor = System.Drawing.Color.Transparent
        Me.DropAlmacen.BorderRadius = 3
        Me.DropAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DropAlmacen.ForeColor = System.Drawing.Color.White
        Me.DropAlmacen.Items = New String(-1) {}
        Me.DropAlmacen.Location = New System.Drawing.Point(17, 90)
        Me.DropAlmacen.Name = "DropAlmacen"
        Me.DropAlmacen.NomalColor = System.Drawing.Color.Transparent
        Me.DropAlmacen.onHoverColor = System.Drawing.Color.Transparent
        Me.DropAlmacen.selectedIndex = -1
        Me.DropAlmacen.Size = New System.Drawing.Size(282, 35)
        Me.DropAlmacen.TabIndex = 53
        '
        'LabelFechaEntrada
        '
        Me.LabelFechaEntrada.AutoSize = True
        Me.LabelFechaEntrada.BackColor = System.Drawing.Color.Transparent
        Me.LabelFechaEntrada.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaEntrada.ForeColor = System.Drawing.Color.White
        Me.LabelFechaEntrada.Location = New System.Drawing.Point(108, 9)
        Me.LabelFechaEntrada.Name = "LabelFechaEntrada"
        Me.LabelFechaEntrada.Size = New System.Drawing.Size(194, 21)
        Me.LabelFechaEntrada.TabIndex = 52
        Me.LabelFechaEntrada.Text = "Sabado 13 de Junio de 2020"
        '
        'LabelIdEntrada
        '
        Me.LabelIdEntrada.AutoSize = True
        Me.LabelIdEntrada.BackColor = System.Drawing.Color.Transparent
        Me.LabelIdEntrada.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIdEntrada.ForeColor = System.Drawing.Color.White
        Me.LabelIdEntrada.Location = New System.Drawing.Point(14, 35)
        Me.LabelIdEntrada.Name = "LabelIdEntrada"
        Me.LabelIdEntrada.Size = New System.Drawing.Size(82, 21)
        Me.LabelIdEntrada.TabIndex = 51
        Me.LabelIdEntrada.Text = "ID Entrada:"
        '
        'FormEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 501)
        Me.Controls.Add(Me.GridDetalles)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Name = "FormEntradas"
        Me.Text = "FormEntradas"
        CType(Me.GridDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents LabelObservacion As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LabelConcepto As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LabelAlmacen As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DropAlmacen As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents LabelFechaEntrada As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LabelIdEntrada As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TxtReferencia As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TxtObervaciones As Bunifu.Framework.UI.BunifuMetroTextbox
    Private WithEvents BtnCargarSobrante As FontAwesome.Sharp.IconButton
    Private WithEvents BtnGuardarEntrada As FontAwesome.Sharp.IconButton
    Private WithEvents BtnNuevaEntrada As FontAwesome.Sharp.IconButton
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents TxtCantidad As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents LabelCodigo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TxtProducto As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents TxtCodigo As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents LabelProducto As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LabelCantidad As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents GridDetalles As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ClCodigo As DataGridViewTextBoxColumn
    Friend WithEvents ClCantidad As DataGridViewTextBoxColumn
    Friend WithEvents ClProducto As DataGridViewTextBoxColumn
    Friend WithEvents DropConcepto As Bunifu.Framework.UI.BunifuDropdown
End Class
