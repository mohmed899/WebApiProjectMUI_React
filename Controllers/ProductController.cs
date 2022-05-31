using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiProjectMUI_React.Repo;
using WebApiProjectMUI_React.DTOs;
namespace WebApiProjectMUI_React.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductRepo productRepo;
        public ProductController(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
           return Ok(productRepo.getAll());
        }

        [HttpPost]
        public IActionResult AddProduct( ProductDTO product)
        {

            if (ModelState.IsValid)
            {
              int rowEffected =   productRepo.Add(product);
                if (rowEffected > 0)
                    return Ok(product);
                else
                    return Problem();
            }
            else
            return BadRequest(ModelState);
        }

        [HttpGet("details")]
        public IActionResult getProduct( [ FromQuery]string name)
        {
            var productDto = productRepo.GetByName(name);
            if(productDto != null)
            {
                return Ok(productDto);
            }
            return BadRequest("no such pro with that name ");
        }

        [HttpPut("up")]
        public IActionResult UpdateProduct([FromBody] ProductDTO dTO)
        {
            var res = productRepo.Update(dTO);
            if (res > 0)
            {
                return Ok(dTO);
            }
            else return BadRequest("some thing happend");
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteProduct(int id )
        {
            var res = productRepo.Delete(id);
            if (res > 0)
            {
                return Ok();
            }
            else return BadRequest("some thing happend");
        }

    }
}
