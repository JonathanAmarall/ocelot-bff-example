using JayShoop.Core.DomainObjects;

namespace JayShop.Stock.API.Models
{
    public class Stock : EntityBase
    {
        public Stock(int quantity, Guid productId, string unitOfMeasurement)
        {
            Quantity = quantity;
            ProductId = productId;
            UnitOfMeasurement = unitOfMeasurement;
        }

        public int Quantity { get; private set; }
        public Guid ProductId { get; private set; }
        public string UnitOfMeasurement { get; set; }
    }
}
