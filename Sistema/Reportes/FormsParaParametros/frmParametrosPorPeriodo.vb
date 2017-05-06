Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmParametrosPorPeriodo
    Private Sub frmParametrosPorPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combitoOpcion.SelectedIndex = 0
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim f1 As String
        Dim f2 As String
        f1 = DTP1.Value.Day & "/" & DTP1.Value.Month & "/" & DTP1.Value.Year
        f2 = DTP2.Value.Day & "/" & DTP2.Value.Month & "/" & DTP2.Value.Year

        Dim CONEXION As New SqlConnection(stringConnection())

        If combitoOpcion.Text.Equals("ENTRADA DE MATERIAL EN UN PERIODO") Then
            Dim cmd As New SqlCommand("REPORTEENTRADAMATERIALPORPERIODO", CONEXION)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter()
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = CONEXION
            adaptador.SelectCommand.CommandText = "REPORTEENTRADAMATERIALPORPERIODO"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@FECHA1", SqlDbType.Date)
            Dim param2 = New SqlParameter("@FECHA2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", f1)
            Dim p2 As New ReportParameter("P2", f2)
            frmReporte.reportViewer.LocalReport.DataSources.Clear()
            frmReporte.reportViewer.LocalReport.DataSources.Add(datasource)
            frmReporte.reportViewer.LocalReport.ReportPath =
            "C:\SistemaAguaPotable\System\WaterSystem\Sistema\Reportes\ReporteEntradaMaterialPorPeriodo.rdlc"
            frmReporte.reportViewer.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReporte.reportViewer.RefreshReport()
            frmReporte.ShowDialog()
            CONEXION.Close()
        End If

        If combitoOpcion.Text.Equals("SALIDA DE MATERIAL EN UN PERIODO") Then
            Dim cmd As New SqlCommand("REPORTESALIDAMATERIALPORPERIODO", CONEXION)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter()
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = CONEXION
            adaptador.SelectCommand.CommandText = "REPORTESALIDAMATERIALPORPERIODO"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@FECHA1", SqlDbType.Date)
            Dim param2 = New SqlParameter("@FECHA2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", f1)
            Dim p2 As New ReportParameter("P2", f2)
            frmReporte.reportViewer.LocalReport.DataSources.Clear()
            frmReporte.reportViewer.LocalReport.DataSources.Add(datasource)
            frmReporte.reportViewer.LocalReport.ReportPath =
            "C:\SistemaAguaPotable\System\WaterSystem\Sistema\Reportes\ReporteSalidaMaterialPorPeriodo.rdlc"
            frmReporte.reportViewer.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReporte.reportViewer.RefreshReport()
            frmReporte.ShowDialog()
            CONEXION.Close()
        End If

        If combitoOpcion.Text.Equals("GASTOS EN UN PERIODO") Then
            Dim cmd As New SqlCommand("REPORTEGASTOSPORPERIODO", CONEXION)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter()
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = CONEXION
            adaptador.SelectCommand.CommandText = "REPORTEGASTOSPORPERIODO"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@FECHA1", SqlDbType.Date)
            Dim param2 = New SqlParameter("@FECHA2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", f1)
            Dim p2 As New ReportParameter("P2", f2)
            frmReporte.reportViewer.LocalReport.DataSources.Clear()
            frmReporte.reportViewer.LocalReport.DataSources.Add(datasource)
            frmReporte.reportViewer.LocalReport.ReportPath =
            "C:\SistemaAguaPotable\System\WaterSystem\Sistema\Reportes\ReporteGastosPorPeriodo.rdlc"
            frmReporte.reportViewer.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReporte.reportViewer.RefreshReport()
            frmReporte.ShowDialog()
            CONEXION.Close()
        End If

        If combitoOpcion.Text.Equals("PAGOS EN UN PERIODO") Then
            Dim cmd As New SqlCommand("REPORTEPAGOSPORPERIODO", CONEXION)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter()
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = CONEXION
            adaptador.SelectCommand.CommandText = "REPORTEPAGOSPORPERIODO"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@FECHA1", SqlDbType.Date)
            Dim param2 = New SqlParameter("@FECHA2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", f1)
            Dim p2 As New ReportParameter("P2", f2)
            frmReporte.reportViewer.LocalReport.DataSources.Clear()
            frmReporte.reportViewer.LocalReport.DataSources.Add(datasource)
            frmReporte.reportViewer.LocalReport.ReportPath =
            "C:\SistemaAguaPotable\System\WaterSystem\Sistema\Reportes\ReportePagosPorPeriodo.rdlc"
            frmReporte.reportViewer.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReporte.reportViewer.RefreshReport()
            frmReporte.ShowDialog()
            CONEXION.Close()
        End If

        If combitoOpcion.Text.Equals("ACTIVIDAD DE POZOS EN UN PERIODO") Then
            Dim cmd As New SqlCommand("REPORTEACTIVIDADPOZOSPORPERIODO", CONEXION)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter()
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = CONEXION
            adaptador.SelectCommand.CommandText = "REPORTEACTIVIDADPOZOSPORPERIODO"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@FECHA1", SqlDbType.Date)
            Dim param2 = New SqlParameter("@FECHA2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", f1)
            Dim p2 As New ReportParameter("P2", f2)
            frmReporte.reportViewer.LocalReport.DataSources.Clear()
            frmReporte.reportViewer.LocalReport.DataSources.Add(datasource)
            frmReporte.reportViewer.LocalReport.ReportPath =
            "C:\SistemaAguaPotable\System\WaterSystem\Sistema\Reportes\ReporteActividadPozosPorPeriodo.rdlc"
            frmReporte.reportViewer.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReporte.reportViewer.RefreshReport()
            frmReporte.ShowDialog()
            CONEXION.Close()
        End If

    End Sub


End Class