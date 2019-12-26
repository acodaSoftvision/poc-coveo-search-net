using System.Net.Http;

namespace poc_coveo_search.Services
{
    public interface ICoveoService
    {
        HttpResponseMessage Search(string filter);
    }
}
