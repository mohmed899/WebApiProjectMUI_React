using WebApiProjectMUI_React.Models;

namespace WebApiProjectMUI_React.Repo
{
    public class OrderDetailsrepo : IOrderDetailsrepo
    {
        StoreEntity db;
        public OrderDetailsrepo(StoreEntity db) { this.db = db; }
        public int AddOrderDetails(OrederDetails order)
        {
            try
            {
                db.orederDetails.Add(order);
                return db.SaveChanges();

            }
            catch (Exception)
            {

                return -1;
            }
        }

        public int AddRelatedOrderDetails (int[] ProductId , int orderId)
        {
            foreach( int id in ProductId)
            {
                OrederDetails orederDetails = new OrederDetails() {                 
                OrderID = orderId,
                ProductId = id
                };

                db.orederDetails.Add(orederDetails);
            }

            try
            {
                return db.SaveChanges();
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
