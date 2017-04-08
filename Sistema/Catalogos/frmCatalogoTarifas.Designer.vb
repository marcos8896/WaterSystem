<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogoTarifas
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
        Me.txtIdTarifa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCF = New System.Windows.Forms.TextBox()
        Me.txtRecargos = New System.Windows.Forms.TextBox()
        Me.txtTAR = New System.Windows.Forms.TextBox()
        Me.txtINFRA = New System.Windows.Forms.TextBox()
        Me.dgTarifas = New System.Windows.Forms.DataGridView()
        Me.IdTarifaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecargosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INFRADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSistema = New Sistema.DataSetSistema()
        Me.TarifasTableAdapter = New Sistema.DataSetSistemaTableAdapters.TarifasTableAdapter()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarifasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUltimo
        '
        Me.btnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Location = New System.Drawing.Point(149, 12)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(87, 25)
        Me.btnUltimo.TabIndex = 9
        Me.btnUltimo.Text = "Último"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(242, 12)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(87, 25)
        Me.btnAnterior.TabIndex = 10
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(335, 12)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(87, 25)
        Me.btnSiguiente.TabIndex = 11
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.Location = New System.Drawing.Point(56, 12)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(87, 25)
        Me.btnInicio.TabIndex = 8
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "idTarifa:"
        '
        'txtIdTarifa
        '
        Me.txtIdTarifa.Enabled = False
        Me.txtIdTarifa.Location = New System.Drawing.Point(117, 60)
        Me.txtIdTarifa.Name = "txtIdTarifa"
        Me.txtIdTarifa.Size = New System.Drawing.Size(100, 20)
        Me.txtIdTarifa.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(278, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "CF:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Recargos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(278, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "TAR:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(278, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "INFRA:"
        '
        'txtCF
        '
        Me.txtCF.Enabled = False
        Me.txtCF.Location = New System.Drawing.Point(335, 60)
        Me.txtCF.Name = "txtCF"
        Me.txtCF.Size = New System.Drawing.Size(90, 20)
        Me.txtCF.TabIndex = 3
        '
        'txtRecargos
        '
        Me.txtRecargos.Enabled = False
        Me.txtRecargos.Location = New System.Drawing.Point(117, 87)
        Me.txtRecargos.Name = "txtRecargos"
        Me.txtRecargos.Size = New System.Drawing.Size(100, 20)
        Me.txtRecargos.TabIndex = 1
        '
        'txtTAR
        '
        Me.txtTAR.Enabled = False
        Me.txtTAR.Location = New System.Drawing.Point(335, 116)
        Me.txtTAR.Name = "txtTAR"
        Me.txtTAR.Size = New System.Drawing.Size(90, 20)
        Me.txtTAR.TabIndex = 5
        '
        'txtINFRA
        '
        Me.txtINFRA.Enabled = False
        Me.txtINFRA.Location = New System.Drawing.Point(335, 87)
        Me.txtINFRA.Name = "txtINFRA"
        Me.txtINFRA.Size = New System.Drawing.Size(90, 20)
        Me.txtINFRA.TabIndex = 4
        '
        'dgTarifas
        '
        Me.dgTarifas.AutoGenerateColumns = False
        Me.dgTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTarifas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTarifaDataGridViewTextBoxColumn, Me.AnioDataGridViewTextBoxColumn, Me.CFDataGridViewTextBoxColumn, Me.RecargosDataGridViewTextBoxColumn, Me.TARDataGridViewTextBoxColumn, Me.INFRADataGridViewTextBoxColumn})
        Me.dgTarifas.DataSource = Me.TarifasBindingSource
        Me.dgTarifas.Enabled = False
        Me.dgTarifas.Location = New System.Drawing.Point(13, 157)
        Me.dgTarifas.Name = "dgTarifas"
        Me.dgTarifas.ReadOnly = True
        Me.dgTarifas.Size = New System.Drawing.Size(463, 150)
        Me.dgTarifas.TabIndex = 40
        '
        'IdTarifaDataGridViewTextBoxColumn
        '
        Me.IdTarifaDataGridViewTextBoxColumn.DataPropertyName = "idTarifa"
        Me.IdTarifaDataGridViewTextBoxColumn.HeaderText = "idTarifa"
        Me.IdTarifaDataGridViewTextBoxColumn.Name = "IdTarifaDataGridViewTextBoxColumn"
        Me.IdTarifaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdTarifaDataGridViewTextBoxColumn.Width = 70
        '
        'AnioDataGridViewTextBoxColumn
        '
        Me.AnioDataGridViewTextBoxColumn.DataPropertyName = "anio"
        Me.AnioDataGridViewTextBoxColumn.HeaderText = "anio"
        Me.AnioDataGridViewTextBoxColumn.Name = "AnioDataGridViewTextBoxColumn"
        Me.AnioDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnioDataGridViewTextBoxColumn.Width = 70
        '
        'CFDataGridViewTextBoxColumn
        '
        Me.CFDataGridViewTextBoxColumn.DataPropertyName = "CF"
        Me.CFDataGridViewTextBoxColumn.HeaderText = "CF"
        Me.CFDataGridViewTextBoxColumn.Name = "CFDataGridViewTextBoxColumn"
        Me.CFDataGridViewTextBoxColumn.ReadOnly = True
        Me.CFDataGridViewTextBoxColumn.Width = 70
        '
        'RecargosDataGridViewTextBoxColumn
        '
        Me.RecargosDataGridViewTextBoxColumn.DataPropertyName = "recargos"
        Me.RecargosDataGridViewTextBoxColumn.HeaderText = "recargos"
        Me.RecargosDataGridViewTextBoxColumn.Name = "RecargosDataGridViewTextBoxColumn"
        Me.RecargosDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecargosDataGridViewTextBoxColumn.Width = 70
        '
        'TARDataGridViewTextBoxColumn
        '
        Me.TARDataGridViewTextBoxColumn.DataPropertyName = "TAR"
        Me.TARDataGridViewTextBoxColumn.HeaderText = "TAR"
        Me.TARDataGridViewTextBoxColumn.Name = "TARDataGridViewTextBoxColumn"
        Me.TARDataGridViewTextBoxColumn.ReadOnly = True
        Me.TARDataGridViewTextBoxColumn.Width = 70
        '
        'INFRADataGridViewTextBoxColumn
        '
        Me.INFRADataGridViewTextBoxColumn.DataPropertyName = "INFRA"
        Me.INFRADataGridViewTextBoxColumn.HeaderText = "INFRA"
        Me.INFRADataGridViewTextBoxColumn.Name = "INFRADataGridViewTextBoxColumn"
        Me.INFRADataGridViewTextBoxColumn.ReadOnly = True
        Me.INFRADataGridViewTextBoxColumn.Width = 70
        '
        'TarifasBindingSource
        '
        Me.TarifasBindingSource.DataMember = "Tarifas"
        Me.TarifasBindingSource.DataSource = Me.DataSetSistema
        '
        'DataSetSistema
        '
        Me.DataSetSistema.DataSetName = "DataSetSistema"
        Me.DataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TarifasTableAdapter
        '
        Me.TarifasTableAdapter.ClearBeforeFill = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(312, 324)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(118, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Location = New System.Drawing.Point(188, 324)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(118, 23)
        Me.btnGrabar.TabIndex = 7
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(65, 324)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(118, 23)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtAnio
        '
        Me.txtAnio.Enabled = False
        Me.txtAnio.Location = New System.Drawing.Point(117, 115)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(100, 20)
        Me.txtAnio.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Año:"
        '
        'frmCatalogoTarifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 368)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgTarifas)
        Me.Controls.Add(Me.txtINFRA)
        Me.Controls.Add(Me.txtTAR)
        Me.Controls.Add(Me.txtRecargos)
        Me.Controls.Add(Me.txtCF)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdTarifa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnInicio)
        Me.Name = "frmCatalogoTarifas"
        Me.Text = "Tarifas"
        CType(Me.dgTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarifasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdTarifa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCF As TextBox
    Friend WithEvents txtRecargos As TextBox
    Friend WithEvents txtTAR As TextBox
    Friend WithEvents txtINFRA As TextBox
    Friend WithEvents dgTarifas As DataGridView
    Friend WithEvents DataSetSistema As DataSetSistema
    Friend WithEvents TarifasBindingSource As BindingSource
    Friend WithEvents TarifasTableAdapter As DataSetSistemaTableAdapters.TarifasTableAdapter
    Friend WithEvents IdTarifaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecargosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INFRADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents Label6 As Label
End Class
