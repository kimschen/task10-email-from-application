Imports System.Net.Mail

Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub Button_Click(sender As Object, e As EventArgs)

        Dim mMailMessage As New MailMessage()

        With mMailMessage
            .From = New MailAddress(txtmailfrom.Text)
            .To.Add(txtmailto.Text)
            .Subject = txtmailsubject.Text
            .BodyEncoding = Encoding.Default
            .IsBodyHtml = True
            .Body = "<center><font color:#336699;>HELLO!</font></center>"
        End With

        Dim plainView As AlternateView = AlternateView.CreateAlternateViewFromString(txtText.Text.ToString(), Nothing, "text/plain")
        plainView.TransferEncoding = Net.Mime.TransferEncoding.QuotedPrintable

        Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(txtText.Text.ToString(), Nothing, "text/html")
        htmlView.TransferEncoding = Net.Mime.TransferEncoding.QuotedPrintable

        mMailMessage.AlternateViews.Add(plainView)
        mMailMessage.AlternateViews.Add(htmlView)

        Select Case msgPriority.SelectedValue
            Case "Low"
                mMailMessage.Priority = MailPriority.Low
            Case "Normal"
                mMailMessage.Priority = MailPriority.Normal
            Case "High"
                mMailMessage.Priority = MailPriority.High
        End Select

        Dim mailClient As New SmtpClient
        mailClient.Send(mMailMessage)
        mailClient.Dispose()

        emailForm.Visible = False
        Response.Write("Thanks for your email!")

    End Sub

End Class
