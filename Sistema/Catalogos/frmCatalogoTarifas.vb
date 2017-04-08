Public Class frmCatalogoTarifas
    Private Sub frmCatalogoTarifas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Tarifas' Puede moverla o quitarla según sea necesario.
        Me.TarifasTableAdapter.Fill(Me.DataSetSistema.Tarifas)
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        TarifasBindingSource.MoveFirst()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        TarifasBindingSource.MoveNext()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        TarifasBindingSource.MovePrevious()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        TarifasBindingSource.MoveLast()
        asignarValoresTextBoxs()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        n = TarifasBindingSource.Count + 1


        TarifasBindingSource.AddNew()
        txtIdTarifa.Text = n.ToString

        txtRecargos.Enabled = True
        txtCF.Enabled = True
        txtINFRA.Enabled = True
        txtTAR.Enabled = True
        txtAnio.Enabled = True

        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnSalir.Enabled = False

        btnInicio.Enabled = False
        btnUltimo.Enabled = False
        btnAnterior.Enabled = False
        btnSiguiente.Enabled = False

        txtRecargos.Text = ""
        txtCF.Text = ""
        txtINFRA.Text = ""
        txtTAR.Text = ""
        txtAnio.Text = ""

        txtRecargos.Select()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        txtRecargos.Enabled = False
        txtCF.Enabled = False
        txtINFRA.Enabled = False
        txtTAR.Enabled = False
        txtAnio.Enabled = False

        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        btnSalir.Enabled = True

        TarifasBindingSource.Current(0) = CInt(txtIdTarifa.Text)
        TarifasBindingSource.Current(1) = CInt(txtAnio.Text)
        TarifasBindingSource.Current(2) = CDbl(txtCF.Text)
        TarifasBindingSource.Current(3) = CDbl(txtRecargos.Text)
        TarifasBindingSource.Current(4) = CDbl(txtTAR.Text)
        TarifasBindingSource.Current(5) = CDbl(txtINFRA.Text)

        txtRecargos.Text = ""
        txtCF.Text = ""
        txtINFRA.Text = ""
        txtTAR.Text = ""
        txtAnio.Text = ""

        dgTarifas.Refresh()

        btnInicio.Enabled = True
        btnUltimo.Enabled = True
        btnAnterior.Enabled = True
        btnSiguiente.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        TarifasBindingSource.EndEdit()
        Me.TarifasTableAdapter.Update(Me.DataSetSistema.Tarifas)
        Me.Dispose()
    End Sub

    Private Sub asignarValoresTextBoxs()
        If TarifasBindingSource.Count <> 0 Then
            txtIdTarifa.Text = TarifasBindingSource.Current(0)
            txtAnio.Text = TarifasBindingSource.Current(1)
            txtCF.Text = TarifasBindingSource.Current(2)
            txtRecargos.Text = TarifasBindingSource.Current(3)
            txtTAR.Text = TarifasBindingSource.Current(4)
            txtINFRA.Text = TarifasBindingSource.Current(5)
        End If
    End Sub

    Private Sub txtCF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCF.KeyPress
        caracteresValidos(sender, e, "NUMBERS")
    End Sub

    Private Sub txtINFRA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtINFRA.KeyPress
        caracteresValidos(sender, e, "NUMBERS")
    End Sub

    Private Sub txtRecargos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRecargos.KeyPress
        caracteresValidos(sender, e, "NUMBERS")
    End Sub

    Private Sub txtTAR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTAR.KeyPress
        caracteresValidos(sender, e, "NUMBERS")
    End Sub

    Private Sub txtAnio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnio.KeyPress
        caracteresValidos(sender, e, "NUMBERS_NO_DOT")
    End Sub
End Class