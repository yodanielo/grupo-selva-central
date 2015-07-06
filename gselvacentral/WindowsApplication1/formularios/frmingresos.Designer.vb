<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmingresos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmingresos))
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione una fecha"
        '
        'dtp1
        '
        Me.dtp1.Location = New System.Drawing.Point(129, 2)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(200, 20)
        Me.dtp1.TabIndex = 0
        '
        'btnaceptar
        '
        Me.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnaceptar.Location = New System.Drawing.Point(173, 28)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnaceptar.TabIndex = 1
        Me.btnaceptar.Text = "&Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancelar.Location = New System.Drawing.Point(254, 28)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 2
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'frmingresos
        '
        Me.AcceptButton = Me.btnaceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btncancelar
        Me.ClientSize = New System.Drawing.Size(340, 61)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmingresos"
        Me.Text = "Reporte de Ingresos Diarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
End Class
