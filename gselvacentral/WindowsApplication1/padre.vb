Public Class padre
    Protected estform As estado_formulario
    Protected Sub filtrar(ByVal campo As String, ByVal valor As String)
        If (Trim(valor) <> "") Then
            If (grilla.Rows.ColumnFilters(campo).FilterConditions.Count = 0) Then
                Dim a As Infragistics.Win.UltraWinGrid.FilterCondition = New Infragistics.Win.UltraWinGrid.FilterCondition()
                a.ComparisionOperator = Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Contains
                grilla.DisplayLayout.Bands(0).ColumnFilters(campo).FilterConditions.Add(a)
            End If
            grilla.DisplayLayout.Bands(0).ColumnFilters(campo).FilterConditions(0).CompareValue = valor
        Else
            grilla.DisplayLayout.Bands(0).ColumnFilters(campo).FilterConditions.Clear()
        End If
    End Sub
End Class