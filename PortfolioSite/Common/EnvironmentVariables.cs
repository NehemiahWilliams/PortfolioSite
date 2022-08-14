namespace PortfolioSite.Common
{
    public class EnvironmentVariables : IEnvironmentVariables
    {
        public string SendGridApiKey { get; }
        public EnvironmentVariables()
        {
            SendGridApiKey = GetEnvironmentVariable("SENDGRID_API_KEY");
        }

        public string GetEnvironmentVariable(string value)
        {
            string? result = Environment.GetEnvironmentVariable(value);
            if (result is null)
            {
                throw new ArgumentNullException(result, "SENDGRID_API_KEY environment variable is not set");
            }
            return result;
        }

    }
}
