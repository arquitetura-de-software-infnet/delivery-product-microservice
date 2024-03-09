using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Item.SqlData.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public int Stock { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
