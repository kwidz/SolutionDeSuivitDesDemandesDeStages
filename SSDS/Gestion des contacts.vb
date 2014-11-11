Imports SSDS.SSDSDataSetTableAdapters

Public Class Gestion_des_contacts

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

    Private noEntreprise As Integer
    Private par As GestionDesDemarches

    Sub New(noE As Integer, nonEtudiant As Boolean, ByRef p As GestionDesDemarches)
        InitializeComponent()
        If (nonEtudiant) Then
            AjouterContact.Hide()
            ModifierContact.Hide()
            SauvegarderContact.Hide()
            AnnulerContact.Hide()
            SupprimerContact.Hide()

        End If
        par = p
        noEntreprise = noE
        Dim taNomEntreprise As New SSDSDataSetTableAdapters.SelectionNomEntrepriseByIdTableAdapter
        Dim dtNomEntreprise As DataTable
        dtNomEntreprise = taNomEntreprise.GetData(noEntreprise)
        Me.Text = "Gestion des contacts (" + dtNomEntreprise.Rows(0)(0) + ")"
        dgvContacts.DataSource = SelectionContactPourGestionTableAdapter.GetData(noEntreprise)
        GbContacts.Text = "Contacts (" + CStr(dgvContacts.Rows.Count) + ")"
        ActiverDetails(False)
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
        If dgvContacts.RowCount > 0 Then
            ModifierContact.Enabled = True
            SupprimerContact.Enabled = True
        Else
            ModifierContact.Enabled = False
            SupprimerContact.Enabled = False
        End If

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



    Private Sub SauvegarderContact_Click(sender As Object, e As EventArgs) Handles SauvegarderContact.Click
        If validerLesDonnees() Then
            Dim monDataset As New QueriesTableAdapter

            Select Case ActionEnCours
                Case Intention.Ajouter

                    monDataset.InsertContact(TextBoxNom.Text, TextBoxPrenom.Text, TextTitre.Text, TextBoxDescription.Text, TextBoxTelephone.Text, TextBoxCouriel.Text, noEntreprise)

                Case Intention.Modifier
                    Dim noContact As Integer = dgvContacts.SelectedRows(0).Cells(0).Value
                    monDataset.UpdateContact(TextBoxNom.Text, TextBoxPrenom.Text, TextTitre.Text, TextBoxDescription.Text, TextBoxTelephone.Text, TextBoxCouriel.Text, noContact)
            End Select

            ActionEnCours = Intention.Aucune
            ActiverDetails(False)
            rafraichirContacts()
            afficherDetail()
        End If
    End Sub

    Private Function validerLesDonnees() As Boolean
        If TextBoxCouriel.Text = "" Then
            MsgBox("Veuillez spécifier un couriel au contact")
            TextBoxCouriel.Focus()
            Return False
        End If
        If TextBoxNom.Text = "" Then
            MsgBox("Veuillez spécifier un nom au contact")
            TextBoxNom.Focus()
            Return False
        End If
        If TextBoxPrenom.Text = "" Then
            MsgBox("Veuillez spécifier un prenom au contact")
            TextBoxPrenom.Focus()
            Return False
        End If
        If TextBoxDescription.Text = "" Then
            MsgBox("Veuillez spécifier une description au contact")
            TextBoxDescription.Focus()
            Return False
        End If
        If TextTitre.Text = "" Then
            MsgBox("Veuillez spécifier un titre au contact.")
            TextTitre.Focus()
            Return False
        End If
        If TextBoxTelephone.Text = "" Then
            MsgBox("Veuillez spécifier un numéro de telephone au contact")
            TextBoxTelephone.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub SupprimerContact_Click(sender As Object, e As EventArgs) Handles SupprimerContact.Click
        If MsgBox("Désirez-vous supprimer ce contact ?", MsgBoxStyle.YesNo, _
               "Attention!") = vbYes Then
            ' supprimer l'enregistrement
            Dim monDataset As New QueriesTableAdapter
            monDataset.supprimerContact(dgvContacts.SelectedRows(0).Cells(0).Value)
            ActionEnCours = Intention.Aucune
            rafraichirContacts()
            ActiverDetails(False)
            afficherDetail()


        End If
    End Sub
    Private Sub rafraichirContacts()
        dgvContacts.DataSource = SelectionContactPourGestionTableAdapter.GetData(noEntreprise)
        GbContacts.Text = "Contacts (" + CStr(dgvContacts.Rows.Count) + ")"
        par.rafraichir()
    End Sub
End Class