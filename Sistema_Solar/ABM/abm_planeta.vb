Public Class abm_planeta
    

    Private Sub abm_planeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Inicio
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Dim objplaneta As BE.Planeta

        BLL.Planeta()




    End Sub
End Class