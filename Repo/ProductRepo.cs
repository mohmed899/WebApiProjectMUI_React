using WebApiProjectMUI_React.DTOs;
using WebApiProjectMUI_React.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApiProjectMUI_React.Repo
{
    public class ProductRepo : IProductRepo
    {
        StoreEntity db;
        public ProductRepo(StoreEntity db) { this.db = db; }

        public List<ProductDTO> getAll()
        {
            List<ProductDTO> productDTOs = new List<ProductDTO>();

            foreach (Product pro in db.products.Include(p => p.category))
            {
                ProductDTO productDTO = new ProductDTO();

                productDTO.Id = pro.Id;
                productDTO.Name = pro.Name;
                productDTO.Code = pro.Code;
                productDTO.Cover = pro.Cover;
                productDTO.createdAt = pro.createdAt;
                productDTO.Price = pro.Price;
                productDTO.PriceSale = pro.PriceSale;
                productDTO.Gender = pro.Gender;
                productDTO.Status = pro.Status;
                productDTO.TotalRating = pro.TotalRating;
                productDTO.TotalReview = pro.TotalReview;
                productDTO.description = pro.description;
                productDTO.inventoryType = pro.inventoryType;
                productDTO.available = 1;
                productDTO.Sold = 2;
                productDTO.Category = pro.category.Name;
                productDTO.Colors = pro.Colors.Split(',');


                productDTOs.Add(productDTO);
            }
            return productDTOs;
        }

        public int Add(ProductDTO productDTO)
        {
            Product product = new Product()
            {
                Name = productDTO.Name,
                CatId = productDTO.CatId,
                Code = productDTO.Code,
                Cover = productDTO.Cover,
                createdAt = productDTO.createdAt,
                Gender = productDTO.Gender,
                inventoryType = productDTO.inventoryType,
                description = productDTO.description,
                PriceSale = productDTO.PriceSale,
                Status = productDTO.Status,
                TotalRating = productDTO.TotalRating,
                TotalReview = productDTO.TotalReview,
                Price = productDTO.Price,
                Colors = String.Join(',', productDTO.Colors),
            };

            try
            {
                db.products.Add(product);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                return -1;
            }
        }

        public ProductDTO GetByName(string name)
        {
            name = name.Replace('-', ' ');
            var pro = db.products.Include(p => p.category).FirstOrDefault(p => p.Code == name);
            if (pro != null)
            {
                ProductDTO productDTO = new ProductDTO();

                productDTO.Id = pro.Id;
                productDTO.Name = pro.Name;
                productDTO.Code = pro.Code;
                productDTO.Cover = pro.Cover;
                productDTO.createdAt = pro.createdAt;
                productDTO.Price = pro.Price;
                productDTO.PriceSale = pro.PriceSale;
                productDTO.Gender = pro.Gender;
                productDTO.Status = pro.Status;
                productDTO.TotalRating = pro.TotalRating;
                productDTO.TotalReview = pro.TotalReview;
                productDTO.description = pro.description;
                productDTO.inventoryType = pro.inventoryType;
                productDTO.available = 1;
                productDTO.Sold = 2;
                productDTO.Category = pro.category.Name;
                productDTO.Colors = pro.Colors.Split(',');

                return productDTO;
            }
            return null;

        }

        public int Update(ProductDTO productDTO)
        {
            var oldPro = db.products.FirstOrDefault(p=>p.Id==productDTO.Id);

            if(oldPro != null)
            {

            oldPro.Name = productDTO.Name;
            oldPro.CatId = productDTO.CatId;
            oldPro.Code = productDTO.Code;
            oldPro.Cover = productDTO.Cover;
            oldPro.createdAt = productDTO.createdAt;
            oldPro.Gender = productDTO.Gender;
            oldPro.inventoryType = productDTO.inventoryType;
            oldPro.description = productDTO.description;
            oldPro.PriceSale = productDTO.PriceSale;
            oldPro.Status = productDTO.Status;
            oldPro.TotalRating = productDTO.TotalRating;
            oldPro.TotalReview = productDTO.TotalReview;
            oldPro.Price = productDTO.Price;
            oldPro.Colors = String.Join(',', productDTO.Colors);

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

        public int Delete(int id)
        {
            var prosuct = db.products.FirstOrDefault(p => p.Id == id);
            if (prosuct != null)
            {
                try
                {
                    db.products.Remove(prosuct);
                    return  db.SaveChanges();

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
