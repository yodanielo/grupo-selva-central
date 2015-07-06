Imports MySql.Data.MySqlClient

Public Class frmcamioneros
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
        Dim sql = "select * from ste_camionero"
        db.ejecutar(sql)
        dtmaestro = db.gettabla()
        grilla.DataSource = Nothing
        grilla.DataSource = dtmaestro
        grilla.DisplayLayout.Bands(0).Columns(0).Hidden = True
        grilla.DisplayLayout.Bands(0).Columns("camnombres").Header.Caption = "Nombres"
        grilla.DisplayLayout.Bands(0).Columns("camapellidos").Header.Caption = "Apellidos"
        grilla.DisplayLayout.Bands(0).Columns("camdni").Header.Caption = "DNI"
        grilla.DisplayLayout.Bands(0).Columns("camdireccion").Header.Caption = "Dirección"
        grilla.DisplayLayout.Bands(0).Columns("camlicencia").Header.Caption = "Licencia de conducir"
        grilla.DisplayLayout.Bands(0).Columns("camcategoria").Hidden = True
        Dim cc As Object
        For Each cc In grilla.DisplayLayout.Bands(0).Columns
            cc.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Next
    End Sub
    Private Sub seleccionar(ByVal r As Integer)
        estform = estado_formulario.actualizando
        Dim dr As DataRow = dtmaestro.Select("idcamionero=" + r.ToString)(0)
        Me.txtnombres.Text = dr("camnombres")
        Me.txtapellidos.Text = dr("camapellidos")
        Me.txtdni.Text = dr("camdni")
        Me.txtdireccion.Text = dr("camdireccion")
        Me.txtlic.Text = dr("camlicencia")
        Me.cbocategoria.SelectedIndex = dr("camcategoria")
        id = r
    End Sub
    Private Sub grilla_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles grilla.AfterSelectChange
        If (grilla.Selected.Cells.Count > 0) Then
            Dim c = grilla.Selected.Cells.Count - 1
            Dim r = grilla.Selected.Cells(c).Row.Cells("idcamionero").Text
            seleccionar(r)
        End If
    End Sub
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.estform = estado_formulario.insertando
        Me.txtnombres.Text = ""
        Me.txtapellidos.Text = ""
        Me.txtdni.Text = ""
        Me.txtdireccion.Text = ""
        Me.txtlic.Text = ""
        Me.cbocategoria.SelectedIndex = 0
    End Sub
    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Dim c = grilla.Selected.Cells.Count - 1
        Dim r = grilla.Selected.Cells(c).Row.Cells("idcamionero").Text
        seleccionar(r)
    End Sub
    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Dim val As Infragistics.Win.Misc.Validation
        val = uv.Validate(True, False)
        If (val.IsValid = True) Then
            Dim cb As New MySqlCommand()
            cb.Parameters.Add("@camnombres", MySqlDbType.VarChar).Value = Me.txtnombres.Text
            cb.Parameters.Add("@camapellidos", MySqlDbType.VarChar).Value = Me.txtapellidos.Text
            cb.Parameters.Add("@camdni", MySqlDbType.VarChar).Value = Me.txtdni.Text
            cb.Parameters.Add("@camdireccion", MySqlDbType.VarChar).Value = Me.txtdireccion.Text
            cb.Parameters.Add("@camlicencia", MySqlDbType.VarChar).Value = Me.txtlic.Text
            cb.Parameters.Add("@camcategoria", MySqlDbType.VarChar).Value = Me.cbocategoria.SelectedIndex
            If (estform = estado_formulario.insertando) Then
                cb.CommandText = "insert into ste_camionero values(null,@camnombres,@camapellidos,@camdni,@camdireccion,@camlicencia,@camcategoria)"
                btnnuevo_Click(sender, e)
            Else
                cb.CommandText = "update ste_camionero set camnombres=@camnombres,camapellidos=@camapellidos,camdni=@camdni,camdireccion=@camdireccion,camlicencia=@camlicencia,camcategoria=@camcategoria where idcamionero=" + id.ToString()
            End If
            db.ejecutar(cb)
            carga_datos()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged, TextBox3.TextChanged, TextBox2.TextChanged, TextBox1.TextChanged
        Me.filtrar(CType(sender, TextBox).Tag, CType(sender, TextBox).Text)
    End Sub
End Class
