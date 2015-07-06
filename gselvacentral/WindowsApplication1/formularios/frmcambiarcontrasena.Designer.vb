<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcambiarcontrasena
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
        Me.components = New System.ComponentModel.Container
        Me.uv = New Infragistics.Win.Misc.UltraValidator(Me.components)
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.txtanterior = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtpass2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtpass1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtuser = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.uv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(398, 53)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnaceptar.TabIndex = 4
        Me.btnaceptar.Text = "&Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancelar.Location = New System.Drawing.Point(479, 53)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 5
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'txtanterior
        '
        Me.txtanterior.Location = New System.Drawing.Point(149, 27)
        Me.txtanterior.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtanterior.Name = "txtanterior"
        Me.txtanterior.Size = New System.Drawing.Size(127, 20)
        Me.txtanterior.TabIndex = 1
        Me.txtanterior.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Password anterior:"
        '
        'txtpass2
        '
        Me.txtpass2.Location = New System.Drawing.Point(427, 27)
        Me.txtpass2.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtpass2.Name = "txtpass2"
        Me.txtpass2.Size = New System.Drawing.Size(127, 20)
        Me.txtpass2.TabIndex = 3
        Me.txtpass2.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(427, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Confirme su password:"
        '
        'txtpass1
        '
        Me.txtpass1.Location = New System.Drawing.Point(288, 27)
        Me.txtpass1.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtpass1.Name = "txtpass1"
        Me.txtpass1.Size = New System.Drawing.Size(127, 20)
        Me.txtpass1.TabIndex = 2
        Me.txtpass1.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(288, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nuevo Password"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(10, 27)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.ReadOnly = True
        Me.txtuser.Size = New System.Drawing.Size(127, 20)
        Me.txtuser.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Usuario:"
        '
        'frmcambiarcontrasena
        '
        Me.AcceptButton = Me.btnaceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btncancelar
        Me.ClientSize = New System.Drawing.Size(565, 87)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.txtanterior)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpass2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpass1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmcambiarcontrasena"
        Me.Text = "Cambiar Contraseña"
        CType(Me.uv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uv As Infragistics.Win.Misc.UltraValidator
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents txtanterior As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtpass2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpass1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
