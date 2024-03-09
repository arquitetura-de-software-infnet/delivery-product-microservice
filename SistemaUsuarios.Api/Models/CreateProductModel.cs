namespace Delivery.Item.Api.Models
{
    /// <summary>
    /// Modelo de dados para o ENDPOINT de cadastro de usuário
    /// </summary>
    public class CreateProductModel
    {
        public string? Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }

}
