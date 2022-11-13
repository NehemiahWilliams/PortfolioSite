using PortfolioSite.Data.Models.StrapiModels;

namespace PortfolioSite.Data.Services
{
    public class ArticleService
    {
        public async Task<List<Article>> GetPageAsync(PaginationParameters paginationParameters)
        {
            throw new NotImplementedException();
        }

        public async Task<Article?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Article?>> GetRelatedByIdAsync(int articleId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Article?>> GetRelatedByTagsAsync(List<string> tags, int articleId = 0)
        {
            throw new NotImplementedException();
        }
    }
}
