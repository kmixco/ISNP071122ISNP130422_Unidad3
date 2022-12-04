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
        Me.grpCodigo.Location = New System.Drawing.Point(22, 70)
        Me.grpCodigo.Name = "grpCodigo"
        Me.grpCodigo.Size = New System.Drawing.Size(751, 83)
        Me.grpCodigo.TabIndex = 0
        Me.grpCodigo.TabStop = False
        Me.grpCodigo.Text = "Generar Codigo"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(513, 30)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(149, 26)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar Alumno"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(206, 30)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(149, 26)
        Me.btnGenerar.TabIndex = 3
        Me.btnGenerar.Text = "Generar Codigo"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(15, 32)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(167, 22)
        Me.txtCodigo.TabIndex = 2
        '
        'VerDatos
        '
        Me.VerDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VerDatos.Location = New System.Drawing.Point(22, 353)
        Me.VerDatos.Name = "VerDatos"
        Me.VerDatos.RowHeadersWidth = 51
        Me.VerDatos.RowTemplate.Height = 24
        Me.VerDatos.Size = New System.Drawing.Size(751, 223)
        Me.VerDatos.TabIndex = 1
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
        Me.grpDatos.Location = New System.Drawing.Point(22, 159)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(751, 188)
        Me.grpDatos.TabIndex = 2
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos de Alumno"
        '
        'txtDui
        '
        Me.txtDui.Location = New System.Drawing.Point(463, 35)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.Size = New System.Drawing.Size(130, 22)
        Me.txtDui.TabIndex = 13
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(463, 97)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(70, 22)
        Me.txtEdad.TabIndex = 12
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(463, 65)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(265, 22)
        Me.txtCorreo.TabIndex = 11
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(90, 140)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(265, 22)
        Me.txtDireccion.TabIndex = 10
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(90, 99)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(92, 22)
        Me.txtGenero.TabIndex = 9
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(90, 65)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(265, 22)
        Me.txtApellido.TabIndex = 8
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(90, 35)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(265, 22)
        Me.txtNombre.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(406, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(406, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Correo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Genero"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Direccion"
        '
        'lbDui
        '
        Me.lbDui.AutoSize = True
        Me.lbDui.Location = New System.Drawing.Point(406, 35)
        Me.lbDui.Name = "lbDui"
        Me.lbDui.Size = New System.Drawing.Size(31, 17)
        Me.lbDui.TabIndex = 2
        Me.lbDui.Text = "DUI"
        '
        'lbApellido
        '
        Me.lbApellido.AutoSize = True
        Me.lbApellido.Location = New System.Drawing.Point(25, 68)
        Me.lbApellido.Name = "lbApellido"
        Me.lbApellido.Size = New System.Drawing.Size(58, 17)
        Me.lbApellido.TabIndex = 1
        Me.lbApellido.Text = "Apellido"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(25, 35)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(58, 17)
        Me.lbNombre.TabIndex = 0
        Me.lbNombre.Text = "Nombre"
        '
        'lbRegistro
        '
        Me.lbRegistro.AutoSize = True
        Me.lbRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRegistro.Location = New System.Drawing.Point(223, 21)
        Me.lbRegistro.Name = "lbRegistro"
        Me.lbRegistro.Size = New System.Drawing.Size(334, 29)
        Me.lbRegistro.TabIndex = 3
        Me.lbRegistro.Text = "REGISTRO DE ALUMNOS"
        '
        'RegistroAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 588)
        Me.Controls.Add(Me.lbRegistro)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.VerDatos)
        Me.Controls.Add(Me.grpCodigo)
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
End Class
