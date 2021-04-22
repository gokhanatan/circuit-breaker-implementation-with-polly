using System;
using System.Threading.Tasks;
using ProductApi.Models;
using ProductApi.Services.Abstract;

namespace ProductApi.Services.Concrete
{
    public class ProductService : IProductService
    {
        public Task<ProductDetails> GetProductDetailsById(Guid productId)
        {

            return Task.FromResult(new ProductDetails()
            {
                Id = productId,
                Name = "Computer"
            });
        }
    }
}