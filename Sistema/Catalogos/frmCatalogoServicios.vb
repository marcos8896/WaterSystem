Public Class frmCatalogoServicios
    Private Sub frmCatalogoServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.DataSetSistema.Servicios)
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        ServiciosBindingSource.MoveFirst()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        ServiciosBindingSource.MoveNext()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        ServiciosBindingSource.MovePrevious()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        ServiciosBindingSource.MoveLast()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        n = ServiciosBindingSource.Count + 1


        ServiciosBindingSource.AddNew()
        txtIdServicio.Text = n.ToString

        txtDescripcion.Enabled = True
        txtPrecio.Enabled = True

        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnSalir.Enabled = False

        btnInicio.Enabled = False
        btnUltimo.Enabled = False
        btnAnterior.Enabled = False
        btnSiguiente.Enabled = False

        txtDescripcion.Text = ""
        txtPrecio.Text = ""

        txtDescripcion.Select()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        txtDescripcion.Enabled = False
        txtPrecio.Enabled = False

        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        btnSalir.Enabled = True
        ServiciosBindingSource.Current(0) = CInt(txtIdServicio.Text)
        ServiciosBindingSource.Current(1) = txtDescripcion.Text
        ServiciosBindingSource.Current(2) = CDbl(txtPrecio.Text)

        txtDescripcion.Text = ""
        txtPrecio.Text = ""

        dgServicios.Refresh()

        btnInicio.Enabled = True
        btnUltimo.Enabled = True
        btnAnterior.Enabled = True
        btnSiguiente.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ServiciosBindingSource.EndEdit()
        Me.ServiciosTableAdapter.Update(Me.DataSetSistema.Servicios)
        Me.Dispose()
    End Sub

    Private Sub asignarValoresTextBoxs()
        If ServiciosBindingSource.Count <> 0 Then
            txtIdServicio.Text = ServiciosBindingSource.Current(0)
            txtDescripcion.Text = ServiciosBindingSource.Current(1)
            txtPrecio.Text = ServiciosBindingSource.Current(2)
        End If
    End Sub

End Class