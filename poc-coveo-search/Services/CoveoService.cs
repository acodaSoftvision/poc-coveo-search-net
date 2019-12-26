using System.Net.Http;
using System.Net.Http.Headers;

namespace poc_coveo_search.Services
{
    public class CoveoService : ICoveoService
    {
        private readonly string TOKEN = "xx99c21a86-6f53-4d44-9840-8c7be5fcb0f4";
        private readonly string URI = "https://platform.cloud.coveo.com/rest/search/v2?organizationId=aocodasv2d2vjnv7";

        public HttpResponseMessage Search(string filter)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(TOKEN, "Example");
            var simpleQuery = new
            {
                q = "Madeon - Adventure"
            };

            var stringContent = new StringContent(simpleQuery.ToString());
            var response = httpClient.PostAsync(URI, stringContent);

            return response.Result;
        }
    }
}
