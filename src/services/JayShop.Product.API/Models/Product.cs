using JayShoop.Core.DomainObjects;

namespace JayShop.Product.API.Models
{
    public class Product : EntityBase
    {
        public Product(string description, decimal value, decimal saleValue)
        {
            Description = description;
            Value = value;
            SaleValue = saleValue;
        }

        public string Description { get; private set; }
        public decimal Value { get; private set; }
        public decimal SaleValue { get; private set; }

    }
}
