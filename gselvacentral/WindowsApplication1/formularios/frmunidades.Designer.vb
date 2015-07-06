<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmunidades
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
        Me.uv = New Infragistics.Win.Misc.UltraValidator(Me.components)
        Me.cbochofer = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.txtplaca = New System.Windows.Forms.MaskedTextBox
        Me.cboempresa = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.gpsub = New Infragistics.Win.Misc.UltraGroupBox
        Me.txtruc = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtsocial = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_series, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_series.SuspendLayout()
        CType(Me.uv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbochofer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpsub, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpsub.SuspendLayout()
        Me.SuspendLayout()
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
        '
        'gb_series
        '
        Me.gb_series.Controls.Add(Me.cbochofer)
        Me.gb_series.Controls.Add(Me.txtplaca)
        Me.gb_series.Controls.Add(Me.Label4)
        Me.gb_series.Controls.Add(Me.cboempresa)
        Me.gb_series.Controls.Add(Me.Label1)
        Me.gb_series.Controls.Add(Me.Label2)
        Me.gb_series.Size = New System.Drawing.Size(399, 101)
        Me.gb_series.Controls.SetChildIndex(Me.Label2, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label1, 0)
        Me.gb_series.Controls.SetChildIndex(Me.cboempresa, 0)
        Me.gb_series.Controls.SetChildIndex(Me.btnnuevo, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label4, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtplaca, 0)
        Me.gb_series.Controls.SetChildIndex(Me.btncancelar, 0)
        Me.gb_series.Controls.SetChildIndex(Me.btnguardar, 0)
        Me.gb_series.Controls.SetChildIndex(Me.cbochofer, 0)
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(234, 66)
        Me.btncancelar.TabIndex = 4
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(315, 66)
        Me.btnguardar.TabIndex = 5
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(153, 66)
        Me.btnnuevo.TabIndex = 3
        '
        'uv
        '
        Me.uv.NotificationSettings.Action = Infragistics.Win.Misc.NotificationAction.None
        '
        'cbochofer
        '
        Me.cbochofer.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cbochofer.Location = New System.Drawing.Point(120, 38)
        Me.cbochofer.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.cbochofer.Name = "cbochofer"
        Me.cbochofer.Size = New System.Drawing.Size(170, 21)
        Me.cbochofer.TabIndex = 1
        Me.uv.GetValidationSettings(Me.cbochofer).IsRequired = True
        '
        'txtplaca
        '
        Me.txtplaca.AsciiOnly = True
        Me.txtplaca.Location = New System.Drawing.Point(11, 40)
        Me.txtplaca.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.txtplaca.Mask = "?&&&-###?"
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.Size = New System.Drawing.Size(100, 20)
        Me.txtplaca.TabIndex = 0
        Me.uv.GetValidationSettings(Me.txtplaca).IsRequired = True
        '
        'cboempresa
        '
        Me.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboempresa.FormattingEnabled = True
        Me.cboempresa.Items.AddRange(New Object() {"No", "Sí"})
        Me.cboempresa.Location = New System.Drawing.Point(302, 39)
        Me.cboempresa.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.cboempresa.Name = "cboempresa"
        Me.cboempresa.Size = New System.Drawing.Size(88, 21)
        Me.cboempresa.TabIndex = 2
        Me.uv.GetValidationSettings(Me.cboempresa).IsRequired = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Es de la empresa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Chofer:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Placa de rodaje:"
        '
        'gpsub
        '
        Me.gpsub.Controls.Add(Me.txtruc)
        Me.gpsub.Controls.Add(Me.Label5)
        Me.gpsub.Controls.Add(Me.txtsocial)
        Me.gpsub.Controls.Add(Me.Label3)
        Me.gpsub.Location = New System.Drawing.Point(418, 12)
        Me.gpsub.Name = "gpsub"
        Me.gpsub.Size = New System.Drawing.Size(269, 101)
        Me.gpsub.TabIndex = 7
        Me.gpsub.Text = "Empresa Sub-Contratada"
        Me.gpsub.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        Me.gpsub.Visible = False
        '
        'txtruc
        '
        Me.txtruc.Location = New System.Drawing.Point(163, 40)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(101, 20)
        Me.txtruc.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "RUC"
        '
        'txtsocial
        '
        Me.txtsocial.Location = New System.Drawing.Point(8, 40)
        Me.txtsocial.Name = "txtsocial"
        Me.txtsocial.Size = New System.Drawing.Size(149, 20)
        Me.txtsocial.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Razon Social"
        '
        'frmunidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(699, 584)
        Me.Controls.Add(Me.gpsub)
        Me.Name = "frmunidades"
        Me.Text = "Unidades de Transporte"
        Me.Controls.SetChildIndex(Me.gpsub, 0)
        Me.Controls.SetChildIndex(Me.gb_series, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_series, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_series.ResumeLayout(False)
        Me.gb_series.PerformLayout()
        CType(Me.uv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbochofer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpsub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpsub.ResumeLayout(False)
        Me.gpsub.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents uv As Infragistics.Win.Misc.UltraValidator
    Friend WithEvents cbochofer As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txtplaca As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboempresa As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gpsub As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsocial As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
