Imports System.Data.SqlClient

Public Class frmMovimientoSalidasMaterialesAltas

    '--------------------DECLARACIÓN DE VARIABLES GLOBALES DE LA CLASE--------------------------!
    Dim conexionsql As New SqlConnection("Data Source='MARCOS-LAPTOP\PLEASEWORK'; Initial Catalog='db_agua_potable'; Integrated security=true")
    Dim comando As SqlCommand = conexionsql.CreateCommand()
    Dim lector As SqlDataReader

    '--------------------MÉTODO LOAD--------------------------!
    Private Sub frmMovimientoSalidasMaterialesAltas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()

        FillCombitoEmpleado(combitoEmpleado)
        FillCombitoMaterial(combitoMaterial)
        FillCombitoCalle(combitoCalle)

    End Sub

    '--------------------LLENADO DE COMBOS--------------------------!
    Private Sub FillCombitoEmpleado(combo As ComboBox)
        combo.Items.Clear()
        comando.CommandText = "SELECT nombre FROM Empleados"

        lector = comando.ExecuteReader()
        While lector.Read()
            combo.Items.Add(lector(0))
        End While
        lector.Close()

        combo.SelectedIndex = 0
    End Sub

    Private Sub FillCombitoMaterial(combo As ComboBox)
        combo.Items.Clear()
        comando.CommandText = "SELECT descripcion FROM Materiales"

        lector = comando.ExecuteReader()
        While lector.Read()
            combo.Items.Add(lector(0))
        End While
        lector.Close()

        combo.SelectedIndex = 0
    End Sub

    Private Sub FillCombitoCalle(combo As ComboBox)
        combo.Items.Clear()
        comando.CommandText = "SELECT nombre FROM Calles"

        lector = comando.ExecuteReader()
        While lector.Read()
            combo.Items.Add(lector(0))
        End While
        lector.Close()

        combo.SelectedIndex = 0
    End Sub

    '--------------------BÚSQUEDAS DE LOS TEXTBOXS RELACIONADOS A LAS COMBOBOXS--------------------------!
    Private Sub combitoEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combitoEmpleado.SelectedIndexChanged
        comando.CommandText = String.Format(
                              "SELECT idEmpleado, domicilio, celular " &
                              "FROM Empleados WHERE nombre='{0}'", combitoEmpleado.Text)

        lector = comando.ExecuteReader()
        lector.Read()

        txtIdEmpleado.Text = lector(0)
        txtEmpleadoDomicilio.Text = lector(1)
        txtEmpleadoCelular.Text = lector(2)

        lector.Close()
    End Sub

    Private Sub combitoMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combitoMaterial.SelectedIndexChanged
        comando.CommandText = String.Format(
                              "SELECT m.idMaterial, m.existencia, m.maximo, " &
                              "m.minimo, m.unidad, m.costo, m.ultimaFechaCompra " &
                              "FROM Materiales m WHERE descripcion='{0}'", combitoMaterial.Text)

        lector = comando.ExecuteReader()
        lector.Read()

        txtIdMaterial.Text = lector(0)
        txtExistencias.Text = Math.Round(lector(1), 2)
        txtMaximos.Text = Math.Round(lector(2), 2)
        txtMinimos.Text = Math.Round(lector(3), 2)
        txtUnidad.Text = lector(4)
        txtCosto.Text = Math.Round(lector(5), 2)
        txtUltimaFechaCompra.Text = lector(6)

        lector.Close()
    End Sub

    Private Sub combitoCalle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combitoCalle.SelectedIndexChanged
        comando.CommandText = String.Format(
                              "SELECT idCalle, TotalCasas " &
                              "FROM Calles WHERE nombre='{0}'", combitoCalle.Text)

        lector = comando.ExecuteReader()
        lector.Read()

        txtIdCalle.Text = lector(0)
        txtTotalCasas.Text = lector(1)

        lector.Close()
    End Sub

    '--------------------MÉTODOS DE SALIDA DEL FORMULARIO--------------------------!
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub frmMovimientoSalidasMateriales_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexionsql.Close()
        Me.Dispose()
    End Sub

    '--------------------BOTONES DE ACCIÓN DEL FORMULARIO--------------------------!
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        comando.CommandText = "SELECT COUNT(*) FROM SalidasMateriales"
        Dim n As Integer
        n = comando.ExecuteScalar() + 1

        txtIdSalida.Text = n.ToString

        btnNuevo.Enabled = False
        btnSalir.Enabled = False
        btnAceptar.Enabled = True
        btnGrabar.Enabled = True

        txtConceptoSalida.ReadOnly = False
        txtCantidad.ReadOnly = False

        combitoEmpleado.Enabled = True
        combitoMaterial.Enabled = True
        combitoCalle.Enabled = True

        dtpFecha.Enabled = True
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Not txtCantidad.Text.Equals("") Then

            Dim actualizado As Boolean = False

            For x = 0 To dgComprasMateriales.Rows.Count - 2
                If combitoMaterial.Text = dgComprasMateriales.Item(1, x).Value Then

                    'Registro nuevo tomado de los TextBoxs
                    Dim cantidad As Double = Math.Round(CDbl(Replace(txtCantidad.Text, ".", ",")), 4)
                    Dim costo As Double = Math.Round(CDbl(Replace(txtCosto.Text, ".", ",")), 4)
                    Dim importe As Double = Math.Round(cantidad * costo, 4)
                    Dim nuevoRegistro() As Object = {CInt(txtIdMaterial.Text), combitoMaterial.Text,
                                                    cantidad, costo, importe}


                    'Registro de la rejilla con el mismo material que el registro nuevo
                    Dim filaRejilla(4) As Object
                    For y = 0 To 4
                        filaRejilla(y) = dgComprasMateriales.Item(y, x).Value
                    Next

                    'Registro final que reemplazará al antiguo registro en la rejilla
                    Dim filaActualizada(4) As Object
                    filaActualizada(0) = txtIdMaterial.Text
                    filaActualizada(1) = combitoMaterial.Text
                    filaActualizada(2) = CStr(CDbl(nuevoRegistro(2)) + CDbl(filaRejilla(2)))
                    filaActualizada(3) = nuevoRegistro(3)
                    filaActualizada(4) = CStr(CDbl(filaActualizada(2)) * CDbl(nuevoRegistro(3)))

                    'Se sube la fila actualizada a la rejilla
                    For y = 0 To 4
                        dgComprasMateriales.Item(y, x).Value = filaActualizada(y)
                    Next

                    x = dgComprasMateriales.Rows.Count
                    actualizado = True
                End If
            Next

            If actualizado = False Then

                Dim cantidad As Double = Math.Round(CDbl(Replace(txtCantidad.Text, ".", ",")), 4)
                Dim costo As Double = Math.Round(CDbl(Replace(txtCosto.Text, ".", ",")), 4)
                Dim importe As Double = Math.Round(cantidad * costo, 4)

                dgComprasMateriales.Rows.Add(CInt(txtIdMaterial.Text), combitoMaterial.Text,
                    cantidad, costo, importe)
            End If


            'Ciclo para calcular el subtotal.
            Dim total As Double = 0
            Dim subtotal As Double = 0
            Dim iva As Double = 0
            For y = 0 To dgComprasMateriales.Rows.Count - 2
                subtotal += dgComprasMateriales.Item(4, y).Value
            Next

            iva = subtotal * 0.16
            total = subtotal + iva

            'Valores de los TextBoxs de subtotal, iva y total
            txtSubtotal.Text = Math.Round(subtotal, 2)
            txtIVA.Text = Math.Round(iva, 2)
            txtTotal.Text = Math.Round(total, 2)

            txtCantidad.Text = ""

            txtCantidad.Select()

        Else
            MessageBox.Show("No se permiten campos vacíos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Not txtTotal.Text.Equals("") And Not txtConceptoSalida.Text.Equals("") Then

            altaSalidasMateriales()
            altaDetalleSalidasMateriales()

            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnSalir.Enabled = True
            btnAceptar.Enabled = False

            txtConceptoSalida.ReadOnly = True
            txtCantidad.ReadOnly = True

            combitoMaterial.Enabled = False
            combitoEmpleado.Enabled = False
            combitoCalle.Enabled = True
            dtpFecha.Enabled = False

            'Se limpian los controles
            txtConceptoSalida.Text = ""
            txtCantidad.Text = ""
            txtSubtotal.Text = ""
            txtTotal.Text = ""
            txtIVA.Text = ""
            txtIdSalida.Text = ""
            dgComprasMateriales.Rows.Clear()
            dtpFecha.Value = Date.Today

            FillCombitoEmpleado(combitoEmpleado)
            FillCombitoMaterial(combitoMaterial)
            FillCombitoCalle(combitoCalle)

        Else
            MessageBox.Show("No se permiten campos vacíos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    '--------------------MÉTODOS DE INSERCIÓN Y MODIFICACIÓN  EN DATABASE--------------------------!
    Public Sub altaSalidasMateriales()
        'Se da de alta en ComprasMateriales
        Dim idSalida As Integer = CInt(txtIdSalida.Text)
        Dim idEmpleado As Integer = CInt(txtIdEmpleado.Text)
        Dim idCalle As Integer = CInt(txtIdCalle.Text)
        Dim fecha As Date = dtpFecha.Value.Date
        Dim concepto As String = txtConceptoSalida.Text

        comando.CommandText = String.Format("INSERT INTO SalidasMateriales (idSalida, " &
                                            "idEmpleado, idCalle, fecha, concepto) " &
                                            "VALUES ({0}, {1}, {2}, '{3}', '{4}')",
                                            idSalida, idEmpleado, idCalle, CStr(fecha.ToShortDateString),
                                            concepto)
        comando.ExecuteNonQuery()
    End Sub

    Public Sub altaDetalleSalidasMateriales()

        'Se da de alta en DetalleComprasMateriales
        Dim idSalida As Integer
        Dim idMaterial As Integer
        Dim cantidad As String
        Dim costo As String
        Dim existencia As String

        For x = 0 To dgComprasMateriales.Rows.Count - 2

            idSalida = CInt(txtIdSalida.Text)

            'Consulta para obtener el idMaterial de cada uno de los materiales en la rejilla
            comando.CommandText = String.Format("SELECT idMaterial, existencia FROM Materiales " &
                                                "WHERE descripcion='{0}'",
                                                CStr(dgComprasMateriales.Item(1, x).Value))

            lector = comando.ExecuteReader()
            lector.Read()
            idMaterial = lector(0)
            existencia = lector(1)
            lector.Close()

            cantidad = dgComprasMateriales.Item(2, x).Value
            costo = dgComprasMateriales.Item(3, x).Value


            'Actualizar datos del material en tabla Materiales
            Dim aux As Double = CDbl(existencia) - CDbl(cantidad)

            cantidad = Replace(cantidad, ",", ".")
            costo = Replace(costo, ",", ".")

            comando.CommandText = String.Format("UPDATE Materiales SET existencia='{0}' " &
                                                "WHERE idMaterial={1}",
                                                Replace(CStr(aux), ",", "."), idMaterial)
            comando.ExecuteNonQuery()

            'Inserción en DetalleComprasMateriales
            comando.CommandText = String.Format("INSERT INTO DetalleSalidasMateriales (" &
                                                "idSalida, idMaterial, cantidad, costo) " &
                                                "VALUES ({0}, {1}, '{2}', '{3}')",
                                                idSalida, idMaterial, cantidad, costo)
            comando.ExecuteNonQuery()

        Next
    End Sub

    '--------------------VALIDACIÓN DE CARACTERES VÁLIDOS--------------------------!
    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        caracteresValidos(sender, e, "NUMBERS")

        'Sólo se permite un punto en la cadena.
        If (e.KeyChar = "." And txtCantidad.Text.Contains(".")) Then
            e.Handled = True
        End If

    End Sub

End Class