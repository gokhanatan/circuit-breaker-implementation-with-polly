using System;
using System.Threading.Tasks;
using PricingApi.Model;
using PricingApi.Services.Abstract;

namespace PricingApi.Services.Concrete
{
    public class PricingService : IPricingService
    {
        private DateTime _recoveryTime = DateTime.UtcNow;
        private static readonly Random _random = new Random();

        public Task<PricingDetails> GetPricingForProductAsync(Guid productId, string currencyCode)
        {
            if (_recoveryTime > DateTime.UtcNow)
            {
                throw new Exception("Something went wrong");
            }

            if (_recoveryTime < DateTime.UtcNow && _random.Next(1, 3) == 2)
            {
                _recoveryTime = DateTime.UtcNow.AddSeconds(30);
            }

            return Task.FromResult(new PricingDetails
            {
                Id = productId,
                CurrencyCode = currencyCode,
                Price = 10.99m
            });

        }
    }
}