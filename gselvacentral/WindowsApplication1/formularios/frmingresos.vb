Imports CrystalDecisions.Shared
Public Class frmingresos
    Private db As basedato.mysqlbasedato

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim ds = New DataSet("ingresos_diarios")
        Dim sql As String
        Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportClass = New reportediario()
        Dim parametro As ParameterDiscreteValue = New ParameterDiscreteValue()
        Dim paramlist As ParameterFields = New ParameterFields()
        sql = "select idcliente,clitipo,idenvio,if(clitipo=0,(select concat(natnombres,' ',natapellidos) from ste_clinatural where idclinatural=idcliente),(select jurrazonsocial from ste_clijuridico where idste_clijuridico=idcliente)) as nomcliente ," & _
                " (select sum(a.dencantidad*a.denpreciounitario) from ste_detalleenvio a where a.denidenvio=ste_envio.idenvio) as total," & _
                " concat(ste_unidad.uniplaca,' - ',ste_camionero.camnombres,' ',ste_camionero.camapellidos) as unidad" & _
                "        from(ste_cliente)" & _
                " inner join ste_envio on ste_cliente.idcliente=ste_envio.envidcliente" & _
                " inner join ste_unidad on ste_envio.idunidad=ste_unidad.idunidad" & _
                " inner join ste_camionero on ste_unidad.uniidcamionero=ste_camionero.idcamionero" & _
                " where ste_envio.envfecha_registro='" & dtp1.Value.Year & "-" & dtp1.Value.Month & "-" & dtp1.Value.Day & "'"
        db.ejecutar(sql)
        ds.Tables.Add(db.gettabla())
        ds.WriteXmlSchema("./ingresos.xml")

        parametro.Value = dtp1.Text
        paramlist.Add("fecha", ParameterValueKind.StringParameter, DiscreteOrRangeKind.DiscreteValue).CurrentValues.Add(parametro)

        rpt.SetDataSource(ds)
        Dim frmr As New imprimir(rpt)
        frmr.CrystalReportViewer1.ParameterFieldInfo = paramlist
        frmr.ShowDialog(Me)
    End Sub

    Public Sub New(ByVal cn As basedato.mysqlbasedato)
        InitializeComponent()
        Me.db = cn
    End Sub
End Class