using Fashionista.core.Common;
using Fashionista.core.Data;
using Fashionista.core.Repository;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.infra.Repository
{
    public class MailRepository : IMailRepository
    {

        private readonly IdbContext context;

        public MailRepository(IdbContext dbcontext)
        {
            this.context = dbcontext;
        }

        public bool SendEmailAsync(MailRequest mailRequest)
        {
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("Shahed",
            "shahedmalkawi18@gmail.com");
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress("User",
            "" + mailRequest.ToEmail + "");
            message.To.Add(to);

            message.Subject = mailRequest.Subject;

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = mailRequest.Body;/* "<p>This is the Verification Code : " + login.Verification + " To Rest Password.";*/
            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                //client.SslProtocols = SslProtocols.Ssl3 | SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12 | SslProtocols.Tls13;
                client.CheckCertificateRevocation = false;

                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("shahedmalkawi18@gmail.com", "yarab***");

                client.Send(message);
                client.Disconnect(true);

            }

            return true;
        }
    }

}

