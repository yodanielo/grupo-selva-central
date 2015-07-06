<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcamioneros
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
        Me.txtdni = New System.Windows.Forms.TextBox
        Me.txtapellidos = New System.Windows.Forms.TextBox
        Me.txtnombres = New System.Windows.Forms.TextBox
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.cbocategoria = New System.Windows.Forms.ComboBox
        Me.txtlic = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
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
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 156)
        Me.UltraGroupBox1.Size = New System.Drawing.Size(661, 416)
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
        Me.grilla.Size = New System.Drawing.Size(651, 390)
        '
        'gb_series
        '
        Me.gb_series.Controls.Add(Me.txtdireccion)
        Me.gb_series.Controls.Add(Me.Label3)
        Me.gb_series.Controls.Add(Me.cbocategoria)
        Me.gb_series.Controls.Add(Me.Label2)
        Me.gb_series.Controls.Add(Me.txtlic)
        Me.gb_series.Controls.Add(Me.Label1)
        Me.gb_series.Controls.Add(Me.txtdni)
        Me.gb_series.Controls.Add(Me.Label6)
        Me.gb_series.Controls.Add(Me.Label4)
        Me.gb_series.Controls.Add(Me.txtapellidos)
        Me.gb_series.Controls.Add(Me.txtnombres)
        Me.gb_series.Controls.Add(Me.Label5)
        Me.gb_series.Size = New System.Drawing.Size(363, 138)
        Me.gb_series.TabIndex = 0
        Me.gb_series.Controls.SetChildIndex(Me.Label5, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtnombres, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtapellidos, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label4, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label6, 0)
        Me.gb_series.Controls.SetChildIndex(Me.btncancelar, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtdni, 0)
        Me.gb_series.Controls.SetChildIndex(Me.btnnuevo, 0)
        Me.gb_series.Controls.SetChildIndex(Me.btnguardar, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label1, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtlic, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label2, 0)
        Me.gb_series.Controls.SetChildIndex(Me.cbocategoria, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label3, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtdireccion, 0)
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(197, 104)
        Me.btncancelar.TabIndex = 14
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(278, 104)
        Me.btnguardar.TabIndex = 0
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(116, 104)
        Me.btnnuevo.TabIndex = 13
        '
        'uv
        '
        Me.uv.NotificationSettings.Action = Infragistics.Win.Misc.NotificationAction.None
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(232, 39)
        Me.txtdni.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(121, 20)
        Me.txtdni.TabIndex = 9
        Me.uv.GetValidationSettings(Me.txtdni).Condition = New Infragistics.Win.RangeCondition("10000000", "99999999", GetType(Double))
        Me.uv.GetValidationSettings(Me.txtdni).IsRequired = True
        '
        'txtapellidos
        '
        Me.txtapellidos.Location = New System.Drawing.Point(120, 39)
        Me.txtapellidos.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(100, 20)
        Me.txtapellidos.TabIndex = 8
        Me.uv.GetValidationSettings(Me.txtapellidos).IsRequired = True
        '
        'txtnombres
        '
        Me.txtnombres.Location = New System.Drawing.Point(8, 39)
        Me.txtnombres.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(100, 20)
        Me.txtnombres.TabIndex = 7
        Me.uv.GetValidationSettings(Me.txtnombres).IsRequired = True
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(8, 78)
        Me.txtdireccion.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtdireccion.TabIndex = 10
        Me.uv.GetValidationSettings(Me.txtdireccion).IsRequired = True
        '
        'cbocategoria
        '
        Me.cbocategoria.FormattingEnabled = True
        Me.cbocategoria.Items.AddRange(New Object() {"Uno", "Dos B", "Tres profesional", "Especializado B", "Especializado C"})
        Me.cbocategoria.Location = New System.Drawing.Point(232, 77)
        Me.cbocategoria.Name = "cbocategoria"
        Me.cbocategoria.Size = New System.Drawing.Size(121, 21)
        Me.cbocategoria.TabIndex = 12
        Me.uv.GetValidationSettings(Me.cbocategoria).IsRequired = True
        '
        'txtlic
        '
        Me.txtlic.Location = New System.Drawing.Point(120, 78)
        Me.txtlic.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtlic.MaxLength = 10
        Me.txtlic.Name = "txtlic"
        Me.txtlic.Size = New System.Drawing.Size(100, 20)
        Me.txtlic.TabIndex = 11
        Me.uv.GetValidationSettings(Me.txtlic).Condition = New Infragistics.Win.RangeCondition(999999999, CType(9999999999, Long), GetType(Double))
        Me.uv.GetValidationSettings(Me.txtlic).IsRequired = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(141, 76)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 53
        Me.TextBox1.Tag = "camlicencia"
        Me.uv.GetValidationSettings(Me.TextBox1).Condition = New Infragistics.Win.RangeCondition(999999999, CType(9999999999, Long), GetType(Double))
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(141, 37)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 52
        Me.TextBox2.Tag = "camapellidos"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(8, 38)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(121, 20)
        Me.TextBox3.TabIndex = 51
        Me.TextBox3.Tag = "camnombres"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(8, 76)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(121, 20)
        Me.TextBox4.TabIndex = 51
        Me.TextBox4.Tag = "camdni"
        Me.uv.GetValidationSettings(Me.TextBox4).Condition = New Infragistics.Win.RangeCondition("10000000", "99999999", GetType(Double))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(229, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "DNI:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(117, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Apellidos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Nombres:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Direccion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Categoría"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Licencia de conducir:"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.TextBox4)
        Me.UltraGroupBox2.Controls.Add(Me.TextBox1)
        Me.UltraGroupBox2.Controls.Add(Me.Label10)
        Me.UltraGroupBox2.Controls.Add(Me.Label8)
        Me.UltraGroupBox2.Controls.Add(Me.Label7)
        Me.UltraGroupBox2.Controls.Add(Me.Label9)
        Me.UltraGroupBox2.Controls.Add(Me.TextBox3)
        Me.UltraGroupBox2.Controls.Add(Me.TextBox2)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(382, 13)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(252, 137)
        Me.UltraGroupBox2.TabIndex = 7
        Me.UltraGroupBox2.Text = "Buscar"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "DNI:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Nombres:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(138, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Licencia de conducir:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(138, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Apellidos:"
        '
        'frmcamioneros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(685, 584)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Name = "frmcamioneros"
        Me.Text = "Choferes"
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
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents uv As Infragistics.Win.Misc.UltraValidator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbocategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtlic As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtapellidos As System.Windows.Forms.TextBox
    Friend WithEvents txtnombres As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class
