using System.ComponentModel.DataAnnotations.Schema;
using WebApiProjectMUI_React.Models;
namespace WebApiProjectMUI_React.Models
{
    public class OrederDetails
    {
        public int id { get; set; }
        [ForeignKey("order")]
        public int OrderID { get; set; }
        [ForeignKey("product")]
        public int ProductId { get; set; }

        //nav 
        public Product product { get; set; }
        public Order order { get; set; }

    }
}
