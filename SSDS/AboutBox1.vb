Public NotInheritable Class AproposDeLApp

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Définissez le titre du formulaire.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("À propos de {0}", ApplicationTitle)
        ' Initialisez tout le texte affiché dans la boîte de dialogue À propos de.
        ' TODO: personnalisez les informations d'assembly de l'application dans le volet "Application" de la 
        '    boîte de dialogue Propriétés du projet (sous le menu "Projet").
        Me.Apropos.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version intermédiaire")
        Me.LabelCopyright.Text = "Dévelopé par Geoffrey Glangine"
        Me.LabelCompanyName.Text = "Pour Nicolas Gagnon le coordinateur des stages"
        Me.TextBoxDescription.Text = "Description :" + vbNewLine + vbNewLine + "(L'application développée en VB.NET a pour but d'aider les étudiants et les enseignants à garder une trace des démarches de recherche de stages)"

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub



End Class