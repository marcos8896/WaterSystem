<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametrosHistorialPagoPorCuenta
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.txtBuscarCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgCuentas = New System.Windows.Forms.DataGridView()
        Me.idCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumExt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumInt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPagoA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPagoM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(250, 233)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(150, 23)
        Me.btnBuscar.TabIndex = 15
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(340, 196)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(234, 20)
        Me.txtNombre.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "idCuenta"
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.Enabled = False
        Me.txtIdCuenta.Location = New System.Drawing.Point(107, 196)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.Size = New System.Drawing.Size(139, 20)
        Me.txtIdCuenta.TabIndex = 11
        '
        'txtBuscarCuenta
        '
        Me.txtBuscarCuenta.Location = New System.Drawing.Point(153, 14)
        Me.txtBuscarCuenta.Name = "txtBuscarCuenta"
        Me.txtBuscarCuenta.Size = New System.Drawing.Size(277, 20)
        Me.txtBuscarCuenta.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ingrese la cuenta deseada:"
        '
        'dgCuentas
        '
        Me.dgCuentas.AllowUserToAddRows = False
        Me.dgCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCuenta, Me.Nombre, Me.Calle, Me.NumExt, Me.NumInt, Me.FechaAlta, Me.UltimoPagoA, Me.UltimoPagoM})
        Me.dgCuentas.Location = New System.Drawing.Point(12, 40)
        Me.dgCuentas.Name = "dgCuentas"
        Me.dgCuentas.Size = New System.Drawing.Size(656, 150)
        Me.dgCuentas.TabIndex = 9
        '
        'idCuenta
        '
        Me.idCuenta.HeaderText = "idCuenta"
        Me.idCuenta.Name = "idCuenta"
        Me.idCuenta.Width = 70
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 200
        '
        'Calle
        '
        Me.Calle.HeaderText = "Calle"
        Me.Calle.Name = "Calle"
        Me.Calle.Width = 200
        '
        'NumExt
        '
        Me.NumExt.HeaderText = "NumExt"
        Me.NumExt.Name = "NumExt"
        Me.NumExt.Width = 70
        '
        'NumInt
        '
        Me.NumInt.HeaderText = "NumInt"
        Me.NumInt.Name = "NumInt"
        Me.NumInt.Width = 70
        '
        'FechaAlta
        '
        Me.FechaAlta.HeaderText = "FechaAlta"
        Me.FechaAlta.Name = "FechaAlta"
        '
        'UltimoPagoA
        '
        Me.UltimoPagoA.HeaderText = "UltimoPagoA"
        Me.UltimoPagoA.Name = "UltimoPagoA"
        '
        'UltimoPagoM
        '
        Me.UltimoPagoM.HeaderText = "UltimoPagoM"
        Me.UltimoPagoM.Name = "UltimoPagoM"
        '
        'frmParametrosHistorialPagoPorCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 269)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdCuenta)
        Me.Controls.Add(Me.txtBuscarCuenta)
        Me.Controls.Add(Me.dgCuentas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmParametrosHistorialPagoPorCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar historial de pagos por cuenta"
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdCuenta As TextBox
    Friend WithEvents txtBuscarCuenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgCuentas As DataGridView
    Friend WithEvents idCuenta As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Calle As DataGridViewTextBoxColumn
    Friend WithEvents NumExt As DataGridViewTextBoxColumn
    Friend WithEvents NumInt As DataGridViewTextBoxColumn
    Friend WithEvents FechaAlta As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPagoA As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPagoM As DataGridViewTextBoxColumn
End Class
