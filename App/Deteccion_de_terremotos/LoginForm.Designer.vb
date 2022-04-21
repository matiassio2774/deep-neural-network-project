<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.CBRecuerdame = New System.Windows.Forms.CheckBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.LblCrearCuenta = New System.Windows.Forms.LinkLabel()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImgMini = New System.Windows.Forms.PictureBox()
        Me.ImgCerrar = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnLogin.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnLogin.Location = New System.Drawing.Point(77, 315)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnLogin.Size = New System.Drawing.Size(181, 36)
        Me.BtnLogin.TabIndex = 10
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'CBRecuerdame
        '
        Me.CBRecuerdame.AutoSize = True
        Me.CBRecuerdame.Enabled = False
        Me.CBRecuerdame.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBRecuerdame.Location = New System.Drawing.Point(77, 281)
        Me.CBRecuerdame.Name = "CBRecuerdame"
        Me.CBRecuerdame.Size = New System.Drawing.Size(98, 20)
        Me.CBRecuerdame.TabIndex = 11
        Me.CBRecuerdame.Text = "Recuerdame"
        Me.CBRecuerdame.UseVisualStyleBackColor = True
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña.Location = New System.Drawing.Point(77, 242)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContraseña.Size = New System.Drawing.Size(181, 21)
        Me.TxtContraseña.TabIndex = 6
        '
        'LblCrearCuenta
        '
        Me.LblCrearCuenta.AutoSize = True
        Me.LblCrearCuenta.LinkColor = System.Drawing.Color.Navy
        Me.LblCrearCuenta.Location = New System.Drawing.Point(74, 369)
        Me.LblCrearCuenta.Name = "LblCrearCuenta"
        Me.LblCrearCuenta.Size = New System.Drawing.Size(196, 13)
        Me.LblCrearCuenta.TabIndex = 13
        Me.LblCrearCuenta.TabStop = True
        Me.LblCrearCuenta.Text = "¿No tienes una cuenta? Haz click aquí."
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(77, 178)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(181, 21)
        Me.TxtNombre.TabIndex = 4
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(74, 158)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(52, 17)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 33)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Bienvenido"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources.terremoto
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(138, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'ImgMini
        '
        Me.ImgMini.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources.window_minimize_icon_144028
        Me.ImgMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImgMini.Location = New System.Drawing.Point(269, -20)
        Me.ImgMini.Name = "ImgMini"
        Me.ImgMini.Size = New System.Drawing.Size(25, 46)
        Me.ImgMini.TabIndex = 17
        Me.ImgMini.TabStop = False
        '
        'ImgCerrar
        '
        Me.ImgCerrar.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources._1486395882_close_80604
        Me.ImgCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImgCerrar.Location = New System.Drawing.Point(299, 11)
        Me.ImgCerrar.Name = "ImgCerrar"
        Me.ImgCerrar.Size = New System.Drawing.Size(26, 24)
        Me.ImgCerrar.TabIndex = 16
        Me.ImgCerrar.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(336, 452)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ImgMini)
        Me.Controls.Add(Me.ImgCerrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblCrearCuenta)
        Me.Controls.Add(Me.CBRecuerdame)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents CBRecuerdame As CheckBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents LblCrearCuenta As LinkLabel
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ImgCerrar As PictureBox
    Friend WithEvents ImgMini As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
