Public Class frmCatalogoSituacion
    Private Sub frmCatalogoSituacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Situacion' Puede moverla o quitarla según sea necesario.
        Me.SituacionTableAdapter.Fill(Me.DataSetSistema.Situacion)
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        SituacionBindingSource.MoveFirst()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        SituacionBindingSource.MoveNext()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        SituacionBindingSource.MovePrevious()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        SituacionBindingSource.MoveLast()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        n = SituacionBindingSource.Count + 1


        SituacionBindingSource.AddNew()
        txtIdSituacion.Text = n.ToString

        txtDescripcion.Enabled = True
        txtDescuento.Enabled = True

        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnSalir.Enabled = False

        btnInicio.Enabled = False
        btnUltimo.Enabled = False
        btnAnterior.Enabled = False
        btnSiguiente.Enabled = False

        txtDescripcion.Text = ""
        txtDescuento.Text = ""

        txtDescripcion.Select()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        txtDescripcion.Enabled = False
        txtDescuento.Enabled = False

        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        btnSalir.Enabled = True
        SituacionBindingSource.Current(0) = CInt(txtIdSituacion.Text)
        SituacionBindingSource.Current(1) = txtDescripcion.Text
        SituacionBindingSource.Current(2) = CDbl(txtDescuento.Text)

        txtDescripcion.Text = ""
        txtDescuento.Text = ""

        dgSituacion.Refresh()

        btnInicio.Enabled = True
        btnUltimo.Enabled = True
        btnAnterior.Enabled = True
        btnSiguiente.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        SituacionBindingSource.EndEdit()
        Me.SituacionTableAdapter.Update(Me.DataSetSistema.Situacion)
        Me.Dispose()
    End Sub

    Private Sub asignarValoresTextBoxs()
        If SituacionBindingSource.Count <> 0 Then
            txtIdSituacion.Text = SituacionBindingSource.Current(0)
            txtDescripcion.Text = SituacionBindingSource.Current(1)
            txtDescuento.Text = SituacionBindingSource.Current(2)
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        caracteresValidos(sender, e, "LETTERS")
    End Sub

    Private Sub txtDescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescuento.KeyPress
        caracteresValidos(sender, e, "NUMBERS")
    End Sub
End Class