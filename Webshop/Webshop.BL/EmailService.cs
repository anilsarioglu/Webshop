using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.BL
{
    public class EmailService
    {
        public static void SendMail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("teampuntkomma@gmail.com");
            mail.To.Add("idc1994@live.nl");
            mail.Subject = "Test Mail";
            mail.Body = "This is for testing SMTP mail from GMAIL";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("teampuntkomma@gmail.com", "TeamPuntKomma");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
