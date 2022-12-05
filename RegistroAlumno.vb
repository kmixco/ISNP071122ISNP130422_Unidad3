Imports System.Text.RegularExpressions
Public Class RegistroAlumno
    Dim alumno As New alumno
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click


        If txtNombre.Text = "" Then
            MsgBox("Debe llenar los datos del alumno para generar el codigo")

        Else
            txtCodigo.Text = alumno.generarCodigo(txtNombre.Text)

        End If


    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        'Validar correo
        Dim regex As Regex = New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Dim isvalid As Boolean = regex.IsMatch(txtCorreo.Text.Trim)

        If Not isvalid Then
            MsgBox("Debe ingresar un correo valido")
        End If


        'Validar DUI
        Dim regexDUI As Regex = New Regex("^[^@\s]+-[^@\s]+$")
        Dim isduivalid As Boolean = regexDUI.IsMatch(txtDui.Text.Trim)

        If Not isduivalid Then
            MsgBox("Debe ingresar un DUI valido, recuerde usar guiones")
        End If

        alumno.datosAlumno(txtCodigo.Text,
                           txtNombre.Text,
                           txtApellido.Text,
                           txtGenero.Text,
                           txtDireccion.Text,
                           txtDui.Text,
                           txtEdad.Text,
                           txtCorreo.Text)

        VerDatos.Rows.Add(txtCodigo.Text,
                         alumno.nombreAlumno,
                         alumno.apellidoAlumno,
                         alumno.generoAlumno,
                         alumno.direccionAlumno,
                         alumno.duiAlumno,
                         alumno.correoAlumno,
                         alumno.edadAlumno)

        If alumno.datosAceptados Then
            MsgBox("Datos de " & alumno.nombreAlumno & " " & alumno.apellidoAlumno & " han sido registrados con éxito")

        End If

        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtGenero.Text = ""
        txtDireccion.Text = ""
        txtDui.Text = ""
        txtEdad.Text = ""
        txtCorreo.Text = ""

    End Sub

    Private Sub RegistroAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbRegistro_Click(sender As Object, e As EventArgs) Handles lbRegistro.Click

    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub VerDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VerDatos.CellContentClick

    End Sub
End Class
