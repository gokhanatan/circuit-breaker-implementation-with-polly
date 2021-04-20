using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }
    }
}