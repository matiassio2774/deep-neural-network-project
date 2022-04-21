<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class App
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
        Me.BtnEncuesta = New System.Windows.Forms.Button()
        Me.BtnHistorial = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImgMini = New System.Windows.Forms.PictureBox()
        Me.ImgCerrar = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEncuesta
        '
        Me.BtnEncuesta.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnEncuesta.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.BtnEncuesta.ForeColor = System.Drawing.Color.White
        Me.BtnEncuesta.Location = New System.Drawing.Point(117, 164)
        Me.BtnEncuesta.Name = "BtnEncuesta"
        Me.BtnEncuesta.Size = New System.Drawing.Size(232, 64)
        Me.BtnEncuesta.TabIndex = 0
        Me.BtnEncuesta.Text = "Averiguar Terremoto"
        Me.BtnEncuesta.UseVisualStyleBackColor = False
        '
        'BtnHistorial
        '
        Me.BtnHistorial.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnHistorial.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.BtnHistorial.ForeColor = System.Drawing.Color.White
        Me.BtnHistorial.Location = New System.Drawing.Point(117, 266)
        Me.BtnHistorial.Name = "BtnHistorial"
        Me.BtnHistorial.Size = New System.Drawing.Size(232, 64)
        Me.BtnHistorial.TabIndex = 1
        Me.BtnHistorial.Text = "Ver Historial"
        Me.BtnHistorial.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "DT"
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.Location = New System.Drawing.Point(195, 126)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(39, 18)
        Me.LblUser.TabIndex = 22
        Me.LblUser.Text = "User"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources.user_icon_icons_com_57997
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(170, 121)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 27)
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources.terremoto
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 62)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'ImgMini
        '
        Me.ImgMini.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources.window_minimize_icon_144028
        Me.ImgMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImgMini.Location = New System.Drawing.Point(399, -19)
        Me.ImgMini.Name = "ImgMini"
        Me.ImgMini.Size = New System.Drawing.Size(25, 46)
        Me.ImgMini.TabIndex = 19
        Me.ImgMini.TabStop = False
        '
        'ImgCerrar
        '
        Me.ImgCerrar.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources._1486395882_close_80604
        Me.ImgCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImgCerrar.Location = New System.Drawing.Point(429, 12)
        Me.ImgCerrar.Name = "ImgCerrar"
        Me.ImgCerrar.Size = New System.Drawing.Size(26, 24)
        Me.ImgCerrar.TabIndex = 18
        Me.ImgCerrar.TabStop = False
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(470, 457)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ImgMini)
        Me.Controls.Add(Me.ImgCerrar)
        Me.Controls.Add(Me.BtnHistorial)
        Me.Controls.Add(Me.BtnEncuesta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "App"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "App"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEncuesta As Button
    Friend WithEvents BtnHistorial As Button
    Friend WithEvents ImgMini As PictureBox
    Friend WithEvents ImgCerrar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblUser As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
