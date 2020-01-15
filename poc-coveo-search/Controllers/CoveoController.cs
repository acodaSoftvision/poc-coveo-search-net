using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using poc_coveo_search.Models;
using poc_coveo_search.Services;

namespace poc_coveo_search.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoveoController : ControllerBase
    {
        private readonly ILogger<CoveoController> _logger;
        private readonly ICoveoService _coveoService;

        public CoveoController(ILogger<CoveoController> logger, ICoveoService coveoService)
        {
            _logger = logger;
            _coveoService = coveoService;
        }

        [HttpGet]
        [Route("simplequery")]
        public async Task<ActionResult<string>> SimpleQuery(string q)
        {
            try
            {
                var response = await _coveoService.SimpleQuery(q);

                return this.StatusCode((int)HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return this.StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("advancedquery")]
        public async Task<ActionResult<string>> AdvancedQuery([FromQuery]AdvancedQueryModel queryModel)
        {
            try
            {
                var response = await _coveoService.AdvancedQuery(queryModel);

                return this.StatusCode((int)HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return this.StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("customquery")]
        public async Task<ActionResult<string>> CustomQuery([FromBody]CustomQueryModel queryModel)
        {
            try
            {
                var response = await _coveoService.CustomQuery(queryModel);

                return this.StatusCode((int)HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return this.StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
