<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.ImgMini = New System.Windows.Forms.PictureBox()
        Me.ImgCerrar = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRegister
        '
        Me.BtnRegister.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnRegister.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegister.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnRegister.Location = New System.Drawing.Point(75, 302)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnRegister.Size = New System.Drawing.Size(181, 36)
        Me.BtnRegister.TabIndex = 29
        Me.BtnRegister.Text = "Registrar"
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources.terremoto
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(141, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 33)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Registrate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Contraseña"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña.Location = New System.Drawing.Point(75, 244)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContraseña.Size = New System.Drawing.Size(181, 21)
        Me.TxtContraseña.TabIndex = 33
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(75, 175)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(181, 21)
        Me.TxtNombre.TabIndex = 31
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(72, 155)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(52, 17)
        Me.LblNombre.TabIndex = 30
        Me.LblNombre.Text = "Cuenta"
        '
        'ImgMini
        '
        Me.ImgMini.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources.window_minimize_icon_144028
        Me.ImgMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImgMini.Location = New System.Drawing.Point(272, -19)
        Me.ImgMini.Name = "ImgMini"
        Me.ImgMini.Size = New System.Drawing.Size(25, 46)
        Me.ImgMini.TabIndex = 39
        Me.ImgMini.TabStop = False
        '
        'ImgCerrar
        '
        Me.ImgCerrar.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources._1486395882_close_80604
        Me.ImgCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImgCerrar.Location = New System.Drawing.Point(302, 12)
        Me.ImgCerrar.Name = "ImgCerrar"
        Me.ImgCerrar.Size = New System.Drawing.Size(26, 24)
        Me.ImgCerrar.TabIndex = 38
        Me.ImgCerrar.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources.curved_returing_arrow_icon_193344
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 39)
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(340, 389)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ImgMini)
        Me.Controls.Add(Me.ImgCerrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.BtnRegister)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRegister As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents ImgMini As PictureBox
    Friend WithEvents ImgCerrar As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
