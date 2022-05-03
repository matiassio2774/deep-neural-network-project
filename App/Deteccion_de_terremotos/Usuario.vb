Imports System.Text.RegularExpressions

Public Class Usuario
    Private _cuenta As String
    Private _password As String

    Public Sub New(ccuenta As String, ppassword As String)
        Cuenta = ccuenta
        Password = ppassword
    End Sub

    Public Property Cuenta As String
        Get
            Return _cuenta
        End Get
        Set(value As String)
            _cuenta = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Private Function validar(cuenta As String, contraseña As String) As Boolean

        Dim matchCuenta As Boolean
        Dim matchPassword As Boolean

        Dim Regex As Regex = New Regex("^[a-zA-Z0-9]*$") ' Expresion regular para validar matcheo de esos caracteres

        If (Regex.IsMatch(cuenta)) Then
            matchCuenta = True
        End If

        If (Regex.IsMatch(contraseña)) Then
            matchPassword = True
        End If

        If matchCuenta And matchPassword Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function login(cuenta As String, contraseña As String) As Integer

        If validar(cuenta, contraseña) Then

            Dim conex As New ConectaSQL
            Dim sql As String

            sql = "CALL dt.validar_login('" + cuenta + "','" + contraseña + "');"
            conex.EjecutasSql(sql)

            Dim resultado As Integer
            resultado = conex.micomando.ExecuteScalar()

            conex.Dispose()

            If resultado = 0 Then
                Return 0    ' No loguea por usuario , contraseña incorrecta
            Else
                Return 1    ' Loguea
            End If
        Else
            Return 2        ' No loguea por caracteres
        End If

    End Function


    Public Function register(cuenta As String, contraseña As String) As Integer

        If validar(cuenta, contraseña) Then

            Dim conex As New ConectaSQL
            Dim sql As String

            sql = "CALL dt.validar_registro('" + cuenta + "');"
            conex.EjecutasSql(sql)

            Dim resultado As Integer
            resultado = conex.micomando.ExecuteScalar()

            If resultado = 0 Then
                sql = "CALL dt.registrar_usuario('" + cuenta + "','" + contraseña + "');"
                conex.EjecutasSql(sql)

                conex.Dispose()

                Return 1    ' Loguea
            Else
                Return 0    ' No loguea por usuario , contraseña incorrecta
            End If
        Else
            Return 2        ' No loguea por caracteres
        End If

    End Function



End Class
