﻿Public Class RaportNbDemarches

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.rapportNombreContactParEntreprise'. Vous pouvez la déplacer ou la supprimer selon vos besoins.

        'TODO: cette ligne de code charge les données dans la table 'SSDSDataSet.selectionUsersWithTous'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.SelectionUsersWithTousTableAdapter.Fill(Me.SSDSDataSet.selectionUsersWithTous)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.rapportNombreContactParEntrepriseTableAdapter.Fill(Me.SSDSDataSet.rapportNombreContactParEntreprise, ComboBox1.SelectedValue)
        ReportViewer1.RefreshReport()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class