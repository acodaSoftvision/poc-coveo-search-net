using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using poc_coveo_search.Services;

namespace poc_coveo_search.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoveoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CoveoController> _logger;
        private readonly ICoveoService _coveoService;

        public CoveoController(ILogger<CoveoController> logger, ICoveoService coveoService)
        {
            _logger = logger;
            _coveoService = coveoService;
        }

        [HttpGet("/coveo")]
        public ActionResult<string> Get(string filter)
        {
            try
            {
                var response = _coveoService.Search(filter);
                return this.StatusCode((int)HttpStatusCode.Created, "Ok!");
            }
            catch (Exception ex)
            {
                return this.StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
