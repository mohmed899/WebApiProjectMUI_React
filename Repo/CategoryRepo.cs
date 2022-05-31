using WebApiProjectMUI_React.Models;
using WebApiProjectMUI_React.DTOs;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace WebApiProjectMUI_React.Repo
{
    public class CategoryRepo : ICategoryRepo
    {
        StoreEntity db;
        public CategoryRepo(StoreEntity db) { this.db = db; }

        public List<CategoryDTO> GetAllCategory()
        {
            List<CategoryDTO> result = new List<CategoryDTO>();
            foreach (var item in db.categor)
            {
                CategoryDTO category = new CategoryDTO()
                {
                    Name = item.Name,
                    Id = item.Id,
                };
                result.Add(category);
            }
            return result;
        }

        public int AddCategory( CategoryDTO category)
        {
            Category category1 = new Category()
            {
                Id = category.Id,
                Name = category.Name,
            };
            try
            {
                db.categor.Add(category1);
                return db.SaveChanges();
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int EditCategory(int id , CategoryDTO categoryDto)
        {

            Category cat = db.categor.FirstOrDefault(p => p.Id == id);
            if(cat != null)
            {
                cat.Name = categoryDto.Name;
                try
                {
                    return db.SaveChanges();
                }
                catch (Exception)
                {

                    return -1;
                }
            }
            return -1;
        }

        public int DeleteCategory( int id)
        {

            var category = db.categor.FirstOrDefault(c=>c.Id== id);
            if(category != null)
            {
                try
                {
                    db.categor.Remove(category);
                    return db.SaveChanges();
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            return -1;
        }


    }
}
