using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductApi.Responses;
using ProductApi.Services.Abstract;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IPricingService _pricingService;
        private readonly IProductService _productService;

        public ProductController(IPricingService pricingService, IProductService productService, ILogger<ProductController> logger)
        {
            _logger = logger;
            _pricingService = pricingService;
            _productService = productService;
        }

        [HttpGet("{productId}/currencies/{currencyCode}")]
        public async Task<IActionResult> GetProduct([FromRoute] Guid productId, [FromRoute] string currencyCode)
        {
            var product = await _productService.GetProductDetailsById(productId);

            if (product is null)
            {
                return NotFound();
            }

            var pricing = await _pricingService.GetPricingForProductAsync(productId, currencyCode);
            return Ok(new ProductResponse()
            {
                Id = productId,
                Name = product.Name,
                Price = pricing.Price,
                CurrencyCode = pricing.CurrencyCode
            });


        }
    }
}