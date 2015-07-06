Imports MySql.Data.MySqlClient

Public Class frmcambiarcontrasena
    Private db As basedato.mysqlbasedato
    Public Sub New(ByVal cn As basedato.mysqlbasedato, ByVal nomusuario as String)
        InitializeComponent()
        db = cn
        Me.txtuser.Text = nomusuario
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim val As Infragistics.Win.Misc.Validation
        db.ejecutar("select if(usupassword=md5('" + Me.txtanterior.Text + "'),'1','0') from ste_usuario where usuuser='" + Me.txtuser.Text + "'")
        If (db.getvalor = "0") Then
            uv.GetValidationSettings(Me.txtanterior).Condition = New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Match, Me.txtuser.Text + db.getvalor())
        Else
            uv.GetValidationSettings(Me.txtanterior).Condition = New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Match, Me.txtanterior.Text)
        End If
        uv.GetValidationSettings(Me.txtpass2).Condition = New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Match, Me.txtpass1.Text)
        val = uv.Validate(True, False)
        If (val.IsValid) Then
            Dim cm As New MySqlCommand()
            db.begin_transaction()
            cm.Parameters.Add("@user", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Me.txtuser.Text
            cm.Parameters.Add("@pass", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Me.txtpass1.Text
            cm.CommandText = "update ste_usuario set usupassword=md5(@pass) where usuuser=@user"
            db.ejecutar(cm)
            db.commit_transaction()
            MsgBox("El cambio de contraseña fue efectuado con éxito", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
End Class