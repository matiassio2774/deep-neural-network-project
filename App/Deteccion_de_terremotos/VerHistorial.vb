Public Class VerHistorial
    Private Sub VerHistorial_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Environment.Exit(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LVHistorial.Clear()

        LblTitulo.Text = "Historial de Predicciones"

        LVHistorial.View = View.Details

        LVHistorial.Columns.Add("Usuario")
        LVHistorial.Columns.Add("Fecha")
        LVHistorial.Columns.Add("Resultado")

        LVHistorial.Columns(0).Width = 80
        LVHistorial.Columns(1).Width = 70
        LVHistorial.Columns(2).Width = 80

        Dim historial As New Historial_Predicciones

        Dim lista As New List(Of String())

        lista = historial.informarPrediccion()

        Dim tamaño As Integer = lista.Count()

        Dim temp(2) As String

        For i As Integer = 0 To tamaño - 1

            For k = 0 To 2
                temp(k) = lista(i)(k).ToString
            Next

            Dim item = New ListViewItem({temp(0), temp(1), temp(2)})
            LVHistorial.Items.Add(item)
        Next

    End Sub

    Private Sub LBHistorial_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        LblTitulo.Text = "Historial de terremotos"

        LVHistorial.Clear()

        LVHistorial.View = View.Details

        LVHistorial.Columns.Add("Fecha")
        LVHistorial.Columns.Add("Hora")
        LVHistorial.Columns.Add("Magnitud")
        LVHistorial.Columns.Add("Profundidad")
        LVHistorial.Columns.Add("Zona")

        LVHistorial.Columns(0).Width = 80
        LVHistorial.Columns(1).Width = 55
        LVHistorial.Columns(2).Width = 60
        LVHistorial.Columns(3).Width = 40
        LVHistorial.Columns(4).Width = 100


        Dim TS As TimeSpan = New TimeSpan(0, 0, 0, 0)
        Dim DT As Date = #1/1/1 11:11 PM#

        Dim terremoto As New Terremoto(DT, TS, 0, 0, 0)

        Dim lista As New List(Of Terremoto)

        lista = terremoto.informarTerremoto()

        Dim tamaño As Integer = lista.Count()

        Dim temp(4) As String

        For i As Integer = 0 To tamaño - 1

            temp(0) = lista(i).tFecha
            temp(1) = lista(i).tHora.ToString()
            temp(2) = lista(i).tMagnitud.ToString()
            temp(3) = lista(i).tProfundidad.ToString()
            temp(4) = lista(i).tZona.ToString()

            Dim item = New ListViewItem({temp(0), temp(1), temp(2), temp(3), temp(4)})
            LVHistorial.Items.Add(item)
        Next

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
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

    Private Sub VerHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub
End Class