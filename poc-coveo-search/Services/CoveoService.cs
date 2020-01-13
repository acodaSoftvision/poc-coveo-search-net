using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace poc_coveo_search.Services
{
    public class CoveoService : ICoveoService
    {
        private readonly string TOKEN = "xx99c21a86-6f53-4d44-9840-8c7be5fcb0f4";
        private readonly string URI = "https://platform.cloud.coveo.com/rest/search/v2?organizationId=aocodasv2d2vjnv7/";

        public async Task<string> Search(string filter)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TOKEN);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var simpleQuery = new
            {
                q = "Madeon - Good Faith",
                aq = "Mania"
            };

            var response = await httpClient.PostAsJsonAsync(URI, simpleQuery);
            
            return await response.Content.ReadAsStringAsync().ConfigureAwait(true);
        }
    }
}
