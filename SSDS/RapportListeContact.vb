Public Class RapportListeContact

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.rapportListeContactParEntreprise'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.rapportListeContactParEntrepriseTableAdapter.Fill(Me.SSDSDataSet.rapportListeContactParEntreprise)
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.selectionUsersWithTous'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.SelectionUsersWithTousTableAdapter.Fill(Me.SSDSDataSet.selectionUsersWithTous)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.rapportListeContactParEntrepriseTableAdapter.Fill(Me.SSDSDataSet.rapportListeContactParEntreprise, ComboBox1.SelectedValue)
        ReportViewer1.RefreshReport()
    End Sub
End Class