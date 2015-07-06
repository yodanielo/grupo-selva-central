<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("col1")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("col2")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("col3")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGrid1
        '
        Me.UltraGrid1.DataMember = Nothing
        Appearance21.BackColor = System.Drawing.SystemColors.Window
        Appearance21.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGrid1.DisplayLayout.Appearance = Appearance21
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UltraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance22.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance22.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.GroupByBox.Appearance = Appearance22
        Appearance23.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance23
        Me.UltraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance24.BackColor2 = System.Drawing.SystemColors.Control
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance24.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance = Appearance24
        Me.UltraGrid1.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGrid1.DisplayLayout.MaxRowScrollRegions = 1
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGrid1.DisplayLayout.Override.ActiveCellAppearance = Appearance13
        Appearance14.BackColor = System.Drawing.SystemColors.Highlight
        Appearance14.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGrid1.DisplayLayout.Override.ActiveRowAppearance = Appearance14
        Me.UltraGrid1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance15.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance15
        Appearance16.BorderColor = System.Drawing.Color.Silver
        Appearance16.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGrid1.DisplayLayout.Override.CellAppearance = Appearance16
        Me.UltraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGrid1.DisplayLayout.Override.CellPadding = 0
        Appearance17.BackColor = System.Drawing.SystemColors.Control
        Appearance17.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance17.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance17.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.Override.GroupByRowAppearance = Appearance17
        Appearance18.TextHAlignAsString = "Left"
        Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance18
        Me.UltraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.BorderColor = System.Drawing.Color.Silver
        Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance19
        Me.UltraGrid1.DisplayLayout.Override.RowFilterMode = Infragistics.Win.UltraWinGrid.RowFilterMode.AllRowsInBand
        Me.UltraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance20
        Me.UltraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGrid1.Location = New System.Drawing.Point(12, 37)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(619, 332)
        Me.UltraGrid1.TabIndex = 0
        Me.UltraGrid1.Text = "UltraGrid1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 458)
        Me.Controls.Add(Me.UltraGrid1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
