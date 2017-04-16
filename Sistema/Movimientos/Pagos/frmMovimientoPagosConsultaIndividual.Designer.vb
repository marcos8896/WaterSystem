<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovimientoPagosConsultaIndividual
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
        Me.panelServiciosAtendidos = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtDescuentoFinal = New System.Windows.Forms.TextBox()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtOtros = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.panelBotones = New System.Windows.Forms.Panel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgDatosCuentas = New System.Windows.Forms.DataGridView()
        Me.idCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPagoAnio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPagoMes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBuscarCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelRejillaCuenta = New System.Windows.Forms.Panel()
        Me.panelIdPagos = New System.Windows.Forms.Panel()
        Me.dgDatosPagos = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panelEmpleado = New System.Windows.Forms.Panel()
        Me.txtEmpleadoTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmpleadoColonia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmpleadoDomicilio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmpleadoNombre = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtServicioPrecio = New System.Windows.Forms.TextBox()
        Me.txtIdServicio = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtServicioDescripcion = New System.Windows.Forms.TextBox()
        Me.idPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Otros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIdSituacion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSituacionDescuento = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtNombreSituacion = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCuotaFija = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtRecargo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtAnioTarifa = New System.Windows.Forms.TextBox()
        Me.txtTAR = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtINFRA = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtIdTarifa = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtMesInicial = New System.Windows.Forms.TextBox()
        Me.txtMesFinal = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtCuotaFijaCalculada = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtRecargoCalculado = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtTARCalculada = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtINFRACalculada = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.labelPagoPor = New System.Windows.Forms.Label()
        Me.panelPagoAgua = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtPagoTipo = New System.Windows.Forms.TextBox()
        Me.txtPagoFecha = New System.Windows.Forms.TextBox()
        Me.txtPagoNombreCuenta = New System.Windows.Forms.TextBox()
        Me.txtIdPago = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panelServiciosAtendidos.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.panelBotones.SuspendLayout()
        CType(Me.dgDatosCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelRejillaCuenta.SuspendLayout()
        Me.panelIdPagos.SuspendLayout()
        CType(Me.dgDatosPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEmpleado.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.panelPagoAgua.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelServiciosAtendidos
        '
        Me.panelServiciosAtendidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelServiciosAtendidos.Controls.Add(Me.panelEmpleado)
        Me.panelServiciosAtendidos.Controls.Add(Me.Panel1)
        Me.panelServiciosAtendidos.Location = New System.Drawing.Point(12, 332)
        Me.panelServiciosAtendidos.Name = "panelServiciosAtendidos"
        Me.panelServiciosAtendidos.Size = New System.Drawing.Size(741, 173)
        Me.panelServiciosAtendidos.TabIndex = 41
        Me.panelServiciosAtendidos.TabStop = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(181, 56)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(34, 13)
        Me.Label31.TabIndex = 25
        Me.Label31.Text = "Total:"
        '
        'txtDescuentoFinal
        '
        Me.txtDescuentoFinal.Location = New System.Drawing.Point(70, 53)
        Me.txtDescuentoFinal.Name = "txtDescuentoFinal"
        Me.txtDescuentoFinal.ReadOnly = True
        Me.txtDescuentoFinal.Size = New System.Drawing.Size(101, 20)
        Me.txtDescuentoFinal.TabIndex = 34
        Me.txtDescuentoFinal.TabStop = False
        Me.txtDescuentoFinal.Visible = False
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Location = New System.Drawing.Point(7, 56)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(62, 13)
        Me.lblDescuento.TabIndex = 33
        Me.lblDescuento.Text = "Descuento:"
        Me.lblDescuento.Visible = False
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(221, 31)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(101, 20)
        Me.txtSubtotal.TabIndex = 32
        Me.txtSubtotal.TabStop = False
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(172, 34)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(49, 13)
        Me.Label40.TabIndex = 31
        Me.Label40.Text = "Subtotal:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(221, 53)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(101, 20)
        Me.txtTotal.TabIndex = 26
        Me.txtTotal.TabStop = False
        '
        'txtOtros
        '
        Me.txtOtros.Location = New System.Drawing.Point(70, 31)
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.ReadOnly = True
        Me.txtOtros.Size = New System.Drawing.Size(101, 20)
        Me.txtOtros.TabIndex = 24
        Me.txtOtros.TabStop = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(29, 36)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(35, 13)
        Me.Label30.TabIndex = 24
        Me.Label30.Text = "Otros:"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.txtDescuentoFinal)
        Me.Panel6.Controls.Add(Me.lblDescuento)
        Me.Panel6.Controls.Add(Me.txtSubtotal)
        Me.Panel6.Controls.Add(Me.Label40)
        Me.Panel6.Controls.Add(Me.txtTotal)
        Me.Panel6.Controls.Add(Me.txtOtros)
        Me.Panel6.Controls.Add(Me.Label31)
        Me.Panel6.Controls.Add(Me.Label30)
        Me.Panel6.Location = New System.Drawing.Point(12, 601)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(339, 83)
        Me.Panel6.TabIndex = 43
        '
        'panelBotones
        '
        Me.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBotones.Controls.Add(Me.btnImprimir)
        Me.panelBotones.Controls.Add(Me.btnSalir)
        Me.panelBotones.Location = New System.Drawing.Point(357, 601)
        Me.panelBotones.Name = "panelBotones"
        Me.panelBotones.Size = New System.Drawing.Size(396, 83)
        Me.panelBotones.TabIndex = 42
        '
        'btnImprimir
        '
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(219, 24)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(132, 27)
        Me.btnImprimir.TabIndex = 10
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(49, 24)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(132, 27)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(257, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Seleccione el registro deseado"
        '
        'dgDatosCuentas
        '
        Me.dgDatosCuentas.AllowUserToAddRows = False
        Me.dgDatosCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatosCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCuenta, Me.Nombre, Me.idCalle, Me.Calle, Me.fechaAlta, Me.UltimoPagoAnio, Me.UltimoPagoMes})
        Me.dgDatosCuentas.Location = New System.Drawing.Point(6, 43)
        Me.dgDatosCuentas.Name = "dgDatosCuentas"
        Me.dgDatosCuentas.ReadOnly = True
        Me.dgDatosCuentas.Size = New System.Drawing.Size(725, 111)
        Me.dgDatosCuentas.TabIndex = 10
        '
        'idCuenta
        '
        Me.idCuenta.HeaderText = "idCuenta"
        Me.idCuenta.Name = "idCuenta"
        Me.idCuenta.ReadOnly = True
        Me.idCuenta.Width = 65
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 165
        '
        'idCalle
        '
        Me.idCalle.HeaderText = "idCalle"
        Me.idCalle.Name = "idCalle"
        Me.idCalle.ReadOnly = True
        Me.idCalle.Width = 65
        '
        'Calle
        '
        Me.Calle.HeaderText = "Calle"
        Me.Calle.Name = "Calle"
        Me.Calle.ReadOnly = True
        Me.Calle.Width = 165
        '
        'fechaAlta
        '
        Me.fechaAlta.HeaderText = "fechaAlta"
        Me.fechaAlta.Name = "fechaAlta"
        Me.fechaAlta.ReadOnly = True
        Me.fechaAlta.Width = 70
        '
        'UltimoPagoAnio
        '
        Me.UltimoPagoAnio.HeaderText = "UltimoPagoAnio"
        Me.UltimoPagoAnio.Name = "UltimoPagoAnio"
        Me.UltimoPagoAnio.ReadOnly = True
        Me.UltimoPagoAnio.Width = 70
        '
        'UltimoPagoMes
        '
        Me.UltimoPagoMes.HeaderText = "UltimoPagoMes"
        Me.UltimoPagoMes.Name = "UltimoPagoMes"
        Me.UltimoPagoMes.ReadOnly = True
        Me.UltimoPagoMes.Width = 70
        '
        'txtBuscarCuenta
        '
        Me.txtBuscarCuenta.Location = New System.Drawing.Point(289, 10)
        Me.txtBuscarCuenta.Name = "txtBuscarCuenta"
        Me.txtBuscarCuenta.Size = New System.Drawing.Size(312, 20)
        Me.txtBuscarCuenta.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(47, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de la cuenta (pagos pertenecientes):"
        '
        'panelRejillaCuenta
        '
        Me.panelRejillaCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelRejillaCuenta.Controls.Add(Me.Label2)
        Me.panelRejillaCuenta.Controls.Add(Me.dgDatosCuentas)
        Me.panelRejillaCuenta.Controls.Add(Me.txtBuscarCuenta)
        Me.panelRejillaCuenta.Controls.Add(Me.Label1)
        Me.panelRejillaCuenta.Location = New System.Drawing.Point(12, 12)
        Me.panelRejillaCuenta.Name = "panelRejillaCuenta"
        Me.panelRejillaCuenta.Size = New System.Drawing.Size(741, 192)
        Me.panelRejillaCuenta.TabIndex = 37
        Me.panelRejillaCuenta.TabStop = True
        '
        'panelIdPagos
        '
        Me.panelIdPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelIdPagos.Controls.Add(Me.dgDatosPagos)
        Me.panelIdPagos.Location = New System.Drawing.Point(12, 210)
        Me.panelIdPagos.Name = "panelIdPagos"
        Me.panelIdPagos.Size = New System.Drawing.Size(741, 120)
        Me.panelIdPagos.TabIndex = 39
        Me.panelIdPagos.TabStop = True
        '
        'dgDatosPagos
        '
        Me.dgDatosPagos.AllowUserToAddRows = False
        Me.dgDatosPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatosPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPago, Me.NombreCuenta, Me.Fecha, Me.Tipo, Me.Otros, Me.Total})
        Me.dgDatosPagos.Location = New System.Drawing.Point(35, 8)
        Me.dgDatosPagos.Name = "dgDatosPagos"
        Me.dgDatosPagos.Size = New System.Drawing.Size(675, 100)
        Me.dgDatosPagos.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(294, 16)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Datos monetarios del pago seleccionado"
        '
        'panelEmpleado
        '
        Me.panelEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmpleado.Controls.Add(Me.txtEmpleadoTelefono)
        Me.panelEmpleado.Controls.Add(Me.Label6)
        Me.panelEmpleado.Controls.Add(Me.Label5)
        Me.panelEmpleado.Controls.Add(Me.txtEmpleadoColonia)
        Me.panelEmpleado.Controls.Add(Me.Label4)
        Me.panelEmpleado.Controls.Add(Me.txtEmpleadoDomicilio)
        Me.panelEmpleado.Controls.Add(Me.Label3)
        Me.panelEmpleado.Controls.Add(Me.txtEmpleadoNombre)
        Me.panelEmpleado.Controls.Add(Me.Label37)
        Me.panelEmpleado.Controls.Add(Me.Label35)
        Me.panelEmpleado.Controls.Add(Me.txtIdEmpleado)
        Me.panelEmpleado.Location = New System.Drawing.Point(10, 19)
        Me.panelEmpleado.Name = "panelEmpleado"
        Me.panelEmpleado.Size = New System.Drawing.Size(479, 131)
        Me.panelEmpleado.TabIndex = 60
        '
        'txtEmpleadoTelefono
        '
        Me.txtEmpleadoTelefono.Location = New System.Drawing.Point(319, 62)
        Me.txtEmpleadoTelefono.Name = "txtEmpleadoTelefono"
        Me.txtEmpleadoTelefono.ReadOnly = True
        Me.txtEmpleadoTelefono.Size = New System.Drawing.Size(150, 20)
        Me.txtEmpleadoTelefono.TabIndex = 55
        Me.txtEmpleadoTelefono.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(150, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(241, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Empleado que atendió el servicio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(251, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Teléfono:"
        '
        'txtEmpleadoColonia
        '
        Me.txtEmpleadoColonia.Location = New System.Drawing.Point(319, 32)
        Me.txtEmpleadoColonia.Name = "txtEmpleadoColonia"
        Me.txtEmpleadoColonia.ReadOnly = True
        Me.txtEmpleadoColonia.Size = New System.Drawing.Size(150, 20)
        Me.txtEmpleadoColonia.TabIndex = 53
        Me.txtEmpleadoColonia.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Colonia:"
        '
        'txtEmpleadoDomicilio
        '
        Me.txtEmpleadoDomicilio.Location = New System.Drawing.Point(71, 83)
        Me.txtEmpleadoDomicilio.Name = "txtEmpleadoDomicilio"
        Me.txtEmpleadoDomicilio.ReadOnly = True
        Me.txtEmpleadoDomicilio.Size = New System.Drawing.Size(153, 20)
        Me.txtEmpleadoDomicilio.TabIndex = 51
        Me.txtEmpleadoDomicilio.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Domicilio:"
        '
        'txtEmpleadoNombre
        '
        Me.txtEmpleadoNombre.Location = New System.Drawing.Point(71, 57)
        Me.txtEmpleadoNombre.Name = "txtEmpleadoNombre"
        Me.txtEmpleadoNombre.ReadOnly = True
        Me.txtEmpleadoNombre.Size = New System.Drawing.Size(153, 20)
        Me.txtEmpleadoNombre.TabIndex = 49
        Me.txtEmpleadoNombre.TabStop = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(3, 61)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(47, 13)
        Me.Label37.TabIndex = 48
        Me.Label37.Text = "Nombre:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(3, 35)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(65, 13)
        Me.Label35.TabIndex = 47
        Me.Label35.Text = "idEmpleado:"
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Location = New System.Drawing.Point(71, 30)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.ReadOnly = True
        Me.txtIdEmpleado.Size = New System.Drawing.Size(74, 20)
        Me.txtIdEmpleado.TabIndex = 46
        Me.txtIdEmpleado.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtServicioPrecio)
        Me.Panel1.Controls.Add(Me.txtIdServicio)
        Me.Panel1.Controls.Add(Me.Label38)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.txtServicioDescripcion)
        Me.Panel1.Location = New System.Drawing.Point(495, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 131)
        Me.Panel1.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 16)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Servicio atendido"
        '
        'txtServicioPrecio
        '
        Me.txtServicioPrecio.Location = New System.Drawing.Point(77, 51)
        Me.txtServicioPrecio.Name = "txtServicioPrecio"
        Me.txtServicioPrecio.ReadOnly = True
        Me.txtServicioPrecio.Size = New System.Drawing.Size(74, 20)
        Me.txtServicioPrecio.TabIndex = 40
        Me.txtServicioPrecio.TabStop = False
        '
        'txtIdServicio
        '
        Me.txtIdServicio.Location = New System.Drawing.Point(77, 28)
        Me.txtIdServicio.Name = "txtIdServicio"
        Me.txtIdServicio.ReadOnly = True
        Me.txtIdServicio.Size = New System.Drawing.Size(74, 20)
        Me.txtIdServicio.TabIndex = 32
        Me.txtIdServicio.TabStop = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(5, 54)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(40, 13)
        Me.Label38.TabIndex = 41
        Me.Label38.Text = "Precio:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(5, 31)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(56, 13)
        Me.Label34.TabIndex = 33
        Me.Label34.Text = "idServicio:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(5, 78)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(66, 13)
        Me.Label36.TabIndex = 36
        Me.Label36.Text = "Descripción:"
        '
        'txtServicioDescripcion
        '
        Me.txtServicioDescripcion.Location = New System.Drawing.Point(77, 75)
        Me.txtServicioDescripcion.Multiline = True
        Me.txtServicioDescripcion.Name = "txtServicioDescripcion"
        Me.txtServicioDescripcion.ReadOnly = True
        Me.txtServicioDescripcion.Size = New System.Drawing.Size(147, 39)
        Me.txtServicioDescripcion.TabIndex = 37
        Me.txtServicioDescripcion.TabStop = False
        '
        'idPago
        '
        Me.idPago.HeaderText = "idPago"
        Me.idPago.Name = "idPago"
        Me.idPago.Width = 60
        '
        'NombreCuenta
        '
        Me.NombreCuenta.HeaderText = "Nombre de la cuenta"
        Me.NombreCuenta.Name = "NombreCuenta"
        Me.NombreCuenta.Width = 200
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 70
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'Otros
        '
        Me.Otros.HeaderText = "Otros"
        Me.Otros.Name = "Otros"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label32)
        Me.Panel3.Controls.Add(Me.txtNombreSituacion)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtSituacionDescuento)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.txtIdSituacion)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Location = New System.Drawing.Point(6, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(277, 111)
        Me.Panel3.TabIndex = 16
        Me.Panel3.TabStop = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Situación:"
        '
        'txtIdSituacion
        '
        Me.txtIdSituacion.Location = New System.Drawing.Point(90, 47)
        Me.txtIdSituacion.Name = "txtIdSituacion"
        Me.txtIdSituacion.ReadOnly = True
        Me.txtIdSituacion.Size = New System.Drawing.Size(74, 20)
        Me.txtIdSituacion.TabIndex = 14
        Me.txtIdSituacion.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "idSituacion:"
        '
        'txtSituacionDescuento
        '
        Me.txtSituacionDescuento.Location = New System.Drawing.Point(90, 70)
        Me.txtSituacionDescuento.Name = "txtSituacionDescuento"
        Me.txtSituacionDescuento.ReadOnly = True
        Me.txtSituacionDescuento.Size = New System.Drawing.Size(74, 20)
        Me.txtSituacionDescuento.TabIndex = 16
        Me.txtSituacionDescuento.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Descuento (%):"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(476, -121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 95)
        Me.DataGridView1.TabIndex = 0
        '
        'txtNombreSituacion
        '
        Me.txtNombreSituacion.Location = New System.Drawing.Point(90, 23)
        Me.txtNombreSituacion.Name = "txtNombreSituacion"
        Me.txtNombreSituacion.ReadOnly = True
        Me.txtNombreSituacion.Size = New System.Drawing.Size(178, 20)
        Me.txtNombreSituacion.TabIndex = 18
        Me.txtNombreSituacion.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(66, 4)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(134, 16)
        Me.Label32.TabIndex = 21
        Me.Label32.Text = "Situacion utilizada"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label33)
        Me.Panel4.Controls.Add(Me.txtIdTarifa)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.txtINFRA)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.txtTAR)
        Me.Panel4.Controls.Add(Me.txtAnioTarifa)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.txtRecargo)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.txtCuotaFija)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Location = New System.Drawing.Point(289, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(287, 111)
        Me.Panel4.TabIndex = 18
        Me.Panel4.TabStop = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "IdTarifa:"
        '
        'txtCuotaFija
        '
        Me.txtCuotaFija.Location = New System.Drawing.Point(65, 50)
        Me.txtCuotaFija.Name = "txtCuotaFija"
        Me.txtCuotaFija.ReadOnly = True
        Me.txtCuotaFija.Size = New System.Drawing.Size(70, 20)
        Me.txtCuotaFija.TabIndex = 14
        Me.txtCuotaFija.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Cuota fija:"
        '
        'txtRecargo
        '
        Me.txtRecargo.Location = New System.Drawing.Point(205, 49)
        Me.txtRecargo.Name = "txtRecargo"
        Me.txtRecargo.ReadOnly = True
        Me.txtRecargo.Size = New System.Drawing.Size(69, 20)
        Me.txtRecargo.TabIndex = 16
        Me.txtRecargo.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(148, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Recargo:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(148, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Año tarifa:"
        '
        'txtAnioTarifa
        '
        Me.txtAnioTarifa.Location = New System.Drawing.Point(205, 23)
        Me.txtAnioTarifa.Name = "txtAnioTarifa"
        Me.txtAnioTarifa.ReadOnly = True
        Me.txtAnioTarifa.Size = New System.Drawing.Size(69, 20)
        Me.txtAnioTarifa.TabIndex = 19
        Me.txtAnioTarifa.TabStop = False
        '
        'txtTAR
        '
        Me.txtTAR.Location = New System.Drawing.Point(65, 75)
        Me.txtTAR.Name = "txtTAR"
        Me.txtTAR.ReadOnly = True
        Me.txtTAR.Size = New System.Drawing.Size(70, 20)
        Me.txtTAR.TabIndex = 20
        Me.txtTAR.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(5, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "TAR:"
        '
        'txtINFRA
        '
        Me.txtINFRA.Location = New System.Drawing.Point(205, 74)
        Me.txtINFRA.Name = "txtINFRA"
        Me.txtINFRA.ReadOnly = True
        Me.txtINFRA.Size = New System.Drawing.Size(69, 20)
        Me.txtINFRA.TabIndex = 22
        Me.txtINFRA.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(148, 77)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 13)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "INFRA:"
        '
        'txtIdTarifa
        '
        Me.txtIdTarifa.Location = New System.Drawing.Point(65, 25)
        Me.txtIdTarifa.Name = "txtIdTarifa"
        Me.txtIdTarifa.ReadOnly = True
        Me.txtIdTarifa.Size = New System.Drawing.Size(70, 20)
        Me.txtIdTarifa.TabIndex = 24
        Me.txtIdTarifa.TabStop = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(62, 4)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(153, 16)
        Me.Label33.TabIndex = 22
        Me.Label33.Text = "Tarifa anual utilizada"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtMesFinal)
        Me.Panel2.Controls.Add(Me.txtMesInicial)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Location = New System.Drawing.Point(582, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(149, 111)
        Me.Panel2.TabIndex = 24
        Me.Panel2.TabStop = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 27)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Del mes:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 66)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Hasta el mes:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(17, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 16)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Meses pagados"
        '
        'txtMesInicial
        '
        Me.txtMesInicial.Location = New System.Drawing.Point(9, 43)
        Me.txtMesInicial.Name = "txtMesInicial"
        Me.txtMesInicial.ReadOnly = True
        Me.txtMesInicial.Size = New System.Drawing.Size(131, 20)
        Me.txtMesInicial.TabIndex = 19
        Me.txtMesInicial.TabStop = False
        '
        'txtMesFinal
        '
        Me.txtMesFinal.Location = New System.Drawing.Point(9, 82)
        Me.txtMesFinal.Name = "txtMesFinal"
        Me.txtMesFinal.ReadOnly = True
        Me.txtMesFinal.Size = New System.Drawing.Size(131, 20)
        Me.txtMesFinal.TabIndex = 20
        Me.txtMesFinal.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.labelPagoPor)
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Controls.Add(Me.txtINFRACalculada)
        Me.Panel5.Controls.Add(Me.Label26)
        Me.Panel5.Controls.Add(Me.txtTARCalculada)
        Me.Panel5.Controls.Add(Me.Label28)
        Me.Panel5.Controls.Add(Me.txtRecargoCalculado)
        Me.Panel5.Controls.Add(Me.Label29)
        Me.Panel5.Controls.Add(Me.txtCuotaFijaCalculada)
        Me.Panel5.Location = New System.Drawing.Point(6, 121)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(725, 38)
        Me.Panel5.TabIndex = 25
        Me.Panel5.TabStop = True
        '
        'txtCuotaFijaCalculada
        '
        Me.txtCuotaFijaCalculada.Location = New System.Drawing.Point(196, 8)
        Me.txtCuotaFijaCalculada.Name = "txtCuotaFijaCalculada"
        Me.txtCuotaFijaCalculada.ReadOnly = True
        Me.txtCuotaFijaCalculada.Size = New System.Drawing.Size(72, 20)
        Me.txtCuotaFijaCalculada.TabIndex = 14
        Me.txtCuotaFijaCalculada.TabStop = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(137, 11)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(54, 13)
        Me.Label29.TabIndex = 15
        Me.Label29.Text = "Cuota fija:"
        '
        'txtRecargoCalculado
        '
        Me.txtRecargoCalculado.Location = New System.Drawing.Point(348, 8)
        Me.txtRecargoCalculado.Name = "txtRecargoCalculado"
        Me.txtRecargoCalculado.ReadOnly = True
        Me.txtRecargoCalculado.Size = New System.Drawing.Size(72, 20)
        Me.txtRecargoCalculado.TabIndex = 16
        Me.txtRecargoCalculado.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(291, 11)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(51, 13)
        Me.Label28.TabIndex = 17
        Me.Label28.Text = "Recargo:"
        '
        'txtTARCalculada
        '
        Me.txtTARCalculada.Location = New System.Drawing.Point(485, 8)
        Me.txtTARCalculada.Name = "txtTARCalculada"
        Me.txtTARCalculada.ReadOnly = True
        Me.txtTARCalculada.Size = New System.Drawing.Size(72, 20)
        Me.txtTARCalculada.TabIndex = 20
        Me.txtTARCalculada.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(447, 11)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 13)
        Me.Label26.TabIndex = 21
        Me.Label26.Text = "TAR:"
        '
        'txtINFRACalculada
        '
        Me.txtINFRACalculada.Location = New System.Drawing.Point(636, 8)
        Me.txtINFRACalculada.Name = "txtINFRACalculada"
        Me.txtINFRACalculada.ReadOnly = True
        Me.txtINFRACalculada.Size = New System.Drawing.Size(71, 20)
        Me.txtINFRACalculada.TabIndex = 22
        Me.txtINFRACalculada.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(588, 11)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 13)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "INFRA:"
        '
        'labelPagoPor
        '
        Me.labelPagoPor.AutoSize = True
        Me.labelPagoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPagoPor.Location = New System.Drawing.Point(18, 8)
        Me.labelPagoPor.Name = "labelPagoPor"
        Me.labelPagoPor.Size = New System.Drawing.Size(111, 16)
        Me.labelPagoPor.TabIndex = 15
        Me.labelPagoPor.Text = "Tarifa pagada:"
        '
        'panelPagoAgua
        '
        Me.panelPagoAgua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelPagoAgua.Controls.Add(Me.Panel5)
        Me.panelPagoAgua.Controls.Add(Me.Panel2)
        Me.panelPagoAgua.Controls.Add(Me.Panel4)
        Me.panelPagoAgua.Controls.Add(Me.Panel3)
        Me.panelPagoAgua.Location = New System.Drawing.Point(12, 336)
        Me.panelPagoAgua.Name = "panelPagoAgua"
        Me.panelPagoAgua.Size = New System.Drawing.Size(741, 169)
        Me.panelPagoAgua.TabIndex = 40
        Me.panelPagoAgua.TabStop = True
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.txtPagoTipo)
        Me.Panel7.Controls.Add(Me.txtPagoFecha)
        Me.Panel7.Controls.Add(Me.txtPagoNombreCuenta)
        Me.Panel7.Controls.Add(Me.txtIdPago)
        Me.Panel7.Controls.Add(Me.Label27)
        Me.Panel7.Controls.Add(Me.Label23)
        Me.Panel7.Controls.Add(Me.Label22)
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Location = New System.Drawing.Point(13, 511)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(741, 86)
        Me.Panel7.TabIndex = 60
        '
        'txtPagoTipo
        '
        Me.txtPagoTipo.Location = New System.Drawing.Point(514, 57)
        Me.txtPagoTipo.Name = "txtPagoTipo"
        Me.txtPagoTipo.ReadOnly = True
        Me.txtPagoTipo.Size = New System.Drawing.Size(159, 20)
        Me.txtPagoTipo.TabIndex = 66
        '
        'txtPagoFecha
        '
        Me.txtPagoFecha.Location = New System.Drawing.Point(514, 17)
        Me.txtPagoFecha.Name = "txtPagoFecha"
        Me.txtPagoFecha.ReadOnly = True
        Me.txtPagoFecha.Size = New System.Drawing.Size(159, 20)
        Me.txtPagoFecha.TabIndex = 65
        '
        'txtPagoNombreCuenta
        '
        Me.txtPagoNombreCuenta.Location = New System.Drawing.Point(241, 56)
        Me.txtPagoNombreCuenta.Name = "txtPagoNombreCuenta"
        Me.txtPagoNombreCuenta.ReadOnly = True
        Me.txtPagoNombreCuenta.Size = New System.Drawing.Size(228, 20)
        Me.txtPagoNombreCuenta.TabIndex = 64
        '
        'txtIdPago
        '
        Me.txtIdPago.Location = New System.Drawing.Point(241, 17)
        Me.txtIdPago.Name = "txtIdPago"
        Me.txtIdPago.ReadOnly = True
        Me.txtIdPago.Size = New System.Drawing.Size(107, 20)
        Me.txtIdPago.TabIndex = 63
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(511, 44)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 13)
        Me.Label27.TabIndex = 62
        Me.Label27.Text = "Tipo:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(511, 4)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 13)
        Me.Label23.TabIndex = 61
        Me.Label23.Text = "Fecha del pago:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(238, 44)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(155, 13)
        Me.Label22.TabIndex = 60
        Me.Label22.Text = "Nombre de la cuenta asociada:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(238, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "idPago:"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(66, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 49)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Datos generales del pago"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMovimientoPagosConsultaIndividual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 693)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.panelIdPagos)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.panelBotones)
        Me.Controls.Add(Me.panelRejillaCuenta)
        Me.Controls.Add(Me.panelPagoAgua)
        Me.Controls.Add(Me.panelServiciosAtendidos)
        Me.Name = "frmMovimientoPagosConsultaIndividual"
        Me.Text = "Pagos - Consulta Individual"
        Me.panelServiciosAtendidos.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.panelBotones.ResumeLayout(False)
        CType(Me.dgDatosCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelRejillaCuenta.ResumeLayout(False)
        Me.panelRejillaCuenta.PerformLayout()
        Me.panelIdPagos.ResumeLayout(False)
        CType(Me.dgDatosPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEmpleado.ResumeLayout(False)
        Me.panelEmpleado.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.panelPagoAgua.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelServiciosAtendidos As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents txtDescuentoFinal As TextBox
    Friend WithEvents lblDescuento As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtOtros As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents panelBotones As Panel
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dgDatosCuentas As DataGridView
    Friend WithEvents idCuenta As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents idCalle As DataGridViewTextBoxColumn
    Friend WithEvents Calle As DataGridViewTextBoxColumn
    Friend WithEvents fechaAlta As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPagoAnio As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPagoMes As DataGridViewTextBoxColumn
    Friend WithEvents txtBuscarCuenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents panelRejillaCuenta As Panel
    Friend WithEvents panelIdPagos As Panel
    Friend WithEvents dgDatosPagos As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents panelEmpleado As Panel
    Friend WithEvents txtEmpleadoTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmpleadoColonia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmpleadoDomicilio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmpleadoNombre As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents txtIdEmpleado As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtServicioPrecio As TextBox
    Friend WithEvents txtIdServicio As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents txtServicioDescripcion As TextBox
    Friend WithEvents idPago As DataGridViewTextBoxColumn
    Friend WithEvents NombreCuenta As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Otros As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label32 As Label
    Friend WithEvents txtNombreSituacion As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSituacionDescuento As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtIdSituacion As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents txtIdTarifa As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtINFRA As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtTAR As TextBox
    Friend WithEvents txtAnioTarifa As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtRecargo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCuotaFija As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtMesFinal As TextBox
    Friend WithEvents txtMesInicial As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents labelPagoPor As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtINFRACalculada As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtTARCalculada As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtRecargoCalculado As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtCuotaFijaCalculada As TextBox
    Friend WithEvents panelPagoAgua As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtPagoTipo As TextBox
    Friend WithEvents txtPagoFecha As TextBox
    Friend WithEvents txtPagoNombreCuenta As TextBox
    Friend WithEvents txtIdPago As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
