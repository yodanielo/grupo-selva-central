<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadministradores
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
        Me.cboactivo = New System.Windows.Forms.ComboBox
        Me.cbotipo = New System.Windows.Forms.ComboBox
        Me.txtapellidos = New System.Windows.Forms.TextBox
        Me.txtnombres = New System.Windows.Forms.TextBox
        Me.txtpass2 = New System.Windows.Forms.TextBox
        Me.txtpass1 = New System.Windows.Forms.TextBox
        Me.txtuser = New System.Windows.Forms.TextBox
        Me.f_usudni = New System.Windows.Forms.TextBox
        Me.f_usunombres = New System.Windows.Forms.TextBox
        Me.f_usuuser = New System.Windows.Forms.TextBox
        Me.f_usuapellidos = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
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
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 153)
        Me.UltraGroupBox1.Size = New System.Drawing.Size(872, 419)
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
        Me.grilla.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
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
        Me.grilla.Size = New System.Drawing.Size(862, 393)
        '
        'gb_series
        '
        Me.gb_series.Controls.Add(Me.cboactivo)
        Me.gb_series.Controls.Add(Me.txtdni)
        Me.gb_series.Controls.Add(Me.txtnombres)
        Me.gb_series.Controls.Add(Me.Label4)
        Me.gb_series.Controls.Add(Me.Label1)
        Me.gb_series.Controls.Add(Me.Label8)
        Me.gb_series.Controls.Add(Me.txtuser)
        Me.gb_series.Controls.Add(Me.cbotipo)
        Me.gb_series.Controls.Add(Me.Label2)
        Me.gb_series.Controls.Add(Me.Label7)
        Me.gb_series.Controls.Add(Me.txtpass1)
        Me.gb_series.Controls.Add(Me.Label6)
        Me.gb_series.Controls.Add(Me.Label3)
        Me.gb_series.Controls.Add(Me.txtapellidos)
        Me.gb_series.Controls.Add(Me.txtpass2)
        Me.gb_series.Controls.Add(Me.Label5)
        Me.gb_series.Size = New System.Drawing.Size(456, 135)
        Me.gb_series.Controls.SetChildIndex(Me.Label5, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtpass2, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtapellidos, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label3, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label6, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtpass1, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label7, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label2, 0)
        Me.gb_series.Controls.SetChildIndex(Me.cbotipo, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtuser, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label8, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label1, 0)
        Me.gb_series.Controls.SetChildIndex(Me.Label4, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtnombres, 0)
        Me.gb_series.Controls.SetChildIndex(Me.txtdni, 0)
        Me.gb_series.Controls.SetChildIndex(Me.cboactivo, 0)
        Me.gb_series.Controls.SetChildIndex(Me.btncancelar, 0)
        Me.gb_series.Controls.SetChildIndex(Me.btnnuevo, 0)
        Me.gb_series.Controls.SetChildIndex(Me.btnguardar, 0)
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(288, 104)
        Me.btncancelar.TabIndex = 9
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(369, 104)
        Me.btnguardar.TabIndex = 10
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(207, 104)
        Me.btnnuevo.TabIndex = 8
        '
        'uv
        '
        Me.uv.NotificationSettings.Action = Infragistics.Win.Misc.NotificationAction.None
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(232, 78)
        Me.txtdni.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(100, 20)
        Me.txtdni.TabIndex = 6
        Me.uv.GetValidationSettings(Me.txtdni).Condition = New Infragistics.Win.RangeCondition("10000000", "99999999", GetType(Double))
        Me.uv.GetValidationSettings(Me.txtdni).IsRequired = True
        '
        'cboactivo
        '
        Me.cboactivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboactivo.FormattingEnabled = True
        Me.cboactivo.Items.AddRange(New Object() {"Inactivo", "Activo"})
        Me.cboactivo.Location = New System.Drawing.Point(344, 77)
        Me.cboactivo.Name = "cboactivo"
        Me.cboactivo.Size = New System.Drawing.Size(100, 21)
        Me.cboactivo.TabIndex = 7
        Me.uv.GetValidationSettings(Me.cboactivo).IsRequired = True
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Items.AddRange(New Object() {"Administrador", "Operario"})
        Me.cbotipo.Location = New System.Drawing.Point(344, 38)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(100, 21)
        Me.cbotipo.TabIndex = 3
        Me.uv.GetValidationSettings(Me.cbotipo).IsRequired = True
        '
        'txtapellidos
        '
        Me.txtapellidos.Location = New System.Drawing.Point(120, 78)
        Me.txtapellidos.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(100, 20)
        Me.txtapellidos.TabIndex = 5
        Me.uv.GetValidationSettings(Me.txtapellidos).IsRequired = True
        '
        'txtnombres
        '
        Me.txtnombres.Location = New System.Drawing.Point(8, 78)
        Me.txtnombres.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(100, 20)
        Me.txtnombres.TabIndex = 4
        Me.uv.GetValidationSettings(Me.txtnombres).IsRequired = True
        '
        'txtpass2
        '
        Me.txtpass2.Location = New System.Drawing.Point(232, 39)
        Me.txtpass2.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtpass2.Name = "txtpass2"
        Me.txtpass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass2.Size = New System.Drawing.Size(100, 20)
        Me.txtpass2.TabIndex = 2
        Me.uv.GetValidationSettings(Me.txtpass2).IsRequired = True
        '
        'txtpass1
        '
        Me.txtpass1.Location = New System.Drawing.Point(120, 39)
        Me.txtpass1.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtpass1.Name = "txtpass1"
        Me.txtpass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass1.Size = New System.Drawing.Size(100, 20)
        Me.txtpass1.TabIndex = 1
        Me.uv.GetValidationSettings(Me.txtpass1).IsRequired = True
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(8, 39)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(100, 20)
        Me.txtuser.TabIndex = 0
        Me.uv.GetValidationSettings(Me.txtuser).IsRequired = True
        '
        'f_usudni
        '
        Me.f_usudni.Location = New System.Drawing.Point(120, 39)
        Me.f_usudni.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.f_usudni.Name = "f_usudni"
        Me.f_usudni.Size = New System.Drawing.Size(100, 20)
        Me.f_usudni.TabIndex = 48
        Me.f_usudni.Tag = "usudni"
        Me.uv.GetValidationSettings(Me.f_usudni).Condition = New Infragistics.Win.RangeCondition("10000000", "99999999", GetType(Double))
        '
        'f_usunombres
        '
        Me.f_usunombres.Location = New System.Drawing.Point(8, 78)
        Me.f_usunombres.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.f_usunombres.Name = "f_usunombres"
        Me.f_usunombres.Size = New System.Drawing.Size(100, 20)
        Me.f_usunombres.TabIndex = 46
        Me.f_usunombres.Tag = "usunombres"
        '
        'f_usuuser
        '
        Me.f_usuuser.Location = New System.Drawing.Point(8, 39)
        Me.f_usuuser.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.f_usuuser.Name = "f_usuuser"
        Me.f_usuuser.Size = New System.Drawing.Size(100, 20)
        Me.f_usuuser.TabIndex = 45
        Me.f_usuuser.Tag = "usuuser"
        '
        'f_usuapellidos
        '
        Me.f_usuapellidos.Location = New System.Drawing.Point(120, 78)
        Me.f_usuapellidos.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.f_usuapellidos.Name = "f_usuapellidos"
        Me.f_usuapellidos.Size = New System.Drawing.Size(100, 20)
        Me.f_usuapellidos.TabIndex = 47
        Me.f_usuapellidos.Tag = "usuapellidos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(341, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Estado del usuario:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(341, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Tipo de usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(229, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "DNI:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(117, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Apellidos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Nombres:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Confirme Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Nombre de usuario:"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.Label13)
        Me.UltraGroupBox2.Controls.Add(Me.f_usudni)
        Me.UltraGroupBox2.Controls.Add(Me.f_usunombres)
        Me.UltraGroupBox2.Controls.Add(Me.Label9)
        Me.UltraGroupBox2.Controls.Add(Me.Label10)
        Me.UltraGroupBox2.Controls.Add(Me.f_usuuser)
        Me.UltraGroupBox2.Controls.Add(Me.Label11)
        Me.UltraGroupBox2.Controls.Add(Me.f_usuapellidos)
        Me.UltraGroupBox2.Controls.Add(Me.Label12)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(475, 12)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(233, 135)
        Me.UltraGroupBox2.TabIndex = 7
        Me.UltraGroupBox2.Text = "Buscar"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Nombres:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(-57, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Nombres:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 13)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Nombre de usuario:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(117, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "DNI:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(117, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Apellidos:"
        '
        'frmadministradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(896, 584)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Name = "frmadministradores"
        Me.Text = "Usuarios del Sistema"
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
    Friend WithEvents cboactivo As System.Windows.Forms.ComboBox
    Friend WithEvents uv As Infragistics.Win.Misc.UltraValidator
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents txtnombres As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtpass1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtapellidos As System.Windows.Forms.TextBox
    Friend WithEvents txtpass2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents f_usudni As System.Windows.Forms.TextBox
    Friend WithEvents f_usunombres As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents f_usuuser As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents f_usuapellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
