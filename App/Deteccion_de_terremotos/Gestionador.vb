Public Class Gestionador
    Private _pesos(46) As Double '47 pesos en total
    Private _umbrales(7) As Double '8 pesos en total

    Public Property Pesos(ByVal i As Integer) As Double
        Get
            Return _pesos(i)
        End Get
        Set(ByVal value As Double)
            _pesos(i) = value
        End Set
    End Property

    Public Property Umbrales(ByVal j As Integer) As Double
        Get
            Return _umbrales(j)
        End Get
        Set(ByVal value As Double)
            _umbrales(j) = value
        End Set
    End Property

    Public Sub solicitarPesos()
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim rutaPesos As String = "F:\Programacion\proyecto_ult\Deteccion_de_terremotos\red\pesos.txt"
        Dim rutaUmbrales As String = "F:\Programacion\proyecto_ult\Deteccion_de_terremotos\red\umbrales.txt"

        Dim MiArPesos As New System.IO.StreamReader(rutaPesos)

        While MiArPesos.Peek() <> -1
            Pesos(i) = MiArPesos.ReadLine()
            i += 1
        End While

        MiArPesos.Close()

        Dim MiArUmbrales As New System.IO.StreamReader(rutaUmbrales)

        While MiArUmbrales.Peek() <> -1
            Umbrales(j) = MiArUmbrales.ReadLine()
            j += 1
        End While

        MiArUmbrales.Close()
    End Sub


End Class
