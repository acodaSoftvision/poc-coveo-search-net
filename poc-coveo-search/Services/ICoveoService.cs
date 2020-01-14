using poc_coveo_search.Models;
using System.Threading.Tasks;

namespace poc_coveo_search.Services
{
    public interface ICoveoService
    {
        /// <summary>
        /// Performs a simple query with just a keyword.
        /// </summary>
        /// <param name="q">Keyword that wants to be used as filter. If null it will returns every item indexed</param>
        /// <returns>The collection of items that matches with the keyword.</returns>
        Task<string> SimpleQuery(string q);

        /// <summary>
        /// Performs an advanced query for further filter to items collection that matches the keyword.
        /// </summary>
        /// <param name="queryModel">Model that represents the fields necessaries for performing an advanced query</param>
        /// <returns>The collection of items that matches with the keyword with the conditions.</returns>
        Task<string> AdvancedQuery(AdvancedQueryModel queryModel);
    }
}
