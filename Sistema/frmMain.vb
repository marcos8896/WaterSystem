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
End Class