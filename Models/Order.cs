namespace WebApiProjectMUI_React.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal SubTotal  { get; set; }
        public decimal Total  { get; set; }
        public string? OrderNumber { get; set; } 
        public int Discount { get; set; }

        public List<OrederDetails> OrederDetails { get; set; }

    }
}
