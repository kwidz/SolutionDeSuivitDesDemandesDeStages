﻿Imports System.Windows.Forms

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

    End Sub
End Class
