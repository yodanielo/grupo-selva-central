Imports MySql.Data.MySqlClient

Public Class frmunidades
    Private db As basedato.mysqlbasedato
    Private dtmaestro As DataTable
    Private id As Integer
    Public Sub New(ByVal cn As basedato.mysqlbasedato)
        InitializeComponent()
        db = cn
        carga_datos()
        estform = estado_formulario.insertando
        db.ejecutar("select idcamionero,concat(camnombres,' ',camapellidos) as chofer from ste_camionero")
        'esto no va pa otros forms
        Dim dt1 As DataTable = db.gettabla()
        Dim dr As DataRow
        For Each dr In dt1.Rows
            cbochofer.Items.Add(dr("idcamionero"), dr("chofer"))
        Next
    End Sub
    Private Sub carga_datos()
        Dim sql = "select idunidad,uniplaca,concat(camnombres,' ',camapellidos) as camchofer,unidelaempresa,if(unidelaempresa=0,'No','Sí') as empresa,razsocial,ruc from ste_unidad inner join ste_camionero where ste_unidad.uniidcamionero=ste_camionero.idcamionero"
        db.ejecutar(sql)
        dtmaestro = db.gettabla()
        grilla.DataSource = Nothing
        grilla.DataSource = dtmaestro
        grilla.DisplayLayout.Bands(0).Columns("idunidad").Header.Caption = "Constancia de Inscripción"
        grilla.DisplayLayout.Bands(0).Columns("uniplaca").Header.Caption = "Placa de Rodaje"
        grilla.DisplayLayout.Bands(0).Columns("camchofer").Header.Caption = "Chofer"
        grilla.DisplayLayout.Bands(0).Columns("unidelaempresa").Hidden = True
        grilla.DisplayLayout.Bands(0).Columns("empresa").Header.Caption = "De la empresa"
        grilla.DisplayLayout.Bands(0).Columns("razsocial").Hidden = True
        grilla.DisplayLayout.Bands(0).Columns("ruc").Hidden = True
        Dim cc As Object
        For Each cc In grilla.DisplayLayout.Bands(0).Columns
            cc.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Next
    End Sub
    Private Sub seleccionar(ByVal r As Integer)
        Dim dr As DataRow = dtmaestro.Select("idunidad=" + r.ToString)(0)
        Me.txtplaca.Text = dr("uniplaca")
        Me.cbochofer.Text = dr("camchofer")
        Me.cboempresa.SelectedIndex = dr("unidelaempresa")
        Me.txtsocial.Text = dr("razsocial").ToString()
        Me.txtruc.Text = dr("ruc").ToString()
        estform = estado_formulario.actualizando
        id = r
    End Sub
    Private Sub grilla_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles grilla.AfterSelectChange
        If (grilla.Selected.Cells.Count > 0) Then
            Dim c = grilla.Selected.Cells.Count - 1
            Dim r = grilla.Selected.Cells(c).Row.Cells("idunidad").Text
            seleccionar(r)
        End If
    End Sub
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.estform = estado_formulario.insertando
        Me.txtplaca.Text = ""
        Me.cbochofer.SelectedIndex = 0
        Me.cboempresa.SelectedIndex = 0
    End Sub
    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Dim c = grilla.Selected.Cells.Count - 1
        Dim r = grilla.Selected.Cells(c).Row.Cells("idunidad").Text
        seleccionar(r)
    End Sub
    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Dim val As Infragistics.Win.Misc.Validation
        val = uv.Validate(True, False)
        If (val.IsValid = True) Then
            Dim cb As New MySqlCommand()
            cb.Parameters.Add("@uniplaca", MySqlDbType.VarChar).Value = Me.txtplaca.Text
            cb.Parameters.Add("@uniidcamionero", MySqlDbType.Int16).Value = cbochofer.SelectedItem.DataValue
            cb.Parameters.Add("@unidelaempresa", MySqlDbType.Int16).Value = Me.cboempresa.SelectedIndex
            If (Me.cboempresa.SelectedIndex = 1) Then
                cb.Parameters.Add("@razocial", MySqlDbType.VarChar).Value = Me.txtsocial.Text
                cb.Parameters.Add("@ruc", MySqlDbType.VarChar).Value = Me.txtruc.Text
            Else
                cb.Parameters.Add("@razocial", MySqlDbType.VarChar).Value = ""
                cb.Parameters.Add("@ruc", MySqlDbType.VarChar).Value = ""
            End If
            If (estform = estado_formulario.insertando) Then
                cb.CommandText = "insert into ste_unidad values(null,@uniplaca,@uniidcamionero,@unidelaempresa,@razocial,@ruc)"
                btnnuevo_Click(sender, e)
            Else
                cb.CommandText = "update ste_unidad set uniplaca=@uniplaca,uniidcamionero=@uniidcamionero,unidelaempresa=@unidelaempresa,razsocial=@razocial,ruc=@ruc where idunidad=" + id.ToString()
            End If
            db.ejecutar(cb)
            carga_datos()
        End If
    End Sub

    Private Sub cboempresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboempresa.SelectedIndexChanged
        If (cboempresa.SelectedIndex = 1) Then
            gpsub.Visible = True
        Else
            gpsub.Visible = False
        End If
    End Sub
End Class
