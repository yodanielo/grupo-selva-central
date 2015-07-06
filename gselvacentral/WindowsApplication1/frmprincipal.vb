Imports basedato

Public Class frmprincipal
    Private cn As New mysqlbasedato("localhost", "gselvacentraldb", "root", "")
    Public nomusuario As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmprincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, btncerrarsession.Click
        Dim a As New login(cn, Me)
        a.Show(Me)
    End Sub

    Private Sub btnseries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseries.Click
        Dim a As New frmseries(cn)
        a.Show()
        a.MdiParent = Me
    End Sub
    Private Sub btnadministradores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadministradores.Click
        Dim a As New frmadministradores(cn)
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub btncamioneros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncamioneros.Click
        Dim a As New frmcamioneros(cn)
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub btnunidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnunidades.Click
        Dim a As New frmunidades(cn)
        a.MdiParent = Me
        a.Show()
    End Sub
    Private Sub PersonasNaturalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonasNaturalesToolStripMenuItem.Click
        Dim a As New frmclientesnaturales(cn)
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub PersonasJurídicasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonasJurídicasToolStripMenuItem.Click
        Dim a As New frmclientesjuridicos(cn)
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub btnacercade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnacercade.Click
        Dim a As New AboutBox1
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim a As New frmcambiarcontrasena(cn,me.nomusuario)
        a.MdiParent = Me
        a.Show()
    End Sub

    Private Sub btningresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresos.Click
        Dim a As New frmingresos(cn)
        a.MdiParent = Me
        a.Show()
    End Sub
End Class
