<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogoCuentas
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
        Me.components = New System.ComponentModel.Container()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cbCalle = New System.Windows.Forms.ComboBox()
        Me.CallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSistema = New Sistema.DataSetSistema()
        Me.CallesTableAdapter = New Sistema.DataSetSistemaTableAdapters.CallesTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mcCuentas = New System.Windows.Forms.MonthCalendar()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNoInterior = New System.Windows.Forms.TextBox()
        Me.txtNoExterior = New System.Windows.Forms.TextBox()
        Me.dgCuentas = New System.Windows.Forms.DataGridView()
        Me.IdCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumExtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumIntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPagoADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPagoMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentasTableAdapter = New Sistema.DataSetSistemaTableAdapters.CuentasTableAdapter()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUltimo
        '
        Me.btnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Location = New System.Drawing.Point(309, 12)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(87, 25)
        Me.btnUltimo.TabIndex = 17
        Me.btnUltimo.Text = "Último"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(425, 12)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(87, 25)
        Me.btnAnterior.TabIndex = 18
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(538, 12)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(87, 25)
        Me.btnSiguiente.TabIndex = 19
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.Location = New System.Drawing.Point(196, 12)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(87, 25)
        Me.btnInicio.TabIndex = 16
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(94, 178)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(42, 16)
        Me.label1.TabIndex = 25
        Me.label1.Text = "Calle:"
        '
        'cbCalle
        '
        Me.cbCalle.DataSource = Me.CallesBindingSource
        Me.cbCalle.DisplayMember = "nombre"
        Me.cbCalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCalle.Enabled = False
        Me.cbCalle.FormattingEnabled = True
        Me.cbCalle.Location = New System.Drawing.Point(142, 177)
        Me.cbCalle.Name = "cbCalle"
        Me.cbCalle.Size = New System.Drawing.Size(251, 21)
        Me.cbCalle.TabIndex = 26
        Me.cbCalle.ValueMember = "idCalle"
        '
        'CallesBindingSource
        '
        Me.CallesBindingSource.DataMember = "Calles"
        Me.CallesBindingSource.DataSource = Me.DataSetSistema
        '
        'DataSetSistema
        '
        Me.DataSetSistema.DataSetName = "DataSetSistema"
        Me.DataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CallesTableAdapter
        '
        Me.CallesTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "idCuenta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(94, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(94, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "No. interior:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(94, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "No. exterior:"
        '
        'mcCuentas
        '
        Me.mcCuentas.DataBindings.Add(New System.Windows.Forms.Binding("SelectionRange", Me.CuentasBindingSource, "fechaAlta", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.mcCuentas.Enabled = False
        Me.mcCuentas.Location = New System.Drawing.Point(479, 61)
        Me.mcCuentas.MaxSelectionCount = 1
        Me.mcCuentas.Name = "mcCuentas"
        Me.mcCuentas.TabIndex = 33
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "Cuentas"
        Me.CuentasBindingSource.DataSource = Me.DataSetSistema
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.Enabled = False
        Me.txtIdCuenta.Location = New System.Drawing.Point(178, 60)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.Size = New System.Drawing.Size(139, 20)
        Me.txtIdCuenta.TabIndex = 34
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(178, 89)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(207, 20)
        Me.txtNombre.TabIndex = 35
        '
        'txtNoInterior
        '
        Me.txtNoInterior.Enabled = False
        Me.txtNoInterior.Location = New System.Drawing.Point(178, 118)
        Me.txtNoInterior.MaxLength = 5
        Me.txtNoInterior.Name = "txtNoInterior"
        Me.txtNoInterior.Size = New System.Drawing.Size(139, 20)
        Me.txtNoInterior.TabIndex = 36
        '
        'txtNoExterior
        '
        Me.txtNoExterior.Enabled = False
        Me.txtNoExterior.Location = New System.Drawing.Point(178, 147)
        Me.txtNoExterior.MaxLength = 5
        Me.txtNoExterior.Name = "txtNoExterior"
        Me.txtNoExterior.Size = New System.Drawing.Size(139, 20)
        Me.txtNoExterior.TabIndex = 37
        '
        'dgCuentas
        '
        Me.dgCuentas.AutoGenerateColumns = False
        Me.dgCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCuentaDataGridViewTextBoxColumn, Me.IdCalleDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.NumExtDataGridViewTextBoxColumn, Me.NumIntDataGridViewTextBoxColumn, Me.FechaAltaDataGridViewTextBoxColumn, Me.UltimoPagoADataGridViewTextBoxColumn, Me.UltimoPagoMDataGridViewTextBoxColumn})
        Me.dgCuentas.DataSource = Me.CuentasBindingSource
        Me.dgCuentas.Enabled = False
        Me.dgCuentas.Location = New System.Drawing.Point(20, 290)
        Me.dgCuentas.Name = "dgCuentas"
        Me.dgCuentas.ReadOnly = True
        Me.dgCuentas.Size = New System.Drawing.Size(773, 199)
        Me.dgCuentas.TabIndex = 39
        '
        'IdCuentaDataGridViewTextBoxColumn
        '
        Me.IdCuentaDataGridViewTextBoxColumn.DataPropertyName = "idCuenta"
        Me.IdCuentaDataGridViewTextBoxColumn.HeaderText = "idCuenta"
        Me.IdCuentaDataGridViewTextBoxColumn.Name = "IdCuentaDataGridViewTextBoxColumn"
        Me.IdCuentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCuentaDataGridViewTextBoxColumn.Width = 70
        '
        'IdCalleDataGridViewTextBoxColumn
        '
        Me.IdCalleDataGridViewTextBoxColumn.DataPropertyName = "idCalle"
        Me.IdCalleDataGridViewTextBoxColumn.HeaderText = "idCalle"
        Me.IdCalleDataGridViewTextBoxColumn.Name = "IdCalleDataGridViewTextBoxColumn"
        Me.IdCalleDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCalleDataGridViewTextBoxColumn.Width = 70
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 150
        '
        'NumExtDataGridViewTextBoxColumn
        '
        Me.NumExtDataGridViewTextBoxColumn.DataPropertyName = "numExt"
        Me.NumExtDataGridViewTextBoxColumn.HeaderText = "numExt"
        Me.NumExtDataGridViewTextBoxColumn.Name = "NumExtDataGridViewTextBoxColumn"
        Me.NumExtDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumExtDataGridViewTextBoxColumn.Width = 70
        '
        'NumIntDataGridViewTextBoxColumn
        '
        Me.NumIntDataGridViewTextBoxColumn.DataPropertyName = "numInt"
        Me.NumIntDataGridViewTextBoxColumn.HeaderText = "numInt"
        Me.NumIntDataGridViewTextBoxColumn.Name = "NumIntDataGridViewTextBoxColumn"
        Me.NumIntDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumIntDataGridViewTextBoxColumn.Width = 70
        '
        'FechaAltaDataGridViewTextBoxColumn
        '
        Me.FechaAltaDataGridViewTextBoxColumn.DataPropertyName = "fechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.HeaderText = "fechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.Name = "FechaAltaDataGridViewTextBoxColumn"
        Me.FechaAltaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UltimoPagoADataGridViewTextBoxColumn
        '
        Me.UltimoPagoADataGridViewTextBoxColumn.DataPropertyName = "ultimoPagoA"
        Me.UltimoPagoADataGridViewTextBoxColumn.HeaderText = "ultimoPagoA"
        Me.UltimoPagoADataGridViewTextBoxColumn.Name = "UltimoPagoADataGridViewTextBoxColumn"
        Me.UltimoPagoADataGridViewTextBoxColumn.ReadOnly = True
        '
        'UltimoPagoMDataGridViewTextBoxColumn
        '
        Me.UltimoPagoMDataGridViewTextBoxColumn.DataPropertyName = "ultimoPagoM"
        Me.UltimoPagoMDataGridViewTextBoxColumn.HeaderText = "ultimoPagoM"
        Me.UltimoPagoMDataGridViewTextBoxColumn.Name = "UltimoPagoMDataGridViewTextBoxColumn"
        Me.UltimoPagoMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(510, 495)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(169, 23)
        Me.btnSalir.TabIndex = 42
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Location = New System.Drawing.Point(324, 495)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(169, 23)
        Me.btnGrabar.TabIndex = 41
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(138, 495)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(169, 23)
        Me.btnNuevo.TabIndex = 40
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Colonia:"
        Me.Label3.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(94, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 16)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "CP:"
        Me.Label7.Visible = False
        '
        'txtColonia
        '
        Me.txtColonia.Enabled = False
        Me.txtColonia.Location = New System.Drawing.Point(157, 208)
        Me.txtColonia.MaxLength = 5
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(228, 20)
        Me.txtColonia.TabIndex = 45
        Me.txtColonia.Visible = False
        '
        'txtCP
        '
        Me.txtCP.Enabled = False
        Me.txtCP.Location = New System.Drawing.Point(157, 237)
        Me.txtCP.MaxLength = 5
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(139, 20)
        Me.txtCP.TabIndex = 46
        Me.txtCP.Visible = False
        '
        'frmCatalogoCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 545)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgCuentas)
        Me.Controls.Add(Me.txtNoExterior)
        Me.Controls.Add(Me.txtNoInterior)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIdCuenta)
        Me.Controls.Add(Me.mcCuentas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbCalle)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnInicio)
        Me.Name = "frmCatalogoCuentas"
        Me.Text = "Cuentas"
        CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents label1 As Label
    Friend WithEvents cbCalle As ComboBox
    Friend WithEvents DataSetSistema As DataSetSistema
    Friend WithEvents CallesBindingSource As BindingSource
    Friend WithEvents CallesTableAdapter As DataSetSistemaTableAdapters.CallesTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mcCuentas As MonthCalendar
    Friend WithEvents txtIdCuenta As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtNoInterior As TextBox
    Friend WithEvents txtNoExterior As TextBox
    Friend WithEvents dgCuentas As DataGridView
    Friend WithEvents CuentasBindingSource As BindingSource
    Friend WithEvents CuentasTableAdapter As DataSetSistemaTableAdapters.CuentasTableAdapter
    Friend WithEvents IdCuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumExtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumIntDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPagoADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPagoMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents txtCP As TextBox
End Class
