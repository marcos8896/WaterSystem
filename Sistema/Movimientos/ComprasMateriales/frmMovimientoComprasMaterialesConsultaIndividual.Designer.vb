<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientoComprasMaterialesConsultaIndividual
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelBotones = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.panelDataGrid = New System.Windows.Forms.Panel()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dgComprasMaterialesConsulta = New System.Windows.Forms.DataGridView()
        Me.idMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.panelOrden = New System.Windows.Forms.Panel()
        Me.combitoIdOrden = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panelProveedor = New System.Windows.Forms.Panel()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.txtProveedorTelefono = New System.Windows.Forms.TextBox()
        Me.txtProveedorDomicilio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdProveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelBotones.SuspendLayout()
        Me.panelDataGrid.SuspendLayout()
        CType(Me.dgComprasMaterialesConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOrden.SuspendLayout()
        Me.panelProveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBotones
        '
        Me.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBotones.Controls.Add(Me.btnSalir)
        Me.panelBotones.Location = New System.Drawing.Point(12, 347)
        Me.panelBotones.Name = "panelBotones"
        Me.panelBotones.Size = New System.Drawing.Size(597, 42)
        Me.panelBotones.TabIndex = 35
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(196, 7)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(202, 27)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'panelDataGrid
        '
        Me.panelDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDataGrid.Controls.Add(Me.txtIVA)
        Me.panelDataGrid.Controls.Add(Me.Label19)
        Me.panelDataGrid.Controls.Add(Me.txtTotal)
        Me.panelDataGrid.Controls.Add(Me.Label17)
        Me.panelDataGrid.Controls.Add(Me.dgComprasMaterialesConsulta)
        Me.panelDataGrid.Controls.Add(Me.txtSubtotal)
        Me.panelDataGrid.Controls.Add(Me.Label18)
        Me.panelDataGrid.Location = New System.Drawing.Point(12, 138)
        Me.panelDataGrid.Name = "panelDataGrid"
        Me.panelDataGrid.Size = New System.Drawing.Size(598, 203)
        Me.panelDataGrid.TabIndex = 37
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(264, 174)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(99, 20)
        Me.txtIVA.TabIndex = 36
        Me.txtIVA.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(223, 177)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 13)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "IVA:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(461, 174)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(99, 20)
        Me.txtTotal.TabIndex = 34
        Me.txtTotal.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(418, 177)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Total:"
        '
        'dgComprasMaterialesConsulta
        '
        Me.dgComprasMaterialesConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgComprasMaterialesConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMaterial, Me.Material, Me.Cantidad, Me.Costo, Me.Importe})
        Me.dgComprasMaterialesConsulta.Enabled = False
        Me.dgComprasMaterialesConsulta.Location = New System.Drawing.Point(3, 15)
        Me.dgComprasMaterialesConsulta.Name = "dgComprasMaterialesConsulta"
        Me.dgComprasMaterialesConsulta.Size = New System.Drawing.Size(590, 150)
        Me.dgComprasMaterialesConsulta.TabIndex = 30
        '
        'idMaterial
        '
        DataGridViewCellStyle1.NullValue = Nothing
        Me.idMaterial.DefaultCellStyle = DataGridViewCellStyle1
        Me.idMaterial.HeaderText = "idMaterial"
        Me.idMaterial.Name = "idMaterial"
        '
        'Material
        '
        Me.Material.HeaderText = "Material"
        Me.Material.Name = "Material"
        Me.Material.Width = 145
        '
        'Cantidad
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Costo
        '
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Costo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        '
        'Importe
        '
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle4
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(82, 174)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(99, 20)
        Me.txtSubtotal.TabIndex = 32
        Me.txtSubtotal.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(24, 177)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Subtotal:"
        '
        'panelOrden
        '
        Me.panelOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelOrden.Controls.Add(Me.combitoIdOrden)
        Me.panelOrden.Controls.Add(Me.dtpFecha)
        Me.panelOrden.Controls.Add(Me.txtFactura)
        Me.panelOrden.Controls.Add(Me.Label5)
        Me.panelOrden.Controls.Add(Me.Label6)
        Me.panelOrden.Controls.Add(Me.Label7)
        Me.panelOrden.Location = New System.Drawing.Point(312, 12)
        Me.panelOrden.Name = "panelOrden"
        Me.panelOrden.Size = New System.Drawing.Size(298, 120)
        Me.panelOrden.TabIndex = 34
        Me.panelOrden.TabStop = True
        '
        'combitoIdOrden
        '
        Me.combitoIdOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combitoIdOrden.FormattingEnabled = True
        Me.combitoIdOrden.Location = New System.Drawing.Point(52, 8)
        Me.combitoIdOrden.Name = "combitoIdOrden"
        Me.combitoIdOrden.Size = New System.Drawing.Size(190, 21)
        Me.combitoIdOrden.TabIndex = 6
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(52, 62)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(228, 20)
        Me.dtpFecha.TabIndex = 3
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(58, 36)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.ReadOnly = True
        Me.txtFactura.Size = New System.Drawing.Size(141, 20)
        Me.txtFactura.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fecha:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Factura:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "idOrden:"
        '
        'panelProveedor
        '
        Me.panelProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelProveedor.Controls.Add(Me.txtNombreProveedor)
        Me.panelProveedor.Controls.Add(Me.txtProveedorTelefono)
        Me.panelProveedor.Controls.Add(Me.txtProveedorDomicilio)
        Me.panelProveedor.Controls.Add(Me.Label4)
        Me.panelProveedor.Controls.Add(Me.Label3)
        Me.panelProveedor.Controls.Add(Me.Label2)
        Me.panelProveedor.Controls.Add(Me.txtIdProveedor)
        Me.panelProveedor.Controls.Add(Me.Label1)
        Me.panelProveedor.Location = New System.Drawing.Point(12, 12)
        Me.panelProveedor.Name = "panelProveedor"
        Me.panelProveedor.Size = New System.Drawing.Size(281, 120)
        Me.panelProveedor.TabIndex = 33
        Me.panelProveedor.TabStop = True
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Location = New System.Drawing.Point(76, 11)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.ReadOnly = True
        Me.txtNombreProveedor.Size = New System.Drawing.Size(136, 20)
        Me.txtNombreProveedor.TabIndex = 9
        Me.txtNombreProveedor.TabStop = False
        '
        'txtProveedorTelefono
        '
        Me.txtProveedorTelefono.Location = New System.Drawing.Point(76, 83)
        Me.txtProveedorTelefono.Name = "txtProveedorTelefono"
        Me.txtProveedorTelefono.ReadOnly = True
        Me.txtProveedorTelefono.Size = New System.Drawing.Size(128, 20)
        Me.txtProveedorTelefono.TabIndex = 8
        Me.txtProveedorTelefono.TabStop = False
        '
        'txtProveedorDomicilio
        '
        Me.txtProveedorDomicilio.Location = New System.Drawing.Point(76, 58)
        Me.txtProveedorDomicilio.Name = "txtProveedorDomicilio"
        Me.txtProveedorDomicilio.ReadOnly = True
        Me.txtProveedorDomicilio.Size = New System.Drawing.Size(190, 20)
        Me.txtProveedorDomicilio.TabIndex = 6
        Me.txtProveedorDomicilio.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Teléfono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Domicilio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "idProveedor:"
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.Location = New System.Drawing.Point(76, 34)
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.ReadOnly = True
        Me.txtIdProveedor.Size = New System.Drawing.Size(74, 20)
        Me.txtIdProveedor.TabIndex = 2
        Me.txtIdProveedor.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor:"
        '
        'frmMovimientoComprasMaterialesConsultaIndividual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 397)
        Me.Controls.Add(Me.panelBotones)
        Me.Controls.Add(Me.panelDataGrid)
        Me.Controls.Add(Me.panelOrden)
        Me.Controls.Add(Me.panelProveedor)
        Me.Name = "frmMovimientoComprasMaterialesConsultaIndividual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Compras Materiales - Consulta Individual"
        Me.panelBotones.ResumeLayout(False)
        Me.panelDataGrid.ResumeLayout(False)
        Me.panelDataGrid.PerformLayout()
        CType(Me.dgComprasMaterialesConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOrden.ResumeLayout(False)
        Me.panelOrden.PerformLayout()
        Me.panelProveedor.ResumeLayout(False)
        Me.panelProveedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelBotones As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents panelDataGrid As Panel
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dgComprasMaterialesConsulta As DataGridView
    Friend WithEvents idMaterial As DataGridViewTextBoxColumn
    Friend WithEvents Material As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents panelOrden As Panel
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtFactura As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents panelProveedor As Panel
    Friend WithEvents txtProveedorTelefono As TextBox
    Friend WithEvents txtProveedorDomicilio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdProveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents combitoIdOrden As ComboBox
    Friend WithEvents txtNombreProveedor As TextBox
End Class
