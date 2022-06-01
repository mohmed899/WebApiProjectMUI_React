using WebApiProjectMUI_React.DTOs;
using WebApiProjectMUI_React.Models;

namespace WebApiProjectMUI_React.Repo
{
    public interface IOrderRepo
    {
        int AddOrder(OrderDTO order);

        List<Order> GetAllOrders();
    }
}