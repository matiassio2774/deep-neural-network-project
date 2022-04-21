<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Encuesta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBZona = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RBSi = New System.Windows.Forms.RadioButton()
        Me.RBNo = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBMagnitud = New System.Windows.Forms.ComboBox()
        Me.BtnPredecir = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBProfundidad = New System.Windows.Forms.ComboBox()
        Me.ImgMini = New System.Windows.Forms.PictureBox()
        Me.ImgCerrar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ImgMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'CBZona
        '
        Me.CBZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBZona.Enabled = False
        Me.CBZona.FormattingEnabled = True
        Me.CBZona.Items.AddRange(New Object() {"Alameda", "Ejido Jiquilpan", "Los Angeles", "Mono", "Moss Landing", "Riverside", "Sacramento", "San Benito", "San Francisco", "Ventura"})
        Me.CBZona.Location = New System.Drawing.Point(242, 63)
        Me.CBZona.Name = "CBZona"
        Me.CBZona.Size = New System.Drawing.Size(118, 21)
        Me.CBZona.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(93, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "¿En que zona vive?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(93, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 51)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "¿Ha ocurrido un" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sismo/terremoto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en las ultimas 24hs?"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RBSi
        '
        Me.RBSi.AutoSize = True
        Me.RBSi.Enabled = False
        Me.RBSi.Location = New System.Drawing.Point(242, 128)
        Me.RBSi.Name = "RBSi"
        Me.RBSi.Size = New System.Drawing.Size(34, 17)
        Me.RBSi.TabIndex = 8
        Me.RBSi.TabStop = True
        Me.RBSi.Text = "Si"
        Me.RBSi.UseVisualStyleBackColor = True
        '
        'RBNo
        '
        Me.RBNo.AutoSize = True
        Me.RBNo.Enabled = False
        Me.RBNo.Location = New System.Drawing.Point(282, 128)
        Me.RBNo.Name = "RBNo"
        Me.RBNo.Size = New System.Drawing.Size(39, 17)
        Me.RBNo.TabIndex = 9
        Me.RBNo.TabStop = True
        Me.RBNo.Text = "No"
        Me.RBNo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(93, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "¿De que magnitud?"
        '
        'CBMagnitud
        '
        Me.CBMagnitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMagnitud.Enabled = False
        Me.CBMagnitud.FormattingEnabled = True
        Me.CBMagnitud.Items.AddRange(New Object() {"2.0", "2.1", "2.2", "2.3", "2.4", "2.5", "2.6", "2.7", "2.8", "2.9", "3.0", "3.1", "3.2", "3.3", "3.4", "3.5", "3.6", "3.7", "3.8", "3.9", "4.0", "4.1", "4.2", "4.3", "4.4", "4.5", "4.6", "4.7", "4.8", "4.9", "5.0", "5.1", "5.2", "5.3", "5.4", "5.5", "5.6", "5.7", "5.8", "5.9", "6.0", "6.1", "6.2", "6.3", "6.4", "6.5", "6.6", "6.7", "6.8", "6.9", "7.0", "7.1", "7.2", "7.3", "7.4", "7.5", "7.6", "7.7", "7.8", "7.9", "8.0"})
        Me.CBMagnitud.Location = New System.Drawing.Point(242, 194)
        Me.CBMagnitud.Name = "CBMagnitud"
        Me.CBMagnitud.Size = New System.Drawing.Size(118, 21)
        Me.CBMagnitud.TabIndex = 10
        '
        'BtnPredecir
        '
        Me.BtnPredecir.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPredecir.Enabled = False
        Me.BtnPredecir.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPredecir.ForeColor = System.Drawing.Color.White
        Me.BtnPredecir.Location = New System.Drawing.Point(96, 294)
        Me.BtnPredecir.Name = "BtnPredecir"
        Me.BtnPredecir.Size = New System.Drawing.Size(264, 32)
        Me.BtnPredecir.TabIndex = 12
        Me.BtnPredecir.Text = "Predecir"
        Me.BtnPredecir.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(98, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Aprox profundidad:"
        '
        'CBProfundidad
        '
        Me.CBProfundidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBProfundidad.Enabled = False
        Me.CBProfundidad.FormattingEnabled = True
        Me.CBProfundidad.Items.AddRange(New Object() {"2.0", "3.0", "4.0", "5.0", "6.0", "7.0", "8.0", "9.0", "10.0", "11.0", "12.0", "13.0", "14.0", "15.0", "16.0", "17.0", "18.0", "19.0", "20.0", "21.0", "22.0", "23.0", "24.0", "25.0", "26.0", "27.0", "28.0", "29.0", "30.0", "31.0", "32.0"})
        Me.CBProfundidad.Location = New System.Drawing.Point(242, 245)
        Me.CBProfundidad.Name = "CBProfundidad"
        Me.CBProfundidad.Size = New System.Drawing.Size(118, 21)
        Me.CBProfundidad.TabIndex = 13
        '
        'ImgMini
        '
        Me.ImgMini.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources.window_minimize_icon_144028
        Me.ImgMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImgMini.Location = New System.Drawing.Point(380, -19)
        Me.ImgMini.Name = "ImgMini"
        Me.ImgMini.Size = New System.Drawing.Size(25, 46)
        Me.ImgMini.TabIndex = 21
        Me.ImgMini.TabStop = False
        '
        'ImgCerrar
        '
        Me.ImgCerrar.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources._1486395882_close_80604
        Me.ImgCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImgCerrar.Location = New System.Drawing.Point(410, 12)
        Me.ImgCerrar.Name = "ImgCerrar"
        Me.ImgCerrar.Size = New System.Drawing.Size(26, 24)
        Me.ImgCerrar.TabIndex = 20
        Me.ImgCerrar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Deteccion_de_terremotos.My.Resources.Resources.curved_returing_arrow_icon_193344
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 39)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Encuesta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(448, 362)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ImgMini)
        Me.Controls.Add(Me.ImgCerrar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CBProfundidad)
        Me.Controls.Add(Me.BtnPredecir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBMagnitud)
        Me.Controls.Add(Me.RBNo)
        Me.Controls.Add(Me.RBSi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBZona)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Encuesta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.ImgMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CBZona As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RBSi As RadioButton
    Friend WithEvents RBNo As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents CBMagnitud As ComboBox
    Friend WithEvents BtnPredecir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents CBProfundidad As ComboBox
    Friend WithEvents ImgMini As PictureBox
    Friend WithEvents ImgCerrar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
