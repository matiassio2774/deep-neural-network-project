Public Class RegisterForm


    Private Sub BtnRegister_Click_1(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Try

            Dim new_user = New Usuario(TxtNombre.Text, TxtContraseña.Text)

            If new_user.register(TxtNombre.Text, TxtContraseña.Text) = 1 Then

                MsgBox("Usuario registrado correctamente", MsgBoxStyle.Information, "Registro")

                Me.Hide()
                LoginForm.Show()
            Else
                If new_user.register(TxtNombre.Text, TxtContraseña.Text) = 0 Then
                    MsgBox("La cuenta ya existe")
                Else
                    MsgBox("No puede usar esos caracteres.")
                End If

            End If

        Catch ex As Exception
            MsgBox("Error al registrar el usuario" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Registro")
        End Try
    End Sub


    Private Sub Register_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Environment.Exit(1)
    End Sub

    Private Sub ImgCerrar_Click(sender As Object, e As EventArgs) Handles ImgCerrar.Click
        Me.Close()
    End Sub

    Private Sub ImgMini_Click(sender As Object, e As EventArgs) Handles ImgMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub





    'Lo de abajo es para mover el formulario ya que no tiene bordes ni barra de titulo.

    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Private Sub LoginForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub LoginForm_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub LoginForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub
End Class