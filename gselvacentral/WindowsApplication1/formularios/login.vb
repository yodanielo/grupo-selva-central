Imports basedato
Public Class login
    Private db As mysqlbasedato
    Private correcto = False
    Private f As frmprincipal
    Private intentos As Integer
    Public Sub New(ByVal conn As mysqlbasedato, ByVal ff As frmprincipal)
        InitializeComponent()
        db = conn
        f = ff
        ff.Enabled = False
    End Sub
    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        db.ejecutar("select count(*) from ste_usuario where usuestado=1 and usutipo=0 and usuuser='" + Me.txtuser.Text + "' and usupassword=md5('" + Me.txtcontrasena.Text + "')")
        If (CType(db.getvalor(), Integer) = 1) Then
            correcto = True
            Me.f.nomusuario = Me.txtuser.Text
            Me.Close()
        Else
            intentos = intentos + 1
            If (intentos < 3) Then
                MsgBox("Usuario o contraseña erronea", MsgBoxStyle.Exclamation)
                Me.txtcontrasena.Text = ""
                Me.txtuser.Text = ""
            Else
                MsgBox("Ah excedido el numero de intentos permitidos, el programa se cerrará", MsgBoxStyle.Exclamation)
                End
            End If
        End If
    End Sub

    Private Sub login_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (Not correcto = True) Then
            End
        Else
            f.Enabled = True
        End If
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        End
    End Sub
End Class