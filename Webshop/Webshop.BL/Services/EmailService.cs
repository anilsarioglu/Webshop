using System;
using System.Net.Mail;

namespace Webshop.BL
{
    public class EmailService
    {
        public static void SendMail(String mailTo)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("teampuntkomma@gmail.com");
            mail.To.Add(mailTo);
            mail.Subject = "Test Mail";
            mail.Body = "This is for testing SMTP mail from GMAIL";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("teampuntkomma@gmail.com", "TeamPuntKomma3");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }

        public static void SendMail(String mailTo, String html)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("teampuntkomma@gmail.com");
            mail.To.Add(mailTo);
            mail.Subject = "Test Mail";
            mail.Body = "This is for testing SMTP mail from GMAIL";
            GeneratePDF.CreatePDF(html);
            mail.Attachments.Add(new Attachment("..\\..\\test.pdf"));

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("teampuntkomma@gmail.com", "TeamPuntKomma3");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
