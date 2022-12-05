Imports System.Text.RegularExpressions
Public Class alumno

    'Declaracion de propiedades
    Private codigo As String
    Private nombre As String
    Private apellido As String
    Private genero As String
    Private direccion As String
    Private dui As String
    Private edad As String
    Private correo As String

    'Indica si los datos estan completos
    Private datosCompletos As Boolean

    'Metodos de la clase

    'Metodo para nombre
    Public Property nombreAlumno() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    'Metodo para apellido
    Public Property apellidoAlumno() As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    'Metodo para genero
    Public Property generoAlumno() As String
        Get
            Return genero
        End Get
        Set(value As String)
            genero = value
        End Set
    End Property

    'Metodo para direccion
    Public Property direccionAlumno() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    'Metodo para dui
    Public Property duiAlumno() As String
        Get
            Return dui
        End Get
        Set(value As String)
            dui = value
        End Set
    End Property

    'Metodo para edad
    Public Property edadAlumno() As String
        Get
            Return edad
        End Get
        Set(value As String)
            edad = value
        End Set
    End Property

    'Metodo para correo
    Public Property correoAlumno() As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    'Datos aceptados

    Public ReadOnly Property datosAceptados() As Boolean
        Get
            Return datosCompletos
        End Get
    End Property

    'Constructor de la clase
    Public Sub New()
        datosCompletos = False
    End Sub

    'Determina si los datos ingresados son correctos 
    Public Sub datosAlumno(ByVal codigoA As String,
                           ByVal nombreA As String,
                           ByVal apellidoA As String,
                           ByVal generoA As String,
                           ByVal direccionA As String,
                           ByVal duiA As String,
                           ByVal edadA As String,
                           ByVal correoA As String
                           )

        datosCompletos = False

        If codigoA.Length = 0 Then
            MsgBox("Debe generar el codigo")

        Else
            codigo = codigoA
            datosCompletos = True
        End If

        If nombreA.Length = 0 Then
            MsgBox("Debe agregar el nombre")
        Else
            nombre = nombreA
            datosCompletos = True
        End If

        If apellidoA.Length = 0 Then
            MsgBox("Debe agregar el apellido")
        Else
            apellido = apellidoA
            datosCompletos = True
        End If

        If generoA.Length = 0 Then
            MsgBox("Debe agregar el genero, escriba M para masculino o F para femenino")
        Else
            genero = generoA
            datosCompletos = True
        End If

        If direccionA.Length = 0 Then
            MsgBox("Debe agregar el direccion")
        Else
            direccion = direccionA
            datosCompletos = True
        End If

        If duiA.Length = 0 Then
            MsgBox("Debe agregar el dui")
        Else
            Dim regexDUI As Regex = New Regex("^[^@\s]+-[^@\s]+$")
            Dim isduivalid As Boolean = regexDUI.IsMatch(duiA.Trim)

            If Not isduivalid Then
                MsgBox("Debe ingresar un DUI valido, recuerde usar el guion")
            Else
                dui = duiA
                datosCompletos = True
            End If

        End If

        If edadA.Length = 0 Then
            MsgBox("Debe agregar el edad")
        Else
            edad = edadA
            datosCompletos = True
        End If

        If correoA.Length = 0 Then
            MsgBox("Debe agregar el correo")

        Else
            Dim regex As Regex = New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
            Dim isvalid As Boolean = regex.IsMatch(correoA.Trim)
            If Not isvalid Then
                MsgBox("Debe ingresar un correo valido")
            Else
                correo = correoA
                datosCompletos = True
            End If

        End If

    End Sub

    Public Function generarCodigo(ByVal nombre As String)

        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(nombre, 1))
        valor2 = Right(nombre, 2)
        numero = Int(Rnd() * 1000) + 65

        Return valor1 & numero & valor2


    End Function

End Class
