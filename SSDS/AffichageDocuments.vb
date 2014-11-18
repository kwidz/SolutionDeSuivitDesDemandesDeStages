Imports System.IO
Imports SSDS.SSDSDataSetTableAdapters

Public Class AffichageDocuments

    Private _user As Integer
    Private _nonEtudiant As Boolean
    Private nbCV As Integer

    Sub New(user As Integer, nonEtudiant As Boolean)
        ' TODO: Complete member initialization 
        _user = user
        _nonEtudiant = nonEtudiant
        InitializeComponent()
        If nonEtudiant Then
            AjouterFichier.Hide()
            SupprimerLeFichier.Hide()
        End If
        Dim taCount As New SSDSDataSetTableAdapters.CompterFichierListeTableAdapter
        Dim dtCount As New DataTable
        dtCount = taCount.GetData(_user)
        nbCV = dtCount.Rows(0)(0)
    End Sub



    Private Sub SelectionerFichier_Click(sender As Object, e As EventArgs) Handles SelectionerFichier.Click
        If (nbCV > 0) Then
            'afficher le fichier contenu dans la bdd
            Dim nomFichier As String = "c:\cv.pdf"

            Dim ta As New SSDSDataSetTableAdapters.SelectionDesFichierListeTableAdapter
            Dim byteArr() As Byte

            'on récupère la première colonne du premier enregistrement retourné par la procédure stockée
            byteArr = ta.GetData(_user)(0)(0)

            Dim fstream As New FileStream(nomFichier, FileMode.Create, FileAccess.ReadWrite)

            Dim binaryWriter As New BinaryWriter(fstream)
            binaryWriter.Write(byteArr)
            binaryWriter.Close()

            'affiche le fichier
            AxAcroPDF1.src = nomFichier

            'supprime le fichier
            File.Delete(nomFichier)
        Else
            MsgBox("Vous n'avez pas encore de CV")

        End If
    End Sub

    Private Sub SupprimerLeFichier_Click(sender As Object, e As EventArgs) Handles SupprimerLeFichier.Click
        If (nbCV > 0) Then
            If MsgBox("Désirez-vous supprimer définitivement votre CV ?", MsgBoxStyle.YesNo, _
               "Attention!") = vbYes Then
                Dim monDataset As New QueriesTableAdapter
                monDataset.SupprimerFichierListe(_user)
            End If
        Else
            MsgBox("Vous n'avez pas encore de CV")
        End If
        Dim taCount As New SSDSDataSetTableAdapters.CompterFichierListeTableAdapter
        Dim dtCount As New DataTable
        dtCount = taCount.GetData(_user)
        nbCV = dtCount.Rows(0)(0)
    End Sub

    Private Sub AjouterFichier_Click(sender As Object, e As EventArgs) Handles AjouterFichier.Click
        Dim selectionnerFichier As New OpenFileDialog()
        If selectionnerFichier.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim fstream As New FileStream(selectionnerFichier.FileName, FileMode.Open)
            Dim byteArr(fstream.Length) As Byte

            fstream.Read(byteArr, 0, fstream.Length)
            fstream.Close()

            Dim ta As New QueriesTableAdapter
            If (nbCV > 0) Then
                ta.ModifierFichierListe(_user, byteArr)
            Else
                ta.InsererFichierListe(_user, byteArr)
            End If

        End If
        Dim taCount As New SSDSDataSetTableAdapters.CompterFichierListeTableAdapter
        Dim dtCount As New DataTable
        dtCount = taCount.GetData(_user)
        nbCV = dtCount.Rows(0)(0)
    End Sub
End Class