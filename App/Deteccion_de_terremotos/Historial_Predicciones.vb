Public Class Historial_Predicciones


    Public Function informarPrediccion() As List(Of String())

        Dim Cuenta As String
        Dim Fecha As Date
        Dim Resultado As Integer

        Dim conex As New ConectaSQL
        Dim sql As String

        Dim arrays As New List(Of String())
        Dim ResultadoTemp As String
        sql = "CALL dt.mostrar_predicciones;"
        conex.EjecutasSql(sql)

        Dim dr = conex.micomando.ExecuteReader()

        While dr.Read()
            Cuenta = dr(0)
            Fecha = dr(1)
            Resultado = dr(2)

            If Resultado = 1 Then
                ResultadoTemp = "Detectado"
            Else
                ResultadoTemp = "No detectado"
            End If
            arrays.Add(New String() {Cuenta, Fecha, ResultadoTemp})
        End While

        dr.Close()
        conex.Dispose()

        Return arrays
    End Function


End Class
