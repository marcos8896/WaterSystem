<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovimientoComprasMaterialesConsultaGeneral
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
        Me.dgComprasMaterialesConsultaGeneral = New System.Windows.Forms.DataGridView()
        Me.idOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelBusqueda = New System.Windows.Forms.Panel()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dtpConsultaFecha = New System.Windows.Forms.DateTimePicker()
        Me.cbOrden = New System.Windows.Forms.ComboBox()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbProveedor = New System.Windows.Forms.RadioButton()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.dgComprasMaterialesConsultaGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgComprasMaterialesConsultaGeneral
        '
        Me.dgComprasMaterialesConsultaGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgComprasMaterialesConsultaGeneral.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idOrden, Me.idProveedor, Me.Proveedor, Me.factura, Me.Fecha, Me.Subtotal, Me.IVA, Me.Total})
        Me.dgComprasMaterialesConsultaGeneral.Location = New System.Drawing.Point(12, 110)
        Me.dgComprasMaterialesConsultaGeneral.Name = "dgComprasMaterialesConsultaGeneral"
        Me.dgComprasMaterialesConsultaGeneral.Size = New System.Drawing.Size(723, 150)
        Me.dgComprasMaterialesConsultaGeneral.TabIndex = 18
        '
        'idOrden
        '
        Me.idOrden.HeaderText = "idOrden"
        Me.idOrden.Name = "idOrden"
        Me.idOrden.Width = 70
        '
        'idProveedor
        '
        Me.idProveedor.HeaderText = "idProveedor"
        Me.idProveedor.Name = "idProveedor"
        Me.idProveedor.Width = 70
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        '
        'factura
        '
        Me.factura.HeaderText = "Factura"
        Me.factura.Name = "factura"
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 70
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.Width = 85
        '
        'IVA
        '
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        Me.IVA.Width = 85
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'panelBusqueda
        '
        Me.panelBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBusqueda.Controls.Add(Me.btnAceptar)
        Me.panelBusqueda.Controls.Add(Me.dtpConsultaFecha)
        Me.panelBusqueda.Controls.Add(Me.cbOrden)
        Me.panelBusqueda.Controls.Add(Me.rbTodos)
        Me.panelBusqueda.Controls.Add(Me.rbProveedor)
        Me.panelBusqueda.Controls.Add(Me.rbFecha)
        Me.panelBusqueda.Location = New System.Drawing.Point(183, 12)
        Me.panelBusqueda.Name = "panelBusqueda"
        Me.panelBusqueda.Size = New System.Drawing.Size(382, 88)
        Me.panelBusqueda.TabIndex = 19
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(152, 49)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(174, 27)
        Me.btnAceptar.TabIndex = 14
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dtpConsultaFecha
        '
        Me.dtpConsultaFecha.Location = New System.Drawing.Point(127, 12)
        Me.dtpConsultaFecha.Name = "dtpConsultaFecha"
        Me.dtpConsultaFecha.Size = New System.Drawing.Size(228, 20)
        Me.dtpConsultaFecha.TabIndex = 39
        Me.dtpConsultaFecha.Visible = False
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
        'rbProveedor
        '
        Me.rbProveedor.AutoSize = True
        Me.rbProveedor.Location = New System.Drawing.Point(27, 34)
        Me.rbProveedor.Name = "rbProveedor"
        Me.rbProveedor.Size = New System.Drawing.Size(74, 17)
        Me.rbProveedor.TabIndex = 12
        Me.rbProveedor.TabStop = True
        Me.rbProveedor.Text = "Proveedor"
        Me.rbProveedor.UseVisualStyleBackColor = True
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
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(287, 272)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(174, 25)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Salir"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMovimientoComprasMaterialesConsultaGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 313)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.panelBusqueda)
        Me.Controls.Add(Me.dgComprasMaterialesConsultaGeneral)
        Me.Name = "frmMovimientoComprasMaterialesConsultaGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Compras Materiales - Consulta General"
        CType(Me.dgComprasMaterialesConsultaGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBusqueda.ResumeLayout(False)
        Me.panelBusqueda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgComprasMaterialesConsultaGeneral As DataGridView
    Friend WithEvents idOrden As DataGridViewTextBoxColumn
    Friend WithEvents idProveedor As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents factura As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents panelBusqueda As Panel
    Friend WithEvents btnAceptar As Button
    Friend WithEvents dtpConsultaFecha As DateTimePicker
    Friend WithEvents cbOrden As ComboBox
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents rbProveedor As RadioButton
    Friend WithEvents rbFecha As RadioButton
    Friend WithEvents btnExit As Button
End Class
