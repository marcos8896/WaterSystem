<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogoPozos
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
        Me.components = New System.ComponentModel.Container()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdPozo = New System.Windows.Forms.TextBox()
        Me.PozosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSistema = New Sistema.DataSetSistema()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.dgPozos = New System.Windows.Forms.DataGridView()
        Me.IdPozoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UbicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PozosTableAdapter = New Sistema.DataSetSistemaTableAdapters.PozosTableAdapter()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        CType(Me.PozosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPozos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUltimo
        '
        Me.btnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Location = New System.Drawing.Point(115, 22)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(87, 25)
        Me.btnUltimo.TabIndex = 17
        Me.btnUltimo.Text = "Último"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(208, 22)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(87, 25)
        Me.btnAnterior.TabIndex = 18
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(301, 22)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(87, 25)
        Me.btnSiguiente.TabIndex = 19
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.Location = New System.Drawing.Point(22, 22)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(87, 25)
        Me.btnInicio.TabIndex = 16
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "idPozo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Ubicacion:"
        '
        'txtIdPozo
        '
        Me.txtIdPozo.Enabled = False
        Me.txtIdPozo.Location = New System.Drawing.Point(102, 65)
        Me.txtIdPozo.Name = "txtIdPozo"
        Me.txtIdPozo.Size = New System.Drawing.Size(140, 20)
        Me.txtIdPozo.TabIndex = 27
        '
        'PozosBindingSource
        '
        Me.PozosBindingSource.DataMember = "Pozos"
        Me.PozosBindingSource.DataSource = Me.DataSetSistema
        '
        'DataSetSistema
        '
        Me.DataSetSistema.DataSetName = "DataSetSistema"
        Me.DataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Enabled = False
        Me.txtUbicacion.Location = New System.Drawing.Point(102, 92)
        Me.txtUbicacion.MaxLength = 50
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(263, 20)
        Me.txtUbicacion.TabIndex = 28
        '
        'dgPozos
        '
        Me.dgPozos.AutoGenerateColumns = False
        Me.dgPozos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPozos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPozoDataGridViewTextBoxColumn, Me.UbicacionDataGridViewTextBoxColumn})
        Me.dgPozos.DataSource = Me.PozosBindingSource
        Me.dgPozos.Enabled = False
        Me.dgPozos.Location = New System.Drawing.Point(22, 127)
        Me.dgPozos.Name = "dgPozos"
        Me.dgPozos.ReadOnly = True
        Me.dgPozos.Size = New System.Drawing.Size(374, 150)
        Me.dgPozos.TabIndex = 29
        '
        'IdPozoDataGridViewTextBoxColumn
        '
        Me.IdPozoDataGridViewTextBoxColumn.DataPropertyName = "idPozo"
        Me.IdPozoDataGridViewTextBoxColumn.HeaderText = "idPozo"
        Me.IdPozoDataGridViewTextBoxColumn.Name = "IdPozoDataGridViewTextBoxColumn"
        Me.IdPozoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UbicacionDataGridViewTextBoxColumn
        '
        Me.UbicacionDataGridViewTextBoxColumn.DataPropertyName = "ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.HeaderText = "ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.Name = "UbicacionDataGridViewTextBoxColumn"
        Me.UbicacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.UbicacionDataGridViewTextBoxColumn.Width = 230
        '
        'PozosTableAdapter
        '
        Me.PozosTableAdapter.ClearBeforeFill = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(273, 302)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(118, 23)
        Me.btnSalir.TabIndex = 32
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Location = New System.Drawing.Point(149, 302)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(118, 23)
        Me.btnGrabar.TabIndex = 31
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(26, 302)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(118, 23)
        Me.btnNuevo.TabIndex = 30
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmCatalogoPozos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 337)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgPozos)
        Me.Controls.Add(Me.txtUbicacion)
        Me.Controls.Add(Me.txtIdPozo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnInicio)
        Me.Name = "frmCatalogoPozos"
        Me.Text = "Pozos"
        CType(Me.PozosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPozos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdPozo As TextBox
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents dgPozos As DataGridView
    Friend WithEvents DataSetSistema As DataSetSistema
    Friend WithEvents PozosBindingSource As BindingSource
    Friend WithEvents PozosTableAdapter As DataSetSistemaTableAdapters.PozosTableAdapter
    Friend WithEvents IdPozoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnNuevo As Button
End Class
