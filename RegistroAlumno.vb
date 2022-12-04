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

        alumno.datosAlumno(txtCodigo.Text,
                           txtNombre.Text,
                           txtApellido.Text,
                           txtGenero.Text,
                           txtDireccion.Text,
                           txtDui.Text,
                           txtEdad.Text,
                           txtCorreo.Text)

        If alumno.datosAceptados Then
            MsgBox("Datos de " & alumno.nombreAlumno & "Registrados con éxito")

            VerDatos.Rows.Add(txtCodigo.Text,
                         alumno.nombreAlumno,
                         alumno.apellidoAlumno,
                         alumno.generoAlumno,
                         alumno.direccionAlumno,
                         alumno.duiAlumno,
                         alumno.correoAlumno,
                         alumno.edadAlumno)

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

End Class
