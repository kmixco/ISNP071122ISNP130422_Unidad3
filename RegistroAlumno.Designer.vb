<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroAlumno
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpCodigo = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.VerDatos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.txtDui = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbDui = New System.Windows.Forms.Label()
        Me.lbApellido = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbRegistro = New System.Windows.Forms.Label()
        Me.grpCodigo.SuspendLayout()
        CType(Me.VerDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCodigo
        '
        Me.grpCodigo.Controls.Add(Me.btnAgregar)
        Me.grpCodigo.Controls.Add(Me.btnGenerar)
        Me.grpCodigo.Controls.Add(Me.txtCodigo)
        Me.grpCodigo.Location = New System.Drawing.Point(16, 57)
        Me.grpCodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpCodigo.Name = "grpCodigo"
        Me.grpCodigo.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpCodigo.Size = New System.Drawing.Size(563, 67)
        Me.grpCodigo.TabIndex = 0
        Me.grpCodigo.TabStop = False
        Me.grpCodigo.Text = "Generar Codigo"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(385, 24)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(112, 21)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar Alumno"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(154, 24)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(112, 21)
        Me.btnGenerar.TabIndex = 3
        Me.btnGenerar.Text = "Generar Codigo"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(11, 26)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(126, 20)
        Me.txtCodigo.TabIndex = 2
        '
        'VerDatos
        '
        Me.VerDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VerDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.VerDatos.Location = New System.Drawing.Point(16, 287)
        Me.VerDatos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.VerDatos.Name = "VerDatos"
        Me.VerDatos.RowHeadersWidth = 51
        Me.VerDatos.RowTemplate.Height = 24
        Me.VerDatos.Size = New System.Drawing.Size(563, 181)
        Me.VerDatos.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Apellido"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Genero"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Direccion"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "DUI"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Correo"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "Edad"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.txtDui)
        Me.grpDatos.Controls.Add(Me.txtEdad)
        Me.grpDatos.Controls.Add(Me.txtCorreo)
        Me.grpDatos.Controls.Add(Me.txtDireccion)
        Me.grpDatos.Controls.Add(Me.txtGenero)
        Me.grpDatos.Controls.Add(Me.txtApellido)
        Me.grpDatos.Controls.Add(Me.txtNombre)
        Me.grpDatos.Controls.Add(Me.Label4)
        Me.grpDatos.Controls.Add(Me.Label3)
        Me.grpDatos.Controls.Add(Me.Label2)
        Me.grpDatos.Controls.Add(Me.Label1)
        Me.grpDatos.Controls.Add(Me.lbDui)
        Me.grpDatos.Controls.Add(Me.lbApellido)
        Me.grpDatos.Controls.Add(Me.lbNombre)
        Me.grpDatos.Location = New System.Drawing.Point(16, 129)
        Me.grpDatos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpDatos.Size = New System.Drawing.Size(563, 153)
        Me.grpDatos.TabIndex = 2
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos de Alumno"
        '
        'txtDui
        '
        Me.txtDui.Location = New System.Drawing.Point(347, 28)
        Me.txtDui.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDui.MaxLength = 10
        Me.txtDui.Name = "txtDui"
        Me.txtDui.Size = New System.Drawing.Size(98, 20)
        Me.txtDui.TabIndex = 13
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(347, 79)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(54, 20)
        Me.txtEdad.TabIndex = 12
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(347, 53)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(200, 20)
        Me.txtCorreo.TabIndex = 11
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(68, 114)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(200, 20)
        Me.txtDireccion.TabIndex = 10
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(68, 80)
        Me.txtGenero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(70, 20)
        Me.txtGenero.TabIndex = 9
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(68, 53)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(200, 20)
        Me.txtApellido.TabIndex = 8
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(68, 28)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtNombre.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(304, 83)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 55)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Correo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Genero"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 114)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Direccion"
        '
        'lbDui
        '
        Me.lbDui.AutoSize = True
        Me.lbDui.Location = New System.Drawing.Point(304, 28)
        Me.lbDui.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDui.Name = "lbDui"
        Me.lbDui.Size = New System.Drawing.Size(26, 13)
        Me.lbDui.TabIndex = 2
        Me.lbDui.Text = "DUI"
        '
        'lbApellido
        '
        Me.lbApellido.AutoSize = True
        Me.lbApellido.Location = New System.Drawing.Point(19, 55)
        Me.lbApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbApellido.Name = "lbApellido"
        Me.lbApellido.Size = New System.Drawing.Size(44, 13)
        Me.lbApellido.TabIndex = 1
        Me.lbApellido.Text = "Apellido"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(19, 28)
        Me.lbNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(44, 13)
        Me.lbNombre.TabIndex = 0
        Me.lbNombre.Text = "Nombre"
        '
        'lbRegistro
        '
        Me.lbRegistro.AutoSize = True
        Me.lbRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRegistro.Location = New System.Drawing.Point(167, 17)
        Me.lbRegistro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbRegistro.Name = "lbRegistro"
        Me.lbRegistro.Size = New System.Drawing.Size(270, 25)
        Me.lbRegistro.TabIndex = 3
        Me.lbRegistro.Text = "REGISTRO DE ALUMNOS"
        '
        'RegistroAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 478)
        Me.Controls.Add(Me.lbRegistro)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.VerDatos)
        Me.Controls.Add(Me.grpCodigo)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "RegistroAlumno"
        Me.Text = "Registro de Alumno"
        Me.grpCodigo.ResumeLayout(False)
        Me.grpCodigo.PerformLayout()
        CType(Me.VerDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpCodigo As GroupBox
    Friend WithEvents VerDatos As DataGridView
    Friend WithEvents btnGenerar As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents lbDui As Label
    Friend WithEvents lbApellido As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDui As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lbRegistro As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
