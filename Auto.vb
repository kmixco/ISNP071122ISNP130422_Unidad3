Public Class Auto

    'Declaracion de propiedades
    Private codigo As String
    Private marca As String
    Private modelo As String
    Private color As String
    Private placa As String
    Private año As String
    Private tipo As String
    Private vin As String

    'Indica si los datos estan completos
    Private datosCompletos As Boolean

    'Metodos de la clase Auto

    'Metodo para marca
    Public Property marcaAuto() As String
        Get
            Return marca
        End Get
        Set(value As String)
            marca = value
        End Set
    End Property

    'Metodo para modelo
    Public Property modeloAuto() As String
        Get
            Return modelo
        End Get
        Set(value As String)
            modelo = value
        End Set
    End Property

    'Metodo para color
    Public Property colorAuto() As String
        Get
            Return color
        End Get
        Set(value As String)
            color = value
        End Set
    End Property

    'Metodo para placa
    Public Property placaAuto() As String
        Get
            Return placa
        End Get
        Set(value As String)
            placa = value
        End Set
    End Property

    'Metodo para año de fabricacion
    Public Property añoAuto() As String
        Get
            Return año
        End Get
        Set(value As String)
            año = value
        End Set
    End Property

    'Metodo para tipo de auto
    Public Property tipoAuto() As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property

    'Metodo para VIN del vehiculo
    Public Property vinAuto() As String
        Get
            Return vin
        End Get
        Set(value As String)
            vin = value
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
    Public Sub datosAuto(ByVal codigoA As String,
                           ByVal marcaA As String,
                           ByVal modeloA As String,
                           ByVal colorA As String,
                           ByVal placaA As String,
                           ByVal añoA As String,
                           ByVal tipoA As String,
                           ByVal vinA As String
                           )

        datosCompletos = True

        If codigoA.Length = 0 Then
            MsgBox("Debe generar el codigo")
        Else
            codigo = codigoA
        End If

        If marcaA.Length = 0 Then
            MsgBox("Debe agregar la marca")
        Else
            marca = marcaA
        End If

        If modeloA.Length = 0 Then
            MsgBox("Debe agregar el modelo")
        Else
            modelo = modeloA
        End If

        If colorA.Length = 0 Then
            MsgBox("Debe agregar el color")
        Else
            color = colorA
        End If

        If placaA.Length = 0 Then
            MsgBox("Debe agregar la placa")
        Else
            placa = placaA
        End If

        If añoA.Length = 0 Then
            MsgBox("Debe agregar el año de fabricaion")
        Else
            año = añoA
        End If

        If tipoA.Length = 0 Then
            MsgBox("Debe agregar el tipo de auto")
        Else
            tipo = tipoA
        End If

        If vinA.Length = 0 Then
            MsgBox("Debe agregar el VIN del auto")
        Else
            vin = vinA
        End If

    End Sub

    Public Function generarCodigo(ByVal marca As String)

        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(marca, 1))
        valor2 = Right(marca, 2)
        numero = Int(Rnd() * 1000) + 65

        Return valor1 & numero & valor2


    End Function

End Class
