namespace WebApiProjectMUI_React.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public string ? OrderNumber { get; set; }
        public int Discount { get; set; }

    }
}
