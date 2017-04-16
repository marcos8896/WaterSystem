Imports System.Data.SqlClient

Public Class frmMovimientoPagosConsultaIndividual

    '--------------------DECLARACIÓN DE VARIABLES GLOBALES DE LA CLASE--------------------------!
    Dim conexionsql As New SqlConnection(stringConnection())
    Dim comando As SqlCommand = conexionsql.CreateCommand()
    Dim lector As SqlDataReader







    '--------------------MÉTODO LOAD--------------------------!
    Private Sub frmMovimientoPagosConsultaIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()

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

    Private Sub FillDataGridPagos(idCuenta As Integer)
        Dim query As String = String.Format("SELECT p.idPago, c.nombre, p.fecha, p.tipo, p.otros, p.total " &
                                            "FROM Pagos p " &
                                            "INNER JOIN Cuentas c ON c.idCuenta = p.idCuenta " &
                                            "WHERE p.idCuenta = {0}", idCuenta)
        comando.CommandText = query
        lector = comando.ExecuteReader()
        dgDatosPagos.Rows.Clear()
        While lector.Read()
            dgDatosPagos.Rows.Add(lector(0), lector(1), CDate(lector(2)).ToShortDateString, lector(3),
                                  lector(4), lector(5))
        End While
        lector.Close()

    End Sub







    '--------------------TEXTCHANGED'--------------------------!
    Private Sub txtBuscarCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCuenta.TextChanged
        FillDataGridCuentas()
        clearControls()
    End Sub







    '--------------------RELLENADO DE DATAGRIDVIEWS MEDIANTE EL MÉTODO DE CELLCLICK--------------------------!
    Private Sub dgDatosCuentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDatosCuentas.CellClick
        Dim row As DataGridViewRow = dgDatosCuentas.CurrentRow

        If Not IsDBNull(row) Then
            clearControls()
            FillDataGridPagos(row.Cells(0).Value)
        End If

    End Sub

    Private Sub dgDatosPagos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDatosPagos.CellClick
        Dim row As DataGridViewRow = dgDatosPagos.CurrentRow

        If Not IsDBNull(row) Then
            clearControls()

            Dim idPago As Integer = row.Cells(0).Value
            Dim nombreCuenta As String = row.Cells(1).Value
            Dim pagoFecha As Date = CDate(row.Cells(2).Value).ToShortDateString
            Dim pagoTipo As String = row.Cells(3).Value
            Dim otros As Double = row.Cells(4).Value
            Dim total As Double = row.Cells(5).Value

            'Se rellenan los Texboxs de lo datos generales del pago.
            txtIdPago.Text = idPago
            txtPagoNombreCuenta.Text = nombreCuenta
            txtPagoFecha.Text = pagoFecha
            txtPagoTipo.Text = pagoTipo
            txtOtros.Text = Math.Round(otros, 2)
            txtTotal.Text = Math.Round(total, 2)


            If pagoTipo.Equals("PAGO SERVICIO") Then
                panelServiciosAtendidos.Visible = True
                panelPagoAgua.Visible = False

                'Esconde Textbox y etiqueta de descuento.
                lblDescuento.Visible = False
                txtDescuentoFinal.Visible = False

                'Query para rellenar los TextBoxs.
                Dim query As String = String.Format("SELECT sa.idServicio, s.descripcion, sa.precio, " &
                                                        "e.idEmpleado, e.nombre, e.domicilio, e.colonia, e.telefono " &
                                                        "FROM ServiciosAtendidos sa " &
                                                        "INNER JOIN Servicios s ON s.idServicio = sa.idServicio " &
                                                        "INNER JOIN Empleados e ON e.idEmpleado = sa.idEmpleado " &
                                                        "WHERE sa.idPago = {0}", idPago)
                comando.CommandText = query
                lector = comando.ExecuteReader()
                lector.Read()

                'Se rellenan los Textboxs con la información de la Query.-------------------

                '---Datos del servicio que se atendió.
                txtIdServicio.Text = lector(0)
                txtServicioDescripcion.Text = lector(1)
                txtServicioPrecio.Text = Math.Round(lector(2), 2)

                '---Datos del empleado que atendió el servicio.
                txtIdEmpleado.Text = lector(3)
                txtEmpleadoNombre.Text = lector(4)
                txtEmpleadoDomicilio.Text = lector(5)
                txtEmpleadoColonia.Text = lector(6)
                txtEmpleadoTelefono.Text = lector(7)

                '---Cálculo del subtotal.
                'txtSubtotal.Text = CStr(lector(2) + CDbl(Replace(txtOtros.Text, ".", ",")))
                txtSubtotal.Text = CStr(Math.Round(lector(2), 2))
                lector.Close()
            End If


            If pagoTipo.Equals("PAGO AGUA") Then
                panelServiciosAtendidos.Visible = False
                panelPagoAgua.Visible = True

                'Muestra Textbox y etiqueta de descuento.
                lblDescuento.Visible = True
                txtDescuentoFinal.Visible = True

                'Query para rellenar los TextBoxs.
                Dim query As String = String.Format("SELECT si.descripcion, si.idSituacion, si.descuento, " &
                                                            "t.idTarifa, t.anio, t.CF, t.TAR, t.recargos, t.INFRA, " &
                                                            "a.mesInicial, a.mesFinal, a.CF, a.recargos, a.TAR, a.INFRA, " &
                                                            "a.descuento, a.subtotal " &
                                                    "FROM PagosAgua a " &
                                                    "INNER JOIN Situacion si ON si.idSituacion = a.idSituacion " &
                                                    "INNER JOIN Tarifas t ON t.idTarifa = a.idTarifa " &
                                                    "WHERE a.idPago = {0}", idPago)

                comando.CommandText = query
                lector = comando.ExecuteReader()
                lector.Read()

                'Se rellenan los Textboxs con la información de la Query.-------------------

                '---Datos de la situación utilizada
                txtNombreSituacion.Text = lector(0)
                txtIdSituacion.Text = lector(1)
                txtSituacionDescuento.Text = lector(2)

                '---Datos de la tarifa anual utilizada
                txtIdTarifa.Text = Math.Round(lector(3), 2)
                txtAnioTarifa.Text = Math.Round(lector(4), 2)
                txtCuotaFija.Text = Math.Round(lector(5), 2)
                txtTAR.Text = Math.Round(lector(6), 2)
                txtRecargo.Text = Math.Round(lector(7), 2)
                txtINFRA.Text = Math.Round(lector(8), 2)

                '---Meses pagados
                txtMesInicial.Text = getMonthName(lector(9))
                txtMesFinal.Text = getMonthName(lector(10))

                '---Tarifa pagada
                txtCuotaFijaCalculada.Text = Math.Round(lector(11), 2)
                txtRecargoCalculado.Text = Math.Round(lector(12), 2)
                txtTARCalculada.Text = Math.Round(lector(13), 2)
                txtINFRACalculada.Text = Math.Round(lector(14), 2)

                'Falta descuento y subtotal
                txtDescuentoFinal.Text = Math.Round(lector(15), 2)
                txtSubtotal.Text = Math.Round(lector(16), 2)


                lector.Close()
            End If

        End If


    End Sub









    '--------------------MÉTODOS DE SALIDA DEL FORMULARIO--------------------------!
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub frmMovimientoPagosConsultaIndividual_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexionsql.Close()
        Me.Dispose()
    End Sub







    '--------------------MÉTODOS LIMPIEZA DE TEXTBOXS--------------------------!
    Private Sub clearControls()
        'Textboxs de datos generales del pago
        txtIdPago.Text = ""
        txtPagoFecha.Text = ""
        txtPagoNombreCuenta.Text = ""
        txtPagoTipo.Text = ""

        'Textboxs de datos monetarios del pago
        txtOtros.Text = ""
        txtSubtotal.Text = ""
        txtTotal.Text = ""
        txtDescuentoFinal.Text = ""


        '-------------TEXTBOXS DE PAGOS SERVICIOS------------

        'Textbox de datos del empleado
        txtIdEmpleado.Text = ""
        txtEmpleadoNombre.Text = ""
        txtEmpleadoDomicilio.Text = ""
        txtEmpleadoColonia.Text = ""
        txtEmpleadoTelefono.Text = ""

        'Textboxs de servicios
        txtIdServicio.Text = ""
        txtServicioDescripcion.Text = ""
        txtServicioPrecio.Text = ""

        '---Textboxs de Situación utilizada
        txtNombreSituacion.Text = ""
        txtIdSituacion.Text = ""
        txtSituacionDescuento.Text = ""

        '---Textboxs de la Tarifa anual utilizada
        txtIdTarifa.Text = ""
        txtAnioTarifa.Text = ""
        txtCuotaFija.Text = ""
        txtTAR.Text = ""
        txtRecargo.Text = ""
        txtINFRA.Text = ""

        '---Textboxs de los Meses pagados
        txtMesInicial.Text = ""
        txtMesFinal.Text = ""

        '---Textboxs de la Tarifa pagada
        txtCuotaFijaCalculada.Text = ""
        txtRecargoCalculado.Text = ""
        txtTARCalculada.Text = ""
        txtINFRACalculada.Text = ""


    End Sub

    '-------------------MÉTODOS DE CONTROL DE LOS MESES--------------------------!
    Private Function getMonthName(mes As Integer)

        Dim months() As String = {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO",
                                  "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE",
                                  "DICIEMBRE"}
        Dim monthsNumber() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}

        Dim x As Integer = 0
        While (x <= 11)
            If mes = monthsNumber(x) Then
                Return months(x)
            End If

            x += 1
        End While
    End Function
End Class