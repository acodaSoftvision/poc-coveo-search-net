using poc_coveo_search.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace poc_coveo_search.Services
{
    public class CoveoService : ICoveoService
    {
        private readonly string TOKEN = "xx99c21a86-6f53-4d44-9840-8c7be5fcb0f4";
        private readonly string URI = "https://platform.cloud.coveo.com/rest/search/v2?organizationId=aocodasv2d2vjnv7/";

        public Task<string> AdvancedQuery(AdvancedQueryModel queryModel)
        {
            //var httpclient = this.ConfigureHttpClient();

            throw new System.NotImplementedException();
        }

        public async Task<string> SimpleQuery(string q)
        {
            var simpleQuery = new
            {
                q,
            };
            
            return await this.PerformQuery(simpleQuery);
        }

        private async Task<string> PerformQuery(object query)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TOKEN);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.PostAsJsonAsync(URI, query);

            return await response.Content.ReadAsStringAsync().ConfigureAwait(true);
        }
    }
}
