Imports System.Data.SqlClient

Public Class frmMovimientoComprasMaterialesConsultaIndividual

    '--------------------DECLARACIÓN DE VARIABLES GLOBALES DE LA CLASE--------------------------!
    Dim conexionsql As New SqlConnection("Data Source='MARCOS-LAPTOP\PLEASEWORK'; Initial Catalog='db_agua_potable'; Integrated security=true")
    Dim comando As SqlCommand = conexionsql.CreateCommand()
    Dim lector As SqlDataReader

    '--------------------MÉTODO LOAD--------------------------!
    Private Sub frmMovimientoComprasMaterialesConsultaIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
        FillCombitoIdOrden(combitoIdOrden)

    End Sub

    '--------------------LLENADO DE COMBO--------------------------!
    Private Sub FillCombitoIdOrden(combo As ComboBox)
        combo.Items.Clear()
        comando.CommandText = "SELECT idOrden FROM ComprasMateriales"

        lector = comando.ExecuteReader()
        While lector.Read()
            combo.Items.Add(lector(0))
        End While
        lector.Close()

        'combo.SelectedIndex = 0

    End Sub

    '--------------------BÚSQUEDAS DE LOS TEXTBOXS RELACIONADOS A LA COMBOBOX--------------------------!
    Private Sub combitoIdOrden_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combitoIdOrden.SelectedIndexChanged

        Dim idOrdenActual As String = combitoIdOrden.Text

        comando.CommandText = String.Format(
                              "SELECT cm.factura, cm.subtotal, cm.total, cm.iva, cm.fecha, " &
                              "p.nombre, p.idProveedor, p.domicilio, p.telefono " &
                              "FROM ComprasMateriales cm " &
                              "INNER JOIN Proveedores p ON cm.idProveedor = p.idProveedor " &
                              "WHERE cm.idOrden='{0}'", idOrdenActual)

        lector = comando.ExecuteReader()
        lector.Read()

        txtFactura.Text = lector(0)
        txtSubtotal.Text = Math.Round(lector(1), 2)
        txtTotal.Text = Math.Round(lector(2), 2)
        txtIVA.Text = Math.Round(lector(3), 2)
        dtpFecha.Value = lector(4)

        txtNombreProveedor.Text = lector(5)
        txtIdProveedor.Text = lector(6)
        txtProveedorDomicilio.Text = lector(7)
        txtProveedorTelefono.Text = lector(8)

        lector.Close()

        FillDataGridConsulta()

    End Sub

    '--------------------LLENADO DE REJILLA-----------------------!
    Public Sub FillDataGridConsulta()

        Dim lector As SqlDataReader
        comando.CommandText = String.Format(
                              "SELECT d.idMaterial, m.descripcion, d.cantidad, d.costo " &
                              "FROM DetalleComprasMateriales d " &
                              "INNER JOIN Materiales m ON d.idMaterial = m.idMaterial " &
                              "WHERE d.idOrden='{0}'", combitoIdOrden.Text)

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