using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PricingApi.Services.Abstract;

namespace PricingApi.Controllers
{
    [ApiController]
    [Route("api/pricing")]
    public class PricingController : ControllerBase
    {
        private readonly ILogger<PricingController> _logger;
        private readonly IPricingService _pricingService;

        public PricingController(ILogger<PricingController> logger, IPricingService pricingService)
        {
            _pricingService = pricingService;
            _logger = logger;
        }

        [HttpGet("products/{productId}/currencies/{currencyCode}")]
        public async Task<IActionResult> GetPricingForProduct([FromRoute] Guid productId, [FromRoute] string currencyCode)
        {
            try
            {
                var pricingDetails = await _pricingService.GetPricingForProductAsync(productId, currencyCode);
                return Ok(pricingDetails);
            }
            catch (System.Exception)
            {
                return StatusCode(503);
            }
        }
    }
}