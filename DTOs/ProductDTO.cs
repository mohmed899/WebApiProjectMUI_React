using System.Text.Json.Serialization;

namespace WebApiProjectMUI_React.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public int available { get; set; }
        public int Sold { get; set; }
        public int CatId { get; set; }
        public string? Cover { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public decimal Price { get; set; }
        public decimal PriceSale { get; set; }
        public float TotalRating { get; set; }
        public int TotalReview { get; set; }
        public string? Status { get; set; }
        public string? inventoryType { get; set; }
        public string? description { get; set; }
        public string? Gender { get; set; }
        public string? Category { get; set; }
        public string[] Colors { get; set; }
        public DateTime createdAt { get; set; } = DateTime.UtcNow;

        public string[]? Sizes { get; set; } = new[] { "6", "7", "8", "8.5", "9", ".5", "10", "10.5", "11", "11.5", "12", "13" };
        public string[]? ratings { get; set; } = new[] { "6", "7", "8", "8.5", "9", ".5", "10", "10.5", "11", "11.5", "12", "13" };
        public string[]? reviews { get; set; } = new[] { "6", "7", "8", "8.5", "9", ".5", "10", "10.5", "11", "11.5", "12", "13" };
        public string[]? Images { get; set; } = new[] {
            "https://minimal-assets-api-dev.vercel.app/assets/images/products/product_1.jpg",
            "https://minimal-assets-api-dev.vercel.app/assets/images/products/product_2.jpg",
            "https://minimal-assets-api-dev.vercel.app/assets/images/products/product_3.jpg",
            "https://minimal-assets-api-dev.vercel.app/assets/images/products/product_4.jpg",
            "https://minimal-assets-api-dev.vercel.app/assets/images/products/product_5.jpg",
            "https://minimal-assets-api-dev.vercel.app/assets/images/products/product_6.jpg",
            "https://minimal-assets-api-dev.vercel.app/assets/images/products/product_7.jpg",
            "https://minimal-assets-api-dev.vercel.app/assets/images/products/product_8.jpg"
        };
    }
}
