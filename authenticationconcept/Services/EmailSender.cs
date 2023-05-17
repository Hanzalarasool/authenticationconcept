using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
namespace authenticationconcept.Services
{
  

    public class EmailSender : IEmailSenders
    {
        private readonly SmtpClient _smtpClient;

        public EmailSender()
        {
            // Configure the SMTP client with your email provider settings
            _smtpClient = new SmtpClient("smtp.office365.com", 587)
            {
                Credentials = new NetworkCredential("orders@imperialinternet.com", "GSZCpS93$+!"),
                EnableSsl = true
            };
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            // Create a MailMessage object with the email details
            var mailMessage = new MailMessage("orders@imperialinternet.com", email, subject, message)
            {
                IsBodyHtml = true
            };

            // Send the email asynchronously
            await _smtpClient.SendMailAsync(mailMessage);
        }
    }

}
