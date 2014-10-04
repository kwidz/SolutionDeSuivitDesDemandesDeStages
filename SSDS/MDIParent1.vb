﻿Imports System.Windows.Forms

Public Class MDIParent1

    Private user As Integer
    Private prof As Boolean = False
    Private coordinateur As Boolean = False
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        ' Créez une nouvelle instance du formulaire enfant.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Configurez-la en tant qu'enfant de ce formulaire MDI avant de l'afficher.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Fenêtre " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: ajoutez le code ici pour ouvrir le fichier.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: ajoutez le code ici pour enregistrer le contenu actuel du formulaire dans un fichier.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilisez My.Computer.Clipboard pour insérer les images ou le texte sélectionné dans le Presse-papiers
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilisez My.Computer.Clipboard pour insérer les images ou le texte sélectionné dans le Presse-papiers
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilisez My.Computer.Clipboard.GetText() ou My.Computer.Clipboard.GetData pour extraire les informations du Presse-papiers.
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

    Private Sub GestionDesContacts_Click(sender As Object, e As EventArgs)
        For Each f As Form In Application.OpenForms
            If TypeOf f Is Gestion_des_contacts Then
                f.Activate()
                Return
            End If
        Next

        Dim ChildForm As New Gestion_des_contacts(user)
        ChildForm.MdiParent = Me
        ChildForm.Show()


    End Sub

    Private Sub GestionDesDémarchesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDesDémarchesToolStripMenuItem.Click
        For Each f As Form In Application.OpenForms
            If TypeOf f Is GestionDesDemarches Then
                f.Activate()
                Return
            End If
        Next

        Dim ChildForm As New GestionDesDemarches(user)
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
            Utilisateur = InputConnect.User.Text
            dtUser = taUser.GetData(Utilisateur, pass)
            If (InputConnect.DialogResult = Windows.Forms.DialogResult.Cancel) Then
                End
            End If
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

        ElseIf (dtUser.Rows(0)("noTYPUTIL") = 3) Then
            prof = True
            GestionDesDémarchesToolStripMenuItem.Visible = False
            GestionDesUtilisateursToolStripMenuItem.Visible = False
        Else
            GestionDesUtilisateursToolStripMenuItem.Visible = False
            ConsultationDesDémarchesToolStripMenuItem.Visible = False
        End If
    End Sub
End Class
