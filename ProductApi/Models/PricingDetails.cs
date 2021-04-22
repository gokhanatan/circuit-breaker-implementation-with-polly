using System;

namespace ProductApi.Models
{
    public class PricingDetails
    {
        public Guid Id { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Price { get; set; }
    }
}