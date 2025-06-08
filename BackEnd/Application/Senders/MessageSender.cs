using System.Net;
using System.Net.Mail;
using KRB.Domain.Interfaces;

namespace KRB.Application.Senders;

public class MessageSender : IMessageSender
{
    public Task SendEmailAsync(string email, string subject, string message, bool isMessageHtml = false)
    {
        using (var client = new SmtpClient())
        {
            var credentials = new NetworkCredential()
            {
                UserName = "",
                Password = ""
            };

            client.Credentials = credentials;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;

            using var mailmessage = new MailMessage()
            {
                To = { new MailAddress(email) },
                From = new MailAddress(""),
                Subject = subject,
                Body = message,
                IsBodyHtml = isMessageHtml
            };

            client.Send(mailmessage);
        }

        return Task.CompletedTask;
    }

}
