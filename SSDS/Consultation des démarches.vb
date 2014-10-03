Public Class Consultation_des_démarches

    Private Sub Fermer_Click(sender As Object, e As EventArgs) Handles Fermer.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bouton As Integer
        If (Tous.Checked) Then
            bouton = 2
        Else
            If (Actif.Checked) Then
                bouton = 1
            Else
                bouton = 0
            End If
        End If
        dgvEtudiants.DataSource = ListerUserByAllNPATableAdapter.GetData(TextBoxNomEtu.Text, TextBoxPrenomEtu.Text, bouton)

    End Sub


    Private Sub dgvEtudiants_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEtudiants.CellClick
        Dim dial As New GestionDesDemarches(dgvEtudiants.SelectedRows(0).Cells(0).Value)
        dial.Show()


    End Sub
End Class