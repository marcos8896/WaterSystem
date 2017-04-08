Imports System.Data.SqlClient

Public Class frmMovimientoActividadPozos

    Dim conexionsql As New SqlConnection("Data Source='MARCOS-LAPTOP\PLEASEWORK'; Initial Catalog='db_agua_potable'; Integrated security=true")

    Private Sub cbPozo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPozo.SelectedIndexChanged
        Dim r As String = String.Format("SELECT * FROM Pozos WHERE ubicacion='{0}'", cbPozo.Text)

        Dim comando As New SqlCommand(r, conexionsql)

        Dim lector As SqlDataReader

        lector = comando.ExecuteReader()

        lector.Read()

        txtIdPozo.Text = lector(0)

        lector.Close()

    End Sub

    Private Sub frmMovimientoActividadPozos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()

        Dim comando As New SqlCommand()
        Dim lector As SqlDataReader

        'Consulta para conocer los registros de los pozos que hay en la base de datos.
        comando = New SqlCommand("SELECT * FROM Pozos", conexionsql)

        'El lector contiene los datos y es el que permite leer los datos de la consulta del comando.
        lector = comando.ExecuteReader()

        'CARGA DE LOS POZOS EN EL COMBOBOX DE cbPozo-----------------!
        While lector.Read()
            cbPozo.Items.Add(lector(1))
        End While
        lector.Close()


        cbPozo.SelectedIndex = 0
        '------------------------------------------------------------!

        'Método que llena la rejilla con los datos actuales.
        FillDataGrid(comando, lector)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        Dim comando As New SqlCommand()

        comando = New SqlCommand("SELECT COUNT(*) FROM ActividadPozos", conexionsql)
        Dim n As Integer
        n = comando.ExecuteScalar() + 1

        txtIdActividad.Text = n.ToString

        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnSalir.Enabled = False

        txtHora.ReadOnly = False
        txtLectura.ReadOnly = False
        txtObservaciones.ReadOnly = False

        cbPozo.Enabled = True
        dtpFecha.Enabled = True


    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

        Dim comando As New SqlCommand()
        Dim lector As SqlDataReader

        'Columnas de la tabla de ActividadPozo
        Dim idActividad As Integer = CInt(txtIdActividad.Text)
        Dim idPozo As Integer = CInt(txtIdPozo.Text)
        Dim fecha As Date = dtpFecha.Value.Date
        Dim hora As String = txtHora.Text
        Dim lectura As String = txtLectura.Text
        Dim observaciones As String = txtObservaciones.Text

        Dim r As String = String.Format _
            ("INSERT INTO ActividadPozos (idActividad, idPozo, fecha, hora, lectura, observaciones) VALUES ({0},{1},'{2}','{3}','{4}','{5}') ",
            idActividad, idPozo, fecha, hora, lectura, observaciones)

        comando = New SqlCommand(r, conexionsql)

        comando.ExecuteNonQuery()

        btnNuevo.Enabled = True
        btnGrabar.Enabled = False
        btnSalir.Enabled = True

        txtHora.ReadOnly = True
        txtLectura.ReadOnly = True
        txtObservaciones.ReadOnly = True

        cbPozo.Enabled = False
        dtpFecha.Enabled = False

        FillDataGrid(comando, lector)

        'Se limpian los controles
        txtIdActividad.Text = ""
        txtHora.Text = ""
        txtLectura.Text = ""
        txtObservaciones.Text = ""
        cbPozo.SelectedIndex = 0
        dtpFecha.Value = Date.Today

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub

    Private Sub FillDataGrid(comando As SqlCommand, lector As SqlDataReader)
        dgActividadPozos.Rows.Clear()
        'CARGA DE DATOS EN dgActividadPozos--------------------------!
        comando.CommandText = "SELECT ActividadPozos.idActividad, ActividadPozos.idPozo, Pozos.ubicacion, ActividadPozos.fecha, ActividadPozos.hora, ActividadPozos.lectura, ActividadPozos.observaciones FROM ActividadPozos INNER JOIN Pozos on ActividadPozos.idPozo = Pozos.idPozo"
        lector = comando.ExecuteReader()
        While lector.Read()
            dgActividadPozos.Rows.Add(lector(0), lector(1), lector(2), CDate(lector(3)).ToShortDateString, lector(4), lector(5), lector(6))
        End While
        lector.Close()
        '------------------------------------------------------------!
    End Sub
End Class