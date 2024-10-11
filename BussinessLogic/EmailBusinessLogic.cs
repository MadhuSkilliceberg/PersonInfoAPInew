





using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.Extensions.Options;
using PersonsInfoV2Api.Models;
namespace PersonsInfoV2Api.BussinessLogic
{
    public class EmailBusinessLogic
    {
        private readonly EmailSettings _emailSettings;

        public EmailBusinessLogic(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public void SendSms(string toPhoneNumber, string message, string carrierDomain)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("SMS Sender", _emailSettings.Username));
            emailMessage.To.Add(new MailboxAddress("", $"{toPhoneNumber}@{carrierDomain}"));
            emailMessage.Subject = "SMS";
            emailMessage.Body = new TextPart("plain")
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                client.Connect(_emailSettings.SmtpServer, _emailSettings.Port, false);
                client.Authenticate(_emailSettings.Username, _emailSettings.Password);
                client.Send(emailMessage);
                client.Disconnect(true);
            }
        }
    }
}