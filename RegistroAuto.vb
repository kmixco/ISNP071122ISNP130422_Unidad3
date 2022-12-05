Imports System.Text.RegularExpressions
Public Class RegistroAuto
    Dim Auto As New Auto
    Private Sub RegistroAuto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub IbMarca_Click(sender As Object, e As EventArgs) Handles IbMarca.Click

    End Sub

    Private Sub grpCodigo_Enter(sender As Object, e As EventArgs) Handles grpCodigo.Enter

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click


        If txtMarca.Text = "" Then
            MsgBox("Debe llenar los datos del Auto para generar el codigo")

        Else
            txtCodigo.Text = Auto.generarCodigo(txtMarca.Text)

        End If


    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        'Validando que el VIN no tenga menos de 17 caracteres
        If (txtVin.TextLength < 17) Then

            MessageBox.Show("El VIN debe llevar 17 caracteres")
        End If


        Auto.datosAuto(txtCodigo.Text,
                           txtMarca.Text,
                           txtModelo.Text,
                           txtPlaca.Text,
                           txtColor.Text,
                           txtVin.Text,
                           txtAño.Text,
                           txtTipo.Text)

        VerDatos.Rows.Add(txtCodigo.Text,
                         Auto.marcaAuto,
                         Auto.modeloAuto,
                         Auto.placaAuto,
                         Auto.colorAuto,
                         Auto.vinAuto,
                         Auto.añoAuto,
                         Auto.tipoAuto)


        If Auto.datosAceptados Then
            MsgBox("Los datos del " & Auto.marcaAuto & " han sido registrados con éxito")

        End If

        txtCodigo.Text = ""
        txtMarca.Text = ""
        txtModelo.Text = ""
        txtPlaca.Text = ""
        txtColor.Text = ""
        txtVin.Text = ""
        txtAño.Text = ""
        txtTipo.Text = ""

    End Sub

    Private Sub txtAño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAño.KeyPress

        'Validando que el TextBox de año solo admita numeros
        If Char.IsNumber(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColor.KeyPress

        'Validando que el TextBox de Color solo admita letras
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class
