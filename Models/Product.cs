using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiProjectMUI_React.Models
{
    public class Product
    {
        public int Id  { get; set; }
        public string ?Cover { get; set; }
        public string ? Name { get; set; }
        public string ? Code { get; set; }
        public decimal Price { get; set; }
        public decimal PriceSale { get; set; }
        public float TotalRating { get; set; }
        public int TotalReview { get; set; }
        public string? Status { get; set; }
        public string? inventoryType { get; set; }
        public string? description { get; set; }
        public string? Gender { get; set; }
        public string? Colors { get; set; }
        public DateTime createdAt { get; set; }

        [ForeignKey("category")]
        public int CatId { get; set; }

        public Category? category { get; set; }

        public List<OrederDetails> OrederDetails { get; set; }

    }
}
