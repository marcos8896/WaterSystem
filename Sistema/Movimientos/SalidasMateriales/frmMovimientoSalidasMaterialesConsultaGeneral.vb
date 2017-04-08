Imports System.Data.SqlClient

Public Class frmMovimientoSalidasMaterialesConsultaGeneral
    '--------------------DECLARACIÓN DE VARIABLES GLOBALES DE LA CLASE--------------------------!
    Dim conexionsql As New SqlConnection("Data Source='MARCOS-LAPTOP\PLEASEWORK'; Initial Catalog='db_agua_potable'; Integrated security=true")
    Dim comando As SqlCommand = conexionsql.CreateCommand()
    Dim lector As SqlDataReader

    '--------------------MÉTODO LOAD--------------------------!
    Private Sub frmMovimientoSalidasMaterialesConsultaGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
        FillDataGrid(querys("all"))

        rbTodos.Select()
    End Sub

    '----------------------------BOTONES DE ACCIÓN DEL FORMULARIO---------------------------------!
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If rbTodos.Checked Then
            FillDataGrid(querys("all"))
        End If

        If rbFecha.Checked Then
            FillDataGrid(querys("date"))
        End If

        If rbEmpleado.Checked Then
            FillDataGrid(querys("employee"))
        End If

        If rbCalle.Checked Then
            FillDataGrid(querys("street"))
        End If
    End Sub

    '--------------------MÉTODO ENCARGADO DE LAS DISTINTAS CONSULTAS DE LA REJILLA--------------------------!
    Private Function querys(aux As String) As String

        Dim q As String = "SELECT sm.idSalida, e.idEmpleado, e.nombre, c.idCalle, c.nombre, sm.concepto, sm.fecha " &
                          "FROM SalidasMateriales sm " &
                          "INNER JOIN Empleados e ON sm.idEmpleado = e.idEmpleado " &
                          "INNER JOIN Calles c ON sm.idCalle = c.idCalle "

        Select Case aux


            Case "all"
                Return q

            Case "date"
                Return String.Format(q & "WHERE sm.fecha BETWEEN '{0}' AND '{1}'",
                                     dtpConsultaFechaInicio.Value.Date.ToShortDateString,
                                     dtpConsultaFechaFinal.Value.Date.ToShortDateString)

            Case "employee"
                Return String.Format(q & "WHERE e.nombre = '{0}'", cbOrden.Text)

            Case "street"
                Return String.Format(q & "WHERE c.nombre = '{0}'", cbOrden.Text)

        End Select

    End Function

    '--------------------LLENADO DE LA REJILLA--------------------------!
    Private Sub FillDataGrid(query As String)
        comando.CommandText = query
        lector = comando.ExecuteReader()
        dgComprasMaterialesConsultaGeneral.Rows.Clear()
        While lector.Read()
            dgComprasMaterialesConsultaGeneral.Rows.Add(lector(0), lector(1), lector(2), lector(3),
                                                        lector(4), lector(5), CDate(lector(6)).ToShortDateString)
        End While
        lector.Close()

    End Sub

    '--------------------EVENTOS CLICK DE RADIOBUTTONS--------------------------!
    Private Sub rbFecha_Click(sender As Object, e As EventArgs) Handles rbFecha.Click
        dtpConsultaFechaInicio.Visible = True
        dtpConsultaFechaFinal.Visible = True
        cbOrden.Visible = False

    End Sub

    Private Sub rbEmpleado_Click(sender As Object, e As EventArgs) Handles rbEmpleado.Click
        dtpConsultaFechaInicio.Visible = False
        dtpConsultaFechaFinal.Visible = False

        cbOrden.Visible = True

        FillcbEmpleado(cbOrden)
    End Sub

    Private Sub rbTodos_Click(sender As Object, e As EventArgs) Handles rbTodos.Click
        dtpConsultaFechaInicio.Visible = False
        dtpConsultaFechaFinal.Visible = False

        cbOrden.Visible = False
    End Sub

    Private Sub rbCalle_Click(sender As Object, e As EventArgs) Handles rbCalle.Click
        dtpConsultaFechaInicio.Visible = False
        dtpConsultaFechaFinal.Visible = False

        cbOrden.Visible = True

        FillcbCalle(cbOrden)
    End Sub

    Private Sub frmMovimientoSalidasMaterialesConsultaGeneral_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexionsql.Close()
        Me.Dispose()
    End Sub

    '--------------------LLENADO DE COMBO--------------------------!
    Private Sub FillcbEmpleado(combo As ComboBox)
        combo.Items.Clear()
        comando.CommandText = "SELECT nombre FROM Empleados"

        lector = comando.ExecuteReader()
        While lector.Read()
            combo.Items.Add(lector(0))
        End While
        lector.Close()

        combo.SelectedIndex = 0
    End Sub

    Private Sub FillcbCalle(combo As ComboBox)
        combo.Items.Clear()
        comando.CommandText = "SELECT nombre FROM Calles"

        lector = comando.ExecuteReader()
        While lector.Read()
            combo.Items.Add(lector(0))
        End While
        lector.Close()

        combo.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

End Class