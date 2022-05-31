using WebApiProjectMUI_React.Models;

namespace WebApiProjectMUI_React.Repo
{
    public interface IOrderDetailsrepo
    {
        int AddOrderDetails(OrederDetails order);
        public int AddRelatedOrderDetails(int[] ProductId, int orderId);
    }
}