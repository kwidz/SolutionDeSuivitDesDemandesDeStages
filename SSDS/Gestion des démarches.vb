Imports SSDS.SSDSDataSetTableAdapters

Public Class GestionDesDemarches
    Private user As Integer
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
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
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.SelectionEntreprise'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.SelectionEntrepriseTableAdapter.Fill(Me.SSDSDataSet.SelectionEntreprise)
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.SelectionEntreprise'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.SelectionEntrepriseTableAdapter.Fill(Me.SSDSDataSet.SelectionEntreprise)
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.SelectionEntreprise'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.SelectionEntrepriseTableAdapter.Fill(Me.SSDSDataSet.SelectionEntreprise)
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.SelectionEntreprise'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.SelectionEntrepriseTableAdapter.Fill(Me.SSDSDataSet.SelectionEntreprise)
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.SelectionEntreprise'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.SelectionEntrepriseTableAdapter.Fill(Me.SSDSDataSet.SelectionEntreprise)
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.SelectionEntreprise'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.SelectionEntrepriseTableAdapter.Fill(Me.SSDSDataSet.SelectionEntreprise)


    End Sub


    Private Sub dgvEntreprises_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEntreprises.SelectionChanged
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

    Private Sub dgvDemarches_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDemarches.SelectionChanged
        Dim taDemarches As New SSDSDataSetTableAdapters.SelectionDemarchesById2TableAdapter
        Dim dtDemarches As DataTable

        If dgvEntreprises.SelectedRows.Count > 0 Then
            dtDemarches = taDemarches.GetData(dgvEntreprises.SelectedRows(0).Cells(0).Value)
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

    Public Sub New(pVariable As Integer)
        InitializeComponent()
        user = pVariable
        dgvEntreprises.DataSource = (SelectionEntrepriseTableAdapter.GetData(user))

    End Sub



    Private Sub BoutonDetailContacts_Click(sender As Object, e As EventArgs) Handles BoutonDetailContacts.Click
        Try
            Dim dial As New Gestion_des_contacts(dgvEntreprises.SelectedRows(0).Cells(0).Value)
            dial.Show()
        Catch
            MsgBox("Il n'y a pas d'entreprise de séléctionnée")
        End Try
    End Sub
End Class
