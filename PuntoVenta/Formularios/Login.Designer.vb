<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtContraseña = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DragForm = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.CmbUsuarios = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.LabelSideBar = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.MinimizeWindow = New FontAwesome.Sharp.IconPictureBox()
        Me.CloseWindow = New FontAwesome.Sharp.IconPictureBox()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimizeWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(305, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "INICIO DE SESIÓN"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtContraseña.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TxtContraseña.ForeColor = System.Drawing.Color.White
        Me.TxtContraseña.HintForeColor = System.Drawing.Color.White
        Me.TxtContraseña.HintText = "Contraseña"
        Me.TxtContraseña.isPassword = True
        Me.TxtContraseña.LineFocusedColor = System.Drawing.Color.White
        Me.TxtContraseña.LineIdleColor = System.Drawing.Color.White
        Me.TxtContraseña.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.TxtContraseña.LineThickness = 3
        Me.TxtContraseña.Location = New System.Drawing.Point(253, 135)
        Me.TxtContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(299, 44)
        Me.TxtContraseña.TabIndex = 14
        Me.TxtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(253, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(299, 48)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "ACCEDER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DragForm
        '
        Me.DragForm.Fixed = True
        Me.DragForm.Horizontal = True
        Me.DragForm.TargetControl = Me
        Me.DragForm.Vertical = True
        '
        'CmbUsuarios
        '
        Me.CmbUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.CmbUsuarios.BorderRadius = 3
        Me.CmbUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CmbUsuarios.ForeColor = System.Drawing.Color.White
        Me.CmbUsuarios.Items = New String(-1) {}
        Me.CmbUsuarios.Location = New System.Drawing.Point(253, 89)
        Me.CmbUsuarios.Name = "CmbUsuarios"
        Me.CmbUsuarios.NomalColor = System.Drawing.Color.Transparent
        Me.CmbUsuarios.onHoverColor = System.Drawing.Color.Transparent
        Me.CmbUsuarios.selectedIndex = -1
        Me.CmbUsuarios.Size = New System.Drawing.Size(299, 35)
        Me.CmbUsuarios.TabIndex = 16
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.LabelSideBar)
        Me.BunifuGradientPanel1.Controls.Add(Me.IconPictureBox1)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Teal
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Teal
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(217, 298)
        Me.BunifuGradientPanel1.TabIndex = 9
        '
        'LabelSideBar
        '
        Me.LabelSideBar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelSideBar.AutoSize = True
        Me.LabelSideBar.BackColor = System.Drawing.Color.Transparent
        Me.LabelSideBar.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSideBar.ForeColor = System.Drawing.Color.White
        Me.LabelSideBar.Location = New System.Drawing.Point(12, 251)
        Me.LabelSideBar.Name = "LabelSideBar"
        Me.LabelSideBar.Size = New System.Drawing.Size(181, 34)
        Me.LabelSideBar.TabIndex = 2
        Me.LabelSideBar.Text = "ALISER SA DE CV"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.BackgroundImage = Global.PuntoVenta.My.Resources.Resources.logo
        Me.IconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconSize = 129
        Me.IconPictureBox1.Location = New System.Drawing.Point(16, 23)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(180, 129)
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'MinimizeWindow
        '
        Me.MinimizeWindow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizeWindow.BackColor = System.Drawing.Color.Transparent
        Me.MinimizeWindow.BackgroundImage = Global.PuntoVenta.My.Resources.Resources.Icono_Minimizar
        Me.MinimizeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MinimizeWindow.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MinimizeWindow.IconChar = FontAwesome.Sharp.IconChar.None
        Me.MinimizeWindow.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.MinimizeWindow.IconSize = 25
        Me.MinimizeWindow.Location = New System.Drawing.Point(537, 4)
        Me.MinimizeWindow.Name = "MinimizeWindow"
        Me.MinimizeWindow.Size = New System.Drawing.Size(25, 25)
        Me.MinimizeWindow.TabIndex = 7
        Me.MinimizeWindow.TabStop = False
        '
        'CloseWindow
        '
        Me.CloseWindow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseWindow.BackColor = System.Drawing.Color.Transparent
        Me.CloseWindow.BackgroundImage = Global.PuntoVenta.My.Resources.Resources.Icono_cerrar_FN
        Me.CloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseWindow.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CloseWindow.IconChar = FontAwesome.Sharp.IconChar.None
        Me.CloseWindow.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.CloseWindow.IconSize = 25
        Me.CloseWindow.Location = New System.Drawing.Point(568, 4)
        Me.CloseWindow.Name = "CloseWindow"
        Me.CloseWindow.Size = New System.Drawing.Size(25, 25)
        Me.CloseWindow.TabIndex = 8
        Me.CloseWindow.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(597, 298)
        Me.Controls.Add(Me.CmbUsuarios)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.MinimizeWindow)
        Me.Controls.Add(Me.CloseWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinimizeWindow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseWindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents MinimizeWindow As FontAwesome.Sharp.IconPictureBox
    Private WithEvents CloseWindow As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Private WithEvents LabelSideBar As Label
    Private WithEvents Label1 As Label
    Friend WithEvents TxtContraseña As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Button1 As Button
    Friend WithEvents DragForm As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents CmbUsuarios As Bunifu.Framework.UI.BunifuDropdown
End Class
