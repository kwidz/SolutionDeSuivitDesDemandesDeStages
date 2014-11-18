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
            MsgBox("faire le traitement")
        Else
            MsgBox("Vous n'avez pas encore de CV")

        End If
    End Sub

    Private Sub SupprimerLeFichier_Click(sender As Object, e As EventArgs) Handles SupprimerLeFichier.Click
        If (nbCV > 0) Then
            If MsgBox("Désirez-vous supprimer définitivement votre CV ?", MsgBoxStyle.YesNo, _
               "Attention!") = vbYes Then
                MsgBox("Suppression")
            End If
        Else
            MsgBox("Vous n'avez pas encore de CV")

        End If
    End Sub
End Class