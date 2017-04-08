<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientoSalidasMaterialesConsultaGeneral
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.panelBusqueda = New System.Windows.Forms.Panel()
        Me.rbCalle = New System.Windows.Forms.RadioButton()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dtpConsultaFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.cbOrden = New System.Windows.Forms.ComboBox()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbEmpleado = New System.Windows.Forms.RadioButton()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.dgComprasMaterialesConsultaGeneral = New System.Windows.Forms.DataGridView()
        Me.idSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpConsultaFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.panelBusqueda.SuspendLayout()
        CType(Me.dgComprasMaterialesConsultaGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(287, 295)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(174, 25)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Salir"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'panelBusqueda
        '
        Me.panelBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBusqueda.Controls.Add(Me.dtpConsultaFechaFinal)
        Me.panelBusqueda.Controls.Add(Me.rbCalle)
        Me.panelBusqueda.Controls.Add(Me.btnAceptar)
        Me.panelBusqueda.Controls.Add(Me.dtpConsultaFechaInicio)
        Me.panelBusqueda.Controls.Add(Me.cbOrden)
        Me.panelBusqueda.Controls.Add(Me.rbTodos)
        Me.panelBusqueda.Controls.Add(Me.rbEmpleado)
        Me.panelBusqueda.Controls.Add(Me.rbFecha)
        Me.panelBusqueda.Location = New System.Drawing.Point(183, 12)
        Me.panelBusqueda.Name = "panelBusqueda"
        Me.panelBusqueda.Size = New System.Drawing.Size(382, 115)
        Me.panelBusqueda.TabIndex = 22
        '
        'rbCalle
        '
        Me.rbCalle.AutoSize = True
        Me.rbCalle.Location = New System.Drawing.Point(27, 78)
        Me.rbCalle.Name = "rbCalle"
        Me.rbCalle.Size = New System.Drawing.Size(48, 17)
        Me.rbCalle.TabIndex = 40
        Me.rbCalle.TabStop = True
        Me.rbCalle.Text = "Calle"
        Me.rbCalle.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(152, 66)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(174, 27)
        Me.btnAceptar.TabIndex = 14
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dtpConsultaFechaInicio
        '
        Me.dtpConsultaFechaInicio.Location = New System.Drawing.Point(127, 12)
        Me.dtpConsultaFechaInicio.Name = "dtpConsultaFechaInicio"
        Me.dtpConsultaFechaInicio.Size = New System.Drawing.Size(228, 20)
        Me.dtpConsultaFechaInicio.TabIndex = 39
        Me.dtpConsultaFechaInicio.Visible = False
        '
        'cbOrden
        '
        Me.cbOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrden.FormattingEnabled = True
        Me.cbOrden.Location = New System.Drawing.Point(144, 12)
        Me.cbOrden.Name = "cbOrden"
        Me.cbOrden.Size = New System.Drawing.Size(199, 21)
        Me.cbOrden.TabIndex = 9
        Me.cbOrden.Visible = False
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(27, 13)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbTodos.TabIndex = 14
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbEmpleado
        '
        Me.rbEmpleado.AutoSize = True
        Me.rbEmpleado.Location = New System.Drawing.Point(27, 34)
        Me.rbEmpleado.Name = "rbEmpleado"
        Me.rbEmpleado.Size = New System.Drawing.Size(72, 17)
        Me.rbEmpleado.TabIndex = 12
        Me.rbEmpleado.TabStop = True
        Me.rbEmpleado.Text = "Empleado"
        Me.rbEmpleado.UseVisualStyleBackColor = True
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Location = New System.Drawing.Point(27, 55)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(55, 17)
        Me.rbFecha.TabIndex = 11
        Me.rbFecha.TabStop = True
        Me.rbFecha.Text = "Fecha"
        Me.rbFecha.UseVisualStyleBackColor = True
        '
        'dgComprasMaterialesConsultaGeneral
        '
        Me.dgComprasMaterialesConsultaGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgComprasMaterialesConsultaGeneral.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idSalida, Me.idEmpleado, Me.Empleado, Me.idCalle, Me.Calle, Me.Concepto, Me.Fecha})
        Me.dgComprasMaterialesConsultaGeneral.Location = New System.Drawing.Point(12, 133)
        Me.dgComprasMaterialesConsultaGeneral.Name = "dgComprasMaterialesConsultaGeneral"
        Me.dgComprasMaterialesConsultaGeneral.Size = New System.Drawing.Size(723, 150)
        Me.dgComprasMaterialesConsultaGeneral.TabIndex = 21
        '
        'idSalida
        '
        Me.idSalida.HeaderText = "idSalida"
        Me.idSalida.Name = "idSalida"
        Me.idSalida.Width = 70
        '
        'idEmpleado
        '
        Me.idEmpleado.HeaderText = "idEmpleado"
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.Width = 70
        '
        'Empleado
        '
        Me.Empleado.HeaderText = "Empleado"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Width = 120
        '
        'idCalle
        '
        Me.idCalle.HeaderText = "idCalle"
        Me.idCalle.Name = "idCalle"
        Me.idCalle.Width = 70
        '
        'Calle
        '
        Me.Calle.HeaderText = "Calle"
        Me.Calle.Name = "Calle"
        Me.Calle.Width = 120
        '
        'Concepto
        '
        Me.Concepto.HeaderText = "Concepto"
        Me.Concepto.Name = "Concepto"
        Me.Concepto.Width = 150
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 80
        '
        'dtpConsultaFechaFinal
        '
        Me.dtpConsultaFechaFinal.Location = New System.Drawing.Point(127, 40)
        Me.dtpConsultaFechaFinal.Name = "dtpConsultaFechaFinal"
        Me.dtpConsultaFechaFinal.Size = New System.Drawing.Size(228, 20)
        Me.dtpConsultaFechaFinal.TabIndex = 41
        Me.dtpConsultaFechaFinal.Visible = False
        '
        'frmMovimientoSalidasMaterialesConsultaGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 329)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.panelBusqueda)
        Me.Controls.Add(Me.dgComprasMaterialesConsultaGeneral)
        Me.Name = "frmMovimientoSalidasMaterialesConsultaGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Salidas Materiales - Consulta General"
        Me.panelBusqueda.ResumeLayout(False)
        Me.panelBusqueda.PerformLayout()
        CType(Me.dgComprasMaterialesConsultaGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents panelBusqueda As Panel
    Friend WithEvents btnAceptar As Button
    Friend WithEvents dtpConsultaFechaInicio As DateTimePicker
    Friend WithEvents cbOrden As ComboBox
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents rbEmpleado As RadioButton
    Friend WithEvents rbFecha As RadioButton
    Friend WithEvents dgComprasMaterialesConsultaGeneral As DataGridView
    Friend WithEvents idSalida As DataGridViewTextBoxColumn
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents idCalle As DataGridViewTextBoxColumn
    Friend WithEvents Calle As DataGridViewTextBoxColumn
    Friend WithEvents Concepto As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents rbCalle As RadioButton
    Friend WithEvents dtpConsultaFechaFinal As DateTimePicker
End Class
