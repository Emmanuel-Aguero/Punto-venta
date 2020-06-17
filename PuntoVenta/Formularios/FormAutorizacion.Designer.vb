<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAutorizacion
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.LabelAutorizacion = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TxtAutorizacion = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BtnAceptar = New FontAwesome.Sharp.IconButton()
        Me.BtnCancelar = New FontAwesome.Sharp.IconButton()
        Me.LabelError = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(14, 136)
        Me.Panel1.TabIndex = 0
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Key
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IconPictureBox1.IconSize = 38
        Me.IconPictureBox1.Location = New System.Drawing.Point(21, 4)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(39, 38)
        Me.IconPictureBox1.TabIndex = 1
        Me.IconPictureBox1.TabStop = False
        '
        'LabelAutorizacion
        '
        Me.LabelAutorizacion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelAutorizacion.AutoSize = True
        Me.LabelAutorizacion.BackColor = System.Drawing.Color.Transparent
        Me.LabelAutorizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelAutorizacion.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAutorizacion.ForeColor = System.Drawing.Color.Black
        Me.LabelAutorizacion.Location = New System.Drawing.Point(139, 11)
        Me.LabelAutorizacion.Name = "LabelAutorizacion"
        Me.LabelAutorizacion.Size = New System.Drawing.Size(204, 21)
        Me.LabelAutorizacion.TabIndex = 51
        Me.LabelAutorizacion.Text = "Ingrese Clave de Autorización"
        '
        'TxtAutorizacion
        '
        Me.TxtAutorizacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAutorizacion.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAutorizacion.ForeColor = System.Drawing.Color.Black
        Me.TxtAutorizacion.HintForeColor = System.Drawing.Color.Empty
        Me.TxtAutorizacion.HintText = ""
        Me.TxtAutorizacion.isPassword = False
        Me.TxtAutorizacion.LineFocusedColor = System.Drawing.Color.Teal
        Me.TxtAutorizacion.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtAutorizacion.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.TxtAutorizacion.LineThickness = 3
        Me.TxtAutorizacion.Location = New System.Drawing.Point(138, 33)
        Me.TxtAutorizacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtAutorizacion.Name = "TxtAutorizacion"
        Me.TxtAutorizacion.Size = New System.Drawing.Size(214, 38)
        Me.TxtAutorizacion.TabIndex = 52
        Me.TxtAutorizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnAceptar.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.Color.Silver
        Me.BtnAceptar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnAceptar.IconColor = System.Drawing.Color.White
        Me.BtnAceptar.IconSize = 32
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(248, 104)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Rotation = 0R
        Me.BtnAceptar.Size = New System.Drawing.Size(104, 26)
        Me.BtnAceptar.TabIndex = 53
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnCancelar.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Silver
        Me.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnCancelar.IconColor = System.Drawing.Color.White
        Me.BtnCancelar.IconSize = 32
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(138, 104)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Rotation = 0R
        Me.BtnCancelar.Size = New System.Drawing.Size(104, 26)
        Me.BtnCancelar.TabIndex = 54
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'LabelError
        '
        Me.LabelError.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelError.AutoSize = True
        Me.LabelError.BackColor = System.Drawing.Color.Transparent
        Me.LabelError.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelError.Font = New System.Drawing.Font("Poppins", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(157, 76)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(195, 18)
        Me.LabelError.TabIndex = 55
        Me.LabelError.Text = "* No se permiten campos vacios *"
        Me.LabelError.Visible = False
        '
        'FormAutorizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 136)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtAutorizacion)
        Me.Controls.Add(Me.LabelAutorizacion)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAutorizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAutorizacion"
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents LabelAutorizacion As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TxtAutorizacion As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents BtnAceptar As FontAwesome.Sharp.IconButton
    Private WithEvents BtnCancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents LabelError As Bunifu.Framework.UI.BunifuCustomLabel
End Class
