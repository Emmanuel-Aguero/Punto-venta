<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInventarioFisico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInventarioFisico))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.fileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.BtnGuardarInventario = New FontAwesome.Sharp.IconButton()
        Me.BtnLoadFile = New FontAwesome.Sharp.IconButton()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DropSucursal = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.TxtConteo = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TxtProducto = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TxtCodigo = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.GridDetalles = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.ClCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClConteo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnTerminarCaptura = New FontAwesome.Sharp.IconButton()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.GridDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fileDialog
        '
        Me.fileDialog.FileName = "Archivo"
        '
        'BtnGuardarInventario
        '
        Me.BtnGuardarInventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardarInventario.BackColor = System.Drawing.Color.Transparent
        Me.BtnGuardarInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnGuardarInventario.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnGuardarInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnGuardarInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarInventario.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnGuardarInventario.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarInventario.ForeColor = System.Drawing.Color.White
        Me.BtnGuardarInventario.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.BtnGuardarInventario.IconColor = System.Drawing.Color.White
        Me.BtnGuardarInventario.IconSize = 32
        Me.BtnGuardarInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarInventario.Location = New System.Drawing.Point(11, 522)
        Me.BtnGuardarInventario.Name = "BtnGuardarInventario"
        Me.BtnGuardarInventario.Rotation = 0R
        Me.BtnGuardarInventario.Size = New System.Drawing.Size(234, 43)
        Me.BtnGuardarInventario.TabIndex = 14
        Me.BtnGuardarInventario.Text = "      Guardar Inventario"
        Me.BtnGuardarInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardarInventario.UseVisualStyleBackColor = False
        '
        'BtnLoadFile
        '
        Me.BtnLoadFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoadFile.BackColor = System.Drawing.Color.Transparent
        Me.BtnLoadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnLoadFile.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnLoadFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnLoadFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoadFile.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnLoadFile.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoadFile.ForeColor = System.Drawing.Color.White
        Me.BtnLoadFile.IconChar = FontAwesome.Sharp.IconChar.FileUpload
        Me.BtnLoadFile.IconColor = System.Drawing.Color.White
        Me.BtnLoadFile.IconSize = 32
        Me.BtnLoadFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLoadFile.Location = New System.Drawing.Point(11, 471)
        Me.BtnLoadFile.Name = "BtnLoadFile"
        Me.BtnLoadFile.Rotation = 0R
        Me.BtnLoadFile.Size = New System.Drawing.Size(234, 43)
        Me.BtnLoadFile.TabIndex = 13
        Me.BtnLoadFile.Text = "      Cargar archivo"
        Me.BtnLoadFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLoadFile.UseVisualStyleBackColor = False
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BtnTerminarCaptura)
        Me.BunifuGradientPanel1.Controls.Add(Me.GroupBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BtnGuardarInventario)
        Me.BunifuGradientPanel1.Controls.Add(Me.DropSucursal)
        Me.BunifuGradientPanel1.Controls.Add(Me.BtnLoadFile)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(663, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(255, 624)
        Me.BunifuGradientPanel1.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel7)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel6)
        Me.GroupBox1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(24, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 84)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ayuda"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Poppins", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(9, 52)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(180, 18)
        Me.BunifuCustomLabel7.TabIndex = 16
        Me.BunifuCustomLabel7.Text = "Supr  -  Eliminar Ultimo Registro"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Poppins", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(32, 26)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(132, 18)
        Me.BunifuCustomLabel6.TabIndex = 15
        Me.BunifuCustomLabel6.Text = "F5  -  Limpiar Registros"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(6, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(72, 21)
        Me.BunifuCustomLabel1.TabIndex = 1
        Me.BunifuCustomLabel1.Text = "Almacen:"
        '
        'DropSucursal
        '
        Me.DropSucursal.BackColor = System.Drawing.Color.Transparent
        Me.DropSucursal.BorderRadius = 15
        Me.DropSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DropSucursal.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropSucursal.ForeColor = System.Drawing.Color.White
        Me.DropSucursal.Items = New String(-1) {}
        Me.DropSucursal.Location = New System.Drawing.Point(6, 31)
        Me.DropSucursal.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.DropSucursal.Name = "DropSucursal"
        Me.DropSucursal.NomalColor = System.Drawing.Color.Transparent
        Me.DropSucursal.onHoverColor = System.Drawing.Color.Transparent
        Me.DropSucursal.selectedIndex = -1
        Me.DropSucursal.Size = New System.Drawing.Size(243, 30)
        Me.DropSucursal.TabIndex = 12
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(6, 28)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(61, 21)
        Me.BunifuCustomLabel2.TabIndex = 15
        Me.BunifuCustomLabel2.Text = "Codigo:"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(221, 28)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(73, 21)
        Me.BunifuCustomLabel3.TabIndex = 45
        Me.BunifuCustomLabel3.Text = "Producto:"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(556, 28)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(61, 21)
        Me.BunifuCustomLabel4.TabIndex = 47
        Me.BunifuCustomLabel4.Text = "Conteo:"
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuGradientPanel2.Controls.Add(Me.TxtConteo)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuCustomLabel5)
        Me.BunifuGradientPanel2.Controls.Add(Me.TxtProducto)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuCustomLabel4)
        Me.BunifuGradientPanel2.Controls.Add(Me.TxtCodigo)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuCustomLabel2)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuCustomLabel3)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(663, 90)
        Me.BunifuGradientPanel2.TabIndex = 41
        '
        'TxtConteo
        '
        Me.TxtConteo.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TxtConteo.BorderColorIdle = System.Drawing.Color.Silver
        Me.TxtConteo.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TxtConteo.BorderThickness = 1
        Me.TxtConteo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtConteo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtConteo.ForeColor = System.Drawing.Color.White
        Me.TxtConteo.isPassword = False
        Me.TxtConteo.Location = New System.Drawing.Point(556, 51)
        Me.TxtConteo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtConteo.Name = "TxtConteo"
        Me.TxtConteo.Size = New System.Drawing.Size(92, 30)
        Me.TxtConteo.TabIndex = 48
        Me.TxtConteo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(4, 4)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(127, 21)
        Me.BunifuCustomLabel5.TabIndex = 50
        Me.BunifuCustomLabel5.Text = "Agregar Producto"
        '
        'TxtProducto
        '
        Me.TxtProducto.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TxtProducto.BorderColorIdle = System.Drawing.Color.Silver
        Me.TxtProducto.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TxtProducto.BorderThickness = 1
        Me.TxtProducto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtProducto.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtProducto.ForeColor = System.Drawing.Color.White
        Me.TxtProducto.isPassword = False
        Me.TxtProducto.Location = New System.Drawing.Point(217, 51)
        Me.TxtProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.Size = New System.Drawing.Size(332, 30)
        Me.TxtProducto.TabIndex = 47
        Me.TxtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BorderColorFocused = System.Drawing.Color.Transparent
        Me.TxtCodigo.BorderColorIdle = System.Drawing.Color.Silver
        Me.TxtCodigo.BorderColorMouseHover = System.Drawing.Color.Transparent
        Me.TxtCodigo.BorderThickness = 1
        Me.TxtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCodigo.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.ForeColor = System.Drawing.Color.White
        Me.TxtCodigo.isPassword = False
        Me.TxtCodigo.Location = New System.Drawing.Point(10, 51)
        Me.TxtCodigo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(199, 30)
        Me.TxtCodigo.TabIndex = 46
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GridDetalles
        '
        Me.GridDetalles.AllowUserToAddRows = False
        Me.GridDetalles.AllowUserToDeleteRows = False
        Me.GridDetalles.AllowUserToResizeColumns = False
        Me.GridDetalles.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridDetalles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridDetalles.BackgroundColor = System.Drawing.Color.White
        Me.GridDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.GridDetalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridDetalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClCodigo, Me.ClProducto, Me.ClConteo})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridDetalles.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDetalles.DoubleBuffered = True
        Me.GridDetalles.EnableHeadersVisualStyles = False
        Me.GridDetalles.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.GridDetalles.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.GridDetalles.HeaderForeColor = System.Drawing.Color.White
        Me.GridDetalles.Location = New System.Drawing.Point(0, 90)
        Me.GridDetalles.MultiSelect = False
        Me.GridDetalles.Name = "GridDetalles"
        Me.GridDetalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridDetalles.RowHeadersVisible = False
        Me.GridDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridDetalles.Size = New System.Drawing.Size(663, 534)
        Me.GridDetalles.TabIndex = 45
        '
        'ClCodigo
        '
        Me.ClCodigo.HeaderText = "Codigo"
        Me.ClCodigo.Name = "ClCodigo"
        Me.ClCodigo.Width = 230
        '
        'ClProducto
        '
        Me.ClProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ClProducto.HeaderText = "Producto"
        Me.ClProducto.Name = "ClProducto"
        '
        'ClConteo
        '
        Me.ClConteo.HeaderText = "Conteo"
        Me.ClConteo.Name = "ClConteo"
        Me.ClConteo.Width = 80
        '
        'BtnTerminarCaptura
        '
        Me.BtnTerminarCaptura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTerminarCaptura.BackColor = System.Drawing.Color.Transparent
        Me.BtnTerminarCaptura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnTerminarCaptura.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnTerminarCaptura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnTerminarCaptura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnTerminarCaptura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTerminarCaptura.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnTerminarCaptura.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTerminarCaptura.ForeColor = System.Drawing.Color.White
        Me.BtnTerminarCaptura.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.BtnTerminarCaptura.IconColor = System.Drawing.Color.White
        Me.BtnTerminarCaptura.IconSize = 32
        Me.BtnTerminarCaptura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTerminarCaptura.Location = New System.Drawing.Point(11, 574)
        Me.BtnTerminarCaptura.Name = "BtnTerminarCaptura"
        Me.BtnTerminarCaptura.Rotation = 0R
        Me.BtnTerminarCaptura.Size = New System.Drawing.Size(234, 43)
        Me.BtnTerminarCaptura.TabIndex = 16
        Me.BtnTerminarCaptura.Text = "      Terminar Captura"
        Me.BtnTerminarCaptura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTerminarCaptura.UseVisualStyleBackColor = False
        '
        'FormInventarioFisico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(918, 624)
        Me.Controls.Add(Me.GridDetalles)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Name = "FormInventarioFisico"
        Me.Text = "FormInventarioFisico"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        CType(Me.GridDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fileDialog As OpenFileDialog
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Private WithEvents BtnLoadFile As FontAwesome.Sharp.IconButton
    Private WithEvents DropSucursal As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents BtnGuardarInventario As FontAwesome.Sharp.IconButton
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents GridDetalles As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ClCodigo As DataGridViewTextBoxColumn
    Friend WithEvents ClProducto As DataGridViewTextBoxColumn
    Friend WithEvents ClConteo As DataGridViewTextBoxColumn
    Friend WithEvents TxtCodigo As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents TxtConteo As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents TxtProducto As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents BtnTerminarCaptura As FontAwesome.Sharp.IconButton
End Class
