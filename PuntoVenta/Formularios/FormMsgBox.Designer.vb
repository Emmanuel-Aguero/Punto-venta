<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMsgBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMsgBox))
        Me.bunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.LabelTitulo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.MsgCancelar = New FontAwesome.Sharp.IconButton()
        Me.MsgAceptar = New FontAwesome.Sharp.IconButton()
        Me.LabelMensaje = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bunifuGradientPanel1
        '
        Me.bunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("bunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuGradientPanel1.Controls.Add(Me.LabelTitulo)
        Me.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Teal
        Me.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Teal
        Me.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black
        Me.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black
        Me.bunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.bunifuGradientPanel1.Name = "bunifuGradientPanel1"
        Me.bunifuGradientPanel1.Quality = 10
        Me.bunifuGradientPanel1.Size = New System.Drawing.Size(490, 38)
        Me.bunifuGradientPanel1.TabIndex = 14
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitulo.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.White
        Me.LabelTitulo.Location = New System.Drawing.Point(5, 7)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(55, 26)
        Me.LabelTitulo.TabIndex = 12
        Me.LabelTitulo.Text = "Titulo"
        '
        'MsgCancelar
        '
        Me.MsgCancelar.BackColor = System.Drawing.Color.Transparent
        Me.MsgCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MsgCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.MsgCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.MsgCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.MsgCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MsgCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.MsgCancelar.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgCancelar.ForeColor = System.Drawing.Color.Silver
        Me.MsgCancelar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.MsgCancelar.IconColor = System.Drawing.Color.White
        Me.MsgCancelar.IconSize = 32
        Me.MsgCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MsgCancelar.Location = New System.Drawing.Point(221, 144)
        Me.MsgCancelar.Name = "MsgCancelar"
        Me.MsgCancelar.Rotation = 0R
        Me.MsgCancelar.Size = New System.Drawing.Size(128, 35)
        Me.MsgCancelar.TabIndex = 18
        Me.MsgCancelar.Text = "Cancelar"
        Me.MsgCancelar.UseVisualStyleBackColor = False
        '
        'MsgAceptar
        '
        Me.MsgAceptar.BackColor = System.Drawing.Color.Transparent
        Me.MsgAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MsgAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.MsgAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.MsgAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.MsgAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MsgAceptar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.MsgAceptar.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgAceptar.ForeColor = System.Drawing.Color.Silver
        Me.MsgAceptar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.MsgAceptar.IconColor = System.Drawing.Color.White
        Me.MsgAceptar.IconSize = 32
        Me.MsgAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MsgAceptar.Location = New System.Drawing.Point(355, 144)
        Me.MsgAceptar.Name = "MsgAceptar"
        Me.MsgAceptar.Rotation = 0R
        Me.MsgAceptar.Size = New System.Drawing.Size(128, 35)
        Me.MsgAceptar.TabIndex = 17
        Me.MsgAceptar.Text = "Aceptar"
        Me.MsgAceptar.UseVisualStyleBackColor = False
        '
        'LabelMensaje
        '
        Me.LabelMensaje.AutoSize = True
        Me.LabelMensaje.BackColor = System.Drawing.Color.Transparent
        Me.LabelMensaje.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMensaje.ForeColor = System.Drawing.Color.Silver
        Me.LabelMensaje.Location = New System.Drawing.Point(7, 50)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(354, 31)
        Me.LabelMensaje.TabIndex = 16
        Me.LabelMensaje.Text = "No hay registros para su busqueda"
        '
        'FormMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 186)
        Me.Controls.Add(Me.MsgCancelar)
        Me.Controls.Add(Me.MsgAceptar)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.bunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMsgBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMsgBox"
        Me.bunifuGradientPanel1.ResumeLayout(False)
        Me.bunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents bunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Private WithEvents LabelTitulo As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents MsgCancelar As FontAwesome.Sharp.IconButton
    Private WithEvents MsgAceptar As FontAwesome.Sharp.IconButton
    Private WithEvents LabelMensaje As Bunifu.Framework.UI.BunifuCustomLabel
End Class
