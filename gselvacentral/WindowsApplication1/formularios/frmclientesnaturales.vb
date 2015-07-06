Imports MySql.Data.MySqlClient
Imports basedato

Public Class frmclientesnaturales
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
        Dim sql = "select idclinatural,natnombres,natapellidos,natdni,cliruc from ste_cliente inner join ste_clinatural on ste_clinatural.idclinatural=ste_cliente.idcliente"
        db.ejecutar(sql)
        dtmaestro = db.gettabla()
        grilla.DataSource = Nothing
        grilla.DataSource = dtmaestro
        grilla.DisplayLayout.Bands(0).Columns(0).Hidden = True
        grilla.DisplayLayout.Bands(0).Columns("natnombres").Header.Caption = "Nombres"
        grilla.DisplayLayout.Bands(0).Columns("natapellidos").Header.Caption = "Apellidos"
        grilla.DisplayLayout.Bands(0).Columns("natdni").Header.Caption = "DNI"
        grilla.DisplayLayout.Bands(0).Columns("cliruc").Header.Caption = "RUC"
        Dim cc As Object
        For Each cc In grilla.DisplayLayout.Bands(0).Columns
            cc.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Next
    End Sub
    Private Sub seleccionar(ByVal r As Integer)
        Dim dr As DataRow = dtmaestro.Select("idclinatural=" + r.ToString)(0)
        Me.txtnombres.Text = dr("natnombres")
        Me.txtapellidos.Text = dr("natapellidos")
        Me.txtdni.Text = dr("natdni")
        Me.txtruc.Text = dr("cliruc")
        estform = estado_formulario.actualizando
        id = r
    End Sub
    Private Sub grilla_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles grilla.AfterSelectChange
        If (grilla.Selected.Cells.Count > 0) Then
            Dim c = grilla.Selected.Cells.Count - 1
            Dim r = grilla.Selected.Cells(c).Row.Cells("idclinatural").Text
            seleccionar(r)
        End If
    End Sub
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.estform = estado_formulario.insertando
        Me.txtapellidos.Text = ""
        Me.txtdni.Text = ""
        Me.txtnombres.Text = ""
        Me.txtruc.Text = ""
    End Sub
    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Dim c = grilla.Selected.Cells.Count - 1
        Dim r = grilla.Selected.Cells(c).Row.Cells("idclinatural").Text
        seleccionar(r)
    End Sub
    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Dim val As Infragistics.Win.Misc.Validation
        val = uv.Validate(True, False)
        If (val.IsValid = True) Then
            'insertar en clientes
            Dim cb1 As New MySqlCommand()
            cb1.Parameters.Add("@clitipo", MySqlDbType.Int16).Value = 0 '0=>natural
            cb1.Parameters.Add("@cliruc", MySqlDbType.VarChar).Value = Me.txtruc.Text
            cb1.Parameters.Add("@natnombres", MySqlDbType.VarChar).Value = Me.txtnombres.Text
            cb1.Parameters.Add("@natapellidos", MySqlDbType.VarChar).Value = Me.txtapellidos.Text
            cb1.Parameters.Add("@natdni", MySqlDbType.VarChar).Value = Me.txtdni.Text

            Dim lid As String
            If (estform = estado_formulario.insertando) Then
                cb1.CommandText = "insert into ste_cliente values(null,@clitipo,@cliruc)"
                db.ejecutar("update incremento set valor=valor+1 where criterio='cliente'")
                db.ejecutar("select valor+1 from incremento where criterio='cliente'")
                lid = db.getvalor().ToString()
                db.ejecutar(cb1)
                cb1.Parameters.Add("@id", MySqlDbType.VarChar).Value = lid
                cb1.CommandText = "insert into ste_clinatural values(@id,@natnombres,@natapellidos,@natdni)"
                db.ejecutar(cb1)
            Else
                cb1.CommandText = "update ste_cliente set cliruc=@cliruc where idcliente=" & id.ToString()
                db.ejecutar(cb1)
                lid = id.ToString()
                cb1.Parameters.Add("@id", MySqlDbType.VarChar).Value = lid
                cb1.CommandText = "update ste_clinatural set natnombres=@natnombres,natapellidos=@natapellidos, natdni=@natdni where idclinatural=" & id
                db.ejecutar(cb1)
            End If
            btnnuevo_Click(Nothing, Nothing)
            carga_datos()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged, TextBox1.TextChanged, TextBox3.TextChanged
        Me.filtrar(CType(sender, TextBox).Tag, CType(sender, TextBox).Text)
    End Sub
End Class
