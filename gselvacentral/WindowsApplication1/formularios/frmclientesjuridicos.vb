Imports MySql.Data.MySqlClient
Imports basedato

Public Class frmclientesjuridicos
    Private db As basedato.mysqlbasedato
    Private dtmaestro As DataTable
    Private id As Integer
    Public Sub New(ByVal cn As basedato.mysqlbasedato)
        InitializeComponent()
        db = cn
        carga_datos()
        estform = estado_formulario.insertando
    End Sub
    Private Sub carga_datos()
        Dim sql = "select idste_clijuridico,jurrazonsocial,cliruc,jurrepresentante from ste_cliente inner join ste_clijuridico on ste_clijuridico.idste_clijuridico=ste_cliente.idcliente"
        db.ejecutar(sql)
        dtmaestro = db.gettabla()
        grilla.DataSource = Nothing
        grilla.DataSource = dtmaestro
        grilla.DisplayLayout.Bands(0).Columns(0).Hidden = True
        grilla.DisplayLayout.Bands(0).Columns("jurrazonsocial").Header.Caption = "Razon Social"
        grilla.DisplayLayout.Bands(0).Columns("cliruc").Header.Caption = "RUC"
        grilla.DisplayLayout.Bands(0).Columns("jurrepresentante").Header.Caption = "Representante"
        Dim cc As Object
        For Each cc In grilla.DisplayLayout.Bands(0).Columns
            cc.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Next
    End Sub
    Private Sub seleccionar(ByVal r As Integer)
        Dim dr As DataRow = dtmaestro.Select("idste_clijuridico=" + r.ToString)(0)
        Me.txtrazonsocial.Text = dr("jurrazonsocial")
        Me.txtruc.Text = dr("cliruc")
        Me.txtrepresentante.Text = dr("jurrepresentante")
        estform = estado_formulario.actualizando
        id = r
    End Sub
    Private Sub grilla_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles grilla.AfterSelectChange
        If (grilla.Selected.Cells.Count > 0) Then
            Dim c = grilla.Selected.Cells.Count - 1
            Dim r = grilla.Selected.Cells(c).Row.Cells("idste_clijuridico").Text
            seleccionar(r)
        End If
    End Sub
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.estform = estado_formulario.insertando
        Me.txtrazonsocial.Text = ""
        Me.txtruc.Text = ""
        Me.txtrepresentante.Text = ""
    End Sub
    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Dim c = grilla.Selected.Cells.Count - 1
        Dim r = grilla.Selected.Cells(c).Row.Cells("idste_clijuridico").Text
        seleccionar(r)
    End Sub
    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Dim val As Infragistics.Win.Misc.Validation
        val = uv.Validate(True, False)
        If (val.IsValid = True) Then
            'insertar en clientes
            Dim cb1 As New MySqlCommand()
            cb1.Parameters.Add("@clitipo", MySqlDbType.Int16).Value = 1 '0=>natural
            cb1.Parameters.Add("@cliruc", MySqlDbType.VarChar).Value = Me.txtruc.Text
            cb1.Parameters.Add("@razsocial", MySqlDbType.VarChar).Value = Me.txtrazonsocial.Text
            cb1.Parameters.Add("@representante", MySqlDbType.VarChar).Value = Me.txtrepresentante.Text
            db.ejecutar("select valor+1 from incremento where criterio='cliente'")
            Dim lid As String
            If (estform = estado_formulario.insertando) Then
                '//incremento
                db.ejecutar("update incremento set valor=valor+1 where criterio='cliente'")
                '//inserto
                cb1.CommandText = "insert into ste_cliente values(null,@clitipo,@cliruc)"
                db.ejecutar(cb1)
                '//ultimo id
                db.ejecutar("select valor from incremento where criterio = 'cliente'")
                lid = db.getvalor().ToString()
                '//generalizacion
                cb1.Parameters.Add("@id", MySqlDbType.Int16).Value = lid
                cb1.CommandText = "insert into ste_clijuridico values (@id,@representante,@razsocial)"
                db.ejecutar(cb1)
            Else
                lid = id.ToString()
                cb1.Parameters.Add("@id", MySqlDbType.Int16).Value = lid
                cb1.CommandText = "update ste_cliente set cliruc=@cliruc where idcliente=@id"
                db.ejecutar(cb1)
                cb1.CommandText = "update ste_clijuridico set jurrepresentante=@representante, jurrazonsocial=@razsocial where idste_clijuridico=@id"
                db.ejecutar(cb1)
            End If
            btnnuevo_Click(Nothing, Nothing)
            carga_datos()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged, TextBox2.TextChanged, TextBox1.TextChanged
        Me.filtrar(CType(sender, TextBox).Tag, CType(sender, TextBox).Text)
    End Sub
End Class
