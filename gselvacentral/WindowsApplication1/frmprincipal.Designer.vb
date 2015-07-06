<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmprincipal))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btncerrarsession = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnseries = New System.Windows.Forms.ToolStripButton
        Me.btningresos = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btncamioneros = New System.Windows.Forms.ToolStripButton
        Me.btnunidades = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnadministradores = New System.Windows.Forms.ToolStripButton
        Me.btnclientes = New System.Windows.Forms.ToolStripSplitButton
        Me.PersonasNaturalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PersonasJurídicasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnacercade = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btncerrarsession, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.btnseries, Me.btningresos, Me.ToolStripSeparator2, Me.btncamioneros, Me.btnunidades, Me.ToolStripSeparator3, Me.btnadministradores, Me.btnclientes, Me.ToolStripSeparator4, Me.btnacercade})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1077, 54)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btncerrarsession
        '
        Me.btncerrarsession.Image = Global.administrador.My.Resources.Resources.gnome_logout
        Me.btncerrarsession.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btncerrarsession.Name = "btncerrarsession"
        Me.btncerrarsession.Size = New System.Drawing.Size(82, 51)
        Me.btncerrarsession.Text = "Cerrar Cesión"
        Me.btncerrarsession.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.administrador.My.Resources.Resources.Keychain_Access
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(119, 51)
        Me.ToolStripButton1.Text = "Cambiar Contraseña"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'btnseries
        '
        Me.btnseries.Image = Global.administrador.My.Resources.Resources.Sales_by_Payment_Method_rep
        Me.btnseries.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnseries.Name = "btnseries"
        Me.btnseries.Size = New System.Drawing.Size(137, 51)
        Me.btnseries.Text = "Series de comprobantes"
        Me.btnseries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnseries.Visible = False
        '
        'btningresos
        '
        Me.btningresos.Image = Global.administrador.My.Resources.Resources.applications_utilities
        Me.btningresos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btningresos.Name = "btningresos"
        Me.btningresos.Size = New System.Drawing.Size(95, 51)
        Me.btningresos.Text = "Ingresos por dia"
        Me.btningresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 54)
        '
        'btncamioneros
        '
        Me.btncamioneros.Image = Global.administrador.My.Resources.Resources.personal
        Me.btncamioneros.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btncamioneros.Name = "btncamioneros"
        Me.btncamioneros.Size = New System.Drawing.Size(58, 51)
        Me.btncamioneros.Text = "Choferes"
        Me.btncamioneros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnunidades
        '
        Me.btnunidades.Image = Global.administrador.My.Resources.Resources.truck
        Me.btnunidades.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnunidades.Name = "btnunidades"
        Me.btnunidades.Size = New System.Drawing.Size(136, 51)
        Me.btnunidades.Text = "Unidades de Transporte"
        Me.btnunidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 54)
        '
        'btnadministradores
        '
        Me.btnadministradores.Image = Global.administrador.My.Resources.Resources.people
        Me.btnadministradores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnadministradores.Name = "btnadministradores"
        Me.btnadministradores.Size = New System.Drawing.Size(118, 51)
        Me.btnadministradores.Text = "Usuarios del sistema"
        Me.btnadministradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnclientes
        '
        Me.btnclientes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonasNaturalesToolStripMenuItem, Me.PersonasJurídicasToolStripMenuItem})
        Me.btnclientes.Image = Global.administrador.My.Resources.Resources.clients
        Me.btnclientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(65, 51)
        Me.btnclientes.Text = "Clientes"
        Me.btnclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PersonasNaturalesToolStripMenuItem
        '
        Me.PersonasNaturalesToolStripMenuItem.Name = "PersonasNaturalesToolStripMenuItem"
        Me.PersonasNaturalesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PersonasNaturalesToolStripMenuItem.Text = "Personas Naturales"
        '
        'PersonasJurídicasToolStripMenuItem
        '
        Me.PersonasJurídicasToolStripMenuItem.Name = "PersonasJurídicasToolStripMenuItem"
        Me.PersonasJurídicasToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PersonasJurídicasToolStripMenuItem.Text = "Personas Jurídicas"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 54)
        '
        'btnacercade
        '
        Me.btnacercade.Image = Global.administrador.My.Resources.Resources.Information
        Me.btnacercade.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnacercade.Name = "btnacercade"
        Me.btnacercade.Size = New System.Drawing.Size(75, 51)
        Me.btnacercade.Text = "Acerca de ..."
        Me.btnacercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 495)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmprincipal"
        Me.Text = "Grupo Selva Central"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btncerrarsession As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnseries As System.Windows.Forms.ToolStripButton
    Friend WithEvents btningresos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnadministradores As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnclientes As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents PersonasNaturalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonasJurídicasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnacercade As System.Windows.Forms.ToolStripButton
    Friend WithEvents btncamioneros As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnunidades As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator

End Class
