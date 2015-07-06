Imports basedato
Imports MySql.Data.MySqlClient

Public Class frmadministradores
    Public db As mysqlbasedato
    Public dtmaestro As DataTable
    Public id As Integer
    Public Sub New(ByVal cn As mysqlbasedato)
        InitializeComponent()
        db = cn
        carga_datos()
        estform = estado_formulario.insertando
    End Sub
    Private Sub carga_datos()
        Dim sql As String = "select *,if(usutipo=0,'Administrador','Operario') as usutipo2 from ste_usuario"
        db.ejecutar(sql)
        dtmaestro = db.gettabla()
        grilla.DataSource = Nothing
        grilla.DataSource = dtmaestro
        grilla.DisplayLayout.Bands(0).Columns(0).Hidden = True
        grilla.DisplayLayout.Bands(0).Columns("usupassword").Hidden = True
        grilla.DisplayLayout.Bands(0).Columns("usuestado").Hidden = True
        grilla.DisplayLayout.Bands(0).Columns("usutipo").Hidden = True
        grilla.DisplayLayout.Bands(0).Columns("usuuser").Header.Caption = "Usuario"
        grilla.DisplayLayout.Bands(0).Columns("usunombres").Header.Caption = "Nombres"
        grilla.DisplayLayout.Bands(0).Columns("usuapellidos").Header.Caption = "Apellidos"
        grilla.DisplayLayout.Bands(0).Columns("usudni").Header.Caption = "DNI"
        grilla.DisplayLayout.Bands(0).Columns("usutipo2").Header.Caption = "Tipo"
        Dim cc As Object
        For Each cc In grilla.DisplayLayout.Bands(0).Columns
            cc.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Next
    End Sub
    Private Sub seleccionar(ByVal r As Integer)
        Dim dr As DataRow = dtmaestro.Select("idusuario=" + r.ToString)(0)
        Me.txtapellidos.Text = dr("usuapellidos")
        Me.txtdni.Text = dr("usudni")
        Me.txtnombres.Text = dr("usunombres")
        Me.txtpass1.Text = dr("usupassword")
        Me.txtpass2.Text = dr("usupassword")
        Me.txtuser.Text = dr("usuuser")
        Me.cbotipo.SelectedIndex = dr("usutipo")
        Me.cboactivo.SelectedIndex = dr("usuestado")
        id = r
    End Sub
    Private Sub grilla_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles grilla.AfterSelectChange
        If (grilla.Selected.Cells.Count > 0) Then
            Me.estform = estado_formulario.actualizando
            Dim c = grilla.Selected.Cells.Count - 1
            Dim r = grilla.Selected.Cells(c).Row.Cells("idusuario").Text
            seleccionar(r)
        End If
    End Sub
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.estform = estado_formulario.insertando
        Me.txtapellidos.Text = ""
        Me.txtdni.Text = ""
        Me.txtnombres.Text = ""
        Me.txtpass1.Text = ""
        Me.txtpass2.Text = ""
        Me.txtuser.Text = ""
        Me.cboactivo.SelectedIndex = 1
        Me.cbotipo.SelectedIndex = 0
    End Sub
    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Dim c = grilla.Selected.Cells.Count - 1
        Dim r = grilla.Selected.Cells(c).Row.Cells("idusuario").Text
        seleccionar(r)
    End Sub
    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Dim val As Infragistics.Win.Misc.Validation
        uv.GetValidationSettings(Me.txtpass2).Condition = New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Match, Me.txtpass1.Text)
        uv.GetValidationSettings(Me.txtpass1).Condition = New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Match, Me.txtpass2.Text)
        val = uv.Validate(True, False)
        Dim cb As New MySqlCommand()
        If (val.IsValid = True) Then
            cb.Parameters.Add("@usuuser", MySqlDbType.VarChar).Value = Me.txtuser.Text
            cb.Parameters.Add("@usupassword", MySqlDbType.VarChar).Value = Me.txtpass1.Text
            cb.Parameters.Add("@usunombres", MySqlDbType.VarChar).Value = Me.txtnombres.Text
            cb.Parameters.Add("@usuapellidos", MySqlDbType.VarChar).Value = Me.txtapellidos.Text
            cb.Parameters.Add("@usudni", MySqlDbType.VarChar).Value = Me.txtdni.Text
            cb.Parameters.Add("@usuestado", MySqlDbType.VarChar).Value = Me.cboactivo.SelectedIndex
            cb.Parameters.Add("@usutipo", MySqlDbType.VarChar).Value = Me.cbotipo.SelectedIndex
            cb.Parameters.Add("@idusuario", MySqlDbType.VarChar).Value = id
            If (estform = estado_formulario.insertando) Then
                cb.CommandText = "insert into ste_usuario values(null,@usuuser,md5(@usupassword),@usunombres,@usuapellidos,@usudni,@usuestado,@usutipo)"
                btnnuevo_Click(sender, e)
            Else
                cb.CommandText = "update ste_usuario set usuuser=@usuuser, usupassword=md5(@usupassword), usunombres=@usunombres, usuapellidos=@usuapellidos, usudni=@usudni, usuestado=@usuestado, usutipo=@usutipo where idusuario=@idusuario"
            End If
            db.ejecutar(cb)
            carga_datos()
        End If
    End Sub


    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f_usuuser.TextChanged, f_usuapellidos.TextChanged, f_usudni.TextChanged, f_usunombres.TextChanged
        Me.filtrar(CType(sender, TextBox).Tag, CType(sender, TextBox).Text)
    End Sub
End Class
