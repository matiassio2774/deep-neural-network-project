Public Class Terremoto
    Private _tFecha As Date
    Private _tHora As TimeSpan
    Private _tMagnitud As Single
    Private _tProfundidad As Single
    Private _tZona As String

    Public Sub New(ttFecha As Date, ttHora As TimeSpan, ttMagnitud As Single, ttProfundidad As Single, ttZona As String)
        tFecha = ttFecha
        tHora = ttHora
        tMagnitud = ttMagnitud
        tProfundidad = ttProfundidad
        tZona = ttZona
    End Sub

    Public Property tFecha As Date
        Get
            Return _tFecha
        End Get
        Set(value As Date)
            _tFecha = value
        End Set
    End Property

    Public Property tHora As TimeSpan
        Get
            Return _tHora
        End Get
        Set(value As TimeSpan)
            _tHora = value
        End Set
    End Property

    Public Property tMagnitud As Single
        Get
            Return _tMagnitud
        End Get
        Set(value As Single)
            _tMagnitud = value
        End Set
    End Property

    Public Property tProfundidad As Single
        Get
            Return _tProfundidad
        End Get
        Set(value As Single)
            _tProfundidad = value
        End Set
    End Property

    Public Property tZona As String
        Get
            Return _tZona
        End Get
        Set(value As String)
            _tZona = value
        End Set
    End Property

    Public Function informarTerremoto() As List(Of Terremoto)

        Dim conex As New ConectaSQL
        Dim sql As String

        Dim contador As Integer = 0
        Dim VectorTerremotos(contador) As Terremoto

        Dim arrays As New List(Of Terremoto)

        sql = "CALL dt.mostrar_historial;"
        conex.EjecutasSql(sql)

        Dim dr = conex.micomando.ExecuteReader()

        While dr.Read()

            tFecha = dr(1)
            tHora = dr(2)
            tMagnitud = dr(3)
            tProfundidad = dr(4)
            tZona = dr(5)

            VectorTerremotos(contador) = New Terremoto(tFecha, tHora, tMagnitud, tProfundidad, tZona)
            Dim linea As String = " " + tFecha + "  " + tHora.ToString() + "    " + Strings.Left(Str(tMagnitud), 4) + "            " + Strings.Left(Str(tProfundidad), 5) + "            " + tZona

            arrays.Add(New Terremoto(tFecha, tHora, tMagnitud, tProfundidad, tZona))

        End While


        dr.Close()
        conex.Dispose()




        Return arrays
    End Function

End Class
