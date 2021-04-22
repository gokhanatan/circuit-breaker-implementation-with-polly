using System;
using System.Threading.Tasks;
using ProductApi.Models;

namespace ProductApi.Services.Abstract
{
    public interface IProductService
    {
        Task<ProductDetails> GetProductDetailsById(Guid productId);
    }
}