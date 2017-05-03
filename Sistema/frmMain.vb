Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms


Public Class frmMain
    Private Sub tsmiCatalogosCalles_Click(sender As Object, e As EventArgs) Handles tsmiCatalogosCalles.Click
        frmCatalogoCalles.ShowDialog()
    End Sub

    Private Sub tsmiCatalogosMateriales_Click(sender As Object, e As EventArgs) Handles tsmiCatalogosMateriales.Click
        frmCatalogoMateriales.ShowDialog()
    End Sub

    Private Sub tsmiCatalogosGastos_Click(sender As Object, e As EventArgs) Handles tsmiCatalogosGastos.Click
        frmCatalogoGastos.ShowDialog()
    End Sub

    Private Sub tsmiCatalogosPozos_Click(sender As Object, e As EventArgs) Handles tsmiCatalogosPozos.Click
        frmCatalogoPozos.ShowDialog()
    End Sub

    Private Sub tsmiCatalogosServicios_Click(sender As Object, e As EventArgs) Handles tsmiCatalogosServicios.Click
        frmCatalogoServicios.ShowDialog()
    End Sub

    Private Sub tsmiArchivoSalir_Click(sender As Object, e As EventArgs) Handles tsmiArchivoSalir.Click
        End
    End Sub

    Private Sub tsmiCatalogosEmpleados_Click(sender As Object, e As EventArgs) Handles tsmiCatalogosEmpleados.Click
        frmCatalogoEmpleados.ShowDialog()
    End Sub

    Private Sub tsmiCatalogosCuentas_Click(sender As Object, e As EventArgs) Handles tsmiCatalogosCuentas.Click
        frmCatalogoCuentas.ShowDialog()

    End Sub

    Private Sub tsmiCatalogosProveedores_Click(sender As Object, e As EventArgs) Handles tsmiCatalogosProveedores.Click
        frmCatalogoProveedores.ShowDialog()
    End Sub

    Private Sub tsmiCatalogosSituaciones_Click(sender As Object, e As EventArgs) Handles tsmiCatalogosSituaciones.Click
        frmCatalogoSituacion.ShowDialog()
    End Sub

    Private Sub tsmiCatalogosTarifas_Click(sender As Object, e As EventArgs) Handles tsmiCatalogosTarifas.Click
        frmCatalogoTarifas.ShowDialog()
    End Sub

    Private Sub tsmiMovimientosActividadPozos_Click(sender As Object, e As EventArgs) Handles tsmiMovimientosActividadPozos.Click
        frmMovimientoActividadPozos.ShowDialog()
    End Sub

    Private Sub tsmiServiciosAtendidos_Click(sender As Object, e As EventArgs) Handles tsmiGastosRealizados.Click
        frmMovimientoGastosRealizados.ShowDialog()
    End Sub

    Private Sub tsmiSalidasMateriales_Click(sender As Object, e As EventArgs) Handles tsmiSalidasMateriales.Click

    End Sub

    Private Sub tsmiComprasMaterialesAltas_Click(sender As Object, e As EventArgs) Handles tsmiComprasMaterialesAltas.Click
        frmMovimientoComprasMaterialesAltas.ShowDialog()
    End Sub

    Private Sub tsmiComprasMaterialesConInd_Click(sender As Object, e As EventArgs) Handles tsmiComprasMaterialesConInd.Click
        frmMovimientoComprasMaterialesConsultaIndividual.ShowDialog()
    End Sub

    Private Sub tsmiComprasMaterialesConGen_Click(sender As Object, e As EventArgs) Handles tsmiComprasMaterialesConGen.Click
        frmMovimientoComprasMaterialesConsultaGeneral.ShowDialog()
    End Sub

    Private Sub tsmiSalidasMaterialesAltas_Click(sender As Object, e As EventArgs) Handles tsmiSalidasMaterialesAltas.Click
        frmMovimientoSalidasMaterialesAltas.ShowDialog()
    End Sub

    Private Sub tsmiSalidasMaterialesConInd_Click(sender As Object, e As EventArgs) Handles tsmiSalidasMaterialesConInd.Click
        frmMovimientoSalidasMaterialesConsultaIndividual.ShowDialog()
    End Sub

    Private Sub tsmiSalidasMaterialesConGen_Click(sender As Object, e As EventArgs) Handles tsmiSalidasMaterialesConGen.Click
        frmMovimientoSalidasMaterialesConsultaGeneral.ShowDialog()
    End Sub

    Private Sub tsmiPagosAltas_Click(sender As Object, e As EventArgs) Handles tsmiPagosAltas.Click
        txtBuscarEmpleado.ShowDialog()
    End Sub

    Private Sub tsmiPagosConsultaIndividual_Click(sender As Object, e As EventArgs) Handles tsmiPagosConsultaIndividual.Click
        frmMovimientoPagosConsultaIndividual.ShowDialog()
    End Sub

    Private Sub tsmiReportesCuentas_Click(sender As Object, e As EventArgs) Handles tsmiReportesCuentas.Click
        Dim CONEXION As New SqlConnection(stringConnection())
        Dim cmd As New SqlCommand("REPORTECUENTAS", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "ReporteCuentas"
        Dim reportes As New ReportDataSource("ReporteCuentas", data.Tables(0))
        frmReporte.reportViewer.LocalReport.DataSources.Clear()
        frmReporte.reportViewer.LocalReport.DataSources.Add(reportes)
        frmReporte.reportViewer.LocalReport.ReportPath =
        "C:\SistemaAguaPotable\System\WaterSystem\Sistema\Reportes\ReporteCuentas.rdlc"
        frmReporte.reportViewer.RefreshReport()
        frmReporte.Show()
        CONEXION.Close()
    End Sub

    Private Sub tsmiReportesCalles_Click(sender As Object, e As EventArgs) Handles tsmiReportesCalles.Click
        Dim CONEXION As New SqlConnection(stringConnection())
        Dim cmd As New SqlCommand("REPORTECALLES", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "ReporteCalles"
        Dim reportes As New ReportDataSource("ReporteCalles", data.Tables(0))
        frmReporte.reportViewer.LocalReport.DataSources.Clear()
        frmReporte.reportViewer.LocalReport.DataSources.Add(reportes)
        frmReporte.reportViewer.LocalReport.ReportPath =
        "C:\SistemaAguaPotable\System\WaterSystem\Sistema\Reportes\ReporteCalles.rdlc"
        frmReporte.reportViewer.RefreshReport()
        frmReporte.Show()
        CONEXION.Close()
    End Sub

    Private Sub tsmiReportesEmpleados_Click(sender As Object, e As EventArgs) Handles tsmiReportesEmpleados.Click
        Dim CONEXION As New SqlConnection(stringConnection())
        Dim cmd As New SqlCommand("REPORTEEMPLEADOS", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "ReporteEmpleados"
        Dim reportes As New ReportDataSource("ReporteEmpleados", data.Tables(0))
        frmReporte.reportViewer.LocalReport.DataSources.Clear()
        frmReporte.reportViewer.LocalReport.DataSources.Add(reportes)
        frmReporte.reportViewer.LocalReport.ReportPath =
        "C:\SistemaAguaPotable\System\WaterSystem\Sistema\Reportes\ReporteEmpleados.rdlc"
        frmReporte.reportViewer.RefreshReport()
        frmReporte.Show()
        CONEXION.Close()
    End Sub

    Private Sub tsmiReportesGastos_Click(sender As Object, e As EventArgs) Handles tsmiReportesGastos.Click
        Dim CONEXION As New SqlConnection(stringConnection())
        Dim cmd As New SqlCommand("REPORTEGASTOS", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "ReporteGastos"
        Dim reportes As New ReportDataSource("ReporteGastos", data.Tables(0))
        frmReporte.reportViewer.LocalReport.DataSources.Clear()
        frmReporte.reportViewer.LocalReport.DataSources.Add(reportes)
        frmReporte.reportViewer.LocalReport.ReportPath =
        "C:\SistemaAguaPotable\System\WaterSystem\Sistema\Reportes\ReporteGastos.rdlc"
        frmReporte.reportViewer.RefreshReport()
        frmReporte.Show()
        CONEXION.Close()
    End Sub

    Private Sub tsmiReportesTarifas_Click(sender As Object, e As EventArgs) Handles tsmiReportesTarifas.Click
        Dim CONEXION As New SqlConnection(stringConnection())
        Dim cmd As New SqlCommand("REPORTETARIFAS", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "ReporteTarifas"
        Dim reportes As New ReportDataSource("ReporteTarifas", data.Tables(0))
        frmReporte.reportViewer.LocalReport.DataSources.Clear()
        frmReporte.reportViewer.LocalReport.DataSources.Add(reportes)
        frmReporte.reportViewer.LocalReport.ReportPath =
        "C:\SistemaAguaPotable\System\WaterSystem\Sistema\Reportes\ReporteTarifas.rdlc"
        frmReporte.reportViewer.RefreshReport()
        frmReporte.Show()
        CONEXION.Close()
    End Sub

    Private Sub tsmiReportesPozos_Click(sender As Object, e As EventArgs) Handles tsmiReportesPozos.Click
        Dim CONEXION As New SqlConnection(stringConnection())
        Dim cmd As New SqlCommand("REPORTEPOZOS", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "ReportePozos"
        Dim reportes As New ReportDataSource("ReportePozos", data.Tables(0))
        frmReporte.reportViewer.LocalReport.DataSources.Clear()
        frmReporte.reportViewer.LocalReport.DataSources.Add(reportes)
        frmReporte.reportViewer.LocalReport.ReportPath =
        "C:\SistemaAguaPotable\System\WaterSystem\Sistema\Reportes\ReportePozos.rdlc"
        frmReporte.reportViewer.RefreshReport()
        frmReporte.Show()
        CONEXION.Close()
    End Sub
End Class