Public Class App
    Private Sub BtnEncuesta_Click(sender As Object, e As EventArgs) Handles BtnEncuesta.Click

        Me.Hide()
        Encuesta.Show()

    End Sub

    Private Sub App_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Environment.Exit(1)
    End Sub

    Private Sub BtnHistorial_Click(sender As Object, e As EventArgs) Handles BtnHistorial.Click
        Me.Hide()
        VerHistorial.Show()
    End Sub

    Private Sub ImgCerrar_Click(sender As Object, e As EventArgs) Handles ImgCerrar.Click
        Me.Close()
    End Sub

    Private Sub ImgMini_Click(sender As Object, e As EventArgs) Handles ImgMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnHistorial.FlatStyle = FlatStyle.Flat
        BtnHistorial.FlatAppearance.BorderSize = 0

        BtnEncuesta.FlatStyle = FlatStyle.Flat
        BtnEncuesta.FlatAppearance.BorderSize = 0
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

    Private Sub LoginForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub
End Class