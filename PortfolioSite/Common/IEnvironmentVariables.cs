namespace PortfolioSite.Common
{
    public interface IEnvironmentVariables
    {
        string SendGridApiKey { get; }

        string GetEnvironmentVariable(string value);
    }
}