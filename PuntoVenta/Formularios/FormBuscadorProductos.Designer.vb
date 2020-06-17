<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBuscadorProductos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtProducto = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.LabelProducto = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GridProductos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.ClDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CloseWindow = New System.Windows.Forms.PictureBox()
        Me.PanelCerrar = New System.Windows.Forms.Panel()
        Me.LabelTitulo = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.GridProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCerrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(25, 410)
        Me.Panel1.TabIndex = 0
        '
        'TxtProducto
        '
        Me.TxtProducto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtProducto.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProducto.ForeColor = System.Drawing.Color.Black
        Me.TxtProducto.HintForeColor = System.Drawing.Color.Empty
        Me.TxtProducto.HintText = ""
        Me.TxtProducto.isPassword = False
        Me.TxtProducto.LineFocusedColor = System.Drawing.Color.Teal
        Me.TxtProducto.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtProducto.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.TxtProducto.LineThickness = 4
        Me.TxtProducto.Location = New System.Drawing.Point(169, 38)
        Me.TxtProducto.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.Size = New System.Drawing.Size(581, 40)
        Me.TxtProducto.TabIndex = 53
        Me.TxtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LabelProducto
        '
        Me.LabelProducto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelProducto.AutoSize = True
        Me.LabelProducto.BackColor = System.Drawing.Color.Transparent
        Me.LabelProducto.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProducto.ForeColor = System.Drawing.Color.Gray
        Me.LabelProducto.Location = New System.Drawing.Point(56, 47)
        Me.LabelProducto.Name = "LabelProducto"
        Me.LabelProducto.Size = New System.Drawing.Size(105, 31)
        Me.LabelProducto.TabIndex = 56
        Me.LabelProducto.Text = "Producto:"
        '
        'GridProductos
        '
        Me.GridProductos.AllowUserToAddRows = False
        Me.GridProductos.AllowUserToDeleteRows = False
        Me.GridProductos.AllowUserToResizeColumns = False
        Me.GridProductos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = "DEFAULT"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridProductos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.GridProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClDescripcion, Me.ClPrecio, Me.ClIva, Me.ClCodigo})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridProductos.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridProductos.DoubleBuffered = True
        Me.GridProductos.EnableHeadersVisualStyles = False
        Me.GridProductos.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GridProductos.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.GridProductos.HeaderForeColor = System.Drawing.Color.White
        Me.GridProductos.Location = New System.Drawing.Point(62, 89)
        Me.GridProductos.MultiSelect = False
        Me.GridProductos.Name = "GridProductos"
        Me.GridProductos.ReadOnly = True
        Me.GridProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridProductos.RowHeadersVisible = False
        Me.GridProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridProductos.Size = New System.Drawing.Size(688, 309)
        Me.GridProductos.TabIndex = 57
        '
        'ClDescripcion
        '
        Me.ClDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ClDescripcion.HeaderText = "Descripcion"
        Me.ClDescripcion.Name = "ClDescripcion"
        Me.ClDescripcion.ReadOnly = True
        '
        'ClPrecio
        '
        Me.ClPrecio.HeaderText = "Precio"
        Me.ClPrecio.Name = "ClPrecio"
        Me.ClPrecio.ReadOnly = True
        '
        'ClIva
        '
        Me.ClIva.HeaderText = "Iva"
        Me.ClIva.Name = "ClIva"
        Me.ClIva.ReadOnly = True
        Me.ClIva.Width = 80
        '
        'ClCodigo
        '
        Me.ClCodigo.HeaderText = "Codigo"
        Me.ClCodigo.Name = "ClCodigo"
        Me.ClCodigo.ReadOnly = True
        Me.ClCodigo.Width = 150
        '
        'CloseWindow
        '
        Me.CloseWindow.BackgroundImage = Global.PuntoVenta.My.Resources.Resources.Icono_cerrar_FN
        Me.CloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseWindow.Location = New System.Drawing.Point(0, 0)
        Me.CloseWindow.Name = "CloseWindow"
        Me.CloseWindow.Size = New System.Drawing.Size(59, 28)
        Me.CloseWindow.TabIndex = 58
        Me.CloseWindow.TabStop = False
        '
        'PanelCerrar
        '
        Me.PanelCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.PanelCerrar.Controls.Add(Me.CloseWindow)
        Me.PanelCerrar.Location = New System.Drawing.Point(704, 0)
        Me.PanelCerrar.Name = "PanelCerrar"
        Me.PanelCerrar.Size = New System.Drawing.Size(59, 28)
        Me.PanelCerrar.TabIndex = 59
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitulo.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.Gray
        Me.LabelTitulo.Location = New System.Drawing.Point(281, 3)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(236, 31)
        Me.LabelTitulo.TabIndex = 60
        Me.LabelTitulo.Text = "Buscador de Productos"
        '
        'FormBuscadorProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 410)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.PanelCerrar)
        Me.Controls.Add(Me.GridProductos)
        Me.Controls.Add(Me.LabelProducto)
        Me.Controls.Add(Me.TxtProducto)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBuscadorProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBuscadorProductos"
        CType(Me.GridProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseWindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCerrar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtProducto As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents LabelProducto As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents GridProductos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ClDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents ClPrecio As DataGridViewTextBoxColumn
    Friend WithEvents ClIva As DataGridViewTextBoxColumn
    Friend WithEvents ClCodigo As DataGridViewTextBoxColumn
    Friend WithEvents CloseWindow As PictureBox
    Friend WithEvents PanelCerrar As Panel
    Friend WithEvents LabelTitulo As Bunifu.Framework.UI.BunifuCustomLabel
End Class
