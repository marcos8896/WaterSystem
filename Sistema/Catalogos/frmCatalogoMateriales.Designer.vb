<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogoMateriales
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdMaterial = New System.Windows.Forms.TextBox()
        Me.MaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSistema = New Sistema.DataSetSistema()
        Me.txtExistencia = New System.Windows.Forms.TextBox()
        Me.txtMinimos = New System.Windows.Forms.TextBox()
        Me.txtMaximos = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cbUnidad = New System.Windows.Forms.ComboBox()
        Me.dgMaterial = New System.Windows.Forms.DataGridView()
        Me.IdMaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinimoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimaFechaCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialesTableAdapter = New Sistema.DataSetSistemaTableAdapters.MaterialesTableAdapter()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.mcFecha = New System.Windows.Forms.MonthCalendar()
        CType(Me.MaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "idMaterial:"
        '
        'btnUltimo
        '
        Me.btnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Location = New System.Drawing.Point(147, 225)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(87, 25)
        Me.btnUltimo.TabIndex = 13
        Me.btnUltimo.Text = "Último"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(263, 225)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(87, 25)
        Me.btnAnterior.TabIndex = 14
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(376, 225)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(87, 25)
        Me.btnSiguiente.TabIndex = 15
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.Location = New System.Drawing.Point(34, 225)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(87, 25)
        Me.btnInicio.TabIndex = 12
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(330, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Minimos:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(330, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Máximos:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Descripción:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(36, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Existencia:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(36, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 16)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Unidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(587, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Última compra:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(330, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Costo:"
        '
        'txtIdMaterial
        '
        Me.txtIdMaterial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "idMaterial", True))
        Me.txtIdMaterial.Enabled = False
        Me.txtIdMaterial.Location = New System.Drawing.Point(118, 25)
        Me.txtIdMaterial.Name = "txtIdMaterial"
        Me.txtIdMaterial.Size = New System.Drawing.Size(88, 20)
        Me.txtIdMaterial.TabIndex = 1
        '
        'MaterialesBindingSource
        '
        Me.MaterialesBindingSource.DataMember = "Materiales"
        Me.MaterialesBindingSource.DataSource = Me.DataSetSistema
        '
        'DataSetSistema
        '
        Me.DataSetSistema.DataSetName = "DataSetSistema"
        Me.DataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtExistencia
        '
        Me.txtExistencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "existencia", True))
        Me.txtExistencia.Enabled = False
        Me.txtExistencia.Location = New System.Drawing.Point(118, 83)
        Me.txtExistencia.MaxLength = 15
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.Size = New System.Drawing.Size(186, 20)
        Me.txtExistencia.TabIndex = 3
        '
        'txtMinimos
        '
        Me.txtMinimos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "minimo", True))
        Me.txtMinimos.Enabled = False
        Me.txtMinimos.Location = New System.Drawing.Point(395, 79)
        Me.txtMinimos.MaxLength = 15
        Me.txtMinimos.Name = "txtMinimos"
        Me.txtMinimos.Size = New System.Drawing.Size(102, 20)
        Me.txtMinimos.TabIndex = 6
        '
        'txtMaximos
        '
        Me.txtMaximos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "maximo", True))
        Me.txtMaximos.Enabled = False
        Me.txtMaximos.Location = New System.Drawing.Point(395, 52)
        Me.txtMaximos.MaxLength = 15
        Me.txtMaximos.Name = "txtMaximos"
        Me.txtMaximos.Size = New System.Drawing.Size(102, 20)
        Me.txtMaximos.TabIndex = 5
        '
        'txtCosto
        '
        Me.txtCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "costo", True))
        Me.txtCosto.Enabled = False
        Me.txtCosto.Location = New System.Drawing.Point(395, 109)
        Me.txtCosto.MaxLength = 15
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(102, 20)
        Me.txtCosto.TabIndex = 7
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "descripcion", True))
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(118, 52)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(186, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'cbUnidad
        '
        Me.cbUnidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "unidad", True))
        Me.cbUnidad.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MaterialesBindingSource, "unidad", True))
        Me.cbUnidad.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.MaterialesBindingSource, "unidad", True))
        Me.cbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidad.Enabled = False
        Me.cbUnidad.FormattingEnabled = True
        Me.cbUnidad.Items.AddRange(New Object() {"PIEZA", "MILILITRO", "LITRO", "MILIMETRO", "CENTIMETRO", "METRO", "MILIGRAMO", "GRAMO", "KILO", "LIBRA", "ONZA"})
        Me.cbUnidad.Location = New System.Drawing.Point(118, 112)
        Me.cbUnidad.Name = "cbUnidad"
        Me.cbUnidad.Size = New System.Drawing.Size(186, 21)
        Me.cbUnidad.TabIndex = 4
        '
        'dgMaterial
        '
        Me.dgMaterial.AutoGenerateColumns = False
        Me.dgMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMaterialDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.MaximoDataGridViewTextBoxColumn, Me.MinimoDataGridViewTextBoxColumn, Me.UnidadDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.UltimaFechaCompraDataGridViewTextBoxColumn})
        Me.dgMaterial.DataSource = Me.MaterialesBindingSource
        Me.dgMaterial.Enabled = False
        Me.dgMaterial.Location = New System.Drawing.Point(12, 269)
        Me.dgMaterial.Name = "dgMaterial"
        Me.dgMaterial.ReadOnly = True
        Me.dgMaterial.Size = New System.Drawing.Size(763, 150)
        Me.dgMaterial.TabIndex = 45
        '
        'IdMaterialDataGridViewTextBoxColumn
        '
        Me.IdMaterialDataGridViewTextBoxColumn.DataPropertyName = "idMaterial"
        Me.IdMaterialDataGridViewTextBoxColumn.HeaderText = "idMaterial"
        Me.IdMaterialDataGridViewTextBoxColumn.Name = "IdMaterialDataGridViewTextBoxColumn"
        Me.IdMaterialDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdMaterialDataGridViewTextBoxColumn.Width = 70
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 150
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        Me.ExistenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExistenciaDataGridViewTextBoxColumn.Width = 70
        '
        'MaximoDataGridViewTextBoxColumn
        '
        Me.MaximoDataGridViewTextBoxColumn.DataPropertyName = "maximo"
        Me.MaximoDataGridViewTextBoxColumn.HeaderText = "maximo"
        Me.MaximoDataGridViewTextBoxColumn.Name = "MaximoDataGridViewTextBoxColumn"
        Me.MaximoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaximoDataGridViewTextBoxColumn.Width = 70
        '
        'MinimoDataGridViewTextBoxColumn
        '
        Me.MinimoDataGridViewTextBoxColumn.DataPropertyName = "minimo"
        Me.MinimoDataGridViewTextBoxColumn.HeaderText = "minimo"
        Me.MinimoDataGridViewTextBoxColumn.Name = "MinimoDataGridViewTextBoxColumn"
        Me.MinimoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MinimoDataGridViewTextBoxColumn.Width = 70
        '
        'UnidadDataGridViewTextBoxColumn
        '
        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "unidad"
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        Me.UnidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnidadDataGridViewTextBoxColumn.Width = 120
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoDataGridViewTextBoxColumn.Width = 70
        '
        'UltimaFechaCompraDataGridViewTextBoxColumn
        '
        Me.UltimaFechaCompraDataGridViewTextBoxColumn.DataPropertyName = "ultimaFechaCompra"
        Me.UltimaFechaCompraDataGridViewTextBoxColumn.HeaderText = "ultimaFechaCompra"
        Me.UltimaFechaCompraDataGridViewTextBoxColumn.Name = "UltimaFechaCompraDataGridViewTextBoxColumn"
        Me.UltimaFechaCompraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaterialesTableAdapter
        '
        Me.MaterialesTableAdapter.ClearBeforeFill = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(499, 435)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(169, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Location = New System.Drawing.Point(313, 435)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(169, 23)
        Me.btnGrabar.TabIndex = 10
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(127, 435)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(169, 23)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'mcFecha
        '
        Me.mcFecha.DataBindings.Add(New System.Windows.Forms.Binding("SelectionRange", Me.MaterialesBindingSource, "ultimaFechaCompra", True))
        Me.mcFecha.Enabled = False
        Me.mcFecha.Location = New System.Drawing.Point(522, 54)
        Me.mcFecha.MaxSelectionCount = 1
        Me.mcFecha.Name = "mcFecha"
        Me.mcFecha.TabIndex = 8
        '
        'frmCatalogoMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 515)
        Me.Controls.Add(Me.mcFecha)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgMaterial)
        Me.Controls.Add(Me.cbUnidad)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtMaximos)
        Me.Controls.Add(Me.txtMinimos)
        Me.Controls.Add(Me.txtExistencia)
        Me.Controls.Add(Me.txtIdMaterial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnInicio)
        Me.Name = "frmCatalogoMateriales"
        Me.Text = "Materiales"
        CType(Me.MaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdMaterial As TextBox
    Friend WithEvents txtExistencia As TextBox
    Friend WithEvents txtMinimos As TextBox
    Friend WithEvents txtMaximos As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents cbUnidad As ComboBox
    Friend WithEvents dgMaterial As DataGridView
    Friend WithEvents DataSetSistema As DataSetSistema
    Friend WithEvents MaterialesBindingSource As BindingSource
    Friend WithEvents MaterialesTableAdapter As DataSetSistemaTableAdapters.MaterialesTableAdapter
    Friend WithEvents IdMaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaximoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinimoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UltimaFechaCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents mcFecha As MonthCalendar
End Class
