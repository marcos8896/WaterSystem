<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientoSalidasMaterialesConsultaIndividual
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
        Me.combitoIdSalida = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panelProveedor = New System.Windows.Forms.Panel()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.txtEmpleadoCelular = New System.Windows.Forms.TextBox()
        Me.txtEmpleadoDomicilio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtTotalCasas = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtIdCalle = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panelBotones.SuspendLayout()
        Me.panelDataGrid.SuspendLayout()
        CType(Me.dgComprasMaterialesConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOrden.SuspendLayout()
        Me.panelProveedor.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBotones
        '
        Me.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBotones.Controls.Add(Me.btnSalir)
        Me.panelBotones.Location = New System.Drawing.Point(12, 413)
        Me.panelBotones.Name = "panelBotones"
        Me.panelBotones.Size = New System.Drawing.Size(597, 42)
        Me.panelBotones.TabIndex = 40
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
        Me.panelDataGrid.Location = New System.Drawing.Point(12, 204)
        Me.panelDataGrid.Name = "panelDataGrid"
        Me.panelDataGrid.Size = New System.Drawing.Size(598, 203)
        Me.panelDataGrid.TabIndex = 41
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
        Me.panelOrden.Controls.Add(Me.combitoIdSalida)
        Me.panelOrden.Controls.Add(Me.dtpFecha)
        Me.panelOrden.Controls.Add(Me.txtConcepto)
        Me.panelOrden.Controls.Add(Me.Label5)
        Me.panelOrden.Controls.Add(Me.Label6)
        Me.panelOrden.Controls.Add(Me.Label7)
        Me.panelOrden.Location = New System.Drawing.Point(312, 12)
        Me.panelOrden.Name = "panelOrden"
        Me.panelOrden.Size = New System.Drawing.Size(298, 138)
        Me.panelOrden.TabIndex = 39
        Me.panelOrden.TabStop = True
        '
        'combitoIdSalida
        '
        Me.combitoIdSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combitoIdSalida.FormattingEnabled = True
        Me.combitoIdSalida.Location = New System.Drawing.Point(59, 11)
        Me.combitoIdSalida.Name = "combitoIdSalida"
        Me.combitoIdSalida.Size = New System.Drawing.Size(190, 21)
        Me.combitoIdSalida.TabIndex = 6
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(52, 105)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(228, 20)
        Me.dtpFecha.TabIndex = 3
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(58, 36)
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.ReadOnly = True
        Me.txtConcepto.Size = New System.Drawing.Size(222, 51)
        Me.txtConcepto.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fecha:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Concepto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "idSalida:"
        '
        'panelProveedor
        '
        Me.panelProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelProveedor.Controls.Add(Me.txtNombreEmpleado)
        Me.panelProveedor.Controls.Add(Me.txtEmpleadoCelular)
        Me.panelProveedor.Controls.Add(Me.txtEmpleadoDomicilio)
        Me.panelProveedor.Controls.Add(Me.Label4)
        Me.panelProveedor.Controls.Add(Me.Label3)
        Me.panelProveedor.Controls.Add(Me.Label2)
        Me.panelProveedor.Controls.Add(Me.txtIdEmpleado)
        Me.panelProveedor.Controls.Add(Me.Label1)
        Me.panelProveedor.Location = New System.Drawing.Point(12, 12)
        Me.panelProveedor.Name = "panelProveedor"
        Me.panelProveedor.Size = New System.Drawing.Size(281, 138)
        Me.panelProveedor.TabIndex = 38
        Me.panelProveedor.TabStop = True
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(79, 22)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.ReadOnly = True
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(136, 20)
        Me.txtNombreEmpleado.TabIndex = 9
        Me.txtNombreEmpleado.TabStop = False
        '
        'txtEmpleadoCelular
        '
        Me.txtEmpleadoCelular.Location = New System.Drawing.Point(79, 94)
        Me.txtEmpleadoCelular.Name = "txtEmpleadoCelular"
        Me.txtEmpleadoCelular.ReadOnly = True
        Me.txtEmpleadoCelular.Size = New System.Drawing.Size(128, 20)
        Me.txtEmpleadoCelular.TabIndex = 8
        Me.txtEmpleadoCelular.TabStop = False
        '
        'txtEmpleadoDomicilio
        '
        Me.txtEmpleadoDomicilio.Location = New System.Drawing.Point(79, 69)
        Me.txtEmpleadoDomicilio.Name = "txtEmpleadoDomicilio"
        Me.txtEmpleadoDomicilio.ReadOnly = True
        Me.txtEmpleadoDomicilio.Size = New System.Drawing.Size(190, 20)
        Me.txtEmpleadoDomicilio.TabIndex = 6
        Me.txtEmpleadoDomicilio.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Celular:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Domicilio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "idEmpleado:"
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Location = New System.Drawing.Point(79, 45)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.ReadOnly = True
        Me.txtIdEmpleado.Size = New System.Drawing.Size(74, 20)
        Me.txtIdEmpleado.TabIndex = 2
        Me.txtIdEmpleado.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleado:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtCalle)
        Me.Panel1.Controls.Add(Me.txtTotalCasas)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.txtIdCalle)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(12, 156)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(598, 42)
        Me.Panel1.TabIndex = 37
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(65, 7)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.ReadOnly = True
        Me.txtCalle.Size = New System.Drawing.Size(136, 20)
        Me.txtCalle.TabIndex = 12
        Me.txtCalle.TabStop = False
        '
        'txtTotalCasas
        '
        Me.txtTotalCasas.Location = New System.Drawing.Point(444, 7)
        Me.txtTotalCasas.Name = "txtTotalCasas"
        Me.txtTotalCasas.ReadOnly = True
        Me.txtTotalCasas.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCasas.TabIndex = 11
        Me.txtTotalCasas.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(385, 10)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 13)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "totalCasas:"
        '
        'txtIdCalle
        '
        Me.txtIdCalle.Location = New System.Drawing.Point(274, 7)
        Me.txtIdCalle.Name = "txtIdCalle"
        Me.txtIdCalle.ReadOnly = True
        Me.txtIdCalle.Size = New System.Drawing.Size(79, 20)
        Me.txtIdCalle.TabIndex = 9
        Me.txtIdCalle.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(228, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "idCalle:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Calle:"
        '
        'frmMovimientoSalidasMaterialesConsultaIndividual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 464)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelBotones)
        Me.Controls.Add(Me.panelDataGrid)
        Me.Controls.Add(Me.panelOrden)
        Me.Controls.Add(Me.panelProveedor)
        Me.Name = "frmMovimientoSalidasMaterialesConsultaIndividual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Salidas Materiales - Consulta Individual"
        Me.panelBotones.ResumeLayout(False)
        Me.panelDataGrid.ResumeLayout(False)
        Me.panelDataGrid.PerformLayout()
        CType(Me.dgComprasMaterialesConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOrden.ResumeLayout(False)
        Me.panelOrden.PerformLayout()
        Me.panelProveedor.ResumeLayout(False)
        Me.panelProveedor.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents combitoIdSalida As ComboBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtConcepto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents panelProveedor As Panel
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents txtEmpleadoCelular As TextBox
    Friend WithEvents txtEmpleadoDomicilio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdEmpleado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtTotalCasas As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtIdCalle As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCalle As TextBox
End Class
