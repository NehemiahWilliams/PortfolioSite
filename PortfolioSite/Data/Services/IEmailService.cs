using SendGrid;

namespace PortfolioSite.Data.Services
{
    public interface IEmailService
    {
        Task<Response> SendEmail(string toName, string toEmail, string subject, string body);
    }
}