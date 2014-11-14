Imports System.Windows.Forms
Imports SSDS.SSDSDataSetTableAdapters

Public Class Connection
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        End
    End Sub

    Private Sub Connection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles mdpForgot.LinkClicked
        Dim msgb As mdpOublie
        msgb = New mdpOublie()
        msgb.ShowDialog()
        Dim adresse As String = ""
        Dim taUser As New SSDSDataSetTableAdapters.compterUserByMailTableAdapter
        Dim dtUser As DataTable
        adresse = msgb.User.Text
        dtUser = taUser.GetData(adresse)
        If (dtUser.Rows.Count = 0) Then
            MsgBox("Mauvais nom d'utilisateur !")
        Else
            Dim nouveauPass As String = generateRandomPassword()
            Dim id = dtUser.Rows(0)(0)
            Dim monDataset As New QueriesTableAdapter
            monDataset.UpdateMdpUtilisateur(id, getSha1Hash(nouveauPass))
            Dim adresses As New List(Of String)
            adresses.Add(adresse)
            Dim cc As New List(Of String)
            envoyerCourriel("Votre mot de passe SSDS", "Votre mot de passe SSDS a bien été modifié voici le nouveau : " & nouveauPass, adresses, cc, cc)
            MsgBox("Un couriel vient de vous être envoyé avec votre nouveau courriel !")


        End If


    End Sub
End Class
