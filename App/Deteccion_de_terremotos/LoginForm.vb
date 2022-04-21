Imports MySql.Data.MySqlClient
Public Class LoginForm
    Public user As Usuario

    Private Sub LblCrearCuenta_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblCrearCuenta.LinkClicked

        RegisterForm.Show()
        Me.Close()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        user = New Usuario(TxtNombre.Text, TxtContraseña.Text)

        If user.login(TxtNombre.Text, TxtContraseña.Text) = 1 Then

            'MsgBox("Bienvenido " + VectorUsuarios(contador).Nombre)

            App.LblUser.Text = user.Cuenta


            Me.Hide()
            App.Show()

        Else
            If user.login(TxtNombre.Text, TxtContraseña.Text) = 0 Then
                MsgBox("La cuenta no existe.")
            Else
                MsgBox("No puede usar esos caracteres.")
            End If
        End If


    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnLogin.FlatStyle = FlatStyle.Flat
        BtnLogin.FlatAppearance.BorderSize = 0

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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub



    'Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
    '    If Mid(TxtNombre.Text, Len(Trim(TxtNombre.Text)), 1) >= "A" And
    '        Mid(TxtNombre.Text, Len(Trim(TxtNombre.Text)), 1) <= "Z" Then
    '        MsgBox("SI")
    '    Else
    '        MsgBox("NO")
    '    End If
    'End Sub

    Private Sub LoginForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub

End Class
