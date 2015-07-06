Public Class imprimir
    Private cn As basedato.mysqlbasedato

    Public Sub New(ByVal r As CrystalDecisions.CrystalReports.Engine.ReportClass)
        InitializeComponent()
        Me.CrystalReportViewer1.ReportSource = r
    End Sub
End Class