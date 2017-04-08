Imports System.Data.SqlClient

Public Class frmMovimientoSalidasMaterialesConsultaIndividual

    '--------------------DECLARACIÓN DE VARIABLES GLOBALES DE LA CLASE--------------------------!
    Dim conexionsql As New SqlConnection("Data Source='MARCOS-LAPTOP\PLEASEWORK'; Initial Catalog='db_agua_potable'; Integrated security=true")
    Dim comando As SqlCommand = conexionsql.CreateCommand()
    Dim lector As SqlDataReader

    '--------------------MÉTODO LOAD--------------------------!
    Private Sub frmMovimientoSalidasMaterialesConsultaIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
        FillCombitoIdSalida(combitoIdSalida)

    End Sub

    '--------------------LLENADO DE COMBO--------------------------!
    Private Sub FillCombitoIdSalida(combo As ComboBox)
        combo.Items.Clear()
        comando.CommandText = "SELECT idSalida FROM SalidasMateriales"

        lector = comando.ExecuteReader()
        While lector.Read()
            combo.Items.Add(lector(0))
        End While
        lector.Close()

        'combo.SelectedIndex = 0

    End Sub

    '--------------------BÚSQUEDAS DE LOS TEXTBOXS RELACIONADOS A LA COMBOBOX--------------------------!
    Private Sub combitoIdSalida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combitoIdSalida.SelectedIndexChanged

        Dim idSalidaActual As String = combitoIdSalida.Text

        comando.CommandText = String.Format(
                              "SELECT sm.concepto, sm.fecha, " &
                              "e.nombre, sm.idEmpleado, e.domicilio, e.celular, " &
                              "c.nombre, c.idCalle, c.TotalCasas " &
                              "FROM SalidasMateriales sm " &
                              "INNER JOIN Empleados e ON sm.idEmpleado = e.idEmpleado " &
                              "INNER JOIN Calles c ON sm.idCalle = c.idCalle " &
                              "WHERE sm.idSalida='{0}'", idSalidaActual)

        lector = comando.ExecuteReader()
        lector.Read()

        txtConcepto.Text = lector(0)
        dtpFecha.Value = lector(1)

        txtNombreEmpleado.Text = lector(2)
        txtIdEmpleado.Text = lector(3)
        txtEmpleadoDomicilio.Text = lector(4)
        txtEmpleadoCelular.Text = lector(5)

        txtCalle.Text = lector(6)
        txtIdCalle.Text = lector(7)
        txtTotalCasas.Text = lector(8)

        lector.Close()
        'Ciclo para calcular el subtotal.

        FillDataGridConsulta()

        Dim total As Double = 0
        Dim subtotal As Double = 0
        Dim iva As Double = 0
        For y = 0 To dgComprasMaterialesConsulta.Rows.Count - 2
            subtotal += dgComprasMaterialesConsulta.Item(4, y).Value
        Next

        iva = subtotal * 0.16
        total = subtotal + iva

        'Valores de los TextBoxs de subtotal, iva y total
        txtSubtotal.Text = Math.Round(subtotal, 2)
        txtIVA.Text = Math.Round(iva, 2)
        txtTotal.Text = Math.Round(total, 2)

    End Sub

    '--------------------LLENADO DE REJILLA-----------------------!
    Public Sub FillDataGridConsulta()

        Dim lector As SqlDataReader
        comando.CommandText = String.Format(
                              "SELECT d.idMaterial, m.descripcion, d.cantidad, d.costo " &
                              "FROM DetalleSalidasMateriales d " &
                              "INNER JOIN Materiales m ON d.idMaterial = m.idMaterial " &
                              "WHERE d.idSalida='{0}'", combitoIdSalida.Text)

        lector = comando.ExecuteReader()

        dgComprasMaterialesConsulta.Rows.Clear()
        While lector.Read()
            dgComprasMaterialesConsulta.Rows.Add(lector(0), lector(1), Math.Round(lector(2), 2),
                                                 Math.Round(lector(3), 2), CDbl(lector(2)) * CDbl(lector(3)))
        End While
        lector.Close()
    End Sub

    '--------------------MÉTODOS DE SALIDA DEL FORMULARIO--------------------------!
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub frmMovimientoComprasMaterialesConsultaIndividual_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexionsql.Close()
        Me.Dispose()
    End Sub

End Class