Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmParametrosHistorialPagoPorCuenta
    '--------------------DECLARACIÓN DE VARIABLES GLOBALES DE LA CLASE--------------------------!
    Dim conexionsql As New SqlConnection(stringConnection())
    Dim comando As SqlCommand = conexionsql.CreateCommand()
    Dim lector As SqlDataReader


    Private Sub frmParametroCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
    End Sub

    Private Sub FillDataGridCuentas()
        Dim query As String = String.Format("SELECT cu.idCuenta, cu.nombre AS nombre, ca.nombre AS calle, cu.numExt, 
                                            cu.numInt, cu.fechaAlta, cu.ultimoPagoA, cu.ultimoPagoM 
                                            FROM Cuentas cu 
                                            INNER JOIN Calles ca ON cu.idCalle = ca.idCalle
                                            WHERE cu.nombre LIKE '{0}%'", Trim(txtBuscarCuenta.Text))
        comando.CommandText = query
        lector = comando.ExecuteReader()
        dgCuentas.Rows.Clear()
        While lector.Read()
            dgCuentas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()

    End Sub

    Private Sub txtBuscarCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCuenta.TextChanged
        FillDataGridCuentas()
    End Sub

    Private Sub frmParametroCuenta_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub dgCuentas_Click(sender As Object, e As EventArgs) Handles dgCuentas.Click
        Dim row As DataGridViewRow = dgCuentas.CurrentRow

        If Not IsDBNull(row) Then
            txtIdCuenta.Text = row.Cells(0).Value
            txtNombre.Text = row.Cells(1).Value
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Not txtIdCuenta.Text.Equals("") Then
            Dim idCuenta As String = CInt(txtIdCuenta.Text)
            Dim CONEXION As New SqlConnection(stringConnection())

            Dim cmd As New SqlCommand("REPORTEHISTORIALPAGOSCUENTAS", CONEXION)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter()
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = CONEXION
            adaptador.SelectCommand.CommandText = "REPORTEHISTORIALPAGOSCUENTAS"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@idCuenta", SqlDbType.Int)
            param1.Direction = ParameterDirection.Input
            param1.Value = CInt(idCuenta)
            adaptador.SelectCommand.Parameters.Add(param1)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "ReporteHistorialPagosCuentas"
            Dim datasource As New ReportDataSource("ReporteHistorialPagosCuentas", dataset.Tables(0))
            datasource.Name = "ReporteHistorialPagosCuentas"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", txtNombre.Text)
            frmReporte.reportViewer.LocalReport.DataSources.Clear()
            frmReporte.reportViewer.LocalReport.DataSources.Add(datasource)
            frmReporte.reportViewer.LocalReport.ReportPath =
            "C:\SistemaAguaPotable\System\WaterSystem\Sistema\Reportes\ReporteHistorialPagosCuentas.rdlc"
            frmReporte.reportViewer.LocalReport.SetParameters(New ReportParameter() {p1})
            frmReporte.reportViewer.RefreshReport()
            frmReporte.ShowDialog()
            CONEXION.Close()
        End If
    End Sub
End Class