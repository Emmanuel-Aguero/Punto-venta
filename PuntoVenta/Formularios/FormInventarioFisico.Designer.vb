<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventarioFisico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInventarioFisico))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.fileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BtnLoadFile = New FontAwesome.Sharp.IconButton()
        Me.DropSucursal = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BtnGuardarInventario = New FontAwesome.Sharp.IconButton()
        Me.GridDetalles = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.GridDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fileDialog
        '
        Me.fileDialog.FileName = "Archivo"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BtnGuardarInventario)
        Me.BunifuGradientPanel1.Controls.Add(Me.BtnLoadFile)
        Me.BunifuGradientPanel1.Controls.Add(Me.DropSucursal)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(311, 496)
        Me.BunifuGradientPanel1.TabIndex = 40
        '
        'BtnLoadFile
        '
        Me.BtnLoadFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.BtnLoadFile.Location = New System.Drawing.Point(16, 389)
        Me.BtnLoadFile.Name = "BtnLoadFile"
        Me.BtnLoadFile.Rotation = 0R
        Me.BtnLoadFile.Size = New System.Drawing.Size(276, 43)
        Me.BtnLoadFile.TabIndex = 13
        Me.BtnLoadFile.Text = "      Cargar archivo"
        Me.BtnLoadFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLoadFile.UseVisualStyleBackColor = False
        '
        'DropSucursal
        '
        Me.DropSucursal.BackColor = System.Drawing.Color.Transparent
        Me.DropSucursal.BorderRadius = 15
        Me.DropSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DropSucursal.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropSucursal.ForeColor = System.Drawing.Color.White
        Me.DropSucursal.Items = New String(-1) {}
        Me.DropSucursal.Location = New System.Drawing.Point(16, 34)
        Me.DropSucursal.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.DropSucursal.Name = "DropSucursal"
        Me.DropSucursal.NomalColor = System.Drawing.Color.Transparent
        Me.DropSucursal.onHoverColor = System.Drawing.Color.Transparent
        Me.DropSucursal.selectedIndex = -1
        Me.DropSucursal.Size = New System.Drawing.Size(276, 30)
        Me.DropSucursal.TabIndex = 12
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(11, 6)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(89, 26)
        Me.BunifuCustomLabel1.TabIndex = 1
        Me.BunifuCustomLabel1.Text = "Almacen:"
        '
        'BtnGuardarInventario
        '
        Me.BtnGuardarInventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.BtnGuardarInventario.Location = New System.Drawing.Point(16, 441)
        Me.BtnGuardarInventario.Name = "BtnGuardarInventario"
        Me.BtnGuardarInventario.Rotation = 0R
        Me.BtnGuardarInventario.Size = New System.Drawing.Size(277, 43)
        Me.BtnGuardarInventario.TabIndex = 14
        Me.BtnGuardarInventario.Text = "      Guardar Inventario"
        Me.BtnGuardarInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardarInventario.UseVisualStyleBackColor = False
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
        Me.GridDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
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
        Me.GridDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
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
        Me.GridDetalles.Location = New System.Drawing.Point(311, 0)
        Me.GridDetalles.MultiSelect = False
        Me.GridDetalles.Name = "GridDetalles"
        Me.GridDetalles.ReadOnly = True
        Me.GridDetalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridDetalles.RowHeadersVisible = False
        Me.GridDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridDetalles.Size = New System.Drawing.Size(691, 496)
        Me.GridDetalles.TabIndex = 41
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Producto"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Conteo"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'FormInventarioFisico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1002, 496)
        Me.Controls.Add(Me.GridDetalles)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Name = "FormInventarioFisico"
        Me.Text = "FormInventarioFisico"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.GridDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fileDialog As OpenFileDialog
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Private WithEvents BtnLoadFile As FontAwesome.Sharp.IconButton
    Private WithEvents DropSucursal As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents BtnGuardarInventario As FontAwesome.Sharp.IconButton
    Private WithEvents GridDetalles As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
