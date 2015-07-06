<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btningresar = New System.Windows.Forms.Button
        Me.txtcontrasena = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtuser = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncancelar
        '
        Me.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancelar.Location = New System.Drawing.Point(227, 97)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 3
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btningresar
        '
        Me.btningresar.Location = New System.Drawing.Point(146, 97)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(75, 23)
        Me.btningresar.TabIndex = 2
        Me.btningresar.Text = "&Ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'txtcontrasena
        '
        Me.txtcontrasena.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontrasena.Location = New System.Drawing.Point(121, 70)
        Me.txtcontrasena.Name = "txtcontrasena"
        Me.txtcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontrasena.Size = New System.Drawing.Size(181, 21)
        Me.txtcontrasena.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Contraseña:"
        '
        'txtuser
        '
        Me.txtuser.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(121, 28)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(181, 21)
        Me.txtuser.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.administrador.My.Resources.Resources.login
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'login
        '
        Me.AcceptButton = Me.btningresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btncancelar
        Me.ClientSize = New System.Drawing.Size(313, 133)
        Me.ControlBox = False
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.txtcontrasena)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "login"
        Me.Text = "Ingreso de Usuarios"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btningresar As System.Windows.Forms.Button
    Friend WithEvents txtcontrasena As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
