Public Class frmCatalogoPozos
    Private Sub frmCatalogoPozos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Pozos' Puede moverla o quitarla según sea necesario.
        Me.PozosTableAdapter.Fill(Me.DataSetSistema.Pozos)
        asignarValoresTextBoxs()

    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        PozosBindingSource.MoveFirst()
        asignarValoresTextBoxs()

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        PozosBindingSource.MoveNext()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        PozosBindingSource.MovePrevious()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        PozosBindingSource.MoveLast()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        n = PozosBindingSource.Count + 1


        PozosBindingSource.AddNew()
        txtIdPozo.Text = n.ToString

        txtUbicacion.Enabled = True

        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnSalir.Enabled = False

        btnInicio.Enabled = False
        btnUltimo.Enabled = False
        btnAnterior.Enabled = False
        btnSiguiente.Enabled = False

        txtUbicacion.Text = ""
        txtUbicacion.Select()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        txtUbicacion.Enabled = False
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        btnSalir.Enabled = True
        PozosBindingSource.Current(0) = CInt(txtIdPozo.Text)
        PozosBindingSource.Current(1) = txtUbicacion.Text
        txtUbicacion.Text = ""
        dgPozos.Refresh()

        btnInicio.Enabled = True
        btnUltimo.Enabled = True
        btnAnterior.Enabled = True
        btnSiguiente.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        PozosBindingSource.EndEdit()
        Me.PozosTableAdapter.Update(Me.DataSetSistema.Pozos)
        Me.Dispose()
    End Sub

    Private Sub asignarValoresTextBoxs()
        If PozosBindingSource.Count <> 0 Then
            txtIdPozo.Text = PozosBindingSource.Current(0)
            txtUbicacion.Text = PozosBindingSource.Current(1)
        End If
    End Sub
End Class