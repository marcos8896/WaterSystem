Imports System.Data.SqlClient

Public Class frmMovimientoGastosRealizados

    '--------------------DECLARACIÓN DE VARIABLES GLOBALES DE LA CLASE--------------------------!
    Dim conexionsql As New SqlConnection("Data Source='MARCOS-LAPTOP\PLEASEWORK'; Initial Catalog='db_agua_potable'; Integrated security=true")
    Dim comando As SqlCommand = conexionsql.CreateCommand()
    Dim lector As SqlDataReader

    '--------------------MÉTODO LOAD--------------------------!
    Private Sub frmMovimientoServiciosAtendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
        FillcbEmpleado(cbEmpleado) 'Llena el ComboBox de Empleados
        FillcbConcepto(cbConceptoGasto) 'Llena el ComboBox de Gastos

        FillDataGrid(querys("all", Nothing))

        rbTodos.Select()
        btnNuevo.Select()
    End Sub

    '--------------------LLENADO DE LA REJILLA--------------------------!
    Private Sub FillDataGrid(query As String)
        comando.CommandText = query
        lector = comando.ExecuteReader()
        dgGastosRealizados.Rows.Clear()
        While lector.Read()
            dgGastosRealizados.Rows.Add(lector(0), CDate(lector(1)).ToShortDateString, lector(2), lector(3), lector(4), lector(5), lector(6))
        End While
        lector.Close()

    End Sub

    '--------------------MÉTODO ENCARGADO DE LAS DISTINTAS CONSULTAS DE LA REJILLA--------------------------!
    Private Function querys(aux As String, wildcard As Object) As String

        Dim q As String = "Select gr.idGastoR, gr.fecha, e.idEmpleado, e.Nombre, g.concepto, gr.importe, gr.observaciones " &
                       "FROM GastosRealizados gr INNER JOIN Gastos g On g.idGasto = gr.idGasto " &
                       "INNER JOIN Empleados e On e.idEmpleado = gr.idEmpleado "

        Select Case aux


            Case "all"
                Return q

            Case "date"
                Return String.Format(q & "WHERE gr.fecha = '{0}'", CDate(wildcard).ToShortDateString)

            Case "employee"
                Return String.Format(q & "WHERE e.Nombre = '{0}'", CStr(wildcard))

            Case "concept"

                Return String.Format(q & "WHERE g.concepto = '{0}'", CStr(wildcard))

        End Select

    End Function

    '----------------------------BOTONES DE ACCIÓN DEL FORMULARIO---------------------------------!
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If rbTodos.Checked Then
            FillDataGrid(querys("all", Nothing))
        End If

        If rbFecha.Checked Then
            FillDataGrid(querys("date", dtpConsultaFecha.Value.Date))
        End If

        If rbEmpleado.Checked Then
            FillDataGrid(querys("employee", cbOrden.Text))
        End If

        If rbConcepto.Checked Then
            FillDataGrid(querys("concept", cbOrden.Text))
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        comando.CommandText = "SELECT COUNT(*) FROM GastosRealizados"
        Dim n As Integer
        n = comando.ExecuteScalar() + 1

        txtIdGastoR.Text = n.ToString

        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnSalir.Enabled = False

        txtImporte.ReadOnly = False
        txtObservaciones.ReadOnly = False

        cbConceptoGasto.Enabled = True
        cbEmpleado.Enabled = True

        dtpFecha.Enabled = True

        panelBusqueda.Enabled = False
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

        If Not txtImporte.Text.Equals("") Then

            'Columnas de la tabla de GastosRealizados
            Dim idGastoR As Integer = CInt(txtIdGastoR.Text)
            Dim idGasto As Integer = CInt(txtIdGasto.Text)
            Dim idEmpleado As Integer = CInt(txtIdEmpleado.Text)
            Dim fecha As Date = dtpFecha.Value.Date
            Dim importe As Double = CDbl(txtImporte.Text)
            Dim observaciones As String = txtObservaciones.Text

            comando.CommandText = String.Format _
            ("INSERT INTO GastosRealizados (idGastoR, idGasto, idEmpleado, fecha, importe, observaciones) VALUES ({0},{1},'{2}','{3}','{4}','{5}')",
            idGastoR, idGasto, idEmpleado, CDate(fecha).ToShortDateString, importe, observaciones)

            comando.ExecuteNonQuery()

            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnSalir.Enabled = True

            txtImporte.ReadOnly = True
            txtObservaciones.ReadOnly = True

            cbEmpleado.Enabled = False
            cbConceptoGasto.Enabled = False
            dtpFecha.Enabled = False

            FillDataGrid(querys("all", Nothing))
            rbTodos.Select()

            'Se limpian los controles
            txtImporte.Text = ""
            txtObservaciones.Text = ""
            dtpFecha.Value = Date.Today

            panelBusqueda.Enabled = True
        Else
            MessageBox.Show("No se permiten campos vacíos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtImporte.Select()
        End If

    End Sub

    '--------------------EVENTOS CLICK DE RADIOBUTTONS--------------------------!
    Private Sub rbFecha_Click(sender As Object, e As EventArgs) Handles rbFecha.Click
        dtpConsultaFecha.Visible = True
        cbOrden.Visible = False

    End Sub

    Private Sub rbConcepto_Click(sender As Object, e As EventArgs) Handles rbConcepto.Click
        dtpConsultaFecha.Visible = False
        cbOrden.Visible = True

        FillcbConcepto(cbOrden)
    End Sub

    Private Sub rbEmpleado_Click(sender As Object, e As EventArgs) Handles rbEmpleado.Click
        dtpConsultaFecha.Visible = False
        cbOrden.Visible = True

        FillcbEmpleado(cbOrden)
    End Sub

    Private Sub rbTodos_Click(sender As Object, e As EventArgs) Handles rbTodos.Click
        dtpConsultaFecha.Visible = False
        cbOrden.Visible = False
    End Sub

    '--------------------LLENADO DE COMBOS--------------------------!
    Private Sub FillcbEmpleado(combo As ComboBox)
        combo.Items.Clear()
        comando.CommandText = "SELECT * FROM Empleados"

        lector = comando.ExecuteReader()
        While lector.Read()
            combo.Items.Add(lector(1))
        End While
        lector.Close()

        combo.SelectedIndex = 0
    End Sub

    Private Sub FillcbConcepto(combo As ComboBox)
        combo.Items.Clear()
        comando = New SqlCommand("SELECT * FROM Gastos", conexionsql)

        lector = comando.ExecuteReader()
        While lector.Read()
            combo.Items.Add(lector(1))
        End While
        lector.Close()

        combo.SelectedIndex = 0
    End Sub

    '--------------------BÚSQUEDAS DE LOS TEXTBOXS RELACIONADOS A LAS COMBOBOXS--------------------------!
    Private Sub cbConceptoGasto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbConceptoGasto.SelectedIndexChanged
        comando.CommandText = String.Format("SELECT * FROM Gastos WHERE concepto='{0}'", cbConceptoGasto.Text)
        lector = comando.ExecuteReader()
        lector.Read()

        txtIdGasto.Text = lector(0)

        lector.Close()
    End Sub

    Private Sub cbEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpleado.SelectedIndexChanged
        comando.CommandText = String.Format("SELECT idEmpleado, domicilio, telefono FROM Empleados WHERE nombre='{0}'", cbEmpleado.Text)

        lector = comando.ExecuteReader()
        lector.Read()

        txtIdEmpleado.Text = lector(0)
        txtDomicilio.Text = lector(1)
        txtTelefono.Text = lector(2)

        lector.Close()
    End Sub

    '--------------------MÉTODOS DE SALIDA DEL FORMULARIO--------------------------!
    Private Sub frmMovimientoGastosRealizados_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    '--------------------VALIDACIÓN DE TEXTBOXS--------------------------!
    Private Sub txtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporte.KeyPress
        caracteresValidos(sender, e, "NUMBERS")
    End Sub
End Class