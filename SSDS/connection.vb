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

End Class
