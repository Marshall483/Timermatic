using MailKit.Net.Smtp;
using MimeKit;
using MyApplication.Interfaces;
using MyApplication.Models;
using System.Threading.Tasks;

namespace MyApplication.Services
{
    public class EmailSenderService : IEmailSender
    {
        public async Task<bool> SendEmailAsync(MessageData data)
        {
            var emailMessage = new MimeMessage();

            var emailBody = data.Email;
            var options = data.Options;

            emailMessage.From.Add(new MailboxAddress("Email sender service", options.SourceEmail));
            emailMessage.To.Add(new MailboxAddress("Email sender service", emailBody.YourEmail));
            emailMessage.Subject = emailBody.Subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = emailBody.Message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.mail.ru", options.Port, options.UseSSL == 0 ? false : true);
                await client.AuthenticateAsync(options.SourceEmail, options.SourcePassword);
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
                
            }
            return true;
        }
    }
}
