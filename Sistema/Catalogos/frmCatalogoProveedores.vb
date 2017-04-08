Public Class frmCatalogoProveedores
    Private Sub frmCatalogoProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.DataSetSistema.Proveedores)
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        ProveedoresBindingSource.MoveFirst()
        asignarValoresTextBoxs()

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        ProveedoresBindingSource.MoveNext()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        ProveedoresBindingSource.MovePrevious()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        ProveedoresBindingSource.MoveLast()
        asignarValoresTextBoxs()
    End Sub

    Private Sub asignarValoresTextBoxs()
        If ProveedoresBindingSource.Count <> 0 Then
            txtIdProveedor.Text = ProveedoresBindingSource.Current(0)
            txtNombre.Text = ProveedoresBindingSource.Current(1)
            txtDomicilio.Text = ProveedoresBindingSource.Current(2)
            txtColonia.Text = ProveedoresBindingSource.Current(3)
            txtCiudad.Text = ProveedoresBindingSource.Current(4)
            txtEstado.Text = ProveedoresBindingSource.Current(5)
            txtCP.Text = ProveedoresBindingSource.Current(6)
            txtTelefono.Text = ProveedoresBindingSource.Current(7)
            txtEmail.Text = ProveedoresBindingSource.Current(8)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        n = ProveedoresBindingSource.Count + 1

        ProveedoresBindingSource.MoveLast()
        ProveedoresBindingSource.AddNew()
        txtIdProveedor.Text = n.ToString

        txtNombre.Enabled = True
        txtDomicilio.Enabled = True
        txtColonia.Enabled = True
        txtCiudad.Enabled = True
        txtEstado.Enabled = True
        txtCP.Enabled = True
        txtTelefono.Enabled = True
        txtEmail.Enabled = True

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
        txtCiudad.Text = ""
        txtEstado.Text = ""
        txtCP.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""

        txtNombre.Select()

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        txtNombre.Enabled = False
        txtDomicilio.Enabled = False
        txtColonia.Enabled = False
        txtCiudad.Enabled = False
        txtEstado.Enabled = False
        txtCP.Enabled = False
        txtTelefono.Enabled = False
        txtEmail.Enabled = False

        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        btnSalir.Enabled = True

        ProveedoresBindingSource.Current(0) = CInt(txtIdProveedor.Text)
        ProveedoresBindingSource.Current(1) = txtNombre.Text
        ProveedoresBindingSource.Current(2) = txtDomicilio.Text
        ProveedoresBindingSource.Current(3) = txtColonia.Text
        ProveedoresBindingSource.Current(4) = txtCiudad.Text
        ProveedoresBindingSource.Current(5) = txtEstado.Text
        ProveedoresBindingSource.Current(6) = txtCP.Text
        ProveedoresBindingSource.Current(7) = txtTelefono.Text
        ProveedoresBindingSource.Current(8) = txtEmail.Text


        txtNombre.Text = ""
        txtDomicilio.Text = ""
        txtColonia.Text = ""
        txtCiudad.Text = ""
        txtEstado.Text = ""
        txtCP.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""

        dgProveedores.Refresh()

        btnInicio.Enabled = True
        btnUltimo.Enabled = True
        btnAnterior.Enabled = True
        btnSiguiente.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ProveedoresBindingSource.EndEdit()
        Me.ProveedoresTableAdapter.Update(Me.DataSetSistema.Proveedores)
        Me.Dispose()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        caracteresValidos(sender, e, "ALL")
    End Sub

    Private Sub txtDomicilio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDomicilio.KeyPress
        caracteresValidos(sender, e, "ALL")
    End Sub

    Private Sub txtColonia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColonia.KeyPress
        caracteresValidos(sender, e, "ALL")
    End Sub

    Private Sub txtCiudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCiudad.KeyPress
        caracteresValidos(sender, e, "ALL")
    End Sub

    Private Sub txtEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstado.KeyPress
        caracteresValidos(sender, e, "LETTERS_ONLY")
    End Sub

    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        caracteresValidos(sender, e, "NUMBERS_NO_DOT")
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        caracteresValidos(sender, e, "NUMBERS_NO_DOT")
    End Sub
End Class