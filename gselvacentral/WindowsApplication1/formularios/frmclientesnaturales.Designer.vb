<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmclientesnaturales
    Inherits administrador.padre

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.txtruc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtdni = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtapellidos = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnombres = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.uv = New Infragistics.Win.Misc.UltraValidator(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_series, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_series.SuspendLayout()
        CType(Me.uv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Size = New System.Drawing.Size(865, 453)
        '
        'grilla
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.grilla.DisplayLayout.Appearance = Appearance1
        Me.grilla.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grilla.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grilla.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grilla.DisplayLayout.InterBandSpacing = 10
        Me.grilla.DisplayLayout.MaxColScrollRegions = 1
        Me.grilla.DisplayLayout.MaxRowScrollRegions = 1
        Appearance2.BackColor = System.Drawing.SystemColors.Window
        Appearance2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grilla.DisplayLayout.Override.ActiveCellAppearance = Appearance2
        Appearance3.BackColor = System.Drawing.SystemColors.Highlight
        Appearance3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grilla.DisplayLayout.Override.ActiveRowAppearance = Appearance3
        Me.grilla.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grilla.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.grilla.DisplayLayout.Override.CardAreaAppearance = Appearance4
        Appearance5.BorderColor = System.Drawing.Color.Silver
        Appearance5.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grilla.DisplayLayout.Override.CellAppearance = Appearance5
        Me.grilla.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grilla.DisplayLayout.Override.CellPadding = 0
        Appearance6.BackColor = System.Drawing.SystemColors.Control
        Appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance6.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance6.BorderColor = System.Drawing.SystemColors.Window
        Me.grilla.DisplayLayout.Override.GroupByRowAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.Brown
        Appearance7.BackColor2 = System.Drawing.Color.Red
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.ForeColor = System.Drawing.Color.White
        Appearance7.TextHAlignAsString = "Left"
        Appearance7.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.grilla.DisplayLayout.Override.HeaderAppearance = Appearance7
        Me.grilla.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grilla.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance8.BorderColor = System.Drawing.Color.Red
        Me.grilla.DisplayLayout.Override.RowAppearance = Appearance8
        Appearance9.BackColor = System.Drawing.Color.Brown
        Appearance9.BackColor2 = System.Drawing.Color.Red
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.grilla.DisplayLayout.Override.RowSelectorAppearance = Appearance9
        Me.grilla.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.grilla.DisplayLayout.Override.RowSelectorWidth = 12
        Me.grilla.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance10.BackColor = System.Drawing.Color.Red
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.grilla.DisplayLayout.Override.SelectedRowAppearance = Appearance10
        Appearance11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grilla.DisplayLayout.Override.TemplateAddRowAppearance = Appearance11
        Me.grilla.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.grilla.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.grilla.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grilla.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grilla.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grilla.Size = New System.Drawing.Size(855, 427)
        '
        'gb_series
        '
        Me.gb_series.Controls.Add(Me.txtruc)
        Me.gb_series.Controls.Add(Me.Label3)
        Me.gb_series.Controls.Add(Me.Label4)
        Me.gb_series.Controls.Add(Me.txtdni)
        Me.gb_series.Controls.Add(Me.txtnombres)
        Me.gb_series.Controls.Add(Me.Label6)
        Me.gb_series.Controls.Add(Me.Label5)
        Me.gb_series.Controls.Add(Me.txtapellidos)
        Me.gb_series.Size = New System.Drawing.Size(460, 101)
        Me.gb_series.Controls.SetChildIndex(Me.txtapellidos, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label5, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label6, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtnombres, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtdni, 0)
        Me.gb_series.Controls.SetChildIndex(Me.btnnuevo, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label4, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label3, 0)
        Me.gb_series.Controls.SetChildIndex(Me.btncancelar, 0)
        Me.gb_series.Controls.SetChildIndex(Me.btnguardar, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtruc, 0)
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(288, 63)
        Me.btncancelar.TabIndex = 5
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(369, 63)
        Me.btnguardar.TabIndex = 6
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(207, 63)
        Me.btnnuevo.TabIndex = 4
        '
        'txtruc
        '
        Me.txtruc.Location = New System.Drawing.Point(344, 37)
        Me.txtruc.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(100, 20)
        Me.txtruc.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(341, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "RUC:"
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(232, 37)
        Me.txtdni.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(100, 20)
        Me.txtdni.TabIndex = 2
        Me.uv.GetValidationSettings(Me.txtdni).IsRequired = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(229, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "DNI:"
        '
        'txtapellidos
        '
        Me.txtapellidos.Location = New System.Drawing.Point(120, 37)
        Me.txtapellidos.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(100, 20)
        Me.txtapellidos.TabIndex = 1
        Me.uv.GetValidationSettings(Me.txtapellidos).IsRequired = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(117, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Apellidos:"
        '
        'txtnombres
        '
        Me.txtnombres.Location = New System.Drawing.Point(8, 37)
        Me.txtnombres.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(100, 20)
        Me.txtnombres.TabIndex = 0
        Me.uv.GetValidationSettings(Me.txtnombres).IsRequired = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Nombres:"
        '
        'uv
        '
        Me.uv.NotificationSettings.Action = Infragistics.Win.Misc.NotificationAction.None
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(232, 36)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 69
        Me.TextBox1.Tag = "natdni"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(8, 36)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 67
        Me.TextBox2.Tag = "natnombres"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(120, 36)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 68
        Me.TextBox3.Tag = "natapellidos"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.Label1)
        Me.UltraGroupBox2.Controls.Add(Me.TextBox1)
        Me.UltraGroupBox2.Controls.Add(Me.TextBox2)
        Me.UltraGroupBox2.Controls.Add(Me.Label2)
        Me.UltraGroupBox2.Controls.Add(Me.Label7)
        Me.UltraGroupBox2.Controls.Add(Me.TextBox3)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(478, 13)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(346, 100)
        Me.UltraGroupBox2.TabIndex = 7
        Me.UltraGroupBox2.Text = "Buscar"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Nombres:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "DNI:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(117, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Apellidos:"
        '
        'frmclientesnaturales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(889, 584)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Name = "frmclientesnaturales"
        Me.Text = "Clientes [Personas Naturales]"
        Me.Controls.SetChildIndex(Me.UltraGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.gb_series, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_series, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_series.ResumeLayout(False)
        Me.gb_series.PerformLayout()
        CType(Me.uv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtapellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnombres As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents uv As Infragistics.Win.Misc.UltraValidator
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

End Class
