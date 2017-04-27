Imports System.Data.SqlClient

Public Class frmMovimientoComprasMaterialesConsultaGeneral
    '--------------------DECLARACIÓN DE VARIABLES GLOBALES DE LA CLASE--------------------------!
    Dim conexionsql As New SqlConnection(stringConnection())
    Dim comando As SqlCommand = conexionsql.CreateCommand()
    Dim lector As SqlDataReader

    '--------------------MÉTODO LOAD--------------------------!
    Private Sub frmMovimientoComprasMaterialesConsultaGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
        FillDataGrid(querys("all", Nothing))

        rbTodos.Select()

    End Sub

    '----------------------------BOTONES DE ACCIÓN DEL FORMULARIO---------------------------------!
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If rbTodos.Checked Then
            FillDataGrid(querys("all", Nothing))
        End If

        If rbFecha.Checked Then
            FillDataGrid(querys("date", dtpConsultaFecha.Value.Date))
        End If

        If rbProveedor.Checked Then
            FillDataGrid(querys("provider", cbOrden.Text))
        End If
    End Sub

    '--------------------MÉTODO ENCARGADO DE LAS DISTINTAS CONSULTAS DE LA REJILLA--------------------------!
    Private Function querys(aux As String, wildcard As Object) As String

        Dim q As String = "SELECT cm.idOrden, p.idProveedor, p.nombre, cm.factura, cm.fecha, " &
                          "cm.subtotal, cm.iva, cm.total From ComprasMateriales cm " &
                          "INNER JOIN Proveedores p ON p.idProveedor = cm.idProveedor "

        Select Case aux


            Case "all"
                Return q

            Case "date"
                Return String.Format(q & "WHERE cm.fecha = '{0}'", CDate(wildcard).ToShortDateString)

            Case "provider"
                Return String.Format(q & "WHERE p.nombre = '{0}'", CStr(wildcard))

        End Select

    End Function

    '--------------------LLENADO DE LA REJILLA--------------------------!
    Private Sub FillDataGrid(query As String)
        comando.CommandText = query
        lector = comando.ExecuteReader()
        dgComprasMaterialesConsultaGeneral.Rows.Clear()
        While lector.Read()
            dgComprasMaterialesConsultaGeneral.Rows.Add(lector(0), lector(1), lector(2), lector(3),
                                                        CDate(lector(4)).ToShortDateString,
                                                        Math.Round(lector(5), 2),
                                                        Math.Round(lector(6), 2),
                                                        Math.Round(lector(7), 2))
        End While
        lector.Close()

    End Sub

    '--------------------EVENTOS CLICK DE RADIOBUTTONS--------------------------!
    Private Sub rbFecha_Click(sender As Object, e As EventArgs) Handles rbFecha.Click
        dtpConsultaFecha.Visible = True
        cbOrden.Visible = False

    End Sub

    Private Sub rbProveedor_Click(sender As Object, e As EventArgs) Handles rbProveedor.Click
        dtpConsultaFecha.Visible = False
        cbOrden.Visible = True

        FillcbProveedor(cbOrden)
    End Sub

    Private Sub rbTodos_Click(sender As Object, e As EventArgs) Handles rbTodos.Click
        dtpConsultaFecha.Visible = False
        cbOrden.Visible = False
    End Sub

    Private Sub frmMovimientoComprasMaterialesConsultaGeneral_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexionsql.Close()
        Me.Dispose()
    End Sub

    '--------------------LLENADO DE COMBO--------------------------!
    Private Sub FillcbProveedor(combo As ComboBox)
        combo.Items.Clear()
        comando.CommandText = "SELECT nombre FROM Proveedores"

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