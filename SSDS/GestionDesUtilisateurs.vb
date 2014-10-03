
Public Class GestionDesUtilisateurs

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub GestionDesUtilisateurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet2.REF_TypeUtilisateur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.REF_TypeUtilisateurTableAdapter.Fill(Me.SSDSDataSet2.REF_TypeUtilisateur)
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet1.selectionRefTypUtilWithTous'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.SelectionRefTypUtilWithTousTableAdapter.Fill(Me.SSDSDataSet1.selectionRefTypUtilWithTous)
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.REF_TypeUtilisateur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.


    End Sub

    Private Sub Rechercher_Click(sender As Object, e As EventArgs) Handles Rechercher.Click
        Dim bouton As Integer
        If (Tous.Checked) Then
            bouton = 2
        Else
            If (Actifs.Checked) Then
                bouton = 1
            Else
                bouton = 0
            End If
        End If
        dgvEtudiants.DataSource = ListerUserByAllNPAWithTypeTableAdapter.GetData(TextBoxNom.Text, TextBoxPrenom.Text, bouton, Type.SelectedValue)

    End Sub

    Private Sub dgvEtudiants_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEtudiants.SelectionChanged
        Dim taEtudiant As New SSDSDataSetTableAdapters.selectionnerUtilisateurByIdTableAdapter
        Dim dtEtudiant As DataTable

        If dgvEtudiants.SelectedRows.Count > 0 Then
            dtEtudiant = taEtudiant.GetData(dgvEtudiants.SelectedRows(0).Cells(0).Value)
            If dtEtudiant.Rows.Count > 0 Then
                TextBoxDetailNom.Text = dtEtudiant.Rows(0)("nomUTIL")
                TextBoxDetailPrenom.Text = dtEtudiant.Rows(0)("prenomUTIL")
                TextBoxDetailCouriel.Text = dtEtudiant.Rows(0)("courielUTIL")
                DateCreation.Text = DateCreation.Text + " " + dtEtudiant.Rows(0)("dateCreation")
                DerniereModification.Text = DerniereModification.Text + " " + dtEtudiant.Rows(0)("dateModif")
                ComboBoxDetailType.SelectedValue = dtEtudiant.Rows(0)("noTYPUTIL")
                CheckBoxDetailActif.Checked = dtEtudiant.Rows(0)("estActif")
            End If
        Else

            TextBoxDetailNom.Text = ""
            TextBoxDetailPrenom.Text = ""
            TextBoxDetailCouriel.Text = ""
            DateCreation.Text = ""
            DerniereModification.Text = ""

        End If
    End Sub

End Class