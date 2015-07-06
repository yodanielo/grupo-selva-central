Imports basedato
Imports MySql.Data.MySqlClient
Public Class frmseries
    Private db As mysqlbasedato
    Private dtmaestro As DataTable
    Private id As Integer
    Public Sub New(ByVal conn As mysqlbasedato)
        InitializeComponent()
        db = conn
        carga_datos()
        btnnuevo_Click(Nothing, Nothing)
    End Sub
    Private Sub carga_datos()
        Dim sql = "select idserie,sertipo,if(sertipo=0,'Boleta de venta','Factura') as sertipo1,sernumero,servalmin,servalmax from ste_serie"
        db.ejecutar(sql)
        dtmaestro = db.gettabla()
        grilla.DataSource = Nothing
        grilla.DataSource = dtmaestro
        grilla.DisplayLayout.Bands(0).Columns(0).Hidden = True
        grilla.DisplayLayout.Bands(0).Columns(1).Hidden = True
        grilla.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Tipo de Comprobante"
        grilla.DisplayLayout.Bands(0).Columns(3).Header.Caption = "Nº de Serie"
        grilla.DisplayLayout.Bands(0).Columns(4).Header.Caption = "Valor Mínimo"
        grilla.DisplayLayout.Bands(0).Columns(5).Header.Caption = "Valor Máximo"
        grilla.DisplayLayout.Bands(0).Columns(1).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        grilla.DisplayLayout.Bands(0).Columns(2).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        grilla.DisplayLayout.Bands(0).Columns(3).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        grilla.DisplayLayout.Bands(0).Columns(4).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        grilla.DisplayLayout.Bands(0).Columns(5).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
    End Sub
    Private Sub seleccionar(ByVal r As Integer)
        Dim dr As DataRow = dtmaestro.Select("idserie=" + r.ToString)(0)
        Me.cmbtipcomprobante.SelectedIndex = dr("sertipo")
        Me.txtnrodeserie.Text = dr("sernumero")
        Me.txtvalmin.Text = dr("servalmin")
        Me.txtvalmax.Text = dr("servalmax")
        Me.estform = estado_formulario.actualizando
        id = r
    End Sub
    Private Sub grilla_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles grilla.AfterSelectChange
        If (grilla.Selected.Cells.Count > 0) Then
            Dim c = grilla.Selected.Cells.Count - 1
            Dim r = grilla.Selected.Cells(c).Row.Cells("idserie").Text
            seleccionar(r)
        End If
    End Sub
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.estform = estado_formulario.insertando
        Me.txtnrodeserie.Text = ""
        Me.txtvalmin.Text = 0
        Me.txtvalmax.Text = 0
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Dim c = grilla.Selected.Cells.Count - 1
        Dim r = grilla.Selected.Cells(c).Row.Cells("idserie").Text
        seleccionar(r)
    End Sub
    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Dim val As Infragistics.Win.Misc.Validation
        val = uv.Validate(True, False)
        If (val.IsValid = True) Then
            Dim cb As New MySqlCommand()
            cb.Parameters.Add("@sertipo", MySqlDbType.Int16).Value = Me.cmbtipcomprobante.SelectedIndex
            cb.Parameters.Add("@sernumero", MySqlDbType.Int16).Value = Me.txtnrodeserie.Text
            cb.Parameters.Add("@servalmin", MySqlDbType.Int16).Value = Me.txtvalmin.Text
            cb.Parameters.Add("@servalmax", MySqlDbType.Int16).Value = Me.txtvalmax.Text
            If (estform = estado_formulario.insertando) Then
                cb.CommandText = "insert into ste_serie values(null,@sertipo,@sernumero,@servalmin,@servalmax)"
                btnnuevo_Click(Me, e)
            Else
                cb.CommandText = "update ste_serie set sertipo=@sertipo, sernumero=@sernumero,servalmin=@servalmin,servalmax=@servalmax where idserie=" + id.ToString()
            End If
            db.ejecutar(cb)
            carga_datos()
        End If
    End Sub

    Private Sub frmseries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
