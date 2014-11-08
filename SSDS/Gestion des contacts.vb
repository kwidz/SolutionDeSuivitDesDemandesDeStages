Public Class Gestion_des_contacts

    Enum Intention
        Ajouter
        Aucune
        Modifier
    End Enum

    Private ActionEnCours As Intention = Intention.Aucune

    Private noEntreprise As Integer

    Sub New(noE As Integer, nonEtudiant As Boolean)
        InitializeComponent()
        If (nonEtudiant) Then
            AjouterContact.Hide()
            ModifierContact.Hide()
            SauvegarderContact.Hide()
            AnnulerContact.Hide()
            SupprimerContact.Hide()

        End If

        noEntreprise = noE
        Dim taNomEntreprise As New SSDSDataSetTableAdapters.SelectionNomEntrepriseByIdTableAdapter
        Dim dtNomEntreprise As DataTable
        dtNomEntreprise = taNomEntreprise.GetData(noEntreprise)
        Me.Text = "Gestion des contacts (" + dtNomEntreprise.Rows(0)(0) + ")"
        dgvContacts.DataSource = SelectionContactPourGestionTableAdapter.GetData(noEntreprise)
        GbContacts.Text = "Contacts (" + CStr(dgvContacts.Rows.Count) + ")"
    End Sub

    Private Sub BoutonFermer_Click(sender As Object, e As EventArgs) Handles BoutonFermer.Click
        Me.Close()
    End Sub


    Private Sub Gestion_des_contacts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.SelectionContactPourGestion'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.SelectionContactPourGestionTableAdapter.Fill(Me.SSDSDataSet.SelectionContactPourGestion)

    End Sub


    Private Sub dgvContacts_SelectionChanged(sender As Object, e As EventArgs) Handles dgvContacts.SelectionChanged
        ActionEnCours = Intention.Aucune
        ActiverDetails(False)
        afficherDetail()
    End Sub

    Private Sub afficherDetail()
        Dim taContacts As New SSDSDataSetTableAdapters.SelectionContactPourGestionByIdTableAdapter
        Dim dtContacts As DataTable

        If dgvContacts.SelectedRows.Count > 0 Then
            dtContacts = taContacts.GetData(dgvContacts.SelectedRows(0).Cells(0).Value)
            If dtContacts.Rows.Count > 0 Then
                TextBoxNom.Text = dtContacts.Rows(0)("nomCON")
                TextBoxPrenom.Text = dtContacts.Rows(0)("prenomCON")
                TextTitre.Text = dtContacts.Rows(0)("titreCON")
                TextBoxCouriel.Text = dtContacts.Rows(0)("courielCON")
                TextBoxTelephone.Text = dtContacts.Rows(0)("telephoneCON")
                TextBoxDescription.Text = dtContacts.Rows(0)("noteCON")

                dateCreation.Text = "Date de création : " + dtContacts.Rows(0)("dateCreation")

                dateModif.Text = "Dernière Modification : " + dtContacts.Rows(0)("dateModification")




            End If
        Else

            TextBoxNom.Text = ""
            TextBoxPrenom.Text = ""
            TextTitre.Text = ""
            TextBoxCouriel.Text = ""
            TextBoxTelephone.Text = ""
            TextBoxDescription.Text = ""
            dateCreation.Text = "Date de création : "
            dateModification.Text = "Dernière Modification : "

        End If
    End Sub

    Private Sub ActiverDetails(ByVal blnEnabled As Boolean)
        TextBoxNom.Enabled = blnEnabled
        TextBoxPrenom.Enabled = blnEnabled
        TextBoxCouriel.Enabled = blnEnabled
        TextBoxDescription.Enabled = blnEnabled
        TextBoxTelephone.Enabled = blnEnabled
        TextTitre.Enabled = blnEnabled
        SauvegarderContact.Enabled = blnEnabled
        AnnulerContact.Enabled = blnEnabled
        
    End Sub

    Private Sub AjouterContact_Click(sender As Object, e As EventArgs) Handles AjouterContact.Click
        ActionEnCours = Intention.Ajouter
        ActiverDetails(True)
        TextBoxNom.Text = ""
        TextBoxPrenom.Text = ""
        TextTitre.Text = ""
        TextBoxCouriel.Text = ""
        TextBoxTelephone.Text = ""
        TextBoxDescription.Text = ""
        dateCreation.Text = "Date de création : "
        dateModification.Text = "Dernière Modification : "
    End Sub

    Private Sub ModifierContact_Click(sender As Object, e As EventArgs) Handles ModifierContact.Click
        ActionEnCours = Intention.Modifier
        ActiverDetails(True)
        afficherDetail()
    End Sub

    Private Sub AnnulerContact_Click(sender As Object, e As EventArgs) Handles AnnulerContact.Click
        ActionEnCours = Intention.Aucune
        ActiverDetails(False)
        afficherDetail()
    End Sub
End Class