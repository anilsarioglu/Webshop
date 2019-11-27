using System;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace Webshop.BL
{
    public class EmailService
    {
        public void SendMail(string email, string id, string subject, string body)
        {
            // Plug in your email service here to send an email.
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("yaramis.naseyb@gmail.com");
            mail.To.Add(email);
            mail.Subject = subject;
            mail.Body = body;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("yaramis.naseyb@gmail.com", "Nasy1995");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
