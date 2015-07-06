<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class padre
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
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(padre))
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.grilla = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.gb_series = New Infragistics.Win.Misc.UltraGroupBox
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnguardar = New System.Windows.Forms.Button
        Me.btnnuevo = New System.Windows.Forms.Button
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_series, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_series.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.grilla)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 119)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(675, 453)
        Me.UltraGroupBox1.TabIndex = 6
        Me.UltraGroupBox1.Text = "Seleccione una fila para editarla"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grilla
        '
        Me.grilla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance13.BackColor = System.Drawing.Color.White
        Appearance13.BackColor2 = System.Drawing.Color.White
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.grilla.DisplayLayout.Appearance = Appearance13
        Me.grilla.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grilla.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance24.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance24.BorderColor = System.Drawing.SystemColors.Window
        Me.grilla.DisplayLayout.GroupByBox.Appearance = Appearance24
        Appearance25.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grilla.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance25
        Me.grilla.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance26.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance26.BackColor2 = System.Drawing.SystemColors.Control
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance26.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grilla.DisplayLayout.GroupByBox.PromptAppearance = Appearance26
        Me.grilla.DisplayLayout.InterBandSpacing = 10
        Me.grilla.DisplayLayout.MaxColScrollRegions = 1
        Me.grilla.DisplayLayout.MaxRowScrollRegions = 1
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grilla.DisplayLayout.Override.ActiveCellAppearance = Appearance14
        Appearance15.BackColor = System.Drawing.SystemColors.Highlight
        Appearance15.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grilla.DisplayLayout.Override.ActiveRowAppearance = Appearance15
        Me.grilla.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grilla.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Me.grilla.DisplayLayout.Override.CardAreaAppearance = Appearance16
        Appearance17.BorderColor = System.Drawing.Color.Silver
        Appearance17.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grilla.DisplayLayout.Override.CellAppearance = Appearance17
        Me.grilla.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grilla.DisplayLayout.Override.CellPadding = 0
        Appearance18.BackColor = System.Drawing.SystemColors.Control
        Appearance18.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance18.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance18.BorderColor = System.Drawing.SystemColors.Window
        Me.grilla.DisplayLayout.Override.GroupByRowAppearance = Appearance18
        Appearance19.BackColor = System.Drawing.Color.Brown
        Appearance19.BackColor2 = System.Drawing.Color.Red
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance19.ForeColor = System.Drawing.Color.White
        Appearance19.TextHAlignAsString = "Left"
        Appearance19.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.grilla.DisplayLayout.Override.HeaderAppearance = Appearance19
        Me.grilla.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grilla.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance20.BorderColor = System.Drawing.Color.Red
        Me.grilla.DisplayLayout.Override.RowAppearance = Appearance20
        Appearance21.BackColor = System.Drawing.Color.Brown
        Appearance21.BackColor2 = System.Drawing.Color.Red
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.grilla.DisplayLayout.Override.RowSelectorAppearance = Appearance21
        Me.grilla.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.grilla.DisplayLayout.Override.RowSelectorWidth = 12
        Me.grilla.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance22.BackColor = System.Drawing.Color.Red
        Appearance22.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance22.ForeColor = System.Drawing.Color.Black
        Me.grilla.DisplayLayout.Override.SelectedRowAppearance = Appearance22
        Appearance23.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grilla.DisplayLayout.Override.TemplateAddRowAppearance = Appearance23
        Me.grilla.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.grilla.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.grilla.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grilla.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grilla.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grilla.Location = New System.Drawing.Point(5, 21)
        Me.grilla.Name = "grilla"
        Me.grilla.Size = New System.Drawing.Size(665, 427)
        Me.grilla.TabIndex = 0
        Me.grilla.Text = "UltraGrid1"
        '
        'gb_series
        '
        Me.gb_series.Controls.Add(Me.btncancelar)
        Me.gb_series.Controls.Add(Me.btnguardar)
        Me.gb_series.Controls.Add(Me.btnnuevo)
        Me.gb_series.Location = New System.Drawing.Point(12, 12)
        Me.gb_series.Name = "gb_series"
        Me.gb_series.Size = New System.Drawing.Size(480, 101)
        Me.gb_series.TabIndex = 5
        Me.gb_series.Text = "Series de Comprobantes de Pago"
        Me.gb_series.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(312, 69)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 15
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(393, 69)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 14
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(231, 69)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 7
        Me.btnnuevo.Text = "&Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'padre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 584)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.gb_series)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "padre"
        Me.Text = "padre"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_series, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_series.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Protected WithEvents grilla As Infragistics.Win.UltraWinGrid.UltraGrid
    Protected WithEvents gb_series As Infragistics.Win.Misc.UltraGroupBox
    Protected WithEvents btncancelar As System.Windows.Forms.Button
    Protected WithEvents btnguardar As System.Windows.Forms.Button
    Protected WithEvents btnnuevo As System.Windows.Forms.Button
End Class
