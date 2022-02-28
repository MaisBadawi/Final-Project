using Fashionista.core.Data;
using Fashionista.core.Service;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.infra.Service
{
    public class MailService : IMailService
    {
        public bool SendEmailAsync(MailRequest mailRequest)
        {
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("Fashionista.com",
            "Khr25984@gmail.com");
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress("User",
            "" + mailRequest.ToEmail + "");
            message.To.Add(to);

            message.Subject = mailRequest.Subject;

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h1>Greetings from Fashionista.com</h1><p>" + mailRequest.Body + "</P>"; 
            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                
                client.CheckCertificateRevocation = false;

                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("Khr25984@gmail.com", "RAMAM97@97");

                client.Send(message);
                client.Disconnect(true);

            }

            return true;
        }
    }
}
