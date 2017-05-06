<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.menuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.tsmiArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiArchivoSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogosCalles = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogosCuentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogosMateriales = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogosEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogosGastos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogosTarifas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogosPozos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogosServicios = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogosProveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogosSituaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMovimientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMovimientosActividadPozos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiGastosRealizados = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiESMateriales = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiComprasMateriales = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiComprasMaterialesAltas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiComprasMaterialesConInd = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiComprasMaterialesConGen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSalidasMateriales = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSalidasMaterialesAltas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSalidasMaterialesConInd = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSalidasMaterialesConGen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPagos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPagosAltas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPagosConsultaIndividual = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReportesCuentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReportesCalles = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReportesEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReportesGastos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReportesTarifas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReportesPozos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReportesMaterialPorExistencia = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReportesCuentasPorCalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReportesServicios = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReportesProveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReportesCuentasDeudoras = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReportesHistorialDePagosPorCuenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuPrincipal
        '
        Me.menuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiArchivo, Me.tsmiCatalogos, Me.tsmiMovimientos, Me.tsmiReportes})
        Me.menuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.menuPrincipal.Name = "menuPrincipal"
        Me.menuPrincipal.Size = New System.Drawing.Size(441, 24)
        Me.menuPrincipal.TabIndex = 0
        Me.menuPrincipal.Text = "MenuStrip1"
        '
        'tsmiArchivo
        '
        Me.tsmiArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiArchivoSalir})
        Me.tsmiArchivo.Name = "tsmiArchivo"
        Me.tsmiArchivo.Size = New System.Drawing.Size(60, 20)
        Me.tsmiArchivo.Text = "Archivo"
        '
        'tsmiArchivoSalir
        '
        Me.tsmiArchivoSalir.Name = "tsmiArchivoSalir"
        Me.tsmiArchivoSalir.Size = New System.Drawing.Size(96, 22)
        Me.tsmiArchivoSalir.Text = "Salir"
        '
        'tsmiCatalogos
        '
        Me.tsmiCatalogos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCatalogosCalles, Me.tsmiCatalogosCuentas, Me.tsmiCatalogosMateriales, Me.tsmiCatalogosEmpleados, Me.tsmiCatalogosGastos, Me.tsmiCatalogosTarifas, Me.tsmiCatalogosPozos, Me.tsmiCatalogosServicios, Me.tsmiCatalogosProveedores, Me.tsmiCatalogosSituaciones})
        Me.tsmiCatalogos.Name = "tsmiCatalogos"
        Me.tsmiCatalogos.Size = New System.Drawing.Size(72, 20)
        Me.tsmiCatalogos.Text = "Catálogos"
        '
        'tsmiCatalogosCalles
        '
        Me.tsmiCatalogosCalles.Name = "tsmiCatalogosCalles"
        Me.tsmiCatalogosCalles.Size = New System.Drawing.Size(139, 22)
        Me.tsmiCatalogosCalles.Text = "Calles"
        '
        'tsmiCatalogosCuentas
        '
        Me.tsmiCatalogosCuentas.Name = "tsmiCatalogosCuentas"
        Me.tsmiCatalogosCuentas.Size = New System.Drawing.Size(139, 22)
        Me.tsmiCatalogosCuentas.Text = "Cuentas"
        '
        'tsmiCatalogosMateriales
        '
        Me.tsmiCatalogosMateriales.Name = "tsmiCatalogosMateriales"
        Me.tsmiCatalogosMateriales.Size = New System.Drawing.Size(139, 22)
        Me.tsmiCatalogosMateriales.Text = "Materiales"
        '
        'tsmiCatalogosEmpleados
        '
        Me.tsmiCatalogosEmpleados.Name = "tsmiCatalogosEmpleados"
        Me.tsmiCatalogosEmpleados.Size = New System.Drawing.Size(139, 22)
        Me.tsmiCatalogosEmpleados.Text = "Empleados"
        '
        'tsmiCatalogosGastos
        '
        Me.tsmiCatalogosGastos.Name = "tsmiCatalogosGastos"
        Me.tsmiCatalogosGastos.Size = New System.Drawing.Size(139, 22)
        Me.tsmiCatalogosGastos.Text = "Gastos"
        '
        'tsmiCatalogosTarifas
        '
        Me.tsmiCatalogosTarifas.Name = "tsmiCatalogosTarifas"
        Me.tsmiCatalogosTarifas.Size = New System.Drawing.Size(139, 22)
        Me.tsmiCatalogosTarifas.Text = "Tarifas"
        '
        'tsmiCatalogosPozos
        '
        Me.tsmiCatalogosPozos.Name = "tsmiCatalogosPozos"
        Me.tsmiCatalogosPozos.Size = New System.Drawing.Size(139, 22)
        Me.tsmiCatalogosPozos.Text = "Pozos"
        '
        'tsmiCatalogosServicios
        '
        Me.tsmiCatalogosServicios.Name = "tsmiCatalogosServicios"
        Me.tsmiCatalogosServicios.Size = New System.Drawing.Size(139, 22)
        Me.tsmiCatalogosServicios.Text = "Servicios"
        '
        'tsmiCatalogosProveedores
        '
        Me.tsmiCatalogosProveedores.Name = "tsmiCatalogosProveedores"
        Me.tsmiCatalogosProveedores.Size = New System.Drawing.Size(139, 22)
        Me.tsmiCatalogosProveedores.Text = "Proveedores"
        '
        'tsmiCatalogosSituaciones
        '
        Me.tsmiCatalogosSituaciones.Name = "tsmiCatalogosSituaciones"
        Me.tsmiCatalogosSituaciones.Size = New System.Drawing.Size(139, 22)
        Me.tsmiCatalogosSituaciones.Text = "Situaciones"
        '
        'tsmiMovimientos
        '
        Me.tsmiMovimientos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiMovimientosActividadPozos, Me.tsmiGastosRealizados, Me.tsmiESMateriales, Me.tsmiPagos})
        Me.tsmiMovimientos.Name = "tsmiMovimientos"
        Me.tsmiMovimientos.Size = New System.Drawing.Size(89, 20)
        Me.tsmiMovimientos.Text = "Movimientos"
        '
        'tsmiMovimientosActividadPozos
        '
        Me.tsmiMovimientosActividadPozos.Name = "tsmiMovimientosActividadPozos"
        Me.tsmiMovimientosActividadPozos.Size = New System.Drawing.Size(164, 22)
        Me.tsmiMovimientosActividadPozos.Text = "Actividad pozos"
        '
        'tsmiGastosRealizados
        '
        Me.tsmiGastosRealizados.Name = "tsmiGastosRealizados"
        Me.tsmiGastosRealizados.Size = New System.Drawing.Size(164, 22)
        Me.tsmiGastosRealizados.Text = "Gastos realizados"
        '
        'tsmiESMateriales
        '
        Me.tsmiESMateriales.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiComprasMateriales, Me.tsmiSalidasMateriales})
        Me.tsmiESMateriales.Name = "tsmiESMateriales"
        Me.tsmiESMateriales.Size = New System.Drawing.Size(164, 22)
        Me.tsmiESMateriales.Text = "E/S Materiales"
        '
        'tsmiComprasMateriales
        '
        Me.tsmiComprasMateriales.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiComprasMaterialesAltas, Me.tsmiComprasMaterialesConInd, Me.tsmiComprasMaterialesConGen})
        Me.tsmiComprasMateriales.Name = "tsmiComprasMateriales"
        Me.tsmiComprasMateriales.Size = New System.Drawing.Size(179, 22)
        Me.tsmiComprasMateriales.Text = "Compras Materiales"
        '
        'tsmiComprasMaterialesAltas
        '
        Me.tsmiComprasMaterialesAltas.Name = "tsmiComprasMaterialesAltas"
        Me.tsmiComprasMaterialesAltas.Size = New System.Drawing.Size(192, 22)
        Me.tsmiComprasMaterialesAltas.Text = "Altas"
        '
        'tsmiComprasMaterialesConInd
        '
        Me.tsmiComprasMaterialesConInd.Name = "tsmiComprasMaterialesConInd"
        Me.tsmiComprasMaterialesConInd.Size = New System.Drawing.Size(192, 22)
        Me.tsmiComprasMaterialesConInd.Text = "Consultas Individuales"
        '
        'tsmiComprasMaterialesConGen
        '
        Me.tsmiComprasMaterialesConGen.Name = "tsmiComprasMaterialesConGen"
        Me.tsmiComprasMaterialesConGen.Size = New System.Drawing.Size(192, 22)
        Me.tsmiComprasMaterialesConGen.Text = "Consulta General"
        '
        'tsmiSalidasMateriales
        '
        Me.tsmiSalidasMateriales.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSalidasMaterialesAltas, Me.tsmiSalidasMaterialesConInd, Me.tsmiSalidasMaterialesConGen})
        Me.tsmiSalidasMateriales.Name = "tsmiSalidasMateriales"
        Me.tsmiSalidasMateriales.Size = New System.Drawing.Size(179, 22)
        Me.tsmiSalidasMateriales.Text = "Salidas Materiales"
        '
        'tsmiSalidasMaterialesAltas
        '
        Me.tsmiSalidasMaterialesAltas.Name = "tsmiSalidasMaterialesAltas"
        Me.tsmiSalidasMaterialesAltas.Size = New System.Drawing.Size(192, 22)
        Me.tsmiSalidasMaterialesAltas.Text = "Altas"
        '
        'tsmiSalidasMaterialesConInd
        '
        Me.tsmiSalidasMaterialesConInd.Name = "tsmiSalidasMaterialesConInd"
        Me.tsmiSalidasMaterialesConInd.Size = New System.Drawing.Size(192, 22)
        Me.tsmiSalidasMaterialesConInd.Text = "Consultas Individuales"
        '
        'tsmiSalidasMaterialesConGen
        '
        Me.tsmiSalidasMaterialesConGen.Name = "tsmiSalidasMaterialesConGen"
        Me.tsmiSalidasMaterialesConGen.Size = New System.Drawing.Size(192, 22)
        Me.tsmiSalidasMaterialesConGen.Text = "Consulta General"
        '
        'tsmiPagos
        '
        Me.tsmiPagos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiPagosAltas, Me.tsmiPagosConsultaIndividual})
        Me.tsmiPagos.Name = "tsmiPagos"
        Me.tsmiPagos.Size = New System.Drawing.Size(164, 22)
        Me.tsmiPagos.Text = "Pagos"
        '
        'tsmiPagosAltas
        '
        Me.tsmiPagosAltas.Name = "tsmiPagosAltas"
        Me.tsmiPagosAltas.Size = New System.Drawing.Size(176, 22)
        Me.tsmiPagosAltas.Text = "Altas"
        '
        'tsmiPagosConsultaIndividual
        '
        Me.tsmiPagosConsultaIndividual.Name = "tsmiPagosConsultaIndividual"
        Me.tsmiPagosConsultaIndividual.Size = New System.Drawing.Size(176, 22)
        Me.tsmiPagosConsultaIndividual.Text = "Consulta Individual"
        '
        'tsmiReportes
        '
        Me.tsmiReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiReportesCalles, Me.tsmiReportesCuentas, Me.tsmiReportesCuentasPorCalle, Me.tsmiReportesCuentasDeudoras, Me.tsmiReportesHistorialDePagosPorCuenta, Me.tsmiReportesMaterialPorExistencia, Me.tsmiReportesEmpleados, Me.tsmiReportesGastos, Me.tsmiReportesTarifas, Me.tsmiReportesPozos, Me.tsmiReportesServicios, Me.tsmiReportesProveedores})
        Me.tsmiReportes.Name = "tsmiReportes"
        Me.tsmiReportes.Size = New System.Drawing.Size(65, 20)
        Me.tsmiReportes.Text = "Reportes"
        '
        'tsmiReportesCuentas
        '
        Me.tsmiReportesCuentas.Name = "tsmiReportesCuentas"
        Me.tsmiReportesCuentas.Size = New System.Drawing.Size(232, 22)
        Me.tsmiReportesCuentas.Text = "Cuentas"
        '
        'tsmiReportesCalles
        '
        Me.tsmiReportesCalles.Name = "tsmiReportesCalles"
        Me.tsmiReportesCalles.Size = New System.Drawing.Size(232, 22)
        Me.tsmiReportesCalles.Text = "Calles"
        '
        'tsmiReportesEmpleados
        '
        Me.tsmiReportesEmpleados.Name = "tsmiReportesEmpleados"
        Me.tsmiReportesEmpleados.Size = New System.Drawing.Size(232, 22)
        Me.tsmiReportesEmpleados.Text = "Empleados"
        '
        'tsmiReportesGastos
        '
        Me.tsmiReportesGastos.Name = "tsmiReportesGastos"
        Me.tsmiReportesGastos.Size = New System.Drawing.Size(232, 22)
        Me.tsmiReportesGastos.Text = "Gastos"
        '
        'tsmiReportesTarifas
        '
        Me.tsmiReportesTarifas.Name = "tsmiReportesTarifas"
        Me.tsmiReportesTarifas.Size = New System.Drawing.Size(232, 22)
        Me.tsmiReportesTarifas.Text = "Tarifas"
        '
        'tsmiReportesPozos
        '
        Me.tsmiReportesPozos.Name = "tsmiReportesPozos"
        Me.tsmiReportesPozos.Size = New System.Drawing.Size(232, 22)
        Me.tsmiReportesPozos.Text = "Pozos"
        '
        'tsmiReportesMaterialPorExistencia
        '
        Me.tsmiReportesMaterialPorExistencia.Name = "tsmiReportesMaterialPorExistencia"
        Me.tsmiReportesMaterialPorExistencia.Size = New System.Drawing.Size(232, 22)
        Me.tsmiReportesMaterialPorExistencia.Text = "Material con existencia"
        '
        'tsmiReportesCuentasPorCalle
        '
        Me.tsmiReportesCuentasPorCalle.Name = "tsmiReportesCuentasPorCalle"
        Me.tsmiReportesCuentasPorCalle.Size = New System.Drawing.Size(232, 22)
        Me.tsmiReportesCuentasPorCalle.Text = "Cuentas por calle"
        '
        'tsmiReportesServicios
        '
        Me.tsmiReportesServicios.Name = "tsmiReportesServicios"
        Me.tsmiReportesServicios.Size = New System.Drawing.Size(232, 22)
        Me.tsmiReportesServicios.Text = "Servicios"
        '
        'tsmiReportesProveedores
        '
        Me.tsmiReportesProveedores.Name = "tsmiReportesProveedores"
        Me.tsmiReportesProveedores.Size = New System.Drawing.Size(232, 22)
        Me.tsmiReportesProveedores.Text = "Proveedores"
        '
        'tsmiReportesCuentasDeudoras
        '
        Me.tsmiReportesCuentasDeudoras.Name = "tsmiReportesCuentasDeudoras"
        Me.tsmiReportesCuentasDeudoras.Size = New System.Drawing.Size(232, 22)
        Me.tsmiReportesCuentasDeudoras.Text = "Cuentas deudoras"
        '
        'tsmiReportesHistorialDePagosPorCuenta
        '
        Me.tsmiReportesHistorialDePagosPorCuenta.Name = "tsmiReportesHistorialDePagosPorCuenta"
        Me.tsmiReportesHistorialDePagosPorCuenta.Size = New System.Drawing.Size(229, 22)
        Me.tsmiReportesHistorialDePagosPorCuenta.Text = "Historial de pagos por cuenta"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 328)
        Me.Controls.Add(Me.menuPrincipal)
        Me.MainMenuStrip = Me.menuPrincipal
        Me.Name = "frmMain"
        Me.Text = "Sistema de agua potable"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuPrincipal.ResumeLayout(False)
        Me.menuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuPrincipal As MenuStrip
    Friend WithEvents tsmiArchivo As ToolStripMenuItem
    Friend WithEvents tsmiArchivoSalir As ToolStripMenuItem
    Friend WithEvents tsmiCatalogos As ToolStripMenuItem
    Friend WithEvents tsmiCatalogosCalles As ToolStripMenuItem
    Friend WithEvents tsmiCatalogosCuentas As ToolStripMenuItem
    Friend WithEvents tsmiCatalogosMateriales As ToolStripMenuItem
    Friend WithEvents tsmiCatalogosEmpleados As ToolStripMenuItem
    Friend WithEvents tsmiCatalogosGastos As ToolStripMenuItem
    Friend WithEvents tsmiCatalogosTarifas As ToolStripMenuItem
    Friend WithEvents tsmiCatalogosPozos As ToolStripMenuItem
    Friend WithEvents tsmiCatalogosServicios As ToolStripMenuItem
    Friend WithEvents tsmiCatalogosProveedores As ToolStripMenuItem
    Friend WithEvents tsmiCatalogosSituaciones As ToolStripMenuItem
    Friend WithEvents tsmiMovimientos As ToolStripMenuItem
    Friend WithEvents tsmiMovimientosActividadPozos As ToolStripMenuItem
    Friend WithEvents tsmiGastosRealizados As ToolStripMenuItem
    Friend WithEvents tsmiESMateriales As ToolStripMenuItem
    Friend WithEvents tsmiComprasMateriales As ToolStripMenuItem
    Friend WithEvents tsmiSalidasMateriales As ToolStripMenuItem
    Friend WithEvents tsmiComprasMaterialesAltas As ToolStripMenuItem
    Friend WithEvents tsmiComprasMaterialesConInd As ToolStripMenuItem
    Friend WithEvents tsmiComprasMaterialesConGen As ToolStripMenuItem
    Friend WithEvents tsmiSalidasMaterialesAltas As ToolStripMenuItem
    Friend WithEvents tsmiSalidasMaterialesConInd As ToolStripMenuItem
    Friend WithEvents tsmiSalidasMaterialesConGen As ToolStripMenuItem
    Friend WithEvents tsmiPagos As ToolStripMenuItem
    Friend WithEvents tsmiPagosAltas As ToolStripMenuItem
    Friend WithEvents tsmiPagosConsultaIndividual As ToolStripMenuItem
    Friend WithEvents tsmiReportes As ToolStripMenuItem
    Friend WithEvents tsmiReportesCuentas As ToolStripMenuItem
    Friend WithEvents tsmiReportesCalles As ToolStripMenuItem
    Friend WithEvents tsmiReportesEmpleados As ToolStripMenuItem
    Friend WithEvents tsmiReportesGastos As ToolStripMenuItem
    Friend WithEvents tsmiReportesTarifas As ToolStripMenuItem
    Friend WithEvents tsmiReportesPozos As ToolStripMenuItem
    Friend WithEvents tsmiReportesMaterialPorExistencia As ToolStripMenuItem
    Friend WithEvents tsmiReportesCuentasPorCalle As ToolStripMenuItem
    Friend WithEvents tsmiReportesServicios As ToolStripMenuItem
    Friend WithEvents tsmiReportesProveedores As ToolStripMenuItem
    Friend WithEvents tsmiReportesCuentasDeudoras As ToolStripMenuItem
    Friend WithEvents tsmiReportesHistorialDePagosPorCuenta As ToolStripMenuItem
End Class
