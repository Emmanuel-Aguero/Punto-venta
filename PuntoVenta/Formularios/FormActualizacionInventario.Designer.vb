<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormActualizacionInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormActualizacionInventario))
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelFlexTitulo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.FlexDrop = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuGradientPanel4 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BtnAjustar = New FontAwesome.Sharp.IconButton()
        Me.BtnInicializa = New FontAwesome.Sharp.IconButton()
        Me.BtnGeneraDif = New FontAwesome.Sharp.IconButton()
        Me.BunifuGradientPanel3 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DatimeFecha = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.CmbTipoInventario = New Bunifu.Framework.UI.BunifuDropdown()
        Me.CmbAlmacen = New Bunifu.Framework.UI.BunifuDropdown()
        Me.DatePicker = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.DropAlmacen = New Bunifu.Framework.UI.BunifuDropdown()
        Me.DropTipoInventario = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.BunifuGradientPanel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel1)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(918, 624)
        Me.BunifuGradientPanel1.TabIndex = 41
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LabelFlexTitulo)
        Me.Panel1.Controls.Add(Me.FlexDrop)
        Me.Panel1.Controls.Add(Me.BunifuGradientPanel4)
        Me.Panel1.Controls.Add(Me.BunifuGradientPanel3)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.DatimeFecha)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.CmbTipoInventario)
        Me.Panel1.Controls.Add(Me.CmbAlmacen)
        Me.Panel1.Location = New System.Drawing.Point(99, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(645, 395)
        Me.Panel1.TabIndex = 17
        '
        'LabelFlexTitulo
        '
        Me.LabelFlexTitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelFlexTitulo.AutoSize = True
        Me.LabelFlexTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LabelFlexTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelFlexTitulo.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFlexTitulo.ForeColor = System.Drawing.Color.White
        Me.LabelFlexTitulo.Location = New System.Drawing.Point(15, 282)
        Me.LabelFlexTitulo.Name = "LabelFlexTitulo"
        Me.LabelFlexTitulo.Size = New System.Drawing.Size(87, 25)
        Me.LabelFlexTitulo.TabIndex = 26
        Me.LabelFlexTitulo.Text = "Flex Titulo:"
        Me.LabelFlexTitulo.Visible = False
        '
        'FlexDrop
        '
        Me.FlexDrop.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlexDrop.BackColor = System.Drawing.Color.Transparent
        Me.FlexDrop.BorderRadius = 3
        Me.FlexDrop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlexDrop.ForeColor = System.Drawing.Color.White
        Me.FlexDrop.Items = New String() {"General", "Familia", "Proveedor", "Seleccion de productos", "Ubicacion"}
        Me.FlexDrop.Location = New System.Drawing.Point(18, 317)
        Me.FlexDrop.Name = "FlexDrop"
        Me.FlexDrop.NomalColor = System.Drawing.Color.Transparent
        Me.FlexDrop.onHoverColor = System.Drawing.Color.Transparent
        Me.FlexDrop.selectedIndex = -1
        Me.FlexDrop.Size = New System.Drawing.Size(306, 35)
        Me.FlexDrop.TabIndex = 25
        Me.FlexDrop.Visible = False
        '
        'BunifuGradientPanel4
        '
        Me.BunifuGradientPanel4.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel4.Controls.Add(Me.GroupBox1)
        Me.BunifuGradientPanel4.Controls.Add(Me.BtnAjustar)
        Me.BunifuGradientPanel4.Controls.Add(Me.BtnInicializa)
        Me.BunifuGradientPanel4.Controls.Add(Me.BtnGeneraDif)
        Me.BunifuGradientPanel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.Teal
        Me.BunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.Teal
        Me.BunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.Black
        Me.BunifuGradientPanel4.GradientTopRight = System.Drawing.Color.Black
        Me.BunifuGradientPanel4.Location = New System.Drawing.Point(352, 0)
        Me.BunifuGradientPanel4.Name = "BunifuGradientPanel4"
        Me.BunifuGradientPanel4.Quality = 10
        Me.BunifuGradientPanel4.Size = New System.Drawing.Size(291, 385)
        Me.BunifuGradientPanel4.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel8)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel7)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel6)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel5)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel4)
        Me.GroupBox1.Font = New System.Drawing.Font("Poppins", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 199)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pasos"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Poppins", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(15, 152)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(117, 18)
        Me.BunifuCustomLabel8.TabIndex = 31
        Me.BunifuCustomLabel8.Text = "5. Ajustar inventario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Poppins", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(15, 124)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(205, 18)
        Me.BunifuCustomLabel7.TabIndex = 30
        Me.BunifuCustomLabel7.Text = "4. Generar diferencias de inventario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Poppins", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(15, 96)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(229, 18)
        Me.BunifuCustomLabel6.TabIndex = 29
        Me.BunifuCustomLabel6.Text = "3. Capturar Inventario (Inventario fisico)"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Poppins", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(15, 68)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(240, 18)
        Me.BunifuCustomLabel5.TabIndex = 28
        Me.BunifuCustomLabel5.Text = "2. Inicializar Inventario (Click en inicializa)"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Poppins", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(15, 40)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(221, 18)
        Me.BunifuCustomLabel4.TabIndex = 27
        Me.BunifuCustomLabel4.Text = "1. Sacar reporte de inventario costeado"
        '
        'BtnAjustar
        '
        Me.BtnAjustar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAjustar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAjustar.FlatAppearance.BorderSize = 0
        Me.BtnAjustar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnAjustar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAjustar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAjustar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnAjustar.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAjustar.ForeColor = System.Drawing.Color.White
        Me.BtnAjustar.IconChar = FontAwesome.Sharp.IconChar.Adjust
        Me.BtnAjustar.IconColor = System.Drawing.Color.White
        Me.BtnAjustar.IconSize = 32
        Me.BtnAjustar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAjustar.Location = New System.Drawing.Point(12, 344)
        Me.BtnAjustar.Name = "BtnAjustar"
        Me.BtnAjustar.Rotation = 0R
        Me.BtnAjustar.Size = New System.Drawing.Size(262, 37)
        Me.BtnAjustar.TabIndex = 24
        Me.BtnAjustar.Text = "      AJUSTAR"
        Me.BtnAjustar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAjustar.UseVisualStyleBackColor = False
        '
        'BtnInicializa
        '
        Me.BtnInicializa.BackColor = System.Drawing.Color.Transparent
        Me.BtnInicializa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInicializa.FlatAppearance.BorderSize = 0
        Me.BtnInicializa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnInicializa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnInicializa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnInicializa.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnInicializa.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInicializa.ForeColor = System.Drawing.Color.White
        Me.BtnInicializa.IconChar = FontAwesome.Sharp.IconChar.Play
        Me.BtnInicializa.IconColor = System.Drawing.Color.White
        Me.BtnInicializa.IconSize = 32
        Me.BtnInicializa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInicializa.Location = New System.Drawing.Point(10, 250)
        Me.BtnInicializa.Name = "BtnInicializa"
        Me.BtnInicializa.Rotation = 0R
        Me.BtnInicializa.Size = New System.Drawing.Size(264, 37)
        Me.BtnInicializa.TabIndex = 22
        Me.BtnInicializa.Text = "      INICIALIZA"
        Me.BtnInicializa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnInicializa.UseVisualStyleBackColor = False
        '
        'BtnGeneraDif
        '
        Me.BtnGeneraDif.BackColor = System.Drawing.Color.Transparent
        Me.BtnGeneraDif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnGeneraDif.FlatAppearance.BorderSize = 0
        Me.BtnGeneraDif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGeneraDif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGeneraDif.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGeneraDif.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnGeneraDif.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGeneraDif.ForeColor = System.Drawing.Color.White
        Me.BtnGeneraDif.IconChar = FontAwesome.Sharp.IconChar.Rocket
        Me.BtnGeneraDif.IconColor = System.Drawing.Color.White
        Me.BtnGeneraDif.IconSize = 32
        Me.BtnGeneraDif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGeneraDif.Location = New System.Drawing.Point(12, 297)
        Me.BtnGeneraDif.Name = "BtnGeneraDif"
        Me.BtnGeneraDif.Rotation = 0R
        Me.BtnGeneraDif.Size = New System.Drawing.Size(262, 37)
        Me.BtnGeneraDif.TabIndex = 23
        Me.BtnGeneraDif.Text = "      GENERA DIFERENCIAS"
        Me.BtnGeneraDif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGeneraDif.UseVisualStyleBackColor = False
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.Teal
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.Teal
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.Black
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.Color.Black
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(0, 385)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Quality = 10
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(643, 8)
        Me.BunifuGradientPanel3.TabIndex = 0
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(15, 19)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(61, 25)
        Me.BunifuCustomLabel1.TabIndex = 18
        Me.BunifuCustomLabel1.Text = "Fecha:"
        '
        'DatimeFecha
        '
        Me.DatimeFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DatimeFecha.BackColor = System.Drawing.Color.Transparent
        Me.DatimeFecha.BorderRadius = 3
        Me.DatimeFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DatimeFecha.ForeColor = System.Drawing.Color.White
        Me.DatimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DatimeFecha.FormatCustom = Nothing
        Me.DatimeFecha.Location = New System.Drawing.Point(18, 54)
        Me.DatimeFecha.Name = "DatimeFecha"
        Me.DatimeFecha.Size = New System.Drawing.Size(306, 36)
        Me.DatimeFecha.TabIndex = 17
        Me.DatimeFecha.Value = New Date(2020, 6, 8, 12, 22, 26, 649)
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(15, 104)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(78, 25)
        Me.BunifuCustomLabel2.TabIndex = 19
        Me.BunifuCustomLabel2.Text = "Almacen"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(15, 193)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(148, 25)
        Me.BunifuCustomLabel3.TabIndex = 21
        Me.BunifuCustomLabel3.Text = "Tipo de inventario:"
        '
        'CmbTipoInventario
        '
        Me.CmbTipoInventario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbTipoInventario.BackColor = System.Drawing.Color.Transparent
        Me.CmbTipoInventario.BorderRadius = 3
        Me.CmbTipoInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CmbTipoInventario.ForeColor = System.Drawing.Color.White
        Me.CmbTipoInventario.Items = New String() {"General", "Familia", "Seleccion de productos", "Ubicacion"}
        Me.CmbTipoInventario.Location = New System.Drawing.Point(18, 228)
        Me.CmbTipoInventario.Name = "CmbTipoInventario"
        Me.CmbTipoInventario.NomalColor = System.Drawing.Color.Transparent
        Me.CmbTipoInventario.onHoverColor = System.Drawing.Color.Transparent
        Me.CmbTipoInventario.selectedIndex = -1
        Me.CmbTipoInventario.Size = New System.Drawing.Size(306, 35)
        Me.CmbTipoInventario.TabIndex = 20
        '
        'CmbAlmacen
        '
        Me.CmbAlmacen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbAlmacen.BackColor = System.Drawing.Color.Transparent
        Me.CmbAlmacen.BorderRadius = 3
        Me.CmbAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CmbAlmacen.ForeColor = System.Drawing.Color.White
        Me.CmbAlmacen.Items = New String(-1) {}
        Me.CmbAlmacen.Location = New System.Drawing.Point(18, 139)
        Me.CmbAlmacen.Name = "CmbAlmacen"
        Me.CmbAlmacen.NomalColor = System.Drawing.Color.Transparent
        Me.CmbAlmacen.onHoverColor = System.Drawing.Color.Transparent
        Me.CmbAlmacen.selectedIndex = -1
        Me.CmbAlmacen.Size = New System.Drawing.Size(306, 35)
        Me.CmbAlmacen.TabIndex = 16
        '
        'DatePicker
        '
        Me.DatePicker.BackColor = System.Drawing.Color.Transparent
        Me.DatePicker.BorderRadius = 0
        Me.DatePicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DatePicker.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePicker.ForeColor = System.Drawing.Color.White
        Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker.FormatCustom = Nothing
        Me.DatePicker.Location = New System.Drawing.Point(124, 45)
        Me.DatePicker.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(313, 30)
        Me.DatePicker.TabIndex = 15
        Me.DatePicker.Value = New Date(2020, 6, 8, 11, 34, 20, 733)
        '
        'DropAlmacen
        '
        Me.DropAlmacen.BackColor = System.Drawing.Color.Transparent
        Me.DropAlmacen.BorderRadius = 15
        Me.DropAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DropAlmacen.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropAlmacen.ForeColor = System.Drawing.Color.White
        Me.DropAlmacen.Items = New String(-1) {}
        Me.DropAlmacen.Location = New System.Drawing.Point(124, 113)
        Me.DropAlmacen.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.DropAlmacen.Name = "DropAlmacen"
        Me.DropAlmacen.NomalColor = System.Drawing.Color.Transparent
        Me.DropAlmacen.onHoverColor = System.Drawing.Color.Transparent
        Me.DropAlmacen.selectedIndex = -1
        Me.DropAlmacen.Size = New System.Drawing.Size(313, 30)
        Me.DropAlmacen.TabIndex = 17
        '
        'DropTipoInventario
        '
        Me.DropTipoInventario.BackColor = System.Drawing.Color.Transparent
        Me.DropTipoInventario.BorderRadius = 15
        Me.DropTipoInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DropTipoInventario.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropTipoInventario.ForeColor = System.Drawing.Color.White
        Me.DropTipoInventario.Items = New String(-1) {}
        Me.DropTipoInventario.Location = New System.Drawing.Point(124, 182)
        Me.DropTipoInventario.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.DropTipoInventario.Name = "DropTipoInventario"
        Me.DropTipoInventario.NomalColor = System.Drawing.Color.Transparent
        Me.DropTipoInventario.onHoverColor = System.Drawing.Color.Transparent
        Me.DropTipoInventario.selectedIndex = -1
        Me.DropTipoInventario.Size = New System.Drawing.Size(313, 30)
        Me.DropTipoInventario.TabIndex = 18
        '
        'FormActualizacionInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 624)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Name = "FormActualizacionInventario"
        Me.Text = "FormActualizacionInventario"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuGradientPanel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents DatePicker As Bunifu.Framework.UI.BunifuDatepicker
    Private WithEvents DropAlmacen As Bunifu.Framework.UI.BunifuDropdown
    Private WithEvents DropTipoInventario As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents CmbTipoInventario As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DatimeFecha As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents CmbAlmacen As Bunifu.Framework.UI.BunifuDropdown
    Private WithEvents BtnAjustar As FontAwesome.Sharp.IconButton
    Private WithEvents BtnGeneraDif As FontAwesome.Sharp.IconButton
    Friend WithEvents LabelFlexTitulo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents FlexDrop As Bunifu.Framework.UI.BunifuDropdown
    Private WithEvents BtnInicializa As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuGradientPanel4 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel3 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
