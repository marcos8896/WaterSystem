Public Class frmCatalogoCuentas
    Private Sub frmCatalogoCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Cuentas' Puede moverla o quitarla según sea necesario.
        Me.CuentasTableAdapter.Fill(Me.DataSetSistema.Cuentas)
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Calles' Puede moverla o quitarla según sea necesario.
        Me.CallesTableAdapter.Fill(Me.DataSetSistema.Calles)
        asignarValoresTextBoxs()

    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        CuentasBindingSource.MoveFirst()
        asignarValoresTextBoxs()

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        CuentasBindingSource.MoveNext()
        asignarValoresTextBoxs()

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        CuentasBindingSource.MovePrevious()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        CuentasBindingSource.MoveLast()
        asignarValoresTextBoxs()
    End Sub

    Private Sub asignarValoresTextBoxs()
        If CuentasBindingSource.Count <> 0 Then
            txtIdCuenta.Text = CuentasBindingSource.Current(0)
            txtNombre.Text = CuentasBindingSource.Current(2)
            txtNoExterior.Text = CuentasBindingSource.Current(3)
            txtNoInterior.Text = CuentasBindingSource.Current(4)
            mcCuentas.SetDate(CuentasBindingSource.Current(5))
            cbCalle.SelectedIndex = (CuentasBindingSource.Current(1) - 1)
            'coloniaAndCP(cbCalle.SelectedValue)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        n = CuentasBindingSource.Count + 1


        CuentasBindingSource.AddNew()
        txtIdCuenta.Text = n.ToString

        txtNombre.Enabled = True
        txtNoInterior.Enabled = True
        txtNoExterior.Enabled = True
        cbCalle.Enabled = True
        mcCuentas.Enabled = True

        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnSalir.Enabled = False

        btnInicio.Enabled = False
        btnUltimo.Enabled = False
        btnAnterior.Enabled = False
        btnSiguiente.Enabled = False

        txtNombre.Text = ""
        txtNoInterior.Text = ""
        txtNoExterior.Text = ""
        txtColonia.Text = ""
        txtCP.Text = ""
        mcCuentas.SetDate(Date.Today.Date)
        cbCalle.SelectedIndex = 0

        txtNombre.Select()

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        txtNombre.Enabled = False
        txtNoInterior.Enabled = False
        txtNoExterior.Enabled = False
        cbCalle.Enabled = False
        mcCuentas.Enabled = False

        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        btnSalir.Enabled = True

        CuentasBindingSource.Current(0) = CInt(txtIdCuenta.Text)
        CuentasBindingSource.Current(1) = CInt(cbCalle.SelectedValue)

        'Actualización del campo totalCasas de tabla Calles
        actualizarTotalCasas(cbCalle.SelectedValue)
        '--------------------------------------------------------------------

        CuentasBindingSource.Current(2) = txtNombre.Text
        CuentasBindingSource.Current(3) = txtNoExterior.Text
        CuentasBindingSource.Current(4) = txtNoInterior.Text
        CuentasBindingSource.Current(5) = mcCuentas.SelectionStart.Date
        CuentasBindingSource.Current(6) = "0"
        CuentasBindingSource.Current(7) = "0"


        txtNombre.Text = ""
        txtNoInterior.Text = ""
        txtNoExterior.Text = ""
        txtColonia.Text = ""
        txtCP.Text = ""

        dgCuentas.Refresh()

        btnInicio.Enabled = True
        btnUltimo.Enabled = True
        btnAnterior.Enabled = True
        btnSiguiente.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        CuentasBindingSource.EndEdit()
        Me.CuentasTableAdapter.Update(Me.DataSetSistema.Cuentas)

        CallesBindingSource.EndEdit()
        Me.CallesTableAdapter.Update(Me.DataSetSistema.Calles)

        Me.Dispose()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        caracteresValidos(sender, e, "ALL")
    End Sub

    Private Sub txtNoExterior_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoExterior.KeyPress
        caracteresValidos(sender, e, "ALL")
    End Sub

    Private Sub txtNoInterior_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoInterior.KeyPress
        caracteresValidos(sender, e, "ALL")
    End Sub

    Private Sub actualizarTotalCasas(idCalle As Integer)
        Dim pos As Integer = CallesBindingSource.Find("idCalle", idCalle)
        CallesBindingSource.Position = pos
        CallesBindingSource.Current(4) = CallesBindingSource.Current(4) + 1

        'CallesBindingSource.MoveFirst()
        'For x = 0 To CallesBindingSource.Count
        '    If CallesBindingSource.Current(0) = cbCalle.SelectedValue Then
        '        CallesBindingSource.Current(4) = CallesBindingSource.Current(4) + 1
        '    End If
        '    CallesBindingSource.MoveNext()
        'Next
    End Sub

    'Public Sub coloniaAndCP(idCalle As Integer)
    '    Dim pos As Integer = CallesBindingSource.Find("idCalle", idCalle)
    '    CallesBindingSource.Position = pos
    '    txtColonia.Text = CallesBindingSource.Current(2)
    '    txtCP.Text = CallesBindingSource.Current(3)
    'End Sub

    'Private Sub cbCalle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCalle.SelectedIndexChanged
    '    coloniaAndCP(cbCalle.SelectedValue)
    'End Sub
End Class