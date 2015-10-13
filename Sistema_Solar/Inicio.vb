Public Class Inicio
    Dim m_ChildFormNumber As Integer

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub AltaPlanetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaPlanetaToolStripMenuItem.Click
        Dim mdiabmobj As New abm_planeta
        CerrarFormularios()
        mdiabmobj.Show()
    End Sub


    Private Sub CerrarFormularios()
        For Each mFrm As Form In Me.MdiChildren
            If Not IsNothing(mFrm) Then
                mFrm.Close()
            End If
        Next
    End Sub

End Class