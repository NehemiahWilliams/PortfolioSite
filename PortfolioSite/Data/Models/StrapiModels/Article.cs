namespace PortfolioSite.Data.Models.StrapiModels
{
    public class Article
    {
        public int Id { get; set; }
    }

    public class Attributes
    {
        public string? Title { get; set; }
        public string? Body { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime PublishedAt { get; set; }
    }
}
