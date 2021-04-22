using System;
using System.Threading.Tasks;
using PricingApi.Model;

namespace PricingApi.Services.Abstract
{
    public interface IPricingService
    {
        Task<PricingDetails> GetPricingForProductAsync(Guid guid, string currencyCode);
    }
}