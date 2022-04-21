Public Class Encuesta
    Private Sub RBSi_CheckedChanged(sender As Object, e As EventArgs) Handles RBSi.CheckedChanged
        CBMagnitud.Enabled = True
    End Sub

    Private Sub Encuesta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnPredecir.FlatStyle = FlatStyle.Flat
        BtnPredecir.FlatAppearance.BorderSize = 0
        CBZona.Enabled = True
    End Sub

    Private Sub RBNo_CheckedChanged(sender As Object, e As EventArgs) Handles RBNo.CheckedChanged
        CBMagnitud.Enabled = False
    End Sub

    Private Sub CBZona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBZona.SelectedIndexChanged
        RBSi.Enabled = True
        RBNo.Enabled = True
    End Sub

    Private Sub CBMagnitud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMagnitud.SelectedIndexChanged
        CBProfundidad.Enabled = True
    End Sub

    Private Sub CBProfundidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBProfundidad.SelectedIndexChanged
        BtnPredecir.Enabled = True
    End Sub



    Private Sub Encuesta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Environment.Exit(1)
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs)
        Me.Close()
        App.Show()
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        App.Show()
    End Sub

    Private Sub BtnPredecir_Click(sender As Object, e As EventArgs) Handles BtnPredecir.Click
        Dim Zona As String = CBZona.SelectedItem.ToString()
        Dim Magnitud As Double = Val(CBMagnitud.SelectedItem)
        Dim Profundidad As Double = Val(CBProfundidad.SelectedItem)

        Dim pred As New Predictor
        If pred.solicitarEncuesta(Zona, Magnitud, Profundidad, LoginForm.user.Cuenta) <= 0.5 Then
            MsgBox("El sistema pronosticó que no ocurrirá un terremoto en las próximas 24hs.")
        Else
            MsgBox("El sistema pronosticó que ocurrirá un terremoto (M +4) en las próximas 24hs.")
        End If

        'MsgBox(Str(pred.solicitarEncuesta(Zona, Magnitud, Profundidad)))
    End Sub

    Private Sub LoginForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub
End Class
