Imports MySql.Data.MySqlClient

Public Class ConectaSQL

    Private miconexion As New MySqlConnection
    Public micomando As New MySqlCommand


    Public Sub New()
        Try
            miconexion.ConnectionString = "Server = localhost;Port=3306;Database=dt;Uid=root;Pwd=philips"
            miconexion.Open()
            micomando.Connection = miconexion
            'MsgBox("Conectado a la base de datos!")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al conectarse a la base de datos.")
        End Try
    End Sub
    Public Sub EjecutasSql(SentenciaSQL As String)
        micomando.CommandText = SentenciaSQL
        micomando.ExecuteNonQuery()
    End Sub

    Public Sub Dispose()
        miconexion.Close()
        miconexion.Dispose()
        micomando.Dispose()
    End Sub

End Class
