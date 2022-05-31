using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using WebApiProjectMUI_React.Repo;
using WebApiProjectMUI_React.DTOs;
namespace WebApiProjectMUI_React.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        ICategoryRepo categoryRepo;
        public CategoryController(ICategoryRepo categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(categoryRepo.GetAllCategory());
        }

        [HttpPost]
        public IActionResult AddCategory( CategoryDTO categoryDTO)
        {
            if( ModelState.IsValid)
            {
                var res =  categoryRepo.AddCategory(categoryDTO);
                if (res > 0)
                {
                    return Created("url", categoryDTO);
                }
                else return Problem("something  bad happend ");
            }

            return BadRequest("invaild category  obj");
        }

        [HttpPut]
        public IActionResult UpdateCategory(CategoryDTO categoryDTO)
        {
            if (ModelState.IsValid)
            {
               var res  =  categoryRepo.EditCategory(categoryDTO.Id, categoryDTO);
                if(res > 0)
                {
                    return Ok("success");
                }
                return Problem("something bad happend ");
            }
            return BadRequest("invaild obj ");
        }


        [HttpDelete("{id:int}")]
        public IActionResult DeleteCategory(int id)
        {
            var res = categoryRepo.DeleteCategory(id);
            if (res > 0)
                return Ok("deleted");
            return BadRequest("invalid obj");
        }
    }
}
