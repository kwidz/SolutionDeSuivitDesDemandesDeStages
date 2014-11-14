Imports System.Windows.Forms
Imports SSDS.SSDSDataSetTableAdapters

Public Class MDIParent1

    Private user As Integer
    Private prof As Boolean = False
    Private coordinateur As Boolean = False
    Private nonEtudiant = False
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        ' Créez une nouvelle instance du formulaire enfant.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Configurez-la en tant qu'enfant de ce formulaire MDI avant de l'afficher.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Fenêtre " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Fermez tous les formulaires enfants du parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    'Private Sub GestionDesContacts_Click(sender As Object, e As EventArgs)
    '    For Each f As Form In Application.OpenForms
    '        If TypeOf f Is Gestion_des_contacts Then
    '            f.Activate()
    '            Return
    '        End If
    '    Next

    '    Dim ChildForm As New Gestion_des_contacts(user, nonEtudiant)
    '    ChildForm.MdiParent = Me
    '    ChildForm.Show()


    'End Sub

    Private Sub GestionDesDémarchesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDesDémarchesToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is GestionDesDemarches Then
                f.Activate()
                Return
            End If
        Next

        Dim ChildForm As New GestionDesDemarches(user, nonEtudiant)
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub ConsultationDesDémarchesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultationDesDémarchesToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Consultation_des_démarches Then
                f.Activate()
                Return
            End If
        Next

        Dim ChildForm As New Consultation_des_démarches
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub GestionDesUtilisateursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDesUtilisateursToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is GestionDesUtilisateurs Then
                f.Activate()
                Return
            End If
        Next

        Dim ChildForm As New GestionDesUtilisateurs
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim InputConnect As Connection
        Dim pass As String = ""
        Dim Utilisateur As String = ""
        Dim taUser As New SSDSDataSetTableAdapters.compterUsersTableAdapter
        Dim dtUser As DataTable
        While (1)
            InputConnect = New Connection
            InputConnect.ShowDialog()
            pass = InputConnect.Pass.Text
            pass = getSha1Hash(pass)
            Utilisateur = InputConnect.User.Text
            dtUser = taUser.GetData(Utilisateur, pass)
            If (dtUser.Rows.Count = 0) Then
                MsgBox("Mauvaise Combinaison Mot de passe / utilisateur")
            Else
                Exit While
            End If

        End While
        dtUser = taUser.GetData(Utilisateur, pass)
        user = dtUser.Rows(0)("noUtil")
        If (dtUser.Rows(0)("noTYPUTIL") = 1) Then
            coordinateur = True
            GestionDesDémarchesToolStripMenuItem.Visible = False
            nonEtudiant = True

        ElseIf (dtUser.Rows(0)("noTYPUTIL") = 3) Then
            prof = True
            GestionDesDémarchesToolStripMenuItem.Visible = False
            GestionDesUtilisateursToolStripMenuItem.Visible = False
            nonEtudiant = True
        Else
            GestionDesUtilisateursToolStripMenuItem.Visible = False
            ConsultationDesDémarchesToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AproposDeLApp.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ChangerDeMotDePasseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangerDeMotDePasseToolStripMenuItem.Click
        Dim changePass As New ChangerMotDePasse

        changePass.ShowDialog()
        Dim pass As String = changePass.passwd.Text
        Dim confirm As String = changePass.confirm.Text
        If (pass = confirm) Then
            Dim monDataset As New QueriesTableAdapter
            monDataset.UpdateMdpUtilisateur(user, getSha1Hash(pass))
            MsgBox("Votre mot de passe a été modifié avec succès !")
        Else
            MsgBox("Les deux mots de passes ne sont pas identiques, veillez recommencer.")
        End If
    End Sub
End Class
