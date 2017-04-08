Public Class frmCatalogoEmpleados
    Private Sub frmCatalogoEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.DataSetSistema.Empleados)
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        EmpleadosBindingSource.MoveFirst()
        asignarValoresTextBoxs()

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        EmpleadosBindingSource.MoveNext()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        EmpleadosBindingSource.MovePrevious()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        EmpleadosBindingSource.MoveLast()
        asignarValoresTextBoxs()
    End Sub

    Private Sub asignarValoresTextBoxs()
        If EmpleadosBindingSource.Count <> 0 Then
            txtNombre.Text = EmpleadosBindingSource.Current(1)
            txtDomicilio.Text = EmpleadosBindingSource.Current(2)
            txtColonia.Text = EmpleadosBindingSource.Current(3)
            txtTelefono.Text = EmpleadosBindingSource.Current(5)
            txtCelular.Text = EmpleadosBindingSource.Current(6)
            txtCP.Text = EmpleadosBindingSource.Current(4)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        n = EmpleadosBindingSource.Count + 1


        EmpleadosBindingSource.AddNew()
        txtIdEmpleado.Text = n.ToString

        txtNombre.Enabled = True
        txtDomicilio.Enabled = True
        txtColonia.Enabled = True
        txtTelefono.Enabled = True
        txtCelular.Enabled = True
        txtCP.Enabled = True

        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnSalir.Enabled = False

        btnInicio.Enabled = False
        btnUltimo.Enabled = False
        btnAnterior.Enabled = False
        btnSiguiente.Enabled = False

        txtNombre.Text = ""
        txtDomicilio.Text = ""
        txtColonia.Text = ""
        txtTelefono.Text = ""
        txtCelular.Text = ""
        txtCP.Text = ""

        txtNombre.Select()

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        txtNombre.Enabled = False
        txtDomicilio.Enabled = False
        txtColonia.Enabled = False
        txtTelefono.Enabled = False
        txtCelular.Enabled = False
        txtCP.Enabled = False

        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        btnSalir.Enabled = True

        EmpleadosBindingSource.Current(0) = CInt(txtIdEmpleado.Text)
        EmpleadosBindingSource.Current(1) = txtNombre.Text
        EmpleadosBindingSource.Current(2) = txtDomicilio.Text
        EmpleadosBindingSource.Current(3) = txtColonia.Text
        EmpleadosBindingSource.Current(4) = txtCP.Text
        EmpleadosBindingSource.Current(5) = txtTelefono.Text
        EmpleadosBindingSource.Current(6) = txtCelular.Text


        txtNombre.Text = ""
        txtDomicilio.Text = ""
        txtColonia.Text = ""
        txtTelefono.Text = ""
        txtCelular.Text = ""
        txtCP.Text = ""

        dgEmpleados.Refresh()

        btnInicio.Enabled = True
        btnUltimo.Enabled = True
        btnAnterior.Enabled = True
        btnSiguiente.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        EmpleadosBindingSource.EndEdit()
        Me.EmpleadosTableAdapter.Update(Me.DataSetSistema.Empleados)
        Me.Dispose()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        caracteresValidos(sender, e, "LETTERS")
    End Sub

    Private Sub txtDomicilio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDomicilio.KeyPress
        caracteresValidos(sender, e, "ALL")
    End Sub

    Private Sub txtColonia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColonia.KeyPress
        caracteresValidos(sender, e, "ALL")
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        caracteresValidos(sender, e, "NUMBERS_NO_DOT")
    End Sub

    Private Sub txtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCelular.KeyPress
        caracteresValidos(sender, e, "NUMBERS_NO_DOT")
    End Sub

    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        caracteresValidos(sender, e, "NUMBERS_NO_DOT")
    End Sub


End Class