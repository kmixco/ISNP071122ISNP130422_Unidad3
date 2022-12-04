Public Class RegistroAlumno
    Dim alumno As New alumno

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbDui.Click

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click


        If txtNombre.Text = "" Then
            MsgBox("Debe agregar un nombre")

        Else
            txtCodigo.Text = alumno.generarCodigo(txtNombre.Text)

            'Datagridview.Rows.Add(TxtFecha.Text, TxtDeposito.Text)

        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        alumno.datosAlumno(txtCodigo.Text, txtNombre.Text, txtApellido.Text, txtGenero.Text, txtDireccion.Text, txtDui.Text, txtEdad.Text, txtCorreo.Text)

        If alumno.datosAceptados Then
            MsgBox("Datos de " & alumno.nombreAlumno & "Registrados")
        End If

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub
End Class
