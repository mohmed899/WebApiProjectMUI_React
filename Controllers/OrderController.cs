using WebApiProjectMUI_React.DTOs;
using WebApiProjectMUI_React.Models;
using WebApiProjectMUI_React.Repo;
using Microsoft.AspNetCore.Mvc;

namespace WebApiProjectMUI_React.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderRepo oredrRepo;
        IOrderDetailsrepo oredrDetailsRepo;
        public OrderController(IOrderRepo oredrRepo, IOrderDetailsrepo oredrDetailsRepo)
        {
            this.oredrRepo = oredrRepo;
            this.oredrDetailsRepo = oredrDetailsRepo;
        }

        [HttpGet]
        IActionResult GetAllOrders()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult AddOrder(OrderDTO o)
        {
            var res = oredrRepo.AddOrder(o);
            if (res > 0)
                return Ok(o);
            else
                return BadRequest(res);
        }

      [HttpPost("OrderDetails/{OrderNumber:int}")]
        public IActionResult AddOrderDetails( int[] productIds, int OrderNumber)
        {
            var res = oredrDetailsRepo.AddRelatedOrderDetails(productIds, OrderNumber);
            if (res > 0)
                return Ok();
            else
                return BadRequest(res);
        }

    }
}

