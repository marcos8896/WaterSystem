Imports System.Data.SqlClient

Public Class txtBuscarEmpleado
    '--------------------DECLARACIÓN DE VARIABLES GLOBALES DE LA CLASE--------------------------!
    Dim conexionsql As New SqlConnection(stringConnection())
    Dim comando As SqlCommand = conexionsql.CreateCommand()
    Dim lector As SqlDataReader







    '--------------------MÉTODO LOAD--------------------------!
    Private Sub frmMovimientoPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()

        FillCombitoSituacion(combitoSituacion)
        FillCombitoTarifa(combitoIdTarifa)

        cleanTextBoxsAndDataGrids()
    End Sub







    '--------------------LLENADO DE COMBOS--------------------------!
    Private Sub FillCombitoSituacion(combo As ComboBox)
        combo.Items.Clear()
        comando.CommandText = "SELECT descripcion FROM Situacion"

        lector = comando.ExecuteReader()
        While lector.Read()
            combo.Items.Add(lector(0))
        End While
        lector.Close()

        combo.SelectedIndex = 0
    End Sub

    Private Sub FillCombitoTarifa(combo As ComboBox)
        combo.Items.Clear()
        comando.CommandText = "SELECT idTarifa FROM Tarifas"

        lector = comando.ExecuteReader()
        While lector.Read()
            combo.Items.Add(lector(0))
        End While
        lector.Close()

        combo.SelectedIndex = 0
    End Sub







    '--------------------BÚSQUEDAS DE LOS TEXTBOXS RELACIONADOS A LAS COMBOBOXS--------------------------!
    Private Sub combitoSituacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combitoSituacion.SelectedIndexChanged
        comando.CommandText = String.Format(
                              "SELECT idSituacion, descuento " &
                              "FROM Situacion WHERE descripcion='{0}'", combitoSituacion.Text)

        lector = comando.ExecuteReader()
        lector.Read()

        txtIdSituacion.Text = lector(0)
        txtDescuento.Text = lector(1)

        lector.Close()


        calculoTentativoAguaCombitoSituacion()

    End Sub

    Private Sub combitoIdTarifa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combitoIdTarifa.SelectedIndexChanged
        comando.CommandText = String.Format(
                              "SELECT anio, CF, TAR, recargos, INFRA " &
                              "FROM Tarifas WHERE idTarifa='{0}'", combitoIdTarifa.Text)

        lector = comando.ExecuteReader()
        lector.Read()

        txtAnioTarifa.Text = lector(0)
        txtCuotaFija.Text = lector(1)
        txtTAR.Text = lector(2)
        txtRecargo.Text = lector(3)
        txtINFRA.Text = lector(4)

        lector.Close()

        calculoTentativoAguaCombitoTarifa()
    End Sub








    '--------------------LLENADO DE LA REJILLAS--------------------------!
    Private Sub FillDataGridCuentas()
        Dim query As String = String.Format("SELECT c.idCuenta, c.nombre, ca.idCalle, ca.Nombre, " &
                                            "c.fechaAlta, c.ultimoPagoA, c.ultimoPagoM " &
                                            "FROM Cuentas c " &
                                            "INNER JOIN Calles ca ON c.idCalle = ca.idCalle " &
                                            "WHERE c.nombre LIKE '{0}%'", Trim(txtBuscarCuenta.Text))
        comando.CommandText = query
        lector = comando.ExecuteReader()
        dgDatosCuentas.Rows.Clear()
        While lector.Read()
            dgDatosCuentas.Rows.Add(lector(0), lector(1), lector(2), lector(3),
                                                        CDate(lector(4)).ToShortDateString, lector(5),
                                                        lector(6))
        End While
        lector.Close()

    End Sub

    Private Sub FillDataGridServicios()
        Dim query As String = String.Format("SELECT idServicio, descripcion, precio " &
                                            "FROM Servicios " &
                                            "WHERE descripcion LIKE '{0}%'", Trim(txtBuscarServicio.Text))
        comando.CommandText = query
        lector = comando.ExecuteReader()
        dgServicios.Rows.Clear()
        
        While lector.Read()
            dgServicios.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()

    End Sub

    Private Sub FillDataGridEmpleados()
        Dim query As String = String.Format("SELECT idEmpleado, nombre, celular " &
                                            "FROM Empleados " &
                                            "WHERE nombre LIKE '{0}%'", Trim(txtBuscarEmployee.Text))
        comando.CommandText = query
        lector = comando.ExecuteReader()
        dgEmpleados.Rows.Clear()
        While lector.Read()
            dgEmpleados.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()

    End Sub







    '--------------------TEXTCHANGED'--------------------------!
    Private Sub txtBuscarCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCuenta.TextChanged
        FillDataGridCuentas()
    End Sub

    Private Sub txtNombreEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEmployee.TextChanged
        FillDataGridEmpleados()
    End Sub

    Private Sub txtNombreServicio_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarServicio.TextChanged
        FillDataGridServicios()
    End Sub







    '--------------------RELLENADO DE TEXTBOXS MEDIANTE DATAGRIDs--------------------------!
    Private Sub dgDatosCuentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDatosCuentas.CellClick
        Dim row As DataGridViewRow = dgDatosCuentas.CurrentRow

        If Not IsDBNull(row) Then
            txtIdCuenta.Text = row.Cells(0).Value
            txtCuentaNombre.Text = row.Cells(1).Value
            txtCuentaIdCalle.Text = row.Cells(2).Value
            txtCuentaCalle.Text = row.Cells(3).Value
            txtCuentaUltimoA.Text = row.Cells(5).Value
            txtCuentaUltimoM.Text = row.Cells(6).Value
        End If

    End Sub

    Private Sub dgServicios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgServicios.CellClick
        Dim row As DataGridViewRow = dgServicios.CurrentRow

        If Not IsDBNull(row) Then
            txtIdServicio.Text = row.Cells(0).Value
            txtServicioDescripcion.Text = row.Cells(1).Value
            txtServicioPrecio.Text = row.Cells(2).Value

        End If
    End Sub

    Private Sub dgEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEmpleados.CellClick
        Dim row As DataGridViewRow = dgEmpleados.CurrentRow

        If Not IsDBNull(row) Then
            txtIdEmpleado.Text = row.Cells(0).Value
            txtEmpleadoNombre.Text = row.Cells(1).Value
        End If
    End Sub







    '--------------------MÉTODOS DE SALIDA DEL FORMULARIO--------------------------!
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub frmMovimientoPagosAltas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexionsql.Close()
        Me.Dispose()
    End Sub







    '--------------------MÉTODOS DE ACCIÓN (DE BOTONES PRINCIPALES)--------------------------!
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        cleanTextBoxsAndDataGrids()

        comando.CommandText = "SELECT COUNT(*) FROM Pagos"
        Dim n As Integer
        n = comando.ExecuteScalar() + 1

        txtIdPago.Text = n.ToString

        txtBuscarCuenta.ReadOnly = False
        txtBuscarServicio.ReadOnly = False
        txtBuscarEmployee.ReadOnly = False
        txtOtros.ReadOnly = False

        btnNuevo.Enabled = False
        btnSalir.Enabled = False
        btnGrabar.Enabled = True

        panelPagoAgua.Enabled = True
        panelTipoPago.Enabled = False

    End Sub

    Private Sub rbAgua_Click(sender As Object, e As EventArgs) Handles rbAgua.Click
        panelPagoAgua.Visible = True
        panelServiciosAtendidos.Visible = False

        lblDescuento.Visible = True
        txtDescuentoFinal.Visible = True

        panelTipoPago.Enabled = False

        btnNuevo.Enabled = True

        cleanTextBoxsAndDataGrids()

    End Sub

    Private Sub rbServicios_Click(sender As Object, e As EventArgs) Handles rbServicios.Click
        panelPagoAgua.Visible = False
        panelServiciosAtendidos.Visible = True

        lblDescuento.Visible = False
        txtDescuentoFinal.Visible = False

        panelTipoPago.Enabled = False

        btnNuevo.Enabled = True

        cleanTextBoxsAndDataGrids()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If rbAgua.Checked Then
            If Not txtIdCuenta.Text.Equals("") And Not txtIdSituacion.Text.Equals("") And Not txtAnioTarifa.Text.Equals("") And Not txtOtros.Text.Equals("") Then
                '   Campos de TABLA: Pagos
                Dim idPago As Integer = CInt(txtIdPago.Text)
                Dim idCuenta As Integer = CInt(txtIdCuenta.Text)
                Dim fecha As Date = CDate(txtFechaSO.Text)
                Dim tipo As String = "PAGO AGUA" 'PAGO SERVICIO ES LA OTRA OPCIÓN
                Dim otros As Double = CDbl(Replace(txtOtros.Text, ".", ","))
                Dim total As Double

                '   Campos de TABLA: PagosAgua
                'idPago
                Dim idSituacion As Integer = CInt(txtIdSituacion.Text)
                Dim idTarifa As Integer = CInt(combitoIdTarifa.Text)
                Dim mesInicial As Integer = getMonthNumber(combitoMesInicial)
                Dim mesFinal As Integer = getMonthNumber(combitoMesFinal)
                Dim descuento As Double = CDbl(txtDescuento.Text) 'Es un porcentaje
                Dim recargos As Double = CDbl(txtRecargo.Text)
                Dim CF As Double = CDbl(txtCuotaFija.Text)
                Dim TAR As Double = CDbl(txtTAR.Text)
                Dim INFRA As Double = CDbl(txtINFRA.Text)

                'CÁLCULOS Y OPERACIONES


                If CStr(CDate(txtFechaSO.Text).Date.Year).Equals(txtAnioTarifa.Text) Then
                    recargos = 0
                Else
                    descuento = 0
                End If

                'Meses a pagar
                Dim mesesAPagar As Integer = getMonthMutiplier(getMonthNumber(combitoMesInicial), getMonthNumber(combitoMesFinal))

                CF = (CF / 12) * mesesAPagar
                txtCuotaFijaCalculada.Text = CStr(CF)

                recargos = (recargos / 12) * mesesAPagar
                txtRecargoCalculado.Text = CStr(recargos)

                TAR = (TAR / 12) * mesesAPagar
                txtTARCalculada.Text = CStr(TAR)

                INFRA = (INFRA / 12) * mesesAPagar
                txtINFRACalculada.Text = CStr(INFRA)

                'CHECAR SI LOS DESCUENTOS SON VÁLIDOS INCLUSO SI SE PAGA UN AÑO ATRASADO.
                Dim subtotal As Double = CF + TAR + INFRA + recargos ' CHECAR SI EL RECARGO SÓLO APLICA EN AÑOS ATRASADOS
                Dim descuentoFinal As Double = subtotal * descuento

                total = subtotal + CDbl(Replace(txtOtros.Text, ".", ",")) - descuentoFinal

                'LLENAR TEXTBOXS DE TOTAL, DESCUENTO Y TOTAL
                txtSubtotal.Text = Replace(CStr(subtotal), ".", ",")
                txtDescuentoFinal.Text = Replace(CStr(descuentoFinal), ".", ",")
                txtTotal.Text = Replace(CStr(total), ".", ",")

                If payPerYear() Then 'Pago por año
                    labelPagoPor.Text = "Tarifas a pagar por: " + "Año"

                Else 'Pago por mes
                    labelPagoPor.Text = "Tarifas a pagar por: " + "Mes"

                End If


                'DAR DE ALTA EN LA BASE DE DATOS
                Dim query As String

                '-----PAGOS
                query = String.Format("INSERT INTO Pagos (idPago, idCuenta, fecha, tipo, otros, total) VALUES " &
                                      "({0}, {1}, '{2}', '{3}', {4}, {5})",
                                      idPago, idCuenta, fecha.ToShortDateString, tipo,
                                      Replace(CStr(otros), ",", "."), Replace(CStr(total), ",", "."))
                comando.CommandText = query
                comando.ExecuteNonQuery()


                '-----PAGOS AGUA
                query = String.Format("INSERT INTO PagosAgua (idPago, idSituacion, idTarifa, mesInicial, mesFinal, descuento, recargos, " &
                                      "CF, TAR, INFRA, subtotal) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})",
                                      idPago, idSituacion, idTarifa, mesInicial, mesFinal,
                                      Replace(CStr(descuentoFinal), ",", "."), Replace(CStr(recargos), ",", "."),
                                      Replace(CStr(CF), ",", "."), Replace(CStr(TAR), ",", "."),
                                      Replace(CStr(INFRA), ",", "."), Replace(CStr(subtotal), ",", "."))
                comando.CommandText = query
                comando.ExecuteNonQuery()

                '-----ACTUALIZAR ultimoMesPago y ultimoAñoPago en TABLA: CUENTAS
                query = String.Format("UPDATE Cuentas SET ultimoPagoA={0}, ultimoPagoM={1} WHERE idCuenta={2}",
                                      CInt(txtAnioTarifa.Text), mesFinal, idCuenta)
                comando.CommandText = query
                comando.ExecuteNonQuery()

                habilitarBotonesGrabar()

            Else
                MessageBox.Show("No se permiten campos vacíos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        Else
        End If


        If rbServicios.Checked Then
            If Not txtIdCuenta.Text.Equals("") And Not txtIdServicio.Text.Equals("") And Not txtIdEmpleado.Text.Equals("") And Not txtOtros.Text.Equals("") Then
                '   Campos de TABLA: Pagos
                Dim idPago As Integer = CInt(txtIdPago.Text)
                Dim idCuenta As Integer = CInt(txtIdCuenta.Text)
                Dim fecha As Date = CDate(txtFechaSO.Text)
                Dim tipo As String = "PAGO SERVICIO" 'PAGO SERVICIO ES LA OTRA OPCIÓN
                Dim otros As Double = CDbl(Replace(txtOtros.Text, ".", ","))
                Dim total As Double

                '   Campos de TABLA: ServiciosAtendidos
                'idPago
                Dim idServicio As Integer = CInt(txtIdServicio.Text)
                Dim idEmpleado As Integer = CInt(txtIdEmpleado.Text)
                Dim precioServicio As Double = CDbl(Replace(txtServicioPrecio.Text, ".", ","))

                '-----------------------------------
                Dim subtotal As Double = precioServicio

                total = subtotal + otros

                'LLENAR TEXTBOXS DE TOTAL, DESCUENTO Y TOTAL
                txtSubtotal.Text = Replace(CStr(subtotal), ".", ",")
                txtTotal.Text = Replace(CStr(total), ".", ",")


                'DAR DE ALTA EN LA BASE DE DATOS

                Dim query As String

                '-----PAGOS
                query = String.Format("INSERT INTO Pagos (idPago, idCuenta, fecha, tipo, otros, total) VALUES " &
                                      "({0}, {1}, '{2}', '{3}', {4}, {5})",
                                      idPago, idCuenta, fecha.ToShortDateString, tipo,
                                      Replace(CStr(otros), ",", "."), Replace(CStr(total), ",", "."))
                comando.CommandText = query
                comando.ExecuteNonQuery()


                '-----SERVICIOSATENDIDOS
                query = String.Format("INSERT INTO ServiciosAtendidos (idPago, idServicio, idEmpleado, precio) " &
                                      "VALUES ({0}, {1}, {2}, {3})", idPago, idServicio, idEmpleado, Replace(CStr(precioServicio), ",", "."))
                comando.CommandText = query
                comando.ExecuteNonQuery()


                habilitarBotonesGrabar()

            Else
                MessageBox.Show("No se permiten campos vacíos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If
    End Sub







    '--------------------MÉTODOS AUXILIARES PARA LAS ALTAS DE PagosAgua--------------------------!
    Public Function payPerYear() As Boolean
        If getMonthNumber(combitoMesInicial) = 1 And getMonthNumber(combitoMesFinal) = 12 Then ' Pago por año
            Return True
        End If
        Return False
    End Function


    '           -------------------MÉTODOS DE CONTROL DE LOS MESES A PAGAR--------------------------!
    Private Sub combitoMesInicial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combitoMesInicial.SelectedIndexChanged
        Dim months() As String = {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO",
                                  "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE",
                                  "DICIEMBRE"}
        Dim numberMonths() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}

        combitoMesFinal.Items.Clear()

        For x = combitoMesInicial.SelectedIndex To 11
            combitoMesFinal.Items.Add(months(x))
        Next

        combitoMesFinal.SelectedIndex = 0
    End Sub


    Private Function getMonthNumber(combito As ComboBox)

        Dim months() As String = {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO",
                                  "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE",
                                  "DICIEMBRE"}
        Dim monthsNumber() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}

        Dim mes As String = combito.Text
        Dim x As Integer = 0
        While (x <= 11)
            If mes.Equals(months(x)) Then
                Return monthsNumber(x)
            End If

            x += 1
        End While
    End Function

    Public Function getMonthMutiplier(mesInicial As Integer, mesFinal As Integer) As Integer
        Dim x As Integer = mesInicial - 1
        Dim cont As Integer = 0

        While (x <= mesFinal - 1)
            cont += 1
            x += 1
        End While

        Return cont
    End Function







    '--------------------VALIDACIÓN DE CARACTERES VÁLIDOS--------------------------!
    Private Sub txtOtros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtros.KeyPress
        caracteresValidos(sender, e, "NUMBERS")

        'Sólo se permite un punto en la cadena.
        If (e.KeyChar = "." And txtOtros.Text.Length = 0) Then
            e.Handled = True
        Else
            If (e.KeyChar = "." And txtOtros.Text.Contains(".")) Then
                e.Handled = True
            End If
        End If

    End Sub







    '--------------------MÉTODOS DE HABILITACIÓN Y DESHABILITACIÓN
    Public Sub habilitarBotonesGrabar()
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        btnSalir.Enabled = True

        panelTipoPago.Enabled = True

        txtBuscarCuenta.ReadOnly = True
        txtBuscarServicio.ReadOnly = True
        txtBuscarEmployee.ReadOnly = True
        txtBuscarEmployee.ReadOnly = True
        'btnImprimir.Enabled = True

        panelPagoAgua.Enabled = False
    End Sub







    '--------------------MÉTODOS LIMPIEZA DE TEXTBOXS--------------------------!
    Private Sub cleanTextBoxsAndDataGrids()
        'Textboxs principales
        txtIdPago.Text = ""
        txtFechaSO.Text = Date.Today.Date.ToShortDateString

        'Textbox de cuentas
        txtCuentaNombre.Text = ""
        txtCuentaCalle.Text = ""
        txtIdCuenta.Text = ""
        txtCuentaIdCalle.Text = ""
        txtCuentaUltimoA.Text = ""
        txtCuentaUltimoM.Text = ""

        'Textboxs de servicios
        txtIdServicio.Text = ""
        txtServicioDescripcion.Text = ""
        txtServicioPrecio.Text = ""
        txtBuscarServicio.Text = ""

        'Textboxs de empleados
        txtIdEmpleado.Text = ""
        txtEmpleadoNombre.Text = ""
        txtBuscarEmployee.Text = ""

        'Textboxs de tarifas
        txtCuotaFijaCalculada.Text = ""
        txtRecargoCalculado.Text = ""
        txtTARCalculada.Text = ""
        txtINFRACalculada.Text = ""

        'Textboxs generales
        txtTotal.Text = ""
        txtOtros.Text = ""
        txtDescuentoFinal.Text = ""
        txtSubtotal.Text = ""

        'Textboxs búsquedas
        txtBuscarCuenta.Text = ""
        txtBuscarEmployee.Text = ""
        txtBuscarServicio.Text = ""

        'Limpieza de DataGrids
        dgServicios.Rows.Clear()
        dgEmpleados.Rows.Clear()
        dgDatosCuentas.Rows.Clear()

        combitoMesInicial.SelectedIndex = 0
        combitoMesFinal.SelectedIndex = 0

        labelPagoPor.Text = "Tarifas a pagar por: "

    End Sub





    '----------------MÉTODOS DE CÁLCULOS TENTATIVOS DE PAGOS AGUA
    Private Sub combitoMesFinal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combitoMesFinal.SelectedIndexChanged
        calculoAgua()
    End Sub

    Private Sub txtOtros_TextChanged(sender As Object, e As EventArgs) Handles txtOtros.TextChanged
        calculoAgua()
        calculoServicio()

    End Sub

    Public Sub calculoTentativoAguaCombitoTarifa()
        If Not txtIdSituacion.Text.Equals("") Then
            calculoAgua()
        End If
    End Sub

    Public Sub calculoTentativoAguaCombitoSituacion()
        If Not txtAnioTarifa.Text.Equals("") Then
            calculoAgua()
        End If
    End Sub

    Private Sub calculoAgua()
        If rbAgua.Checked Then
            '   Campos a calcular de TABLA: PagosAgua
            Dim descuento As Double = CDbl(txtDescuento.Text) 'Es un porcentaje
            Dim recargos As Double = CDbl(txtRecargo.Text)
            Dim CF As Double = CDbl(txtCuotaFija.Text)
            Dim TAR As Double = CDbl(txtTAR.Text)
            Dim INFRA As Double = CDbl(txtINFRA.Text)

            'CÁLCULOS Y OPERACIONES
            If CStr(CDate(txtFechaSO.Text).Date.Year).Equals(txtAnioTarifa.Text) Then
                recargos = 0
            Else
                descuento = 0
            End If

            'Meses a pagar
            Dim mesesAPagar As Integer = getMonthMutiplier(getMonthNumber(combitoMesInicial), getMonthNumber(combitoMesFinal))

            CF = (CF / 12) * mesesAPagar
            txtCuotaFijaCalculada.Text = CStr(CF)

            recargos = (recargos / 12) * mesesAPagar
            txtRecargoCalculado.Text = CStr(recargos)

            TAR = (TAR / 12) * mesesAPagar
            txtTARCalculada.Text = CStr(TAR)

            INFRA = (INFRA / 12) * mesesAPagar
            txtINFRACalculada.Text = CStr(INFRA)

            'CHECAR SI LOS DESCUENTOS SON VÁLIDOS INCLUSO SI SE PAGA UN AÑO ATRASADO.
            Dim subtotal As Double = CF + TAR + INFRA + recargos ' CHECAR SI EL RECARGO SÓLO APLICA EN AÑOS ATRASADOS
            Dim descuentoFinal As Double = subtotal * descuento
            Dim total As Double

            total = subtotal + CDbl(Replace(txtOtros.Text, ".", ",")) - descuentoFinal

            'LLENAR TEXTBOXS DE TOTAL, DESCUENTO Y TOTAL
            txtSubtotal.Text = Replace(CStr(subtotal), ".", ",")
            txtDescuentoFinal.Text = Replace(CStr(descuentoFinal), ".", ",")
            txtTotal.Text = Replace(CStr(total), ".", ",")

            If payPerYear() Then 'Pago por año
                labelPagoPor.Text = "Tarifas a pagar por: " + "Año"

            Else 'Pago por mes
                labelPagoPor.Text = "Tarifas a pagar por: " + "Mes"

            End If

        End If
    End Sub

    Public Sub calculoServicio()
        If rbServicios.Checked Then
            If Not txtServicioPrecio.Text.Equals("") Then
                Dim total As Double
                Dim precioServicio As Double = CDbl(Replace(txtServicioPrecio.Text, ".", ","))
                '-----------------------------------
                Dim subtotal As Double = precioServicio
                Dim otros As Double = CDbl(Replace(txtOtros.Text, ".", ","))
                total = subtotal + otros

                'LLENAR TEXTBOXS DE TOTAL, DESCUENTO Y TOTAL
                txtSubtotal.Text = Replace(CStr(subtotal), ".", ",")
                txtTotal.Text = Replace(CStr(total), ".", ",")
            End If
        End If


    End Sub

    '----------------MÉTODOS DE CÁLCULOS TENTATIVOS DE PAGOS SERVICIO---------------------
    Private Sub txtServicioPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtServicioPrecio.TextChanged
        calculoServicio()
    End Sub

    '----------------MÉTODOS DE SELECCIÓN DE COMBOS TARIFA Y MESES---------------------
    Private Sub txtCuentaUltimoA_TextChanged(sender As Object, e As EventArgs) Handles txtCuentaUltimoA.TextChanged

    End Sub

    Private Sub txtCuentaUltimoM_TextChanged(sender As Object, e As EventArgs) Handles txtCuentaUltimoM.TextChanged
        If CInt(txtCuentaUltimoM.Text) = 0 Then
            combitoMesInicial.SelectedIndex = 0
        Else
            If CInt(txtCuentaUltimoM.Text = 12) Then
                combitoMesInicial.SelectedIndex = 0
            Else
                combitoMesInicial.SelectedIndex = txtCuentaUltimoM.Text
            End If
        End If
    End Sub
End Class