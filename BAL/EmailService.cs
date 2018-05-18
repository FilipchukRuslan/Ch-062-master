using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
namespace BAL
{
    public class EmailService
    {
        public void SendEmailAsync()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("Filipchukruslan72@gmail.com");
            mail.To.Add("Filipchukruslan@rambler.ru");
            mail.Subject = "Test Mail - 1";
            mail.Body = "mail with attachment";

            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = true;
            SmtpServer.Credentials = new System.Net.NetworkCredential("Filipchukruslan72@gmail.com", "ybrbnfybrbnf72");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}