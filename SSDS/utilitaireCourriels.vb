Imports System.Net.Mail

Module utilitaireCourriels
    Public Sub envoyerCourriel(Subject As String, Body As String, msgTo As List(Of String), msgCC As List(Of String), msgCCI As List(Of String))
        Dim Mailmsg As New MailMessage()
        Dim Smtp As New SmtpClient

        Smtp.Host = SSDS.My.Settings.SMTPHost ' définir SMTPHost dans les paramètres du projet
        Smtp.Port = SSDS.My.Settings.SMTPPort ' définir SMTPPort dans les paramètres du projet

        Mailmsg.Subject = Subject
        Mailmsg.Body = Body
        Mailmsg.IsBodyHtml = True
        Mailmsg.From = New MailAddress(SSDS.My.Settings.SMTPAccount) ' définir SMTPAccount dans les paramètres du projet

        'ajoute le(s) To
        For Each adress As String In msgTo
            Mailmsg.To.Add(New MailAddress(adress))
        Next

        'ajoute le(s) CC
        For Each adress As String In msgCC
            Mailmsg.CC.Add(New MailAddress(adress))
        Next

        'ajoute le(s) CCI
        For Each adress As String In msgCCI
            Mailmsg.Bcc.Add(New MailAddress(adress))
        Next

        'envoie le courriel
        Smtp.Send(Mailmsg)
    End Sub
End Module

