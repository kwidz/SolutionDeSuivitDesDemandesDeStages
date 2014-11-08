Imports SSDS.SSDSDataSetTableAdapters

Public Class GestionDesDemarches

    Enum Intention
        Ajouter
        Aucune
        Modifier
    End Enum

    Private ActionEnCoursEntreprise As Intention = Intention.Aucune
    Private ActionEnCoursDemarche As Intention = Intention.Aucune

    Private user As Integer
    Private nonEtudiant As Boolean
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Public Sub New(pVariable As Integer, nonEtu As Boolean)
        InitializeComponent()
        nonEtudiant = nonEtu
        If (nonEtudiant) Then
            BoutonAjouter.Hide()
            BoutonModifier.Hide()
            BoutonSupprimer.Hide()
            BoutonDetailAnnuler.Hide()
            BoutonDetailSauvegarder.Hide()
            AjouterDemarche.Hide()
            ModifierDemarche.Hide()
            SupprimerDemarche.Hide()
            SauvegarderDemarche.Hide()
            AnnulerDemarche.Hide()

        End If
        user = pVariable
        dgvEntreprises.DataSource = (SelectionEntrepriseTableAdapter.GetData(user))
        GroupBoxEntreprises.Text = "Entreprises (" + CStr(dgvEntreprises.Rows.Count) + ")"

        Dim taNomEtudiant As New SSDSDataSetTableAdapters.SelectionNomPrenomEtudiantByIdTableAdapter
        Dim dtNomEtudiant As DataTable
        dtNomEtudiant = taNomEtudiant.GetData(user)
        Me.Text = "Gestion des démarches (" + dtNomEtudiant.Rows(0)(0) + ")"

    End Sub

    'Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.SelectionEntrepriseTableAdapter.Fill(Me.SSDSDataSet.SelectionEntreprise)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.SelectionContact'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.SelectionContactTableAdapter.Fill(Me.SSDSDataSet.SelectionContact)
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet1.SelectionTypeDEM'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.SelectionTypeDEMTableAdapter.Fill(Me.SSDSDataSet1.SelectionTypeDEM)
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.SelectionStatutENT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.SelectionStatutENTTableAdapter.Fill(Me.SSDSDataSet.SelectionStatutENT)

    End Sub




    '
    '
    'GESTION DES DÉMARCHES
    '
    '
    Private Sub BoutonDetailContacts_Click(sender As Object, e As EventArgs) Handles BoutonDetailContacts.Click
        Try
            Dim dial As New Gestion_des_contacts(dgvEntreprises.SelectedRows(0).Cells(0).Value, nonEtudiant)
            dial.Show()
        Catch
            MsgBox("Il n'y a pas d'entreprise de séléctionnée")
        End Try
    End Sub

    Private Sub dgvDemarches_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDemarches.SelectionChanged
        ActiverDetailsDemarche(False)
        ActionEnCoursDemarche = Intention.Aucune
        remplirDetailDemarche()
    End Sub

    Private Sub AjouterDemarche_Click(sender As Object, e As EventArgs) Handles AjouterDemarche.Click
        ActiverDetailsDemarche(True)
        DateDem.Text = ""
        DescriptionDem.Text = ""
        DateCreationDem.Text = ""
        DerniereModificationDem.Text = ""
        ActionEnCoursDemarche = Intention.Ajouter
    End Sub

    Private Sub ModifierDemarche_Click(sender As Object, e As EventArgs) Handles ModifierDemarche.Click
        ActiverDetailsDemarche(True)
        ActionEnCoursDemarche = Intention.Modifier
        remplirDetailDemarche()
    End Sub

    Private Sub AnnulerDemarche_Click(sender As Object, e As EventArgs) Handles AnnulerDemarche.Click
        ActiverDetailsDemarche(False)
        remplirDetailDemarche()
    End Sub


    Private Sub remplirDetailDemarche()
        Dim taDemarches As New SSDSDataSetTableAdapters.SelectionDemarchesById2TableAdapter
        Dim dtDemarches As DataTable

        If dgvDemarches.SelectedRows.Count > 0 Then
            dtDemarches = taDemarches.GetData(dgvDemarches.SelectedRows(0).Cells(0).Value)
            If dtDemarches.Rows.Count > 0 Then

                DateDem.Text = dtDemarches.Rows(0)("dateDEM")
                DescriptionDem.Text = dtDemarches.Rows(0)("noteDEM")
                DateCreationDem.Text = "Date de création : " + dtDemarches.Rows(0)("dateCreation")
                DerniereModificationDem.Text = "Dernière Modification : " + dtDemarches.Rows(0)("dateModification")
                ContactDem.SelectedValue = dtDemarches.Rows(0)("noCON")
                TypeDem.SelectedValue = dtDemarches.Rows(0)("noTYPDEM")


            End If
        Else

            DateDem.Text = ""
            DescriptionDem.Text = ""
            DateCreationDem.Text = ""
            DerniereModificationDem.Text = ""

        End If
    End Sub

    Private Sub ActiverDetailsDemarche(ByVal blnEnabled As Boolean)
        DateDem.Enabled = blnEnabled
        ContactDem.Enabled = blnEnabled
        TypeDem.Enabled = blnEnabled
        DescriptionDem.Enabled = blnEnabled
        SauvegarderDemarche.Enabled = blnEnabled
        AnnulerDemarche.Enabled = blnEnabled
    End Sub


    '
    '
    'GESTION DES ENTREPRISES
    '
    '



    Private Sub dgvEntreprises_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEntreprises.SelectionChanged
        ActionEnCoursEntreprise = Intention.Aucune
        ActiverDetailsEntreprise(False)
        remplirDetailsEntreprises()

    End Sub

    Private Sub ActiverDetailsEntreprise(ByVal blnEnabled As Boolean)
        TextBoxDetailNomEntreprise.Enabled = blnEnabled
        TextBoxDetailAdresseEntreprise.Enabled = blnEnabled
        TextBoxDetailVilleEntreprise.Enabled = blnEnabled
        TextBoxDetailVilleEntreprise.Enabled = blnEnabled
        TextBoxDetailCodePEntreprise.Enabled = blnEnabled
        TextBoxDetailDescriptionEntreprise.Enabled = blnEnabled
        ComboBoxDetailStatutEntreprise.Enabled = blnEnabled
        TextBoxDetailTelephoneEntreprise.Enabled = blnEnabled
        TextBoxDetailCourielEntreprise.Enabled = blnEnabled
        BoutonDetailSauvegarder.Enabled = blnEnabled
        BoutonDetailAnnuler.Enabled = blnEnabled
    End Sub

    Private Sub BoutonAjouter_Click(sender As Object, e As EventArgs) Handles BoutonAjouter.Click
        ActiverDetailsEntreprise(True)
        ActionEnCoursEntreprise = Intention.Ajouter
        TextBoxDetailCourielEntreprise.Text = ""
        TextBoxDetailVilleEntreprise.Text = ""
        TextBoxDetailDescriptionEntreprise.Text = ""
        TextBoxDetailTelephoneEntreprise.Text = ""
        TextBoxDetailNomEntreprise.Text = ""
        TextBoxDetailAdresseEntreprise.Text = ""
        TextBoxDetailCodePEntreprise.Text = ""
        txtDateCreationEntreprise.Text = ""
        txtDateModificationEntreprise.Text = ""
    End Sub

    Private Sub BoutonModifier_Click(sender As Object, e As EventArgs) Handles BoutonModifier.Click
        ActionEnCoursEntreprise = Intention.Modifier
        ActiverDetailsEntreprise(True)
        remplirDetailsEntreprises()

    End Sub

    Private Sub BoutonDetailAnnuler_Click(sender As Object, e As EventArgs) Handles BoutonDetailAnnuler.Click
        ActiverDetailsEntreprise(False)
        remplirDetailsEntreprises()

    End Sub

    Private Sub remplirDetailsEntreprises()
        Dim taEntreprises As New SSDSDataSetTableAdapters.SelectionEntreprisesByIdTableAdapter
        Dim dtEntreprises As DataTable

        If dgvEntreprises.SelectedRows.Count > 0 Then
            dtEntreprises = taEntreprises.GetData(dgvEntreprises.SelectedRows(0).Cells(0).Value)
            If dtEntreprises.Rows.Count > 0 Then
                TextBoxDetailCourielEntreprise.Text = dtEntreprises.Rows(0)("courrielENT")
                TextBoxDetailVilleEntreprise.Text = dtEntreprises.Rows(0)("villeENT")
                TextBoxDetailDescriptionEntreprise.Text = dtEntreprises.Rows(0)("descriptionENT")
                TextBoxDetailTelephoneEntreprise.Text = dtEntreprises.Rows(0)("noTelephoneENT")
                TextBoxDetailNomEntreprise.Text = dtEntreprises.Rows(0)("nomENT")
                TextBoxDetailAdresseEntreprise.Text = dtEntreprises.Rows(0)("AdresseENT")
                TextBoxDetailCodePEntreprise.Text = dtEntreprises.Rows(0)("CodePostalENT")
                txtDateCreationEntreprise.Text = "Date de création : " + dtEntreprises.Rows(0)("dateCreation")
                txtDateModificationEntreprise.Text = "Dernière Modification:" + dtEntreprises.Rows(0)("dateModification")
                dgvDemarches.DataSource = SelectionDemarchesByIdTableAdapter.GetData(dgvEntreprises.SelectedRows(0).Cells(0).Value)
                ComboBoxDetailStatutEntreprise.SelectedValue = dtEntreprises.Rows(0)("statut")
                GroupBoxDemarches.Text = "Démarches (" + CStr(dgvEntreprises.SelectedRows(0).Cells(1).Value) + ") (" + CStr(dgvDemarches.Rows.Count) + ")"
            End If
        Else
            TextBoxDetailCourielEntreprise.Text = ""
            TextBoxDetailVilleEntreprise.Text = ""
            TextBoxDetailDescriptionEntreprise.Text = ""
            TextBoxDetailTelephoneEntreprise.Text = ""
            TextBoxDetailNomEntreprise.Text = ""
            TextBoxDetailAdresseEntreprise.Text = ""
            TextBoxDetailCodePEntreprise.Text = ""
            txtDateCreationEntreprise.Text = ""
            txtDateModificationEntreprise.Text = ""



        End If
    End Sub

    
    Private Sub BoutonDetailSauvegarder_Click(sender As Object, e As EventArgs) Handles BoutonDetailSauvegarder.Click
        If validerLesDonneesEntreprises() Then
            Dim monDataset As New QueriesTableAdapter
            Dim entrepriseId As Integer
            Select Case ActionEnCoursEntreprise
                Case Intention.Ajouter

                    monDataset.InsertEntreprise(TextBoxDetailNomEntreprise.Text, TextBoxDetailAdresseEntreprise.Text, TextBoxDetailVilleEntreprise.Text, TextBoxDetailCodePEntreprise.Text, TextBoxDetailTelephoneEntreprise.Text, TextBoxDetailCourielEntreprise.Text, TextBoxDetailDescriptionEntreprise.Text, ComboBoxDetailStatutEntreprise.SelectedValue, user)

                Case Intention.Modifier

                    entrepriseId = dgvEntreprises.SelectedRows(0).Cells(0).Value

                    monDataset.UpdateEntreprise(TextBoxDetailNomEntreprise.Text, TextBoxDetailAdresseEntreprise.Text, TextBoxDetailVilleEntreprise.Text, TextBoxDetailCodePEntreprise.Text, TextBoxDetailTelephoneEntreprise.Text, TextBoxDetailCourielEntreprise.Text, TextBoxDetailDescriptionEntreprise.Text, ComboBoxDetailStatutEntreprise.SelectedValue, entrepriseId)
            End Select

            ActionEnCoursEntreprise = Intention.Aucune
            ActiverDetailsEntreprise(False)
            rafraichirEntreprises()
        End If
    End Sub
    Private Function validerLesDonneesEntreprises() As Boolean
        If TextBoxDetailCourielEntreprise.Text = "" Then
            MsgBox("Veuillez spécifier un courriel à l'entreprise.")
            TextBoxDetailCourielEntreprise.Focus()
            Return False
        End If

        If TextBoxDetailNomEntreprise.Text = "" Then
            MsgBox("Veuillez spécifier un nom à l'entreprise.")
            TextBoxDetailCourielEntreprise.Focus()
            Return False
        End If

        If TextBoxDetailAdresseEntreprise.Text = "" Then
            MsgBox("Veuillez spécifier une adresse à l'entreprise.")
            TextBoxDetailCourielEntreprise.Focus()
            Return False
        End If

        If TextBoxDetailVilleEntreprise.Text = "" Then
            MsgBox("Veuillez spécifier une adresse à l'entreprise.")
            TextBoxDetailCourielEntreprise.Focus()
            Return False
        End If

        If TextBoxDetailCodePEntreprise.Text = "" Then
            MsgBox("Veuillez spécifier une adresse à l'entreprise.")
            TextBoxDetailCourielEntreprise.Focus()
            Return False
        End If
        If TextBoxDetailDescriptionEntreprise.Text = "" Then
            MsgBox("Veuillez spécifier une adresse à l'entreprise.")
            TextBoxDetailCourielEntreprise.Focus()
            Return False
        End If
        If TextBoxDetailTelephoneEntreprise.Text = "" Then
            MsgBox("Veuillez spécifier une adresse à l'entreprise.")
            TextBoxDetailCourielEntreprise.Focus()
            Return False
        End If
        

        Return True
    End Function

    Private Sub rafraichirEntreprises()
        dgvEntreprises.DataSource = (SelectionEntrepriseTableAdapter.GetData(user))
        GroupBoxEntreprises.Text = "Entreprises (" + CStr(dgvEntreprises.Rows.Count) + ")"
    End Sub

    Private Sub BoutonSupprimer_Click(sender As Object, e As EventArgs) Handles BoutonSupprimer.Click
        If MsgBox("Désirez-vous supprimer cette Entreprise ?", MsgBoxStyle.YesNo, _
               "Attention!") = vbYes Then
            ' supprimer l'enregistrement
            Dim monDataset As New QueriesTableAdapter
            monDataset.SupprimerEntreprise(dgvEntreprises.SelectedRows(0).Cells(0).Value)
            ActionEnCoursEntreprise = Intention.Aucune
            ActiverDetailsEntreprise(False)
            rafraichirEntreprises()
        End If
    End Sub
End Class

        
        