using System.ComponentModel.DataAnnotations;

namespace StoreProducts.WebAPI.DTOs
{
    public class CreateProductDTO
    {
        [Required]
        [MaxLength(200)]
        public required string Nombre { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public required string Currency { get; set; }

        public int InitialInventory { get; set; }
    }
}
