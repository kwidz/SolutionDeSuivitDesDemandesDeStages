Public Class Form1

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SelectionEntrepriseTableAdapter.Fill(Me.SSDSDataSet.SelectionEntreprise)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.SelectionEntreprise'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.SelectionEntrepriseTableAdapter.Fill(Me.SSDSDataSet.SelectionEntreprise)

    End Sub
End Class
