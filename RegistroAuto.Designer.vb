<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroAuto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.IbRegistro = New System.Windows.Forms.Label()
        Me.grpCodigo = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtVin = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.IbVin = New System.Windows.Forms.Label()
        Me.IbTipo = New System.Windows.Forms.Label()
        Me.IbAño = New System.Windows.Forms.Label()
        Me.IbPlaca = New System.Windows.Forms.Label()
        Me.IbColor = New System.Windows.Forms.Label()
        Me.IbModelo = New System.Windows.Forms.Label()
        Me.IbMarca = New System.Windows.Forms.Label()
        Me.VerDatos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpCodigo.SuspendLayout()
        Me.grpDatos.SuspendLayout()
        CType(Me.VerDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IbRegistro
        '
        Me.IbRegistro.AutoSize = True
        Me.IbRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.IbRegistro.Location = New System.Drawing.Point(241, 21)
        Me.IbRegistro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.IbRegistro.Name = "IbRegistro"
        Me.IbRegistro.Size = New System.Drawing.Size(239, 25)
        Me.IbRegistro.TabIndex = 3
        Me.IbRegistro.Text = "REGISTRO DE AUTOS"
        '
        'grpCodigo
        '
        Me.grpCodigo.Controls.Add(Me.btnAgregar)
        Me.grpCodigo.Controls.Add(Me.btnGenerar)
        Me.grpCodigo.Controls.Add(Me.txtCodigo)
        Me.grpCodigo.Location = New System.Drawing.Point(35, 62)
        Me.grpCodigo.Name = "grpCodigo"
        Me.grpCodigo.Size = New System.Drawing.Size(629, 70)
        Me.grpCodigo.TabIndex = 4
        Me.grpCodigo.TabStop = False
        Me.grpCodigo.Text = "Generar Codigo"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(455, 30)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(119, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar Auto"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(178, 26)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(115, 23)
        Me.btnGenerar.TabIndex = 1
        Me.btnGenerar.Text = "Generar Codigo"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.SystemColors.Control
        Me.txtCodigo.Location = New System.Drawing.Point(6, 30)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(152, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.txtTipo)
        Me.grpDatos.Controls.Add(Me.txtAño)
        Me.grpDatos.Controls.Add(Me.txtVin)
        Me.grpDatos.Controls.Add(Me.txtColor)
        Me.grpDatos.Controls.Add(Me.txtPlaca)
        Me.grpDatos.Controls.Add(Me.txtModelo)
        Me.grpDatos.Controls.Add(Me.txtMarca)
        Me.grpDatos.Controls.Add(Me.IbVin)
        Me.grpDatos.Controls.Add(Me.IbTipo)
        Me.grpDatos.Controls.Add(Me.IbAño)
        Me.grpDatos.Controls.Add(Me.IbPlaca)
        Me.grpDatos.Controls.Add(Me.IbColor)
        Me.grpDatos.Controls.Add(Me.IbModelo)
        Me.grpDatos.Controls.Add(Me.IbMarca)
        Me.grpDatos.Location = New System.Drawing.Point(35, 161)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(629, 192)
        Me.grpDatos.TabIndex = 0
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos Alumno"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(376, 117)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(104, 20)
        Me.txtTipo.TabIndex = 13
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(376, 76)
        Me.txtAño.MaxLength = 4
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(69, 20)
        Me.txtAño.TabIndex = 12
        '
        'txtVin
        '
        Me.txtVin.Location = New System.Drawing.Point(376, 40)
        Me.txtVin.MaxLength = 17
        Me.txtVin.Name = "txtVin"
        Me.txtVin.Size = New System.Drawing.Size(209, 20)
        Me.txtVin.TabIndex = 11
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(89, 145)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(109, 20)
        Me.txtColor.TabIndex = 10
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(89, 108)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(109, 20)
        Me.txtPlaca.TabIndex = 9
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(89, 76)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(154, 20)
        Me.txtModelo.TabIndex = 8
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(89, 40)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(154, 20)
        Me.txtMarca.TabIndex = 7
        '
        'IbVin
        '
        Me.IbVin.AutoSize = True
        Me.IbVin.Location = New System.Drawing.Point(328, 40)
        Me.IbVin.Name = "IbVin"
        Me.IbVin.Size = New System.Drawing.Size(25, 13)
        Me.IbVin.TabIndex = 6
        Me.IbVin.Text = "VIN"
        '
        'IbTipo
        '
        Me.IbTipo.AutoSize = True
        Me.IbTipo.Location = New System.Drawing.Point(328, 117)
        Me.IbTipo.Name = "IbTipo"
        Me.IbTipo.Size = New System.Drawing.Size(28, 13)
        Me.IbTipo.TabIndex = 5
        Me.IbTipo.Text = "Tipo"
        '
        'IbAño
        '
        Me.IbAño.AutoSize = True
        Me.IbAño.Location = New System.Drawing.Point(328, 76)
        Me.IbAño.Name = "IbAño"
        Me.IbAño.Size = New System.Drawing.Size(26, 13)
        Me.IbAño.TabIndex = 4
        Me.IbAño.Text = "Año"
        '
        'IbPlaca
        '
        Me.IbPlaca.AutoSize = True
        Me.IbPlaca.Location = New System.Drawing.Point(33, 108)
        Me.IbPlaca.Name = "IbPlaca"
        Me.IbPlaca.Size = New System.Drawing.Size(34, 13)
        Me.IbPlaca.TabIndex = 3
        Me.IbPlaca.Text = "Placa"
        '
        'IbColor
        '
        Me.IbColor.AutoSize = True
        Me.IbColor.Location = New System.Drawing.Point(36, 145)
        Me.IbColor.Name = "IbColor"
        Me.IbColor.Size = New System.Drawing.Size(31, 13)
        Me.IbColor.TabIndex = 2
        Me.IbColor.Text = "Color"
        '
        'IbModelo
        '
        Me.IbModelo.AutoSize = True
        Me.IbModelo.Location = New System.Drawing.Point(30, 76)
        Me.IbModelo.Name = "IbModelo"
        Me.IbModelo.Size = New System.Drawing.Size(42, 13)
        Me.IbModelo.TabIndex = 1
        Me.IbModelo.Text = "Modelo"
        '
        'IbMarca
        '
        Me.IbMarca.AutoSize = True
        Me.IbMarca.Location = New System.Drawing.Point(30, 40)
        Me.IbMarca.Name = "IbMarca"
        Me.IbMarca.Size = New System.Drawing.Size(37, 13)
        Me.IbMarca.TabIndex = 0
        Me.IbMarca.Text = "Marca"
        '
        'VerDatos
        '
        Me.VerDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VerDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column7, Me.Column8, Me.Column5, Me.Column6})
        Me.VerDatos.Location = New System.Drawing.Point(35, 369)
        Me.VerDatos.Name = "VerDatos"
        Me.VerDatos.Size = New System.Drawing.Size(629, 150)
        Me.VerDatos.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Marca"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Modelo"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Placa"
        Me.Column4.Name = "Column4"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Color"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "VIN"
        Me.Column8.Name = "Column8"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Año"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Tipo"
        Me.Column6.Name = "Column6"
        '
        'RegistroAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 525)
        Me.Controls.Add(Me.VerDatos)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.grpCodigo)
        Me.Controls.Add(Me.IbRegistro)
        Me.Name = "RegistroAuto"
        Me.Text = "RegistroAuto"
        Me.grpCodigo.ResumeLayout(False)
        Me.grpCodigo.PerformLayout()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.VerDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IbRegistro As Label
    Friend WithEvents grpCodigo As GroupBox
    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents IbMarca As Label
    Friend WithEvents IbColor As Label
    Friend WithEvents IbModelo As Label
    Friend WithEvents IbAño As Label
    Friend WithEvents IbPlaca As Label
    Friend WithEvents IbTipo As Label
    Friend WithEvents IbVin As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents txtVin As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents VerDatos As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
