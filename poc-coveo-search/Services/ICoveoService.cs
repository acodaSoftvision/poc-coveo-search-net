using System.Net.Http;
using System.Threading.Tasks;

namespace poc_coveo_search.Services
{
    public interface ICoveoService
    {
        Task<string> Search(string filter);
    }
}
