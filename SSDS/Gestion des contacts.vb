Public Class Gestion_des_contacts

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
        dgvContacts.DataSource = SelectionContactPourGestionTableAdapter.GetData(noEntreprise)
    End Sub

    Private Sub BoutonFermer_Click(sender As Object, e As EventArgs) Handles BoutonFermer.Click
        Me.Close()
    End Sub


    Private Sub Gestion_des_contacts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.SelectionContactPourGestion'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.SelectionContactPourGestionTableAdapter.Fill(Me.SSDSDataSet.SelectionContactPourGestion)

    End Sub


    Private Sub dgvContacts_SelectionChanged(sender As Object, e As EventArgs) Handles dgvContacts.SelectionChanged
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
End Class