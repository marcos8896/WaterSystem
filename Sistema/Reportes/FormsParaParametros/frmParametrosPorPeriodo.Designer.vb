<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametrosPorPeriodo
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
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.combitoOpcion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DTP1
        '
        Me.DTP1.Location = New System.Drawing.Point(20, 30)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(274, 20)
        Me.DTP1.TabIndex = 0
        '
        'DTP2
        '
        Me.DTP2.Location = New System.Drawing.Point(20, 101)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(274, 20)
        Me.DTP2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DTP1)
        Me.Panel1.Controls.Add(Me.DTP2)
        Me.Panel1.Location = New System.Drawing.Point(12, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(316, 144)
        Me.Panel1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Y:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Entre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Seleccione las fechas deseadas:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(113, 238)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(115, 23)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'combitoOpcion
        '
        Me.combitoOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combitoOpcion.FormattingEnabled = True
        Me.combitoOpcion.Items.AddRange(New Object() {"ENTRADA DE MATERIAL EN UN PERIODO", "SALIDA DE MATERIAL EN UN PERIODO", "GASTOS EN UN PERIODO", "PAGOS EN UN PERIODO", "ACTIVIDAD DE POZOS EN UN PERIODO"})
        Me.combitoOpcion.Location = New System.Drawing.Point(23, 25)
        Me.combitoOpcion.Name = "combitoOpcion"
        Me.combitoOpcion.Size = New System.Drawing.Size(295, 21)
        Me.combitoOpcion.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Seleccione el reporte deseado:"
        '
        'frmParametrosPorPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 271)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.combitoOpcion)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmParametrosPorPeriodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reportes por periodo (5)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents DTP2 As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents combitoOpcion As ComboBox
    Friend WithEvents Label4 As Label
End Class
