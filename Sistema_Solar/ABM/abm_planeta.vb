Public Class abm_planeta

    Private Sub abm_planeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Inicio
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objplaneta As New BE.Planeta

        objplaneta.pNombre = txtNombre.Text
        objplaneta.pDiametro = txtDiametro.Text
        objplaneta.pTemperatura = txtTemp.Text
        objplaneta.pOrden = txtOrden.Text
        objplaneta.pClasificacion = cbClasifica.SelectedText



    End Sub
End Class