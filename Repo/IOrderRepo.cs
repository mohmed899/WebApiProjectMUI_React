using WebApiProjectMUI_React.DTOs;

namespace WebApiProjectMUI_React.Repo
{
    public interface IOrderRepo
    {
        int AddOrder(OrderDTO order);
    }
}