Public Class Predictor

    Public Function solicitarEncuesta(Zona As String, Magnitud As Double, Profundidad As Double, cuenta As String) As Double

        Return lanzarPrediccion(Zona, Magnitud, Profundidad, cuenta)
    End Function

    Private Function lanzarPrediccion(Zona As String, Magnitud As Double, Profundidad As Double, cuenta As String) As Double
        ' Magnitud - Intervalo - Escala - Profundidad - Efecto - BI - Zona 
        Dim Intervalo As Double
        Dim Escala As Double
        Dim Efecto As Double
        Dim BI As Double
        Dim NumZona As Double

        Dim gest As New Gestionador
        gest.solicitarPesos()

        Dim W As Double(,,)
        Dim U As Double(,)
        Dim A As Double(,)
        Dim cont1 As Integer = 0
        Dim cont2 As Integer = 0
        Dim resultado As Double

        Dim TotalEntradas As Integer = 7
        Dim TotalSalidas As Integer = 1
        Dim TotalCapas As Integer = 3
        Dim neuronasporcapa As Integer() = New Integer(TotalCapas) {}
        neuronasporcapa(0) = TotalEntradas
        neuronasporcapa(1) = 5
        neuronasporcapa(2) = 2
        neuronasporcapa(3) = TotalSalidas
        'Dim objP As Perceptron = New Perceptron(TotalEntradas, TotalSalidas, TotalCapas, neuronasporcapa)
        Dim MaximosRegistros As Integer = 0
        Dim entrada As Double()() = New Double(MaximosRegistros)() {}

        If Zona = "Alameda" Then NumZona = 0
        If Zona = "Ejido Jiquilpan" Then NumZona = 1
        If Zona = "Los Angeles" Then NumZona = 2
        If Zona = "Mono" Then NumZona = 3
        If Zona = "Moss Landing" Then NumZona = 4
        If Zona = "Riverside" Then NumZona = 5
        If Zona = "Sacramento " Then NumZona = 6
        If Zona = "San Benito" Then NumZona = 7
        If Zona = "San Francisco" Then NumZona = 8
        If Zona = "Ventura" Then NumZona = 9

        If Magnitud >= 2.0 And Magnitud < 3.0 Then Intervalo = 0
        If Magnitud >= 3.0 And Magnitud < 4.0 Then Intervalo = 1
        If Magnitud >= 4.0 And Magnitud < 5.0 Then Intervalo = 2 And Efecto = 1 And BI = 0
        If Magnitud >= 5 Then Intervalo = 3 And Efecto = 2 And BI = 0 And Escala = 6
        If Magnitud >= 2 And Magnitud <= 3.9 = Efecto Then Efecto = 0 And BI = 1
        If Magnitud >= 3 And Magnitud <= 3.3 Then Escala = 0
        If Magnitud >= 5 And Magnitud <= 5.4 Then Escala = 1
        If Magnitud >= 2.5 And Magnitud <= 2.9 Then Escala = 2
        If Magnitud >= 3.5 And Magnitud <= 3.9 Then Escala = 3
        If Magnitud >= 2 And Magnitud <= 2.4 Then Escala = 4
        If Magnitud >= 4 And Magnitud <= 4.9 Then Escala = 5

        entrada(0) = New Double() {Magnitud, Intervalo, Escala, Profundidad, Efecto, BI, NumZona}

        W = New Double(TotalCapas, 6, 6) {}
        U = New Double(TotalCapas, 6) {}
        A = New Double(TotalCapas, 6) {}

        For capa As Integer = 1 To TotalCapas

            For p As Integer = 0 To neuronasporcapa(capa) - 1
                U(capa, p) = gest.Umbrales(cont1)
                cont1 += 1
            Next
        Next

        For capa As Integer = 0 To TotalCapas - 1

            For p As Integer = 0 To neuronasporcapa(capa) - 1

                For k As Integer = 0 To neuronasporcapa(capa + 1) - 1
                    W(capa, p, k) = gest.Pesos(cont2)
                    cont2 += 1
                Next
            Next
        Next

        For copia As Integer = 0 To TotalEntradas - 1
            A(0, copia) = entrada(0)(copia)
        Next

        For capa As Integer = 1 To TotalCapas

            For neurona As Integer = 0 To neuronasporcapa(capa) - 1
                A(capa, neurona) = 0

                For entra As Integer = 0 To neuronasporcapa(capa - 1) - 1
                    A(capa, neurona) += A(capa - 1, entra) * W(capa - 1, entra, neurona) + 1 * U(capa, neurona)
                Next

                A(capa, neurona) = 1 / (1 + Math.Exp(-A(capa, neurona)))

                If capa = TotalCapas Then

                    resultado = A(capa, neurona)

                End If

            Next
        Next

        Dim conex As New ConectaSQL
        Dim sql As String

        sql = "CALL dt.insertar_prediccion('" + cuenta + "'," + Str(resultado) + "," + Str(Magnitud) + "," + Str(Intervalo) + "," + Str(Escala) + "," + Str(Profundidad) + "," + Str(Efecto) + "," + Str(BI) + "," + Str(NumZona) + ");"
        conex.EjecutasSql(sql)
        conex.Dispose()

        Return resultado
    End Function

End Class
