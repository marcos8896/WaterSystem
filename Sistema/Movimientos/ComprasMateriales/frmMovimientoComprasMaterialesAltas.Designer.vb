﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovimientoComprasMaterialesAltas
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelProveedor = New System.Windows.Forms.Panel()
        Me.txtProveedorTelefono = New System.Windows.Forms.TextBox()
        Me.combitoProveedor = New System.Windows.Forms.ComboBox()
        Me.txtProveedorDomicilio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdProveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelOrden = New System.Windows.Forms.Panel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdOrden = New System.Windows.Forms.TextBox()
        Me.panelMaterial = New System.Windows.Forms.Panel()
        Me.txtUltimaFechaCompra = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCostoAnterior = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMinimos = New System.Windows.Forms.TextBox()
        Me.txtMaximos = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtExistencias = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIdMaterial = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.combitoMaterial = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.dgComprasMateriales = New System.Windows.Forms.DataGridView()
        Me.idMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.panelDataGrid = New System.Windows.Forms.Panel()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.panelBotones = New System.Windows.Forms.Panel()
        Me.panelProveedor.SuspendLayout()
        Me.panelOrden.SuspendLayout()
        Me.panelMaterial.SuspendLayout()
        CType(Me.dgComprasMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDataGrid.SuspendLayout()
        Me.panelBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelProveedor
        '
        Me.panelProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelProveedor.Controls.Add(Me.txtProveedorTelefono)
        Me.panelProveedor.Controls.Add(Me.combitoProveedor)
        Me.panelProveedor.Controls.Add(Me.txtProveedorDomicilio)
        Me.panelProveedor.Controls.Add(Me.Label4)
        Me.panelProveedor.Controls.Add(Me.Label3)
        Me.panelProveedor.Controls.Add(Me.Label2)
        Me.panelProveedor.Controls.Add(Me.txtIdProveedor)
        Me.panelProveedor.Controls.Add(Me.Label1)
        Me.panelProveedor.Location = New System.Drawing.Point(12, 12)
        Me.panelProveedor.Name = "panelProveedor"
        Me.panelProveedor.Size = New System.Drawing.Size(281, 120)
        Me.panelProveedor.TabIndex = 0
        Me.panelProveedor.TabStop = True
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
        'combitoProveedor
        '
        Me.combitoProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combitoProveedor.Enabled = False
        Me.combitoProveedor.FormattingEnabled = True
        Me.combitoProveedor.Location = New System.Drawing.Point(76, 8)
        Me.combitoProveedor.Name = "combitoProveedor"
        Me.combitoProveedor.Size = New System.Drawing.Size(190, 21)
        Me.combitoProveedor.TabIndex = 1
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
        'panelOrden
        '
        Me.panelOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelOrden.Controls.Add(Me.dtpFecha)
        Me.panelOrden.Controls.Add(Me.txtFactura)
        Me.panelOrden.Controls.Add(Me.Label5)
        Me.panelOrden.Controls.Add(Me.Label6)
        Me.panelOrden.Controls.Add(Me.Label7)
        Me.panelOrden.Controls.Add(Me.txtIdOrden)
        Me.panelOrden.Location = New System.Drawing.Point(312, 12)
        Me.panelOrden.Name = "panelOrden"
        Me.panelOrden.Size = New System.Drawing.Size(298, 120)
        Me.panelOrden.TabIndex = 2
        Me.panelOrden.TabStop = True
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
        Me.txtFactura.MaxLength = 50
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
        'txtIdOrden
        '
        Me.txtIdOrden.Location = New System.Drawing.Point(58, 12)
        Me.txtIdOrden.Name = "txtIdOrden"
        Me.txtIdOrden.ReadOnly = True
        Me.txtIdOrden.Size = New System.Drawing.Size(95, 20)
        Me.txtIdOrden.TabIndex = 2
        Me.txtIdOrden.TabStop = False
        '
        'panelMaterial
        '
        Me.panelMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMaterial.Controls.Add(Me.txtUltimaFechaCompra)
        Me.panelMaterial.Controls.Add(Me.Label20)
        Me.panelMaterial.Controls.Add(Me.btnAceptar)
        Me.panelMaterial.Controls.Add(Me.txtUnidad)
        Me.panelMaterial.Controls.Add(Me.Label16)
        Me.panelMaterial.Controls.Add(Me.txtCostoAnterior)
        Me.panelMaterial.Controls.Add(Me.Label15)
        Me.panelMaterial.Controls.Add(Me.txtMinimos)
        Me.panelMaterial.Controls.Add(Me.txtMaximos)
        Me.panelMaterial.Controls.Add(Me.Label14)
        Me.panelMaterial.Controls.Add(Me.Label13)
        Me.panelMaterial.Controls.Add(Me.txtExistencias)
        Me.panelMaterial.Controls.Add(Me.txtCosto)
        Me.panelMaterial.Controls.Add(Me.txtCantidad)
        Me.panelMaterial.Controls.Add(Me.Label12)
        Me.panelMaterial.Controls.Add(Me.txtIdMaterial)
        Me.panelMaterial.Controls.Add(Me.Label11)
        Me.panelMaterial.Controls.Add(Me.Label9)
        Me.panelMaterial.Controls.Add(Me.Label8)
        Me.panelMaterial.Controls.Add(Me.combitoMaterial)
        Me.panelMaterial.Controls.Add(Me.Label10)
        Me.panelMaterial.Location = New System.Drawing.Point(12, 138)
        Me.panelMaterial.Name = "panelMaterial"
        Me.panelMaterial.Size = New System.Drawing.Size(598, 161)
        Me.panelMaterial.TabIndex = 6
        Me.panelMaterial.TabStop = True
        '
        'txtUltimaFechaCompra
        '
        Me.txtUltimaFechaCompra.Location = New System.Drawing.Point(414, 123)
        Me.txtUltimaFechaCompra.Name = "txtUltimaFechaCompra"
        Me.txtUltimaFechaCompra.ReadOnly = True
        Me.txtUltimaFechaCompra.Size = New System.Drawing.Size(139, 20)
        Me.txtUltimaFechaCompra.TabIndex = 25
        Me.txtUltimaFechaCompra.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(422, 103)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Última fecha de compra:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(232, 119)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(133, 27)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(457, 63)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.ReadOnly = True
        Me.txtUnidad.Size = New System.Drawing.Size(126, 20)
        Me.txtUnidad.TabIndex = 22
        Me.txtUnidad.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(407, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Unidad:"
        '
        'txtCostoAnterior
        '
        Me.txtCostoAnterior.Location = New System.Drawing.Point(488, 37)
        Me.txtCostoAnterior.Name = "txtCostoAnterior"
        Me.txtCostoAnterior.ReadOnly = True
        Me.txtCostoAnterior.Size = New System.Drawing.Size(95, 20)
        Me.txtCostoAnterior.TabIndex = 20
        Me.txtCostoAnterior.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(407, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Costo anterior:"
        '
        'txtMinimos
        '
        Me.txtMinimos.Location = New System.Drawing.Point(282, 89)
        Me.txtMinimos.Name = "txtMinimos"
        Me.txtMinimos.ReadOnly = True
        Me.txtMinimos.Size = New System.Drawing.Size(95, 20)
        Me.txtMinimos.TabIndex = 18
        Me.txtMinimos.TabStop = False
        '
        'txtMaximos
        '
        Me.txtMaximos.Location = New System.Drawing.Point(282, 63)
        Me.txtMaximos.Name = "txtMaximos"
        Me.txtMaximos.ReadOnly = True
        Me.txtMaximos.Size = New System.Drawing.Size(95, 20)
        Me.txtMaximos.TabIndex = 17
        Me.txtMaximos.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(213, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Mínimos:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(213, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Máximos:"
        '
        'txtExistencias
        '
        Me.txtExistencias.Location = New System.Drawing.Point(282, 37)
        Me.txtExistencias.Name = "txtExistencias"
        Me.txtExistencias.ReadOnly = True
        Me.txtExistencias.Size = New System.Drawing.Size(95, 20)
        Me.txtExistencias.TabIndex = 14
        Me.txtExistencias.TabStop = False
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(68, 89)
        Me.txtCosto.MaxLength = 15
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.ReadOnly = True
        Me.txtCosto.Size = New System.Drawing.Size(122, 20)
        Me.txtCosto.TabIndex = 6
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(68, 63)
        Me.txtCantidad.MaxLength = 15
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(122, 20)
        Me.txtCantidad.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Costo:"
        '
        'txtIdMaterial
        '
        Me.txtIdMaterial.Location = New System.Drawing.Point(68, 37)
        Me.txtIdMaterial.Name = "txtIdMaterial"
        Me.txtIdMaterial.ReadOnly = True
        Me.txtIdMaterial.Size = New System.Drawing.Size(95, 20)
        Me.txtIdMaterial.TabIndex = 8
        Me.txtIdMaterial.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Cantidad:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(213, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Existencias:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "idMaterial:"
        '
        'combitoMaterial
        '
        Me.combitoMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combitoMaterial.Enabled = False
        Me.combitoMaterial.FormattingEnabled = True
        Me.combitoMaterial.Location = New System.Drawing.Point(59, 9)
        Me.combitoMaterial.Name = "combitoMaterial"
        Me.combitoMaterial.Size = New System.Drawing.Size(190, 21)
        Me.combitoMaterial.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Material:"
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
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(82, 174)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(99, 20)
        Me.txtSubtotal.TabIndex = 32
        Me.txtSubtotal.TabStop = False
        '
        'dgComprasMateriales
        '
        Me.dgComprasMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgComprasMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMaterial, Me.Material, Me.Cantidad, Me.Costo, Me.Importe})
        Me.dgComprasMateriales.Enabled = False
        Me.dgComprasMateriales.Location = New System.Drawing.Point(3, 15)
        Me.dgComprasMateriales.Name = "dgComprasMateriales"
        Me.dgComprasMateriales.Size = New System.Drawing.Size(590, 150)
        Me.dgComprasMateriales.TabIndex = 30
        '
        'idMaterial
        '
        DataGridViewCellStyle5.NullValue = Nothing
        Me.idMaterial.DefaultCellStyle = DataGridViewCellStyle5
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
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle6
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Costo
        '
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Costo.DefaultCellStyle = DataGridViewCellStyle7
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        '
        'Importe
        '
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle8
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
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
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(461, 174)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(99, 20)
        Me.txtTotal.TabIndex = 34
        Me.txtTotal.TabStop = False
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
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(264, 174)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(99, 20)
        Me.txtIVA.TabIndex = 36
        Me.txtIVA.TabStop = False
        '
        'panelDataGrid
        '
        Me.panelDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDataGrid.Controls.Add(Me.txtIVA)
        Me.panelDataGrid.Controls.Add(Me.Label19)
        Me.panelDataGrid.Controls.Add(Me.txtTotal)
        Me.panelDataGrid.Controls.Add(Me.Label17)
        Me.panelDataGrid.Controls.Add(Me.dgComprasMateriales)
        Me.panelDataGrid.Controls.Add(Me.txtSubtotal)
        Me.panelDataGrid.Controls.Add(Me.Label18)
        Me.panelDataGrid.Location = New System.Drawing.Point(12, 305)
        Me.panelDataGrid.Name = "panelDataGrid"
        Me.panelDataGrid.Size = New System.Drawing.Size(598, 203)
        Me.panelDataGrid.TabIndex = 32
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Location = New System.Drawing.Point(232, 8)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(132, 27)
        Me.btnGrabar.TabIndex = 8
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(421, 8)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(132, 27)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(43, 8)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(132, 27)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'panelBotones
        '
        Me.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBotones.Controls.Add(Me.btnNuevo)
        Me.panelBotones.Controls.Add(Me.btnSalir)
        Me.panelBotones.Controls.Add(Me.btnGrabar)
        Me.panelBotones.Location = New System.Drawing.Point(12, 516)
        Me.panelBotones.Name = "panelBotones"
        Me.panelBotones.Size = New System.Drawing.Size(597, 42)
        Me.panelBotones.TabIndex = 4
        '
        'frmMovimientoComprasMaterialesAltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 580)
        Me.Controls.Add(Me.panelBotones)
        Me.Controls.Add(Me.panelDataGrid)
        Me.Controls.Add(Me.panelMaterial)
        Me.Controls.Add(Me.panelOrden)
        Me.Controls.Add(Me.panelProveedor)
        Me.Name = "frmMovimientoComprasMaterialesAltas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Compras Materiales -  Altas"
        Me.panelProveedor.ResumeLayout(False)
        Me.panelProveedor.PerformLayout()
        Me.panelOrden.ResumeLayout(False)
        Me.panelOrden.PerformLayout()
        Me.panelMaterial.ResumeLayout(False)
        Me.panelMaterial.PerformLayout()
        CType(Me.dgComprasMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDataGrid.ResumeLayout(False)
        Me.panelDataGrid.PerformLayout()
        Me.panelBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelProveedor As Panel
    Friend WithEvents txtProveedorTelefono As TextBox
    Friend WithEvents combitoProveedor As ComboBox
    Friend WithEvents txtProveedorDomicilio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdProveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents panelOrden As Panel
    Friend WithEvents txtFactura As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIdOrden As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents panelMaterial As Panel
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCostoAnterior As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtMinimos As TextBox
    Friend WithEvents txtMaximos As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtExistencias As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtIdMaterial As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents combitoMaterial As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents dgComprasMateriales As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents panelDataGrid As Panel
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents panelBotones As Panel
    Friend WithEvents txtUltimaFechaCompra As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents idMaterial As DataGridViewTextBoxColumn
    Friend WithEvents Material As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
End Class
