namespace JayShop.Product.API.DTO
{
    public class ProductDTO
    {
        public ProductDTO(Guid? id, string description, decimal value, decimal saleValue)
        {
            Id = id;
            Description = description;
            Value = value;
            SaleValue = saleValue;
        }

        public Guid? Id { get; set; }
        public string Description { get;  set; }
        public decimal Value { get;  set; }
        public decimal SaleValue { get;  set; }
    }
}
