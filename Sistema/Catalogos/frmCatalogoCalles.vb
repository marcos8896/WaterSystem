Public Class frmCatalogoCalles
    Private Sub frmCatalogoCalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Calles' Puede moverla o quitarla según sea necesario.
        Me.CallesTableAdapter.Fill(Me.DataSetSistema.Calles)

    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        CallesBindingSource.MoveFirst()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        CallesBindingSource.MoveNext()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        CallesBindingSource.MovePrevious()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        CallesBindingSource.MoveLast()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        n = CallesBindingSource.Count + 1


        CallesBindingSource.AddNew()
        txtIdCalle.Text = n.ToString

        txtNombre.Enabled = True
        txtColonia.Enabled = True
        txtCP.Enabled = True

        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnSalir.Enabled = False

        btnInicio.Enabled = False
        btnUltimo.Enabled = False
        btnAnterior.Enabled = False
        btnSiguiente.Enabled = False

        txtNombre.Select()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        txtNombre.Enabled = False
        txtColonia.Enabled = False
        txtCP.Enabled = False

        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        btnSalir.Enabled = True
        CallesBindingSource.Current(4) = 0
        dgCalles.Refresh()

        btnInicio.Enabled = True
        btnUltimo.Enabled = True
        btnAnterior.Enabled = True
        btnSiguiente.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        CallesBindingSource.EndEdit()
        Me.CallesTableAdapter.Update(Me.DataSetSistema.Calles)
        Me.Dispose()
    End Sub

    Private Sub txtColonia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColonia.KeyPress
        caracteresValidos(sender, e, "ALL")
    End Sub

    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        caracteresValidos(sender, e, "NUMBERS_NO_DOT")
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        caracteresValidos(sender, e, "ALL")
    End Sub
End Class