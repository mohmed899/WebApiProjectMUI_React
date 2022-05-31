using WebApiProjectMUI_React.Models;
using WebApiProjectMUI_React.DTOs;

namespace WebApiProjectMUI_React.Repo
{
    public class OrderRepo : IOrderRepo
    {
        StoreEntity db;
        public OrderRepo(StoreEntity db) { this.db = db; }

        public int AddOrder(OrderDTO orderDTO)
        {
            try
            {
                Order order = new Order()
                {
                    CustomerId = orderDTO.CustomerId,
                    Discount = orderDTO.Discount,
                    OrderNumber = orderDTO.OrderNumber,
                    SubTotal = orderDTO.SubTotal,
                    Total = orderDTO.Total, 
                    
                };
                db.order.Add(order);
                var res =  db.SaveChanges();
                orderDTO.Id = order.Id;
                return res; 

            }
            catch (Exception)
            {

                return -1;
            }
        }
    }
}
