Public Class frmCatalogoMateriales
    Private Sub frmCatalogoMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Materiales' Puede moverla o quitarla según sea necesario.
        Me.MaterialesTableAdapter.Fill(Me.DataSetSistema.Materiales)
        cbUnidad.SelectedIndex = 0

    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        MaterialesBindingSource.MoveFirst()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        MaterialesBindingSource.MoveNext()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        MaterialesBindingSource.MovePrevious()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        MaterialesBindingSource.MoveLast()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        n = MaterialesBindingSource.Count + 1


        MaterialesBindingSource.AddNew()
        txtIdMaterial.Text = n.ToString

        txtDescripcion.Enabled = True
        txtExistencia.Enabled = True
        cbUnidad.Enabled = True
        txtMaximos.Enabled = True
        txtMinimos.Enabled = True
        txtMaximos.Enabled = True
        txtCosto.Enabled = True
        mcFecha.Enabled = True

        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnSalir.Enabled = False
        cbUnidad.SelectedIndex = 0

        btnInicio.Enabled = False
        btnUltimo.Enabled = False
        btnAnterior.Enabled = False
        btnSiguiente.Enabled = False

        txtDescripcion.Select()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        txtDescripcion.Enabled = False
        txtExistencia.Enabled = False
        cbUnidad.Enabled = False
        txtMaximos.Enabled = False
        txtMinimos.Enabled = False
        txtMaximos.Enabled = False
        txtCosto.Enabled = False
        mcFecha.Enabled = False

        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        btnSalir.Enabled = True
        dgMaterial.Refresh()

        btnInicio.Enabled = True
        btnUltimo.Enabled = True
        btnAnterior.Enabled = True
        btnSiguiente.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        MaterialesBindingSource.EndEdit()
        Me.MaterialesTableAdapter.Update(Me.DataSetSistema.Materiales)
        Me.Dispose()
    End Sub
End Class