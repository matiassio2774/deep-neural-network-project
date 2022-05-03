<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerHistorial
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
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImgMini = New System.Windows.Forms.PictureBox()
        Me.ImgCerrar = New System.Windows.Forms.PictureBox()
        Me.LVHistorial = New System.Windows.Forms.ListView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(63, 42)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(167, 22)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "                  Historial"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(199, 362)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ultimas Predicciones"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(67, 362)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Terremotos Historicos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources.curved_returing_arrow_icon_193344
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 39)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ImgMini
        '
        Me.ImgMini.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources.window_minimize_icon_144028
        Me.ImgMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImgMini.Location = New System.Drawing.Point(334, -19)
        Me.ImgMini.Name = "ImgMini"
        Me.ImgMini.Size = New System.Drawing.Size(25, 46)
        Me.ImgMini.TabIndex = 41
        Me.ImgMini.TabStop = False
        '
        'ImgCerrar
        '
        Me.ImgCerrar.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources._1486395882_close_80604
        Me.ImgCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImgCerrar.Location = New System.Drawing.Point(364, 12)
        Me.ImgCerrar.Name = "ImgCerrar"
        Me.ImgCerrar.Size = New System.Drawing.Size(26, 24)
        Me.ImgCerrar.TabIndex = 40
        Me.ImgCerrar.TabStop = False
        '
        'LVHistorial
        '
        Me.LVHistorial.HideSelection = False
        Me.LVHistorial.Location = New System.Drawing.Point(67, 100)
        Me.LVHistorial.Name = "LVHistorial"
        Me.LVHistorial.Size = New System.Drawing.Size(259, 224)
        Me.LVHistorial.TabIndex = 42
        Me.LVHistorial.UseCompatibleStateImageBehavior = False
        '
        'VerHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(402, 433)
        Me.Controls.Add(Me.LVHistorial)
        Me.Controls.Add(Me.ImgMini)
        Me.Controls.Add(Me.ImgCerrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerHistorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VerHistorial"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImgMini As PictureBox
    Friend WithEvents ImgCerrar As PictureBox
    Friend WithEvents LVHistorial As ListView
End Class
