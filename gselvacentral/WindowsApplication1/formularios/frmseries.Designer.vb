<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmseries
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
        Me.txtvalmax = New System.Windows.Forms.MaskedTextBox
        Me.txtvalmin = New System.Windows.Forms.MaskedTextBox
        Me.txtnrodeserie = New System.Windows.Forms.MaskedTextBox
        Me.cmbtipcomprobante = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.uv = New Infragistics.Win.Misc.UltraValidator(Me.components)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_series, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_series.SuspendLayout()
        CType(Me.uv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 116)
        Me.UltraGroupBox1.Size = New System.Drawing.Size(675, 456)
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
        Me.grilla.Size = New System.Drawing.Size(665, 430)
        '
        'gb_series
        '
        Me.gb_series.Controls.Add(Me.Label4)
        Me.gb_series.Controls.Add(Me.txtvalmax)
        Me.gb_series.Controls.Add(Me.Label3)
        Me.gb_series.Controls.Add(Me.txtvalmin)
        Me.gb_series.Controls.Add(Me.Label2)
        Me.gb_series.Controls.Add(Me.txtnrodeserie)
        Me.gb_series.Controls.Add(Me.Label1)
        Me.gb_series.Controls.Add(Me.cmbtipcomprobante)
        Me.gb_series.Size = New System.Drawing.Size(480, 98)
        Me.gb_series.Controls.SetChildIndex(Me.cmbtipcomprobante, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label1, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtnrodeserie, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label2, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtvalmin, 0)
        Me.gb_series.Controls.SetChildIndex(Me.btncancelar, 0)
        Me.gb_series.Controls.SetChildIndex(Me.btnnuevo, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label3, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtvalmax, 0)
        Me.gb_series.Controls.SetChildIndex(Me.btnguardar, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label4, 0)
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(312, 65)
        Me.btncancelar.TabIndex = 1
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(393, 65)
        Me.btnguardar.TabIndex = 2
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(231, 65)
        Me.btnnuevo.TabIndex = 0
        '
        'txtvalmax
        '
        Me.txtvalmax.Location = New System.Drawing.Point(368, 39)
        Me.txtvalmax.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.txtvalmax.Mask = "0000000000"
        Me.txtvalmax.Name = "txtvalmax"
        Me.txtvalmax.Size = New System.Drawing.Size(100, 20)
        Me.txtvalmax.TabIndex = 10
        Me.uv.GetValidationSettings(Me.txtvalmax).IsRequired = True
        '
        'txtvalmin
        '
        Me.txtvalmin.Location = New System.Drawing.Point(248, 39)
        Me.txtvalmin.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.txtvalmin.Mask = "0000000000"
        Me.txtvalmin.Name = "txtvalmin"
        Me.txtvalmin.Size = New System.Drawing.Size(100, 20)
        Me.txtvalmin.TabIndex = 9
        Me.uv.GetValidationSettings(Me.txtvalmin).IsRequired = True
        '
        'txtnrodeserie
        '
        Me.txtnrodeserie.Location = New System.Drawing.Point(128, 39)
        Me.txtnrodeserie.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.txtnrodeserie.Mask = "0000000000"
        Me.txtnrodeserie.Name = "txtnrodeserie"
        Me.txtnrodeserie.Size = New System.Drawing.Size(100, 20)
        Me.txtnrodeserie.TabIndex = 8
        Me.uv.GetValidationSettings(Me.txtnrodeserie).IsRequired = True
        '
        'cmbtipcomprobante
        '
        Me.cmbtipcomprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipcomprobante.FormattingEnabled = True
        Me.cmbtipcomprobante.Items.AddRange(New Object() {"Boleta de Venta", "Factura"})
        Me.cmbtipcomprobante.Location = New System.Drawing.Point(8, 39)
        Me.cmbtipcomprobante.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.cmbtipcomprobante.Name = "cmbtipcomprobante"
        Me.cmbtipcomprobante.Size = New System.Drawing.Size(100, 21)
        Me.cmbtipcomprobante.TabIndex = 7
        Me.uv.GetValidationSettings(Me.cmbtipcomprobante).IsRequired = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Tipo de comp:"
        '
        'Label3
        '
        Me.Label3.AccessibleName = ""
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(365, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Valor Máximo:"
        '
        'Label2
        '
        Me.Label2.AccessibleName = ""
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Valor Mínimo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Nro de serie:"
        '
        'uv
        '
        Me.uv.NotificationSettings.Action = Infragistics.Win.Misc.NotificationAction.None
        '
        'frmseries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(699, 584)
        Me.Name = "frmseries"
        Me.Text = "Series de comprobantes de pago"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_series, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_series.ResumeLayout(False)
        Me.gb_series.PerformLayout()
        CType(Me.uv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtvalmax As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtvalmin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtnrodeserie As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbtipcomprobante As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents uv As Infragistics.Win.Misc.UltraValidator

End Class
