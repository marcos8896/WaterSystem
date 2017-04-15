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
    End Sub







    '--------------------RELLENADO DE DATAGRIDVIEWS MEDIANTE EL MÉTODO DE CELLCLICK--------------------------!
    Private Sub dgDatosCuentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDatosCuentas.CellClick
        Dim row As DataGridViewRow = dgDatosCuentas.CurrentRow

        If Not IsDBNull(row) Then
            FillDataGridPagos(row.Cells(0).Value)
        End If

    End Sub

    Private Sub dgDatosPagos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDatosPagos.CellClick
        Dim row As DataGridViewRow = dgDatosCuentas.CurrentRow

        If Not IsDBNull(row) Then
            'Dim idPago = row.Cells(0).Value
            'Dim nombreCuenta = row.Cells(1).Value
            'Dim fecha = row.Cells(2).Value
            'Dim tipo = row.Cells(3).Value
            'Dim otro = row.Cells(4).Value
            'Dim total = row.Cells(5).Value

            Dim idPago As Integer = row.Cells(0).Value
            Dim tipo As String = row.Cells(3).Value


            If tipo.Equals("PAGO SERVICIO") Then
                panelServiciosAtendidos.Visible = True
                panelPagoAgua.Visible = False

                'Query para rellenar los TextBoxs
                comando.CommandText = String.Format("SELECT sa.idServicio, s.descripcion, sa.precio, " &
                                                    "e.idEmpleado, e.nombre, e.domicilio, e.colonia, e.telefono " &
                                                    "FROM ServiciosAtendidos sa " &
                                                    "INNER JOIN Servicios s ON s.idServicio = sa.idServicio " &
                                                    "INNER JOIN Empleados e ON e.idEmpleado = sa.idEmpleado " &
                                                    "WHERE sa.idPago = {0}", idPago)

                'Se rellenan los Textboxs con la información de la Query

                '---------------------------HERE I LEFT IT jiji------------------------------

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
    'Private Sub cleanTextBoxsAndDataGrids()
    '    'Textboxs principales
    '    txtIdPago.Text = ""
    '    txtFechaSO.Text = Date.Today.Date.ToShortDateString

    '    'Textbox de cuentas
    '    txtCuentaNombre.Text = ""
    '    txtCuentaCalle.Text = ""
    '    txtIdCuenta.Text = ""
    '    txtCuentaIdCalle.Text = ""
    '    txtCuentaUltimoA.Text = ""
    '    txtCuentaUltimoM.Text = ""

    '    'Textboxs de servicios
    '    txtIdServicio.Text = ""
    '    txtServicioDescripcion.Text = ""
    '    txtServicioPrecio.Text = ""
    '    txtBuscarServicio.Text = ""

    '    'Textboxs de empleados
    '    txtIdEmpleado.Text = ""
    '    txtEmpleadoNombre.Text = ""
    '    txtBuscarEmployee.Text = ""

    '    'Textboxs de tarifas
    '    txtCuotaFijaCalculada.Text = ""
    '    txtRecargoCalculado.Text = ""
    '    txtTARCalculada.Text = ""
    '    txtINFRACalculada.Text = ""

    '    'Textboxs generales
    '    txtTotal.Text = ""
    '    txtOtros.Text = ""
    '    txtDescuentoFinal.Text = ""
    '    txtSubtotal.Text = ""

    '    'Textboxs búsquedas
    '    txtBuscarCuenta.Text = ""
    '    txtBuscarEmployee.Text = ""
    '    txtBuscarServicio.Text = ""

    '    'Limpieza de DataGrids
    '    dgServicios.Rows.Clear()
    '    dgEmpleados.Rows.Clear()
    '    dgDatosCuentas.Rows.Clear()

    '    combitoMesInicial.SelectedIndex = 0
    '    combitoMesFinal.SelectedIndex = 0

    '    labelPagoPor.Text = "Tarifas a pagar por: "

    'End Sub
End Class