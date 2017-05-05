<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametroCuenta
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
        Me.dgCalles = New System.Windows.Forms.DataGridView()
        Me.idCalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colonia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCasas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBuscarCalle = New System.Windows.Forms.TextBox()
        Me.txtIdCalle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.dgCalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese la calle deseada:"
        '
        'dgCalles
        '
        Me.dgCalles.AllowUserToAddRows = False
        Me.dgCalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCalle, Me.Nombre, Me.Colonia, Me.CP, Me.TotalCasas})
        Me.dgCalles.Location = New System.Drawing.Point(12, 44)
        Me.dgCalles.Name = "dgCalles"
        Me.dgCalles.Size = New System.Drawing.Size(656, 150)
        Me.dgCalles.TabIndex = 1
        '
        'idCalle
        '
        Me.idCalle.HeaderText = "idCalle"
        Me.idCalle.Name = "idCalle"
        Me.idCalle.Width = 70
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 200
        '
        'Colonia
        '
        Me.Colonia.HeaderText = "Colonia"
        Me.Colonia.Name = "Colonia"
        Me.Colonia.Width = 200
        '
        'CP
        '
        Me.CP.HeaderText = "CP"
        Me.CP.Name = "CP"
        Me.CP.Width = 70
        '
        'TotalCasas
        '
        Me.TotalCasas.HeaderText = "TotalCasas"
        Me.TotalCasas.Name = "TotalCasas"
        Me.TotalCasas.Width = 70
        '
        'txtBuscarCalle
        '
        Me.txtBuscarCalle.Location = New System.Drawing.Point(153, 18)
        Me.txtBuscarCalle.Name = "txtBuscarCalle"
        Me.txtBuscarCalle.Size = New System.Drawing.Size(277, 20)
        Me.txtBuscarCalle.TabIndex = 2
        '
        'txtIdCalle
        '
        Me.txtIdCalle.Enabled = False
        Me.txtIdCalle.Location = New System.Drawing.Point(96, 200)
        Me.txtIdCalle.Name = "txtIdCalle"
        Me.txtIdCalle.Size = New System.Drawing.Size(139, 20)
        Me.txtIdCalle.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "idCalle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(340, 200)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(234, 20)
        Me.txtNombre.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(250, 237)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(150, 23)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmParametroCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 272)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdCalle)
        Me.Controls.Add(Me.txtBuscarCalle)
        Me.Controls.Add(Me.dgCalles)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmParametroCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte por calles"
        CType(Me.dgCalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgCalles As DataGridView
    Friend WithEvents txtBuscarCalle As TextBox
    Friend WithEvents idCalle As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Colonia As DataGridViewTextBoxColumn
    Friend WithEvents CP As DataGridViewTextBoxColumn
    Friend WithEvents TotalCasas As DataGridViewTextBoxColumn
    Friend WithEvents txtIdCalle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnBuscar As Button
End Class
