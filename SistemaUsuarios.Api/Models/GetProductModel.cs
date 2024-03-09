namespace Delivery.Item.Api.Models
{
    public class GetProductModel
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}
