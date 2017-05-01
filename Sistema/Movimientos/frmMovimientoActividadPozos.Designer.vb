<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientoActividadPozos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdActividad = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.txtLectura = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.cbPozo = New System.Windows.Forms.ComboBox()
        Me.txtIdPozo = New System.Windows.Forms.TextBox()
        Me.dgActividadPozos = New System.Windows.Forms.DataGridView()
        Me.idActividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPozo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pozo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lectura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.dgActividadPozos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "idActividad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Pozo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(228, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "idPozo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(93, 76)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(397, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Hora:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(397, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Lectura:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Observaciones:"
        '
        'txtIdActividad
        '
        Me.txtIdActividad.Location = New System.Drawing.Point(122, 22)
        Me.txtIdActividad.Name = "txtIdActividad"
        Me.txtIdActividad.ReadOnly = True
        Me.txtIdActividad.Size = New System.Drawing.Size(100, 20)
        Me.txtIdActividad.TabIndex = 32
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(452, 25)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(129, 20)
        Me.txtHora.TabIndex = 3
        '
        'txtLectura
        '
        Me.txtLectura.Location = New System.Drawing.Point(452, 52)
        Me.txtLectura.Name = "txtLectura"
        Me.txtLectura.ReadOnly = True
        Me.txtLectura.Size = New System.Drawing.Size(200, 20)
        Me.txtLectura.TabIndex = 4
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(147, 119)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ReadOnly = True
        Me.txtObservaciones.Size = New System.Drawing.Size(505, 67)
        Me.txtObservaciones.TabIndex = 5
        '
        'cbPozo
        '
        Me.cbPozo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPozo.Enabled = False
        Me.cbPozo.FormattingEnabled = True
        Me.cbPozo.Location = New System.Drawing.Point(86, 49)
        Me.cbPozo.Name = "cbPozo"
        Me.cbPozo.Size = New System.Drawing.Size(136, 21)
        Me.cbPozo.TabIndex = 1
        '
        'txtIdPozo
        '
        Me.txtIdPozo.Location = New System.Drawing.Point(285, 50)
        Me.txtIdPozo.Name = "txtIdPozo"
        Me.txtIdPozo.ReadOnly = True
        Me.txtIdPozo.Size = New System.Drawing.Size(67, 20)
        Me.txtIdPozo.TabIndex = 37
        '
        'dgActividadPozos
        '
        Me.dgActividadPozos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgActividadPozos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idActividad, Me.idPozo, Me.Pozo, Me.Fecha, Me.Hora, Me.Lectura, Me.Observaciones})
        Me.dgActividadPozos.Location = New System.Drawing.Point(30, 205)
        Me.dgActividadPozos.Name = "dgActividadPozos"
        Me.dgActividadPozos.Size = New System.Drawing.Size(638, 150)
        Me.dgActividadPozos.TabIndex = 38
        '
        'idActividad
        '
        Me.idActividad.HeaderText = "idActividad"
        Me.idActividad.Name = "idActividad"
        Me.idActividad.ReadOnly = True
        Me.idActividad.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idActividad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.idActividad.Width = 70
        '
        'idPozo
        '
        Me.idPozo.HeaderText = "idPozo"
        Me.idPozo.Name = "idPozo"
        Me.idPozo.ReadOnly = True
        Me.idPozo.Width = 70
        '
        'Pozo
        '
        Me.Pozo.HeaderText = "Pozo"
        Me.Pozo.Name = "Pozo"
        Me.Pozo.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 85
        '
        'Hora
        '
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        Me.Hora.ReadOnly = True
        Me.Hora.Width = 85
        '
        'Lectura
        '
        Me.Lectura.HeaderText = "Lectura"
        Me.Lectura.Name = "Lectura"
        Me.Lectura.ReadOnly = True
        Me.Lectura.Width = 85
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(136, 375)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(125, 25)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Location = New System.Drawing.Point(287, 375)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(125, 25)
        Me.btnGrabar.TabIndex = 6
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(438, 375)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(125, 25)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmMovimientoActividadPozos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 416)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgActividadPozos)
        Me.Controls.Add(Me.txtIdPozo)
        Me.Controls.Add(Me.cbPozo)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtLectura)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.txtIdActividad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMovimientoActividadPozos"
        Me.Text = "Actividad de Pozos"
        CType(Me.dgActividadPozos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIdActividad As TextBox
    Friend WithEvents txtHora As TextBox
    Friend WithEvents txtLectura As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents cbPozo As ComboBox
    Friend WithEvents txtIdPozo As TextBox
    Friend WithEvents dgActividadPozos As DataGridView
    Friend WithEvents idActividad As DataGridViewTextBoxColumn
    Friend WithEvents idPozo As DataGridViewTextBoxColumn
    Friend WithEvents Pozo As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Hora As DataGridViewTextBoxColumn
    Friend WithEvents Lectura As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnSalir As Button
End Class
