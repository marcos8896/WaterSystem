Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmParametroCuenta
    '--------------------DECLARACIÓN DE VARIABLES GLOBALES DE LA CLASE--------------------------!
    Dim conexionsql As New SqlConnection(stringConnection())
    Dim comando As SqlCommand = conexionsql.CreateCommand()
    Dim lector As SqlDataReader


    Private Sub frmParametroCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
    End Sub

    Private Sub FillDataGridCalles()
        Dim query As String = String.Format("SELECT idCalle, nombre, colonia, CP, TotalCasas FROM Calles WHERE nombre LIKE '{0}%'", Trim(txtBuscarCalle.Text))
        comando.CommandText = query
        lector = comando.ExecuteReader()
        dgCalles.Rows.Clear()
        While lector.Read()
            dgCalles.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()

    End Sub

    Private Sub txtBuscarCalle_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCalle.TextChanged
        FillDataGridCalles()
    End Sub

    Private Sub frmParametroCuenta_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub dgCalles_Click(sender As Object, e As EventArgs) Handles dgCalles.Click
        Dim row As DataGridViewRow = dgCalles.CurrentRow

        If Not IsDBNull(row) Then
            txtIdCalle.Text = row.Cells(0).Value
            txtNombre.Text = row.Cells(1).Value
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Not txtIdCalle.Text.Equals("") Then
            Dim idCalle As String = CInt(txtIdCalle.Text)
            Dim CONEXION As New SqlConnection(stringConnection())

            Dim cmd As New SqlCommand("REPORTECUENTASPORCALLE", CONEXION)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter()
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = CONEXION
            adaptador.SelectCommand.CommandText = "REPORTECUENTASPORCALLE"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@idCalle", SqlDbType.Int)
            param1.Direction = ParameterDirection.Input
            param1.Value = CInt(idCalle)
            adaptador.SelectCommand.Parameters.Add(param1)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "ReporteCuentasPorCalle"
            Dim datasource As New ReportDataSource("ReporteCuentasPorCalle", dataset.Tables(0))
            datasource.Name = "ReporteCuentasPorCalle"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", txtNombre.Text)
            frmReporte.reportViewer.LocalReport.DataSources.Clear()
            frmReporte.reportViewer.LocalReport.DataSources.Add(datasource)
            frmReporte.reportViewer.LocalReport.ReportPath =
            "C:\SistemaAguaPotable\System\WaterSystem\Sistema\Reportes\ReporteCuentasPorCalle.rdlc"
            frmReporte.reportViewer.LocalReport.SetParameters(New ReportParameter() {p1})
            frmReporte.reportViewer.RefreshReport()
            frmReporte.Show()
            CONEXION.Close()
        End If
    End Sub
End Class