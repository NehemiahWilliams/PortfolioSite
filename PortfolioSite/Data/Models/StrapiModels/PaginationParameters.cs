
using Newtonsoft.Json;

namespace PortfolioSite.Data.Models.StrapiModels
{
    public class PaginationParameters
    {
        [JsonProperty("pagination[page]")]
        public int PageNumber { get; set; } = 1;

        [JsonProperty("pagination[pageSize]")]
        public int PageSize { get; set; } = 10;
    }
}
