using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PricingApi.Controllers
{
    [ApiController]
    [Route("api/pricing")]
    public class PricingController : ControllerBase
    {
        private readonly ILogger<PricingController> _logger;

        public PricingController(ILogger<PricingController> logger)
        {
            _logger = logger;
        }
    }
}