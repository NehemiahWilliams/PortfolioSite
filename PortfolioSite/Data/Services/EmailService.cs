using PortfolioSite.Common;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace PortfolioSite.Data.Services
{
    public class EmailService : IEmailService
    {
        private IEnvironmentVariables EnvironmentVariables { get; }
        public EmailService(IEnvironmentVariables environmentVariables)
        {
            EnvironmentVariables = environmentVariables;
        }

        public async Task<Response> SendEmail(string fromName, string fromEmail, string subject, string body)
        {
            var client = new SendGridClient(new SendGridClientOptions{ApiKey = EnvironmentVariables.SendGridApiKey, HttpErrorAsException = true });
            var to = new EmailAddress("nwil215@wgu.edu", "Nehemiah");
            var from = new EmailAddress("nehemiahwilliams80@gmail.com", "Nehemiah");
            var plainTextContent = body;
            var htmlContent = $"<div> Email: {fromEmail} <br> Name: {fromName} <br> Message: {body}</div>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject + fromName, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg).ConfigureAwait(false);
            return response;
        }
    }
}
