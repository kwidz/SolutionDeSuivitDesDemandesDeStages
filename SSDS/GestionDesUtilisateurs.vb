Imports SSDS.SSDSDataSetTableAdapters

Public Class GestionDesUtilisateurs

    Enum Intention
        Ajouter
        Aucune
        Modifier
    End Enum

    Private ActionEnCours As Intention = Intention.Aucune

    Private Sub frmGestionProduits_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (ActionEnCours <> Intention.Aucune) Then
            If MsgBox("Les données en cours de modification seront perdues.  Désirez-vous fermer le formulaire?", MsgBoxStyle.YesNo, _
                    "Attention!") = vbNo Then
                ' interrompre la fermeture du formulaire
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub GestionDesUtilisateurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet2.REF_TypeUtilisateur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.REF_TypeUtilisateurTableAdapter.Fill(Me.SSDSDataSet2.REF_TypeUtilisateur)
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet1.selectionRefTypUtilWithTous'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.SelectionRefTypUtilWithTousTableAdapter.Fill(Me.SSDSDataSet1.selectionRefTypUtilWithTous)
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.REF_TypeUtilisateur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        ActiverRecherche(True)
        ActiverResultats(True)
        ActiverDetails(False)

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
        gbResultats.Text = "Résultats (" + CStr(dgvEtudiants.Rows.Count) + ")"
        ActiverRecherche(True)
        ActiverResultats(True)
        ActiverDetails(False)
    End Sub

    Private Sub dgvEtudiants_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEtudiants.SelectionChanged
        afficherDetails()
    End Sub

    Private Sub RafraichirResultats()
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
        gbResultats.Text = "Résultats (" + CStr(dgvEtudiants.Rows.Count) + ")"
    End Sub

    Private Sub afficherDetails()
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








    Private Sub ActiverRecherche(ByVal blnEnabled As Boolean)
        TextBoxPrenom.Enabled = blnEnabled
        TextBoxNom.Enabled = blnEnabled
        Actifs.Enabled = blnEnabled
        Inactifs.Enabled = blnEnabled
        Tous.Enabled = blnEnabled
        Rechercher.Enabled = blnEnabled
    End Sub

    Private Sub ActiverResultats(ByVal blnEnabled As Boolean)
        dgvEtudiants.Enabled = blnEnabled
        btnAjouter.Enabled = blnEnabled

        If dgvEtudiants.RowCount > 0 Then
            btnModifier.Enabled = blnEnabled
            btnSupprimer.Enabled = blnEnabled
        Else
            btnModifier.Enabled = False
            btnSupprimer.Enabled = False
        End If
    End Sub

    Private Sub ActiverDetails(ByVal blnEnabled As Boolean)
        TextBoxDetailNom.Enabled = blnEnabled
        TextBoxDetailPrenom.Enabled = blnEnabled
        TextBoxDetailCouriel.Enabled = blnEnabled
        ComboBoxDetailType.Enabled = blnEnabled
        CheckBoxDetailActif.Enabled = blnEnabled
        btnSauvegarder.Enabled = blnEnabled
        btnAnnuler.Enabled = blnEnabled
        Type.Enabled = blnEnabled
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        ActiverRecherche(False)
        ActiverResultats(False)
        ActiverDetails(True)

        ActionEnCours = Intention.Ajouter

        TextBoxDetailNom.Text = ""
        TextBoxDetailPrenom.Text = ""
        TextBoxDetailCouriel.Text = ""
        DateCreation.Text = ""
        DerniereModification.Text = ""

        TextBoxDetailNom.Focus()
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        ActiverRecherche(False)
        ActiverResultats(False)
        ActiverDetails(True)

        ActionEnCours = Intention.Modifier

        TextBoxDetailNom.Focus()

    End Sub


    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        ActiverRecherche(True)
        ActiverResultats(True)
        ActiverDetails(False)
        ActionEnCours = Intention.Aucune

        ' on veut remettre les données originales dans les contrôles
        afficherDetails()
    End Sub

    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs) Handles btnSauvegarder.Click

        If ValiderDonnees() Then
            Dim monDataset As New QueriesTableAdapter

            
            Select Case ActionEnCours
                Case Intention.Ajouter
                    MsgBox(Type.SelectedValue)
                    monDataset.InsertUtilisateur(TextBoxDetailCouriel.Text, TextBoxDetailNom.Text, TextBoxDetailPrenom.Text, CheckBoxDetailActif.Checked, ComboBoxDetailType.SelectedValue)

                Case Intention.Modifier

                    monDataset.UpdateUtilisateur(TextBoxDetailCouriel.Text, TextBoxDetailNom.Text, TextBoxDetailPrenom.Text, CheckBoxDetailActif.Checked, ComboBoxDetailType.SelectedValue, dgvEtudiants.SelectedRows(0).Cells(0).Value)
            End Select

            ActionEnCours = Intention.Aucune

            ActiverRecherche(True)
            ActiverResultats(True)
            ActiverDetails(False)

            ' rafraichir les données
            RafraichirResultats()
        End If
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click

        Dim monDataset As New QueriesTableAdapter
        monDataset.supprimerUtilisateur(dgvEtudiants.SelectedRows(0).Cells(0).Value)
        ActionEnCours = Intention.Aucune
        ActiverRecherche(True)
        ActiverResultats(True)
        ActiverDetails(False)

        ' rafraichir les données
        RafraichirResultats()
    End Sub

    Private Function ValiderDonnees() As Boolean
        If TextBoxDetailNom.Text = "" Then
            MsgBox("Veuillez spécifier un nom.")
            TextBoxDetailNom.Focus()
            Return False
        End If
        If TextBoxDetailPrenom.Text = "" Then
            MsgBox("Veuillez spécifier un prenom")
            TextBoxDetailPrenom.Focus()
            Return False
        End If
        If TextBoxDetailCouriel.Text = "" Then
            MsgBox("Veuillez spécifier un couriel")
            TextBoxDetailCouriel.Focus()
            Return False
        End If
        Return True
    End Function

    
End Class